
namespace CommercialAutomationDevExpress
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAnasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.btnStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.btnFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiderler = new DevExpress.XtraBars.BarButtonItem();
            this.btnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.btnBankalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnFaturalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnRehber = new DevExpress.XtraBars.BarButtonItem();
            this.btnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnAnasayfa,
            this.btnUrunler,
            this.btnMusteriler,
            this.btnStoklar,
            this.btnFirmalar,
            this.btnPersoneller,
            this.btnGiderler,
            this.btnKasa,
            this.btnBankalar,
            this.btnFaturalar,
            this.btnNotlar,
            this.btnRehber,
            this.btnAyarlar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 289;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(1119, 171);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Caption = "Ana Sayfa";
            this.btnAnasayfa.Id = 3;
            this.btnAnasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.ImageOptions.Image")));
            this.btnAnasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.ImageOptions.LargeImage")));
            this.btnAnasayfa.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAnasayfa.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnAnasayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAnasayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAnasayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Caption = "Ürünler";
            this.btnUrunler.Id = 4;
            this.btnUrunler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUrunler.ImageOptions.SvgImage")));
            this.btnUrunler.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            this.btnUrunler.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnUrunler.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnUrunler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnUrunler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunler_ItemClick);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Caption = "Müşteriler";
            this.btnMusteriler.Id = 5;
            this.btnMusteriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.ImageOptions.Image")));
            this.btnMusteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.ImageOptions.LargeImage")));
            this.btnMusteriler.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnMusteriler.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnMusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnMusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriler_ItemClick);
            // 
            // btnStoklar
            // 
            this.btnStoklar.Caption = "Stoklar";
            this.btnStoklar.Id = 6;
            this.btnStoklar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStoklar.ImageOptions.Image")));
            this.btnStoklar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStoklar.ImageOptions.LargeImage")));
            this.btnStoklar.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnStoklar.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnStoklar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnStoklar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStoklar.Name = "btnStoklar";
            this.btnStoklar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnFirmalar
            // 
            this.btnFirmalar.Caption = "Firmalar";
            this.btnFirmalar.Id = 7;
            this.btnFirmalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmalar.ImageOptions.Image")));
            this.btnFirmalar.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnFirmalar.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnFirmalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnFirmalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnFirmalar.Name = "btnFirmalar";
            this.btnFirmalar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnFirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Caption = "Personeller";
            this.btnPersoneller.Id = 8;
            this.btnPersoneller.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPersoneller.ImageOptions.SvgImage")));
            this.btnPersoneller.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnPersoneller.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnPersoneller.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnPersoneller.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // btnGiderler
            // 
            this.btnGiderler.Caption = "Giderler";
            this.btnGiderler.Id = 9;
            this.btnGiderler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiderler.ImageOptions.Image")));
            this.btnGiderler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGiderler.ImageOptions.LargeImage")));
            this.btnGiderler.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnGiderler.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnGiderler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnGiderler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnKasa
            // 
            this.btnKasa.Caption = "Kasa";
            this.btnKasa.Id = 10;
            this.btnKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKasa.ImageOptions.Image")));
            this.btnKasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKasa.ImageOptions.LargeImage")));
            this.btnKasa.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnKasa.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // btnBankalar
            // 
            this.btnBankalar.Caption = "Bankalar";
            this.btnBankalar.Id = 11;
            this.btnBankalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBankalar.ImageOptions.Image")));
            this.btnBankalar.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnBankalar.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnBankalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnBankalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBankalar.Name = "btnBankalar";
            this.btnBankalar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnFaturalar
            // 
            this.btnFaturalar.Caption = "Faturalar";
            this.btnFaturalar.Id = 12;
            this.btnFaturalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturalar.ImageOptions.Image")));
            this.btnFaturalar.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnFaturalar.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnFaturalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnFaturalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnFaturalar.Name = "btnFaturalar";
            this.btnFaturalar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnNotlar
            // 
            this.btnNotlar.Caption = "Notlar";
            this.btnNotlar.Id = 13;
            this.btnNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNotlar.ImageOptions.Image")));
            this.btnNotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNotlar.ImageOptions.LargeImage")));
            this.btnNotlar.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnNotlar.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnNotlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnNotlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnNotlar.Name = "btnNotlar";
            this.btnNotlar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNotlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // btnRehber
            // 
            this.btnRehber.Caption = "Rehber";
            this.btnRehber.Id = 14;
            this.btnRehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRehber.ImageOptions.Image")));
            this.btnRehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRehber.ImageOptions.LargeImage")));
            this.btnRehber.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnRehber.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnRehber.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnRehber.ItemAppearance.Normal.Options.UseFont = true;
            this.btnRehber.Name = "btnRehber";
            this.btnRehber.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Caption = "Ayarlar";
            this.btnAyarlar.Id = 15;
            this.btnAyarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.Image")));
            this.btnAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.LargeImage")));
            this.btnAyarlar.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAyarlar.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnAyarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnAyarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAyarlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAnasayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUrunler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStoklar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFirmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPersoneller);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGiderler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBankalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFaturalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAyarlar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 565);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Form1.IconOptions.SvgImage")));
            this.IconOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Commercial Automation";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem btnAnasayfa;
        private DevExpress.XtraBars.BarButtonItem btnUrunler;
        private DevExpress.XtraBars.BarButtonItem btnMusteriler;
        private DevExpress.XtraBars.BarButtonItem btnStoklar;
        private DevExpress.XtraBars.BarButtonItem btnFirmalar;
        private DevExpress.XtraBars.BarButtonItem btnPersoneller;
        private DevExpress.XtraBars.BarButtonItem btnGiderler;
        private DevExpress.XtraBars.BarButtonItem btnKasa;
        private DevExpress.XtraBars.BarButtonItem btnBankalar;
        private DevExpress.XtraBars.BarButtonItem btnFaturalar;
        private DevExpress.XtraBars.BarButtonItem btnNotlar;
        private DevExpress.XtraBars.BarButtonItem btnRehber;
        private DevExpress.XtraBars.BarButtonItem btnAyarlar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

