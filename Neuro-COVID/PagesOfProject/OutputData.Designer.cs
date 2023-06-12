namespace Neuro_COVID.PagesOfProject
{
    partial class OutputData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputData));
            this.ResultsClustList = new System.Windows.Forms.ListView();
            this.tStripInfo = new System.Windows.Forms.ToolStrip();
            this.tStripLblChooseCl = new System.Windows.Forms.ToolStripLabel();
            this.cBoxNumCluster = new System.Windows.Forms.ToolStripComboBox();
            this.WatchInfoBtn = new System.Windows.Forms.ToolStripButton();
            this.DataTransferBtn = new System.Windows.Forms.ToolStripButton();
            this.tStripBtnExportData = new System.Windows.Forms.ToolStripButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tStripStartClust = new System.Windows.Forms.ToolStrip();
            this.startNeuroBtn = new System.Windows.Forms.ToolStripButton();
            this.cMenuStrDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteTStripMenuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripInfo.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tStripStartClust.SuspendLayout();
            this.cMenuStrDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultsClustList
            // 
            this.ResultsClustList.ContextMenuStrip = this.cMenuStrDelete;
            this.ResultsClustList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsClustList.FullRowSelect = true;
            this.ResultsClustList.GridLines = true;
            this.ResultsClustList.HideSelection = false;
            this.ResultsClustList.Location = new System.Drawing.Point(0, 25);
            this.ResultsClustList.Name = "ResultsClustList";
            this.ResultsClustList.Size = new System.Drawing.Size(800, 400);
            this.ResultsClustList.TabIndex = 31;
            this.ResultsClustList.UseCompatibleStateImageBehavior = false;
            this.ResultsClustList.View = System.Windows.Forms.View.Details;
            // 
            // tStripInfo
            // 
            this.tStripInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tStripInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripLblChooseCl,
            this.cBoxNumCluster,
            this.WatchInfoBtn,
            this.DataTransferBtn,
            this.tStripBtnExportData});
            this.tStripInfo.Location = new System.Drawing.Point(0, 425);
            this.tStripInfo.Name = "tStripInfo";
            this.tStripInfo.Size = new System.Drawing.Size(800, 25);
            this.tStripInfo.TabIndex = 32;
            this.tStripInfo.Text = "toolStrip2";
            // 
            // tStripLblChooseCl
            // 
            this.tStripLblChooseCl.Name = "tStripLblChooseCl";
            this.tStripLblChooseCl.Size = new System.Drawing.Size(107, 22);
            this.tStripLblChooseCl.Text = "Выберите кластер";
            // 
            // cBoxNumCluster
            // 
            this.cBoxNumCluster.Name = "cBoxNumCluster";
            this.cBoxNumCluster.Size = new System.Drawing.Size(121, 25);
            // 
            // WatchInfoBtn
            // 
            this.WatchInfoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WatchInfoBtn.Image = ((System.Drawing.Image)(resources.GetObject("WatchInfoBtn.Image")));
            this.WatchInfoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WatchInfoBtn.Name = "WatchInfoBtn";
            this.WatchInfoBtn.Size = new System.Drawing.Size(64, 22);
            this.WatchInfoBtn.Text = "Смотреть";
            this.WatchInfoBtn.Click += new System.EventHandler(this.WatchInfoBtn_Click);
            // 
            // DataTransferBtn
            // 
            this.DataTransferBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DataTransferBtn.Image = ((System.Drawing.Image)(resources.GetObject("DataTransferBtn.Image")));
            this.DataTransferBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DataTransferBtn.Name = "DataTransferBtn";
            this.DataTransferBtn.Size = new System.Drawing.Size(180, 22);
            this.DataTransferBtn.Text = "Перенести в исходные данные";
            this.DataTransferBtn.Click += new System.EventHandler(this.DataTransferBtn_Click);
            // 
            // tStripBtnExportData
            // 
            this.tStripBtnExportData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripBtnExportData.Image = ((System.Drawing.Image)(resources.GetObject("tStripBtnExportData.Image")));
            this.tStripBtnExportData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripBtnExportData.Name = "tStripBtnExportData";
            this.tStripBtnExportData.Size = new System.Drawing.Size(101, 22);
            this.tStripBtnExportData.Text = "Вывести данные";
            this.tStripBtnExportData.Click += new System.EventHandler(this.tStripBtnExportData_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.ResultsClustList);
            this.panelMain.Controls.Add(this.tStripStartClust);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 425);
            this.panelMain.TabIndex = 33;
            // 
            // tStripStartClust
            // 
            this.tStripStartClust.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNeuroBtn});
            this.tStripStartClust.Location = new System.Drawing.Point(0, 0);
            this.tStripStartClust.Name = "tStripStartClust";
            this.tStripStartClust.Size = new System.Drawing.Size(800, 25);
            this.tStripStartClust.TabIndex = 32;
            this.tStripStartClust.Text = "toolStrip3";
            // 
            // startNeuroBtn
            // 
            this.startNeuroBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.startNeuroBtn.Image = ((System.Drawing.Image)(resources.GetObject("startNeuroBtn.Image")));
            this.startNeuroBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startNeuroBtn.Name = "startNeuroBtn";
            this.startNeuroBtn.Size = new System.Drawing.Size(164, 22);
            this.startNeuroBtn.Text = "Произвести кластеризацию";
            this.startNeuroBtn.Click += new System.EventHandler(this.startNeuroBtn_Click);
            // 
            // cMenuStrDelete
            // 
            this.cMenuStrDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteTStripMenuItm});
            this.cMenuStrDelete.Name = "cMenuStrDelete";
            this.cMenuStrDelete.Size = new System.Drawing.Size(119, 26);
            // 
            // DeleteTStripMenuItm
            // 
            this.DeleteTStripMenuItm.Name = "DeleteTStripMenuItm";
            this.DeleteTStripMenuItm.Size = new System.Drawing.Size(180, 22);
            this.DeleteTStripMenuItm.Text = "Удалить";
            this.DeleteTStripMenuItm.Click += new System.EventHandler(this.DeleteTStripMenuItm_Click);
            // 
            // OutputData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.tStripInfo);
            this.Name = "OutputData";
            this.Text = "OutputData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OutputData_FormClosing);
            this.Load += new System.EventHandler(this.OutputData_Load);
            this.tStripInfo.ResumeLayout(false);
            this.tStripInfo.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tStripStartClust.ResumeLayout(false);
            this.tStripStartClust.PerformLayout();
            this.cMenuStrDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ResultsClustList;
        private System.Windows.Forms.ToolStrip tStripInfo;
        private System.Windows.Forms.ToolStripLabel tStripLblChooseCl;
        private System.Windows.Forms.ToolStripComboBox cBoxNumCluster;
        private System.Windows.Forms.ToolStripButton WatchInfoBtn;
        private System.Windows.Forms.ToolStripButton DataTransferBtn;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripButton tStripBtnExportData;
        private System.Windows.Forms.ToolStrip tStripStartClust;
        private System.Windows.Forms.ToolStripButton startNeuroBtn;
        private System.Windows.Forms.ContextMenuStrip cMenuStrDelete;
        private System.Windows.Forms.ToolStripMenuItem DeleteTStripMenuItm;
    }
}