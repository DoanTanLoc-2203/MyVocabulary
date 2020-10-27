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
using System.Speech.Synthesis;

namespace Test_Vocabulary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer ss = new SpeechSynthesizer();
            string answer = textBox1.Text;
            bool H = true;
            if (answer == "")
            {
                note.ForeColor = System.Drawing.Color.Red;
                note.Text = " Please! Write your answer ";
            }
            else
            {
                if (H == true)
                {
                    string ans = label5.Text;
                    string ysub = textBox1.Text;
                    string ans1 = "";
                    string ysub1 = "";
                    string T;
                    int t;
                    string F;
                    int f;
                    ans = ans.ToLower();
                    ysub = ysub.ToLower();
                    for (int i = 0; i < ans.Length; i++)
                    {
                        if (ans[i] != ' ')
                            ans1 = ans1 + ans[i];
                    }
                    for (int i = 0; i < ysub.Length; i++)
                    {
                        if (ysub[i] != ' ')
                            ysub1 = ysub1 + ysub[i];
                    }
                    if (ans1 == ysub1)
                    {
                        note.ForeColor = System.Drawing.Color.Green;
                        note.Text = "Right!";
                        T = right.Text;
                        t = Convert.ToInt32(T);
                        t = t + 1;
                        T = Convert.ToString(t);
                        right.Text = T;
                        True.Text = T;
                        ss.Speak(answer);
                        note.Text = "";
                        Console.OutputEncoding = Encoding.Unicode;
                        string filePath = @"Data.txt";
                        string filetest = @"test.txt";
                        int range = 0;//number of word
                        int id;// id random of word
                        string[] lines;
                        string[] testtxt;
                        string[] nm;
                        string QA = "";// Question and answer
                        string Ques = "";
                        string Ans = "";
                        string Id = "";
                        int j = 0;
                        int k = 0;
                        string spee = "";
                        Boolean check = false;
                        Boolean check1 = true;
                        Random idrandom = new Random();

                        textBox1.Text = "";//clear ans
                        if (System.IO.File.Exists(filePath))// Process number of word
                        {
                            lines = System.IO.File.ReadAllLines(filePath);
                            range = lines.Length;
                            if (range == 2)
                            {
                                H = false;
                            }
                            //////////////////////////////////////////

                            /*String filepath1 = "testtg.txt";// đường dẫn của file muốn tạo
                            FileStream fs1 = new FileStream(filepath1, FileMode.Append);//Tạo file mới tên là test.txt            
                            StreamWriter sWriter1 = new StreamWriter(fs1, Encoding.UTF8);//fs là 1 FileStream 
                            for (int i = 0; i < range; i++)
                            {
                                if (i == Convert.ToInt64(label4.Text))
                                    {
                                    sWriter1.WriteLine(lines[Convert.ToInt64(label4.Text)] + "*");
                                }
                                else
                                {
                                    sWriter1.WriteLine(lines[i]);
                                }

                            }

                            sWriter1.Flush();
                            fs1.Close();
                            File.Delete("data.txt");
                            File.Move("testtg.txt", "data.txt");*/
                            //////////////////////////////////////////
                            String filepath2 = "testtg2.txt";// đường dẫn của file muốn tạo
                            FileStream fs2 = new FileStream(filepath2, FileMode.Append);//Tạo file mới tên là test.txt            
                            StreamWriter sWriter2 = new StreamWriter(fs2, Encoding.UTF8);//fs là 1 FileStream 
                            for (int i = 0; i < range - 1; i++)
                            {
                                if (i != Convert.ToInt64(label4.Text))
                                {
                                    sWriter2.WriteLine(lines[i]);
                                }
                            }
                            range = range - 1;
                            sWriter2.Flush();
                            fs2.Close();
                            File.Delete("data.txt");
                            File.Move("testtg2.txt", "data.txt");


                        }/////////////
                        id = idrandom.Next(1,range );
                        if (System.IO.File.Exists(filePath))// Process number of word
                        {
                            lines = System.IO.File.ReadAllLines(filePath);
                                QA = lines[id];
                        }
                        for (int i = 0; i < QA.Length; i++)// get Id
                        {
                            if (QA[i] == '.')
                            {
                                check1 = false;
                                j = i;
                                break;
                            }
                            if (check1 == true)
                            {
                                Id = Id + QA[i];
                            }
                        }
                        for (int i = j + 1; i < QA.Length; i++)//Get question and answer
                        {
                            if (QA[i] == '/')
                            {
                                k = i;
                                break;
                            }
                            else
                            {
                                if (QA[i] == '-')
                                    check = true;
                                if (check1 == false)
                                {
                                    if (check == false)
                                    {
                                        Ques = Ques + QA[i];
                                    }
                                    else
                                    {
                                        if (QA[i] != '-')
                                            Ans = Ans + QA[i];
                                    }
                                }
                            }
                        }
                        for (int i = k + 1; i < QA.Length; i++)
                        {
                            spee = spee + QA[i];
                        }
                        label4.Text = Id;
                        TextQuestion.Text = Ques;
                        label5.Text = Ans;
                        speech.Text = spee;

                    }
                    else
                    {
                        note.ForeColor = System.Drawing.Color.Red;
                        note.Text = "Wrong!";
                        F = wrong.Text;
                        f = Convert.ToInt32(F);
                        f = f + 1;
                        F = Convert.ToString(f);
                        wrong.Text = F;
                        False.Text = F;
                    }
                }
                else
                {
                    MessageBox.Show("Completed!!!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool H = true;
            if (H == true)
            {
                note.Text = "";
                Console.OutputEncoding = Encoding.Unicode;
                string filePath = @"Data.txt";
                int range = 0;//number of word
                int id;// id random of word
                string[] lines;
                string QA = "";// Question and answer
                string Ques = "";
                string Ans = "";
                string Id = "";
                int j = 0;
                int k = 0;
                string spee = "";
                Boolean check = false;
                Boolean check1 = true;
                Boolean kt = true;
                Random idrandom = new Random();

                textBox1.Text = "";//clear ans
                if (System.IO.File.Exists(filePath))// Process number of word
                {
                    lines = System.IO.File.ReadAllLines(filePath);
                    range = lines.Length;
                    if(range==2)
                    {
                        H = false;
                    }
                }

                id = idrandom.Next(1, range);//random number
                if (System.IO.File.Exists(filePath))// Process number of word
                {
                    lines = System.IO.File.ReadAllLines(filePath);
                    QA = lines[id];
                }
                /////////////////////////
                for (int i = 0; i < QA.Length; i++)// get Id
                {
                    if (QA[i] == '.')
                    {
                        check1 = false;
                        j = i;
                        break;
                    }
                    if (check1 == true)
                    {
                        Id = Id + QA[i];
                    }
                }
                for (int i = j + 1; i < QA.Length; i++)//Get question and answer
                {
                    if (QA[i] == '/')
                    {
                        k = i;
                        break;
                    }
                    else
                    {
                        if (QA[i] == '-')
                            check = true;
                        if (check1 == false)
                        {
                            if (check == false)
                            {
                                Ques = Ques + QA[i];
                            }
                            else
                            {
                                if (QA[i] != '-')
                                    Ans = Ans + QA[i];
                            }
                        }
                    }
                }
                for (int i = k + 1; i < QA.Length; i++)
                {
                    spee = spee + QA[i];
                }
                label4.Text = Id;
                TextQuestion.Text = Ques;
                label5.Text = Ans;
                speech.Text = spee;
            }
            else
            {
                MessageBox.Show("Completed!!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string hint = label5.Text;
            MessageBox.Show(hint);
        }

        private void List_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Data.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            string data = rd.ReadToEnd();
            fs.Close();
            // MessageBox.Show(data);
            Form3 f = new Form3();
            f.Show();
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }
        private void Add_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Help.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            string data = rd.ReadToEnd();
            fs.Close();
            MessageBox.Show(data);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void spe_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer ss = new SpeechSynthesizer();
            
            ss.Speak(label5.Text);
        }

        private void trans_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
}
