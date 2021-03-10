namespace WindowsFormsApp
{
    partial class FormUrunEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbbx_AltKat = new System.Windows.Forms.ComboBox();
            this.cmbbx_Anakat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbx_UrunFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtbx_UrunAd = new System.Windows.Forms.TextBox();
            this.txtbx_UrunKod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Btn_UrunEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbx_UrunFiyat)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbbx_AltKat);
            this.groupBox1.Controls.Add(this.cmbbx_Anakat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori İşlemleri";
            // 
            // cmbbx_AltKat
            // 
            this.cmbbx_AltKat.FormattingEnabled = true;
            this.cmbbx_AltKat.Location = new System.Drawing.Point(168, 83);
            this.cmbbx_AltKat.Name = "cmbbx_AltKat";
            this.cmbbx_AltKat.Size = new System.Drawing.Size(232, 28);
            this.cmbbx_AltKat.TabIndex = 1;
            // 
            // cmbbx_Anakat
            // 
            this.cmbbx_Anakat.FormattingEnabled = true;
            this.cmbbx_Anakat.Location = new System.Drawing.Point(168, 36);
            this.cmbbx_Anakat.Name = "cmbbx_Anakat";
            this.cmbbx_Anakat.Size = new System.Drawing.Size(232, 28);
            this.cmbbx_Anakat.TabIndex = 0;
            this.cmbbx_Anakat.SelectedIndexChanged += new System.EventHandler(this.cmbbx_Anakat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alt Kategori Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ana Kategori Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbx_UrunFiyat);
            this.groupBox2.Controls.Add(this.txtbx_UrunAd);
            this.groupBox2.Controls.Add(this.txtbx_UrunKod);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // txtbx_UrunFiyat
            // 
            this.txtbx_UrunFiyat.DecimalPlaces = 2;
            this.txtbx_UrunFiyat.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.txtbx_UrunFiyat.Location = new System.Drawing.Point(594, 69);
            this.txtbx_UrunFiyat.Name = "txtbx_UrunFiyat";
            this.txtbx_UrunFiyat.Size = new System.Drawing.Size(120, 27);
            this.txtbx_UrunFiyat.TabIndex = 3;
            // 
            // txtbx_UrunAd
            // 
            this.txtbx_UrunAd.Location = new System.Drawing.Point(324, 69);
            this.txtbx_UrunAd.Name = "txtbx_UrunAd";
            this.txtbx_UrunAd.Size = new System.Drawing.Size(131, 27);
            this.txtbx_UrunAd.TabIndex = 2;
            // 
            // txtbx_UrunKod
            // 
            this.txtbx_UrunKod.Location = new System.Drawing.Point(115, 69);
            this.txtbx_UrunKod.MaxLength = 5;
            this.txtbx_UrunKod.Name = "txtbx_UrunKod";
            this.txtbx_UrunKod.Size = new System.Drawing.Size(87, 27);
            this.txtbx_UrunKod.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ürün Fiyatı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ürün Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ürün Kodu:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(491, 332);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Aktif Ürün";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Btn_UrunEkle
            // 
            this.Btn_UrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_UrunEkle.Location = new System.Drawing.Point(606, 324);
            this.Btn_UrunEkle.Name = "Btn_UrunEkle";
            this.Btn_UrunEkle.Size = new System.Drawing.Size(120, 35);
            this.Btn_UrunEkle.TabIndex = 5;
            this.Btn_UrunEkle.Text = "EKLE";
            this.Btn_UrunEkle.UseVisualStyleBackColor = true;
            this.Btn_UrunEkle.Click += new System.EventHandler(this.Btn_UrunEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(13, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(762, 216);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürünleri Listele";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(7, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 590);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_UrunEkle);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormUrunEkle";
            this.Text = "gnm0-p";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbx_UrunFiyat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbbx_Anakat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbbx_AltKat;
        private System.Windows.Forms.TextBox txtbx_UrunKod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtbx_UrunFiyat;
        private System.Windows.Forms.TextBox txtbx_UrunAd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Btn_UrunEkle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}