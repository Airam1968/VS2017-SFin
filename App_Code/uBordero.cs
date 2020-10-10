using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

using System.IO;
using System.Xml;
using System.Windows;
using System.Windows.Forms;

 

/// <summary>
/// Summary description for uBordero
/// </summary>
public class uBordero
{



public String data;
public String numero;
public String empresa;
public String cedente;
public String tipo_operacao;
public String bordero; 

public String  data_oper;
public String  data_cadastro;
public String  dmais;
public String  criterio;
public String  tdesc;
public String  tserv;
public String  tiss;
public String  txiof;
public String  lcalc;
public String  tipograva;
public String  tmora;
public String  iof_ts;
public String  cpmf;
public String  cpmf2;
public String  custo_che;
public String  custo_dup;
public String  custo_doc;
public String  cobserv;
public String  cobiof;
public String  cobiss;
public String  recompra;
public String  custo_che2;
public String  custo_dup2;
public String  custo_doc2;
public String  pis;
public String  fin;
public String  df_no_pis;
public String  df_no_fim;
public String  zera_custos;
public String  tipo_custo;
public String  tipo_cdi;
public String  cdbano;
public String  cdbmes;
public String  dc;
public String  du;
public String  ccdmais;
public String  juros_bancarios;
public String  iof_custos;
public String  vtac;
public String  npis;
public String  nfin;
public String  niss;
public String  visao;
public String  ndoc;
public String  nirpj;
public String  ncsocial;
public String  txsaq;
public String  valsaque;

public String nche;
public String ndup ;
public String vche ;
public String vdup;
public String vdoc;
public String tche;
public String tdup;
public String tdoc;
public String adicional;
public Double txsaque;
public String cbcpmf;
public String cbnche;
public String cbndup;
public String cbndoc;
public String cbvche ;
public String cbvdup ;
public String cbvdoc ;
public String cbtche ;
public String cbtdup ;
public String cbtdoc ;
public String jb      ;
public String db  ;
public String liquido;
public String perc_retencao_ir;
public String perc_retencao2_total ;
public String retencao_ir  ;
public String retencao2_total;
public String perc_retencao_pis ;
public String perc_retencao_cofins ;
public String perc_retencao_csll ;
public String retencao_pis ;
public String retencao_cofins ;
public String retencao_csll;
public String pago      ;
public String vcpmf     ;
public String tcpmf     ;
public String treceita   ;
public String tdespesa ;
public String lucro     ;
public String margem    ;
public String margem30  ;
public String totimp    ;
public String tover ;
public String totcc  ;
public String vjb   ;
public String viof_custos ;
       
public String nbord;

public String vtt;
public String tdesconto;
public String df;
public String pmpx;
public String pmp0;
public String ts;
public String iss;
public String niof;
public String viof;
public String tiof;
public String iof;
public String cbvcpmf;
public String cbtcpmf;
public String totcb;

public String vpis;
public String tpis;
public String vfin;
public String tfin;
public String viss;
public String tiss2;
public String obs1;
public String obs2;

public String virpj;
public String tirpj;
public String vcsocial;
public String tcsocial;
public String gerente;     
public String ntitulos;
public String status;

public String _adicional2;
public String dataatual;
public String cms;

public String bordvinc;



    public String AlteraBordero(String pXml)
    {
        // Conexao Conn = new Conexao(pXml);
        if (bordvinc.Trim() == "")
            bordvinc = "0";
        String Qry = "EXEC GN_ALTERA_BORDERO " +
                     Srelib.QStr(empresa) + "," +
                     Srelib.QStr(cedente) + "," +
                     tipo_operacao + "," +
                     bordero + "," +
                     Srelib.QStr(Srelib.DataQuery(data_oper, DM.FormatoData)) + "," +
                     Srelib.QStr(Srelib.DataQuery(data_cadastro, DM.FormatoData)) + "," +
                     dmais + "," +
                     criterio + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tdesc)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tserv)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tiss)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(txiof)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(pmpx)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(pmp0)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(vtt)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(df)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(ts)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(iss)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(iof)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(db)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(liquido)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(recompra)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(pago)) + "," +
                     nche + "," +
                     ndup + "," +
                     ndoc + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cpmf)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(vche)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(vdup)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(vdoc)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(vcpmf)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tche)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tdup)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tdoc)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tcpmf)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(adicional)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2("0.00")) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cbnche)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cbndup)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cbndoc)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cbcpmf)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cbvche)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cbvdup)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cbvdoc)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cbvcpmf)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cbtche)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cbtdup)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cbtdoc)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cbtcpmf)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(totcb)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(npis)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(nfin)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(niss)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(niof)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(vpis)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(vfin)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(viss)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(viof)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tpis)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tfin)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tiss2)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tiof)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(totimp)) + "," +
                     tipo_custo + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cdbano)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cdbmes)) + "," +
                     Srelib.forcaponto(dc) + "," +
                     Srelib.forcaponto(du) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tover)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(totcc)) + "," +
                     ccdmais + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(jb)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(iof_custos)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(vjb)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(viof_custos)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(vtac)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(lucro)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(margem)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(margem30)) + "," +
                     tipo_cdi + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(treceita)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tdespesa)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tmora)) + "," +
                     Srelib.QStr("") + "," +
                     Srelib.QStr(gerente) + "," +
                     ntitulos + "," +
                     Srelib.QStr(obs1) + "," +
                     Srelib.QStr(obs2) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tdesconto)) + "," +
                     Srelib.QStr(Srelib.DataQuery(dataatual, DM.FormatoData)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(perc_retencao_ir)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(perc_retencao2_total)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(retencao_ir)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(retencao2_total)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(perc_retencao_pis)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(perc_retencao_cofins)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(perc_retencao_csll)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(retencao_pis)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(retencao_cofins)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(retencao_csll)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(nirpj)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(virpj)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tirpj)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(ncsocial)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(vcsocial)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tcsocial)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(txsaq)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(valsaque)) + "," +
                     Srelib.QStr("INCLUSÃO BORDERÔ") + "," +
                     Srelib.QStr("VIA GESTOR") + "," +
                     Srelib.QStr("") + "," +
                     Srelib.QStr(Srelib.DataQuery(data, DM.FormatoData)) + "," +
                     numero + "," +
                     bordvinc;




        DataSet _StProc = new DataSet();
        SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
        Command.CommandTimeout = 99999;
        SqlDataAdapter DA = new SqlDataAdapter();
        DA.TableMappings.Add("Table", "calcbor");
        DA.SelectCommand = Command;
        DA.Fill(_StProc);
        DataTable DT;
        DT = _StProc.Tables["calcbor"];
        DataRow DR = DT.Rows[0];

        cms = Convert.ToString(DR["cms"]);

        return cms;

    }



    public String PegaValorSerasa(String pXml)
    {
        // Conexao Conn = new Conexao(pXml);
        String Qry = "EXEC GN_CALC_SERASA " +
                     Srelib.QStr(Srelib.DataQuery(data, DM.FormatoData)) + "," +
                     numero;


        DataSet _StProc = new DataSet();
        SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
        Command.CommandTimeout = 99999;
        SqlDataAdapter DA = new SqlDataAdapter();
        DA.TableMappings.Add("Table", "calcbor");
        DA.SelectCommand = Command;
        DA.Fill(_StProc);
        DataTable DT;
        DT = _StProc.Tables["calcbor"];
        DataRow DR = DT.Rows[0];

        cms = Convert.ToString(DR["valor_serasa"]);

        return cms;

    }





public void CalculaBordero( Boolean lPrimeira, String pXml)
{
        // Conexao Conn = new Conexao(pXml);

        if ( (adicional == "") || (adicional==null) ) { adicional = "0.00"; }
        Double naux = Convert.ToDouble(adicional) + Convert.ToDouble( PegaValorSerasa(pXml) );

        adicional = Srelib.PadDouble(Convert.ToString(naux));

        String Qry = "EXEC CALCULA_BOR " +
                     Srelib.QStr(empresa) + "," +
                     Srelib.QStr(cedente) + "," +
                     tipo_operacao + "," +
                     bordero + "," +
                     Srelib.QStr(Srelib.DataQuery(data_oper, DM.FormatoData)) + "," +
                     Srelib.QStr(Srelib.DataQuery(data_cadastro, DM.FormatoData)) + "," +
                     dmais + "," +
                     criterio + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tdesc)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tserv)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tiss)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(txiof)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(tmora)) + "," +
                     lcalc + "," +
                     Srelib.QStr(tipograva) + "," +
                     Srelib.QStr(iof_ts) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cpmf)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(custo_che)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(custo_dup)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(custo_doc)) + "," +
                     cobserv + "," +
                     cobiof + "," +
                     cobiss + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(recompra)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(custo_che2)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(custo_dup2)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(custo_doc2)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(pis)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(fin)) + "," +
                     Srelib.QStr(df_no_pis) + "," +
                     Srelib.QStr(df_no_fim) + "," +
                     Srelib.QStr(zera_custos) + "," +
                     tipo_custo + "," +
                     tipo_cdi + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cdbano)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cdbmes)) + "," +
                     dc + "," +
                     du + "," +
                     ccdmais + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(juros_bancarios)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(iof_custos)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(vtac)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(npis)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(nfin)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(niss)) + "," +
                     visao + "," +
                     ndoc + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2( adicional )) + "," + 
                     Srelib.forcaponto(Srelib.TrNumeroString2(nirpj)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(ncsocial)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(txsaq)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(valsaque)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2(cpmf2)) + "," +
                     Srelib.forcaponto(Srelib.TrNumeroString2("0.00"));


        DataSet _StProc = new DataSet();
        SqlCommand Command = new SqlCommand(Qry, DM.ConexaoSessao);
        Command.CommandTimeout = 99999;
        SqlDataAdapter DA = new SqlDataAdapter();
        DA.TableMappings.Add("Table", "calcbor");
        DA.SelectCommand = Command;
        DA.Fill(_StProc);
        DataTable DT;
        DT = _StProc.Tables["calcbor"];
        DataRow DR = DT.Rows[0];

        // moradefault = Convert.ToString(DR["taxamora"]);

       if( lPrimeira )
       {
         nche            = Convert.ToString(DR["nche"]);
         ndup            = Convert.ToString(DR["ndup"]);
         cpmf            = Convert.ToString(DR["cpmf"]);
         vche            = Convert.ToString(DR["custo_che"]);
         vdup            = Convert.ToString(DR["custo_dup"]);
         vdoc            = Convert.ToString(DR["custo_doc"]);
         tche            = Convert.ToString(DR["tche"]);
         tdup            = Convert.ToString(DR["tdup"]);
         tdoc            = Convert.ToString(DR["tdoc"]);
         adicional       = Convert.ToString(DR["adicional"]);
         txsaque         = Convert.ToDouble(DR["txsaque"]);
         valsaque        = Convert.ToString(DR["valsaque"]);
         cbcpmf          = Convert.ToString(DR["cbcpmf"]);
         cbnche          = Convert.ToString(DR["cbnche"]);
         cbndup          = Convert.ToString(DR["cbndup"]);
         cbndoc          = Convert.ToString(DR["cbndoc"]);
         cbndoc          = ndoc;
         cbvche          = Convert.ToString(DR["custo_che2"]);
         cbvdup          = Convert.ToString(DR["custo_dup2"]);
         cbvdoc          = Convert.ToString(DR["custo_doc2"]);
         cbtche          = Convert.ToString(DR["cbtche"]);
         cbtdup          = Convert.ToString(DR["cbtdup"]);
         cbtdoc          = Convert.ToString(DR["cbtdoc"]);
         tipo_custo      = Convert.ToString(DR["tipo_custo"]);
         tipo_cdi        = Convert.ToString(DR["tipo_cdi"]);
         cdbano          = Convert.ToString(DR["cdbano"]);
         cdbmes          = Convert.ToString(DR["cdbmes"]);
         dc              = Convert.ToString( DR["dc"] );
         du              = Convert.ToString( DR["du"] );
         ccdmais         = Convert.ToString(DR["ccdmais"]);
         jb              = Convert.ToString(DR["juros_bancarios"]);
         iof_custos      = Convert.ToString(DR["iof_custos"]);
         vtac            = Convert.ToString(DR["vtac"]);
         db              = Convert.ToString(DR["kdb"]);
         liquido         = Convert.ToString(DR["kliquido"]);
         perc_retencao_ir= Convert.ToString(DR["perc_retencao_ir"]);
         perc_retencao2_total = Convert.ToString(DR["perc_retencao2_total"]);
         retencao_ir          = Convert.ToString(DR["retencao_ir"]);
         retencao2_total      = Convert.ToString(DR["retencao2_total"]);
         perc_retencao_pis    = Convert.ToString(DR["perc_retencao_pis"]);
         perc_retencao_cofins = Convert.ToString(DR["perc_retencao_cofins"]);
         perc_retencao_csll   = Convert.ToString(DR["perc_retencao_csll"]);
         retencao_pis         = Convert.ToString(DR["retencao_pis"]);
         retencao_cofins      = Convert.ToString(DR["retencao_cofins"]);
         retencao_csll        = Convert.ToString(DR["retencao_csll"]);
         recompra        = Convert.ToString(DR["recompra"]);
         pago            = Convert.ToString(DR["kpago"]);
         vcpmf           = Convert.ToString(DR["kvcpmf"]);
         tcpmf           = Convert.ToString(DR["ktcpmf"]);
         treceita        = Convert.ToString(DR["treceita"]);
         tdespesa        = Convert.ToString(DR["tdespesa"]);
         lucro           = Convert.ToString(DR["lucro"]);
         margem          = Convert.ToString(DR["margem"]);
         margem30        = Convert.ToString(DR["margem30"]);
         totimp          = Convert.ToString(DR["totimp"]);
         cdbmes          = Convert.ToString(DR["cdbmes"]);
         tover           = Convert.ToString(DR["tover"]);
         totcc           = Convert.ToString(DR["totcc"]);
         vjb             = Convert.ToString(DR["vjb"]);
         viof_custos = Convert.ToString(DR["viof_custos"]);
       }

       lPrimeira     = false;
       empresa       = Convert.ToString(DR["empresa"]);
       cedente       = Convert.ToString(DR["cedente"]);
       nbord         = bordero;

       data_oper     =  String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(DR["data_oper"]));
       data_cadastro = String.Format("{0:dd/MM/yyyy}", Convert.ToDateTime(DR["data_cadastro"]));

       dmais         = Convert.ToString(DR["dmais"]);
       criterio      = Convert.ToString(DR["criterio"]);
       tdesc         = Convert.ToString(DR["tdesc"]);
       tserv         = Convert.ToString(DR["tserv"]);
       tiss          = Convert.ToString(DR["tiss"]);
       txiof         = Convert.ToString(DR["txiof"]);
       tmora         = Convert.ToString(DR["tmora"]);
       vtt           = Convert.ToString(DR["ktotaltitulos"]);
       tdesconto     = Convert.ToString(DR["totaldesconto"]);
       df            = Convert.ToString(DR["ktotaldesagio"]);
       pmpx          = Convert.ToString(DR["kpmpx"]);
       pmp0          = Convert.ToString(DR["kpmp0"]);
       ts            = Convert.ToString(DR["kts"]);
       iss           = Convert.ToString(DR["kiss"]);
       niof          = Convert.ToString(DR["niof"]);
       viof          = Convert.ToString(DR["viof"]);
       tiof          = Convert.ToString(DR["tiof"]);
       iof           = Convert.ToString(DR["iof"]);
       cbvcpmf       = Convert.ToString(DR["kcbvcpmf"]);
       cbtcpmf       = Convert.ToString(DR["kcbtcpmf"]);
       totcb         = Convert.ToString(DR["ktotcb"]);
       npis          = Convert.ToString(DR["npis"]);
       nfin          = Convert.ToString(DR["nfin"]);
       niss          = Convert.ToString(DR["niss"]);
       vpis          = Convert.ToString(DR["vpis"]);
       tpis          = Convert.ToString(DR["tpis"]);
       vfin          = Convert.ToString(DR["vfin"]);
       tfin          = Convert.ToString(DR["tfin"]);
       viss          = Convert.ToString(DR["viss"]);
       tiss2         = Convert.ToString(DR["tiss2"]);
       obs1          = "IMPORTADO DA APROVAÇÃO - GESTOR";
       obs2          = "";
       nirpj         = Convert.ToString(DR["nirpj"]);
       virpj         = Convert.ToString(DR["virpj"]);
       tirpj         = Convert.ToString(DR["tirpj"]);
       ncsocial      = Convert.ToString(DR["ncsocial"]);
       vcsocial      = Convert.ToString(DR["vcsocial"]);
       tcsocial      = Convert.ToString(DR["tcsocial"]);
       // gerente       =   ""; // _Cedente.PegaGerente(xCedente);
       ntitulos      = Convert.ToString(DR["numtit"]);
       status = "1";

       // Conn.SqlConn.Close();
       
}

	public uBordero()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
