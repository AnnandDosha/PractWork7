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

namespace PR_7
{
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстовый файл|*.txt|Файл формата цсв|*.csv";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.GetEncoding(1251)))
                {
                    for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                    {
                        writer.WriteLine(dataGridView[0, i].Value.ToString() + ";" + dataGridView[1, i].Value.ToString() + ";" + dataGridView[2, i].Value.ToString() + ";");
                    }
                }
            }
        }
    }
}
