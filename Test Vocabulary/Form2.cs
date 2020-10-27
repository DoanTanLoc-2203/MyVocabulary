using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Vocabulary
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.Text ="";
            note.Location = new System.Drawing.Point(70,185);
        }

        private void AddWord_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            string mean = textBox2.Text;
            string S = comboBox1.Text;
            string spee = "";
            if ((word == "") || (mean == "")||(S == ""))
            {
                note.ForeColor = System.Drawing.Color.Red;
                note.Text = " Empty value ";
            }
            else
            {
                note.Text ="";
                string[] lines;
                int number = 0;
                int id;
                string Id;
                String filepath = "Data.txt";// đường dẫn của file muốn tạo
                if (System.IO.File.Exists(filepath))// Process number of word
                {
                    lines = System.IO.File.ReadAllLines(filepath);
                    number = lines.Length;
                }
                FileStream fs = new FileStream(filepath, FileMode.Append);//Tạo file mới tên là test.txt            
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 
                id = number;
                Id = Convert.ToString(id);
                for(int i=0;i<S.Length;i++)
                {
                    if (S[i] == '(')
                        break;
                    spee = spee + S[i];
                }
                sWriter.WriteLine(Id + "." + mean + "-" + word+"/"+spee);
                sWriter.Flush();
                fs.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                note.ForeColor = System.Drawing.Color.Green;
                note.Text = "Added!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            note.Text = "";
        }
    }
}
