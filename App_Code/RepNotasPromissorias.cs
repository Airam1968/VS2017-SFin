using DevExpress.XtraReports.UI;
using System;

/// <summary>
/// Summary description for RepNotasPromissorias
/// </summary>
public class RepNotasPromissorias : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private PageHeaderBand PageHeader;
    private XRPageInfo xrPageInfo2;
    public XRLabel ltitulorelatorio;
    private XRPictureBox xrPictureBox1;
    private XRControlStyle xrControlStyle1;
    private XRControlStyle xrControlStyle2;
    private FormattingRule formattingRule1;
    private PageFooterBand PageFooter;
    public XRLabel lcaminho;
    private XRLine xrLine1;
    private XRCrossBandBox xrCrossBandBox1;
    public XRLabel lvalorextenso1;
    public XRLabel ldatabaseextenso;
    public XRLabel xrLabel9;
    public XRLabel lindice;
    public XRLabel xrLabel8;
    public XRLabel xrLabel7;
    public XRLabel lcnpjempresa;
    public XRLabel xrLabel6;
    public XRLabel lnomeempresa;
    public XRLabel xrLabel5;
    public XRLabel lvencimentoextenso;
    public XRLabel xrLabel4;
    public XRLabel lvinculo3;
    public XRLabel lvinculo2;
    public XRLabel lvinculo1;
    public XRLabel lvalor;
    public XRLabel lvencimento;
    public XRLabel lnumero;
    public XRLabel xrLabel3;
    public XRLabel xrLabel2;
    public XRLabel xrLabel1;
    private XRLine xrLine4;
    public XRLabel lconjugeendereco1;
    public XRLabel lconjugeendereco2;
    public XRLabel lconjugecpfcnpj;
    public XRLabel lconjugenome;
    private XRLine xrLine3;
    public XRLabel lemitenteendereco2;
    public XRLabel lemitenteendereco1;
    public XRLabel lemitentecpfcnpj;
    private XRLine xrLine2;
    public XRLabel lemitentenome;
    public XRLabel xrLabel12;
    public XRLabel xrLabel11;
    public XRLabel lemissaoextenso;
    public XRLabel lcidadeestadoextenso;
    public XRLabel xrLabel10;
    public XRLabel lvalorextenso2;
    private XRPictureBox xrPictureBox2;
    public XRLabel xrLabel17;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public RepNotasPromissorias()
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
            //string resourceFileName = "RepNotasPromissorias.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.lconjugeendereco1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lconjugeendereco2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lconjugecpfcnpj = new DevExpress.XtraReports.UI.XRLabel();
            this.lconjugenome = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.lemitenteendereco2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lemitenteendereco1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lemitentecpfcnpj = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.lemitentenome = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.lemissaoextenso = new DevExpress.XtraReports.UI.XRLabel();
            this.lcidadeestadoextenso = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvalorextenso2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvalorextenso1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ldatabaseextenso = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.lindice = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.lcnpjempresa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.lnomeempresa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvencimentoextenso = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvinculo3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvinculo2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvinculo1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvalor = new DevExpress.XtraReports.UI.XRLabel();
            this.lvencimento = new DevExpress.XtraReports.UI.XRLabel();
            this.lnumero = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.ltitulorelatorio = new DevExpress.XtraReports.UI.XRLabel();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lcaminho = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCrossBandBox1 = new DevExpress.XtraReports.UI.XRCrossBandBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox2,
            this.xrLabel17,
            this.xrLine4,
            this.lconjugeendereco1,
            this.lconjugeendereco2,
            this.lconjugecpfcnpj,
            this.lconjugenome,
            this.xrLine3,
            this.lemitenteendereco2,
            this.lemitenteendereco1,
            this.lemitentecpfcnpj,
            this.xrLine2,
            this.lemitentenome,
            this.xrLabel12,
            this.xrLabel11,
            this.lemissaoextenso,
            this.lcidadeestadoextenso,
            this.xrLabel10,
            this.lvalorextenso2,
            this.lvalorextenso1,
            this.ldatabaseextenso,
            this.xrLabel9,
            this.lindice,
            this.xrLabel8,
            this.xrLabel7,
            this.lcnpjempresa,
            this.xrLabel6,
            this.lnomeempresa,
            this.xrLabel5,
            this.lvencimentoextenso,
            this.xrLabel4,
            this.lvinculo3,
            this.lvinculo2,
            this.lvinculo1,
            this.lvalor,
            this.lvencimento,
            this.lnumero,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.xrLine1});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 416.6667F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.BorderColor = System.Drawing.Color.Azure;
            this.xrPictureBox2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrPictureBox2.BorderWidth = 0F;
            this.xrPictureBox2.ImageUrl = "~\\images\\notapromissoria\\brasao_republica_pb.jpg";
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(12.00015F, 15.37496F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(49.99999F, 55.25002F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.xrPictureBox2.StylePriority.UseBorderColor = false;
            this.xrPictureBox2.StylePriority.UseBorderDashStyle = false;
            this.xrPictureBox2.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Angle = 90F;
            this.xrLabel17.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel17.BorderColor = System.Drawing.Color.Empty;
            this.xrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.ForeColor = System.Drawing.Color.Black;
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(27.99999F, 71.625F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(12.70839F, 333F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "NOTA PROMISSÓRIA";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLine4
            // 
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(5.000146F, 405.625F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(1040.917F, 7.375F);
            // 
            // lconjugeendereco1
            // 
            this.lconjugeendereco1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconjugeendereco1.LocationFloat = new DevExpress.Utils.PointFloat(536.0834F, 346.2917F);
            this.lconjugeendereco1.Name = "lconjugeendereco1";
            this.lconjugeendereco1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lconjugeendereco1.SizeF = new System.Drawing.SizeF(345.8333F, 14F);
            this.lconjugeendereco1.StylePriority.UseFont = false;
            this.lconjugeendereco1.Text = "lconjugeendereco1";
            this.lconjugeendereco1.Visible = false;
            // 
            // lconjugeendereco2
            // 
            this.lconjugeendereco2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconjugeendereco2.LocationFloat = new DevExpress.Utils.PointFloat(536.0833F, 361.2917F);
            this.lconjugeendereco2.Name = "lconjugeendereco2";
            this.lconjugeendereco2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lconjugeendereco2.SizeF = new System.Drawing.SizeF(345.8333F, 14F);
            this.lconjugeendereco2.StylePriority.UseFont = false;
            this.lconjugeendereco2.Text = "lconjugeendereco2";
            this.lconjugeendereco2.Visible = false;
            // 
            // lconjugecpfcnpj
            // 
            this.lconjugecpfcnpj.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconjugecpfcnpj.LocationFloat = new DevExpress.Utils.PointFloat(536.0834F, 331.2916F);
            this.lconjugecpfcnpj.Name = "lconjugecpfcnpj";
            this.lconjugecpfcnpj.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lconjugecpfcnpj.SizeF = new System.Drawing.SizeF(345.8333F, 14F);
            this.lconjugecpfcnpj.StylePriority.UseFont = false;
            this.lconjugecpfcnpj.Text = "lconjugecpfcnpj";
            this.lconjugecpfcnpj.Visible = false;
            // 
            // lconjugenome
            // 
            this.lconjugenome.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconjugenome.LocationFloat = new DevExpress.Utils.PointFloat(536.0834F, 316.2917F);
            this.lconjugenome.Name = "lconjugenome";
            this.lconjugenome.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lconjugenome.SizeF = new System.Drawing.SizeF(345.8333F, 14F);
            this.lconjugenome.StylePriority.UseFont = false;
            this.lconjugenome.Text = "lconjugenome";
            this.lconjugenome.Visible = false;
            // 
            // xrLine3
            // 
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(536.0833F, 293.9167F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(345.8334F, 7.375F);
            this.xrLine3.Visible = false;
            // 
            // lemitenteendereco2
            // 
            this.lemitenteendereco2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemitenteendereco2.LocationFloat = new DevExpress.Utils.PointFloat(114F, 360.7917F);
            this.lemitenteendereco2.Name = "lemitenteendereco2";
            this.lemitenteendereco2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lemitenteendereco2.SizeF = new System.Drawing.SizeF(345.8333F, 14F);
            this.lemitenteendereco2.StylePriority.UseFont = false;
            this.lemitenteendereco2.Text = "lemitenteendereco2";
            // 
            // lemitenteendereco1
            // 
            this.lemitenteendereco1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemitenteendereco1.LocationFloat = new DevExpress.Utils.PointFloat(114.0001F, 345.7917F);
            this.lemitenteendereco1.Name = "lemitenteendereco1";
            this.lemitenteendereco1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lemitenteendereco1.SizeF = new System.Drawing.SizeF(345.8333F, 14F);
            this.lemitenteendereco1.StylePriority.UseFont = false;
            this.lemitenteendereco1.Text = "lemitenteendereco1";
            // 
            // lemitentecpfcnpj
            // 
            this.lemitentecpfcnpj.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemitentecpfcnpj.LocationFloat = new DevExpress.Utils.PointFloat(114.0001F, 330.7917F);
            this.lemitentecpfcnpj.Name = "lemitentecpfcnpj";
            this.lemitentecpfcnpj.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lemitentecpfcnpj.SizeF = new System.Drawing.SizeF(345.8333F, 14F);
            this.lemitentecpfcnpj.StylePriority.UseFont = false;
            this.lemitentecpfcnpj.Text = "lemitentecpfcnpj";
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(114F, 293.9167F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(345.8334F, 7.375F);
            // 
            // lemitentenome
            // 
            this.lemitentenome.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemitentenome.LocationFloat = new DevExpress.Utils.PointFloat(114.0001F, 315.7917F);
            this.lemitentenome.Name = "lemitentenome";
            this.lemitentenome.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lemitentenome.SizeF = new System.Drawing.SizeF(345.8333F, 14F);
            this.lemitentenome.StylePriority.UseFont = false;
            this.lemitentenome.Text = "lemitentenome";
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(536.0833F, 301.2917F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.Text = "Conjuge:";
            this.xrLabel12.Visible = false;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(114F, 301.2917F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.Text = "Emitente:";
            // 
            // lemissaoextenso
            // 
            this.lemissaoextenso.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemissaoextenso.LocationFloat = new DevExpress.Utils.PointFloat(536.0833F, 224.75F);
            this.lemissaoextenso.Name = "lemissaoextenso";
            this.lemissaoextenso.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lemissaoextenso.SizeF = new System.Drawing.SizeF(457.3753F, 14.00002F);
            this.lemissaoextenso.StylePriority.UseFont = false;
            this.lemissaoextenso.Text = "lemissaoextenso";
            // 
            // lcidadeestadoextenso
            // 
            this.lcidadeestadoextenso.BackColor = System.Drawing.Color.SlateGray;
            this.lcidadeestadoextenso.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcidadeestadoextenso.LocationFloat = new DevExpress.Utils.PointFloat(200.2086F, 183.625F);
            this.lcidadeestadoextenso.Name = "lcidadeestadoextenso";
            this.lcidadeestadoextenso.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcidadeestadoextenso.SizeF = new System.Drawing.SizeF(793.2501F, 14.00002F);
            this.lcidadeestadoextenso.StylePriority.UseBackColor = false;
            this.lcidadeestadoextenso.StylePriority.UseFont = false;
            this.lcidadeestadoextenso.Text = "lcidadeestadoextenso";
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(68.00014F, 183.625F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(132.2085F, 14.00002F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = ", na Praça do Município de ";
            // 
            // lvalorextenso2
            // 
            this.lvalorextenso2.BackColor = System.Drawing.Color.SlateGray;
            this.lvalorextenso2.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalorextenso2.LocationFloat = new DevExpress.Utils.PointFloat(68.00014F, 167.625F);
            this.lvalorextenso2.Name = "lvalorextenso2";
            this.lvalorextenso2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvalorextenso2.SizeF = new System.Drawing.SizeF(925.4585F, 14F);
            this.lvalorextenso2.StylePriority.UseBackColor = false;
            this.lvalorextenso2.StylePriority.UseFont = false;
            this.lvalorextenso2.Text = "lvalorextenso2";
            // 
            // lvalorextenso1
            // 
            this.lvalorextenso1.BackColor = System.Drawing.Color.SlateGray;
            this.lvalorextenso1.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalorextenso1.LocationFloat = new DevExpress.Utils.PointFloat(68.00016F, 151.625F);
            this.lvalorextenso1.Name = "lvalorextenso1";
            this.lvalorextenso1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvalorextenso1.SizeF = new System.Drawing.SizeF(925.4585F, 14F);
            this.lvalorextenso1.StylePriority.UseBackColor = false;
            this.lvalorextenso1.StylePriority.UseFont = false;
            this.lvalorextenso1.Text = "lvalorextenso1";
            // 
            // ldatabaseextenso
            // 
            this.ldatabaseextenso.BackColor = System.Drawing.Color.SlateGray;
            this.ldatabaseextenso.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldatabaseextenso.LocationFloat = new DevExpress.Utils.PointFloat(636.0833F, 135.125F);
            this.ldatabaseextenso.Name = "ldatabaseextenso";
            this.ldatabaseextenso.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldatabaseextenso.SizeF = new System.Drawing.SizeF(357.3753F, 14F);
            this.ldatabaseextenso.StylePriority.UseBackColor = false;
            this.ldatabaseextenso.StylePriority.UseFont = false;
            this.ldatabaseextenso.Text = "ldatabaseextenso";
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(538.6671F, 135.125F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(97.4162F, 14F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = ", com data base em ";
            // 
            // lindice
            // 
            this.lindice.BackColor = System.Drawing.Color.SlateGray;
            this.lindice.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lindice.LocationFloat = new DevExpress.Utils.PointFloat(429.2918F, 135.125F);
            this.lindice.Name = "lindice";
            this.lindice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lindice.SizeF = new System.Drawing.SizeF(109.3752F, 14F);
            this.lindice.StylePriority.UseBackColor = false;
            this.lindice.StylePriority.UseFont = false;
            this.lindice.Text = "lindice";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(68.00016F, 135.125F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(361.2917F, 14F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "corresponder a quantia abaixo, corrigida de acordo com a variação do indice";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(558.1254F, 119.125F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(435.3332F, 14F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = ", ou a sua ordem em moeda corrente nacional valor que na data de sua efetiva liqu" +
    "idação";
            // 
            // lcnpjempresa
            // 
            this.lcnpjempresa.BackColor = System.Drawing.Color.SlateGray;
            this.lcnpjempresa.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcnpjempresa.LocationFloat = new DevExpress.Utils.PointFloat(442.2918F, 119.125F);
            this.lcnpjempresa.Name = "lcnpjempresa";
            this.lcnpjempresa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcnpjempresa.SizeF = new System.Drawing.SizeF(115.8336F, 14F);
            this.lcnpjempresa.StylePriority.UseBackColor = false;
            this.lcnpjempresa.StylePriority.UseFont = false;
            this.lcnpjempresa.Text = "lcnpjempresa";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(327.9167F, 119.125F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(114.3752F, 14F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = ", inscrita sob o CNPJ No.";
            // 
            // lnomeempresa
            // 
            this.lnomeempresa.BackColor = System.Drawing.Color.SlateGray;
            this.lnomeempresa.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnomeempresa.LocationFloat = new DevExpress.Utils.PointFloat(68.00016F, 119.125F);
            this.lnomeempresa.Name = "lnomeempresa";
            this.lnomeempresa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lnomeempresa.SizeF = new System.Drawing.SizeF(259.9165F, 14F);
            this.lnomeempresa.StylePriority.UseBackColor = false;
            this.lnomeempresa.StylePriority.UseFont = false;
            this.lnomeempresa.Text = "lnomeempresa";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(750.0002F, 103.125F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(243.4584F, 14F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "Pagarei(emos) por esta via de nota promissória á";
            // 
            // lvencimentoextenso
            // 
            this.lvencimentoextenso.BackColor = System.Drawing.Color.SlateGray;
            this.lvencimentoextenso.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvencimentoextenso.LocationFloat = new DevExpress.Utils.PointFloat(100.5002F, 103.125F);
            this.lvencimentoextenso.Name = "lvencimentoextenso";
            this.lvencimentoextenso.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvencimentoextenso.SizeF = new System.Drawing.SizeF(649.5001F, 14F);
            this.lvencimentoextenso.StylePriority.UseBackColor = false;
            this.lvencimentoextenso.StylePriority.UseFont = false;
            this.lvencimentoextenso.Text = "lvencimentoextenso";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(68.00012F, 103.125F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(32.50005F, 14F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "Ao(s)";
            // 
            // lvinculo3
            // 
            this.lvinculo3.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvinculo3.LocationFloat = new DevExpress.Utils.PointFloat(587.2085F, 53.87497F);
            this.lvinculo3.Name = "lvinculo3";
            this.lvinculo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvinculo3.SizeF = new System.Drawing.SizeF(385.2502F, 14F);
            this.lvinculo3.StylePriority.UseFont = false;
            this.lvinculo3.Text = "lvinculo3";
            // 
            // lvinculo2
            // 
            this.lvinculo2.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvinculo2.LocationFloat = new DevExpress.Utils.PointFloat(587.2085F, 37.87498F);
            this.lvinculo2.Name = "lvinculo2";
            this.lvinculo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvinculo2.SizeF = new System.Drawing.SizeF(385.2502F, 14F);
            this.lvinculo2.StylePriority.UseFont = false;
            this.lvinculo2.Text = "lvinculo2";
            // 
            // lvinculo1
            // 
            this.lvinculo1.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvinculo1.LocationFloat = new DevExpress.Utils.PointFloat(587.2085F, 21.875F);
            this.lvinculo1.Name = "lvinculo1";
            this.lvinculo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvinculo1.SizeF = new System.Drawing.SizeF(385.2502F, 14F);
            this.lvinculo1.StylePriority.UseFont = false;
            this.lvinculo1.Text = "Vinculada ao Contrato de Compra e Venda do Empreendimento";
            // 
            // lvalor
            // 
            this.lvalor.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalor.LocationFloat = new DevExpress.Utils.PointFloat(160.0002F, 53.875F);
            this.lvalor.Name = "lvalor";
            this.lvalor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvalor.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.lvalor.StylePriority.UseFont = false;
            this.lvalor.Text = "lvalor";
            // 
            // lvencimento
            // 
            this.lvencimento.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvencimento.LocationFloat = new DevExpress.Utils.PointFloat(160.0002F, 37.87502F);
            this.lvencimento.Name = "lvencimento";
            this.lvencimento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvencimento.SizeF = new System.Drawing.SizeF(282.2917F, 14F);
            this.lvencimento.StylePriority.UseFont = false;
            this.lvencimento.Text = "lvencimento";
            // 
            // lnumero
            // 
            this.lnumero.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnumero.LocationFloat = new DevExpress.Utils.PointFloat(160.0002F, 21.875F);
            this.lnumero.Name = "lnumero";
            this.lnumero.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lnumero.SizeF = new System.Drawing.SizeF(100F, 14F);
            this.lnumero.StylePriority.UseFont = false;
            this.lnumero.Text = "lnumero";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(68.00014F, 53.87497F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(92.00004F, 14F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "Valor:";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(68.00014F, 37.87498F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(92.00004F, 14F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Vencimento:";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(68.00014F, 21.875F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(92.00004F, 14F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Promissória No.:";
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(5.000146F, 1.999982F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1040.917F, 7.375F);
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
            // xrPageInfo2
            // 
            this.xrPageInfo2.BackColor = System.Drawing.Color.Transparent;
            this.xrPageInfo2.BorderWidth = 0F;
            this.xrPageInfo2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo2.Format = "{0:dddd, d\' de \'MMMM\' de \'yyyy HH:mm:ss}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(863.6669F, 4.000028F);
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
            this.ltitulorelatorio});
            this.PageHeader.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.PageHeader.HeightF = 83.33334F;
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
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(5.00015F, 4F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(129F, 75F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.xrPictureBox1.StylePriority.UseBorderColor = false;
            this.xrPictureBox1.StylePriority.UseBorderDashStyle = false;
            this.xrPictureBox1.StylePriority.UseBorderWidth = false;
            // 
            // ltitulorelatorio
            // 
            this.ltitulorelatorio.BackColor = System.Drawing.Color.Transparent;
            this.ltitulorelatorio.BorderColor = System.Drawing.Color.Empty;
            this.ltitulorelatorio.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.ltitulorelatorio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.ltitulorelatorio.ForeColor = System.Drawing.Color.Black;
            this.ltitulorelatorio.LocationFloat = new DevExpress.Utils.PointFloat(279.0002F, 34.375F);
            this.ltitulorelatorio.Name = "ltitulorelatorio";
            this.ltitulorelatorio.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulorelatorio.SizeF = new System.Drawing.SizeF(461.0147F, 21.54171F);
            this.ltitulorelatorio.StylePriority.UseBackColor = false;
            this.ltitulorelatorio.StylePriority.UseBorderColor = false;
            this.ltitulorelatorio.StylePriority.UseBorders = false;
            this.ltitulorelatorio.StylePriority.UseFont = false;
            this.ltitulorelatorio.StylePriority.UseForeColor = false;
            this.ltitulorelatorio.StylePriority.UseTextAlignment = false;
            this.ltitulorelatorio.Text = "NOTA PROMISSÓRIA EM REAIS";
            this.ltitulorelatorio.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
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
            this.lcaminho,
            this.xrPageInfo2});
            this.PageFooter.HeightF = 22.91667F;
            this.PageFooter.Name = "PageFooter";
            // 
            // lcaminho
            // 
            this.lcaminho.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcaminho.LocationFloat = new DevExpress.Utils.PointFloat(5.000146F, 4F);
            this.lcaminho.Name = "lcaminho";
            this.lcaminho.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcaminho.SizeF = new System.Drawing.SizeF(322.9165F, 14F);
            this.lcaminho.StylePriority.UseFont = false;
            this.lcaminho.Text = "Gitano ->SGFin ->Vendas ->Nota Promissória";
            // 
            // xrCrossBandBox1
            // 
            this.xrCrossBandBox1.BorderWidth = 2F;
            this.xrCrossBandBox1.EndBand = this.BottomMargin;
            this.xrCrossBandBox1.EndPointFloat = new DevExpress.Utils.PointFloat(1.000134F, 2.083333F);
            this.xrCrossBandBox1.LocationFloat = new DevExpress.Utils.PointFloat(1.000134F, 0F);
            this.xrCrossBandBox1.Name = "xrCrossBandBox1";
            this.xrCrossBandBox1.StartBand = this.PageHeader;
            this.xrCrossBandBox1.StartPointFloat = new DevExpress.Utils.PointFloat(1.000134F, 0F);
            this.xrCrossBandBox1.WidthF = 1047F;
            // 
            // RepNotasPromissorias
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.PageFooter});
            this.CrossBandControls.AddRange(new DevExpress.XtraReports.UI.XRCrossBandControl[] {
            this.xrCrossBandBox1});
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
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepNotasPromissorias_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    //
    public Int32 quantidade = 0;
    public Boolean ckconjuge = false;
    public string rbdatabase;

    private void RepNotasPromissorias_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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

        //grupofiltros.RepeatEveryPage = ((SreDblib.GetParametro("EXIBE FILTRO RELAT") == "SIM"));

    }

    private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //
        string parcela = Convert.ToString(GetCurrentColumnValue("parcela"));
        string tipo = Convert.ToString(GetCurrentColumnValue("tipo"));
        lnumero.Text = parcela + "/" + quantidade + " Tipo: (" + tipo + ")";
        //
        string vencimento = Convert.ToString(GetCurrentColumnValue("data_vencimento")).Substring(0, 10);
        lvencimento.Text = vencimento;
        //
        string valor = Convert.ToString(GetCurrentColumnValue("vlr_parcela"));
        lvalor.Text = Srelib.forcaponto(valor);
        //
        Int32 produto = Convert.ToInt32(GetCurrentColumnValue("produto"));
        lvinculo2.Text = uProduto.PegaProdutoDescricao(produto);
        //
        Int32 grupo = Convert.ToInt32(GetCurrentColumnValue("grupo"));
        Int32 unidade = Convert.ToInt32(GetCurrentColumnValue("unidade"));
        string grupodescricao = uProduto.PegaProdutoGrupoDescricao(produto, grupo);
        if (grupodescricao.Trim() == string.Empty)
        {
            lvinculo3.Text = "Bloco No. " + grupo.ToString() + " Unidade No. " + unidade.ToString();
        }
        else
        {
            lvinculo3.Text = "Bloco No. " + grupo.ToString() + "-(" + grupodescricao + ") Unidade No. " + unidade.ToString();
        }
        //
        lvencimentoextenso.Text = Srelib.DataExtenso(Convert.ToDateTime(vencimento));
        //
        lnomeempresa.Text = uEmpresa.PegaNome(uEmpresa.PegaMatriz());
        //
        lcnpjempresa.Text = Srelib.FormataCPFCNPJ(uEmpresa.PegaCnpj(uEmpresa.PegaMatriz()));
        //       
        lindice.Text = uVendas.PegaIndexador(produto.ToString(), grupo.ToString(), unidade.ToString(), "0");
        // 
        if (rbdatabase == "0")
        {
            ldatabaseextenso.Text = Srelib.DataExtenso(uVendas.PegaDataBase(produto.ToString(), grupo.ToString(), unidade.ToString(), "0"));
            ldatabaseextenso.Text = ldatabaseextenso.Text + ".";
        }
        else
        {
            ldatabaseextenso.Text = Srelib.DataExtenso(Convert.ToDateTime(vencimento));
            ldatabaseextenso.Text = ldatabaseextenso.Text + ".";
        }
        //
        ValorExtenso xExt = new ValorExtenso();
        String xAux;
        xAux = xExt.ValExtenso(Convert.ToDouble(valor));
        lvalorextenso1.Text = xAux;
        lvalorextenso2.Text = " ";
        //
        lcidadeestadoextenso.Text = uEmpresa.PegaCidade(uEmpresa.PegaMatriz()) + ", " + uEmpresa.PegaEstado(uEmpresa.PegaMatriz()) + ".";
        //
        lemissaoextenso.Text = uEmpresa.PegaCidade(uEmpresa.PegaMatriz()) + ", " + Srelib.DataExtenso(DateTime.Now);
        //
        //
        string cliente = uVendas.PegaProprietário(produto.ToString(), grupo.ToString(), unidade.ToString(), "0");
        lemitentenome.Text = uContato.PegaNomeID(cliente);
        lemitentecpfcnpj.Text = Srelib.FormataCPFCNPJ(uContato.PegaCpfCnpjID(cliente));
        lemitenteendereco1.Text = uContato.PegaEnderecoID(cliente);
        lemitenteendereco2.Text = " ";
        //
        //
        if (ckconjuge)
        {
            xrLine3.Visible = ckconjuge;
            xrLabel12.Visible = ckconjuge;
            lconjugenome.Visible = ckconjuge;
            lconjugecpfcnpj.Visible = ckconjuge;
            lconjugeendereco1.Visible = ckconjuge;
            lconjugeendereco2.Visible = ckconjuge;
            //
            lconjugenome.Text = uContato.PegaNomeConjugeID(cliente);
            lconjugecpfcnpj.Text = Srelib.FormataCPFCNPJ(uContato.PegaCpfCnpjConjugeID(cliente));
            lconjugeendereco1.Text = uContato.PegaEnderecoConjugeID(cliente);
            lconjugeendereco2.Text = " ";
        }
        //
    }

}
