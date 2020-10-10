using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for RepVendasComissoes
/// </summary>
public class RepVendasComissoes : DevExpress.XtraReports.UI.XtraReport
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
	public XRLabel ltaxacomissao;
	public XRLabel lvlrpagamento;
	public XRLabel lunidade;
	private XRLabel xrLabel3;
	private XRLabel xrLabel15;
    public XRLabel ldatavencimento;
	public XRLabel lgrupo;
    private XRLabel xrLabel17;
    private FormattingRule formattingRule1;
    private XRLabel xrLabel5;
	private PageFooterBand PageFooter;
	public XRLabel lcaminho;
    public XRLabel lfgrupo;
    private XRLabel xrLabel1;
    public XRLabel lparcela;
    private XRLabel xrLabel6;
    public XRLabel lparte;
    private XRLabel xrLabel7;
    private XRLine xrLine1;
    public XRLabel lfcontacorrente;
    private XRLabel xrLabel10;
    public XRLabel lfperiodo;
    private XRLabel xrLabel11;
    public XRLabel lvlrparcela;
    private XRLabel xrLabel8;
    public XRLabel lcorretor;
    public XRLabel lfgrupounidade;
    private XRLabel xrLabel12;
    public XRLabel lfproprietario;
    private XRLabel xrLabel2;
    private XRLabel xrLabel20;
    private XRLabel xrLabel16;
    private XRLabel xrLabel14;
    private XRLabel xrLabel13;
    private XRLabel xrLabel9;
    public XRLabel lconta;
    public XRLabel ltipo;
    public XRLabel ldatapagamento;
    public XRLabel lvlrcomissao;
    public XRLabel lorigem;
    private ReportFooterBand ReportFooter;
    public XRLabel llegenda;
    private XRLine xrLine3;
    private XRLine xrLine2;
    public XRLabel ltotparcelaqtd;
    public XRLabel ltotcomissao;
    public XRLabel ltotpagamento;
    public XRLabel ltotparcela;
    public XRLabel xrLabel21;
    public GroupHeaderBand headerdata;
    public GroupFooterBand footerdata;
    public XRLabel lsubcomissao;
    public XRLabel lsubpagamento;
    public XRLabel lrodapedata;
    private XRLine xrLine4;
    public XRLabel xrLabel24;
    public XRLabel lsubparcela;
    public XRLabel lcabecalhodata;
    public XRLabel lftipoparcela;
    private XRLabel xrLabel30;
    public XRLabel lfpagamentos;
    private XRLabel xrLabel25;
    public XRLabel lforigempagamentos;
    private XRLabel xrLabel28;
    private XRLabel xrLabel29;
    public XRLabel lfordem;
    private XRLabel xrLabel31;
    public XRLabel lfdesistentes;
    public GroupHeaderBand headerunidade;
    public XRLabel lcabecalhounidade;
    public GroupFooterBand footerunidade;
    public XRLabel lsubpagamento2;
    public XRLabel lsubcomissao2;
    public XRLabel lrodapeunidade;
    public XRLabel lsubparcela2;
    public XRLabel xrLabel32;
    private XRLine xrLine5;
    public XRLabel lfcorretor;
    private XRLabel xrLabel22;
	
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public RepVendasComissoes()
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
            string resourceFileName = "RepVendasComissoes.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lorigem = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrcomissao = new DevExpress.XtraReports.UI.XRLabel();
            this.ldatapagamento = new DevExpress.XtraReports.UI.XRLabel();
            this.lconta = new DevExpress.XtraReports.UI.XRLabel();
            this.ltipo = new DevExpress.XtraReports.UI.XRLabel();
            this.lcorretor = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrparcela = new DevExpress.XtraReports.UI.XRLabel();
            this.lparte = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcela = new DevExpress.XtraReports.UI.XRLabel();
            this.ldatavencimento = new DevExpress.XtraReports.UI.XRLabel();
            this.lgrupo = new DevExpress.XtraReports.UI.XRLabel();
            this.ltaxacomissao = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrpagamento = new DevExpress.XtraReports.UI.XRLabel();
            this.lunidade = new DevExpress.XtraReports.UI.XRLabel();
            this.lid = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.grupofiltros = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lfcorretor = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfdesistentes = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfordem = new DevExpress.XtraReports.UI.XRLabel();
            this.lftipoparcela = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfpagamentos = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.lforigempagamentos = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfproprietario = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfgrupounidade = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfperiodo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfcontacorrente = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
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
            this.llegenda = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.ltotparcelaqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotcomissao = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotpagamento = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotparcela = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.headerdata = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lcabecalhodata = new DevExpress.XtraReports.UI.XRLabel();
            this.footerdata = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.lsubcomissao = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubpagamento = new DevExpress.XtraReports.UI.XRLabel();
            this.lrodapedata = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubparcela = new DevExpress.XtraReports.UI.XRLabel();
            this.headerunidade = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lcabecalhounidade = new DevExpress.XtraReports.UI.XRLabel();
            this.footerunidade = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.lsubpagamento2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubcomissao2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lrodapeunidade = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubparcela2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lorigem,
            this.lvlrcomissao,
            this.ldatapagamento,
            this.lconta,
            this.ltipo,
            this.lcorretor,
            this.lvlrparcela,
            this.lparte,
            this.lparcela,
            this.ldatavencimento,
            this.lgrupo,
            this.ltaxacomissao,
            this.lvlrpagamento,
            this.lunidade,
            this.lid});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 13.54167F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // lorigem
            // 
            this.lorigem.Font = new System.Drawing.Font("Calibri", 7F);
            this.lorigem.ForeColor = System.Drawing.Color.Black;
            this.lorigem.LocationFloat = new DevExpress.Utils.PointFloat(890.0002F, 0.9999911F);
            this.lorigem.Name = "lorigem";
            this.lorigem.NullValueText = " ";
            this.lorigem.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lorigem.SizeF = new System.Drawing.SizeF(70.00012F, 9.999999F);
            this.lorigem.StylePriority.UseBackColor = false;
            this.lorigem.StylePriority.UseFont = false;
            this.lorigem.StylePriority.UseTextAlignment = false;
            this.lorigem.Text = "lorigem";
            this.lorigem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lorigem.WordWrap = false;
            // 
            // lvlrcomissao
            // 
            this.lvlrcomissao.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrcomissao.ForeColor = System.Drawing.Color.Black;
            this.lvlrcomissao.LocationFloat = new DevExpress.Utils.PointFloat(820.0002F, 1.041667F);
            this.lvlrcomissao.Name = "lvlrcomissao";
            this.lvlrcomissao.NullValueText = " ";
            this.lvlrcomissao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrcomissao.SizeF = new System.Drawing.SizeF(70F, 9.999999F);
            this.lvlrcomissao.StylePriority.UseBackColor = false;
            this.lvlrcomissao.StylePriority.UseFont = false;
            this.lvlrcomissao.StylePriority.UseTextAlignment = false;
            this.lvlrcomissao.Text = "lvlrcomissao";
            this.lvlrcomissao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlrcomissao.WordWrap = false;
            // 
            // ldatapagamento
            // 
            this.ldatapagamento.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldatapagamento.ForeColor = System.Drawing.Color.Black;
            this.ldatapagamento.LocationFloat = new DevExpress.Utils.PointFloat(580.0002F, 1.041667F);
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
            // lconta
            // 
            this.lconta.Font = new System.Drawing.Font("Calibri", 7F);
            this.lconta.ForeColor = System.Drawing.Color.Black;
            this.lconta.LocationFloat = new DevExpress.Utils.PointFloat(340.0002F, 1.041667F);
            this.lconta.Name = "lconta";
            this.lconta.NullValueText = " ";
            this.lconta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lconta.SizeF = new System.Drawing.SizeF(69.99998F, 9.999999F);
            this.lconta.StylePriority.UseBackColor = false;
            this.lconta.StylePriority.UseFont = false;
            this.lconta.StylePriority.UseTextAlignment = false;
            this.lconta.Text = "lconta";
            this.lconta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lconta.WordWrap = false;
            // 
            // ltipo
            // 
            this.ltipo.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltipo.ForeColor = System.Drawing.Color.Black;
            this.ltipo.LocationFloat = new DevExpress.Utils.PointFloat(270.0002F, 1.041667F);
            this.ltipo.Name = "ltipo";
            this.ltipo.NullValueText = " ";
            this.ltipo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltipo.SizeF = new System.Drawing.SizeF(69.99998F, 9.999999F);
            this.ltipo.StylePriority.UseBackColor = false;
            this.ltipo.StylePriority.UseFont = false;
            this.ltipo.StylePriority.UseTextAlignment = false;
            this.ltipo.Text = "ltipo";
            this.ltipo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.ltipo.WordWrap = false;
            // 
            // lcorretor
            // 
            this.lcorretor.Font = new System.Drawing.Font("Calibri", 7F);
            this.lcorretor.ForeColor = System.Drawing.Color.Black;
            this.lcorretor.LocationFloat = new DevExpress.Utils.PointFloat(960.0003F, 1.041667F);
            this.lcorretor.Name = "lcorretor";
            this.lcorretor.NullValueText = " ";
            this.lcorretor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcorretor.SizeF = new System.Drawing.SizeF(87.99982F, 9.999999F);
            this.lcorretor.StylePriority.UseBackColor = false;
            this.lcorretor.StylePriority.UseFont = false;
            this.lcorretor.StylePriority.UseTextAlignment = false;
            this.lcorretor.Text = "lcorretor";
            this.lcorretor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lcorretor.WordWrap = false;
            // 
            // lvlrparcela
            // 
            this.lvlrparcela.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrparcela.ForeColor = System.Drawing.Color.Black;
            this.lvlrparcela.LocationFloat = new DevExpress.Utils.PointFloat(480.0002F, 1.041667F);
            this.lvlrparcela.Name = "lvlrparcela";
            this.lvlrparcela.NullValueText = " ";
            this.lvlrparcela.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrparcela.SizeF = new System.Drawing.SizeF(100F, 9.999999F);
            this.lvlrparcela.StylePriority.UseBackColor = false;
            this.lvlrparcela.StylePriority.UseFont = false;
            this.lvlrparcela.StylePriority.UseTextAlignment = false;
            this.lvlrparcela.Text = "lvlrparcela";
            this.lvlrparcela.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlrparcela.WordWrap = false;
            // 
            // lparte
            // 
            this.lparte.Font = new System.Drawing.Font("Calibri", 7F);
            this.lparte.ForeColor = System.Drawing.Color.Black;
            this.lparte.LocationFloat = new DevExpress.Utils.PointFloat(150.0002F, 1.041667F);
            this.lparte.Name = "lparte";
            this.lparte.NullValueText = " ";
            this.lparte.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparte.SizeF = new System.Drawing.SizeF(50F, 10F);
            this.lparte.StylePriority.UseBackColor = false;
            this.lparte.StylePriority.UseFont = false;
            this.lparte.Text = "lparte";
            this.lparte.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lparte.WordWrap = false;
            // 
            // lparcela
            // 
            this.lparcela.Font = new System.Drawing.Font("Calibri", 7F);
            this.lparcela.ForeColor = System.Drawing.Color.Black;
            this.lparcela.LocationFloat = new DevExpress.Utils.PointFloat(200.0002F, 0.9999911F);
            this.lparcela.Name = "lparcela";
            this.lparcela.NullValueText = " ";
            this.lparcela.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcela.SizeF = new System.Drawing.SizeF(69.99998F, 9.999999F);
            this.lparcela.StylePriority.UseBackColor = false;
            this.lparcela.StylePriority.UseFont = false;
            this.lparcela.StylePriority.UseTextAlignment = false;
            this.lparcela.Text = "lparcela";
            this.lparcela.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lparcela.WordWrap = false;
            // 
            // ldatavencimento
            // 
            this.ldatavencimento.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldatavencimento.ForeColor = System.Drawing.Color.Black;
            this.ldatavencimento.LocationFloat = new DevExpress.Utils.PointFloat(410.0002F, 1.041667F);
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
            // lgrupo
            // 
            this.lgrupo.Font = new System.Drawing.Font("Calibri", 7F);
            this.lgrupo.ForeColor = System.Drawing.Color.Black;
            this.lgrupo.LocationFloat = new DevExpress.Utils.PointFloat(50.00016F, 1.041667F);
            this.lgrupo.Name = "lgrupo";
            this.lgrupo.NullValueText = " ";
            this.lgrupo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lgrupo.SizeF = new System.Drawing.SizeF(50.00002F, 10F);
            this.lgrupo.StylePriority.UseBackColor = false;
            this.lgrupo.StylePriority.UseFont = false;
            this.lgrupo.Text = "lgrupo";
            this.lgrupo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lgrupo.WordWrap = false;
            // 
            // ltaxacomissao
            // 
            this.ltaxacomissao.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltaxacomissao.ForeColor = System.Drawing.Color.Black;
            this.ltaxacomissao.LocationFloat = new DevExpress.Utils.PointFloat(750.0002F, 1.041667F);
            this.ltaxacomissao.Name = "ltaxacomissao";
            this.ltaxacomissao.NullValueText = " ";
            this.ltaxacomissao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltaxacomissao.SizeF = new System.Drawing.SizeF(70F, 9.999999F);
            this.ltaxacomissao.StylePriority.UseBackColor = false;
            this.ltaxacomissao.StylePriority.UseFont = false;
            this.ltaxacomissao.StylePriority.UseTextAlignment = false;
            this.ltaxacomissao.Text = "ltaxacomissao";
            this.ltaxacomissao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltaxacomissao.WordWrap = false;
            // 
            // lvlrpagamento
            // 
            this.lvlrpagamento.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrpagamento.ForeColor = System.Drawing.Color.Black;
            this.lvlrpagamento.LocationFloat = new DevExpress.Utils.PointFloat(650.0001F, 0.9999911F);
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
            // lunidade
            // 
            this.lunidade.Font = new System.Drawing.Font("Calibri", 7F);
            this.lunidade.ForeColor = System.Drawing.Color.Black;
            this.lunidade.LocationFloat = new DevExpress.Utils.PointFloat(100.0002F, 1.041667F);
            this.lunidade.Name = "lunidade";
            this.lunidade.NullValueText = " ";
            this.lunidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lunidade.SizeF = new System.Drawing.SizeF(50F, 10F);
            this.lunidade.StylePriority.UseBackColor = false;
            this.lunidade.StylePriority.UseFont = false;
            this.lunidade.Text = "lunidade";
            this.lunidade.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lunidade.WordWrap = false;
            // 
            // lid
            // 
            this.lid.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lid.ForeColor = System.Drawing.Color.Black;
            this.lid.LocationFloat = new DevExpress.Utils.PointFloat(0.0001509984F, 1.041667F);
            this.lid.Name = "lid";
            this.lid.NullValueText = " ";
            this.lid.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lid.SizeF = new System.Drawing.SizeF(50.00001F, 10F);
            this.lid.StylePriority.UseBackColor = false;
            this.lid.StylePriority.UseFont = false;
            this.lid.Text = "lid";
            this.lid.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lid.WordWrap = false;
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
            this.ltitulorelatorio.Text = "RELATÓRIO COMISSÕES";
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
            this.xrLabel17,
            this.xrLabel15,
            this.xrLabel3,
            this.xrLabel18,
            this.xrLabel26,
            this.xrLabel19});
            this.grupocabecalho.HeightF = 14.04165F;
            this.grupocabecalho.Level = 2;
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
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(820.0002F, 0F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(70F, 13F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseBorderColor = false;
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseForeColor = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Vlr. Comissão";
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
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(750.0002F, 0F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(70F, 13F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseBorderColor = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "% Comissão";
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
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(580.0002F, 0F);
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
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(340.0002F, 0F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(70F, 13F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseBorderColor = false;
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Conta";
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
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(270.0002F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(70F, 13F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseBorderColor = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Parcela Tipo";
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
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(650.0002F, 0F);
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
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(410.0002F, 0F);
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
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(200.0002F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(70F, 13F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Parcela No.";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(960.0002F, 0F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(88.99976F, 13F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Corretor";
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
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(480.0002F, 0F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(100F, 13F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseBorderColor = false;
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "Vlr.Parcela";
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
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(890.0002F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(70F, 13F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Origem Pgto";
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
            this.lfcorretor,
            this.xrLabel22,
            this.xrLabel31,
            this.lfdesistentes,
            this.xrLabel29,
            this.lfordem,
            this.lftipoparcela,
            this.xrLabel30,
            this.lfpagamentos,
            this.xrLabel25,
            this.lforigempagamentos,
            this.xrLabel28,
            this.lfproprietario,
            this.xrLabel2,
            this.lfgrupounidade,
            this.xrLabel12,
            this.lfperiodo,
            this.xrLabel11,
            this.lfcontacorrente,
            this.xrLabel10,
            this.lfgrupo,
            this.xrLabel1,
            this.lfproduto,
            this.xrLabel4});
            this.grupofiltros.HeightF = 87.5F;
            this.grupofiltros.Level = 3;
            this.grupofiltros.Name = "grupofiltros";
            // 
            // lfcorretor
            // 
            this.lfcorretor.LocationFloat = new DevExpress.Utils.PointFloat(470.5198F, 43.74997F);
            this.lfcorretor.Name = "lfcorretor";
            this.lfcorretor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfcorretor.SizeF = new System.Drawing.SizeF(300F, 20F);
            this.lfcorretor.StylePriority.UseTextAlignment = false;
            this.lfcorretor.Text = "lfcorretor";
            this.lfcorretor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel22
            // 
            this.xrLabel22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(390.2898F, 43.74997F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(78F, 20F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "Corretor:";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel31
            // 
            this.xrLabel31.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(391.5198F, 65.74997F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(78F, 20F);
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.Text = "Desistêntes:";
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfdesistentes
            // 
            this.lfdesistentes.LocationFloat = new DevExpress.Utils.PointFloat(471.7499F, 65.74997F);
            this.lfdesistentes.Name = "lfdesistentes";
            this.lfdesistentes.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfdesistentes.SizeF = new System.Drawing.SizeF(180F, 20F);
            this.lfdesistentes.StylePriority.UseTextAlignment = false;
            this.lfdesistentes.Text = "lfdesistentes";
            this.lfdesistentes.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel29
            // 
            this.xrLabel29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(784.5004F, 64.74998F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(78F, 20F);
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.Text = "Ordenação:";
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfordem
            // 
            this.lfordem.LocationFloat = new DevExpress.Utils.PointFloat(864.7304F, 64.74998F);
            this.lfordem.Name = "lfordem";
            this.lfordem.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfordem.SizeF = new System.Drawing.SizeF(180F, 20F);
            this.lfordem.StylePriority.UseTextAlignment = false;
            this.lfordem.Text = "lfordem";
            this.lfordem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lftipoparcela
            // 
            this.lftipoparcela.LocationFloat = new DevExpress.Utils.PointFloat(864.7303F, 21.99996F);
            this.lftipoparcela.Name = "lftipoparcela";
            this.lftipoparcela.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lftipoparcela.SizeF = new System.Drawing.SizeF(180F, 20F);
            this.lftipoparcela.StylePriority.UseTextAlignment = false;
            this.lftipoparcela.Text = "lftipoparcela";
            this.lftipoparcela.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel30
            // 
            this.xrLabel30.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(784.5003F, 43.74997F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(78F, 20F);
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.StylePriority.UseTextAlignment = false;
            this.xrLabel30.Text = "Pagamentos:";
            this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfpagamentos
            // 
            this.lfpagamentos.LocationFloat = new DevExpress.Utils.PointFloat(864.7303F, 43.74997F);
            this.lfpagamentos.Name = "lfpagamentos";
            this.lfpagamentos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfpagamentos.SizeF = new System.Drawing.SizeF(180F, 20F);
            this.lfpagamentos.StylePriority.UseTextAlignment = false;
            this.lfpagamentos.Text = "lfpagamentos";
            this.lfpagamentos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel25
            // 
            this.xrLabel25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(784.5002F, 0.9999911F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(78F, 20F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "Origem:";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lforigempagamentos
            // 
            this.lforigempagamentos.LocationFloat = new DevExpress.Utils.PointFloat(864.7303F, 0.9999911F);
            this.lforigempagamentos.Name = "lforigempagamentos";
            this.lforigempagamentos.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lforigempagamentos.SizeF = new System.Drawing.SizeF(180F, 20F);
            this.lforigempagamentos.StylePriority.UseTextAlignment = false;
            this.lforigempagamentos.Text = "lforigempagamentos";
            this.lforigempagamentos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel28
            // 
            this.xrLabel28.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(784.5003F, 21.99996F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(78F, 20F);
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "Tipo Parc.";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfproprietario
            // 
            this.lfproprietario.LocationFloat = new DevExpress.Utils.PointFloat(81.23018F, 65.00002F);
            this.lfproprietario.Name = "lfproprietario";
            this.lfproprietario.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfproprietario.SizeF = new System.Drawing.SizeF(300F, 20F);
            this.lfproprietario.StylePriority.UseTextAlignment = false;
            this.lfproprietario.Text = "lfproprietario";
            this.lfproprietario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(1.000198F, 65.00002F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(78F, 20F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Proprietário:";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfgrupounidade
            // 
            this.lfgrupounidade.LocationFloat = new DevExpress.Utils.PointFloat(81.23019F, 43.00001F);
            this.lfgrupounidade.Name = "lfgrupounidade";
            this.lfgrupounidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfgrupounidade.SizeF = new System.Drawing.SizeF(300F, 20F);
            this.lfgrupounidade.StylePriority.UseTextAlignment = false;
            this.lfgrupounidade.Text = "lfgrupounidade";
            this.lfgrupounidade.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            this.xrLabel12.Text = "Unidade:";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfperiodo
            // 
            this.lfperiodo.LocationFloat = new DevExpress.Utils.PointFloat(471.7499F, 21.99999F);
            this.lfperiodo.Name = "lfperiodo";
            this.lfperiodo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfperiodo.SizeF = new System.Drawing.SizeF(300F, 20F);
            this.lfperiodo.StylePriority.UseTextAlignment = false;
            this.lfperiodo.Text = "lfperiodo";
            this.lfperiodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(391.5199F, 21.99999F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(78F, 20F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Período:";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfcontacorrente
            // 
            this.lfcontacorrente.LocationFloat = new DevExpress.Utils.PointFloat(471.7499F, 1F);
            this.lfcontacorrente.Name = "lfcontacorrente";
            this.lfcontacorrente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfcontacorrente.SizeF = new System.Drawing.SizeF(300F, 20F);
            this.lfcontacorrente.StylePriority.UseTextAlignment = false;
            this.lfcontacorrente.Text = "lfcontacorrente";
            this.lfcontacorrente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(391.5198F, 1F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(78F, 20F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Conta:";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfgrupo
            // 
            this.lfgrupo.LocationFloat = new DevExpress.Utils.PointFloat(81.23018F, 22F);
            this.lfgrupo.Name = "lfgrupo";
            this.lfgrupo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfgrupo.SizeF = new System.Drawing.SizeF(300F, 20F);
            this.lfgrupo.StylePriority.UseTextAlignment = false;
            this.lfgrupo.Text = "lfgrupo";
            this.lfgrupo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            this.xrLabel1.Text = "Grupo:";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfproduto
            // 
            this.lfproduto.LocationFloat = new DevExpress.Utils.PointFloat(81.23017F, 1F);
            this.lfproduto.Name = "lfproduto";
            this.lfproduto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfproduto.SizeF = new System.Drawing.SizeF(300F, 20F);
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
            this.lcaminho.LocationFloat = new DevExpress.Utils.PointFloat(4.999995F, 3.999964F);
            this.lcaminho.Name = "lcaminho";
            this.lcaminho.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcaminho.SizeF = new System.Drawing.SizeF(418.7498F, 14F);
            this.lcaminho.StylePriority.UseFont = false;
            this.lcaminho.Text = "Gitano ->SGFin ->Empresa ->Relatório Comissões";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.llegenda,
            this.xrLine3,
            this.xrLine2,
            this.ltotparcelaqtd,
            this.ltotcomissao,
            this.ltotpagamento,
            this.ltotparcela,
            this.xrLabel21,
            this.xrLine1});
            this.ReportFooter.HeightF = 68.75F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ReportFooter_BeforePrint);
            // 
            // llegenda
            // 
            this.llegenda.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llegenda.LocationFloat = new DevExpress.Utils.PointFloat(2.000006F, 41.83334F);
            this.llegenda.Name = "llegenda";
            this.llegenda.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.llegenda.SizeF = new System.Drawing.SizeF(860.5002F, 14F);
            this.llegenda.StylePriority.UseFont = false;
            this.llegenda.StylePriority.UseTextAlignment = false;
            this.llegenda.Text = "llegenda";
            this.llegenda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0.0001192093F, 34.45834F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
            // 
            // ltotparcelaqtd
            // 
            this.ltotparcelaqtd.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotparcelaqtd.LocationFloat = new DevExpress.Utils.PointFloat(200.0002F, 10.00001F);
            this.ltotparcelaqtd.Name = "ltotparcelaqtd";
            this.ltotparcelaqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotparcelaqtd.SizeF = new System.Drawing.SizeF(70F, 14F);
            this.ltotparcelaqtd.StylePriority.UseFont = false;
            this.ltotparcelaqtd.StylePriority.UseTextAlignment = false;
            this.ltotparcelaqtd.Text = "ltotparcelaqtd";
            this.ltotparcelaqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotcomissao
            // 
            this.ltotcomissao.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotcomissao.LocationFloat = new DevExpress.Utils.PointFloat(820.0002F, 10.00001F);
            this.ltotcomissao.Name = "ltotcomissao";
            this.ltotcomissao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotcomissao.SizeF = new System.Drawing.SizeF(70F, 14F);
            this.ltotcomissao.StylePriority.UseFont = false;
            this.ltotcomissao.StylePriority.UseTextAlignment = false;
            this.ltotcomissao.Text = "ltotcomissao";
            this.ltotcomissao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotpagamento
            // 
            this.ltotpagamento.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotpagamento.LocationFloat = new DevExpress.Utils.PointFloat(650.0002F, 10.00001F);
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
            this.ltotparcela.LocationFloat = new DevExpress.Utils.PointFloat(480.0001F, 10.00001F);
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
            // headerdata
            // 
            this.headerdata.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lcabecalhodata});
            this.headerdata.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage;
            this.headerdata.HeightF = 16.66667F;
            this.headerdata.Name = "headerdata";
            this.headerdata.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.headerdata_BeforePrint);
            // 
            // lcabecalhodata
            // 
            this.lcabecalhodata.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcabecalhodata.LocationFloat = new DevExpress.Utils.PointFloat(1.999995F, 1F);
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
            this.lsubcomissao,
            this.lsubpagamento,
            this.lrodapedata,
            this.xrLine4,
            this.xrLabel24,
            this.lsubparcela});
            this.footerdata.HeightF = 31.25F;
            this.footerdata.Name = "footerdata";
            this.footerdata.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.footerdata_BeforePrint);
            // 
            // lsubcomissao
            // 
            this.lsubcomissao.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubcomissao.LocationFloat = new DevExpress.Utils.PointFloat(820.5001F, 12.70835F);
            this.lsubcomissao.Name = "lsubcomissao";
            this.lsubcomissao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubcomissao.SizeF = new System.Drawing.SizeF(70F, 14F);
            this.lsubcomissao.StylePriority.UseFont = false;
            this.lsubcomissao.StylePriority.UseTextAlignment = false;
            this.lsubcomissao.Text = "lsubcomissao";
            this.lsubcomissao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubpagamento
            // 
            this.lsubpagamento.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubpagamento.LocationFloat = new DevExpress.Utils.PointFloat(650.5001F, 12.70834F);
            this.lsubpagamento.Name = "lsubpagamento";
            this.lsubpagamento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubpagamento.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.lsubpagamento.StylePriority.UseFont = false;
            this.lsubpagamento.StylePriority.UseTextAlignment = false;
            this.lsubpagamento.Text = "lsubpagamento";
            this.lsubpagamento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lrodapedata
            // 
            this.lrodapedata.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrodapedata.LocationFloat = new DevExpress.Utils.PointFloat(200.5001F, 12.70834F);
            this.lrodapedata.Name = "lrodapedata";
            this.lrodapedata.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lrodapedata.SizeF = new System.Drawing.SizeF(80F, 14F);
            this.lrodapedata.StylePriority.UseFont = false;
            this.lrodapedata.StylePriority.UseTextAlignment = false;
            this.lrodapedata.Text = "lrodapedata";
            this.lrodapedata.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLine4
            // 
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0.5F, 2.708329F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
            // 
            // xrLabel24
            // 
            this.xrLabel24.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(2.499879F, 12.70834F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(198.0002F, 14F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "Totais Data:";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubparcela
            // 
            this.lsubparcela.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubparcela.LocationFloat = new DevExpress.Utils.PointFloat(480.5F, 12.70834F);
            this.lsubparcela.Name = "lsubparcela";
            this.lsubparcela.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubparcela.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.lsubparcela.StylePriority.UseFont = false;
            this.lsubparcela.StylePriority.UseTextAlignment = false;
            this.lsubparcela.Text = "lsubparcela";
            this.lsubparcela.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // headerunidade
            // 
            this.headerunidade.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lcabecalhounidade});
            this.headerunidade.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage;
            this.headerunidade.HeightF = 17.70833F;
            this.headerunidade.Level = 1;
            this.headerunidade.Name = "headerunidade";
            this.headerunidade.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.headerunidade_BeforePrint);
            // 
            // lcabecalhounidade
            // 
            this.lcabecalhounidade.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcabecalhounidade.LocationFloat = new DevExpress.Utils.PointFloat(2.000149F, 0.9999911F);
            this.lcabecalhounidade.Name = "lcabecalhounidade";
            this.lcabecalhounidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcabecalhounidade.SizeF = new System.Drawing.SizeF(888.0002F, 14F);
            this.lcabecalhounidade.StylePriority.UseFont = false;
            this.lcabecalhounidade.StylePriority.UseTextAlignment = false;
            this.lcabecalhounidade.Text = "lcabecalhounidade";
            this.lcabecalhounidade.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // footerunidade
            // 
            this.footerunidade.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lsubpagamento2,
            this.lsubcomissao2,
            this.lrodapeunidade,
            this.lsubparcela2,
            this.xrLabel32,
            this.xrLine5});
            this.footerunidade.HeightF = 29.16667F;
            this.footerunidade.Level = 1;
            this.footerunidade.Name = "footerunidade";
            this.footerunidade.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.footerunidade_BeforePrint);
            // 
            // lsubpagamento2
            // 
            this.lsubpagamento2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubpagamento2.LocationFloat = new DevExpress.Utils.PointFloat(650.5001F, 14F);
            this.lsubpagamento2.Name = "lsubpagamento2";
            this.lsubpagamento2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubpagamento2.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.lsubpagamento2.StylePriority.UseFont = false;
            this.lsubpagamento2.StylePriority.UseTextAlignment = false;
            this.lsubpagamento2.Text = "lsubpagamento2";
            this.lsubpagamento2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubcomissao2
            // 
            this.lsubcomissao2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubcomissao2.LocationFloat = new DevExpress.Utils.PointFloat(820.5001F, 14.00001F);
            this.lsubcomissao2.Name = "lsubcomissao2";
            this.lsubcomissao2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubcomissao2.SizeF = new System.Drawing.SizeF(70F, 14F);
            this.lsubcomissao2.StylePriority.UseFont = false;
            this.lsubcomissao2.StylePriority.UseTextAlignment = false;
            this.lsubcomissao2.Text = "lsubcomissao2";
            this.lsubcomissao2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lrodapeunidade
            // 
            this.lrodapeunidade.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrodapeunidade.LocationFloat = new DevExpress.Utils.PointFloat(200.5001F, 14F);
            this.lrodapeunidade.Name = "lrodapeunidade";
            this.lrodapeunidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lrodapeunidade.SizeF = new System.Drawing.SizeF(120F, 14F);
            this.lrodapeunidade.StylePriority.UseFont = false;
            this.lrodapeunidade.StylePriority.UseTextAlignment = false;
            this.lrodapeunidade.Text = "lrodapeunidade";
            this.lrodapeunidade.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubparcela2
            // 
            this.lsubparcela2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubparcela2.LocationFloat = new DevExpress.Utils.PointFloat(480.5F, 14F);
            this.lsubparcela2.Name = "lsubparcela2";
            this.lsubparcela2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubparcela2.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.lsubparcela2.StylePriority.UseFont = false;
            this.lsubparcela2.StylePriority.UseTextAlignment = false;
            this.lsubparcela2.Text = "lsubparcela2";
            this.lsubparcela2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel32
            // 
            this.xrLabel32.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(2.499879F, 14F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(198.0002F, 14F);
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.Text = "Totais Unidade:";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLine5
            // 
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(0.5F, 3.999989F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
            // 
            // RepVendasComissoes
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
            this.footerdata,
            this.headerunidade,
            this.footerunidade});
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
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepVendasComissoes_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

    double subparcela = 0.00;
    double subpagamento = 0.00;
    Int64 subparcelaqtd = 0;
    double submulta = 0.00;
    double subcomissao = 0.00;
    //
    double totparcela = 0.00;
    double totpagamento = 0.00;
    Int64 totparcelaqtd = 0;
    double totmulta = 0.00;
    double totcomissao = 0.00;
    //
    double totsaldodevedor = 0.00;
    double totsaldocredor = 0.00;
    //
    public Boolean eimprimedatapagamento = false;
    public Boolean eimprimeunidade = false;

	private void RepVendasComissoes_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
        string unidade = Convert.ToString(GetCurrentColumnValue("unidade"));
        string parte = Convert.ToString(GetCurrentColumnValue("parte"));
        Int32 corretor = Convert.ToInt32(uVendas.PegaCorretor(produto, grupo, unidade, parte));
        //
        double parcela = Convert.ToDouble(GetCurrentColumnValue("vlr_parcela"));
        double pagamento = Convert.ToDouble(GetCurrentColumnValue("vlr_pagamento"));
        Int64 parcelaqtd = 1;
        double taxacomissao = Convert.ToDouble(uCorretor.PegaTaxaComissão(corretor));
        double comissao = 0.00;
        //
        if (taxacomissao != 0)
        {
            comissao = (parcela * (taxacomissao/100));
        }
        //
        ltaxacomissao.Text = String.Format("{0:N}", Convert.ToDouble(taxacomissao));
        lvlrcomissao.Text = String.Format("{0:N}", Convert.ToDouble(comissao));
        lcorretor.Text = corretor.ToString().Trim() + " - " + uCorretor.PegaApelidoCorretor(corretor);
        //
        subparcela = subparcela + parcela;
        subpagamento = subpagamento + pagamento;
        subparcelaqtd = subparcelaqtd + parcelaqtd;
        subcomissao = subcomissao + comissao;
        //
        totparcela = totparcela + parcela;
        totpagamento = totpagamento + pagamento;
        totparcelaqtd = totparcelaqtd + parcelaqtd;
        totcomissao = totcomissao + comissao;
        //
        parcela = 0.00;
        pagamento = 0.00;
        parcelaqtd = 0;
        taxacomissao = 0.00;
        comissao = 0.00;
        //
    }

    private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //
        ltotparcela.Text = String.Format("{0:N}", Convert.ToDouble(totparcela));
        ltotpagamento.Text = String.Format("{0:N}", Convert.ToDouble(totpagamento));
        ltotparcelaqtd.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(totparcelaqtd));
        //ltotmulta.Text = String.Format("{0:N}", Convert.ToDouble(totmulta));
        ltotcomissao.Text = String.Format("{0:N}", Convert.ToDouble(totcomissao));
        //ltotsaldodevedor.Text = String.Format("{0:N}", Convert.ToDouble(totsaldodevedor));
        //ltotsaldocredor.Text = String.Format("{0:N}", Convert.ToDouble(totsaldocredor));

    }

    private void footerdata_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        e.Cancel = !eimprimedatapagamento;
        //
        if (eimprimedatapagamento)
        {
            lrodapedata.Text = GetCurrentColumnValue("data_pagamento").ToString();
            lrodapedata.Text = Convert.ToDateTime(GetCurrentColumnValue("data_pagamento")).ToShortDateString();
            //
            lsubparcela.Text = String.Format("{0:N}", Convert.ToDouble(subparcela));
            lsubpagamento.Text = String.Format("{0:N}", Convert.ToDouble(subpagamento));
            //lsubmulta.Text = String.Format("{0:N}", Convert.ToDouble(submulta));
            lsubcomissao.Text = String.Format("{0:N}", Convert.ToDouble(subcomissao));
            //
            subparcela = 0.00;
            subpagamento = 0.00;
            subparcelaqtd = 0;
            submulta = 0.00;
            subcomissao = 0.00;
        }
    }

    private void headerdata_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        e.Cancel = !eimprimedatapagamento;
        //
        if (eimprimedatapagamento)
        {
            lcabecalhodata.Text = GetCurrentColumnValue("data_pagamento").ToString();
            lcabecalhodata.Text = Convert.ToDateTime(GetCurrentColumnValue("data_pagamento")).ToShortDateString();
            //
        }
    }

    private void headerunidade_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        e.Cancel = !eimprimeunidade;
        //
        if (eimprimeunidade)
        {
            string produto = GetCurrentColumnValue("produto").ToString().Trim();
            string grupo = GetCurrentColumnValue("grupo").ToString().Trim();
            string grupounidade = GetCurrentColumnValue("unidade").ToString().Trim();
            string parte = GetCurrentColumnValue("parte").ToString().Trim();
            lcabecalhounidade.Text = GetCurrentColumnValue("identificador").ToString() + " - " +
            uContato.PegaNomeID(uVendas.PegaProprietário(produto, grupo, grupounidade, parte));
            //
        }
    }

    private void footerunidade_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        e.Cancel = !eimprimeunidade;
        //
        if (eimprimeunidade)
        {
            lrodapeunidade.Text = GetCurrentColumnValue("identificador").ToString();
            //
            lsubparcela2.Text = String.Format("{0:N}", Convert.ToDouble(subparcela));
            lsubpagamento2.Text = String.Format("{0:N}", Convert.ToDouble(subpagamento));
            //lsubmulta2.Text = String.Format("{0:N}", Convert.ToDouble(submulta));
            lsubcomissao2.Text = String.Format("{0:N}", Convert.ToDouble(subcomissao));
            //
            subparcela = 0.00;
            subpagamento = 0.00;
            subparcelaqtd = 0;
            submulta = 0.00;
            subcomissao = 0.00;
        }
    }

}
