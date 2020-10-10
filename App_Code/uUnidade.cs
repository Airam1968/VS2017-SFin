using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uUnidade
/// </summary>
public class uUnidade
{

    public static DataSet LookUpUnidade()
    {
        return SreDblib.GetDsScript("select apelido from produto_unidades");
    }

    public static ASPxComboBox MontaComboUnidade(ASPxComboBox pCombo)
    {
        //Documentação - Chamada da Função
        //
        //uBanco.MontaComboBanco(ASPxComboBox1);
        //
        //Fim Documentação - Chamada da Função


        return SreDblib.MontaCombo(pCombo, "produto_unidades", "apelido", "apelido", false, "");

    }

    public static String Grava(string xproduto,
                                string xgrupo,
                                string xunidade,
                                string xparte,
                                decimal xmetragem_total,
                                decimal xvlr_total,
                                decimal xvlr_1,
                                decimal xmetragem_1,
                                string xinscricao_1,
                                string xproprietario_1,
                                Int16 xquitado_1,
                                Int16 xescritura_1,
                                string xdtescritura_1,
                                string xcartorio_1,
                                string xlivro_1,
                                string xfolha_1,
                                Int16 xprocesso_1,
                                string xobs_1,
                                decimal xvlr_2,
                                decimal xmetragem_2,
                                string xinscricao_2,
                                string xproprietario_2,
                                Int16 xquitado_2,
                                Int16 xescritura_2,
                                string xdtescritura_2,
                                string xcartorio_2,
                                string xlivro_2,
                                string xfolha_2,
                                Int16 xprocesso_2,
                                string xobs_2,
                                decimal xarea_privativa_coletiva_m2,
                                decimal xarea_privativa_terraco_coberto_m2,
                                decimal xarea_privativa_terraco_descoberto_m2,
                                decimal xarea_comum_m2,
                                decimal xarea_garagem_m2,
                                decimal xarea_hobby_box_m2,
                                decimal xarea_total_m2,
                                decimal xfracao_ideal_m2,
                                decimal xfracao_ideal_percentual,
                                string xhobby_box_numero,
                                string xhobby_box_localizacao,
                                string xnumero_garagem_01,
                                string xnumero_garagem_02,
                                string xnumero_garagem_03,
                                string xnumero_garagem_04,
                                string xnumero_garagem_05,
                                string xvagas_localizacao,
                                Int16 xvagas_quantidade)
    {

        if (xproduto != String.Empty)
        {
            string script = "INSERT INTO produto_unidades VALUES ( " +
                            Srelib.QStr(xproduto) +
                            ", " + Srelib.QStr(xgrupo) +
                            ", " + Srelib.QStr(xunidade) +
                            ", " + Srelib.QStr(xparte) +
                            ", " + Srelib.forcaponto(Convert.ToString(xmetragem_total)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_total)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_1)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xmetragem_1)) +
                            ", " + Srelib.QStr(xinscricao_1) +
                            ", " + Srelib.QStr(xproprietario_1) +
                            ", " + (xquitado_1) +
                            ", " + (xescritura_1) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtescritura_1)) +
                            ", " + Srelib.QStr(xcartorio_1) +
                            ", " + Srelib.QStr(xlivro_1) +
                            ", " + Srelib.QStr(xfolha_1) +
                            ", " + (xprocesso_1) +
                            ", " + Srelib.QStr(xobs_1) +
                            ", " + Srelib.forcaponto(Convert.ToString(xvlr_2)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xmetragem_2)) +
                            ", " + Srelib.QStr(xinscricao_2) +
                            ", " + Srelib.QStr(xproprietario_2) +
                            ", " + (xquitado_2) +
                            ", " + (xescritura_2) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtescritura_2)) +
                            ", " + Srelib.QStr(xcartorio_2) +
                            ", " + Srelib.QStr(xlivro_2) +
                            ", " + Srelib.QStr(xfolha_2) +
                            ", " + (xprocesso_2) +
                            ", " + Srelib.QStr(xobs_2) +
                            ", " + Srelib.forcaponto(Convert.ToString(xarea_privativa_coletiva_m2)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xarea_privativa_terraco_coberto_m2)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xarea_privativa_terraco_descoberto_m2)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xarea_comum_m2)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xarea_garagem_m2)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xarea_hobby_box_m2)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xarea_total_m2)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xfracao_ideal_m2)) +
                            ", " + Srelib.forcaponto(Convert.ToString(xfracao_ideal_percentual)) +
                            ", " + Srelib.QStr(xhobby_box_numero) +
                            ", " + Srelib.QStr(xhobby_box_localizacao) +
                            ", " + Srelib.QStr(xnumero_garagem_01) +
                            ", " + Srelib.QStr(xnumero_garagem_02) +
                            ", " + Srelib.QStr(xnumero_garagem_03) +
                            ", " + Srelib.QStr(xnumero_garagem_04) +
                            ", " + Srelib.QStr(xnumero_garagem_05) +
                            ", " + Srelib.QStr(xvagas_localizacao) +
                            ", " + (xvagas_quantidade) +
                            ", " + "0" +
                            ", " + "0" +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString("01/01/1900"))) +
                            ", " + "0" +
                            ", " + "0" +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString("01/01/1900"))) +
                            ", " + "0" +
                            ", " + "0" +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString("01/01/1900"))) +
                            ", " + "0" +
                            ", " + "0" +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString("01/01/1900"))) +
                            ", " + "0" +
                            ", " + "0" +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString("01/01/1900"))) +
                            ", " + "0" +
                            ", " + "0" +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString("01/01/1900"))) +
                           " ) ";

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }


    public static String Altera(string xID,
                                string xproduto,
                                string xgrupo,
                                string xunidade,
                                string xparte,
                                decimal xmetragem_total,
                                decimal xvlr_total,
                                decimal xvlr_1,
                                decimal xmetragem_1,
                                string xinscricao_1,
                                string xproprietario_1,
                                Int16 xquitado_1,
                                Int16 xescritura_1,
                                string xdtescritura_1,
                                string xcartorio_1,
                                string xlivro_1,
                                string xfolha_1,
                                Int16 xprocesso_1,
                                string xobs_1,
                                decimal xvlr_2,
                                decimal xmetragem_2,
                                string xinscricao_2,
                                string xproprietario_2,
                                Int16 xquitado_2,
                                Int16 xescritura_2,
                                string xdtescritura_2,
                                string xcartorio_2,
                                string xlivro_2,
                                string xfolha_2,
                                Int16 xprocesso_2,
                                string xobs_2,
                                decimal xarea_privativa_coletiva_m2,
                                decimal xarea_privativa_terraco_coberto_m2,
                                decimal xarea_privativa_terraco_descoberto_m2,
                                decimal xarea_comum_m2,
                                decimal xarea_garagem_m2,
                                decimal xarea_hobby_box_m2,
                                decimal xarea_total_m2,
                                decimal xfracao_ideal_m2,
                                decimal xfracao_ideal_percentual,
                                string xhobby_box_numero,
                                string xhobby_box_localizacao,
                                string xnumero_garagem_01,
                                string xnumero_garagem_02,
                                string xnumero_garagem_03,
                                string xnumero_garagem_04,
                                string xnumero_garagem_05,
                                string xvagas_localizacao,
                                Int16 xvagas_quantidade)        
    {

        if (xID != String.Empty)
        {
            string script = "UPDATE PRODUTO_UNIDADES SET " +
                //" produto = " + Srelib.QStr(xproduto) +
                //" grupo = " + Srelib.QStr(xgrupo) +
                //" unidade = " + Srelib.QStr(xunidade) +
                            " parte = " + Srelib.QStr(xparte) +
                            " ,metragem_total = " + Srelib.forcaponto(Convert.ToString(xmetragem_total)) +
                            " ,vlr_total = " + Srelib.forcaponto(Convert.ToString(xvlr_total)) +
                            " ,vlr_1 = " + Srelib.forcaponto(Convert.ToString(xvlr_1)) +
                            " ,metragem_1 = " + Srelib.forcaponto(Convert.ToString(xmetragem_1)) +
                            " ,inscricao_1 = " + Srelib.QStr(xinscricao_1) +
                            " ,proprietario_1 = " + Srelib.QStr(xproprietario_1) +
                //" quitado_1 = " + (xquitado_1) +
                            " ,escritura_1 = " + (xescritura_1) +
                            " ,dtescritura_1 = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtescritura_1)) +
                            " ,cartorio_1 = " + Srelib.QStr(xcartorio_1) +
                            " ,livro_1 = " + Srelib.QStr(xlivro_1) +
                            " ,folha_1 = " + Srelib.QStr(xfolha_1) +
                            " ,processo_1 = " + (xprocesso_1) +
                            " ,obs_1 = " + Srelib.QStr(xobs_1) +
                            " ,vlr_2 = " + Srelib.forcaponto(Convert.ToString(xvlr_2)) +
                            " ,metragem_2 = " + Srelib.forcaponto(Convert.ToString(xmetragem_2)) +
                            " ,inscricao_2 = " + Srelib.QStr(xinscricao_2) +
                            " ,proprietario_2 = " + Srelib.QStr(xproprietario_2) +
                //" quitado_2 = " + (xquitado_2) +
                            " ,escritura_2 = " + (xescritura_2) +
                            " ,dtescritura_2 = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtescritura_2)) +
                            " ,cartorio_2 = " + Srelib.QStr(xcartorio_2) +
                            " ,livro_2 = " + Srelib.QStr(xlivro_2) +
                            " ,folha_2 = " + Srelib.QStr(xfolha_2) +
                            " ,processo_2 = " + (xprocesso_2) +
                            " ,obs_2 = " + Srelib.QStr(xobs_2) +
                            " ,area_privativa_coletiva_m2 = " + Srelib.forcaponto(Convert.ToString(xarea_privativa_coletiva_m2)) +
                            " ,area_privativa_terraco_coberto_m2 = " + Srelib.forcaponto(Convert.ToString(xarea_privativa_terraco_coberto_m2)) +
                            " ,area_privativa_terraco_descoberto_m2 = " + Srelib.forcaponto(Convert.ToString(xarea_privativa_terraco_descoberto_m2)) +
                            " ,area_comum_m2 = " + Srelib.forcaponto(Convert.ToString(xarea_comum_m2)) +
                            " ,area_garagem_m2 = " + Srelib.forcaponto(Convert.ToString(xarea_garagem_m2)) +
                            " ,area_hobby_box_m2 = " + Srelib.forcaponto(Convert.ToString(xarea_hobby_box_m2)) +
                            " ,area_total_m2 = " + Srelib.forcaponto(Convert.ToString(xarea_total_m2)) +
                            " ,fracao_ideal_m2 = " + Srelib.forcaponto(Convert.ToString(xfracao_ideal_m2)) +
                            " ,fracao_ideal_percentual = " + Srelib.forcaponto(Convert.ToString(xfracao_ideal_percentual)) +
                            " ,hobby_box_numero = " + Srelib.QStr(xhobby_box_numero) + 
                            " ,hobby_box_localizacao = " + Srelib.QStr(xhobby_box_localizacao) +
                            " ,numero_garagem_01 = " + Srelib.QStr(xnumero_garagem_01)  +
                            " ,numero_garagem_02 = " + Srelib.QStr(xnumero_garagem_02)  +
                            " ,numero_garagem_03 = " + Srelib.QStr(xnumero_garagem_03)  +
                            " ,numero_garagem_04 = " + Srelib.QStr(xnumero_garagem_04)  +
                            " ,numero_garagem_05 = " + Srelib.QStr(xnumero_garagem_05)  +
                            " ,vagas_localizacao = " + Srelib.QStr(xvagas_localizacao)  +
                            " ,vagas_quantidade = " + xvagas_quantidade +
                            " where ID =" + xID;

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String Exclui(string xproduto,
                                string xgrupo)
    {

        if (xproduto != String.Empty)
        {
            string script = "DELETE produto_unidades  " +
                            " WHERE PRODUTO =  " + xproduto +
                            " AND GRUPO =  " + xgrupo;


            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String PegaIDCliente(string xproduto,
                                       string xgrupo,
                                       string xunidade,
                                       string xparte,
                                       string xproprietario)
    {
        string script = "";
        if (xproprietario == "1")
        {
            script = "SELECT proprietario_1 FROM Produto_unidades WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = " + xparte;
        }
        else
        {
            script = "SELECT proprietario_2 FROM Produto_unidades WITH(NOLOCK) WHERE " +
                " produto = " + xproduto +
                " and " +
                " grupo = " + xgrupo +
                " and " +
                " unidade = " + xunidade +
                " and " +
                " parte = 1 ";
        }

        try
        {
            return SreDblib.GetCampoScript(script);
        }
        catch
        {
            return "";
        }
    }

    public static String AlteraUnidadeVenda(string xproduto,
                                            string xgrupo,
                                            string xunidade,
                                            string xparte,
                                            decimal xvlr_total,
                                            decimal xvlr_1,
                                            string xproprietario_1,
                                            decimal xvlr_2,
                                            string xproprietario_2)
    {
        string script = "";
        if (xparte == "0" || xparte == "1")
        {
            script = "UPDATE PRODUTO_UNIDADES SET " +
                     " vlr_total = " + Srelib.forcaponto(Convert.ToString(xvlr_total)) +
                     " ,vlr_1 = " + Srelib.forcaponto(Convert.ToString(xvlr_1)) +
                     " ,proprietario_1 = " + xproprietario_1 +
                     " where " +
                     " produto = " + Srelib.QStr(xproduto) +
                     " and grupo = " + Srelib.QStr(xgrupo) +
                     " and unidade = " + Srelib.QStr(xunidade) +
                     " and parte = " + Srelib.QStr(xparte);

            SreDblib.ExecScript(script);
        }
        if (xparte == "2")
        {
            script = "UPDATE PRODUTO_UNIDADES SET " +
                     " vlr_2 = " + Srelib.forcaponto(Convert.ToString(xvlr_2)) +
                     " ,proprietario_2 = " + xproprietario_2 +
                     " where " +
                     " produto = " + Srelib.QStr(xproduto) +
                     " and grupo = " + Srelib.QStr(xgrupo) +
                     " and unidade = " + Srelib.QStr(xunidade) +
                     " and parte = " + Srelib.QStr("1");

            SreDblib.ExecScript(script);
        }
        
        return " ";
    }


    public uUnidade()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}