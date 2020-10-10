using DevExpress.XtraReports.UI;
using System;

/// <summary>
/// Summary description for RepClienteCadastroTotal
/// </summary>
public class RepClienteCadastroTotal : DevExpress.XtraReports.UI.XtraReport
{
	private DevExpress.XtraReports.UI.DetailBand Detail;
	private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
	private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
	private PageHeaderBand PageHeader;
	private XRPageInfo xrPageInfo2;
	public XRLabel ltitulorelatorio;
	private XRPageInfo xrPageInfo3;
	private GroupHeaderBand grupocabecalho;
	public XRLabel xrLabel18;
	private XRLabel xrLabel26;
	private XRLabel xrLabel19;
	private GroupHeaderBand grupofiltros;
	private XRLabel xrLabel4;
	public XRLabel ltempresa;
	public XRLabel lfcliente;
	public XRLabel ltusuario;
	private XRPictureBox xrPictureBox1;
	private XRControlStyle xrControlStyle1;
	private XRControlStyle xrControlStyle2;
	public XRLabel lapelido;
	public XRLabel lemissaorg;
	public XRLabel lrg;
	public XRLabel lcnpj;
	private XRLabel xrLabel3;
	private XRLabel xrLabel15;
	public XRLabel ldtnascimento;
	public XRLabel lorgaorg;
	public XRLabel lnome;
	private XRLabel xrLabel17;
	private XRLabel xrLabel16;
	private FormattingRule formattingRule1;
	private XRLabel xrLabel2;
	public XRLabel lufrg;
	private XRLabel xrLabel5;
	public XRLabel linscrmunicipal;
	private PageFooterBand PageFooter;
	public XRLabel lcaminho;
    private XRLabel xrLabel11;
    private XRLabel xrLabel10;
    private XRLabel xrLabel13;
    private XRLabel xrLabel9;
    private XRLabel xrLabel1;
    public XRLabel xrLabel7;
    public XRLabel lsexo;
    public XRLabel lendres;
    public XRLabel linscrestadual;
    private XRLabel xrLabel12;
    public XRLabel lendcomcep;
    public XRLabel lendcomuf;
    public XRLabel lfone1com;
    public XRLabel lfone3com;
    public XRLabel lfone2com;
    public XRLabel lendcomnumero;
    public XRLabel lendcom;
    public XRLabel lendcomcomplem;
    public XRLabel lendcomcidade;
    public XRLabel lendcombairro;
    public XRLabel lfone3res;
    public XRLabel lfone2res;
    public XRLabel lfone1res;
    public XRLabel lendrescep;
    public XRLabel lendresuf;
    public XRLabel lendrescidade;
    public XRLabel lendresbairro;
    public XRLabel lendrescomplem;
    public XRLabel lendresnumero;
    private XRLine xrLine1;
    public XRLabel lufrgconjuge;
    public XRLabel ldtnascimentoconjuge;
    public XRLabel lfoneconjuge;
    public XRLabel lmailconjuge;
    public XRLabel lsexoconjuge;
    public XRLabel lorgaorgconjuge;
    public XRLabel lcnpjconjuge;
    public XRLabel lrgconjuge;
    public XRLabel lnomeconjuge;
    public XRLabel lemissaorgconjuge;
    public XRLabel lmail5;
    public XRLabel lmail4;
    public XRLabel lmail3;
    public XRLabel lmail2;
    public XRLabel lmail1;
    private XRLabel xrLabel6;
    public XRLabel lobs1;
    private XRLabel xrLabel8;
    public XRLabel lobs4;
    public XRLabel lobs3;
    public XRLabel lobs2;
    private ReportFooterBand ReportFooter;
    private XRLine xrLine2;
    public XRLabel ltotquant;
    public XRLabel xrLabel14;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

	public RepClienteCadastroTotal()
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
            string resourceFileName = "RepClienteCadastroTotal.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lobs4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lobs3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lobs2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lobs1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lufrgconjuge = new DevExpress.XtraReports.UI.XRLabel();
            this.ldtnascimentoconjuge = new DevExpress.XtraReports.UI.XRLabel();
            this.lfoneconjuge = new DevExpress.XtraReports.UI.XRLabel();
            this.lmailconjuge = new DevExpress.XtraReports.UI.XRLabel();
            this.lsexoconjuge = new DevExpress.XtraReports.UI.XRLabel();
            this.lorgaorgconjuge = new DevExpress.XtraReports.UI.XRLabel();
            this.lcnpjconjuge = new DevExpress.XtraReports.UI.XRLabel();
            this.lrgconjuge = new DevExpress.XtraReports.UI.XRLabel();
            this.lnomeconjuge = new DevExpress.XtraReports.UI.XRLabel();
            this.lemissaorgconjuge = new DevExpress.XtraReports.UI.XRLabel();
            this.lmail5 = new DevExpress.XtraReports.UI.XRLabel();
            this.lmail4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lmail3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lmail2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lmail1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lendcomcep = new DevExpress.XtraReports.UI.XRLabel();
            this.lendcomuf = new DevExpress.XtraReports.UI.XRLabel();
            this.lfone1com = new DevExpress.XtraReports.UI.XRLabel();
            this.lfone3com = new DevExpress.XtraReports.UI.XRLabel();
            this.lfone2com = new DevExpress.XtraReports.UI.XRLabel();
            this.lendcomnumero = new DevExpress.XtraReports.UI.XRLabel();
            this.lendcom = new DevExpress.XtraReports.UI.XRLabel();
            this.lendcomcomplem = new DevExpress.XtraReports.UI.XRLabel();
            this.lendcomcidade = new DevExpress.XtraReports.UI.XRLabel();
            this.lendcombairro = new DevExpress.XtraReports.UI.XRLabel();
            this.lfone3res = new DevExpress.XtraReports.UI.XRLabel();
            this.lfone2res = new DevExpress.XtraReports.UI.XRLabel();
            this.lfone1res = new DevExpress.XtraReports.UI.XRLabel();
            this.lendrescep = new DevExpress.XtraReports.UI.XRLabel();
            this.lendresuf = new DevExpress.XtraReports.UI.XRLabel();
            this.lendrescidade = new DevExpress.XtraReports.UI.XRLabel();
            this.lendresbairro = new DevExpress.XtraReports.UI.XRLabel();
            this.lendrescomplem = new DevExpress.XtraReports.UI.XRLabel();
            this.lendresnumero = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.linscrestadual = new DevExpress.XtraReports.UI.XRLabel();
            this.lendres = new DevExpress.XtraReports.UI.XRLabel();
            this.lsexo = new DevExpress.XtraReports.UI.XRLabel();
            this.linscrmunicipal = new DevExpress.XtraReports.UI.XRLabel();
            this.lufrg = new DevExpress.XtraReports.UI.XRLabel();
            this.ldtnascimento = new DevExpress.XtraReports.UI.XRLabel();
            this.lorgaorg = new DevExpress.XtraReports.UI.XRLabel();
            this.lnome = new DevExpress.XtraReports.UI.XRLabel();
            this.lemissaorg = new DevExpress.XtraReports.UI.XRLabel();
            this.lrg = new DevExpress.XtraReports.UI.XRLabel();
            this.lcnpj = new DevExpress.XtraReports.UI.XRLabel();
            this.lapelido = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.ltusuario = new DevExpress.XtraReports.UI.XRLabel();
            this.ltempresa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ltitulorelatorio = new DevExpress.XtraReports.UI.XRLabel();
            this.grupocabecalho = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.grupofiltros = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lfcliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lcaminho = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.ltotquant = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lobs4,
            this.lobs3,
            this.lobs2,
            this.lobs1,
            this.lufrgconjuge,
            this.ldtnascimentoconjuge,
            this.lfoneconjuge,
            this.lmailconjuge,
            this.lsexoconjuge,
            this.lorgaorgconjuge,
            this.lcnpjconjuge,
            this.lrgconjuge,
            this.lnomeconjuge,
            this.lemissaorgconjuge,
            this.lmail5,
            this.lmail4,
            this.lmail3,
            this.lmail2,
            this.lmail1,
            this.lendcomcep,
            this.lendcomuf,
            this.lfone1com,
            this.lfone3com,
            this.lfone2com,
            this.lendcomnumero,
            this.lendcom,
            this.lendcomcomplem,
            this.lendcomcidade,
            this.lendcombairro,
            this.lfone3res,
            this.lfone2res,
            this.lfone1res,
            this.lendrescep,
            this.lendresuf,
            this.lendrescidade,
            this.lendresbairro,
            this.lendrescomplem,
            this.lendresnumero,
            this.xrLine1,
            this.linscrestadual,
            this.lendres,
            this.lsexo,
            this.linscrmunicipal,
            this.lufrg,
            this.ldtnascimento,
            this.lorgaorg,
            this.lnome,
            this.lemissaorg,
            this.lrg,
            this.lcnpj,
            this.lapelido});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 74.58331F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // lobs4
            // 
            this.lobs4.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lobs4.ForeColor = System.Drawing.Color.Black;
            this.lobs4.LocationFloat = new DevExpress.Utils.PointFloat(859.6904F, 55.04169F);
            this.lobs4.Name = "lobs4";
            this.lobs4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lobs4.SizeF = new System.Drawing.SizeF(188.3097F, 10.00001F);
            this.lobs4.StylePriority.UseBackColor = false;
            this.lobs4.StylePriority.UseFont = false;
            this.lobs4.Text = "lobs4";
            this.lobs4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lobs4.WordWrap = false;
            // 
            // lobs3
            // 
            this.lobs3.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lobs3.ForeColor = System.Drawing.Color.Black;
            this.lobs3.LocationFloat = new DevExpress.Utils.PointFloat(573.4603F, 55.04169F);
            this.lobs3.Name = "lobs3";
            this.lobs3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lobs3.SizeF = new System.Drawing.SizeF(286.2301F, 9.999998F);
            this.lobs3.StylePriority.UseBackColor = false;
            this.lobs3.StylePriority.UseFont = false;
            this.lobs3.Text = "lobs3";
            this.lobs3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lobs3.WordWrap = false;
            // 
            // lobs2
            // 
            this.lobs2.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lobs2.ForeColor = System.Drawing.Color.Black;
            this.lobs2.LocationFloat = new DevExpress.Utils.PointFloat(287.2303F, 55.04169F);
            this.lobs2.Name = "lobs2";
            this.lobs2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lobs2.SizeF = new System.Drawing.SizeF(286.2301F, 9.999998F);
            this.lobs2.StylePriority.UseBackColor = false;
            this.lobs2.StylePriority.UseFont = false;
            this.lobs2.Text = "lobs2";
            this.lobs2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lobs2.WordWrap = false;
            // 
            // lobs1
            // 
            this.lobs1.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lobs1.ForeColor = System.Drawing.Color.Black;
            this.lobs1.LocationFloat = new DevExpress.Utils.PointFloat(1.000166F, 55.04167F);
            this.lobs1.Name = "lobs1";
            this.lobs1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lobs1.SizeF = new System.Drawing.SizeF(286.2301F, 9.999998F);
            this.lobs1.StylePriority.UseBackColor = false;
            this.lobs1.StylePriority.UseFont = false;
            this.lobs1.Text = "lobs1";
            this.lobs1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lobs1.WordWrap = false;
            // 
            // lufrgconjuge
            // 
            this.lufrgconjuge.Font = new System.Drawing.Font("Calibri", 7F);
            this.lufrgconjuge.ForeColor = System.Drawing.Color.Black;
            this.lufrgconjuge.LocationFloat = new DevExpress.Utils.PointFloat(437.0989F, 44.04165F);
            this.lufrgconjuge.Name = "lufrgconjuge";
            this.lufrgconjuge.NullValueText = " ";
            this.lufrgconjuge.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lufrgconjuge.SizeF = new System.Drawing.SizeF(42.95807F, 9.999999F);
            this.lufrgconjuge.StylePriority.UseBackColor = false;
            this.lufrgconjuge.StylePriority.UseFont = false;
            this.lufrgconjuge.Text = "lufrgconjuge";
            this.lufrgconjuge.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lufrgconjuge.WordWrap = false;
            // 
            // ldtnascimentoconjuge
            // 
            this.ldtnascimentoconjuge.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldtnascimentoconjuge.ForeColor = System.Drawing.Color.Black;
            this.ldtnascimentoconjuge.LocationFloat = new DevExpress.Utils.PointFloat(620.8796F, 44.04165F);
            this.ldtnascimentoconjuge.Name = "ldtnascimentoconjuge";
            this.ldtnascimentoconjuge.NullValueText = " ";
            this.ldtnascimentoconjuge.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldtnascimentoconjuge.SizeF = new System.Drawing.SizeF(61.62915F, 9.999999F);
            this.ldtnascimentoconjuge.StylePriority.UseBackColor = false;
            this.ldtnascimentoconjuge.StylePriority.UseFont = false;
            this.ldtnascimentoconjuge.Text = "ldtnascimentoconjuge";
            this.ldtnascimentoconjuge.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.ldtnascimentoconjuge.WordWrap = false;
            // 
            // lfoneconjuge
            // 
            this.lfoneconjuge.Font = new System.Drawing.Font("Calibri", 7F);
            this.lfoneconjuge.ForeColor = System.Drawing.Color.Black;
            this.lfoneconjuge.LocationFloat = new DevExpress.Utils.PointFloat(752.5928F, 44.04166F);
            this.lfoneconjuge.Name = "lfoneconjuge";
            this.lfoneconjuge.NullValueText = " ";
            this.lfoneconjuge.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfoneconjuge.SizeF = new System.Drawing.SizeF(152.4073F, 10F);
            this.lfoneconjuge.StylePriority.UseBackColor = false;
            this.lfoneconjuge.StylePriority.UseFont = false;
            this.lfoneconjuge.Text = "lfoneconjuge";
            this.lfoneconjuge.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lfoneconjuge.WordWrap = false;
            // 
            // lmailconjuge
            // 
            this.lmailconjuge.Font = new System.Drawing.Font("Calibri", 7F);
            this.lmailconjuge.ForeColor = System.Drawing.Color.Black;
            this.lmailconjuge.LocationFloat = new DevExpress.Utils.PointFloat(905.0002F, 44.04166F);
            this.lmailconjuge.Name = "lmailconjuge";
            this.lmailconjuge.NullValueText = " ";
            this.lmailconjuge.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lmailconjuge.SizeF = new System.Drawing.SizeF(143.9996F, 10F);
            this.lmailconjuge.StylePriority.UseBackColor = false;
            this.lmailconjuge.StylePriority.UseFont = false;
            this.lmailconjuge.Text = "lmailconjuge";
            this.lmailconjuge.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lmailconjuge.WordWrap = false;
            // 
            // lsexoconjuge
            // 
            this.lsexoconjuge.Font = new System.Drawing.Font("Calibri", 7F);
            this.lsexoconjuge.ForeColor = System.Drawing.Color.Black;
            this.lsexoconjuge.LocationFloat = new DevExpress.Utils.PointFloat(683.3008F, 44.04165F);
            this.lsexoconjuge.Name = "lsexoconjuge";
            this.lsexoconjuge.NullValueText = " ";
            this.lsexoconjuge.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsexoconjuge.SizeF = new System.Drawing.SizeF(69.29211F, 10F);
            this.lsexoconjuge.StylePriority.UseBackColor = false;
            this.lsexoconjuge.StylePriority.UseFont = false;
            this.lsexoconjuge.Text = "lsexoconjuge";
            this.lsexoconjuge.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lsexoconjuge.WordWrap = false;
            // 
            // lorgaorgconjuge
            // 
            this.lorgaorgconjuge.Font = new System.Drawing.Font("Calibri", 7F);
            this.lorgaorgconjuge.ForeColor = System.Drawing.Color.Black;
            this.lorgaorgconjuge.LocationFloat = new DevExpress.Utils.PointFloat(546.9974F, 44.04166F);
            this.lorgaorgconjuge.Name = "lorgaorgconjuge";
            this.lorgaorgconjuge.NullValueText = " ";
            this.lorgaorgconjuge.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lorgaorgconjuge.SizeF = new System.Drawing.SizeF(73.8822F, 10F);
            this.lorgaorgconjuge.StylePriority.UseBackColor = false;
            this.lorgaorgconjuge.StylePriority.UseFont = false;
            this.lorgaorgconjuge.Text = "lorgaorgconjuge";
            this.lorgaorgconjuge.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lorgaorgconjuge.WordWrap = false;
            // 
            // lcnpjconjuge
            // 
            this.lcnpjconjuge.Font = new System.Drawing.Font("Calibri", 7F);
            this.lcnpjconjuge.ForeColor = System.Drawing.Color.Black;
            this.lcnpjconjuge.LocationFloat = new DevExpress.Utils.PointFloat(203.2302F, 44.04165F);
            this.lcnpjconjuge.Name = "lcnpjconjuge";
            this.lcnpjconjuge.NullValueText = " ";
            this.lcnpjconjuge.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcnpjconjuge.SizeF = new System.Drawing.SizeF(131.42F, 10F);
            this.lcnpjconjuge.StylePriority.UseBackColor = false;
            this.lcnpjconjuge.StylePriority.UseFont = false;
            this.lcnpjconjuge.Text = "lcnpjconjuge";
            this.lcnpjconjuge.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lcnpjconjuge.WordWrap = false;
            // 
            // lrgconjuge
            // 
            this.lrgconjuge.Font = new System.Drawing.Font("Calibri", 7F);
            this.lrgconjuge.ForeColor = System.Drawing.Color.Black;
            this.lrgconjuge.LocationFloat = new DevExpress.Utils.PointFloat(334.6502F, 44.04165F);
            this.lrgconjuge.Name = "lrgconjuge";
            this.lrgconjuge.NullValueText = " ";
            this.lrgconjuge.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lrgconjuge.SizeF = new System.Drawing.SizeF(102.4488F, 9.999999F);
            this.lrgconjuge.StylePriority.UseBackColor = false;
            this.lrgconjuge.StylePriority.UseFont = false;
            this.lrgconjuge.Text = "lrgconjuge";
            this.lrgconjuge.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lrgconjuge.WordWrap = false;
            // 
            // lnomeconjuge
            // 
            this.lnomeconjuge.Font = new System.Drawing.Font("Calibri", 7F);
            this.lnomeconjuge.ForeColor = System.Drawing.Color.Black;
            this.lnomeconjuge.LocationFloat = new DevExpress.Utils.PointFloat(0.631691F, 44.04165F);
            this.lnomeconjuge.Name = "lnomeconjuge";
            this.lnomeconjuge.NullValueText = " ";
            this.lnomeconjuge.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lnomeconjuge.SizeF = new System.Drawing.SizeF(202.5985F, 10F);
            this.lnomeconjuge.StylePriority.UseBackColor = false;
            this.lnomeconjuge.StylePriority.UseFont = false;
            this.lnomeconjuge.Text = "lnomeconjuge";
            this.lnomeconjuge.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lnomeconjuge.WordWrap = false;
            // 
            // lemissaorgconjuge
            // 
            this.lemissaorgconjuge.Font = new System.Drawing.Font("Calibri", 7F);
            this.lemissaorgconjuge.ForeColor = System.Drawing.Color.Black;
            this.lemissaorgconjuge.LocationFloat = new DevExpress.Utils.PointFloat(480.0572F, 44.04166F);
            this.lemissaorgconjuge.Name = "lemissaorgconjuge";
            this.lemissaorgconjuge.NullValueText = " ";
            this.lemissaorgconjuge.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lemissaorgconjuge.SizeF = new System.Drawing.SizeF(66.94016F, 10F);
            this.lemissaorgconjuge.StylePriority.UseBackColor = false;
            this.lemissaorgconjuge.StylePriority.UseFont = false;
            this.lemissaorgconjuge.Text = "lemissaorgconjuge";
            this.lemissaorgconjuge.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lemissaorgconjuge.WordWrap = false;
            // 
            // lmail5
            // 
            this.lmail5.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lmail5.ForeColor = System.Drawing.Color.Black;
            this.lmail5.LocationFloat = new DevExpress.Utils.PointFloat(801.4602F, 33.54165F);
            this.lmail5.Name = "lmail5";
            this.lmail5.NullValueText = " ";
            this.lmail5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lmail5.SizeF = new System.Drawing.SizeF(247.5397F, 10F);
            this.lmail5.StylePriority.UseBackColor = false;
            this.lmail5.StylePriority.UseFont = false;
            this.lmail5.Text = "lmail5";
            this.lmail5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lmail5.WordWrap = false;
            // 
            // lmail4
            // 
            this.lmail4.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lmail4.ForeColor = System.Drawing.Color.Black;
            this.lmail4.LocationFloat = new DevExpress.Utils.PointFloat(601.4602F, 33.54165F);
            this.lmail4.Name = "lmail4";
            this.lmail4.NullValueText = " ";
            this.lmail4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lmail4.SizeF = new System.Drawing.SizeF(200F, 10F);
            this.lmail4.StylePriority.UseBackColor = false;
            this.lmail4.StylePriority.UseFont = false;
            this.lmail4.Text = "lmail4";
            this.lmail4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lmail4.WordWrap = false;
            // 
            // lmail3
            // 
            this.lmail3.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lmail3.ForeColor = System.Drawing.Color.Black;
            this.lmail3.LocationFloat = new DevExpress.Utils.PointFloat(401.4602F, 33.54166F);
            this.lmail3.Name = "lmail3";
            this.lmail3.NullValueText = " ";
            this.lmail3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lmail3.SizeF = new System.Drawing.SizeF(200F, 10F);
            this.lmail3.StylePriority.UseBackColor = false;
            this.lmail3.StylePriority.UseFont = false;
            this.lmail3.Text = "lmail3";
            this.lmail3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lmail3.WordWrap = false;
            // 
            // lmail2
            // 
            this.lmail2.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lmail2.ForeColor = System.Drawing.Color.Black;
            this.lmail2.LocationFloat = new DevExpress.Utils.PointFloat(201.2301F, 33.54165F);
            this.lmail2.Name = "lmail2";
            this.lmail2.NullValueText = " ";
            this.lmail2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lmail2.SizeF = new System.Drawing.SizeF(200F, 10F);
            this.lmail2.StylePriority.UseBackColor = false;
            this.lmail2.StylePriority.UseFont = false;
            this.lmail2.Text = "lmail2";
            this.lmail2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lmail2.WordWrap = false;
            // 
            // lmail1
            // 
            this.lmail1.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lmail1.ForeColor = System.Drawing.Color.Black;
            this.lmail1.LocationFloat = new DevExpress.Utils.PointFloat(1F, 33.54166F);
            this.lmail1.Name = "lmail1";
            this.lmail1.NullValueText = " ";
            this.lmail1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lmail1.SizeF = new System.Drawing.SizeF(200F, 10F);
            this.lmail1.StylePriority.UseBackColor = false;
            this.lmail1.StylePriority.UseFont = false;
            this.lmail1.Text = "lmail1";
            this.lmail1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lmail1.WordWrap = false;
            // 
            // lendcomcep
            // 
            this.lendcomcep.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lendcomcep.ForeColor = System.Drawing.Color.Black;
            this.lendcomcep.LocationFloat = new DevExpress.Utils.PointFloat(648.2974F, 22.54166F);
            this.lendcomcep.Name = "lendcomcep";
            this.lendcomcep.NullValueText = " ";
            this.lendcomcep.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendcomcep.SizeF = new System.Drawing.SizeF(56.58215F, 10F);
            this.lendcomcep.StylePriority.UseBackColor = false;
            this.lendcomcep.StylePriority.UseFont = false;
            this.lendcomcep.Text = "lendcomcep";
            this.lendcomcep.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lendcomcep.WordWrap = false;
            // 
            // lendcomuf
            // 
            this.lendcomuf.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lendcomuf.ForeColor = System.Drawing.Color.Black;
            this.lendcomuf.LocationFloat = new DevExpress.Utils.PointFloat(594.4839F, 22.54166F);
            this.lendcomuf.Name = "lendcomuf";
            this.lendcomuf.NullValueText = " ";
            this.lendcomuf.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendcomuf.SizeF = new System.Drawing.SizeF(52.8551F, 10F);
            this.lendcomuf.StylePriority.UseBackColor = false;
            this.lendcomuf.StylePriority.UseFont = false;
            this.lendcomuf.Text = "lendcomuf";
            this.lendcomuf.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lendcomuf.WordWrap = false;
            // 
            // lfone1com
            // 
            this.lfone1com.Font = new System.Drawing.Font("Calibri", 7F);
            this.lfone1com.ForeColor = System.Drawing.Color.Black;
            this.lfone1com.LocationFloat = new DevExpress.Utils.PointFloat(704.8797F, 22.54164F);
            this.lfone1com.Name = "lfone1com";
            this.lfone1com.NullValueText = " ";
            this.lfone1com.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfone1com.SizeF = new System.Drawing.SizeF(123.9993F, 10F);
            this.lfone1com.StylePriority.UseBackColor = false;
            this.lfone1com.StylePriority.UseFont = false;
            this.lfone1com.Text = "lfone1com";
            this.lfone1com.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lfone1com.WordWrap = false;
            // 
            // lfone3com
            // 
            this.lfone3com.Font = new System.Drawing.Font("Calibri", 7F);
            this.lfone3com.ForeColor = System.Drawing.Color.Black;
            this.lfone3com.LocationFloat = new DevExpress.Utils.PointFloat(939.0005F, 22.54166F);
            this.lfone3com.Name = "lfone3com";
            this.lfone3com.NullValueText = " ";
            this.lfone3com.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfone3com.SizeF = new System.Drawing.SizeF(109.9996F, 10F);
            this.lfone3com.StylePriority.UseBackColor = false;
            this.lfone3com.StylePriority.UseFont = false;
            this.lfone3com.Text = "lfone3com";
            this.lfone3com.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lfone3com.WordWrap = false;
            // 
            // lfone2com
            // 
            this.lfone2com.Font = new System.Drawing.Font("Calibri", 7F);
            this.lfone2com.ForeColor = System.Drawing.Color.Black;
            this.lfone2com.LocationFloat = new DevExpress.Utils.PointFloat(828.879F, 22.54166F);
            this.lfone2com.Name = "lfone2com";
            this.lfone2com.NullValueText = " ";
            this.lfone2com.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfone2com.SizeF = new System.Drawing.SizeF(109.9996F, 10F);
            this.lfone2com.StylePriority.UseBackColor = false;
            this.lfone2com.StylePriority.UseFont = false;
            this.lfone2com.Text = "lfone2com";
            this.lfone2com.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lfone2com.WordWrap = false;
            // 
            // lendcomnumero
            // 
            this.lendcomnumero.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lendcomnumero.ForeColor = System.Drawing.Color.Black;
            this.lendcomnumero.LocationFloat = new DevExpress.Utils.PointFloat(287.23F, 22.54166F);
            this.lendcomnumero.Name = "lendcomnumero";
            this.lendcomnumero.NullValueText = " ";
            this.lendcomnumero.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendcomnumero.SizeF = new System.Drawing.SizeF(76.81345F, 10F);
            this.lendcomnumero.StylePriority.UseBackColor = false;
            this.lendcomnumero.StylePriority.UseFont = false;
            this.lendcomnumero.Text = "lendcomnumero";
            this.lendcomnumero.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lendcomnumero.WordWrap = false;
            // 
            // lendcom
            // 
            this.lendcom.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lendcom.ForeColor = System.Drawing.Color.Black;
            this.lendcom.LocationFloat = new DevExpress.Utils.PointFloat(0.999999F, 22.54165F);
            this.lendcom.Name = "lendcom";
            this.lendcom.NullValueText = " ";
            this.lendcom.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendcom.SizeF = new System.Drawing.SizeF(286.2301F, 9.999998F);
            this.lendcom.StylePriority.UseBackColor = false;
            this.lendcom.StylePriority.UseFont = false;
            this.lendcom.Text = "lendcom";
            this.lendcom.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lendcom.WordWrap = false;
            // 
            // lendcomcomplem
            // 
            this.lendcomcomplem.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lendcomcomplem.ForeColor = System.Drawing.Color.Black;
            this.lendcomcomplem.LocationFloat = new DevExpress.Utils.PointFloat(364.0435F, 22.54166F);
            this.lendcomcomplem.Name = "lendcomcomplem";
            this.lendcomcomplem.NullValueText = " ";
            this.lendcomcomplem.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendcomcomplem.SizeF = new System.Drawing.SizeF(76.81345F, 10F);
            this.lendcomcomplem.StylePriority.UseBackColor = false;
            this.lendcomcomplem.StylePriority.UseFont = false;
            this.lendcomcomplem.Text = "lendcomcomplem";
            this.lendcomcomplem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lendcomcomplem.WordWrap = false;
            // 
            // lendcomcidade
            // 
            this.lendcomcidade.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lendcomcidade.ForeColor = System.Drawing.Color.Black;
            this.lendcomcidade.LocationFloat = new DevExpress.Utils.PointFloat(517.6704F, 22.54166F);
            this.lendcomcidade.Name = "lendcomcidade";
            this.lendcomcidade.NullValueText = " ";
            this.lendcomcidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendcomcidade.SizeF = new System.Drawing.SizeF(76.81345F, 10F);
            this.lendcomcidade.StylePriority.UseBackColor = false;
            this.lendcomcidade.StylePriority.UseFont = false;
            this.lendcomcidade.Text = "lendcomcidade";
            this.lendcomcidade.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lendcomcidade.WordWrap = false;
            // 
            // lendcombairro
            // 
            this.lendcombairro.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lendcombairro.ForeColor = System.Drawing.Color.Black;
            this.lendcombairro.LocationFloat = new DevExpress.Utils.PointFloat(440.8569F, 22.54166F);
            this.lendcombairro.Name = "lendcombairro";
            this.lendcombairro.NullValueText = " ";
            this.lendcombairro.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendcombairro.SizeF = new System.Drawing.SizeF(76.81345F, 10F);
            this.lendcombairro.StylePriority.UseBackColor = false;
            this.lendcombairro.StylePriority.UseFont = false;
            this.lendcombairro.Text = "lendcombairro";
            this.lendcombairro.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lendcombairro.WordWrap = false;
            // 
            // lfone3res
            // 
            this.lfone3res.Font = new System.Drawing.Font("Calibri", 7F);
            this.lfone3res.ForeColor = System.Drawing.Color.Black;
            this.lfone3res.LocationFloat = new DevExpress.Utils.PointFloat(939.0006F, 11F);
            this.lfone3res.Name = "lfone3res";
            this.lfone3res.NullValueText = " ";
            this.lfone3res.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfone3res.SizeF = new System.Drawing.SizeF(109.9996F, 10F);
            this.lfone3res.StylePriority.UseBackColor = false;
            this.lfone3res.StylePriority.UseFont = false;
            this.lfone3res.Text = "lfone3res";
            this.lfone3res.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lfone3res.WordWrap = false;
            // 
            // lfone2res
            // 
            this.lfone2res.Font = new System.Drawing.Font("Calibri", 7F);
            this.lfone2res.ForeColor = System.Drawing.Color.Black;
            this.lfone2res.LocationFloat = new DevExpress.Utils.PointFloat(828.8792F, 11F);
            this.lfone2res.Name = "lfone2res";
            this.lfone2res.NullValueText = " ";
            this.lfone2res.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfone2res.SizeF = new System.Drawing.SizeF(109.9996F, 10F);
            this.lfone2res.StylePriority.UseBackColor = false;
            this.lfone2res.StylePriority.UseFont = false;
            this.lfone2res.Text = "lfone2res";
            this.lfone2res.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lfone2res.WordWrap = false;
            // 
            // lfone1res
            // 
            this.lfone1res.Font = new System.Drawing.Font("Calibri", 7F);
            this.lfone1res.ForeColor = System.Drawing.Color.Black;
            this.lfone1res.LocationFloat = new DevExpress.Utils.PointFloat(704.8796F, 11F);
            this.lfone1res.Name = "lfone1res";
            this.lfone1res.NullValueText = " ";
            this.lfone1res.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfone1res.SizeF = new System.Drawing.SizeF(123.9996F, 9.999999F);
            this.lfone1res.StylePriority.UseBackColor = false;
            this.lfone1res.StylePriority.UseFont = false;
            this.lfone1res.Text = "lfone1res";
            this.lfone1res.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lfone1res.WordWrap = false;
            // 
            // lendrescep
            // 
            this.lendrescep.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lendrescep.ForeColor = System.Drawing.Color.Black;
            this.lendrescep.LocationFloat = new DevExpress.Utils.PointFloat(648.2975F, 11F);
            this.lendrescep.Name = "lendrescep";
            this.lendrescep.NullValueText = " ";
            this.lendrescep.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendrescep.SizeF = new System.Drawing.SizeF(56.58215F, 10F);
            this.lendrescep.StylePriority.UseBackColor = false;
            this.lendrescep.StylePriority.UseFont = false;
            this.lendrescep.Text = "lendrescep";
            this.lendrescep.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lendrescep.WordWrap = false;
            // 
            // lendresuf
            // 
            this.lendresuf.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lendresuf.ForeColor = System.Drawing.Color.Black;
            this.lendresuf.LocationFloat = new DevExpress.Utils.PointFloat(594.484F, 11F);
            this.lendresuf.Name = "lendresuf";
            this.lendresuf.NullValueText = " ";
            this.lendresuf.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendresuf.SizeF = new System.Drawing.SizeF(52.8551F, 10F);
            this.lendresuf.StylePriority.UseBackColor = false;
            this.lendresuf.StylePriority.UseFont = false;
            this.lendresuf.Text = "lendresuf";
            this.lendresuf.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lendresuf.WordWrap = false;
            // 
            // lendrescidade
            // 
            this.lendrescidade.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lendrescidade.ForeColor = System.Drawing.Color.Black;
            this.lendrescidade.LocationFloat = new DevExpress.Utils.PointFloat(518.0988F, 11F);
            this.lendrescidade.Name = "lendrescidade";
            this.lendrescidade.NullValueText = " ";
            this.lendrescidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendrescidade.SizeF = new System.Drawing.SizeF(76.38519F, 9.999999F);
            this.lendrescidade.StylePriority.UseBackColor = false;
            this.lendrescidade.StylePriority.UseFont = false;
            this.lendrescidade.Text = "lendrescidade";
            this.lendrescidade.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lendrescidade.WordWrap = false;
            // 
            // lendresbairro
            // 
            this.lendresbairro.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lendresbairro.ForeColor = System.Drawing.Color.Black;
            this.lendresbairro.LocationFloat = new DevExpress.Utils.PointFloat(440.8571F, 11F);
            this.lendresbairro.Name = "lendresbairro";
            this.lendresbairro.NullValueText = " ";
            this.lendresbairro.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendresbairro.SizeF = new System.Drawing.SizeF(76.81345F, 10F);
            this.lendresbairro.StylePriority.UseBackColor = false;
            this.lendresbairro.StylePriority.UseFont = false;
            this.lendresbairro.Text = "lendresbairro";
            this.lendresbairro.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lendresbairro.WordWrap = false;
            // 
            // lendrescomplem
            // 
            this.lendrescomplem.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lendrescomplem.ForeColor = System.Drawing.Color.Black;
            this.lendrescomplem.LocationFloat = new DevExpress.Utils.PointFloat(364.0436F, 11F);
            this.lendrescomplem.Name = "lendrescomplem";
            this.lendrescomplem.NullValueText = " ";
            this.lendrescomplem.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendrescomplem.SizeF = new System.Drawing.SizeF(76.81345F, 10F);
            this.lendrescomplem.StylePriority.UseBackColor = false;
            this.lendrescomplem.StylePriority.UseFont = false;
            this.lendrescomplem.Text = "lendrescomplem";
            this.lendrescomplem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lendrescomplem.WordWrap = false;
            // 
            // lendresnumero
            // 
            this.lendresnumero.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lendresnumero.ForeColor = System.Drawing.Color.Black;
            this.lendresnumero.LocationFloat = new DevExpress.Utils.PointFloat(287.2302F, 11F);
            this.lendresnumero.Name = "lendresnumero";
            this.lendresnumero.NullValueText = " ";
            this.lendresnumero.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendresnumero.SizeF = new System.Drawing.SizeF(76.81345F, 10F);
            this.lendresnumero.StylePriority.UseBackColor = false;
            this.lendresnumero.StylePriority.UseFont = false;
            this.lendresnumero.Text = "lendresnumero";
            this.lendresnumero.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lendresnumero.WordWrap = false;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(1F, 65.04167F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
            // 
            // linscrestadual
            // 
            this.linscrestadual.Font = new System.Drawing.Font("Calibri", 7F);
            this.linscrestadual.ForeColor = System.Drawing.Color.Black;
            this.linscrestadual.LocationFloat = new DevExpress.Utils.PointFloat(939.0002F, 0.9999911F);
            this.linscrestadual.Name = "linscrestadual";
            this.linscrestadual.NullValueText = " ";
            this.linscrestadual.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linscrestadual.SizeF = new System.Drawing.SizeF(109.9996F, 10F);
            this.linscrestadual.StylePriority.UseBackColor = false;
            this.linscrestadual.StylePriority.UseFont = false;
            this.linscrestadual.Text = "linscrestadual";
            this.linscrestadual.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.linscrestadual.WordWrap = false;
            // 
            // lendres
            // 
            this.lendres.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lendres.ForeColor = System.Drawing.Color.Black;
            this.lendres.LocationFloat = new DevExpress.Utils.PointFloat(0.999999F, 11F);
            this.lendres.Name = "lendres";
            this.lendres.NullValueText = " ";
            this.lendres.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendres.SizeF = new System.Drawing.SizeF(286.2302F, 9.999999F);
            this.lendres.StylePriority.UseBackColor = false;
            this.lendres.StylePriority.UseFont = false;
            this.lendres.Text = "lendres";
            this.lendres.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lendres.WordWrap = false;
            // 
            // lsexo
            // 
            this.lsexo.Font = new System.Drawing.Font("Calibri", 7F);
            this.lsexo.ForeColor = System.Drawing.Color.Black;
            this.lsexo.LocationFloat = new DevExpress.Utils.PointFloat(767.3007F, 0F);
            this.lsexo.Name = "lsexo";
            this.lsexo.NullValueText = " ";
            this.lsexo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsexo.SizeF = new System.Drawing.SizeF(69.29211F, 10F);
            this.lsexo.StylePriority.UseBackColor = false;
            this.lsexo.StylePriority.UseFont = false;
            this.lsexo.Text = "lsexo";
            this.lsexo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lsexo.WordWrap = false;
            // 
            // linscrmunicipal
            // 
            this.linscrmunicipal.Font = new System.Drawing.Font("Calibri", 7F);
            this.linscrmunicipal.ForeColor = System.Drawing.Color.Black;
            this.linscrmunicipal.LocationFloat = new DevExpress.Utils.PointFloat(836.5928F, 0F);
            this.linscrmunicipal.Name = "linscrmunicipal";
            this.linscrmunicipal.NullValueText = " ";
            this.linscrmunicipal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linscrmunicipal.SizeF = new System.Drawing.SizeF(102.4073F, 10F);
            this.linscrmunicipal.StylePriority.UseBackColor = false;
            this.linscrmunicipal.StylePriority.UseFont = false;
            this.linscrmunicipal.Text = "linscrmunicipal";
            this.linscrmunicipal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.linscrmunicipal.WordWrap = false;
            // 
            // lufrg
            // 
            this.lufrg.Font = new System.Drawing.Font("Calibri", 7F);
            this.lufrg.ForeColor = System.Drawing.Color.Black;
            this.lufrg.LocationFloat = new DevExpress.Utils.PointFloat(521.0989F, 0F);
            this.lufrg.Name = "lufrg";
            this.lufrg.NullValueText = " ";
            this.lufrg.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lufrg.SizeF = new System.Drawing.SizeF(42.95807F, 9.999999F);
            this.lufrg.StylePriority.UseBackColor = false;
            this.lufrg.StylePriority.UseFont = false;
            this.lufrg.Text = "lufrg";
            this.lufrg.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lufrg.WordWrap = false;
            // 
            // ldtnascimento
            // 
            this.ldtnascimento.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldtnascimento.ForeColor = System.Drawing.Color.Black;
            this.ldtnascimento.LocationFloat = new DevExpress.Utils.PointFloat(704.8796F, 0F);
            this.ldtnascimento.Name = "ldtnascimento";
            this.ldtnascimento.NullValueText = " ";
            this.ldtnascimento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldtnascimento.SizeF = new System.Drawing.SizeF(61.62915F, 9.999999F);
            this.ldtnascimento.StylePriority.UseBackColor = false;
            this.ldtnascimento.StylePriority.UseFont = false;
            this.ldtnascimento.Text = "ldtnascimento";
            this.ldtnascimento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.ldtnascimento.WordWrap = false;
            // 
            // lorgaorg
            // 
            this.lorgaorg.Font = new System.Drawing.Font("Calibri", 7F);
            this.lorgaorg.ForeColor = System.Drawing.Color.Black;
            this.lorgaorg.LocationFloat = new DevExpress.Utils.PointFloat(620.8796F, 0F);
            this.lorgaorg.Name = "lorgaorg";
            this.lorgaorg.NullValueText = " ";
            this.lorgaorg.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lorgaorg.SizeF = new System.Drawing.SizeF(83.99994F, 10F);
            this.lorgaorg.StylePriority.UseBackColor = false;
            this.lorgaorg.StylePriority.UseFont = false;
            this.lorgaorg.Text = "lorgaorg";
            this.lorgaorg.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lorgaorg.WordWrap = false;
            // 
            // lnome
            // 
            this.lnome.Font = new System.Drawing.Font("Calibri", 7F);
            this.lnome.ForeColor = System.Drawing.Color.Black;
            this.lnome.LocationFloat = new DevExpress.Utils.PointFloat(87.23019F, 0F);
            this.lnome.Name = "lnome";
            this.lnome.NullValueText = " ";
            this.lnome.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lnome.SizeF = new System.Drawing.SizeF(200F, 10F);
            this.lnome.StylePriority.UseBackColor = false;
            this.lnome.StylePriority.UseFont = false;
            this.lnome.Text = "lnome";
            this.lnome.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lnome.WordWrap = false;
            // 
            // lemissaorg
            // 
            this.lemissaorg.Font = new System.Drawing.Font("Calibri", 7F);
            this.lemissaorg.ForeColor = System.Drawing.Color.Black;
            this.lemissaorg.LocationFloat = new DevExpress.Utils.PointFloat(564.057F, 0F);
            this.lemissaorg.Name = "lemissaorg";
            this.lemissaorg.NullValueText = " ";
            this.lemissaorg.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lemissaorg.SizeF = new System.Drawing.SizeF(56.82263F, 9.999999F);
            this.lemissaorg.StylePriority.UseBackColor = false;
            this.lemissaorg.StylePriority.UseFont = false;
            this.lemissaorg.Text = "lemissaorg";
            this.lemissaorg.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lemissaorg.WordWrap = false;
            // 
            // lrg
            // 
            this.lrg.Font = new System.Drawing.Font("Calibri", 7F);
            this.lrg.ForeColor = System.Drawing.Color.Black;
            this.lrg.LocationFloat = new DevExpress.Utils.PointFloat(418.6502F, 0F);
            this.lrg.Name = "lrg";
            this.lrg.NullValueText = " ";
            this.lrg.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lrg.SizeF = new System.Drawing.SizeF(102.4488F, 9.999999F);
            this.lrg.StylePriority.UseBackColor = false;
            this.lrg.StylePriority.UseFont = false;
            this.lrg.Text = "lrg";
            this.lrg.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lrg.WordWrap = false;
            // 
            // lcnpj
            // 
            this.lcnpj.Font = new System.Drawing.Font("Calibri", 7F);
            this.lcnpj.ForeColor = System.Drawing.Color.Black;
            this.lcnpj.LocationFloat = new DevExpress.Utils.PointFloat(287.2302F, 0F);
            this.lcnpj.Name = "lcnpj";
            this.lcnpj.NullValueText = " ";
            this.lcnpj.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcnpj.SizeF = new System.Drawing.SizeF(131.42F, 10F);
            this.lcnpj.StylePriority.UseBackColor = false;
            this.lcnpj.StylePriority.UseFont = false;
            this.lcnpj.Text = "lcnpj";
            this.lcnpj.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lcnpj.WordWrap = false;
            // 
            // lapelido
            // 
            this.lapelido.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lapelido.ForeColor = System.Drawing.Color.Black;
            this.lapelido.LocationFloat = new DevExpress.Utils.PointFloat(0.999999F, 0F);
            this.lapelido.Name = "lapelido";
            this.lapelido.NullValueText = " ";
            this.lapelido.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lapelido.SizeF = new System.Drawing.SizeF(86.23016F, 10F);
            this.lapelido.StylePriority.UseBackColor = false;
            this.lapelido.StylePriority.UseFont = false;
            this.lapelido.Text = "lapelido";
            this.lapelido.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lapelido.WordWrap = false;
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
            this.ltusuario.LocationFloat = new DevExpress.Utils.PointFloat(910.0001F, 14F);
            this.ltusuario.Name = "ltusuario";
            this.ltusuario.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltusuario.SizeF = new System.Drawing.SizeF(128.9999F, 14F);
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
            this.ltempresa.LocationFloat = new DevExpress.Utils.PointFloat(271.0265F, 40.91218F);
            this.ltempresa.Name = "ltempresa";
            this.ltempresa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltempresa.SizeF = new System.Drawing.SizeF(461.0147F, 17.08783F);
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
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(806.3752F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(230.62F, 14F);
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
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(939.0001F, 28.00001F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(100F, 14F);
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
            this.ltitulorelatorio.LocationFloat = new DevExpress.Utils.PointFloat(271.0265F, 14F);
            this.ltitulorelatorio.Name = "ltitulorelatorio";
            this.ltitulorelatorio.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulorelatorio.SizeF = new System.Drawing.SizeF(461.0147F, 21.54171F);
            this.ltitulorelatorio.StylePriority.UseBackColor = false;
            this.ltitulorelatorio.StylePriority.UseBorderColor = false;
            this.ltitulorelatorio.StylePriority.UseBorders = false;
            this.ltitulorelatorio.StylePriority.UseFont = false;
            this.ltitulorelatorio.StylePriority.UseForeColor = false;
            this.ltitulorelatorio.StylePriority.UseTextAlignment = false;
            this.ltitulorelatorio.Text = "RELATÓRIO CLIENTE CADASTRO TOTAL";
            this.ltitulorelatorio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // grupocabecalho
            // 
            this.grupocabecalho.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel6,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel13,
            this.xrLabel9,
            this.xrLabel1,
            this.xrLabel7,
            this.xrLabel5,
            this.xrLabel2,
            this.xrLabel17,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel3,
            this.xrLabel18,
            this.xrLabel26,
            this.xrLabel19});
            this.grupocabecalho.HeightF = 84.87498F;
            this.grupocabecalho.Name = "grupocabecalho";
            this.grupocabecalho.RepeatEveryPage = true;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.Silver;
            this.xrLabel8.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel8.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 70.25F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(1048F, 13.00001F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Observações";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.Silver;
            this.xrLabel6.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel6.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(704.8795F, 28.04164F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(344.1202F, 13F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Telefones Comerciais";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.Silver;
            this.xrLabel12.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel12.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel12.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(939.0001F, 0F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(109.9996F, 13F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseBorderColor = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Inscr. Estadual";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.Silver;
            this.xrLabel11.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel11.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel11.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(1F, 56.04163F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(1048F, 13.00001F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseBorderColor = false;
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseForeColor = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Dados do Conjuge";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.BackColor = System.Drawing.Color.Silver;
            this.xrLabel10.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel10.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0.999999F, 42.04163F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(1048F, 13F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseBorderColor = false;
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Emails";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.BackColor = System.Drawing.Color.Silver;
            this.xrLabel13.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel13.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel13.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(836.5929F, 0F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(102.4072F, 13F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseBorderColor = false;
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Inscr. Municipal";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel9
            // 
            this.xrLabel9.BackColor = System.Drawing.Color.Silver;
            this.xrLabel9.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel9.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel9.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0.999999F, 28.04162F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(703.8795F, 12.99999F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseBorderColor = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Endereço Comercial";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.Silver;
            this.xrLabel1.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(704.8797F, 14.04165F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(344.1202F, 13F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Telefones Residenciais";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.Silver;
            this.xrLabel7.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel7.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0.999999F, 14.04165F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(703.8797F, 13F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Endereço Residencial";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.Silver;
            this.xrLabel5.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel5.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(767.3005F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(69.29236F, 13F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Sexo";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Silver;
            this.xrLabel2.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(704.8796F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(61.62921F, 13F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Nascimento";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.BackColor = System.Drawing.Color.Silver;
            this.xrLabel17.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel17.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel17.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(620.8796F, 0F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(83.99982F, 13F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Orgão RG";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel16
            // 
            this.xrLabel16.BackColor = System.Drawing.Color.Silver;
            this.xrLabel16.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel16.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel16.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(521.0987F, 0F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(42.95831F, 13F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseBorderColor = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "UF RG";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel15
            // 
            this.xrLabel15.BackColor = System.Drawing.Color.Silver;
            this.xrLabel15.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel15.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel15.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(418.6502F, 0F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(102.4485F, 13F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseBorderColor = false;
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "RG";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.Silver;
            this.xrLabel3.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(564.057F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(56.82263F, 13F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Emissão";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel18
            // 
            this.xrLabel18.BackColor = System.Drawing.Color.Silver;
            this.xrLabel18.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel18.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel18.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(1.00015F, 0F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(86.23002F, 13F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseBorderColor = false;
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseForeColor = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Apelido";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel26
            // 
            this.xrLabel26.BackColor = System.Drawing.Color.Silver;
            this.xrLabel26.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel26.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel26.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(287.2302F, 0F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(131.42F, 13F);
            this.xrLabel26.StylePriority.UseBackColor = false;
            this.xrLabel26.StylePriority.UseBorderColor = false;
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseForeColor = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.Text = "CPF\\CNPJ";
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BackColor = System.Drawing.Color.Silver;
            this.xrLabel19.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel19.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel19.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(87.23018F, 0F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(200F, 13F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseBorderColor = false;
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseForeColor = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Nome";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // grupofiltros
            // 
            this.grupofiltros.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lfcliente,
            this.xrLabel4});
            this.grupofiltros.HeightF = 29.16667F;
            this.grupofiltros.Level = 1;
            this.grupofiltros.Name = "grupofiltros";
            // 
            // lfcliente
            // 
            this.lfcliente.LocationFloat = new DevExpress.Utils.PointFloat(82.23017F, 5.000007F);
            this.lfcliente.Name = "lfcliente";
            this.lfcliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfcliente.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lfcliente.StylePriority.UseTextAlignment = false;
            this.lfcliente.Text = "lfcliente";
            this.lfcliente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(4.999998F, 5.00001F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(74.63166F, 20F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Cliente:";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            this.lcaminho.LocationFloat = new DevExpress.Utils.PointFloat(4.999995F, 4F);
            this.lcaminho.Name = "lcaminho";
            this.lcaminho.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcaminho.SizeF = new System.Drawing.SizeF(322.9165F, 14F);
            this.lcaminho.StylePriority.UseFont = false;
            this.lcaminho.Text = "Gitano->SGFin->Empresa->Relatório Empresa Cadastro Total";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.ltotquant,
            this.xrLabel14});
            this.ReportFooter.HeightF = 29.16667F;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ReportFooter_BeforePrint);
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(1.000277F, 2F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
            // 
            // ltotquant
            // 
            this.ltotquant.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotquant.LocationFloat = new DevExpress.Utils.PointFloat(287.2305F, 12.00004F);
            this.ltotquant.Name = "ltotquant";
            this.ltotquant.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotquant.SizeF = new System.Drawing.SizeF(108.0415F, 14F);
            this.ltotquant.StylePriority.UseFont = false;
            this.ltotquant.StylePriority.UseTextAlignment = false;
            this.ltotquant.Text = "ltotquant";
            this.ltotquant.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(5.000273F, 12.00004F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(254.2502F, 14F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Total :";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RepClienteCadastroTotal
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.grupocabecalho,
            this.grupofiltros,
            this.PageFooter,
            this.ReportFooter});
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(50, 70, 49, 24);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1,
            this.xrControlStyle2});
            this.Version = "13.2";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepClienteCadastroTotal_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

    #endregion

    Int32 totquantidade = 0;

    private void RepClienteCadastroTotal_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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

		grupofiltros.RepeatEveryPage = ((SreDblib.GetParametro("EXIBE FILTRO RELAT") == "SIM"));

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
        lcnpj.Text = Srelib.FormataCPFCNPJ(Convert.ToString(GetCurrentColumnValue("cnpj")));
        totquantidade++;
    }

    private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        ltotquant.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(totquantidade));
    }
}
