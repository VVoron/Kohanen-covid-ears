namespace Neuro_COVID.PagesOfProject
{
    partial class LoadOrSaveInfo
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
            this.spContainerMain = new System.Windows.Forms.SplitContainer();
            this.lblTopSave = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Label();
            this.btnChooseSave = new System.Windows.Forms.Button();
            this.tBoxSave = new System.Windows.Forms.TextBox();
            this.lblTopLoad = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblLoad = new System.Windows.Forms.Label();
            this.btnChooseLoad = new System.Windows.Forms.Button();
            this.tBoxLoad = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerMain)).BeginInit();
            this.spContainerMain.Panel1.SuspendLayout();
            this.spContainerMain.Panel2.SuspendLayout();
            this.spContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // spContainerMain
            // 
            this.spContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainerMain.Location = new System.Drawing.Point(0, 0);
            this.spContainerMain.Name = "spContainerMain";
            this.spContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spContainerMain.Panel1
            // 
            this.spContainerMain.Panel1.Controls.Add(this.lblTopSave);
            this.spContainerMain.Panel1.Controls.Add(this.btnSave);
            this.spContainerMain.Panel1.Controls.Add(this.lblSave);
            this.spContainerMain.Panel1.Controls.Add(this.btnChooseSave);
            this.spContainerMain.Panel1.Controls.Add(this.tBoxSave);
            // 
            // spContainerMain.Panel2
            // 
            this.spContainerMain.Panel2.Controls.Add(this.lblTopLoad);
            this.spContainerMain.Panel2.Controls.Add(this.btnLoad);
            this.spContainerMain.Panel2.Controls.Add(this.lblLoad);
            this.spContainerMain.Panel2.Controls.Add(this.btnChooseLoad);
            this.spContainerMain.Panel2.Controls.Add(this.tBoxLoad);
            this.spContainerMain.Size = new System.Drawing.Size(800, 450);
            this.spContainerMain.SplitterDistance = 218;
            this.spContainerMain.TabIndex = 0;
            // 
            // lblTopSave
            // 
            this.lblTopSave.AutoSize = true;
            this.lblTopSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTopSave.Location = new System.Drawing.Point(0, 0);
            this.lblTopSave.Name = "lblTopSave";
            this.lblTopSave.Size = new System.Drawing.Size(250, 31);
            this.lblTopSave.TabIndex = 4;
            this.lblTopSave.Text = "Сохранить данные";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(348, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSave.Location = new System.Drawing.Point(187, 72);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(111, 18);
            this.lblSave.TabIndex = 2;
            this.lblSave.Text = "Выберите путь";
            // 
            // btnChooseSave
            // 
            this.btnChooseSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseSave.Location = new System.Drawing.Point(509, 73);
            this.btnChooseSave.Name = "btnChooseSave";
            this.btnChooseSave.Size = new System.Drawing.Size(38, 21);
            this.btnChooseSave.TabIndex = 1;
            this.btnChooseSave.Text = "···";
            this.btnChooseSave.UseVisualStyleBackColor = true;
            this.btnChooseSave.Click += new System.EventHandler(this.btnChooseSave_Click);
            // 
            // tBoxSave
            // 
            this.tBoxSave.Location = new System.Drawing.Point(312, 73);
            this.tBoxSave.Name = "tBoxSave";
            this.tBoxSave.Size = new System.Drawing.Size(191, 20);
            this.tBoxSave.TabIndex = 0;
            // 
            // lblTopLoad
            // 
            this.lblTopLoad.AutoSize = true;
            this.lblTopLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTopLoad.Location = new System.Drawing.Point(0, 0);
            this.lblTopLoad.Name = "lblTopLoad";
            this.lblTopLoad.Size = new System.Drawing.Size(242, 31);
            this.lblTopLoad.TabIndex = 8;
            this.lblTopLoad.Text = "Загрузить данные";
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(348, 113);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(109, 34);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoad.Location = new System.Drawing.Point(187, 86);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(119, 18);
            this.lblLoad.TabIndex = 6;
            this.lblLoad.Text = "Выберите файл";
            // 
            // btnChooseLoad
            // 
            this.btnChooseLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseLoad.Location = new System.Drawing.Point(509, 87);
            this.btnChooseLoad.Name = "btnChooseLoad";
            this.btnChooseLoad.Size = new System.Drawing.Size(38, 21);
            this.btnChooseLoad.TabIndex = 5;
            this.btnChooseLoad.Text = "···";
            this.btnChooseLoad.UseVisualStyleBackColor = true;
            this.btnChooseLoad.Click += new System.EventHandler(this.btnChooseLoad_Click);
            // 
            // tBoxLoad
            // 
            this.tBoxLoad.Location = new System.Drawing.Point(312, 87);
            this.tBoxLoad.Name = "tBoxLoad";
            this.tBoxLoad.Size = new System.Drawing.Size(191, 20);
            this.tBoxLoad.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LoadOrSaveInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spContainerMain);
            this.Name = "LoadOrSaveInfo";
            this.Text = "LoadOrSaveInfo";
            this.spContainerMain.Panel1.ResumeLayout(false);
            this.spContainerMain.Panel1.PerformLayout();
            this.spContainerMain.Panel2.ResumeLayout(false);
            this.spContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerMain)).EndInit();
            this.spContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spContainerMain;
        private System.Windows.Forms.Label lblTopSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Button btnChooseSave;
        private System.Windows.Forms.TextBox tBoxSave;
        private System.Windows.Forms.Label lblTopLoad;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Button btnChooseLoad;
        private System.Windows.Forms.TextBox tBoxLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}