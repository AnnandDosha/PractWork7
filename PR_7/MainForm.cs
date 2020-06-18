using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileList list = new FileList();
            list.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PurchaseForm purchase = new PurchaseForm();
            purchase.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RecordForm record = new RecordForm();
            record.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }
    }
}
