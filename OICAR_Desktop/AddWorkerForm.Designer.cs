
namespace OICAR_Desktop
{
    partial class AddWorkerForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label labl1;
            System.Windows.Forms.Label Lable2;
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.workerMDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            contactLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            labl1 = new System.Windows.Forms.Label();
            Lable2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workerMDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(405, 243);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(44, 13);
            contactLabel.TabIndex = 23;
            contactLabel.Text = "Kontakt";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(179, 240);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 25;
            emailLabel.Text = "Email";
            // 
            // labl1
            // 
            labl1.AutoSize = true;
            labl1.Location = new System.Drawing.Point(179, 191);
            labl1.Name = "labl1";
            labl1.Size = new System.Drawing.Size(24, 13);
            labl1.TabIndex = 27;
            labl1.Text = "Ime";
            // 
            // Lable2
            // 
            Lable2.AutoSize = true;
            Lable2.Location = new System.Drawing.Point(409, 191);
            Lable2.Name = "Lable2";
            Lable2.Size = new System.Drawing.Size(44, 13);
            Lable2.TabIndex = 29;
            Lable2.Text = "Prezime";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(277, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(234, 39);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(121, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 158);
            this.panel1.TabIndex = 21;
            // 
            // txtContact
            // 
            this.txtContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerMDBindingSource, "Contact", true));
            this.txtContact.Location = new System.Drawing.Point(467, 240);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(145, 20);
            this.txtContact.TabIndex = 24;
            // 
            // workerMDBindingSource
            // 
            this.workerMDBindingSource.DataSource = typeof(OICAR_Desktop.Model.WorkerMD);
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerMDBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(237, 237);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 20);
            this.txtEmail.TabIndex = 26;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerMDBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(237, 188);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 20);
            this.txtName.TabIndex = 28;
            // 
            // txtSurname
            // 
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerMDBindingSource, "Surname", true));
            this.txtSurname.Location = new System.Drawing.Point(467, 188);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(145, 20);
            this.txtSurname.TabIndex = 30;
            // 
            // AddWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 528);
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
            this.Name = "AddWorkerForm";
            this.Text = "AddWorkerForm";
            ((System.ComponentModel.ISupportInitialize)(this.workerMDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource workerMDBindingSource;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
    }
}