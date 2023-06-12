using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Neuro_COVID.PagesOfProject
{
    public partial class ClusterDiagrams : Form
    {
        public ClusterDiagrams()
        {
            InitializeComponent();
        }

        Kohanen_Data[] Childrens_Info;
        Kohanen_Func Kohanen_Func = new Kohanen_Func();
        string[] clasters_info;

        private void ClusterDiagrams_Load(object sender, EventArgs e)
        {
            zGControlNumClusters.GraphPane.Title.Text = "";
            zGControlNumClusters.GraphPane.XAxis.Title.Text = "";
            zGControlNumClusters.GraphPane.YAxis.Title.Text = "";

            zGControlProp.GraphPane.Title.Text = "";
            zGControlProp.GraphPane.XAxis.Title.Text = "";
            zGControlProp.GraphPane.YAxis.Title.Text = "";

            if (Form1.Childrens_Info != null)
            {
                Childrens_Info = Form1.Childrens_Info;
                toolStrip1.Enabled = true;
            }
            else
                toolStrip1.Enabled = false;
            if (Form1.ClastersInfo != null)
            {
                clasters_info = Form1.ClastersInfo;
                GraphPane pane = zGControlNumClusters.GraphPane;
                pane.CurveList.Clear();
                int items_count = clasters_info.Length;
                double[] XValues = new double[items_count];
                double[] YValues = new double[items_count];
                Console.WriteLine(items_count);
                for (int i = 0; i < items_count; i++)
                {
                    XValues[i] = i + 1;
                    lViewAllInfo.Columns.Add(XValues[i].ToString() + " Кластер");

                    YValues[i] = clasters_info[i].Trim(' ').Split(' ').Length;
                }
                BarItem barNumbers = pane.AddBar("Количество", XValues, YValues, Color.Green);

                pane.BarSettings.MinClusterGap = 2.5f;

                pane.Title.Text = "Количество примеров в кластерах";
                pane.XAxis.Title.Text = "Номер кластера";
                pane.YAxis.Title.Text = "Количество";

                pane.YAxis.MajorGrid.IsVisible = true;

                pane.YAxis.MajorGrid.DashOn = 10;
                pane.YAxis.MajorGrid.DashOff = 5;

                pane.YAxis.MinorGrid.IsVisible = true;

                pane.YAxis.MinorGrid.DashOn = 1;
                pane.YAxis.MinorGrid.DashOff = 2;

                zGControlNumClusters.AxisChange();
                zGControlNumClusters.Invalidate();

                for (int i = 0; i < Kohanen_Func.colomnsData().Count - 3; i++)
                {
                    string[] info = new string[items_count + 1];
                    info[0] = Kohanen_Func.colomnsData()[i + 3];
                    double[] avarage = avarageOfProp(i);
                    for (int j = 0; j < avarage.Length; j++)
                        info[j + 1] = Math.Round(avarage[j], 4).ToString();
                    lViewAllInfo.Items.Add(new ListViewItem(info));
                }
                lViewAllInfo.Columns[0].Width = -1;
            }

        }

        private void tStripBtnWatch_Click(object sender, EventArgs e)
        {
            if (listBoxProp.SelectedIndex != -1)
            {
                double[] YValues = new double[clasters_info.Length];
                if (listBoxMassProp.SelectedIndex == 0)
                    YValues = avarageOfProp(listBoxProp.SelectedIndex);
                else if (listBoxMassProp.SelectedIndex == 1)
                    YValues = despersionOfProp(listBoxProp.SelectedIndex);
                else if (listBoxMassProp.SelectedIndex == 2)
                    YValues = normalDespersionOfProp(listBoxProp.SelectedIndex);

                GraphPane pane = zGControlProp.GraphPane;
                pane.CurveList.Clear();
                int items_count = clasters_info.Length;
                double[] XValues = new double[items_count];
                for (int i = 0; i < items_count; i++)
                    XValues[i] = i + 1;
                BarItem barNumbers = pane.AddBar("Значения", XValues, YValues, Color.Green);

                pane.BarSettings.MinClusterGap = 2.5f;

                pane.Title.Text = listBoxProp.SelectedItem.ToString();
                pane.XAxis.Title.Text = "Номер кластера";
                pane.YAxis.Title.Text = "Значение";

                pane.YAxis.MajorGrid.IsVisible = true;

                pane.YAxis.MajorGrid.DashOn = 10;
                pane.YAxis.MajorGrid.DashOff = 5;

                pane.YAxis.MinorGrid.IsVisible = true;

                pane.YAxis.MinorGrid.DashOn = 1;
                pane.YAxis.MinorGrid.DashOff = 2;

                zGControlProp.AxisChange();
                zGControlProp.Invalidate();
            }
        }

        public double[] avarageOfProp(int selected_prop)
        {
            Console.WriteLine(clasters_info.Length);
            double[] avarage = new double[clasters_info.Length];
            for (int i = 0; i < clasters_info.Length; i++)
            {
                string[] numbers = clasters_info[i].Trim(' ').Split(' ');
                for (int j = 0; j < numbers.Length; j++)
                {
                    double param = Convert.ToDouble(Childrens_Info[Convert.ToInt32(numbers[j]) - 1].OutPut_Info()[selected_prop + 3]);
                    avarage[i] += (Double.IsNaN(param)) ? 0 : param;
                }
                avarage[i] /= numbers.Length;
            }
            return avarage;
        }

        public double[] despersionOfProp(int selected_prop)
        {
            double[] despersion = new double[clasters_info.Length];
            double[] avarage = avarageOfProp(selected_prop);
            for (int i = 0; i < clasters_info.Length; i++)
            {
                string[] numbers = clasters_info[i].Trim(' ').Split(' ');
                for (int j = 0; j < numbers.Length; j++)
                {
                    double param = (Convert.ToDouble(Childrens_Info[Convert.ToInt32(numbers[j]) - 1].OutPut_Info()[selected_prop + 3]));
                    param = (Double.IsNaN(param)) ? 0 : param;
                    despersion[i] += (param - avarage[i]) *
                        (param - avarage[i]);
                }
                despersion[i] /= numbers.Length;
            }
            return despersion;
        }

        public double[] normalDespersionOfProp(int selected_prop)
        {
            double[] despersion = new double[clasters_info.Length];
            for (int i = 0; i < clasters_info.Length; i++)
            {
                string[] numbers = clasters_info[i].Trim(' ').Split(' ');
                double[,] data = new double[numbers.Length, 1];
                for (int j = 0; j < numbers.Length; j++)
                {
                    double param = Convert.ToDouble(Childrens_Info[Convert.ToInt32(numbers[j]) - 1].OutPut_Info()[selected_prop + 3]);
                    data[j, 0] = (Double.IsNaN(param)) ? 0 : param;
                }
                data = Kohanen_Func.neuroStart(data);
                double avarage = 0;
                for (int j = 0; j < numbers.Length; j++)
                    avarage += data[j, 0];
                avarage /= numbers.Length;
                for (int j = 0; j < numbers.Length; j++)
                    despersion[i] += (data[j, 0] - avarage) * (data[j, 0] - avarage);
                despersion[i] /= numbers.Length;
            }
            return despersion;
        }

        private void zGControlNumClusters_MouseClick(object sender, MouseEventArgs e)
        {
            double x, y;
            zGControlNumClusters.GraphPane.ReverseTransform(e.Location, out x, out y);
            int cluster_number = Convert.ToInt32(Math.Round(x));
            Console.WriteLine(cluster_number);
            if (cluster_number >= 1 && cluster_number <= clasters_info.Length && y <= clasters_info[cluster_number - 1].Trim(' ').Split(' ').Length && Math.Abs(x - cluster_number) < 0.2)
            {
                string[] info;
                int[] properties = Form1.Properties;
                if (properties != null)
                {
                    info = new string[properties.Length + 1];
                    info[0] = "Количество:" + clasters_info[cluster_number - 1].Trim(' ').Split(' ').Length;
                    for (int i = 0; i < properties.Length; i++)
                    {
                        info[i + 1] = Kohanen_Func.colomnsData()[properties[i] + 3] + ":" + Math.Round(avarageOfProp(properties[i] + 4)[cluster_number - 1], 4);
                    }
                }
                else
                {
                    info = new string[Kohanen_Func.colomnsData().Count - 6];
                    info[0] = "Количество:" + clasters_info[cluster_number - 1].Trim(' ').Split(' ').Length;
                    for (int i = 0; i < Kohanen_Func.colomnsData().Count - 3; i++)
                        info[i + 1] = Kohanen_Func.colomnsData()[i + 3] + ":" + Math.Round(avarageOfProp(i + 4)[cluster_number - 1],4);
                }
                Form show_info = new PagesOfProject.ClusterInfo(info, cluster_number);
                show_info.Show();
            }
        }
    }
}
