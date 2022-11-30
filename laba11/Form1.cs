using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void register_butt_Click(object sender, EventArgs e)
        {
            register reg = new register();
            this.Hide();
            reg.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthManager mgr = new AuthManager();
            try
            {
                mgr.Log_In(login_box.Text.Trim(), pass_box.Text.Trim());
                //this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка входа!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                pass_box.PasswordChar = '\0';
            }
            else
            {
                pass_box.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы вошли как гость!", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
