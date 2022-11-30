namespace laba11
{
    partial class abitur_form
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
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.patronim_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.surname_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dir_box = new System.Windows.Forms.ListBox();
            this.subjects_box = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.birth_box = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Пол";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Отчество";
            // 
            // patronim_box
            // 
            this.patronim_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronim_box.Location = new System.Drawing.Point(7, 159);
            this.patronim_box.Name = "patronim_box";
            this.patronim_box.ReadOnly = true;
            this.patronim_box.Size = new System.Drawing.Size(272, 38);
            this.patronim_box.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Фамилия";
            // 
            // surname_box
            // 
            this.surname_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_box.Location = new System.Drawing.Point(7, 29);
            this.surname_box.Name = "surname_box";
            this.surname_box.ReadOnly = true;
            this.surname_box.Size = new System.Drawing.Size(272, 38);
            this.surname_box.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Имя";
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_box.Location = new System.Drawing.Point(7, 93);
            this.name_box.Name = "name_box";
            this.name_box.ReadOnly = true;
            this.name_box.Size = new System.Drawing.Size(272, 38);
            this.name_box.TabIndex = 46;
            // 
            // GenderBox
            // 
            this.GenderBox.Enabled = false;
            this.GenderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.GenderBox.Location = new System.Drawing.Point(7, 223);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(272, 33);
            this.GenderBox.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dir_box);
            this.panel1.Controls.Add(this.subjects_box);
            this.panel1.Location = new System.Drawing.Point(296, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 341);
            this.panel1.TabIndex = 53;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "Дата рождения";
            // 
            // birth_box
            // 
            this.birth_box.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birth_box.Enabled = false;
            this.birth_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birth_box.Location = new System.Drawing.Point(7, 297);
            this.birth_box.Name = "birth_box";
            this.birth_box.Size = new System.Drawing.Size(272, 31);
            this.birth_box.TabIndex = 62;
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
            this.comboBox1.Size = new System.Drawing.Size(269, 28);
            this.comboBox1.TabIndex = 49;
            this.comboBox1.Visible = false;
            // 
            // abitur_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 349);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.birth_box);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.patronim_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.surname_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.GenderBox);
            this.Name = "abitur_form";
            this.Text = "abitur_form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.abitur_form_FormClosed);
            this.Load += new System.EventHandler(this.abitur_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox patronim_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surname_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox dir_box;
        private System.Windows.Forms.ListBox subjects_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker birth_box;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}