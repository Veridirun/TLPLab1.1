using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TLPLab1._1
{

    public partial class Form1 : Form
    {
        Grammar grammar;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            textBox.Text = "A -> 0 | 0A | 1B | 1B \r\nB -> 0 | 0B | 1C\r\nC -> ab";
            startSymbolField.Text = "A";
            minLenField.Value = 2;
            maxLenField.Value = 5;
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            try
            {
                grammar = Grammar.InputGrammar(textBox.Text, startSymbolField.Text[0], (int)minLenField.Value, (int)maxLenField.Value);
            }
            catch
            {
                MessageBox.Show(this, "Неправильные входные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int amountOfLines = 7;
            string result = "";
            for (int i = 0; i<amountOfLines; i++)
            {
                textBoxResult.AppendText(grammar.GenerateChain());
                textBoxResult.AppendText(Environment.NewLine);
            }
        }
    }
}
