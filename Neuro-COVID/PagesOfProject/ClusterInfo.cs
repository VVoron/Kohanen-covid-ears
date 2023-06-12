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
    public partial class ClusterInfo : Form
    {
        public ClusterInfo(string[] data, int number)
        {
            InitializeComponent();
            info = data;
            this.Text = number.ToString() + " Кластер";
        }

        string[] info;

        private void ClusterInfo_Load(object sender, EventArgs e)
        {
            var _point = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y);
            this.Top = _point.Y;
            this.Left = _point.X;
            for (int i = 0; i < info.Length; i++)
            {
                string[] item = info[i].Split(':');
                listView1.Items.Add(new ListViewItem(item));
            }
            listView1.Columns[0].Width = -1;
            this.Width = listView1.Columns[0].Width + 80;
            this.Height = (info.Length + 1) * 25 + 30;
        }
    }
}
