using DevExpress.XtraReports.UI;
using System;

/// <summary>
/// Summary description for RepPagamentosCobrancaNBancaria
/// </summary>
public class RepPagamentosCobrancaNBancaria : DevExpress.XtraReports.UI.XtraReport
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
    private GroupHeaderBand grupofiltros;
    private XRLabel xrLabel4;
    public XRLabel ltempresa;
    public XRLabel lfproduto;
    public XRLabel ltusuario;
    private XRPictureBox xrPictureBox1;
    private XRControlStyle xrControlStyle1;
    private XRControlStyle xrControlStyle2;
    public XRLabel lid_venda;
    public XRLabel lvenda_localizada;
    public XRLabel lvlrpagamento;
    public XRLabel lidentificador;
    private XRLabel xrLabel3;
    private XRLabel xrLabel15;
    public XRLabel ldatavencimento;
    private XRLabel xrLabel17;
    private FormattingRule formattingRule1;
    private PageFooterBand PageFooter;
    public XRLabel lcaminho;
    public XRLabel lfgrupo;
    private XRLabel xrLabel1;
    public XRLabel lconta_cedente;
    private XRLabel xrLabel6;
    public XRLabel lplano;
    private XRLabel xrLabel7;
    private XRLine xrLine1;
    public XRLabel lfcontacorrente;
    private XRLabel xrLabel10;
    public XRLabel lfperiodo;
    private XRLabel xrLabel11;
    public XRLabel lvlrparcela;
    private XRLabel xrLabel8;
    public XRLabel lparcela_ID;
    public XRLabel lfgrupounidade;
    private XRLabel xrLabel12;
    public XRLabel lfdiferenca;
    private XRLabel xrLabel2;
    private XRLabel xrLabel20;
    private XRLabel xrLabel16;
    private XRLabel xrLabel14;
    private XRLabel xrLabel9;
    public XRLabel lapelido_cedente;
    public XRLabel lvlrjuros;
    public XRLabel lparcela_sistema;
    public XRLabel lparcela_corrigida;
    private ReportFooterBand ReportFooter;
    private XRLine xrLine2;
    public XRLabel ltotparcelaqtd;
    public XRLabel ltotparcela_sistema;
    public XRLabel ltotvlr_pgto_total;
    public XRLabel ltotvlr_pgto_juros;
    public XRLabel ltotvlr_pgto_base;
    public XRLabel xrLabel21;
    public GroupHeaderBand headerdata;
    public GroupFooterBand footerdata;
    public XRLabel lsubparcela_sistema;
    public XRLabel lsubvlr_pgto_juros;
    public XRLabel lsubvlr_pgto_total;
    public XRLabel lrodapedata;
    private XRLine xrLine4;
    public XRLabel xrLabel24;
    public XRLabel lsubvlr_pgto_base;
    public XRLabel lcabecalhodata;
    public XRLabel lsubparcela_corrigida;
    public XRLabel lparcela_diferenca;
    private XRLabel xrLabel13;
    public XRLabel lsubparcela_diferenca;
    public XRLabel ltotparcela_corrigida;
    public XRLabel ltotparcela_diferenca;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public RepPagamentosCobrancaNBancaria()
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
            //string resourceFileName = "RepPagamentosCobrancaNBancaria.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lparcela_diferenca = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcela_corrigida = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcela_sistema = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrjuros = new DevExpress.XtraReports.UI.XRLabel();
            this.lapelido_cedente = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcela_ID = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrparcela = new DevExpress.XtraReports.UI.XRLabel();
            this.lplano = new DevExpress.XtraReports.UI.XRLabel();
            this.lconta_cedente = new DevExpress.XtraReports.UI.XRLabel();
            this.ldatavencimento = new DevExpress.XtraReports.UI.XRLabel();
            this.lvenda_localizada = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrpagamento = new DevExpress.XtraReports.UI.XRLabel();
            this.lidentificador = new DevExpress.XtraReports.UI.XRLabel();
            this.lid_venda = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.grupofiltros = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lfdiferenca = new DevExpress.XtraReports.UI.XRLabel();
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
            this.ltotparcela_diferenca = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotparcela_corrigida = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.ltotparcelaqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotparcela_sistema = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotvlr_pgto_total = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotvlr_pgto_juros = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotvlr_pgto_base = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.headerdata = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lcabecalhodata = new DevExpress.XtraReports.UI.XRLabel();
            this.footerdata = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.lsubparcela_diferenca = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubparcela_corrigida = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubparcela_sistema = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubvlr_pgto_juros = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubvlr_pgto_total = new DevExpress.XtraReports.UI.XRLabel();
            this.lrodapedata = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubvlr_pgto_base = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lparcela_diferenca,
            this.lparcela_corrigida,
            this.lparcela_sistema,
            this.lvlrjuros,
            this.lapelido_cedente,
            this.lparcela_ID,
            this.lvlrparcela,
            this.lplano,
            this.lconta_cedente,
            this.ldatavencimento,
            this.lvenda_localizada,
            this.lvlrpagamento,
            this.lidentificador,
            this.lid_venda});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 13.54167F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // lparcela_diferenca
            // 
            this.lparcela_diferenca.Font = new System.Drawing.Font("Calibri", 7F);
            this.lparcela_diferenca.ForeColor = System.Drawing.Color.Black;
            this.lparcela_diferenca.LocationFloat = new DevExpress.Utils.PointFloat(913.3334F, 2.041667F);
            this.lparcela_diferenca.Name = "lparcela_diferenca";
            this.lparcela_diferenca.NullValueText = " ";
            this.lparcela_diferenca.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcela_diferenca.SizeF = new System.Drawing.SizeF(80F, 9.999999F);
            this.lparcela_diferenca.StylePriority.UseBackColor = false;
            this.lparcela_diferenca.StylePriority.UseFont = false;
            this.lparcela_diferenca.StylePriority.UseTextAlignment = false;
            this.lparcela_diferenca.Text = "lparcela_diferenca";
            this.lparcela_diferenca.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lparcela_diferenca.WordWrap = false;
            // 
            // lparcela_corrigida
            // 
            this.lparcela_corrigida.Font = new System.Drawing.Font("Calibri", 7F);
            this.lparcela_corrigida.ForeColor = System.Drawing.Color.Black;
            this.lparcela_corrigida.LocationFloat = new DevExpress.Utils.PointFloat(823.3335F, 2.041667F);
            this.lparcela_corrigida.Name = "lparcela_corrigida";
            this.lparcela_corrigida.NullValueText = " ";
            this.lparcela_corrigida.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcela_corrigida.SizeF = new System.Drawing.SizeF(90F, 9.999999F);
            this.lparcela_corrigida.StylePriority.UseBackColor = false;
            this.lparcela_corrigida.StylePriority.UseFont = false;
            this.lparcela_corrigida.StylePriority.UseTextAlignment = false;
            this.lparcela_corrigida.Text = "lparcela_corrigida";
            this.lparcela_corrigida.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lparcela_corrigida.WordWrap = false;
            // 
            // lparcela_sistema
            // 
            this.lparcela_sistema.Font = new System.Drawing.Font("Calibri", 7F);
            this.lparcela_sistema.ForeColor = System.Drawing.Color.Black;
            this.lparcela_sistema.LocationFloat = new DevExpress.Utils.PointFloat(733.3335F, 2.041667F);
            this.lparcela_sistema.Name = "lparcela_sistema";
            this.lparcela_sistema.NullValueText = " ";
            this.lparcela_sistema.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcela_sistema.SizeF = new System.Drawing.SizeF(90F, 9.999999F);
            this.lparcela_sistema.StylePriority.UseBackColor = false;
            this.lparcela_sistema.StylePriority.UseFont = false;
            this.lparcela_sistema.StylePriority.UseTextAlignment = false;
            this.lparcela_sistema.Text = "lparcela_sistema";
            this.lparcela_sistema.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lparcela_sistema.WordWrap = false;
            // 
            // lvlrjuros
            // 
            this.lvlrjuros.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrjuros.ForeColor = System.Drawing.Color.Black;
            this.lvlrjuros.LocationFloat = new DevExpress.Utils.PointFloat(543.3334F, 2.041667F);
            this.lvlrjuros.Name = "lvlrjuros";
            this.lvlrjuros.NullValueText = " ";
            this.lvlrjuros.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrjuros.SizeF = new System.Drawing.SizeF(69.50012F, 9.999999F);
            this.lvlrjuros.StylePriority.UseBackColor = false;
            this.lvlrjuros.StylePriority.UseFont = false;
            this.lvlrjuros.Text = "lvlrjuros";
            this.lvlrjuros.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlrjuros.WordWrap = false;
            // 
            // lapelido_cedente
            // 
            this.lapelido_cedente.Font = new System.Drawing.Font("Calibri", 7F);
            this.lapelido_cedente.ForeColor = System.Drawing.Color.Black;
            this.lapelido_cedente.LocationFloat = new DevExpress.Utils.PointFloat(229.3752F, 2.041667F);
            this.lapelido_cedente.Name = "lapelido_cedente";
            this.lapelido_cedente.NullValueText = " ";
            this.lapelido_cedente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lapelido_cedente.SizeF = new System.Drawing.SizeF(149.9386F, 9.999999F);
            this.lapelido_cedente.StylePriority.UseBackColor = false;
            this.lapelido_cedente.StylePriority.UseFont = false;
            this.lapelido_cedente.StylePriority.UseTextAlignment = false;
            this.lapelido_cedente.Text = "lapelido_cedente";
            this.lapelido_cedente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lapelido_cedente.WordWrap = false;
            // 
            // lparcela_ID
            // 
            this.lparcela_ID.Font = new System.Drawing.Font("Calibri", 7F);
            this.lparcela_ID.ForeColor = System.Drawing.Color.Black;
            this.lparcela_ID.LocationFloat = new DevExpress.Utils.PointFloat(993.3335F, 2.041667F);
            this.lparcela_ID.Name = "lparcela_ID";
            this.lparcela_ID.NullValueText = " ";
            this.lparcela_ID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcela_ID.SizeF = new System.Drawing.SizeF(54.66663F, 9.999999F);
            this.lparcela_ID.StylePriority.UseBackColor = false;
            this.lparcela_ID.StylePriority.UseFont = false;
            this.lparcela_ID.StylePriority.UseTextAlignment = false;
            this.lparcela_ID.Text = "lparcela_ID";
            this.lparcela_ID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lparcela_ID.WordWrap = false;
            // 
            // lvlrparcela
            // 
            this.lvlrparcela.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrparcela.ForeColor = System.Drawing.Color.Black;
            this.lvlrparcela.LocationFloat = new DevExpress.Utils.PointFloat(449.8337F, 1.999991F);
            this.lvlrparcela.Name = "lvlrparcela";
            this.lvlrparcela.NullValueText = " ";
            this.lvlrparcela.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrparcela.SizeF = new System.Drawing.SizeF(92.99973F, 9.999999F);
            this.lvlrparcela.StylePriority.UseBackColor = false;
            this.lvlrparcela.StylePriority.UseFont = false;
            this.lvlrparcela.StylePriority.UseTextAlignment = false;
            this.lvlrparcela.Text = "lvlrparcela";
            this.lvlrparcela.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlrparcela.WordWrap = false;
            // 
            // lplano
            // 
            this.lplano.Font = new System.Drawing.Font("Calibri", 7F);
            this.lplano.ForeColor = System.Drawing.Color.Black;
            this.lplano.LocationFloat = new DevExpress.Utils.PointFloat(150.0002F, 2.041667F);
            this.lplano.Name = "lplano";
            this.lplano.NullValueText = " ";
            this.lplano.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lplano.SizeF = new System.Drawing.SizeF(50F, 10F);
            this.lplano.StylePriority.UseBackColor = false;
            this.lplano.StylePriority.UseFont = false;
            this.lplano.Text = "lplano";
            this.lplano.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lplano.WordWrap = false;
            // 
            // lconta_cedente
            // 
            this.lconta_cedente.Font = new System.Drawing.Font("Calibri", 7F);
            this.lconta_cedente.ForeColor = System.Drawing.Color.Black;
            this.lconta_cedente.LocationFloat = new DevExpress.Utils.PointFloat(200.0002F, 1.999991F);
            this.lconta_cedente.Name = "lconta_cedente";
            this.lconta_cedente.NullValueText = " ";
            this.lconta_cedente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lconta_cedente.SizeF = new System.Drawing.SizeF(29.37497F, 9.999999F);
            this.lconta_cedente.StylePriority.UseBackColor = false;
            this.lconta_cedente.StylePriority.UseFont = false;
            this.lconta_cedente.StylePriority.UseTextAlignment = false;
            this.lconta_cedente.Text = "lconta_cedente";
            this.lconta_cedente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lconta_cedente.WordWrap = false;
            // 
            // ldatavencimento
            // 
            this.ldatavencimento.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldatavencimento.ForeColor = System.Drawing.Color.Black;
            this.ldatavencimento.LocationFloat = new DevExpress.Utils.PointFloat(379.8337F, 1.999991F);
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
            // lvenda_localizada
            // 
            this.lvenda_localizada.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvenda_localizada.ForeColor = System.Drawing.Color.Black;
            this.lvenda_localizada.LocationFloat = new DevExpress.Utils.PointFloat(692.3336F, 1.083342F);
            this.lvenda_localizada.Name = "lvenda_localizada";
            this.lvenda_localizada.NullValueText = " ";
            this.lvenda_localizada.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvenda_localizada.SizeF = new System.Drawing.SizeF(40.49988F, 9.999999F);
            this.lvenda_localizada.StylePriority.UseBackColor = false;
            this.lvenda_localizada.StylePriority.UseFont = false;
            this.lvenda_localizada.StylePriority.UseTextAlignment = false;
            this.lvenda_localizada.Text = "lvenda_localizada";
            this.lvenda_localizada.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lvenda_localizada.WordWrap = false;
            // 
            // lvlrpagamento
            // 
            this.lvlrpagamento.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrpagamento.ForeColor = System.Drawing.Color.Black;
            this.lvlrpagamento.LocationFloat = new DevExpress.Utils.PointFloat(612.8335F, 1.083342F);
            this.lvlrpagamento.Name = "lvlrpagamento";
            this.lvlrpagamento.NullValueText = " ";
            this.lvlrpagamento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrpagamento.SizeF = new System.Drawing.SizeF(79.50006F, 9.999998F);
            this.lvlrpagamento.StylePriority.UseBackColor = false;
            this.lvlrpagamento.StylePriority.UseFont = false;
            this.lvlrpagamento.Text = "lvlrpagamento";
            this.lvlrpagamento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlrpagamento.WordWrap = false;
            // 
            // lidentificador
            // 
            this.lidentificador.Font = new System.Drawing.Font("Calibri", 7F);
            this.lidentificador.ForeColor = System.Drawing.Color.Black;
            this.lidentificador.LocationFloat = new DevExpress.Utils.PointFloat(78.63167F, 2.041667F);
            this.lidentificador.Name = "lidentificador";
            this.lidentificador.NullValueText = " ";
            this.lidentificador.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lidentificador.SizeF = new System.Drawing.SizeF(71.36852F, 10F);
            this.lidentificador.StylePriority.UseBackColor = false;
            this.lidentificador.StylePriority.UseFont = false;
            this.lidentificador.Text = "lidentificador";
            this.lidentificador.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lidentificador.WordWrap = false;
            // 
            // lid_venda
            // 
            this.lid_venda.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lid_venda.ForeColor = System.Drawing.Color.Black;
            this.lid_venda.LocationFloat = new DevExpress.Utils.PointFloat(0.0001509984F, 2.041667F);
            this.lid_venda.Name = "lid_venda";
            this.lid_venda.NullValueText = " ";
            this.lid_venda.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lid_venda.SizeF = new System.Drawing.SizeF(78.63151F, 10F);
            this.lid_venda.StylePriority.UseBackColor = false;
            this.lid_venda.StylePriority.UseFont = false;
            this.lid_venda.Text = "lid_venda";
            this.lid_venda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lid_venda.WordWrap = false;
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
            this.ltitulorelatorio.Text = "RELATÓRIO COBRANÇA NÃO BANCÁRIA";
            this.ltitulorelatorio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // grupocabecalho
            // 
            this.grupocabecalho.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.xrLabel20,
            this.xrLabel16,
            this.xrLabel14,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel17,
            this.xrLabel15,
            this.xrLabel3,
            this.xrLabel18,
            this.xrLabel26});
            this.grupocabecalho.HeightF = 15.08331F;
            this.grupocabecalho.Level = 1;
            this.grupocabecalho.Name = "grupocabecalho";
            this.grupocabecalho.RepeatEveryPage = true;
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
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(913.3335F, 0F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(80F, 13F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseBorderColor = false;
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Diferença";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(733.3335F, 0F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(90F, 13F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseBorderColor = false;
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseForeColor = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "Vlr.Parcela Sist.";
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
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(692.8335F, 0F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(40.49988F, 13F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseBorderColor = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Venda";
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
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(542.8335F, 0F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(70F, 13F);
            this.xrLabel14.StylePriority.UseBackColor = false;
            this.xrLabel14.StylePriority.UseBorderColor = false;
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Juros";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(200.5001F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(178.8137F, 13F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseBorderColor = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Cedente";
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
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(612.8335F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(80F, 13F);
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
            this.xrLabel7.SizeF = new System.Drawing.SizeF(49.99997F, 13F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Plano";
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
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(379.3138F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(70.51987F, 13F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Vencimento";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(993.3335F, 0F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(55.6665F, 13F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Parcela_ID";
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
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(449.8336F, 0F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(92.99991F, 13F);
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
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(823.3335F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(90F, 13F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Vlr.Parc.Corr.";
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
            this.xrLabel18.SizeF = new System.Drawing.SizeF(78.63173F, 13F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseBorderColor = false;
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseForeColor = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "ID Venda";
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
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(78.6319F, 0F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(71.36829F, 13F);
            this.xrLabel26.StylePriority.UseBackColor = false;
            this.xrLabel26.StylePriority.UseBorderColor = false;
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseForeColor = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.Text = "Identificador";
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // grupofiltros
            // 
            this.grupofiltros.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lfdiferenca,
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
            this.grupofiltros.Level = 2;
            this.grupofiltros.Name = "grupofiltros";
            // 
            // lfdiferenca
            // 
            this.lfdiferenca.LocationFloat = new DevExpress.Utils.PointFloat(658.7499F, 43.74999F);
            this.lfdiferenca.Name = "lfdiferenca";
            this.lfdiferenca.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfdiferenca.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lfdiferenca.StylePriority.UseTextAlignment = false;
            this.lfdiferenca.Text = "lfdiferenca";
            this.lfdiferenca.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(578.5199F, 43.74999F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(78F, 20F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Diferença:";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lfgrupounidade
            // 
            this.lfgrupounidade.LocationFloat = new DevExpress.Utils.PointFloat(81.23019F, 43.00001F);
            this.lfgrupounidade.Name = "lfgrupounidade";
            this.lfgrupounidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfgrupounidade.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
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
            this.lfperiodo.LocationFloat = new DevExpress.Utils.PointFloat(658.7499F, 21.99999F);
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
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(578.5199F, 21.99999F);
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
            this.lfcontacorrente.LocationFloat = new DevExpress.Utils.PointFloat(658.7499F, 1F);
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
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(578.5198F, 1F);
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
            this.lfgrupo.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
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
            this.lcaminho.LocationFloat = new DevExpress.Utils.PointFloat(4.999995F, 3.999964F);
            this.lcaminho.Name = "lcaminho";
            this.lcaminho.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcaminho.SizeF = new System.Drawing.SizeF(418.7498F, 14F);
            this.lcaminho.StylePriority.UseFont = false;
            this.lcaminho.Text = "Gitano ->SGFin ->Pagamentos ->Relatório Cobrança Não Bancária";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ltotparcela_diferenca,
            this.ltotparcela_corrigida,
            this.xrLine2,
            this.ltotparcelaqtd,
            this.ltotparcela_sistema,
            this.ltotvlr_pgto_total,
            this.ltotvlr_pgto_juros,
            this.ltotvlr_pgto_base,
            this.xrLabel21,
            this.xrLine1});
            this.ReportFooter.HeightF = 39F;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ReportFooter_BeforePrint);
            // 
            // ltotparcela_diferenca
            // 
            this.ltotparcela_diferenca.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotparcela_diferenca.LocationFloat = new DevExpress.Utils.PointFloat(913.3334F, 9.999974F);
            this.ltotparcela_diferenca.Name = "ltotparcela_diferenca";
            this.ltotparcela_diferenca.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotparcela_diferenca.SizeF = new System.Drawing.SizeF(80F, 14F);
            this.ltotparcela_diferenca.StylePriority.UseFont = false;
            this.ltotparcela_diferenca.StylePriority.UseTextAlignment = false;
            this.ltotparcela_diferenca.Text = "ltotparcela_diferenca";
            this.ltotparcela_diferenca.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotparcela_corrigida
            // 
            this.ltotparcela_corrigida.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotparcela_corrigida.LocationFloat = new DevExpress.Utils.PointFloat(823.3335F, 10.00004F);
            this.ltotparcela_corrigida.Name = "ltotparcela_corrigida";
            this.ltotparcela_corrigida.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotparcela_corrigida.SizeF = new System.Drawing.SizeF(90F, 14F);
            this.ltotparcela_corrigida.StylePriority.UseFont = false;
            this.ltotparcela_corrigida.StylePriority.UseTextAlignment = false;
            this.ltotparcela_corrigida.Text = "ltotparcela_corrigida";
            this.ltotparcela_corrigida.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0.0001192093F, 30.45834F);
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
            // ltotparcela_sistema
            // 
            this.ltotparcela_sistema.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotparcela_sistema.LocationFloat = new DevExpress.Utils.PointFloat(733.3335F, 10.00001F);
            this.ltotparcela_sistema.Name = "ltotparcela_sistema";
            this.ltotparcela_sistema.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotparcela_sistema.SizeF = new System.Drawing.SizeF(90F, 14F);
            this.ltotparcela_sistema.StylePriority.UseFont = false;
            this.ltotparcela_sistema.StylePriority.UseTextAlignment = false;
            this.ltotparcela_sistema.Text = "ltotparcela_sistema";
            this.ltotparcela_sistema.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotvlr_pgto_total
            // 
            this.ltotvlr_pgto_total.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotvlr_pgto_total.LocationFloat = new DevExpress.Utils.PointFloat(613.3335F, 10.00001F);
            this.ltotvlr_pgto_total.Name = "ltotvlr_pgto_total";
            this.ltotvlr_pgto_total.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotvlr_pgto_total.SizeF = new System.Drawing.SizeF(79.00012F, 14F);
            this.ltotvlr_pgto_total.StylePriority.UseFont = false;
            this.ltotvlr_pgto_total.StylePriority.UseTextAlignment = false;
            this.ltotvlr_pgto_total.Text = "ltotvlr_pgto_total";
            this.ltotvlr_pgto_total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotvlr_pgto_juros
            // 
            this.ltotvlr_pgto_juros.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotvlr_pgto_juros.LocationFloat = new DevExpress.Utils.PointFloat(543.3334F, 10.00001F);
            this.ltotvlr_pgto_juros.Name = "ltotvlr_pgto_juros";
            this.ltotvlr_pgto_juros.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotvlr_pgto_juros.SizeF = new System.Drawing.SizeF(70.00006F, 14F);
            this.ltotvlr_pgto_juros.StylePriority.UseFont = false;
            this.ltotvlr_pgto_juros.StylePriority.UseTextAlignment = false;
            this.ltotvlr_pgto_juros.Text = "ltotvlr_pgto_juros";
            this.ltotvlr_pgto_juros.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotvlr_pgto_base
            // 
            this.ltotvlr_pgto_base.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotvlr_pgto_base.LocationFloat = new DevExpress.Utils.PointFloat(449.8336F, 10.00001F);
            this.ltotvlr_pgto_base.Name = "ltotvlr_pgto_base";
            this.ltotvlr_pgto_base.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotvlr_pgto_base.SizeF = new System.Drawing.SizeF(92.99991F, 14F);
            this.ltotvlr_pgto_base.StylePriority.UseFont = false;
            this.ltotvlr_pgto_base.StylePriority.UseTextAlignment = false;
            this.ltotvlr_pgto_base.Text = "ltotvlr_pgto_base";
            this.ltotvlr_pgto_base.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
            this.headerdata.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
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
            this.lsubparcela_diferenca,
            this.lsubparcela_corrigida,
            this.lsubparcela_sistema,
            this.lsubvlr_pgto_juros,
            this.lsubvlr_pgto_total,
            this.lrodapedata,
            this.xrLine4,
            this.xrLabel24,
            this.lsubvlr_pgto_base});
            this.footerdata.HeightF = 31.25F;
            this.footerdata.Name = "footerdata";
            this.footerdata.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.footerdata_BeforePrint);
            // 
            // lsubparcela_diferenca
            // 
            this.lsubparcela_diferenca.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubparcela_diferenca.LocationFloat = new DevExpress.Utils.PointFloat(913.3335F, 12.70835F);
            this.lsubparcela_diferenca.Name = "lsubparcela_diferenca";
            this.lsubparcela_diferenca.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubparcela_diferenca.SizeF = new System.Drawing.SizeF(80F, 14F);
            this.lsubparcela_diferenca.StylePriority.UseFont = false;
            this.lsubparcela_diferenca.StylePriority.UseTextAlignment = false;
            this.lsubparcela_diferenca.Text = "lsubparcela_diferenca";
            this.lsubparcela_diferenca.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubparcela_corrigida
            // 
            this.lsubparcela_corrigida.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubparcela_corrigida.LocationFloat = new DevExpress.Utils.PointFloat(823.3335F, 12.70835F);
            this.lsubparcela_corrigida.Name = "lsubparcela_corrigida";
            this.lsubparcela_corrigida.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubparcela_corrigida.SizeF = new System.Drawing.SizeF(90F, 14F);
            this.lsubparcela_corrigida.StylePriority.UseFont = false;
            this.lsubparcela_corrigida.StylePriority.UseTextAlignment = false;
            this.lsubparcela_corrigida.Text = "lsubparcela_corrigida";
            this.lsubparcela_corrigida.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubparcela_sistema
            // 
            this.lsubparcela_sistema.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubparcela_sistema.LocationFloat = new DevExpress.Utils.PointFloat(733.3335F, 12.70835F);
            this.lsubparcela_sistema.Name = "lsubparcela_sistema";
            this.lsubparcela_sistema.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubparcela_sistema.SizeF = new System.Drawing.SizeF(90F, 14F);
            this.lsubparcela_sistema.StylePriority.UseFont = false;
            this.lsubparcela_sistema.StylePriority.UseTextAlignment = false;
            this.lsubparcela_sistema.Text = "lsubparcela_sistema";
            this.lsubparcela_sistema.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubvlr_pgto_juros
            // 
            this.lsubvlr_pgto_juros.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubvlr_pgto_juros.LocationFloat = new DevExpress.Utils.PointFloat(543.3334F, 12.70835F);
            this.lsubvlr_pgto_juros.Name = "lsubvlr_pgto_juros";
            this.lsubvlr_pgto_juros.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubvlr_pgto_juros.SizeF = new System.Drawing.SizeF(70.00006F, 14F);
            this.lsubvlr_pgto_juros.StylePriority.UseFont = false;
            this.lsubvlr_pgto_juros.StylePriority.UseTextAlignment = false;
            this.lsubvlr_pgto_juros.Text = "lsubvlr_pgto_juros";
            this.lsubvlr_pgto_juros.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubvlr_pgto_total
            // 
            this.lsubvlr_pgto_total.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubvlr_pgto_total.LocationFloat = new DevExpress.Utils.PointFloat(613.3335F, 12.70835F);
            this.lsubvlr_pgto_total.Name = "lsubvlr_pgto_total";
            this.lsubvlr_pgto_total.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubvlr_pgto_total.SizeF = new System.Drawing.SizeF(79.99994F, 14F);
            this.lsubvlr_pgto_total.StylePriority.UseFont = false;
            this.lsubvlr_pgto_total.StylePriority.UseTextAlignment = false;
            this.lsubvlr_pgto_total.Text = "lsubvlr_pgto_total";
            this.lsubvlr_pgto_total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
            // lsubvlr_pgto_base
            // 
            this.lsubvlr_pgto_base.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubvlr_pgto_base.LocationFloat = new DevExpress.Utils.PointFloat(449.8337F, 12.70835F);
            this.lsubvlr_pgto_base.Name = "lsubvlr_pgto_base";
            this.lsubvlr_pgto_base.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubvlr_pgto_base.SizeF = new System.Drawing.SizeF(92.49994F, 14F);
            this.lsubvlr_pgto_base.StylePriority.UseFont = false;
            this.lsubvlr_pgto_base.StylePriority.UseTextAlignment = false;
            this.lsubvlr_pgto_base.Text = "lsubvlr_pgto_base";
            this.lsubvlr_pgto_base.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RepPagamentosCobrancaNBancaria
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
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepPagamentosCobrancaNBancaria_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    double subvlr_pgto_base = 0.00;
    double subvlr_pgto_juros = 0.00;
    double subvlr_pgto_total = 0.00;
    double subparcela_sistema = 0.00;
    double subparcela_corrigida = 0.00;
    double subparcela_diferenca = 0.00;
    Int64 subparcelaqtd = 0;
    //
    double totvlr_pgto_base = 0.00;
    double totvlr_pgto_juros = 0.00;
    double totvlr_pgto_total = 0.00;
    double totparcela_sistema = 0.00;
    double totparcela_corrigida = 0.00;
    double totparcela_diferenca = 0.00;
    Int64 totparcelaqtd = 0;
    //

    private void RepPagamentosCobrancaNBancaria_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
        double vlr_pgto_base = Convert.ToDouble(GetCurrentColumnValue("vlr_pgto_base"));
        double vlr_pgto_juros = Convert.ToDouble(GetCurrentColumnValue("vlr_pgto_juros"));
        double vlr_pgto_total = Convert.ToDouble(GetCurrentColumnValue("vlr_pgto_total"));
        double parcela_sistema = Convert.ToDouble(GetCurrentColumnValue("parcela_sistema"));
        double parcela_corrigida = Convert.ToDouble(GetCurrentColumnValue("parcela_corrigida"));
        double parcela_diferenca = Convert.ToDouble(GetCurrentColumnValue("diferenca"));
        //
        subvlr_pgto_base = subvlr_pgto_base + vlr_pgto_base;
        subvlr_pgto_juros = subvlr_pgto_juros + vlr_pgto_juros;
        subvlr_pgto_total = subvlr_pgto_total + vlr_pgto_total;
        subparcela_sistema = subparcela_sistema + parcela_sistema;
        subparcela_corrigida = subparcela_corrigida + parcela_corrigida;
        subparcela_diferenca = subparcela_diferenca + parcela_diferenca;
        //
        totvlr_pgto_base =     totvlr_pgto_base + vlr_pgto_base;
        totvlr_pgto_juros =    totvlr_pgto_juros + vlr_pgto_juros;
        totvlr_pgto_total =    totvlr_pgto_total + vlr_pgto_total;
        totparcela_sistema =   totparcela_sistema + parcela_sistema;
        totparcela_corrigida = totparcela_corrigida + parcela_corrigida;
        totparcela_diferenca = totparcela_diferenca + parcela_diferenca;
        totparcelaqtd++;
        //
    }

    private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //
        ltotvlr_pgto_base.Text = String.Format("{0:N}", Convert.ToDouble(totvlr_pgto_base));
        ltotvlr_pgto_juros.Text = String.Format("{0:N}", Convert.ToDouble(totvlr_pgto_juros));
        ltotvlr_pgto_total.Text = String.Format("{0:N}", Convert.ToDouble(totvlr_pgto_total));
        ltotparcela_sistema.Text = String.Format("{0:N}", Convert.ToDouble(totparcela_sistema));
        ltotparcela_corrigida.Text = String.Format("{0:N}", Convert.ToDouble(totparcela_corrigida));
        ltotparcela_diferenca.Text = String.Format("{0:N}", Convert.ToDouble(totparcela_diferenca));
        ltotparcelaqtd.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(totparcelaqtd));
        //
    }

    private void footerdata_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        lrodapedata.Text = GetCurrentColumnValue("data_pagamento").ToString();
        lrodapedata.Text = Convert.ToDateTime(GetCurrentColumnValue("data_pagamento")).ToShortDateString();
        //
        lsubvlr_pgto_base.Text = String.Format("{0:N}", Convert.ToDouble(subvlr_pgto_base));
        lsubvlr_pgto_juros.Text = String.Format("{0:N}", Convert.ToDouble(subvlr_pgto_juros));
        lsubvlr_pgto_total.Text = String.Format("{0:N}", Convert.ToDouble(subvlr_pgto_total));
        lsubparcela_sistema.Text = String.Format("{0:N}", Convert.ToDouble(subparcela_sistema));
        lsubparcela_corrigida.Text = String.Format("{0:N}", Convert.ToDouble(subparcela_corrigida));
        lsubparcela_diferenca.Text = String.Format("{0:N}", Convert.ToDouble(subparcela_diferenca));
        //
        subvlr_pgto_base = 0.00;
        subvlr_pgto_juros = 0.00;
        subvlr_pgto_total = 0.00;
        subparcela_sistema = 0.00;
        subparcela_corrigida = 0.00;
        subparcela_diferenca = 0.00;
        subparcelaqtd = 0;
        //
    }

    private void headerdata_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        lcabecalhodata.Text = GetCurrentColumnValue("data_pagamento").ToString();
        lcabecalhodata.Text = Convert.ToDateTime(GetCurrentColumnValue("data_pagamento")).ToShortDateString();
        //
    }

}
