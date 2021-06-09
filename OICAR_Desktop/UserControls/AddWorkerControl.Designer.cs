
namespace OICAR_Desktop.UserControls
{
    partial class AddWorkerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            this.workerMDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workerMDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(377, 263);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(44, 13);
            contactLabel.TabIndex = 1;
            contactLabel.Text = "Kontakt";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(141, 266);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(141, 219);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(24, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Ime";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(377, 219);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(44, 13);
            surnameLabel.TabIndex = 7;
            surnameLabel.Text = "Prezime";
            // 
            // workerMDBindingSource
            // 
            this.workerMDBindingSource.DataSource = typeof(OICAR_Desktop.Model.WorkerMD);
            // 
            // txtContact
            // 
            this.txtContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerMDBindingSource, "Contact", true));
            this.txtContact.Location = new System.Drawing.Point(435, 260);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(158, 20);
            this.txtContact.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerMDBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(199, 263);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(158, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerMDBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(199, 216);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workerMDBindingSource, "Surname", true));
            this.txtSurname.Location = new System.Drawing.Point(435, 216);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(158, 20);
            this.txtSurname.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(277, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(214, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(100, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 158);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dodaj klijenta";
            // 
            // AddWorkerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(contactLabel);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.panel1);
            this.Name = "AddWorkerControl";
            this.Size = new System.Drawing.Size(820, 495);
            ((System.ComponentModel.ISupportInitialize)(this.workerMDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource workerMDBindingSource;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
