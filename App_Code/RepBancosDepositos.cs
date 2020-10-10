using DevExpress.XtraReports.UI;
using System;

/// <summary>
/// Summary description for RepBancosDepositos
/// </summary>
public class RepBancosDepositos : DevExpress.XtraReports.UI.XtraReport
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
	public XRLabel lcheque;
	public XRLabel lvlrpagamento;
	public XRLabel lconta;
	private XRLabel xrLabel3;
	private XRLabel xrLabel15;
    public XRLabel ldatavencimento;
    public XRLabel lproduto;
    private FormattingRule formattingRule1;
    private XRLabel xrLabel5;
	private PageFooterBand PageFooter;
	public XRLabel lcaminho;
    public XRLabel lfclassereceita;
    private XRLabel xrLabel1;
    public XRLabel lclassereceita;
    private XRLabel xrLabel6;
    public XRLabel lcliente;
    private XRLabel xrLabel7;
    private XRLine xrLine1;
    public XRLabel lfcontacorrente;
    private XRLabel xrLabel10;
    public XRLabel lfperiodoprevisao;
    private XRLabel xrLabel11;
    public XRLabel lvlrprevisto;
    private XRLabel xrLabel8;
    public XRLabel lfcliente;
    private XRLabel xrLabel12;
    private XRLabel xrLabel20;
    private XRLabel xrLabel16;
    private XRLabel xrLabel14;
    private XRLabel xrLabel13;
    private XRLabel xrLabel9;
    public XRLabel ldatadocumento;
    public XRLabel lnf;
    public XRLabel ldatapagamento;
    public XRLabel lcompensado;
    public XRLabel lcmc7;
    private ReportFooterBand ReportFooter;
    public XRLabel ltotparcelaqtd;
    public XRLabel ltotpagamento;
    public XRLabel ltotparcela;
    public XRLabel xrLabel21;
    public XRLabel lfperiodonotafiscal;
    private XRLabel xrLabel24;
    public XRLabel lfperiodorealizado;
    private XRLabel xrLabel17;
    public XRLabel lfordenacao;
    private XRLabel xrLabel25;
    public XRLabel lfcompensacao;
    private XRLabel xrLabel2;
	
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public RepBancosDepositos()
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
            //string resourceFileName = "RepBancosDepositos.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lcmc7 = new DevExpress.XtraReports.UI.XRLabel();
            this.lcompensado = new DevExpress.XtraReports.UI.XRLabel();
            this.ldatapagamento = new DevExpress.XtraReports.UI.XRLabel();
            this.ldatadocumento = new DevExpress.XtraReports.UI.XRLabel();
            this.lnf = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrprevisto = new DevExpress.XtraReports.UI.XRLabel();
            this.lcliente = new DevExpress.XtraReports.UI.XRLabel();
            this.lclassereceita = new DevExpress.XtraReports.UI.XRLabel();
            this.ldatavencimento = new DevExpress.XtraReports.UI.XRLabel();
            this.lproduto = new DevExpress.XtraReports.UI.XRLabel();
            this.lcheque = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.grupofiltros = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lfordenacao = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfperiodonotafiscal = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfperiodorealizado = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfcompensacao = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfcliente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfperiodoprevisao = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfcontacorrente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfclassereceita = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfproduto = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lcaminho = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.ltotparcelaqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotpagamento = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotparcela = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lcmc7,
            this.lcompensado,
            this.ldatapagamento,
            this.ldatadocumento,
            this.lnf,
            this.lvlrprevisto,
            this.lcliente,
            this.lclassereceita,
            this.ldatavencimento,
            this.lproduto,
            this.lcheque,
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
            // lcmc7
            // 
            this.lcmc7.Font = new System.Drawing.Font("Calibri", 7F);
            this.lcmc7.ForeColor = System.Drawing.Color.Black;
            this.lcmc7.LocationFloat = new DevExpress.Utils.PointFloat(978.0417F, 1F);
            this.lcmc7.Name = "lcmc7";
            this.lcmc7.NullValueText = " ";
            this.lcmc7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcmc7.SizeF = new System.Drawing.SizeF(70.00012F, 9.999999F);
            this.lcmc7.StylePriority.UseBackColor = false;
            this.lcmc7.StylePriority.UseFont = false;
            this.lcmc7.StylePriority.UseTextAlignment = false;
            this.lcmc7.Text = "lcmc7";
            this.lcmc7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lcmc7.WordWrap = false;
            // 
            // lcompensado
            // 
            this.lcompensado.Font = new System.Drawing.Font("Calibri", 7F);
            this.lcompensado.ForeColor = System.Drawing.Color.Black;
            this.lcompensado.LocationFloat = new DevExpress.Utils.PointFloat(908.0417F, 1.041676F);
            this.lcompensado.Name = "lcompensado";
            this.lcompensado.NullValueText = " ";
            this.lcompensado.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcompensado.SizeF = new System.Drawing.SizeF(70F, 9.999999F);
            this.lcompensado.StylePriority.UseBackColor = false;
            this.lcompensado.StylePriority.UseFont = false;
            this.lcompensado.StylePriority.UseTextAlignment = false;
            this.lcompensado.Text = "lcompensado";
            this.lcompensado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lcompensado.WordWrap = false;
            // 
            // ldatapagamento
            // 
            this.ldatapagamento.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldatapagamento.ForeColor = System.Drawing.Color.Black;
            this.ldatapagamento.LocationFloat = new DevExpress.Utils.PointFloat(668.0417F, 1.041676F);
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
            this.ldatadocumento.LocationFloat = new DevExpress.Utils.PointFloat(428.0418F, 1.041676F);
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
            this.lnf.LocationFloat = new DevExpress.Utils.PointFloat(358.0417F, 1.041676F);
            this.lnf.Name = "lnf";
            this.lnf.NullValueText = " ";
            this.lnf.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lnf.SizeF = new System.Drawing.SizeF(69.99998F, 9.999999F);
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
            this.lvlrprevisto.LocationFloat = new DevExpress.Utils.PointFloat(568.0417F, 1.041676F);
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
            // lcliente
            // 
            this.lcliente.Font = new System.Drawing.Font("Calibri", 7F);
            this.lcliente.ForeColor = System.Drawing.Color.Black;
            this.lcliente.LocationFloat = new DevExpress.Utils.PointFloat(150.0002F, 1.041667F);
            this.lcliente.Name = "lcliente";
            this.lcliente.NullValueText = " ";
            this.lcliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcliente.SizeF = new System.Drawing.SizeF(100F, 10F);
            this.lcliente.StylePriority.UseBackColor = false;
            this.lcliente.StylePriority.UseFont = false;
            this.lcliente.StylePriority.UseTextAlignment = false;
            this.lcliente.Text = "lcliente";
            this.lcliente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lcliente.WordWrap = false;
            // 
            // lclassereceita
            // 
            this.lclassereceita.Font = new System.Drawing.Font("Calibri", 7F);
            this.lclassereceita.ForeColor = System.Drawing.Color.Black;
            this.lclassereceita.LocationFloat = new DevExpress.Utils.PointFloat(250.0004F, 1.041667F);
            this.lclassereceita.Name = "lclassereceita";
            this.lclassereceita.NullValueText = " ";
            this.lclassereceita.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lclassereceita.SizeF = new System.Drawing.SizeF(108.0415F, 9.999999F);
            this.lclassereceita.StylePriority.UseBackColor = false;
            this.lclassereceita.StylePriority.UseFont = false;
            this.lclassereceita.StylePriority.UseTextAlignment = false;
            this.lclassereceita.Text = "lclassereceita";
            this.lclassereceita.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lclassereceita.WordWrap = false;
            // 
            // ldatavencimento
            // 
            this.ldatavencimento.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldatavencimento.ForeColor = System.Drawing.Color.Black;
            this.ldatavencimento.LocationFloat = new DevExpress.Utils.PointFloat(498.0418F, 1F);
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
            this.lcheque.LocationFloat = new DevExpress.Utils.PointFloat(838.0417F, 1.041676F);
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
            // lvlrpagamento
            // 
            this.lvlrpagamento.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrpagamento.ForeColor = System.Drawing.Color.Black;
            this.lvlrpagamento.LocationFloat = new DevExpress.Utils.PointFloat(738.0417F, 1F);
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
            this.lconta.LocationFloat = new DevExpress.Utils.PointFloat(100.0002F, 1.041667F);
            this.lconta.Name = "lconta";
            this.lconta.NullValueText = " ";
            this.lconta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lconta.SizeF = new System.Drawing.SizeF(50F, 10F);
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
            this.ltitulorelatorio.Text = "RELATÓRIO BANCOS - DEPÓSITOS";
            this.ltitulorelatorio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // grupocabecalho
            // 
            this.grupocabecalho.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel20,
            this.xrLabel16,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel15,
            this.xrLabel3,
            this.xrLabel18,
            this.xrLabel26,
            this.xrLabel19});
            this.grupocabecalho.HeightF = 14.04165F;
            this.grupocabecalho.Name = "grupocabecalho";
            this.grupocabecalho.RepeatEveryPage = true;
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
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(908.0418F, 0F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(70F, 13F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseBorderColor = false;
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseForeColor = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Compensado";
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
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(838.0419F, 0F);
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
            // xrLabel14
            // 
            this.xrLabel14.BackColor = System.Drawing.Color.Silver;
            this.xrLabel14.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel14.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel14.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(668.0419F, 0F);
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
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(428.0419F, 0F);
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
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(358.0419F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(70F, 13F);
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
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(738.0419F, 0F);
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
            this.xrLabel7.SizeF = new System.Drawing.SizeF(100F, 13F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Cliente";
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
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(498.0419F, 0F);
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
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(250.0002F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(108.0417F, 13F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Receita";
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
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(568.0419F, 0F);
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
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.Silver;
            this.xrLabel3.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(978.0419F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(70F, 13F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "CMC7";
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
            this.lfordenacao,
            this.xrLabel25,
            this.lfperiodonotafiscal,
            this.xrLabel24,
            this.lfperiodorealizado,
            this.xrLabel17,
            this.lfcompensacao,
            this.xrLabel2,
            this.lfcliente,
            this.xrLabel12,
            this.lfperiodoprevisao,
            this.xrLabel11,
            this.lfcontacorrente,
            this.xrLabel10,
            this.lfclassereceita,
            this.xrLabel1,
            this.lfproduto,
            this.xrLabel4});
            this.grupofiltros.HeightF = 106.25F;
            this.grupofiltros.Level = 1;
            this.grupofiltros.Name = "grupofiltros";
            // 
            // lfordenacao
            // 
            this.lfordenacao.LocationFloat = new DevExpress.Utils.PointFloat(658.7498F, 84.99998F);
            this.lfordenacao.Name = "lfordenacao";
            this.lfordenacao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfordenacao.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lfordenacao.StylePriority.UseTextAlignment = false;
            this.lfordenacao.Text = "lfordenacao";
            this.lfordenacao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel25
            // 
            this.xrLabel25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(568.0417F, 84.99998F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(88.47809F, 20F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "Ordenação:";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfperiodonotafiscal
            // 
            this.lfperiodonotafiscal.LocationFloat = new DevExpress.Utils.PointFloat(658.7499F, 42.99998F);
            this.lfperiodonotafiscal.Name = "lfperiodonotafiscal";
            this.lfperiodonotafiscal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfperiodonotafiscal.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lfperiodonotafiscal.StylePriority.UseTextAlignment = false;
            this.lfperiodonotafiscal.Text = "lfperiodonotafiscal";
            this.lfperiodonotafiscal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel24
            // 
            this.xrLabel24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(568.0419F, 42.99997F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(88.47809F, 20F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "Nota Fiscal:";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfperiodorealizado
            // 
            this.lfperiodorealizado.LocationFloat = new DevExpress.Utils.PointFloat(658.7499F, 21.99999F);
            this.lfperiodorealizado.Name = "lfperiodorealizado";
            this.lfperiodorealizado.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfperiodorealizado.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lfperiodorealizado.StylePriority.UseTextAlignment = false;
            this.lfperiodorealizado.Text = "lfperiodorealizado";
            this.lfperiodorealizado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(568.0419F, 21.99999F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(88.47809F, 20F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Realizado:";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfcompensacao
            // 
            this.lfcompensacao.LocationFloat = new DevExpress.Utils.PointFloat(658.7499F, 64F);
            this.lfcompensacao.Name = "lfcompensacao";
            this.lfcompensacao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfcompensacao.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lfcompensacao.StylePriority.UseTextAlignment = false;
            this.lfcompensacao.Text = "lfcompensacao";
            this.lfcompensacao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(568.0419F, 64F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(88.47809F, 20F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Compensação:";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfcliente
            // 
            this.lfcliente.LocationFloat = new DevExpress.Utils.PointFloat(81.23019F, 43.00001F);
            this.lfcliente.Name = "lfcliente";
            this.lfcliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfcliente.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lfcliente.StylePriority.UseTextAlignment = false;
            this.lfcliente.Text = "lfcliente";
            this.lfcliente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(4.000219F, 43.00001F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(74.63166F, 20F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Cliente:";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            this.xrLabel11.Text = "Previsão:";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfcontacorrente
            // 
            this.lfcontacorrente.LocationFloat = new DevExpress.Utils.PointFloat(81.23019F, 64F);
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
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(3.999996F, 64F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(74.6319F, 20F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Conta:";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfclassereceita
            // 
            this.lfclassereceita.LocationFloat = new DevExpress.Utils.PointFloat(81.23018F, 22F);
            this.lfclassereceita.Name = "lfclassereceita";
            this.lfclassereceita.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfclassereceita.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lfclassereceita.StylePriority.UseTextAlignment = false;
            this.lfclassereceita.Text = "lfclassereceita";
            this.lfclassereceita.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(4.000171F, 22F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(74.63166F, 20F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Receita:";
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
            this.lcaminho.Text = "Gitano ->SGFin ->Bancos ->Relatório Depósitos";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ltotparcelaqtd,
            this.ltotpagamento,
            this.ltotparcela,
            this.xrLabel21,
            this.xrLine1});
            this.ReportFooter.HeightF = 27.08333F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ReportFooter_BeforePrint);
            // 
            // ltotparcelaqtd
            // 
            this.ltotparcelaqtd.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotparcelaqtd.LocationFloat = new DevExpress.Utils.PointFloat(250.0002F, 7.374954F);
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
            this.ltotpagamento.LocationFloat = new DevExpress.Utils.PointFloat(738.0417F, 7.374986F);
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
            this.ltotparcela.LocationFloat = new DevExpress.Utils.PointFloat(568.0416F, 7.374986F);
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
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(1.999998F, 10.00001F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(198.0002F, 14F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Totais Gerais :";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RepBancosDepositos
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
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepBancosDepositos_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion


    double totprevisto = 0.00;
    double totrealizado = 0.00;
    Int64 totqtd = 0;
    //

	private void RepBancosDepositos_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
        string cliente = Convert.ToString(GetCurrentColumnValue("cliente"));
        lcliente.Text = cliente + " - " + uCliente.PegaNomeCliente(Convert.ToInt32(cliente));
        //
        string receita = Convert.ToString(GetCurrentColumnValue("classe"));
        lclassereceita.Text = receita + " - " + uReceitas.PegaReceitaDescricao(Convert.ToInt32(receita));
        //
        double previso = Convert.ToDouble(GetCurrentColumnValue("vlr_previsto"));
        double realizado = Convert.ToDouble(GetCurrentColumnValue("vlr_realizado"));
        Int64 parcelaqtd = 1;
        //
        totprevisto = totprevisto + previso;
        totrealizado = totrealizado + realizado;
        totqtd = totqtd + parcelaqtd;
        //
        //
        previso = 0.00;
        realizado = 0.00;
        parcelaqtd = 0;
        //
    }

    private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //
        ltotparcela.Text = String.Format("{0:N}", Convert.ToDouble(totprevisto));
        ltotpagamento.Text = String.Format("{0:N}", Convert.ToDouble(totrealizado));
        ltotparcelaqtd.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(totqtd));
    }

}
