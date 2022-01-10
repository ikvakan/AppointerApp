
namespace OICAR_Desktop
{
    partial class AddSpecializationDialog
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label1;
            this.specializationMDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbWorker = new System.Windows.Forms.ComboBox();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.specializationMDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // specializationMDBindingSource
            // 
            this.specializationMDBindingSource.DataSource = typeof(OICAR_Desktop.Model.SpecializationMD);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(124, 87);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(73, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Specijalizacija";
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specializationMDBindingSource, "Name", true));
            this.txtSpecialization.Location = new System.Drawing.Point(203, 84);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.Size = new System.Drawing.Size(121, 20);
            this.txtSpecialization.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(123, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(228, 162);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbWorker
            // 
            this.cbWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorker.FormattingEnabled = true;
            this.cbWorker.Location = new System.Drawing.Point(203, 121);
            this.cbWorker.Name = "cbWorker";
            this.cbWorker.Size = new System.Drawing.Size(121, 21);
            this.cbWorker.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(150, 124);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 13);
            label1.TabIndex = 6;
            label1.Text = "Djelatnik";
            // 
            // AddSpecializationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 258);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbWorker);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtSpecialization);
            this.Name = "AddSpecializationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSpecializationDialog";
            ((System.ComponentModel.ISupportInitialize)(this.specializationMDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource specializationMDBindingSource;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbWorker;
    }
}