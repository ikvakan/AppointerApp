
namespace OICAR_Desktop
{
    partial class UpdateServiceForm
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
            System.Windows.Forms.Label durationLabel;
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesciption = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.cbServiceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            durationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(191, 179);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(45, 13);
            durationLabel.TabIndex = 62;
            durationLabel.Text = "Trajanje";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(511, 122);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(124, 20);
            this.txtPrice.TabIndex = 71;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(271, 122);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 20);
            this.txtName.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Cijena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Usluga";
            // 
            // txtDesciption
            // 
            this.txtDesciption.Location = new System.Drawing.Point(194, 230);
            this.txtDesciption.Name = "txtDesciption";
            this.txtDesciption.Size = new System.Drawing.Size(444, 96);
            this.txtDesciption.TabIndex = 67;
            this.txtDesciption.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Opis";
            // 
            // cbDuration
            // 
            this.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Location = new System.Drawing.Point(271, 176);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(124, 21);
            this.cbDuration.TabIndex = 65;
            // 
            // cbServiceType
            // 
            this.cbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServiceType.FormattingEnabled = true;
            this.cbServiceType.Location = new System.Drawing.Point(511, 176);
            this.cbServiceType.Name = "cbServiceType";
            this.cbServiceType.Size = new System.Drawing.Size(124, 21);
            this.cbServiceType.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Vrsta usluge";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(291, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(238, 37);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UpdateServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 596);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesciption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDuration);
            this.Controls.Add(this.cbServiceType);
            this.Controls.Add(this.label1);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.btnSave);
            this.Name = "UpdateServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateServiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtDesciption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDuration;
        private System.Windows.Forms.ComboBox cbServiceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}