
namespace OICAR_Desktop.UserControls
{
    partial class ServiceControl
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
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbServices = new System.Windows.Forms.ListBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnDeleteServiceType = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(40, 24);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(40, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Usluge";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vrsta usluge";
            // 
            // lbServices
            // 
            this.lbServices.FormattingEnabled = true;
            this.lbServices.Location = new System.Drawing.Point(43, 105);
            this.lbServices.Name = "lbServices";
            this.lbServices.Size = new System.Drawing.Size(112, 173);
            this.lbServices.TabIndex = 2;
            this.lbServices.SelectedIndexChanged += new System.EventHandler(this.lbServices_SelectedIndexChanged);
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
            this.dataGridView.Location = new System.Drawing.Point(225, 131);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(540, 150);
            this.dataGridView.TabIndex = 3;
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
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(328, 80);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(112, 23);
            this.btnAddService.TabIndex = 4;
            this.btnAddService.Text = "Dodaj uslugu";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(446, 80);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteService.TabIndex = 5;
            this.btnDeleteService.Text = "Obriši uslugu";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(564, 80);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(112, 23);
            this.btnUpdateService.TabIndex = 6;
            this.btnUpdateService.Text = "Ažuriraj uslugu";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // btnDeleteServiceType
            // 
            this.btnDeleteServiceType.Location = new System.Drawing.Point(43, 284);
            this.btnDeleteServiceType.Name = "btnDeleteServiceType";
            this.btnDeleteServiceType.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteServiceType.TabIndex = 7;
            this.btnDeleteServiceType.Text = "Obriši";
            this.btnDeleteServiceType.UseVisualStyleBackColor = true;
            this.btnDeleteServiceType.Click += new System.EventHandler(this.btnDeleteServiceType_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(426, 211);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(83, 13);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Nema podataka";
            this.lblInfo.Visible = false;
            // 
            // ServiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDeleteServiceType);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lbServices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Name = "ServiceControl";
            this.Size = new System.Drawing.Size(912, 404);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbServices;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnDeleteServiceType;
        private System.Windows.Forms.Label lblInfo;
    }
}
