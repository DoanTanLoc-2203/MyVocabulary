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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();          
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] lines;
            int range = 0;
            string filePath = @"Data.txt";
            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                range = lines.Length;
            }
            for(int i=0;i<range;i++)
            {
                if (System.IO.File.Exists(filePath))
                {
                    lines = System.IO.File.ReadAllLines(filePath);
                    string data = lines[i];
                    Boolean check = false;
                    string vocab = "";
                    for (int j=0;j<data.Length;j++)
                    {
                        if(data[j]=='/')
                        {
                            check = false;
                        }
                        if (check ==true)
                        {
                            vocab = vocab + data[j];
                        }
                        if(data[j]=='-')
                        {
                            check = true;
                        }
                    }
                    comboBox1.Items.Add(vocab);//load data to combobox1
                    label9.Text = Convert.ToString(range);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="")
            {
                label7.ForeColor = System.Drawing.Color.Red;
                label7.Text = "Empty value!";
            }
            else
            {
                string[] lines;
                int range = 0;
                string filePath = @"Data.txt";
                if (System.IO.File.Exists(filePath))
                {
                    lines = System.IO.File.ReadAllLines(filePath);
                    range = lines.Length;
                }
                string[] id = new string[range];
                string[] mean = new string[range];
                string[] speech = new string[range];
                string[] english = new string[range];
                for (int i = 0; i < range; i++)
                {
                    if (System.IO.File.Exists(filePath))
                    {
                        lines = System.IO.File.ReadAllLines(filePath);
                        string data = lines[i];
                        Boolean check = false;
                        Boolean check1 = true;
                        Boolean check2 = false;
                        Boolean check3 = false;
                        string tg = "";
                        mean[i] = "";
                        speech[i] = "";
                        english[i] = "";
                        for (int j = 0; j < data.Length; j++)
                        {
                            if (check3 == true)
                            {
                                speech[i] = speech[i] + data[j];
                            }
                            if (data[j] == '/')
                            {
                                check3 = true;
                            }
                            if (data[j] == '-')
                            {
                                check2 = false;
                            }
                            if (check2 == true)
                            {
                                mean[i] = mean[i] + data[j];
                            }
                            if (data[j] == '.')
                            {
                                check2 = true;
                            }
                            if (data[j] == '.')
                            {
                                check1 = false;
                            }
                            if (check1 == true)
                            {
                                tg = tg + data[j];
                            }
                            if (data[j] == '/')
                            {
                                check = false;
                            }
                            if (check == true)
                            {
                                english[i] = english[i] + data[j];
                            }
                            if (data[j] == '-')
                            {
                                check = true;
                            }
                        }
                        if (tg != "")
                        {
                            id[i] = tg;
                        }
                    }
                }
                //load data
                int k = 0;
                for (int i = 0; i < range; i++)
                {
                    if (comboBox1.Text == english[i])
                    {
                        k = i;
                        break;
                    }
                }
                label5.Text = id[k];
                textBox2.Text = mean[k];
                comboBox2.Text = speech[k];
                label7.ForeColor = System.Drawing.Color.Green;
                label7.Text = "Loaded!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                label7.ForeColor = System.Drawing.Color.Red;
                label7.Text = "Empty value!";
            }
            else
            {
                string[] lines;
                int range = 0;
                string filePath = @"Data.txt";
                int poindelete = 0;
                if (System.IO.File.Exists(filePath))
                {
                    lines = System.IO.File.ReadAllLines(filePath);
                    range = lines.Length;
                }
                string[] vocab = new string[range];
                string[] databackup = new string[range];
                for (int i = 0; i < range; i++)
                {
                    if (System.IO.File.Exists(filePath))
                    {
                        lines = System.IO.File.ReadAllLines(filePath);
                        string data = lines[i];
                        databackup[i] = "";
                        Boolean check1 = false;
                        Boolean check = false;
                        vocab[i] = "";
                        for (int j = 0; j < data.Length; j++)
                        {
                            if (check1 == true)
                            {
                                databackup[i] = databackup[i] + data[j];
                            }
                            if (data[j] == '.')
                            {
                                check1 = true;
                            }
                            if (data[j] == '/')
                            {
                                check = false;
                            }
                            if (check == true)
                            {
                                vocab[i] = vocab[i] + data[j];
                            }
                            if (data[j] == '-')
                            {
                                check = true;
                            }
                        }
                    }
                }
                for (int i = 0; i < range; i++)
                {
                    if (vocab[i] == comboBox1.Text)
                    {
                        poindelete = i;
                    }
                }
                string[] tempdata = new string[range];
                for (int i = 0; i < range; i++)
                {
                    if (i != poindelete)
                    {
                        tempdata[i] = databackup[i];
                    }
                    else
                    {
                        tempdata[i] = "$Unvalue";
                    }
                }
                int temp = 0;
                string[] newdata = new string[range - 1];
                for (int i = 0; i < tempdata.Length - 1; i++)
                {
                    String filepath0 = "tempdata.txt";// đường dẫn của file muốn tạo
                    FileStream fs0 = new FileStream(filepath0, FileMode.Append);//Tạo file mới tên là test.txt            
                    StreamWriter sWriter0 = new StreamWriter(fs0, Encoding.UTF8);//fs là 1 FileStream 
                    if (tempdata[i] != "$Unvalue")
                    {
                        newdata[temp] = "";
                        Boolean check = false;
                        for (int j = 0; j < tempdata[i].Length; j++)
                        {
                            if (tempdata[i][j] == '/')
                            {
                                check = false;
                            }
                            if (check == true)
                            {
                                newdata[temp] = newdata[temp] + tempdata[i][j];
                            }
                            if (tempdata[i][j] == '-')
                            {
                                check = true;
                            }
                        }
                        string id = Convert.ToString(temp);
                        sWriter0.WriteLine(id + "." + tempdata[i]);
                        temp++;
                    }
                    // Ghi và đóng file
                    sWriter0.Flush();
                    fs0.Close();
                }
                File.Delete("data.txt");
                File.Move("tempdata.txt", "data.txt");
                comboBox1.Items.Clear();
                for (int i = 0; i < newdata.Length - 1; i++)
                {
                    comboBox1.Items.Add(newdata[i]);
                }
                label5.Text = "...";
                textBox2.Text = "";
                comboBox2.Text = "";
                comboBox1.Text = "";
                label7.ForeColor = System.Drawing.Color.Red;
                label7.Text = "Deleted!";
                label9.Text = Convert.ToString(range);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox2.Text == "")
            {
                label7.ForeColor = System.Drawing.Color.Red;
                label7.Text = "Empty value!";
            }
            else
            {
                string[] lines;
                int range = 0;
                int replacepoint = 0;
                string filePath = @"Data.txt";
                if (System.IO.File.Exists(filePath))
                {
                    lines = System.IO.File.ReadAllLines(filePath);
                    range = lines.Length;
                }
                string[] id = new string[range];
                string[] orther = new string[range];
                for (int i = 0; i < range; i++)
                {
                    if (System.IO.File.Exists(filePath))
                    {
                        lines = System.IO.File.ReadAllLines(filePath);
                        id[i] = "";
                        orther[i] = "";
                        Boolean check = false;
                        for (int j = 0; j < lines[i].Length; j++)
                        {
                            if (lines[i][j] == '.')
                            {
                                check = true;
                            }
                            if (check == true)
                            {
                                orther[i] = orther[i] + lines[i][j];
                            }
                            else
                            {
                                id[i] = id[i] + lines[i][j];
                            }
                        }
                    }
                    if (label5.Text == id[i])
                    {
                        replacepoint = i;
                    }
                }
                String filepath0 = "tempdatareplace.txt";// đường dẫn của file muốn tạo
                FileStream fs0 = new FileStream(filepath0, FileMode.Append);//Tạo file mới tên là test.txt            
                StreamWriter sWriter0 = new StreamWriter(fs0, Encoding.UTF8);//fs là 1 FileStream 
                for (int i = 0; i < range; i++)
                {
                    if (replacepoint != i)
                    {
                        sWriter0.WriteLine(id[i] + orther[i]);
                    }
                    else
                    {
                        sWriter0.WriteLine(label5.Text + "." + textBox2.Text + "-" + comboBox1.Text + "/" + comboBox2.Text);
                    }
                }
                sWriter0.Flush();
                fs0.Close();
                File.Delete("data.txt");
                File.Move("tempdatareplace.txt", "data.txt");
                label7.ForeColor = System.Drawing.Color.Green;
                label7.Text = "replaced!";
                label5.Text = "...";
                textBox2.Text = "";
                comboBox2.Text = "";
                comboBox1.Text = "";
            }
        }
    }
}
