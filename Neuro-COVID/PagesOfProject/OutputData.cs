using Microsoft.Office.Interop.Excel;
using Neuro_COVID.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neuro_COVID.PagesOfProject
{
    public partial class OutputData : Form
    {
        Kohanen_Data[] Childrens_Info;
        double v;
        double Rk;
        int steps;
        double[,] w;
        Kohanen_Func Kohanen_Func = new Kohanen_Func();
        int[] Properties;
        string[] ChildForClusters;

        public OutputData()
        {
            InitializeComponent();
        }
        private void OutputData_Load(object sender, EventArgs e)
        {
            List<string> colomns = Kohanen_Func.colomnsData();
            foreach (string colomn in colomns)
                ResultsClustList.Columns.Add(colomn);
            
            foreach (ListViewItem item in ResultsClustList.Items)
                item.UseItemStyleForSubItems = false;
            tStripStartClust.Enabled = false;
            tStripInfo.Enabled = false;
            if (Form1.v != 0 & Form1.Rk != 0 & Form1.steps != 0 & Form1.Childrens_Info != null)
            {
                Childrens_Info = Form1.Childrens_Info;
                v = Form1.v;
                Rk = Form1.Rk;
                steps = Form1.steps;
                w = Form1.w;
                Properties = Form1.Properties;
                tStripStartClust.Enabled = true;
            }
            if (Form1.ClastersInfo != null & Form1.Childrens_Info != null)
            {
                tStripInfo.Enabled = true;
                Childrens_Info = Form1.Childrens_Info;
                ChildForClusters = Form1.ClastersInfo;
                int new_count = 0;
                for (int i = 0; i < ChildForClusters.Length; i++)
                {
                    Console.WriteLine(ChildForClusters[i].ToString());
                    if (ChildForClusters[i].ToString() != "")
                    {
                        new_count++;
                        cBoxNumCluster.Items.Add((new_count).ToString() + " кластер");
                    }
                }
                if (Form1.SelectedСluster != Double.NaN)
                {
                    try
                    {
                        cBoxNumCluster.SelectedIndex = Convert.ToInt32(Form1.SelectedСluster);
                        WatchInfoBtn_Click(null, null);
                    }
                    catch
                    {

                    }
                }
            }
            Console.WriteLine("!");
        }
        private void startNeuroBtn_Click(object sender, EventArgs e)
        {
            Form1.New_Childrens_Info = null;
            cBoxNumCluster.Items.Clear();
            int M = Childrens_Info.Length;
            int N = Kohanen_Func.colomnsData().Count() - 3;
            if (Properties != null)
                N = Properties.Length;

            double [,] x_0 = new double[M, N];
            int i = 0;
            foreach (Kohanen_Data data in Childrens_Info)
            {
                double[] needed_Info = data.DataForClasterisation();
                int k = 0;
                for (int j = 0; j < needed_Info.Length; j++)
                    if (Properties != null)
                    {
                        if (Properties.Contains(j))
                        {
                            x_0[i, k] = needed_Info[j];
                            k++;
                        }
                    }
                    else
                    {
                        x_0[i, k] = needed_Info[j];
                        k++;
                    }
                i++;
            }
            double[,] x = Kohanen_Func.neuroStart(x_0);

            if (w == null)
                w = Kohanen_Func.WStartWithout(x, Rk, v, Form1.Koefs); //Получение начальных весовых коэффициентов

            //Изменение весовых коэффициентов
            w = Kohanen_Func.WCorrect(x, v, steps, w, Form1.Koefs);

            //Расфасофка по кластерам
            ChildForClusters = Kohanen_Func.childInClusters(x, w, Rk);

            Form1.ClastersInfo = ChildForClusters;

            int new_count = 0;
            for (i = 0; i < ChildForClusters.Length; i++)
            {
                if (ChildForClusters[i] != null && ChildForClusters[i].ToString() != "")
                {
                    new_count++;
                    cBoxNumCluster.Items.Add((new_count).ToString() + " кластер");
                }
            }
            tStripInfo.Enabled = true;
            Form1.w = w;
        }

        private void WatchInfoBtn_Click(object sender, EventArgs e)
        {
            ResultsClustList.Items.Clear();
            int index_item = 0;
            if (cBoxNumCluster.SelectedItem != null)
            {
                int i = cBoxNumCluster.SelectedIndex;
                string[] numChild = ChildForClusters[i].Trim(' ').Split(' ');
                i = 0;
                int childcount = ResultsClustList.Columns.Count;
                double[,] data = new double[numChild.Length, childcount - 3];
                ResultsClustList.BeginUpdate();
                foreach (string j in numChild)
                {
                    ResultsClustList.Items.Add(new ListViewItem(Childrens_Info[Convert.ToInt32(j) - 1].OutPut_Info()));
                    ResultsClustList.Items[index_item].UseItemStyleForSubItems = false;
                    string[] infoAbutChild = Childrens_Info[Convert.ToInt32(j) - 1].OutPut_Info();
                    double[] row = new double[infoAbutChild.Length - 3];
                    for (int k = 0; k < infoAbutChild.Length - 3; k++)
                        row[k] = Convert.ToDouble(infoAbutChild[k + 3]);
                    for (int j2 = 0; j2 < row.Length; j2++)
                    {
                        if (Form1.Properties != null && Form1.Properties.Contains(j2 - 3))
                            ResultsClustList.Items[index_item].SubItems[j2].Font = new System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold);

                        double[] diapason = Kohanen_Func.selectedPropNormal(j2, row[1], row[0]);

                        if (diapason != null) 
                        {
                            if (j2 <= 9)
                            {
                                if (row[j2 + 4] < diapason[0])
                                    if (Math.Abs(row[j2 + 4] - diapason[0]) <= 1.5)
                                        ResultsClustList.Items[index_item].SubItems[j2 + 7].BackColor = System.Drawing.Color.FromArgb(255, 250, 151);
                                    else
                                        ResultsClustList.Items[index_item].SubItems[j2 + 7].BackColor = System.Drawing.Color.FromArgb(254, 222, 95);
                                else if (row[j2 + 4] > diapason[1])
                                {
                                    if (Math.Abs(row[j2 + 4] - diapason[1]) <= 1.5)
                                        ResultsClustList.Items[index_item].SubItems[j2 + 7].BackColor = System.Drawing.Color.FromArgb(255, 138, 138);
                                    else
                                        ResultsClustList.Items[index_item].SubItems[j2 + 7].BackColor = System.Drawing.Color.FromArgb(255, 55, 55);
                                }
                                else
                                    ResultsClustList.Items[index_item].SubItems[j2 + 7].BackColor = System.Drawing.Color.FromArgb(90, 255, 87);
                            }
                            else if (j2 <= 27)
                            {
                                if (row[j2 + 4] > diapason[0] && row[j2 + 4] < diapason[1])
                                    ResultsClustList.Items[index_item].SubItems[j2 + 7].BackColor = System.Drawing.Color.FromArgb(90, 255, 87);
                                else
                                    ResultsClustList.Items[index_item].SubItems[j2 + 7].BackColor = System.Drawing.Color.FromArgb(255, 55, 55);
                            }
                            else if (j2 <= 33)
                            {
                                if (ResultsClustList.Items[index_item].SubItems[j2 + 6].BackColor == System.Drawing.Color.FromArgb(255, 55, 55) || j2 == 28 || j2 == 31)
                                {
                                    if (row[j2 + 4] > diapason[0] && row[j2 + 4] < diapason[1])
                                        ResultsClustList.Items[index_item].SubItems[j2 + 7].BackColor = System.Drawing.Color.FromArgb(90, 255, 87);
                                    else
                                        ResultsClustList.Items[index_item].SubItems[j2 + 7].BackColor = System.Drawing.Color.FromArgb(255, 55, 55);
                                }
                            }
                        }

                    }
                    index_item++;
                    data[i, 0] = Convert.ToDouble(Childrens_Info[Convert.ToInt32(j) - 1].OutPut_Info()[3]);
                    data[i, 1] = Convert.ToDouble(Childrens_Info[Convert.ToInt32(j) - 1].OutPut_Info()[4]);
                    data[i, 2] = Convert.ToDouble(Childrens_Info[Convert.ToInt32(j) - 1].OutPut_Info()[5]);
                    data[i, 3] = Convert.ToDouble(Childrens_Info[Convert.ToInt32(j) - 1].OutPut_Info()[6]);
                    for (int k = 0; k < row.Length; k++)
                        data[i, k] = row[k];
                    i++;
                }
                
                string[] info = new string[] { "В норме", "Незначительно ниже", "Значительно ниже", "Немного выше", "Значительно выше" };
                ResultsClustList.Items.Add(new ListViewItem(info));
                ResultsClustList.Items[index_item].UseItemStyleForSubItems = false;
                ResultsClustList.Items[index_item].SubItems[0].BackColor = System.Drawing.Color.FromArgb(90, 255, 87);
                ResultsClustList.Items[index_item].SubItems[1].BackColor = System.Drawing.Color.FromArgb(255, 250, 151);
                ResultsClustList.Items[index_item].SubItems[2].BackColor = System.Drawing.Color.FromArgb(254, 222, 95);
                ResultsClustList.Items[index_item].SubItems[3].BackColor = System.Drawing.Color.FromArgb(255, 138, 138);
                ResultsClustList.Items[index_item].SubItems[4].BackColor = System.Drawing.Color.FromArgb(255, 55, 55);
                string[] avarage = new string[childcount];
                avarage[0] = "Средние значения";
                avarage[1] = "-";
                avarage[2] = "-";
                double[] avarage_data = Avarage(data);
                for (int j = 0; j < childcount - 3; j++)
                {
                    avarage[j + 3] = Math.Round(avarage_data[j], 4).ToString();
                }
                ResultsClustList.Items.Add(new ListViewItem(avarage));
                string[] normalization_despersion = normalizationDespersion(numChild);
                ResultsClustList.Items.Add(new ListViewItem(normalization_despersion));
                /*string[] despersion = Despersion(numChild, avarage);*/
                ResultsClustList.Items.Add(new ListViewItem(/*despersion*/));
                ResultsClustList.EndUpdate();
            }
            
        }

        public double[] Avarage(double[,] x)
        {
            double[] avarage = new double[x.GetLength(1)];
            for (int i = 0; i < x.GetLength(1); i++)
                avarage[i] = 0;

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                    avarage[j] += (Double.IsNaN(x[i, j])) ? 0 : x[i, j];
            }
            for (int i = 0; i < x.GetLength(1); i++)
                avarage[i] /= x.GetLength(0);
            return avarage;
        }

/*        public string[] Despersion(string[] numChild, string[] avarage)
        {
            int childcount = ResultsClustList.Columns.Count;
            string[] despersion = new string[childcount];
            despersion[0] = "Дисперсия";
            despersion[1] = "-";
            despersion[2] = "-";
            double[] despers_var = new double[childcount - 3];
            for (int j = 0; j < numChild.Length; j++)
            {
                int number = Convert.ToInt32(numChild[j]);
                double[] row = new double[childcount-3];
                for (int i = 0; i < childcount - 3; i++)
                    row[i] = Convert.ToDouble(Childrens_Info[number - 1].OutPut_Info()[i + 3]);
                row[0] = Convert.ToDouble(Childrens_Info[number - 1].OutPut_Info()[3]);

                for (int k = 0; k < childcount - 3; k++)
                {
                    double variable = row[k];
                    despers_var[k] += (variable - Convert.ToDouble(avarage[k + 3])) * (variable - Convert.ToDouble(avarage[k + 3]));
                }
            }
            for (int j = 0; j < childcount - 3; j++)
            {
                despersion[j + 3] = Math.Round((despers_var[j] / numChild.Length), 4).ToString();
            }
            return despersion;
        }*/

        public string[] normalizationDespersion(string[] numChild)
        {
            int childcount = ResultsClustList.Columns.Count;
            string[] despersion = new string[childcount];
            despersion[0] = "Нормализованная дисперсия";
            despersion[1] = "-";
            despersion[2] = "-";
            double[,] despersion_data = new double[numChild.Length, childcount - 3];
            for (int i = 0; i < numChild.Length; i++)
            {
                int number = Convert.ToInt32(numChild[i]) - 1;
                string[] row = Childrens_Info[number].OutPut_Info();
                for (int j = 0; j < childcount - 3; j++)
                    despersion_data[i, j] = (Double.IsNaN(Convert.ToDouble(row[j + 3]))) ? 0 : Convert.ToDouble(row[j + 3]);
            }
            despersion_data = Kohanen_Func.neuroStart(despersion_data);
            double[] avarage = Avarage(despersion_data);
            double[] despers_var = new double[despersion_data.GetLength(1)];
            for (int i = 0; i < despersion_data.GetLength(1); i++)
                despers_var[i] = 0;
            for (int i = 0; i < despersion_data.GetLength(0); i++)
            {
                for (int j = 0; j < despersion_data.GetLength(1); j++)
                    despers_var[j] += (despersion_data[i, j] - avarage[j]) * (despersion_data[i, j] - avarage[j]);
            }
            for (int i = 0; i < despersion_data.GetLength(1); i++)
            {
                if (!Double.IsNaN(despers_var[i]) && !Double.IsInfinity(despers_var[i]))
                    despersion[i + 3] = Math.Round((despers_var[i] / numChild.Length), 4).ToString();
                else
                    despersion[i + 3] = "0";

            }
            return despersion;
        }

        private void DataTransferBtn_Click(object sender, EventArgs e)
        {
            if (cBoxNumCluster.SelectedItem == null)
                MessageBox.Show("Кластер не был выведен");
            else
            {
                var argeemant = MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (argeemant == DialogResult.Yes)
                {
                    string[] numChild = ChildForClusters[cBoxNumCluster.SelectedIndex].Trim(' ').Split(' ');
                    Kohanen_Data[] New_Childs_List = new Kohanen_Data[ResultsClustList.Items.Count - 4];
                    for (int i = 0; i < numChild.Length; i++)
                        New_Childs_List[i] = Childrens_Info[Convert.ToInt32(numChild[i]) - 1];
                    if (Form1.v != 0)
                        Form1.New_Childrens_Info = New_Childs_List;
                    else
                    {
                        Kohanen_Data[] Old_Childs_List = Form1.Childrens_Info;
                        Kohanen_Data[] Combine_Of_Lists = new Kohanen_Data[Old_Childs_List.Length + New_Childs_List.Length];
                        for (int j = 0; j < Old_Childs_List.Length; j++)
                            Combine_Of_Lists[j] = Old_Childs_List[j];
                        for (int j = 0; j < New_Childs_List.Length; j++)
                            Combine_Of_Lists[j + Old_Childs_List.Length] = New_Childs_List[j];
                        Form1.New_Childrens_Info = Combine_Of_Lists;
                    }
                }
            }
        }

        private void tStripBtnExportData_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xls*", ValidateNames = true, FileName = cBoxNumCluster.Text })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Interactive = false;
                    app.Visible = false;
                    for (int i = 0; i < ResultsClustList.Columns.Count; i++)
                        ws.Cells[1, i+1] = ResultsClustList.Columns[i].Text;
                    int k = 2;
                    foreach (ListViewItem item in ResultsClustList.Items)
                    {
                        for (int i = 0; i < item.SubItems.Count; i++)
                            ws.Cells[k, i + 1] = item.SubItems[i].Text.Replace(',','.');
                        k++;
                    }
                    wb.SaveAs(saveFileDialog.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Данные были успешно сохранены в файл\n" + saveFileDialog.FileName);
                }
            }
        }

        private void OutputData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cBoxNumCluster.SelectedItem != null)
                Form1.SelectedСluster = cBoxNumCluster.SelectedIndex;
        }

        private void DeleteTStripMenuItm_Click(object sender, EventArgs e)
        {
            ResultsClustList.FocusedItem.Remove();
        }
    }
}
