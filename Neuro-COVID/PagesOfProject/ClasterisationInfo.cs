using Neuro_COVID.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neuro_COVID.PagesOfProject
{
    public partial class ClasterisationInfo : Form
    {
        private bool isCollapsedStdOpt = true;
        private bool isCollapsedProp = true;
        private bool isCollapsedWRatio = true;
        private Dictionary<string, double> propCoefs = new Dictionary<string, double>();

        public ClasterisationInfo()
        {
            InitializeComponent();
        }
        private void ClasterisationInfo_Load(object sender, EventArgs e)
        {
            dGViewKoefs.Visible = false;
            lblMostProp.Visible = false;
            btnRefreshCoefs.Visible = false;

            if (Form1.Childrens_Info != null)
            {
                List<string> colomns = Kohanen_Func.colomnsData();
                int i = 0;
                foreach (string colomn in colomns)
                {
                    if (i >= 3)
                        Properties.Items.Add(colomn);
                    i++;
                }
            }

            if (Form1.v != null & Form1.v != 0)
            {
                InputVShod.Text = Form1.v.ToString();
                InputRk.Text = Form1.Rk.ToString();
                InputSteps.Text = Form1.steps.ToString();
            }
            if (Form1.Properties != null)
            {
                dGViewKoefs.Visible = true;
                lblMostProp.Visible = true;
                for (int i = 0; i < Form1.Properties.Length; i++)
                {
                    Properties.SetSelected(Form1.Properties[i], true);
                    dGViewKoefs.Rows.Add(Properties.Items[Form1.Properties[i]], Form1.Koefs[i]);
                }
            }

            if (Form1.w != null)
            {
                dGViewWRatio.RowCount = Form1.w.GetLength(0);
                dGViewWRatio.ColumnCount = Form1.w.GetLength(1);
                for (int rows = 0; rows < Form1.w.GetLength(0); rows++)
                {
                    for (int col = 0; col < Form1.w.GetLength(1); col++)
                    {
                        dGViewWRatio.Rows[rows].Cells[col].Value = Form1.w[rows, col].ToString();
                    }
                }
            }
        }

        //
        /// Visual
        //
        private void timerStdOpt_Tick(object sender, EventArgs e)
        {
            if (isCollapsedStdOpt)
            {
                btnStandatrOptions.Image = Resources.Collapse_Arrow_20px;
                pnlStandartOpt.Height += 7;
                if (pnlStandartOpt.Height == 142)
                {
                    timerStdOpt.Stop();
                    isCollapsedStdOpt = false;
                }
            }
            else
            {
                btnStandatrOptions.Image = Resources.Expand_Arrow_20px;
                pnlStandartOpt.Height -= 7;
                if (pnlStandartOpt.Height == 30)
                {
                    timerStdOpt.Stop();
                    isCollapsedStdOpt = true;
                }
            }
        }

        private void btnStandatrOptions_Click(object sender, EventArgs e)
        {
            if (isCollapsedStdOpt)
            {
                btnStandatrOptions.Image = Resources.Collapse_Arrow_20px;
                pnlStandartOpt.Height += 7;
                if (pnlStandartOpt.Size == pnlStandartOpt.MaximumSize)
                {
                    timerStdOpt.Stop();
                    isCollapsedStdOpt = false;
                }
            }
            else
            {
                btnStandatrOptions.Image = Resources.Expand_Arrow_20px;
                pnlStandartOpt.Height -= 7;
                if (pnlStandartOpt.Size == pnlStandartOpt.MinimumSize)
                {
                    timerStdOpt.Stop();
                    isCollapsedStdOpt = true;
                }
            }
            timerStdOpt.Start();
            //Thread.Sleep Но тут все показывается не самым лучшим образом хоть и меньше кода
           /* if (isCollapsedStdOpt)
            {
                btnStandatrOptions.Image = Resources.Collapse_Arrow_20px;
                while (isCollapsedStdOpt)
                {
                    pnlStandartOpt.Height += 7;
                    if (pnlStandartOpt.Size == pnlStandartOpt.MaximumSize)
                        isCollapsedStdOpt = false;
                    Thread.Sleep(1);
                }
            }
            else
            {
                btnStandatrOptions.Image = Resources.Expand_Arrow_20px;
                while (!isCollapsedStdOpt)
                {
                    pnlStandartOpt.Height -= 7;
                    if (pnlStandartOpt.Size == pnlStandartOpt.MinimumSize)
                        isCollapsedStdOpt = true;
                    Thread.Sleep(1);
                }
            }*/
        }
        private void btnProp_Click(object sender, EventArgs e)
        {
            timerProp.Start();
        }

        private void timerProp_Tick(object sender, EventArgs e)
        {
            
            if (isCollapsedProp)
            {
                btnProp.Image = Resources.Collapse_Arrow_20px;
                pnlProp.Height += 15;
                if (pnlProp.Height == 270)
                {
                    timerProp.Stop();
                    isCollapsedProp = false;
                }
            }
            else
            {
                btnProp.Image = Resources.Expand_Arrow_20px;
                pnlProp.Height -= 15;
                if (pnlProp.Height == 30)
                {
                    timerProp.Stop();
                    isCollapsedProp = true;
                }
            }
        }

        private void btnWRatio_Click(object sender, EventArgs e)
        {
            if (Properties.SelectedItems.Count != 0)
                dGViewWRatio.ColumnCount = Properties.SelectedItems.Count;
            else
                dGViewWRatio.ColumnCount = 34;
            timerWRatio.Start();
        }

        private void timerWRatio_Tick(object sender, EventArgs e)
        {
            if (isCollapsedWRatio)
            {
                btnWRatio.Image = Resources.Collapse_Arrow_20px;
                pnlWRatio.Height += 10;
                if (pnlWRatio.Height == 200)
                {
                    timerWRatio.Stop();
                    isCollapsedWRatio = false;
                }
            }
            else
            {
                btnWRatio.Image = Resources.Expand_Arrow_20px;
                pnlWRatio.Height -= 10;
                if (pnlWRatio.Height == 30)
                {
                    timerWRatio.Stop();
                    isCollapsedWRatio = true;
                }
            }
        }
        //
        /// Visual
        //
        private void ClasterisationInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (chBUsingWRatio.Checked)
                {
                    double[,] w = new double[dGViewWRatio.Rows.Count, dGViewWRatio.ColumnCount];
                    for (int rows = 0; rows < dGViewWRatio.Rows.Count; rows++)
                    {
                        for (int col = 0; col < dGViewWRatio.Rows[rows].Cells.Count; col++)
                        {
                            w[rows, col] = Convert.ToDouble(dGViewWRatio.Rows[rows].Cells[col].Value);
                        }
                    }
                    if (Form1.w != w)
                        if (Form1.New_Childrens_Info != null)
                        {
                            Form1.Childrens_Info = Form1.New_Childrens_Info;
                            Form1.New_Childrens_Info = null;
                        }
                    Form1.w = w;
                }
                else
                    Form1.w = null;
            }
            catch
            {
                MessageBox.Show("Весовые коэффициенты заданы неверно, из-за чего не будут использоваться", "Error");
                Form1.w = null;
            }


            try
            {
                if (InputVShod.Text != "" & InputRk.Text != "" & InputSteps.Text != "")
                {
                    if (Convert.ToDouble(InputVShod.Text) != Form1.v || Convert.ToDouble(InputRk.Text) != Form1.Rk || Convert.ToDouble(InputSteps.Text) != Form1.steps)
                    {
                        Form1.ClastersInfo = null;
                        Form1.SelectedСluster = Double.NaN;
                    }
                    Form1.v = Convert.ToDouble(InputVShod.Text);
                    Form1.Rk = Convert.ToDouble(InputRk.Text);
                    Form1.steps = Convert.ToInt32(InputSteps.Text);
                    if (Form1.New_Childrens_Info != null)
                    {
                        Form1.Childrens_Info = Form1.New_Childrens_Info;
                        Form1.New_Childrens_Info = null;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Необходимые данные заданы неверно", "Error");
            }

            if (Properties.SelectedIndices.Count > 0 & chBUsingProp.Checked)
            {
                int[] properties = new int[Properties.SelectedIndices.Count];
                string[] koefs = new string[Properties.SelectedIndices.Count];
                for (int i = 0; i < Properties.SelectedIndices.Count; i++)
                    properties[i] = Properties.SelectedIndices[i];
                for (int i = 0; i < Properties.SelectedIndices.Count; i++)
                {
                    try{
                        Convert.ToDouble(dGViewKoefs.Rows[i].Cells[1].Value);
                        koefs[i] = dGViewKoefs.Rows[i].Cells[1].Value.ToString();
                    }
                    catch
                    {
                        koefs[i] = "1";
                    }
                }


                    int[] old_prop = Form1.Properties;
                if (Form1.Properties == null || !Enumerable.SequenceEqual<int>(Form1.Properties, properties))
                {
                    Form1.ClastersInfo = null;
                    Form1.SelectedСluster = Double.NaN;
                    if (Form1.New_Childrens_Info != null)
                    {
                        Form1.Childrens_Info = Form1.New_Childrens_Info;
                        Form1.New_Childrens_Info = null;
                    }
                    Form1.Properties = properties;
                    Form1.Koefs = koefs;
                }
            }
            else
            {
                if (Form1.Properties != null)
                {
                    Form1.ClastersInfo = null;
                    Form1.SelectedСluster = Double.NaN;
                    if (Form1.New_Childrens_Info != null)
                    {
                        Form1.Childrens_Info = Form1.New_Childrens_Info;
                        Form1.New_Childrens_Info = null;
                    }
                    Form1.Properties = null;
                    Form1.Koefs = null;
                }
            }
        }

        private void chBUsingProp_CheckedChanged(object sender, EventArgs e)
        {
            if (chBUsingProp.Checked)
            {
                lblMostProp.Visible = true;
                dGViewKoefs.Visible = true;
                btnRefreshCoefs.Visible = true;
            }
            else
            {
                lblMostProp.Visible = false;
                dGViewKoefs.Visible = false;
                btnRefreshCoefs.Visible = false;
            }
            if (Properties.SelectedIndices.Count > 0)
                foreach (int index in Properties.SelectedIndices)
                    dGViewKoefs.Rows.Add(Properties.Items[index], 1);
            else
                for (int i = 0; i < Properties.Items.Count; i++)
                    dGViewKoefs.Rows.Add(Properties.Items[i], 1);
        }

        private void btnRefreshCoefs_Click(object sender, EventArgs e)
        {
            for (int rows = 0; rows < dGViewKoefs.Rows.Count; rows++)
                propCoefs[dGViewKoefs.Rows[rows].Cells[0].Value.ToString()] = Convert.ToDouble(dGViewKoefs.Rows[rows].Cells[1].Value);

            dGViewKoefs.Rows.Clear();

            if (Properties.SelectedIndices.Count > 0)
                foreach (int index in Properties.SelectedIndices)
                    dGViewKoefs.Rows.Add(Properties.Items[index], (!propCoefs.ContainsKey(Properties.Items[index].ToString())) ? 1: propCoefs[Properties.Items[index].ToString()]);
            else
                for (int i = 0; i < Properties.Items.Count; i++)
                    dGViewKoefs.Rows.Add(Properties.Items[i], (!propCoefs.ContainsKey(Properties.Items[i].ToString())) ? 1 : propCoefs[Properties.Items[i].ToString()]);
            propCoefs.Clear();
        }
    }
}
