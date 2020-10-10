using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for RepVendasCarteira
/// </summary>
public class RepVendasCarteira : DevExpress.XtraReports.UI.XtraReport
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
    public XRLabel ltitulosqtd;
	public XRLabel ltitulosprotestoqtd;
    public XRLabel ltitulosdevidosqtd;
    public XRLabel ltitulospagosqtd;
    private FormattingRule formattingRule1;
    private XRLabel xrLabel5;
	private PageFooterBand PageFooter;
	public XRLabel lcaminho;
    public XRLabel lfgrupo;
    private XRLabel xrLabel1;
    public XRLabel ltitulosbancariadevidosqtd;
    private XRLabel xrLabel6;
    public XRLabel ltituloscarteirapagosqtd;
    private XRLabel xrLabel7;
    public XRLabel lfperiodo;
    private XRLabel xrLabel11;
    private XRLabel xrLabel3;
    private XRLabel xrLabel2;
    public XRLabel ltitulosbancariapagosqtd;
    public XRLabel ltituloscarteiradevidosqtd;
    public XRLabel ltituloscarteirapagosvlr;
    public XRLabel ltitulosbancariadevidosvlr;
    public XRLabel ltitulosbancariapagosvlr;
    public XRLabel ltituloscarteiradevidosvlr;
    public XRLabel ltitulosdevidosvlr;
    public XRLabel ltitulosvlr;
    public XRLabel ltitulospagosvlr;
    public XRLabel ltitulosprotestovlr;
	
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public RepVendasCarteira()
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
            //string resourceFileName = "RepVendasCarteira.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ltitulosbancariapagosqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltituloscarteiradevidosqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltituloscarteirapagosqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltitulosbancariadevidosqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltitulospagosqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltitulosprotestoqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltitulosdevidosqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltitulosqtd = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.grupofiltros = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lfperiodo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfgrupo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfproduto = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lcaminho = new DevExpress.XtraReports.UI.XRLabel();
            this.ltitulosvlr = new DevExpress.XtraReports.UI.XRLabel();
            this.ltitulosdevidosvlr = new DevExpress.XtraReports.UI.XRLabel();
            this.ltitulosprotestovlr = new DevExpress.XtraReports.UI.XRLabel();
            this.ltitulospagosvlr = new DevExpress.XtraReports.UI.XRLabel();
            this.ltitulosbancariadevidosvlr = new DevExpress.XtraReports.UI.XRLabel();
            this.ltituloscarteirapagosvlr = new DevExpress.XtraReports.UI.XRLabel();
            this.ltituloscarteiradevidosvlr = new DevExpress.XtraReports.UI.XRLabel();
            this.ltitulosbancariapagosvlr = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ltituloscarteirapagosvlr,
            this.ltitulosbancariadevidosvlr,
            this.ltitulosbancariapagosvlr,
            this.ltituloscarteiradevidosvlr,
            this.ltitulosdevidosvlr,
            this.ltitulosvlr,
            this.ltitulospagosvlr,
            this.ltitulosprotestovlr,
            this.ltitulosbancariapagosqtd,
            this.ltituloscarteiradevidosqtd,
            this.ltituloscarteirapagosqtd,
            this.ltitulosbancariadevidosqtd,
            this.ltitulospagosqtd,
            this.ltitulosprotestoqtd,
            this.ltitulosdevidosqtd,
            this.ltitulosqtd});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 26.04167F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ltitulosbancariapagosqtd
            // 
            this.ltitulosbancariapagosqtd.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltitulosbancariapagosqtd.ForeColor = System.Drawing.Color.Black;
            this.ltitulosbancariapagosqtd.LocationFloat = new DevExpress.Utils.PointFloat(688.9999F, 1.041667F);
            this.ltitulosbancariapagosqtd.Name = "ltitulosbancariapagosqtd";
            this.ltitulosbancariapagosqtd.NullValueText = " ";
            this.ltitulosbancariapagosqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulosbancariapagosqtd.SizeF = new System.Drawing.SizeF(120F, 10F);
            this.ltitulosbancariapagosqtd.StylePriority.UseBackColor = false;
            this.ltitulosbancariapagosqtd.StylePriority.UseFont = false;
            this.ltitulosbancariapagosqtd.StylePriority.UseTextAlignment = false;
            this.ltitulosbancariapagosqtd.Text = "ltitulosbancariapagosqtd";
            this.ltitulosbancariapagosqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltitulosbancariapagosqtd.WordWrap = false;
            // 
            // ltituloscarteiradevidosqtd
            // 
            this.ltituloscarteiradevidosqtd.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltituloscarteiradevidosqtd.ForeColor = System.Drawing.Color.Black;
            this.ltituloscarteiradevidosqtd.LocationFloat = new DevExpress.Utils.PointFloat(568.9999F, 1.041667F);
            this.ltituloscarteiradevidosqtd.Name = "ltituloscarteiradevidosqtd";
            this.ltituloscarteiradevidosqtd.NullValueText = " ";
            this.ltituloscarteiradevidosqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltituloscarteiradevidosqtd.SizeF = new System.Drawing.SizeF(120F, 10F);
            this.ltituloscarteiradevidosqtd.StylePriority.UseBackColor = false;
            this.ltituloscarteiradevidosqtd.StylePriority.UseFont = false;
            this.ltituloscarteiradevidosqtd.StylePriority.UseTextAlignment = false;
            this.ltituloscarteiradevidosqtd.Text = "ltituloscarteiradevidosqtd";
            this.ltituloscarteiradevidosqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltituloscarteiradevidosqtd.WordWrap = false;
            // 
            // ltituloscarteirapagosqtd
            // 
            this.ltituloscarteirapagosqtd.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltituloscarteirapagosqtd.ForeColor = System.Drawing.Color.Black;
            this.ltituloscarteirapagosqtd.LocationFloat = new DevExpress.Utils.PointFloat(449F, 1.041667F);
            this.ltituloscarteirapagosqtd.Name = "ltituloscarteirapagosqtd";
            this.ltituloscarteirapagosqtd.NullValueText = " ";
            this.ltituloscarteirapagosqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltituloscarteirapagosqtd.SizeF = new System.Drawing.SizeF(120F, 10F);
            this.ltituloscarteirapagosqtd.StylePriority.UseBackColor = false;
            this.ltituloscarteirapagosqtd.StylePriority.UseFont = false;
            this.ltituloscarteirapagosqtd.StylePriority.UseTextAlignment = false;
            this.ltituloscarteirapagosqtd.Text = "ltituloscarteirapagosqtd";
            this.ltituloscarteirapagosqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltituloscarteirapagosqtd.WordWrap = false;
            // 
            // ltitulosbancariadevidosqtd
            // 
            this.ltitulosbancariadevidosqtd.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltitulosbancariadevidosqtd.ForeColor = System.Drawing.Color.Black;
            this.ltitulosbancariadevidosqtd.LocationFloat = new DevExpress.Utils.PointFloat(808.9999F, 1.041667F);
            this.ltitulosbancariadevidosqtd.Name = "ltitulosbancariadevidosqtd";
            this.ltitulosbancariadevidosqtd.NullValueText = " ";
            this.ltitulosbancariadevidosqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulosbancariadevidosqtd.SizeF = new System.Drawing.SizeF(120F, 9.999999F);
            this.ltitulosbancariadevidosqtd.StylePriority.UseBackColor = false;
            this.ltitulosbancariadevidosqtd.StylePriority.UseFont = false;
            this.ltitulosbancariadevidosqtd.StylePriority.UseTextAlignment = false;
            this.ltitulosbancariadevidosqtd.Text = "ltitulosbancariadevidosqtd";
            this.ltitulosbancariadevidosqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltitulosbancariadevidosqtd.WordWrap = false;
            // 
            // ltitulospagosqtd
            // 
            this.ltitulospagosqtd.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltitulospagosqtd.ForeColor = System.Drawing.Color.Black;
            this.ltitulospagosqtd.LocationFloat = new DevExpress.Utils.PointFloat(209F, 1F);
            this.ltitulospagosqtd.Name = "ltitulospagosqtd";
            this.ltitulospagosqtd.NullValueText = " ";
            this.ltitulospagosqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulospagosqtd.SizeF = new System.Drawing.SizeF(120F, 10F);
            this.ltitulospagosqtd.StylePriority.UseBackColor = false;
            this.ltitulospagosqtd.StylePriority.UseFont = false;
            this.ltitulospagosqtd.StylePriority.UseTextAlignment = false;
            this.ltitulospagosqtd.Text = "ltitulospagosqtd";
            this.ltitulospagosqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltitulospagosqtd.WordWrap = false;
            // 
            // ltitulosprotestoqtd
            // 
            this.ltitulosprotestoqtd.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltitulosprotestoqtd.ForeColor = System.Drawing.Color.Black;
            this.ltitulosprotestoqtd.LocationFloat = new DevExpress.Utils.PointFloat(928.9999F, 1.041667F);
            this.ltitulosprotestoqtd.Name = "ltitulosprotestoqtd";
            this.ltitulosprotestoqtd.NullValueText = " ";
            this.ltitulosprotestoqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulosprotestoqtd.SizeF = new System.Drawing.SizeF(120.0001F, 9.999999F);
            this.ltitulosprotestoqtd.StylePriority.UseBackColor = false;
            this.ltitulosprotestoqtd.StylePriority.UseFont = false;
            this.ltitulosprotestoqtd.StylePriority.UseTextAlignment = false;
            this.ltitulosprotestoqtd.Text = "ltitulosprotestoqtd";
            this.ltitulosprotestoqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltitulosprotestoqtd.WordWrap = false;
            // 
            // ltitulosdevidosqtd
            // 
            this.ltitulosdevidosqtd.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltitulosdevidosqtd.ForeColor = System.Drawing.Color.Black;
            this.ltitulosdevidosqtd.LocationFloat = new DevExpress.Utils.PointFloat(329F, 1.041667F);
            this.ltitulosdevidosqtd.Name = "ltitulosdevidosqtd";
            this.ltitulosdevidosqtd.NullValueText = " ";
            this.ltitulosdevidosqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulosdevidosqtd.SizeF = new System.Drawing.SizeF(120F, 10F);
            this.ltitulosdevidosqtd.StylePriority.UseBackColor = false;
            this.ltitulosdevidosqtd.StylePriority.UseFont = false;
            this.ltitulosdevidosqtd.StylePriority.UseTextAlignment = false;
            this.ltitulosdevidosqtd.Text = "ltitulosdevidosqtd";
            this.ltitulosdevidosqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltitulosdevidosqtd.WordWrap = false;
            // 
            // ltitulosqtd
            // 
            this.ltitulosqtd.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.ltitulosqtd.ForeColor = System.Drawing.Color.Black;
            this.ltitulosqtd.LocationFloat = new DevExpress.Utils.PointFloat(0.0001509984F, 1.041667F);
            this.ltitulosqtd.Name = "ltitulosqtd";
            this.ltitulosqtd.NullValueText = " ";
            this.ltitulosqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulosqtd.SizeF = new System.Drawing.SizeF(208.9998F, 10F);
            this.ltitulosqtd.StylePriority.UseBackColor = false;
            this.ltitulosqtd.StylePriority.UseFont = false;
            this.ltitulosqtd.StylePriority.UseTextAlignment = false;
            this.ltitulosqtd.Text = "ltitulosqtd";
            this.ltitulosqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltitulosqtd.WordWrap = false;
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
            this.ltitulorelatorio.Text = "RELATÓRIO VENDAS CARTEIRA";
            this.ltitulorelatorio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // grupocabecalho
            // 
            this.grupocabecalho.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel18,
            this.xrLabel26,
            this.xrLabel19});
            this.grupocabecalho.HeightF = 14.04165F;
            this.grupocabecalho.Name = "grupocabecalho";
            this.grupocabecalho.RepeatEveryPage = true;
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
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(808.9999F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(120F, 13F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Bancária Devidos";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(689F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(120F, 13F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Bancária Pagos";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(449F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(120F, 13F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Carteira Pagos";
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
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(929F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(120F, 13F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Em Protesto";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(569F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(120F, 13F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Carteira Devidos";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel18.SizeF = new System.Drawing.SizeF(208.9998F, 13F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseBorderColor = false;
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseForeColor = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Títulos";
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
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(329F, 0F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(120F, 13F);
            this.xrLabel26.StylePriority.UseBackColor = false;
            this.xrLabel26.StylePriority.UseBorderColor = false;
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseForeColor = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.Text = "Devidos";
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
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(209F, 0F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(120F, 13F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseBorderColor = false;
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseForeColor = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Pagos";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // grupofiltros
            // 
            this.grupofiltros.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lfperiodo,
            this.xrLabel11,
            this.lfgrupo,
            this.xrLabel1,
            this.lfproduto,
            this.xrLabel4});
            this.grupofiltros.HeightF = 43.75F;
            this.grupofiltros.Level = 1;
            this.grupofiltros.Name = "grupofiltros";
            // 
            // lfperiodo
            // 
            this.lfperiodo.LocationFloat = new DevExpress.Utils.PointFloat(659.7916F, 0.9999911F);
            this.lfperiodo.Name = "lfperiodo";
            this.lfperiodo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfperiodo.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lfperiodo.StylePriority.UseTextAlignment = false;
            this.lfperiodo.Text = "lfperiodo";
            this.lfperiodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(582.5615F, 0.9999911F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(74.63166F, 20F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Período:";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfgrupo
            // 
            this.lfgrupo.LocationFloat = new DevExpress.Utils.PointFloat(81.23016F, 21.99999F);
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
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(4.000155F, 21.99999F);
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
            this.lfproduto.LocationFloat = new DevExpress.Utils.PointFloat(81.23017F, 1F);
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
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(3.999998F, 1F);
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
            this.lcaminho.Text = "Gitano ->SGFin ->Empresa ->Relatório Vendas Carteira";
            // 
            // ltitulosvlr
            // 
            this.ltitulosvlr.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.ltitulosvlr.ForeColor = System.Drawing.Color.Black;
            this.ltitulosvlr.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 12.125F);
            this.ltitulosvlr.Name = "ltitulosvlr";
            this.ltitulosvlr.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulosvlr.SizeF = new System.Drawing.SizeF(208.9998F, 10F);
            this.ltitulosvlr.StylePriority.UseBackColor = false;
            this.ltitulosvlr.StylePriority.UseFont = false;
            this.ltitulosvlr.StylePriority.UseTextAlignment = false;
            this.ltitulosvlr.Text = "ltitulosvlr";
            this.ltitulosvlr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltitulosvlr.WordWrap = false;
            // 
            // ltitulosdevidosvlr
            // 
            this.ltitulosdevidosvlr.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltitulosdevidosvlr.ForeColor = System.Drawing.Color.Black;
            this.ltitulosdevidosvlr.LocationFloat = new DevExpress.Utils.PointFloat(328.9999F, 12.125F);
            this.ltitulosdevidosvlr.Name = "ltitulosdevidosvlr";
            this.ltitulosdevidosvlr.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulosdevidosvlr.SizeF = new System.Drawing.SizeF(120F, 10F);
            this.ltitulosdevidosvlr.StylePriority.UseBackColor = false;
            this.ltitulosdevidosvlr.StylePriority.UseFont = false;
            this.ltitulosdevidosvlr.StylePriority.UseTextAlignment = false;
            this.ltitulosdevidosvlr.Text = "ltitulosdevidosvlr";
            this.ltitulosdevidosvlr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltitulosdevidosvlr.WordWrap = false;
            // 
            // ltitulosprotestovlr
            // 
            this.ltitulosprotestovlr.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltitulosprotestovlr.ForeColor = System.Drawing.Color.Black;
            this.ltitulosprotestovlr.LocationFloat = new DevExpress.Utils.PointFloat(928.9999F, 12.125F);
            this.ltitulosprotestovlr.Name = "ltitulosprotestovlr";
            this.ltitulosprotestovlr.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulosprotestovlr.SizeF = new System.Drawing.SizeF(120.0001F, 9.999999F);
            this.ltitulosprotestovlr.StylePriority.UseBackColor = false;
            this.ltitulosprotestovlr.StylePriority.UseFont = false;
            this.ltitulosprotestovlr.StylePriority.UseTextAlignment = false;
            this.ltitulosprotestovlr.Text = "ltitulosprotestovlr";
            this.ltitulosprotestovlr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltitulosprotestovlr.WordWrap = false;
            // 
            // ltitulospagosvlr
            // 
            this.ltitulospagosvlr.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltitulospagosvlr.ForeColor = System.Drawing.Color.Black;
            this.ltitulospagosvlr.LocationFloat = new DevExpress.Utils.PointFloat(208.9999F, 12.08333F);
            this.ltitulospagosvlr.Name = "ltitulospagosvlr";
            this.ltitulospagosvlr.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulospagosvlr.SizeF = new System.Drawing.SizeF(120F, 10F);
            this.ltitulospagosvlr.StylePriority.UseBackColor = false;
            this.ltitulospagosvlr.StylePriority.UseFont = false;
            this.ltitulospagosvlr.StylePriority.UseTextAlignment = false;
            this.ltitulospagosvlr.Text = "ltitulospagosvlr";
            this.ltitulospagosvlr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltitulospagosvlr.WordWrap = false;
            // 
            // ltitulosbancariadevidosvlr
            // 
            this.ltitulosbancariadevidosvlr.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltitulosbancariadevidosvlr.ForeColor = System.Drawing.Color.Black;
            this.ltitulosbancariadevidosvlr.LocationFloat = new DevExpress.Utils.PointFloat(808.9999F, 12.125F);
            this.ltitulosbancariadevidosvlr.Name = "ltitulosbancariadevidosvlr";
            this.ltitulosbancariadevidosvlr.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulosbancariadevidosvlr.SizeF = new System.Drawing.SizeF(120F, 9.999999F);
            this.ltitulosbancariadevidosvlr.StylePriority.UseBackColor = false;
            this.ltitulosbancariadevidosvlr.StylePriority.UseFont = false;
            this.ltitulosbancariadevidosvlr.StylePriority.UseTextAlignment = false;
            this.ltitulosbancariadevidosvlr.Text = "ltitulosbancariadevidosvlr";
            this.ltitulosbancariadevidosvlr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltitulosbancariadevidosvlr.WordWrap = false;
            // 
            // ltituloscarteirapagosvlr
            // 
            this.ltituloscarteirapagosvlr.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltituloscarteirapagosvlr.ForeColor = System.Drawing.Color.Black;
            this.ltituloscarteirapagosvlr.LocationFloat = new DevExpress.Utils.PointFloat(449F, 12.12502F);
            this.ltituloscarteirapagosvlr.Name = "ltituloscarteirapagosvlr";
            this.ltituloscarteirapagosvlr.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltituloscarteirapagosvlr.SizeF = new System.Drawing.SizeF(120F, 10F);
            this.ltituloscarteirapagosvlr.StylePriority.UseBackColor = false;
            this.ltituloscarteirapagosvlr.StylePriority.UseFont = false;
            this.ltituloscarteirapagosvlr.StylePriority.UseTextAlignment = false;
            this.ltituloscarteirapagosvlr.Text = "ltituloscarteirapagosvlr";
            this.ltituloscarteirapagosvlr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltituloscarteirapagosvlr.WordWrap = false;
            // 
            // ltituloscarteiradevidosvlr
            // 
            this.ltituloscarteiradevidosvlr.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltituloscarteiradevidosvlr.ForeColor = System.Drawing.Color.Black;
            this.ltituloscarteiradevidosvlr.LocationFloat = new DevExpress.Utils.PointFloat(568.9999F, 12.125F);
            this.ltituloscarteiradevidosvlr.Name = "ltituloscarteiradevidosvlr";
            this.ltituloscarteiradevidosvlr.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltituloscarteiradevidosvlr.SizeF = new System.Drawing.SizeF(120F, 10F);
            this.ltituloscarteiradevidosvlr.StylePriority.UseBackColor = false;
            this.ltituloscarteiradevidosvlr.StylePriority.UseFont = false;
            this.ltituloscarteiradevidosvlr.StylePriority.UseTextAlignment = false;
            this.ltituloscarteiradevidosvlr.Text = "ltituloscarteiradevidosvlr";
            this.ltituloscarteiradevidosvlr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltituloscarteiradevidosvlr.WordWrap = false;
            // 
            // ltitulosbancariapagosvlr
            // 
            this.ltitulosbancariapagosvlr.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltitulosbancariapagosvlr.ForeColor = System.Drawing.Color.Black;
            this.ltitulosbancariapagosvlr.LocationFloat = new DevExpress.Utils.PointFloat(688.9998F, 12.125F);
            this.ltitulosbancariapagosvlr.Name = "ltitulosbancariapagosvlr";
            this.ltitulosbancariapagosvlr.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulosbancariapagosvlr.SizeF = new System.Drawing.SizeF(120F, 10F);
            this.ltitulosbancariapagosvlr.StylePriority.UseBackColor = false;
            this.ltitulosbancariapagosvlr.StylePriority.UseFont = false;
            this.ltitulosbancariapagosvlr.StylePriority.UseTextAlignment = false;
            this.ltitulosbancariapagosvlr.Text = "ltitulosbancariapagosvlr";
            this.ltitulosbancariapagosvlr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltitulosbancariapagosvlr.WordWrap = false;
            // 
            // RepVendasCarteira
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.grupocabecalho,
            this.grupofiltros,
            this.PageFooter});
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
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepVendasCarteira_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

	private void RepVendasCarteira_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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

}
