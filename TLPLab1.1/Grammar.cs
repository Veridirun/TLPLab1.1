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
        static private Random rand = new Random();

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

        public string GenerateChains()
        {
            string result = "";
            List<string> rules = new List<string> { startSymbol.ToString() };
            HashSet<string> usedSeq = new HashSet<string>();

            while(rules.Count > 0)
            {
                string sequence = rules.Last();
                rules.RemoveAt(rules.Count - 1);

                if (usedSeq.Contains(sequence))
                {
                    continue;
                }
                usedSeq.Add(sequence);

                bool onlyTerm = true;
                for(int i = 0; i < sequence.Length; i++)
                {
                    char symbol = sequence[i];
                    if(grammarMap.ContainsKey(symbol))
                    {
                        onlyTerm = false;
                        foreach (string elem in grammarMap[symbol]) 
                        {
                            string temp = sequence.Substring(0, i) + elem + sequence.Substring(i + 1);
                            if(temp.Length <= maxLen + 1)
                            {
                                rules.Add(temp);
                            }
                        }
                    }
                }
                if (onlyTerm && sequence.Length >= minLen && sequence.Length <= maxLen)
                {
                    result += string.IsNullOrEmpty(sequence) ? "lambda" + "\r\n" : sequence + "\r\n";
                }
            }
            return result;
        }
    }
}
