﻿
namespace Ekipman_Bulucu
{
    partial class OyuncuKoltuguu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuKoltuguu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunPuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oyuncuKoltuguBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myEquipmentDataSet15 = new Ekipman_Bulucu.MyEquipmentDataSet15();
            this.oyuncuKoltuguTableAdapter = new Ekipman_Bulucu.MyEquipmentDataSet15TableAdapters.OyuncuKoltuguTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncuKoltuguBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myEquipmentDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(223, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 281);
            this.panel1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkMagenta;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(98, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "Filtrelemeyi Uygula";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(175, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 87);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "SEÇİNİZ....",
            "UCUZ",
            "ORTA",
            "PAHALI"});
            this.comboBox4.Location = new System.Drawing.Point(16, 57);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(404, 33);
            this.comboBox4.TabIndex = 4;
            this.comboBox4.Text = "SEÇİNİZ....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "1) Ürün Fiyatı?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkMagenta;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(126, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Filtrele";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(11, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 76);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(126, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 76);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkMagenta;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(534, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkMagenta;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(227, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Bulunan Ürün Sayısı :";
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
            this.dataGridView1.Location = new System.Drawing.Point(223, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(554, 325);
            this.dataGridView1.TabIndex = 23;
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
            this.oyuncuKoltuguBindingSource.DataSource = this.myEquipmentDataSet15;
            // 
            // myEquipmentDataSet15
            // 
            this.myEquipmentDataSet15.DataSetName = "MyEquipmentDataSet15";
            this.myEquipmentDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oyuncuKoltuguTableAdapter
            // 
            this.oyuncuKoltuguTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkMagenta;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(229, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(314, 29);
            this.label10.TabIndex = 24;
            this.label10.Text = "Seçtiğin ürüne çift tıkla....";
            // 
            // OyuncuKoltuguu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 603);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OyuncuKoltuguu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EkipmanSeç / Oyuncu Koltuğu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OyuncuKoltuguu_FormClosing);
            this.Load += new System.EventHandler(this.OyuncuKoltuguu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncuKoltuguBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myEquipmentDataSet15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MyEquipmentDataSet15 myEquipmentDataSet15;
        private System.Windows.Forms.BindingSource oyuncuKoltuguBindingSource;
        private MyEquipmentDataSet15TableAdapters.OyuncuKoltuguTableAdapter oyuncuKoltuguTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunmarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunPuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
    }
}