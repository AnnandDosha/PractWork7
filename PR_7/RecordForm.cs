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
using System.Drawing.Drawing2D;

namespace PR_7
{
    public partial class RecordForm : Form
    {
        public RecordForm()
        {
            InitializeComponent();
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            {
                using (StreamWriter writer = new StreamWriter(@"..\Notes.txt", true, Encoding.GetEncoding(1251)))
                    
                {
                    writer.WriteLine(DateTime.Now.ToString());
                    for (int i = 0; i < textBox.Lines.Length; i++)
                    {
                        
                        writer.WriteLine(textBox.Lines[i]);
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}
