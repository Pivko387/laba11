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
    public partial class register : Form
    {
        List<Subject> subjects = new List<Subject>();
        List<short> dirs = new List<short>();
        public register()
        {
            InitializeComponent();
            usertype_box.SelectedIndex = 0;
            if (System.IO.File.Exists(@"\lab10\facul.inf") == false)
                System.IO.File.WriteAllLines(@"\lab10\facul.inf", new string[] { "ФИСИС", "ФЭМИТ", "ФИТКБ", "ФМАТ", "ФГЕО" });
            if (System.IO.File.Exists(@"\lab10\jobs.inf") == false)
                System.IO.File.WriteAllLines(@"\lab10\jobs.inf", new string[] { "Ст. преподаватель", "Лектор", "Лаборант", "Доцент", "Профессор" });
            facultyBox.Items.AddRange(System.IO.File.ReadAllLines(@"\lab10\facul.inf"));
            worker_box.Items.AddRange(System.IO.File.ReadAllLines(@"\lab10\jobs.inf"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var auth_mgr = new AuthManager();
            User user;
            if (login_box.Text.Trim() != "" && System.IO.File.Exists(@"\lab10\users\" + login_box.Text.Trim() + ".acc") == false)
            {
                if (pass_box.Text.Trim() != "" && re_pass_box.Text.Trim() != "" && name_box.Text.Trim() != ""
                    && surname_box.Text.Trim() != "" && patronim_box.Text.Trim() != "" && GenderBox.SelectedIndex >= 0 && birth_box.Value < System.DateTime.Now)
                {
                    if (pass_box.Text.Trim() == re_pass_box.Text.Trim() && pass_box.Text.Trim().Length >= 8)
                    {

                        if (usertype_box.SelectedIndex == 0)
                        {
                            var abitur = new Abiturient(login_box.Text.Trim(), pass_box.Text.Trim(), name_box.Text.Trim(),
                                surname_box.Text.Trim(), patronim_box.Text.Trim(), (short)GenderBox.SelectedIndex, birth_box.Value);
                            foreach(var i in subjects)
                            {
                                try
                                {
                                    abitur.AddSubject(i);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    break;
                                }
                            }
                            foreach (var i in dirs)
                            {
                                try
                                {
                                    abitur.AddDirection(i);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                    break;
                                }
                            }
                            user = abitur;
                        }
                        else
                        {
                            user = new Employee(login_box.Text.Trim(), pass_box.Text.Trim(), name_box.Text.Trim(),
                                surname_box.Text.Trim(), patronim_box.Text.Trim(), (short)GenderBox.SelectedIndex,
                                (short)facultyBox.SelectedIndex, birth_box.Value, (short)worker_box.SelectedIndex);
                        }
                        auth_mgr.Register(user);
                        this.Close();
                    }
                    else { MessageBox.Show("Ошибка при вводе пароля: должен содержать не менее 8 символов, либо пароли не совпадают."); }
                }
                else { MessageBox.Show("Все поля должны быть заполены корректно!", "Ошибка!"); }
            }
            else { MessageBox.Show("Такой пользователь уже существует!", "Ошибка!"); }
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            subjects.Add(new Subject(comboBox2.SelectedItem.ToString(),(int)numericUpDown1.Value));
            subjects_box.Items.Add(comboBox2.SelectedItem.ToString() + "\t" + numericUpDown1.Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dirs.Add((short)comboBox1.SelectedIndex);
            dir_box.Items.Add(comboBox1.SelectedItem.ToString());
        }

        private void usertype_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(usertype_box.SelectedIndex==0)
            {
                panel1.Visible = true;
                employee_box.Visible = false;
            }
            if (usertype_box.SelectedIndex == 1)
            {
                panel1.Visible = false;
                employee_box.Visible = true;
            }
        }
    }
}
