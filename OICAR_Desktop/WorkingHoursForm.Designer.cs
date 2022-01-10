
namespace OICAR_Desktop
{
    partial class WorkingHoursForm
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
            this.dtMonFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSunday = new System.Windows.Forms.TextBox();
            this.txtSaturday = new System.Windows.Forms.TextBox();
            this.txtFriday = new System.Windows.Forms.TextBox();
            this.txtThursday = new System.Windows.Forms.TextBox();
            this.txtWednesday = new System.Windows.Forms.TextBox();
            this.txtTuesday = new System.Windows.Forms.TextBox();
            this.txtMonday = new System.Windows.Forms.TextBox();
            this.cbSun = new System.Windows.Forms.CheckBox();
            this.cbSat = new System.Windows.Forms.CheckBox();
            this.cbFri = new System.Windows.Forms.CheckBox();
            this.cbTh = new System.Windows.Forms.CheckBox();
            this.cbWed = new System.Windows.Forms.CheckBox();
            this.cbTue = new System.Windows.Forms.CheckBox();
            this.cbMon = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtSunTo = new System.Windows.Forms.DateTimePicker();
            this.dtSunFrom = new System.Windows.Forms.DateTimePicker();
            this.dtSatTo = new System.Windows.Forms.DateTimePicker();
            this.dtSatFrom = new System.Windows.Forms.DateTimePicker();
            this.dtFriTo = new System.Windows.Forms.DateTimePicker();
            this.dtFriFrom = new System.Windows.Forms.DateTimePicker();
            this.dtThTo = new System.Windows.Forms.DateTimePicker();
            this.dtThFrom = new System.Windows.Forms.DateTimePicker();
            this.dtWedTo = new System.Windows.Forms.DateTimePicker();
            this.dtWedFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTueTo = new System.Windows.Forms.DateTimePicker();
            this.dtTueFrom = new System.Windows.Forms.DateTimePicker();
            this.dtMonTo = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtMonFrom
            // 
            this.dtMonFrom.CustomFormat = "HH:mm ";
            this.dtMonFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMonFrom.Location = new System.Drawing.Point(135, 54);
            this.dtMonFrom.Name = "dtMonFrom";
            this.dtMonFrom.ShowUpDown = true;
            this.dtMonFrom.Size = new System.Drawing.Size(58, 20);
            this.dtMonFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RADNO VRIJEME";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSunday);
            this.panel1.Controls.Add(this.txtSaturday);
            this.panel1.Controls.Add(this.txtFriday);
            this.panel1.Controls.Add(this.txtThursday);
            this.panel1.Controls.Add(this.txtWednesday);
            this.panel1.Controls.Add(this.txtTuesday);
            this.panel1.Controls.Add(this.txtMonday);
            this.panel1.Controls.Add(this.cbSun);
            this.panel1.Controls.Add(this.cbSat);
            this.panel1.Controls.Add(this.cbFri);
            this.panel1.Controls.Add(this.cbTh);
            this.panel1.Controls.Add(this.cbWed);
            this.panel1.Controls.Add(this.cbTue);
            this.panel1.Controls.Add(this.cbMon);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dtSunTo);
            this.panel1.Controls.Add(this.dtSunFrom);
            this.panel1.Controls.Add(this.dtSatTo);
            this.panel1.Controls.Add(this.dtSatFrom);
            this.panel1.Controls.Add(this.dtFriTo);
            this.panel1.Controls.Add(this.dtFriFrom);
            this.panel1.Controls.Add(this.dtThTo);
            this.panel1.Controls.Add(this.dtThFrom);
            this.panel1.Controls.Add(this.dtWedTo);
            this.panel1.Controls.Add(this.dtWedFrom);
            this.panel1.Controls.Add(this.dtTueTo);
            this.panel1.Controls.Add(this.dtTueFrom);
            this.panel1.Controls.Add(this.dtMonTo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtMonFrom);
            this.panel1.Location = new System.Drawing.Point(71, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 313);
            this.panel1.TabIndex = 2;
            // 
            // txtSunday
            // 
            this.txtSunday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSunday.Location = new System.Drawing.Point(29, 276);
            this.txtSunday.Name = "txtSunday";
            this.txtSunday.ReadOnly = true;
            this.txtSunday.Size = new System.Drawing.Size(100, 13);
            this.txtSunday.TabIndex = 36;
            this.txtSunday.Text = "Nedjelja";
            // 
            // txtSaturday
            // 
            this.txtSaturday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaturday.Location = new System.Drawing.Point(29, 247);
            this.txtSaturday.Name = "txtSaturday";
            this.txtSaturday.ReadOnly = true;
            this.txtSaturday.Size = new System.Drawing.Size(100, 13);
            this.txtSaturday.TabIndex = 35;
            this.txtSaturday.Text = "Subota";
            // 
            // txtFriday
            // 
            this.txtFriday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFriday.Location = new System.Drawing.Point(29, 212);
            this.txtFriday.Name = "txtFriday";
            this.txtFriday.ReadOnly = true;
            this.txtFriday.Size = new System.Drawing.Size(100, 13);
            this.txtFriday.TabIndex = 34;
            this.txtFriday.Text = "Petak";
            // 
            // txtThursday
            // 
            this.txtThursday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThursday.Location = new System.Drawing.Point(29, 175);
            this.txtThursday.Name = "txtThursday";
            this.txtThursday.ReadOnly = true;
            this.txtThursday.Size = new System.Drawing.Size(100, 13);
            this.txtThursday.TabIndex = 33;
            this.txtThursday.Text = "Četvrtak";
            // 
            // txtWednesday
            // 
            this.txtWednesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWednesday.Location = new System.Drawing.Point(29, 135);
            this.txtWednesday.Name = "txtWednesday";
            this.txtWednesday.ReadOnly = true;
            this.txtWednesday.Size = new System.Drawing.Size(100, 13);
            this.txtWednesday.TabIndex = 32;
            this.txtWednesday.Text = "Srijeda";
            // 
            // txtTuesday
            // 
            this.txtTuesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTuesday.Location = new System.Drawing.Point(29, 96);
            this.txtTuesday.Name = "txtTuesday";
            this.txtTuesday.ReadOnly = true;
            this.txtTuesday.Size = new System.Drawing.Size(100, 13);
            this.txtTuesday.TabIndex = 31;
            this.txtTuesday.Text = "Utorak";
            // 
            // txtMonday
            // 
            this.txtMonday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonday.Location = new System.Drawing.Point(29, 60);
            this.txtMonday.Name = "txtMonday";
            this.txtMonday.ReadOnly = true;
            this.txtMonday.Size = new System.Drawing.Size(100, 13);
            this.txtMonday.TabIndex = 4;
            this.txtMonday.Text = "Ponedjeljak";
            // 
            // cbSun
            // 
            this.cbSun.AutoSize = true;
            this.cbSun.Location = new System.Drawing.Point(471, 276);
            this.cbSun.Name = "cbSun";
            this.cbSun.Size = new System.Drawing.Size(15, 14);
            this.cbSun.TabIndex = 30;
            this.cbSun.UseVisualStyleBackColor = true;
            // 
            // cbSat
            // 
            this.cbSat.AutoSize = true;
            this.cbSat.Location = new System.Drawing.Point(471, 244);
            this.cbSat.Name = "cbSat";
            this.cbSat.Size = new System.Drawing.Size(15, 14);
            this.cbSat.TabIndex = 29;
            this.cbSat.UseVisualStyleBackColor = true;
            // 
            // cbFri
            // 
            this.cbFri.AutoSize = true;
            this.cbFri.Location = new System.Drawing.Point(471, 209);
            this.cbFri.Name = "cbFri";
            this.cbFri.Size = new System.Drawing.Size(15, 14);
            this.cbFri.TabIndex = 28;
            this.cbFri.UseVisualStyleBackColor = true;
            // 
            // cbTh
            // 
            this.cbTh.AutoSize = true;
            this.cbTh.Location = new System.Drawing.Point(471, 172);
            this.cbTh.Name = "cbTh";
            this.cbTh.Size = new System.Drawing.Size(15, 14);
            this.cbTh.TabIndex = 27;
            this.cbTh.UseVisualStyleBackColor = true;
            // 
            // cbWed
            // 
            this.cbWed.AutoSize = true;
            this.cbWed.Location = new System.Drawing.Point(471, 129);
            this.cbWed.Name = "cbWed";
            this.cbWed.Size = new System.Drawing.Size(15, 14);
            this.cbWed.TabIndex = 26;
            this.cbWed.UseVisualStyleBackColor = true;
            // 
            // cbTue
            // 
            this.cbTue.AutoSize = true;
            this.cbTue.Location = new System.Drawing.Point(471, 90);
            this.cbTue.Name = "cbTue";
            this.cbTue.Size = new System.Drawing.Size(15, 14);
            this.cbTue.TabIndex = 25;
            this.cbTue.UseVisualStyleBackColor = true;
            // 
            // cbMon
            // 
            this.cbMon.AutoSize = true;
            this.cbMon.Location = new System.Drawing.Point(471, 53);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(15, 14);
            this.cbMon.TabIndex = 24;
            this.cbMon.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(440, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "NERADNI DANI";
            // 
            // dtSunTo
            // 
            this.dtSunTo.CustomFormat = "HH:mm";
            this.dtSunTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSunTo.Location = new System.Drawing.Point(297, 276);
            this.dtSunTo.Name = "dtSunTo";
            this.dtSunTo.ShowUpDown = true;
            this.dtSunTo.Size = new System.Drawing.Size(58, 20);
            this.dtSunTo.TabIndex = 22;
            // 
            // dtSunFrom
            // 
            this.dtSunFrom.CustomFormat = "HH:mm";
            this.dtSunFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSunFrom.Location = new System.Drawing.Point(135, 276);
            this.dtSunFrom.Name = "dtSunFrom";
            this.dtSunFrom.ShowUpDown = true;
            this.dtSunFrom.Size = new System.Drawing.Size(58, 20);
            this.dtSunFrom.TabIndex = 21;
            // 
            // dtSatTo
            // 
            this.dtSatTo.CustomFormat = "HH:mm";
            this.dtSatTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSatTo.Location = new System.Drawing.Point(297, 241);
            this.dtSatTo.Name = "dtSatTo";
            this.dtSatTo.ShowUpDown = true;
            this.dtSatTo.Size = new System.Drawing.Size(58, 20);
            this.dtSatTo.TabIndex = 20;
            // 
            // dtSatFrom
            // 
            this.dtSatFrom.CustomFormat = "HH:mm";
            this.dtSatFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSatFrom.Location = new System.Drawing.Point(135, 241);
            this.dtSatFrom.Name = "dtSatFrom";
            this.dtSatFrom.ShowUpDown = true;
            this.dtSatFrom.Size = new System.Drawing.Size(58, 20);
            this.dtSatFrom.TabIndex = 19;
            // 
            // dtFriTo
            // 
            this.dtFriTo.CustomFormat = "HH:mm";
            this.dtFriTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFriTo.Location = new System.Drawing.Point(297, 206);
            this.dtFriTo.Name = "dtFriTo";
            this.dtFriTo.ShowUpDown = true;
            this.dtFriTo.Size = new System.Drawing.Size(58, 20);
            this.dtFriTo.TabIndex = 18;
            // 
            // dtFriFrom
            // 
            this.dtFriFrom.CustomFormat = "HH:mm";
            this.dtFriFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFriFrom.Location = new System.Drawing.Point(135, 206);
            this.dtFriFrom.Name = "dtFriFrom";
            this.dtFriFrom.ShowUpDown = true;
            this.dtFriFrom.Size = new System.Drawing.Size(58, 20);
            this.dtFriFrom.TabIndex = 17;
            // 
            // dtThTo
            // 
            this.dtThTo.CustomFormat = "HH:mm";
            this.dtThTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThTo.Location = new System.Drawing.Point(297, 169);
            this.dtThTo.Name = "dtThTo";
            this.dtThTo.ShowUpDown = true;
            this.dtThTo.Size = new System.Drawing.Size(58, 20);
            this.dtThTo.TabIndex = 16;
            // 
            // dtThFrom
            // 
            this.dtThFrom.CustomFormat = "HH:mm";
            this.dtThFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThFrom.Location = new System.Drawing.Point(135, 169);
            this.dtThFrom.Name = "dtThFrom";
            this.dtThFrom.ShowUpDown = true;
            this.dtThFrom.Size = new System.Drawing.Size(58, 20);
            this.dtThFrom.TabIndex = 15;
            // 
            // dtWedTo
            // 
            this.dtWedTo.CustomFormat = "HH:mm";
            this.dtWedTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtWedTo.Location = new System.Drawing.Point(297, 129);
            this.dtWedTo.Name = "dtWedTo";
            this.dtWedTo.ShowUpDown = true;
            this.dtWedTo.Size = new System.Drawing.Size(58, 20);
            this.dtWedTo.TabIndex = 14;
            // 
            // dtWedFrom
            // 
            this.dtWedFrom.CustomFormat = "HH:mm";
            this.dtWedFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtWedFrom.Location = new System.Drawing.Point(135, 129);
            this.dtWedFrom.Name = "dtWedFrom";
            this.dtWedFrom.ShowUpDown = true;
            this.dtWedFrom.Size = new System.Drawing.Size(58, 20);
            this.dtWedFrom.TabIndex = 13;
            // 
            // dtTueTo
            // 
            this.dtTueTo.CustomFormat = "HH:mm";
            this.dtTueTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTueTo.Location = new System.Drawing.Point(297, 90);
            this.dtTueTo.Name = "dtTueTo";
            this.dtTueTo.ShowUpDown = true;
            this.dtTueTo.Size = new System.Drawing.Size(58, 20);
            this.dtTueTo.TabIndex = 12;
            // 
            // dtTueFrom
            // 
            this.dtTueFrom.CustomFormat = "HH:mm";
            this.dtTueFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTueFrom.Location = new System.Drawing.Point(135, 90);
            this.dtTueFrom.Name = "dtTueFrom";
            this.dtTueFrom.ShowUpDown = true;
            this.dtTueFrom.Size = new System.Drawing.Size(58, 20);
            this.dtTueFrom.TabIndex = 11;
            // 
            // dtMonTo
            // 
            this.dtMonTo.CustomFormat = "HH:mm";
            this.dtMonTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMonTo.Location = new System.Drawing.Point(297, 54);
            this.dtMonTo.Name = "dtMonTo";
            this.dtMonTo.ShowUpDown = true;
            this.dtMonTo.Size = new System.Drawing.Size(58, 20);
            this.dtMonTo.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "DO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "OD";
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnSaveUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveUpdate.Location = new System.Drawing.Point(277, 430);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(150, 38);
            this.btnSaveUpdate.TabIndex = 3;
            this.btnSaveUpdate.Text = "Spremi/Ažuriraj";
            this.btnSaveUpdate.UseVisualStyleBackColor = false;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // WorkingHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.btnSaveUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "WorkingHoursForm";
            this.Text = "WorkingHoursForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkingHoursForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtMonFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtSunTo;
        private System.Windows.Forms.DateTimePicker dtSunFrom;
        private System.Windows.Forms.DateTimePicker dtSatTo;
        private System.Windows.Forms.DateTimePicker dtSatFrom;
        private System.Windows.Forms.DateTimePicker dtFriTo;
        private System.Windows.Forms.DateTimePicker dtFriFrom;
        private System.Windows.Forms.DateTimePicker dtThTo;
        private System.Windows.Forms.DateTimePicker dtThFrom;
        private System.Windows.Forms.DateTimePicker dtWedTo;
        private System.Windows.Forms.DateTimePicker dtWedFrom;
        private System.Windows.Forms.DateTimePicker dtTueTo;
        private System.Windows.Forms.DateTimePicker dtTueFrom;
        private System.Windows.Forms.DateTimePicker dtMonTo;
        private System.Windows.Forms.CheckBox cbSun;
        private System.Windows.Forms.CheckBox cbSat;
        private System.Windows.Forms.CheckBox cbFri;
        private System.Windows.Forms.CheckBox cbTh;
        private System.Windows.Forms.CheckBox cbWed;
        private System.Windows.Forms.CheckBox cbTue;
        private System.Windows.Forms.CheckBox cbMon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.TextBox txtSunday;
        private System.Windows.Forms.TextBox txtSaturday;
        private System.Windows.Forms.TextBox txtFriday;
        private System.Windows.Forms.TextBox txtThursday;
        private System.Windows.Forms.TextBox txtWednesday;
        private System.Windows.Forms.TextBox txtTuesday;
        private System.Windows.Forms.TextBox txtMonday;
    }
}