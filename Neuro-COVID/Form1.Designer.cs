namespace Neuro_COVID
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
            this.HomeBtn = new System.Windows.Forms.Button();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.RollUpBtn = new System.Windows.Forms.Button();
            this.FullScreenBtn = new System.Windows.Forms.Button();
            this.CloseFormBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.ClusterBtn = new System.Windows.Forms.Button();
            this.ClasterisationBtn = new System.Windows.Forms.Button();
            this.InputPageBtn = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSaveLoadInfo = new System.Windows.Forms.Button();
            this.ClasterDiagramsBtn = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.TitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(263, 75);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "  COVID-19";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.TitleBar.Controls.Add(this.RollUpBtn);
            this.TitleBar.Controls.Add(this.FullScreenBtn);
            this.TitleBar.Controls.Add(this.CloseFormBtn);
            this.TitleBar.Controls.Add(this.TitleLbl);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(263, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(821, 75);
            this.TitleBar.TabIndex = 3;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // RollUpBtn
            // 
            this.RollUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RollUpBtn.FlatAppearance.BorderSize = 0;
            this.RollUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RollUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RollUpBtn.ForeColor = System.Drawing.Color.White;
            this.RollUpBtn.Location = new System.Drawing.Point(719, -7);
            this.RollUpBtn.Name = "RollUpBtn";
            this.RollUpBtn.Size = new System.Drawing.Size(30, 39);
            this.RollUpBtn.TabIndex = 24;
            this.RollUpBtn.Text = "-";
            this.RollUpBtn.UseVisualStyleBackColor = true;
            this.RollUpBtn.Click += new System.EventHandler(this.RollUpBtn_Click);
            // 
            // FullScreenBtn
            // 
            this.FullScreenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullScreenBtn.FlatAppearance.BorderSize = 0;
            this.FullScreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullScreenBtn.ForeColor = System.Drawing.Color.White;
            this.FullScreenBtn.Location = new System.Drawing.Point(755, 0);
            this.FullScreenBtn.Name = "FullScreenBtn";
            this.FullScreenBtn.Size = new System.Drawing.Size(30, 30);
            this.FullScreenBtn.TabIndex = 23;
            this.FullScreenBtn.Text = "☐";
            this.FullScreenBtn.UseVisualStyleBackColor = true;
            this.FullScreenBtn.Click += new System.EventHandler(this.FullScreenBtn_Click);
            // 
            // CloseFormBtn
            // 
            this.CloseFormBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseFormBtn.FlatAppearance.BorderSize = 0;
            this.CloseFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseFormBtn.ForeColor = System.Drawing.Color.White;
            this.CloseFormBtn.Location = new System.Drawing.Point(791, 0);
            this.CloseFormBtn.Name = "CloseFormBtn";
            this.CloseFormBtn.Size = new System.Drawing.Size(30, 30);
            this.CloseFormBtn.TabIndex = 22;
            this.CloseFormBtn.Text = "✖";
            this.CloseFormBtn.UseVisualStyleBackColor = true;
            this.CloseFormBtn.Click += new System.EventHandler(this.CloseFormBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TitleLbl.Location = new System.Drawing.Point(308, 26);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(242, 25);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Связь слуха с ковидом";
            this.TitleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLbl_MouseDown);
            // 
            // ClusterBtn
            // 
            this.ClusterBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClusterBtn.FlatAppearance.BorderSize = 0;
            this.ClusterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClusterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClusterBtn.ForeColor = System.Drawing.Color.White;
            this.ClusterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClusterBtn.Location = new System.Drawing.Point(0, 195);
            this.ClusterBtn.Name = "ClusterBtn";
            this.ClusterBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ClusterBtn.Size = new System.Drawing.Size(263, 60);
            this.ClusterBtn.TabIndex = 3;
            this.ClusterBtn.Text = "  Кластеры, информация\r\n  о них";
            this.ClusterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClusterBtn.UseVisualStyleBackColor = true;
            this.ClusterBtn.Click += new System.EventHandler(this.ClusterBtn_Click);
            // 
            // ClasterisationBtn
            // 
            this.ClasterisationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClasterisationBtn.FlatAppearance.BorderSize = 0;
            this.ClasterisationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClasterisationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClasterisationBtn.ForeColor = System.Drawing.Color.White;
            this.ClasterisationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClasterisationBtn.Location = new System.Drawing.Point(0, 135);
            this.ClasterisationBtn.Name = "ClasterisationBtn";
            this.ClasterisationBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ClasterisationBtn.Size = new System.Drawing.Size(263, 60);
            this.ClasterisationBtn.TabIndex = 2;
            this.ClasterisationBtn.Text = "    Процедура кластеризации";
            this.ClasterisationBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClasterisationBtn.UseVisualStyleBackColor = true;
            this.ClasterisationBtn.Click += new System.EventHandler(this.ClasterisationBtn_Click);
            // 
            // InputPageBtn
            // 
            this.InputPageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputPageBtn.FlatAppearance.BorderSize = 0;
            this.InputPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPageBtn.ForeColor = System.Drawing.Color.White;
            this.InputPageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InputPageBtn.Location = new System.Drawing.Point(0, 75);
            this.InputPageBtn.Name = "InputPageBtn";
            this.InputPageBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.InputPageBtn.Size = new System.Drawing.Size(263, 60);
            this.InputPageBtn.TabIndex = 1;
            this.InputPageBtn.Text = "    Исходные данные";
            this.InputPageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InputPageBtn.UseVisualStyleBackColor = true;
            this.InputPageBtn.Click += new System.EventHandler(this.InputPageBtn_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnSaveLoadInfo);
            this.panelMenu.Controls.Add(this.ClasterDiagramsBtn);
            this.panelMenu.Controls.Add(this.ClusterBtn);
            this.panelMenu.Controls.Add(this.ClasterisationBtn);
            this.panelMenu.Controls.Add(this.InputPageBtn);
            this.panelMenu.Controls.Add(this.TopPanel);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(263, 461);
            this.panelMenu.TabIndex = 2;
            // 
            // btnSaveLoadInfo
            // 
            this.btnSaveLoadInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveLoadInfo.FlatAppearance.BorderSize = 0;
            this.btnSaveLoadInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLoadInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveLoadInfo.ForeColor = System.Drawing.Color.White;
            this.btnSaveLoadInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveLoadInfo.Location = new System.Drawing.Point(0, 315);
            this.btnSaveLoadInfo.Name = "btnSaveLoadInfo";
            this.btnSaveLoadInfo.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnSaveLoadInfo.Size = new System.Drawing.Size(263, 35);
            this.btnSaveLoadInfo.TabIndex = 5;
            this.btnSaveLoadInfo.Text = "Сохранение/Загрузка";
            this.btnSaveLoadInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveLoadInfo.UseVisualStyleBackColor = true;
            this.btnSaveLoadInfo.Click += new System.EventHandler(this.btnSaveLoadInfo_Click);
            // 
            // ClasterDiagramsBtn
            // 
            this.ClasterDiagramsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClasterDiagramsBtn.FlatAppearance.BorderSize = 0;
            this.ClasterDiagramsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClasterDiagramsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClasterDiagramsBtn.ForeColor = System.Drawing.Color.White;
            this.ClasterDiagramsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClasterDiagramsBtn.Location = new System.Drawing.Point(0, 255);
            this.ClasterDiagramsBtn.Name = "ClasterDiagramsBtn";
            this.ClasterDiagramsBtn.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ClasterDiagramsBtn.Size = new System.Drawing.Size(263, 60);
            this.ClasterDiagramsBtn.TabIndex = 4;
            this.ClasterDiagramsBtn.Text = "Диаграммы";
            this.ClasterDiagramsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClasterDiagramsBtn.UseVisualStyleBackColor = true;
            this.ClasterDiagramsBtn.Click += new System.EventHandler(this.ClasterDiagramsBtn_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(62)))), ((int)(((byte)(0)))));
            this.TopPanel.Controls.Add(this.HomeBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(263, 75);
            this.TopPanel.TabIndex = 0;
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(263, 75);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(821, 386);
            this.DesktopPanel.TabIndex = 4;
            this.DesktopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DesktopPanel_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button CloseFormBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button ClusterBtn;
        private System.Windows.Forms.Button ClasterisationBtn;
        private System.Windows.Forms.Button InputPageBtn;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel DesktopPanel;
        private System.Windows.Forms.Button ClasterDiagramsBtn;
        private System.Windows.Forms.Button FullScreenBtn;
        private System.Windows.Forms.Button RollUpBtn;
        private System.Windows.Forms.Button btnSaveLoadInfo;
    }
}

