
namespace CommercialAutomationDevExpress
{
    partial class frmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControlUrun = new DevExpress.XtraEditors.GroupControl();
            this.sbtnUrunSil = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnUrunGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnUrunKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.textEditUrunAciklama = new System.Windows.Forms.RichTextBox();
            this.labelUrunAciklama = new DevExpress.XtraEditors.LabelControl();
            this.textEditUrunAdet = new System.Windows.Forms.NumericUpDown();
            this.textEditUrunSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelUrunSatisFiyat = new DevExpress.XtraEditors.LabelControl();
            this.textEditUrunAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelUrunAlisFiyat = new DevExpress.XtraEditors.LabelControl();
            this.labelUrunAdet = new DevExpress.XtraEditors.LabelControl();
            this.textEditUrunYil = new DevExpress.XtraEditors.TextEdit();
            this.labelUrunYil = new DevExpress.XtraEditors.LabelControl();
            this.textEditUrunModel = new DevExpress.XtraEditors.TextEdit();
            this.labelUrunModel = new DevExpress.XtraEditors.LabelControl();
            this.textEditUrunMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelUrunMarka = new DevExpress.XtraEditors.LabelControl();
            this.textEditUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.labelUrunAd = new DevExpress.XtraEditors.LabelControl();
            this.textEditUrunID = new DevExpress.XtraEditors.TextEdit();
            this.labelUrunID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUrun)).BeginInit();
            this.groupControlUrun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunSatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunAlisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunYil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-3, -2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(989, 526);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControlUrun
            // 
            this.groupControlUrun.Controls.Add(this.sbtnUrunSil);
            this.groupControlUrun.Controls.Add(this.sbtnUrunGuncelle);
            this.groupControlUrun.Controls.Add(this.sbtnUrunKaydet);
            this.groupControlUrun.Controls.Add(this.textEditUrunAciklama);
            this.groupControlUrun.Controls.Add(this.labelUrunAciklama);
            this.groupControlUrun.Controls.Add(this.textEditUrunAdet);
            this.groupControlUrun.Controls.Add(this.textEditUrunSatisFiyat);
            this.groupControlUrun.Controls.Add(this.labelUrunSatisFiyat);
            this.groupControlUrun.Controls.Add(this.textEditUrunAlisFiyat);
            this.groupControlUrun.Controls.Add(this.labelUrunAlisFiyat);
            this.groupControlUrun.Controls.Add(this.labelUrunAdet);
            this.groupControlUrun.Controls.Add(this.textEditUrunYil);
            this.groupControlUrun.Controls.Add(this.labelUrunYil);
            this.groupControlUrun.Controls.Add(this.textEditUrunModel);
            this.groupControlUrun.Controls.Add(this.labelUrunModel);
            this.groupControlUrun.Controls.Add(this.textEditUrunMarka);
            this.groupControlUrun.Controls.Add(this.labelUrunMarka);
            this.groupControlUrun.Controls.Add(this.textEditUrunAd);
            this.groupControlUrun.Controls.Add(this.labelUrunAd);
            this.groupControlUrun.Controls.Add(this.textEditUrunID);
            this.groupControlUrun.Controls.Add(this.labelUrunID);
            this.groupControlUrun.Location = new System.Drawing.Point(983, -33);
            this.groupControlUrun.Name = "groupControlUrun";
            this.groupControlUrun.Size = new System.Drawing.Size(334, 557);
            this.groupControlUrun.TabIndex = 2;
            // 
            // sbtnUrunSil
            // 
            this.sbtnUrunSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnUrunSil.ImageOptions.Image")));
            this.sbtnUrunSil.Location = new System.Drawing.Point(109, 435);
            this.sbtnUrunSil.Name = "sbtnUrunSil";
            this.sbtnUrunSil.Size = new System.Drawing.Size(174, 38);
            this.sbtnUrunSil.TabIndex = 21;
            this.sbtnUrunSil.Text = "Sil";
            this.sbtnUrunSil.Click += new System.EventHandler(this.sbtnUrunSil_Click);
            // 
            // sbtnUrunGuncelle
            // 
            this.sbtnUrunGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnUrunGuncelle.ImageOptions.Image")));
            this.sbtnUrunGuncelle.Location = new System.Drawing.Point(109, 479);
            this.sbtnUrunGuncelle.Name = "sbtnUrunGuncelle";
            this.sbtnUrunGuncelle.Size = new System.Drawing.Size(174, 38);
            this.sbtnUrunGuncelle.TabIndex = 20;
            this.sbtnUrunGuncelle.Text = "Güncelle";
            this.sbtnUrunGuncelle.Click += new System.EventHandler(this.sbtnUrunGuncelle_Click);
            // 
            // sbtnUrunKaydet
            // 
            this.sbtnUrunKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnUrunKaydet.ImageOptions.Image")));
            this.sbtnUrunKaydet.Location = new System.Drawing.Point(109, 391);
            this.sbtnUrunKaydet.Name = "sbtnUrunKaydet";
            this.sbtnUrunKaydet.Size = new System.Drawing.Size(174, 38);
            this.sbtnUrunKaydet.TabIndex = 19;
            this.sbtnUrunKaydet.Text = "Kaydet";
            this.sbtnUrunKaydet.Click += new System.EventHandler(this.sbtnUrunKaydet_Click);
            // 
            // textEditUrunAciklama
            // 
            this.textEditUrunAciklama.Location = new System.Drawing.Point(108, 291);
            this.textEditUrunAciklama.Name = "textEditUrunAciklama";
            this.textEditUrunAciklama.Size = new System.Drawing.Size(175, 94);
            this.textEditUrunAciklama.TabIndex = 18;
            this.textEditUrunAciklama.Text = "";
            // 
            // labelUrunAciklama
            // 
            this.labelUrunAciklama.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.labelUrunAciklama.Appearance.Options.UseFont = true;
            this.labelUrunAciklama.Location = new System.Drawing.Point(45, 291);
            this.labelUrunAciklama.Name = "labelUrunAciklama";
            this.labelUrunAciklama.Size = new System.Drawing.Size(57, 17);
            this.labelUrunAciklama.TabIndex = 17;
            this.labelUrunAciklama.Text = "Açıklama:";
            // 
            // textEditUrunAdet
            // 
            this.textEditUrunAdet.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.textEditUrunAdet.Location = new System.Drawing.Point(109, 197);
            this.textEditUrunAdet.Name = "textEditUrunAdet";
            this.textEditUrunAdet.Size = new System.Drawing.Size(174, 24);
            this.textEditUrunAdet.TabIndex = 16;
            // 
            // textEditUrunSatisFiyat
            // 
            this.textEditUrunSatisFiyat.Location = new System.Drawing.Point(108, 252);
            this.textEditUrunSatisFiyat.Name = "textEditUrunSatisFiyat";
            this.textEditUrunSatisFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.textEditUrunSatisFiyat.Properties.Appearance.Options.UseFont = true;
            this.textEditUrunSatisFiyat.Size = new System.Drawing.Size(175, 24);
            this.textEditUrunSatisFiyat.TabIndex = 15;
            // 
            // labelUrunSatisFiyat
            // 
            this.labelUrunSatisFiyat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.labelUrunSatisFiyat.Appearance.Options.UseFont = true;
            this.labelUrunSatisFiyat.Location = new System.Drawing.Point(30, 255);
            this.labelUrunSatisFiyat.Name = "labelUrunSatisFiyat";
            this.labelUrunSatisFiyat.Size = new System.Drawing.Size(72, 17);
            this.labelUrunSatisFiyat.TabIndex = 14;
            this.labelUrunSatisFiyat.Text = " Satış Fiyatı:";
            // 
            // textEditUrunAlisFiyat
            // 
            this.textEditUrunAlisFiyat.Location = new System.Drawing.Point(108, 224);
            this.textEditUrunAlisFiyat.Name = "textEditUrunAlisFiyat";
            this.textEditUrunAlisFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.textEditUrunAlisFiyat.Properties.Appearance.Options.UseFont = true;
            this.textEditUrunAlisFiyat.Size = new System.Drawing.Size(175, 24);
            this.textEditUrunAlisFiyat.TabIndex = 13;
            // 
            // labelUrunAlisFiyat
            // 
            this.labelUrunAlisFiyat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.labelUrunAlisFiyat.Appearance.Options.UseFont = true;
            this.labelUrunAlisFiyat.Location = new System.Drawing.Point(44, 227);
            this.labelUrunAlisFiyat.Name = "labelUrunAlisFiyat";
            this.labelUrunAlisFiyat.Size = new System.Drawing.Size(58, 17);
            this.labelUrunAlisFiyat.TabIndex = 12;
            this.labelUrunAlisFiyat.Text = "Alış Fiyatı:";
            // 
            // labelUrunAdet
            // 
            this.labelUrunAdet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.labelUrunAdet.Appearance.Options.UseFont = true;
            this.labelUrunAdet.Location = new System.Drawing.Point(65, 198);
            this.labelUrunAdet.Name = "labelUrunAdet";
            this.labelUrunAdet.Size = new System.Drawing.Size(37, 17);
            this.labelUrunAdet.TabIndex = 10;
            this.labelUrunAdet.Text = " Adet:";
            // 
            // textEditUrunYil
            // 
            this.textEditUrunYil.Location = new System.Drawing.Point(108, 168);
            this.textEditUrunYil.Name = "textEditUrunYil";
            this.textEditUrunYil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.textEditUrunYil.Properties.Appearance.Options.UseFont = true;
            this.textEditUrunYil.Size = new System.Drawing.Size(175, 24);
            this.textEditUrunYil.TabIndex = 9;
            // 
            // labelUrunYil
            // 
            this.labelUrunYil.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.labelUrunYil.Appearance.Options.UseFont = true;
            this.labelUrunYil.Location = new System.Drawing.Point(75, 170);
            this.labelUrunYil.Name = "labelUrunYil";
            this.labelUrunYil.Size = new System.Drawing.Size(21, 17);
            this.labelUrunYil.TabIndex = 8;
            this.labelUrunYil.Text = " Yıl:";
            // 
            // textEditUrunModel
            // 
            this.textEditUrunModel.Location = new System.Drawing.Point(108, 140);
            this.textEditUrunModel.Name = "textEditUrunModel";
            this.textEditUrunModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.textEditUrunModel.Properties.Appearance.Options.UseFont = true;
            this.textEditUrunModel.Size = new System.Drawing.Size(175, 24);
            this.textEditUrunModel.TabIndex = 7;
            // 
            // labelUrunModel
            // 
            this.labelUrunModel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.labelUrunModel.Appearance.Options.UseFont = true;
            this.labelUrunModel.Location = new System.Drawing.Point(56, 142);
            this.labelUrunModel.Name = "labelUrunModel";
            this.labelUrunModel.Size = new System.Drawing.Size(40, 17);
            this.labelUrunModel.TabIndex = 6;
            this.labelUrunModel.Text = "Model:";
            // 
            // textEditUrunMarka
            // 
            this.textEditUrunMarka.Location = new System.Drawing.Point(108, 112);
            this.textEditUrunMarka.Name = "textEditUrunMarka";
            this.textEditUrunMarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.textEditUrunMarka.Properties.Appearance.Options.UseFont = true;
            this.textEditUrunMarka.Size = new System.Drawing.Size(175, 24);
            this.textEditUrunMarka.TabIndex = 5;
            // 
            // labelUrunMarka
            // 
            this.labelUrunMarka.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.labelUrunMarka.Appearance.Options.UseFont = true;
            this.labelUrunMarka.Location = new System.Drawing.Point(51, 114);
            this.labelUrunMarka.Name = "labelUrunMarka";
            this.labelUrunMarka.Size = new System.Drawing.Size(45, 17);
            this.labelUrunMarka.TabIndex = 4;
            this.labelUrunMarka.Text = " Marka:";
            // 
            // textEditUrunAd
            // 
            this.textEditUrunAd.Location = new System.Drawing.Point(108, 84);
            this.textEditUrunAd.Name = "textEditUrunAd";
            this.textEditUrunAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.textEditUrunAd.Properties.Appearance.Options.UseFont = true;
            this.textEditUrunAd.Size = new System.Drawing.Size(175, 24);
            this.textEditUrunAd.TabIndex = 3;
            // 
            // labelUrunAd
            // 
            this.labelUrunAd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.labelUrunAd.Appearance.Options.UseFont = true;
            this.labelUrunAd.Location = new System.Drawing.Point(75, 86);
            this.labelUrunAd.Name = "labelUrunAd";
            this.labelUrunAd.Size = new System.Drawing.Size(21, 17);
            this.labelUrunAd.TabIndex = 2;
            this.labelUrunAd.Text = "Ad:";
            // 
            // textEditUrunID
            // 
            this.textEditUrunID.Location = new System.Drawing.Point(108, 56);
            this.textEditUrunID.Name = "textEditUrunID";
            this.textEditUrunID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.textEditUrunID.Properties.Appearance.Options.UseFont = true;
            this.textEditUrunID.Size = new System.Drawing.Size(175, 24);
            this.textEditUrunID.TabIndex = 1;
            // 
            // labelUrunID
            // 
            this.labelUrunID.Appearance.Font = new System.Drawing.Font("Tahoma", 8.1F);
            this.labelUrunID.Appearance.Options.UseFont = true;
            this.labelUrunID.Location = new System.Drawing.Point(75, 59);
            this.labelUrunID.Name = "labelUrunID";
            this.labelUrunID.Size = new System.Drawing.Size(19, 17);
            this.labelUrunID.TabIndex = 0;
            this.labelUrunID.Text = "ID:";
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 525);
            this.Controls.Add(this.groupControlUrun);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmUrunler";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.frmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlUrun)).EndInit();
            this.groupControlUrun.ResumeLayout(false);
            this.groupControlUrun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunSatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunAlisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunYil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrunID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControlUrun;
        private DevExpress.XtraEditors.SimpleButton sbtnUrunSil;
        private DevExpress.XtraEditors.SimpleButton sbtnUrunGuncelle;
        private DevExpress.XtraEditors.SimpleButton sbtnUrunKaydet;
        private System.Windows.Forms.RichTextBox textEditUrunAciklama;
        private DevExpress.XtraEditors.LabelControl labelUrunAciklama;
        private System.Windows.Forms.NumericUpDown textEditUrunAdet;
        private DevExpress.XtraEditors.TextEdit textEditUrunSatisFiyat;
        private DevExpress.XtraEditors.LabelControl labelUrunSatisFiyat;
        private DevExpress.XtraEditors.TextEdit textEditUrunAlisFiyat;
        private DevExpress.XtraEditors.LabelControl labelUrunAlisFiyat;
        private DevExpress.XtraEditors.LabelControl labelUrunAdet;
        private DevExpress.XtraEditors.TextEdit textEditUrunYil;
        private DevExpress.XtraEditors.LabelControl labelUrunYil;
        private DevExpress.XtraEditors.TextEdit textEditUrunModel;
        private DevExpress.XtraEditors.LabelControl labelUrunModel;
        private DevExpress.XtraEditors.TextEdit textEditUrunMarka;
        private DevExpress.XtraEditors.LabelControl labelUrunMarka;
        private DevExpress.XtraEditors.TextEdit textEditUrunAd;
        private DevExpress.XtraEditors.LabelControl labelUrunAd;
        private DevExpress.XtraEditors.TextEdit textEditUrunID;
        private DevExpress.XtraEditors.LabelControl labelUrunID;
    }
}