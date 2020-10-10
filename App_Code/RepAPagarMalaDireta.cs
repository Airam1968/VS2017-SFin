using DevExpress.XtraReports.UI;
using System;

/// <summary>
/// Summary description for RepAPagarMalaDireta
/// </summary>
public class RepAPagarMalaDireta : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private XRControlStyle xrControlStyle1;
    private XRControlStyle xrControlStyle2;
    private FormattingRule formattingRule1;
    private XRPanel xrPanel1;
    private TopMarginBand topMarginBand1;
    private BottomMarginBand bottomMarginBand1;
    public XRLabel lcidade;
    public XRLabel lbairro;
    public XRLabel lcomplemento;
    public XRLabel lendereco;
    public XRLabel lnome;
    public XRLabel luf;
    public XRLabel lcep;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public RepAPagarMalaDireta()
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
        //string resourceFileName = "RepAPagarMalaDireta.resx";
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
        this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
        this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
        this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
        this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
        this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.lnome = new DevExpress.XtraReports.UI.XRLabel();
        this.lendereco = new DevExpress.XtraReports.UI.XRLabel();
        this.lcomplemento = new DevExpress.XtraReports.UI.XRLabel();
        this.lbairro = new DevExpress.XtraReports.UI.XRLabel();
        this.lcidade = new DevExpress.XtraReports.UI.XRLabel();
        this.lcep = new DevExpress.XtraReports.UI.XRLabel();
        this.luf = new DevExpress.XtraReports.UI.XRLabel();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
        this.Detail.EvenStyleName = "xrControlStyle1";
        this.Detail.HeightF = 99F;
        this.Detail.MultiColumn.ColumnCount = 2;
        this.Detail.MultiColumn.ColumnSpacing = 6F;
        this.Detail.MultiColumn.ColumnWidth = 254F;
        this.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown;
        this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
        this.Detail.Name = "Detail";
        this.Detail.OddStyleName = "xrControlStyle2";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
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
        // xrPanel1
        // 
        this.xrPanel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrPanel1.CanGrow = false;
        this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.luf,
            this.lcep,
            this.lcidade,
            this.lbairro,
            this.lcomplemento,
            this.lendereco,
            this.lnome});
        this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrPanel1.Name = "xrPanel1";
        this.xrPanel1.SizeF = new System.Drawing.SizeF(254F, 99F);
        this.xrPanel1.StylePriority.UseBorders = false;
        // 
        // topMarginBand1
        // 
        this.topMarginBand1.HeightF = 10F;
        this.topMarginBand1.Name = "topMarginBand1";
        // 
        // bottomMarginBand1
        // 
        this.bottomMarginBand1.HeightF = 0F;
        this.bottomMarginBand1.Name = "bottomMarginBand1";
        // 
        // lnome
        // 
        this.lnome.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lnome.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
        this.lnome.ForeColor = System.Drawing.Color.Black;
        this.lnome.LocationFloat = new DevExpress.Utils.PointFloat(6.723209F, 10.00001F);
        this.lnome.Name = "lnome";
        this.lnome.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lnome.SizeF = new System.Drawing.SizeF(237.2768F, 10F);
        this.lnome.StylePriority.UseBackColor = false;
        this.lnome.StylePriority.UseBorders = false;
        this.lnome.StylePriority.UseFont = false;
        this.lnome.Text = "lnome";
        this.lnome.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.lnome.WordWrap = false;
        // 
        // lendereco
        // 
        this.lendereco.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lendereco.Font = new System.Drawing.Font("Calibri", 7F);
        this.lendereco.ForeColor = System.Drawing.Color.Black;
        this.lendereco.LocationFloat = new DevExpress.Utils.PointFloat(6.723205F, 22.29167F);
        this.lendereco.Name = "lendereco";
        this.lendereco.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lendereco.SizeF = new System.Drawing.SizeF(237.2768F, 10F);
        this.lendereco.StylePriority.UseBackColor = false;
        this.lendereco.StylePriority.UseBorders = false;
        this.lendereco.StylePriority.UseFont = false;
        this.lendereco.Text = "lendereco";
        this.lendereco.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.lendereco.WordWrap = false;
        // 
        // lcomplemento
        // 
        this.lcomplemento.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lcomplemento.Font = new System.Drawing.Font("Calibri", 7F);
        this.lcomplemento.ForeColor = System.Drawing.Color.Black;
        this.lcomplemento.LocationFloat = new DevExpress.Utils.PointFloat(6.723205F, 33.29167F);
        this.lcomplemento.Name = "lcomplemento";
        this.lcomplemento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lcomplemento.SizeF = new System.Drawing.SizeF(237.2768F, 10F);
        this.lcomplemento.StylePriority.UseBackColor = false;
        this.lcomplemento.StylePriority.UseBorders = false;
        this.lcomplemento.StylePriority.UseFont = false;
        this.lcomplemento.Text = "lcomplemento";
        this.lcomplemento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.lcomplemento.WordWrap = false;
        // 
        // lbairro
        // 
        this.lbairro.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lbairro.Font = new System.Drawing.Font("Calibri", 7F);
        this.lbairro.ForeColor = System.Drawing.Color.Black;
        this.lbairro.LocationFloat = new DevExpress.Utils.PointFloat(6.723209F, 44.29167F);
        this.lbairro.Name = "lbairro";
        this.lbairro.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lbairro.SizeF = new System.Drawing.SizeF(237.2768F, 10F);
        this.lbairro.StylePriority.UseBackColor = false;
        this.lbairro.StylePriority.UseBorders = false;
        this.lbairro.StylePriority.UseFont = false;
        this.lbairro.Text = "lbairro";
        this.lbairro.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.lbairro.WordWrap = false;
        // 
        // lcidade
        // 
        this.lcidade.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lcidade.Font = new System.Drawing.Font("Calibri", 7F);
        this.lcidade.ForeColor = System.Drawing.Color.Black;
        this.lcidade.LocationFloat = new DevExpress.Utils.PointFloat(6.723213F, 54.29167F);
        this.lcidade.Name = "lcidade";
        this.lcidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lcidade.SizeF = new System.Drawing.SizeF(186.7055F, 10F);
        this.lcidade.StylePriority.UseBackColor = false;
        this.lcidade.StylePriority.UseBorders = false;
        this.lcidade.StylePriority.UseFont = false;
        this.lcidade.Text = "lcidade";
        this.lcidade.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.lcidade.WordWrap = false;
        // 
        // lcep
        // 
        this.lcep.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.lcep.Font = new System.Drawing.Font("Calibri", 7F, System.Drawing.FontStyle.Bold);
        this.lcep.ForeColor = System.Drawing.Color.Black;
        this.lcep.LocationFloat = new DevExpress.Utils.PointFloat(6.723201F, 66.29167F);
        this.lcep.Name = "lcep";
        this.lcep.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lcep.SizeF = new System.Drawing.SizeF(237.2768F, 10F);
        this.lcep.StylePriority.UseBackColor = false;
        this.lcep.StylePriority.UseBorders = false;
        this.lcep.StylePriority.UseFont = false;
        this.lcep.Text = "lcep";
        this.lcep.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.lcep.WordWrap = false;
        // 
        // luf
        // 
        this.luf.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.luf.Font = new System.Drawing.Font("Calibri", 7F);
        this.luf.ForeColor = System.Drawing.Color.Black;
        this.luf.LocationFloat = new DevExpress.Utils.PointFloat(193.4287F, 55.29167F);
        this.luf.Name = "luf";
        this.luf.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.luf.SizeF = new System.Drawing.SizeF(50.5713F, 10.00001F);
        this.luf.StylePriority.UseBackColor = false;
        this.luf.StylePriority.UseBorders = false;
        this.luf.StylePriority.UseFont = false;
        this.luf.Text = "luf";
        this.luf.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.luf.WordWrap = false;
        // 
        // RepAPagarMalaDireta
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.topMarginBand1,
            this.bottomMarginBand1});
        this.Font = new System.Drawing.Font("Calibri", 9.75F);
        this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
        this.Margins = new System.Drawing.Printing.Margins(10, 0, 10, 0);
        this.PageHeight = 1169;
        this.PageWidth = 827;
        this.PaperKind = System.Drawing.Printing.PaperKind.A4;
        this.ReportPrintOptions.DetailCountOnEmptyDataSource = 33;
        this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1,
            this.xrControlStyle2});
        this.Version = "13.2";
        this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepAPagarMalaDireta_BeforePrint);
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void RepAPagarMalaDireta_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
        string endereco = "";
        string complemento = "";
        string bairro = "";
        string cidade = "";
        string uf = "";
        string cep = "";
        //
        endereco = Convert.ToString(GetCurrentColumnValue("enderecocom"));
        complemento = Convert.ToString(GetCurrentColumnValue("enderecocomcomplem"));
        bairro = Convert.ToString(GetCurrentColumnValue("bairrocom"));
        cidade = Convert.ToString(GetCurrentColumnValue("cidadecom"));
        uf = Convert.ToString(GetCurrentColumnValue("ufcom"));
        cep = Convert.ToString(GetCurrentColumnValue("cepcom"));
        //
        lendereco.Text = endereco;
        lcomplemento.Text = complemento;
        lbairro.Text = bairro;
        lcidade.Text = cidade;
        luf.Text = uf;
        lcep.Text = cep;
    }

}
