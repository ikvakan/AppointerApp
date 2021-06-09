
namespace OICAR_Desktop
{
    partial class SetupForm
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
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnService = new System.Windows.Forms.Button();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.btnWorkingHours = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSideBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Controls.Add(this.tableLayoutPanel1);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(854, 65);
            this.pnlSideBar.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnService, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnWorkers, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnWorkingHours, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCompany, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 65);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnService
            // 
            this.btnService.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnService.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnService.Location = new System.Drawing.Point(642, 3);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(209, 59);
            this.btnService.TabIndex = 3;
            this.btnService.Text = "Usluge";
            this.btnService.UseVisualStyleBackColor = false;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWorkers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWorkers.Location = new System.Drawing.Point(429, 3);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(207, 59);
            this.btnWorkers.TabIndex = 2;
            this.btnWorkers.Text = "Djelatnici";
            this.btnWorkers.UseVisualStyleBackColor = false;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnWorkingHours
            // 
            this.btnWorkingHours.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnWorkingHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWorkingHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkingHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWorkingHours.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWorkingHours.Location = new System.Drawing.Point(216, 3);
            this.btnWorkingHours.Name = "btnWorkingHours";
            this.btnWorkingHours.Size = new System.Drawing.Size(207, 59);
            this.btnWorkingHours.TabIndex = 1;
            this.btnWorkingHours.Text = "Radno vrijeme";
            this.btnWorkingHours.UseVisualStyleBackColor = false;
            this.btnWorkingHours.Click += new System.EventHandler(this.btnWorkingHours_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCompany.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompany.Location = new System.Drawing.Point(3, 3);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(207, 59);
            this.btnCompany.TabIndex = 0;
            this.btnCompany.Text = "Poslovnica";
            this.btnCompany.UseVisualStyleBackColor = false;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 65);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(854, 559);
            this.pnlContent.TabIndex = 1;
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 624);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSideBar);
            this.Name = "SetupForm";
            this.Text = "SetupForm";
            this.pnlSideBar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Button btnWorkingHours;
    }
}