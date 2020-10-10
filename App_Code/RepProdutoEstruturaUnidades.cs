using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for RepProdutoEstruturaUnidades
/// </summary>
public class RepProdutoEstruturaUnidades : DevExpress.XtraReports.UI.XtraReport
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
	public XRLabel lfproduto;
	public XRLabel ltusuario;
	private XRPictureBox xrPictureBox1;
	private XRControlStyle xrControlStyle1;
	private XRControlStyle xrControlStyle2;
	public XRLabel lid;
	public XRLabel lHBLOCAL;
	public XRLabel lFIPERC;
	public XRLabel lunidade;
	private XRLabel xrLabel3;
	private XRLabel xrLabel15;
	public XRLabel lAPTC;
	public XRLabel lNUMVG1;
	public XRLabel lgrupo;
    private XRLabel xrLabel17;
	private FormattingRule formattingRule1;
    private XRLabel xrLabel2;
	private XRLabel xrLabel5;
	public XRLabel lVGQTD;
	private PageFooterBand PageFooter;
	public XRLabel lcaminho;
    public XRLabel lfgrupo;
    private XRLabel xrLabel1;
    public XRLabel lAPTD;
    private XRLabel xrLabel6;
    public XRLabel lparte;
    private XRLabel xrLabel7;
    public XRLabel lAPC;
    private XRLabel xrLabel8;
    private XRLabel xrLabel21;
    private XRLabel xrLabel20;
    private XRLabel xrLabel16;
    private XRLabel xrLabel14;
    private XRLabel xrLabel13;
    private XRLabel xrLabel12;
    private XRLabel xrLabel11;
    private XRLabel xrLabel10;
    private XRLabel xrLabel9;
    public XRLabel lAC;
    public XRLabel lHBM2;
    public XRLabel lAG;
    public XRLabel lFIM2;
    public XRLabel lATM2;
    public XRLabel lHBNUM;
    public XRLabel lNUMVG2;
    public XRLabel lVGLOCAL;
    public XRLabel lNUMVG3;
    private ReportFooterBand ReportFooter;
    public XRLabel llegenda;
    private XRLine xrLine2;
    public XRLabel xrLabel22;
    public XRLabel xrLabel31;
    public XRLabel xrLabel32;
    public XRLabel xrLabel30;
    public XRLabel xrLabel28;
    public XRLabel xrLabel29;
    public XRLabel xrLabel27;
    public XRLabel xrLabel25;
    public XRLabel xrLabel24;
    public XRLabel xrLabel23;
    public XRLabel xrLabel39;
    public XRLabel xrLabel40;
    public XRLabel xrLabel42;
    public XRLabel xrLabel41;
    public XRLabel xrLabel34;
    public XRLabel xrLabel33;
    public XRLabel xrLabel35;
    public XRLabel xrLabel37;
    public XRLabel xrLabel36;
    public XRLabel xrLabel38;
    private XRLine xrLine1;
    public XRLabel xrLabel54;
    public XRLabel xrLabel53;
    public XRLabel xrLabel49;
    public XRLabel xrLabel48;
    public XRLabel xrLabel50;
    public XRLabel xrLabel52;
    public XRLabel xrLabel51;
    public XRLabel xrLabel44;
    public XRLabel xrLabel43;
    public XRLabel xrLabel45;
    public XRLabel xrLabel47;
    public XRLabel xrLabel46;
	
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public RepProdutoEstruturaUnidades()
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
            //string resourceFileName = "RepProdutoEstruturaUnidades.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lVGLOCAL = new DevExpress.XtraReports.UI.XRLabel();
            this.lNUMVG3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lNUMVG2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lHBNUM = new DevExpress.XtraReports.UI.XRLabel();
            this.lFIM2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lATM2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lHBM2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lAG = new DevExpress.XtraReports.UI.XRLabel();
            this.lAC = new DevExpress.XtraReports.UI.XRLabel();
            this.lAPC = new DevExpress.XtraReports.UI.XRLabel();
            this.lparte = new DevExpress.XtraReports.UI.XRLabel();
            this.lAPTD = new DevExpress.XtraReports.UI.XRLabel();
            this.lVGQTD = new DevExpress.XtraReports.UI.XRLabel();
            this.lAPTC = new DevExpress.XtraReports.UI.XRLabel();
            this.lNUMVG1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lgrupo = new DevExpress.XtraReports.UI.XRLabel();
            this.lHBLOCAL = new DevExpress.XtraReports.UI.XRLabel();
            this.lFIPERC = new DevExpress.XtraReports.UI.XRLabel();
            this.lunidade = new DevExpress.XtraReports.UI.XRLabel();
            this.lid = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.grupofiltros = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lfgrupo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfproduto = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lcaminho = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.llegenda = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lVGLOCAL,
            this.lNUMVG3,
            this.lNUMVG2,
            this.lHBNUM,
            this.lFIM2,
            this.lATM2,
            this.lHBM2,
            this.lAG,
            this.lAC,
            this.lAPC,
            this.lparte,
            this.lAPTD,
            this.lVGQTD,
            this.lAPTC,
            this.lNUMVG1,
            this.lgrupo,
            this.lHBLOCAL,
            this.lFIPERC,
            this.lunidade,
            this.lid});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 11.04167F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // lVGLOCAL
            // 
            this.lVGLOCAL.Font = new System.Drawing.Font("Calibri", 7F);
            this.lVGLOCAL.ForeColor = System.Drawing.Color.Black;
            this.lVGLOCAL.LocationFloat = new DevExpress.Utils.PointFloat(958.8745F, 0F);
            this.lVGLOCAL.Name = "lVGLOCAL";
            this.lVGLOCAL.NullValueText = " ";
            this.lVGLOCAL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lVGLOCAL.SizeF = new System.Drawing.SizeF(50F, 10F);
            this.lVGLOCAL.StylePriority.UseBackColor = false;
            this.lVGLOCAL.StylePriority.UseFont = false;
            this.lVGLOCAL.Text = "lVGLOCAL";
            this.lVGLOCAL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lVGLOCAL.WordWrap = false;
            // 
            // lNUMVG3
            // 
            this.lNUMVG3.Font = new System.Drawing.Font("Calibri", 7F);
            this.lNUMVG3.ForeColor = System.Drawing.Color.Black;
            this.lNUMVG3.LocationFloat = new DevExpress.Utils.PointFloat(912.0411F, 0F);
            this.lNUMVG3.Name = "lNUMVG3";
            this.lNUMVG3.NullValueText = " ";
            this.lNUMVG3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lNUMVG3.SizeF = new System.Drawing.SizeF(46.83344F, 10F);
            this.lNUMVG3.StylePriority.UseBackColor = false;
            this.lNUMVG3.StylePriority.UseFont = false;
            this.lNUMVG3.StylePriority.UseTextAlignment = false;
            this.lNUMVG3.Text = "lNUMVG3";
            this.lNUMVG3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lNUMVG3.WordWrap = false;
            // 
            // lNUMVG2
            // 
            this.lNUMVG2.Font = new System.Drawing.Font("Calibri", 7F);
            this.lNUMVG2.ForeColor = System.Drawing.Color.Black;
            this.lNUMVG2.LocationFloat = new DevExpress.Utils.PointFloat(862.0411F, 0F);
            this.lNUMVG2.Name = "lNUMVG2";
            this.lNUMVG2.NullValueText = " ";
            this.lNUMVG2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lNUMVG2.SizeF = new System.Drawing.SizeF(50F, 10F);
            this.lNUMVG2.StylePriority.UseBackColor = false;
            this.lNUMVG2.StylePriority.UseFont = false;
            this.lNUMVG2.StylePriority.UseTextAlignment = false;
            this.lNUMVG2.Text = "lNUMVG2";
            this.lNUMVG2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lNUMVG2.WordWrap = false;
            // 
            // lHBNUM
            // 
            this.lHBNUM.Font = new System.Drawing.Font("Calibri", 7F);
            this.lHBNUM.ForeColor = System.Drawing.Color.Black;
            this.lHBNUM.LocationFloat = new DevExpress.Utils.PointFloat(682.0411F, 0F);
            this.lHBNUM.Name = "lHBNUM";
            this.lHBNUM.NullValueText = " ";
            this.lHBNUM.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lHBNUM.SizeF = new System.Drawing.SizeF(50F, 9.999999F);
            this.lHBNUM.StylePriority.UseBackColor = false;
            this.lHBNUM.StylePriority.UseFont = false;
            this.lHBNUM.StylePriority.UseTextAlignment = false;
            this.lHBNUM.Text = "lHBNUM";
            this.lHBNUM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lHBNUM.WordWrap = false;
            // 
            // lFIM2
            // 
            this.lFIM2.Font = new System.Drawing.Font("Calibri", 7F);
            this.lFIM2.ForeColor = System.Drawing.Color.Black;
            this.lFIM2.LocationFloat = new DevExpress.Utils.PointFloat(581.9169F, 0F);
            this.lFIM2.Name = "lFIM2";
            this.lFIM2.NullValueText = " ";
            this.lFIM2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lFIM2.SizeF = new System.Drawing.SizeF(50F, 9.999999F);
            this.lFIM2.StylePriority.UseBackColor = false;
            this.lFIM2.StylePriority.UseFont = false;
            this.lFIM2.StylePriority.UseTextAlignment = false;
            this.lFIM2.Text = "lFIM2";
            this.lFIM2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lFIM2.WordWrap = false;
            // 
            // lATM2
            // 
            this.lATM2.Font = new System.Drawing.Font("Calibri", 7F);
            this.lATM2.ForeColor = System.Drawing.Color.Black;
            this.lATM2.LocationFloat = new DevExpress.Utils.PointFloat(499.9585F, 0F);
            this.lATM2.Name = "lATM2";
            this.lATM2.NullValueText = " ";
            this.lATM2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lATM2.SizeF = new System.Drawing.SizeF(81.95837F, 9.999999F);
            this.lATM2.StylePriority.UseBackColor = false;
            this.lATM2.StylePriority.UseFont = false;
            this.lATM2.StylePriority.UseTextAlignment = false;
            this.lATM2.Text = "lATM2";
            this.lATM2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lATM2.WordWrap = false;
            // 
            // lHBM2
            // 
            this.lHBM2.Font = new System.Drawing.Font("Calibri", 7F);
            this.lHBM2.ForeColor = System.Drawing.Color.Black;
            this.lHBM2.LocationFloat = new DevExpress.Utils.PointFloat(450.9585F, 0F);
            this.lHBM2.Name = "lHBM2";
            this.lHBM2.NullValueText = " ";
            this.lHBM2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lHBM2.SizeF = new System.Drawing.SizeF(49F, 9.999999F);
            this.lHBM2.StylePriority.UseBackColor = false;
            this.lHBM2.StylePriority.UseFont = false;
            this.lHBM2.StylePriority.UseTextAlignment = false;
            this.lHBM2.Text = "lHBM2";
            this.lHBM2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lHBM2.WordWrap = false;
            // 
            // lAG
            // 
            this.lAG.Font = new System.Drawing.Font("Calibri", 7F);
            this.lAG.ForeColor = System.Drawing.Color.Black;
            this.lAG.LocationFloat = new DevExpress.Utils.PointFloat(401.9585F, 0F);
            this.lAG.Name = "lAG";
            this.lAG.NullValueText = " ";
            this.lAG.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lAG.SizeF = new System.Drawing.SizeF(49F, 9.999999F);
            this.lAG.StylePriority.UseBackColor = false;
            this.lAG.StylePriority.UseFont = false;
            this.lAG.StylePriority.UseTextAlignment = false;
            this.lAG.Text = "lAG";
            this.lAG.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lAG.WordWrap = false;
            // 
            // lAC
            // 
            this.lAC.Font = new System.Drawing.Font("Calibri", 7F);
            this.lAC.ForeColor = System.Drawing.Color.Black;
            this.lAC.LocationFloat = new DevExpress.Utils.PointFloat(350.9585F, 0F);
            this.lAC.Name = "lAC";
            this.lAC.NullValueText = " ";
            this.lAC.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lAC.SizeF = new System.Drawing.SizeF(50.00003F, 9.999999F);
            this.lAC.StylePriority.UseBackColor = false;
            this.lAC.StylePriority.UseFont = false;
            this.lAC.StylePriority.UseTextAlignment = false;
            this.lAC.Text = "lAC";
            this.lAC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lAC.WordWrap = false;
            // 
            // lAPC
            // 
            this.lAPC.Font = new System.Drawing.Font("Calibri", 7F);
            this.lAPC.ForeColor = System.Drawing.Color.Black;
            this.lAPC.LocationFloat = new DevExpress.Utils.PointFloat(200.0002F, 0F);
            this.lAPC.Name = "lAPC";
            this.lAPC.NullValueText = " ";
            this.lAPC.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lAPC.SizeF = new System.Drawing.SizeF(50F, 9.999999F);
            this.lAPC.StylePriority.UseBackColor = false;
            this.lAPC.StylePriority.UseFont = false;
            this.lAPC.StylePriority.UseTextAlignment = false;
            this.lAPC.Text = "lAPC";
            this.lAPC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lAPC.WordWrap = false;
            // 
            // lparte
            // 
            this.lparte.Font = new System.Drawing.Font("Calibri", 7F);
            this.lparte.ForeColor = System.Drawing.Color.Black;
            this.lparte.LocationFloat = new DevExpress.Utils.PointFloat(150.0002F, 0F);
            this.lparte.Name = "lparte";
            this.lparte.NullValueText = " ";
            this.lparte.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparte.SizeF = new System.Drawing.SizeF(50F, 10F);
            this.lparte.StylePriority.UseBackColor = false;
            this.lparte.StylePriority.UseFont = false;
            this.lparte.Text = "lparte";
            this.lparte.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lparte.WordWrap = false;
            // 
            // lAPTD
            // 
            this.lAPTD.Font = new System.Drawing.Font("Calibri", 7F);
            this.lAPTD.ForeColor = System.Drawing.Color.Black;
            this.lAPTD.LocationFloat = new DevExpress.Utils.PointFloat(300.9585F, 0F);
            this.lAPTD.Name = "lAPTD";
            this.lAPTD.NullValueText = " ";
            this.lAPTD.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lAPTD.SizeF = new System.Drawing.SizeF(49.7F, 9.999999F);
            this.lAPTD.StylePriority.UseBackColor = false;
            this.lAPTD.StylePriority.UseFont = false;
            this.lAPTD.StylePriority.UseTextAlignment = false;
            this.lAPTD.Text = "lAPTD";
            this.lAPTD.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lAPTD.WordWrap = false;
            // 
            // lVGQTD
            // 
            this.lVGQTD.Font = new System.Drawing.Font("Calibri", 7F);
            this.lVGQTD.ForeColor = System.Drawing.Color.Black;
            this.lVGQTD.LocationFloat = new DevExpress.Utils.PointFloat(1008.875F, 0F);
            this.lVGQTD.Name = "lVGQTD";
            this.lVGQTD.NullValueText = " ";
            this.lVGQTD.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lVGQTD.SizeF = new System.Drawing.SizeF(40.12524F, 10F);
            this.lVGQTD.StylePriority.UseBackColor = false;
            this.lVGQTD.StylePriority.UseFont = false;
            this.lVGQTD.StylePriority.UseTextAlignment = false;
            this.lVGQTD.Text = "lVGQTD";
            this.lVGQTD.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lVGQTD.WordWrap = false;
            // 
            // lAPTC
            // 
            this.lAPTC.Font = new System.Drawing.Font("Calibri", 7F);
            this.lAPTC.ForeColor = System.Drawing.Color.Black;
            this.lAPTC.LocationFloat = new DevExpress.Utils.PointFloat(250.9585F, 0F);
            this.lAPTC.Name = "lAPTC";
            this.lAPTC.NullValueText = " ";
            this.lAPTC.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lAPTC.SizeF = new System.Drawing.SizeF(49.99995F, 9.999999F);
            this.lAPTC.StylePriority.UseBackColor = false;
            this.lAPTC.StylePriority.UseFont = false;
            this.lAPTC.StylePriority.UseTextAlignment = false;
            this.lAPTC.Text = "lAPTC";
            this.lAPTC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lAPTC.WordWrap = false;
            // 
            // lNUMVG1
            // 
            this.lNUMVG1.Font = new System.Drawing.Font("Calibri", 7F);
            this.lNUMVG1.ForeColor = System.Drawing.Color.Black;
            this.lNUMVG1.LocationFloat = new DevExpress.Utils.PointFloat(812.0411F, 0F);
            this.lNUMVG1.Name = "lNUMVG1";
            this.lNUMVG1.NullValueText = " ";
            this.lNUMVG1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lNUMVG1.SizeF = new System.Drawing.SizeF(50F, 11.04167F);
            this.lNUMVG1.StylePriority.UseBackColor = false;
            this.lNUMVG1.StylePriority.UseFont = false;
            this.lNUMVG1.StylePriority.UseTextAlignment = false;
            this.lNUMVG1.Text = "lNUMVG1";
            this.lNUMVG1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lNUMVG1.WordWrap = false;
            // 
            // lgrupo
            // 
            this.lgrupo.Font = new System.Drawing.Font("Calibri", 7F);
            this.lgrupo.ForeColor = System.Drawing.Color.Black;
            this.lgrupo.LocationFloat = new DevExpress.Utils.PointFloat(50.00016F, 0F);
            this.lgrupo.Name = "lgrupo";
            this.lgrupo.NullValueText = " ";
            this.lgrupo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lgrupo.SizeF = new System.Drawing.SizeF(50.00002F, 10F);
            this.lgrupo.StylePriority.UseBackColor = false;
            this.lgrupo.StylePriority.UseFont = false;
            this.lgrupo.Text = "lgrupo";
            this.lgrupo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lgrupo.WordWrap = false;
            // 
            // lHBLOCAL
            // 
            this.lHBLOCAL.Font = new System.Drawing.Font("Calibri", 7F);
            this.lHBLOCAL.ForeColor = System.Drawing.Color.Black;
            this.lHBLOCAL.LocationFloat = new DevExpress.Utils.PointFloat(732.0411F, 0F);
            this.lHBLOCAL.Name = "lHBLOCAL";
            this.lHBLOCAL.NullValueText = " ";
            this.lHBLOCAL.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lHBLOCAL.SizeF = new System.Drawing.SizeF(80F, 9.999999F);
            this.lHBLOCAL.StylePriority.UseBackColor = false;
            this.lHBLOCAL.StylePriority.UseFont = false;
            this.lHBLOCAL.Text = "lHBLOCAL";
            this.lHBLOCAL.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lHBLOCAL.WordWrap = false;
            // 
            // lFIPERC
            // 
            this.lFIPERC.Font = new System.Drawing.Font("Calibri", 7F);
            this.lFIPERC.ForeColor = System.Drawing.Color.Black;
            this.lFIPERC.LocationFloat = new DevExpress.Utils.PointFloat(631.9169F, 0F);
            this.lFIPERC.Name = "lFIPERC";
            this.lFIPERC.NullValueText = " ";
            this.lFIPERC.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lFIPERC.SizeF = new System.Drawing.SizeF(50F, 9.999999F);
            this.lFIPERC.StylePriority.UseBackColor = false;
            this.lFIPERC.StylePriority.UseFont = false;
            this.lFIPERC.StylePriority.UseTextAlignment = false;
            this.lFIPERC.Text = "lFIPERC";
            this.lFIPERC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lFIPERC.WordWrap = false;
            // 
            // lunidade
            // 
            this.lunidade.Font = new System.Drawing.Font("Calibri", 7F);
            this.lunidade.ForeColor = System.Drawing.Color.Black;
            this.lunidade.LocationFloat = new DevExpress.Utils.PointFloat(100.0002F, 0F);
            this.lunidade.Name = "lunidade";
            this.lunidade.NullValueText = " ";
            this.lunidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lunidade.SizeF = new System.Drawing.SizeF(50F, 10F);
            this.lunidade.StylePriority.UseBackColor = false;
            this.lunidade.StylePriority.UseFont = false;
            this.lunidade.Text = "lunidade";
            this.lunidade.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lunidade.WordWrap = false;
            // 
            // lid
            // 
            this.lid.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lid.ForeColor = System.Drawing.Color.Black;
            this.lid.LocationFloat = new DevExpress.Utils.PointFloat(0.0001509984F, 0F);
            this.lid.Name = "lid";
            this.lid.NullValueText = " ";
            this.lid.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lid.SizeF = new System.Drawing.SizeF(50.00001F, 10F);
            this.lid.StylePriority.UseBackColor = false;
            this.lid.StylePriority.UseFont = false;
            this.lid.Text = "lid";
            this.lid.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lid.WordWrap = false;
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
            this.ltitulorelatorio.Text = "RELATÓRIO PRODUTO ESTRUTURA UNIDADES";
            this.ltitulorelatorio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // grupocabecalho
            // 
            this.grupocabecalho.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel21,
            this.xrLabel20,
            this.xrLabel16,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel2,
            this.xrLabel17,
            this.xrLabel15,
            this.xrLabel3,
            this.xrLabel18,
            this.xrLabel26,
            this.xrLabel19});
            this.grupocabecalho.HeightF = 14.04165F;
            this.grupocabecalho.Name = "grupocabecalho";
            this.grupocabecalho.RepeatEveryPage = true;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BackColor = System.Drawing.Color.Silver;
            this.xrLabel21.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel21.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel21.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(1008.875F, 0F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(40F, 13F);
            this.xrLabel21.StylePriority.UseBackColor = false;
            this.xrLabel21.StylePriority.UseBorderColor = false;
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseForeColor = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "VG Qtd";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel20
            // 
            this.xrLabel20.BackColor = System.Drawing.Color.Silver;
            this.xrLabel20.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel20.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel20.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(862.0411F, 0F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseBorderColor = false;
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseForeColor = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "VG 2 No.";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(812.0411F, 0F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseBorderColor = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "VG 1 No.";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.BackColor = System.Drawing.Color.Silver;
            this.xrLabel14.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel14.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel14.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(732.0411F, 0F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(80F, 13F);
            this.xrLabel14.StylePriority.UseBackColor = false;
            this.xrLabel14.StylePriority.UseBorderColor = false;
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "HB Local";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(631.9169F, 0F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseBorderColor = false;
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "FI %";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(451.9585F, 0F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(48F, 13F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseBorderColor = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "HB M2";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(400.9585F, 0F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseBorderColor = false;
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseForeColor = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "AG";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(350.9585F, 0F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseBorderColor = false;
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "AC";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(250.9585F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseBorderColor = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "APTC";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(200.0002F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "APC";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(150.0002F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Parte";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(581.9169F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "FI M2";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(499.9585F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(81.95831F, 13F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "AT M2";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(958.8745F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Local.";
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
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(912.0411F, 0F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(46.83344F, 13F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "VG 3 No.";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(300.9585F, 0F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseBorderColor = false;
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "APTD";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(682.0411F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "HB No.";
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
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(0.0001589457F, 0F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseBorderColor = false;
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseForeColor = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "ID";
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
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(100.0002F, 0F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel26.StylePriority.UseBackColor = false;
            this.xrLabel26.StylePriority.UseBorderColor = false;
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseForeColor = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.Text = "Unidade";
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
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(50.00016F, 0F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseBorderColor = false;
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseForeColor = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Blc\\Qdr";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // grupofiltros
            // 
            this.grupofiltros.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lfgrupo,
            this.xrLabel1,
            this.lfproduto,
            this.xrLabel4});
            this.grupofiltros.HeightF = 29.16667F;
            this.grupofiltros.Level = 1;
            this.grupofiltros.Name = "grupofiltros";
            // 
            // lfgrupo
            // 
            this.lfgrupo.LocationFloat = new DevExpress.Utils.PointFloat(661.7499F, 5.000019F);
            this.lfgrupo.Name = "lfgrupo";
            this.lfgrupo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfgrupo.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lfgrupo.StylePriority.UseTextAlignment = false;
            this.lfgrupo.Text = "lfgrupo";
            this.lfgrupo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(584.5199F, 5.000051F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(74.63166F, 20F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Grupo:";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfproduto
            // 
            this.lfproduto.LocationFloat = new DevExpress.Utils.PointFloat(82.23017F, 5.000007F);
            this.lfproduto.Name = "lfproduto";
            this.lfproduto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfproduto.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lfproduto.StylePriority.UseTextAlignment = false;
            this.lfproduto.Text = "lfproduto";
            this.lfproduto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            this.xrLabel4.Text = "Produto:";
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
            this.lcaminho.Text = "Gitano ->SGFin ->Empresa ->Relatório Produto Estrutura Unidades";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrLabel54,
            this.xrLabel53,
            this.xrLabel49,
            this.xrLabel48,
            this.xrLabel50,
            this.xrLabel52,
            this.xrLabel51,
            this.xrLabel44,
            this.xrLabel43,
            this.xrLabel45,
            this.xrLabel47,
            this.xrLabel46,
            this.xrLabel39,
            this.xrLabel38,
            this.xrLabel40,
            this.xrLabel42,
            this.xrLabel41,
            this.xrLabel34,
            this.xrLabel33,
            this.xrLabel35,
            this.xrLabel37,
            this.xrLabel36,
            this.xrLabel31,
            this.xrLabel32,
            this.xrLabel30,
            this.xrLabel28,
            this.xrLabel29,
            this.xrLabel27,
            this.xrLabel25,
            this.xrLabel24,
            this.xrLabel23,
            this.xrLabel22,
            this.llegenda,
            this.xrLine2});
            this.ReportFooter.HeightF = 131.25F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel39
            // 
            this.xrLabel39.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(401.9585F, 35.41667F);
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel39.SizeF = new System.Drawing.SizeF(190.0002F, 14F);
            this.xrLabel39.StylePriority.UseFont = false;
            this.xrLabel39.StylePriority.UseTextAlignment = false;
            this.xrLabel39.Text = "Área Hobby Box M2";
            this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel38
            // 
            this.xrLabel38.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(401.9585F, 49.41667F);
            this.xrLabel38.Multiline = true;
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(190.0002F, 14F);
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.StylePriority.UseTextAlignment = false;
            this.xrLabel38.Text = "Área Total M2";
            this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel40
            // 
            this.xrLabel40.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(401.9586F, 64.04168F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(190.0002F, 14F);
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            this.xrLabel40.Text = "Fração Ideal M2";
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel42
            // 
            this.xrLabel42.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(401.9586F, 78.04165F);
            this.xrLabel42.Name = "xrLabel42";
            this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel42.SizeF = new System.Drawing.SizeF(190.0002F, 14F);
            this.xrLabel42.StylePriority.UseFont = false;
            this.xrLabel42.StylePriority.UseTextAlignment = false;
            this.xrLabel42.Text = "Fração Ideal Percentual";
            this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel41
            // 
            this.xrLabel41.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(401.9585F, 92.04162F);
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel41.SizeF = new System.Drawing.SizeF(190.0002F, 14.00001F);
            this.xrLabel41.StylePriority.UseFont = false;
            this.xrLabel41.StylePriority.UseTextAlignment = false;
            this.xrLabel41.Text = "Hobby Box Número";
            this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel34
            // 
            this.xrLabel34.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(313.0003F, 49.41667F);
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(79.63166F, 14F);
            this.xrLabel34.StylePriority.UseFont = false;
            this.xrLabel34.StylePriority.UseTextAlignment = false;
            this.xrLabel34.Text = "AT M2";
            this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel33
            // 
            this.xrLabel33.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(313.0003F, 35.41667F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(79.63166F, 14F);
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.StylePriority.UseTextAlignment = false;
            this.xrLabel33.Text = "HB M2";
            this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel35
            // 
            this.xrLabel35.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(313.0004F, 64.04165F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(79.63165F, 14F);
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.StylePriority.UseTextAlignment = false;
            this.xrLabel35.Text = "FI M2";
            this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel37
            // 
            this.xrLabel37.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(313.0003F, 92.04162F);
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel37.SizeF = new System.Drawing.SizeF(79.63166F, 14F);
            this.xrLabel37.StylePriority.UseFont = false;
            this.xrLabel37.StylePriority.UseTextAlignment = false;
            this.xrLabel37.Text = "HB No.";
            this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel36
            // 
            this.xrLabel36.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(313.0004F, 78.04165F);
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(79.63165F, 14F);
            this.xrLabel36.StylePriority.UseFont = false;
            this.xrLabel36.StylePriority.UseTextAlignment = false;
            this.xrLabel36.Text = "FI %";
            this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel31
            // 
            this.xrLabel31.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(88.95835F, 78.04165F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(190.0002F, 14F);
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.Text = "Área Construida";
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel32
            // 
            this.xrLabel32.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(88.95823F, 92.04165F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(190.0002F, 14.00001F);
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.Text = "Área Garagens";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel30
            // 
            this.xrLabel30.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(88.95835F, 64.04168F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(190.0002F, 14F);
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.StylePriority.UseTextAlignment = false;
            this.xrLabel30.Text = "Área Privada Terraço Descoberto";
            this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel28
            // 
            this.xrLabel28.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(88.95823F, 35.41667F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(190.0002F, 14F);
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "Área Privada Coberta";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel29
            // 
            this.xrLabel29.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(88.95823F, 49.41667F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(190.0002F, 14F);
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.Text = "Área Privada Terraço Coberto";
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel27
            // 
            this.xrLabel27.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(0F, 92.04165F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(79.63166F, 14F);
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "AG";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel25
            // 
            this.xrLabel25.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(0.0001509984F, 78.04165F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(79.63165F, 14F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "AC";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel24
            // 
            this.xrLabel24.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(0.0001509984F, 64.04165F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(79.63165F, 14F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "APTD";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel23
            // 
            this.xrLabel23.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(0F, 49.41667F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(79.63166F, 14F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "APTC";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel22
            // 
            this.xrLabel22.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(0F, 35.41667F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(79.63166F, 14F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "APC";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // llegenda
            // 
            this.llegenda.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llegenda.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.llegenda.Name = "llegenda";
            this.llegenda.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.llegenda.SizeF = new System.Drawing.SizeF(100.0002F, 14F);
            this.llegenda.StylePriority.UseFont = false;
            this.llegenda.StylePriority.UseTextAlignment = false;
            this.llegenda.Text = "Legendas:";
            this.llegenda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.624989F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
            // 
            // xrLabel43
            // 
            this.xrLabel43.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(633.0828F, 78.04162F);
            this.xrLabel43.Name = "xrLabel43";
            this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel43.SizeF = new System.Drawing.SizeF(79.63165F, 14F);
            this.xrLabel43.StylePriority.UseFont = false;
            this.xrLabel43.StylePriority.UseTextAlignment = false;
            this.xrLabel43.Text = "VG 3 No.";
            this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel44
            // 
            this.xrLabel44.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(633.0827F, 92.04159F);
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(79.63166F, 14F);
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            this.xrLabel44.Text = "Local.";
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel45
            // 
            this.xrLabel45.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(633.0828F, 64.04165F);
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel45.SizeF = new System.Drawing.SizeF(79.63165F, 14F);
            this.xrLabel45.StylePriority.UseFont = false;
            this.xrLabel45.StylePriority.UseTextAlignment = false;
            this.xrLabel45.Text = "VG 2 No.";
            this.xrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel46
            // 
            this.xrLabel46.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(633.0827F, 35.41667F);
            this.xrLabel46.Name = "xrLabel46";
            this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel46.SizeF = new System.Drawing.SizeF(79.63166F, 14F);
            this.xrLabel46.StylePriority.UseFont = false;
            this.xrLabel46.StylePriority.UseTextAlignment = false;
            this.xrLabel46.Text = "HB Local";
            this.xrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel47
            // 
            this.xrLabel47.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(633.0827F, 49.41667F);
            this.xrLabel47.Name = "xrLabel47";
            this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel47.SizeF = new System.Drawing.SizeF(79.63166F, 14F);
            this.xrLabel47.StylePriority.UseFont = false;
            this.xrLabel47.StylePriority.UseTextAlignment = false;
            this.xrLabel47.Text = "VG 1 No.";
            this.xrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel48
            // 
            this.xrLabel48.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(722.0409F, 92.04159F);
            this.xrLabel48.Name = "xrLabel48";
            this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel48.SizeF = new System.Drawing.SizeF(190.0002F, 14.00001F);
            this.xrLabel48.StylePriority.UseFont = false;
            this.xrLabel48.StylePriority.UseTextAlignment = false;
            this.xrLabel48.Text = "Garagem Localização";
            this.xrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel49
            // 
            this.xrLabel49.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(722.041F, 78.04162F);
            this.xrLabel49.Name = "xrLabel49";
            this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel49.SizeF = new System.Drawing.SizeF(190.0002F, 14F);
            this.xrLabel49.StylePriority.UseFont = false;
            this.xrLabel49.StylePriority.UseTextAlignment = false;
            this.xrLabel49.Text = "Garagem No. 3 Numeração";
            this.xrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel50
            // 
            this.xrLabel50.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(722.041F, 64.04165F);
            this.xrLabel50.Name = "xrLabel50";
            this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel50.SizeF = new System.Drawing.SizeF(190.0002F, 14F);
            this.xrLabel50.StylePriority.UseFont = false;
            this.xrLabel50.StylePriority.UseTextAlignment = false;
            this.xrLabel50.Text = "Garagem No. 2 Numeração";
            this.xrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel51
            // 
            this.xrLabel51.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(722.0409F, 49.41667F);
            this.xrLabel51.Multiline = true;
            this.xrLabel51.Name = "xrLabel51";
            this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel51.SizeF = new System.Drawing.SizeF(190.0002F, 14F);
            this.xrLabel51.StylePriority.UseFont = false;
            this.xrLabel51.StylePriority.UseTextAlignment = false;
            this.xrLabel51.Text = "Garagem No. 1 Numeração";
            this.xrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel52
            // 
            this.xrLabel52.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(722.0409F, 35.41667F);
            this.xrLabel52.Name = "xrLabel52";
            this.xrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel52.SizeF = new System.Drawing.SizeF(190.0002F, 14F);
            this.xrLabel52.StylePriority.UseFont = false;
            this.xrLabel52.StylePriority.UseTextAlignment = false;
            this.xrLabel52.Text = "Hobby Box Localização";
            this.xrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel53
            // 
            this.xrLabel53.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(633.0827F, 106.25F);
            this.xrLabel53.Name = "xrLabel53";
            this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel53.SizeF = new System.Drawing.SizeF(79.63166F, 14F);
            this.xrLabel53.StylePriority.UseFont = false;
            this.xrLabel53.StylePriority.UseTextAlignment = false;
            this.xrLabel53.Text = "VG Qtd";
            this.xrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel54
            // 
            this.xrLabel54.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel54.LocationFloat = new DevExpress.Utils.PointFloat(722.0409F, 106.25F);
            this.xrLabel54.Name = "xrLabel54";
            this.xrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel54.SizeF = new System.Drawing.SizeF(190.0002F, 14.00001F);
            this.xrLabel54.StylePriority.UseFont = false;
            this.xrLabel54.StylePriority.UseTextAlignment = false;
            this.xrLabel54.Text = "Garagem Quantidade";
            this.xrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 123.875F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
            // 
            // RepProdutoEstruturaUnidades
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
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepProdutoEstruturaUnidades_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

	private void RepProdutoEstruturaUnidades_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
        //
        string produto = GetCurrentColumnValue("produto").ToString().Trim();
        string grupo = GetCurrentColumnValue("grupo").ToString().Trim();
        string observacao = uGrupo.PegaObservacao1(produto, grupo).Trim();
        if (observacao == String.Empty)
        {
            lgrupo.Text = grupo;
        }
        else
        {
            lgrupo.Text = grupo;
            if (observacao.Length <= 3)
            {
                lgrupo.Text = grupo + "-" + observacao.Trim();
            }
        }
        //
    }

}
