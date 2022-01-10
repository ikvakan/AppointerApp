
namespace OICAR_Desktop
{
    partial class MainForm
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
            this.btnPostavke = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKlijenti = new System.Windows.Forms.Button();
            this.btnTermini = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.pnlSideBar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlChildForm.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.AutoScroll = true;
            this.pnlSideBar.BackColor = System.Drawing.Color.Snow;
            this.pnlSideBar.Controls.Add(this.btnPostavke);
            this.pnlSideBar.Controls.Add(this.pnlLogo);
            this.pnlSideBar.Controls.Add(this.btnKlijenti);
            this.pnlSideBar.Controls.Add(this.btnTermini);
            this.pnlSideBar.Controls.Add(this.btnPocetna);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.ForeColor = System.Drawing.Color.White;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(205, 663);
            this.pnlSideBar.TabIndex = 0;
            // 
            // btnPostavke
            // 
            this.btnPostavke.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPostavke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPostavke.Location = new System.Drawing.Point(-3, 410);
            this.btnPostavke.Name = "btnPostavke";
            this.btnPostavke.Size = new System.Drawing.Size(205, 71);
            this.btnPostavke.TabIndex = 4;
            this.btnPostavke.Text = "Postavke";
            this.btnPostavke.UseVisualStyleBackColor = false;
            this.btnPostavke.Click += new System.EventHandler(this.btnPostavke_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(205, 145);
            this.pnlLogo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OICAR_Desktop.Properties.Resources.appointer_logo;
            this.pictureBox1.Location = new System.Drawing.Point(42, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnKlijenti
            // 
            this.btnKlijenti.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKlijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKlijenti.ForeColor = System.Drawing.Color.White;
            this.btnKlijenti.Location = new System.Drawing.Point(-3, 333);
            this.btnKlijenti.Name = "btnKlijenti";
            this.btnKlijenti.Size = new System.Drawing.Size(205, 71);
            this.btnKlijenti.TabIndex = 3;
            this.btnKlijenti.Text = "Klijenti";
            this.btnKlijenti.UseVisualStyleBackColor = false;
            this.btnKlijenti.Click += new System.EventHandler(this.btnKlijenti_Click);
            // 
            // btnTermini
            // 
            this.btnTermini.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTermini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTermini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTermini.Location = new System.Drawing.Point(-3, 256);
            this.btnTermini.Name = "btnTermini";
            this.btnTermini.Size = new System.Drawing.Size(205, 71);
            this.btnTermini.TabIndex = 2;
            this.btnTermini.Text = "Termini";
            this.btnTermini.UseVisualStyleBackColor = false;
            this.btnTermini.Click += new System.EventHandler(this.btnTermini_Click);
            // 
            // btnPocetna
            // 
            this.btnPocetna.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPocetna.Location = new System.Drawing.Point(-3, 179);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(205, 71);
            this.btnPocetna.TabIndex = 0;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = false;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlChildForm.Controls.Add(this.pnlWelcome);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(205, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(875, 663);
            this.pnlChildForm.TabIndex = 1;
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlWelcome.Controls.Add(this.lblWelcomeUser);
            this.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWelcome.Location = new System.Drawing.Point(0, 0);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(875, 100);
            this.pnlWelcome.TabIndex = 18;
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcomeUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcomeUser.Location = new System.Drawing.Point(28, 39);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(0, 24);
            this.lblWelcomeUser.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 663);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlSideBar);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlChildForm.ResumeLayout(false);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnPostavke;
        private System.Windows.Forms.Button btnKlijenti;
        private System.Windows.Forms.Button btnTermini;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label lblWelcomeUser;
    }
}

