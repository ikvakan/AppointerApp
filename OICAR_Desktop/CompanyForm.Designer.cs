
namespace OICAR_Desktop
{
    partial class CompanyForm
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            this.pbCompanyImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.companyMDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUploadPicture = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            adressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyMDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(200, 296);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(40, 13);
            adressLabel.TabIndex = 14;
            adressLabel.Text = "Adresa";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(453, 296);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(30, 13);
            cityLabel.TabIndex = 16;
            cityLabel.Text = "Grad";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(196, 333);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(44, 13);
            contactLabel.TabIndex = 18;
            contactLabel.Text = "Kontakt";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(453, 112);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(28, 13);
            descriptionLabel.TabIndex = 20;
            descriptionLabel.Text = "Opis";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(453, 333);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 22;
            emailLabel.Text = "Email";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(447, 67);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(34, 13);
            nameLabel.TabIndex = 24;
            nameLabel.Text = "Naziv";
            // 
            // pbCompanyImage
            // 
            this.pbCompanyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCompanyImage.Image = global::OICAR_Desktop.Properties.Resources.appointer_logo;
            this.pbCompanyImage.Location = new System.Drawing.Point(246, 64);
            this.pbCompanyImage.Name = "pbCompanyImage";
            this.pbCompanyImage.Size = new System.Drawing.Size(196, 170);
            this.pbCompanyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCompanyImage.TabIndex = 6;
            this.pbCompanyImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(385, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 45);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(248, 293);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(196, 20);
            this.adressTextBox.TabIndex = 15;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(487, 293);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(153, 20);
            this.cityTextBox.TabIndex = 17;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(251, 330);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(196, 20);
            this.contactTextBox.TabIndex = 19;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyMDBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(487, 109);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(153, 125);
            this.descriptionTextBox.TabIndex = 21;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(487, 330);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(153, 20);
            this.emailTextBox.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyMDBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(487, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 20);
            this.txtName.TabIndex = 25;
            // 
            // companyMDBindingSource
            // 
            this.companyMDBindingSource.DataSource = typeof(ClassLibrary.Model.CompanyMD);
            // 
            // btnUploadPicture
            // 
            this.btnUploadPicture.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUploadPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUploadPicture.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUploadPicture.Location = new System.Drawing.Point(246, 240);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.Size = new System.Drawing.Size(196, 34);
            this.btnUploadPicture.TabIndex = 26;
            this.btnUploadPicture.Text = "Postavi sliku";
            this.btnUploadPicture.UseVisualStyleBackColor = false;
            this.btnUploadPicture.Click += new System.EventHandler(this.btnUploadPicture_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 615);
            this.Controls.Add(this.btnUploadPicture);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(contactLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbCompanyImage);
            this.Name = "CompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompanyForm_FormClosed);
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyMDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbCompanyImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.BindingSource companyMDBindingSource;
        private System.Windows.Forms.Button btnUploadPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}