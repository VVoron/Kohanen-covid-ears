namespace Neuro_COVID.PagesOfProject
{
    partial class InputDataPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDataPage));
            this.tStripData = new System.Windows.Forms.ToolStrip();
            this.AddData = new System.Windows.Forms.ToolStripButton();
            this.ClearData = new System.Windows.Forms.ToolStripButton();
            this.ChildsList = new System.Windows.Forms.ListView();
            this.cMenuStrDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteTStripMenuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.DataOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tStripData.SuspendLayout();
            this.cMenuStrDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tStripData
            // 
            this.tStripData.BackColor = System.Drawing.Color.White;
            this.tStripData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddData,
            this.ClearData});
            this.tStripData.Location = new System.Drawing.Point(0, 0);
            this.tStripData.Name = "tStripData";
            this.tStripData.Size = new System.Drawing.Size(800, 25);
            this.tStripData.TabIndex = 1;
            this.tStripData.Text = "toolStrip1";
            // 
            // AddData
            // 
            this.AddData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(104)))), ((int)(((byte)(154)))));
            this.AddData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddData.ForeColor = System.Drawing.Color.White;
            this.AddData.Image = ((System.Drawing.Image)(resources.GetObject("AddData.Image")));
            this.AddData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddData.Name = "AddData";
            this.AddData.Size = new System.Drawing.Size(107, 22);
            this.AddData.Text = "Добавить данные";
            this.AddData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // ClearData
            // 
            this.ClearData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(104)))), ((int)(((byte)(154)))));
            this.ClearData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClearData.ForeColor = System.Drawing.Color.White;
            this.ClearData.Image = ((System.Drawing.Image)(resources.GetObject("ClearData.Image")));
            this.ClearData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearData.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.ClearData.Name = "ClearData";
            this.ClearData.Size = new System.Drawing.Size(63, 22);
            this.ClearData.Text = "Очистить";
            this.ClearData.Click += new System.EventHandler(this.ClearData_Click);
            // 
            // ChildsList
            // 
            this.ChildsList.ContextMenuStrip = this.cMenuStrDelete;
            this.ChildsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildsList.FullRowSelect = true;
            this.ChildsList.GridLines = true;
            this.ChildsList.HideSelection = false;
            this.ChildsList.Location = new System.Drawing.Point(0, 25);
            this.ChildsList.Name = "ChildsList";
            this.ChildsList.Size = new System.Drawing.Size(800, 425);
            this.ChildsList.TabIndex = 22;
            this.ChildsList.UseCompatibleStateImageBehavior = false;
            this.ChildsList.View = System.Windows.Forms.View.Details;
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
            this.DeleteTStripMenuItm.Size = new System.Drawing.Size(118, 22);
            this.DeleteTStripMenuItm.Text = "Удалить";
            this.DeleteTStripMenuItm.Click += new System.EventHandler(this.DeleteTStripMenuItm_Click);
            // 
            // DataOpenFileDialog
            // 
            this.DataOpenFileDialog.FileName = "openFileDialog1";
            // 
            // InputDataPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChildsList);
            this.Controls.Add(this.tStripData);
            this.Name = "InputDataPage";
            this.Text = "InputDataPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputDataPage_FormClosing);
            this.Load += new System.EventHandler(this.InputDataPage_Load);
            this.tStripData.ResumeLayout(false);
            this.tStripData.PerformLayout();
            this.cMenuStrDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tStripData;
        private System.Windows.Forms.ToolStripButton AddData;
        private System.Windows.Forms.ToolStripButton ClearData;
        private System.Windows.Forms.ListView ChildsList;
        private System.Windows.Forms.OpenFileDialog DataOpenFileDialog;
        private System.Windows.Forms.ContextMenuStrip cMenuStrDelete;
        private System.Windows.Forms.ToolStripMenuItem DeleteTStripMenuItm;
    }
}