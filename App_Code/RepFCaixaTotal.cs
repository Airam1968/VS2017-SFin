using DevExpress.XtraReports.UI;
using System;

/// <summary>
/// Summary description for RepFCaixaTotal
/// </summary>
public class RepFCaixaTotal : DevExpress.XtraReports.UI.XtraReport
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
	public XRLabel llancamento;
	public XRLabel ldescricao;
	public XRLabel lvlrpagamento;
    public XRLabel lconta;
	private XRLabel xrLabel15;
    public XRLabel ldatavencimento;
    public XRLabel lproduto;
    private FormattingRule formattingRule1;
    private XRLabel xrLabel5;
	private PageFooterBand PageFooter;
    public XRLabel lcaminho;
    public XRLabel lclassedespesa;
    private XRLabel xrLabel6;
    public XRLabel lfornecedor;
    private XRLabel xrLabel7;
    private XRLine xrLine1;
    public XRLabel lfcontacorrente;
    private XRLabel xrLabel10;
    public XRLabel lfperiodoprevisao;
    private XRLabel xrLabel11;
    public XRLabel lvlrprevisto;
    private XRLabel xrLabel8;
    public XRLabel lflancamentos;
    private XRLabel xrLabel2;
    private XRLabel xrLabel16;
    private XRLabel xrLabel14;
    private XRLabel xrLabel13;
    private XRLabel xrLabel9;
    public XRLabel ldatadocumento;
    public XRLabel lnf;
    public XRLabel ldatapagamento;
    private ReportFooterBand ReportFooter;
    public XRLabel ltotparcelaqtd;
    public XRLabel ltotpagamento;
    public XRLabel ltotparcela;
    public XRLabel xrLabel21;
    public XRLabel ltipo;
    private XRLabel xrLabel1;
    public XRLabel ltotpagamentos;
    public XRLabel ltotparcelaqtds;
    public XRLabel xrLabel22;
    public XRLabel ltotparcelas;
    public XRLabel ltotpagamentoe;
    public XRLabel ltotparcelaqtde;
    public XRLabel xrLabel3;
    public XRLabel ltotparcelae;
    public GroupHeaderBand headerdata;
    public GroupFooterBand footerdata;
    public XRLabel lcabecalhodata;
    public XRLabel lsubparcelaqtde;
    public XRLabel xrLabel24;
    public XRLabel lsubparcelas;
    public XRLabel lsubparcelaqtds;
    public XRLabel xrLabel28;
    public XRLabel xrLabel12;
    private XRLine xrLine2;
    public XRLabel lsubparcela;
    public XRLabel lsubparcelae;
    public XRLabel lsubparcelaqtd;
    public XRLabel lsubpagamentos;
    public XRLabel lsubpagamentoe;
    public XRLabel lsubpagamento;
	
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public RepFCaixaTotal()
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
            //string resourceFileName = "RepFCaixaTotal.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ltipo = new DevExpress.XtraReports.UI.XRLabel();
            this.ldatapagamento = new DevExpress.XtraReports.UI.XRLabel();
            this.ldatadocumento = new DevExpress.XtraReports.UI.XRLabel();
            this.lnf = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrprevisto = new DevExpress.XtraReports.UI.XRLabel();
            this.lfornecedor = new DevExpress.XtraReports.UI.XRLabel();
            this.lclassedespesa = new DevExpress.XtraReports.UI.XRLabel();
            this.ldatavencimento = new DevExpress.XtraReports.UI.XRLabel();
            this.lproduto = new DevExpress.XtraReports.UI.XRLabel();
            this.ldescricao = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrpagamento = new DevExpress.XtraReports.UI.XRLabel();
            this.lconta = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.grupofiltros = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lflancamentos = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfperiodoprevisao = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfcontacorrente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfproduto = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lcaminho = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.ltotpagamentos = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotparcelaqtds = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotparcelas = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotpagamentoe = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotparcelaqtde = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotparcelae = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotparcelaqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotpagamento = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotparcela = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.headerdata = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lcabecalhodata = new DevExpress.XtraReports.UI.XRLabel();
            this.footerdata = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.lsubpagamentos = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubpagamentoe = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubpagamento = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubparcelaqtde = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubparcelas = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubparcelaqtds = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.lsubparcela = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubparcelae = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubparcelaqtd = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ltipo,
            this.ldatapagamento,
            this.ldatadocumento,
            this.lnf,
            this.lvlrprevisto,
            this.lfornecedor,
            this.lclassedespesa,
            this.ldatavencimento,
            this.lproduto,
            this.ldescricao,
            this.lvlrpagamento,
            this.lconta,
            this.llancamento});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 13.54167F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // ltipo
            // 
            this.ltipo.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltipo.ForeColor = System.Drawing.Color.Black;
            this.ltipo.LocationFloat = new DevExpress.Utils.PointFloat(80.00016F, 1.041667F);
            this.ltipo.Name = "ltipo";
            this.ltipo.NullValueText = " ";
            this.ltipo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltipo.SizeF = new System.Drawing.SizeF(30.00005F, 10F);
            this.ltipo.StylePriority.UseBackColor = false;
            this.ltipo.StylePriority.UseFont = false;
            this.ltipo.Text = "ltipo";
            this.ltipo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltipo.WordWrap = false;
            // 
            // ldatapagamento
            // 
            this.ldatapagamento.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldatapagamento.ForeColor = System.Drawing.Color.Black;
            this.ldatapagamento.LocationFloat = new DevExpress.Utils.PointFloat(877.5002F, 1.041676F);
            this.ldatapagamento.Name = "ldatapagamento";
            this.ldatapagamento.NullValueText = " ";
            this.ldatapagamento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldatapagamento.SizeF = new System.Drawing.SizeF(69.99994F, 9.999999F);
            this.ldatapagamento.StylePriority.UseBackColor = false;
            this.ldatapagamento.StylePriority.UseFont = false;
            this.ldatapagamento.Text = "ldatapagamento";
            this.ldatapagamento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ldatapagamento.WordWrap = false;
            // 
            // ldatadocumento
            // 
            this.ldatadocumento.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldatadocumento.ForeColor = System.Drawing.Color.Black;
            this.ldatadocumento.LocationFloat = new DevExpress.Utils.PointFloat(457.5003F, 1F);
            this.ldatadocumento.Name = "ldatadocumento";
            this.ldatadocumento.NullValueText = " ";
            this.ldatadocumento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldatadocumento.SizeF = new System.Drawing.SizeF(69.99998F, 9.999999F);
            this.ldatadocumento.StylePriority.UseBackColor = false;
            this.ldatadocumento.StylePriority.UseFont = false;
            this.ldatadocumento.StylePriority.UseTextAlignment = false;
            this.ldatadocumento.Text = "ldatadocumento";
            this.ldatadocumento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ldatadocumento.WordWrap = false;
            // 
            // lnf
            // 
            this.lnf.Font = new System.Drawing.Font("Calibri", 7F);
            this.lnf.ForeColor = System.Drawing.Color.Black;
            this.lnf.LocationFloat = new DevExpress.Utils.PointFloat(407.5003F, 0.9999911F);
            this.lnf.Name = "lnf";
            this.lnf.NullValueText = " ";
            this.lnf.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lnf.SizeF = new System.Drawing.SizeF(50F, 9.999999F);
            this.lnf.StylePriority.UseBackColor = false;
            this.lnf.StylePriority.UseFont = false;
            this.lnf.StylePriority.UseTextAlignment = false;
            this.lnf.Text = "lnf";
            this.lnf.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lnf.WordWrap = false;
            // 
            // lvlrprevisto
            // 
            this.lvlrprevisto.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrprevisto.ForeColor = System.Drawing.Color.Black;
            this.lvlrprevisto.LocationFloat = new DevExpress.Utils.PointFloat(777.5001F, 1.041676F);
            this.lvlrprevisto.Name = "lvlrprevisto";
            this.lvlrprevisto.NullValueText = " ";
            this.lvlrprevisto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrprevisto.SizeF = new System.Drawing.SizeF(100F, 9.999999F);
            this.lvlrprevisto.StylePriority.UseBackColor = false;
            this.lvlrprevisto.StylePriority.UseFont = false;
            this.lvlrprevisto.StylePriority.UseTextAlignment = false;
            this.lvlrprevisto.Text = "lvlrprevisto";
            this.lvlrprevisto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlrprevisto.WordWrap = false;
            // 
            // lfornecedor
            // 
            this.lfornecedor.Font = new System.Drawing.Font("Calibri", 7F);
            this.lfornecedor.ForeColor = System.Drawing.Color.Black;
            this.lfornecedor.LocationFloat = new DevExpress.Utils.PointFloat(150.0002F, 1.041667F);
            this.lfornecedor.Name = "lfornecedor";
            this.lfornecedor.NullValueText = " ";
            this.lfornecedor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfornecedor.SizeF = new System.Drawing.SizeF(137.5001F, 10F);
            this.lfornecedor.StylePriority.UseBackColor = false;
            this.lfornecedor.StylePriority.UseFont = false;
            this.lfornecedor.StylePriority.UseTextAlignment = false;
            this.lfornecedor.Text = "lfornecedor";
            this.lfornecedor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lfornecedor.WordWrap = false;
            // 
            // lclassedespesa
            // 
            this.lclassedespesa.Font = new System.Drawing.Font("Calibri", 7F);
            this.lclassedespesa.ForeColor = System.Drawing.Color.Black;
            this.lclassedespesa.LocationFloat = new DevExpress.Utils.PointFloat(287.5002F, 0.9999911F);
            this.lclassedespesa.Name = "lclassedespesa";
            this.lclassedespesa.NullValueText = " ";
            this.lclassedespesa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lclassedespesa.SizeF = new System.Drawing.SizeF(120F, 9.999999F);
            this.lclassedespesa.StylePriority.UseBackColor = false;
            this.lclassedespesa.StylePriority.UseFont = false;
            this.lclassedespesa.StylePriority.UseTextAlignment = false;
            this.lclassedespesa.Text = "lclassedespesa";
            this.lclassedespesa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lclassedespesa.WordWrap = false;
            // 
            // ldatavencimento
            // 
            this.ldatavencimento.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldatavencimento.ForeColor = System.Drawing.Color.Black;
            this.ldatavencimento.LocationFloat = new DevExpress.Utils.PointFloat(707.5002F, 1F);
            this.ldatavencimento.Name = "ldatavencimento";
            this.ldatavencimento.NullValueText = " ";
            this.ldatavencimento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldatavencimento.SizeF = new System.Drawing.SizeF(69.99994F, 9.999999F);
            this.ldatavencimento.StylePriority.UseBackColor = false;
            this.ldatavencimento.StylePriority.UseFont = false;
            this.ldatavencimento.Text = "ldatavencimento";
            this.ldatavencimento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ldatavencimento.WordWrap = false;
            // 
            // lproduto
            // 
            this.lproduto.Font = new System.Drawing.Font("Calibri", 7F);
            this.lproduto.ForeColor = System.Drawing.Color.Black;
            this.lproduto.LocationFloat = new DevExpress.Utils.PointFloat(50.00016F, 1.041667F);
            this.lproduto.Name = "lproduto";
            this.lproduto.NullValueText = " ";
            this.lproduto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lproduto.SizeF = new System.Drawing.SizeF(30F, 10F);
            this.lproduto.StylePriority.UseBackColor = false;
            this.lproduto.StylePriority.UseFont = false;
            this.lproduto.Text = "lproduto";
            this.lproduto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lproduto.WordWrap = false;
            // 
            // ldescricao
            // 
            this.ldescricao.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldescricao.ForeColor = System.Drawing.Color.Black;
            this.ldescricao.LocationFloat = new DevExpress.Utils.PointFloat(527.5003F, 0.9999911F);
            this.ldescricao.Name = "ldescricao";
            this.ldescricao.NullValueText = " ";
            this.ldescricao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldescricao.SizeF = new System.Drawing.SizeF(180F, 9.999999F);
            this.ldescricao.StylePriority.UseBackColor = false;
            this.ldescricao.StylePriority.UseFont = false;
            this.ldescricao.StylePriority.UseTextAlignment = false;
            this.ldescricao.Text = "ldescricao";
            this.ldescricao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.ldescricao.WordWrap = false;
            // 
            // lvlrpagamento
            // 
            this.lvlrpagamento.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrpagamento.ForeColor = System.Drawing.Color.Black;
            this.lvlrpagamento.LocationFloat = new DevExpress.Utils.PointFloat(947.5002F, 1F);
            this.lvlrpagamento.Name = "lvlrpagamento";
            this.lvlrpagamento.NullValueText = " ";
            this.lvlrpagamento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrpagamento.SizeF = new System.Drawing.SizeF(100.0001F, 9.999999F);
            this.lvlrpagamento.StylePriority.UseBackColor = false;
            this.lvlrpagamento.StylePriority.UseFont = false;
            this.lvlrpagamento.Text = "lvlrpagamento";
            this.lvlrpagamento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlrpagamento.WordWrap = false;
            // 
            // lconta
            // 
            this.lconta.Font = new System.Drawing.Font("Calibri", 7F);
            this.lconta.ForeColor = System.Drawing.Color.Black;
            this.lconta.LocationFloat = new DevExpress.Utils.PointFloat(110.0002F, 0.9999911F);
            this.lconta.Name = "lconta";
            this.lconta.NullValueText = " ";
            this.lconta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lconta.SizeF = new System.Drawing.SizeF(40F, 10F);
            this.lconta.StylePriority.UseBackColor = false;
            this.lconta.StylePriority.UseFont = false;
            this.lconta.Text = "lconta";
            this.lconta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lconta.WordWrap = false;
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
            this.ltitulorelatorio.Text = "RELATÓRIO FLUXO DE CAIXA - TOTAIS";
            this.ltitulorelatorio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // grupocabecalho
            // 
            this.grupocabecalho.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel16,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel15,
            this.xrLabel18,
            this.xrLabel26,
            this.xrLabel19});
            this.grupocabecalho.HeightF = 15.08331F;
            this.grupocabecalho.Level = 1;
            this.grupocabecalho.Name = "grupocabecalho";
            this.grupocabecalho.RepeatEveryPage = true;
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
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(80.00016F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(30F, 13F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "R/D";
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
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(527.5002F, 0F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(180F, 13F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseBorderColor = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Descrição";
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
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(877.5002F, 0F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(70F, 13F);
            this.xrLabel14.StylePriority.UseBackColor = false;
            this.xrLabel14.StylePriority.UseBorderColor = false;
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Pagamento";
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
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(457.5003F, 0F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(70F, 13F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseBorderColor = false;
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Data NF";
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
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(407.5003F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(50F, 13F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseBorderColor = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "NF";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(947.5002F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(100F, 13F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Vlr. Pago";
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
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(150.0002F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(137.5001F, 13F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Clientes\\Fornec.";
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
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(707.5002F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(70F, 13F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Vencimento";
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
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(287.5002F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(120F, 13F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Receitas\\Despesas";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(777.5002F, 0F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(100F, 13F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseBorderColor = false;
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "Vlr.Previsto";
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
            // xrLabel26
            // 
            this.xrLabel26.BackColor = System.Drawing.Color.Silver;
            this.xrLabel26.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel26.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel26.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(110.0002F, 0F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(40F, 13F);
            this.xrLabel26.StylePriority.UseBackColor = false;
            this.xrLabel26.StylePriority.UseBorderColor = false;
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseForeColor = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.Text = "Conta";
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
            this.xrLabel19.SizeF = new System.Drawing.SizeF(30F, 13F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseBorderColor = false;
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseForeColor = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Prod";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // grupofiltros
            // 
            this.grupofiltros.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lflancamentos,
            this.xrLabel2,
            this.lfperiodoprevisao,
            this.xrLabel11,
            this.lfcontacorrente,
            this.xrLabel10,
            this.lfproduto,
            this.xrLabel4});
            this.grupofiltros.HeightF = 43.75F;
            this.grupofiltros.Level = 2;
            this.grupofiltros.Name = "grupofiltros";
            // 
            // lflancamentos
            // 
            this.lflancamentos.LocationFloat = new DevExpress.Utils.PointFloat(658.7499F, 21.99999F);
            this.lflancamentos.Name = "lflancamentos";
            this.lflancamentos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lflancamentos.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lflancamentos.StylePriority.UseTextAlignment = false;
            this.lflancamentos.Text = "lflancamentos";
            this.lflancamentos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(568.0419F, 21.99999F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(88.47809F, 20F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Lançamentos:";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfperiodoprevisao
            // 
            this.lfperiodoprevisao.LocationFloat = new DevExpress.Utils.PointFloat(658.7499F, 0.9999911F);
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
            this.xrLabel11.SizeF = new System.Drawing.SizeF(88.47815F, 20F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Período:";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfcontacorrente
            // 
            this.lfcontacorrente.LocationFloat = new DevExpress.Utils.PointFloat(81.23016F, 22F);
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
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(3.999964F, 22F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(74.6319F, 20F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Conta:";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            this.lcaminho.Text = "Gitano ->SGFin ->Fluxo de Caixa ->Relatório Fluxo de Caixa - Totais";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ltotpagamentos,
            this.ltotparcelaqtds,
            this.xrLabel22,
            this.ltotparcelas,
            this.ltotpagamentoe,
            this.ltotparcelaqtde,
            this.xrLabel3,
            this.ltotparcelae,
            this.ltotparcelaqtd,
            this.ltotpagamento,
            this.ltotparcela,
            this.xrLabel21,
            this.xrLine1});
            this.ReportFooter.HeightF = 57.29167F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ReportFooter_BeforePrint);
            // 
            // ltotpagamentos
            // 
            this.ltotpagamentos.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotpagamentos.LocationFloat = new DevExpress.Utils.PointFloat(947.2501F, 24.27086F);
            this.ltotpagamentos.Name = "ltotpagamentos";
            this.ltotpagamentos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotpagamentos.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotpagamentos.StylePriority.UseFont = false;
            this.ltotpagamentos.StylePriority.UseTextAlignment = false;
            this.ltotpagamentos.Text = "ltotpagamentos";
            this.ltotpagamentos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotparcelaqtds
            // 
            this.ltotparcelaqtds.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotparcelaqtds.LocationFloat = new DevExpress.Utils.PointFloat(248.7501F, 24.64581F);
            this.ltotparcelaqtds.Name = "ltotparcelaqtds";
            this.ltotparcelaqtds.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotparcelaqtds.SizeF = new System.Drawing.SizeF(108.0415F, 14F);
            this.ltotparcelaqtds.StylePriority.UseFont = false;
            this.ltotparcelaqtds.StylePriority.UseTextAlignment = false;
            this.ltotparcelaqtds.Text = "ltotparcelaqtds";
            this.ltotparcelaqtds.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel22
            // 
            this.xrLabel22.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(1.749878F, 26.27086F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(198.0002F, 14F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "Totais Saídas (-) :";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotparcelas
            // 
            this.ltotparcelas.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotparcelas.LocationFloat = new DevExpress.Utils.PointFloat(775.2499F, 26.27086F);
            this.ltotparcelas.Name = "ltotparcelas";
            this.ltotparcelas.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotparcelas.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotparcelas.StylePriority.UseFont = false;
            this.ltotparcelas.StylePriority.UseTextAlignment = false;
            this.ltotparcelas.Text = "ltotparcelas";
            this.ltotparcelas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotpagamentoe
            // 
            this.ltotpagamentoe.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotpagamentoe.LocationFloat = new DevExpress.Utils.PointFloat(947.5003F, 8.374946F);
            this.ltotpagamentoe.Name = "ltotpagamentoe";
            this.ltotpagamentoe.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotpagamentoe.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotpagamentoe.StylePriority.UseFont = false;
            this.ltotpagamentoe.StylePriority.UseTextAlignment = false;
            this.ltotpagamentoe.Text = "ltotpagamentoe";
            this.ltotpagamentoe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotparcelaqtde
            // 
            this.ltotparcelaqtde.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotparcelaqtde.LocationFloat = new DevExpress.Utils.PointFloat(248.0002F, 8.374946F);
            this.ltotparcelaqtde.Name = "ltotparcelaqtde";
            this.ltotparcelaqtde.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotparcelaqtde.SizeF = new System.Drawing.SizeF(108.0415F, 14F);
            this.ltotparcelaqtde.StylePriority.UseFont = false;
            this.ltotparcelaqtde.StylePriority.UseTextAlignment = false;
            this.ltotparcelaqtde.Text = "ltotparcelaqtde";
            this.ltotparcelaqtde.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(2F, 10.00001F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(198.0002F, 14F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Totais Entradas (+) :";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotparcelae
            // 
            this.ltotparcelae.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotparcelae.LocationFloat = new DevExpress.Utils.PointFloat(775.5F, 10.00001F);
            this.ltotparcelae.Name = "ltotparcelae";
            this.ltotparcelae.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotparcelae.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotparcelae.StylePriority.UseFont = false;
            this.ltotparcelae.StylePriority.UseTextAlignment = false;
            this.ltotparcelae.Text = "ltotparcelae";
            this.ltotparcelae.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotparcelaqtd
            // 
            this.ltotparcelaqtd.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotparcelaqtd.LocationFloat = new DevExpress.Utils.PointFloat(248.0002F, 41.29161F);
            this.ltotparcelaqtd.Name = "ltotparcelaqtd";
            this.ltotparcelaqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotparcelaqtd.SizeF = new System.Drawing.SizeF(108.0415F, 14F);
            this.ltotparcelaqtd.StylePriority.UseFont = false;
            this.ltotparcelaqtd.StylePriority.UseTextAlignment = false;
            this.ltotparcelaqtd.Text = "ltotparcelaqtd";
            this.ltotparcelaqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotpagamento
            // 
            this.ltotpagamento.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotpagamento.LocationFloat = new DevExpress.Utils.PointFloat(947.5002F, 39.91666F);
            this.ltotpagamento.Name = "ltotpagamento";
            this.ltotpagamento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotpagamento.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotpagamento.StylePriority.UseFont = false;
            this.ltotpagamento.StylePriority.UseTextAlignment = false;
            this.ltotpagamento.Text = "ltotpagamento";
            this.ltotpagamento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotparcela
            // 
            this.ltotparcela.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotparcela.LocationFloat = new DevExpress.Utils.PointFloat(775.5001F, 41.91666F);
            this.ltotparcela.Name = "ltotparcela";
            this.ltotparcela.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotparcela.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotparcela.StylePriority.UseFont = false;
            this.ltotparcela.StylePriority.UseTextAlignment = false;
            this.ltotparcela.Text = "ltotparcela";
            this.ltotparcela.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel21
            // 
            this.xrLabel21.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(1.999998F, 41.91666F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(198.0002F, 14F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Total Geral (=) :";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // headerdata
            // 
            this.headerdata.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lcabecalhodata});
            this.headerdata.HeightF = 17.70833F;
            this.headerdata.Name = "headerdata";
            this.headerdata.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.headerdata_BeforePrint);
            // 
            // lcabecalhodata
            // 
            this.lcabecalhodata.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcabecalhodata.LocationFloat = new DevExpress.Utils.PointFloat(2.00015F, 2F);
            this.lcabecalhodata.Name = "lcabecalhodata";
            this.lcabecalhodata.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcabecalhodata.SizeF = new System.Drawing.SizeF(80F, 14F);
            this.lcabecalhodata.StylePriority.UseFont = false;
            this.lcabecalhodata.StylePriority.UseTextAlignment = false;
            this.lcabecalhodata.Text = "lcabecalhodata";
            this.lcabecalhodata.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // footerdata
            // 
            this.footerdata.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lsubpagamentos,
            this.lsubpagamentoe,
            this.lsubpagamento,
            this.lsubparcelaqtde,
            this.xrLabel24,
            this.lsubparcelas,
            this.lsubparcelaqtds,
            this.xrLabel28,
            this.xrLabel12,
            this.xrLine2,
            this.lsubparcela,
            this.lsubparcelae,
            this.lsubparcelaqtd});
            this.footerdata.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.footerdata.HeightF = 58.33333F;
            this.footerdata.Name = "footerdata";
            this.footerdata.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.footerdata_BeforePrint);
            // 
            // lsubpagamentos
            // 
            this.lsubpagamentos.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubpagamentos.LocationFloat = new DevExpress.Utils.PointFloat(946.9998F, 25.89591F);
            this.lsubpagamentos.Name = "lsubpagamentos";
            this.lsubpagamentos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubpagamentos.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.lsubpagamentos.StylePriority.UseFont = false;
            this.lsubpagamentos.StylePriority.UseTextAlignment = false;
            this.lsubpagamentos.Text = "lsubpagamentos";
            this.lsubpagamentos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubpagamentoe
            // 
            this.lsubpagamentoe.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubpagamentoe.LocationFloat = new DevExpress.Utils.PointFloat(947.2501F, 10.00001F);
            this.lsubpagamentoe.Name = "lsubpagamentoe";
            this.lsubpagamentoe.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubpagamentoe.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.lsubpagamentoe.StylePriority.UseFont = false;
            this.lsubpagamentoe.StylePriority.UseTextAlignment = false;
            this.lsubpagamentoe.Text = "lsubpagamentoe";
            this.lsubpagamentoe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubpagamento
            // 
            this.lsubpagamento.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubpagamento.LocationFloat = new DevExpress.Utils.PointFloat(947.2499F, 41.5417F);
            this.lsubpagamento.Name = "lsubpagamento";
            this.lsubpagamento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubpagamento.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.lsubpagamento.StylePriority.UseFont = false;
            this.lsubpagamento.StylePriority.UseTextAlignment = false;
            this.lsubpagamento.Text = "lsubpagamento";
            this.lsubpagamento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubparcelaqtde
            // 
            this.lsubparcelaqtde.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubparcelaqtde.LocationFloat = new DevExpress.Utils.PointFloat(249.0002F, 8.374946F);
            this.lsubparcelaqtde.Name = "lsubparcelaqtde";
            this.lsubparcelaqtde.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubparcelaqtde.SizeF = new System.Drawing.SizeF(108.0415F, 14F);
            this.lsubparcelaqtde.StylePriority.UseFont = false;
            this.lsubparcelaqtde.StylePriority.UseTextAlignment = false;
            this.lsubparcelaqtde.Text = "lsubparcelaqtde";
            this.lsubparcelaqtde.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel24
            // 
            this.xrLabel24.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(3.000046F, 10.00001F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(198.0002F, 14F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "SubTotais Entradas (+) :";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubparcelas
            // 
            this.lsubparcelas.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubparcelas.LocationFloat = new DevExpress.Utils.PointFloat(776.25F, 26.27087F);
            this.lsubparcelas.Name = "lsubparcelas";
            this.lsubparcelas.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubparcelas.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.lsubparcelas.StylePriority.UseFont = false;
            this.lsubparcelas.StylePriority.UseTextAlignment = false;
            this.lsubparcelas.Text = "lsubparcelas";
            this.lsubparcelas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubparcelaqtds
            // 
            this.lsubparcelaqtds.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubparcelaqtds.LocationFloat = new DevExpress.Utils.PointFloat(249.7501F, 24.64581F);
            this.lsubparcelaqtds.Name = "lsubparcelaqtds";
            this.lsubparcelaqtds.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubparcelaqtds.SizeF = new System.Drawing.SizeF(108.0415F, 14F);
            this.lsubparcelaqtds.StylePriority.UseFont = false;
            this.lsubparcelaqtds.StylePriority.UseTextAlignment = false;
            this.lsubparcelaqtds.Text = "lsubparcelaqtds";
            this.lsubparcelaqtds.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel28
            // 
            this.xrLabel28.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(2.749921F, 26.27087F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(198.0002F, 14F);
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "SubTotais Saídas (-) :";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(3.000046F, 41.91666F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(198.0002F, 14F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "SubTotais (=) :";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(1.000159F, 0F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
            // 
            // lsubparcela
            // 
            this.lsubparcela.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubparcela.LocationFloat = new DevExpress.Utils.PointFloat(776.5001F, 41.91666F);
            this.lsubparcela.Name = "lsubparcela";
            this.lsubparcela.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubparcela.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.lsubparcela.StylePriority.UseFont = false;
            this.lsubparcela.StylePriority.UseTextAlignment = false;
            this.lsubparcela.Text = "lsubparcela";
            this.lsubparcela.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubparcelae
            // 
            this.lsubparcelae.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubparcelae.LocationFloat = new DevExpress.Utils.PointFloat(776.5001F, 10.00001F);
            this.lsubparcelae.Name = "lsubparcelae";
            this.lsubparcelae.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubparcelae.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.lsubparcelae.StylePriority.UseFont = false;
            this.lsubparcelae.StylePriority.UseTextAlignment = false;
            this.lsubparcelae.Text = "lsubparcelae";
            this.lsubparcelae.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubparcelaqtd
            // 
            this.lsubparcelaqtd.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubparcelaqtd.LocationFloat = new DevExpress.Utils.PointFloat(249.0002F, 41.29162F);
            this.lsubparcelaqtd.Name = "lsubparcelaqtd";
            this.lsubparcelaqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubparcelaqtd.SizeF = new System.Drawing.SizeF(108.0415F, 14F);
            this.lsubparcelaqtd.StylePriority.UseFont = false;
            this.lsubparcelaqtd.StylePriority.UseTextAlignment = false;
            this.lsubparcelaqtd.Text = "lsubparcelaqtd";
            this.lsubparcelaqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RepFCaixaTotal
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.grupocabecalho,
            this.grupofiltros,
            this.PageFooter,
            this.ReportFooter,
            this.headerdata,
            this.footerdata});
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
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepFCaixaTotal_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

    double subprevisto = 0.00;
    double subrealizado = 0.00;
    Int64 subqtd = 0;
    //
    double subprevistoe = 0.00;
    double subrealizadoe = 0.00;
    Int64 subqtde = 0;
    //
    double subprevistos = 0.00;
    double subrealizados = 0.00;
    Int64 subqtds = 0;
    //
    double totprevisto = 0.00;
    double totrealizado = 0.00;
    Int64 totqtd = 0;
    //
    double totprevistoe = 0.00;
    double totrealizadoe = 0.00;
    Int64 totqtde = 0;
    //
    double totprevistos = 0.00;
    double totrealizados = 0.00;
    Int64 totqtds = 0;
    //
    public Boolean eimprimedata = false;
    public Boolean eimprimedetail = false;
    public string rblancamentossituacao = "";


	private void RepFCaixaTotal_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
        double previso = Convert.ToDouble(GetCurrentColumnValue("vlr_previsto"));
        double realizado = Convert.ToDouble(GetCurrentColumnValue("vlr_realizado"));
        Int64 parcelaqtd = 1;
        //
        string fornecedor = "";
        if (Convert.ToString(GetCurrentColumnValue("ID")) == "1")
        {
            fornecedor = Convert.ToString(GetCurrentColumnValue("cliente"));
            lfornecedor.Text = fornecedor + " - " + uCliente.PegaNomeCliente(Convert.ToInt32(fornecedor));
            //
            string despesa = Convert.ToString(GetCurrentColumnValue("classe"));
            lclassedespesa.Text = despesa + " - " + uReceitas.PegaReceitaDescricao(Convert.ToInt32(despesa));
            //
            subprevistoe = subprevistoe + previso;
            subrealizadoe = subrealizadoe + realizado;
            subqtde = subqtde + parcelaqtd;
            //
            totprevistoe = totprevistoe + previso;
            totrealizadoe = totrealizadoe + realizado;
            totqtde = totqtde + parcelaqtd;
        }
        else
        {
            fornecedor = Convert.ToString(GetCurrentColumnValue("cliente"));
            lfornecedor.Text = fornecedor + " - " + uFornecedores.PegaNomeFornecedor(Convert.ToInt32(fornecedor));
            //
            string despesa = Convert.ToString(GetCurrentColumnValue("classe"));
            lclassedespesa.Text = despesa + " - " + uDespesas.PegaDespesaDescricao(Convert.ToInt32(despesa));
            //
            subprevistos = subprevistos + previso;
            subrealizados = subrealizados + realizado;
            subqtds = subqtds + parcelaqtd;
            //
            totprevistos = totprevistos + previso;
            totrealizados = totrealizados + realizado;
            totqtds = totqtds + parcelaqtd;
        }
        //
        subprevisto = subprevisto + previso;
        subrealizado = subrealizado + realizado;
        subqtd = subqtd + parcelaqtd;
        //
        totprevisto = totprevisto + previso;
        totrealizado = totrealizado + realizado;
        totqtd = totqtd + parcelaqtd;
        //
        previso = 0.00;
        realizado = 0.00;
        parcelaqtd = 0;
        //
        //
        e.Cancel = !eimprimedetail;
    }

    private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //Entradas
        ltotparcelaqtde.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(totqtde));
        ltotparcelae.Text = String.Format("{0:N}", Convert.ToDouble(totprevistoe));
        ltotpagamentoe.Text = String.Format("{0:N}", Convert.ToDouble(totrealizadoe));
        //Saidas
        ltotparcelaqtds.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(totqtds));
        ltotparcelas.Text = String.Format("{0:N}", Convert.ToDouble(totprevistos));
        ltotpagamentos.Text = String.Format("{0:N}", Convert.ToDouble(totprevistos));
        //Totais
        ltotparcelaqtd.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(totqtd));
        //
        totprevisto = totprevistoe - totprevistos;
        totrealizado = totrealizadoe - totrealizados;
        //
        ltotparcela.Text = String.Format("{0:N}", Convert.ToDouble(totprevisto));        
        ltotpagamento.Text = String.Format("{0:N}", Convert.ToDouble(totrealizado));

    }

    private void footerdata_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //Entradas
        lsubparcelaqtde.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(subqtde));
        lsubparcelae.Text = String.Format("{0:N}", Convert.ToDouble(subprevistoe));
        lsubpagamentoe.Text = String.Format("{0:N}", Convert.ToDouble(subrealizadoe));
        //Saidas
        lsubparcelaqtds.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(subqtds));
        lsubparcelas.Text = String.Format("{0:N}", Convert.ToDouble(subprevistos));
        lsubpagamentos.Text = String.Format("{0:N}", Convert.ToDouble(subprevistos));
        //subais
        lsubparcelaqtd.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(subqtd));
        //
        subprevisto = subprevistoe - subprevistos;
        subrealizado = subrealizadoe - subrealizados;
        //
        lsubparcela.Text = String.Format("{0:N}", Convert.ToDouble(subprevisto));
        lsubpagamento.Text = String.Format("{0:N}", Convert.ToDouble(subrealizado));
        //
        subprevisto = 0.00;
        subrealizado = 0.00;
        subqtd = 0;
        //
        subprevistoe = 0.00;
        subrealizadoe = 0.00;
        subqtde = 0;
        //
        subprevistos = 0.00;
        subrealizados = 0.00;
        subqtds = 0;
        //
    }

    private void headerdata_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        e.Cancel = !eimprimedata;
        //
        if (eimprimedata)
        {
            if (rblancamentossituacao == "P")
            {
                lcabecalhodata.Text = GetCurrentColumnValue("data_prevista").ToString();
                lcabecalhodata.Text = Convert.ToDateTime(GetCurrentColumnValue("data_prevista")).ToShortDateString();
            }
            else
            {
                lcabecalhodata.Text = GetCurrentColumnValue("data_realizado").ToString();
                lcabecalhodata.Text = Convert.ToDateTime(GetCurrentColumnValue("data_realizado")).ToShortDateString();
            }
            //
        }
    }

}
