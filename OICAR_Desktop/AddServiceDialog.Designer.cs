
namespace OICAR_Desktop
{
    partial class AddServiceDialog
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
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label priceLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesciption = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSpecialization = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.cbServiceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddSpecialization = new System.Windows.Forms.Button();
            this.btnAddServiceType = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.serviceMDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            durationLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(60, 132);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(45, 13);
            durationLabel.TabIndex = 17;
            durationLabel.Text = "Trajanje";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(67, 84);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(34, 13);
            nameLabel.TabIndex = 29;
            nameLabel.Text = "Naziv";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(priceLabel);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtDesciption);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbSpecialization);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbDuration);
            this.panel1.Controls.Add(this.cbServiceType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(durationLabel);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAddSpecialization);
            this.panel1.Controls.Add(this.btnAddServiceType);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 454);
            this.panel1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceMDBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(134, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 20);
            this.txtName.TabIndex = 30;
            // 
            // txtDesciption
            // 
            this.txtDesciption.Location = new System.Drawing.Point(54, 237);
            this.txtDesciption.Name = "txtDesciption";
            this.txtDesciption.Size = new System.Drawing.Size(490, 96);
            this.txtDesciption.TabIndex = 29;
            this.txtDesciption.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Opis";
            // 
            // cbSpecialization
            // 
            this.cbSpecialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecialization.FormattingEnabled = true;
            this.cbSpecialization.Location = new System.Drawing.Point(134, 170);
            this.cbSpecialization.Name = "cbSpecialization";
            this.cbSpecialization.Size = new System.Drawing.Size(124, 21);
            this.cbSpecialization.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Specijalizacija";
            // 
            // cbDuration
            // 
            this.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Location = new System.Drawing.Point(134, 129);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(124, 21);
            this.cbDuration.TabIndex = 25;
            // 
            // cbServiceType
            // 
            this.cbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServiceType.FormattingEnabled = true;
            this.cbServiceType.Location = new System.Drawing.Point(339, 129);
            this.cbServiceType.Name = "cbServiceType";
            this.cbServiceType.Size = new System.Drawing.Size(124, 21);
            this.cbServiceType.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Vrsta usluge";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(280, 359);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 37);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(134, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 37);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddSpecialization
            // 
            this.btnAddSpecialization.Location = new System.Drawing.Point(268, 168);
            this.btnAddSpecialization.Name = "btnAddSpecialization";
            this.btnAddSpecialization.Size = new System.Drawing.Size(75, 23);
            this.btnAddSpecialization.TabIndex = 13;
            this.btnAddSpecialization.Text = "Dodaj";
            this.btnAddSpecialization.UseVisualStyleBackColor = true;
            this.btnAddSpecialization.Click += new System.EventHandler(this.btnAddSpecialization_Click);
            // 
            // btnAddServiceType
            // 
            this.btnAddServiceType.Location = new System.Drawing.Point(469, 127);
            this.btnAddServiceType.Name = "btnAddServiceType";
            this.btnAddServiceType.Size = new System.Drawing.Size(75, 23);
            this.btnAddServiceType.TabIndex = 12;
            this.btnAddServiceType.Text = "Dodaj";
            this.btnAddServiceType.UseVisualStyleBackColor = true;
            this.btnAddServiceType.Click += new System.EventHandler(this.btnAddServiceType_Click);
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(277, 81);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(36, 13);
            priceLabel.TabIndex = 30;
            priceLabel.Text = "Cijena";
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceMDBindingSource, "Price", true));
            this.txtPrice.Location = new System.Drawing.Point(339, 81);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(124, 20);
            this.txtPrice.TabIndex = 31;
            // 
            // serviceMDBindingSource
            // 
            this.serviceMDBindingSource.DataSource = typeof(OICAR_Desktop.Model.ServiceMD);
            // 
            // AddServiceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 490);
            this.Controls.Add(this.panel1);
            this.Name = "AddServiceDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddServiceDialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddSpecialization;
        private System.Windows.Forms.Button btnAddServiceType;
        private System.Windows.Forms.ComboBox cbSpecialization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDuration;
        private System.Windows.Forms.ComboBox cbServiceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDesciption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.BindingSource serviceMDBindingSource;
        private System.Windows.Forms.TextBox txtPrice;
    }
}