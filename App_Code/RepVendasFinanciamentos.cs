using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for RepVendasFinanciamentos
/// </summary>
public class RepVendasFinanciamentos : DevExpress.XtraReports.UI.XtraReport
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
    public XRLabel lsaldocredor;
	public XRLabel lunidade;
	private XRLabel xrLabel3;
	private XRLabel xrLabel15;
    public XRLabel ldatavenda;
	public XRLabel lgrupo;
    private XRLabel xrLabel17;
    private FormattingRule formattingRule1;
    private XRLabel xrLabel5;
	private PageFooterBand PageFooter;
	public XRLabel lcaminho;
    public XRLabel lfgrupo;
    private XRLabel xrLabel1;
    public XRLabel lproprietario;
    public XRLabel lparte;
    private XRLabel xrLabel7;
    public XRLabel lfperiodo;
    private XRLabel xrLabel11;
    public XRLabel lvlrvenda;
    private XRLabel xrLabel8;
    public XRLabel lsaldodevedor;
    public XRLabel lquitado;
    public XRLabel lsaldodevedorativo;
    public XRLabel lsaldocredorativo;
    public XRLabel lrenegociacao;
    private XRLabel xrLabel10;
    private XRLabel xrLabel9;
    private XRLabel xrLabel6;
    private XRLabel xrLabel2;
    private ReportFooterBand ReportFooter;
    private XRLine xrLine4;
    public XRLabel ltotsaldodevedorativo;
    public XRLabel xrLabel21;
    public XRLabel ltotvenda;
    public XRLabel ltotsaldocredor;
    public XRLabel ltotsaldodevedor;
    public XRLabel ltotsaldocredorativo;
    public XRLabel ltotvendaqtd;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

	public RepVendasFinanciamentos()
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
            string resourceFileName = "RepVendasFinanciamentos.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lquitado = new DevExpress.XtraReports.UI.XRLabel();
            this.lsaldodevedorativo = new DevExpress.XtraReports.UI.XRLabel();
            this.lsaldocredorativo = new DevExpress.XtraReports.UI.XRLabel();
            this.lrenegociacao = new DevExpress.XtraReports.UI.XRLabel();
            this.lsaldodevedor = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrvenda = new DevExpress.XtraReports.UI.XRLabel();
            this.lparte = new DevExpress.XtraReports.UI.XRLabel();
            this.lproprietario = new DevExpress.XtraReports.UI.XRLabel();
            this.ldatavenda = new DevExpress.XtraReports.UI.XRLabel();
            this.lgrupo = new DevExpress.XtraReports.UI.XRLabel();
            this.lsaldocredor = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
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
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotvenda = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaldocredor = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaldodevedor = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaldocredorativo = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotvendaqtd = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaldodevedorativo = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lquitado,
            this.lsaldodevedorativo,
            this.lsaldocredorativo,
            this.lrenegociacao,
            this.lsaldodevedor,
            this.lvlrvenda,
            this.lparte,
            this.lproprietario,
            this.ldatavenda,
            this.lgrupo,
            this.lsaldocredor,
            this.lunidade,
            this.lid});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 11.45833F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // lquitado
            // 
            this.lquitado.Font = new System.Drawing.Font("Calibri", 7F);
            this.lquitado.ForeColor = System.Drawing.Color.Black;
            this.lquitado.LocationFloat = new DevExpress.Utils.PointFloat(994.3233F, 1.041667F);
            this.lquitado.Name = "lquitado";
            this.lquitado.NullValueText = " ";
            this.lquitado.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lquitado.SizeF = new System.Drawing.SizeF(54.6767F, 9.999999F);
            this.lquitado.StylePriority.UseBackColor = false;
            this.lquitado.StylePriority.UseFont = false;
            this.lquitado.StylePriority.UseTextAlignment = false;
            this.lquitado.Text = "lquitado";
            this.lquitado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lquitado.WordWrap = false;
            // 
            // lsaldodevedorativo
            // 
            this.lsaldodevedorativo.Font = new System.Drawing.Font("Calibri", 7F);
            this.lsaldodevedorativo.ForeColor = System.Drawing.Color.Black;
            this.lsaldodevedorativo.LocationFloat = new DevExpress.Utils.PointFloat(904.3231F, 1.041667F);
            this.lsaldodevedorativo.Name = "lsaldodevedorativo";
            this.lsaldodevedorativo.NullValueText = " ";
            this.lsaldodevedorativo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsaldodevedorativo.SizeF = new System.Drawing.SizeF(90F, 9.999999F);
            this.lsaldodevedorativo.StylePriority.UseBackColor = false;
            this.lsaldodevedorativo.StylePriority.UseFont = false;
            this.lsaldodevedorativo.Text = "lsaldodevedorativo";
            this.lsaldodevedorativo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lsaldodevedorativo.WordWrap = false;
            // 
            // lsaldocredorativo
            // 
            this.lsaldocredorativo.Font = new System.Drawing.Font("Calibri", 7F);
            this.lsaldocredorativo.ForeColor = System.Drawing.Color.Black;
            this.lsaldocredorativo.LocationFloat = new DevExpress.Utils.PointFloat(814.3232F, 1F);
            this.lsaldocredorativo.Name = "lsaldocredorativo";
            this.lsaldocredorativo.NullValueText = " ";
            this.lsaldocredorativo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsaldocredorativo.SizeF = new System.Drawing.SizeF(90F, 9.999999F);
            this.lsaldocredorativo.StylePriority.UseBackColor = false;
            this.lsaldocredorativo.StylePriority.UseFont = false;
            this.lsaldocredorativo.StylePriority.UseTextAlignment = false;
            this.lsaldocredorativo.Text = "lsaldocredorativo";
            this.lsaldocredorativo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lsaldocredorativo.WordWrap = false;
            // 
            // lrenegociacao
            // 
            this.lrenegociacao.Font = new System.Drawing.Font("Calibri", 7F);
            this.lrenegociacao.ForeColor = System.Drawing.Color.Black;
            this.lrenegociacao.LocationFloat = new DevExpress.Utils.PointFloat(744.1149F, 0.9999911F);
            this.lrenegociacao.Name = "lrenegociacao";
            this.lrenegociacao.NullValueText = " ";
            this.lrenegociacao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lrenegociacao.SizeF = new System.Drawing.SizeF(70.20825F, 9.999999F);
            this.lrenegociacao.StylePriority.UseBackColor = false;
            this.lrenegociacao.StylePriority.UseFont = false;
            this.lrenegociacao.StylePriority.UseTextAlignment = false;
            this.lrenegociacao.Text = "lrenegociacao";
            this.lrenegociacao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lrenegociacao.WordWrap = false;
            // 
            // lsaldodevedor
            // 
            this.lsaldodevedor.Font = new System.Drawing.Font("Calibri", 7F);
            this.lsaldodevedor.ForeColor = System.Drawing.Color.Black;
            this.lsaldodevedor.LocationFloat = new DevExpress.Utils.PointFloat(654.1149F, 1.041667F);
            this.lsaldodevedor.Name = "lsaldodevedor";
            this.lsaldodevedor.NullValueText = " ";
            this.lsaldodevedor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsaldodevedor.SizeF = new System.Drawing.SizeF(90F, 9.999999F);
            this.lsaldodevedor.StylePriority.UseBackColor = false;
            this.lsaldodevedor.StylePriority.UseFont = false;
            this.lsaldodevedor.Text = "lsaldodevedor";
            this.lsaldodevedor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lsaldodevedor.WordWrap = false;
            // 
            // lvlrvenda
            // 
            this.lvlrvenda.Font = new System.Drawing.Font("Calibri", 7F);
            this.lvlrvenda.ForeColor = System.Drawing.Color.Black;
            this.lvlrvenda.LocationFloat = new DevExpress.Utils.PointFloat(474.1149F, 0.9999911F);
            this.lvlrvenda.Name = "lvlrvenda";
            this.lvlrvenda.NullValueText = " ";
            this.lvlrvenda.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrvenda.SizeF = new System.Drawing.SizeF(90F, 9.999999F);
            this.lvlrvenda.StylePriority.UseBackColor = false;
            this.lvlrvenda.StylePriority.UseFont = false;
            this.lvlrvenda.StylePriority.UseTextAlignment = false;
            this.lvlrvenda.Text = "lvlrvenda";
            this.lvlrvenda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lvlrvenda.WordWrap = false;
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
            // lproprietario
            // 
            this.lproprietario.Font = new System.Drawing.Font("Calibri", 7F);
            this.lproprietario.ForeColor = System.Drawing.Color.Black;
            this.lproprietario.LocationFloat = new DevExpress.Utils.PointFloat(200.0002F, 0.9999911F);
            this.lproprietario.Name = "lproprietario";
            this.lproprietario.NullValueText = " ";
            this.lproprietario.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lproprietario.SizeF = new System.Drawing.SizeF(211.2496F, 9.999999F);
            this.lproprietario.StylePriority.UseBackColor = false;
            this.lproprietario.StylePriority.UseFont = false;
            this.lproprietario.Text = "lproprietario";
            this.lproprietario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lproprietario.WordWrap = false;
            // 
            // ldatavenda
            // 
            this.ldatavenda.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldatavenda.ForeColor = System.Drawing.Color.Black;
            this.ldatavenda.LocationFloat = new DevExpress.Utils.PointFloat(411.2498F, 0.9999911F);
            this.ldatavenda.Name = "ldatavenda";
            this.ldatavenda.NullValueText = " ";
            this.ldatavenda.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldatavenda.SizeF = new System.Drawing.SizeF(62.86508F, 9.999999F);
            this.ldatavenda.StylePriority.UseBackColor = false;
            this.ldatavenda.StylePriority.UseFont = false;
            this.ldatavenda.Text = "ldatavenda";
            this.ldatavenda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ldatavenda.WordWrap = false;
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
            // lsaldocredor
            // 
            this.lsaldocredor.Font = new System.Drawing.Font("Calibri", 7F);
            this.lsaldocredor.ForeColor = System.Drawing.Color.Black;
            this.lsaldocredor.LocationFloat = new DevExpress.Utils.PointFloat(564.1148F, 1.041667F);
            this.lsaldocredor.Name = "lsaldocredor";
            this.lsaldocredor.NullValueText = " ";
            this.lsaldocredor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsaldocredor.SizeF = new System.Drawing.SizeF(90F, 9.999999F);
            this.lsaldocredor.StylePriority.UseBackColor = false;
            this.lsaldocredor.StylePriority.UseFont = false;
            this.lsaldocredor.StylePriority.UseTextAlignment = false;
            this.lsaldocredor.Text = "lsaldocredor";
            this.lsaldocredor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lsaldocredor.WordWrap = false;
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
            this.ltitulorelatorio.Text = "RELATÓRIO SALDOS FINANCIAMENTOS";
            this.ltitulorelatorio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // grupocabecalho
            // 
            this.grupocabecalho.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel6,
            this.xrLabel2,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel5,
            this.xrLabel17,
            this.xrLabel15,
            this.xrLabel3,
            this.xrLabel18,
            this.xrLabel26,
            this.xrLabel19});
            this.grupocabecalho.HeightF = 15.08331F;
            this.grupocabecalho.Name = "grupocabecalho";
            this.grupocabecalho.RepeatEveryPage = true;
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
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(994.3232F, 0F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(54.67676F, 13F);
            this.xrLabel10.StylePriority.UseBackColor = false;
            this.xrLabel10.StylePriority.UseBorderColor = false;
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseForeColor = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Quitado";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(904.3232F, 0F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(90F, 13F);
            this.xrLabel9.StylePriority.UseBackColor = false;
            this.xrLabel9.StylePriority.UseBorderColor = false;
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseForeColor = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Sd. Devedor Ativo";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(814.3232F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(90F, 13F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Sd. Credor Ativo";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(744.1149F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(70.20831F, 13F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Renegociação";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(474.1149F, 0F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(90F, 13F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Vlr. Venda";
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
            this.xrLabel5.SizeF = new System.Drawing.SizeF(211.2496F, 13F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Proprietário";
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
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(654.1149F, 0F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(90F, 13F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Sd. Devedor Total";
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
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(411.2498F, 0F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(62.86514F, 13F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseBorderColor = false;
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "Data Venda";
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
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(564.1149F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(90F, 13F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Sd. Credor Total";
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
            this.lfperiodo.LocationFloat = new DevExpress.Utils.PointFloat(656.7132F, 0.9999911F);
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
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(579.4832F, 0.9999911F);
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
            this.lfgrupo.LocationFloat = new DevExpress.Utils.PointFloat(81.23001F, 21.99999F);
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
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(4.000004F, 21.99999F);
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
            this.lcaminho.LocationFloat = new DevExpress.Utils.PointFloat(4.999995F, 3.999996F);
            this.lcaminho.Name = "lcaminho";
            this.lcaminho.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcaminho.SizeF = new System.Drawing.SizeF(406.2498F, 14F);
            this.lcaminho.StylePriority.UseFont = false;
            this.lcaminho.Text = "Gitano ->SGFin ->Empresa ->Relatório Saldos Financiamentos";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ltotsaldodevedorativo,
            this.xrLabel21,
            this.ltotvenda,
            this.ltotsaldocredor,
            this.ltotsaldodevedor,
            this.ltotsaldocredorativo,
            this.ltotvendaqtd,
            this.xrLine4});
            this.ReportFooter.HeightF = 27.08333F;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ReportFooter_BeforePrint);
            // 
            // xrLine4
            // 
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1.5F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
            // 
            // xrLabel21
            // 
            this.xrLabel21.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(1.00015F, 10.00001F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(198.0002F, 14F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Totais Gerais (R$):";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotvenda
            // 
            this.ltotvenda.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotvenda.LocationFloat = new DevExpress.Utils.PointFloat(474.1149F, 10.00001F);
            this.ltotvenda.Name = "ltotvenda";
            this.ltotvenda.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotvenda.SizeF = new System.Drawing.SizeF(90F, 14F);
            this.ltotvenda.StylePriority.UseFont = false;
            this.ltotvenda.StylePriority.UseTextAlignment = false;
            this.ltotvenda.Text = "ltotvenda";
            this.ltotvenda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaldocredor
            // 
            this.ltotsaldocredor.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldocredor.LocationFloat = new DevExpress.Utils.PointFloat(564.1149F, 10.00001F);
            this.ltotsaldocredor.Name = "ltotsaldocredor";
            this.ltotsaldocredor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldocredor.SizeF = new System.Drawing.SizeF(90.00006F, 14F);
            this.ltotsaldocredor.StylePriority.UseFont = false;
            this.ltotsaldocredor.StylePriority.UseTextAlignment = false;
            this.ltotsaldocredor.Text = "ltotsaldocredor";
            this.ltotsaldocredor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaldodevedor
            // 
            this.ltotsaldodevedor.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldodevedor.LocationFloat = new DevExpress.Utils.PointFloat(654.1149F, 10.00001F);
            this.ltotsaldodevedor.Name = "ltotsaldodevedor";
            this.ltotsaldodevedor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldodevedor.SizeF = new System.Drawing.SizeF(90F, 14F);
            this.ltotsaldodevedor.StylePriority.UseFont = false;
            this.ltotsaldodevedor.StylePriority.UseTextAlignment = false;
            this.ltotsaldodevedor.Text = "ltotsaldodevedor";
            this.ltotsaldodevedor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaldocredorativo
            // 
            this.ltotsaldocredorativo.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldocredorativo.LocationFloat = new DevExpress.Utils.PointFloat(814.3232F, 10.00001F);
            this.ltotsaldocredorativo.Name = "ltotsaldocredorativo";
            this.ltotsaldocredorativo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldocredorativo.SizeF = new System.Drawing.SizeF(90F, 14F);
            this.ltotsaldocredorativo.StylePriority.UseFont = false;
            this.ltotsaldocredorativo.StylePriority.UseTextAlignment = false;
            this.ltotsaldocredorativo.Text = "ltotsaldocredorativo";
            this.ltotsaldocredorativo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotvendaqtd
            // 
            this.ltotvendaqtd.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotvendaqtd.LocationFloat = new DevExpress.Utils.PointFloat(199.0004F, 10.00001F);
            this.ltotvendaqtd.Name = "ltotvendaqtd";
            this.ltotvendaqtd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotvendaqtd.SizeF = new System.Drawing.SizeF(70F, 14F);
            this.ltotvendaqtd.StylePriority.UseFont = false;
            this.ltotvendaqtd.StylePriority.UseTextAlignment = false;
            this.ltotvendaqtd.Text = "ltotvendaqtd";
            this.ltotvendaqtd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaldodevedorativo
            // 
            this.ltotsaldodevedorativo.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldodevedorativo.LocationFloat = new DevExpress.Utils.PointFloat(904.3231F, 10.00001F);
            this.ltotsaldodevedorativo.Name = "ltotsaldodevedorativo";
            this.ltotsaldodevedorativo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldodevedorativo.SizeF = new System.Drawing.SizeF(90F, 14F);
            this.ltotsaldodevedorativo.StylePriority.UseFont = false;
            this.ltotsaldodevedorativo.StylePriority.UseTextAlignment = false;
            this.ltotsaldodevedorativo.Text = "ltotsaldodevedorativo";
            this.ltotsaldodevedorativo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RepVendasFinanciamentos
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
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepVendasFinanciamentos_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

    #endregion

    //
    Int64 totvendaqtd = 0;
    double totvenda = 0.00;
    double totsaldocredor = 0.00;
    double totsaldodevedor = 0.00;
    double totsaldocredorativo = 0.00;
    double totsaldodevedorativo = 0.00;
    //

    private void RepVendasFinanciamentos_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
        string unidade = GetCurrentColumnValue("unidade").ToString().Trim();
        string parte = GetCurrentColumnValue("parte").ToString().Trim();
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
        string quitado = GetCurrentColumnValue("quitado").ToString().Trim();
        lquitado.Text = "Não";
        if (quitado == "True")
        {
            lquitado.Text = "Sim";
        }
        //
        Double saldocredorativo = Convert.ToDouble(GetCurrentColumnValue("saldocredorativo"));
        Double saldodevedorativo = Convert.ToDouble(GetCurrentColumnValue("saldodevedorativo"));
        Boolean renegociação = uVendas.TemRenegociacao(produto, grupo, unidade, parte);
        lrenegociacao.Text = "Não";
        if (renegociação)
        {
            lrenegociacao.Text = "Sim";
            if ((saldodevedorativo != 0) && (saldocredorativo != 0))
            {
                lsaldocredorativo.Text = String.Format("{0:N}", saldocredorativo);
                lsaldodevedorativo.Text = String.Format("{0:N}", saldodevedorativo);
            }
            else
            {
                lsaldocredorativo.Text = " ";
                lsaldodevedorativo.Text = " ";
            }
        }
        //
        totvendaqtd = totvendaqtd + 1;
        totvenda = totvenda + Convert.ToDouble(GetCurrentColumnValue("vlr_venda"));
        totsaldocredor = totsaldocredor + Convert.ToDouble(GetCurrentColumnValue("saldocredor"));
        totsaldodevedor = totsaldodevedor + Convert.ToDouble(GetCurrentColumnValue("saldodevedor"));
        totsaldocredorativo = totsaldocredorativo + Convert.ToDouble(GetCurrentColumnValue("saldocredorativo"));
        totsaldodevedorativo = totsaldodevedorativo + Convert.ToDouble(GetCurrentColumnValue("saldodevedorativo"));
        //
    }

    private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //
        ltotvendaqtd.Text = String.Format("{0:################0;-################0;##0}", Convert.ToInt64(totvendaqtd));
        ltotvenda.Text = String.Format("{0:N}", Convert.ToDouble(totvenda));
        ltotsaldodevedor.Text = String.Format("{0:N}", Convert.ToDouble(totsaldodevedor));
        ltotsaldocredor.Text = String.Format("{0:N}", Convert.ToDouble(totsaldocredor));
        ltotsaldodevedorativo.Text = String.Format("{0:N}", Convert.ToDouble(totsaldodevedorativo));
        ltotsaldocredorativo.Text = String.Format("{0:N}", Convert.ToDouble(totsaldocredorativo));

    }
}
