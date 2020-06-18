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
    public partial class FileList : Form
    {
        public FileList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.Text = folderBrowserDialog.SelectedPath;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListBox.Items.Clear();

            if (Directory.Exists(this.Text))
            {
                string[] stringArray = Directory.GetFiles(this.Text, "*" + textBox.Text + "*", SearchOption.AllDirectories);
                for (int i = 0; i < stringArray.Length; i++)
                {
                    ListBox.Items.Add(stringArray[i]);
                }
            }
        }
    }
}
