
namespace OICAR_Desktop.UserControls
{
    partial class UpdateServiceControl
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
            System.Windows.Forms.Label durationLabel;
            this.txtDesciption = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.cbServiceType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            durationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(216, 243);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(45, 13);
            durationLabel.TabIndex = 51;
            durationLabel.Text = "Trajanje";
            // 
            // txtDesciption
            // 
            this.txtDesciption.Location = new System.Drawing.Point(216, 348);
            this.txtDesciption.Name = "txtDesciption";
            this.txtDesciption.Size = new System.Drawing.Size(409, 96);
            this.txtDesciption.TabIndex = 56;
            this.txtDesciption.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Opis";
            // 
            // cbDuration
            // 
            this.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Location = new System.Drawing.Point(296, 240);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(124, 21);
            this.cbDuration.TabIndex = 54;
            // 
            // cbServiceType
            // 
            this.cbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServiceType.FormattingEnabled = true;
            this.cbServiceType.Location = new System.Drawing.Point(501, 240);
            this.cbServiceType.Name = "cbServiceType";
            this.cbServiceType.Size = new System.Drawing.Size(124, 21);
            this.cbServiceType.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Vrsta usluge";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(313, 462);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(238, 37);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Usluga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Cijena";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(296, 186);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 20);
            this.txtName.TabIndex = 59;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(501, 186);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(124, 20);
            this.txtPrice.TabIndex = 60;
            // 
            // UpdateServiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "UpdateServiceControl";
            this.Size = new System.Drawing.Size(866, 613);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
    }
}
