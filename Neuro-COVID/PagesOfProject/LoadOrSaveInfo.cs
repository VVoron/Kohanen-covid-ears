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

namespace Neuro_COVID.PagesOfProject
{
    public partial class LoadOrSaveInfo : Form
    {
        public LoadOrSaveInfo()
        {
            InitializeComponent();
            if (Form1.Childrens_Info == null)
                btnSave.Enabled = false;
        }

        private void btnChooseSave_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tBoxSave.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string text_in_file = Form1.Childrens_Info.Length.ToString() + '\n';
                for (int i = 0; i < Form1.Childrens_Info.Length; i++)
                {
                    string[] info = Form1.Childrens_Info[i].OutPut_Info();
                    for (int j = 0; j < info.Length - 1; j++)
                    {
                        text_in_file += info[j] + ";";
                    }
                    text_in_file += info[info.Length - 1] + "\n";
                }
                text_in_file += Form1.v.ToString() + '\n' + Form1.Rk.ToString() + '\n' + Form1.steps + '\n';
                if (Form1.w != null)
                {
                    text_in_file += Form1.w.GetLength(0).ToString() + '\n';
                    for (int i = 0; i < Form1.w.GetLength(0); i++)
                    {
                        for (int j = 0; j < Form1.w.GetLength(1) - 1; j++)
                        {
                            text_in_file += Form1.w[i, j].ToString() + ";";
                        }
                        text_in_file += Form1.w[i, Form1.w.GetLength(1) - 1].ToString() + '\n';
                    }
                }
                else
                    text_in_file += "None\n";
                //PROPERTIES
                if (Form1.Properties != null)
                {
                    for (int i = 0; i < Form1.Properties.Length - 1; i++)
                        text_in_file += Form1.Properties[i].ToString() + ';';
                    text_in_file += Form1.Properties[Form1.Properties.Length - 1].ToString() + '\n';
                }
                else
                    text_in_file += "None\n";

                //MOST PROPERTIES
                if (Form1.Koefs != null)
                {
                    for (int i = 0; i < Form1.Koefs.Length - 1; i++)
                        text_in_file += Form1.Koefs[i].ToString() + ';';
                    text_in_file += Form1.Koefs[Form1.Koefs.Length - 1].ToString() + '\n';
                }
                else
                    text_in_file += "None\n";

                //CLASTER INFO
                if (Form1.ClastersInfo != null)
                {
                    for (int i = 0; i < Form1.ClastersInfo.Length - 1; i++)
                        text_in_file += Form1.ClastersInfo[i] + ';';
                    text_in_file += Form1.ClastersInfo[Form1.ClastersInfo.Length - 1] + '\n';
                }
                else
                    text_in_file += "None\n";

                //SELECTED CLUSTER
                if (Form1.SelectedСluster != Double.NaN)
                    text_in_file += Form1.SelectedСluster.ToString();
                else
                    text_in_file += "None";
                File.WriteAllText(tBoxSave.Text + "\\" + DateTime.Now.ToString("HH-mm_dd-MM-yyyy") + ".txt", text_in_file);
                MessageBox.Show("Файл успешно сохранен");
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения файла");
            }
        }

        private void btnChooseLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tBoxLoad.Text = openFileDialog1.FileName;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader file = new StreamReader(tBoxLoad.Text, Encoding.UTF8))
                {
                    int num_of_Childs = Convert.ToInt32(file.ReadLine());
                    Form1.Childrens_Info = new Kohanen_Data[num_of_Childs];
                    for (int i = 0; i < num_of_Childs; i++)
                    {
                        string line = file.ReadLine();
                        Form1.Childrens_Info[i] = new Kohanen_Data(line.Split(';'));
                    }
                    Form1.v = Convert.ToDouble(file.ReadLine());
                    Form1.Rk = Convert.ToDouble(file.ReadLine());
                    Form1.steps = Convert.ToInt32(file.ReadLine());
                    string num = file.ReadLine();
                    if (num != "None")
                    {
                        int num_of_w = Convert.ToInt32(num);
                        string[] first_line = file.ReadLine().Split(';');
                        Form1.w = new double[num_of_w, first_line.Length];
                        for (int i = 0; i < first_line.Length; i++)
                            Form1.w[0, i] = Convert.ToDouble(first_line[i]);
                        for (int i = 1; i < num_of_w; i++)
                        {
                            string[] line = file.ReadLine().Split(';');
                            for (int j = 0; j < line.Length; j++)
                                Form1.w[i, j] = Convert.ToDouble(line[j]);
                        }
                    }

                    string propert_info = file.ReadLine();
                    if (propert_info != "None")
                    {
                        string[] propert = propert_info.Split(';');
                        Form1.Properties = new int[propert.Length];
                        for (int i = 0; i < propert.Length; i++)
                            Form1.Properties[i] = Convert.ToInt32(propert[i]);
                    }

                    string most_propert_info = file.ReadLine();
                    if (most_propert_info != "None")
                    {
                        string[] propert = most_propert_info.Split(';');
                        Form1.Koefs = new string[propert.Length];
                        for (int i = 0; i < propert.Length; i++)
                            Form1.Koefs[i] =propert[i];
                    }

                    string clust_info = file.ReadLine();
                    if (clust_info != "None")
                    {
                        Form1.ClastersInfo = clust_info.Split(';');
                    }
                    string selected_clust = file.ReadLine();
                    if (selected_clust != "None")
                        Form1.SelectedСluster = Convert.ToDouble(selected_clust);

                }
                MessageBox.Show("Загрузка прошла успешно");
            }
            catch
            {
                MessageBox.Show("Данные некорректны");
            }
        }
    }
}
