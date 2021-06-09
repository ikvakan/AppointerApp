
namespace OICAR_Desktop.UserControls
{
    partial class AddServiceControl
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
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label nameLabel1;
            System.Windows.Forms.Label priceLabel1;
            this.txtDesciption = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.cbServiceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddServiceType = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.serviceMDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrice = new System.Windows.Forms.TextBox();
            durationLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            priceLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(165, 170);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(45, 13);
            durationLabel.TabIndex = 35;
            durationLabel.Text = "Trajanje";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(171, 121);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(34, 13);
            nameLabel1.TabIndex = 45;
            nameLabel1.Text = "Naziv";
            // 
            // priceLabel1
            // 
            priceLabel1.AutoSize = true;
            priceLabel1.Location = new System.Drawing.Point(405, 121);
            priceLabel1.Name = "priceLabel1";
            priceLabel1.Size = new System.Drawing.Size(36, 13);
            priceLabel1.TabIndex = 47;
            priceLabel1.Text = "Cijena";
            // 
            // txtDesciption
            // 
            this.txtDesciption.Location = new System.Drawing.Point(165, 275);
            this.txtDesciption.Name = "txtDesciption";
            this.txtDesciption.Size = new System.Drawing.Size(490, 96);
            this.txtDesciption.TabIndex = 41;
            this.txtDesciption.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Opis";
            // 
            // cbDuration
            // 
            this.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Location = new System.Drawing.Point(245, 167);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(124, 21);
            this.cbDuration.TabIndex = 38;
            // 
            // cbServiceType
            // 
            this.cbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServiceType.FormattingEnabled = true;
            this.cbServiceType.Location = new System.Drawing.Point(450, 167);
            this.cbServiceType.Name = "cbServiceType";
            this.cbServiceType.Size = new System.Drawing.Size(124, 21);
            this.cbServiceType.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Vrsta usluge";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(268, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(238, 37);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddServiceType
            // 
            this.btnAddServiceType.Location = new System.Drawing.Point(580, 165);
            this.btnAddServiceType.Name = "btnAddServiceType";
            this.btnAddServiceType.Size = new System.Drawing.Size(75, 23);
            this.btnAddServiceType.TabIndex = 32;
            this.btnAddServiceType.Text = "Dodaj";
            this.btnAddServiceType.UseVisualStyleBackColor = true;
            this.btnAddServiceType.Click += new System.EventHandler(this.btnAddServiceType_Click);
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceMDBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(245, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 20);
            this.txtName.TabIndex = 46;
            // 
            // serviceMDBindingSource
            // 
            this.serviceMDBindingSource.DataSource = typeof(OICAR_Desktop.Model.ServiceMD);
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceMDBindingSource, "Price", true));
            this.txtPrice.Location = new System.Drawing.Point(450, 118);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(124, 20);
            this.txtPrice.TabIndex = 48;
            // 
            // AddServiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(priceLabel1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDesciption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDuration);
            this.Controls.Add(this.cbServiceType);
            this.Controls.Add(this.label1);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddServiceType);
            this.Name = "AddServiceControl";
            this.Size = new System.Drawing.Size(823, 548);
            ((System.ComponentModel.ISupportInitialize)(this.serviceMDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtDesciption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDuration;
        private System.Windows.Forms.ComboBox cbServiceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddServiceType;
        private System.Windows.Forms.BindingSource serviceMDBindingSource;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
    }
}
