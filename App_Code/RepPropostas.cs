using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for RepPropostas
/// </summary>
public class RepPropostas : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private PageHeaderBand PageHeader;
    private XRPageInfo xrPageInfo2;
    public XRLabel ltitulorelatorio;
    private XRPageInfo xrPageInfo3;
    public XRLabel ltempresa;
    public XRLabel ltusuario;
    private XRPictureBox xrPictureBox1;
    private XRControlStyle xrControlStyle1;
    private XRControlStyle xrControlStyle2;
    private FormattingRule formattingRule1;
    private PageFooterBand PageFooter;
    public XRLabel lcaminho;
    public XRLabel lemissaoextenso;
    private XRLine xrLine2;
    public XRLabel lvinculo1;
    public XRLabel lproponente;
    public XRLabel xrLabel11;
    public XRLabel lvalorsinal;
    public XRLabel lvalorsaldo;
    public XRLabel xrLabel6;
    public XRLabel lvalorvenda;
    public XRLabel xrLabel9;
    public XRLabel lconjugeprofissao;
    public XRLabel lconjugenacionalidade;
    public XRLabel xrLabel29;
    public XRLabel xrLabel32;
    public XRLabel lconjugecpf;
    public XRLabel xrLabel24;
    public XRLabel lconjuge;
    public XRLabel lconjugerg;
    public XRLabel xrLabel27;
    public XRLabel xrLabel26;
    public XRLabel xrLabel23;
    public XRLabel lclienteregimecasamento;
    public XRLabel xrLabel22;
    public XRLabel lclienteestadocivil;
    public XRLabel xrLabel13;
    public XRLabel lclienteprofissao;
    public XRLabel lclientenacionalidade;
    public XRLabel xrLabel21;
    public XRLabel lclienterg;
    public XRLabel xrLabel19;
    public XRLabel xrLabel17;
    public XRLabel lclientecpf;
    public XRLabel lproduto;
    public XRLabel xrLabel18;
    public XRLabel lcliente;
    public XRLabel lproposta;
    public XRLabel xrLabel15;
    public XRLabel xrLabel16;
    public XRLabel lcomissao;
    public XRLabel ltabelaprice;
    public XRLabel xrLabel20;
    public XRLabel xrLabel25;
    public XRLabel lprodutogrupo;
    public XRLabel xrLabel28;
    public XRLabel lopcaodeplanta;
    public XRLabel xrLabel3;
    public XRLabel lprodutogrupounidade;
    public XRLabel xrLabel2;
    public XRLabel limovelendereco;
    public XRLabel xrLabel1;
    public XRLabel xrLabel4;
    public XRLabel xrLabel8;
    public XRLabel lqtdparcela01;
    public XRLabel xrLabel5;
    public XRLabel lvencimentoparcela01;
    public XRLabel xrLabel10;
    public XRLabel lparcelavalor01;
    public XRLabel xrLabel7;
    public XRLabel lparcelatipo01;
    public XRLabel lparcelavalor02;
    public XRLabel xrLabel35;
    public XRLabel lvencimentoparcela02;
    public XRLabel xrLabel33;
    public XRLabel lqtdparcela02;
    public XRLabel xrLabel30;
    public XRLabel lparcelatipo02;
    public XRLabel lqtdparcela07;
    public XRLabel xrLabel70;
    public XRLabel lparcelatipo07;
    public XRLabel xrLabel68;
    public XRLabel lparcelavalor07;
    public XRLabel xrLabel66;
    public XRLabel lvencimentoparcela07;
    public XRLabel lparcelatipo08;
    public XRLabel xrLabel77;
    public XRLabel lqtdparcela08;
    public XRLabel xrLabel75;
    public XRLabel lvencimentoparcela08;
    public XRLabel xrLabel73;
    public XRLabel lparcelavalor08;
    public XRLabel lparcelavalor05;
    public XRLabel xrLabel56;
    public XRLabel lvencimentoparcela05;
    public XRLabel xrLabel54;
    public XRLabel lqtdparcela05;
    public XRLabel xrLabel52;
    public XRLabel lparcelatipo05;
    public XRLabel lvencimentoparcela06;
    public XRLabel xrLabel63;
    public XRLabel lparcelavalor06;
    public XRLabel xrLabel61;
    public XRLabel lparcelatipo06;
    public XRLabel xrLabel59;
    public XRLabel lqtdparcela06;
    public XRLabel lqtdparcela04;
    public XRLabel xrLabel45;
    public XRLabel lparcelatipo04;
    public XRLabel xrLabel47;
    public XRLabel lparcelavalor04;
    public XRLabel xrLabel49;
    public XRLabel lvencimentoparcela04;
    public XRLabel lparcelatipo03;
    public XRLabel xrLabel38;
    public XRLabel lqtdparcela03;
    public XRLabel xrLabel40;
    public XRLabel lvencimentoparcela03;
    public XRLabel xrLabel42;
    public XRLabel lparcelavalor03;
    public XRLabel ldataproposta;
    public XRLabel xrLabel79;
    public XRLabel lcorretor;
    private XRLine xrLine1;
    public XRLabel xrLabel36;
    public XRLabel xrLabel34;
    public XRLabel lindice2;
    public XRLabel xrLabel31;
    public XRLabel lindice;
    public XRLabel xrLabel14;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public RepPropostas()
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
            //string resourceFileName = "RepPropostas.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lcorretor = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.lindice2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.lindice = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.ldataproposta = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel79 = new DevExpress.XtraReports.UI.XRLabel();
            this.lqtdparcela07 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel70 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelatipo07 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel68 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelavalor07 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel66 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvencimentoparcela07 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelatipo08 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel77 = new DevExpress.XtraReports.UI.XRLabel();
            this.lqtdparcela08 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel75 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvencimentoparcela08 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel73 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelavalor08 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelavalor05 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel56 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvencimentoparcela05 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
            this.lqtdparcela05 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelatipo05 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvencimentoparcela06 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel63 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelavalor06 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelatipo06 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
            this.lqtdparcela06 = new DevExpress.XtraReports.UI.XRLabel();
            this.lqtdparcela04 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelatipo04 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelavalor04 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvencimentoparcela04 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelatipo03 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            this.lqtdparcela03 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvencimentoparcela03 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelavalor03 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelavalor02 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvencimentoparcela02 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.lqtdparcela02 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelatipo02 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvencimentoparcela01 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelavalor01 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.lparcelatipo01 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.lqtdparcela01 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lopcaodeplanta = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lprodutogrupounidade = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.limovelendereco = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lprodutogrupo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.lcomissao = new DevExpress.XtraReports.UI.XRLabel();
            this.ltabelaprice = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.lconjugeprofissao = new DevExpress.XtraReports.UI.XRLabel();
            this.lconjugenacionalidade = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.lconjugecpf = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.lconjuge = new DevExpress.XtraReports.UI.XRLabel();
            this.lconjugerg = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.lclienteregimecasamento = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.lclienteestadocivil = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.lclienteprofissao = new DevExpress.XtraReports.UI.XRLabel();
            this.lclientenacionalidade = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.lclienterg = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.lclientecpf = new DevExpress.XtraReports.UI.XRLabel();
            this.lproduto = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.lcliente = new DevExpress.XtraReports.UI.XRLabel();
            this.lproposta = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvalorsinal = new DevExpress.XtraReports.UI.XRLabel();
            this.lvalorsaldo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvalorvenda = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.lproponente = new DevExpress.XtraReports.UI.XRLabel();
            this.lemissaoextenso = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.lvinculo1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.ltusuario = new DevExpress.XtraReports.UI.XRLabel();
            this.ltempresa = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ltitulorelatorio = new DevExpress.XtraReports.UI.XRLabel();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lcaminho = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lcorretor,
            this.xrLine1,
            this.xrLabel36,
            this.xrLabel34,
            this.lindice2,
            this.xrLabel31,
            this.lindice,
            this.xrLabel14,
            this.ldataproposta,
            this.xrLabel79,
            this.lqtdparcela07,
            this.xrLabel70,
            this.lparcelatipo07,
            this.xrLabel68,
            this.lparcelavalor07,
            this.xrLabel66,
            this.lvencimentoparcela07,
            this.lparcelatipo08,
            this.xrLabel77,
            this.lqtdparcela08,
            this.xrLabel75,
            this.lvencimentoparcela08,
            this.xrLabel73,
            this.lparcelavalor08,
            this.lparcelavalor05,
            this.xrLabel56,
            this.lvencimentoparcela05,
            this.xrLabel54,
            this.lqtdparcela05,
            this.xrLabel52,
            this.lparcelatipo05,
            this.lvencimentoparcela06,
            this.xrLabel63,
            this.lparcelavalor06,
            this.xrLabel61,
            this.lparcelatipo06,
            this.xrLabel59,
            this.lqtdparcela06,
            this.lqtdparcela04,
            this.xrLabel45,
            this.lparcelatipo04,
            this.xrLabel47,
            this.lparcelavalor04,
            this.xrLabel49,
            this.lvencimentoparcela04,
            this.lparcelatipo03,
            this.xrLabel38,
            this.lqtdparcela03,
            this.xrLabel40,
            this.lvencimentoparcela03,
            this.xrLabel42,
            this.lparcelavalor03,
            this.lparcelavalor02,
            this.xrLabel35,
            this.lvencimentoparcela02,
            this.xrLabel33,
            this.lqtdparcela02,
            this.xrLabel30,
            this.lparcelatipo02,
            this.lvencimentoparcela01,
            this.xrLabel10,
            this.lparcelavalor01,
            this.xrLabel7,
            this.lparcelatipo01,
            this.xrLabel8,
            this.lqtdparcela01,
            this.xrLabel5,
            this.xrLabel4,
            this.lopcaodeplanta,
            this.xrLabel3,
            this.lprodutogrupounidade,
            this.xrLabel2,
            this.limovelendereco,
            this.xrLabel1,
            this.lprodutogrupo,
            this.xrLabel28,
            this.lcomissao,
            this.ltabelaprice,
            this.xrLabel20,
            this.xrLabel25,
            this.lconjugeprofissao,
            this.lconjugenacionalidade,
            this.xrLabel29,
            this.xrLabel32,
            this.lconjugecpf,
            this.xrLabel24,
            this.lconjuge,
            this.lconjugerg,
            this.xrLabel27,
            this.xrLabel26,
            this.xrLabel23,
            this.lclienteregimecasamento,
            this.xrLabel22,
            this.lclienteestadocivil,
            this.xrLabel13,
            this.lclienteprofissao,
            this.lclientenacionalidade,
            this.xrLabel21,
            this.lclienterg,
            this.xrLabel19,
            this.xrLabel17,
            this.lclientecpf,
            this.lproduto,
            this.xrLabel18,
            this.lcliente,
            this.lproposta,
            this.xrLabel15,
            this.xrLabel16,
            this.xrLabel11,
            this.lvalorsinal,
            this.lvalorsaldo,
            this.xrLabel6,
            this.lvalorvenda,
            this.xrLabel9,
            this.lproponente,
            this.lemissaoextenso,
            this.xrLine2,
            this.lvinculo1});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 734.8586F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // lcorretor
            // 
            this.lcorretor.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcorretor.LocationFloat = new DevExpress.Utils.PointFloat(400.4166F, 710.8586F);
            this.lcorretor.Name = "lcorretor";
            this.lcorretor.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcorretor.SizeF = new System.Drawing.SizeF(259.6042F, 14F);
            this.lcorretor.StylePriority.UseFont = false;
            this.lcorretor.Text = "lcorretor";
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(400.4166F, 696.9836F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(259.6043F, 7.375F);
            // 
            // xrLabel36
            // 
            this.xrLabel36.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(15.99995F, 615.625F);
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(680.7707F, 14F);
            this.xrLabel36.StylePriority.UseFont = false;
            this.xrLabel36.Text = "Esta proposta tem validade de 10 dias para assinatura do contrato definitivo de v" +
    "enda e compra e suas respectivas promissórias.";
            // 
            // xrLabel34
            // 
            this.xrLabel34.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(15.99994F, 581.6376F);
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(289.646F, 14F);
            this.xrLabel34.StylePriority.UseFont = false;
            this.xrLabel34.Text = "acrescido de juros de 1% ao mês.";
            // 
            // lindice2
            // 
            this.lindice2.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lindice2.LocationFloat = new DevExpress.Utils.PointFloat(305.6458F, 566.6376F);
            this.lindice2.Name = "lindice2";
            this.lindice2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lindice2.SizeF = new System.Drawing.SizeF(391.3541F, 14F);
            this.lindice2.StylePriority.UseFont = false;
            this.lindice2.Text = "lindice2";
            // 
            // xrLabel31
            // 
            this.xrLabel31.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(15.99989F, 566.6376F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(289.646F, 14F);
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.Text = ", até o habite-se ou entrega das chaves e após pelo indice :";
            // 
            // lindice
            // 
            this.lindice.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lindice.LocationFloat = new DevExpress.Utils.PointFloat(307.6459F, 550.6376F);
            this.lindice.Name = "lindice";
            this.lindice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lindice.SizeF = new System.Drawing.SizeF(389.1247F, 14F);
            this.lindice.StylePriority.UseFont = false;
            this.lindice.Text = "lindice";
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(15.77053F, 550.6376F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(289.8753F, 14F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.Text = "Todas as parcelas serão corrigidas mensalmente pelo indice :";
            // 
            // ldataproposta
            // 
            this.ldataproposta.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldataproposta.LocationFloat = new DevExpress.Utils.PointFloat(459.1463F, 4.845937F);
            this.ldataproposta.Name = "ldataproposta";
            this.ldataproposta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldataproposta.SizeF = new System.Drawing.SizeF(102F, 14F);
            this.ldataproposta.StylePriority.UseFont = false;
            this.ldataproposta.Text = "ldataproposta";
            // 
            // xrLabel79
            // 
            this.xrLabel79.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel79.LocationFloat = new DevExpress.Utils.PointFloat(367.1462F, 4.845937F);
            this.xrLabel79.Name = "xrLabel79";
            this.xrLabel79.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel79.SizeF = new System.Drawing.SizeF(92.00011F, 14F);
            this.xrLabel79.StylePriority.UseFont = false;
            this.xrLabel79.Text = "Data:";
            // 
            // lqtdparcela07
            // 
            this.lqtdparcela07.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lqtdparcela07.LocationFloat = new DevExpress.Utils.PointFloat(15.99986F, 504.9293F);
            this.lqtdparcela07.Name = "lqtdparcela07";
            this.lqtdparcela07.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lqtdparcela07.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lqtdparcela07.StylePriority.UseFont = false;
            this.lqtdparcela07.StylePriority.UseTextAlignment = false;
            this.lqtdparcela07.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel70
            // 
            this.xrLabel70.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel70.LocationFloat = new DevExpress.Utils.PointFloat(110F, 504.9293F);
            this.xrLabel70.Name = "xrLabel70";
            this.xrLabel70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel70.SizeF = new System.Drawing.SizeF(72.8334F, 14F);
            this.xrLabel70.StylePriority.UseFont = false;
            this.xrLabel70.Text = "Parcela(s)";
            // 
            // lparcelatipo07
            // 
            this.lparcelatipo07.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelatipo07.LocationFloat = new DevExpress.Utils.PointFloat(183.8334F, 504.9293F);
            this.lparcelatipo07.Name = "lparcelatipo07";
            this.lparcelatipo07.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelatipo07.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelatipo07.StylePriority.UseFont = false;
            this.lparcelatipo07.StylePriority.UseTextAlignment = false;
            this.lparcelatipo07.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel68
            // 
            this.xrLabel68.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel68.LocationFloat = new DevExpress.Utils.PointFloat(277.6042F, 504.9293F);
            this.xrLabel68.Name = "xrLabel68";
            this.xrLabel68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel68.SizeF = new System.Drawing.SizeF(28.04172F, 14F);
            this.xrLabel68.StylePriority.UseFont = false;
            this.xrLabel68.Text = "de";
            // 
            // lparcelavalor07
            // 
            this.lparcelavalor07.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelavalor07.LocationFloat = new DevExpress.Utils.PointFloat(307.6459F, 504.9293F);
            this.lparcelavalor07.Name = "lparcelavalor07";
            this.lparcelavalor07.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelavalor07.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelavalor07.StylePriority.UseFont = false;
            this.lparcelavalor07.StylePriority.UseTextAlignment = false;
            this.lparcelavalor07.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel66
            // 
            this.xrLabel66.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel66.LocationFloat = new DevExpress.Utils.PointFloat(400.4166F, 504.9293F);
            this.xrLabel66.Name = "xrLabel66";
            this.xrLabel66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel66.SizeF = new System.Drawing.SizeF(90.54178F, 14F);
            this.xrLabel66.StylePriority.UseFont = false;
            this.xrLabel66.StylePriority.UseTextAlignment = false;
            this.xrLabel66.Text = "1o. Vencimento";
            this.xrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lvencimentoparcela07
            // 
            this.lvencimentoparcela07.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvencimentoparcela07.LocationFloat = new DevExpress.Utils.PointFloat(492.9584F, 504.9293F);
            this.lvencimentoparcela07.Name = "lvencimentoparcela07";
            this.lvencimentoparcela07.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvencimentoparcela07.SizeF = new System.Drawing.SizeF(138.6458F, 14.00003F);
            this.lvencimentoparcela07.StylePriority.UseFont = false;
            this.lvencimentoparcela07.StylePriority.UseTextAlignment = false;
            this.lvencimentoparcela07.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lparcelatipo08
            // 
            this.lparcelatipo08.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelatipo08.LocationFloat = new DevExpress.Utils.PointFloat(183.8334F, 519.9293F);
            this.lparcelatipo08.Name = "lparcelatipo08";
            this.lparcelatipo08.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelatipo08.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelatipo08.StylePriority.UseFont = false;
            this.lparcelatipo08.StylePriority.UseTextAlignment = false;
            this.lparcelatipo08.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel77
            // 
            this.xrLabel77.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel77.LocationFloat = new DevExpress.Utils.PointFloat(110F, 519.9293F);
            this.xrLabel77.Name = "xrLabel77";
            this.xrLabel77.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel77.SizeF = new System.Drawing.SizeF(72.8334F, 14F);
            this.xrLabel77.StylePriority.UseFont = false;
            this.xrLabel77.Text = "Parcela(s)";
            // 
            // lqtdparcela08
            // 
            this.lqtdparcela08.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lqtdparcela08.LocationFloat = new DevExpress.Utils.PointFloat(15.99983F, 519.9293F);
            this.lqtdparcela08.Name = "lqtdparcela08";
            this.lqtdparcela08.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lqtdparcela08.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lqtdparcela08.StylePriority.UseFont = false;
            this.lqtdparcela08.StylePriority.UseTextAlignment = false;
            this.lqtdparcela08.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel75
            // 
            this.xrLabel75.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel75.LocationFloat = new DevExpress.Utils.PointFloat(277.6041F, 519.9293F);
            this.xrLabel75.Name = "xrLabel75";
            this.xrLabel75.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel75.SizeF = new System.Drawing.SizeF(28.04172F, 14F);
            this.xrLabel75.StylePriority.UseFont = false;
            this.xrLabel75.Text = "de";
            // 
            // lvencimentoparcela08
            // 
            this.lvencimentoparcela08.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvencimentoparcela08.LocationFloat = new DevExpress.Utils.PointFloat(492.9583F, 519.9293F);
            this.lvencimentoparcela08.Name = "lvencimentoparcela08";
            this.lvencimentoparcela08.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvencimentoparcela08.SizeF = new System.Drawing.SizeF(138.6458F, 14F);
            this.lvencimentoparcela08.StylePriority.UseFont = false;
            this.lvencimentoparcela08.StylePriority.UseTextAlignment = false;
            this.lvencimentoparcela08.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel73
            // 
            this.xrLabel73.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel73.LocationFloat = new DevExpress.Utils.PointFloat(400.4166F, 519.9293F);
            this.xrLabel73.Name = "xrLabel73";
            this.xrLabel73.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel73.SizeF = new System.Drawing.SizeF(90.54178F, 14F);
            this.xrLabel73.StylePriority.UseFont = false;
            this.xrLabel73.StylePriority.UseTextAlignment = false;
            this.xrLabel73.Text = "1o. Vencimento";
            this.xrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lparcelavalor08
            // 
            this.lparcelavalor08.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelavalor08.LocationFloat = new DevExpress.Utils.PointFloat(307.6459F, 519.9293F);
            this.lparcelavalor08.Name = "lparcelavalor08";
            this.lparcelavalor08.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelavalor08.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelavalor08.StylePriority.UseFont = false;
            this.lparcelavalor08.StylePriority.UseTextAlignment = false;
            this.lparcelavalor08.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lparcelavalor05
            // 
            this.lparcelavalor05.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelavalor05.LocationFloat = new DevExpress.Utils.PointFloat(307.6459F, 473.7626F);
            this.lparcelavalor05.Name = "lparcelavalor05";
            this.lparcelavalor05.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelavalor05.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelavalor05.StylePriority.UseFont = false;
            this.lparcelavalor05.StylePriority.UseTextAlignment = false;
            this.lparcelavalor05.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel56
            // 
            this.xrLabel56.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel56.LocationFloat = new DevExpress.Utils.PointFloat(400.4166F, 473.7626F);
            this.xrLabel56.Name = "xrLabel56";
            this.xrLabel56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel56.SizeF = new System.Drawing.SizeF(90.54178F, 14F);
            this.xrLabel56.StylePriority.UseFont = false;
            this.xrLabel56.StylePriority.UseTextAlignment = false;
            this.xrLabel56.Text = "1o. Vencimento";
            this.xrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lvencimentoparcela05
            // 
            this.lvencimentoparcela05.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvencimentoparcela05.LocationFloat = new DevExpress.Utils.PointFloat(492.9584F, 473.7626F);
            this.lvencimentoparcela05.Name = "lvencimentoparcela05";
            this.lvencimentoparcela05.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvencimentoparcela05.SizeF = new System.Drawing.SizeF(138.6458F, 14F);
            this.lvencimentoparcela05.StylePriority.UseFont = false;
            this.lvencimentoparcela05.StylePriority.UseTextAlignment = false;
            this.lvencimentoparcela05.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel54
            // 
            this.xrLabel54.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel54.LocationFloat = new DevExpress.Utils.PointFloat(277.6042F, 473.7626F);
            this.xrLabel54.Name = "xrLabel54";
            this.xrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel54.SizeF = new System.Drawing.SizeF(28.04172F, 14F);
            this.xrLabel54.StylePriority.UseFont = false;
            this.xrLabel54.Text = "de";
            // 
            // lqtdparcela05
            // 
            this.lqtdparcela05.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lqtdparcela05.LocationFloat = new DevExpress.Utils.PointFloat(15.99986F, 473.7626F);
            this.lqtdparcela05.Name = "lqtdparcela05";
            this.lqtdparcela05.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lqtdparcela05.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lqtdparcela05.StylePriority.UseFont = false;
            this.lqtdparcela05.StylePriority.UseTextAlignment = false;
            this.lqtdparcela05.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel52
            // 
            this.xrLabel52.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(110F, 473.7626F);
            this.xrLabel52.Name = "xrLabel52";
            this.xrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel52.SizeF = new System.Drawing.SizeF(72.8334F, 14F);
            this.xrLabel52.StylePriority.UseFont = false;
            this.xrLabel52.Text = "Parcela(s)";
            // 
            // lparcelatipo05
            // 
            this.lparcelatipo05.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelatipo05.LocationFloat = new DevExpress.Utils.PointFloat(183.8334F, 473.7626F);
            this.lparcelatipo05.Name = "lparcelatipo05";
            this.lparcelatipo05.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelatipo05.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelatipo05.StylePriority.UseFont = false;
            this.lparcelatipo05.StylePriority.UseTextAlignment = false;
            this.lparcelatipo05.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lvencimentoparcela06
            // 
            this.lvencimentoparcela06.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvencimentoparcela06.LocationFloat = new DevExpress.Utils.PointFloat(492.9583F, 488.7626F);
            this.lvencimentoparcela06.Name = "lvencimentoparcela06";
            this.lvencimentoparcela06.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvencimentoparcela06.SizeF = new System.Drawing.SizeF(138.6458F, 14F);
            this.lvencimentoparcela06.StylePriority.UseFont = false;
            this.lvencimentoparcela06.StylePriority.UseTextAlignment = false;
            this.lvencimentoparcela06.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel63
            // 
            this.xrLabel63.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel63.LocationFloat = new DevExpress.Utils.PointFloat(400.4166F, 488.7626F);
            this.xrLabel63.Name = "xrLabel63";
            this.xrLabel63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel63.SizeF = new System.Drawing.SizeF(90.54178F, 14F);
            this.xrLabel63.StylePriority.UseFont = false;
            this.xrLabel63.StylePriority.UseTextAlignment = false;
            this.xrLabel63.Text = "1o. Vencimento";
            this.xrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lparcelavalor06
            // 
            this.lparcelavalor06.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelavalor06.LocationFloat = new DevExpress.Utils.PointFloat(307.6459F, 488.7626F);
            this.lparcelavalor06.Name = "lparcelavalor06";
            this.lparcelavalor06.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelavalor06.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelavalor06.StylePriority.UseFont = false;
            this.lparcelavalor06.StylePriority.UseTextAlignment = false;
            this.lparcelavalor06.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel61
            // 
            this.xrLabel61.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(277.6041F, 488.7626F);
            this.xrLabel61.Name = "xrLabel61";
            this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel61.SizeF = new System.Drawing.SizeF(28.04172F, 14F);
            this.xrLabel61.StylePriority.UseFont = false;
            this.xrLabel61.Text = "de";
            // 
            // lparcelatipo06
            // 
            this.lparcelatipo06.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelatipo06.LocationFloat = new DevExpress.Utils.PointFloat(183.8334F, 488.7626F);
            this.lparcelatipo06.Name = "lparcelatipo06";
            this.lparcelatipo06.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelatipo06.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelatipo06.StylePriority.UseFont = false;
            this.lparcelatipo06.StylePriority.UseTextAlignment = false;
            this.lparcelatipo06.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel59
            // 
            this.xrLabel59.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel59.LocationFloat = new DevExpress.Utils.PointFloat(110F, 488.7626F);
            this.xrLabel59.Name = "xrLabel59";
            this.xrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel59.SizeF = new System.Drawing.SizeF(72.8334F, 14F);
            this.xrLabel59.StylePriority.UseFont = false;
            this.xrLabel59.Text = "Parcela(s)";
            // 
            // lqtdparcela06
            // 
            this.lqtdparcela06.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lqtdparcela06.LocationFloat = new DevExpress.Utils.PointFloat(15.99983F, 488.7626F);
            this.lqtdparcela06.Name = "lqtdparcela06";
            this.lqtdparcela06.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lqtdparcela06.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lqtdparcela06.StylePriority.UseFont = false;
            this.lqtdparcela06.StylePriority.UseTextAlignment = false;
            this.lqtdparcela06.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lqtdparcela04
            // 
            this.lqtdparcela04.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lqtdparcela04.LocationFloat = new DevExpress.Utils.PointFloat(15.99986F, 458.1584F);
            this.lqtdparcela04.Name = "lqtdparcela04";
            this.lqtdparcela04.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lqtdparcela04.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lqtdparcela04.StylePriority.UseFont = false;
            this.lqtdparcela04.StylePriority.UseTextAlignment = false;
            this.lqtdparcela04.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel45
            // 
            this.xrLabel45.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(110F, 458.1584F);
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel45.SizeF = new System.Drawing.SizeF(72.8334F, 14F);
            this.xrLabel45.StylePriority.UseFont = false;
            this.xrLabel45.Text = "Parcela(s)";
            // 
            // lparcelatipo04
            // 
            this.lparcelatipo04.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelatipo04.LocationFloat = new DevExpress.Utils.PointFloat(183.8334F, 458.1584F);
            this.lparcelatipo04.Name = "lparcelatipo04";
            this.lparcelatipo04.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelatipo04.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelatipo04.StylePriority.UseFont = false;
            this.lparcelatipo04.StylePriority.UseTextAlignment = false;
            this.lparcelatipo04.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel47
            // 
            this.xrLabel47.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(277.6042F, 458.1584F);
            this.xrLabel47.Name = "xrLabel47";
            this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel47.SizeF = new System.Drawing.SizeF(28.04172F, 14F);
            this.xrLabel47.StylePriority.UseFont = false;
            this.xrLabel47.Text = "de";
            // 
            // lparcelavalor04
            // 
            this.lparcelavalor04.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelavalor04.LocationFloat = new DevExpress.Utils.PointFloat(307.6459F, 458.1584F);
            this.lparcelavalor04.Name = "lparcelavalor04";
            this.lparcelavalor04.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelavalor04.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelavalor04.StylePriority.UseFont = false;
            this.lparcelavalor04.StylePriority.UseTextAlignment = false;
            this.lparcelavalor04.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel49
            // 
            this.xrLabel49.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(400.4166F, 458.1584F);
            this.xrLabel49.Name = "xrLabel49";
            this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel49.SizeF = new System.Drawing.SizeF(90.54178F, 14F);
            this.xrLabel49.StylePriority.UseFont = false;
            this.xrLabel49.StylePriority.UseTextAlignment = false;
            this.xrLabel49.Text = "1o. Vencimento";
            this.xrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lvencimentoparcela04
            // 
            this.lvencimentoparcela04.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvencimentoparcela04.LocationFloat = new DevExpress.Utils.PointFloat(492.9583F, 458.1585F);
            this.lvencimentoparcela04.Name = "lvencimentoparcela04";
            this.lvencimentoparcela04.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvencimentoparcela04.SizeF = new System.Drawing.SizeF(138.6458F, 13.99997F);
            this.lvencimentoparcela04.StylePriority.UseFont = false;
            this.lvencimentoparcela04.StylePriority.UseTextAlignment = false;
            this.lvencimentoparcela04.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lparcelatipo03
            // 
            this.lparcelatipo03.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelatipo03.LocationFloat = new DevExpress.Utils.PointFloat(183.8334F, 443.1584F);
            this.lparcelatipo03.Name = "lparcelatipo03";
            this.lparcelatipo03.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelatipo03.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelatipo03.StylePriority.UseFont = false;
            this.lparcelatipo03.StylePriority.UseTextAlignment = false;
            this.lparcelatipo03.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel38
            // 
            this.xrLabel38.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(110F, 443.1584F);
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(72.8334F, 14F);
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.Text = "Parcela(s)";
            // 
            // lqtdparcela03
            // 
            this.lqtdparcela03.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lqtdparcela03.LocationFloat = new DevExpress.Utils.PointFloat(15.99989F, 443.1584F);
            this.lqtdparcela03.Name = "lqtdparcela03";
            this.lqtdparcela03.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lqtdparcela03.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lqtdparcela03.StylePriority.UseFont = false;
            this.lqtdparcela03.StylePriority.UseTextAlignment = false;
            this.lqtdparcela03.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel40
            // 
            this.xrLabel40.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(277.6042F, 443.1584F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(28.04172F, 14F);
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.Text = "de";
            // 
            // lvencimentoparcela03
            // 
            this.lvencimentoparcela03.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvencimentoparcela03.LocationFloat = new DevExpress.Utils.PointFloat(492.9585F, 443.1585F);
            this.lvencimentoparcela03.Name = "lvencimentoparcela03";
            this.lvencimentoparcela03.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvencimentoparcela03.SizeF = new System.Drawing.SizeF(138.6457F, 14F);
            this.lvencimentoparcela03.StylePriority.UseFont = false;
            this.lvencimentoparcela03.StylePriority.UseTextAlignment = false;
            this.lvencimentoparcela03.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel42
            // 
            this.xrLabel42.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(400.4166F, 443.1584F);
            this.xrLabel42.Name = "xrLabel42";
            this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel42.SizeF = new System.Drawing.SizeF(90.54178F, 14F);
            this.xrLabel42.StylePriority.UseFont = false;
            this.xrLabel42.StylePriority.UseTextAlignment = false;
            this.xrLabel42.Text = "1o. Vencimento";
            this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lparcelavalor03
            // 
            this.lparcelavalor03.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelavalor03.LocationFloat = new DevExpress.Utils.PointFloat(307.6459F, 443.1584F);
            this.lparcelavalor03.Name = "lparcelavalor03";
            this.lparcelavalor03.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelavalor03.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelavalor03.StylePriority.UseFont = false;
            this.lparcelavalor03.StylePriority.UseTextAlignment = false;
            this.lparcelavalor03.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lparcelavalor02
            // 
            this.lparcelavalor02.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelavalor02.LocationFloat = new DevExpress.Utils.PointFloat(307.6459F, 426.9918F);
            this.lparcelavalor02.Name = "lparcelavalor02";
            this.lparcelavalor02.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelavalor02.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelavalor02.StylePriority.UseFont = false;
            this.lparcelavalor02.StylePriority.UseTextAlignment = false;
            this.lparcelavalor02.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel35
            // 
            this.xrLabel35.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(400.4166F, 426.9918F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(90.54178F, 14F);
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.StylePriority.UseTextAlignment = false;
            this.xrLabel35.Text = "1o. Vencimento";
            this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lvencimentoparcela02
            // 
            this.lvencimentoparcela02.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvencimentoparcela02.LocationFloat = new DevExpress.Utils.PointFloat(492.9583F, 426.9918F);
            this.lvencimentoparcela02.Name = "lvencimentoparcela02";
            this.lvencimentoparcela02.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvencimentoparcela02.SizeF = new System.Drawing.SizeF(138.6458F, 14F);
            this.lvencimentoparcela02.StylePriority.UseFont = false;
            this.lvencimentoparcela02.StylePriority.UseTextAlignment = false;
            this.lvencimentoparcela02.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel33
            // 
            this.xrLabel33.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(277.6042F, 426.9918F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(28.04172F, 14F);
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.Text = "de";
            // 
            // lqtdparcela02
            // 
            this.lqtdparcela02.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lqtdparcela02.LocationFloat = new DevExpress.Utils.PointFloat(15.99986F, 426.9918F);
            this.lqtdparcela02.Name = "lqtdparcela02";
            this.lqtdparcela02.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lqtdparcela02.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lqtdparcela02.StylePriority.UseFont = false;
            this.lqtdparcela02.StylePriority.UseTextAlignment = false;
            this.lqtdparcela02.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel30
            // 
            this.xrLabel30.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(110F, 426.9918F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(72.8334F, 14F);
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.Text = "Parcela(s)";
            // 
            // lparcelatipo02
            // 
            this.lparcelatipo02.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelatipo02.LocationFloat = new DevExpress.Utils.PointFloat(183.8334F, 426.9918F);
            this.lparcelatipo02.Name = "lparcelatipo02";
            this.lparcelatipo02.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelatipo02.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelatipo02.StylePriority.UseFont = false;
            this.lparcelatipo02.StylePriority.UseTextAlignment = false;
            this.lparcelatipo02.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lvencimentoparcela01
            // 
            this.lvencimentoparcela01.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvencimentoparcela01.LocationFloat = new DevExpress.Utils.PointFloat(492.9585F, 411.9918F);
            this.lvencimentoparcela01.Name = "lvencimentoparcela01";
            this.lvencimentoparcela01.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvencimentoparcela01.SizeF = new System.Drawing.SizeF(138.6457F, 14F);
            this.lvencimentoparcela01.StylePriority.UseFont = false;
            this.lvencimentoparcela01.StylePriority.UseTextAlignment = false;
            this.lvencimentoparcela01.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(400.4166F, 411.9918F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(90.54178F, 14F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "1o. Vencimento";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lparcelavalor01
            // 
            this.lparcelavalor01.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelavalor01.LocationFloat = new DevExpress.Utils.PointFloat(307.6459F, 411.9918F);
            this.lparcelavalor01.Name = "lparcelavalor01";
            this.lparcelavalor01.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelavalor01.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelavalor01.StylePriority.UseFont = false;
            this.lparcelavalor01.StylePriority.UseTextAlignment = false;
            this.lparcelavalor01.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(277.6042F, 411.9918F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(28.04172F, 14F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "de";
            // 
            // lparcelatipo01
            // 
            this.lparcelatipo01.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparcelatipo01.LocationFloat = new DevExpress.Utils.PointFloat(183.8334F, 411.9918F);
            this.lparcelatipo01.Name = "lparcelatipo01";
            this.lparcelatipo01.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lparcelatipo01.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lparcelatipo01.StylePriority.UseFont = false;
            this.lparcelatipo01.StylePriority.UseTextAlignment = false;
            this.lparcelatipo01.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(110F, 411.9918F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(72.8334F, 14F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "Parcela(s)";
            // 
            // lqtdparcela01
            // 
            this.lqtdparcela01.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lqtdparcela01.LocationFloat = new DevExpress.Utils.PointFloat(15.99988F, 411.9918F);
            this.lqtdparcela01.Name = "lqtdparcela01";
            this.lqtdparcela01.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lqtdparcela01.SizeF = new System.Drawing.SizeF(91.77075F, 14F);
            this.lqtdparcela01.StylePriority.UseFont = false;
            this.lqtdparcela01.StylePriority.UseTextAlignment = false;
            this.lqtdparcela01.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(15.77053F, 382.4584F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(681.0001F, 14.00002F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "Plano de pagamento do Saldo:";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(15.77055F, 287.5F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(681.0001F, 14.00002F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "Preço e Condições de Pagamento:";
            // 
            // lopcaodeplanta
            // 
            this.lopcaodeplanta.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopcaodeplanta.LocationFloat = new DevExpress.Utils.PointFloat(108F, 250.846F);
            this.lopcaodeplanta.Name = "lopcaodeplanta";
            this.lopcaodeplanta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lopcaodeplanta.SizeF = new System.Drawing.SizeF(589F, 14F);
            this.lopcaodeplanta.StylePriority.UseFont = false;
            this.lopcaodeplanta.Text = "lopcaodeplanta";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(15.99988F, 250.8459F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "Opção de Planta:";
            // 
            // lprodutogrupounidade
            // 
            this.lprodutogrupounidade.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lprodutogrupounidade.LocationFloat = new DevExpress.Utils.PointFloat(107.7707F, 235.846F);
            this.lprodutogrupounidade.Name = "lprodutogrupounidade";
            this.lprodutogrupounidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lprodutogrupounidade.SizeF = new System.Drawing.SizeF(589F, 14F);
            this.lprodutogrupounidade.StylePriority.UseFont = false;
            this.lprodutogrupounidade.Text = "lprodutogrupounidade";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(15.77055F, 235.8459F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Unidade:\r\n";
            // 
            // limovelendereco
            // 
            this.limovelendereco.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limovelendereco.LocationFloat = new DevExpress.Utils.PointFloat(107.771F, 220.846F);
            this.limovelendereco.Name = "limovelendereco";
            this.limovelendereco.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.limovelendereco.SizeF = new System.Drawing.SizeF(589F, 14F);
            this.limovelendereco.StylePriority.UseFont = false;
            this.limovelendereco.Text = "limovelendereco";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(15.77088F, 220.8459F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Imóvel:";
            // 
            // lprodutogrupo
            // 
            this.lprodutogrupo.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lprodutogrupo.LocationFloat = new DevExpress.Utils.PointFloat(107.7708F, 35.84599F);
            this.lprodutogrupo.Name = "lprodutogrupo";
            this.lprodutogrupo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lprodutogrupo.SizeF = new System.Drawing.SizeF(237.6251F, 14F);
            this.lprodutogrupo.StylePriority.UseFont = false;
            this.lprodutogrupo.Text = "lprodutogrupo";
            // 
            // xrLabel28
            // 
            this.xrLabel28.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(15.77069F, 35.84592F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(92.00011F, 14F);
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.Text = "Bloco\\Quadra:";
            // 
            // lcomissao
            // 
            this.lcomissao.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcomissao.LocationFloat = new DevExpress.Utils.PointFloat(459.1461F, 19.84587F);
            this.lcomissao.Name = "lcomissao";
            this.lcomissao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcomissao.SizeF = new System.Drawing.SizeF(102F, 14F);
            this.lcomissao.StylePriority.UseFont = false;
            this.lcomissao.Text = "lcomissao";
            // 
            // ltabelaprice
            // 
            this.ltabelaprice.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltabelaprice.LocationFloat = new DevExpress.Utils.PointFloat(459.1461F, 35.84592F);
            this.ltabelaprice.Name = "ltabelaprice";
            this.ltabelaprice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltabelaprice.SizeF = new System.Drawing.SizeF(237.6251F, 14F);
            this.ltabelaprice.StylePriority.UseFont = false;
            this.ltabelaprice.Text = "ltabelaprice";
            // 
            // xrLabel20
            // 
            this.xrLabel20.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(367.146F, 35.84585F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(92.00011F, 14F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.Text = "Tabela Price:";
            // 
            // xrLabel25
            // 
            this.xrLabel25.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(367.146F, 19.84587F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(92.00011F, 14F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.Text = "Comissão:";
            // 
            // lconjugeprofissao
            // 
            this.lconjugeprofissao.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconjugeprofissao.LocationFloat = new DevExpress.Utils.PointFloat(107.7707F, 152.846F);
            this.lconjugeprofissao.Name = "lconjugeprofissao";
            this.lconjugeprofissao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lconjugeprofissao.SizeF = new System.Drawing.SizeF(237.6249F, 14F);
            this.lconjugeprofissao.StylePriority.UseFont = false;
            this.lconjugeprofissao.Text = "lconjugeprofissao";
            // 
            // lconjugenacionalidade
            // 
            this.lconjugenacionalidade.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconjugenacionalidade.LocationFloat = new DevExpress.Utils.PointFloat(459.1464F, 135.846F);
            this.lconjugenacionalidade.Name = "lconjugenacionalidade";
            this.lconjugenacionalidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lconjugenacionalidade.SizeF = new System.Drawing.SizeF(237.6249F, 14F);
            this.lconjugenacionalidade.StylePriority.UseFont = false;
            this.lconjugenacionalidade.Text = "lconjugenacionalidade";
            // 
            // xrLabel29
            // 
            this.xrLabel29.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(367.1462F, 137.846F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.Text = "Nacionalidade:";
            // 
            // xrLabel32
            // 
            this.xrLabel32.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(15.77057F, 152.8459F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.Text = "Profissão:";
            // 
            // lconjugecpf
            // 
            this.lconjugecpf.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconjugecpf.LocationFloat = new DevExpress.Utils.PointFloat(459.1461F, 120.8461F);
            this.lconjugecpf.Name = "lconjugecpf";
            this.lconjugecpf.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lconjugecpf.SizeF = new System.Drawing.SizeF(237.6249F, 14F);
            this.lconjugecpf.StylePriority.UseFont = false;
            this.lconjugecpf.Text = "lconjugecpf";
            // 
            // xrLabel24
            // 
            this.xrLabel24.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(15.77067F, 122.8459F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.Text = "Conjuge:";
            // 
            // lconjuge
            // 
            this.lconjuge.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconjuge.LocationFloat = new DevExpress.Utils.PointFloat(107.7708F, 122.846F);
            this.lconjuge.Name = "lconjuge";
            this.lconjuge.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lconjuge.SizeF = new System.Drawing.SizeF(237.6249F, 14F);
            this.lconjuge.StylePriority.UseFont = false;
            this.lconjuge.Text = "lconjuge";
            // 
            // lconjugerg
            // 
            this.lconjugerg.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lconjugerg.LocationFloat = new DevExpress.Utils.PointFloat(107.771F, 137.846F);
            this.lconjugerg.Name = "lconjugerg";
            this.lconjugerg.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lconjugerg.SizeF = new System.Drawing.SizeF(237.6249F, 14F);
            this.lconjugerg.StylePriority.UseFont = false;
            this.lconjugerg.Text = "lconjugerg";
            // 
            // xrLabel27
            // 
            this.xrLabel27.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(15.77087F, 137.8459F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.Text = "RG No.:";
            // 
            // xrLabel26
            // 
            this.xrLabel26.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(367.146F, 122.846F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.Text = "CPF:";
            // 
            // xrLabel23
            // 
            this.xrLabel23.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(15.77088F, 106.8459F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.Text = "Reg.de Casamento:";
            // 
            // lclienteregimecasamento
            // 
            this.lclienteregimecasamento.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclienteregimecasamento.LocationFloat = new DevExpress.Utils.PointFloat(107.771F, 106.846F);
            this.lclienteregimecasamento.Name = "lclienteregimecasamento";
            this.lclienteregimecasamento.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lclienteregimecasamento.SizeF = new System.Drawing.SizeF(237.6249F, 14F);
            this.lclienteregimecasamento.StylePriority.UseFont = false;
            this.lclienteregimecasamento.Text = "lclienteregimecasamento";
            // 
            // xrLabel22
            // 
            this.xrLabel22.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(367.1459F, 90.84596F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.Text = "Estado Civil:";
            // 
            // lclienteestadocivil
            // 
            this.lclienteestadocivil.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclienteestadocivil.LocationFloat = new DevExpress.Utils.PointFloat(459.1461F, 90.84603F);
            this.lclienteestadocivil.Name = "lclienteestadocivil";
            this.lclienteestadocivil.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lclienteestadocivil.SizeF = new System.Drawing.SizeF(237.6249F, 14F);
            this.lclienteestadocivil.StylePriority.UseFont = false;
            this.lclienteestadocivil.Text = "lclienteestadocivil";
            // 
            // xrLabel13
            // 
            this.xrLabel13.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(15.77056F, 90.84591F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.Text = "Profissão:";
            // 
            // lclienteprofissao
            // 
            this.lclienteprofissao.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclienteprofissao.LocationFloat = new DevExpress.Utils.PointFloat(107.7707F, 90.84597F);
            this.lclienteprofissao.Name = "lclienteprofissao";
            this.lclienteprofissao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lclienteprofissao.SizeF = new System.Drawing.SizeF(237.6249F, 14F);
            this.lclienteprofissao.StylePriority.UseFont = false;
            this.lclienteprofissao.Text = "lclienteprofissao";
            // 
            // lclientenacionalidade
            // 
            this.lclientenacionalidade.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclientenacionalidade.LocationFloat = new DevExpress.Utils.PointFloat(459.1464F, 75.84604F);
            this.lclientenacionalidade.Name = "lclientenacionalidade";
            this.lclientenacionalidade.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lclientenacionalidade.SizeF = new System.Drawing.SizeF(237.6249F, 14F);
            this.lclientenacionalidade.StylePriority.UseFont = false;
            this.lclientenacionalidade.Text = "lclientenacionalidade";
            // 
            // xrLabel21
            // 
            this.xrLabel21.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(367.1462F, 75.84597F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.Text = "Nacionalidade:";
            // 
            // lclienterg
            // 
            this.lclienterg.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclienterg.LocationFloat = new DevExpress.Utils.PointFloat(107.771F, 75.84598F);
            this.lclienterg.Name = "lclienterg";
            this.lclienterg.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lclienterg.SizeF = new System.Drawing.SizeF(237.6249F, 14F);
            this.lclienterg.StylePriority.UseFont = false;
            this.lclienterg.Text = "lclienterg";
            // 
            // xrLabel19
            // 
            this.xrLabel19.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(15.77086F, 75.84592F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.Text = "RG No.:";
            // 
            // xrLabel17
            // 
            this.xrLabel17.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(367.146F, 60.84598F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.Text = "CPF:";
            // 
            // lclientecpf
            // 
            this.lclientecpf.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclientecpf.LocationFloat = new DevExpress.Utils.PointFloat(459.1461F, 60.84604F);
            this.lclientecpf.Name = "lclientecpf";
            this.lclientecpf.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lclientecpf.SizeF = new System.Drawing.SizeF(237.6249F, 14F);
            this.lclientecpf.StylePriority.UseFont = false;
            this.lclientecpf.Text = "lclientecpf";
            // 
            // lproduto
            // 
            this.lproduto.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lproduto.LocationFloat = new DevExpress.Utils.PointFloat(107.7707F, 20.84599F);
            this.lproduto.Name = "lproduto";
            this.lproduto.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lproduto.SizeF = new System.Drawing.SizeF(237.6251F, 14F);
            this.lproduto.StylePriority.UseFont = false;
            this.lproduto.Text = "lproduto";
            // 
            // xrLabel18
            // 
            this.xrLabel18.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(15.77066F, 60.84591F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(92.00007F, 14F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.Text = "Nome:";
            // 
            // lcliente
            // 
            this.lcliente.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcliente.LocationFloat = new DevExpress.Utils.PointFloat(107.7708F, 60.84597F);
            this.lcliente.Name = "lcliente";
            this.lcliente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcliente.SizeF = new System.Drawing.SizeF(237.6249F, 14F);
            this.lcliente.StylePriority.UseFont = false;
            this.lcliente.Text = "lcliente";
            // 
            // lproposta
            // 
            this.lproposta.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lproposta.LocationFloat = new DevExpress.Utils.PointFloat(107.7707F, 4.845937F);
            this.lproposta.Name = "lproposta";
            this.lproposta.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lproposta.SizeF = new System.Drawing.SizeF(102F, 14F);
            this.lproposta.StylePriority.UseFont = false;
            this.lproposta.Text = "lproposta";
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(15.77059F, 4.845937F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(92.00011F, 14F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.Text = "Proposta No.:";
            // 
            // xrLabel16
            // 
            this.xrLabel16.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(15.77059F, 20.84592F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(92.00011F, 14F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.Text = "Empreendimento:";
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(15.77053F, 333.0751F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(133.6668F, 14F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.Text = "Valor Sinal:";
            // 
            // lvalorsinal
            // 
            this.lvalorsinal.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalorsinal.LocationFloat = new DevExpress.Utils.PointFloat(160.7706F, 333.0751F);
            this.lvalorsinal.Name = "lvalorsinal";
            this.lvalorsinal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvalorsinal.SizeF = new System.Drawing.SizeF(131.1667F, 14F);
            this.lvalorsinal.StylePriority.UseFont = false;
            this.lvalorsinal.StylePriority.UseTextAlignment = false;
            this.lvalorsinal.Text = "lvalorsinal";
            this.lvalorsinal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lvalorsaldo
            // 
            this.lvalorsaldo.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalorsaldo.LocationFloat = new DevExpress.Utils.PointFloat(160.7706F, 349.0751F);
            this.lvalorsaldo.Name = "lvalorsaldo";
            this.lvalorsaldo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvalorsaldo.SizeF = new System.Drawing.SizeF(131.1667F, 14F);
            this.lvalorsaldo.StylePriority.UseFont = false;
            this.lvalorsaldo.StylePriority.UseTextAlignment = false;
            this.lvalorsaldo.Text = "lvalorsaldo";
            this.lvalorsaldo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(15.77053F, 349.0751F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(133.6668F, 14F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "Saldo:";
            // 
            // lvalorvenda
            // 
            this.lvalorvenda.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalorvenda.LocationFloat = new DevExpress.Utils.PointFloat(160.7706F, 317.0752F);
            this.lvalorvenda.Name = "lvalorvenda";
            this.lvalorvenda.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvalorvenda.SizeF = new System.Drawing.SizeF(131.1667F, 14F);
            this.lvalorvenda.StylePriority.UseFont = false;
            this.lvalorvenda.StylePriority.UseTextAlignment = false;
            this.lvalorvenda.Text = "lvalorvenda";
            this.lvalorvenda.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(15.77053F, 317.0752F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(133.6668F, 14F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.Text = "Valor Total da Venda";
            // 
            // lproponente
            // 
            this.lproponente.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lproponente.LocationFloat = new DevExpress.Utils.PointFloat(15.77053F, 710.8586F);
            this.lproponente.Name = "lproponente";
            this.lproponente.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lproponente.SizeF = new System.Drawing.SizeF(259.6042F, 14F);
            this.lproponente.StylePriority.UseFont = false;
            this.lproponente.Text = "lproponente";
            // 
            // lemissaoextenso
            // 
            this.lemissaoextenso.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lemissaoextenso.LocationFloat = new DevExpress.Utils.PointFloat(15.77053F, 643.3875F);
            this.lemissaoextenso.Name = "lemissaoextenso";
            this.lemissaoextenso.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lemissaoextenso.SizeF = new System.Drawing.SizeF(457.3753F, 14.00002F);
            this.lemissaoextenso.StylePriority.UseFont = false;
            this.lemissaoextenso.Text = "lemissaoextenso";
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(15.77053F, 696.9836F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(259.6043F, 7.375F);
            // 
            // lvinculo1
            // 
            this.lvinculo1.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvinculo1.LocationFloat = new DevExpress.Utils.PointFloat(15.7709F, 187.7626F);
            this.lvinculo1.Name = "lvinculo1";
            this.lvinculo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvinculo1.SizeF = new System.Drawing.SizeF(681.0001F, 14.00002F);
            this.lvinculo1.StylePriority.UseFont = false;
            this.lvinculo1.Text = "Apresentamos a presente proposta para aquisição do imóvel residencial abaixo desc" +
    "rito, junto a ";
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
            this.ltusuario.LocationFloat = new DevExpress.Utils.PointFloat(586.0417F, 14F);
            this.ltusuario.Name = "ltusuario";
            this.ltusuario.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltusuario.SizeF = new System.Drawing.SizeF(120.9583F, 14F);
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
            this.ltempresa.LocationFloat = new DevExpress.Utils.PointFloat(182.7708F, 45.91218F);
            this.ltempresa.Name = "ltempresa";
            this.ltempresa.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltempresa.SizeF = new System.Drawing.SizeF(376.4166F, 17.08783F);
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
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(529.2919F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(177.7082F, 14F);
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
            this.PageHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.PageHeader_BeforePrint);
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
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(615.0418F, 28.00001F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(91.95819F, 14F);
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
            this.ltitulorelatorio.LocationFloat = new DevExpress.Utils.PointFloat(182.7708F, 19F);
            this.ltitulorelatorio.Name = "ltitulorelatorio";
            this.ltitulorelatorio.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ltitulorelatorio.SizeF = new System.Drawing.SizeF(376.4166F, 21.54171F);
            this.ltitulorelatorio.StylePriority.UseBackColor = false;
            this.ltitulorelatorio.StylePriority.UseBorderColor = false;
            this.ltitulorelatorio.StylePriority.UseBorders = false;
            this.ltitulorelatorio.StylePriority.UseFont = false;
            this.ltitulorelatorio.StylePriority.UseForeColor = false;
            this.ltitulorelatorio.StylePriority.UseTextAlignment = false;
            this.ltitulorelatorio.Text = "PROPOSTA DE VENDA DE IMÓVEL";
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
            this.lcaminho.Text = "Gitano ->SGFin ->Propostas ->Proposta de Venda de Imóvel";
            // 
            // RepPropostas
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
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
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepPropostas_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    public Int64 proposta;
    //

    private void RepPropostas_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //if ((SreDblib.GetParametro("RELATORIO ZEBRADO") == "SIM"))
        //{
        //    Detail.Styles.EvenStyle.BackColor = System.Drawing.Color.Empty;
        //    Detail.Styles.OddStyle.BackColor = System.Drawing.Color.Silver;
        //    Detail.Styles.EvenStyle.ForeColor = System.Drawing.Color.Black;
        //}
        //else
        //{
        //    Detail.Styles.EvenStyle.BackColor = System.Drawing.Color.Empty;
        //    Detail.Styles.OddStyle.BackColor = System.Drawing.Color.Empty;
        //    Detail.Styles.EvenStyle.ForeColor = System.Drawing.Color.Black;
        //}

        //grupofiltros.RepeatEveryPage = ((SreDblib.GetParametro("EXIBE FILTRO RELAT") == "SIM"));

        //if ((SreDblib.GetParametro("EXIBE LOGO RELATÓRIO") != "SIM"))
        //{
        //    xrPictureBox1.Visible = false;
        //}

        //if ((SreDblib.GetParametro("EXIBE EMPRESA RELAT") != "SIM"))
        //{
        //    ltempresa.Visible = false;
        //}

    }

    private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //
        lproposta.Text = Convert.ToString(proposta).Trim();
        //
        string produto = Convert.ToString(GetCurrentColumnValue("produto")).Trim();
        lproduto.Text = produto;
        lproduto.Text = lproduto.Text + " - " + uProduto.PegaProdutoDescricao(Convert.ToInt16(lproduto.Text));
        lprodutogrupo.Text = Convert.ToString(GetCurrentColumnValue("grupo")).Trim();
        lprodutogrupo.Text = lprodutogrupo.Text + " - " + uProduto.PegaProdutoGrupoDescricao(Convert.ToInt16(Convert.ToString(GetCurrentColumnValue("produto")).Trim()), Convert.ToInt16(lprodutogrupo.Text));
        //
        string dataproposta = Convert.ToString(GetCurrentColumnValue("data_proposta")).Substring(0, 10);
        ldataproposta.Text = dataproposta;
        //
        Int16 comissao = Convert.ToInt16(GetCurrentColumnValue("comissaopermanencia"));
        if (comissao == 1)
            lcomissao.Text = "SIM";
        else
            lcomissao.Text = "NÃO";
        //
        Int16 tabelaprice = Convert.ToInt16(GetCurrentColumnValue("tabelaprice"));
        if (tabelaprice == 1)
            ltabelaprice.Text = "SIM";
        else
            ltabelaprice.Text = "NÃO";
        //

        string nome = Convert.ToString(GetCurrentColumnValue("nome"));
        lcliente.Text = nome;
        //
        string clientecpf = Convert.ToString(GetCurrentColumnValue("cnpj"));
        lclientecpf.Text = Srelib.FormataCPFCNPJ(clientecpf);
        string clienterg = Convert.ToString(GetCurrentColumnValue("rg"));
        lclienterg.Text = clienterg;
        string clientenacionalidade = Convert.ToString(GetCurrentColumnValue("nacionalidade"));
        lclientenacionalidade.Text = clientenacionalidade;
        string clienteprofissao = Convert.ToString(GetCurrentColumnValue("profissao"));
        lclienteprofissao.Text = clienteprofissao;
        string clienteestadocivil = Convert.ToString(GetCurrentColumnValue("estadocivil"));
        lclienteestadocivil.Text = clienteestadocivil;
        string regimecansamento = Convert.ToString(GetCurrentColumnValue("regimecasamento"));
        lclienteregimecasamento.Text = regimecansamento;
        //
        string conjuge = Convert.ToString(GetCurrentColumnValue("conjugenome"));
        lconjuge.Text = conjuge;
        //
        string conjugecpf = Convert.ToString(GetCurrentColumnValue("conjugecpf"));
        lconjugecpf.Text = Srelib.FormataCPFCNPJ(conjugecpf);
        string conjugerg = Convert.ToString(GetCurrentColumnValue("conjugerg"));
        lconjugerg.Text = conjugerg;
        string conjugenacionalidade = Convert.ToString(GetCurrentColumnValue("conjugenacionalidade"));
        lconjugenacionalidade.Text = conjugenacionalidade;
        string conjugeprofissao = Convert.ToString(GetCurrentColumnValue("conjugeprofissao"));
        lconjugeprofissao.Text = conjugeprofissao;
        //
        string imovel = uProduto.PegaEndereco(produto);
        limovelendereco.Text = imovel;
        string unidade = Convert.ToString(GetCurrentColumnValue("unidade"));
        lprodutogrupounidade.Text = unidade;
        string opcaoplanta = Convert.ToString(GetCurrentColumnValue("tipoplanta"));
        lopcaodeplanta.Text = opcaoplanta;
        //
        string vlr_proposta = Convert.ToString(GetCurrentColumnValue("valor_venda"));
        //lvalorvenda.Text = Srelib.forcaponto(vlr_proposta);
        lvalorvenda.Text = String.Format("{0:N}", Convert.ToDouble(vlr_proposta)).Trim();
        //
        string vlr_sinal = Convert.ToString(GetCurrentColumnValue("sinal"));
        //lvalorsinal.Text = Srelib.forcaponto(vlr_sinal);
        lvalorsinal.Text = String.Format("{0:N}", Convert.ToDouble(vlr_sinal)).Trim();
        //
        string vlr_saldo = Convert.ToString(GetCurrentColumnValue("saldo"));
        //lvalorsaldo.Text = Srelib.forcaponto(vlr_saldo);
        lvalorsaldo.Text = String.Format("{0:N}", Convert.ToDouble(vlr_saldo)).Trim();
        //
        //
        if (Convert.ToDouble(vlr_saldo) != 0)
        {
            //01
            if (Convert.ToDouble(Convert.ToString(GetCurrentColumnValue("plano1_parcelas_qtd"))) != 0)
            {
                string qtdparcela01 = Convert.ToString(GetCurrentColumnValue("plano1_parcelas_qtd"));
                lqtdparcela01.Text = String.Format("{0}", Convert.ToDouble(qtdparcela01)).Trim();
                //
                //string parcelatipo01 = Convert.ToString(GetCurrentColumnValue("saldo"));
                lparcelatipo01.Text = "SINAL"; // String.Format("{0:N}", Convert.ToDouble(vlr_saldo)).Trim();
                //
                string parcelavalor01 = Convert.ToString(GetCurrentColumnValue("plano1_parcelas_vlr"));
                lparcelavalor01.Text = String.Format("{0:N}", Convert.ToDouble(parcelavalor01)).Trim();
                //
                string vencimentoparcela01 = Convert.ToString(GetCurrentColumnValue("plano1_parcelas_vencimento")).Substring(0, 10);
                lvencimentoparcela01.Text = vencimentoparcela01;
            }
            else
            {
                lqtdparcela01.Text = "0";
                lparcelatipo01.Text = " ";
                lparcelavalor01.Text = "0.00";
                lvencimentoparcela01.Text = " ";
            }
            //
            //02
            if (Convert.ToDouble(Convert.ToString(GetCurrentColumnValue("plano2_parcelas_qtd"))) != 0)
            {
                string qtdparcela02 = Convert.ToString(GetCurrentColumnValue("plano2_parcelas_qtd"));
                lqtdparcela02.Text = String.Format("{0}", Convert.ToDouble(qtdparcela02)).Trim();
                //
                lparcelatipo02.Text = "MENSAIS"; // String.Format("{0:N}", Convert.ToDouble(vlr_saldo)).Trim();
                //
                string parcelavalor02 = Convert.ToString(GetCurrentColumnValue("plano2_parcelas_vlr"));
                lparcelavalor02.Text = String.Format("{0:N}", Convert.ToDouble(parcelavalor02)).Trim();
                //
                string vencimentoparcela02 = Convert.ToString(GetCurrentColumnValue("plano2_parcelas_vencimento")).Substring(0, 10);
                lvencimentoparcela02.Text = vencimentoparcela02;
            }
            else
            {
                lqtdparcela02.Text = "0";
                lparcelatipo02.Text = " ";
                lparcelavalor02.Text = "0.00";
                lvencimentoparcela02.Text = " ";
            }
            //
            //03
            if (Convert.ToDouble(Convert.ToString(GetCurrentColumnValue("plano3_parcelas_qtd"))) != 0)
            {
                string qtdparcela03 = Convert.ToString(GetCurrentColumnValue("plano3_parcelas_qtd"));
                lqtdparcela03.Text = String.Format("{0}", Convert.ToDouble(qtdparcela03)).Trim();
                //
                lparcelatipo03.Text = "MENSAIS"; // String.Format("{0:N}", Convert.ToDouble(vlr_saldo)).Trim();
                //
                string parcelavalor03 = Convert.ToString(GetCurrentColumnValue("plano3_parcelas_vlr"));
                lparcelavalor03.Text = String.Format("{0:N}", Convert.ToDouble(parcelavalor03)).Trim();
                //
                string vencimentoparcela03 = Convert.ToString(GetCurrentColumnValue("plano3_parcelas_vencimento")).Substring(0, 10);
                lvencimentoparcela03.Text = vencimentoparcela03;
            }
            else
            {
                lqtdparcela03.Text = "0";
                lparcelatipo03.Text = " ";
                lparcelavalor03.Text = "0.00";
                lvencimentoparcela03.Text = " ";
            }
            //
            //04
            if (Convert.ToDouble(Convert.ToString(GetCurrentColumnValue("plano4_parcelas_qtd"))) != 0)
            {
                string qtdparcela04 = Convert.ToString(GetCurrentColumnValue("plano4_parcelas_qtd"));
                lqtdparcela04.Text = String.Format("{0}", Convert.ToDouble(qtdparcela04)).Trim();
                //
                lparcelatipo04.Text = "MENSAIS"; // String.Format("{0:N}", Convert.ToDouble(vlr_saldo)).Trim();
                //
                string parcelavalor04 = Convert.ToString(GetCurrentColumnValue("plano4_parcelas_vlr"));
                lparcelavalor04.Text = String.Format("{0:N}", Convert.ToDouble(parcelavalor04)).Trim();
                //
                string vencimentoparcela04 = Convert.ToString(GetCurrentColumnValue("plano4_parcelas_vencimento")).Substring(0, 10);
                lvencimentoparcela04.Text = vencimentoparcela04;
            }
            else
            {
                lqtdparcela04.Text = "0";
                lparcelatipo04.Text = " ";
                lparcelavalor04.Text = "0.00";
                lvencimentoparcela04.Text = " ";
            }
            //
            //05
            if (Convert.ToDouble(Convert.ToString(GetCurrentColumnValue("plano5_parcelas_qtd"))) != 0)
            {
                string qtdparcela05 = Convert.ToString(GetCurrentColumnValue("plano5_parcelas_qtd"));
                lqtdparcela05.Text = String.Format("{0}", Convert.ToDouble(qtdparcela05)).Trim();
                //
                lparcelatipo05.Text = "MENSAIS"; // String.Format("{0:N}", Convert.ToDouble(vlr_saldo)).Trim();
                //
                string parcelavalor05 = Convert.ToString(GetCurrentColumnValue("plano5_parcelas_vlr"));
                lparcelavalor05.Text = String.Format("{0:N}", Convert.ToDouble(parcelavalor05)).Trim();
                //
                string vencimentoparcela05 = Convert.ToString(GetCurrentColumnValue("plano5_parcelas_vencimento")).Substring(0, 10);
                lvencimentoparcela05.Text = vencimentoparcela05;
            }
            else
            {
                lqtdparcela05.Text = "0";
                lparcelatipo05.Text = " ";
                lparcelavalor05.Text = "0.00";
                lvencimentoparcela05.Text = " ";
            }
            //
            //06
            if (Convert.ToDouble(Convert.ToString(GetCurrentColumnValue("plano6_parcelas_qtd"))) != 0)
            {
                string qtdparcela06 = Convert.ToString(GetCurrentColumnValue("plano6_parcelas_qtd"));
                lqtdparcela06.Text = String.Format("{0}", Convert.ToDouble(qtdparcela06)).Trim();
                //
                lparcelatipo06.Text = "MENSAIS"; // String.Format("{0:N}", Convert.ToDouble(vlr_saldo)).Trim();
                //
                string parcelavalor06 = Convert.ToString(GetCurrentColumnValue("plano6_parcelas_vlr"));
                lparcelavalor06.Text = String.Format("{0:N}", Convert.ToDouble(parcelavalor06)).Trim();
                //
                string vencimentoparcela06 = Convert.ToString(GetCurrentColumnValue("plano6_parcelas_vencimento")).Substring(0, 10);
                lvencimentoparcela06.Text = vencimentoparcela06;
            }
            else
            {
                lqtdparcela06.Text = "0";
                lparcelatipo06.Text = " ";
                lparcelavalor06.Text = "0.00";
                lvencimentoparcela06.Text = " ";
            }
            //
            //07
            if (Convert.ToDouble(Convert.ToString(GetCurrentColumnValue("plano7_parcelas_qtd"))) != 0)
            {
                string qtdparcela07 = Convert.ToString(GetCurrentColumnValue("plano7_parcelas_qtd"));
                lqtdparcela07.Text = String.Format("{0}", Convert.ToDouble(qtdparcela07)).Trim();
                //
                lparcelatipo07.Text = "MENSAIS"; // String.Format("{0:N}", Convert.ToDouble(vlr_saldo)).Trim();
                //
                string parcelavalor07 = Convert.ToString(GetCurrentColumnValue("plano7_parcelas_vlr"));
                lparcelavalor07.Text = String.Format("{0:N}", Convert.ToDouble(parcelavalor07)).Trim();
                //
                string vencimentoparcela07 = Convert.ToString(GetCurrentColumnValue("plano7_parcelas_vencimento")).Substring(0, 10);
                lvencimentoparcela07.Text = vencimentoparcela07;
            }
            else
            {
                lqtdparcela07.Text = "0";
                lparcelatipo07.Text = " ";
                lparcelavalor07.Text = "0.00";
                lvencimentoparcela07.Text = " ";
            }
            //
            //08
            if (Convert.ToDouble(Convert.ToString(GetCurrentColumnValue("plano8_parcelas_qtd"))) != 0)
            {
                string qtdparcela08 = Convert.ToString(GetCurrentColumnValue("plano8_parcelas_qtd"));
                lqtdparcela08.Text = String.Format("{0}", Convert.ToDouble(qtdparcela08)).Trim();
                //
                lparcelatipo08.Text = "MENSAIS"; // String.Format("{0:N}", Convert.ToDouble(vlr_saldo)).Trim();
                //
                string parcelavalor08 = Convert.ToString(GetCurrentColumnValue("plano8_parcelas_vlr"));
                lparcelavalor08.Text = String.Format("{0:N}", Convert.ToDouble(parcelavalor08)).Trim();
                //
                string vencimentoparcela08 = Convert.ToString(GetCurrentColumnValue("plano8_parcelas_vencimento")).Substring(0, 10);
                lvencimentoparcela08.Text = vencimentoparcela08;
            }
            else
            {
                lqtdparcela08.Text = "0";
                lparcelatipo08.Text = " ";
                lparcelavalor08.Text = "0.00";
                lvencimentoparcela08.Text = " ";
            }
            //
            //
            string indexador1 = Convert.ToString(GetCurrentColumnValue("indexadorprehabitese"));
            lindice.Text = indexador1.Trim();
            //
            string indexador2 = Convert.ToString(GetCurrentColumnValue("indexadorposhabitese"));
            lindice2.Text = indexador2.Trim();
            //
            //
            lemissaoextenso.Text = uEmpresa.PegaCidade(uEmpresa.PegaMatriz()) + ", " + Srelib.DataExtenso(DateTime.Now);
            //
            lproponente.Text = nome;
            //
            string corretor = Convert.ToString(GetCurrentColumnValue("corretor"));
            lcorretor.Text = uCorretor.PegaNomeIDCorretor(corretor);
            //
        }
    }

    private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //
        //TITULO RECIBO
        ltitulorelatorio.Text = "PROPOSTA DE VENDA DE IMÓVEL No. " + proposta.ToString();
    }

}
