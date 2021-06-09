
namespace OICAR_Desktop
{
    partial class ServiceForm
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnDeleteServiceType = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbServices = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(411, 179);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(83, 13);
            this.lblInfo.TabIndex = 17;
            this.lblInfo.Text = "Nema podataka";
            this.lblInfo.Visible = false;
            // 
            // btnDeleteServiceType
            // 
            this.btnDeleteServiceType.BackColor = System.Drawing.Color.Red;
            this.btnDeleteServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteServiceType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteServiceType.Location = new System.Drawing.Point(28, 252);
            this.btnDeleteServiceType.Name = "btnDeleteServiceType";
            this.btnDeleteServiceType.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteServiceType.TabIndex = 16;
            this.btnDeleteServiceType.Text = "Obriši";
            this.btnDeleteServiceType.UseVisualStyleBackColor = false;
            this.btnDeleteServiceType.Click += new System.EventHandler(this.btnDeleteServiceType_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdateService.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateService.Location = new System.Drawing.Point(558, 48);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(138, 28);
            this.btnUpdateService.TabIndex = 15;
            this.btnUpdateService.Text = "Ažuriraj uslugu";
            this.btnUpdateService.UseVisualStyleBackColor = false;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.BackColor = System.Drawing.Color.Red;
            this.btnDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteService.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteService.Location = new System.Drawing.Point(414, 48);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(138, 28);
            this.btnDeleteService.TabIndex = 14;
            this.btnDeleteService.Text = "Obriši uslugu";
            this.btnDeleteService.UseVisualStyleBackColor = false;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddService.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddService.Location = new System.Drawing.Point(270, 48);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(138, 28);
            this.btnAddService.TabIndex = 13;
            this.btnAddService.Text = "Dodaj uslugu";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeight = 40;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServiceDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.serviceBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(210, 99);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(540, 247);
            this.dataGridView.TabIndex = 12;
            // 
            // idServiceDataGridViewTextBoxColumn
            // 
            this.idServiceDataGridViewTextBoxColumn.DataPropertyName = "IdService";
            this.idServiceDataGridViewTextBoxColumn.HeaderText = "IdService";
            this.idServiceDataGridViewTextBoxColumn.Name = "idServiceDataGridViewTextBoxColumn";
            this.idServiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.idServiceDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Usluga";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Trajanje";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(OICAR_Desktop.Model.Service);
            // 
            // lbServices
            // 
            this.lbServices.FormattingEnabled = true;
            this.lbServices.Location = new System.Drawing.Point(28, 73);
            this.lbServices.Name = "lbServices";
            this.lbServices.Size = new System.Drawing.Size(112, 173);
            this.lbServices.TabIndex = 11;
            this.lbServices.SelectedIndexChanged += new System.EventHandler(this.lbServices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vrsta usluge";
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDeleteServiceType);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lbServices);
            this.Controls.Add(this.label1);
            this.Name = "ServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDeleteServiceType;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ListBox lbServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
    }
}