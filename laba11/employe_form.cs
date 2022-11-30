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
    public partial class employe_form : Form
    {
        Employee user;
        public employe_form(Employee employee)
        {
            InitializeComponent();
            user = employee;
            //
            if (System.IO.File.Exists(@"\lab10\facul.inf") == false)
                System.IO.File.WriteAllLines(@"\lab10\facul.inf", new string[] { "ФИСИС", "ФЭМИТ", "ФИТКБ", "ФМАТ", "ФГЕО" });
            if (System.IO.File.Exists(@"\lab10\jobs.inf") == false)
                System.IO.File.WriteAllLines(@"\lab10\jobs.inf", new string[] { "Ст. преподаватель", "Лектор", "Лаборант", "Доцент", "Профессор" });
            facultyBox.Items.AddRange(System.IO.File.ReadAllLines(@"\lab10\facul.inf"));
            worker_box.Items.AddRange(System.IO.File.ReadAllLines(@"\lab10\jobs.inf"));
        }

        private void employe_form_Load(object sender, EventArgs e)
        {
            name_box.Text = user.Name;
            surname_box.Text = user.Surname;
            patronim_box.Text = user.Patronim;
            GenderBox.SelectedIndex = (int)user.Gender;
            worker_box.SelectedIndex = (int)user.Worker;
            facultyBox.SelectedIndex = (int)user.FacultyID;
            birth_box.Value = user.Birth;
        }

        private void employe_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
