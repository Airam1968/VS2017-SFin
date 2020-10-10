using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.Web.ASPxEditors;

/// <summary>
/// Summary description for uProposta
/// </summary>
public class uProposta
{

    public static DataSet PegaDadosPropostas(string xproduto,
                                             string xgrupo)
    {
        string script = "";

        if (xproduto != string.Empty)
        {
            script = " SELECT * " +
                     " FROM proposta p " +
                     " WHERE p.produto = " + xproduto;

            if (xgrupo != string.Empty)
            {
                script = script + " AND p.grupo = " + xgrupo;
            }
            script = script + " order by produto, grupo, unidade ";

        }

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosPropostaID(string xID)
    {
        string script = "";

        if (xID != string.Empty)
        {
            script = " SELECT * " +
                     " FROM proposta p " +
                     " WHERE p.Proposta = " + xID;

        }

        return SreDblib.GetDsScript(script);

    }
    
    public static DataSet PegaDadosPropostasnome(string xnome)
    {
        string script = "";

        if (xnome != string.Empty)
        {
            script = " SELECT * " +
                     " FROM proposta p " +
                     " WHERE p.nome like " + Srelib.QStr("%" + xnome + "%");

            script = script + " order by produto, grupo, unidade ";

        }

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosProposta(string xproposta)
    {
        string script = "";

        if (xproposta != string.Empty)
        {
            script = " SELECT * " +
                     " FROM proposta p " +
                     " WHERE p.proposta = " + xproposta;

            script = script + " order by produto, grupo, unidade ";

        }

        return SreDblib.GetDsScript(script);

    }

    public static String Grava(string xproposta,
                               string xdata_proposta,
                               string xproduto,
                               string xgrupo,
                               string xunidade,
                               string xparte,
                               string xtipoplanta,
                               string xindexadorprehabitese,
                               string xindexadorposhabitese,
                               string xjurosposhabitese,
                               string xcliente,
                               string xsexo,
                               string xcnpj,
                               string xinscmunicipal,
                               string xinscestadual,
                               string xregjuntacom,
                               string xnire,
                               string xrg,
                               string xrguf,
                               string xrgemissor,
                               string xrgemissao,
                               string xestadocivil,
                               string xregimecasamento,
                               string xnacionalidade,
                               string xprofissao,
                               string xemail1,
                               string xemail2,
                               string xemail3,
                               string xdtnascimento,
                               string xconjugenome,
                               string xconjugesexo,
                               string xconjugecpf,
                               string xconjugerg,
                               string xconjugerguf,
                               string xconjugergemissor,
                               string xconjugergemissao,
                               string xconjugenacionalidade,
                               string xconjugeprofissao,
                               string xconjugeemail1,
                               string xconjugeemail2,
                               string xconjugeemail3,
                               string xconjugedtnascimento,
                               string xendereco,
                               string xenderecores,
                               string xenderecoresnumero,
                               string xenderecorescomplem,
                               string xbairrores,
                               string xcidaderes,
                               string xufres,
                               string xcepres,
                               string xfone1res,
                               string xfone2res,
                               string xfone3res,
                               string xenderecocom,
                               string xenderecocomnumero,
                               string xenderecocomcomplem,
                               string xbairrocom,
                               string xcidadecom,
                               string xufcom,
                               string xcepcom,
                               string xfone1com,
                               string xfone2com,
                               string xfone3com,
                               string xativo,
                               Decimal xcomissaopermanencia,
                               string xtabelaprice,
                               Decimal xvalor_venda,
                               Decimal xsinal,
                               Decimal xsaldo,
                               string xplano1_parcelas_qtd,
                               Decimal xplano1_parcelas_vlr,
                               string xplano1_parcelas_vencimento,
                               string xplano2_parcelas_qtd,
                               Decimal xplano2_parcelas_vlr,
                               string xplano2_parcelas_vencimento,
                               string xplano3_parcelas_qtd,
                               Decimal xplano3_parcelas_vlr,
                               string xplano3_parcelas_vencimento,
                               string xplano4_parcelas_qtd,
                               Decimal xplano4_parcelas_vlr,
                               string xplano4_parcelas_vencimento,
                               string xplano5_parcelas_qtd,
                               Decimal xplano5_parcelas_vlr,
                               string xplano5_parcelas_vencimento,
                               string xplano6_parcelas_qtd,
                               Decimal xplano6_parcelas_vlr,
                               string xplano6_parcelas_vencimento,
                               string xplano7_parcelas_qtd,
                               Decimal xplano7_parcelas_vlr,
                               string xplano7_parcelas_vencimento,
                               string xplano8_parcelas_qtd,
                               Decimal xplano8_parcelas_vlr,
                               string xplano8_parcelas_vencimento,
                               string xobs,
                               string xcorretor)
    {
        string yproposta = ProximaProposta();
        //
        if (xproduto != String.Empty)
        {
            //
            string script = "INSERT INTO proposta VALUES ( " +
                               yproposta +
                               ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata_proposta.ToString().Substring(0, 10))) +
                               ", " + xproduto +
                               ", " + xgrupo +
                               ", " + xunidade +
                               ", " + xparte +
                               ", " + Srelib.QStr(xtipoplanta) +
                               ", " + Srelib.QStr(xindexadorprehabitese) +
                               ", " + Srelib.QStr(xindexadorposhabitese) +
                               ", " + Srelib.QStr(xjurosposhabitese) +
                               ", " + Srelib.QStr(xcliente) +
                               ", " + Srelib.QStr(xsexo) +
                               ", " + Srelib.QStr(xcnpj) +
                               ", " + Srelib.QStr(xinscmunicipal) +
                               ", " + Srelib.QStr(xinscestadual) +
                               ", " + Srelib.QStr(xregjuntacom) +
                               ", " + Srelib.QStr(xnire) +
                               ", " + Srelib.QStr(xrg) +
                               ", " + Srelib.QStr(xrguf) +
                               ", " + Srelib.QStr(xrgemissor) +
                               ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xrgemissao.ToString().Substring(0, 10))) +
                               ", " + Srelib.QStr(xestadocivil) +
                               ", " + Srelib.QStr(xregimecasamento) +
                               ", " + Srelib.QStr(xnacionalidade) +
                               ", " + Srelib.QStr(xprofissao) +
                               ", " + Srelib.QStr(xemail1) +
                               ", " + Srelib.QStr(xemail2) +
                               ", " + Srelib.QStr(xemail3) +
                               ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtnascimento.ToString().Substring(0, 10))) +
                               ", " + Srelib.QStr(xconjugenome) +
                               ", " + Srelib.QStr(xconjugesexo) +
                               ", " + Srelib.QStr(xconjugecpf) +
                               ", " + Srelib.QStr(xconjugerg) +
                               ", " + Srelib.QStr(xconjugerguf) +
                               ", " + Srelib.QStr(xconjugergemissor) +
                               ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xconjugergemissao.ToString().Substring(0, 10))) +
                               ", " + Srelib.QStr(xconjugenacionalidade) +
                               ", " + Srelib.QStr(xconjugeprofissao) +
                               ", " + Srelib.QStr(xconjugeemail1) +
                               ", " + Srelib.QStr(xconjugeemail2) +
                               ", " + Srelib.QStr(xconjugeemail3) +
                               ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xconjugedtnascimento.ToString().Substring(0, 10))) +
                               ", " + Srelib.QStr(xendereco) +
                               ", " + Srelib.QStr(xenderecores) +
                               ", " + Srelib.QStr(xenderecoresnumero) +
                               ", " + Srelib.QStr(xenderecorescomplem) +
                               ", " + Srelib.QStr(xbairrores) +
                               ", " + Srelib.QStr(xcidaderes) +
                               ", " + Srelib.QStr(xufres) +
                               ", " + Srelib.QStr(xcepres) +
                               ", " + Srelib.QStr(xfone1res) +
                               ", " + Srelib.QStr(xfone2res) +
                               ", " + Srelib.QStr(xfone3res) +
                               ", " + Srelib.QStr(xenderecocom) +
                               ", " + Srelib.QStr(xenderecocomnumero) +
                               ", " + Srelib.QStr(xenderecocomcomplem) +
                               ", " + Srelib.QStr(xbairrocom) +
                               ", " + Srelib.QStr(xcidadecom) +
                               ", " + Srelib.QStr(xufcom) +
                               ", " + Srelib.QStr(xcepcom) +
                               ", " + Srelib.QStr(xfone1com) +
                               ", " + Srelib.QStr(xfone2com) +
                               ", " + Srelib.QStr(xfone3com) +
                               ", " + xativo +
                               ", " + Srelib.forcaponto(Convert.ToString(xcomissaopermanencia)) +
                               ", " + xtabelaprice +
                               ", " + Srelib.forcaponto(Convert.ToString(xvalor_venda)) +
                               ", " + Srelib.forcaponto(Convert.ToString(xsinal)) +
                               ", " + Srelib.forcaponto(Convert.ToString(xsaldo)) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano1_parcelas_qtd)) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano1_parcelas_vlr)) +
                               ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xplano1_parcelas_vencimento.ToString().Substring(0, 10))) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano2_parcelas_qtd)) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano2_parcelas_vlr)) +
                               ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xplano2_parcelas_vencimento.ToString().Substring(0, 10))) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano3_parcelas_qtd)) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano3_parcelas_vlr)) +
                               ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xplano3_parcelas_vencimento.ToString().Substring(0, 10))) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano4_parcelas_qtd)) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano4_parcelas_vlr)) +
                               ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xplano4_parcelas_vencimento.ToString().Substring(0, 10))) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano5_parcelas_qtd)) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano5_parcelas_vlr)) +
                               ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xplano5_parcelas_vencimento.ToString().Substring(0, 10))) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano6_parcelas_qtd)) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano6_parcelas_vlr)) +
                               ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xplano6_parcelas_vencimento.ToString().Substring(0, 10))) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano7_parcelas_qtd)) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano7_parcelas_vlr)) +
                               ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xplano7_parcelas_vencimento.ToString().Substring(0, 10))) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano8_parcelas_qtd)) +
                               ", " + Srelib.forcaponto(Convert.ToString(xplano8_parcelas_vlr)) +
                               ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xplano8_parcelas_vencimento.ToString().Substring(0, 10))) +
                               ", " + Srelib.QStr(xobs) +
                               ", " + xcorretor +                               
                               ")";

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static string ProximaProposta()
    {
        string script;
        script = "SELECT MAX(proposta) + 1 ID FROM proposta WITH(NOLOCK)";
        string resultado = SreDblib.GetCampoScript(script);
        //
        if (resultado == "")
        {
            return "1";
        }
        else
        {
            return SreDblib.GetCampoScript(script);
        }
    }

    public uProposta()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}