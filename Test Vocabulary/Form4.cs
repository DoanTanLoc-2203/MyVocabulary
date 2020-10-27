using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarrenLee.Translator;

namespace Test_Vocabulary
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if(text == "")
            {
                label3.ForeColor = System.Drawing.Color.Red;
                label3.Text = "Empty Value!";
            }
            else
            {
                label3.ForeColor = System.Drawing.Color.Black;
                string tran = Translator.Translate(text,"en","vi");
                label3.Text = tran;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text == "")
            {
                label3.ForeColor = System.Drawing.Color.Red;
                label3.Text = "Empty Value!";
            }
            else
            {
                label3.ForeColor = System.Drawing.Color.Black;
                string tran = Translator.Translate(text, "vi", "en");
                label3.Text = tran;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
