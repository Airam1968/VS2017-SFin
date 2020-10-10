using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for RepParcelasRetrato
/// </summary>
public class RepParcelasRetrato : DevExpress.XtraReports.UI.XtraReport
{
	private DevExpress.XtraReports.UI.DetailBand Detail;
	private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
	private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
	private PageHeaderBand PageHeader;
	private XRPageInfo xrPageInfo2;
	public XRLabel ltitulorelatorio;
    private XRPageInfo xrPageInfo3;
    public XRLabel ltempresa;
	public XRLabel ltusuario;
	private XRPictureBox xrPictureBox1;
	private XRControlStyle xrControlStyle1;
    private XRControlStyle xrControlStyle2;
    private FormattingRule formattingRule1;
	private PageFooterBand PageFooter;
    public XRLabel lcaminho;
    public XRLabel lemissaoextenso;
    public XRLabel lcidadeestadoextenso;
    public XRLabel lvalorextenso1;
    public XRLabel xrLabel10;
    public XRLabel lvalorextenso2;
    public XRLabel lcnpjempresa;
    private XRLine xrLine2;
    public XRLabel lvinculo1;
    public XRLabel lvinculo3;
    public XRLabel lvinculo2;
    public XRLabel lvencimento;
    public XRLabel xrLabel2;
    public XRLabel xrLabel1;
    public XRLabel lnumero;
    public XRLabel xrLabel7;
    public XRLabel xrLabel5;
    public XRLabel xrLabel4;
    public XRLabel lemitentenome;
    public XRLabel lnomeempresa;
    public XRLabel lvalorpagamento;
    public XRLabel xrLabel14;
    public XRLabel xrLabel11;
    public XRLabel lvaloracrescimos;
    public XRLabel lvalordesconto;
    public XRLabel xrLabel6;
    public XRLabel lvalorparcela;
    public XRLabel xrLabel9;
    public XRLabel lemitentecpf;
    public XRLabel xrLabel3;
    public XRLabel lpagamento;
    public XRLabel xrLabel8;
    public XRLabel xrLabel12;
	
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public RepParcelasRetrato()
	{
		InitializeComponent();
		//
		// TODO: Add constructor logic here
		//
	}
	
	/// <summary> 
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
            //string resourceFileName = "RepParcelasRetrato.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.lpagamento = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.lemitentecpf = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvalorpagamento = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvaloracrescimos = new DevExpress.XtraReports.UI.XRLabel();
            this.lvalordesconto = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvalorparcela = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.lnomeempresa = new DevExpress.XtraReports.UI.XRLabel();
            this.lemitentenome = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lemissaoextenso = new DevExpress.XtraReports.UI.XRLabel();
            this.lcidadeestadoextenso = new DevExpress.XtraReports.UI.XRLabel();
            this.lvalorextenso1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvalorextenso2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lcnpjempresa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.lvinculo1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvinculo3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvinculo2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvencimento = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lnumero = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.ltusuario = new DevExpress.XtraReports.UI.XRLabel();
            this.ltempresa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ltitulorelatorio = new DevExpress.XtraReports.UI.XRLabel();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lcaminho = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12,
            this.lpagamento,
            this.xrLabel8,
            this.lemitentecpf,
            this.xrLabel3,
            this.lvalorpagamento,
            this.xrLabel14,
            this.xrLabel11,
            this.lvaloracrescimos,
            this.lvalordesconto,
            this.xrLabel6,
            this.lvalorparcela,
            this.xrLabel9,
            this.lnomeempresa,
            this.lemitentenome,
            this.xrLabel4,
            this.lemissaoextenso,
            this.lcidadeestadoextenso,
            this.lvalorextenso1,
            this.xrLabel10,
            this.lvalorextenso2,
            this.lcnpjempresa,
            this.xrLine2,
            this.lvinculo1,
            this.lvinculo3,
            this.lvinculo2,
            this.lvencimento,
            this.xrLabel2,
            this.xrLabel1,
            this.lnumero,
            this.xrLabel7,
            this.xrLabel5});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 424.4419F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(209.7708F, 168.0126F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(135.625F, 14.00002F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.Text = ", na Praça do Município de ";
            // 
            // lpagamento
            // 
            this.lpagamento.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpagamento.LocationFloat = new DevExpress.Utils.PointFloat(107.7709F, 70.76263F);
            this.lpagamento.Name = "lpagamento";
            this.lpagamento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lpagamento.SizeF = new System.Drawing.SizeF(237.6249F, 14F);
            this.lpagamento.StylePriority.UseFont = false;
            this.lpagamento.Text = "lpagamento";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(15.77073F, 70.76257F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "Pagamento:";
            // 
            // lemitentecpf
            // 
            this.lemitentecpf.BackColor = System.Drawing.Color.SlateGray;
            this.lemitentecpf.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemitentecpf.LocationFloat = new DevExpress.Utils.PointFloat(485.4374F, 120.0126F);
            this.lemitentecpf.Name = "lemitentecpf";
            this.lemitentecpf.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lemitentecpf.SizeF = new System.Drawing.SizeF(117.3541F, 14F);
            this.lemitentecpf.StylePriority.UseBackColor = false;
            this.lemitentecpf.StylePriority.UseFont = false;
            this.lemitentecpf.Text = "lemitentecpf";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(335.9789F, 120.0126F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(149.4585F, 14.00002F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = ", inscrito no CPF/CNPJ sob No. ";
            // 
            // lvalorpagamento
            // 
            this.lvalorpagamento.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalorpagamento.LocationFloat = new DevExpress.Utils.PointFloat(107.7708F, 279.6169F);
            this.lvalorpagamento.Name = "lvalorpagamento";
            this.lvalorpagamento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvalorpagamento.SizeF = new System.Drawing.SizeF(102F, 14F);
            this.lvalorpagamento.StylePriority.UseFont = false;
            this.lvalorpagamento.Text = "lvalorpagamento";
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(15.77073F, 279.6168F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.Text = "Valor Pago";
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(15.77071F, 247.6168F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(92.00009F, 14F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.Text = "Acréscimos";
            // 
            // lvaloracrescimos
            // 
            this.lvaloracrescimos.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvaloracrescimos.LocationFloat = new DevExpress.Utils.PointFloat(107.7708F, 247.6168F);
            this.lvaloracrescimos.Name = "lvaloracrescimos";
            this.lvaloracrescimos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvaloracrescimos.SizeF = new System.Drawing.SizeF(102F, 14F);
            this.lvaloracrescimos.StylePriority.UseFont = false;
            this.lvaloracrescimos.Text = "lvaloracrescimos";
            // 
            // lvalordesconto
            // 
            this.lvalordesconto.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalordesconto.LocationFloat = new DevExpress.Utils.PointFloat(107.7708F, 263.6168F);
            this.lvalordesconto.Name = "lvalordesconto";
            this.lvalordesconto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvalordesconto.SizeF = new System.Drawing.SizeF(102F, 14F);
            this.lvalordesconto.StylePriority.UseFont = false;
            this.lvalordesconto.Text = "lvalordesconto";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(15.77071F, 263.6167F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(92.00009F, 14F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "Descontos";
            // 
            // lvalorparcela
            // 
            this.lvalorparcela.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalorparcela.LocationFloat = new DevExpress.Utils.PointFloat(107.7708F, 231.6168F);
            this.lvalorparcela.Name = "lvalorparcela";
            this.lvalorparcela.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvalorparcela.SizeF = new System.Drawing.SizeF(102F, 14F);
            this.lvalorparcela.StylePriority.UseFont = false;
            this.lvalorparcela.Text = "lvalorparcela";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(15.77071F, 231.6168F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(92.00009F, 14F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "Valor Parcela";
            // 
            // lnomeempresa
            // 
            this.lnomeempresa.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnomeempresa.LocationFloat = new DevExpress.Utils.PointFloat(239.3957F, 348.8459F);
            this.lnomeempresa.Name = "lnomeempresa";
            this.lnomeempresa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lnomeempresa.SizeF = new System.Drawing.SizeF(411.6043F, 14F);
            this.lnomeempresa.StylePriority.UseFont = false;
            this.lnomeempresa.Text = "lnomeempresa";
            // 
            // lemitentenome
            // 
            this.lemitentenome.BackColor = System.Drawing.Color.SlateGray;
            this.lemitentenome.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemitentenome.LocationFloat = new DevExpress.Utils.PointFloat(73.2708F, 120.0126F);
            this.lemitentenome.Name = "lemitentenome";
            this.lemitentenome.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lemitentenome.SizeF = new System.Drawing.SizeF(262.7081F, 14.00001F);
            this.lemitentenome.StylePriority.UseBackColor = false;
            this.lemitentenome.StylePriority.UseFont = false;
            this.lemitentenome.Text = "lemitentenome";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(15.77069F, 120.0126F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(57.50011F, 14F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "Recebi de ";
            // 
            // lemissaoextenso
            // 
            this.lemissaoextenso.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemissaoextenso.LocationFloat = new DevExpress.Utils.PointFloat(239.3957F, 260.3459F);
            this.lemissaoextenso.Name = "lemissaoextenso";
            this.lemissaoextenso.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lemissaoextenso.SizeF = new System.Drawing.SizeF(457.3753F, 14.00002F);
            this.lemissaoextenso.StylePriority.UseFont = false;
            this.lemissaoextenso.Text = "lemissaoextenso";
            // 
            // lcidadeestadoextenso
            // 
            this.lcidadeestadoextenso.BackColor = System.Drawing.Color.SlateGray;
            this.lcidadeestadoextenso.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcidadeestadoextenso.LocationFloat = new DevExpress.Utils.PointFloat(345.3958F, 168.0126F);
            this.lcidadeestadoextenso.Name = "lcidadeestadoextenso";
            this.lcidadeestadoextenso.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcidadeestadoextenso.SizeF = new System.Drawing.SizeF(351.3752F, 14.00006F);
            this.lcidadeestadoextenso.StylePriority.UseBackColor = false;
            this.lcidadeestadoextenso.StylePriority.UseFont = false;
            this.lcidadeestadoextenso.Text = "lcidadeestadoextenso";
            // 
            // lvalorextenso1
            // 
            this.lvalorextenso1.BackColor = System.Drawing.Color.SlateGray;
            this.lvalorextenso1.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalorextenso1.LocationFloat = new DevExpress.Utils.PointFloat(15.77068F, 136.0126F);
            this.lvalorextenso1.Name = "lvalorextenso1";
            this.lvalorextenso1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvalorextenso1.SizeF = new System.Drawing.SizeF(681.0003F, 14F);
            this.lvalorextenso1.StylePriority.UseBackColor = false;
            this.lvalorextenso1.StylePriority.UseFont = false;
            this.lvalorextenso1.Text = "lvalorextenso1";
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(207.7708F, 168.0126F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(2.000015F, 14.00002F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = ", na Praça do Município de ";
            // 
            // lvalorextenso2
            // 
            this.lvalorextenso2.BackColor = System.Drawing.Color.SlateGray;
            this.lvalorextenso2.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalorextenso2.LocationFloat = new DevExpress.Utils.PointFloat(15.77065F, 152.0126F);
            this.lvalorextenso2.Name = "lvalorextenso2";
            this.lvalorextenso2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvalorextenso2.SizeF = new System.Drawing.SizeF(681.0004F, 14F);
            this.lvalorextenso2.StylePriority.UseBackColor = false;
            this.lvalorextenso2.StylePriority.UseFont = false;
            this.lvalorextenso2.Text = "lvalorextenso2";
            // 
            // lcnpjempresa
            // 
            this.lcnpjempresa.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcnpjempresa.LocationFloat = new DevExpress.Utils.PointFloat(239.3957F, 363.8459F);
            this.lcnpjempresa.Name = "lcnpjempresa";
            this.lcnpjempresa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcnpjempresa.SizeF = new System.Drawing.SizeF(411.6043F, 14F);
            this.lcnpjempresa.StylePriority.UseFont = false;
            this.lcnpjempresa.Text = "lcnpjempresa";
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(239.3957F, 326.9709F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(411.6043F, 7.375F);
            // 
            // lvinculo1
            // 
            this.lvinculo1.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvinculo1.LocationFloat = new DevExpress.Utils.PointFloat(385.5625F, 38.76267F);
            this.lvinculo1.Name = "lvinculo1";
            this.lvinculo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvinculo1.SizeF = new System.Drawing.SizeF(311.2085F, 14F);
            this.lvinculo1.StylePriority.UseFont = false;
            this.lvinculo1.Text = "Vinculada ao Contrato de Compra e Venda do Empreendimento";
            // 
            // lvinculo3
            // 
            this.lvinculo3.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvinculo3.LocationFloat = new DevExpress.Utils.PointFloat(385.5625F, 70.76264F);
            this.lvinculo3.Name = "lvinculo3";
            this.lvinculo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvinculo3.SizeF = new System.Drawing.SizeF(311.2085F, 14F);
            this.lvinculo3.StylePriority.UseFont = false;
            this.lvinculo3.Text = "lvinculo3";
            // 
            // lvinculo2
            // 
            this.lvinculo2.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvinculo2.LocationFloat = new DevExpress.Utils.PointFloat(385.5625F, 54.76266F);
            this.lvinculo2.Name = "lvinculo2";
            this.lvinculo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvinculo2.SizeF = new System.Drawing.SizeF(311.2085F, 14F);
            this.lvinculo2.StylePriority.UseFont = false;
            this.lvinculo2.Text = "lvinculo2";
            // 
            // lvencimento
            // 
            this.lvencimento.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvencimento.LocationFloat = new DevExpress.Utils.PointFloat(107.7708F, 54.76265F);
            this.lvencimento.Name = "lvencimento";
            this.lvencimento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvencimento.SizeF = new System.Drawing.SizeF(237.6251F, 14F);
            this.lvencimento.StylePriority.UseFont = false;
            this.lvencimento.Text = "lvencimento";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(15.77069F, 54.7626F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(92.00011F, 14F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Vencimento:";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(15.77069F, 38.76262F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(92.00011F, 14F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Parcela No.:";
            // 
            // lnumero
            // 
            this.lnumero.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnumero.LocationFloat = new DevExpress.Utils.PointFloat(107.7708F, 38.76262F);
            this.lnumero.Name = "lnumero";
            this.lnumero.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lnumero.SizeF = new System.Drawing.SizeF(102F, 14F);
            this.lnumero.StylePriority.UseFont = false;
            this.lnumero.Text = "lnumero";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(15.77073F, 168.0126F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(192.0001F, 14.00002F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = ", refente a parcela descriminada abaixo";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(602.7914F, 120.0126F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(93.97955F, 13.99998F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "a  importancia  de";
            // 
            // TopMargin
            // 
            this.TopMargin.BackColor = System.Drawing.Color.Transparent;
            this.TopMargin.HeightF = 48.81465F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ltusuario
            // 
            this.ltusuario.BackColor = System.Drawing.Color.White;
            this.ltusuario.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltusuario.LocationFloat = new DevExpress.Utils.PointFloat(586.0417F, 14F);
            this.ltusuario.Name = "ltusuario";
            this.ltusuario.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltusuario.SizeF = new System.Drawing.SizeF(120.9583F, 14F);
            this.ltusuario.StylePriority.UseBackColor = false;
            this.ltusuario.StylePriority.UseFont = false;
            this.ltusuario.StylePriority.UseTextAlignment = false;
            this.ltusuario.Text = "ltusuario";
            this.ltusuario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // ltempresa
            // 
            this.ltempresa.BackColor = System.Drawing.Color.Transparent;
            this.ltempresa.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.ltempresa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltempresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.ltempresa.LocationFloat = new DevExpress.Utils.PointFloat(182.7708F, 45.91218F);
            this.ltempresa.Name = "ltempresa";
            this.ltempresa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltempresa.SizeF = new System.Drawing.SizeF(376.4166F, 17.08783F);
            this.ltempresa.StylePriority.UseBackColor = false;
            this.ltempresa.StylePriority.UseBorders = false;
            this.ltempresa.StylePriority.UseFont = false;
            this.ltempresa.StylePriority.UseForeColor = false;
            this.ltempresa.StylePriority.UseTextAlignment = false;
            this.ltempresa.Text = "ltempresa";
            this.ltempresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.BackColor = System.Drawing.Color.Transparent;
            this.xrPageInfo2.BorderWidth = 0F;
            this.xrPageInfo2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo2.Format = "{0:dddd, d\' de \'MMMM\' de \'yyyy HH:mm:ss}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(529.2919F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(177.7082F, 14F);
            this.xrPageInfo2.StylePriority.UseBackColor = false;
            this.xrPageInfo2.StylePriority.UseBorderWidth = false;
            this.xrPageInfo2.StylePriority.UseFont = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 24.16428F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.BackColor = System.Drawing.Color.LightGray;
            this.PageHeader.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrPageInfo3,
            this.ltitulorelatorio,
            this.xrPageInfo2,
            this.ltempresa,
            this.ltusuario});
            this.PageHeader.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.PageHeader.HeightF = 76.04166F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseBackColor = false;
            this.PageHeader.StylePriority.UseBorders = false;
            this.PageHeader.StylePriority.UseFont = false;
            this.PageHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.PageHeader_BeforePrint);
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.BorderColor = System.Drawing.Color.Azure;
            this.xrPictureBox1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrPictureBox1.BorderWidth = 0F;
            this.xrPictureBox1.ImageUrl = "~\\images\\logomarca\\logoCliente_pequena_75x129px.jpg";
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(1.00015F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(129F, 75F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.xrPictureBox1.StylePriority.UseBorderColor = false;
            this.xrPictureBox1.StylePriority.UseBorderDashStyle = false;
            this.xrPictureBox1.StylePriority.UseBorderWidth = false;
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.BackColor = System.Drawing.Color.White;
            this.xrPageInfo3.Font = new System.Drawing.Font("Calibri", 8F);
            this.xrPageInfo3.Format = "Pág: {0}/{1}";
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(615.0418F, 28.00001F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(91.95819F, 14F);
            this.xrPageInfo3.StylePriority.UseBackColor = false;
            this.xrPageInfo3.StylePriority.UseFont = false;
            this.xrPageInfo3.StylePriority.UseTextAlignment = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // ltitulorelatorio
            // 
            this.ltitulorelatorio.BackColor = System.Drawing.Color.Transparent;
            this.ltitulorelatorio.BorderColor = System.Drawing.Color.Empty;
            this.ltitulorelatorio.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.ltitulorelatorio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.ltitulorelatorio.ForeColor = System.Drawing.Color.Black;
            this.ltitulorelatorio.LocationFloat = new DevExpress.Utils.PointFloat(182.7708F, 19F);
            this.ltitulorelatorio.Name = "ltitulorelatorio";
            this.ltitulorelatorio.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulorelatorio.SizeF = new System.Drawing.SizeF(376.4166F, 21.54171F);
            this.ltitulorelatorio.StylePriority.UseBackColor = false;
            this.ltitulorelatorio.StylePriority.UseBorderColor = false;
            this.ltitulorelatorio.StylePriority.UseBorders = false;
            this.ltitulorelatorio.StylePriority.UseFont = false;
            this.ltitulorelatorio.StylePriority.UseForeColor = false;
            this.ltitulorelatorio.StylePriority.UseTextAlignment = false;
            this.ltitulorelatorio.Text = "RECIBO DE PAGAMENTO DE PARCELA No. ";
            this.ltitulorelatorio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrControlStyle1
            // 
            this.xrControlStyle1.Name = "xrControlStyle1";
            this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // xrControlStyle2
            // 
            this.xrControlStyle2.Name = "xrControlStyle2";
            this.xrControlStyle2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // formattingRule1
            // 
            this.formattingRule1.Name = "formattingRule1";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lcaminho});
            this.PageFooter.HeightF = 22.91667F;
            this.PageFooter.Name = "PageFooter";
            // 
            // lcaminho
            // 
            this.lcaminho.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcaminho.LocationFloat = new DevExpress.Utils.PointFloat(4.999995F, 3.999964F);
            this.lcaminho.Name = "lcaminho";
            this.lcaminho.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcaminho.SizeF = new System.Drawing.SizeF(418.7498F, 14F);
            this.lcaminho.StylePriority.UseFont = false;
            this.lcaminho.Text = "Gitano ->SGFin ->Pagamentos ->Recibo de Pagamento de Parcela - Retrato";
            // 
            // RepParcelasRetrato
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.PageFooter});
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
            this.Margins = new System.Drawing.Printing.Margins(50, 70, 49, 24);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1,
            this.xrControlStyle2});
            this.Version = "13.2";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepParcelasRetrato_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

    public Int64 recibo;
    //

	private void RepParcelasRetrato_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
	{
		if ((SreDblib.GetParametro("RELATORIO ZEBRADO") == "SIM"))
		{
			Detail.Styles.EvenStyle.BackColor = System.Drawing.Color.Empty;
			Detail.Styles.OddStyle.BackColor = System.Drawing.Color.Silver;
			Detail.Styles.EvenStyle.ForeColor = System.Drawing.Color.Black;
		}
		else
		{
			Detail.Styles.EvenStyle.BackColor = System.Drawing.Color.Empty;
			Detail.Styles.OddStyle.BackColor = System.Drawing.Color.Empty;
			Detail.Styles.EvenStyle.ForeColor = System.Drawing.Color.Black;
		}

		//grupofiltros.RepeatEveryPage = ((SreDblib.GetParametro("EXIBE FILTRO RELAT") == "SIM"));

        if ((SreDblib.GetParametro("EXIBE LOGO RELATÓRIO") != "SIM"))
        {
            xrPictureBox1.Visible = false;
        }

        if ((SreDblib.GetParametro("EXIBE EMPRESA RELAT") != "SIM"))
        {
            ltempresa.Visible = false;
        }

	}

    private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //
        string parcela = Convert.ToString(GetCurrentColumnValue("parcela"));
        string tipo = Convert.ToString(GetCurrentColumnValue("tipo"));
        lnumero.Text = parcela + " Tipo: (" + tipo + ")";
        //
        string vencimento = Convert.ToString(GetCurrentColumnValue("data_vencimento")).Substring(0, 10);
        lvencimento.Text = vencimento;
        //
        string pagamento = Convert.ToString(GetCurrentColumnValue("data_pagamento")).Substring(0, 10);
        lpagamento.Text = pagamento;
        //
        string vlr_parcela = Convert.ToString(GetCurrentColumnValue("vlr_parcela"));
        lvalorparcela.Text = Srelib.forcaponto(vlr_parcela);
        //
        //
        string vlr_pagamento = Convert.ToString(GetCurrentColumnValue("vlr_pagamento"));
        lvalorpagamento.Text = Srelib.forcaponto(vlr_pagamento);
        //
        double diferenca = Convert.ToDouble(GetCurrentColumnValue("vlr_pagamento")) -
                                Convert.ToDouble(GetCurrentColumnValue("vlr_parcela"));
        //
        lvaloracrescimos.Text = "0,00";
        lvalordesconto.Text = "0,00";
        if (diferenca != 0)
        {
            if (diferenca > 0)
            {
                lvaloracrescimos.Text = Srelib.forcaponto(Convert.ToString(diferenca));
            }
            else
            {
                lvalordesconto.Text = Srelib.forcaponto(Convert.ToString(diferenca * -1));
            }
        }
        //
        Int32 produto = Convert.ToInt32(GetCurrentColumnValue("produto"));
        lvinculo2.Text = uProduto.PegaProdutoDescricao(produto);
        //
        Int32 grupo = Convert.ToInt32(GetCurrentColumnValue("grupo"));
        Int32 unidade = Convert.ToInt32(GetCurrentColumnValue("unidade"));
        Int32 parte = Convert.ToInt32(GetCurrentColumnValue("parte"));
        Int32 id = Convert.ToInt32(GetCurrentColumnValue("ID"));
        //
        lvinculo3.Text = "Bloco No. " + grupo.ToString() + " Unidade No. " + unidade.ToString();
        lvinculo3.Text = " " + lvinculo3.Text + " Parte No. " + parte.ToString();
        //
        //lvencimentoextenso.Text = Srelib.DataExtenso(Convert.ToDateTime(vencimento));
        //
        lnomeempresa.Text = uEmpresa.PegaNome(uEmpresa.PegaMatriz());
        //
        lcnpjempresa.Text = Srelib.FormataCPFCNPJ(uEmpresa.PegaCnpj(uEmpresa.PegaMatriz()));
        //       
        ValorExtenso xExt = new ValorExtenso();
        String xAux;
        xAux = xExt.ValExtenso(Convert.ToDouble(vlr_pagamento));
        lvalorextenso1.Text = xAux;
        lvalorextenso2.Text = " ";
        //
        lcidadeestadoextenso.Text = uEmpresa.PegaCidade(uEmpresa.PegaMatriz()) + ", " + uEmpresa.PegaEstado(uEmpresa.PegaMatriz()) + ".";
        //
        lemissaoextenso.Text = uEmpresa.PegaCidade(uEmpresa.PegaMatriz()) + ", " + Srelib.DataExtenso(DateTime.Now);
        //
        //
        string cliente = uVendas.PegaProprietário(produto.ToString(), grupo.ToString(), unidade.ToString(), "0");
        lemitentenome.Text = uContato.PegaNomeID(cliente);
        lemitentecpf.Text = Srelib.FormataCPFCNPJ(uContato.PegaCpfCnpjID(cliente));
        //
        //
        ////TITULO RECIBO
        //uParcelas.GravaRecibo(produto.ToString(), grupo.ToString(), unidade.ToString(), parte.ToString(), id.ToString(), recibo.ToString());
        //uParametros.AlteraMigracao("PROXIMO RECIBO", Convert.ToString(Convert.ToInt64(recibo) + 1));
    }

    private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //
        //TITULO RECIBO
        ltitulorelatorio.Text = "RECIBO DE PAGAMENTO DE PARCELA No. " + recibo.ToString();
    }


}
