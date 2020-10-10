using DevExpress.XtraReports.UI;
using System;

/// <summary>
/// Summary description for RepBancosResumoContas
/// </summary>
public class RepBancosResumoContas : DevExpress.XtraReports.UI.XtraReport
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
    private GroupHeaderBand grupofiltros;
    public XRLabel ltempresa;
	public XRLabel ltusuario;
	private XRPictureBox xrPictureBox1;
	private XRControlStyle xrControlStyle1;
	private XRControlStyle xrControlStyle2;
    public XRLabel lconta;
    public XRLabel lvlrentradas;
    private XRLabel xrLabel15;
    private FormattingRule formattingRule1;
	private PageFooterBand PageFooter;
    public XRLabel lcaminho;
    public XRLabel ldescricao;
    private XRLabel xrLabel7;
    private XRLine xrLine1;
    public XRLabel lfcontacorrente;
    private XRLabel xrLabel10;
    public XRLabel lfperiodoprevisao;
    private XRLabel xrLabel11;
    public XRLabel lvlrinicial;
    private XRLabel xrLabel8;
    private XRLabel xrLabel13;
    public XRLabel ldata;
    private ReportFooterBand ReportFooter;
    public XRLabel ltotsaidas;
    public XRLabel ltotentradas;
    public XRLabel xrLabel21;
    public XRLabel lvlrfinal;
    public XRLabel lvlrsaidas;
    private XRLabel xrLabel17;
    private XRLabel xrLabel12;
    private XRLabel xrLabel4;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    public XRLabel lvlrsaldomaisaplicacao;
    public XRLabel lvlraplicacaodesbloq;
    public XRLabel lvlraplicacaobloq;
    public XRLabel ltotsaldofinalaplicacao;
    public XRLabel ltotsaldoaplicd;
    public XRLabel ltotsaldoaplicb;
    public XRLabel ltotsaldofinal;
	
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public RepBancosResumoContas()
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
            //string resourceFileName = "RepBancosResumoContas.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lvlrsaldomaisaplicacao = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlraplicacaodesbloq = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlraplicacaobloq = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrfinal = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrsaidas = new DevExpress.XtraReports.UI.XRLabel();
            this.ldata = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrinicial = new DevExpress.XtraReports.UI.XRLabel();
            this.ldescricao = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrentradas = new DevExpress.XtraReports.UI.XRLabel();
            this.lconta = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
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
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.grupofiltros = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lfperiodoprevisao = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfcontacorrente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lcaminho = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.ltotsaldofinalaplicacao = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaldoaplicd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaldoaplicb = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaldofinal = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaidas = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotentradas = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lvlrsaldomaisaplicacao,
            this.lvlraplicacaodesbloq,
            this.lvlraplicacaobloq,
            this.lvlrfinal,
            this.lvlrsaidas,
            this.ldata,
            this.lvlrinicial,
            this.ldescricao,
            this.lvlrentradas,
            this.lconta});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 13.54167F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // lvlrsaldomaisaplicacao
            // 
            this.lvlrsaldomaisaplicacao.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrsaldomaisaplicacao.ForeColor = System.Drawing.Color.Black;
            this.lvlrsaldomaisaplicacao.LocationFloat = new DevExpress.Utils.PointFloat(948.9165F, 1.041667F);
            this.lvlrsaldomaisaplicacao.Name = "lvlrsaldomaisaplicacao";
            this.lvlrsaldomaisaplicacao.NullValueText = " ";
            this.lvlrsaldomaisaplicacao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrsaldomaisaplicacao.SizeF = new System.Drawing.SizeF(100.0001F, 9.999999F);
            this.lvlrsaldomaisaplicacao.StylePriority.UseBackColor = false;
            this.lvlrsaldomaisaplicacao.StylePriority.UseFont = false;
            this.lvlrsaldomaisaplicacao.Text = "lvlrsaldomaisaplicacao";
            this.lvlrsaldomaisaplicacao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlrsaldomaisaplicacao.WordWrap = false;
            // 
            // lvlraplicacaodesbloq
            // 
            this.lvlraplicacaodesbloq.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlraplicacaodesbloq.ForeColor = System.Drawing.Color.Black;
            this.lvlraplicacaodesbloq.LocationFloat = new DevExpress.Utils.PointFloat(848.9169F, 1.041667F);
            this.lvlraplicacaodesbloq.Name = "lvlraplicacaodesbloq";
            this.lvlraplicacaodesbloq.NullValueText = " ";
            this.lvlraplicacaodesbloq.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlraplicacaodesbloq.SizeF = new System.Drawing.SizeF(100.0001F, 9.999999F);
            this.lvlraplicacaodesbloq.StylePriority.UseBackColor = false;
            this.lvlraplicacaodesbloq.StylePriority.UseFont = false;
            this.lvlraplicacaodesbloq.Text = "lvlraplicacaodesbloq";
            this.lvlraplicacaodesbloq.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlraplicacaodesbloq.WordWrap = false;
            // 
            // lvlraplicacaobloq
            // 
            this.lvlraplicacaobloq.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlraplicacaobloq.ForeColor = System.Drawing.Color.Black;
            this.lvlraplicacaobloq.LocationFloat = new DevExpress.Utils.PointFloat(748.9167F, 1.000023F);
            this.lvlraplicacaobloq.Name = "lvlraplicacaobloq";
            this.lvlraplicacaobloq.NullValueText = " ";
            this.lvlraplicacaobloq.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlraplicacaobloq.SizeF = new System.Drawing.SizeF(100.0001F, 9.999999F);
            this.lvlraplicacaobloq.StylePriority.UseBackColor = false;
            this.lvlraplicacaobloq.StylePriority.UseFont = false;
            this.lvlraplicacaobloq.Text = "lvlraplicacaobloq";
            this.lvlraplicacaobloq.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlraplicacaobloq.WordWrap = false;
            // 
            // lvlrfinal
            // 
            this.lvlrfinal.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrfinal.ForeColor = System.Drawing.Color.Black;
            this.lvlrfinal.LocationFloat = new DevExpress.Utils.PointFloat(648.9166F, 1.041667F);
            this.lvlrfinal.Name = "lvlrfinal";
            this.lvlrfinal.NullValueText = " ";
            this.lvlrfinal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrfinal.SizeF = new System.Drawing.SizeF(100.0001F, 9.999999F);
            this.lvlrfinal.StylePriority.UseBackColor = false;
            this.lvlrfinal.StylePriority.UseFont = false;
            this.lvlrfinal.Text = "lvlrfinal";
            this.lvlrfinal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlrfinal.WordWrap = false;
            // 
            // lvlrsaidas
            // 
            this.lvlrsaidas.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrsaidas.ForeColor = System.Drawing.Color.Black;
            this.lvlrsaidas.LocationFloat = new DevExpress.Utils.PointFloat(548.9166F, 1.041667F);
            this.lvlrsaidas.Name = "lvlrsaidas";
            this.lvlrsaidas.NullValueText = " ";
            this.lvlrsaidas.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrsaidas.SizeF = new System.Drawing.SizeF(100.0001F, 9.999999F);
            this.lvlrsaidas.StylePriority.UseBackColor = false;
            this.lvlrsaidas.StylePriority.UseFont = false;
            this.lvlrsaidas.Text = "lvlrsaidas";
            this.lvlrsaidas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlrsaidas.WordWrap = false;
            // 
            // ldata
            // 
            this.ldata.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldata.ForeColor = System.Drawing.Color.Black;
            this.ldata.LocationFloat = new DevExpress.Utils.PointFloat(285.3751F, 1.041667F);
            this.ldata.Name = "ldata";
            this.ldata.NullValueText = " ";
            this.ldata.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldata.SizeF = new System.Drawing.SizeF(63.54176F, 9.999999F);
            this.ldata.StylePriority.UseBackColor = false;
            this.ldata.StylePriority.UseFont = false;
            this.ldata.StylePriority.UseTextAlignment = false;
            this.ldata.Text = "ldata";
            this.ldata.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ldata.WordWrap = false;
            // 
            // lvlrinicial
            // 
            this.lvlrinicial.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrinicial.ForeColor = System.Drawing.Color.Black;
            this.lvlrinicial.LocationFloat = new DevExpress.Utils.PointFloat(348.9167F, 1.041667F);
            this.lvlrinicial.Name = "lvlrinicial";
            this.lvlrinicial.NullValueText = " ";
            this.lvlrinicial.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrinicial.SizeF = new System.Drawing.SizeF(100F, 9.999999F);
            this.lvlrinicial.StylePriority.UseBackColor = false;
            this.lvlrinicial.StylePriority.UseFont = false;
            this.lvlrinicial.StylePriority.UseTextAlignment = false;
            this.lvlrinicial.Text = "lvlrinicial";
            this.lvlrinicial.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlrinicial.WordWrap = false;
            // 
            // ldescricao
            // 
            this.ldescricao.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldescricao.ForeColor = System.Drawing.Color.Black;
            this.ldescricao.LocationFloat = new DevExpress.Utils.PointFloat(45.29858F, 1.041667F);
            this.ldescricao.Name = "ldescricao";
            this.ldescricao.NullValueText = " ";
            this.ldescricao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldescricao.SizeF = new System.Drawing.SizeF(240.0765F, 10F);
            this.ldescricao.StylePriority.UseBackColor = false;
            this.ldescricao.StylePriority.UseFont = false;
            this.ldescricao.StylePriority.UseTextAlignment = false;
            this.ldescricao.Text = "ldescricao";
            this.ldescricao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.ldescricao.WordWrap = false;
            // 
            // lvlrentradas
            // 
            this.lvlrentradas.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrentradas.ForeColor = System.Drawing.Color.Black;
            this.lvlrentradas.LocationFloat = new DevExpress.Utils.PointFloat(448.9166F, 1.041667F);
            this.lvlrentradas.Name = "lvlrentradas";
            this.lvlrentradas.NullValueText = " ";
            this.lvlrentradas.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrentradas.SizeF = new System.Drawing.SizeF(100.0001F, 9.999999F);
            this.lvlrentradas.StylePriority.UseBackColor = false;
            this.lvlrentradas.StylePriority.UseFont = false;
            this.lvlrentradas.Text = "lvlrentradas";
            this.lvlrentradas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlrentradas.WordWrap = false;
            // 
            // lconta
            // 
            this.lconta.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lconta.ForeColor = System.Drawing.Color.Black;
            this.lconta.LocationFloat = new DevExpress.Utils.PointFloat(0.0001509984F, 1.041667F);
            this.lconta.Name = "lconta";
            this.lconta.NullValueText = " ";
            this.lconta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lconta.SizeF = new System.Drawing.SizeF(45.29842F, 10F);
            this.lconta.StylePriority.UseBackColor = false;
            this.lconta.StylePriority.UseFont = false;
            this.lconta.StylePriority.UseTextAlignment = false;
            this.lconta.Text = "lconta";
            this.lconta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.lconta.WordWrap = false;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0.0001192093F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
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
            this.ltitulorelatorio.Text = "RELATÓRIO BANCOS - RESUMO DE CONTAS";
            this.ltitulorelatorio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // grupocabecalho
            // 
            this.grupocabecalho.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel17,
            this.xrLabel12,
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel1,
            this.xrLabel13,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel15,
            this.xrLabel18});
            this.grupocabecalho.HeightF = 14.04165F;
            this.grupocabecalho.Name = "grupocabecalho";
            this.grupocabecalho.RepeatEveryPage = true;
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
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(948.9168F, 0F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(100F, 13F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Saldo Final + Aplic.";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(848.9168F, 0F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(100F, 13F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseBorderColor = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Aplicação Liquida";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.Silver;
            this.xrLabel4.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel4.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(748.9168F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(100F, 13F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Aplicação Bloq.";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(648.9169F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(100F, 13F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Saldo Final";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(548.9167F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(100F, 13F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Saídas (CP)";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(285.3751F, 0F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(63.5417F, 13F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseBorderColor = false;
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Data";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(448.9167F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(100F, 13F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Entradas (CR)";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(45.29858F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(240.0765F, 13F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Descrição";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(348.9167F, 0F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(100F, 13F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseBorderColor = false;
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "Inicial";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel18.SizeF = new System.Drawing.SizeF(45.29841F, 13F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseBorderColor = false;
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseForeColor = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Conta";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // grupofiltros
            // 
            this.grupofiltros.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lfperiodoprevisao,
            this.xrLabel11,
            this.lfcontacorrente,
            this.xrLabel10});
            this.grupofiltros.HeightF = 22.91667F;
            this.grupofiltros.Level = 1;
            this.grupofiltros.Name = "grupofiltros";
            // 
            // lfperiodoprevisao
            // 
            this.lfperiodoprevisao.LocationFloat = new DevExpress.Utils.PointFloat(666.7499F, 0.9999911F);
            this.lfperiodoprevisao.Name = "lfperiodoprevisao";
            this.lfperiodoprevisao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfperiodoprevisao.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lfperiodoprevisao.StylePriority.UseTextAlignment = false;
            this.lfperiodoprevisao.Text = "lfperiodoprevisao";
            this.lfperiodoprevisao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(568.0417F, 0.9999911F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(95F, 20F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Período:";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfcontacorrente
            // 
            this.lfcontacorrente.LocationFloat = new DevExpress.Utils.PointFloat(80.18853F, 0.9999911F);
            this.lfcontacorrente.Name = "lfcontacorrente";
            this.lfcontacorrente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfcontacorrente.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lfcontacorrente.StylePriority.UseTextAlignment = false;
            this.lfcontacorrente.Text = "lfcontacorrente";
            this.lfcontacorrente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(2.958329F, 0.9999911F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(74.6319F, 20F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Conta:";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            this.lcaminho.Text = "Gitano ->SGFin ->Bancos ->Relatório Resumo de Contas";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ltotsaldofinalaplicacao,
            this.ltotsaldoaplicd,
            this.ltotsaldoaplicb,
            this.ltotsaldofinal,
            this.ltotsaidas,
            this.ltotentradas,
            this.xrLabel21,
            this.xrLine1});
            this.ReportFooter.HeightF = 36.45833F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ReportFooter_BeforePrint);
            // 
            // ltotsaldofinalaplicacao
            // 
            this.ltotsaldofinalaplicacao.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldofinalaplicacao.LocationFloat = new DevExpress.Utils.PointFloat(948.9167F, 10.00004F);
            this.ltotsaldofinalaplicacao.Name = "ltotsaldofinalaplicacao";
            this.ltotsaldofinalaplicacao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldofinalaplicacao.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotsaldofinalaplicacao.StylePriority.UseFont = false;
            this.ltotsaldofinalaplicacao.StylePriority.UseTextAlignment = false;
            this.ltotsaldofinalaplicacao.Text = "ltotsaldofinalaplicacao";
            this.ltotsaldofinalaplicacao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaldoaplicd
            // 
            this.ltotsaldoaplicd.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldoaplicd.LocationFloat = new DevExpress.Utils.PointFloat(848.9167F, 10.00004F);
            this.ltotsaldoaplicd.Name = "ltotsaldoaplicd";
            this.ltotsaldoaplicd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldoaplicd.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotsaldoaplicd.StylePriority.UseFont = false;
            this.ltotsaldoaplicd.StylePriority.UseTextAlignment = false;
            this.ltotsaldoaplicd.Text = "ltotsaldoaplicd";
            this.ltotsaldoaplicd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaldoaplicb
            // 
            this.ltotsaldoaplicb.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldoaplicb.LocationFloat = new DevExpress.Utils.PointFloat(748.9167F, 10.00004F);
            this.ltotsaldoaplicb.Name = "ltotsaldoaplicb";
            this.ltotsaldoaplicb.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldoaplicb.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotsaldoaplicb.StylePriority.UseFont = false;
            this.ltotsaldoaplicb.StylePriority.UseTextAlignment = false;
            this.ltotsaldoaplicb.Text = "ltotsaldoaplicb";
            this.ltotsaldoaplicb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaldofinal
            // 
            this.ltotsaldofinal.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldofinal.LocationFloat = new DevExpress.Utils.PointFloat(648.9167F, 10.00001F);
            this.ltotsaldofinal.Name = "ltotsaldofinal";
            this.ltotsaldofinal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldofinal.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotsaldofinal.StylePriority.UseFont = false;
            this.ltotsaldofinal.StylePriority.UseTextAlignment = false;
            this.ltotsaldofinal.Text = "ltotsaldofinal";
            this.ltotsaldofinal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaidas
            // 
            this.ltotsaidas.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaidas.LocationFloat = new DevExpress.Utils.PointFloat(548.9166F, 10.00001F);
            this.ltotsaidas.Name = "ltotsaidas";
            this.ltotsaidas.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaidas.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotsaidas.StylePriority.UseFont = false;
            this.ltotsaidas.StylePriority.UseTextAlignment = false;
            this.ltotsaidas.Text = "ltotsaidas";
            this.ltotsaidas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotentradas
            // 
            this.ltotentradas.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotentradas.LocationFloat = new DevExpress.Utils.PointFloat(448.9165F, 9.999974F);
            this.ltotentradas.Name = "ltotentradas";
            this.ltotentradas.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotentradas.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotentradas.StylePriority.UseFont = false;
            this.ltotentradas.StylePriority.UseTextAlignment = false;
            this.ltotentradas.Text = "ltotentradas";
            this.ltotentradas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel21
            // 
            this.xrLabel21.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(1.999998F, 10.00001F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(198.0002F, 14F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Totais Gerais :";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RepBancosResumoContas
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
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepBancosResumoContas_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

    //
    double totentradas = 0.00;
    double totsaidas = 0.00;
    Int64 totqtd = 0;
    //
    double totsaldofinal = 0.00;
    double totaplicacaod = 0.00;
    double totaplicacaob = 0.00;
    double totsaldofinalaplicacao = 0.00;
    //
        //cheques e depositos
    public double cheques = 0.00;
    public double depositos = 0.00;


	private void RepBancosResumoContas_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
        string contacorrente = Convert.ToString(GetCurrentColumnValue("cod_conta"));
        string descricao = uContas.PegaContaDescricao(contacorrente);
        ldescricao.Text = descricao;
        //
        double entradas = Convert.ToDouble(GetCurrentColumnValue("credito"));
        double saidas = Convert.ToDouble(GetCurrentColumnValue("debito"));
        Int64 parcelaqtd = 1;
        //
        totentradas = totentradas + entradas;
        totsaidas = totsaidas + saidas;
        totqtd = totqtd + parcelaqtd;
        //
        double saldofinal = Convert.ToDouble(GetCurrentColumnValue("saldo_f"));
        double aplicacaod = Convert.ToDouble(GetCurrentColumnValue("saldo_aplicacaoD"));
        double aplicacaob = Convert.ToDouble(GetCurrentColumnValue("saldo_aplicacaoB"));
        double saldofinalaplicacao = Convert.ToDouble(GetCurrentColumnValue("saldo_f")) +
                                     Convert.ToDouble(GetCurrentColumnValue("saldo_aplicacaoD")) +
                                     Convert.ToDouble(GetCurrentColumnValue("saldo_aplicacaoB"));
        //
        totsaldofinal = totsaldofinal + saldofinal;
        totaplicacaod = totaplicacaod + aplicacaod;
        totaplicacaob = totaplicacaob + aplicacaob;
        totsaldofinalaplicacao = totsaldofinalaplicacao + saldofinalaplicacao;
        //
        entradas = 0.00;
        saidas = 0.00;
        parcelaqtd = 0;
        //
    }

    private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //
        ltotentradas.Text = String.Format("{0:N}", Convert.ToDouble(totentradas));
        ltotsaidas.Text = String.Format("{0:N}", Convert.ToDouble(totsaidas));
        //
        ltotsaldofinal.Text = String.Format("{0:N}", Convert.ToDouble(totsaldofinal));
        ltotsaldoaplicb.Text = String.Format("{0:N}", Convert.ToDouble(totaplicacaob));
        ltotsaldoaplicd.Text = String.Format("{0:N}", Convert.ToDouble(totaplicacaod));
        ltotsaldofinalaplicacao.Text = String.Format("{0:N}", Convert.ToDouble(totsaldofinalaplicacao));
        //
    }

}
