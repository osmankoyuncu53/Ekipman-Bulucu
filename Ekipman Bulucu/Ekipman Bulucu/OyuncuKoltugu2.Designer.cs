
namespace Ekipman_Bulucu
{
    partial class OyuncuKoltugu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuKoltugu2));
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunPuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyuncuKoltuguBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myEquipmentDataSet16 = new Ekipman_Bulucu.MyEquipmentDataSet16();
            this.oyuncuKoltuguTableAdapter = new Ekipman_Bulucu.MyEquipmentDataSet16TableAdapters.OyuncuKoltuguTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncuKoltuguBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myEquipmentDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 90);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Snow;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Black;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkViolet;
            this.linkLabel1.Location = new System.Drawing.Point(190, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(452, 33);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Filtrelemek için üye girişi yapın....";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkMagenta;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunadiDataGridViewTextBoxColumn,
            this.urunmarkaDataGridViewTextBoxColumn,
            this.urunFiyatDataGridViewTextBoxColumn,
            this.urunLinkDataGridViewTextBoxColumn,
            this.urunPuanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oyuncuKoltuguBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkMagenta;
            this.dataGridView1.Location = new System.Drawing.Point(108, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(560, 297);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // urunadiDataGridViewTextBoxColumn
            // 
            this.urunadiDataGridViewTextBoxColumn.DataPropertyName = "Urun_adi";
            this.urunadiDataGridViewTextBoxColumn.HeaderText = "Urun_adi";
            this.urunadiDataGridViewTextBoxColumn.Name = "urunadiDataGridViewTextBoxColumn";
            this.urunadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunmarkaDataGridViewTextBoxColumn
            // 
            this.urunmarkaDataGridViewTextBoxColumn.DataPropertyName = "Urun_marka";
            this.urunmarkaDataGridViewTextBoxColumn.HeaderText = "Urun_marka";
            this.urunmarkaDataGridViewTextBoxColumn.Name = "urunmarkaDataGridViewTextBoxColumn";
            this.urunmarkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunFiyatDataGridViewTextBoxColumn
            // 
            this.urunFiyatDataGridViewTextBoxColumn.DataPropertyName = "Urun_Fiyat";
            this.urunFiyatDataGridViewTextBoxColumn.HeaderText = "Urun_Fiyat";
            this.urunFiyatDataGridViewTextBoxColumn.Name = "urunFiyatDataGridViewTextBoxColumn";
            this.urunFiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunLinkDataGridViewTextBoxColumn
            // 
            this.urunLinkDataGridViewTextBoxColumn.DataPropertyName = "Urun_Link";
            this.urunLinkDataGridViewTextBoxColumn.HeaderText = "Urun_Link";
            this.urunLinkDataGridViewTextBoxColumn.Name = "urunLinkDataGridViewTextBoxColumn";
            this.urunLinkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunPuanDataGridViewTextBoxColumn
            // 
            this.urunPuanDataGridViewTextBoxColumn.DataPropertyName = "Urun_Puan";
            this.urunPuanDataGridViewTextBoxColumn.HeaderText = "Urun_Puan";
            this.urunPuanDataGridViewTextBoxColumn.Name = "urunPuanDataGridViewTextBoxColumn";
            this.urunPuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oyuncuKoltuguBindingSource
            // 
            this.oyuncuKoltuguBindingSource.DataMember = "OyuncuKoltugu";
            this.oyuncuKoltuguBindingSource.DataSource = this.myEquipmentDataSet16;
            // 
            // myEquipmentDataSet16
            // 
            this.myEquipmentDataSet16.DataSetName = "MyEquipmentDataSet16";
            this.myEquipmentDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oyuncuKoltuguTableAdapter
            // 
            this.oyuncuKoltuguTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkMagenta;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Seçtiğin ürüne çift tıkla....";
            // 
            // OyuncuKoltugu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OyuncuKoltugu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EkipmanSeç / Oyuncu Koltuğu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OyuncuKoltugu2_FormClosing);
            this.Load += new System.EventHandler(this.OyuncuKoltugu2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncuKoltuguBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myEquipmentDataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyEquipmentDataSet16 myEquipmentDataSet16;
        private System.Windows.Forms.BindingSource oyuncuKoltuguBindingSource;
        private MyEquipmentDataSet16TableAdapters.OyuncuKoltuguTableAdapter oyuncuKoltuguTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunmarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunPuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}