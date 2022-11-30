namespace laba11
{
    partial class employe_form
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
            this.SuspendLayout();
            // 
            // worker_box
            // 
            this.worker_box.Enabled = false;
            this.worker_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.worker_box.FormattingEnabled = true;
            this.worker_box.Location = new System.Drawing.Point(12, 216);
            this.worker_box.Name = "worker_box";
            this.worker_box.Size = new System.Drawing.Size(272, 33);
            this.worker_box.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(8, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 61;
            this.label10.Text = "Дата рождения";
            // 
            // birth_box
            // 
            this.birth_box.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birth_box.Enabled = false;
            this.birth_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birth_box.Location = new System.Drawing.Point(12, 415);
            this.birth_box.Name = "birth_box";
            this.birth_box.Size = new System.Drawing.Size(272, 31);
            this.birth_box.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(8, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 59;
            this.label9.Text = "Пол";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "Факультет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "Должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Отчество";
            // 
            // patronim_box
            // 
            this.patronim_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronim_box.Location = new System.Drawing.Point(12, 147);
            this.patronim_box.Name = "patronim_box";
            this.patronim_box.ReadOnly = true;
            this.patronim_box.Size = new System.Drawing.Size(272, 38);
            this.patronim_box.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Фамилия";
            // 
            // surname_box
            // 
            this.surname_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_box.Location = new System.Drawing.Point(12, 86);
            this.surname_box.Name = "surname_box";
            this.surname_box.ReadOnly = true;
            this.surname_box.Size = new System.Drawing.Size(272, 38);
            this.surname_box.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Имя";
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_box.Location = new System.Drawing.Point(12, 25);
            this.name_box.Name = "name_box";
            this.name_box.ReadOnly = true;
            this.name_box.Size = new System.Drawing.Size(272, 38);
            this.name_box.TabIndex = 51;
            // 
            // GenderBox
            // 
            this.GenderBox.Enabled = false;
            this.GenderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.GenderBox.Location = new System.Drawing.Point(12, 343);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(272, 33);
            this.GenderBox.TabIndex = 50;
            // 
            // facultyBox
            // 
            this.facultyBox.Enabled = false;
            this.facultyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultyBox.FormattingEnabled = true;
            this.facultyBox.Location = new System.Drawing.Point(12, 280);
            this.facultyBox.Name = "facultyBox";
            this.facultyBox.Size = new System.Drawing.Size(272, 33);
            this.facultyBox.TabIndex = 49;
            // 
            // employe_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 460);
            this.Controls.Add(this.worker_box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.birth_box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.patronim_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.surname_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.facultyBox);
            this.Name = "employe_form";
            this.Text = "employe_form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.employe_form_FormClosed);
            this.Load += new System.EventHandler(this.employe_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox worker_box;
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
    }
}