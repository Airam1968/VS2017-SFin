using DevExpress.XtraReports.UI;
using System;

/// <summary>
/// Summary description for RepAPagarCheques
/// </summary>
public class RepAPagarCheques : DevExpress.XtraReports.UI.XtraReport
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

    public RepAPagarCheques()
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
            string resourceFileName = "RepAPagarCheques.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lemissaoextenso = new DevExpress.XtraReports.UI.XRLabel();
            this.lnominal = new DevExpress.XtraReports.UI.XRLabel();
            this.lvalorextenso2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvalorextenso1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvalor = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
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
            this.Detail.HeightF = 285.4166F;
            this.Detail.KeepTogether = true;
            this.Detail.KeepTogetherWithDetailReports = true;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseBorderWidth = false;
            this.Detail.StylePriority.UseForeColor = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // lemissaoextenso
            // 
            this.lemissaoextenso.BackColor = System.Drawing.Color.Transparent;
            this.lemissaoextenso.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemissaoextenso.LocationFloat = new DevExpress.Utils.PointFloat(303.8331F, 121.7917F);
            this.lemissaoextenso.Name = "lemissaoextenso";
            this.lemissaoextenso.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lemissaoextenso.SizeF = new System.Drawing.SizeF(393.1669F, 20.00001F);
            this.lemissaoextenso.StylePriority.UseBackColor = false;
            this.lemissaoextenso.StylePriority.UseFont = false;
            this.lemissaoextenso.Text = "lemissaoextenso";
            // 
            // lnominal
            // 
            this.lnominal.BackColor = System.Drawing.Color.Transparent;
            this.lnominal.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnominal.LocationFloat = new DevExpress.Utils.PointFloat(54.79167F, 93.58333F);
            this.lnominal.Name = "lnominal";
            this.lnominal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lnominal.SizeF = new System.Drawing.SizeF(549.5F, 20F);
            this.lnominal.StylePriority.UseBackColor = false;
            this.lnominal.StylePriority.UseFont = false;
            this.lnominal.Text = "lnominal";
            // 
            // lvalorextenso2
            // 
            this.lvalorextenso2.BackColor = System.Drawing.Color.Transparent;
            this.lvalorextenso2.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalorextenso2.LocationFloat = new DevExpress.Utils.PointFloat(34.79167F, 69.20837F);
            this.lvalorextenso2.Name = "lvalorextenso2";
            this.lvalorextenso2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvalorextenso2.SizeF = new System.Drawing.SizeF(612F, 20F);
            this.lvalorextenso2.StylePriority.UseBackColor = false;
            this.lvalorextenso2.StylePriority.UseFont = false;
            this.lvalorextenso2.Text = "lvalorextenso2";
            // 
            // lvalorextenso1
            // 
            this.lvalorextenso1.BackColor = System.Drawing.Color.Transparent;
            this.lvalorextenso1.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalorextenso1.LocationFloat = new DevExpress.Utils.PointFloat(127.7083F, 44.08331F);
            this.lvalorextenso1.Name = "lvalorextenso1";
            this.lvalorextenso1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvalorextenso1.SizeF = new System.Drawing.SizeF(569.2916F, 20F);
            this.lvalorextenso1.StylePriority.UseBackColor = false;
            this.lvalorextenso1.StylePriority.UseFont = false;
            this.lvalorextenso1.Text = "lvalorextenso1";
            // 
            // lvalor
            // 
            this.lvalor.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalor.LocationFloat = new DevExpress.Utils.PointFloat(529.7916F, 10.00001F);
            this.lvalor.Name = "lvalor";
            this.lvalor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvalor.SizeF = new System.Drawing.SizeF(155.2083F, 20F);
            this.lvalor.StylePriority.UseFont = false;
            this.lvalor.StylePriority.UseTextAlignment = false;
            this.lvalor.Text = "lvalor";
            this.lvalor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
            this.BottomMargin.HeightF = 1.041667F;
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
            // RepAPagarCheques
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
            this.Margins = new System.Drawing.Printing.Margins(50, 70, 0, 1);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1,
            this.xrControlStyle2});
            this.Version = "13.2";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepAPagarCheques_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    //
    public Int32 quantidade = 0;
    public Boolean ckconjuge = false;
    public string rbdatabase;
    public string rbvalores;
    public string rbcompensacao;
    public string numerocheque;


    private void RepAPagarCheques_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        Detail.Styles.EvenStyle.BackColor = System.Drawing.Color.Empty;
        Detail.Styles.OddStyle.BackColor = System.Drawing.Color.Empty;
        Detail.Styles.EvenStyle.ForeColor = System.Drawing.Color.Black;
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
        
        lvalor.Text = "( " + String.Format("{0:N}", Convert.ToDouble(valor)) + " )";
        //
        DateTime emissao = Convert.ToDateTime(GetCurrentColumnValue("data_prevista"));
        // 
        ValorExtenso xExt = new ValorExtenso();
        String xAux;
        xAux = "( " + xExt.ValExtenso(Convert.ToDouble(valor)) + " )";
        //tamanho máximo de extenso = 70 + 100 = 170 chars
        if (xAux.Length > 170)
        {
            lvalorextenso1.Text = "Extenso supera o limite máximo de 180 characteres. Acione Suporte.";
            lvalorextenso2.Text = Srelib.replicate("*", 100);
        }
        else
        {
            if (xAux.Length <= 70)
            {
                lvalorextenso1.Text = xAux + Srelib.replicate("*", (70 - xAux.Length));
                lvalorextenso2.Text = Srelib.replicate("*", 100);
            }
            else
            {
                //> 70
                lvalorextenso1.Text = xAux.Substring(0, 70);
                lvalorextenso2.Text = xAux.Substring(70, (xAux.Length - 70)) + Srelib.replicate("*", (100 - (xAux.Length - 70)));
            }
        }
        //
        Int32 fornecedor = Convert.ToInt32(GetCurrentColumnValue("fornecedor"));
        lnominal.Text = uFornecedores.PegaNomeFornecedor(fornecedor);
        //
        lemissaoextenso.Text = uEmpresa.PegaCidade(uEmpresa.PegaMatriz()) + ",     " + Srelib.DataExtenso(DateTime.Now);
        //
        //Compensação
        if (rbcompensacao == "1")
        {
            //Compensação na Data da emissão do Cheque
            string lancamento = Convert.ToString(GetCurrentColumnValue("lancamento"));
            //
            uContasPagar.GravaCompensacao(lancamento,
                                          DateTime.Now.ToString().Substring(0, 10),
                                          numerocheque);
            numerocheque = (Convert.ToInt16(numerocheque) + 1).ToString();
        }

    }

}
