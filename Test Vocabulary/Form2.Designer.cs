namespace Test_Vocabulary
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Emean = new System.Windows.Forms.Label();
            this.Vmean = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddWord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Emean
            // 
            this.Emean.AutoSize = true;
            this.Emean.Location = new System.Drawing.Point(20, 20);
            this.Emean.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Emean.Name = "Emean";
            this.Emean.Size = new System.Drawing.Size(90, 26);
            this.Emean.TabIndex = 0;
            this.Emean.Text = "English:";
            // 
            // Vmean
            // 
            this.Vmean.AutoSize = true;
            this.Vmean.Location = new System.Drawing.Point(20, 73);
            this.Vmean.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Vmean.Name = "Vmean";
            this.Vmean.Size = new System.Drawing.Size(134, 26);
            this.Vmean.TabIndex = 1;
            this.Vmean.Text = "Vietnamese:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(591, 32);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 68);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(545, 32);
            this.textBox2.TabIndex = 3;
            // 
            // AddWord
            // 
            this.AddWord.Location = new System.Drawing.Point(24, 218);
            this.AddWord.Margin = new System.Windows.Forms.Padding(5);
            this.AddWord.Name = "AddWord";
            this.AddWord.Size = new System.Drawing.Size(135, 44);
            this.AddWord.TabIndex = 4;
            this.AddWord.Text = "Add";
            this.AddWord.UseVisualStyleBackColor = true;
            this.AddWord.Click += new System.EventHandler(this.AddWord_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 218);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Note:";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.ForeColor = System.Drawing.Color.Red;
            this.note.Location = new System.Drawing.Point(84, 115);
            this.note.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(0, 26);
            this.note.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Noun ( danh từ )",
            "Verb ( động từ )",
            "Pronoun ( đại từ )",
            "Adjective ( tính từ )",
            "Adverb ( phó từ )",
            "Preposition ( giới từ )",
            "Interjection ( thán từ )",
            "Conjunction ( liên từ )",
            "Article ( mạo từ )",
            "Orther ( khác )"});
            this.comboBox1.Location = new System.Drawing.Point(198, 128);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(516, 34);
            this.comboBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Part of speech:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.note);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddWord);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Vmean);
            this.Controls.Add(this.Emean);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.Text = "Add Vocabulary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Emean;
        private System.Windows.Forms.Label Vmean;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AddWord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}