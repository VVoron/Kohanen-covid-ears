namespace KohanenNeuronet
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartNeuro = new System.Windows.Forms.Button();
            this.InputFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vShod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputRk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputInfo = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.InputSteps = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumCluster = new System.Windows.Forms.ComboBox();
            this.ClasterInfo = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Watchbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReNeuro = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NewInput = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.Properties = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartNeuro
            // 
            this.StartNeuro.Location = new System.Drawing.Point(429, 270);
            this.StartNeuro.Name = "StartNeuro";
            this.StartNeuro.Size = new System.Drawing.Size(100, 23);
            this.StartNeuro.TabIndex = 0;
            this.StartNeuro.Text = "Запуск";
            this.StartNeuro.UseVisualStyleBackColor = true;
            this.StartNeuro.Click += new System.EventHandler(this.StartNeuro_Click);
            // 
            // InputFile
            // 
            this.InputFile.Location = new System.Drawing.Point(542, 31);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(75, 20);
            this.InputFile.TabIndex = 1;
            this.InputFile.Text = "Обзор";
            this.InputFile.UseVisualStyleBackColor = true;
            this.InputFile.Click += new System.EventHandler(this.InputFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исходные данные";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // vShod
            // 
            this.vShod.Location = new System.Drawing.Point(429, 57);
            this.vShod.Name = "vShod";
            this.vShod.Size = new System.Drawing.Size(100, 20);
            this.vShod.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Скорость сходимости";
            // 
            // InputRk
            // 
            this.InputRk.Location = new System.Drawing.Point(429, 83);
            this.InputRk.Name = "InputRk";
            this.InputRk.Size = new System.Drawing.Size(100, 20);
            this.InputRk.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Граница разрыва";
            // 
            // OutputInfo
            // 
            this.OutputInfo.Location = new System.Drawing.Point(34, 75);
            this.OutputInfo.Name = "OutputInfo";
            this.OutputInfo.Size = new System.Drawing.Size(192, 164);
            this.OutputInfo.TabIndex = 8;
            this.OutputInfo.Text = "";
            this.OutputInfo.TextChanged += new System.EventHandler(this.OutputInfo_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // InputSteps
            // 
            this.InputSteps.Location = new System.Drawing.Point(429, 109);
            this.InputSteps.Name = "InputSteps";
            this.InputSteps.Size = new System.Drawing.Size(100, 20);
            this.InputSteps.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количество шагов";
            // 
            // NumCluster
            // 
            this.NumCluster.FormattingEnabled = true;
            this.NumCluster.Location = new System.Drawing.Point(181, 21);
            this.NumCluster.Name = "NumCluster";
            this.NumCluster.Size = new System.Drawing.Size(121, 21);
            this.NumCluster.TabIndex = 11;
            // 
            // ClasterInfo
            // 
            this.ClasterInfo.Location = new System.Drawing.Point(255, 75);
            this.ClasterInfo.Name = "ClasterInfo";
            this.ClasterInfo.Size = new System.Drawing.Size(192, 164);
            this.ClasterInfo.TabIndex = 12;
            this.ClasterInfo.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Выберите кластер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дети, входящие в него";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Информация о кластере";
            // 
            // Watchbtn
            // 
            this.Watchbtn.Location = new System.Drawing.Point(322, 19);
            this.Watchbtn.Name = "Watchbtn";
            this.Watchbtn.Size = new System.Drawing.Size(75, 23);
            this.Watchbtn.TabIndex = 16;
            this.Watchbtn.Text = "Смотреть";
            this.Watchbtn.UseVisualStyleBackColor = true;
            this.Watchbtn.Click += new System.EventHandler(this.Watchbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.ReNeuro);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.ClasterInfo);
            this.groupBox1.Controls.Add(this.Watchbtn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.NewInput);
            this.groupBox1.Controls.Add(this.OutputInfo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.NumCluster);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Enabled = false;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(240, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 344);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // ReNeuro
            // 
            this.ReNeuro.Location = new System.Drawing.Point(171, 281);
            this.ReNeuro.Name = "ReNeuro";
            this.ReNeuro.Size = new System.Drawing.Size(122, 23);
            this.ReNeuro.TabIndex = 18;
            this.ReNeuro.Text = "Перераспределить";
            this.ReNeuro.UseVisualStyleBackColor = true;
            this.ReNeuro.Click += new System.EventHandler(this.ReNeuro_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 255);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Добавить данные";
            // 
            // NewInput
            // 
            this.NewInput.Location = new System.Drawing.Point(289, 255);
            this.NewInput.Name = "NewInput";
            this.NewInput.Size = new System.Drawing.Size(75, 20);
            this.NewInput.TabIndex = 17;
            this.NewInput.Text = "Обзор";
            this.NewInput.UseVisualStyleBackColor = true;
            this.NewInput.Click += new System.EventHandler(this.NewInput_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Properties
            // 
            this.Properties.FormattingEnabled = true;
            this.Properties.Items.AddRange(new object[] {
            "Срок гестации на момент обследования",
            "Оотоакустическая эмиссия на правое ухо 1кГц",
            "Оотоакустическая эмиссия на правое ухо 2кГц",
            "Оотоакустическая эмиссия на правое ухо 4кГц",
            "Оотоакустическая эмиссия на правое ухо 6кГц",
            "Оотоакустическая эмиссия на левое ухо 1кГц",
            "Оотоакустическая эмиссия на левое ухо 2кГц",
            "Оотоакустическая эмиссия на левое ухо 4кГц",
            "Оотоакустическая эмиссия на левое ухо 6кГц",
            "ASSR правое ухо 500Гц",
            "ASSR правое ухо 1000Гц",
            "ASSR правое ухо 2000Гц",
            "ASSR правое ухо 4000Гц",
            "ASSR левое ухо 500Гц",
            "ASSR левое ухо 1000Гц",
            "ASSR левое ухо 2000Гц",
            "ASSR левое ухо 4000Гц",
            "КСВП латентность правое ухо 20",
            "КСВП латентность правое ухо 40",
            "КСВП латентность правое ухо 60",
            "КСВП латентность левое ухо 20",
            "КСВП латентность левое ухо 40",
            "КСВП латентность левое ухо 60"});
            this.Properties.Location = new System.Drawing.Point(341, 169);
            this.Properties.Name = "Properties";
            this.Properties.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Properties.Size = new System.Drawing.Size(276, 95);
            this.Properties.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Выберите данные для кластеризации:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(981, 718);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Properties);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputSteps);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InputRk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vShod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputFile);
            this.Controls.Add(this.StartNeuro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartNeuro;
        private System.Windows.Forms.Button InputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox vShod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputRk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox OutputInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox InputSteps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NumCluster;
        private System.Windows.Forms.RichTextBox ClasterInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Watchbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button NewInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button ReNeuro;
        private System.Windows.Forms.ListBox Properties;
        private System.Windows.Forms.Label label9;
    }
}

