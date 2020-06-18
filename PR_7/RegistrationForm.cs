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

namespace PR_7
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            {
                if(loginCheck(loginTextBox.Text))
                {
                    MessageBox.Show("Данный пользователь уже существует");
                }
                else
                {
                    MessageBox.Show("Пользователь удачно зарегистрирован");
                    using (BinaryWriter writer = new BinaryWriter(File.Open(@"..\logins.dat", FileMode.OpenOrCreate)))

                    {
                        writer.Write(loginTextBox.Text);
                        writer.Write(passwordTextBox.Text);
                        writer.Write(Convert.ToInt32(ageTextBox.Text));

                    }
                }

            }
        }
        private bool loginCheck(string login)
        {
            using (BinaryReader reader= new BinaryReader(File.Open(@"..\logins.dat", FileMode.Open)))
            {
                while (reader.PeekChar()> -1)
                {
                    string savelogin = reader.ReadString();
                    string passsword= reader.ReadString();
                    int age = reader.ReadInt32();

                    if(savelogin==login)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
