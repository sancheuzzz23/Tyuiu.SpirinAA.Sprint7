using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;
using Tyuiu.SpirinAA.Sprint7.Project.V1.Lib;

namespace Tyuiu.SpirinAA.Sprint7.Project.V1
{
    public partial class FormMain_SAA : Form
    {
        public FormMain_SAA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;

        private void aboutProgramToolStripMenuItem_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта программа содержит в себе данные:\r* О заказах клиентов(Номер водительских прав, ФИО, Номер телефона владельца автомобиля, Марка, Мощность автомобиля, Цвет автомобиля)", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_SAA_Click(object sender, EventArgs e)
        {
            openFileDialogTable_SAA.ShowDialog();
            openFilePath = openFileDialogTable_SAA.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewTableOrders_SAA.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewTableOrders_SAA.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewTableOrders_SAA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
        }

        private void buttonDownload_SAA_Click(object sender, EventArgs e)
        {
            saveFileDialogTable_SAA.FileName = "DataBase.csv";
            saveFileDialogTable_SAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTable_SAA.ShowDialog();


            string path = saveFileDialogTable_SAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewTableOrders_SAA.RowCount;
            int columns = dataGridViewTableOrders_SAA.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewTableOrders_SAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewTableOrders_SAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }


        private void buttonAdd_SAA_Click(object sender, EventArgs e)
        {
            dataGridViewTableOrders_SAA.Rows.Add();
        }

        private void buttonInfo_SAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void toolStripMenuItemExit_SAA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemoveRows_SAA_Click(object sender, EventArgs e)
        {
            int ind = dataGridViewTableOrders_SAA.SelectedCells[0].RowIndex;
            dataGridViewTableOrders_SAA.Rows.RemoveAt(ind);
        }

        private void buttonSearch_SAA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewTableOrders_SAA.RowCount; i++)
            {
                dataGridViewTableOrders_SAA.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewTableOrders_SAA.ColumnCount; j++)
                    if (dataGridViewTableOrders_SAA.Rows[i].Cells[j].Value != null)
                        if (dataGridViewTableOrders_SAA.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch_SAA.Text))
                        {
                            dataGridViewTableOrders_SAA.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void textBoxSearch_SAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewTable_SAA_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.dataGridViewTableOrders_SAA.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridViewTableOrders_SAA.Rows[index].HeaderCell.Value = indexStr;
        }
    }
}
