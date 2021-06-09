
namespace OICAR_Desktop
{
    partial class AddServiceForm
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
            this.btnAddServiceType = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.serviceMDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesciption = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.cbServiceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            durationLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serviceMDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(189, 186);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(45, 13);
            durationLabel.TabIndex = 17;
            durationLabel.Text = "Trajanje";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(190, 138);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(34, 13);
            nameLabel.TabIndex = 29;
            nameLabel.Text = "Naziv";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(406, 135);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(36, 13);
            priceLabel.TabIndex = 30;
            priceLabel.Text = "Cijena";
            // 
            // btnAddServiceType
            // 
            this.btnAddServiceType.Location = new System.Drawing.Point(598, 181);
            this.btnAddServiceType.Name = "btnAddServiceType";
            this.btnAddServiceType.Size = new System.Drawing.Size(75, 23);
            this.btnAddServiceType.TabIndex = 33;
            this.btnAddServiceType.Text = "Dodaj";
            this.btnAddServiceType.UseVisualStyleBackColor = true;
            this.btnAddServiceType.Click += new System.EventHandler(this.btnAddServiceType_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceMDBindingSource, "Price", true));
            this.txtPrice.Location = new System.Drawing.Point(468, 135);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(124, 20);
            this.txtPrice.TabIndex = 31;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serviceMDBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(263, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 20);
            this.txtName.TabIndex = 30;
            // 
            // txtDesciption
            // 
            this.txtDesciption.Location = new System.Drawing.Point(190, 240);
            this.txtDesciption.Name = "txtDesciption";
            this.txtDesciption.Size = new System.Drawing.Size(490, 96);
            this.txtDesciption.TabIndex = 29;
            this.txtDesciption.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Opis";
            // 
            // cbDuration
            // 
            this.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Location = new System.Drawing.Point(263, 183);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(124, 21);
            this.cbDuration.TabIndex = 25;
            // 
            // cbServiceType
            // 
            this.cbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServiceType.FormattingEnabled = true;
            this.cbServiceType.Location = new System.Drawing.Point(468, 183);
            this.cbServiceType.Name = "cbServiceType";
            this.cbServiceType.Size = new System.Drawing.Size(124, 21);
            this.cbServiceType.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Vrsta usluge";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(332, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(214, 39);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 587);
            this.Controls.Add(this.btnAddServiceType);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(nameLabel);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesciption);
            this.Controls.Add(this.cbServiceType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDuration);
            this.Name = "AddServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddService";
            ((System.ComponentModel.ISupportInitialize)(this.serviceMDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbDuration;
        private System.Windows.Forms.ComboBox cbServiceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDesciption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.BindingSource serviceMDBindingSource;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddServiceType;
    }
}