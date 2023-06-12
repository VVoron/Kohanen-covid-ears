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

namespace Neuro_COVID.PagesOfProject
{
    public partial class InputDataPage : Form
    {
        public InputDataPage()
        {
            InitializeComponent();
        }
        private void InputDataPage_Load(object sender, EventArgs e)
        {
            List<string> colomns = Kohanen_Func.colomnsData();
            foreach(string colomn in colomns)
                ChildsList.Columns.Add(colomn);
            if (Form1.New_Childrens_Info != null || Form1.Childrens_Info != null)
            {
                Kohanen_Data[] Childrens_Info = null;
                if (Form1.New_Childrens_Info == null)
                    Childrens_Info = Form1.Childrens_Info;
                else
                    Childrens_Info = Form1.New_Childrens_Info;
                foreach (Kohanen_Data child in Childrens_Info)
                {
                    ChildsList.Items.Add(new ListViewItem(child.OutPut_Info()));
                    Console.WriteLine(child.OutPut_Info());
                }
            }
        }
        private void AddData_Click(object sender, EventArgs e)
        {
            if (DataOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = DataOpenFileDialog.FileName;
                ExcelPackage excelFile = new ExcelPackage(new FileInfo(filename));
                ExcelWorksheet worksheet = excelFile.Workbook.Worksheets[1];
                
                int new_N = worksheet.Dimension.End.Row;
                int new_M = worksheet.Dimension.End.Column;
                Kohanen_Data[] Childrens_Info = new Kohanen_Data[new_N - 3];
                int i = 0;
                for (int rowIndex = 4; rowIndex < new_N + 1; rowIndex++)
                {
                    IEnumerable<string> row = worksheet.Cells[rowIndex, 1, rowIndex, new_M].Select(c => c.Value == null ? "".ToString() : c.Value.ToString());
                    string[] list = row.ToArray();
                    Childrens_Info[i] = new Kohanen_Data(list);
                    i++;
                }
                foreach (Kohanen_Data childs in Childrens_Info)
                {
                    ChildsList.Items.Add(new ListViewItem(childs.OutPut_Info()));
                }
            }
        }

        private void InputDataPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Kohanen_Data[] New_Childs_List = new Kohanen_Data[ChildsList.Items.Count];
            int i = 0;
            foreach(ListViewItem item in ChildsList.Items)
            {
                string[] row = new string[item.SubItems.Count];
                for (int numElFromItem = 0; numElFromItem < item.SubItems.Count; numElFromItem++)
                    row[numElFromItem] = item.SubItems[numElFromItem].Text;
                New_Childs_List[i++] = new Kohanen_Data(row);
            }
            if (Form1.New_Childrens_Info == null)
                Form1.Childrens_Info = New_Childs_List;
        }

        private void DeleteTStripMenuItm_Click(object sender, EventArgs e)
        {
            ChildsList.FocusedItem.Remove();
        }

        private void ClearData_Click(object sender, EventArgs e)
        {
            ChildsList.Items.Clear();
        }
    }
}
