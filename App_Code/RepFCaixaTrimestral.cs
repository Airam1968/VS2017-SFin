using DevExpress.XtraReports.UI;
using System;

/// <summary>
/// Summary description for RepFCaixaTrimestral
/// </summary>
public class RepFCaixaTrimestral : DevExpress.XtraReports.UI.XtraReport
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
    private XRLabel xrLabel4;
    public XRLabel ltempresa;
    public XRLabel lfproduto;
    public XRLabel ltusuario;
    private XRPictureBox xrPictureBox1;
    private XRControlStyle xrControlStyle1;
    private XRControlStyle xrControlStyle2;
    public XRLabel lclasse;
    public XRLabel ldescricao;
    public XRLabel lpercentual;
    private FormattingRule formattingRule1;
    public XRLabel xrLabel5;
    private PageFooterBand PageFooter;
    public XRLabel lcaminho;
    public XRLabel lmes1;
    public XRLabel xrLabel6;
    public XRLabel xrLabel7;
    private XRLine xrLine1;
    public XRLabel lfcontacorrente;
    private XRLabel xrLabel10;
    public XRLabel lftrimestre;
    private XRLabel xrLabel11;
    public XRLabel lmes3;
    private XRLabel xrLabel8;
    public XRLabel lflancamentos;
    private XRLabel xrLabel2;
    private XRLabel xrLabel16;
    private XRLabel xrLabel14;
    public XRLabel lmes2;
    public XRLabel ltotais;
    private ReportFooterBand ReportFooter;
    public XRLabel ltotal;
    public XRLabel ltotmes3;
    public XRLabel ltotmes1;
    public XRLabel xrLabel3;
    public XRLabel ltotmes2;
    public GroupHeaderBand headertipo;
    public GroupFooterBand footertipo;
    public XRLabel lcabecalhotipo;
    public XRLabel lsubmes1;
    public XRLabel xrLabel24;
    public XRLabel lsubmes3;
    private XRLine xrLine2;
    public XRLabel lsubmes2;
    public XRLabel lsubtotal;
    public XRLabel lfano;
    private XRLabel xrLabel17;
    public XRLabel lsaldo;
    public XRLabel xrLabel9;
    private XRLine xrLine3;
    public XRLabel ltotsaldofim3;
    public XRLabel ltotsaldofim1;
    public XRLabel xrLabel28;
    public XRLabel ltotsaldofim2;
    public XRLabel ltotsaimes1;
    public XRLabel ltotsaimes3;
    public XRLabel ltotsaimes2;
    public XRLabel xrLabel25;
    public XRLabel ltotentmes3;
    public XRLabel ltotentmes1;
    public XRLabel xrLabel19;
    public XRLabel ltotentmes2;
    public XRLabel xrLabel15;
    public XRLabel lsaldoini2;
    public XRLabel lsaldoini1;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public RepFCaixaTrimestral()
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
            //string resourceFileName = "RepFCaixaTrimestral.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ltotais = new DevExpress.XtraReports.UI.XRLabel();
            this.lmes2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lmes3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lmes1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ldescricao = new DevExpress.XtraReports.UI.XRLabel();
            this.lpercentual = new DevExpress.XtraReports.UI.XRLabel();
            this.lclasse = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.grupofiltros = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lfano = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.lflancamentos = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lftrimestre = new DevExpress.XtraReports.UI.XRLabel();
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
            this.lsaldoini2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lsaldoini1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.ltotsaldofim3 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaldofim1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaldofim2 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaimes1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaimes3 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotsaimes2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotentmes3 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotentmes1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotentmes2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.lsaldo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotmes3 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotmes1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotmes2 = new DevExpress.XtraReports.UI.XRLabel();
            this.ltotal = new DevExpress.XtraReports.UI.XRLabel();
            this.headertipo = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lcabecalhotipo = new DevExpress.XtraReports.UI.XRLabel();
            this.footertipo = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.lsubtotal = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubmes1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.lsubmes3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.lsubmes2 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ltotais,
            this.lmes2,
            this.lmes3,
            this.lmes1,
            this.ldescricao,
            this.lpercentual,
            this.lclasse});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 13.54167F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // ltotais
            // 
            this.ltotais.Font = new System.Drawing.Font("Calibri", 7F);
            this.ltotais.ForeColor = System.Drawing.Color.Black;
            this.ltotais.LocationFloat = new DevExpress.Utils.PointFloat(775.0004F, 1.041667F);
            this.ltotais.Name = "ltotais";
            this.ltotais.NullValueText = " ";
            this.ltotais.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotais.SizeF = new System.Drawing.SizeF(172.4998F, 10F);
            this.ltotais.StylePriority.UseBackColor = false;
            this.ltotais.StylePriority.UseFont = false;
            this.ltotais.Text = "ltotais";
            this.ltotais.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.ltotais.WordWrap = false;
            // 
            // lmes2
            // 
            this.lmes2.Font = new System.Drawing.Font("Calibri", 7F);
            this.lmes2.ForeColor = System.Drawing.Color.Black;
            this.lmes2.LocationFloat = new DevExpress.Utils.PointFloat(500.0003F, 0.9999911F);
            this.lmes2.Name = "lmes2";
            this.lmes2.NullValueText = " ";
            this.lmes2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lmes2.SizeF = new System.Drawing.SizeF(137.5001F, 9.999999F);
            this.lmes2.StylePriority.UseBackColor = false;
            this.lmes2.StylePriority.UseFont = false;
            this.lmes2.StylePriority.UseTextAlignment = false;
            this.lmes2.Text = "lmes2";
            this.lmes2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lmes2.WordWrap = false;
            // 
            // lmes3
            // 
            this.lmes3.Font = new System.Drawing.Font("Calibri", 7F);
            this.lmes3.ForeColor = System.Drawing.Color.Black;
            this.lmes3.LocationFloat = new DevExpress.Utils.PointFloat(637.5004F, 1.041667F);
            this.lmes3.Name = "lmes3";
            this.lmes3.NullValueText = " ";
            this.lmes3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lmes3.SizeF = new System.Drawing.SizeF(137.5F, 9.999999F);
            this.lmes3.StylePriority.UseBackColor = false;
            this.lmes3.StylePriority.UseFont = false;
            this.lmes3.StylePriority.UseTextAlignment = false;
            this.lmes3.Text = "lmes3";
            this.lmes3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lmes3.WordWrap = false;
            // 
            // lmes1
            // 
            this.lmes1.Font = new System.Drawing.Font("Calibri", 7F);
            this.lmes1.ForeColor = System.Drawing.Color.Black;
            this.lmes1.LocationFloat = new DevExpress.Utils.PointFloat(362.5002F, 0.9999911F);
            this.lmes1.Name = "lmes1";
            this.lmes1.NullValueText = " ";
            this.lmes1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lmes1.SizeF = new System.Drawing.SizeF(137.5001F, 9.999999F);
            this.lmes1.StylePriority.UseBackColor = false;
            this.lmes1.StylePriority.UseFont = false;
            this.lmes1.StylePriority.UseTextAlignment = false;
            this.lmes1.Text = "lmes1";
            this.lmes1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lmes1.WordWrap = false;
            // 
            // ldescricao
            // 
            this.ldescricao.Font = new System.Drawing.Font("Calibri", 7F);
            this.ldescricao.ForeColor = System.Drawing.Color.Black;
            this.ldescricao.LocationFloat = new DevExpress.Utils.PointFloat(81.23018F, 1.041667F);
            this.ldescricao.Name = "ldescricao";
            this.ldescricao.NullValueText = " ";
            this.ldescricao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldescricao.SizeF = new System.Drawing.SizeF(281.27F, 9.999999F);
            this.ldescricao.StylePriority.UseBackColor = false;
            this.ldescricao.StylePriority.UseFont = false;
            this.ldescricao.StylePriority.UseTextAlignment = false;
            this.ldescricao.Text = "ldescricao";
            this.ldescricao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.ldescricao.WordWrap = false;
            // 
            // lpercentual
            // 
            this.lpercentual.Font = new System.Drawing.Font("Calibri", 7F);
            this.lpercentual.ForeColor = System.Drawing.Color.Black;
            this.lpercentual.LocationFloat = new DevExpress.Utils.PointFloat(947.5002F, 1F);
            this.lpercentual.Name = "lpercentual";
            this.lpercentual.NullValueText = " ";
            this.lpercentual.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lpercentual.SizeF = new System.Drawing.SizeF(100.0001F, 9.999999F);
            this.lpercentual.StylePriority.UseBackColor = false;
            this.lpercentual.StylePriority.UseFont = false;
            this.lpercentual.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lpercentual.WordWrap = false;
            // 
            // lclasse
            // 
            this.lclasse.Font = new System.Drawing.Font("Calibri", 6.5F);
            this.lclasse.ForeColor = System.Drawing.Color.Black;
            this.lclasse.LocationFloat = new DevExpress.Utils.PointFloat(0.0001509984F, 1.041667F);
            this.lclasse.Name = "lclasse";
            this.lclasse.NullValueText = " ";
            this.lclasse.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lclasse.SizeF = new System.Drawing.SizeF(78.63151F, 10F);
            this.lclasse.StylePriority.UseBackColor = false;
            this.lclasse.StylePriority.UseFont = false;
            this.lclasse.Text = "lclasse";
            this.lclasse.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lclasse.WordWrap = false;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0.0001192093F, 2F);
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
            this.ltitulorelatorio.Text = "RELATÓRIO FLUXO DE CAIXA - TRIMESTRAL";
            this.ltitulorelatorio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // grupocabecalho
            // 
            this.grupocabecalho.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16,
            this.xrLabel14,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel18});
            this.grupocabecalho.HeightF = 15.08334F;
            this.grupocabecalho.Level = 1;
            this.grupocabecalho.Name = "grupocabecalho";
            this.grupocabecalho.RepeatEveryPage = true;
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
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(78.63165F, 0F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(283.8686F, 13F);
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
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(775.0004F, 0F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(172.4998F, 13F);
            this.xrLabel14.StylePriority.UseBackColor = false;
            this.xrLabel14.StylePriority.UseBorderColor = false;
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseForeColor = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Totais";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.xrLabel8.Text = "%";
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
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(500.0003F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(137.5001F, 13F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseForeColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Mes 2";
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
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(637.5004F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(137.5F, 13F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseForeColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Mes 3";
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
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(362.5002F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(137.5001F, 13F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Mes 1";
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
            this.xrLabel18.SizeF = new System.Drawing.SizeF(78.6315F, 13F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseBorderColor = false;
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseForeColor = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Classe R\\D";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // grupofiltros
            // 
            this.grupofiltros.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lfano,
            this.xrLabel17,
            this.lflancamentos,
            this.xrLabel2,
            this.lftrimestre,
            this.xrLabel11,
            this.lfcontacorrente,
            this.xrLabel10,
            this.lfproduto,
            this.xrLabel4});
            this.grupofiltros.HeightF = 65.625F;
            this.grupofiltros.Level = 2;
            this.grupofiltros.Name = "grupofiltros";
            // 
            // lfano
            // 
            this.lfano.LocationFloat = new DevExpress.Utils.PointFloat(658.7499F, 21.99999F);
            this.lfano.Name = "lfano";
            this.lfano.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lfano.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lfano.StylePriority.UseTextAlignment = false;
            this.lfano.Text = "lfano";
            this.lfano.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(568.0417F, 21.99999F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(88.47815F, 20F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Ano:";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lflancamentos
            // 
            this.lflancamentos.LocationFloat = new DevExpress.Utils.PointFloat(658.7498F, 42.99998F);
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
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(568.0417F, 42.99998F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(88.47809F, 20F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Lançamentos:";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lftrimestre
            // 
            this.lftrimestre.LocationFloat = new DevExpress.Utils.PointFloat(658.7499F, 0.9999911F);
            this.lftrimestre.Name = "lftrimestre";
            this.lftrimestre.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lftrimestre.SizeF = new System.Drawing.SizeF(377.2502F, 20F);
            this.lftrimestre.StylePriority.UseTextAlignment = false;
            this.lftrimestre.Text = "lftrimestre";
            this.lftrimestre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            this.xrLabel11.Text = "Trimestre:";
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
            this.lcaminho.LocationFloat = new DevExpress.Utils.PointFloat(4.999995F, 3.999964F);
            this.lcaminho.Name = "lcaminho";
            this.lcaminho.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcaminho.SizeF = new System.Drawing.SizeF(384.3748F, 14F);
            this.lcaminho.StylePriority.UseFont = false;
            this.lcaminho.Text = "Gitano ->SGFin ->Fluxo de Caixa ->Relatório Fluxo de Caixa - Trimestral";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lsaldoini2,
            this.lsaldoini1,
            this.xrLine3,
            this.ltotsaldofim3,
            this.ltotsaldofim1,
            this.xrLabel28,
            this.ltotsaldofim2,
            this.ltotsaimes1,
            this.ltotsaimes3,
            this.ltotsaimes2,
            this.xrLabel25,
            this.ltotentmes3,
            this.ltotentmes1,
            this.xrLabel19,
            this.ltotentmes2,
            this.xrLabel15,
            this.lsaldo,
            this.xrLabel9,
            this.ltotmes3,
            this.ltotmes1,
            this.xrLabel3,
            this.ltotmes2,
            this.ltotal,
            this.xrLine1});
            this.ReportFooter.HeightF = 118.75F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ReportFooter_BeforePrint);
            // 
            // lsaldoini2
            // 
            this.lsaldoini2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsaldoini2.LocationFloat = new DevExpress.Utils.PointFloat(637.5004F, 47.68753F);
            this.lsaldoini2.Name = "lsaldoini2";
            this.lsaldoini2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsaldoini2.SizeF = new System.Drawing.SizeF(137.4999F, 14F);
            this.lsaldoini2.StylePriority.UseFont = false;
            this.lsaldoini2.StylePriority.UseTextAlignment = false;
            this.lsaldoini2.Text = "lsaldoini2";
            this.lsaldoini2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsaldoini1
            // 
            this.lsaldoini1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsaldoini1.LocationFloat = new DevExpress.Utils.PointFloat(500.0005F, 47.68753F);
            this.lsaldoini1.Name = "lsaldoini1";
            this.lsaldoini1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsaldoini1.SizeF = new System.Drawing.SizeF(137.5F, 14F);
            this.lsaldoini1.StylePriority.UseFont = false;
            this.lsaldoini1.StylePriority.UseTextAlignment = false;
            this.lsaldoini1.Text = "lsaldoini1";
            this.lsaldoini1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 107.625F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
            // 
            // ltotsaldofim3
            // 
            this.ltotsaldofim3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldofim3.LocationFloat = new DevExpress.Utils.PointFloat(637.5004F, 92.68758F);
            this.ltotsaldofim3.Name = "ltotsaldofim3";
            this.ltotsaldofim3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldofim3.SizeF = new System.Drawing.SizeF(137.4999F, 14F);
            this.ltotsaldofim3.StylePriority.UseFont = false;
            this.ltotsaldofim3.StylePriority.UseTextAlignment = false;
            this.ltotsaldofim3.Text = "ltotsaldofim3";
            this.ltotsaldofim3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaldofim1
            // 
            this.ltotsaldofim1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldofim1.LocationFloat = new DevExpress.Utils.PointFloat(362.5002F, 92.68758F);
            this.ltotsaldofim1.Name = "ltotsaldofim1";
            this.ltotsaldofim1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldofim1.SizeF = new System.Drawing.SizeF(137.5002F, 14F);
            this.ltotsaldofim1.StylePriority.UseFont = false;
            this.ltotsaldofim1.StylePriority.UseTextAlignment = false;
            this.ltotsaldofim1.Text = "ltotsaldofim1";
            this.ltotsaldofim1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel28
            // 
            this.xrLabel28.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(0F, 92.68758F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(360.5001F, 14F);
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "Saldos Finais:";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaldofim2
            // 
            this.ltotsaldofim2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaldofim2.LocationFloat = new DevExpress.Utils.PointFloat(500.0005F, 92.68758F);
            this.ltotsaldofim2.Name = "ltotsaldofim2";
            this.ltotsaldofim2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaldofim2.SizeF = new System.Drawing.SizeF(137.5F, 14F);
            this.ltotsaldofim2.StylePriority.UseFont = false;
            this.ltotsaldofim2.StylePriority.UseTextAlignment = false;
            this.ltotsaldofim2.Text = "ltotsaldofim2";
            this.ltotsaldofim2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaimes1
            // 
            this.ltotsaimes1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaimes1.LocationFloat = new DevExpress.Utils.PointFloat(362.5002F, 77.68756F);
            this.ltotsaimes1.Name = "ltotsaimes1";
            this.ltotsaimes1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaimes1.SizeF = new System.Drawing.SizeF(137.5002F, 14F);
            this.ltotsaimes1.StylePriority.UseFont = false;
            this.ltotsaimes1.StylePriority.UseTextAlignment = false;
            this.ltotsaimes1.Text = "ltotsaimes1";
            this.ltotsaimes1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaimes3
            // 
            this.ltotsaimes3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaimes3.LocationFloat = new DevExpress.Utils.PointFloat(637.5004F, 77.68756F);
            this.ltotsaimes3.Name = "ltotsaimes3";
            this.ltotsaimes3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaimes3.SizeF = new System.Drawing.SizeF(137.4999F, 14F);
            this.ltotsaimes3.StylePriority.UseFont = false;
            this.ltotsaimes3.StylePriority.UseTextAlignment = false;
            this.ltotsaimes3.Text = "ltotsaimes3";
            this.ltotsaimes3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotsaimes2
            // 
            this.ltotsaimes2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotsaimes2.LocationFloat = new DevExpress.Utils.PointFloat(500.0005F, 77.68756F);
            this.ltotsaimes2.Name = "ltotsaimes2";
            this.ltotsaimes2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotsaimes2.SizeF = new System.Drawing.SizeF(137.5F, 14F);
            this.ltotsaimes2.StylePriority.UseFont = false;
            this.ltotsaimes2.StylePriority.UseTextAlignment = false;
            this.ltotsaimes2.Text = "ltotsaimes2";
            this.ltotsaimes2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel25
            // 
            this.xrLabel25.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(0F, 77.68756F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(360.5001F, 14F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "Sub Total Saídas:";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotentmes3
            // 
            this.ltotentmes3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotentmes3.LocationFloat = new DevExpress.Utils.PointFloat(637.5004F, 62.68753F);
            this.ltotentmes3.Name = "ltotentmes3";
            this.ltotentmes3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotentmes3.SizeF = new System.Drawing.SizeF(137.4999F, 14F);
            this.ltotentmes3.StylePriority.UseFont = false;
            this.ltotentmes3.StylePriority.UseTextAlignment = false;
            this.ltotentmes3.Text = "ltotentmes3";
            this.ltotentmes3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotentmes1
            // 
            this.ltotentmes1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotentmes1.LocationFloat = new DevExpress.Utils.PointFloat(362.5002F, 62.68753F);
            this.ltotentmes1.Name = "ltotentmes1";
            this.ltotentmes1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotentmes1.SizeF = new System.Drawing.SizeF(137.5002F, 14F);
            this.ltotentmes1.StylePriority.UseFont = false;
            this.ltotentmes1.StylePriority.UseTextAlignment = false;
            this.ltotentmes1.Text = "ltotentmes1";
            this.ltotentmes1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel19
            // 
            this.xrLabel19.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(0F, 62.68753F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(360.5001F, 14F);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Sub Total Entradas:";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotentmes2
            // 
            this.ltotentmes2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotentmes2.LocationFloat = new DevExpress.Utils.PointFloat(500.0005F, 62.68753F);
            this.ltotentmes2.Name = "ltotentmes2";
            this.ltotentmes2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotentmes2.SizeF = new System.Drawing.SizeF(137.5F, 14F);
            this.ltotentmes2.StylePriority.UseFont = false;
            this.ltotentmes2.StylePriority.UseTextAlignment = false;
            this.ltotentmes2.Text = "ltotentmes2";
            this.ltotentmes2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 32.68753F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(360.5001F, 14F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "Resumo do Fluxo de Caixa:";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsaldo
            // 
            this.lsaldo.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsaldo.LocationFloat = new DevExpress.Utils.PointFloat(362.5002F, 47.68753F);
            this.lsaldo.Name = "lsaldo";
            this.lsaldo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsaldo.SizeF = new System.Drawing.SizeF(137.5002F, 14F);
            this.lsaldo.StylePriority.UseFont = false;
            this.lsaldo.StylePriority.UseTextAlignment = false;
            this.lsaldo.Text = "lsaldo";
            this.lsaldo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 47.68753F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(360.5001F, 14F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Saldo Inicial:";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotmes3
            // 
            this.ltotmes3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotmes3.LocationFloat = new DevExpress.Utils.PointFloat(637.5004F, 9.375018F);
            this.ltotmes3.Name = "ltotmes3";
            this.ltotmes3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotmes3.SizeF = new System.Drawing.SizeF(137.4999F, 14F);
            this.ltotmes3.StylePriority.UseFont = false;
            this.ltotmes3.StylePriority.UseTextAlignment = false;
            this.ltotmes3.Text = "ltotmes3";
            this.ltotmes3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotmes1
            // 
            this.ltotmes1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotmes1.LocationFloat = new DevExpress.Utils.PointFloat(362.5002F, 9.375018F);
            this.ltotmes1.Name = "ltotmes1";
            this.ltotmes1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotmes1.SizeF = new System.Drawing.SizeF(137.5002F, 14F);
            this.ltotmes1.StylePriority.UseFont = false;
            this.ltotmes1.StylePriority.UseTextAlignment = false;
            this.ltotmes1.Text = "ltotmes1";
            this.ltotmes1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 9.375018F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(360.5001F, 14F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Totais:";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotmes2
            // 
            this.ltotmes2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotmes2.LocationFloat = new DevExpress.Utils.PointFloat(500.0004F, 9.375018F);
            this.ltotmes2.Name = "ltotmes2";
            this.ltotmes2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotmes2.SizeF = new System.Drawing.SizeF(137.5F, 14F);
            this.ltotmes2.StylePriority.UseFont = false;
            this.ltotmes2.StylePriority.UseTextAlignment = false;
            this.ltotmes2.Text = "ltotmes2";
            this.ltotmes2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ltotal
            // 
            this.ltotal.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltotal.LocationFloat = new DevExpress.Utils.PointFloat(775.0003F, 9.374987F);
            this.ltotal.Name = "ltotal";
            this.ltotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltotal.SizeF = new System.Drawing.SizeF(172.4999F, 14F);
            this.ltotal.StylePriority.UseFont = false;
            this.ltotal.StylePriority.UseTextAlignment = false;
            this.ltotal.Text = "ltotal";
            this.ltotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // headertipo
            // 
            this.headertipo.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lcabecalhotipo});
            this.headertipo.HeightF = 17.70833F;
            this.headertipo.Name = "headertipo";
            this.headertipo.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.headerdata_BeforePrint);
            // 
            // lcabecalhotipo
            // 
            this.lcabecalhotipo.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcabecalhotipo.LocationFloat = new DevExpress.Utils.PointFloat(2.00015F, 2F);
            this.lcabecalhotipo.Name = "lcabecalhotipo";
            this.lcabecalhotipo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcabecalhotipo.SizeF = new System.Drawing.SizeF(80F, 14F);
            this.lcabecalhotipo.StylePriority.UseFont = false;
            this.lcabecalhotipo.StylePriority.UseTextAlignment = false;
            this.lcabecalhotipo.Text = "lcabecalhotipo";
            this.lcabecalhotipo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // footertipo
            // 
            this.footertipo.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lsubtotal,
            this.lsubmes1,
            this.xrLabel24,
            this.lsubmes3,
            this.xrLine2,
            this.lsubmes2});
            this.footertipo.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.footertipo.HeightF = 27.08333F;
            this.footertipo.Name = "footertipo";
            this.footertipo.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.footerdata_BeforePrint);
            // 
            // lsubtotal
            // 
            this.lsubtotal.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubtotal.LocationFloat = new DevExpress.Utils.PointFloat(775.0004F, 10.00004F);
            this.lsubtotal.Name = "lsubtotal";
            this.lsubtotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubtotal.SizeF = new System.Drawing.SizeF(172.4998F, 14F);
            this.lsubtotal.StylePriority.UseFont = false;
            this.lsubtotal.StylePriority.UseTextAlignment = false;
            this.lsubtotal.Text = "lsubtotal";
            this.lsubtotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubmes1
            // 
            this.lsubmes1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubmes1.LocationFloat = new DevExpress.Utils.PointFloat(362.5002F, 10.00004F);
            this.lsubmes1.Name = "lsubmes1";
            this.lsubmes1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubmes1.SizeF = new System.Drawing.SizeF(137.5001F, 14F);
            this.lsubmes1.StylePriority.UseFont = false;
            this.lsubmes1.StylePriority.UseTextAlignment = false;
            this.lsubmes1.Text = "lsubmes1";
            this.lsubmes1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel24
            // 
            this.xrLabel24.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(3.000045F, 9.999974F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(359.5001F, 14F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "SubTotais:";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lsubmes3
            // 
            this.lsubmes3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubmes3.LocationFloat = new DevExpress.Utils.PointFloat(637.5004F, 10.00004F);
            this.lsubmes3.Name = "lsubmes3";
            this.lsubmes3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubmes3.SizeF = new System.Drawing.SizeF(137.4999F, 14F);
            this.lsubmes3.StylePriority.UseFont = false;
            this.lsubmes3.StylePriority.UseTextAlignment = false;
            this.lsubmes3.Text = "lsubmes3";
            this.lsubmes3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(1.000159F, 0F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(1048F, 7.375F);
            // 
            // lsubmes2
            // 
            this.lsubmes2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsubmes2.LocationFloat = new DevExpress.Utils.PointFloat(500.0003F, 10.00004F);
            this.lsubmes2.Name = "lsubmes2";
            this.lsubmes2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsubmes2.SizeF = new System.Drawing.SizeF(137.5001F, 14F);
            this.lsubmes2.StylePriority.UseFont = false;
            this.lsubmes2.StylePriority.UseTextAlignment = false;
            this.lsubmes2.Text = "lsubmes2";
            this.lsubmes2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RepFCaixaTrimestral
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
            this.headertipo,
            this.footertipo});
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
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepFCaixaTrimestral_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    double subreceitames1 = 0.00;
    double subreceitames2 = 0.00;
    double subreceitames3 = 0.00;
    double subreceitatotal = 0.00;
    //
    double totreceitames1 = 0.00;
    double totreceitames2 = 0.00;
    double totreceitames3 = 0.00;
    double totreceitatotal = 0.00;
    //
    double subdespesames1 = 0.00;
    double subdespesames2 = 0.00;
    double subdespesames3 = 0.00;
    double subdespesatotal = 0.00;
    //
    double totdespesames1 = 0.00;
    double totdespesames2 = 0.00;
    double totdespesames3 = 0.00;
    double totdespesatotal = 0.00;
    //
    public double saldoinicial = 0.00;
    Int16 contador = 1;
    //
    public Boolean eimprimetipo = false;
    public string rblancamentossituacao = "";


    private void RepFCaixaTrimestral_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
        lmes1.Text = String.Format("{0:N}", Convert.ToDouble(GetCurrentColumnValue("mes1")));
        lmes2.Text = String.Format("{0:N}", Convert.ToDouble(GetCurrentColumnValue("mes2")));
        lmes3.Text = String.Format("{0:N}", Convert.ToDouble(GetCurrentColumnValue("mes3")));
        ltotais.Text = String.Format("{0:N}", Convert.ToDouble(GetCurrentColumnValue("totaltrimestre")));
        //
        double previso = Convert.ToDouble(GetCurrentColumnValue("vlr_previsto"));
        double realizado = Convert.ToDouble(GetCurrentColumnValue("vlr_realizado"));
        //
        if (GetCurrentColumnValue("tipo").ToString() == "1")
        {
            //Receitas
            subreceitames1 = subreceitames1 + Convert.ToDouble(GetCurrentColumnValue("mes1")); 
            subreceitames2 = subreceitames2 + Convert.ToDouble(GetCurrentColumnValue("mes2")); 
            subreceitames3 = subreceitames3 + Convert.ToDouble(GetCurrentColumnValue("mes3")); 
            subreceitatotal = subreceitatotal + Convert.ToDouble(GetCurrentColumnValue("totaltrimestre"));
            //
            totreceitames1 = totreceitames1 + subreceitames1;
            totreceitames2 = totreceitames2 + subreceitames2;
            totreceitames3 = totreceitames3 + subreceitames3;
            totreceitatotal = totreceitatotal + subreceitatotal;
        }
        else
        {
            //Despesas
            subdespesames1 = subdespesames1 + Convert.ToDouble(GetCurrentColumnValue("mes1")); 
            subdespesames2 = subdespesames2 + Convert.ToDouble(GetCurrentColumnValue("mes2"));
            subdespesames3 = subdespesames3 + Convert.ToDouble(GetCurrentColumnValue("mes3")); 
            subdespesatotal = subdespesatotal + Convert.ToDouble(GetCurrentColumnValue("totaltrimestre"));
            //
            totdespesames1 = totdespesames1 + subdespesames1;
            totdespesames2 = totdespesames2 + subdespesames2;
            totdespesames3 = totdespesames3 + subdespesames3;
            totdespesatotal = totdespesatotal + subdespesatotal;
        }
        //
    }

    private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //Despesas
        ltotmes1.Text = String.Format("{0:N}", Convert.ToDouble(totdespesames1));
        ltotmes2.Text = String.Format("{0:N}", Convert.ToDouble(totdespesames2));
        ltotmes3.Text = String.Format("{0:N}", Convert.ToDouble(totdespesames3));
        ltotal.Text = String.Format("{0:N}", Convert.ToDouble(totdespesatotal));
        //
        //Quadro Resumo
        Double saldoinicial2 = saldoinicial + Convert.ToDouble(subreceitames1) - Convert.ToDouble(subdespesames1);
        Double saldoinicial3 = saldoinicial2 + Convert.ToDouble(subreceitames2) - Convert.ToDouble(subdespesames2);
        //
        lsaldo.Text = String.Format("{0:N}", saldoinicial);
        lsaldoini1.Text = String.Format("{0:N}", saldoinicial + Convert.ToDouble(subreceitames1) - Convert.ToDouble(subdespesames1));
        lsaldoini2.Text = String.Format("{0:N}", saldoinicial2 + Convert.ToDouble(subreceitames2) - Convert.ToDouble(subdespesames2));
        //
        //Receitas
        ltotentmes1.Text = String.Format("{0:N}", Convert.ToDouble(subreceitames1));
        ltotentmes2.Text = String.Format("{0:N}", Convert.ToDouble(subreceitames2));
        ltotentmes3.Text = String.Format("{0:N}", Convert.ToDouble(subreceitames3));
        //Despesas
        ltotsaimes1.Text = String.Format("{0:N}", Convert.ToDouble(subdespesames1));
        ltotsaimes2.Text = String.Format("{0:N}", Convert.ToDouble(subdespesames2));
        ltotsaimes3.Text = String.Format("{0:N}", Convert.ToDouble(subdespesames3));
        //
        ltotsaldofim1.Text = String.Format("{0:N}", saldoinicial + Convert.ToDouble(subreceitames1) - Convert.ToDouble(subdespesames1));
        ltotsaldofim2.Text = String.Format("{0:N}", saldoinicial2 + Convert.ToDouble(subreceitames2) - Convert.ToDouble(subdespesames2));
        ltotsaldofim3.Text = String.Format("{0:N}", saldoinicial3 + Convert.ToDouble(subreceitames3) - Convert.ToDouble(subdespesames3));
        //
    }

    private void footerdata_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //Receitas
        if (contador == 1)
        {
            lsubmes1.Text = String.Format("{0:N}", Convert.ToDouble(subreceitames1));
            lsubmes2.Text = String.Format("{0:N}", Convert.ToDouble(subreceitames2));
            lsubmes3.Text = String.Format("{0:N}", Convert.ToDouble(subreceitames3));
            lsubtotal.Text = String.Format("{0:N}", Convert.ToDouble(subreceitatotal));
            contador++;
        }
        else
        {
            //Despesas
            lsubmes1.Text = String.Format("{0:N}", Convert.ToDouble(subdespesames1));
            lsubmes2.Text = String.Format("{0:N}", Convert.ToDouble(subdespesames2));
            lsubmes3.Text = String.Format("{0:N}", Convert.ToDouble(subdespesames3));
            lsubtotal.Text = String.Format("{0:N}", Convert.ToDouble(subdespesatotal));
        }
        //
    }

    private void headerdata_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        e.Cancel = !eimprimetipo;
        //
        if (eimprimetipo)
        {
            if (GetCurrentColumnValue("tipo").ToString() == "1")
            {
                lcabecalhotipo.Text = "Receitas";
            }
            else
            {
                lcabecalhotipo.Text = "Despesas";
            }
            //
        }
    }

}
