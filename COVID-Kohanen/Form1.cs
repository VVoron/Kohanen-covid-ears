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
using static System.Windows.Forms.ListViewItem;

namespace COVID_Kohanen
{
    public partial class Form1 : Form
    {
        private Button CurrentButton;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        public Form1()
        {
            InitializeComponent();
        }

        private double v = 0;
        private double Rk = 0;
        private int steps = 0;
        private int N = 0;
        private int M = 0;
        private int count;
        private double[,] w;
        private double[,] x_0;
        string[] ChildForClusters;
        bool cluster = false;
        bool FirstTime = true;

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

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Исходные данные";
            ActiveButton(sender);
            tabControl1.SelectedIndex = 0;
            tabControl1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Параметры кластеризации";
            ActiveButton(sender);
            tabControl1.SelectedIndex = 1;
            tabControl1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Итоги кластеризации";
            ActiveButton(sender);
            tabControl1.SelectedIndex = 2;
            tabControl1.Visible = true;
            NumCluster.Items.Clear();
            try
            {
                v = Convert.ToDouble(vShod.Text);
                Rk = Convert.ToDouble(InputRk.Text);
                steps = Convert.ToInt32(InputSteps.Text);
                if (Properties.SelectedItems.Count != 0)
                    N = Properties.SelectedItems.Count;
                x_0 = new double[M, N];
                int i = 0;
                int j = 0;
                foreach (ListViewItem item in ChildsList.Items)
                {
                    bool check = false;
                    j = 0;
                    int num = 0;
                    foreach (ListViewSubItem itemName in item.SubItems)
                    {
                        if (check)
                        {
                            if (Properties.SelectedItems.Count == 0)
                            {
                                x_0[i, j] = Convert.ToDouble(itemName.Text);
                                j++;
                            }
                            else
                            {
                                bool checker = false;
                                foreach (int index in Properties.SelectedIndices)
                                {
                                    Console.WriteLine(index.ToString());
                                    if (num == index + 3)
                                    {
                                        checker = true;
                                        break;
                                    }
                                }
                                if (checker == true)
                                {
                                    x_0[i, j] = Convert.ToDouble(itemName.Text);
                                    j++;
                                }
                            }
                        }
                        num++;
                        if (num == 3)
                            check = true;
                    }
                    i++;
                }

                N = j;

                double[,] x = Neurostart(x_0);

                if (!FirstTime)
                    WstartWithout(x); //Получение начальных весовых коэффициентов

                Console.WriteLine(count + 1);

                ChildForClusters = new string[count + 1];

                //Изменение весовых коэффициентов
                Wcorrect(x);

                //Расфасофка по кластерам
                ChildInClusters(x);

                Childs_Clast();

                tabPage3.Enabled = true;

                FirstTime = false;
            }
            catch
            {
                NumCluster.Items.Clear();
                tabPage3.Enabled = false;
            }
        }

        private void AddData_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                ExcelPackage excelFile = new ExcelPackage(new FileInfo(filename));
                ExcelWorksheet worksheet = excelFile.Workbook.Worksheets[1];
                int new_M = worksheet.Dimension.End.Row;
                int new_N = worksheet.Dimension.End.Column;
                for (int rowIndex = 4; rowIndex < new_M + 1; rowIndex++)
                {
                    IEnumerable<string> row = worksheet.Cells[rowIndex, 1, rowIndex, new_N].Select(c => c.Value == null ? "0".ToString() : c.Value.ToString());
                    string[] list = row.ToArray();
                    ChildsList.Items.Add(new ListViewItem(list));
                }
                N = new_N - 3;
                M += new_M - 3;
            }
        }

        private void ClearData_Click(object sender, EventArgs e)
        {
            ChildsList.Items.Clear();
        }

        public double[,] Neurostart(double[,] x_0)
        {
            //Нормализация данных
            double[] min = new double[N];
            double[] max = new double[N];
            double[,] b = new double[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    b[i, j] = x_0[j, i];
                }
            }
            for (int i = 0; i < N; i++)
            {
                min[i] = b[i, 0];
                max[i] = b[i, 0];
                for (int j = 1; j < M; j++)
                {
                    min[i] = Math.Min(min[i], b[i, j]);
                    max[i] = Math.Max(max[i], b[i, j]);
                }
            }

            double[,] x = new double[M, N];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    x[i, j] = Math.Round((x_0[i, j] - (min[j])) / (max[j] - min[j]), 2);
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }

            return x;
        }

        public int[] ListShafle(int[] a)
        {
            Random random = new Random();
            for (int i = a.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = a[j];
                a[j] = a[i];
                a[i] = temp;
            }
            return a;
        }

        public void WstartWithout(double[,] x)
        {
            count = 0;
            w = new double[M, N];
            for (int i = 0; i < N; i++)
            {
                w[0, i] = x[0, i];
                Console.Write(w[0, i] + " ");
            }
            for (int i = 0; i < M; i++)
            {
                double[] R = new double[count + 1];
                for (int j = 0; j < (count + 1); j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        R[j] += Math.Pow(x[i, k] - w[j, k], 2);
                    }
                    R[j] = Math.Sqrt(R[j]);
                }

                int bestR = 0;
                double best = R[0];
                for (int j = 0; j < R.Length; j++)
                {
                    best = Math.Min(best, R[j]);
                    if (best == R[j]) { bestR = j; }
                }
                if (best <= Rk)
                {
                    for (int j = 0; j < N; j++)
                    {
                        w[bestR, j] += v * (x[i, j] - w[bestR, j]);
                    }
                }
                else
                {
                    count++;
                    for (int j = 0; j < N; j++)
                    {
                        w[count, j] = x[i, j];
                    }
                }
            }
        }

        public void Wcorrect(double[,] x)
        {
            double step = v / steps;
            //Изменение весовых коэффициентов
            for (int z = 0; z < steps; z++)
            {
                double new_v = v - step * z;
                int[] listforstep = Enumerable.Range(1, M).ToArray();
                listforstep = ListShafle(listforstep);
                for (int i = 0; i < M; i++)
                {
                    double[] R = new double[count + 1];
                    int number = listforstep[i] - 1;
                    for (int j = 0; j < (count + 1); j++)
                    {
                        for (int k = 0; k < N; k++)
                        {
                            R[j] += Math.Pow(x[number, k] - w[j, k], 2);
                        }
                        R[j] = Math.Sqrt(R[j]);
                    }
                    int bestR = 0;
                    double best = R[0];
                    for (int j = 0; j < R.Length; j++)
                    {
                        best = Math.Min(best, R[j]);
                        if (best == R[j]) { bestR = j; }
                    }
                    for (int j = 0; j < N; j++)
                    {
                        w[bestR, j] += new_v * (x[number, j] - w[bestR, j]);
                    }
                }
            }
        }

        public void Childs_Clast()
        {
            int new_count = 0;
            for (int i = 0; i < ChildForClusters.Length; i++)
            {
                Console.WriteLine(ChildForClusters[i].ToString());
                if (ChildForClusters[i].ToString() != "")
                {
                    new_count++;
                    NumCluster.Items.Add((new_count).ToString() + " кластер");
                    Console.WriteLine("В " + (new_count).ToString() + " кластер");

                    string[] numChild = ChildForClusters[i].Trim(' ').Split(' ');
                    for (int j = 0; j < numChild.Length; j++)
                    {
                        Console.WriteLine(numChild[j]);
                        int number = Convert.ToInt32(numChild[j]);
                        Console.WriteLine("№" + number.ToString() + " " + ChildsList.Items[number-1].Text);
                    }
                }
            }
        }

        public void ChildInClusters(double[,] x)
        {
            for (int i = 0; i < M; i++)
            {
                double[] R = new double[count + 1];
                for (int j = 0; j < (count + 1); j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        R[j] += Math.Pow(x[i, k] - w[j, k], 2);
                    }
                    R[j] = Math.Sqrt(R[j]);
                }
                int bestR = 0;
                double best = R[0];
                for (int j = 0; j < R.Length; j++)
                {
                    best = Math.Min(best, R[j]);
                    if (best == R[j]) { bestR = j; }
                }
                ChildForClusters[bestR] += " " + (i + 1).ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Связь ковида со слухом";
            tabControl1.Visible = false;
            DisableButton();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ResultsClustList.Items.Clear();
            if (NumCluster.SelectedItem != null)
            {
                int i = NumCluster.SelectedIndex;
                string[] numChild = ChildForClusters[i].Trim(' ').Split(' ');
                int childcount = ChildsList.Columns.Count;
                double[] min = new double[childcount - 1];
                double[] max = new double[childcount - 1];
                for (int j = 0; j < numChild.Length; j++)
                {
                    int number = Convert.ToInt32(numChild[j]);
                    string[] row = new string[childcount];
                    
                    for (int k = 0; k < row.Length; k++)
                    {
                        row[k] = ChildsList.Items[number-1].SubItems[k].Text;
                        if (k >= 3)
                            if (j == 0)
                            {
                                min[k-3] = Convert.ToDouble(row[k]);
                                max[k-3] = Convert.ToDouble(row[k]);
                            }else if (j > 0)
                            {
                                double varible = Convert.ToDouble(row[k]);
                                if (varible < min[k-3])
                                    min[k-3] = varible;
                                if (varible > max[k-3])
                                    max[k-3] = varible;
                            }
                    }
                    Console.WriteLine(row[0]);
                    ResultsClustList.Items.Add(new ListViewItem(row));
                }
                string[] avarage = new string[childcount];
                avarage[0] = "Средние значения";
                avarage[1] = "-";
                avarage[2] = "-";
                for (int j = 0; j < childcount - 3; j++)
                {
                    avarage[j + 3] = ((max[j] + min[j]) / 2).ToString();
                }
                ResultsClustList.Items.Add(" ");
                ResultsClustList.Items.Add(new ListViewItem(avarage));
                Despersion(numChild, avarage);
            }
        }

        public void Despersion(string[] numChild, string[] avarage)
        {
            int childcount = ChildsList.Columns.Count;
            string[] despersion = new string[childcount];
            despersion[0] = "Дисперсия";
            despersion[1] = "-";
            despersion[2] = "-";
            double[] despers_var = new double[childcount - 1];
            for (int j = 0; j < numChild.Length; j++)
            {
                int number = Convert.ToInt32(numChild[j]);
                for (int k = 0; k < childcount - 3; k++)
                {
                    double variable = Convert.ToDouble(ChildsList.Items[number - 1].SubItems[k + 3].Text);
                    despers_var[k] += (variable - Convert.ToDouble(avarage[k + 3])) * (variable - Convert.ToDouble(avarage[k + 3]));
                }
            }
            for (int j = 0; j < childcount - 3; j++)
            {
                despersion[j + 3] = Math.Round((despers_var[j] / numChild.Length), 3).ToString();
            }
            ResultsClustList.Items.Add(new ListViewItem(despersion));
        }

        private void InputRk_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (InputRk.Text != "")
                {
                    Rk = Convert.ToDouble(InputRk.Text);
                    if (Properties.SelectedItems.Count != 0)
                        N = Properties.SelectedItems.Count;
                    x_0 = new double[M, N];
                    int i = 0;
                    int j = 0;
                    foreach (ListViewItem item in ChildsList.Items)
                    {
                        bool check = false;
                        j = 0;
                        int num = 0;
                        foreach (ListViewSubItem itemName in item.SubItems)
                        {
                            if (check)
                            {
                                if (Properties.SelectedItems.Count == 0)
                                {
                                    x_0[i, j] = Convert.ToDouble(itemName.Text);
                                    j++;
                                }
                                else
                                {
                                    bool checker = false;
                                    foreach (int index in Properties.SelectedIndices)
                                    {
                                        Console.WriteLine(index.ToString());
                                        if (num == index + 3)
                                        {
                                            checker = true;
                                            break;
                                        }
                                    }
                                    if (checker == true)
                                    {
                                        x_0[i, j] = Convert.ToDouble(itemName.Text);
                                        j++;
                                    }
                                }
                            }
                            num++;
                            if (num == 3)
                                check = true;
                        }
                        i++;
                    }

                    N = j;

                    double[,] x = Neurostart(x_0);

                    WstartWithout(x);
                    cluster = true;
                    nClustersLabel.Visible = true;
                    Console.WriteLine(w.Length / N + " " + count);
                    if (Properties.SelectedItems.Count == 0 & FirstTime)
                        nClustersLabel.Text = "Кластеров: " + (count+1).ToString();
                    else
                    {
                        nClustersLabel.Text = "Кластеров: " + (count + 1).ToString();
                        FirstTime = false;
                    }
                    N = ChildsList.Columns.Count;
                }
            }
            catch
            {

            }
        }

        private void vShod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
