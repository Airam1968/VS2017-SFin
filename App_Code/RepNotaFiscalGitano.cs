using DevExpress.XtraReports.UI;
using System;

/// <summary>
/// Summary description for RepNotaFiscalGitano
/// </summary>
public class RepNotaFiscalGitano : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private PageHeaderBand PageHeader;
    private XRControlStyle xrControlStyle1;
    private XRControlStyle xrControlStyle2;
    private FormattingRule formattingRule1;
    private XRCrossBandBox xrCrossBandBox1;
    public XRLabel xrLabel5;
    public XRLabel xrLabel4;
    public XRLabel xrLabel3;
    public XRLabel xrLabel2;
    public XRLabel xrLabel1;
    public XRLabel lvlrtot1_1;
    public XRLabel lvlruni1_1;
    public XRLabel ldescricao1_1;
    public XRLabel lqtd1_1;
    public XRLabel luni1_1;
    public XRLabel xrLabel96;
    public XRLabel xrLabel95;
    public XRLabel xrLabel94;
    public XRLabel xrLabel93;
    public XRLabel lvlrtotalnf1_1;
    public XRLabel xrLabel89;
    public XRLabel xrLabel82;
    public XRLabel xrLabel83;
    public XRLabel xrLabel81;
    public XRLabel xrLabel79;
    public XRLabel xrLabel80;
    public XRLabel xrLabel87;
    public XRLabel xrLabel88;
    public XRLabel xrLabel86;
    public XRLabel xrLabel84;
    public XRLabel xrLabel85;
    public XRLabel xrLabel72;
    public XRLabel xrLabel73;
    public XRLabel xrLabel71;
    public XRLabel xrLabel69;
    public XRLabel xrLabel70;
    public XRLabel xrLabel77;
    public XRLabel xrLabel78;
    public XRLabel xrLabel76;
    public XRLabel xrLabel74;
    public XRLabel xrLabel75;
    public XRLabel xrLabel62;
    public XRLabel xrLabel63;
    public XRLabel xrLabel61;
    public XRLabel xrLabel59;
    public XRLabel xrLabel60;
    public XRLabel xrLabel67;
    public XRLabel xrLabel68;
    public XRLabel xrLabel66;
    public XRLabel xrLabel64;
    public XRLabel xrLabel65;
    public XRLabel xrLabel52;
    public XRLabel xrLabel53;
    public XRLabel xrLabel51;
    public XRLabel xrLabel49;
    public XRLabel xrLabel50;
    public XRLabel xrLabel57;
    public XRLabel xrLabel58;
    public XRLabel xrLabel56;
    public XRLabel xrLabel54;
    public XRLabel xrLabel55;
    public XRLabel xrLabel47;
    public XRLabel xrLabel48;
    public XRLabel xrLabel46;
    public XRLabel xrLabel44;
    public XRLabel xrLabel45;
    public XRLabel xrLabel42;
    public XRLabel xrLabel43;
    public XRLabel xrLabel41;
    public XRLabel xrLabel39;
    public XRLabel xrLabel40;
    public XRLabel xrLabel37;
    public XRLabel xrLabel38;
    public XRLabel xrLabel36;
    public XRLabel xrLabel11;
    public XRLabel xrLabel12;
    private XRPanel xrPanel5;
    private XRPanel xrPanel4;
    public XRLabel xrLabel97;
    public XRLabel xrLabel91;
    private XRPanel xrPanel10;
    public XRLabel xrLabel203;
    public XRLabel xrLabel204;
    public XRLabel xrLabel205;
    public XRLabel xrLabel206;
    public XRLabel xrLabel207;
    public XRLabel xrLabel208;
    private XRPanel xrPanel9;
    public XRLabel xrLabel136;
    public XRLabel xrLabel137;
    public XRLabel xrLabel138;
    public XRLabel xrLabel139;
    public XRLabel xrLabel140;
    public XRLabel luni1_2;
    public XRLabel lqtd1_2;
    public XRLabel ldescricao1_2;
    public XRLabel lvlruni1_2;
    public XRLabel lvlrtot1_2;
    public XRLabel xrLabel146;
    public XRLabel xrLabel147;
    public XRLabel xrLabel148;
    public XRLabel xrLabel149;
    public XRLabel xrLabel150;
    public XRLabel xrLabel151;
    public XRLabel xrLabel152;
    public XRLabel xrLabel153;
    public XRLabel xrLabel154;
    public XRLabel xrLabel155;
    public XRLabel xrLabel156;
    public XRLabel xrLabel157;
    public XRLabel xrLabel158;
    public XRLabel xrLabel159;
    public XRLabel xrLabel160;
    public XRLabel xrLabel161;
    public XRLabel xrLabel162;
    public XRLabel xrLabel163;
    public XRLabel xrLabel164;
    public XRLabel xrLabel165;
    public XRLabel xrLabel166;
    public XRLabel xrLabel167;
    public XRLabel xrLabel168;
    public XRLabel xrLabel169;
    public XRLabel xrLabel170;
    public XRLabel xrLabel171;
    public XRLabel xrLabel172;
    public XRLabel xrLabel173;
    public XRLabel xrLabel174;
    public XRLabel xrLabel175;
    public XRLabel xrLabel176;
    public XRLabel xrLabel177;
    public XRLabel xrLabel178;
    public XRLabel xrLabel179;
    public XRLabel xrLabel180;
    public XRLabel xrLabel181;
    public XRLabel xrLabel182;
    public XRLabel xrLabel183;
    public XRLabel xrLabel184;
    public XRLabel xrLabel185;
    public XRLabel xrLabel186;
    public XRLabel xrLabel187;
    public XRLabel xrLabel188;
    public XRLabel xrLabel189;
    public XRLabel xrLabel190;
    public XRLabel xrLabel191;
    public XRLabel xrLabel192;
    public XRLabel xrLabel193;
    public XRLabel xrLabel194;
    public XRLabel xrLabel195;
    public XRLabel xrLabel196;
    public XRLabel xrLabel197;
    public XRLabel xrLabel198;
    public XRLabel xrLabel199;
    public XRLabel xrLabel200;
    public XRLabel xrLabel201;
    public XRLabel lvlrtotalnf1_2;
    private XRPanel xrPanel3;
    public XRLabel xrLabel29;
    public XRLabel xrLabel30;
    public XRLabel xrLabel31;
    public XRLabel xrLabel32;
    public XRLabel lbairro1;
    public XRLabel lendereco1;
    public XRLabel lnome1;
    public XRLabel xrLabel128;
    public XRLabel lcidade1;
    public XRLabel xrLabel130;
    public XRLabel luf1;
    public XRLabel xrLabel132;
    public XRLabel lcnpj1;
    public XRLabel xrLabel134;
    public XRLabel linscricao1;
    private XRPanel xrPanel7;
    public XRLabel xrLabel105;
    public XRLabel xrLabel106;
    public XRLabel xrLabel107;
    public XRLabel xrLabel108;
    public XRLabel lnumeronota2;
    public XRLabel xrLabel110;
    public XRLabel xrLabel111;
    public XRLabel ldataemissao2;
    private XRPanel xrPanel8;
    public XRLabel xrLabel113;
    public XRLabel xrLabel114;
    public XRLabel xrLabel115;
    public XRLabel xrLabel116;
    public XRLabel lbairro2;
    public XRLabel lendereco2;
    public XRLabel lnome2;
    public XRLabel xrLabel120;
    public XRLabel lcidade2;
    public XRLabel xrLabel122;
    public XRLabel luf2;
    public XRLabel xrLabel124;
    public XRLabel lcnpj2;
    public XRLabel xrLabel126;
    public XRLabel linscricao2;
    private XRPanel xrPanel1;
    public XRLabel xrLabel13;
    public XRLabel xrLabel14;
    public XRLabel xrLabel15;
    public XRLabel xrLabel16;
    public XRLabel xrLabel17;
    public XRLabel xrLabel18;
    public XRLabel xrLabel19;
    public XRLabel xrLabel20;
    private XRPanel xrPanel2;
    public XRLabel xrLabel21;
    public XRLabel xrLabel22;
    public XRLabel xrLabel23;
    public XRLabel xrLabel24;
    public XRLabel lnumeronota1;
    public XRLabel xrLabel26;
    public XRLabel xrLabel27;
    public XRLabel ldataemissao1;
    private XRPanel xrPanel6;
    public XRLabel xrLabel92;
    public XRLabel xrLabel98;
    public XRLabel xrLabel99;
    public XRLabel xrLabel100;
    public XRLabel xrLabel101;
    public XRLabel xrLabel102;
    public XRLabel xrLabel103;
    public XRLabel xrLabel104;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public RepNotaFiscalGitano()
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
            //string resourceFileName = "RepNotaFiscalGitano.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbairro1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lendereco1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lnome1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel128 = new DevExpress.XtraReports.UI.XRLabel();
            this.lcidade1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel130 = new DevExpress.XtraReports.UI.XRLabel();
            this.luf1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel132 = new DevExpress.XtraReports.UI.XRLabel();
            this.lcnpj1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel134 = new DevExpress.XtraReports.UI.XRLabel();
            this.linscricao1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel7 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel105 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel106 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel107 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel108 = new DevExpress.XtraReports.UI.XRLabel();
            this.lnumeronota2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel110 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel111 = new DevExpress.XtraReports.UI.XRLabel();
            this.ldataemissao2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel8 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel113 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel114 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel115 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel116 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbairro2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lendereco2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lnome2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel120 = new DevExpress.XtraReports.UI.XRLabel();
            this.lcidade2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel122 = new DevExpress.XtraReports.UI.XRLabel();
            this.luf2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel124 = new DevExpress.XtraReports.UI.XRLabel();
            this.lcnpj2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel126 = new DevExpress.XtraReports.UI.XRLabel();
            this.linscricao2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.lnumeronota1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.ldataemissao1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel6 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel92 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel98 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel99 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel100 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel101 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel102 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel103 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel104 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel10 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel203 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel204 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel205 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel206 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel207 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel208 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel9 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel136 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel137 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel138 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel139 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel140 = new DevExpress.XtraReports.UI.XRLabel();
            this.luni1_2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lqtd1_2 = new DevExpress.XtraReports.UI.XRLabel();
            this.ldescricao1_2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlruni1_2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrtot1_2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel146 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel147 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel148 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel149 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel150 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel151 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel152 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel153 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel154 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel155 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel156 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel157 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel158 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel159 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel160 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel161 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel162 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel163 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel164 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel165 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel166 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel167 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel168 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel169 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel170 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel171 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel172 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel173 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel174 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel175 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel176 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel177 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel178 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel179 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel180 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel181 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel182 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel183 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel184 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel185 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel186 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel187 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel188 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel189 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel190 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel191 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel192 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel193 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel194 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel195 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel196 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel197 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel198 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel199 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel200 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel201 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrtotalnf1_2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel5 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel94 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel95 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel96 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel93 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel97 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel91 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel4 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.luni1_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lqtd1_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ldescricao1_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlruni1_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrtot1_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel55 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel54 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel56 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel58 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel57 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel65 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel64 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel66 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel68 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel67 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel60 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel59 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel61 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel63 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel62 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel75 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel74 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel76 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel78 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel77 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel70 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel69 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel71 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel73 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel72 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel85 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel84 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel86 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel88 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel87 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel80 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel79 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel81 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel83 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel82 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel89 = new DevExpress.XtraReports.UI.XRLabel();
            this.lvlrtotalnf1_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrCrossBandBox1 = new DevExpress.XtraReports.UI.XRCrossBandBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel3,
            this.xrPanel7,
            this.xrPanel8,
            this.xrPanel1,
            this.xrPanel2,
            this.xrPanel6,
            this.xrPanel10,
            this.xrPanel9,
            this.xrPanel5,
            this.xrPanel4});
            this.Detail.EvenStyleName = "xrControlStyle1";
            this.Detail.HeightF = 723.3752F;
            this.Detail.Name = "Detail";
            this.Detail.OddStyleName = "xrControlStyle2";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrPanel3
            // 
            this.xrPanel3.BackColor = System.Drawing.Color.Empty;
            this.xrPanel3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel29,
            this.xrLabel30,
            this.xrLabel31,
            this.xrLabel32,
            this.lbairro1,
            this.lendereco1,
            this.lnome1,
            this.xrLabel128,
            this.lcidade1,
            this.xrLabel130,
            this.luf1,
            this.xrLabel132,
            this.lcnpj1,
            this.xrLabel134,
            this.linscricao1});
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(17.14599F, 207.4376F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(534.5625F, 103.125F);
            this.xrPanel3.StylePriority.UseBackColor = false;
            this.xrPanel3.StylePriority.UseBorders = false;
            // 
            // xrLabel29
            // 
            this.xrLabel29.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel29.BorderColor = System.Drawing.Color.Black;
            this.xrLabel29.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel29.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel29.ForeColor = System.Drawing.Color.Black;
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(3F, 1.999954F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(529.4792F, 21.5417F);
            this.xrLabel29.StylePriority.UseBackColor = false;
            this.xrLabel29.StylePriority.UseBorderColor = false;
            this.xrLabel29.StylePriority.UseBorders = false;
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UseForeColor = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.Text = "USUÁRIO DOS SERVIÇOS";
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel30
            // 
            this.xrLabel30.BackColor = System.Drawing.Color.Empty;
            this.xrLabel30.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel30.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(4.999756F, 66.20821F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(62.83337F, 14F);
            this.xrLabel30.StylePriority.UseBackColor = false;
            this.xrLabel30.StylePriority.UseBorders = false;
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.Text = "Bairro";
            // 
            // xrLabel31
            // 
            this.xrLabel31.BackColor = System.Drawing.Color.Empty;
            this.xrLabel31.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel31.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(4.999756F, 50.20818F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(62.83337F, 14.00003F);
            this.xrLabel31.StylePriority.UseBackColor = false;
            this.xrLabel31.StylePriority.UseBorders = false;
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.Text = "Endereço";
            // 
            // xrLabel32
            // 
            this.xrLabel32.BackColor = System.Drawing.Color.Empty;
            this.xrLabel32.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel32.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(4.999756F, 34.20824F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(62.83337F, 14F);
            this.xrLabel32.StylePriority.UseBackColor = false;
            this.xrLabel32.StylePriority.UseBorders = false;
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.Text = "Nome";
            // 
            // lbairro1
            // 
            this.lbairro1.BackColor = System.Drawing.Color.Empty;
            this.lbairro1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbairro1.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbairro1.LocationFloat = new DevExpress.Utils.PointFloat(67.99989F, 66.20827F);
            this.lbairro1.Name = "lbairro1";
            this.lbairro1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbairro1.SizeF = new System.Drawing.SizeF(101.0417F, 14F);
            this.lbairro1.StylePriority.UseBackColor = false;
            this.lbairro1.StylePriority.UseBorders = false;
            this.lbairro1.StylePriority.UseFont = false;
            this.lbairro1.Text = "lbairro1";
            // 
            // lendereco1
            // 
            this.lendereco1.BackColor = System.Drawing.Color.Empty;
            this.lendereco1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lendereco1.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lendereco1.LocationFloat = new DevExpress.Utils.PointFloat(67.99989F, 50.2083F);
            this.lendereco1.Name = "lendereco1";
            this.lendereco1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendereco1.SizeF = new System.Drawing.SizeF(457.6249F, 13.99994F);
            this.lendereco1.StylePriority.UseBackColor = false;
            this.lendereco1.StylePriority.UseBorders = false;
            this.lendereco1.StylePriority.UseFont = false;
            this.lendereco1.Text = "lendereco1";
            // 
            // lnome1
            // 
            this.lnome1.BackColor = System.Drawing.Color.Empty;
            this.lnome1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lnome1.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnome1.LocationFloat = new DevExpress.Utils.PointFloat(67.99989F, 34.20824F);
            this.lnome1.Name = "lnome1";
            this.lnome1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lnome1.SizeF = new System.Drawing.SizeF(457.6249F, 14F);
            this.lnome1.StylePriority.UseBackColor = false;
            this.lnome1.StylePriority.UseBorders = false;
            this.lnome1.StylePriority.UseFont = false;
            this.lnome1.Text = "lnome1";
            // 
            // xrLabel128
            // 
            this.xrLabel128.BackColor = System.Drawing.Color.Empty;
            this.xrLabel128.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel128.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel128.LocationFloat = new DevExpress.Utils.PointFloat(169.9998F, 66.20827F);
            this.xrLabel128.Name = "xrLabel128";
            this.xrLabel128.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel128.SizeF = new System.Drawing.SizeF(70.14578F, 14F);
            this.xrLabel128.StylePriority.UseBackColor = false;
            this.xrLabel128.StylePriority.UseBorders = false;
            this.xrLabel128.StylePriority.UseFont = false;
            this.xrLabel128.Text = "Cidade";
            // 
            // lcidade1
            // 
            this.lcidade1.BackColor = System.Drawing.Color.Empty;
            this.lcidade1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lcidade1.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcidade1.LocationFloat = new DevExpress.Utils.PointFloat(264.9999F, 66.20833F);
            this.lcidade1.Name = "lcidade1";
            this.lcidade1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcidade1.SizeF = new System.Drawing.SizeF(159.375F, 14F);
            this.lcidade1.StylePriority.UseBackColor = false;
            this.lcidade1.StylePriority.UseBorders = false;
            this.lcidade1.StylePriority.UseFont = false;
            this.lcidade1.Text = "lcidade1";
            // 
            // xrLabel130
            // 
            this.xrLabel130.BackColor = System.Drawing.Color.Empty;
            this.xrLabel130.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel130.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel130.LocationFloat = new DevExpress.Utils.PointFloat(431.5833F, 66.20827F);
            this.xrLabel130.Name = "xrLabel130";
            this.xrLabel130.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel130.SizeF = new System.Drawing.SizeF(50.33337F, 14F);
            this.xrLabel130.StylePriority.UseBackColor = false;
            this.xrLabel130.StylePriority.UseBorders = false;
            this.xrLabel130.StylePriority.UseFont = false;
            this.xrLabel130.Text = "UF";
            // 
            // luf1
            // 
            this.luf1.BackColor = System.Drawing.Color.Empty;
            this.luf1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.luf1.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luf1.LocationFloat = new DevExpress.Utils.PointFloat(491.0834F, 66.20833F);
            this.luf1.Name = "luf1";
            this.luf1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.luf1.SizeF = new System.Drawing.SizeF(34.54144F, 14F);
            this.luf1.StylePriority.UseBackColor = false;
            this.luf1.StylePriority.UseBorders = false;
            this.luf1.StylePriority.UseFont = false;
            this.luf1.Text = "luf1";
            // 
            // xrLabel132
            // 
            this.xrLabel132.BackColor = System.Drawing.Color.Empty;
            this.xrLabel132.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel132.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel132.LocationFloat = new DevExpress.Utils.PointFloat(4.999817F, 82.20836F);
            this.xrLabel132.Name = "xrLabel132";
            this.xrLabel132.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel132.SizeF = new System.Drawing.SizeF(62.83331F, 14F);
            this.xrLabel132.StylePriority.UseBackColor = false;
            this.xrLabel132.StylePriority.UseBorders = false;
            this.xrLabel132.StylePriority.UseFont = false;
            this.xrLabel132.Text = "CNPJ.:";
            // 
            // lcnpj1
            // 
            this.lcnpj1.BackColor = System.Drawing.Color.Empty;
            this.lcnpj1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lcnpj1.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcnpj1.LocationFloat = new DevExpress.Utils.PointFloat(67.99995F, 82.20834F);
            this.lcnpj1.Name = "lcnpj1";
            this.lcnpj1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcnpj1.SizeF = new System.Drawing.SizeF(123.9583F, 14F);
            this.lcnpj1.StylePriority.UseBackColor = false;
            this.lcnpj1.StylePriority.UseBorders = false;
            this.lcnpj1.StylePriority.UseFont = false;
            this.lcnpj1.Text = "lcnpj1";
            // 
            // xrLabel134
            // 
            this.xrLabel134.BackColor = System.Drawing.Color.Empty;
            this.xrLabel134.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel134.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel134.LocationFloat = new DevExpress.Utils.PointFloat(280.8748F, 82.2083F);
            this.xrLabel134.Name = "xrLabel134";
            this.xrLabel134.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel134.SizeF = new System.Drawing.SizeF(143.5F, 14F);
            this.xrLabel134.StylePriority.UseBackColor = false;
            this.xrLabel134.StylePriority.UseBorders = false;
            this.xrLabel134.StylePriority.UseFont = false;
            this.xrLabel134.Text = "Inscr.Estadual/Municipal";
            // 
            // linscricao1
            // 
            this.linscricao1.BackColor = System.Drawing.Color.Empty;
            this.linscricao1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.linscricao1.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linscricao1.LocationFloat = new DevExpress.Utils.PointFloat(424.3749F, 82.20831F);
            this.linscricao1.Name = "linscricao1";
            this.linscricao1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linscricao1.SizeF = new System.Drawing.SizeF(101.7914F, 14F);
            this.linscricao1.StylePriority.UseBackColor = false;
            this.linscricao1.StylePriority.UseBorders = false;
            this.linscricao1.StylePriority.UseFont = false;
            this.linscricao1.Text = "linscricao1";
            // 
            // xrPanel7
            // 
            this.xrPanel7.BackColor = System.Drawing.Color.Empty;
            this.xrPanel7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel7.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel105,
            this.xrLabel106,
            this.xrLabel107,
            this.xrLabel108,
            this.lnumeronota2,
            this.xrLabel110,
            this.xrLabel111,
            this.ldataemissao2});
            this.xrPanel7.LocationFloat = new DevExpress.Utils.PointFloat(868.5936F, 1.520934F);
            this.xrPanel7.Name = "xrPanel7";
            this.xrPanel7.SizeF = new System.Drawing.SizeF(250.6875F, 205.79F);
            this.xrPanel7.StylePriority.UseBackColor = false;
            this.xrPanel7.StylePriority.UseBorders = false;
            // 
            // xrLabel105
            // 
            this.xrLabel105.BackColor = System.Drawing.Color.Empty;
            this.xrLabel105.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel105.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel105.LocationFloat = new DevExpress.Utils.PointFloat(5.749939F, 8.000009F);
            this.xrLabel105.Name = "xrLabel105";
            this.xrLabel105.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel105.SizeF = new System.Drawing.SizeF(239.2919F, 14F);
            this.xrLabel105.StylePriority.UseBackColor = false;
            this.xrLabel105.StylePriority.UseBorders = false;
            this.xrLabel105.StylePriority.UseFont = false;
            this.xrLabel105.StylePriority.UseTextAlignment = false;
            this.xrLabel105.Text = "Documento Fiscal Simplificado de Serviços";
            this.xrLabel105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel106
            // 
            this.xrLabel106.BackColor = System.Drawing.Color.Empty;
            this.xrLabel106.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel106.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel106.LocationFloat = new DevExpress.Utils.PointFloat(5.749939F, 22.00001F);
            this.xrLabel106.Name = "xrLabel106";
            this.xrLabel106.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel106.SizeF = new System.Drawing.SizeF(239.2919F, 14F);
            this.xrLabel106.StylePriority.UseBackColor = false;
            this.xrLabel106.StylePriority.UseBorders = false;
            this.xrLabel106.StylePriority.UseFont = false;
            this.xrLabel106.StylePriority.UseTextAlignment = false;
            this.xrLabel106.Text = "(Micro Empreendedor Individual - MEI)";
            this.xrLabel106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel107
            // 
            this.xrLabel107.BackColor = System.Drawing.Color.Empty;
            this.xrLabel107.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel107.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel107.LocationFloat = new DevExpress.Utils.PointFloat(5.749939F, 36.00003F);
            this.xrLabel107.Name = "xrLabel107";
            this.xrLabel107.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel107.SizeF = new System.Drawing.SizeF(233.8543F, 14F);
            this.xrLabel107.StylePriority.UseBackColor = false;
            this.xrLabel107.StylePriority.UseBorders = false;
            this.xrLabel107.StylePriority.UseFont = false;
            this.xrLabel107.StylePriority.UseTextAlignment = false;
            this.xrLabel107.Text = "(Extraida em 2 (Duas) Vias)";
            this.xrLabel107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel108
            // 
            this.xrLabel108.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel108.BorderColor = System.Drawing.Color.Empty;
            this.xrLabel108.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel108.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel108.ForeColor = System.Drawing.Color.Black;
            this.xrLabel108.LocationFloat = new DevExpress.Utils.PointFloat(13.75F, 82.66678F);
            this.xrLabel108.Name = "xrLabel108";
            this.xrLabel108.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel108.SizeF = new System.Drawing.SizeF(102.2501F, 21.54172F);
            this.xrLabel108.StylePriority.UseBackColor = false;
            this.xrLabel108.StylePriority.UseBorderColor = false;
            this.xrLabel108.StylePriority.UseBorders = false;
            this.xrLabel108.StylePriority.UseFont = false;
            this.xrLabel108.StylePriority.UseForeColor = false;
            this.xrLabel108.StylePriority.UseTextAlignment = false;
            this.xrLabel108.Text = "No.:";
            this.xrLabel108.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lnumeronota2
            // 
            this.lnumeronota2.BackColor = System.Drawing.Color.Transparent;
            this.lnumeronota2.BorderColor = System.Drawing.Color.Empty;
            this.lnumeronota2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lnumeronota2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lnumeronota2.ForeColor = System.Drawing.Color.Black;
            this.lnumeronota2.LocationFloat = new DevExpress.Utils.PointFloat(116.0002F, 82.66676F);
            this.lnumeronota2.Name = "lnumeronota2";
            this.lnumeronota2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lnumeronota2.SizeF = new System.Drawing.SizeF(102.2917F, 21.54172F);
            this.lnumeronota2.StylePriority.UseBackColor = false;
            this.lnumeronota2.StylePriority.UseBorderColor = false;
            this.lnumeronota2.StylePriority.UseBorders = false;
            this.lnumeronota2.StylePriority.UseFont = false;
            this.lnumeronota2.StylePriority.UseForeColor = false;
            this.lnumeronota2.StylePriority.UseTextAlignment = false;
            this.lnumeronota2.Text = "999";
            this.lnumeronota2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel110
            // 
            this.xrLabel110.BackColor = System.Drawing.Color.Empty;
            this.xrLabel110.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel110.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel110.LocationFloat = new DevExpress.Utils.PointFloat(13.75006F, 104.7501F);
            this.xrLabel110.Name = "xrLabel110";
            this.xrLabel110.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel110.SizeF = new System.Drawing.SizeF(204.5418F, 14F);
            this.xrLabel110.StylePriority.UseBackColor = false;
            this.xrLabel110.StylePriority.UseBorders = false;
            this.xrLabel110.StylePriority.UseFont = false;
            this.xrLabel110.StylePriority.UseTextAlignment = false;
            this.xrLabel110.Text = "2a. Via";
            this.xrLabel110.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel111
            // 
            this.xrLabel111.BackColor = System.Drawing.Color.Empty;
            this.xrLabel111.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel111.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel111.LocationFloat = new DevExpress.Utils.PointFloat(13.75008F, 181.79F);
            this.xrLabel111.Name = "xrLabel111";
            this.xrLabel111.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel111.SizeF = new System.Drawing.SizeF(102.7501F, 14F);
            this.xrLabel111.StylePriority.UseBackColor = false;
            this.xrLabel111.StylePriority.UseBorders = false;
            this.xrLabel111.StylePriority.UseFont = false;
            this.xrLabel111.StylePriority.UseTextAlignment = false;
            this.xrLabel111.Text = "Data de Emissão.:";
            this.xrLabel111.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ldataemissao2
            // 
            this.ldataemissao2.BackColor = System.Drawing.Color.Empty;
            this.ldataemissao2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.ldataemissao2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldataemissao2.LocationFloat = new DevExpress.Utils.PointFloat(128.9168F, 181.79F);
            this.ldataemissao2.Name = "ldataemissao2";
            this.ldataemissao2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldataemissao2.SizeF = new System.Drawing.SizeF(88.16666F, 14F);
            this.ldataemissao2.StylePriority.UseBackColor = false;
            this.ldataemissao2.StylePriority.UseBorders = false;
            this.ldataemissao2.StylePriority.UseFont = false;
            this.ldataemissao2.StylePriority.UseTextAlignment = false;
            this.ldataemissao2.Text = "99/99/9999";
            this.ldataemissao2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPanel8
            // 
            this.xrPanel8.BackColor = System.Drawing.Color.Empty;
            this.xrPanel8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel8.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel113,
            this.xrLabel114,
            this.xrLabel115,
            this.xrLabel116,
            this.lbairro2,
            this.lendereco2,
            this.lnome2,
            this.xrLabel120,
            this.lcidade2,
            this.xrLabel122,
            this.luf2,
            this.xrLabel124,
            this.lcnpj2,
            this.xrLabel126,
            this.linscricao2});
            this.xrPanel8.LocationFloat = new DevExpress.Utils.PointFloat(585.2916F, 208.1459F);
            this.xrPanel8.Name = "xrPanel8";
            this.xrPanel8.SizeF = new System.Drawing.SizeF(534.5625F, 103.125F);
            this.xrPanel8.StylePriority.UseBackColor = false;
            this.xrPanel8.StylePriority.UseBorders = false;
            // 
            // xrLabel113
            // 
            this.xrLabel113.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel113.BorderColor = System.Drawing.Color.Black;
            this.xrLabel113.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel113.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel113.ForeColor = System.Drawing.Color.Black;
            this.xrLabel113.LocationFloat = new DevExpress.Utils.PointFloat(3F, 1.999954F);
            this.xrLabel113.Name = "xrLabel113";
            this.xrLabel113.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel113.SizeF = new System.Drawing.SizeF(529.4792F, 21.5417F);
            this.xrLabel113.StylePriority.UseBackColor = false;
            this.xrLabel113.StylePriority.UseBorderColor = false;
            this.xrLabel113.StylePriority.UseBorders = false;
            this.xrLabel113.StylePriority.UseFont = false;
            this.xrLabel113.StylePriority.UseForeColor = false;
            this.xrLabel113.StylePriority.UseTextAlignment = false;
            this.xrLabel113.Text = "USUÁRIO DOS SERVIÇOS";
            this.xrLabel113.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel114
            // 
            this.xrLabel114.BackColor = System.Drawing.Color.Empty;
            this.xrLabel114.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel114.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel114.LocationFloat = new DevExpress.Utils.PointFloat(4.999756F, 66.20821F);
            this.xrLabel114.Name = "xrLabel114";
            this.xrLabel114.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel114.SizeF = new System.Drawing.SizeF(62.83337F, 14F);
            this.xrLabel114.StylePriority.UseBackColor = false;
            this.xrLabel114.StylePriority.UseBorders = false;
            this.xrLabel114.StylePriority.UseFont = false;
            this.xrLabel114.Text = "Bairro";
            // 
            // xrLabel115
            // 
            this.xrLabel115.BackColor = System.Drawing.Color.Empty;
            this.xrLabel115.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel115.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel115.LocationFloat = new DevExpress.Utils.PointFloat(4.999756F, 50.20818F);
            this.xrLabel115.Name = "xrLabel115";
            this.xrLabel115.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel115.SizeF = new System.Drawing.SizeF(62.83337F, 14.00003F);
            this.xrLabel115.StylePriority.UseBackColor = false;
            this.xrLabel115.StylePriority.UseBorders = false;
            this.xrLabel115.StylePriority.UseFont = false;
            this.xrLabel115.Text = "Endereço";
            // 
            // xrLabel116
            // 
            this.xrLabel116.BackColor = System.Drawing.Color.Empty;
            this.xrLabel116.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel116.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel116.LocationFloat = new DevExpress.Utils.PointFloat(4.999756F, 34.20824F);
            this.xrLabel116.Name = "xrLabel116";
            this.xrLabel116.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel116.SizeF = new System.Drawing.SizeF(62.83337F, 14F);
            this.xrLabel116.StylePriority.UseBackColor = false;
            this.xrLabel116.StylePriority.UseBorders = false;
            this.xrLabel116.StylePriority.UseFont = false;
            this.xrLabel116.Text = "Nome";
            // 
            // lbairro2
            // 
            this.lbairro2.BackColor = System.Drawing.Color.Empty;
            this.lbairro2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbairro2.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbairro2.LocationFloat = new DevExpress.Utils.PointFloat(67.99989F, 66.20827F);
            this.lbairro2.Name = "lbairro2";
            this.lbairro2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbairro2.SizeF = new System.Drawing.SizeF(101.0417F, 14F);
            this.lbairro2.StylePriority.UseBackColor = false;
            this.lbairro2.StylePriority.UseBorders = false;
            this.lbairro2.StylePriority.UseFont = false;
            this.lbairro2.Text = "lbairro2";
            // 
            // lendereco2
            // 
            this.lendereco2.BackColor = System.Drawing.Color.Empty;
            this.lendereco2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lendereco2.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lendereco2.LocationFloat = new DevExpress.Utils.PointFloat(67.99989F, 50.2083F);
            this.lendereco2.Name = "lendereco2";
            this.lendereco2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lendereco2.SizeF = new System.Drawing.SizeF(457.6249F, 13.99994F);
            this.lendereco2.StylePriority.UseBackColor = false;
            this.lendereco2.StylePriority.UseBorders = false;
            this.lendereco2.StylePriority.UseFont = false;
            this.lendereco2.Text = "lendereco2";
            // 
            // lnome2
            // 
            this.lnome2.BackColor = System.Drawing.Color.Empty;
            this.lnome2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lnome2.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnome2.LocationFloat = new DevExpress.Utils.PointFloat(67.99989F, 34.20824F);
            this.lnome2.Name = "lnome2";
            this.lnome2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lnome2.SizeF = new System.Drawing.SizeF(457.6249F, 14F);
            this.lnome2.StylePriority.UseBackColor = false;
            this.lnome2.StylePriority.UseBorders = false;
            this.lnome2.StylePriority.UseFont = false;
            this.lnome2.Text = "lnome2";
            // 
            // xrLabel120
            // 
            this.xrLabel120.BackColor = System.Drawing.Color.Empty;
            this.xrLabel120.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel120.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel120.LocationFloat = new DevExpress.Utils.PointFloat(169.9998F, 66.20828F);
            this.xrLabel120.Name = "xrLabel120";
            this.xrLabel120.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel120.SizeF = new System.Drawing.SizeF(67.21863F, 14F);
            this.xrLabel120.StylePriority.UseBackColor = false;
            this.xrLabel120.StylePriority.UseBorders = false;
            this.xrLabel120.StylePriority.UseFont = false;
            this.xrLabel120.Text = "Cidade";
            // 
            // lcidade2
            // 
            this.lcidade2.BackColor = System.Drawing.Color.Empty;
            this.lcidade2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lcidade2.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcidade2.LocationFloat = new DevExpress.Utils.PointFloat(264.9999F, 66.20833F);
            this.lcidade2.Name = "lcidade2";
            this.lcidade2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcidade2.SizeF = new System.Drawing.SizeF(159.375F, 14F);
            this.lcidade2.StylePriority.UseBackColor = false;
            this.lcidade2.StylePriority.UseBorders = false;
            this.lcidade2.StylePriority.UseFont = false;
            this.lcidade2.Text = "lcidade2";
            // 
            // xrLabel122
            // 
            this.xrLabel122.BackColor = System.Drawing.Color.Empty;
            this.xrLabel122.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel122.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel122.LocationFloat = new DevExpress.Utils.PointFloat(431.5833F, 66.20827F);
            this.xrLabel122.Name = "xrLabel122";
            this.xrLabel122.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel122.SizeF = new System.Drawing.SizeF(50.33337F, 14F);
            this.xrLabel122.StylePriority.UseBackColor = false;
            this.xrLabel122.StylePriority.UseBorders = false;
            this.xrLabel122.StylePriority.UseFont = false;
            this.xrLabel122.Text = "UF";
            // 
            // luf2
            // 
            this.luf2.BackColor = System.Drawing.Color.Empty;
            this.luf2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.luf2.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luf2.LocationFloat = new DevExpress.Utils.PointFloat(491.0834F, 66.20833F);
            this.luf2.Name = "luf2";
            this.luf2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.luf2.SizeF = new System.Drawing.SizeF(34.54144F, 14F);
            this.luf2.StylePriority.UseBackColor = false;
            this.luf2.StylePriority.UseBorders = false;
            this.luf2.StylePriority.UseFont = false;
            this.luf2.Text = "luf2";
            // 
            // xrLabel124
            // 
            this.xrLabel124.BackColor = System.Drawing.Color.Empty;
            this.xrLabel124.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel124.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel124.LocationFloat = new DevExpress.Utils.PointFloat(4.999817F, 82.20836F);
            this.xrLabel124.Name = "xrLabel124";
            this.xrLabel124.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel124.SizeF = new System.Drawing.SizeF(62.83331F, 14F);
            this.xrLabel124.StylePriority.UseBackColor = false;
            this.xrLabel124.StylePriority.UseBorders = false;
            this.xrLabel124.StylePriority.UseFont = false;
            this.xrLabel124.Text = "CNPJ.:";
            // 
            // lcnpj2
            // 
            this.lcnpj2.BackColor = System.Drawing.Color.Empty;
            this.lcnpj2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lcnpj2.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcnpj2.LocationFloat = new DevExpress.Utils.PointFloat(67.99995F, 82.20834F);
            this.lcnpj2.Name = "lcnpj2";
            this.lcnpj2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lcnpj2.SizeF = new System.Drawing.SizeF(123.9583F, 14F);
            this.lcnpj2.StylePriority.UseBackColor = false;
            this.lcnpj2.StylePriority.UseBorders = false;
            this.lcnpj2.StylePriority.UseFont = false;
            this.lcnpj2.Text = "lcnpj2";
            // 
            // xrLabel126
            // 
            this.xrLabel126.BackColor = System.Drawing.Color.Empty;
            this.xrLabel126.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel126.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel126.LocationFloat = new DevExpress.Utils.PointFloat(280.8748F, 82.2083F);
            this.xrLabel126.Name = "xrLabel126";
            this.xrLabel126.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel126.SizeF = new System.Drawing.SizeF(143.5F, 14F);
            this.xrLabel126.StylePriority.UseBackColor = false;
            this.xrLabel126.StylePriority.UseBorders = false;
            this.xrLabel126.StylePriority.UseFont = false;
            this.xrLabel126.Text = "Inscr.Estadual/Municipal";
            // 
            // linscricao2
            // 
            this.linscricao2.BackColor = System.Drawing.Color.Empty;
            this.linscricao2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.linscricao2.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linscricao2.LocationFloat = new DevExpress.Utils.PointFloat(424.3749F, 82.20831F);
            this.linscricao2.Name = "linscricao2";
            this.linscricao2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.linscricao2.SizeF = new System.Drawing.SizeF(101.7914F, 14F);
            this.linscricao2.StylePriority.UseBackColor = false;
            this.linscricao2.StylePriority.UseBorders = false;
            this.linscricao2.StylePriority.UseFont = false;
            this.linscricao2.Text = "linscricao2";
            // 
            // xrPanel1
            // 
            this.xrPanel1.BackColor = System.Drawing.Color.Empty;
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.xrLabel14,
            this.xrLabel15,
            this.xrLabel16,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel19,
            this.xrLabel20});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(16.14587F, 1.64595F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(284.375F, 205.7916F);
            this.xrPanel1.StylePriority.UseBackColor = false;
            this.xrPanel1.StylePriority.UseBorders = false;
            // 
            // xrLabel13
            // 
            this.xrLabel13.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel13.BorderColor = System.Drawing.Color.Empty;
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.ForeColor = System.Drawing.Color.Black;
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(4.000038F, 31.04162F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(278.2502F, 21.54171F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseBorderColor = false;
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "VÍVIAN T. FERNANDES";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel14
            // 
            this.xrLabel14.BackColor = System.Drawing.Color.Empty;
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(4.000038F, 1.874987F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(276.2501F, 14F);
            this.xrLabel14.StylePriority.UseBackColor = false;
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Serviços de Informática, Consertos e Manutenções.";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel15
            // 
            this.xrLabel15.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel15.BorderColor = System.Drawing.Color.Empty;
            this.xrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.ForeColor = System.Drawing.Color.Black;
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(4.000038F, 52.58338F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(278.2502F, 21.54171F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseBorderColor = false;
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "CNPJ.: 13.305.470/0001-05";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel16
            // 
            this.xrLabel16.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel16.BorderColor = System.Drawing.Color.Empty;
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.ForeColor = System.Drawing.Color.Black;
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(4.000038F, 74.1251F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(278.2502F, 21.54171F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseBorderColor = false;
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseForeColor = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "NIRE.: 33-8-0118471-9";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel17
            // 
            this.xrLabel17.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel17.BorderColor = System.Drawing.Color.Empty;
            this.xrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.ForeColor = System.Drawing.Color.Black;
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(4.000038F, 96.66679F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(278.2502F, 21.54171F);
            this.xrLabel17.StylePriority.UseBackColor = false;
            this.xrLabel17.StylePriority.UseBorderColor = false;
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseForeColor = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "CPF.: 033.396.577-93";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel18
            // 
            this.xrLabel18.BackColor = System.Drawing.Color.Empty;
            this.xrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel18.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(4.000038F, 132.4166F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(276.2501F, 14F);
            this.xrLabel18.StylePriority.UseBackColor = false;
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Rua. Iraçi Luchina, 62 - Campo Grande";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BackColor = System.Drawing.Color.Empty;
            this.xrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel19.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(4.000038F, 146.4166F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(276.2501F, 14F);
            this.xrLabel19.StylePriority.UseBackColor = false;
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "Rio de Janeiro - RJ - Cep 23080-600";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel20
            // 
            this.xrLabel20.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel20.BorderColor = System.Drawing.Color.Black;
            this.xrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel20.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel20.ForeColor = System.Drawing.Color.Black;
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(2.99984F, 182.2499F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(279.2502F, 21.54173F);
            this.xrLabel20.StylePriority.UseBackColor = false;
            this.xrLabel20.StylePriority.UseBorderColor = false;
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseForeColor = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "CNPJ.: 13.305.470/0001-05 Inscr. Mun.: ISENTO";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPanel2
            // 
            this.xrPanel2.BackColor = System.Drawing.Color.Empty;
            this.xrPanel2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel21,
            this.xrLabel22,
            this.xrLabel23,
            this.xrLabel24,
            this.lnumeronota1,
            this.xrLabel26,
            this.xrLabel27,
            this.ldataemissao1});
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(301.021F, 1.64595F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(250.6876F, 205.79F);
            this.xrPanel2.StylePriority.UseBackColor = false;
            this.xrPanel2.StylePriority.UseBorders = false;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BackColor = System.Drawing.Color.Empty;
            this.xrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel21.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(5.749939F, 8.000009F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(239.2919F, 14F);
            this.xrLabel21.StylePriority.UseBackColor = false;
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "Documento Fiscal Simplificado de Serviços";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel22
            // 
            this.xrLabel22.BackColor = System.Drawing.Color.Empty;
            this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel22.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(5.749939F, 22.00001F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(239.2919F, 14F);
            this.xrLabel22.StylePriority.UseBackColor = false;
            this.xrLabel22.StylePriority.UseBorders = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "(Micro Empreendedor Individual - MEI)";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel23
            // 
            this.xrLabel23.BackColor = System.Drawing.Color.Empty;
            this.xrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel23.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(5.749939F, 36.00003F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(233.8543F, 14F);
            this.xrLabel23.StylePriority.UseBackColor = false;
            this.xrLabel23.StylePriority.UseBorders = false;
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "(Extraida em 2 (Duas) Vias)";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel24
            // 
            this.xrLabel24.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel24.BorderColor = System.Drawing.Color.Empty;
            this.xrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel24.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel24.ForeColor = System.Drawing.Color.Black;
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(13.75F, 82.66678F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(102.2501F, 21.54172F);
            this.xrLabel24.StylePriority.UseBackColor = false;
            this.xrLabel24.StylePriority.UseBorderColor = false;
            this.xrLabel24.StylePriority.UseBorders = false;
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseForeColor = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "No.:";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lnumeronota1
            // 
            this.lnumeronota1.BackColor = System.Drawing.Color.Transparent;
            this.lnumeronota1.BorderColor = System.Drawing.Color.Empty;
            this.lnumeronota1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lnumeronota1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lnumeronota1.ForeColor = System.Drawing.Color.Black;
            this.lnumeronota1.LocationFloat = new DevExpress.Utils.PointFloat(116.1044F, 82.66678F);
            this.lnumeronota1.Name = "lnumeronota1";
            this.lnumeronota1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lnumeronota1.SizeF = new System.Drawing.SizeF(102.1874F, 21.54172F);
            this.lnumeronota1.StylePriority.UseBackColor = false;
            this.lnumeronota1.StylePriority.UseBorderColor = false;
            this.lnumeronota1.StylePriority.UseBorders = false;
            this.lnumeronota1.StylePriority.UseFont = false;
            this.lnumeronota1.StylePriority.UseForeColor = false;
            this.lnumeronota1.StylePriority.UseTextAlignment = false;
            this.lnumeronota1.Text = "999";
            this.lnumeronota1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel26
            // 
            this.xrLabel26.BackColor = System.Drawing.Color.Empty;
            this.xrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel26.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(13.75006F, 104.7501F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(204.5418F, 14F);
            this.xrLabel26.StylePriority.UseBackColor = false;
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.Text = "1a. Via";
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel27
            // 
            this.xrLabel27.BackColor = System.Drawing.Color.Empty;
            this.xrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel27.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(13.75008F, 181.79F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(102.75F, 13.99998F);
            this.xrLabel27.StylePriority.UseBackColor = false;
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "Data de Emissão.:";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ldataemissao1
            // 
            this.ldataemissao1.BackColor = System.Drawing.Color.Empty;
            this.ldataemissao1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.ldataemissao1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldataemissao1.LocationFloat = new DevExpress.Utils.PointFloat(128.9168F, 181.79F);
            this.ldataemissao1.Name = "ldataemissao1";
            this.ldataemissao1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldataemissao1.SizeF = new System.Drawing.SizeF(88.16666F, 14F);
            this.ldataemissao1.StylePriority.UseBackColor = false;
            this.ldataemissao1.StylePriority.UseBorders = false;
            this.ldataemissao1.StylePriority.UseFont = false;
            this.ldataemissao1.StylePriority.UseTextAlignment = false;
            this.ldataemissao1.Text = "99/99/9999";
            this.ldataemissao1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPanel6
            // 
            this.xrPanel6.BackColor = System.Drawing.Color.Empty;
            this.xrPanel6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel92,
            this.xrLabel98,
            this.xrLabel99,
            this.xrLabel100,
            this.xrLabel101,
            this.xrLabel102,
            this.xrLabel103,
            this.xrLabel104});
            this.xrPanel6.LocationFloat = new DevExpress.Utils.PointFloat(584.7186F, 1.520934F);
            this.xrPanel6.Name = "xrPanel6";
            this.xrPanel6.SizeF = new System.Drawing.SizeF(283.3749F, 205.7916F);
            this.xrPanel6.StylePriority.UseBackColor = false;
            this.xrPanel6.StylePriority.UseBorders = false;
            // 
            // xrLabel92
            // 
            this.xrLabel92.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel92.BorderColor = System.Drawing.Color.Empty;
            this.xrLabel92.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel92.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel92.ForeColor = System.Drawing.Color.Black;
            this.xrLabel92.LocationFloat = new DevExpress.Utils.PointFloat(4.000038F, 31.04162F);
            this.xrLabel92.Name = "xrLabel92";
            this.xrLabel92.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel92.SizeF = new System.Drawing.SizeF(278.2502F, 21.54171F);
            this.xrLabel92.StylePriority.UseBackColor = false;
            this.xrLabel92.StylePriority.UseBorderColor = false;
            this.xrLabel92.StylePriority.UseBorders = false;
            this.xrLabel92.StylePriority.UseFont = false;
            this.xrLabel92.StylePriority.UseForeColor = false;
            this.xrLabel92.StylePriority.UseTextAlignment = false;
            this.xrLabel92.Text = "VÍVIAN T. FERNANDES";
            this.xrLabel92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel98
            // 
            this.xrLabel98.BackColor = System.Drawing.Color.Empty;
            this.xrLabel98.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel98.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel98.LocationFloat = new DevExpress.Utils.PointFloat(4.000038F, 1.874987F);
            this.xrLabel98.Name = "xrLabel98";
            this.xrLabel98.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel98.SizeF = new System.Drawing.SizeF(276.2501F, 14F);
            this.xrLabel98.StylePriority.UseBackColor = false;
            this.xrLabel98.StylePriority.UseBorders = false;
            this.xrLabel98.StylePriority.UseFont = false;
            this.xrLabel98.StylePriority.UseTextAlignment = false;
            this.xrLabel98.Text = "Serviços de Informática, Consertos e Manutenções.";
            this.xrLabel98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel99
            // 
            this.xrLabel99.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel99.BorderColor = System.Drawing.Color.Empty;
            this.xrLabel99.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel99.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel99.ForeColor = System.Drawing.Color.Black;
            this.xrLabel99.LocationFloat = new DevExpress.Utils.PointFloat(4.000038F, 52.58338F);
            this.xrLabel99.Name = "xrLabel99";
            this.xrLabel99.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel99.SizeF = new System.Drawing.SizeF(278.2502F, 21.54171F);
            this.xrLabel99.StylePriority.UseBackColor = false;
            this.xrLabel99.StylePriority.UseBorderColor = false;
            this.xrLabel99.StylePriority.UseBorders = false;
            this.xrLabel99.StylePriority.UseFont = false;
            this.xrLabel99.StylePriority.UseForeColor = false;
            this.xrLabel99.StylePriority.UseTextAlignment = false;
            this.xrLabel99.Text = "CNPJ.: 13.305.470/0001-05";
            this.xrLabel99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel100
            // 
            this.xrLabel100.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel100.BorderColor = System.Drawing.Color.Empty;
            this.xrLabel100.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel100.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel100.ForeColor = System.Drawing.Color.Black;
            this.xrLabel100.LocationFloat = new DevExpress.Utils.PointFloat(4.000038F, 74.1251F);
            this.xrLabel100.Name = "xrLabel100";
            this.xrLabel100.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel100.SizeF = new System.Drawing.SizeF(278.2502F, 21.54171F);
            this.xrLabel100.StylePriority.UseBackColor = false;
            this.xrLabel100.StylePriority.UseBorderColor = false;
            this.xrLabel100.StylePriority.UseBorders = false;
            this.xrLabel100.StylePriority.UseFont = false;
            this.xrLabel100.StylePriority.UseForeColor = false;
            this.xrLabel100.StylePriority.UseTextAlignment = false;
            this.xrLabel100.Text = "NIRE.: 33-8-0118471-9";
            this.xrLabel100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel101
            // 
            this.xrLabel101.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel101.BorderColor = System.Drawing.Color.Empty;
            this.xrLabel101.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel101.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel101.ForeColor = System.Drawing.Color.Black;
            this.xrLabel101.LocationFloat = new DevExpress.Utils.PointFloat(4.000038F, 96.66679F);
            this.xrLabel101.Name = "xrLabel101";
            this.xrLabel101.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel101.SizeF = new System.Drawing.SizeF(278.2502F, 21.54171F);
            this.xrLabel101.StylePriority.UseBackColor = false;
            this.xrLabel101.StylePriority.UseBorderColor = false;
            this.xrLabel101.StylePriority.UseBorders = false;
            this.xrLabel101.StylePriority.UseFont = false;
            this.xrLabel101.StylePriority.UseForeColor = false;
            this.xrLabel101.StylePriority.UseTextAlignment = false;
            this.xrLabel101.Text = "CPF.: 033.396.577-93";
            this.xrLabel101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel102
            // 
            this.xrLabel102.BackColor = System.Drawing.Color.Empty;
            this.xrLabel102.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel102.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel102.LocationFloat = new DevExpress.Utils.PointFloat(4.000038F, 132.4166F);
            this.xrLabel102.Name = "xrLabel102";
            this.xrLabel102.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel102.SizeF = new System.Drawing.SizeF(276.2501F, 14F);
            this.xrLabel102.StylePriority.UseBackColor = false;
            this.xrLabel102.StylePriority.UseBorders = false;
            this.xrLabel102.StylePriority.UseFont = false;
            this.xrLabel102.StylePriority.UseTextAlignment = false;
            this.xrLabel102.Text = "Rua. Iraçi Luchina, 62 - Campo Grande";
            this.xrLabel102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel103
            // 
            this.xrLabel103.BackColor = System.Drawing.Color.Empty;
            this.xrLabel103.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel103.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel103.LocationFloat = new DevExpress.Utils.PointFloat(4.000038F, 146.4166F);
            this.xrLabel103.Name = "xrLabel103";
            this.xrLabel103.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel103.SizeF = new System.Drawing.SizeF(276.2501F, 14F);
            this.xrLabel103.StylePriority.UseBackColor = false;
            this.xrLabel103.StylePriority.UseBorders = false;
            this.xrLabel103.StylePriority.UseFont = false;
            this.xrLabel103.StylePriority.UseTextAlignment = false;
            this.xrLabel103.Text = "Rio de Janeiro - RJ - Cep 23080-600";
            this.xrLabel103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel104
            // 
            this.xrLabel104.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel104.BorderColor = System.Drawing.Color.Black;
            this.xrLabel104.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel104.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel104.ForeColor = System.Drawing.Color.Black;
            this.xrLabel104.LocationFloat = new DevExpress.Utils.PointFloat(2.99984F, 182.2499F);
            this.xrLabel104.Name = "xrLabel104";
            this.xrLabel104.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel104.SizeF = new System.Drawing.SizeF(279.2502F, 21.54173F);
            this.xrLabel104.StylePriority.UseBackColor = false;
            this.xrLabel104.StylePriority.UseBorderColor = false;
            this.xrLabel104.StylePriority.UseBorders = false;
            this.xrLabel104.StylePriority.UseFont = false;
            this.xrLabel104.StylePriority.UseForeColor = false;
            this.xrLabel104.StylePriority.UseTextAlignment = false;
            this.xrLabel104.Text = "CNPJ.: 13.305.470/0001-05 Inscr. Mun.: ISENTO";
            this.xrLabel104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPanel10
            // 
            this.xrPanel10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel10.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel203,
            this.xrLabel204,
            this.xrLabel205,
            this.xrLabel206,
            this.xrLabel207,
            this.xrLabel208});
            this.xrPanel10.LocationFloat = new DevExpress.Utils.PointFloat(584.7186F, 638.5002F);
            this.xrPanel10.Name = "xrPanel10";
            this.xrPanel10.SizeF = new System.Drawing.SizeF(535.5626F, 80.41672F);
            this.xrPanel10.StylePriority.UseBorders = false;
            // 
            // xrLabel203
            // 
            this.xrLabel203.BackColor = System.Drawing.Color.Empty;
            this.xrLabel203.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel203.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel203.LocationFloat = new DevExpress.Utils.PointFloat(42.70827F, 58.24986F);
            this.xrLabel203.Name = "xrLabel203";
            this.xrLabel203.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel203.SizeF = new System.Drawing.SizeF(121.8748F, 14F);
            this.xrLabel203.StylePriority.UseBackColor = false;
            this.xrLabel203.StylePriority.UseBorders = false;
            this.xrLabel203.StylePriority.UseFont = false;
            this.xrLabel203.StylePriority.UseTextAlignment = false;
            this.xrLabel203.Text = "____/____/________";
            this.xrLabel203.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel204
            // 
            this.xrLabel204.BackColor = System.Drawing.Color.Empty;
            this.xrLabel204.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel204.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel204.LocationFloat = new DevExpress.Utils.PointFloat(174.5831F, 58.24986F);
            this.xrLabel204.Name = "xrLabel204";
            this.xrLabel204.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel204.SizeF = new System.Drawing.SizeF(64.20832F, 14F);
            this.xrLabel204.StylePriority.UseBackColor = false;
            this.xrLabel204.StylePriority.UseBorders = false;
            this.xrLabel204.StylePriority.UseFont = false;
            this.xrLabel204.StylePriority.UseTextAlignment = false;
            this.xrLabel204.Text = "Assinatura:";
            this.xrLabel204.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel205
            // 
            this.xrLabel205.BackColor = System.Drawing.Color.Empty;
            this.xrLabel205.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel205.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel205.LocationFloat = new DevExpress.Utils.PointFloat(241.3333F, 58.24986F);
            this.xrLabel205.Name = "xrLabel205";
            this.xrLabel205.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel205.SizeF = new System.Drawing.SizeF(264.2084F, 14F);
            this.xrLabel205.StylePriority.UseBackColor = false;
            this.xrLabel205.StylePriority.UseBorders = false;
            this.xrLabel205.StylePriority.UseFont = false;
            this.xrLabel205.StylePriority.UseTextAlignment = false;
            this.xrLabel205.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel206
            // 
            this.xrLabel206.BackColor = System.Drawing.Color.Empty;
            this.xrLabel206.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel206.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel206.LocationFloat = new DevExpress.Utils.PointFloat(6.999969F, 58.24986F);
            this.xrLabel206.Name = "xrLabel206";
            this.xrLabel206.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel206.SizeF = new System.Drawing.SizeF(32.95832F, 14.00003F);
            this.xrLabel206.StylePriority.UseBackColor = false;
            this.xrLabel206.StylePriority.UseBorders = false;
            this.xrLabel206.StylePriority.UseFont = false;
            this.xrLabel206.StylePriority.UseTextAlignment = false;
            this.xrLabel206.Text = "Em:";
            this.xrLabel206.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel207
            // 
            this.xrLabel207.BackColor = System.Drawing.Color.Empty;
            this.xrLabel207.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel207.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel207.LocationFloat = new DevExpress.Utils.PointFloat(6.999978F, 2F);
            this.xrLabel207.Name = "xrLabel207";
            this.xrLabel207.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel207.SizeF = new System.Drawing.SizeF(497.1665F, 14F);
            this.xrLabel207.StylePriority.UseBackColor = false;
            this.xrLabel207.StylePriority.UseBorders = false;
            this.xrLabel207.StylePriority.UseFont = false;
            this.xrLabel207.Text = "Declaro que foram prestados os serviços constantes neste Documento";
            // 
            // xrLabel208
            // 
            this.xrLabel208.BackColor = System.Drawing.Color.Empty;
            this.xrLabel208.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel208.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel208.LocationFloat = new DevExpress.Utils.PointFloat(6.999969F, 15.99998F);
            this.xrLabel208.Name = "xrLabel208";
            this.xrLabel208.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel208.SizeF = new System.Drawing.SizeF(497.1665F, 14F);
            this.xrLabel208.StylePriority.UseBackColor = false;
            this.xrLabel208.StylePriority.UseBorders = false;
            this.xrLabel208.StylePriority.UseFont = false;
            this.xrLabel208.Text = "Fiscal Simplificado de Serviços de Microempreendedor Individual - MEI.";
            // 
            // xrPanel9
            // 
            this.xrPanel9.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel9.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel136,
            this.xrLabel137,
            this.xrLabel138,
            this.xrLabel139,
            this.xrLabel140,
            this.luni1_2,
            this.lqtd1_2,
            this.ldescricao1_2,
            this.lvlruni1_2,
            this.lvlrtot1_2,
            this.xrLabel146,
            this.xrLabel147,
            this.xrLabel148,
            this.xrLabel149,
            this.xrLabel150,
            this.xrLabel151,
            this.xrLabel152,
            this.xrLabel153,
            this.xrLabel154,
            this.xrLabel155,
            this.xrLabel156,
            this.xrLabel157,
            this.xrLabel158,
            this.xrLabel159,
            this.xrLabel160,
            this.xrLabel161,
            this.xrLabel162,
            this.xrLabel163,
            this.xrLabel164,
            this.xrLabel165,
            this.xrLabel166,
            this.xrLabel167,
            this.xrLabel168,
            this.xrLabel169,
            this.xrLabel170,
            this.xrLabel171,
            this.xrLabel172,
            this.xrLabel173,
            this.xrLabel174,
            this.xrLabel175,
            this.xrLabel176,
            this.xrLabel177,
            this.xrLabel178,
            this.xrLabel179,
            this.xrLabel180,
            this.xrLabel181,
            this.xrLabel182,
            this.xrLabel183,
            this.xrLabel184,
            this.xrLabel185,
            this.xrLabel186,
            this.xrLabel187,
            this.xrLabel188,
            this.xrLabel189,
            this.xrLabel190,
            this.xrLabel191,
            this.xrLabel192,
            this.xrLabel193,
            this.xrLabel194,
            this.xrLabel195,
            this.xrLabel196,
            this.xrLabel197,
            this.xrLabel198,
            this.xrLabel199,
            this.xrLabel200,
            this.xrLabel201,
            this.lvlrtotalnf1_2});
            this.xrPanel9.LocationFloat = new DevExpress.Utils.PointFloat(584.7186F, 312.5834F);
            this.xrPanel9.Name = "xrPanel9";
            this.xrPanel9.SizeF = new System.Drawing.SizeF(535.5626F, 325.9168F);
            this.xrPanel9.StylePriority.UseBorders = false;
            // 
            // xrLabel136
            // 
            this.xrLabel136.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel136.BorderColor = System.Drawing.Color.Black;
            this.xrLabel136.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel136.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel136.ForeColor = System.Drawing.Color.Black;
            this.xrLabel136.LocationFloat = new DevExpress.Utils.PointFloat(102.1252F, 5.000005F);
            this.xrLabel136.Name = "xrLabel136";
            this.xrLabel136.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel136.SizeF = new System.Drawing.SizeF(238.4585F, 21.5417F);
            this.xrLabel136.StylePriority.UseBackColor = false;
            this.xrLabel136.StylePriority.UseBorderColor = false;
            this.xrLabel136.StylePriority.UseBorders = false;
            this.xrLabel136.StylePriority.UseFont = false;
            this.xrLabel136.StylePriority.UseForeColor = false;
            this.xrLabel136.StylePriority.UseTextAlignment = false;
            this.xrLabel136.Text = "Descrição dos Serviços";
            this.xrLabel136.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel137
            // 
            this.xrLabel137.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel137.BorderColor = System.Drawing.Color.Black;
            this.xrLabel137.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel137.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel137.ForeColor = System.Drawing.Color.Black;
            this.xrLabel137.LocationFloat = new DevExpress.Utils.PointFloat(55.12516F, 5.000007F);
            this.xrLabel137.Name = "xrLabel137";
            this.xrLabel137.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel137.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel137.StylePriority.UseBackColor = false;
            this.xrLabel137.StylePriority.UseBorderColor = false;
            this.xrLabel137.StylePriority.UseBorders = false;
            this.xrLabel137.StylePriority.UseFont = false;
            this.xrLabel137.StylePriority.UseForeColor = false;
            this.xrLabel137.StylePriority.UseTextAlignment = false;
            this.xrLabel137.Text = "Unid.";
            this.xrLabel137.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel138
            // 
            this.xrLabel138.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel138.BorderColor = System.Drawing.Color.Black;
            this.xrLabel138.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel138.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel138.ForeColor = System.Drawing.Color.Black;
            this.xrLabel138.LocationFloat = new DevExpress.Utils.PointFloat(6.125151F, 5.000007F);
            this.xrLabel138.Name = "xrLabel138";
            this.xrLabel138.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel138.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel138.StylePriority.UseBackColor = false;
            this.xrLabel138.StylePriority.UseBorderColor = false;
            this.xrLabel138.StylePriority.UseBorders = false;
            this.xrLabel138.StylePriority.UseFont = false;
            this.xrLabel138.StylePriority.UseForeColor = false;
            this.xrLabel138.StylePriority.UseTextAlignment = false;
            this.xrLabel138.Text = "Qtd.";
            this.xrLabel138.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel139
            // 
            this.xrLabel139.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel139.BorderColor = System.Drawing.Color.Black;
            this.xrLabel139.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel139.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel139.ForeColor = System.Drawing.Color.Black;
            this.xrLabel139.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 5.000007F);
            this.xrLabel139.Name = "xrLabel139";
            this.xrLabel139.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel139.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel139.StylePriority.UseBackColor = false;
            this.xrLabel139.StylePriority.UseBorderColor = false;
            this.xrLabel139.StylePriority.UseBorders = false;
            this.xrLabel139.StylePriority.UseFont = false;
            this.xrLabel139.StylePriority.UseForeColor = false;
            this.xrLabel139.StylePriority.UseTextAlignment = false;
            this.xrLabel139.Text = "Vlr. Total";
            this.xrLabel139.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel140
            // 
            this.xrLabel140.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel140.BorderColor = System.Drawing.Color.Black;
            this.xrLabel140.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel140.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel140.ForeColor = System.Drawing.Color.Black;
            this.xrLabel140.LocationFloat = new DevExpress.Utils.PointFloat(341.4168F, 5.000005F);
            this.xrLabel140.Name = "xrLabel140";
            this.xrLabel140.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel140.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel140.StylePriority.UseBackColor = false;
            this.xrLabel140.StylePriority.UseBorderColor = false;
            this.xrLabel140.StylePriority.UseBorders = false;
            this.xrLabel140.StylePriority.UseFont = false;
            this.xrLabel140.StylePriority.UseForeColor = false;
            this.xrLabel140.StylePriority.UseTextAlignment = false;
            this.xrLabel140.Text = "Vlr. Unitário";
            this.xrLabel140.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // luni1_2
            // 
            this.luni1_2.BackColor = System.Drawing.Color.Transparent;
            this.luni1_2.BorderColor = System.Drawing.Color.Black;
            this.luni1_2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.luni1_2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.luni1_2.ForeColor = System.Drawing.Color.Black;
            this.luni1_2.LocationFloat = new DevExpress.Utils.PointFloat(55.1251F, 26.54169F);
            this.luni1_2.Name = "luni1_2";
            this.luni1_2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.luni1_2.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.luni1_2.StylePriority.UseBackColor = false;
            this.luni1_2.StylePriority.UseBorderColor = false;
            this.luni1_2.StylePriority.UseBorders = false;
            this.luni1_2.StylePriority.UseFont = false;
            this.luni1_2.StylePriority.UseForeColor = false;
            this.luni1_2.StylePriority.UseTextAlignment = false;
            this.luni1_2.Text = "-";
            this.luni1_2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lqtd1_2
            // 
            this.lqtd1_2.BackColor = System.Drawing.Color.Transparent;
            this.lqtd1_2.BorderColor = System.Drawing.Color.Black;
            this.lqtd1_2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lqtd1_2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lqtd1_2.ForeColor = System.Drawing.Color.Black;
            this.lqtd1_2.LocationFloat = new DevExpress.Utils.PointFloat(6.125086F, 26.54169F);
            this.lqtd1_2.Name = "lqtd1_2";
            this.lqtd1_2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lqtd1_2.SizeF = new System.Drawing.SizeF(48.54167F, 21.5417F);
            this.lqtd1_2.StylePriority.UseBackColor = false;
            this.lqtd1_2.StylePriority.UseBorderColor = false;
            this.lqtd1_2.StylePriority.UseBorders = false;
            this.lqtd1_2.StylePriority.UseFont = false;
            this.lqtd1_2.StylePriority.UseForeColor = false;
            this.lqtd1_2.StylePriority.UseTextAlignment = false;
            this.lqtd1_2.Text = "1";
            this.lqtd1_2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // ldescricao1_2
            // 
            this.ldescricao1_2.BackColor = System.Drawing.Color.Transparent;
            this.ldescricao1_2.BorderColor = System.Drawing.Color.Black;
            this.ldescricao1_2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.ldescricao1_2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.ldescricao1_2.ForeColor = System.Drawing.Color.Black;
            this.ldescricao1_2.LocationFloat = new DevExpress.Utils.PointFloat(102.1251F, 26.5417F);
            this.ldescricao1_2.Name = "ldescricao1_2";
            this.ldescricao1_2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldescricao1_2.SizeF = new System.Drawing.SizeF(238.4586F, 21.54171F);
            this.ldescricao1_2.StylePriority.UseBackColor = false;
            this.ldescricao1_2.StylePriority.UseBorderColor = false;
            this.ldescricao1_2.StylePriority.UseBorders = false;
            this.ldescricao1_2.StylePriority.UseFont = false;
            this.ldescricao1_2.StylePriority.UseForeColor = false;
            this.ldescricao1_2.StylePriority.UseTextAlignment = false;
            this.ldescricao1_2.Text = "Manutenção de Equipamentos";
            this.ldescricao1_2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lvlruni1_2
            // 
            this.lvlruni1_2.BackColor = System.Drawing.Color.Transparent;
            this.lvlruni1_2.BorderColor = System.Drawing.Color.Black;
            this.lvlruni1_2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lvlruni1_2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lvlruni1_2.ForeColor = System.Drawing.Color.Black;
            this.lvlruni1_2.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 26.5417F);
            this.lvlruni1_2.Name = "lvlruni1_2";
            this.lvlruni1_2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlruni1_2.SizeF = new System.Drawing.SizeF(88.37491F, 21.54171F);
            this.lvlruni1_2.StylePriority.UseBackColor = false;
            this.lvlruni1_2.StylePriority.UseBorderColor = false;
            this.lvlruni1_2.StylePriority.UseBorders = false;
            this.lvlruni1_2.StylePriority.UseFont = false;
            this.lvlruni1_2.StylePriority.UseForeColor = false;
            this.lvlruni1_2.StylePriority.UseTextAlignment = false;
            this.lvlruni1_2.Text = "0,00";
            this.lvlruni1_2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lvlrtot1_2
            // 
            this.lvlrtot1_2.BackColor = System.Drawing.Color.Transparent;
            this.lvlrtot1_2.BorderColor = System.Drawing.Color.Black;
            this.lvlrtot1_2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lvlrtot1_2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lvlrtot1_2.ForeColor = System.Drawing.Color.Black;
            this.lvlrtot1_2.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 26.54169F);
            this.lvlrtot1_2.Name = "lvlrtot1_2";
            this.lvlrtot1_2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrtot1_2.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.lvlrtot1_2.StylePriority.UseBackColor = false;
            this.lvlrtot1_2.StylePriority.UseBorderColor = false;
            this.lvlrtot1_2.StylePriority.UseBorders = false;
            this.lvlrtot1_2.StylePriority.UseFont = false;
            this.lvlrtot1_2.StylePriority.UseForeColor = false;
            this.lvlrtot1_2.StylePriority.UseTextAlignment = false;
            this.lvlrtot1_2.Text = "0,00";
            this.lvlrtot1_2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel146
            // 
            this.xrLabel146.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel146.BorderColor = System.Drawing.Color.Black;
            this.xrLabel146.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel146.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel146.ForeColor = System.Drawing.Color.Black;
            this.xrLabel146.LocationFloat = new DevExpress.Utils.PointFloat(6.125055F, 48.08339F);
            this.xrLabel146.Name = "xrLabel146";
            this.xrLabel146.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel146.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel146.StylePriority.UseBackColor = false;
            this.xrLabel146.StylePriority.UseBorderColor = false;
            this.xrLabel146.StylePriority.UseBorders = false;
            this.xrLabel146.StylePriority.UseFont = false;
            this.xrLabel146.StylePriority.UseForeColor = false;
            this.xrLabel146.StylePriority.UseTextAlignment = false;
            this.xrLabel146.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel147
            // 
            this.xrLabel147.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel147.BorderColor = System.Drawing.Color.Black;
            this.xrLabel147.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel147.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel147.ForeColor = System.Drawing.Color.Black;
            this.xrLabel147.LocationFloat = new DevExpress.Utils.PointFloat(55.12507F, 48.08339F);
            this.xrLabel147.Name = "xrLabel147";
            this.xrLabel147.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel147.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel147.StylePriority.UseBackColor = false;
            this.xrLabel147.StylePriority.UseBorderColor = false;
            this.xrLabel147.StylePriority.UseBorders = false;
            this.xrLabel147.StylePriority.UseFont = false;
            this.xrLabel147.StylePriority.UseForeColor = false;
            this.xrLabel147.StylePriority.UseTextAlignment = false;
            this.xrLabel147.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel148
            // 
            this.xrLabel148.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel148.BorderColor = System.Drawing.Color.Black;
            this.xrLabel148.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel148.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel148.ForeColor = System.Drawing.Color.Black;
            this.xrLabel148.LocationFloat = new DevExpress.Utils.PointFloat(102.1251F, 48.08339F);
            this.xrLabel148.Name = "xrLabel148";
            this.xrLabel148.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel148.SizeF = new System.Drawing.SizeF(238.4586F, 21.54171F);
            this.xrLabel148.StylePriority.UseBackColor = false;
            this.xrLabel148.StylePriority.UseBorderColor = false;
            this.xrLabel148.StylePriority.UseBorders = false;
            this.xrLabel148.StylePriority.UseFont = false;
            this.xrLabel148.StylePriority.UseForeColor = false;
            this.xrLabel148.StylePriority.UseTextAlignment = false;
            this.xrLabel148.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel149
            // 
            this.xrLabel149.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel149.BorderColor = System.Drawing.Color.Black;
            this.xrLabel149.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel149.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel149.ForeColor = System.Drawing.Color.Black;
            this.xrLabel149.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 48.08339F);
            this.xrLabel149.Name = "xrLabel149";
            this.xrLabel149.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel149.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel149.StylePriority.UseBackColor = false;
            this.xrLabel149.StylePriority.UseBorderColor = false;
            this.xrLabel149.StylePriority.UseBorders = false;
            this.xrLabel149.StylePriority.UseFont = false;
            this.xrLabel149.StylePriority.UseForeColor = false;
            this.xrLabel149.StylePriority.UseTextAlignment = false;
            this.xrLabel149.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel150
            // 
            this.xrLabel150.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel150.BorderColor = System.Drawing.Color.Black;
            this.xrLabel150.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel150.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel150.ForeColor = System.Drawing.Color.Black;
            this.xrLabel150.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 48.08339F);
            this.xrLabel150.Name = "xrLabel150";
            this.xrLabel150.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel150.SizeF = new System.Drawing.SizeF(88.37491F, 21.54171F);
            this.xrLabel150.StylePriority.UseBackColor = false;
            this.xrLabel150.StylePriority.UseBorderColor = false;
            this.xrLabel150.StylePriority.UseBorders = false;
            this.xrLabel150.StylePriority.UseFont = false;
            this.xrLabel150.StylePriority.UseForeColor = false;
            this.xrLabel150.StylePriority.UseTextAlignment = false;
            this.xrLabel150.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel151
            // 
            this.xrLabel151.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel151.BorderColor = System.Drawing.Color.Black;
            this.xrLabel151.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel151.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel151.ForeColor = System.Drawing.Color.Black;
            this.xrLabel151.LocationFloat = new DevExpress.Utils.PointFloat(6.125086F, 70.62508F);
            this.xrLabel151.Name = "xrLabel151";
            this.xrLabel151.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel151.SizeF = new System.Drawing.SizeF(48.54167F, 21.5417F);
            this.xrLabel151.StylePriority.UseBackColor = false;
            this.xrLabel151.StylePriority.UseBorderColor = false;
            this.xrLabel151.StylePriority.UseBorders = false;
            this.xrLabel151.StylePriority.UseFont = false;
            this.xrLabel151.StylePriority.UseForeColor = false;
            this.xrLabel151.StylePriority.UseTextAlignment = false;
            this.xrLabel151.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel152
            // 
            this.xrLabel152.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel152.BorderColor = System.Drawing.Color.Black;
            this.xrLabel152.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel152.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel152.ForeColor = System.Drawing.Color.Black;
            this.xrLabel152.LocationFloat = new DevExpress.Utils.PointFloat(55.1251F, 70.62508F);
            this.xrLabel152.Name = "xrLabel152";
            this.xrLabel152.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel152.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel152.StylePriority.UseBackColor = false;
            this.xrLabel152.StylePriority.UseBorderColor = false;
            this.xrLabel152.StylePriority.UseBorders = false;
            this.xrLabel152.StylePriority.UseFont = false;
            this.xrLabel152.StylePriority.UseForeColor = false;
            this.xrLabel152.StylePriority.UseTextAlignment = false;
            this.xrLabel152.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel153
            // 
            this.xrLabel153.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel153.BorderColor = System.Drawing.Color.Black;
            this.xrLabel153.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel153.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel153.ForeColor = System.Drawing.Color.Black;
            this.xrLabel153.LocationFloat = new DevExpress.Utils.PointFloat(102.1252F, 70.62508F);
            this.xrLabel153.Name = "xrLabel153";
            this.xrLabel153.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel153.SizeF = new System.Drawing.SizeF(238.4585F, 21.5417F);
            this.xrLabel153.StylePriority.UseBackColor = false;
            this.xrLabel153.StylePriority.UseBorderColor = false;
            this.xrLabel153.StylePriority.UseBorders = false;
            this.xrLabel153.StylePriority.UseFont = false;
            this.xrLabel153.StylePriority.UseForeColor = false;
            this.xrLabel153.StylePriority.UseTextAlignment = false;
            this.xrLabel153.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel154
            // 
            this.xrLabel154.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel154.BorderColor = System.Drawing.Color.Black;
            this.xrLabel154.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel154.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel154.ForeColor = System.Drawing.Color.Black;
            this.xrLabel154.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 70.62508F);
            this.xrLabel154.Name = "xrLabel154";
            this.xrLabel154.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel154.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel154.StylePriority.UseBackColor = false;
            this.xrLabel154.StylePriority.UseBorderColor = false;
            this.xrLabel154.StylePriority.UseBorders = false;
            this.xrLabel154.StylePriority.UseFont = false;
            this.xrLabel154.StylePriority.UseForeColor = false;
            this.xrLabel154.StylePriority.UseTextAlignment = false;
            this.xrLabel154.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel155
            // 
            this.xrLabel155.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel155.BorderColor = System.Drawing.Color.Black;
            this.xrLabel155.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel155.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel155.ForeColor = System.Drawing.Color.Black;
            this.xrLabel155.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 70.62508F);
            this.xrLabel155.Name = "xrLabel155";
            this.xrLabel155.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel155.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel155.StylePriority.UseBackColor = false;
            this.xrLabel155.StylePriority.UseBorderColor = false;
            this.xrLabel155.StylePriority.UseBorders = false;
            this.xrLabel155.StylePriority.UseFont = false;
            this.xrLabel155.StylePriority.UseForeColor = false;
            this.xrLabel155.StylePriority.UseTextAlignment = false;
            this.xrLabel155.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel156
            // 
            this.xrLabel156.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel156.BorderColor = System.Drawing.Color.Black;
            this.xrLabel156.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel156.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel156.ForeColor = System.Drawing.Color.Black;
            this.xrLabel156.LocationFloat = new DevExpress.Utils.PointFloat(6.125055F, 92.16677F);
            this.xrLabel156.Name = "xrLabel156";
            this.xrLabel156.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel156.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel156.StylePriority.UseBackColor = false;
            this.xrLabel156.StylePriority.UseBorderColor = false;
            this.xrLabel156.StylePriority.UseBorders = false;
            this.xrLabel156.StylePriority.UseFont = false;
            this.xrLabel156.StylePriority.UseForeColor = false;
            this.xrLabel156.StylePriority.UseTextAlignment = false;
            this.xrLabel156.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel157
            // 
            this.xrLabel157.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel157.BorderColor = System.Drawing.Color.Black;
            this.xrLabel157.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel157.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel157.ForeColor = System.Drawing.Color.Black;
            this.xrLabel157.LocationFloat = new DevExpress.Utils.PointFloat(55.12507F, 92.16677F);
            this.xrLabel157.Name = "xrLabel157";
            this.xrLabel157.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel157.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel157.StylePriority.UseBackColor = false;
            this.xrLabel157.StylePriority.UseBorderColor = false;
            this.xrLabel157.StylePriority.UseBorders = false;
            this.xrLabel157.StylePriority.UseFont = false;
            this.xrLabel157.StylePriority.UseForeColor = false;
            this.xrLabel157.StylePriority.UseTextAlignment = false;
            this.xrLabel157.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel158
            // 
            this.xrLabel158.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel158.BorderColor = System.Drawing.Color.Black;
            this.xrLabel158.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel158.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel158.ForeColor = System.Drawing.Color.Black;
            this.xrLabel158.LocationFloat = new DevExpress.Utils.PointFloat(102.1251F, 92.16677F);
            this.xrLabel158.Name = "xrLabel158";
            this.xrLabel158.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel158.SizeF = new System.Drawing.SizeF(238.4586F, 21.5417F);
            this.xrLabel158.StylePriority.UseBackColor = false;
            this.xrLabel158.StylePriority.UseBorderColor = false;
            this.xrLabel158.StylePriority.UseBorders = false;
            this.xrLabel158.StylePriority.UseFont = false;
            this.xrLabel158.StylePriority.UseForeColor = false;
            this.xrLabel158.StylePriority.UseTextAlignment = false;
            this.xrLabel158.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel159
            // 
            this.xrLabel159.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel159.BorderColor = System.Drawing.Color.Black;
            this.xrLabel159.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel159.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel159.ForeColor = System.Drawing.Color.Black;
            this.xrLabel159.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 92.16677F);
            this.xrLabel159.Name = "xrLabel159";
            this.xrLabel159.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel159.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel159.StylePriority.UseBackColor = false;
            this.xrLabel159.StylePriority.UseBorderColor = false;
            this.xrLabel159.StylePriority.UseBorders = false;
            this.xrLabel159.StylePriority.UseFont = false;
            this.xrLabel159.StylePriority.UseForeColor = false;
            this.xrLabel159.StylePriority.UseTextAlignment = false;
            this.xrLabel159.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel160
            // 
            this.xrLabel160.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel160.BorderColor = System.Drawing.Color.Black;
            this.xrLabel160.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel160.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel160.ForeColor = System.Drawing.Color.Black;
            this.xrLabel160.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 92.16677F);
            this.xrLabel160.Name = "xrLabel160";
            this.xrLabel160.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel160.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel160.StylePriority.UseBackColor = false;
            this.xrLabel160.StylePriority.UseBorderColor = false;
            this.xrLabel160.StylePriority.UseBorders = false;
            this.xrLabel160.StylePriority.UseFont = false;
            this.xrLabel160.StylePriority.UseForeColor = false;
            this.xrLabel160.StylePriority.UseTextAlignment = false;
            this.xrLabel160.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel161
            // 
            this.xrLabel161.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel161.BorderColor = System.Drawing.Color.Black;
            this.xrLabel161.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel161.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel161.ForeColor = System.Drawing.Color.Black;
            this.xrLabel161.LocationFloat = new DevExpress.Utils.PointFloat(55.12507F, 135.8333F);
            this.xrLabel161.Name = "xrLabel161";
            this.xrLabel161.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel161.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel161.StylePriority.UseBackColor = false;
            this.xrLabel161.StylePriority.UseBorderColor = false;
            this.xrLabel161.StylePriority.UseBorders = false;
            this.xrLabel161.StylePriority.UseFont = false;
            this.xrLabel161.StylePriority.UseForeColor = false;
            this.xrLabel161.StylePriority.UseTextAlignment = false;
            this.xrLabel161.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel162
            // 
            this.xrLabel162.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel162.BorderColor = System.Drawing.Color.Black;
            this.xrLabel162.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel162.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel162.ForeColor = System.Drawing.Color.Black;
            this.xrLabel162.LocationFloat = new DevExpress.Utils.PointFloat(6.125055F, 135.8333F);
            this.xrLabel162.Name = "xrLabel162";
            this.xrLabel162.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel162.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel162.StylePriority.UseBackColor = false;
            this.xrLabel162.StylePriority.UseBorderColor = false;
            this.xrLabel162.StylePriority.UseBorders = false;
            this.xrLabel162.StylePriority.UseFont = false;
            this.xrLabel162.StylePriority.UseForeColor = false;
            this.xrLabel162.StylePriority.UseTextAlignment = false;
            this.xrLabel162.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel163
            // 
            this.xrLabel163.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel163.BorderColor = System.Drawing.Color.Black;
            this.xrLabel163.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel163.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel163.ForeColor = System.Drawing.Color.Black;
            this.xrLabel163.LocationFloat = new DevExpress.Utils.PointFloat(102.1252F, 135.8333F);
            this.xrLabel163.Name = "xrLabel163";
            this.xrLabel163.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel163.SizeF = new System.Drawing.SizeF(238.4585F, 21.54173F);
            this.xrLabel163.StylePriority.UseBackColor = false;
            this.xrLabel163.StylePriority.UseBorderColor = false;
            this.xrLabel163.StylePriority.UseBorders = false;
            this.xrLabel163.StylePriority.UseFont = false;
            this.xrLabel163.StylePriority.UseForeColor = false;
            this.xrLabel163.StylePriority.UseTextAlignment = false;
            this.xrLabel163.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel164
            // 
            this.xrLabel164.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel164.BorderColor = System.Drawing.Color.Black;
            this.xrLabel164.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel164.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel164.ForeColor = System.Drawing.Color.Black;
            this.xrLabel164.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 135.8333F);
            this.xrLabel164.Name = "xrLabel164";
            this.xrLabel164.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel164.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel164.StylePriority.UseBackColor = false;
            this.xrLabel164.StylePriority.UseBorderColor = false;
            this.xrLabel164.StylePriority.UseBorders = false;
            this.xrLabel164.StylePriority.UseFont = false;
            this.xrLabel164.StylePriority.UseForeColor = false;
            this.xrLabel164.StylePriority.UseTextAlignment = false;
            this.xrLabel164.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel165
            // 
            this.xrLabel165.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel165.BorderColor = System.Drawing.Color.Black;
            this.xrLabel165.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel165.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel165.ForeColor = System.Drawing.Color.Black;
            this.xrLabel165.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 135.8333F);
            this.xrLabel165.Name = "xrLabel165";
            this.xrLabel165.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel165.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel165.StylePriority.UseBackColor = false;
            this.xrLabel165.StylePriority.UseBorderColor = false;
            this.xrLabel165.StylePriority.UseBorders = false;
            this.xrLabel165.StylePriority.UseFont = false;
            this.xrLabel165.StylePriority.UseForeColor = false;
            this.xrLabel165.StylePriority.UseTextAlignment = false;
            this.xrLabel165.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel166
            // 
            this.xrLabel166.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel166.BorderColor = System.Drawing.Color.Black;
            this.xrLabel166.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel166.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel166.ForeColor = System.Drawing.Color.Black;
            this.xrLabel166.LocationFloat = new DevExpress.Utils.PointFloat(6.125086F, 114.2916F);
            this.xrLabel166.Name = "xrLabel166";
            this.xrLabel166.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel166.SizeF = new System.Drawing.SizeF(48.54167F, 21.54171F);
            this.xrLabel166.StylePriority.UseBackColor = false;
            this.xrLabel166.StylePriority.UseBorderColor = false;
            this.xrLabel166.StylePriority.UseBorders = false;
            this.xrLabel166.StylePriority.UseFont = false;
            this.xrLabel166.StylePriority.UseForeColor = false;
            this.xrLabel166.StylePriority.UseTextAlignment = false;
            this.xrLabel166.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel167
            // 
            this.xrLabel167.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel167.BorderColor = System.Drawing.Color.Black;
            this.xrLabel167.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel167.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel167.ForeColor = System.Drawing.Color.Black;
            this.xrLabel167.LocationFloat = new DevExpress.Utils.PointFloat(55.1251F, 114.2916F);
            this.xrLabel167.Name = "xrLabel167";
            this.xrLabel167.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel167.SizeF = new System.Drawing.SizeF(46.45834F, 21.54171F);
            this.xrLabel167.StylePriority.UseBackColor = false;
            this.xrLabel167.StylePriority.UseBorderColor = false;
            this.xrLabel167.StylePriority.UseBorders = false;
            this.xrLabel167.StylePriority.UseFont = false;
            this.xrLabel167.StylePriority.UseForeColor = false;
            this.xrLabel167.StylePriority.UseTextAlignment = false;
            this.xrLabel167.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel168
            // 
            this.xrLabel168.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel168.BorderColor = System.Drawing.Color.Black;
            this.xrLabel168.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel168.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel168.ForeColor = System.Drawing.Color.Black;
            this.xrLabel168.LocationFloat = new DevExpress.Utils.PointFloat(102.1252F, 114.2916F);
            this.xrLabel168.Name = "xrLabel168";
            this.xrLabel168.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel168.SizeF = new System.Drawing.SizeF(238.4585F, 21.54169F);
            this.xrLabel168.StylePriority.UseBackColor = false;
            this.xrLabel168.StylePriority.UseBorderColor = false;
            this.xrLabel168.StylePriority.UseBorders = false;
            this.xrLabel168.StylePriority.UseFont = false;
            this.xrLabel168.StylePriority.UseForeColor = false;
            this.xrLabel168.StylePriority.UseTextAlignment = false;
            this.xrLabel168.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel169
            // 
            this.xrLabel169.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel169.BorderColor = System.Drawing.Color.Black;
            this.xrLabel169.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel169.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel169.ForeColor = System.Drawing.Color.Black;
            this.xrLabel169.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 114.2916F);
            this.xrLabel169.Name = "xrLabel169";
            this.xrLabel169.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel169.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel169.StylePriority.UseBackColor = false;
            this.xrLabel169.StylePriority.UseBorderColor = false;
            this.xrLabel169.StylePriority.UseBorders = false;
            this.xrLabel169.StylePriority.UseFont = false;
            this.xrLabel169.StylePriority.UseForeColor = false;
            this.xrLabel169.StylePriority.UseTextAlignment = false;
            this.xrLabel169.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel170
            // 
            this.xrLabel170.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel170.BorderColor = System.Drawing.Color.Black;
            this.xrLabel170.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel170.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel170.ForeColor = System.Drawing.Color.Black;
            this.xrLabel170.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 114.2916F);
            this.xrLabel170.Name = "xrLabel170";
            this.xrLabel170.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel170.SizeF = new System.Drawing.SizeF(88.37491F, 21.54171F);
            this.xrLabel170.StylePriority.UseBackColor = false;
            this.xrLabel170.StylePriority.UseBorderColor = false;
            this.xrLabel170.StylePriority.UseBorders = false;
            this.xrLabel170.StylePriority.UseFont = false;
            this.xrLabel170.StylePriority.UseForeColor = false;
            this.xrLabel170.StylePriority.UseTextAlignment = false;
            this.xrLabel170.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel171
            // 
            this.xrLabel171.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel171.BorderColor = System.Drawing.Color.Black;
            this.xrLabel171.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel171.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel171.ForeColor = System.Drawing.Color.Black;
            this.xrLabel171.LocationFloat = new DevExpress.Utils.PointFloat(55.12507F, 178.9167F);
            this.xrLabel171.Name = "xrLabel171";
            this.xrLabel171.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel171.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel171.StylePriority.UseBackColor = false;
            this.xrLabel171.StylePriority.UseBorderColor = false;
            this.xrLabel171.StylePriority.UseBorders = false;
            this.xrLabel171.StylePriority.UseFont = false;
            this.xrLabel171.StylePriority.UseForeColor = false;
            this.xrLabel171.StylePriority.UseTextAlignment = false;
            this.xrLabel171.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel172
            // 
            this.xrLabel172.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel172.BorderColor = System.Drawing.Color.Black;
            this.xrLabel172.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel172.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel172.ForeColor = System.Drawing.Color.Black;
            this.xrLabel172.LocationFloat = new DevExpress.Utils.PointFloat(6.125055F, 178.9167F);
            this.xrLabel172.Name = "xrLabel172";
            this.xrLabel172.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel172.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel172.StylePriority.UseBackColor = false;
            this.xrLabel172.StylePriority.UseBorderColor = false;
            this.xrLabel172.StylePriority.UseBorders = false;
            this.xrLabel172.StylePriority.UseFont = false;
            this.xrLabel172.StylePriority.UseForeColor = false;
            this.xrLabel172.StylePriority.UseTextAlignment = false;
            this.xrLabel172.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel173
            // 
            this.xrLabel173.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel173.BorderColor = System.Drawing.Color.Black;
            this.xrLabel173.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel173.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel173.ForeColor = System.Drawing.Color.Black;
            this.xrLabel173.LocationFloat = new DevExpress.Utils.PointFloat(102.1252F, 178.9167F);
            this.xrLabel173.Name = "xrLabel173";
            this.xrLabel173.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel173.SizeF = new System.Drawing.SizeF(238.4585F, 21.5417F);
            this.xrLabel173.StylePriority.UseBackColor = false;
            this.xrLabel173.StylePriority.UseBorderColor = false;
            this.xrLabel173.StylePriority.UseBorders = false;
            this.xrLabel173.StylePriority.UseFont = false;
            this.xrLabel173.StylePriority.UseForeColor = false;
            this.xrLabel173.StylePriority.UseTextAlignment = false;
            this.xrLabel173.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel174
            // 
            this.xrLabel174.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel174.BorderColor = System.Drawing.Color.Black;
            this.xrLabel174.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel174.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel174.ForeColor = System.Drawing.Color.Black;
            this.xrLabel174.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 178.9167F);
            this.xrLabel174.Name = "xrLabel174";
            this.xrLabel174.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel174.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel174.StylePriority.UseBackColor = false;
            this.xrLabel174.StylePriority.UseBorderColor = false;
            this.xrLabel174.StylePriority.UseBorders = false;
            this.xrLabel174.StylePriority.UseFont = false;
            this.xrLabel174.StylePriority.UseForeColor = false;
            this.xrLabel174.StylePriority.UseTextAlignment = false;
            this.xrLabel174.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel175
            // 
            this.xrLabel175.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel175.BorderColor = System.Drawing.Color.Black;
            this.xrLabel175.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel175.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel175.ForeColor = System.Drawing.Color.Black;
            this.xrLabel175.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 178.9167F);
            this.xrLabel175.Name = "xrLabel175";
            this.xrLabel175.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel175.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel175.StylePriority.UseBackColor = false;
            this.xrLabel175.StylePriority.UseBorderColor = false;
            this.xrLabel175.StylePriority.UseBorders = false;
            this.xrLabel175.StylePriority.UseFont = false;
            this.xrLabel175.StylePriority.UseForeColor = false;
            this.xrLabel175.StylePriority.UseTextAlignment = false;
            this.xrLabel175.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel176
            // 
            this.xrLabel176.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel176.BorderColor = System.Drawing.Color.Black;
            this.xrLabel176.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel176.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel176.ForeColor = System.Drawing.Color.Black;
            this.xrLabel176.LocationFloat = new DevExpress.Utils.PointFloat(55.1251F, 157.375F);
            this.xrLabel176.Name = "xrLabel176";
            this.xrLabel176.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel176.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel176.StylePriority.UseBackColor = false;
            this.xrLabel176.StylePriority.UseBorderColor = false;
            this.xrLabel176.StylePriority.UseBorders = false;
            this.xrLabel176.StylePriority.UseFont = false;
            this.xrLabel176.StylePriority.UseForeColor = false;
            this.xrLabel176.StylePriority.UseTextAlignment = false;
            this.xrLabel176.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel177
            // 
            this.xrLabel177.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel177.BorderColor = System.Drawing.Color.Black;
            this.xrLabel177.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel177.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel177.ForeColor = System.Drawing.Color.Black;
            this.xrLabel177.LocationFloat = new DevExpress.Utils.PointFloat(6.125086F, 157.375F);
            this.xrLabel177.Name = "xrLabel177";
            this.xrLabel177.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel177.SizeF = new System.Drawing.SizeF(48.54167F, 21.5417F);
            this.xrLabel177.StylePriority.UseBackColor = false;
            this.xrLabel177.StylePriority.UseBorderColor = false;
            this.xrLabel177.StylePriority.UseBorders = false;
            this.xrLabel177.StylePriority.UseFont = false;
            this.xrLabel177.StylePriority.UseForeColor = false;
            this.xrLabel177.StylePriority.UseTextAlignment = false;
            this.xrLabel177.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel178
            // 
            this.xrLabel178.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel178.BorderColor = System.Drawing.Color.Black;
            this.xrLabel178.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel178.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel178.ForeColor = System.Drawing.Color.Black;
            this.xrLabel178.LocationFloat = new DevExpress.Utils.PointFloat(102.1252F, 157.375F);
            this.xrLabel178.Name = "xrLabel178";
            this.xrLabel178.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel178.SizeF = new System.Drawing.SizeF(238.4585F, 21.5417F);
            this.xrLabel178.StylePriority.UseBackColor = false;
            this.xrLabel178.StylePriority.UseBorderColor = false;
            this.xrLabel178.StylePriority.UseBorders = false;
            this.xrLabel178.StylePriority.UseFont = false;
            this.xrLabel178.StylePriority.UseForeColor = false;
            this.xrLabel178.StylePriority.UseTextAlignment = false;
            this.xrLabel178.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel179
            // 
            this.xrLabel179.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel179.BorderColor = System.Drawing.Color.Black;
            this.xrLabel179.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel179.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel179.ForeColor = System.Drawing.Color.Black;
            this.xrLabel179.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 157.375F);
            this.xrLabel179.Name = "xrLabel179";
            this.xrLabel179.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel179.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel179.StylePriority.UseBackColor = false;
            this.xrLabel179.StylePriority.UseBorderColor = false;
            this.xrLabel179.StylePriority.UseBorders = false;
            this.xrLabel179.StylePriority.UseFont = false;
            this.xrLabel179.StylePriority.UseForeColor = false;
            this.xrLabel179.StylePriority.UseTextAlignment = false;
            this.xrLabel179.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel180
            // 
            this.xrLabel180.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel180.BorderColor = System.Drawing.Color.Black;
            this.xrLabel180.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel180.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel180.ForeColor = System.Drawing.Color.Black;
            this.xrLabel180.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 157.375F);
            this.xrLabel180.Name = "xrLabel180";
            this.xrLabel180.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel180.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel180.StylePriority.UseBackColor = false;
            this.xrLabel180.StylePriority.UseBorderColor = false;
            this.xrLabel180.StylePriority.UseBorders = false;
            this.xrLabel180.StylePriority.UseFont = false;
            this.xrLabel180.StylePriority.UseForeColor = false;
            this.xrLabel180.StylePriority.UseTextAlignment = false;
            this.xrLabel180.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel181
            // 
            this.xrLabel181.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel181.BorderColor = System.Drawing.Color.Black;
            this.xrLabel181.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel181.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel181.ForeColor = System.Drawing.Color.Black;
            this.xrLabel181.LocationFloat = new DevExpress.Utils.PointFloat(55.12504F, 222.3749F);
            this.xrLabel181.Name = "xrLabel181";
            this.xrLabel181.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel181.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel181.StylePriority.UseBackColor = false;
            this.xrLabel181.StylePriority.UseBorderColor = false;
            this.xrLabel181.StylePriority.UseBorders = false;
            this.xrLabel181.StylePriority.UseFont = false;
            this.xrLabel181.StylePriority.UseForeColor = false;
            this.xrLabel181.StylePriority.UseTextAlignment = false;
            this.xrLabel181.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel182
            // 
            this.xrLabel182.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel182.BorderColor = System.Drawing.Color.Black;
            this.xrLabel182.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel182.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel182.ForeColor = System.Drawing.Color.Black;
            this.xrLabel182.LocationFloat = new DevExpress.Utils.PointFloat(6.125023F, 222.3749F);
            this.xrLabel182.Name = "xrLabel182";
            this.xrLabel182.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel182.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel182.StylePriority.UseBackColor = false;
            this.xrLabel182.StylePriority.UseBorderColor = false;
            this.xrLabel182.StylePriority.UseBorders = false;
            this.xrLabel182.StylePriority.UseFont = false;
            this.xrLabel182.StylePriority.UseForeColor = false;
            this.xrLabel182.StylePriority.UseTextAlignment = false;
            this.xrLabel182.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel183
            // 
            this.xrLabel183.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel183.BorderColor = System.Drawing.Color.Black;
            this.xrLabel183.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel183.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel183.ForeColor = System.Drawing.Color.Black;
            this.xrLabel183.LocationFloat = new DevExpress.Utils.PointFloat(102.1251F, 222.375F);
            this.xrLabel183.Name = "xrLabel183";
            this.xrLabel183.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel183.SizeF = new System.Drawing.SizeF(238.4586F, 21.5417F);
            this.xrLabel183.StylePriority.UseBackColor = false;
            this.xrLabel183.StylePriority.UseBorderColor = false;
            this.xrLabel183.StylePriority.UseBorders = false;
            this.xrLabel183.StylePriority.UseFont = false;
            this.xrLabel183.StylePriority.UseForeColor = false;
            this.xrLabel183.StylePriority.UseTextAlignment = false;
            this.xrLabel183.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel184
            // 
            this.xrLabel184.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel184.BorderColor = System.Drawing.Color.Black;
            this.xrLabel184.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel184.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel184.ForeColor = System.Drawing.Color.Black;
            this.xrLabel184.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 222.375F);
            this.xrLabel184.Name = "xrLabel184";
            this.xrLabel184.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel184.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel184.StylePriority.UseBackColor = false;
            this.xrLabel184.StylePriority.UseBorderColor = false;
            this.xrLabel184.StylePriority.UseBorders = false;
            this.xrLabel184.StylePriority.UseFont = false;
            this.xrLabel184.StylePriority.UseForeColor = false;
            this.xrLabel184.StylePriority.UseTextAlignment = false;
            this.xrLabel184.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel185
            // 
            this.xrLabel185.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel185.BorderColor = System.Drawing.Color.Black;
            this.xrLabel185.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel185.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel185.ForeColor = System.Drawing.Color.Black;
            this.xrLabel185.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 222.3749F);
            this.xrLabel185.Name = "xrLabel185";
            this.xrLabel185.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel185.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel185.StylePriority.UseBackColor = false;
            this.xrLabel185.StylePriority.UseBorderColor = false;
            this.xrLabel185.StylePriority.UseBorders = false;
            this.xrLabel185.StylePriority.UseFont = false;
            this.xrLabel185.StylePriority.UseForeColor = false;
            this.xrLabel185.StylePriority.UseTextAlignment = false;
            this.xrLabel185.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel186
            // 
            this.xrLabel186.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel186.BorderColor = System.Drawing.Color.Black;
            this.xrLabel186.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel186.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel186.ForeColor = System.Drawing.Color.Black;
            this.xrLabel186.LocationFloat = new DevExpress.Utils.PointFloat(6.125055F, 200.8333F);
            this.xrLabel186.Name = "xrLabel186";
            this.xrLabel186.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel186.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel186.StylePriority.UseBackColor = false;
            this.xrLabel186.StylePriority.UseBorderColor = false;
            this.xrLabel186.StylePriority.UseBorders = false;
            this.xrLabel186.StylePriority.UseFont = false;
            this.xrLabel186.StylePriority.UseForeColor = false;
            this.xrLabel186.StylePriority.UseTextAlignment = false;
            this.xrLabel186.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel187
            // 
            this.xrLabel187.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel187.BorderColor = System.Drawing.Color.Black;
            this.xrLabel187.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel187.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel187.ForeColor = System.Drawing.Color.Black;
            this.xrLabel187.LocationFloat = new DevExpress.Utils.PointFloat(55.12507F, 200.8333F);
            this.xrLabel187.Name = "xrLabel187";
            this.xrLabel187.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel187.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel187.StylePriority.UseBackColor = false;
            this.xrLabel187.StylePriority.UseBorderColor = false;
            this.xrLabel187.StylePriority.UseBorders = false;
            this.xrLabel187.StylePriority.UseFont = false;
            this.xrLabel187.StylePriority.UseForeColor = false;
            this.xrLabel187.StylePriority.UseTextAlignment = false;
            this.xrLabel187.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel188
            // 
            this.xrLabel188.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel188.BorderColor = System.Drawing.Color.Black;
            this.xrLabel188.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel188.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel188.ForeColor = System.Drawing.Color.Black;
            this.xrLabel188.LocationFloat = new DevExpress.Utils.PointFloat(102.1251F, 200.8333F);
            this.xrLabel188.Name = "xrLabel188";
            this.xrLabel188.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel188.SizeF = new System.Drawing.SizeF(238.4586F, 21.5417F);
            this.xrLabel188.StylePriority.UseBackColor = false;
            this.xrLabel188.StylePriority.UseBorderColor = false;
            this.xrLabel188.StylePriority.UseBorders = false;
            this.xrLabel188.StylePriority.UseFont = false;
            this.xrLabel188.StylePriority.UseForeColor = false;
            this.xrLabel188.StylePriority.UseTextAlignment = false;
            this.xrLabel188.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel189
            // 
            this.xrLabel189.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel189.BorderColor = System.Drawing.Color.Black;
            this.xrLabel189.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel189.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel189.ForeColor = System.Drawing.Color.Black;
            this.xrLabel189.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 200.8333F);
            this.xrLabel189.Name = "xrLabel189";
            this.xrLabel189.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel189.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel189.StylePriority.UseBackColor = false;
            this.xrLabel189.StylePriority.UseBorderColor = false;
            this.xrLabel189.StylePriority.UseBorders = false;
            this.xrLabel189.StylePriority.UseFont = false;
            this.xrLabel189.StylePriority.UseForeColor = false;
            this.xrLabel189.StylePriority.UseTextAlignment = false;
            this.xrLabel189.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel190
            // 
            this.xrLabel190.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel190.BorderColor = System.Drawing.Color.Black;
            this.xrLabel190.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel190.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel190.ForeColor = System.Drawing.Color.Black;
            this.xrLabel190.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 200.8333F);
            this.xrLabel190.Name = "xrLabel190";
            this.xrLabel190.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel190.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel190.StylePriority.UseBackColor = false;
            this.xrLabel190.StylePriority.UseBorderColor = false;
            this.xrLabel190.StylePriority.UseBorders = false;
            this.xrLabel190.StylePriority.UseFont = false;
            this.xrLabel190.StylePriority.UseForeColor = false;
            this.xrLabel190.StylePriority.UseTextAlignment = false;
            this.xrLabel190.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel191
            // 
            this.xrLabel191.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel191.BorderColor = System.Drawing.Color.Black;
            this.xrLabel191.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel191.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel191.ForeColor = System.Drawing.Color.Black;
            this.xrLabel191.LocationFloat = new DevExpress.Utils.PointFloat(55.12504F, 265.4584F);
            this.xrLabel191.Name = "xrLabel191";
            this.xrLabel191.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel191.SizeF = new System.Drawing.SizeF(46.45834F, 21.54169F);
            this.xrLabel191.StylePriority.UseBackColor = false;
            this.xrLabel191.StylePriority.UseBorderColor = false;
            this.xrLabel191.StylePriority.UseBorders = false;
            this.xrLabel191.StylePriority.UseFont = false;
            this.xrLabel191.StylePriority.UseForeColor = false;
            this.xrLabel191.StylePriority.UseTextAlignment = false;
            this.xrLabel191.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel192
            // 
            this.xrLabel192.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel192.BorderColor = System.Drawing.Color.Black;
            this.xrLabel192.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel192.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel192.ForeColor = System.Drawing.Color.Black;
            this.xrLabel192.LocationFloat = new DevExpress.Utils.PointFloat(6.125023F, 265.4584F);
            this.xrLabel192.Name = "xrLabel192";
            this.xrLabel192.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel192.SizeF = new System.Drawing.SizeF(48.54166F, 21.54169F);
            this.xrLabel192.StylePriority.UseBackColor = false;
            this.xrLabel192.StylePriority.UseBorderColor = false;
            this.xrLabel192.StylePriority.UseBorders = false;
            this.xrLabel192.StylePriority.UseFont = false;
            this.xrLabel192.StylePriority.UseForeColor = false;
            this.xrLabel192.StylePriority.UseTextAlignment = false;
            this.xrLabel192.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel193
            // 
            this.xrLabel193.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel193.BorderColor = System.Drawing.Color.Black;
            this.xrLabel193.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel193.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel193.ForeColor = System.Drawing.Color.Black;
            this.xrLabel193.LocationFloat = new DevExpress.Utils.PointFloat(102.1251F, 265.4583F);
            this.xrLabel193.Name = "xrLabel193";
            this.xrLabel193.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel193.SizeF = new System.Drawing.SizeF(238.4586F, 21.54166F);
            this.xrLabel193.StylePriority.UseBackColor = false;
            this.xrLabel193.StylePriority.UseBorderColor = false;
            this.xrLabel193.StylePriority.UseBorders = false;
            this.xrLabel193.StylePriority.UseFont = false;
            this.xrLabel193.StylePriority.UseForeColor = false;
            this.xrLabel193.StylePriority.UseTextAlignment = false;
            this.xrLabel193.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel194
            // 
            this.xrLabel194.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel194.BorderColor = System.Drawing.Color.Black;
            this.xrLabel194.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel194.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel194.ForeColor = System.Drawing.Color.Black;
            this.xrLabel194.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 265.4583F);
            this.xrLabel194.Name = "xrLabel194";
            this.xrLabel194.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel194.SizeF = new System.Drawing.SizeF(88.37491F, 21.54166F);
            this.xrLabel194.StylePriority.UseBackColor = false;
            this.xrLabel194.StylePriority.UseBorderColor = false;
            this.xrLabel194.StylePriority.UseBorders = false;
            this.xrLabel194.StylePriority.UseFont = false;
            this.xrLabel194.StylePriority.UseForeColor = false;
            this.xrLabel194.StylePriority.UseTextAlignment = false;
            this.xrLabel194.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel195
            // 
            this.xrLabel195.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel195.BorderColor = System.Drawing.Color.Black;
            this.xrLabel195.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel195.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel195.ForeColor = System.Drawing.Color.Black;
            this.xrLabel195.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 265.4584F);
            this.xrLabel195.Name = "xrLabel195";
            this.xrLabel195.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel195.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel195.StylePriority.UseBackColor = false;
            this.xrLabel195.StylePriority.UseBorderColor = false;
            this.xrLabel195.StylePriority.UseBorders = false;
            this.xrLabel195.StylePriority.UseFont = false;
            this.xrLabel195.StylePriority.UseForeColor = false;
            this.xrLabel195.StylePriority.UseTextAlignment = false;
            this.xrLabel195.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel196
            // 
            this.xrLabel196.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel196.BorderColor = System.Drawing.Color.Black;
            this.xrLabel196.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel196.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel196.ForeColor = System.Drawing.Color.Black;
            this.xrLabel196.LocationFloat = new DevExpress.Utils.PointFloat(55.12507F, 243.9167F);
            this.xrLabel196.Name = "xrLabel196";
            this.xrLabel196.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel196.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel196.StylePriority.UseBackColor = false;
            this.xrLabel196.StylePriority.UseBorderColor = false;
            this.xrLabel196.StylePriority.UseBorders = false;
            this.xrLabel196.StylePriority.UseFont = false;
            this.xrLabel196.StylePriority.UseForeColor = false;
            this.xrLabel196.StylePriority.UseTextAlignment = false;
            this.xrLabel196.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel197
            // 
            this.xrLabel197.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel197.BorderColor = System.Drawing.Color.Black;
            this.xrLabel197.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel197.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel197.ForeColor = System.Drawing.Color.Black;
            this.xrLabel197.LocationFloat = new DevExpress.Utils.PointFloat(6.125055F, 243.9167F);
            this.xrLabel197.Name = "xrLabel197";
            this.xrLabel197.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel197.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel197.StylePriority.UseBackColor = false;
            this.xrLabel197.StylePriority.UseBorderColor = false;
            this.xrLabel197.StylePriority.UseBorders = false;
            this.xrLabel197.StylePriority.UseFont = false;
            this.xrLabel197.StylePriority.UseForeColor = false;
            this.xrLabel197.StylePriority.UseTextAlignment = false;
            this.xrLabel197.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel198
            // 
            this.xrLabel198.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel198.BorderColor = System.Drawing.Color.Black;
            this.xrLabel198.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel198.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel198.ForeColor = System.Drawing.Color.Black;
            this.xrLabel198.LocationFloat = new DevExpress.Utils.PointFloat(102.1251F, 243.9167F);
            this.xrLabel198.Name = "xrLabel198";
            this.xrLabel198.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel198.SizeF = new System.Drawing.SizeF(238.4586F, 21.5417F);
            this.xrLabel198.StylePriority.UseBackColor = false;
            this.xrLabel198.StylePriority.UseBorderColor = false;
            this.xrLabel198.StylePriority.UseBorders = false;
            this.xrLabel198.StylePriority.UseFont = false;
            this.xrLabel198.StylePriority.UseForeColor = false;
            this.xrLabel198.StylePriority.UseTextAlignment = false;
            this.xrLabel198.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel199
            // 
            this.xrLabel199.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel199.BorderColor = System.Drawing.Color.Black;
            this.xrLabel199.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel199.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel199.ForeColor = System.Drawing.Color.Black;
            this.xrLabel199.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 243.9167F);
            this.xrLabel199.Name = "xrLabel199";
            this.xrLabel199.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel199.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel199.StylePriority.UseBackColor = false;
            this.xrLabel199.StylePriority.UseBorderColor = false;
            this.xrLabel199.StylePriority.UseBorders = false;
            this.xrLabel199.StylePriority.UseFont = false;
            this.xrLabel199.StylePriority.UseForeColor = false;
            this.xrLabel199.StylePriority.UseTextAlignment = false;
            this.xrLabel199.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel200
            // 
            this.xrLabel200.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel200.BorderColor = System.Drawing.Color.Black;
            this.xrLabel200.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel200.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel200.ForeColor = System.Drawing.Color.Black;
            this.xrLabel200.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 243.9167F);
            this.xrLabel200.Name = "xrLabel200";
            this.xrLabel200.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel200.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel200.StylePriority.UseBackColor = false;
            this.xrLabel200.StylePriority.UseBorderColor = false;
            this.xrLabel200.StylePriority.UseBorders = false;
            this.xrLabel200.StylePriority.UseFont = false;
            this.xrLabel200.StylePriority.UseForeColor = false;
            this.xrLabel200.StylePriority.UseTextAlignment = false;
            this.xrLabel200.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel201
            // 
            this.xrLabel201.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel201.BorderColor = System.Drawing.Color.Black;
            this.xrLabel201.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel201.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel201.ForeColor = System.Drawing.Color.Black;
            this.xrLabel201.LocationFloat = new DevExpress.Utils.PointFloat(6.125122F, 287F);
            this.xrLabel201.Name = "xrLabel201";
            this.xrLabel201.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel201.SizeF = new System.Drawing.SizeF(393.4272F, 21.54172F);
            this.xrLabel201.StylePriority.UseBackColor = false;
            this.xrLabel201.StylePriority.UseBorderColor = false;
            this.xrLabel201.StylePriority.UseBorders = false;
            this.xrLabel201.StylePriority.UseFont = false;
            this.xrLabel201.StylePriority.UseForeColor = false;
            this.xrLabel201.StylePriority.UseTextAlignment = false;
            this.xrLabel201.Text = "Valor Total da Nota R$    ";
            this.xrLabel201.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lvlrtotalnf1_2
            // 
            this.lvlrtotalnf1_2.BackColor = System.Drawing.Color.Transparent;
            this.lvlrtotalnf1_2.BorderColor = System.Drawing.Color.Black;
            this.lvlrtotalnf1_2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lvlrtotalnf1_2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lvlrtotalnf1_2.ForeColor = System.Drawing.Color.Black;
            this.lvlrtotalnf1_2.LocationFloat = new DevExpress.Utils.PointFloat(399.5524F, 287.0001F);
            this.lvlrtotalnf1_2.Name = "lvlrtotalnf1_2";
            this.lvlrtotalnf1_2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrtotalnf1_2.SizeF = new System.Drawing.SizeF(130.8644F, 21.54169F);
            this.lvlrtotalnf1_2.StylePriority.UseBackColor = false;
            this.lvlrtotalnf1_2.StylePriority.UseBorderColor = false;
            this.lvlrtotalnf1_2.StylePriority.UseBorders = false;
            this.lvlrtotalnf1_2.StylePriority.UseFont = false;
            this.lvlrtotalnf1_2.StylePriority.UseForeColor = false;
            this.lvlrtotalnf1_2.StylePriority.UseTextAlignment = false;
            this.lvlrtotalnf1_2.Text = "0,00";
            this.lvlrtotalnf1_2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPanel5
            // 
            this.xrPanel5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel94,
            this.xrLabel95,
            this.xrLabel96,
            this.xrLabel93,
            this.xrLabel97,
            this.xrLabel91});
            this.xrPanel5.LocationFloat = new DevExpress.Utils.PointFloat(16.25019F, 636.5002F);
            this.xrPanel5.Name = "xrPanel5";
            this.xrPanel5.SizeF = new System.Drawing.SizeF(535.5627F, 81.41672F);
            this.xrPanel5.StylePriority.UseBorders = false;
            // 
            // xrLabel94
            // 
            this.xrLabel94.BackColor = System.Drawing.Color.Empty;
            this.xrLabel94.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel94.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel94.LocationFloat = new DevExpress.Utils.PointFloat(44.95834F, 59.24988F);
            this.xrLabel94.Name = "xrLabel94";
            this.xrLabel94.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel94.SizeF = new System.Drawing.SizeF(121.8748F, 14F);
            this.xrLabel94.StylePriority.UseBackColor = false;
            this.xrLabel94.StylePriority.UseBorders = false;
            this.xrLabel94.StylePriority.UseFont = false;
            this.xrLabel94.StylePriority.UseTextAlignment = false;
            this.xrLabel94.Text = "____/____/________";
            this.xrLabel94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel95
            // 
            this.xrLabel95.BackColor = System.Drawing.Color.Empty;
            this.xrLabel95.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel95.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel95.LocationFloat = new DevExpress.Utils.PointFloat(176.8331F, 59.2499F);
            this.xrLabel95.Name = "xrLabel95";
            this.xrLabel95.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel95.SizeF = new System.Drawing.SizeF(64.20832F, 14F);
            this.xrLabel95.StylePriority.UseBackColor = false;
            this.xrLabel95.StylePriority.UseBorders = false;
            this.xrLabel95.StylePriority.UseFont = false;
            this.xrLabel95.StylePriority.UseTextAlignment = false;
            this.xrLabel95.Text = "Assinatura:";
            this.xrLabel95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel96
            // 
            this.xrLabel96.BackColor = System.Drawing.Color.Empty;
            this.xrLabel96.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel96.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel96.LocationFloat = new DevExpress.Utils.PointFloat(243.5834F, 59.2499F);
            this.xrLabel96.Name = "xrLabel96";
            this.xrLabel96.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel96.SizeF = new System.Drawing.SizeF(264.2084F, 14F);
            this.xrLabel96.StylePriority.UseBackColor = false;
            this.xrLabel96.StylePriority.UseBorders = false;
            this.xrLabel96.StylePriority.UseFont = false;
            this.xrLabel96.StylePriority.UseTextAlignment = false;
            this.xrLabel96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel93
            // 
            this.xrLabel93.BackColor = System.Drawing.Color.Empty;
            this.xrLabel93.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel93.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel93.LocationFloat = new DevExpress.Utils.PointFloat(9.249977F, 59.24991F);
            this.xrLabel93.Name = "xrLabel93";
            this.xrLabel93.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel93.SizeF = new System.Drawing.SizeF(32.95832F, 14.00003F);
            this.xrLabel93.StylePriority.UseBackColor = false;
            this.xrLabel93.StylePriority.UseBorders = false;
            this.xrLabel93.StylePriority.UseFont = false;
            this.xrLabel93.StylePriority.UseTextAlignment = false;
            this.xrLabel93.Text = "Em:";
            this.xrLabel93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel97
            // 
            this.xrLabel97.BackColor = System.Drawing.Color.Empty;
            this.xrLabel97.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel97.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel97.LocationFloat = new DevExpress.Utils.PointFloat(6.999978F, 2F);
            this.xrLabel97.Name = "xrLabel97";
            this.xrLabel97.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel97.SizeF = new System.Drawing.SizeF(497.1665F, 14F);
            this.xrLabel97.StylePriority.UseBackColor = false;
            this.xrLabel97.StylePriority.UseBorders = false;
            this.xrLabel97.StylePriority.UseFont = false;
            this.xrLabel97.Text = "Declaro que foram prestados os serviços constantes neste Documento";
            // 
            // xrLabel91
            // 
            this.xrLabel91.BackColor = System.Drawing.Color.Empty;
            this.xrLabel91.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel91.Font = new System.Drawing.Font("Calibri", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel91.LocationFloat = new DevExpress.Utils.PointFloat(6.999969F, 15.99998F);
            this.xrLabel91.Name = "xrLabel91";
            this.xrLabel91.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel91.SizeF = new System.Drawing.SizeF(497.1665F, 14F);
            this.xrLabel91.StylePriority.UseBackColor = false;
            this.xrLabel91.StylePriority.UseBorders = false;
            this.xrLabel91.StylePriority.UseFont = false;
            this.xrLabel91.Text = "Fiscal Simplificado de Serviços de Microempreendedor Individual - MEI.";
            // 
            // xrPanel4
            // 
            this.xrPanel4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.xrLabel4,
            this.xrLabel5,
            this.luni1_1,
            this.lqtd1_1,
            this.ldescricao1_1,
            this.lvlruni1_1,
            this.lvlrtot1_1,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel36,
            this.xrLabel38,
            this.xrLabel37,
            this.xrLabel40,
            this.xrLabel39,
            this.xrLabel41,
            this.xrLabel43,
            this.xrLabel42,
            this.xrLabel45,
            this.xrLabel44,
            this.xrLabel46,
            this.xrLabel48,
            this.xrLabel47,
            this.xrLabel55,
            this.xrLabel54,
            this.xrLabel56,
            this.xrLabel58,
            this.xrLabel57,
            this.xrLabel50,
            this.xrLabel49,
            this.xrLabel51,
            this.xrLabel53,
            this.xrLabel52,
            this.xrLabel65,
            this.xrLabel64,
            this.xrLabel66,
            this.xrLabel68,
            this.xrLabel67,
            this.xrLabel60,
            this.xrLabel59,
            this.xrLabel61,
            this.xrLabel63,
            this.xrLabel62,
            this.xrLabel75,
            this.xrLabel74,
            this.xrLabel76,
            this.xrLabel78,
            this.xrLabel77,
            this.xrLabel70,
            this.xrLabel69,
            this.xrLabel71,
            this.xrLabel73,
            this.xrLabel72,
            this.xrLabel85,
            this.xrLabel84,
            this.xrLabel86,
            this.xrLabel88,
            this.xrLabel87,
            this.xrLabel80,
            this.xrLabel79,
            this.xrLabel81,
            this.xrLabel83,
            this.xrLabel82,
            this.xrLabel89,
            this.lvlrtotalnf1_1});
            this.xrPanel4.LocationFloat = new DevExpress.Utils.PointFloat(16.25019F, 310.5834F);
            this.xrPanel4.Name = "xrPanel4";
            this.xrPanel4.SizeF = new System.Drawing.SizeF(535.5626F, 325.9168F);
            this.xrPanel4.StylePriority.UseBorders = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel3.BorderColor = System.Drawing.Color.Black;
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(102.1252F, 5.000005F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(238.4585F, 21.5417F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Descrição dos Serviços";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel2.BorderColor = System.Drawing.Color.Black;
            this.xrLabel2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(55.12516F, 5.000007F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Unid.";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel1.BorderColor = System.Drawing.Color.Black;
            this.xrLabel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.ForeColor = System.Drawing.Color.Black;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(6.125151F, 5.000007F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Qtd.";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel4.BorderColor = System.Drawing.Color.Black;
            this.xrLabel4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.ForeColor = System.Drawing.Color.Black;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 5.000007F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Vlr. Total";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel5.BorderColor = System.Drawing.Color.Black;
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.ForeColor = System.Drawing.Color.Black;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(341.4168F, 5.000005F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Vlr. Unitário";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // luni1_1
            // 
            this.luni1_1.BackColor = System.Drawing.Color.Transparent;
            this.luni1_1.BorderColor = System.Drawing.Color.Black;
            this.luni1_1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.luni1_1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.luni1_1.ForeColor = System.Drawing.Color.Black;
            this.luni1_1.LocationFloat = new DevExpress.Utils.PointFloat(55.1251F, 26.54169F);
            this.luni1_1.Name = "luni1_1";
            this.luni1_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.luni1_1.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.luni1_1.StylePriority.UseBackColor = false;
            this.luni1_1.StylePriority.UseBorderColor = false;
            this.luni1_1.StylePriority.UseBorders = false;
            this.luni1_1.StylePriority.UseFont = false;
            this.luni1_1.StylePriority.UseForeColor = false;
            this.luni1_1.StylePriority.UseTextAlignment = false;
            this.luni1_1.Text = "-";
            this.luni1_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lqtd1_1
            // 
            this.lqtd1_1.BackColor = System.Drawing.Color.Transparent;
            this.lqtd1_1.BorderColor = System.Drawing.Color.Black;
            this.lqtd1_1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lqtd1_1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lqtd1_1.ForeColor = System.Drawing.Color.Black;
            this.lqtd1_1.LocationFloat = new DevExpress.Utils.PointFloat(6.125086F, 26.54169F);
            this.lqtd1_1.Name = "lqtd1_1";
            this.lqtd1_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lqtd1_1.SizeF = new System.Drawing.SizeF(48.54167F, 21.5417F);
            this.lqtd1_1.StylePriority.UseBackColor = false;
            this.lqtd1_1.StylePriority.UseBorderColor = false;
            this.lqtd1_1.StylePriority.UseBorders = false;
            this.lqtd1_1.StylePriority.UseFont = false;
            this.lqtd1_1.StylePriority.UseForeColor = false;
            this.lqtd1_1.StylePriority.UseTextAlignment = false;
            this.lqtd1_1.Text = "1";
            this.lqtd1_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // ldescricao1_1
            // 
            this.ldescricao1_1.BackColor = System.Drawing.Color.Transparent;
            this.ldescricao1_1.BorderColor = System.Drawing.Color.Black;
            this.ldescricao1_1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.ldescricao1_1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.ldescricao1_1.ForeColor = System.Drawing.Color.Black;
            this.ldescricao1_1.LocationFloat = new DevExpress.Utils.PointFloat(102.1251F, 26.5417F);
            this.ldescricao1_1.Name = "ldescricao1_1";
            this.ldescricao1_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ldescricao1_1.SizeF = new System.Drawing.SizeF(238.4586F, 21.54171F);
            this.ldescricao1_1.StylePriority.UseBackColor = false;
            this.ldescricao1_1.StylePriority.UseBorderColor = false;
            this.ldescricao1_1.StylePriority.UseBorders = false;
            this.ldescricao1_1.StylePriority.UseFont = false;
            this.ldescricao1_1.StylePriority.UseForeColor = false;
            this.ldescricao1_1.StylePriority.UseTextAlignment = false;
            this.ldescricao1_1.Text = "Manutenção de Equipamentos";
            this.ldescricao1_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lvlruni1_1
            // 
            this.lvlruni1_1.BackColor = System.Drawing.Color.Transparent;
            this.lvlruni1_1.BorderColor = System.Drawing.Color.Black;
            this.lvlruni1_1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lvlruni1_1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lvlruni1_1.ForeColor = System.Drawing.Color.Black;
            this.lvlruni1_1.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 26.5417F);
            this.lvlruni1_1.Name = "lvlruni1_1";
            this.lvlruni1_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlruni1_1.SizeF = new System.Drawing.SizeF(88.37491F, 21.54171F);
            this.lvlruni1_1.StylePriority.UseBackColor = false;
            this.lvlruni1_1.StylePriority.UseBorderColor = false;
            this.lvlruni1_1.StylePriority.UseBorders = false;
            this.lvlruni1_1.StylePriority.UseFont = false;
            this.lvlruni1_1.StylePriority.UseForeColor = false;
            this.lvlruni1_1.StylePriority.UseTextAlignment = false;
            this.lvlruni1_1.Text = "0,00";
            this.lvlruni1_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lvlrtot1_1
            // 
            this.lvlrtot1_1.BackColor = System.Drawing.Color.Transparent;
            this.lvlrtot1_1.BorderColor = System.Drawing.Color.Black;
            this.lvlrtot1_1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lvlrtot1_1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lvlrtot1_1.ForeColor = System.Drawing.Color.Black;
            this.lvlrtot1_1.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 26.54169F);
            this.lvlrtot1_1.Name = "lvlrtot1_1";
            this.lvlrtot1_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrtot1_1.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.lvlrtot1_1.StylePriority.UseBackColor = false;
            this.lvlrtot1_1.StylePriority.UseBorderColor = false;
            this.lvlrtot1_1.StylePriority.UseBorders = false;
            this.lvlrtot1_1.StylePriority.UseFont = false;
            this.lvlrtot1_1.StylePriority.UseForeColor = false;
            this.lvlrtot1_1.StylePriority.UseTextAlignment = false;
            this.lvlrtot1_1.Text = "0,00";
            this.lvlrtot1_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel12
            // 
            this.xrLabel12.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel12.BorderColor = System.Drawing.Color.Black;
            this.xrLabel12.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.ForeColor = System.Drawing.Color.Black;
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(6.125055F, 48.08339F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel12.StylePriority.UseBackColor = false;
            this.xrLabel12.StylePriority.UseBorderColor = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseForeColor = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel11.BorderColor = System.Drawing.Color.Black;
            this.xrLabel11.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.ForeColor = System.Drawing.Color.Black;
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(55.12507F, 48.08339F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseBorderColor = false;
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseForeColor = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel36
            // 
            this.xrLabel36.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel36.BorderColor = System.Drawing.Color.Black;
            this.xrLabel36.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel36.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel36.ForeColor = System.Drawing.Color.Black;
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(102.1251F, 48.08339F);
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(238.4586F, 21.54171F);
            this.xrLabel36.StylePriority.UseBackColor = false;
            this.xrLabel36.StylePriority.UseBorderColor = false;
            this.xrLabel36.StylePriority.UseBorders = false;
            this.xrLabel36.StylePriority.UseFont = false;
            this.xrLabel36.StylePriority.UseForeColor = false;
            this.xrLabel36.StylePriority.UseTextAlignment = false;
            this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel38
            // 
            this.xrLabel38.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel38.BorderColor = System.Drawing.Color.Black;
            this.xrLabel38.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel38.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel38.ForeColor = System.Drawing.Color.Black;
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 48.08339F);
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel38.StylePriority.UseBackColor = false;
            this.xrLabel38.StylePriority.UseBorderColor = false;
            this.xrLabel38.StylePriority.UseBorders = false;
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.StylePriority.UseForeColor = false;
            this.xrLabel38.StylePriority.UseTextAlignment = false;
            this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel37
            // 
            this.xrLabel37.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel37.BorderColor = System.Drawing.Color.Black;
            this.xrLabel37.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel37.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel37.ForeColor = System.Drawing.Color.Black;
            this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 48.08339F);
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel37.SizeF = new System.Drawing.SizeF(88.37491F, 21.54171F);
            this.xrLabel37.StylePriority.UseBackColor = false;
            this.xrLabel37.StylePriority.UseBorderColor = false;
            this.xrLabel37.StylePriority.UseBorders = false;
            this.xrLabel37.StylePriority.UseFont = false;
            this.xrLabel37.StylePriority.UseForeColor = false;
            this.xrLabel37.StylePriority.UseTextAlignment = false;
            this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel40
            // 
            this.xrLabel40.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel40.BorderColor = System.Drawing.Color.Black;
            this.xrLabel40.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel40.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel40.ForeColor = System.Drawing.Color.Black;
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(6.125086F, 70.62508F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(48.54167F, 21.5417F);
            this.xrLabel40.StylePriority.UseBackColor = false;
            this.xrLabel40.StylePriority.UseBorderColor = false;
            this.xrLabel40.StylePriority.UseBorders = false;
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UseForeColor = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel39
            // 
            this.xrLabel39.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel39.BorderColor = System.Drawing.Color.Black;
            this.xrLabel39.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel39.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel39.ForeColor = System.Drawing.Color.Black;
            this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(55.1251F, 70.62508F);
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel39.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel39.StylePriority.UseBackColor = false;
            this.xrLabel39.StylePriority.UseBorderColor = false;
            this.xrLabel39.StylePriority.UseBorders = false;
            this.xrLabel39.StylePriority.UseFont = false;
            this.xrLabel39.StylePriority.UseForeColor = false;
            this.xrLabel39.StylePriority.UseTextAlignment = false;
            this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel41
            // 
            this.xrLabel41.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel41.BorderColor = System.Drawing.Color.Black;
            this.xrLabel41.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel41.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel41.ForeColor = System.Drawing.Color.Black;
            this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(102.1252F, 70.62508F);
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel41.SizeF = new System.Drawing.SizeF(238.4585F, 21.5417F);
            this.xrLabel41.StylePriority.UseBackColor = false;
            this.xrLabel41.StylePriority.UseBorderColor = false;
            this.xrLabel41.StylePriority.UseBorders = false;
            this.xrLabel41.StylePriority.UseFont = false;
            this.xrLabel41.StylePriority.UseForeColor = false;
            this.xrLabel41.StylePriority.UseTextAlignment = false;
            this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel43
            // 
            this.xrLabel43.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel43.BorderColor = System.Drawing.Color.Black;
            this.xrLabel43.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel43.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel43.ForeColor = System.Drawing.Color.Black;
            this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 70.62508F);
            this.xrLabel43.Name = "xrLabel43";
            this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel43.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel43.StylePriority.UseBackColor = false;
            this.xrLabel43.StylePriority.UseBorderColor = false;
            this.xrLabel43.StylePriority.UseBorders = false;
            this.xrLabel43.StylePriority.UseFont = false;
            this.xrLabel43.StylePriority.UseForeColor = false;
            this.xrLabel43.StylePriority.UseTextAlignment = false;
            this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel42
            // 
            this.xrLabel42.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel42.BorderColor = System.Drawing.Color.Black;
            this.xrLabel42.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel42.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel42.ForeColor = System.Drawing.Color.Black;
            this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 70.62508F);
            this.xrLabel42.Name = "xrLabel42";
            this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel42.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel42.StylePriority.UseBackColor = false;
            this.xrLabel42.StylePriority.UseBorderColor = false;
            this.xrLabel42.StylePriority.UseBorders = false;
            this.xrLabel42.StylePriority.UseFont = false;
            this.xrLabel42.StylePriority.UseForeColor = false;
            this.xrLabel42.StylePriority.UseTextAlignment = false;
            this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel45
            // 
            this.xrLabel45.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel45.BorderColor = System.Drawing.Color.Black;
            this.xrLabel45.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel45.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel45.ForeColor = System.Drawing.Color.Black;
            this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(6.125055F, 92.16677F);
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel45.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel45.StylePriority.UseBackColor = false;
            this.xrLabel45.StylePriority.UseBorderColor = false;
            this.xrLabel45.StylePriority.UseBorders = false;
            this.xrLabel45.StylePriority.UseFont = false;
            this.xrLabel45.StylePriority.UseForeColor = false;
            this.xrLabel45.StylePriority.UseTextAlignment = false;
            this.xrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel44
            // 
            this.xrLabel44.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel44.BorderColor = System.Drawing.Color.Black;
            this.xrLabel44.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel44.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel44.ForeColor = System.Drawing.Color.Black;
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(55.12507F, 92.16677F);
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel44.StylePriority.UseBackColor = false;
            this.xrLabel44.StylePriority.UseBorderColor = false;
            this.xrLabel44.StylePriority.UseBorders = false;
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.StylePriority.UseForeColor = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel46
            // 
            this.xrLabel46.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel46.BorderColor = System.Drawing.Color.Black;
            this.xrLabel46.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel46.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel46.ForeColor = System.Drawing.Color.Black;
            this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(102.1251F, 92.16677F);
            this.xrLabel46.Name = "xrLabel46";
            this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel46.SizeF = new System.Drawing.SizeF(238.4586F, 21.5417F);
            this.xrLabel46.StylePriority.UseBackColor = false;
            this.xrLabel46.StylePriority.UseBorderColor = false;
            this.xrLabel46.StylePriority.UseBorders = false;
            this.xrLabel46.StylePriority.UseFont = false;
            this.xrLabel46.StylePriority.UseForeColor = false;
            this.xrLabel46.StylePriority.UseTextAlignment = false;
            this.xrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel48
            // 
            this.xrLabel48.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel48.BorderColor = System.Drawing.Color.Black;
            this.xrLabel48.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel48.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel48.ForeColor = System.Drawing.Color.Black;
            this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 92.16677F);
            this.xrLabel48.Name = "xrLabel48";
            this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel48.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel48.StylePriority.UseBackColor = false;
            this.xrLabel48.StylePriority.UseBorderColor = false;
            this.xrLabel48.StylePriority.UseBorders = false;
            this.xrLabel48.StylePriority.UseFont = false;
            this.xrLabel48.StylePriority.UseForeColor = false;
            this.xrLabel48.StylePriority.UseTextAlignment = false;
            this.xrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel47
            // 
            this.xrLabel47.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel47.BorderColor = System.Drawing.Color.Black;
            this.xrLabel47.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel47.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel47.ForeColor = System.Drawing.Color.Black;
            this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 92.16677F);
            this.xrLabel47.Name = "xrLabel47";
            this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel47.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel47.StylePriority.UseBackColor = false;
            this.xrLabel47.StylePriority.UseBorderColor = false;
            this.xrLabel47.StylePriority.UseBorders = false;
            this.xrLabel47.StylePriority.UseFont = false;
            this.xrLabel47.StylePriority.UseForeColor = false;
            this.xrLabel47.StylePriority.UseTextAlignment = false;
            this.xrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel55
            // 
            this.xrLabel55.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel55.BorderColor = System.Drawing.Color.Black;
            this.xrLabel55.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel55.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel55.ForeColor = System.Drawing.Color.Black;
            this.xrLabel55.LocationFloat = new DevExpress.Utils.PointFloat(55.12507F, 135.8333F);
            this.xrLabel55.Name = "xrLabel55";
            this.xrLabel55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel55.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel55.StylePriority.UseBackColor = false;
            this.xrLabel55.StylePriority.UseBorderColor = false;
            this.xrLabel55.StylePriority.UseBorders = false;
            this.xrLabel55.StylePriority.UseFont = false;
            this.xrLabel55.StylePriority.UseForeColor = false;
            this.xrLabel55.StylePriority.UseTextAlignment = false;
            this.xrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel54
            // 
            this.xrLabel54.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel54.BorderColor = System.Drawing.Color.Black;
            this.xrLabel54.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel54.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel54.ForeColor = System.Drawing.Color.Black;
            this.xrLabel54.LocationFloat = new DevExpress.Utils.PointFloat(6.125055F, 135.8333F);
            this.xrLabel54.Name = "xrLabel54";
            this.xrLabel54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel54.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel54.StylePriority.UseBackColor = false;
            this.xrLabel54.StylePriority.UseBorderColor = false;
            this.xrLabel54.StylePriority.UseBorders = false;
            this.xrLabel54.StylePriority.UseFont = false;
            this.xrLabel54.StylePriority.UseForeColor = false;
            this.xrLabel54.StylePriority.UseTextAlignment = false;
            this.xrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel56
            // 
            this.xrLabel56.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel56.BorderColor = System.Drawing.Color.Black;
            this.xrLabel56.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel56.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel56.ForeColor = System.Drawing.Color.Black;
            this.xrLabel56.LocationFloat = new DevExpress.Utils.PointFloat(102.1252F, 135.8333F);
            this.xrLabel56.Name = "xrLabel56";
            this.xrLabel56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel56.SizeF = new System.Drawing.SizeF(238.4585F, 21.54173F);
            this.xrLabel56.StylePriority.UseBackColor = false;
            this.xrLabel56.StylePriority.UseBorderColor = false;
            this.xrLabel56.StylePriority.UseBorders = false;
            this.xrLabel56.StylePriority.UseFont = false;
            this.xrLabel56.StylePriority.UseForeColor = false;
            this.xrLabel56.StylePriority.UseTextAlignment = false;
            this.xrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel58
            // 
            this.xrLabel58.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel58.BorderColor = System.Drawing.Color.Black;
            this.xrLabel58.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel58.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel58.ForeColor = System.Drawing.Color.Black;
            this.xrLabel58.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 135.8333F);
            this.xrLabel58.Name = "xrLabel58";
            this.xrLabel58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel58.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel58.StylePriority.UseBackColor = false;
            this.xrLabel58.StylePriority.UseBorderColor = false;
            this.xrLabel58.StylePriority.UseBorders = false;
            this.xrLabel58.StylePriority.UseFont = false;
            this.xrLabel58.StylePriority.UseForeColor = false;
            this.xrLabel58.StylePriority.UseTextAlignment = false;
            this.xrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel57
            // 
            this.xrLabel57.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel57.BorderColor = System.Drawing.Color.Black;
            this.xrLabel57.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel57.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel57.ForeColor = System.Drawing.Color.Black;
            this.xrLabel57.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 135.8333F);
            this.xrLabel57.Name = "xrLabel57";
            this.xrLabel57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel57.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel57.StylePriority.UseBackColor = false;
            this.xrLabel57.StylePriority.UseBorderColor = false;
            this.xrLabel57.StylePriority.UseBorders = false;
            this.xrLabel57.StylePriority.UseFont = false;
            this.xrLabel57.StylePriority.UseForeColor = false;
            this.xrLabel57.StylePriority.UseTextAlignment = false;
            this.xrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel50
            // 
            this.xrLabel50.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel50.BorderColor = System.Drawing.Color.Black;
            this.xrLabel50.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel50.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel50.ForeColor = System.Drawing.Color.Black;
            this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(6.125086F, 114.2916F);
            this.xrLabel50.Name = "xrLabel50";
            this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel50.SizeF = new System.Drawing.SizeF(48.54167F, 21.54171F);
            this.xrLabel50.StylePriority.UseBackColor = false;
            this.xrLabel50.StylePriority.UseBorderColor = false;
            this.xrLabel50.StylePriority.UseBorders = false;
            this.xrLabel50.StylePriority.UseFont = false;
            this.xrLabel50.StylePriority.UseForeColor = false;
            this.xrLabel50.StylePriority.UseTextAlignment = false;
            this.xrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel49
            // 
            this.xrLabel49.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel49.BorderColor = System.Drawing.Color.Black;
            this.xrLabel49.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel49.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel49.ForeColor = System.Drawing.Color.Black;
            this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(55.1251F, 114.2916F);
            this.xrLabel49.Name = "xrLabel49";
            this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel49.SizeF = new System.Drawing.SizeF(46.45834F, 21.54171F);
            this.xrLabel49.StylePriority.UseBackColor = false;
            this.xrLabel49.StylePriority.UseBorderColor = false;
            this.xrLabel49.StylePriority.UseBorders = false;
            this.xrLabel49.StylePriority.UseFont = false;
            this.xrLabel49.StylePriority.UseForeColor = false;
            this.xrLabel49.StylePriority.UseTextAlignment = false;
            this.xrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel51
            // 
            this.xrLabel51.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel51.BorderColor = System.Drawing.Color.Black;
            this.xrLabel51.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel51.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel51.ForeColor = System.Drawing.Color.Black;
            this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(102.1252F, 114.2916F);
            this.xrLabel51.Name = "xrLabel51";
            this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel51.SizeF = new System.Drawing.SizeF(238.4585F, 21.54169F);
            this.xrLabel51.StylePriority.UseBackColor = false;
            this.xrLabel51.StylePriority.UseBorderColor = false;
            this.xrLabel51.StylePriority.UseBorders = false;
            this.xrLabel51.StylePriority.UseFont = false;
            this.xrLabel51.StylePriority.UseForeColor = false;
            this.xrLabel51.StylePriority.UseTextAlignment = false;
            this.xrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel53
            // 
            this.xrLabel53.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel53.BorderColor = System.Drawing.Color.Black;
            this.xrLabel53.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel53.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel53.ForeColor = System.Drawing.Color.Black;
            this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 114.2916F);
            this.xrLabel53.Name = "xrLabel53";
            this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel53.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel53.StylePriority.UseBackColor = false;
            this.xrLabel53.StylePriority.UseBorderColor = false;
            this.xrLabel53.StylePriority.UseBorders = false;
            this.xrLabel53.StylePriority.UseFont = false;
            this.xrLabel53.StylePriority.UseForeColor = false;
            this.xrLabel53.StylePriority.UseTextAlignment = false;
            this.xrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel52
            // 
            this.xrLabel52.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel52.BorderColor = System.Drawing.Color.Black;
            this.xrLabel52.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel52.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel52.ForeColor = System.Drawing.Color.Black;
            this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 114.2916F);
            this.xrLabel52.Name = "xrLabel52";
            this.xrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel52.SizeF = new System.Drawing.SizeF(88.37491F, 21.54171F);
            this.xrLabel52.StylePriority.UseBackColor = false;
            this.xrLabel52.StylePriority.UseBorderColor = false;
            this.xrLabel52.StylePriority.UseBorders = false;
            this.xrLabel52.StylePriority.UseFont = false;
            this.xrLabel52.StylePriority.UseForeColor = false;
            this.xrLabel52.StylePriority.UseTextAlignment = false;
            this.xrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel65
            // 
            this.xrLabel65.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel65.BorderColor = System.Drawing.Color.Black;
            this.xrLabel65.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel65.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel65.ForeColor = System.Drawing.Color.Black;
            this.xrLabel65.LocationFloat = new DevExpress.Utils.PointFloat(55.12507F, 178.9167F);
            this.xrLabel65.Name = "xrLabel65";
            this.xrLabel65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel65.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel65.StylePriority.UseBackColor = false;
            this.xrLabel65.StylePriority.UseBorderColor = false;
            this.xrLabel65.StylePriority.UseBorders = false;
            this.xrLabel65.StylePriority.UseFont = false;
            this.xrLabel65.StylePriority.UseForeColor = false;
            this.xrLabel65.StylePriority.UseTextAlignment = false;
            this.xrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel64
            // 
            this.xrLabel64.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel64.BorderColor = System.Drawing.Color.Black;
            this.xrLabel64.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel64.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel64.ForeColor = System.Drawing.Color.Black;
            this.xrLabel64.LocationFloat = new DevExpress.Utils.PointFloat(6.125055F, 178.9167F);
            this.xrLabel64.Name = "xrLabel64";
            this.xrLabel64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel64.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel64.StylePriority.UseBackColor = false;
            this.xrLabel64.StylePriority.UseBorderColor = false;
            this.xrLabel64.StylePriority.UseBorders = false;
            this.xrLabel64.StylePriority.UseFont = false;
            this.xrLabel64.StylePriority.UseForeColor = false;
            this.xrLabel64.StylePriority.UseTextAlignment = false;
            this.xrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel66
            // 
            this.xrLabel66.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel66.BorderColor = System.Drawing.Color.Black;
            this.xrLabel66.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel66.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel66.ForeColor = System.Drawing.Color.Black;
            this.xrLabel66.LocationFloat = new DevExpress.Utils.PointFloat(102.1252F, 178.9167F);
            this.xrLabel66.Name = "xrLabel66";
            this.xrLabel66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel66.SizeF = new System.Drawing.SizeF(238.4585F, 21.5417F);
            this.xrLabel66.StylePriority.UseBackColor = false;
            this.xrLabel66.StylePriority.UseBorderColor = false;
            this.xrLabel66.StylePriority.UseBorders = false;
            this.xrLabel66.StylePriority.UseFont = false;
            this.xrLabel66.StylePriority.UseForeColor = false;
            this.xrLabel66.StylePriority.UseTextAlignment = false;
            this.xrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel68
            // 
            this.xrLabel68.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel68.BorderColor = System.Drawing.Color.Black;
            this.xrLabel68.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel68.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel68.ForeColor = System.Drawing.Color.Black;
            this.xrLabel68.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 178.9167F);
            this.xrLabel68.Name = "xrLabel68";
            this.xrLabel68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel68.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel68.StylePriority.UseBackColor = false;
            this.xrLabel68.StylePriority.UseBorderColor = false;
            this.xrLabel68.StylePriority.UseBorders = false;
            this.xrLabel68.StylePriority.UseFont = false;
            this.xrLabel68.StylePriority.UseForeColor = false;
            this.xrLabel68.StylePriority.UseTextAlignment = false;
            this.xrLabel68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel67
            // 
            this.xrLabel67.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel67.BorderColor = System.Drawing.Color.Black;
            this.xrLabel67.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel67.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel67.ForeColor = System.Drawing.Color.Black;
            this.xrLabel67.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 178.9167F);
            this.xrLabel67.Name = "xrLabel67";
            this.xrLabel67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel67.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel67.StylePriority.UseBackColor = false;
            this.xrLabel67.StylePriority.UseBorderColor = false;
            this.xrLabel67.StylePriority.UseBorders = false;
            this.xrLabel67.StylePriority.UseFont = false;
            this.xrLabel67.StylePriority.UseForeColor = false;
            this.xrLabel67.StylePriority.UseTextAlignment = false;
            this.xrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel60
            // 
            this.xrLabel60.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel60.BorderColor = System.Drawing.Color.Black;
            this.xrLabel60.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel60.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel60.ForeColor = System.Drawing.Color.Black;
            this.xrLabel60.LocationFloat = new DevExpress.Utils.PointFloat(55.1251F, 157.375F);
            this.xrLabel60.Name = "xrLabel60";
            this.xrLabel60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel60.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel60.StylePriority.UseBackColor = false;
            this.xrLabel60.StylePriority.UseBorderColor = false;
            this.xrLabel60.StylePriority.UseBorders = false;
            this.xrLabel60.StylePriority.UseFont = false;
            this.xrLabel60.StylePriority.UseForeColor = false;
            this.xrLabel60.StylePriority.UseTextAlignment = false;
            this.xrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel59
            // 
            this.xrLabel59.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel59.BorderColor = System.Drawing.Color.Black;
            this.xrLabel59.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel59.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel59.ForeColor = System.Drawing.Color.Black;
            this.xrLabel59.LocationFloat = new DevExpress.Utils.PointFloat(6.125086F, 157.375F);
            this.xrLabel59.Name = "xrLabel59";
            this.xrLabel59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel59.SizeF = new System.Drawing.SizeF(48.54167F, 21.5417F);
            this.xrLabel59.StylePriority.UseBackColor = false;
            this.xrLabel59.StylePriority.UseBorderColor = false;
            this.xrLabel59.StylePriority.UseBorders = false;
            this.xrLabel59.StylePriority.UseFont = false;
            this.xrLabel59.StylePriority.UseForeColor = false;
            this.xrLabel59.StylePriority.UseTextAlignment = false;
            this.xrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel61
            // 
            this.xrLabel61.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel61.BorderColor = System.Drawing.Color.Black;
            this.xrLabel61.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel61.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel61.ForeColor = System.Drawing.Color.Black;
            this.xrLabel61.LocationFloat = new DevExpress.Utils.PointFloat(102.1252F, 157.375F);
            this.xrLabel61.Name = "xrLabel61";
            this.xrLabel61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel61.SizeF = new System.Drawing.SizeF(238.4585F, 21.5417F);
            this.xrLabel61.StylePriority.UseBackColor = false;
            this.xrLabel61.StylePriority.UseBorderColor = false;
            this.xrLabel61.StylePriority.UseBorders = false;
            this.xrLabel61.StylePriority.UseFont = false;
            this.xrLabel61.StylePriority.UseForeColor = false;
            this.xrLabel61.StylePriority.UseTextAlignment = false;
            this.xrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel63
            // 
            this.xrLabel63.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel63.BorderColor = System.Drawing.Color.Black;
            this.xrLabel63.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel63.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel63.ForeColor = System.Drawing.Color.Black;
            this.xrLabel63.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 157.375F);
            this.xrLabel63.Name = "xrLabel63";
            this.xrLabel63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel63.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel63.StylePriority.UseBackColor = false;
            this.xrLabel63.StylePriority.UseBorderColor = false;
            this.xrLabel63.StylePriority.UseBorders = false;
            this.xrLabel63.StylePriority.UseFont = false;
            this.xrLabel63.StylePriority.UseForeColor = false;
            this.xrLabel63.StylePriority.UseTextAlignment = false;
            this.xrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel62
            // 
            this.xrLabel62.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel62.BorderColor = System.Drawing.Color.Black;
            this.xrLabel62.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel62.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel62.ForeColor = System.Drawing.Color.Black;
            this.xrLabel62.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 157.375F);
            this.xrLabel62.Name = "xrLabel62";
            this.xrLabel62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel62.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel62.StylePriority.UseBackColor = false;
            this.xrLabel62.StylePriority.UseBorderColor = false;
            this.xrLabel62.StylePriority.UseBorders = false;
            this.xrLabel62.StylePriority.UseFont = false;
            this.xrLabel62.StylePriority.UseForeColor = false;
            this.xrLabel62.StylePriority.UseTextAlignment = false;
            this.xrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel75
            // 
            this.xrLabel75.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel75.BorderColor = System.Drawing.Color.Black;
            this.xrLabel75.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel75.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel75.ForeColor = System.Drawing.Color.Black;
            this.xrLabel75.LocationFloat = new DevExpress.Utils.PointFloat(55.12504F, 222.3749F);
            this.xrLabel75.Name = "xrLabel75";
            this.xrLabel75.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel75.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel75.StylePriority.UseBackColor = false;
            this.xrLabel75.StylePriority.UseBorderColor = false;
            this.xrLabel75.StylePriority.UseBorders = false;
            this.xrLabel75.StylePriority.UseFont = false;
            this.xrLabel75.StylePriority.UseForeColor = false;
            this.xrLabel75.StylePriority.UseTextAlignment = false;
            this.xrLabel75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel74
            // 
            this.xrLabel74.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel74.BorderColor = System.Drawing.Color.Black;
            this.xrLabel74.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel74.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel74.ForeColor = System.Drawing.Color.Black;
            this.xrLabel74.LocationFloat = new DevExpress.Utils.PointFloat(6.125023F, 222.3749F);
            this.xrLabel74.Name = "xrLabel74";
            this.xrLabel74.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel74.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel74.StylePriority.UseBackColor = false;
            this.xrLabel74.StylePriority.UseBorderColor = false;
            this.xrLabel74.StylePriority.UseBorders = false;
            this.xrLabel74.StylePriority.UseFont = false;
            this.xrLabel74.StylePriority.UseForeColor = false;
            this.xrLabel74.StylePriority.UseTextAlignment = false;
            this.xrLabel74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel76
            // 
            this.xrLabel76.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel76.BorderColor = System.Drawing.Color.Black;
            this.xrLabel76.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel76.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel76.ForeColor = System.Drawing.Color.Black;
            this.xrLabel76.LocationFloat = new DevExpress.Utils.PointFloat(102.1251F, 222.375F);
            this.xrLabel76.Name = "xrLabel76";
            this.xrLabel76.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel76.SizeF = new System.Drawing.SizeF(238.4586F, 21.5417F);
            this.xrLabel76.StylePriority.UseBackColor = false;
            this.xrLabel76.StylePriority.UseBorderColor = false;
            this.xrLabel76.StylePriority.UseBorders = false;
            this.xrLabel76.StylePriority.UseFont = false;
            this.xrLabel76.StylePriority.UseForeColor = false;
            this.xrLabel76.StylePriority.UseTextAlignment = false;
            this.xrLabel76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel78
            // 
            this.xrLabel78.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel78.BorderColor = System.Drawing.Color.Black;
            this.xrLabel78.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel78.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel78.ForeColor = System.Drawing.Color.Black;
            this.xrLabel78.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 222.375F);
            this.xrLabel78.Name = "xrLabel78";
            this.xrLabel78.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel78.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel78.StylePriority.UseBackColor = false;
            this.xrLabel78.StylePriority.UseBorderColor = false;
            this.xrLabel78.StylePriority.UseBorders = false;
            this.xrLabel78.StylePriority.UseFont = false;
            this.xrLabel78.StylePriority.UseForeColor = false;
            this.xrLabel78.StylePriority.UseTextAlignment = false;
            this.xrLabel78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel77
            // 
            this.xrLabel77.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel77.BorderColor = System.Drawing.Color.Black;
            this.xrLabel77.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel77.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel77.ForeColor = System.Drawing.Color.Black;
            this.xrLabel77.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 222.3749F);
            this.xrLabel77.Name = "xrLabel77";
            this.xrLabel77.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel77.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel77.StylePriority.UseBackColor = false;
            this.xrLabel77.StylePriority.UseBorderColor = false;
            this.xrLabel77.StylePriority.UseBorders = false;
            this.xrLabel77.StylePriority.UseFont = false;
            this.xrLabel77.StylePriority.UseForeColor = false;
            this.xrLabel77.StylePriority.UseTextAlignment = false;
            this.xrLabel77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel70
            // 
            this.xrLabel70.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel70.BorderColor = System.Drawing.Color.Black;
            this.xrLabel70.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel70.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel70.ForeColor = System.Drawing.Color.Black;
            this.xrLabel70.LocationFloat = new DevExpress.Utils.PointFloat(6.125055F, 200.8333F);
            this.xrLabel70.Name = "xrLabel70";
            this.xrLabel70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel70.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel70.StylePriority.UseBackColor = false;
            this.xrLabel70.StylePriority.UseBorderColor = false;
            this.xrLabel70.StylePriority.UseBorders = false;
            this.xrLabel70.StylePriority.UseFont = false;
            this.xrLabel70.StylePriority.UseForeColor = false;
            this.xrLabel70.StylePriority.UseTextAlignment = false;
            this.xrLabel70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel69
            // 
            this.xrLabel69.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel69.BorderColor = System.Drawing.Color.Black;
            this.xrLabel69.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel69.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel69.ForeColor = System.Drawing.Color.Black;
            this.xrLabel69.LocationFloat = new DevExpress.Utils.PointFloat(55.12507F, 200.8333F);
            this.xrLabel69.Name = "xrLabel69";
            this.xrLabel69.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel69.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel69.StylePriority.UseBackColor = false;
            this.xrLabel69.StylePriority.UseBorderColor = false;
            this.xrLabel69.StylePriority.UseBorders = false;
            this.xrLabel69.StylePriority.UseFont = false;
            this.xrLabel69.StylePriority.UseForeColor = false;
            this.xrLabel69.StylePriority.UseTextAlignment = false;
            this.xrLabel69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel71
            // 
            this.xrLabel71.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel71.BorderColor = System.Drawing.Color.Black;
            this.xrLabel71.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel71.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel71.ForeColor = System.Drawing.Color.Black;
            this.xrLabel71.LocationFloat = new DevExpress.Utils.PointFloat(102.1251F, 200.8333F);
            this.xrLabel71.Name = "xrLabel71";
            this.xrLabel71.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel71.SizeF = new System.Drawing.SizeF(238.4586F, 21.5417F);
            this.xrLabel71.StylePriority.UseBackColor = false;
            this.xrLabel71.StylePriority.UseBorderColor = false;
            this.xrLabel71.StylePriority.UseBorders = false;
            this.xrLabel71.StylePriority.UseFont = false;
            this.xrLabel71.StylePriority.UseForeColor = false;
            this.xrLabel71.StylePriority.UseTextAlignment = false;
            this.xrLabel71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel73
            // 
            this.xrLabel73.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel73.BorderColor = System.Drawing.Color.Black;
            this.xrLabel73.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel73.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel73.ForeColor = System.Drawing.Color.Black;
            this.xrLabel73.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 200.8333F);
            this.xrLabel73.Name = "xrLabel73";
            this.xrLabel73.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel73.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel73.StylePriority.UseBackColor = false;
            this.xrLabel73.StylePriority.UseBorderColor = false;
            this.xrLabel73.StylePriority.UseBorders = false;
            this.xrLabel73.StylePriority.UseFont = false;
            this.xrLabel73.StylePriority.UseForeColor = false;
            this.xrLabel73.StylePriority.UseTextAlignment = false;
            this.xrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel72
            // 
            this.xrLabel72.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel72.BorderColor = System.Drawing.Color.Black;
            this.xrLabel72.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel72.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel72.ForeColor = System.Drawing.Color.Black;
            this.xrLabel72.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 200.8333F);
            this.xrLabel72.Name = "xrLabel72";
            this.xrLabel72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel72.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel72.StylePriority.UseBackColor = false;
            this.xrLabel72.StylePriority.UseBorderColor = false;
            this.xrLabel72.StylePriority.UseBorders = false;
            this.xrLabel72.StylePriority.UseFont = false;
            this.xrLabel72.StylePriority.UseForeColor = false;
            this.xrLabel72.StylePriority.UseTextAlignment = false;
            this.xrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel85
            // 
            this.xrLabel85.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel85.BorderColor = System.Drawing.Color.Black;
            this.xrLabel85.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel85.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel85.ForeColor = System.Drawing.Color.Black;
            this.xrLabel85.LocationFloat = new DevExpress.Utils.PointFloat(55.12504F, 265.4584F);
            this.xrLabel85.Name = "xrLabel85";
            this.xrLabel85.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel85.SizeF = new System.Drawing.SizeF(46.45834F, 21.54169F);
            this.xrLabel85.StylePriority.UseBackColor = false;
            this.xrLabel85.StylePriority.UseBorderColor = false;
            this.xrLabel85.StylePriority.UseBorders = false;
            this.xrLabel85.StylePriority.UseFont = false;
            this.xrLabel85.StylePriority.UseForeColor = false;
            this.xrLabel85.StylePriority.UseTextAlignment = false;
            this.xrLabel85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel84
            // 
            this.xrLabel84.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel84.BorderColor = System.Drawing.Color.Black;
            this.xrLabel84.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel84.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel84.ForeColor = System.Drawing.Color.Black;
            this.xrLabel84.LocationFloat = new DevExpress.Utils.PointFloat(6.125023F, 265.4584F);
            this.xrLabel84.Name = "xrLabel84";
            this.xrLabel84.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel84.SizeF = new System.Drawing.SizeF(48.54166F, 21.54169F);
            this.xrLabel84.StylePriority.UseBackColor = false;
            this.xrLabel84.StylePriority.UseBorderColor = false;
            this.xrLabel84.StylePriority.UseBorders = false;
            this.xrLabel84.StylePriority.UseFont = false;
            this.xrLabel84.StylePriority.UseForeColor = false;
            this.xrLabel84.StylePriority.UseTextAlignment = false;
            this.xrLabel84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel86
            // 
            this.xrLabel86.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel86.BorderColor = System.Drawing.Color.Black;
            this.xrLabel86.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel86.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel86.ForeColor = System.Drawing.Color.Black;
            this.xrLabel86.LocationFloat = new DevExpress.Utils.PointFloat(102.1251F, 265.4583F);
            this.xrLabel86.Name = "xrLabel86";
            this.xrLabel86.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel86.SizeF = new System.Drawing.SizeF(238.4586F, 21.54166F);
            this.xrLabel86.StylePriority.UseBackColor = false;
            this.xrLabel86.StylePriority.UseBorderColor = false;
            this.xrLabel86.StylePriority.UseBorders = false;
            this.xrLabel86.StylePriority.UseFont = false;
            this.xrLabel86.StylePriority.UseForeColor = false;
            this.xrLabel86.StylePriority.UseTextAlignment = false;
            this.xrLabel86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel88
            // 
            this.xrLabel88.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel88.BorderColor = System.Drawing.Color.Black;
            this.xrLabel88.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel88.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel88.ForeColor = System.Drawing.Color.Black;
            this.xrLabel88.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 265.4583F);
            this.xrLabel88.Name = "xrLabel88";
            this.xrLabel88.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel88.SizeF = new System.Drawing.SizeF(88.37491F, 21.54166F);
            this.xrLabel88.StylePriority.UseBackColor = false;
            this.xrLabel88.StylePriority.UseBorderColor = false;
            this.xrLabel88.StylePriority.UseBorders = false;
            this.xrLabel88.StylePriority.UseFont = false;
            this.xrLabel88.StylePriority.UseForeColor = false;
            this.xrLabel88.StylePriority.UseTextAlignment = false;
            this.xrLabel88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel87
            // 
            this.xrLabel87.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel87.BorderColor = System.Drawing.Color.Black;
            this.xrLabel87.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel87.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel87.ForeColor = System.Drawing.Color.Black;
            this.xrLabel87.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 265.4584F);
            this.xrLabel87.Name = "xrLabel87";
            this.xrLabel87.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel87.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel87.StylePriority.UseBackColor = false;
            this.xrLabel87.StylePriority.UseBorderColor = false;
            this.xrLabel87.StylePriority.UseBorders = false;
            this.xrLabel87.StylePriority.UseFont = false;
            this.xrLabel87.StylePriority.UseForeColor = false;
            this.xrLabel87.StylePriority.UseTextAlignment = false;
            this.xrLabel87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel80
            // 
            this.xrLabel80.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel80.BorderColor = System.Drawing.Color.Black;
            this.xrLabel80.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel80.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel80.ForeColor = System.Drawing.Color.Black;
            this.xrLabel80.LocationFloat = new DevExpress.Utils.PointFloat(55.12507F, 243.9167F);
            this.xrLabel80.Name = "xrLabel80";
            this.xrLabel80.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel80.SizeF = new System.Drawing.SizeF(46.45834F, 21.5417F);
            this.xrLabel80.StylePriority.UseBackColor = false;
            this.xrLabel80.StylePriority.UseBorderColor = false;
            this.xrLabel80.StylePriority.UseBorders = false;
            this.xrLabel80.StylePriority.UseFont = false;
            this.xrLabel80.StylePriority.UseForeColor = false;
            this.xrLabel80.StylePriority.UseTextAlignment = false;
            this.xrLabel80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel79
            // 
            this.xrLabel79.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel79.BorderColor = System.Drawing.Color.Black;
            this.xrLabel79.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel79.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel79.ForeColor = System.Drawing.Color.Black;
            this.xrLabel79.LocationFloat = new DevExpress.Utils.PointFloat(6.125055F, 243.9167F);
            this.xrLabel79.Name = "xrLabel79";
            this.xrLabel79.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel79.SizeF = new System.Drawing.SizeF(48.54166F, 21.5417F);
            this.xrLabel79.StylePriority.UseBackColor = false;
            this.xrLabel79.StylePriority.UseBorderColor = false;
            this.xrLabel79.StylePriority.UseBorders = false;
            this.xrLabel79.StylePriority.UseFont = false;
            this.xrLabel79.StylePriority.UseForeColor = false;
            this.xrLabel79.StylePriority.UseTextAlignment = false;
            this.xrLabel79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel81
            // 
            this.xrLabel81.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel81.BorderColor = System.Drawing.Color.Black;
            this.xrLabel81.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel81.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel81.ForeColor = System.Drawing.Color.Black;
            this.xrLabel81.LocationFloat = new DevExpress.Utils.PointFloat(102.1251F, 243.9167F);
            this.xrLabel81.Name = "xrLabel81";
            this.xrLabel81.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel81.SizeF = new System.Drawing.SizeF(238.4586F, 21.5417F);
            this.xrLabel81.StylePriority.UseBackColor = false;
            this.xrLabel81.StylePriority.UseBorderColor = false;
            this.xrLabel81.StylePriority.UseBorders = false;
            this.xrLabel81.StylePriority.UseFont = false;
            this.xrLabel81.StylePriority.UseForeColor = false;
            this.xrLabel81.StylePriority.UseTextAlignment = false;
            this.xrLabel81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel83
            // 
            this.xrLabel83.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel83.BorderColor = System.Drawing.Color.Black;
            this.xrLabel83.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel83.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel83.ForeColor = System.Drawing.Color.Black;
            this.xrLabel83.LocationFloat = new DevExpress.Utils.PointFloat(341.4167F, 243.9167F);
            this.xrLabel83.Name = "xrLabel83";
            this.xrLabel83.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel83.SizeF = new System.Drawing.SizeF(88.37491F, 21.5417F);
            this.xrLabel83.StylePriority.UseBackColor = false;
            this.xrLabel83.StylePriority.UseBorderColor = false;
            this.xrLabel83.StylePriority.UseBorders = false;
            this.xrLabel83.StylePriority.UseFont = false;
            this.xrLabel83.StylePriority.UseForeColor = false;
            this.xrLabel83.StylePriority.UseTextAlignment = false;
            this.xrLabel83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel82
            // 
            this.xrLabel82.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel82.BorderColor = System.Drawing.Color.Black;
            this.xrLabel82.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel82.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel82.ForeColor = System.Drawing.Color.Black;
            this.xrLabel82.LocationFloat = new DevExpress.Utils.PointFloat(430.4168F, 243.9167F);
            this.xrLabel82.Name = "xrLabel82";
            this.xrLabel82.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel82.SizeF = new System.Drawing.SizeF(100F, 21.5417F);
            this.xrLabel82.StylePriority.UseBackColor = false;
            this.xrLabel82.StylePriority.UseBorderColor = false;
            this.xrLabel82.StylePriority.UseBorders = false;
            this.xrLabel82.StylePriority.UseFont = false;
            this.xrLabel82.StylePriority.UseForeColor = false;
            this.xrLabel82.StylePriority.UseTextAlignment = false;
            this.xrLabel82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel89
            // 
            this.xrLabel89.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel89.BorderColor = System.Drawing.Color.Black;
            this.xrLabel89.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel89.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel89.ForeColor = System.Drawing.Color.Black;
            this.xrLabel89.LocationFloat = new DevExpress.Utils.PointFloat(6.125149F, 287F);
            this.xrLabel89.Name = "xrLabel89";
            this.xrLabel89.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel89.SizeF = new System.Drawing.SizeF(394.7501F, 21.54172F);
            this.xrLabel89.StylePriority.UseBackColor = false;
            this.xrLabel89.StylePriority.UseBorderColor = false;
            this.xrLabel89.StylePriority.UseBorders = false;
            this.xrLabel89.StylePriority.UseFont = false;
            this.xrLabel89.StylePriority.UseForeColor = false;
            this.xrLabel89.StylePriority.UseTextAlignment = false;
            this.xrLabel89.Text = "Valor Total da Nota R$    ";
            this.xrLabel89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lvlrtotalnf1_1
            // 
            this.lvlrtotalnf1_1.BackColor = System.Drawing.Color.Transparent;
            this.lvlrtotalnf1_1.BorderColor = System.Drawing.Color.Black;
            this.lvlrtotalnf1_1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lvlrtotalnf1_1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lvlrtotalnf1_1.ForeColor = System.Drawing.Color.Black;
            this.lvlrtotalnf1_1.LocationFloat = new DevExpress.Utils.PointFloat(400.8752F, 287.0001F);
            this.lvlrtotalnf1_1.Name = "lvlrtotalnf1_1";
            this.lvlrtotalnf1_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lvlrtotalnf1_1.SizeF = new System.Drawing.SizeF(129.5416F, 21.54169F);
            this.lvlrtotalnf1_1.StylePriority.UseBackColor = false;
            this.lvlrtotalnf1_1.StylePriority.UseBorderColor = false;
            this.lvlrtotalnf1_1.StylePriority.UseBorders = false;
            this.lvlrtotalnf1_1.StylePriority.UseFont = false;
            this.lvlrtotalnf1_1.StylePriority.UseForeColor = false;
            this.lvlrtotalnf1_1.StylePriority.UseTextAlignment = false;
            this.lvlrtotalnf1_1.Text = "0,00";
            this.lvlrtotalnf1_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.BackColor = System.Drawing.Color.Transparent;
            this.TopMargin.HeightF = 24F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 24F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.BackColor = System.Drawing.Color.LightGray;
            this.PageHeader.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageHeader.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.PageHeader.HeightF = 2F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseBackColor = false;
            this.PageHeader.StylePriority.UseBorders = false;
            this.PageHeader.StylePriority.UseFont = false;
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
            // xrCrossBandBox1
            // 
            this.xrCrossBandBox1.BorderColor = System.Drawing.Color.Empty;
            this.xrCrossBandBox1.BorderWidth = 2F;
            this.xrCrossBandBox1.EndBand = this.BottomMargin;
            this.xrCrossBandBox1.EndPointFloat = new DevExpress.Utils.PointFloat(3.000134F, 1.999982F);
            this.xrCrossBandBox1.LocationFloat = new DevExpress.Utils.PointFloat(3.000134F, 0F);
            this.xrCrossBandBox1.Name = "xrCrossBandBox1";
            this.xrCrossBandBox1.StartBand = this.PageHeader;
            this.xrCrossBandBox1.StartPointFloat = new DevExpress.Utils.PointFloat(3.000134F, 0F);
            this.xrCrossBandBox1.WidthF = 1120.958F;
            // 
            // RepNotaFiscalGitano
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader});
            this.CrossBandControls.AddRange(new DevExpress.XtraReports.UI.XRCrossBandControl[] {
            this.xrCrossBandBox1});
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(7, 17, 24, 24);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1,
            this.xrControlStyle2});
            this.Version = "13.2";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RepNotaFiscalGitano_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    //
    public DateTime dtemissao;
    public Int32 numeronota;
    //
    private void RepNotaFiscalGitano_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //if ((SreDblib.GetParametro("RELATORIO ZEBRADO") == "SIM"))
        //{
        //    Detail.Styles.EvenStyle.BackColor = System.Drawing.Color.Empty;
        //    Detail.Styles.OddStyle.BackColor = System.Drawing.Color.Silver;
        //    Detail.Styles.EvenStyle.ForeColor = System.Drawing.Color.Black;
        //}
        //else
        //{
            Detail.Styles.EvenStyle.BackColor = System.Drawing.Color.Empty;
            Detail.Styles.OddStyle.BackColor = System.Drawing.Color.Empty;
            Detail.Styles.EvenStyle.ForeColor = System.Drawing.Color.Black;
        //}

        //grupofiltros.RepeatEveryPage = ((SreDblib.GetParametro("EXIBE FILTRO RELAT") == "SIM"));

    }

    private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        //
        lnumeronota1.Text = Srelib.QStr0(numeronota.ToString().Trim(),5);
        lnumeronota2.Text = Srelib.QStr0(numeronota.ToString().Trim(), 5);
        //
        ldataemissao1.Text = dtemissao.ToString().Substring(0, 10);
        ldataemissao2.Text = dtemissao.ToString().Substring(0, 10);
        //
        string produto = Convert.ToString(GetCurrentColumnValue("produto"));
        string grupo = Convert.ToString(GetCurrentColumnValue("grupo"));
        string unidade = Convert.ToString(GetCurrentColumnValue("unidade"));
        string parte = Convert.ToString(GetCurrentColumnValue("parte"));
        //
        string cliente = uVendas.PegaProprietário(produto, grupo, unidade, parte);
        //
        lnome1.Text = uContato.PegaNomeID(cliente.ToString().Trim());
        lnome2.Text = uContato.PegaNomeID(cliente.ToString().Trim());
        //
        lendereco1.Text = uContato.PegaEnderecoPuroID(cliente.ToString().Trim());
        lendereco2.Text = uContato.PegaEnderecoPuroID(cliente.ToString().Trim());
        //
        lbairro1.Text = uContato.PegaBairroID(cliente.ToString().Trim());
        lbairro2.Text = uContato.PegaBairroID(cliente.ToString().Trim());
        //
        lcidade1.Text = uContato.PegaCidadeID(cliente.ToString().Trim());
        lcidade2.Text = uContato.PegaCidadeID(cliente.ToString().Trim());
        //
        luf1.Text = uContato.PegaufID(cliente.ToString().Trim());
        luf2.Text = uContato.PegaufID(cliente.ToString().Trim());
        //
        lcnpj1.Text = uContato.PegaCpfCnpjID(cliente.ToString().Trim());
        lcnpj1.Text = Srelib.FormataCPFCNPJ(lcnpj1.Text);
        lcnpj2.Text = uContato.PegaCpfCnpjID(cliente.ToString().Trim());
        lcnpj2.Text = Srelib.FormataCPFCNPJ(lcnpj2.Text);
        //
        linscricao1.Text = uContato.PegaInscricaoMunicipalID(cliente.ToString().Trim());
        linscricao2.Text = uContato.PegaInscricaoMunicipalID(cliente.ToString().Trim());
        //
        if (linscricao1.Text == string.Empty)
        {
            linscricao1.Text = uContato.PegaInscricaoEstadualID(cliente.ToString().Trim());
            linscricao2.Text = uContato.PegaInscricaoEstadualID(cliente.ToString().Trim());
        }
        //
        //
        string valor = Convert.ToString(GetCurrentColumnValue("vlr_parcela"));
        lvlruni1_1.Text = Srelib.forcaponto(valor);
        lvlruni1_2.Text = Srelib.forcaponto(valor);
        //
        lvlrtot1_1.Text = Srelib.forcaponto(valor);
        lvlrtot1_2.Text = Srelib.forcaponto(valor);
        //
        lvlrtotalnf1_1.Text = Srelib.forcaponto(valor);
        lvlrtotalnf1_2.Text = Srelib.forcaponto(valor);
        //
        numeronota++;
        uParametros.AlteraValorParametro("PROXIMA NOTA FISCAL",numeronota.ToString().Trim());
    }

}
