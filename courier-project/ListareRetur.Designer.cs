
namespace courier_project
{
    partial class ListareRetur
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expeditorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinatarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonExpeditorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDestinatarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orasADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orasBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costTransportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareRambursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rambursColectatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refuzColectatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExpeditieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLivrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataReturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcontractorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sediuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coleteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courierDbDataSet = new courier_project.courierDbDataSet();
            this.coleteTableAdapter = new courier_project.courierDbDataSetTableAdapters.ColeteTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sediiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sediiTableAdapter = new courier_project.courierDbDataSetTableAdapters.SediiTableAdapter();
            this.tableAdapterManager = new courier_project.courierDbDataSetTableAdapters.TableAdapterManager();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coleteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courierDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sediiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(764, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listarea retururilor intr-o zi/firma, determinarea valorii rambursurilor pe luna/" +
    "firma.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColetDataGridViewTextBoxColumn,
            this.expeditorDataGridViewTextBoxColumn,
            this.destinatarDataGridViewTextBoxColumn,
            this.telefonExpeditorDataGridViewTextBoxColumn,
            this.telefonDestinatarDataGridViewTextBoxColumn,
            this.orasADataGridViewTextBoxColumn,
            this.orasBDataGridViewTextBoxColumn,
            this.masaDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn,
            this.costTransportDataGridViewTextBoxColumn,
            this.tipCostDataGridViewTextBoxColumn,
            this.valoareRambursDataGridViewTextBoxColumn,
            this.rambursColectatDataGridViewTextBoxColumn,
            this.refuzColectatDataGridViewTextBoxColumn,
            this.dataExpeditieDataGridViewTextBoxColumn,
            this.dataLivrareDataGridViewTextBoxColumn,
            this.dataReturDataGridViewTextBoxColumn,
            this.subcontractorDataGridViewTextBoxColumn,
            this.sediuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coleteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 320);
            this.dataGridView1.TabIndex = 1;
            // 
            // idColetDataGridViewTextBoxColumn
            // 
            this.idColetDataGridViewTextBoxColumn.DataPropertyName = "IdColet";
            this.idColetDataGridViewTextBoxColumn.HeaderText = "IdColet";
            this.idColetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idColetDataGridViewTextBoxColumn.Name = "idColetDataGridViewTextBoxColumn";
            this.idColetDataGridViewTextBoxColumn.ReadOnly = true;
            this.idColetDataGridViewTextBoxColumn.Width = 125;
            // 
            // expeditorDataGridViewTextBoxColumn
            // 
            this.expeditorDataGridViewTextBoxColumn.DataPropertyName = "Expeditor";
            this.expeditorDataGridViewTextBoxColumn.HeaderText = "Expeditor";
            this.expeditorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expeditorDataGridViewTextBoxColumn.Name = "expeditorDataGridViewTextBoxColumn";
            this.expeditorDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinatarDataGridViewTextBoxColumn
            // 
            this.destinatarDataGridViewTextBoxColumn.DataPropertyName = "Destinatar";
            this.destinatarDataGridViewTextBoxColumn.HeaderText = "Destinatar";
            this.destinatarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinatarDataGridViewTextBoxColumn.Name = "destinatarDataGridViewTextBoxColumn";
            this.destinatarDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonExpeditorDataGridViewTextBoxColumn
            // 
            this.telefonExpeditorDataGridViewTextBoxColumn.DataPropertyName = "TelefonExpeditor";
            this.telefonExpeditorDataGridViewTextBoxColumn.HeaderText = "TelefonExpeditor";
            this.telefonExpeditorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonExpeditorDataGridViewTextBoxColumn.Name = "telefonExpeditorDataGridViewTextBoxColumn";
            this.telefonExpeditorDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDestinatarDataGridViewTextBoxColumn
            // 
            this.telefonDestinatarDataGridViewTextBoxColumn.DataPropertyName = "TelefonDestinatar";
            this.telefonDestinatarDataGridViewTextBoxColumn.HeaderText = "TelefonDestinatar";
            this.telefonDestinatarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDestinatarDataGridViewTextBoxColumn.Name = "telefonDestinatarDataGridViewTextBoxColumn";
            this.telefonDestinatarDataGridViewTextBoxColumn.Width = 125;
            // 
            // orasADataGridViewTextBoxColumn
            // 
            this.orasADataGridViewTextBoxColumn.DataPropertyName = "OrasA";
            this.orasADataGridViewTextBoxColumn.HeaderText = "OrasA";
            this.orasADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orasADataGridViewTextBoxColumn.Name = "orasADataGridViewTextBoxColumn";
            this.orasADataGridViewTextBoxColumn.Width = 125;
            // 
            // orasBDataGridViewTextBoxColumn
            // 
            this.orasBDataGridViewTextBoxColumn.DataPropertyName = "OrasB";
            this.orasBDataGridViewTextBoxColumn.HeaderText = "OrasB";
            this.orasBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orasBDataGridViewTextBoxColumn.Name = "orasBDataGridViewTextBoxColumn";
            this.orasBDataGridViewTextBoxColumn.Width = 125;
            // 
            // masaDataGridViewTextBoxColumn
            // 
            this.masaDataGridViewTextBoxColumn.DataPropertyName = "Masa";
            this.masaDataGridViewTextBoxColumn.HeaderText = "Masa";
            this.masaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masaDataGridViewTextBoxColumn.Name = "masaDataGridViewTextBoxColumn";
            this.masaDataGridViewTextBoxColumn.Width = 125;
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.categorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            this.categorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // costTransportDataGridViewTextBoxColumn
            // 
            this.costTransportDataGridViewTextBoxColumn.DataPropertyName = "CostTransport";
            this.costTransportDataGridViewTextBoxColumn.HeaderText = "CostTransport";
            this.costTransportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costTransportDataGridViewTextBoxColumn.Name = "costTransportDataGridViewTextBoxColumn";
            this.costTransportDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipCostDataGridViewTextBoxColumn
            // 
            this.tipCostDataGridViewTextBoxColumn.DataPropertyName = "TipCost";
            this.tipCostDataGridViewTextBoxColumn.HeaderText = "TipCost";
            this.tipCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipCostDataGridViewTextBoxColumn.Name = "tipCostDataGridViewTextBoxColumn";
            this.tipCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // valoareRambursDataGridViewTextBoxColumn
            // 
            this.valoareRambursDataGridViewTextBoxColumn.DataPropertyName = "ValoareRamburs";
            this.valoareRambursDataGridViewTextBoxColumn.HeaderText = "ValoareRamburs";
            this.valoareRambursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valoareRambursDataGridViewTextBoxColumn.Name = "valoareRambursDataGridViewTextBoxColumn";
            this.valoareRambursDataGridViewTextBoxColumn.Width = 125;
            // 
            // rambursColectatDataGridViewTextBoxColumn
            // 
            this.rambursColectatDataGridViewTextBoxColumn.DataPropertyName = "RambursColectat";
            this.rambursColectatDataGridViewTextBoxColumn.HeaderText = "RambursColectat";
            this.rambursColectatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rambursColectatDataGridViewTextBoxColumn.Name = "rambursColectatDataGridViewTextBoxColumn";
            this.rambursColectatDataGridViewTextBoxColumn.Width = 125;
            // 
            // refuzColectatDataGridViewTextBoxColumn
            // 
            this.refuzColectatDataGridViewTextBoxColumn.DataPropertyName = "RefuzColectat";
            this.refuzColectatDataGridViewTextBoxColumn.HeaderText = "RefuzColectat";
            this.refuzColectatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.refuzColectatDataGridViewTextBoxColumn.Name = "refuzColectatDataGridViewTextBoxColumn";
            this.refuzColectatDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataExpeditieDataGridViewTextBoxColumn
            // 
            this.dataExpeditieDataGridViewTextBoxColumn.DataPropertyName = "DataExpeditie";
            this.dataExpeditieDataGridViewTextBoxColumn.HeaderText = "DataExpeditie";
            this.dataExpeditieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataExpeditieDataGridViewTextBoxColumn.Name = "dataExpeditieDataGridViewTextBoxColumn";
            this.dataExpeditieDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataLivrareDataGridViewTextBoxColumn
            // 
            this.dataLivrareDataGridViewTextBoxColumn.DataPropertyName = "DataLivrare";
            this.dataLivrareDataGridViewTextBoxColumn.HeaderText = "DataLivrare";
            this.dataLivrareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataLivrareDataGridViewTextBoxColumn.Name = "dataLivrareDataGridViewTextBoxColumn";
            this.dataLivrareDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataReturDataGridViewTextBoxColumn
            // 
            this.dataReturDataGridViewTextBoxColumn.DataPropertyName = "DataRetur";
            this.dataReturDataGridViewTextBoxColumn.HeaderText = "DataRetur";
            this.dataReturDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataReturDataGridViewTextBoxColumn.Name = "dataReturDataGridViewTextBoxColumn";
            this.dataReturDataGridViewTextBoxColumn.Width = 125;
            // 
            // subcontractorDataGridViewTextBoxColumn
            // 
            this.subcontractorDataGridViewTextBoxColumn.DataPropertyName = "Subcontractor";
            this.subcontractorDataGridViewTextBoxColumn.HeaderText = "Subcontractor";
            this.subcontractorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subcontractorDataGridViewTextBoxColumn.Name = "subcontractorDataGridViewTextBoxColumn";
            this.subcontractorDataGridViewTextBoxColumn.Width = 125;
            // 
            // sediuDataGridViewTextBoxColumn
            // 
            this.sediuDataGridViewTextBoxColumn.DataPropertyName = "Sediu";
            this.sediuDataGridViewTextBoxColumn.HeaderText = "Sediu";
            this.sediuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sediuDataGridViewTextBoxColumn.Name = "sediuDataGridViewTextBoxColumn";
            this.sediuDataGridViewTextBoxColumn.Width = 125;
            // 
            // coleteBindingSource
            // 
            this.coleteBindingSource.DataMember = "Colete";
            this.coleteBindingSource.DataSource = this.courierDbDataSet;
            // 
            // courierDbDataSet
            // 
            this.courierDbDataSet.DataSetName = "courierDbDataSet";
            this.courierDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coleteTableAdapter
            // 
            this.coleteTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cautare retururi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selectare zi:";
            // 
            // sediiBindingSource
            // 
            this.sediiBindingSource.DataMember = "Sedii";
            this.sediiBindingSource.DataSource = this.courierDbDataSet;
            // 
            // sediiTableAdapter
            // 
            this.sediiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColeteTableAdapter = this.coleteTableAdapter;
            this.tableAdapterManager.CurierSediiTableAdapter = null;
            this.tableAdapterManager.CurierSubcontractoriTableAdapter = null;
            this.tableAdapterManager.RuteTableAdapter = null;
            this.tableAdapterManager.SediiTableAdapter = this.sediiTableAdapter;
            this.tableAdapterManager.SubcontractoriTableAdapter = null;
            this.tableAdapterManager.TarifTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = courier_project.courierDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selectare luna*:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(385, 85);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(249, 22);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(405, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "*se poate selecta orice zi dintr-o luna, se ia in considerare luna";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "Calculare ramburs";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(583, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 12;
            // 
            // ListareRetur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ListareRetur";
            this.Text = "ListareRetur";
            this.Load += new System.EventHandler(this.ListareRetur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coleteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courierDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sediiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private courierDbDataSet courierDbDataSet;
        private System.Windows.Forms.BindingSource coleteBindingSource;
        private courierDbDataSetTableAdapters.ColeteTableAdapter coleteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expeditorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinatarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonExpeditorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDestinatarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orasADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orasBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costTransportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareRambursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rambursColectatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refuzColectatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExpeditieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLivrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataReturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcontractorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sediuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sediiBindingSource;
        private courierDbDataSetTableAdapters.SediiTableAdapter sediiTableAdapter;
        private courierDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}