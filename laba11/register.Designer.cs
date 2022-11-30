namespace laba11
{
    partial class register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.worker_box = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.birth_box = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.patronim_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.surname_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.facultyBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.re_pass_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.login_box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.usertype_box = new System.Windows.Forms.ComboBox();
            this.employee_box = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subjects_box = new System.Windows.Forms.ListBox();
            this.dir_box = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.employee_box.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // worker_box
            // 
            this.worker_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.worker_box.FormattingEnabled = true;
            this.worker_box.Location = new System.Drawing.Point(4, 34);
            this.worker_box.Name = "worker_box";
            this.worker_box.Size = new System.Drawing.Size(272, 33);
            this.worker_box.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(6, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(579, 43);
            this.button1.TabIndex = 47;
            this.button1.Text = "Создать учётную запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(313, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Дата рождения";
            // 
            // birth_box
            // 
            this.birth_box.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birth_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birth_box.Location = new System.Drawing.Point(317, 285);
            this.birth_box.Name = "birth_box";
            this.birth_box.Size = new System.Drawing.Size(272, 31);
            this.birth_box.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(313, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Пол";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(0, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Факультет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(0, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(313, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Отчество";
            // 
            // patronim_box
            // 
            this.patronim_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronim_box.Location = new System.Drawing.Point(317, 159);
            this.patronim_box.Name = "patronim_box";
            this.patronim_box.Size = new System.Drawing.Size(272, 38);
            this.patronim_box.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(313, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Фамилия";
            // 
            // surname_box
            // 
            this.surname_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_box.Location = new System.Drawing.Point(317, 29);
            this.surname_box.Name = "surname_box";
            this.surname_box.Size = new System.Drawing.Size(272, 38);
            this.surname_box.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(313, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Имя";
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_box.Location = new System.Drawing.Point(317, 93);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(272, 38);
            this.name_box.TabIndex = 36;
            // 
            // GenderBox
            // 
            this.GenderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.GenderBox.Location = new System.Drawing.Point(317, 223);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(272, 33);
            this.GenderBox.TabIndex = 35;
            // 
            // facultyBox
            // 
            this.facultyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultyBox.FormattingEnabled = true;
            this.facultyBox.Location = new System.Drawing.Point(4, 98);
            this.facultyBox.Name = "facultyBox";
            this.facultyBox.Size = new System.Drawing.Size(272, 33);
            this.facultyBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Повторить пароль";
            // 
            // re_pass_box
            // 
            this.re_pass_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.re_pass_box.Location = new System.Drawing.Point(9, 152);
            this.re_pass_box.Name = "re_pass_box";
            this.re_pass_box.PasswordChar = '*';
            this.re_pass_box.Size = new System.Drawing.Size(272, 38);
            this.re_pass_box.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Логин";
            // 
            // pass_box
            // 
            this.pass_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_box.Location = new System.Drawing.Point(9, 91);
            this.pass_box.Name = "pass_box";
            this.pass_box.PasswordChar = '*';
            this.pass_box.Size = new System.Drawing.Size(272, 38);
            this.pass_box.TabIndex = 29;
            // 
            // login_box
            // 
            this.login_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_box.Location = new System.Drawing.Point(9, 30);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(272, 38);
            this.login_box.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "Тип пользователя";
            // 
            // usertype_box
            // 
            this.usertype_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usertype_box.FormattingEnabled = true;
            this.usertype_box.Items.AddRange(new object[] {
            "Абитуриент",
            "Преподаватель"});
            this.usertype_box.Location = new System.Drawing.Point(10, 221);
            this.usertype_box.Name = "usertype_box";
            this.usertype_box.Size = new System.Drawing.Size(272, 33);
            this.usertype_box.TabIndex = 49;
            this.usertype_box.SelectedIndexChanged += new System.EventHandler(this.usertype_box_SelectedIndexChanged);
            // 
            // employee_box
            // 
            this.employee_box.Controls.Add(this.label7);
            this.employee_box.Controls.Add(this.facultyBox);
            this.employee_box.Controls.Add(this.label8);
            this.employee_box.Controls.Add(this.worker_box);
            this.employee_box.Location = new System.Drawing.Point(317, 322);
            this.employee_box.Name = "employee_box";
            this.employee_box.Size = new System.Drawing.Size(281, 142);
            this.employee_box.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dir_box);
            this.panel1.Controls.Add(this.subjects_box);
            this.panel1.Location = new System.Drawing.Point(9, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 341);
            this.panel1.TabIndex = 52;
            // 
            // subjects_box
            // 
            this.subjects_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjects_box.FormattingEnabled = true;
            this.subjects_box.ItemHeight = 20;
            this.subjects_box.Location = new System.Drawing.Point(4, 25);
            this.subjects_box.Name = "subjects_box";
            this.subjects_box.Size = new System.Drawing.Size(269, 104);
            this.subjects_box.TabIndex = 0;
            // 
            // dir_box
            // 
            this.dir_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dir_box.FormattingEnabled = true;
            this.dir_box.ItemHeight = 20;
            this.dir_box.Location = new System.Drawing.Point(4, 194);
            this.dir_box.Name = "dir_box";
            this.dir_box.Size = new System.Drawing.Size(269, 104);
            this.dir_box.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Результаты ЕГЭ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(3, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Направления подготовки";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Информационные системы и технологии",
            "Прикладная математика",
            "Отраслевая химическая промышленность",
            "Дизайн",
            "Адвокат",
            "Политолог"});
            this.comboBox1.Location = new System.Drawing.Point(4, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 28);
            this.comboBox1.TabIndex = 49;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 28);
            this.button2.TabIndex = 50;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 28);
            this.button3.TabIndex = 51;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Физика",
            "Математика",
            "Русский язык",
            "Английский язык",
            "Химия",
            "Биология",
            "Обществознание",
            "История"});
            this.comboBox2.Location = new System.Drawing.Point(3, 132);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 28);
            this.comboBox2.TabIndex = 52;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(187, 133);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 26);
            this.numericUpDown1.TabIndex = 53;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.employee_box);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.usertype_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.birth_box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.patronim_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.surname_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.re_pass_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.login_box);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.employee_box.ResumeLayout(false);
            this.employee_box.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox worker_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker birth_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox patronim_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surname_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.ComboBox facultyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox re_pass_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox usertype_box;
        private System.Windows.Forms.Panel employee_box;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox dir_box;
        private System.Windows.Forms.ListBox subjects_box;
    }
}