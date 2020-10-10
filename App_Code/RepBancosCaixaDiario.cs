using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for RepBancosCaixaDiario
/// </summary>
public class RepBancosCaixaDiario : DevExpress.XtraReports.UI.XtraReport
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
	private XRLabel xrLabel19;
    private GroupHeaderBand grupofiltros;
    public XRLabel ltempresa;
	public XRLabel ltusuario;
	private XRPictureBox xrPictureBox1;
	private XRControlStyle xrControlStyle1;
	private XRControlStyle xrControlStyle2;
	public XRLabel llancamento;
	public XRLabel lcheque;
    public XRLabel lvlrentradas;
    public XRLabel lproduto;
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
    private XRLabel xrLabel8;
    private XRLabel xrLabel16;
    private XRLabel xrLabel13;
    public XRLabel ldata;
    private ReportFooterBand ReportFooter;
    public XRLabel ltotlancamentos;
    public XRLabel ltotsaidas;
    public XRLabel ltotentradas;
    public XRLabel xrLabel21;
    public XRLabel lvlrfinal;
    public XRLabel lvlrsaidas;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    public XRLabel ltotsaldofinal;
    public XRLabel lordemcompra;
    private XRLabel xrLabel4;
    public XRLabel lcomplemento;
    private XRLabel xrLabel12;
	
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public RepBancosCaixaDiario()
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
            //string resourceFileName = "RepBancosCaixaDiario.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lvlrfinal = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrsaidas = new DevExpress.XtraReports.UI.XRLabel();
            this.ldata = new DevExpress.XtraReports.UI.XRLabel();
            this.ldescricao = new DevExpress.XtraReports.UI.XRLabel();
            this.lproduto = new DevExpress.XtraReports.UI.XRLabel();
            this.lcheque = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrentradas = new DevExpress.XtraReports.UI.XRLabel();
            this.llancamento = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
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
            this.ltotsaldofinal = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotlancamentos = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaidas = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotentradas = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lordemcompra = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.lcomplemento = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lcomplemento,
            this.lordemcompra,
            this.lvlrfinal,
            this.lvlrsaidas,
            this.ldata,
            this.ldescricao,
            this.lproduto,
            this.lcheque,
            this.lvlrentradas,
            this.llancamento});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 11.45833F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // lvlrfinal
            // 
            this.lvlrfinal.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrfinal.ForeColor = System.Drawing.Color.Black;
            this.lvlrfinal.LocationFloat = new DevExpress.Utils.PointFloat(788.0001F, 1.041667F);
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
            this.lvlrsaidas.LocationFloat = new DevExpress.Utils.PointFloat(688.0001F, 1.041667F);
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
            this.ldata.LocationFloat = new DevExpress.Utils.PointFloat(520.2916F, 1.041667F);
            this.ldata.Name = "ldata";
            this.ldata.NullValueText = " ";
            this.ldata.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldata.SizeF = new System.Drawing.SizeF(67.70844F, 9.999999F);
            this.ldata.StylePriority.UseBackColor = false;
            this.ldata.StylePriority.UseFont = false;
            this.ldata.StylePriority.UseTextAlignment = false;
            this.ldata.Text = "ldata";
            this.ldata.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ldata.WordWrap = false;
            // 
            // ldescricao
            // 
            this.ldescricao.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldescricao.ForeColor = System.Drawing.Color.Black;
            this.ldescricao.LocationFloat = new DevExpress.Utils.PointFloat(100.0002F, 1.041667F);
            this.ldescricao.Name = "ldescricao";
            this.ldescricao.NullValueText = " ";
            this.ldescricao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldescricao.SizeF = new System.Drawing.SizeF(225.9998F, 10F);
            this.ldescricao.StylePriority.UseBackColor = false;
            this.ldescricao.StylePriority.UseFont = false;
            this.ldescricao.StylePriority.UseTextAlignment = false;
            this.ldescricao.Text = "ldescricao";
            this.ldescricao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.ldescricao.WordWrap = false;
            // 
            // lproduto
            // 
            this.lproduto.Font = new System.Drawing.Font("Calibri", 7F);
            this.lproduto.ForeColor = System.Drawing.Color.Black;
            this.lproduto.LocationFloat = new DevExpress.Utils.PointFloat(50.00016F, 1.041667F);
            this.lproduto.Name = "lproduto";
            this.lproduto.NullValueText = " ";
            this.lproduto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lproduto.SizeF = new System.Drawing.SizeF(50.00002F, 10F);
            this.lproduto.StylePriority.UseBackColor = false;
            this.lproduto.StylePriority.UseFont = false;
            this.lproduto.Text = "lproduto";
            this.lproduto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lproduto.WordWrap = false;
            // 
            // lcheque
            // 
            this.lcheque.Font = new System.Drawing.Font("Calibri", 7F);
            this.lcheque.ForeColor = System.Drawing.Color.Black;
            this.lcheque.LocationFloat = new DevExpress.Utils.PointFloat(976.0001F, 1.041667F);
            this.lcheque.Name = "lcheque";
            this.lcheque.NullValueText = " ";
            this.lcheque.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcheque.SizeF = new System.Drawing.SizeF(70F, 9.999999F);
            this.lcheque.StylePriority.UseBackColor = false;
            this.lcheque.StylePriority.UseFont = false;
            this.lcheque.StylePriority.UseTextAlignment = false;
            this.lcheque.Text = "lcheque";
            this.lcheque.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lcheque.WordWrap = false;
            // 
            // lvlrentradas
            // 
            this.lvlrentradas.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrentradas.ForeColor = System.Drawing.Color.Black;
            this.lvlrentradas.LocationFloat = new DevExpress.Utils.PointFloat(588.0001F, 1.041667F);
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
            // llancamento
            // 
            this.llancamento.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.llancamento.ForeColor = System.Drawing.Color.Black;
            this.llancamento.LocationFloat = new DevExpress.Utils.PointFloat(0.0001509984F, 1.041667F);
            this.llancamento.Name = "llancamento";
            this.llancamento.NullValueText = " ";
            this.llancamento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.llancamento.SizeF = new System.Drawing.SizeF(50.00001F, 10F);
            this.llancamento.StylePriority.UseBackColor = false;
            this.llancamento.StylePriority.UseFont = false;
            this.llancamento.Text = "llancamento";
            this.llancamento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.llancamento.WordWrap = false;
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
            this.ltitulorelatorio.Text = "RELATÓRIO BANCOS - CAIXA DIÁRIO";
            this.ltitulorelatorio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // grupocabecalho
            // 
            this.grupocabecalho.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12,
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel1,
            this.xrLabel16,
            this.xrLabel13,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel18,
            this.xrLabel19});
            this.grupocabecalho.HeightF = 13F;
            this.grupocabecalho.Name = "grupocabecalho";
            this.grupocabecalho.RepeatEveryPage = true;
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
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(788.2918F, 0F);
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
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(688.0001F, 0F);
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
            // xrLabel16
            // 
            this.xrLabel16.BackColor = System.Drawing.Color.Silver;
            this.xrLabel16.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel16.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel16.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(976.0001F, 0F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(70F, 13F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseBorderColor = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Cheque";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(520.2917F, 0F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(67.70844F, 13F);
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
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(588.0001F, 0F);
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
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(100.0002F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(225.9999F, 13F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Descrição";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel18.Text = "Lanc.";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel19.Text = "Produto";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // grupofiltros
            // 
            this.grupofiltros.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lfperiodoprevisao,
            this.xrLabel11,
            this.lfcontacorrente,
            this.xrLabel10});
            this.grupofiltros.HeightF = 26.04167F;
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
            this.lcaminho.Text = "Gitano ->SGFin ->Bancos ->Relatório Caixa Diário";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ltotsaldofinal,
            this.ltotlancamentos,
            this.ltotsaidas,
            this.ltotentradas,
            this.xrLabel21,
            this.xrLine1});
            this.ReportFooter.HeightF = 35.41667F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ReportFooter_BeforePrint);
            // 
            // ltotsaldofinal
            // 
            this.ltotsaldofinal.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldofinal.LocationFloat = new DevExpress.Utils.PointFloat(788.0003F, 10.00004F);
            this.ltotsaldofinal.Name = "ltotsaldofinal";
            this.ltotsaldofinal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldofinal.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotsaldofinal.StylePriority.UseFont = false;
            this.ltotsaldofinal.StylePriority.UseTextAlignment = false;
            this.ltotsaldofinal.Text = "ltotsaldofinal";
            this.ltotsaldofinal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotlancamentos
            // 
            this.ltotlancamentos.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotlancamentos.LocationFloat = new DevExpress.Utils.PointFloat(438.0002F, 10.00001F);
            this.ltotlancamentos.Name = "ltotlancamentos";
            this.ltotlancamentos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotlancamentos.SizeF = new System.Drawing.SizeF(108.0415F, 14F);
            this.ltotlancamentos.StylePriority.UseFont = false;
            this.ltotlancamentos.StylePriority.UseTextAlignment = false;
            this.ltotlancamentos.Text = "ltotlancamentos";
            this.ltotlancamentos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaidas
            // 
            this.ltotsaidas.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaidas.LocationFloat = new DevExpress.Utils.PointFloat(688.0003F, 10.00004F);
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
            this.ltotentradas.LocationFloat = new DevExpress.Utils.PointFloat(588.0002F, 10.00001F);
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
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.Silver;
            this.xrLabel4.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel4.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(888.2918F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(87.70831F, 13F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Ordem Compra";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lordemcompra
            // 
            this.lordemcompra.Font = new System.Drawing.Font("Calibri", 7F);
            this.lordemcompra.ForeColor = System.Drawing.Color.Black;
            this.lordemcompra.LocationFloat = new DevExpress.Utils.PointFloat(888.2919F, 1.041667F);
            this.lordemcompra.Name = "lordemcompra";
            this.lordemcompra.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lordemcompra.SizeF = new System.Drawing.SizeF(87.70825F, 9.999999F);
            this.lordemcompra.StylePriority.UseBackColor = false;
            this.lordemcompra.StylePriority.UseFont = false;
            this.lordemcompra.StylePriority.UseTextAlignment = false;
            this.lordemcompra.Text = "lordemcompra";
            this.lordemcompra.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lordemcompra.WordWrap = false;
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
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(326.0001F, 0F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(194.2917F, 13F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseBorderColor = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Complemento";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lcomplemento
            // 
            this.lcomplemento.Font = new System.Drawing.Font("Calibri", 7F);
            this.lcomplemento.ForeColor = System.Drawing.Color.Black;
            this.lcomplemento.LocationFloat = new DevExpress.Utils.PointFloat(326.0001F, 1.041667F);
            this.lcomplemento.Name = "lcomplemento";
            this.lcomplemento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcomplemento.SizeF = new System.Drawing.SizeF(194.2916F, 10F);
            this.lcomplemento.StylePriority.UseBackColor = false;
            this.lcomplemento.StylePriority.UseFont = false;
            this.lcomplemento.StylePriority.UseTextAlignment = false;
            this.lcomplemento.Text = "lcomplemento";
            this.lcomplemento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lcomplemento.WordWrap = false;
            // 
            // RepBancosCaixaDiario
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
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepBancosCaixaDiario_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

    //
    double totentradas = 0.00;
    double totsaidas = 0.00;
    Int64 totqtd = 0;
    //
    double totsaldofinal = 0.00;
    //double totaplicacaod = 0.00;
    //double totaplicacaob = 0.00;
    //double totsaldofinalaplicacao = 0.00;
    //
        //cheques e depositos
    public double cheques = 0.00;
    public double depositos = 0.00;


	private void RepBancosCaixaDiario_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
        double entradas = Convert.ToDouble(GetCurrentColumnValue("credito"));
        double saidas = Convert.ToDouble(GetCurrentColumnValue("debito"));
        Int64 parcelaqtd = 1;
        //
        totentradas = totentradas + entradas;
        totsaidas = totsaidas + saidas;
        totqtd = totqtd + parcelaqtd;
        //
        double saldofinal = Convert.ToDouble(GetCurrentColumnValue("saldo_f"));
        //double aplicacaod = Convert.ToDouble(GetCurrentColumnValue("saldo_aplicacaoD"));
        //double aplicacaob = Convert.ToDouble(GetCurrentColumnValue("saldo_aplicacaoB"));
        //double saldofinalaplicacao = Convert.ToDouble(GetCurrentColumnValue("saldo_f")) +
        //                             Convert.ToDouble(GetCurrentColumnValue("saldo_aplicacaoD")) +
        //                             Convert.ToDouble(GetCurrentColumnValue("saldo_aplicacaoB"));
        //
        totsaldofinal = saldofinal;
        //totaplicacaod = aplicacaod;
        //totaplicacaob = aplicacaob;
        //totsaldofinalaplicacao = saldofinalaplicacao;
        //
        entradas = 0.00;
        saidas = 0.00;
        parcelaqtd = 0;
        //
    }

    private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //Limite de Crédito
        //Double Limite = 0.00;
        //Limite = Convert.ToDouble(lflimitecredito.Text);
        //
        ltotentradas.Text = String.Format("{0:N}", Convert.ToDouble(totentradas));
        ltotsaidas.Text = String.Format("{0:N}", Convert.ToDouble(totsaidas));
        ltotlancamentos.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(totqtd));
        //
        ltotsaldofinal.Text = String.Format("{0:N}", Convert.ToDouble(totsaldofinal));
        //ltotsaldoaplicb.Text = String.Format("{0:N}", Convert.ToDouble(totaplicacaob));
        //ltotsaldoaplicd.Text = String.Format("{0:N}", Convert.ToDouble(totaplicacaod));
        //ltotsaldofinalaplicacao.Text = String.Format("{0:N}", Convert.ToDouble(totsaldofinalaplicacao));
        ////
        //ltotsaldofinal2.Text = String.Format("{0:N}", Convert.ToDouble(totsaldofinal) + Limite);
        //ltotsaldoaplicb2.Text = String.Format("{0:N}", Convert.ToDouble(totaplicacaob));
        //ltotsaldoaplicd2.Text = String.Format("{0:N}", Convert.ToDouble(totaplicacaod));
        //ltotsaldofinalaplicacao2.Text = String.Format("{0:N}", Convert.ToDouble(totsaldofinalaplicacao) + Limite);
        ////
        //ltotcheques.Text = String.Format("{0:N}", cheques);
        //ltotdepositos.Text = String.Format("{0:N}", depositos);

    }

}
