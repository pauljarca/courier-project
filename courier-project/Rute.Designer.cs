
namespace courier_project
{
    partial class Rute
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sediiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courierDbDataSet = new courier_project.courierDbDataSet();
            this.sediiTableAdapter = new courier_project.courierDbDataSetTableAdapters.SediiTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.subcontractoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sediiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subcontractoriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subcontractoriTableAdapter = new courier_project.courierDbDataSetTableAdapters.SubcontractoriTableAdapter();
            this.ruteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruteTableAdapter = new courier_project.courierDbDataSetTableAdapters.RuteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sediiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courierDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcontractoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sediiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcontractoriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listarea tuturor rutelor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 372);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(364, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Listare rute anumit sediu/subcontractor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(85, 283);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Sediu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(85, 315);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(122, 21);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Subcontractori";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sediiBindingSource1;
            this.comboBox1.DisplayMember = "Oras";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 278);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Oras";
            // 
            // sediiBindingSource
            // 
            this.sediiBindingSource.DataMember = "Sedii";
            this.sediiBindingSource.DataSource = this.courierDbDataSet;
            // 
            // courierDbDataSet
            // 
            this.courierDbDataSet.DataSetName = "courierDbDataSet";
            this.courierDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sediiTableAdapter
            // 
            this.sediiTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.subcontractoriBindingSource1;
            this.comboBox2.DisplayMember = "Nume";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(212, 313);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 24);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "Nume";
            // 
            // subcontractoriBindingSource
            // 
            this.subcontractoriBindingSource.DataMember = "Subcontractori";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(501, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(532, 458);
            this.dataGridView1.TabIndex = 4;
            // 
            // sediiBindingSource1
            // 
            this.sediiBindingSource1.DataMember = "Sedii";
            this.sediiBindingSource1.DataSource = this.courierDbDataSet;
            // 
            // subcontractoriBindingSource1
            // 
            this.subcontractoriBindingSource1.DataMember = "Subcontractori";
            this.subcontractoriBindingSource1.DataSource = this.courierDbDataSet;
            // 
            // subcontractoriTableAdapter
            // 
            this.subcontractoriTableAdapter.ClearBeforeFill = true;
            // 
            // ruteBindingSource
            // 
            this.ruteBindingSource.DataMember = "Rute";
            this.ruteBindingSource.DataSource = this.courierDbDataSet;
            // 
            // ruteTableAdapter
            // 
            this.ruteTableAdapter.ClearBeforeFill = true;
            // 
            // Rute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Rute";
            this.Text = "Rute";
            this.Load += new System.EventHandler(this.Rute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sediiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courierDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcontractoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sediiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcontractoriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private courierDbDataSet courierDbDataSet;
        private System.Windows.Forms.BindingSource sediiBindingSource;
        private courierDbDataSetTableAdapters.SediiTableAdapter sediiTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource subcontractoriBindingSource;
        private System.Windows.Forms.BindingSource sediiBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource subcontractoriBindingSource1;
        private courierDbDataSetTableAdapters.SubcontractoriTableAdapter subcontractoriTableAdapter;
        private System.Windows.Forms.BindingSource ruteBindingSource;
        private courierDbDataSetTableAdapters.RuteTableAdapter ruteTableAdapter;
    }
}