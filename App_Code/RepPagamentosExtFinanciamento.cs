using DevExpress.XtraReports.UI;
using System;

/// <summary>
/// Summary description for RepPagamentosExtFinanciamento
/// </summary>
public class RepPagamentosExtFinanciamento : DevExpress.XtraReports.UI.XtraReport
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
    public XRLabel lvlrmulta;
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
    public XRLabel lobs;
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
    public XRLabel lvlrdesconto;
    public XRLabel lorigem;
    private ReportFooterBand ReportFooter;
    public XRLabel llegenda;
    private XRLine xrLine3;
    private XRLine xrLine2;
    public XRLabel ltotsaldodevedor;
    public XRLabel xrLabel22;
    public XRLabel ltotparcelaqtd;
    public XRLabel ltotdesconto;
    public XRLabel ltotmulta;
    public XRLabel ltotpagamento;
    public XRLabel ltotparcela;
    public XRLabel xrLabel21;
    public XRLabel ltotmulta_crs;
    public XRLabel ltotdesconto_crs;
    public XRLabel ltotparcelaqtd_crs;
    public XRLabel xrLabel24;
    public XRLabel ltotparcela_crs;
    public XRLabel ltotpagamento_crs;
    public XRLabel lativo;
    private XRLabel xrLabel23;
    public XRLabel xrLabel25;
    public XRLabel lfdatavenda;
    public XRLabel xrLabel28;
    public XRLabel lfperiodovenda;
    public XRLabel xrLabel30;
    public XRLabel lfcorrecao;
    public XRLabel ltotvencidoqtd;
    public XRLabel ltotavencerqtd;
    public XRLabel ltotsaldocredorqtd;
    public XRLabel ltotsaldodevedorqtd;
    public XRLabel xrLabel34;
    public XRLabel ltotavencer;
    public XRLabel ltotvencido;
    public XRLabel xrLabel33;
    public XRLabel xrLabel29;
    public XRLabel ltotsaldocredor;
    public XRLabel xrLabel27;
    private XRLine xrLine4;
    public XRLabel xrLabel41;
    public XRLabel xrLabel40;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public RepPagamentosExtFinanciamento()
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
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            string resourceFileName = "RepPagamentosExtFinanciamento.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lativo = new DevExpress.XtraReports.UI.XRLabel();
            this.lorigem = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrdesconto = new DevExpress.XtraReports.UI.XRLabel();
            this.ldatapagamento = new DevExpress.XtraReports.UI.XRLabel();
            this.lconta = new DevExpress.XtraReports.UI.XRLabel();
            this.ltipo = new DevExpress.XtraReports.UI.XRLabel();
            this.lobs = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrparcela = new DevExpress.XtraReports.UI.XRLabel();
            this.lparte = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcela = new DevExpress.XtraReports.UI.XRLabel();
            this.ldatavencimento = new DevExpress.XtraReports.UI.XRLabel();
            this.lgrupo = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrmulta = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfdatavenda = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfperiodovenda = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.lfcorrecao = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotvencidoqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotavencerqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaldocredorqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaldodevedorqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotavencer = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotvencido = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaldocredor = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.ltotmulta_crs = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotdesconto_crs = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotparcelaqtd_crs = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotparcela_crs = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotpagamento_crs = new DevExpress.XtraReports.UI.XRLabel();
            this.llegenda = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.ltotsaldodevedor = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotparcelaqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotdesconto = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotmulta = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotpagamento = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotparcela = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lativo,
            this.lorigem,
            this.lvlrdesconto,
            this.ldatapagamento,
            this.lconta,
            this.ltipo,
            this.lobs,
            this.lvlrparcela,
            this.lparte,
            this.lparcela,
            this.ldatavencimento,
            this.lgrupo,
            this.lvlrmulta,
            this.lvlrpagamento,
            this.lunidade,
            this.lid});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 12.5F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // lativo
            // 
            this.lativo.Font = new System.Drawing.Font("Calibri", 7F);
            this.lativo.ForeColor = System.Drawing.Color.Black;
            this.lativo.LocationFloat = new DevExpress.Utils.PointFloat(960.0003F, 1.041667F);
            this.lativo.Name = "lativo";
            this.lativo.NullValueText = " ";
            this.lativo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lativo.SizeF = new System.Drawing.SizeF(22.95F, 10F);
            this.lativo.StylePriority.UseBackColor = false;
            this.lativo.StylePriority.UseFont = false;
            this.lativo.StylePriority.UseTextAlignment = false;
            this.lativo.Text = "lativo";
            this.lativo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lativo.WordWrap = false;
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
            // lvlrdesconto
            // 
            this.lvlrdesconto.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrdesconto.ForeColor = System.Drawing.Color.Black;
            this.lvlrdesconto.LocationFloat = new DevExpress.Utils.PointFloat(820.0002F, 1.041667F);
            this.lvlrdesconto.Name = "lvlrdesconto";
            this.lvlrdesconto.NullValueText = " ";
            this.lvlrdesconto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrdesconto.SizeF = new System.Drawing.SizeF(70F, 9.999999F);
            this.lvlrdesconto.StylePriority.UseBackColor = false;
            this.lvlrdesconto.StylePriority.UseFont = false;
            this.lvlrdesconto.StylePriority.UseTextAlignment = false;
            this.lvlrdesconto.Text = "lvlrdesconto";
            this.lvlrdesconto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlrdesconto.WordWrap = false;
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
            // lobs
            // 
            this.lobs.Font = new System.Drawing.Font("Calibri", 7F);
            this.lobs.ForeColor = System.Drawing.Color.Black;
            this.lobs.LocationFloat = new DevExpress.Utils.PointFloat(982.9585F, 1.041667F);
            this.lobs.Name = "lobs";
            this.lobs.NullValueText = " ";
            this.lobs.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lobs.SizeF = new System.Drawing.SizeF(65.04163F, 9.999999F);
            this.lobs.StylePriority.UseBackColor = false;
            this.lobs.StylePriority.UseFont = false;
            this.lobs.StylePriority.UseTextAlignment = false;
            this.lobs.Text = "lobs";
            this.lobs.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lobs.WordWrap = false;
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
            // lvlrmulta
            // 
            this.lvlrmulta.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrmulta.ForeColor = System.Drawing.Color.Black;
            this.lvlrmulta.LocationFloat = new DevExpress.Utils.PointFloat(750.0002F, 1.041667F);
            this.lvlrmulta.Name = "lvlrmulta";
            this.lvlrmulta.NullValueText = " ";
            this.lvlrmulta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrmulta.SizeF = new System.Drawing.SizeF(70F, 9.999999F);
            this.lvlrmulta.StylePriority.UseBackColor = false;
            this.lvlrmulta.StylePriority.UseFont = false;
            this.lvlrmulta.StylePriority.UseTextAlignment = false;
            this.lvlrmulta.Text = "lvlrmulta";
            this.lvlrmulta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlrmulta.WordWrap = false;
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
            this.ltitulorelatorio.Text = "RELATÓRIO EXTRATO DE FINANCIAMENTO";
            this.ltitulorelatorio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // grupocabecalho
            // 
            this.grupocabecalho.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel23,
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
            this.grupocabecalho.HeightF = 16.12498F;
            this.grupocabecalho.Name = "grupocabecalho";
            this.grupocabecalho.RepeatEveryPage = true;
            // 
            // xrLabel23
            // 
            this.xrLabel23.BackColor = System.Drawing.Color.Silver;
            this.xrLabel23.BorderColor = System.Drawing.Color.LightSlateGray;
            this.xrLabel23.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel23.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(83)))), ((int)(((byte)(149)))));
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(960.0003F, 0F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(22.95819F, 13F);
            this.xrLabel23.StylePriority.UseBackColor = false;
            this.xrLabel23.StylePriority.UseBorderColor = false;
            this.xrLabel23.StylePriority.UseBorders = false;
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseForeColor = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "A/I";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel20.Text = "Vlr. Desconto";
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
            this.xrLabel16.Text = "Vlr. Multa";
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
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(982.9585F, 0F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(65.04144F, 13F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Obs";
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
            this.xrLabel25,
            this.lfdatavenda,
            this.xrLabel28,
            this.lfperiodovenda,
            this.xrLabel30,
            this.lfcorrecao,
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
            this.grupofiltros.HeightF = 64.58334F;
            this.grupofiltros.Level = 1;
            this.grupofiltros.Name = "grupofiltros";
            // 
            // xrLabel25
            // 
            this.xrLabel25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(714.8666F, 1.000023F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(78F, 20F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "Data Venda:";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfdatavenda
            // 
            this.lfdatavenda.LocationFloat = new DevExpress.Utils.PointFloat(795.0967F, 1.000023F);
            this.lfdatavenda.Name = "lfdatavenda";
            this.lfdatavenda.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfdatavenda.SizeF = new System.Drawing.SizeF(240.37F, 20F);
            this.lfdatavenda.StylePriority.UseTextAlignment = false;
            this.lfdatavenda.Text = "lfdatavenda";
            this.lfdatavenda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel28
            // 
            this.xrLabel28.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(714.8668F, 21.99999F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(78F, 20F);
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "Período:";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfperiodovenda
            // 
            this.lfperiodovenda.LocationFloat = new DevExpress.Utils.PointFloat(795.0967F, 21.99999F);
            this.lfperiodovenda.Name = "lfperiodovenda";
            this.lfperiodovenda.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfperiodovenda.SizeF = new System.Drawing.SizeF(240.37F, 20F);
            this.lfperiodovenda.StylePriority.UseTextAlignment = false;
            this.lfperiodovenda.Text = "lfperiodovenda";
            this.lfperiodovenda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel30
            // 
            this.xrLabel30.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(714.8668F, 43.75F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(78F, 20F);
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.StylePriority.UseTextAlignment = false;
            this.xrLabel30.Text = "Correção:";
            this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfcorrecao
            // 
            this.lfcorrecao.LocationFloat = new DevExpress.Utils.PointFloat(795.0967F, 43.75003F);
            this.lfcorrecao.Name = "lfcorrecao";
            this.lfcorrecao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfcorrecao.SizeF = new System.Drawing.SizeF(240.37F, 20F);
            this.lfcorrecao.StylePriority.UseTextAlignment = false;
            this.lfcorrecao.Text = "lfcorrecao";
            this.lfcorrecao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfproprietario
            // 
            this.lfproprietario.LocationFloat = new DevExpress.Utils.PointFloat(385.5199F, 43.75F);
            this.lfproprietario.Name = "lfproprietario";
            this.lfproprietario.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfproprietario.SizeF = new System.Drawing.SizeF(318.7666F, 20F);
            this.lfproprietario.StylePriority.UseTextAlignment = false;
            this.lfproprietario.Text = "lfproprietario";
            this.lfproprietario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(305.5199F, 43.74999F);
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
            this.lfgrupounidade.LocationFloat = new DevExpress.Utils.PointFloat(81.23019F, 43.00003F);
            this.lfgrupounidade.Name = "lfgrupounidade";
            this.lfgrupounidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfgrupounidade.SizeF = new System.Drawing.SizeF(215.71F, 20F);
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
            this.lfperiodo.LocationFloat = new DevExpress.Utils.PointFloat(385.5198F, 21.99999F);
            this.lfperiodo.Name = "lfperiodo";
            this.lfperiodo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfperiodo.SizeF = new System.Drawing.SizeF(318.7665F, 20F);
            this.lfperiodo.StylePriority.UseTextAlignment = false;
            this.lfperiodo.Text = "lfperiodo";
            this.lfperiodo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(305.5199F, 21.99999F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(78F, 20F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Filtro:";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfcontacorrente
            // 
            this.lfcontacorrente.LocationFloat = new DevExpress.Utils.PointFloat(385.5198F, 1.000023F);
            this.lfcontacorrente.Name = "lfcontacorrente";
            this.lfcontacorrente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfcontacorrente.SizeF = new System.Drawing.SizeF(318.7667F, 20F);
            this.lfcontacorrente.StylePriority.UseTextAlignment = false;
            this.lfcontacorrente.Text = "lfcontacorrente";
            this.lfcontacorrente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(305.5198F, 1F);
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
            this.lfgrupo.LocationFloat = new DevExpress.Utils.PointFloat(81.23018F, 21.99999F);
            this.lfgrupo.Name = "lfgrupo";
            this.lfgrupo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfgrupo.SizeF = new System.Drawing.SizeF(215.71F, 20F);
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
            this.lfproduto.LocationFloat = new DevExpress.Utils.PointFloat(81.23018F, 1.000023F);
            this.lfproduto.Name = "lfproduto";
            this.lfproduto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfproduto.SizeF = new System.Drawing.SizeF(215.71F, 20F);
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
            this.lcaminho.LocationFloat = new DevExpress.Utils.PointFloat(4.999995F, 3.999996F);
            this.lcaminho.Name = "lcaminho";
            this.lcaminho.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcaminho.SizeF = new System.Drawing.SizeF(442.7082F, 14F);
            this.lcaminho.StylePriority.UseFont = false;
            this.lcaminho.Text = "Gitano ->SGFin ->Empresa ->Relatório Extrato de Financiamento";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel41,
            this.xrLabel40,
            this.ltotvencidoqtd,
            this.ltotavencerqtd,
            this.ltotsaldocredorqtd,
            this.ltotsaldodevedorqtd,
            this.xrLabel34,
            this.ltotavencer,
            this.ltotvencido,
            this.xrLabel33,
            this.xrLabel29,
            this.ltotsaldocredor,
            this.xrLabel27,
            this.xrLine4,
            this.ltotmulta_crs,
            this.ltotdesconto_crs,
            this.ltotparcelaqtd_crs,
            this.xrLabel24,
            this.ltotparcela_crs,
            this.ltotpagamento_crs,
            this.llegenda,
            this.xrLine3,
            this.xrLine2,
            this.ltotsaldodevedor,
            this.xrLabel22,
            this.ltotparcelaqtd,
            this.ltotdesconto,
            this.ltotmulta,
            this.ltotpagamento,
            this.ltotparcela,
            this.xrLabel21,
            this.xrLine1});
            this.ReportFooter.HeightF = 166.6667F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ReportFooter_BeforePrint);
            // 
            // xrLabel41
            // 
            this.xrLabel41.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(480.0002F, 51.37501F);
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel41.SizeF = new System.Drawing.SizeF(99.99988F, 14F);
            this.xrLabel41.StylePriority.UseFont = false;
            this.xrLabel41.StylePriority.UseTextAlignment = false;
            this.xrLabel41.Text = "Valores:";
            this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel40
            // 
            this.xrLabel40.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(200.0002F, 51.37501F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(69.99995F, 14F);
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            this.xrLabel40.Text = "No. Parcelas:";
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ltotvencidoqtd
            // 
            this.ltotvencidoqtd.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotvencidoqtd.LocationFloat = new DevExpress.Utils.PointFloat(200.0002F, 99.4583F);
            this.ltotvencidoqtd.Name = "ltotvencidoqtd";
            this.ltotvencidoqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotvencidoqtd.SizeF = new System.Drawing.SizeF(70F, 14F);
            this.ltotvencidoqtd.StylePriority.UseFont = false;
            this.ltotvencidoqtd.StylePriority.UseTextAlignment = false;
            this.ltotvencidoqtd.Text = "ltotvencidoqtd";
            this.ltotvencidoqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotavencerqtd
            // 
            this.ltotavencerqtd.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotavencerqtd.LocationFloat = new DevExpress.Utils.PointFloat(200.0002F, 114.4583F);
            this.ltotavencerqtd.Name = "ltotavencerqtd";
            this.ltotavencerqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotavencerqtd.SizeF = new System.Drawing.SizeF(70F, 14F);
            this.ltotavencerqtd.StylePriority.UseFont = false;
            this.ltotavencerqtd.StylePriority.UseTextAlignment = false;
            this.ltotavencerqtd.Text = "ltotavencerqtd";
            this.ltotavencerqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaldocredorqtd
            // 
            this.ltotsaldocredorqtd.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldocredorqtd.LocationFloat = new DevExpress.Utils.PointFloat(200.0002F, 84.45836F);
            this.ltotsaldocredorqtd.Name = "ltotsaldocredorqtd";
            this.ltotsaldocredorqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldocredorqtd.SizeF = new System.Drawing.SizeF(70F, 14F);
            this.ltotsaldocredorqtd.StylePriority.UseFont = false;
            this.ltotsaldocredorqtd.StylePriority.UseTextAlignment = false;
            this.ltotsaldocredorqtd.Text = "ltotsaldocredorqtd";
            this.ltotsaldocredorqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaldodevedorqtd
            // 
            this.ltotsaldodevedorqtd.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldodevedorqtd.LocationFloat = new DevExpress.Utils.PointFloat(200.0002F, 68.45834F);
            this.ltotsaldodevedorqtd.Name = "ltotsaldodevedorqtd";
            this.ltotsaldodevedorqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldodevedorqtd.SizeF = new System.Drawing.SizeF(70F, 14F);
            this.ltotsaldodevedorqtd.StylePriority.UseFont = false;
            this.ltotsaldodevedorqtd.StylePriority.UseTextAlignment = false;
            this.ltotsaldodevedorqtd.Text = "ltotsaldodevedorqtd";
            this.ltotsaldodevedorqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel34
            // 
            this.xrLabel34.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(2.00015F, 114.4583F);
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(148.0002F, 13.99999F);
            this.xrLabel34.StylePriority.UseFont = false;
            this.xrLabel34.StylePriority.UseTextAlignment = false;
            this.xrLabel34.Text = "Valor á Vencer:";
            this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotavencer
            // 
            this.ltotavencer.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotavencer.LocationFloat = new DevExpress.Utils.PointFloat(480.0003F, 114.4583F);
            this.ltotavencer.Name = "ltotavencer";
            this.ltotavencer.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotavencer.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotavencer.StylePriority.UseFont = false;
            this.ltotavencer.StylePriority.UseTextAlignment = false;
            this.ltotavencer.Text = "ltotavencer";
            this.ltotavencer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotvencido
            // 
            this.ltotvencido.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotvencido.LocationFloat = new DevExpress.Utils.PointFloat(480.0003F, 99.4583F);
            this.ltotvencido.Name = "ltotvencido";
            this.ltotvencido.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotvencido.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotvencido.StylePriority.UseFont = false;
            this.ltotvencido.StylePriority.UseTextAlignment = false;
            this.ltotvencido.Text = "ltotvencido";
            this.ltotvencido.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel33
            // 
            this.xrLabel33.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(2.00015F, 99.4583F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(148.0002F, 13.99999F);
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.StylePriority.UseTextAlignment = false;
            this.xrLabel33.Text = "Valor Vencido:";
            this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel29
            // 
            this.xrLabel29.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(2.00015F, 84.45834F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(148.0002F, 13.99999F);
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.Text = "Saldo Credor (Pago):";
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaldocredor
            // 
            this.ltotsaldocredor.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldocredor.LocationFloat = new DevExpress.Utils.PointFloat(480.0003F, 84.45834F);
            this.ltotsaldocredor.Name = "ltotsaldocredor";
            this.ltotsaldocredor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldocredor.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotsaldocredor.StylePriority.UseFont = false;
            this.ltotsaldocredor.StylePriority.UseTextAlignment = false;
            this.ltotsaldocredor.Text = "ltotsaldocredor";
            this.ltotsaldocredor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel27
            // 
            this.xrLabel27.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(1.999966F, 51.37501F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(128.0002F, 14F);
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "Resumo Financeiro:";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine4
            // 
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
            // 
            // ltotmulta_crs
            // 
            this.ltotmulta_crs.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotmulta_crs.LocationFloat = new DevExpress.Utils.PointFloat(750.0002F, 10.00001F);
            this.ltotmulta_crs.Name = "ltotmulta_crs";
            this.ltotmulta_crs.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotmulta_crs.SizeF = new System.Drawing.SizeF(70F, 14F);
            this.ltotmulta_crs.StylePriority.UseFont = false;
            this.ltotmulta_crs.StylePriority.UseTextAlignment = false;
            this.ltotmulta_crs.Text = "ltotmulta_crs";
            this.ltotmulta_crs.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotdesconto_crs
            // 
            this.ltotdesconto_crs.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotdesconto_crs.LocationFloat = new DevExpress.Utils.PointFloat(820.0002F, 10.00001F);
            this.ltotdesconto_crs.Name = "ltotdesconto_crs";
            this.ltotdesconto_crs.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotdesconto_crs.SizeF = new System.Drawing.SizeF(70F, 14F);
            this.ltotdesconto_crs.StylePriority.UseFont = false;
            this.ltotdesconto_crs.StylePriority.UseTextAlignment = false;
            this.ltotdesconto_crs.Text = "ltotdesconto_crs";
            this.ltotdesconto_crs.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotparcelaqtd_crs
            // 
            this.ltotparcelaqtd_crs.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotparcelaqtd_crs.LocationFloat = new DevExpress.Utils.PointFloat(200.0002F, 10.00001F);
            this.ltotparcelaqtd_crs.Name = "ltotparcelaqtd_crs";
            this.ltotparcelaqtd_crs.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotparcelaqtd_crs.SizeF = new System.Drawing.SizeF(70F, 14F);
            this.ltotparcelaqtd_crs.StylePriority.UseFont = false;
            this.ltotparcelaqtd_crs.StylePriority.UseTextAlignment = false;
            this.ltotparcelaqtd_crs.Text = "ltotparcelaqtd_crs";
            this.ltotparcelaqtd_crs.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel24
            // 
            this.xrLabel24.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(1.999982F, 10.00001F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(198.0002F, 14F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "Totais Gerais (Cr$):";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotparcela_crs
            // 
            this.ltotparcela_crs.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotparcela_crs.LocationFloat = new DevExpress.Utils.PointFloat(480.0001F, 10.00001F);
            this.ltotparcela_crs.Name = "ltotparcela_crs";
            this.ltotparcela_crs.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotparcela_crs.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotparcela_crs.StylePriority.UseFont = false;
            this.ltotparcela_crs.StylePriority.UseTextAlignment = false;
            this.ltotparcela_crs.Text = "ltotparcela_crs";
            this.ltotparcela_crs.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotpagamento_crs
            // 
            this.ltotpagamento_crs.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotpagamento_crs.LocationFloat = new DevExpress.Utils.PointFloat(650.0002F, 10.00001F);
            this.ltotpagamento_crs.Name = "ltotpagamento_crs";
            this.ltotpagamento_crs.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotpagamento_crs.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotpagamento_crs.StylePriority.UseFont = false;
            this.ltotpagamento_crs.StylePriority.UseTextAlignment = false;
            this.ltotpagamento_crs.Text = "ltotpagamento_crs";
            this.ltotpagamento_crs.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // llegenda
            // 
            this.llegenda.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llegenda.LocationFloat = new DevExpress.Utils.PointFloat(2.000006F, 141.8333F);
            this.llegenda.Name = "llegenda";
            this.llegenda.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.llegenda.SizeF = new System.Drawing.SizeF(1046F, 14F);
            this.llegenda.StylePriority.UseFont = false;
            this.llegenda.StylePriority.UseTextAlignment = false;
            this.llegenda.Text = "llegenda";
            this.llegenda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 159F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0.0001192093F, 134.4583F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
            // 
            // ltotsaldodevedor
            // 
            this.ltotsaldodevedor.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldodevedor.LocationFloat = new DevExpress.Utils.PointFloat(480.0001F, 68.45833F);
            this.ltotsaldodevedor.Name = "ltotsaldodevedor";
            this.ltotsaldodevedor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldodevedor.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.ltotsaldodevedor.StylePriority.UseFont = false;
            this.ltotsaldodevedor.StylePriority.UseTextAlignment = false;
            this.ltotsaldodevedor.Text = "ltotsaldodevedor";
            this.ltotsaldodevedor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel22
            // 
            this.xrLabel22.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(1.999966F, 68.45834F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(148.0002F, 13.99999F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "Saldo Devedor (Aberto):";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotparcelaqtd
            // 
            this.ltotparcelaqtd.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotparcelaqtd.LocationFloat = new DevExpress.Utils.PointFloat(200.0002F, 29.00001F);
            this.ltotparcelaqtd.Name = "ltotparcelaqtd";
            this.ltotparcelaqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotparcelaqtd.SizeF = new System.Drawing.SizeF(70F, 14F);
            this.ltotparcelaqtd.StylePriority.UseFont = false;
            this.ltotparcelaqtd.StylePriority.UseTextAlignment = false;
            this.ltotparcelaqtd.Text = "ltotparcelaqtd";
            this.ltotparcelaqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotdesconto
            // 
            this.ltotdesconto.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotdesconto.LocationFloat = new DevExpress.Utils.PointFloat(820.0002F, 29.00001F);
            this.ltotdesconto.Name = "ltotdesconto";
            this.ltotdesconto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotdesconto.SizeF = new System.Drawing.SizeF(70F, 14F);
            this.ltotdesconto.StylePriority.UseFont = false;
            this.ltotdesconto.StylePriority.UseTextAlignment = false;
            this.ltotdesconto.Text = "ltotdesconto";
            this.ltotdesconto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotmulta
            // 
            this.ltotmulta.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotmulta.LocationFloat = new DevExpress.Utils.PointFloat(750.0002F, 29.00001F);
            this.ltotmulta.Name = "ltotmulta";
            this.ltotmulta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotmulta.SizeF = new System.Drawing.SizeF(70F, 14F);
            this.ltotmulta.StylePriority.UseFont = false;
            this.ltotmulta.StylePriority.UseTextAlignment = false;
            this.ltotmulta.Text = "ltotmulta";
            this.ltotmulta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotpagamento
            // 
            this.ltotpagamento.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotpagamento.LocationFloat = new DevExpress.Utils.PointFloat(650.0002F, 29.00001F);
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
            this.ltotparcela.LocationFloat = new DevExpress.Utils.PointFloat(480.0001F, 29.00001F);
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
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(1.999998F, 29.00001F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(198.0002F, 14F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Totais Gerais (R$):";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RepPagamentosExtFinanciamento
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
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepPagamentosExtFinanciamento_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    //
    double totparcela = 0.00;
    double totpagamento = 0.00;
    Int64 totparcelaqtd = 0;
    double totmulta = 0.00;
    double totdesconto = 0.00;
    //
    double totparcela_crs = 0.00;
    double totpagamento_crs = 0.00;
    Int64 totparcelaqtd_crs = 0;
    double totmulta_crs = 0.00;
    double totdesconto_crs = 0.00;
    //
    double totsaldodevedor = 0.00;
    double totsaldocredor = 0.00;
    Int64 totsaldodevedorqtd = 0;
    Int64 totsaldocredorqtd = 0;
    double totvencido = 0.00;
    double totavencer = 0.00;
    Int64 totvencidoqtd = 0;
    Int64 totavencerqtd = 0;
    //

    private void RepPagamentosExtFinanciamento_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
        string data_pagamento = GetCurrentColumnValue("data_pagamento").ToString().Substring(0, 10);
        //
        if (data_pagamento != "01/01/1900")
        {
            ldatapagamento.Text = data_pagamento;
        }
        else
        {
            ldatapagamento.Text = " ";
        }
        //
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
        //
        //Parcela Ativa
        if (Convert.ToInt16(GetCurrentColumnValue("ativa")) == 1)
        {
            lativo.Text = "A";
        }
        else
        {
            lativo.Text = "I";
        }
        //Linha
        double parcela = Convert.ToDouble(GetCurrentColumnValue("vlr_parcela"));
        double pagamento = Convert.ToDouble(GetCurrentColumnValue("vlr_pagamento"));
        Int64 parcelaqtd = 1;
        double multa = 0.00;
        double desconto = 0.00;
        //
        if (Convert.ToDouble(GetCurrentColumnValue("vlr_pagamento")) != Convert.ToDouble(GetCurrentColumnValue("vlr_parcela")))
        {
            if (Convert.ToDouble(GetCurrentColumnValue("vlr_pagamento")) != 0.00)
            {
                if ((Convert.ToDouble(GetCurrentColumnValue("vlr_pagamento")) > 0.00) &&
                (Convert.ToDouble(GetCurrentColumnValue("vlr_pagamento")) > Convert.ToDouble(GetCurrentColumnValue("vlr_parcela"))))
                {
                    multa = (Convert.ToDouble(GetCurrentColumnValue("vlr_pagamento")) - Convert.ToDouble(GetCurrentColumnValue("vlr_parcela")));
                }
                else
                {
                    desconto = (Convert.ToDouble(GetCurrentColumnValue("vlr_parcela")) - Convert.ToDouble(GetCurrentColumnValue("vlr_pagamento")));
                }
            }
        }
        //
        lvlrmulta.Text = String.Format("{0:N}", Convert.ToDouble(multa));
        lvlrdesconto.Text = String.Format("{0:N}", Convert.ToDouble(desconto));
        //
        double saldodevedor = 0.00;
        double saldocredor = 0.00;
        Int64 saldodevedorqtd = 0;
        Int64 saldocredorqtd = 0;
        //
        double vencido = 0.00;
        double avencer = 0.00;
        Int64 vencidoqtd = 0;
        Int64 avencerqtd = 0;
        //
        if (Convert.ToDateTime(GetCurrentColumnValue("data_vencimento")) <= Convert.ToDateTime("30/06/1994"))
        {
            totparcela_crs = totparcela_crs + parcela;
            totpagamento_crs = totpagamento_crs + pagamento;
            totparcelaqtd_crs = totparcelaqtd_crs + parcelaqtd;
            totmulta_crs = totmulta_crs + multa;
            totdesconto_crs = totdesconto_crs + desconto;
        }
        else
        {
            totparcela = totparcela + parcela;
            totpagamento = totpagamento + pagamento;
            totparcelaqtd = totparcelaqtd + parcelaqtd;
            totmulta = totmulta + multa;
            totdesconto = totdesconto + desconto;
        }
        //
        //Parcela Ativa
        if (Convert.ToInt16(GetCurrentColumnValue("ativa")) == 1)
        {
            //Pós Plano Real
            if (Convert.ToDateTime(GetCurrentColumnValue("data_vencimento")) > Convert.ToDateTime("30/06/1994"))
            {
                if (Convert.ToDateTime(GetCurrentColumnValue("data_pagamento")) == Convert.ToDateTime("01/01/1900"))
                {
                    saldodevedor = Convert.ToDouble(GetCurrentColumnValue("vlr_parcela"));
                    saldodevedorqtd++;
                }
                else
                {
                    saldocredor = Convert.ToDouble(GetCurrentColumnValue("vlr_pagamento"));
                    saldocredorqtd++;
                }
                //
                if (Convert.ToDateTime(GetCurrentColumnValue("data_pagamento")) == Convert.ToDateTime("01/01/1900"))
                {
                    if (Convert.ToDateTime(GetCurrentColumnValue("data_pagamento")) < DateTime.Now)
                    {
                        vencido = Convert.ToDouble(GetCurrentColumnValue("vlr_parcela"));
                        vencidoqtd++;
                    }
                    else
                    {
                        avencer = Convert.ToDouble(GetCurrentColumnValue("vlr_parcela"));
                        avencerqtd++;
                    }
                }
            }
        }
        //
        totsaldodevedor = totsaldodevedor + saldodevedor;
        totsaldocredor = totsaldocredor + saldocredor;
        totsaldodevedorqtd = totsaldodevedorqtd + saldodevedorqtd;
        totsaldocredorqtd = totsaldocredorqtd + saldocredorqtd;
        //
        totvencido = totvencido + vencido;
        totavencer = totavencer + avencer;
        totvencidoqtd = totvencidoqtd + vencidoqtd;
        totavencerqtd = totavencerqtd + avencerqtd;
        //
        parcela = 0.00;
        pagamento = 0.00;
        parcelaqtd = 0;
        multa = 0.00;
        desconto = 0.00;
        saldodevedor = 0.00;
        saldocredor = 0.00;
        saldodevedorqtd = 0;
        saldocredorqtd = 0;
        vencido = 0.00;
        avencer = 0.00;
        vencidoqtd = 0;
        avencerqtd = 0;
        //
    }

    private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //
        ltotparcela_crs.Text = String.Format("{0:N}", Convert.ToDouble(totparcela_crs));
        ltotpagamento_crs.Text = String.Format("{0:N}", Convert.ToDouble(totpagamento_crs));
        ltotparcelaqtd_crs.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(totparcelaqtd_crs));
        ltotmulta_crs.Text = String.Format("{0:N}", Convert.ToDouble(totmulta_crs));
        ltotdesconto_crs.Text = String.Format("{0:N}", Convert.ToDouble(totdesconto_crs));
        //
        ltotparcela.Text = String.Format("{0:N}", Convert.ToDouble(totparcela));
        ltotpagamento.Text = String.Format("{0:N}", Convert.ToDouble(totpagamento));
        ltotparcelaqtd.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(totparcelaqtd));
        ltotmulta.Text = String.Format("{0:N}", Convert.ToDouble(totmulta));
        ltotdesconto.Text = String.Format("{0:N}", Convert.ToDouble(totdesconto));
        //
        ltotsaldodevedor.Text = String.Format("{0:N}", Convert.ToDouble(totsaldodevedor));
        ltotsaldocredor.Text = String.Format("{0:N}", Convert.ToDouble(totsaldocredor));
        ltotsaldodevedorqtd.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(totsaldodevedorqtd));
        ltotsaldocredorqtd.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(totsaldocredorqtd));
        //
        ltotvencido.Text = String.Format("{0:N}", Convert.ToDouble(totvencido));
        ltotavencer.Text = String.Format("{0:N}", Convert.ToDouble(totavencer));
        ltotvencidoqtd.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(totvencidoqtd));
        ltotavencerqtd.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(totavencerqtd));
        //
    }

}
