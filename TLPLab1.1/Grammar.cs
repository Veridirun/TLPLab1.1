using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TLPLab1._1
{
    internal class Grammar
    {
        private Dictionary<char, HashSet<string>> grammarMap = new Dictionary<char, HashSet<string>>();
        private char startSymbol;
        private int minLen;
        private int maxLen;

        public char GetStartSymbol()
        {
            return startSymbol;
        }

        public void SetLength(int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentException("Min cannot be bigger than max");
            }
            minLen = min;
            maxLen = max;
        }

        public void AddRule(char name, HashSet<string> rule)
        {
            grammarMap[name] = rule;
        }

        public void SetStartSymbol(char start)
        {
            if (grammarMap.ContainsKey(start))
            {
                startSymbol = start;
            }
            else
            {
                throw new ArgumentException("Starting character must be non-terminal character");
            }
        }

        public void ShowGrammar()
        {
            foreach (var element in grammarMap)
            {
                Console.Write(element.Key + " -> ");
                foreach (var rule in element.Value)
                {
                    Console.Write(rule + " | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Start symbol: " + startSymbol);
            Console.WriteLine("Length from " + minLen + " to " + maxLen);
        }

        public static Grammar InputGrammar(string inputRule, char startSymbolField, int minLenField, int maxLenField)
        {
            Grammar grammar = new Grammar();

            using (StringReader reader = new StringReader(inputRule))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    char name = words[0][0];
                    HashSet<string> rules = new HashSet<string>();
                    for (int i = 2; i < words.Length; i++)
                    {
                        if (words[i] != "|")
                        {
                            rules.Add(words[i]);
                        }
                    }
                    //grammar.grammarMap.Add(name, rules);
                    grammar.AddRule(name, rules);
                }
            }
            
            grammar.SetStartSymbol(startSymbolField);

            grammar.SetLength(minLenField, maxLenField);

            return grammar;
        }

        public string GenerateChain()
        {
            string current = startSymbol.ToString();

            Random rand = new Random();
            while (true)
            {
                for (int i = 0; i < current.Length; i++)
                {
                    if (grammarMap.ContainsKey(current[i]))
                    {
                        var rules = grammarMap[current[i]];
                        //int idx = rand.Next(rules.Count);

                        byte[] randomNumber = new byte[4];
                        using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
                        {
                            rng.GetBytes(randomNumber); // Заполняем массив случайными байтами
                        }
                        int idx = BitConverter.ToInt32(randomNumber, 0) % rules.Count;
                        idx = Math.Abs(idx);

                        var it = rules.GetEnumerator();
                        for (int t = 0; t <= idx; t++) it.MoveNext();
                        string terminal = it.Current;
                        current = current.Remove(i, 1).Insert(i, terminal);
                        i--;
                        if (current.Length > maxLen) break;
                    }
                }
                if (current.Length >= minLen && current.Length <= maxLen)
                    return current;
                else
                    current = startSymbol.ToString();
            }
        }
    }
}
