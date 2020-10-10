using DevExpress.XtraReports.UI;
using System;

/// <summary>
/// Summary description for RepAReceberDepositos
/// </summary>
public class RepAReceberDepositos : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRControlStyle xrControlStyle1;
    private XRControlStyle xrControlStyle2;
    private FormattingRule formattingRule1;
    public XRLabel lvalorextenso1;
    public XRLabel lvalor;
    public XRLabel lvalorextenso2;
    public XRLabel lemissaoextenso;
    public XRLabel lnominal;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public RepAReceberDepositos()
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
        //string resourceFileName = "RepAReceberDepositos.resx";
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.lvalorextenso2 = new DevExpress.XtraReports.UI.XRLabel();
        this.lvalorextenso1 = new DevExpress.XtraReports.UI.XRLabel();
        this.lvalor = new DevExpress.XtraReports.UI.XRLabel();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
        this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
        this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
        this.lnominal = new DevExpress.XtraReports.UI.XRLabel();
        this.lemissaoextenso = new DevExpress.XtraReports.UI.XRLabel();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.BorderWidth = 1F;
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lemissaoextenso,
            this.lnominal,
            this.lvalorextenso2,
            this.lvalorextenso1,
            this.lvalor});
        this.Detail.EvenStyleName = "xrControlStyle1";
        this.Detail.ForeColor = System.Drawing.Color.Black;
        this.Detail.HeightF = 400F;
        this.Detail.Name = "Detail";
        this.Detail.OddStyleName = "xrControlStyle2";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
        this.Detail.StylePriority.UseBorderWidth = false;
        this.Detail.StylePriority.UseForeColor = false;
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
        // 
        // lvalorextenso2
        // 
        this.lvalorextenso2.BackColor = System.Drawing.Color.Transparent;
        this.lvalorextenso2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lvalorextenso2.LocationFloat = new DevExpress.Utils.PointFloat(68.00008F, 103.1667F);
        this.lvalorextenso2.Name = "lvalorextenso2";
        this.lvalorextenso2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lvalorextenso2.SizeF = new System.Drawing.SizeF(790.0418F, 20F);
        this.lvalorextenso2.StylePriority.UseBackColor = false;
        this.lvalorextenso2.StylePriority.UseFont = false;
        this.lvalorextenso2.Text = "lvalorextenso2";
        // 
        // lvalorextenso1
        // 
        this.lvalorextenso1.BackColor = System.Drawing.Color.Transparent;
        this.lvalorextenso1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lvalorextenso1.LocationFloat = new DevExpress.Utils.PointFloat(220.0834F, 74.16666F);
        this.lvalorextenso1.Name = "lvalorextenso1";
        this.lvalorextenso1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lvalorextenso1.SizeF = new System.Drawing.SizeF(773.3752F, 19.99999F);
        this.lvalorextenso1.StylePriority.UseBackColor = false;
        this.lvalorextenso1.StylePriority.UseFont = false;
        this.lvalorextenso1.Text = "lvalorextenso1";
        // 
        // lvalor
        // 
        this.lvalor.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lvalor.LocationFloat = new DevExpress.Utils.PointFloat(798.6668F, 30.95833F);
        this.lvalor.Name = "lvalor";
        this.lvalor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lvalor.SizeF = new System.Drawing.SizeF(194.7917F, 20F);
        this.lvalor.StylePriority.UseFont = false;
        this.lvalor.Text = "lvalor";
        // 
        // TopMargin
        // 
        this.TopMargin.BackColor = System.Drawing.Color.Transparent;
        this.TopMargin.HeightF = 0F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.StylePriority.UseBackColor = false;
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // BottomMargin
        // 
        this.BottomMargin.HeightF = 0F;
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
        // lnominal
        // 
        this.lnominal.BackColor = System.Drawing.Color.Transparent;
        this.lnominal.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lnominal.LocationFloat = new DevExpress.Utils.PointFloat(116.9584F, 131.1667F);
        this.lnominal.Name = "lnominal";
        this.lnominal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lnominal.SizeF = new System.Drawing.SizeF(876.5002F, 20F);
        this.lnominal.StylePriority.UseBackColor = false;
        this.lnominal.StylePriority.UseFont = false;
        this.lnominal.Text = "lnominal";
        // 
        // lemissaoextenso
        // 
        this.lemissaoextenso.BackColor = System.Drawing.Color.Transparent;
        this.lemissaoextenso.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lemissaoextenso.LocationFloat = new DevExpress.Utils.PointFloat(552.3749F, 234.375F);
        this.lemissaoextenso.Name = "lemissaoextenso";
        this.lemissaoextenso.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.lemissaoextenso.SizeF = new System.Drawing.SizeF(441.0836F, 20.00002F);
        this.lemissaoextenso.StylePriority.UseBackColor = false;
        this.lemissaoextenso.StylePriority.UseFont = false;
        this.lemissaoextenso.Text = "lemissaoextenso";
        // 
        // RepAReceberDepositos
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
        this.Font = new System.Drawing.Font("Calibri", 9.75F);
        this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
        this.Landscape = true;
        this.Margins = new System.Drawing.Printing.Margins(50, 70, 0, 0);
        this.PageHeight = 827;
        this.PageWidth = 1169;
        this.PaperKind = System.Drawing.Printing.PaperKind.A4;
        this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1,
            this.xrControlStyle2});
        this.Version = "13.2";
        this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepAReceberDepositos_BeforePrint);
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    //
    public Int32 quantidade = 0;
    public Boolean ckconjuge = false;
    public string rbdatabase;
    public string rbvalores;
    public string rbcompensacao;


    private void RepAReceberDepositos_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
        string valor = Convert.ToString(GetCurrentColumnValue("vlr_previsto"));
        //
        if (valor.Trim() == "0,00")
        {
            if (rbvalores == "P")
            {
                e.Cancel = true;
            }
        }
        lvalor.Text = Srelib.forcaponto(valor);
        //
        DateTime emissao = Convert.ToDateTime(GetCurrentColumnValue("data_prevista"));
        // 
        ValorExtenso xExt = new ValorExtenso();
        String xAux;
        xAux = xExt.ValExtenso(Convert.ToDouble(valor));
        lvalorextenso1.Text = xAux;
        lvalorextenso2.Text = " ";
        //
        Int32 fornecedor = Convert.ToInt32(GetCurrentColumnValue("fornecedor"));
        lnominal.Text = uFornecedores.PegaNomeFornecedor(fornecedor);
        //
        lemissaoextenso.Text = uEmpresa.PegaCidade(uEmpresa.PegaMatriz()) + ", " + Srelib.DataExtenso(DateTime.Now);
        //
        //Compensação
        if (rbcompensacao == "1")
        {
            //Compensação na Data da emissão do Cheque
            string lancamento = Convert.ToString(GetCurrentColumnValue("lancamento"));
            //
            uContasReceber.GravaCompensacao(lancamento, DateTime.Now.ToString().Substring(0, 10), "0");
        }

    }

}
