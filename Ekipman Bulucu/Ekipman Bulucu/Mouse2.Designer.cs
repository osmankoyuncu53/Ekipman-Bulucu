
namespace Ekipman_Bulucu
{
    partial class Mouse2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mouse2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyunturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunboyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunPuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kablosuzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myEquipmentDataSet9 = new Ekipman_Bulucu.MyEquipmentDataSet9();
            this.mouseTableAdapter = new Ekipman_Bulucu.MyEquipmentDataSet9TableAdapters.MouseTableAdapter();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myEquipmentDataSet9)).BeginInit();
            this.SuspendLayout();
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
            this.oyunturDataGridViewTextBoxColumn,
            this.urunboyDataGridViewTextBoxColumn,
            this.makroDataGridViewTextBoxColumn,
            this.urunFiyatDataGridViewTextBoxColumn,
            this.urunLinkDataGridViewTextBoxColumn,
            this.urunPuanDataGridViewTextBoxColumn,
            this.kablosuzDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mouseBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkMagenta;
            this.dataGridView1.Location = new System.Drawing.Point(55, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(947, 448);
            this.dataGridView1.TabIndex = 0;
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
            // oyunturDataGridViewTextBoxColumn
            // 
            this.oyunturDataGridViewTextBoxColumn.DataPropertyName = "Oyun_tur";
            this.oyunturDataGridViewTextBoxColumn.HeaderText = "Oyun_tur";
            this.oyunturDataGridViewTextBoxColumn.Name = "oyunturDataGridViewTextBoxColumn";
            this.oyunturDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunboyDataGridViewTextBoxColumn
            // 
            this.urunboyDataGridViewTextBoxColumn.DataPropertyName = "Urun_boy";
            this.urunboyDataGridViewTextBoxColumn.HeaderText = "Urun_boy";
            this.urunboyDataGridViewTextBoxColumn.Name = "urunboyDataGridViewTextBoxColumn";
            this.urunboyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makroDataGridViewTextBoxColumn
            // 
            this.makroDataGridViewTextBoxColumn.DataPropertyName = "Makro";
            this.makroDataGridViewTextBoxColumn.HeaderText = "Makro";
            this.makroDataGridViewTextBoxColumn.Name = "makroDataGridViewTextBoxColumn";
            this.makroDataGridViewTextBoxColumn.ReadOnly = true;
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
            // kablosuzDataGridViewTextBoxColumn
            // 
            this.kablosuzDataGridViewTextBoxColumn.DataPropertyName = "Kablosuz";
            this.kablosuzDataGridViewTextBoxColumn.HeaderText = "Kablosuz";
            this.kablosuzDataGridViewTextBoxColumn.Name = "kablosuzDataGridViewTextBoxColumn";
            this.kablosuzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mouseBindingSource
            // 
            this.mouseBindingSource.DataMember = "Mouse";
            this.mouseBindingSource.DataSource = this.myEquipmentDataSet9;
            // 
            // myEquipmentDataSet9
            // 
            this.myEquipmentDataSet9.DataSetName = "MyEquipmentDataSet9";
            this.myEquipmentDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mouseTableAdapter
            // 
            this.mouseTableAdapter.ClearBeforeFill = true;
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
            this.linkLabel1.Location = new System.Drawing.Point(306, 69);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(452, 33);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Filtrelemek için üye girişi yapın....";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(55, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 90);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkMagenta;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Seçtiğin ürüne çift tıkla....";
            // 
            // Mouse2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 623);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mouse2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EkipmanSeç / Mouse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mouse2_FormClosing);
            this.Load += new System.EventHandler(this.Mouse2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myEquipmentDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MyEquipmentDataSet9 myEquipmentDataSet9;
        private System.Windows.Forms.BindingSource mouseBindingSource;
        private MyEquipmentDataSet9TableAdapters.MouseTableAdapter mouseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunmarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oyunturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunboyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunPuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kablosuzDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}