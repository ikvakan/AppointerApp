
namespace OICAR_Desktop
{
    partial class UpdateWorkerForm
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
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label labl1;
            System.Windows.Forms.Label Lable2;
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            contactLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            labl1 = new System.Windows.Forms.Label();
            Lable2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(399, 233);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(44, 13);
            contactLabel.TabIndex = 34;
            contactLabel.Text = "Kontakt";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(173, 230);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 36;
            emailLabel.Text = "Email";
            // 
            // labl1
            // 
            labl1.AutoSize = true;
            labl1.Location = new System.Drawing.Point(173, 181);
            labl1.Name = "labl1";
            labl1.Size = new System.Drawing.Size(24, 13);
            labl1.TabIndex = 38;
            labl1.Text = "Ime";
            // 
            // Lable2
            // 
            Lable2.AutoSize = true;
            Lable2.Location = new System.Drawing.Point(403, 181);
            Lable2.Name = "Lable2";
            Lable2.Size = new System.Drawing.Size(44, 13);
            Lable2.TabIndex = 40;
            Lable2.Text = "Prezime";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(461, 230);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(145, 20);
            this.txtContact.TabIndex = 35;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(231, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 20);
            this.txtEmail.TabIndex = 37;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(231, 178);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 20);
            this.txtName.TabIndex = 39;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(461, 178);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(145, 20);
            this.txtSurname.TabIndex = 41;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(279, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(227, 46);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(115, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 158);
            this.panel1.TabIndex = 32;
            // 
            // UpdateWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(contactLabel);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(labl1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(Lable2);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateWorkerForm";
            this.Text = "x";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
    }
}