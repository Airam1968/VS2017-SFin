using DevExpress.XtraReports.UI;
using System;
using System.Data;

/// <summary>
/// Summary description for RepClienteCartaPadrao
/// </summary>
public class RepClienteCartaPadrao : DevExpress.XtraReports.UI.XtraReport
{
	private DevExpress.XtraReports.UI.DetailBand Detail;
	private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
	private XRControlStyle xrControlStyle1;
    private XRControlStyle xrControlStyle2;
    private FormattingRule formattingRule1;
	private PageFooterBand PageFooter;
	public XRLabel lcaminho;
    public XRLabel lsaudacao;
    public XRLabel lendereco;
    public XRLabel lnome;
    public XRLabel lcomplemento;
    public XRLabel lcep;
    public XRLabel linha_17;
    public XRLabel linha_18;
    public XRLabel linha_19;
    public XRLabel linha_13;
    public XRLabel linha_14;
    public XRLabel linha_15;
    public XRLabel linha_16;
    public XRLabel linha_10;
    public XRLabel linha_9;
    public XRLabel linha_12;
    public XRLabel linha_11;
    public XRLabel linha_7;
    public XRLabel linha_8;
    public XRLabel linha_5;
    public XRLabel linha_6;
    public XRLabel linha_4;
    public XRLabel linha_3;
    public XRLabel linha_2;
    public XRLabel linha_1;
    public XRLabel lassinatura;
    public XRLabel ldata;
	
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public RepClienteCartaPadrao()
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
            //string resourceFileName = "RepClienteCartaPadrao.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lcaminho = new DevExpress.XtraReports.UI.XRLabel();
            this.lsaudacao = new DevExpress.XtraReports.UI.XRLabel();
            this.lnome = new DevExpress.XtraReports.UI.XRLabel();
            this.lendereco = new DevExpress.XtraReports.UI.XRLabel();
            this.lcomplemento = new DevExpress.XtraReports.UI.XRLabel();
            this.lcep = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_2 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_3 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_4 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_5 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_6 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_7 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_8 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_9 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_10 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_11 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_12 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_14 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_13 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_16 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_15 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_19 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_18 = new DevExpress.XtraReports.UI.XRLabel();
            this.linha_17 = new DevExpress.XtraReports.UI.XRLabel();
            this.ldata = new DevExpress.XtraReports.UI.XRLabel();
            this.lassinatura = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lassinatura,
            this.ldata,
            this.linha_17,
            this.linha_18,
            this.linha_19,
            this.linha_13,
            this.linha_14,
            this.linha_15,
            this.linha_16,
            this.linha_10,
            this.linha_9,
            this.linha_12,
            this.linha_11,
            this.linha_7,
            this.linha_8,
            this.linha_5,
            this.linha_6,
            this.linha_4,
            this.linha_3,
            this.linha_2,
            this.linha_1,
            this.lcep,
            this.lcomplemento,
            this.lendereco,
            this.lnome,
            this.lsaudacao});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 664.1666F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
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
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 24.16428F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            this.lcaminho.Text = "Gitano Software";
            // 
            // lsaudacao
            // 
            this.lsaudacao.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsaudacao.LocationFloat = new DevExpress.Utils.PointFloat(67F, 20.83333F);
            this.lsaudacao.Name = "lsaudacao";
            this.lsaudacao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lsaudacao.SizeF = new System.Drawing.SizeF(322.9165F, 14F);
            this.lsaudacao.StylePriority.UseFont = false;
            this.lsaudacao.Text = "lsaudacao";
            // 
            // lnome
            // 
            this.lnome.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnome.LocationFloat = new DevExpress.Utils.PointFloat(67F, 35.83334F);
            this.lnome.Name = "lnome";
            this.lnome.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lnome.SizeF = new System.Drawing.SizeF(322.9165F, 14F);
            this.lnome.StylePriority.UseFont = false;
            this.lnome.Text = "lnome";
            // 
            // lendereco
            // 
            this.lendereco.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lendereco.LocationFloat = new DevExpress.Utils.PointFloat(67F, 50.83333F);
            this.lendereco.Name = "lendereco";
            this.lendereco.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendereco.SizeF = new System.Drawing.SizeF(322.9165F, 14F);
            this.lendereco.StylePriority.UseFont = false;
            this.lendereco.Text = "lendereco";
            // 
            // lcomplemento
            // 
            this.lcomplemento.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcomplemento.LocationFloat = new DevExpress.Utils.PointFloat(67F, 65.83331F);
            this.lcomplemento.Name = "lcomplemento";
            this.lcomplemento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcomplemento.SizeF = new System.Drawing.SizeF(322.9165F, 13.99999F);
            this.lcomplemento.StylePriority.UseFont = false;
            this.lcomplemento.Text = "lcomplemento";
            // 
            // lcep
            // 
            this.lcep.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcep.LocationFloat = new DevExpress.Utils.PointFloat(67F, 80.83331F);
            this.lcep.Name = "lcep";
            this.lcep.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcep.SizeF = new System.Drawing.SizeF(322.9165F, 14F);
            this.lcep.StylePriority.UseFont = false;
            this.lcep.Text = "lcep";
            // 
            // linha_1
            // 
            this.linha_1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_1.LocationFloat = new DevExpress.Utils.PointFloat(72F, 141.7083F);
            this.linha_1.Name = "linha_1";
            this.linha_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_1.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_1.StylePriority.UseFont = false;
            this.linha_1.Text = "linha_1";
            // 
            // linha_2
            // 
            this.linha_2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_2.LocationFloat = new DevExpress.Utils.PointFloat(72F, 156.7083F);
            this.linha_2.Name = "linha_2";
            this.linha_2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_2.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_2.StylePriority.UseFont = false;
            this.linha_2.Text = "linha_2";
            // 
            // linha_3
            // 
            this.linha_3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_3.LocationFloat = new DevExpress.Utils.PointFloat(72F, 171.6875F);
            this.linha_3.Name = "linha_3";
            this.linha_3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_3.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_3.StylePriority.UseFont = false;
            this.linha_3.Text = "linha_3";
            // 
            // linha_4
            // 
            this.linha_4.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_4.LocationFloat = new DevExpress.Utils.PointFloat(72F, 186.6875F);
            this.linha_4.Name = "linha_4";
            this.linha_4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_4.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_4.StylePriority.UseFont = false;
            this.linha_4.Text = "linha_4";
            // 
            // linha_5
            // 
            this.linha_5.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_5.LocationFloat = new DevExpress.Utils.PointFloat(72.49997F, 201.9063F);
            this.linha_5.Name = "linha_5";
            this.linha_5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_5.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_5.StylePriority.UseFont = false;
            this.linha_5.Text = "linha_5";
            // 
            // linha_6
            // 
            this.linha_6.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_6.LocationFloat = new DevExpress.Utils.PointFloat(72.49997F, 216.9063F);
            this.linha_6.Name = "linha_6";
            this.linha_6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_6.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_6.StylePriority.UseFont = false;
            this.linha_6.Text = "linha_6";
            // 
            // linha_7
            // 
            this.linha_7.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_7.LocationFloat = new DevExpress.Utils.PointFloat(72.49998F, 231.8854F);
            this.linha_7.Name = "linha_7";
            this.linha_7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_7.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_7.StylePriority.UseFont = false;
            this.linha_7.Text = "linha_7";
            // 
            // linha_8
            // 
            this.linha_8.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_8.LocationFloat = new DevExpress.Utils.PointFloat(72.49998F, 247.8854F);
            this.linha_8.Name = "linha_8";
            this.linha_8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_8.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_8.StylePriority.UseFont = false;
            this.linha_8.Text = "linha_8";
            // 
            // linha_9
            // 
            this.linha_9.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_9.LocationFloat = new DevExpress.Utils.PointFloat(72.24994F, 263.3073F);
            this.linha_9.Name = "linha_9";
            this.linha_9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_9.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_9.StylePriority.UseFont = false;
            this.linha_9.Text = "linha_9";
            // 
            // linha_10
            // 
            this.linha_10.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_10.LocationFloat = new DevExpress.Utils.PointFloat(72.24994F, 278.3073F);
            this.linha_10.Name = "linha_10";
            this.linha_10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_10.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_10.StylePriority.UseFont = false;
            this.linha_10.Text = "linha_10";
            // 
            // linha_11
            // 
            this.linha_11.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_11.LocationFloat = new DevExpress.Utils.PointFloat(72.24995F, 293.2864F);
            this.linha_11.Name = "linha_11";
            this.linha_11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_11.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_11.StylePriority.UseFont = false;
            this.linha_11.Text = "linha_11";
            // 
            // linha_12
            // 
            this.linha_12.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_12.LocationFloat = new DevExpress.Utils.PointFloat(72.24995F, 308.2864F);
            this.linha_12.Name = "linha_12";
            this.linha_12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_12.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_12.StylePriority.UseFont = false;
            this.linha_12.Text = "linha_12";
            // 
            // linha_14
            // 
            this.linha_14.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_14.LocationFloat = new DevExpress.Utils.PointFloat(72.74991F, 338.5052F);
            this.linha_14.Name = "linha_14";
            this.linha_14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_14.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_14.StylePriority.UseFont = false;
            this.linha_14.Text = "linha_14";
            // 
            // linha_13
            // 
            this.linha_13.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_13.LocationFloat = new DevExpress.Utils.PointFloat(72.74991F, 323.5052F);
            this.linha_13.Name = "linha_13";
            this.linha_13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_13.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_13.StylePriority.UseFont = false;
            this.linha_13.Text = "linha_13";
            // 
            // linha_16
            // 
            this.linha_16.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_16.LocationFloat = new DevExpress.Utils.PointFloat(72.74992F, 368.4844F);
            this.linha_16.Name = "linha_16";
            this.linha_16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_16.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_16.StylePriority.UseFont = false;
            this.linha_16.Text = "linha_16";
            // 
            // linha_15
            // 
            this.linha_15.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_15.LocationFloat = new DevExpress.Utils.PointFloat(72.74992F, 353.4844F);
            this.linha_15.Name = "linha_15";
            this.linha_15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_15.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_15.StylePriority.UseFont = false;
            this.linha_15.Text = "linha_15";
            // 
            // linha_19
            // 
            this.linha_19.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_19.LocationFloat = new DevExpress.Utils.PointFloat(71.49998F, 414.3229F);
            this.linha_19.Name = "linha_19";
            this.linha_19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_19.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_19.StylePriority.UseFont = false;
            this.linha_19.Text = "linha_19";
            // 
            // linha_18
            // 
            this.linha_18.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_18.LocationFloat = new DevExpress.Utils.PointFloat(71.49998F, 399.3229F);
            this.linha_18.Name = "linha_18";
            this.linha_18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_18.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_18.StylePriority.UseFont = false;
            this.linha_18.Text = "linha_18";
            // 
            // linha_17
            // 
            this.linha_17.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linha_17.LocationFloat = new DevExpress.Utils.PointFloat(71.49997F, 384.3438F);
            this.linha_17.Name = "linha_17";
            this.linha_17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linha_17.SizeF = new System.Drawing.SizeF(500F, 14.00002F);
            this.linha_17.StylePriority.UseFont = false;
            this.linha_17.Text = "linha_17";
            // 
            // ldata
            // 
            this.ldata.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldata.LocationFloat = new DevExpress.Utils.PointFloat(154.5F, 469.2083F);
            this.ldata.Name = "ldata";
            this.ldata.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldata.SizeF = new System.Drawing.SizeF(337.8334F, 14F);
            this.ldata.StylePriority.UseFont = false;
            this.ldata.Text = "ldata";
            // 
            // lassinatura
            // 
            this.lassinatura.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.lassinatura.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lassinatura.LocationFloat = new DevExpress.Utils.PointFloat(154.5F, 535F);
            this.lassinatura.Name = "lassinatura";
            this.lassinatura.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lassinatura.SizeF = new System.Drawing.SizeF(337.8334F, 14F);
            this.lassinatura.StylePriority.UseBorders = false;
            this.lassinatura.StylePriority.UseFont = false;
            // 
            // RepClienteCartaPadrao
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter});
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
            this.Margins = new System.Drawing.Printing.Margins(50, 70, 49, 24);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1,
            this.xrControlStyle2});
            this.Version = "13.2";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepClienteCartaPadrao_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

    public string carta = "";

	private void RepClienteCartaPadrao_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
	{
        //

	}

    private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //Cliente
        //
        string sexo = "";
        string endereco = "";
        string complemento = "";
        string bairro = "";
        string cidade = "";
        string uf = "";
        string cep = "";

        if (Convert.ToString(GetCurrentColumnValue("endereco")) != "R")
        {
            sexo = Convert.ToString(GetCurrentColumnValue("sexo"));
            endereco = Convert.ToString(GetCurrentColumnValue("enderecocom"));
            complemento = Convert.ToString(GetCurrentColumnValue("enderecocomcomplem"));
            bairro = Convert.ToString(GetCurrentColumnValue("bairrocom"));
            cidade = Convert.ToString(GetCurrentColumnValue("cidadecom"));
            uf = Convert.ToString(GetCurrentColumnValue("ufcom"));
            cep = Convert.ToString(GetCurrentColumnValue("cepcom"));
        }
        else
        {
            sexo = Convert.ToString(GetCurrentColumnValue("sexo"));
            endereco = Convert.ToString(GetCurrentColumnValue("enderecores"));
            complemento = Convert.ToString(GetCurrentColumnValue("enderecorescomplem"));
            bairro = Convert.ToString(GetCurrentColumnValue("bairrores"));
            cidade = Convert.ToString(GetCurrentColumnValue("cidaderes"));
            uf = Convert.ToString(GetCurrentColumnValue("ufres"));
            cep = Convert.ToString(GetCurrentColumnValue("cepres"));
        }
        //
        if (sexo == "M")
        {
            lsaudacao.Text = "Ilmo. Sr.";
        }
        else
        {
            if (sexo == "F")
            {
                lsaudacao.Text = "Ilma. Sra.";
            }
            else
            {
                lsaudacao.Text = "Á";
            }
        }
        lendereco.Text = endereco;
        if (complemento != "")
        {
            lendereco.Text = endereco+"-"+complemento;
        }
        lcomplemento.Text = bairro + "-" + cidade + "-" + uf;
        lcep.Text = cep;
        //Fim Cliente
        //
        //Carta
        DataSet ds = uMalaDireta.PegaDadosCarta(carta);
        //
        linha_1.Text = ds.Tables[0].Rows[0]["linha_1"].ToString();
        linha_2.Text = ds.Tables[0].Rows[0]["linha_2"].ToString();
        linha_3.Text = ds.Tables[0].Rows[0]["linha_3"].ToString();
        linha_4.Text = ds.Tables[0].Rows[0]["linha_4"].ToString();
        linha_5.Text = ds.Tables[0].Rows[0]["linha_5"].ToString();
        linha_6.Text = ds.Tables[0].Rows[0]["linha_6"].ToString();
        linha_7.Text = ds.Tables[0].Rows[0]["linha_7"].ToString();
        linha_8.Text = ds.Tables[0].Rows[0]["linha_8"].ToString();
        linha_9.Text = ds.Tables[0].Rows[0]["linha_9"].ToString();
        linha_10.Text = ds.Tables[0].Rows[0]["linha_10"].ToString();
        linha_11.Text = ds.Tables[0].Rows[0]["linha_11"].ToString();
        linha_12.Text = ds.Tables[0].Rows[0]["linha_12"].ToString();
        linha_13.Text = ds.Tables[0].Rows[0]["linha_13"].ToString();
        linha_14.Text = ds.Tables[0].Rows[0]["linha_14"].ToString();
        linha_15.Text = ds.Tables[0].Rows[0]["linha_15"].ToString();
        linha_16.Text = ds.Tables[0].Rows[0]["linha_16"].ToString();
        linha_17.Text = ds.Tables[0].Rows[0]["linha_17"].ToString();
        linha_18.Text = ds.Tables[0].Rows[0]["linha_18"].ToString();
        linha_19.Text = ds.Tables[0].Rows[0]["linha_19"].ToString();
        //Fim Carta

    }


}
