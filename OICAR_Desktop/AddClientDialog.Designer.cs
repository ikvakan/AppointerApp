
namespace OICAR_Desktop
{
    partial class AddClientDialog
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
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label oIBLabel;
            System.Windows.Forms.Label surnameLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bindingSourceClientMD = new System.Windows.Forms.BindingSource(this.components);
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            oIBLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClientMD)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(264, 136);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(40, 13);
            adressLabel.TabIndex = 17;
            adressLabel.Text = "Adresa";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(72, 136);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(30, 13);
            cityLabel.TabIndex = 19;
            cityLabel.Text = "Grad";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(264, 100);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(44, 13);
            contactLabel.TabIndex = 21;
            contactLabel.Text = "Kontakt";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(72, 100);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(72, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(24, 13);
            nameLabel.TabIndex = 25;
            nameLabel.Text = "Ime";
            // 
            // oIBLabel
            // 
            oIBLabel.AutoSize = true;
            oIBLabel.Location = new System.Drawing.Point(72, 177);
            oIBLabel.Name = "oIBLabel";
            oIBLabel.Size = new System.Drawing.Size(28, 13);
            oIBLabel.TabIndex = 27;
            oIBLabel.Text = "OIB:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(264, 62);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(44, 13);
            surnameLabel.TabIndex = 29;
            surnameLabel.Text = "Prezime";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(adressLabel);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtAdress);
            this.panel1.Controls.Add(oIBLabel);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(cityLabel);
            this.panel1.Controls.Add(this.txtOib);
            this.panel1.Controls.Add(contactLabel);
            this.panel1.Controls.Add(surnameLabel);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Location = new System.Drawing.Point(199, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 235);
            this.panel1.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceClientMD, "Name", true));
            this.txtName.Location = new System.Drawing.Point(130, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 26;
            // 
            // bindingSourceClientMD
            // 
            this.bindingSourceClientMD.DataSource = typeof(OICAR_Desktop.Model.ClientMD);
            // 
            // txtAdress
            // 
            this.txtAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceClientMD, "Adress", true));
            this.txtAdress.Location = new System.Drawing.Point(322, 133);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(100, 20);
            this.txtAdress.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceClientMD, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(130, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // txtOib
            // 
            this.txtOib.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceClientMD, "OIB", true));
            this.txtOib.Location = new System.Drawing.Point(130, 174);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(292, 20);
            this.txtOib.TabIndex = 28;
            // 
            // txtContact
            // 
            this.txtContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceClientMD, "Contact", true));
            this.txtContact.Location = new System.Drawing.Point(322, 97);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 20);
            this.txtContact.TabIndex = 22;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceClientMD, "City", true));
            this.txtCity.Location = new System.Drawing.Point(130, 133);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 20;
            // 
            // txtSurname
            // 
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceClientMD, "Surname", true));
            this.txtSurname.Location = new System.Drawing.Point(322, 59);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 30;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(360, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 46);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 100);
            this.panel2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj klijenta";
            // 
            // AddClientDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Name = "AddClientDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClientDialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClientMD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bindingSourceClientMD;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}