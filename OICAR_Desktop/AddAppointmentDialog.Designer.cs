
namespace OICAR_Desktop
{
    partial class AddAppointmentDialog
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
            this.pnlAppointment = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemark = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlAppointment.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAppointment
            // 
            this.pnlAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAppointment.Controls.Add(this.label8);
            this.pnlAppointment.Controls.Add(this.cbService);
            this.pnlAppointment.Controls.Add(this.dtpTime);
            this.pnlAppointment.Controls.Add(this.cbDuration);
            this.pnlAppointment.Controls.Add(this.cbWorker);
            this.pnlAppointment.Controls.Add(this.label1);
            this.pnlAppointment.Controls.Add(this.cbStatus);
            this.pnlAppointment.Controls.Add(this.cbClients);
            this.pnlAppointment.Controls.Add(this.dtpDate);
            this.pnlAppointment.Controls.Add(this.txtRemark);
            this.pnlAppointment.Controls.Add(this.label4);
            this.pnlAppointment.Controls.Add(this.label7);
            this.pnlAppointment.Controls.Add(this.label5);
            this.pnlAppointment.Controls.Add(this.label3);
            this.pnlAppointment.Controls.Add(this.label2);
            this.pnlAppointment.Controls.Add(this.label6);
            this.pnlAppointment.Location = new System.Drawing.Point(88, 106);
            this.pnlAppointment.Name = "pnlAppointment";
            this.pnlAppointment.Size = new System.Drawing.Size(737, 375);
            this.pnlAppointment.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 34);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Datum";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(253, 487);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 43);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cbService
            // 
            this.cbService.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(215, 188);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(131, 21);
            this.cbService.TabIndex = 8;
            this.cbService.SelectedIndexChanged += new System.EventHandler(this.cbService_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(468, 487);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(190, 43);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(443, 79);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(134, 20);
            this.dtpTime.TabIndex = 19;
            this.dtpTime.Value = new System.DateTime(2021, 5, 17, 8, 0, 0, 0);
            // 
            // cbDuration
            // 
            this.cbDuration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Location = new System.Drawing.Point(443, 132);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(134, 21);
            this.cbDuration.TabIndex = 9;
            // 
            // cbWorker
            // 
            this.cbWorker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorker.FormattingEnabled = true;
            this.cbWorker.Location = new System.Drawing.Point(215, 132);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(131, 21);
            this.cbWorker.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 80);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klijent";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(446, 188);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(131, 21);
            this.cbStatus.TabIndex = 11;
            // 
            // cbClients
            // 
            this.cbClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(215, 76);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(131, 21);
            this.cbClients.TabIndex = 7;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.Location = new System.Drawing.Point(215, 34);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(134, 20);
            this.dtpDate.TabIndex = 15;
            // 
            // txtRemark
            // 
            this.txtRemark.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRemark.Location = new System.Drawing.Point(161, 253);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(412, 92);
            this.txtRemark.TabIndex = 13;
            this.txtRemark.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 237);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Napomena";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 135);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Djelatnik";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 80);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vrijeme ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 135);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trajanje";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 191);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usluga";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 191);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 100);
            this.panel2.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(28, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Upis termina";
            // 
            // AddAppointmentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlAppointment);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Name = "AddAppointmentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddApointment";
            this.pnlAppointment.ResumeLayout(false);
            this.pnlAppointment.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAppointment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ComboBox cbDuration;
        private System.Windows.Forms.ComboBox cbWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RichTextBox txtRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
    }
}