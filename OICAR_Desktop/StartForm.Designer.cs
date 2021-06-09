
namespace OICAR_Desktop
{
    partial class StartForm
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
            this.btnUpisiTermin = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpisiTermin
            // 
            this.btnUpisiTermin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpisiTermin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpisiTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpisiTermin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpisiTermin.Location = new System.Drawing.Point(258, 491);
            this.btnUpisiTermin.Name = "btnUpisiTermin";
            this.btnUpisiTermin.Size = new System.Drawing.Size(266, 84);
            this.btnUpisiTermin.TabIndex = 0;
            this.btnUpisiTermin.Text = "Upiši termin";
            this.btnUpisiTermin.UseVisualStyleBackColor = false;
            this.btnUpisiTermin.Click += new System.EventHandler(this.btnUpisiTermin_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(304, 32);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeight = 40;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Location = new System.Drawing.Point(28, 237);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(801, 226);
            this.dataGridView.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(318, 290);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(160, 13);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Nema termina za odabran datum";
            this.lblInfo.Visible = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 624);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnUpisiTermin);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PocetnaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpisiTermin;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblInfo;
    }
}