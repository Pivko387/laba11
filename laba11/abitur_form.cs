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
    public partial class abitur_form : Form
    {
        Abiturient abi;
        public abitur_form(Abiturient user)
        {
            InitializeComponent();
            abi = user;
        }

        private void abitur_form_Load(object sender, EventArgs e)
        {
            name_box.Text = abi.Name;
            surname_box.Text = abi.Surname;
            patronim_box.Text = abi.Patronim;
            GenderBox.SelectedIndex = (int)abi.Gender;
            birth_box.Value = abi.Birth;
            foreach(var i in abi.subjects)
            {
                subjects_box.Items.Add(i.Name + "\t" + i.Score.ToString());
            }
            foreach (var i in abi.directions)
            {
                dir_box.Items.Add(comboBox1.Items[i].ToString());
            }
        }

        private void abitur_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
