namespace Neuro_COVID.PagesOfProject
{
    partial class ClasterisationInfo
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
            this.components = new System.ComponentModel.Container();
            this.Properties = new System.Windows.Forms.ListBox();
            this.InputSteps = new System.Windows.Forms.TextBox();
            this.NumStepsLbl = new System.Windows.Forms.Label();
            this.InputRk = new System.Windows.Forms.TextBox();
            this.RkLbl = new System.Windows.Forms.Label();
            this.InputVShod = new System.Windows.Forms.TextBox();
            this.vShodLbl = new System.Windows.Forms.Label();
            this.pnlStandartOpt = new System.Windows.Forms.Panel();
            this.btnStandatrOptions = new System.Windows.Forms.Button();
            this.timerStdOpt = new System.Windows.Forms.Timer(this.components);
            this.pnlProp = new System.Windows.Forms.Panel();
            this.btnRefreshCoefs = new System.Windows.Forms.Button();
            this.dGViewKoefs = new System.Windows.Forms.DataGridView();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Koef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMostProp = new System.Windows.Forms.Label();
            this.chBUsingProp = new System.Windows.Forms.CheckBox();
            this.btnProp = new System.Windows.Forms.Button();
            this.timerProp = new System.Windows.Forms.Timer(this.components);
            this.pnlWRatio = new System.Windows.Forms.Panel();
            this.dGViewWRatio = new System.Windows.Forms.DataGridView();
            this.btnWRatio = new System.Windows.Forms.Button();
            this.chBUsingWRatio = new System.Windows.Forms.CheckBox();
            this.timerWRatio = new System.Windows.Forms.Timer(this.components);
            this.pnlStandartOpt.SuspendLayout();
            this.pnlProp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewKoefs)).BeginInit();
            this.pnlWRatio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewWRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // Properties
            // 
            this.Properties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Properties.FormattingEnabled = true;
            this.Properties.ItemHeight = 16;
            this.Properties.Location = new System.Drawing.Point(13, 36);
            this.Properties.Name = "Properties";
            this.Properties.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Properties.Size = new System.Drawing.Size(392, 180);
            this.Properties.TabIndex = 29;
            // 
            // InputSteps
            // 
            this.InputSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputSteps.Location = new System.Drawing.Point(163, 113);
            this.InputSteps.Multiline = true;
            this.InputSteps.Name = "InputSteps";
            this.InputSteps.Size = new System.Drawing.Size(56, 19);
            this.InputSteps.TabIndex = 28;
            // 
            // NumStepsLbl
            // 
            this.NumStepsLbl.AutoSize = true;
            this.NumStepsLbl.BackColor = System.Drawing.Color.Transparent;
            this.NumStepsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumStepsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumStepsLbl.ForeColor = System.Drawing.Color.Black;
            this.NumStepsLbl.Location = new System.Drawing.Point(10, 116);
            this.NumStepsLbl.Name = "NumStepsLbl";
            this.NumStepsLbl.Size = new System.Drawing.Size(127, 16);
            this.NumStepsLbl.TabIndex = 27;
            this.NumStepsLbl.Text = "Количество шагов";
            // 
            // InputRk
            // 
            this.InputRk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputRk.Location = new System.Drawing.Point(163, 77);
            this.InputRk.Multiline = true;
            this.InputRk.Name = "InputRk";
            this.InputRk.Size = new System.Drawing.Size(56, 19);
            this.InputRk.TabIndex = 26;
            // 
            // RkLbl
            // 
            this.RkLbl.AutoSize = true;
            this.RkLbl.BackColor = System.Drawing.Color.Transparent;
            this.RkLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RkLbl.ForeColor = System.Drawing.Color.Black;
            this.RkLbl.Location = new System.Drawing.Point(10, 80);
            this.RkLbl.Name = "RkLbl";
            this.RkLbl.Size = new System.Drawing.Size(122, 16);
            this.RkLbl.TabIndex = 25;
            this.RkLbl.Text = "Граница разрыва";
            // 
            // InputVShod
            // 
            this.InputVShod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputVShod.Location = new System.Drawing.Point(163, 41);
            this.InputVShod.Multiline = true;
            this.InputVShod.Name = "InputVShod";
            this.InputVShod.Size = new System.Drawing.Size(56, 19);
            this.InputVShod.TabIndex = 24;
            // 
            // vShodLbl
            // 
            this.vShodLbl.AutoSize = true;
            this.vShodLbl.BackColor = System.Drawing.Color.Transparent;
            this.vShodLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vShodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vShodLbl.ForeColor = System.Drawing.Color.Black;
            this.vShodLbl.Location = new System.Drawing.Point(10, 44);
            this.vShodLbl.Name = "vShodLbl";
            this.vShodLbl.Size = new System.Drawing.Size(147, 16);
            this.vShodLbl.TabIndex = 23;
            this.vShodLbl.Text = "Скорость сходимости";
            // 
            // pnlStandartOpt
            // 
            this.pnlStandartOpt.Controls.Add(this.btnStandatrOptions);
            this.pnlStandartOpt.Controls.Add(this.vShodLbl);
            this.pnlStandartOpt.Controls.Add(this.InputVShod);
            this.pnlStandartOpt.Controls.Add(this.InputSteps);
            this.pnlStandartOpt.Controls.Add(this.RkLbl);
            this.pnlStandartOpt.Controls.Add(this.NumStepsLbl);
            this.pnlStandartOpt.Controls.Add(this.InputRk);
            this.pnlStandartOpt.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStandartOpt.Location = new System.Drawing.Point(0, 0);
            this.pnlStandartOpt.Name = "pnlStandartOpt";
            this.pnlStandartOpt.Size = new System.Drawing.Size(845, 30);
            this.pnlStandartOpt.TabIndex = 31;
            // 
            // btnStandatrOptions
            // 
            this.btnStandatrOptions.BackColor = System.Drawing.Color.White;
            this.btnStandatrOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStandatrOptions.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStandatrOptions.FlatAppearance.BorderSize = 0;
            this.btnStandatrOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStandatrOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStandatrOptions.Image = global::Neuro_COVID.Properties.Resources.Expand_Arrow_20px;
            this.btnStandatrOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStandatrOptions.Location = new System.Drawing.Point(0, 0);
            this.btnStandatrOptions.Name = "btnStandatrOptions";
            this.btnStandatrOptions.Size = new System.Drawing.Size(845, 30);
            this.btnStandatrOptions.TabIndex = 32;
            this.btnStandatrOptions.Text = "Необходимые данные";
            this.btnStandatrOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStandatrOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStandatrOptions.UseVisualStyleBackColor = false;
            this.btnStandatrOptions.Click += new System.EventHandler(this.btnStandatrOptions_Click);
            // 
            // timerStdOpt
            // 
            this.timerStdOpt.Interval = 5;
            this.timerStdOpt.Tick += new System.EventHandler(this.timerStdOpt_Tick);
            // 
            // pnlProp
            // 
            this.pnlProp.Controls.Add(this.btnRefreshCoefs);
            this.pnlProp.Controls.Add(this.dGViewKoefs);
            this.pnlProp.Controls.Add(this.lblMostProp);
            this.pnlProp.Controls.Add(this.chBUsingProp);
            this.pnlProp.Controls.Add(this.btnProp);
            this.pnlProp.Controls.Add(this.Properties);
            this.pnlProp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProp.Location = new System.Drawing.Point(0, 30);
            this.pnlProp.Name = "pnlProp";
            this.pnlProp.Size = new System.Drawing.Size(845, 30);
            this.pnlProp.TabIndex = 32;
            // 
            // btnRefreshCoefs
            // 
            this.btnRefreshCoefs.BackColor = System.Drawing.Color.White;
            this.btnRefreshCoefs.FlatAppearance.BorderSize = 0;
            this.btnRefreshCoefs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCoefs.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshCoefs.Image = global::Neuro_COVID.Properties.Resources.new_update;
            this.btnRefreshCoefs.Location = new System.Drawing.Point(785, 25);
            this.btnRefreshCoefs.Name = "btnRefreshCoefs";
            this.btnRefreshCoefs.Size = new System.Drawing.Size(25, 28);
            this.btnRefreshCoefs.TabIndex = 38;
            this.btnRefreshCoefs.UseVisualStyleBackColor = false;
            this.btnRefreshCoefs.Click += new System.EventHandler(this.btnRefreshCoefs_Click);
            // 
            // dGViewKoefs
            // 
            this.dGViewKoefs.AllowUserToAddRows = false;
            this.dGViewKoefs.AllowUserToDeleteRows = false;
            this.dGViewKoefs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewKoefs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.Koef});
            this.dGViewKoefs.Location = new System.Drawing.Point(430, 57);
            this.dGViewKoefs.Name = "dGViewKoefs";
            this.dGViewKoefs.Size = new System.Drawing.Size(380, 195);
            this.dGViewKoefs.TabIndex = 37;
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Название";
            this.NameCol.Name = "NameCol";
            this.NameCol.Width = 250;
            // 
            // Koef
            // 
            this.Koef.HeaderText = "Коэф";
            this.Koef.Name = "Koef";
            // 
            // lblMostProp
            // 
            this.lblMostProp.AutoSize = true;
            this.lblMostProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMostProp.Location = new System.Drawing.Point(426, 33);
            this.lblMostProp.Name = "lblMostProp";
            this.lblMostProp.Size = new System.Drawing.Size(132, 20);
            this.lblMostProp.TabIndex = 36;
            this.lblMostProp.Text = "Коэффициенты";
            // 
            // chBUsingProp
            // 
            this.chBUsingProp.AutoSize = true;
            this.chBUsingProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBUsingProp.Location = new System.Drawing.Point(13, 228);
            this.chBUsingProp.Name = "chBUsingProp";
            this.chBUsingProp.Size = new System.Drawing.Size(320, 20);
            this.chBUsingProp.TabIndex = 34;
            this.chBUsingProp.Text = "Кластеризировать по выбранным свойствам";
            this.chBUsingProp.UseVisualStyleBackColor = true;
            this.chBUsingProp.CheckedChanged += new System.EventHandler(this.chBUsingProp_CheckedChanged);
            // 
            // btnProp
            // 
            this.btnProp.BackColor = System.Drawing.Color.White;
            this.btnProp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProp.FlatAppearance.BorderSize = 0;
            this.btnProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProp.Image = global::Neuro_COVID.Properties.Resources.Expand_Arrow_20px;
            this.btnProp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProp.Location = new System.Drawing.Point(0, 0);
            this.btnProp.Name = "btnProp";
            this.btnProp.Size = new System.Drawing.Size(845, 30);
            this.btnProp.TabIndex = 33;
            this.btnProp.Text = "Дополнительные сведения";
            this.btnProp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProp.UseVisualStyleBackColor = false;
            this.btnProp.Click += new System.EventHandler(this.btnProp_Click);
            // 
            // timerProp
            // 
            this.timerProp.Interval = 7;
            this.timerProp.Tick += new System.EventHandler(this.timerProp_Tick);
            // 
            // pnlWRatio
            // 
            this.pnlWRatio.Controls.Add(this.dGViewWRatio);
            this.pnlWRatio.Controls.Add(this.btnWRatio);
            this.pnlWRatio.Controls.Add(this.chBUsingWRatio);
            this.pnlWRatio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWRatio.Location = new System.Drawing.Point(0, 60);
            this.pnlWRatio.Name = "pnlWRatio";
            this.pnlWRatio.Size = new System.Drawing.Size(845, 30);
            this.pnlWRatio.TabIndex = 33;
            // 
            // dGViewWRatio
            // 
            this.dGViewWRatio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewWRatio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGViewWRatio.Location = new System.Drawing.Point(0, 30);
            this.dGViewWRatio.Name = "dGViewWRatio";
            this.dGViewWRatio.Size = new System.Drawing.Size(845, 0);
            this.dGViewWRatio.TabIndex = 35;
            // 
            // btnWRatio
            // 
            this.btnWRatio.BackColor = System.Drawing.Color.White;
            this.btnWRatio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWRatio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnWRatio.FlatAppearance.BorderSize = 0;
            this.btnWRatio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWRatio.Image = global::Neuro_COVID.Properties.Resources.Expand_Arrow_20px;
            this.btnWRatio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWRatio.Location = new System.Drawing.Point(0, 0);
            this.btnWRatio.Name = "btnWRatio";
            this.btnWRatio.Size = new System.Drawing.Size(845, 30);
            this.btnWRatio.TabIndex = 33;
            this.btnWRatio.Text = "Весовые коэффициенты";
            this.btnWRatio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWRatio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnWRatio.UseVisualStyleBackColor = false;
            this.btnWRatio.Click += new System.EventHandler(this.btnWRatio_Click);
            // 
            // chBUsingWRatio
            // 
            this.chBUsingWRatio.AutoSize = true;
            this.chBUsingWRatio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chBUsingWRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chBUsingWRatio.Location = new System.Drawing.Point(0, 5);
            this.chBUsingWRatio.Name = "chBUsingWRatio";
            this.chBUsingWRatio.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.chBUsingWRatio.Size = new System.Drawing.Size(845, 25);
            this.chBUsingWRatio.TabIndex = 34;
            this.chBUsingWRatio.Text = "Использовать вписанные весовые коэффициенты";
            this.chBUsingWRatio.UseVisualStyleBackColor = true;
            // 
            // timerWRatio
            // 
            this.timerWRatio.Interval = 1;
            this.timerWRatio.Tick += new System.EventHandler(this.timerWRatio_Tick);
            // 
            // ClasterisationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 394);
            this.Controls.Add(this.pnlWRatio);
            this.Controls.Add(this.pnlProp);
            this.Controls.Add(this.pnlStandartOpt);
            this.Name = "ClasterisationInfo";
            this.Text = "ClasterisationInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClasterisationInfo_FormClosing);
            this.Load += new System.EventHandler(this.ClasterisationInfo_Load);
            this.pnlStandartOpt.ResumeLayout(false);
            this.pnlStandartOpt.PerformLayout();
            this.pnlProp.ResumeLayout(false);
            this.pnlProp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewKoefs)).EndInit();
            this.pnlWRatio.ResumeLayout(false);
            this.pnlWRatio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewWRatio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox Properties;
        private System.Windows.Forms.TextBox InputSteps;
        private System.Windows.Forms.Label NumStepsLbl;
        private System.Windows.Forms.TextBox InputRk;
        private System.Windows.Forms.Label RkLbl;
        private System.Windows.Forms.TextBox InputVShod;
        private System.Windows.Forms.Label vShodLbl;
        private System.Windows.Forms.Panel pnlStandartOpt;
        private System.Windows.Forms.Timer timerStdOpt;
        private System.Windows.Forms.Button btnStandatrOptions;
        private System.Windows.Forms.Panel pnlProp;
        private System.Windows.Forms.CheckBox chBUsingProp;
        private System.Windows.Forms.Button btnProp;
        private System.Windows.Forms.Timer timerProp;
        private System.Windows.Forms.Panel pnlWRatio;
        private System.Windows.Forms.DataGridView dGViewWRatio;
        private System.Windows.Forms.CheckBox chBUsingWRatio;
        private System.Windows.Forms.Button btnWRatio;
        private System.Windows.Forms.Timer timerWRatio;
        private System.Windows.Forms.Label lblMostProp;
        private System.Windows.Forms.DataGridView dGViewKoefs;
        private System.Windows.Forms.Button btnRefreshCoefs;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Koef;
    }
}