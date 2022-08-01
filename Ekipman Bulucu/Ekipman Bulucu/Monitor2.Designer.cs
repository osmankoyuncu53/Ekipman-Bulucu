
namespace Ekipman_Bulucu
{
    partial class Monitor2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor2));
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tazelemeOraniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunboyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kavisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunPuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myEquipmentDataSet5 = new Ekipman_Bulucu.MyEquipmentDataSet5();
            this.monitorTableAdapter = new Ekipman_Bulucu.MyEquipmentDataSet5TableAdapters.MonitorTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myEquipmentDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(32, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 90);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Snow;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Black;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkViolet;
            this.linkLabel1.Location = new System.Drawing.Point(220, 46);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(452, 33);
            this.linkLabel1.TabIndex = 7;
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
            this.tazelemeOraniDataGridViewTextBoxColumn,
            this.urunboyDataGridViewTextBoxColumn,
            this.kavisDataGridViewTextBoxColumn,
            this.urunLinkDataGridViewTextBoxColumn,
            this.urunPuanDataGridViewTextBoxColumn,
            this.urunfiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.monitorBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkMagenta;
            this.dataGridView1.Location = new System.Drawing.Point(57, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 305);
            this.dataGridView1.TabIndex = 6;
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
            // tazelemeOraniDataGridViewTextBoxColumn
            // 
            this.tazelemeOraniDataGridViewTextBoxColumn.DataPropertyName = "TazelemeOrani";
            this.tazelemeOraniDataGridViewTextBoxColumn.HeaderText = "TazelemeOrani";
            this.tazelemeOraniDataGridViewTextBoxColumn.Name = "tazelemeOraniDataGridViewTextBoxColumn";
            this.tazelemeOraniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunboyDataGridViewTextBoxColumn
            // 
            this.urunboyDataGridViewTextBoxColumn.DataPropertyName = "Urun_boy";
            this.urunboyDataGridViewTextBoxColumn.HeaderText = "Urun_boy";
            this.urunboyDataGridViewTextBoxColumn.Name = "urunboyDataGridViewTextBoxColumn";
            this.urunboyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kavisDataGridViewTextBoxColumn
            // 
            this.kavisDataGridViewTextBoxColumn.DataPropertyName = "Kavis";
            this.kavisDataGridViewTextBoxColumn.HeaderText = "Kavis";
            this.kavisDataGridViewTextBoxColumn.Name = "kavisDataGridViewTextBoxColumn";
            this.kavisDataGridViewTextBoxColumn.ReadOnly = true;
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
            // urunfiyatDataGridViewTextBoxColumn
            // 
            this.urunfiyatDataGridViewTextBoxColumn.DataPropertyName = "Urun_fiyat";
            this.urunfiyatDataGridViewTextBoxColumn.HeaderText = "Urun_fiyat";
            this.urunfiyatDataGridViewTextBoxColumn.Name = "urunfiyatDataGridViewTextBoxColumn";
            this.urunfiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monitorBindingSource
            // 
            this.monitorBindingSource.DataMember = "Monitor";
            this.monitorBindingSource.DataSource = this.myEquipmentDataSet5;
            // 
            // myEquipmentDataSet5
            // 
            this.myEquipmentDataSet5.DataSetName = "MyEquipmentDataSet5";
            this.myEquipmentDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monitorTableAdapter
            // 
            this.monitorTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkMagenta;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Seçtiğin ürüne çift tıkla....";
            // 
            // Monitor2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 607);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Monitor2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EkipmanSeç / Monitör";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Monitor2_FormClosing);
            this.Load += new System.EventHandler(this.Monitor2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myEquipmentDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyEquipmentDataSet5 myEquipmentDataSet5;
        private System.Windows.Forms.BindingSource monitorBindingSource;
        private MyEquipmentDataSet5TableAdapters.MonitorTableAdapter monitorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunmarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tazelemeOraniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunboyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kavisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunPuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}