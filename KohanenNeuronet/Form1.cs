using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KohanenNeuronet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Child
        {
            public string name { get; set; }
            public string timeGisto { get; set; }
            public string M12R1 { get; set; }
            public string M12R2 { get; set; }
            public string M12R4 { get; set; }
            public string M12R6 { get; set; }
            public string M12L1 { get; set; }
            public string M12L2 { get; set; }
            public string M12L4 { get; set; }
            public string M12L6 { get; set; }
            public string ASSRr05 { get; set; }
            public string ASSRr1 { get; set; }
            public string ASSRr2 { get; set; }
            public string ASSRr4 { get; set; }
            public string ASSRl05 { get; set; }
            public string ASSRl1 { get; set; }
            public string ASSRl2 { get; set; }
            public string ASSRl4 { get; set; }
            public string KSVPr20 { get; set; }
            public string KSVPr40 { get; set; }
            public string KSVPr60 { get; set; }
            public string KSVPl20 { get; set; }
            public string KSVPl40 { get; set; }
            public string KSVPl60 { get; set; }

            public Child(string[] x)
            {
                this.name = x[0];
                this.timeGisto = x[1];
                this.M12R1 = x[2];
                this.M12R2 = x[3];
                this.M12R4 = x[4];
                this.M12R6 = x[5];
                this.M12L1 = x[6];
                this.M12L2 = x[7];
                this.M12L4 = x[8];
                this.M12L6 = x[9];
                this.ASSRr05 = x[10];
                this.ASSRr1 = x[11];
                this.ASSRr2 = x[12];
                this.ASSRr4 = x[13];
                this.ASSRl05 = x[14];
                this.ASSRl1 = x[15];
                this.ASSRl2 = x[16];
                this.ASSRl4 = x[17];
                this.KSVPr20 = x[18];
                this.KSVPr40 = x[19];
                this.KSVPr60 = x[20];
                this.KSVPl20 = x[21];
                this.KSVPl40 = x[22];
                this.KSVPl60 = x[23];
            }
            public string Print()
            {
                return name;
            }
            public string[] allData()
            {
                string[] data = new string[] {timeGisto, M12R1, M12R2, M12R4, M12R6, M12L1, M12L2, M12L4, M12L6, ASSRr05, ASSRr1, ASSRr2, ASSRr4, ASSRl05, ASSRl1, ASSRl2, ASSRl4, KSVPr20, KSVPr40, KSVPr60, KSVPl20, KSVPl40, KSVPl60};
                return data;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
        Child[] objectsChild;


        private void StartNeuro_Click(object sender, EventArgs e)
        {
            NumCluster.Items.Clear();
            OutputInfo.Clear();
            ClasterInfo.Clear();
            try
            {
                v = Convert.ToDouble(vShod.Text);
                Rk = Convert.ToDouble(InputRk.Text);
                steps = Convert.ToInt32(InputSteps.Text);

                string filename = textBox1.Text;
                if (filename == "" || v == 0 || Rk == 0 || steps == 0) throw new Exception();

                ExcelPackage excelFile = new ExcelPackage(new FileInfo(filename));
                ExcelWorksheet worksheet = excelFile.Workbook.Worksheets[1];

                int new_M = worksheet.Dimension.End.Row;
                int new_N = worksheet.Dimension.End.Column;

                M = new_M - 4;
                N = new_N;
                if (Properties.SelectedItems.Count == 0)
                {
                    x_0 = new double[M, N - 1];
                }
                else
                {
                    x_0 = new double[M, Properties.SelectedItems.Count + 1];
                }
                objectsChild = new Child[M];
                Console.WriteLine(M.ToString() + " " + new_M.ToString() + "\n" + N.ToString());

                for (int rowIndex = 5; rowIndex < new_M+1; rowIndex++)
                {
                    IEnumerable<string> row = worksheet.Cells[rowIndex, 1, rowIndex, N].Select(c => c.Value == null ? "0".ToString() : c.Value.ToString());
                    List<string> list = row.ToList<string>();

                    objectsChild[rowIndex - 5] = new Child(list.ToArray());
                    Console.WriteLine(objectsChild[rowIndex - 5].Print());
                    if (Properties.SelectedItems.Count == 0)
                    {
                        for (int i = 0; i < list.Count - 1; i++)
                        {
                            x_0[rowIndex - 5, i] = Convert.ToDouble(list[i + 1]);
                        }
                    }
                    else
                    {
                        int num = 0;
                        for (int i = 0; i < list.Count - 1; i++)
                        {
                            bool check = false;
                            foreach (int item in Properties.SelectedIndices)
                            {
                                if (item == i)
                                {
                                    check = true;
                                    break;
                                }
                            }
                            if (check == true)
                            {
                                x_0[rowIndex - 5, num] = Convert.ToDouble(list[i + 1]);
                                num++;
                            }
                        }
                    }
                }

                if (Properties.SelectedItems.Count != 0)
                    N = Properties.SelectedItems.Count + 1;

                double[,] x = Neurostart(x_0);

                //Получение начальных весовых коэффициентов
                WstartWithout(x);

                Console.WriteLine(count + 1);

                ChildForClusters = new string[count + 1];

                //Изменение весовых коэффициентов
                Wcorrect(x);

                //Расфасофка по кластерам
                ChildInClusters(x);

                Childs_Clast();
                groupBox1.Enabled = true;
            }
            catch
            {
                NumCluster.Items.Clear();
                MessageBox.Show("Исходные значения введены неверно");
            }
        }

        public double[,] Neurostart(double[,] x_0)
        {
            //Нормализация данных
            double[] min = new double[N - 1];
            double[] max = new double[N - 1];
            double[,] b = new double[N - 1, M];
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    b[i, j] = x_0[j, i];
                }
            }
            for (int i = 0; i < N - 1; i++)
            {
                min[i] = b[i, 0];
                max[i] = b[i, 0];
                for (int j = 1; j < M; j++)
                {
                    min[i] = Math.Min(min[i], b[i, j]);
                    max[i] = Math.Max(max[i], b[i, j]);
                }
            }

            double[,] x = new double[M, N - 1];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < (N - 1); j++)
                {
                    x[i, j] = Math.Round((x_0[i, j] - (min[j])) / (max[j] - min[j]), 2);
                }
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
            w = new double[M, N - 1];
            for (int i = 0; i < (N - 1); i++)
            {
                w[0, i] = x[0, i];
                Console.Write(w[0, i] + " ");
            }
            for (int i = 0; i < M; i++)
            {
                double[] R = new double[count + 1];
                for (int j = 0; j < (count + 1); j++)
                {
                    for (int k = 0; k < (N - 1); k++)
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
                    for (int j = 0; j < (N - 1); j++)
                    {
                        w[bestR, j] += v * (x[i, j] - w[bestR, j]);
                    }
                }
                else
                {
                    count++;
                    for (int j = 0; j < (N - 1); j++)
                    {
                        w[count, j] = x[count, j];
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
                        for (int k = 0; k < (N - 1); k++)
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
                    for (int j = 0; j < (N - 1); j++)
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
                if (ChildForClusters[i].ToString() != "")
                {
                    new_count++;
                    NumCluster.Items.Add((new_count).ToString() + " кластер");
                    Console.WriteLine("В " + (new_count).ToString() + " кластер");

                    string[] numChild = ChildForClusters[i].Trim(' ').Split(' ');
                    for (int j = 0; j < numChild.Length; j++)
                    {
                        int number = Convert.ToInt32(numChild[j]);
                        Console.WriteLine("№" + number.ToString() + " " + objectsChild[number - 1].Print());
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
                    for (int k = 0; k < (N - 1); k++)
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

        private void InputFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = filename;
            }
        }

        private void OutputInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Watchbtn_Click(object sender, EventArgs e)
        {
            OutputInfo.Clear();
            ClasterInfo.Clear();
            if (NumCluster.SelectedItem != null)
            {
                int i = NumCluster.SelectedIndex;
                try
                {
                    string[] numChild = ChildForClusters[i].Trim(' ').Split(' ');
                    for (int j = 0; j < numChild.Length; j++)
                    {
                        int number = Convert.ToInt32(numChild[j]);
                        OutputInfo.Text += "№" + number.ToString() + " " + objectsChild[number - 1].Print() + "\n";
                    }
                }
                catch
                {
                    string numChild = ChildForClusters[i].Trim(' ');
                    int number = Convert.ToInt32(numChild);
                    OutputInfo.Text += "№" + number.ToString() + " " + objectsChild[number - 1].Print() + "\n";
                }
                for (int j = 0; j < N - 1; j++)
                {
                    ClasterInfo.Text += Math.Round(w[i, j], 2).ToString() + "\n";
                }
            }

        }

        private void NewInput_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog2.FileName;
                textBox2.Clear();
                textBox2.Text = filename;
            }
        }


        private void ReNeuro_Click(object sender, EventArgs e)
        {
            try
            {
                OutputInfo.Clear();
                ClasterInfo.Clear();

                string filename = textBox2.Text;

                ExcelPackage excelFile = new ExcelPackage(new FileInfo(filename));
                ExcelWorksheet worksheet = excelFile.Workbook.Worksheets[1];

                int new_M = worksheet.Dimension.End.Row;
                int new_N = worksheet.Dimension.End.Column;

                M = new_M - 4;
                N = new_N;

                double[,] old_x_0 = x_0;
                double[,] new_x_0 = new double[M, N - 1];
                x_0 = new double[old_x_0.Length + M, N - 1];
                if (Properties.SelectedIndices.Count != 0)
                {
                    new_x_0 = new double[M, Properties.SelectedItems.Count + 1];
                    x_0 = new double[old_x_0.Length + M, Properties.SelectedItems.Count + 1];
                }

                Child[] new_objectsChild = new Child[M];
                Child[] old_objectsChild = objectsChild;

                objectsChild = new Child[M + old_objectsChild.Length];

                for (int i = 0; i < M; i++)
                {
                    objectsChild[i] = old_objectsChild[i];
                    if (Properties.SelectedIndices.Count == 0)
                    {
                        for (int j = 0; j < N - 1; j++)
                        {
                            x_0[i, j] = old_x_0[i, j];
                        }
                    }
                    else
                    {
                        for (int j = 0;j < Properties.SelectedItems.Count + 1; j++)
                        {
                            x_0[i, j] = old_x_0[i, j];
                        }
                    }
                    Console.WriteLine(objectsChild[i].Print());
                }

                for (int rowIndex = 5; rowIndex < new_M + 1; rowIndex++)
                {
                    IEnumerable<string> row = worksheet.Cells[rowIndex, 1, rowIndex, N].Select(c => c.Value == null ? "0".ToString() : c.Value.ToString());
                    List<string> list = row.ToList<string>();

                    new_objectsChild[rowIndex - 5] = new Child(list.ToArray());
                    if (Properties.SelectedItems.Count == 0)
                    {
                        for (int i = 0; i < list.Count - 1; i++)
                        {
                            new_x_0[rowIndex - 5, i] = Convert.ToDouble(list[i + 1]);
                        }
                    }
                    else
                    {
                        int num = 0;
                        for (int i = 0; i < list.Count - 1; i++)
                        {
                            bool check = false;
                            foreach (int item in Properties.SelectedIndices)
                            {
                                if (item == i)
                                {
                                    check = true;
                                    break;
                                }
                            }
                            if (check == true)
                            {
                                new_x_0[rowIndex - 5, num] = Convert.ToDouble(list[i + 1]);
                                num++;
                            }
                        }
                    }
                }
                if (Properties.SelectedItems.Count != 0)
                    N = Properties.SelectedItems.Count + 2;
                for (int i = 0; i < new_objectsChild.Length; i++)
                {
                    objectsChild[new_objectsChild.Length + i] = new_objectsChild[i];
                    for (int j = 0; j < N - 1; j++)
                    {
                        x_0[new_objectsChild.Length + i, j] = new_x_0[i, j];
                    }
                }
                if (Properties.SelectedItems.Count != 0)
                    N = Properties.SelectedItems.Count + 1;
                M = objectsChild.Length;

                double[,] x = Neurostart(x_0);

                Wcorrect(x);

                ChildForClusters = new string[count + 1];

                //Расфасофка по кластерам
                ChildInClusters(x);
            }
            catch
            {
                MessageBox.Show("Ошибка перераспределения");
            }
            
        }
    }
}