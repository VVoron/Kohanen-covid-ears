using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neuro_COVID.Properties;

namespace Neuro_COVID
{
    public partial class Form1 : Form
    {

        private Button CurrentButton;
        private Form ActiveForm;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
        }

        public static Kohanen_Data[] Childrens_Info;
        public static Kohanen_Data[] New_Childrens_Info;
        public static double v;
        public static double Rk;
        public static int steps;
        public static double[,] w;
        public static int[] Properties;
        public static string[] Koefs;
        public static string[] ClastersInfo;
        public static double SelectedСluster;

        private void ActiveButton(object btnSender)
        {
            DisableButton();
            Color color = Color.FromArgb(101, 104, 154);
            CurrentButton = (Button)btnSender;
            CurrentButton.BackColor = color;
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(50, 51, 76);
                }
            }
        }
        private void OpenChildForm(Form ChildForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveButton(btnSender);
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(ChildForm);
            this.DesktopPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            TitleLbl.Text = "Связь ковида со слухом";
            DisableButton();
        }
        private void InputPageBtn_Click(object sender, EventArgs e)
        {
            TitleLbl.Text = "Исходные данные";
            ActiveButton(sender);
            OpenChildForm(new PagesOfProject.InputDataPage(), sender);
        }

        private void ClasterisationBtn_Click(object sender, EventArgs e)
        {
            TitleLbl.Text = "Параметры кластеризации";
            ActiveButton(sender);
            OpenChildForm(new PagesOfProject.ClasterisationInfo(), sender);
        }

        private void ClusterBtn_Click(object sender, EventArgs e)
        {
            TitleLbl.Text = "Итоги кластеризации";
            ActiveButton(sender);
            OpenChildForm(new PagesOfProject.OutputData(), sender);
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ClasterDiagramsBtn_Click(object sender, EventArgs e)
        {
            TitleLbl.Text = "Диаграммы";
            ActiveButton(sender);
            OpenChildForm(new PagesOfProject.ClusterDiagrams(), sender);
        }

        private void TitleLbl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FullScreenBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void RollUpBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Childrens_Info != null)
            {
                string[] Info_About_Childrens = new string[Childrens_Info.Length];
                int i = 0;
                foreach (Kohanen_Data child in Childrens_Info)
                {
                    string[] item = child.OutPut_Info();
                    for (int j = 0; j < item.Length; j++)
                        Info_About_Childrens[i] += item[j] + ";";
                    i++;
                }
                Settings.Default["Childrens_Info"] = Info_About_Childrens;
                Settings.Default["v"] = v;
                Settings.Default["Rk"] = Rk;
                Settings.Default["steps"] = steps;
            }
            else
                Settings.Default["Childrens_Info"] = null;
            if (w != null)
            {
                string[] Info_About_w = new string[w.GetLength(0)];
                for (int j = 0; j < w.GetLength(0); j++)
                    for (int k = 0; k < w.GetLength(1); k++)
                        Info_About_w[j] += w[j, k].ToString() + ";";
                Settings.Default["w"] = Info_About_w;
            }
            Settings.Default["Properties"] = Properties;
            Settings.Default["MostProperties"] = Koefs;
            Settings.Default["ClastersInfo"] = ClastersInfo;
            Settings.Default["SelectedСluster"] = SelectedСluster;
            Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Settings.Default.Childrens_Info != null)
            {
                DialogResult msb_out = MessageBox.Show("Загрузить данные последнего сеанса?", "Последний сеанс", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msb_out == DialogResult.Yes)
                {
                    string[] Childrens_Info_previous = Settings.Default.Childrens_Info;
                    Childrens_Info = new Kohanen_Data[Childrens_Info_previous.Length];
                    for (int i = 0; i < Childrens_Info_previous.Length; i++)
                        Childrens_Info[i] = new Kohanen_Data(Childrens_Info_previous[i].Split(';'));
                    v = Settings.Default.v;
                    Rk = Settings.Default.Rk;
                    steps = Settings.Default.steps;
                    string[] w_previous = Settings.Default.w;
                    w = new double[w_previous.Length, w_previous[0].Split(';').Length - 1];
                    for (int i = 0; i < w_previous.Length; i++)
                    {
                        string[] w_str = w_previous[i].Split(';');
                        for (int j = 0; j < w_str.Length - 1; j++)
                            w[i, j] = Convert.ToDouble(w_str[j]);
                    }
                    Properties = Settings.Default.Properties;
                    Koefs = Settings.Default.MostProperties;
                    ClastersInfo = Settings.Default.ClastersInfo;
                    SelectedСluster = Settings.Default.SelectedСluster;
                }
            }
        }

        private void btnSaveLoadInfo_Click(object sender, EventArgs e)
        {
            TitleLbl.Text = "Сохранение/Загрузка";
            ActiveButton(sender);
            OpenChildForm(new PagesOfProject.LoadOrSaveInfo(), sender);
        }

        private void DesktopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
