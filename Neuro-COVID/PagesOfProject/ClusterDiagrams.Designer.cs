namespace Neuro_COVID.PagesOfProject
{
    partial class ClusterDiagrams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClusterDiagrams));
            this.spContainerMain = new System.Windows.Forms.SplitContainer();
            this.zGControlNumClusters = new ZedGraph.ZedGraphControl();
            this.spContainerSecond = new System.Windows.Forms.SplitContainer();
            this.zGControlProp = new ZedGraph.ZedGraphControl();
            this.spContainerProp = new System.Windows.Forms.SplitContainer();
            this.listBoxProp = new System.Windows.Forms.ListBox();
            this.listBoxMassProp = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tStripBtnWatch = new System.Windows.Forms.ToolStripButton();
            this.InfospContainer = new System.Windows.Forms.SplitContainer();
            this.lViewAllInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.spContainerMain)).BeginInit();
            this.spContainerMain.Panel1.SuspendLayout();
            this.spContainerMain.Panel2.SuspendLayout();
            this.spContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerSecond)).BeginInit();
            this.spContainerSecond.Panel1.SuspendLayout();
            this.spContainerSecond.Panel2.SuspendLayout();
            this.spContainerSecond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerProp)).BeginInit();
            this.spContainerProp.Panel1.SuspendLayout();
            this.spContainerProp.Panel2.SuspendLayout();
            this.spContainerProp.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfospContainer)).BeginInit();
            this.InfospContainer.Panel1.SuspendLayout();
            this.InfospContainer.Panel2.SuspendLayout();
            this.InfospContainer.SuspendLayout();
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
            this.spContainerMain.Panel1.Controls.Add(this.zGControlNumClusters);
            // 
            // spContainerMain.Panel2
            // 
            this.spContainerMain.Panel2.Controls.Add(this.spContainerSecond);
            this.spContainerMain.Size = new System.Drawing.Size(769, 523);
            this.spContainerMain.SplitterDistance = 232;
            this.spContainerMain.TabIndex = 0;
            // 
            // zGControlNumClusters
            // 
            this.zGControlNumClusters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zGControlNumClusters.Location = new System.Drawing.Point(0, 0);
            this.zGControlNumClusters.Name = "zGControlNumClusters";
            this.zGControlNumClusters.ScrollGrace = 0D;
            this.zGControlNumClusters.ScrollMaxX = 0D;
            this.zGControlNumClusters.ScrollMaxY = 0D;
            this.zGControlNumClusters.ScrollMaxY2 = 0D;
            this.zGControlNumClusters.ScrollMinX = 0D;
            this.zGControlNumClusters.ScrollMinY = 0D;
            this.zGControlNumClusters.ScrollMinY2 = 0D;
            this.zGControlNumClusters.Size = new System.Drawing.Size(769, 232);
            this.zGControlNumClusters.TabIndex = 0;
            this.zGControlNumClusters.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zGControlNumClusters_MouseClick);
            // 
            // spContainerSecond
            // 
            this.spContainerSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainerSecond.Location = new System.Drawing.Point(0, 0);
            this.spContainerSecond.Name = "spContainerSecond";
            this.spContainerSecond.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spContainerSecond.Panel1
            // 
            this.spContainerSecond.Panel1.Controls.Add(this.zGControlProp);
            // 
            // spContainerSecond.Panel2
            // 
            this.spContainerSecond.Panel2.Controls.Add(this.spContainerProp);
            this.spContainerSecond.Panel2.Controls.Add(this.toolStrip1);
            this.spContainerSecond.Size = new System.Drawing.Size(769, 287);
            this.spContainerSecond.SplitterDistance = 166;
            this.spContainerSecond.TabIndex = 3;
            // 
            // zGControlProp
            // 
            this.zGControlProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zGControlProp.Location = new System.Drawing.Point(0, 0);
            this.zGControlProp.Name = "zGControlProp";
            this.zGControlProp.ScrollGrace = 0D;
            this.zGControlProp.ScrollMaxX = 0D;
            this.zGControlProp.ScrollMaxY = 0D;
            this.zGControlProp.ScrollMaxY2 = 0D;
            this.zGControlProp.ScrollMinX = 0D;
            this.zGControlProp.ScrollMinY = 0D;
            this.zGControlProp.ScrollMinY2 = 0D;
            this.zGControlProp.Size = new System.Drawing.Size(769, 166);
            this.zGControlProp.TabIndex = 0;
            // 
            // spContainerProp
            // 
            this.spContainerProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainerProp.Location = new System.Drawing.Point(0, 0);
            this.spContainerProp.Name = "spContainerProp";
            // 
            // spContainerProp.Panel1
            // 
            this.spContainerProp.Panel1.Controls.Add(this.listBoxProp);
            // 
            // spContainerProp.Panel2
            // 
            this.spContainerProp.Panel2.Controls.Add(this.listBoxMassProp);
            this.spContainerProp.Size = new System.Drawing.Size(769, 92);
            this.spContainerProp.SplitterDistance = 375;
            this.spContainerProp.TabIndex = 2;
            // 
            // listBoxProp
            // 
            this.listBoxProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProp.FormattingEnabled = true;
            this.listBoxProp.Items.AddRange(new object[] {
            "Мать",
            "Срок беременности на момент болезни",
            "Ребенок",
            "Возраст на момент болезни",
            "Срок гестации на момент обследования",
            "Возраст на момент обследования",
            "Отоакустическая эмиссия на правое ухо 1кГц",
            "Отоакустическая эмиссия на правое ухо 2кГц",
            "Отоакустическая эмиссия на правое ухо 4кГц",
            "Отоакустическая эмиссия на правое ухо 6кГц",
            "Отоакустическая эмиссия на левое ухо 1кГц",
            "Отоакустическая эмиссия на левое ухо 2кГц",
            "Отоакустическая эмиссия на левое ухо 4кГц",
            "Отоакустическая эмиссия на левое ухо 6кГц",
            "Отоакустическая эмиссия на правое ухо 0,5-1,5кГц",
            "Отоакустическая эмиссия на правое ухо 1,5-2,5кГц",
            "Отоакустическая эмиссия на правое ухо 2,5-3,5кГц",
            "Оотоакустическая эмиссия на правое ухо 3,5-4,5кГц",
            "Отоакустическая эмиссия на правое ухо 4,5-5,5кГц",
            "Отоакустическая эмиссия на левое ухо 0,5-1,5кГц",
            "Отоакустическая эмиссия на левое ухо 1,5-2,5кГц",
            "Отоакустическая эмиссия на левое ухо 2,5-3,5кГц",
            "Отоакустическая эмиссия на левое ухо 3,5-4,5кГц",
            "Отоакустическая эмиссия на левое ухо 4,5-5,5кГц",
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
            this.listBoxProp.Location = new System.Drawing.Point(0, 0);
            this.listBoxProp.Name = "listBoxProp";
            this.listBoxProp.Size = new System.Drawing.Size(375, 92);
            this.listBoxProp.TabIndex = 0;
            // 
            // listBoxMassProp
            // 
            this.listBoxMassProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMassProp.FormattingEnabled = true;
            this.listBoxMassProp.Items.AddRange(new object[] {
            "Среднее значение",
            "Дисперсия",
            "Нормализованная дисперсия"});
            this.listBoxMassProp.Location = new System.Drawing.Point(0, 0);
            this.listBoxMassProp.Name = "listBoxMassProp";
            this.listBoxMassProp.Size = new System.Drawing.Size(390, 92);
            this.listBoxMassProp.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripBtnWatch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 92);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(769, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tStripBtnWatch
            // 
            this.tStripBtnWatch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripBtnWatch.Image = ((System.Drawing.Image)(resources.GetObject("tStripBtnWatch.Image")));
            this.tStripBtnWatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripBtnWatch.Name = "tStripBtnWatch";
            this.tStripBtnWatch.Size = new System.Drawing.Size(100, 22);
            this.tStripBtnWatch.Text = "Вывести график";
            this.tStripBtnWatch.Click += new System.EventHandler(this.tStripBtnWatch_Click);
            // 
            // InfospContainer
            // 
            this.InfospContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfospContainer.Location = new System.Drawing.Point(0, 0);
            this.InfospContainer.Name = "InfospContainer";
            // 
            // InfospContainer.Panel1
            // 
            this.InfospContainer.Panel1.Controls.Add(this.spContainerMain);
            // 
            // InfospContainer.Panel2
            // 
            this.InfospContainer.Panel2.Controls.Add(this.lViewAllInfo);
            this.InfospContainer.Size = new System.Drawing.Size(1002, 523);
            this.InfospContainer.SplitterDistance = 769;
            this.InfospContainer.TabIndex = 1;
            // 
            // lViewAllInfo
            // 
            this.lViewAllInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lViewAllInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lViewAllInfo.GridLines = true;
            this.lViewAllInfo.HideSelection = false;
            this.lViewAllInfo.Location = new System.Drawing.Point(0, 0);
            this.lViewAllInfo.Name = "lViewAllInfo";
            this.lViewAllInfo.Size = new System.Drawing.Size(229, 523);
            this.lViewAllInfo.TabIndex = 0;
            this.lViewAllInfo.UseCompatibleStateImageBehavior = false;
            this.lViewAllInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Свойство";
            // 
            // ClusterDiagrams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 523);
            this.Controls.Add(this.InfospContainer);
            this.Name = "ClusterDiagrams";
            this.Text = "ClusterDiagrams";
            this.Load += new System.EventHandler(this.ClusterDiagrams_Load);
            this.spContainerMain.Panel1.ResumeLayout(false);
            this.spContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainerMain)).EndInit();
            this.spContainerMain.ResumeLayout(false);
            this.spContainerSecond.Panel1.ResumeLayout(false);
            this.spContainerSecond.Panel2.ResumeLayout(false);
            this.spContainerSecond.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerSecond)).EndInit();
            this.spContainerSecond.ResumeLayout(false);
            this.spContainerProp.Panel1.ResumeLayout(false);
            this.spContainerProp.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainerProp)).EndInit();
            this.spContainerProp.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.InfospContainer.Panel1.ResumeLayout(false);
            this.InfospContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfospContainer)).EndInit();
            this.InfospContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spContainerMain;
        private ZedGraph.ZedGraphControl zGControlNumClusters;
        private ZedGraph.ZedGraphControl zGControlProp;
        private System.Windows.Forms.SplitContainer spContainerProp;
        private System.Windows.Forms.ListBox listBoxProp;
        private System.Windows.Forms.ListBox listBoxMassProp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer spContainerSecond;
        private System.Windows.Forms.ToolStripButton tStripBtnWatch;
        private System.Windows.Forms.SplitContainer InfospContainer;
        private System.Windows.Forms.ListView lViewAllInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}