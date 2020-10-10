using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DevExpress.Web.ASPxEditors;

/// <summary>
/// Summary description for uProduto
/// </summary>
public class uProduto
{
    public static DataSet LookUpProduto()
    {
        if ((SreDblib.GetParametro("ORDEM PRODUTO") != "CODIGO") && (SreDblib.GetParametro("ORDEM PRODUTO") != "CÓDIGO"))
        {
            return SreDblib.GetDsScript("select descricao from produto with (nolock) order BY DESCRICAO ");
        }
        else
        {
            return SreDblib.GetDsScript("select descricao from produto with (nolock) order BY ID ");
        }
    }


    public static ASPxComboBox MontaComboProduto(ASPxComboBox pCombo, Boolean pativo)
    {
        if ((SreDblib.GetParametro("ORDEM PRODUTO") != "CODIGO") && (SreDblib.GetParametro("ORDEM PRODUTO") != "CÓDIGO"))
        {
            if (pativo)
                return SreDblib.MontaCombo(pCombo, "produto", "descricao", "ID", true, " where ativo = 1 order by DESCRICAO ");
            else
                return SreDblib.MontaCombo(pCombo, "produto", "descricao", "ID", true, " order by DESCRICAO ");
        }
        else
        {
            if (pativo)
                return SreDblib.MontaCombo(pCombo, "produto", "descricao", "ID", true, " where ativo = 1 order by ID ");
            else
                return SreDblib.MontaCombo(pCombo, "produto", "descricao", "ID", true, " order by ID ");
        }
    }

    public static ASPxComboBox MontaComboGrupo(ASPxComboBox pCombo, string pProduto, Boolean pativo)
    {

        if (pativo)
            return SreDblib.MontaCombo(pCombo, "produto_grupo", "descricao", "grupo", true, " WHERE ativo = 1 and PRODUTO = " + pProduto + " order by produto, grupo ");
        else
            return SreDblib.MontaCombo(pCombo, "produto_grupo", "descricao", "grupo", true, " WHERE ativo = 0 and PRODUTO = " + pProduto + " order by produto, grupo ");

    }


    public static ASPxComboBox MontaComboUnidades(ASPxComboBox pCombo, string pProduto, string pGrupo, Boolean pVendido)
    {
        //Ativos

        if (pVendido)
        {
            //Vendidos
            return SreDblib.MontaCombo(pCombo, "produto_unidades", "parte", "unidade", true,
                " WHERE PRODUTO = " + pProduto +
                " AND GRUPO = " + pGrupo +
                " AND ((parte = 0 and proprietario_1 <> 1) " +
                " OR (parte = 1 and (proprietario_1 <> 1) " +
                " OR (parte = 1 and proprietario_2 <> 1))) " +
                " order by unidade");
        }
        else
        {
            //Disponíveis
            return SreDblib.MontaCombo(pCombo, "produto_unidades", "parte", "unidade", true,
                " WHERE PRODUTO = " + pProduto +
                " AND GRUPO = " + pGrupo +
                " AND ((parte = 0 and proprietario_1 = 1) " +
                " OR (parte = 1 and (proprietario_1 = 1) " +
                " OR (parte = 1 and proprietario_2 = 1))) " +
                " order by unidade");
        }

    }

    public static ASPxComboBox MontaComboUnidadesTodas(ASPxComboBox pCombo, string pProduto, string pGrupo)
    {
        //Ativos

        return SreDblib.MontaCombo(pCombo, "produto_unidades", "parte", "unidade", true,
            " WHERE PRODUTO = " + pProduto +
            " AND GRUPO = " + pGrupo +
            " order by unidade");

    }

    public static ASPxComboBox MontaComboGrupoTipo(ASPxComboBox pCombo, string pTipo)
    {
        return SreDblib.MontaCombo(pCombo, "produto_grupo", "descricao", "grupo", true, " WHERE GRUPO_TIPO = " + pTipo);
    }

    public static DataSet PegaDadosProduto(Int32 xID)
    {
        string script;

        if ((SreDblib.GetParametro("ORDEM PRODUTO") != "CODIGO") || (SreDblib.GetParametro("ORDEM PRODUTO") != "CÓDIGO"))
        {
            if (xID == 0)
            {
                script = "SELECT * FROM produto WITH(NOLOCK) order by descricao";
            }
            else
            {
                script = "SELECT * FROM produto WITH(NOLOCK) WHERE id = " + Convert.ToString(xID) + " order by descricao";
            }
        }
        else
        {
            if (xID == 0)
            {
                script = "SELECT * FROM produto WITH(NOLOCK) order by ID";
            }
            else
            {
                script = "SELECT * FROM produto WITH(NOLOCK) WHERE id = " + Convert.ToString(xID) + " order by ID";
            }
        }
        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosProdutoID(Int32 xID)
    {
        //Forçando a ordem por ID
        string script;

        if (xID == 0)
        {
            script = "SELECT * FROM produto WITH(NOLOCK) order by ID";
        }
        else
        {
            script = "SELECT * FROM produto WITH(NOLOCK) WHERE id = " + Convert.ToString(xID) + " order by ID";
        }
        return SreDblib.GetDsScript(script);
    }

    public static DataSet PegaDadosProdutoGrupo(Int32 xID, string xAtivo)
    {
        string script;

        if (xID == 0)
        {
            if (xAtivo != "")
            {
                if (xAtivo == "1")
                {
                    script = "SELECT * FROM produto_grupo WITH(NOLOCK) WHERE ATIVO = 1 order by produto, grupo";
                }
                else
                {
                    script = "SELECT * FROM produto_grupo WITH(NOLOCK) WHERE ATIVO = 0 order by produto, grupo";
                }
            }
            else
            {
                script = "SELECT * FROM produto_grupo WITH(NOLOCK) order by produto, grupo";
            }
        }
        else
        {
            if (xAtivo != "")
            {
                if (xAtivo == "1")
                {
                    script = "SELECT * FROM produto_grupo WITH(NOLOCK) WHERE produto = " + Convert.ToString(xID) + " AND ATIVO = 1 order by produto, grupo";
                }
                else
                {
                    script = "SELECT * FROM produto_grupo WITH(NOLOCK) WHERE produto = " + Convert.ToString(xID) + " AND ATIVO = 0 order by produto, grupo";
                }
            }
            else
            {
                script = "SELECT * FROM produto_grupo WITH(NOLOCK) WHERE produto = " + Convert.ToString(xID) + " order by produto, grupo";
            }

        }


        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosProdutoTipo(Int32 xID)
    {
        string script;

        if (xID == 0)
        {
            script = "SELECT * FROM produto_tipo WITH(NOLOCK) order by ID";
        }
        else
        {
            script = "SELECT * FROM produto_tipo WITH(NOLOCK) WHERE id = " + Convert.ToString(xID) + " order by ID";
        }

        return SreDblib.GetDsScript(script);

    }


    public static string PegaProdutoConta(Int32 xID)
    {
        string script;

        if (xID == 0)
        {
            script = "SELECT Conta FROM produto WITH(NOLOCK) order by ID";
        }
        else
        {
            script = "SELECT Conta FROM produto WITH(NOLOCK) WHERE id = " + Convert.ToString(xID);
        }

        return Convert.ToString(SreDblib.GetCampoScript(script));

    }

    public static DataSet PegaDadosProdutoUnidades(string xproduto,
                                                   string xgrupo,
                                                   string xsituacaovenda,
                                                   string xsituacaoquitacao,
                                                   string xsituacaoprocesso)
    {
        string script;

        if (xproduto == string.Empty)
        {
            script = "SELECT p.*,c.nome nome_proprietario_1, c.cnpj cnpj_proprietario_1, c.rg rg_proprietario_1, " +
                     "c.enderecores, c.enderecoresnumero, c.enderecorescomplem, c.bairrores, c.cidaderes, c.ufres, c.cepres, " +
                     "c.fone1res, c.fone2res,  " +
                     "c.enderecocom, c.enderecocomnumero, c.enderecocomcomplem, c.bairrocom, c.cidadecom, c.ufcom, c.cepcom,  " +
                     "c.fone1com, c.fone2com,  " +
                     "situacao = ( " +
                     "   CASE " +
                     "     WHEN p.escritura_1 > 0" +
                     "      THEN (" + Srelib.QStr("Data: ") + "+" + "CONVERT(varchar(10), p.dtescritura_1, 103)" + "+" +
                                 Srelib.QStr(" - ") + "+" + Srelib.QStr("Cartório: ") + "+" + "p.cartorio_1" + "+" +
                                 Srelib.QStr(" - ") + "+" + Srelib.QStr("Livro: ") + "+" + "p.livro_1" + "+" +
                                 Srelib.QStr(" - ") + "+" + Srelib.QStr("Folha: ") + "+" + "p.folha_1)" +
                     "      ELSE " + Srelib.QStr("Compromissário") + " " +
                     "   END ) " +
                     "FROM produto_unidades p " +
                     "INNER JOIN contato c ON (p.proprietario_1 = c.ID) " +
                     "WHERE p.proprietario_1 <> 0  ";
            if (xsituacaovenda == "1")
            {
                script = script + "AND p.proprietario_1 <> 1 ";
            }
            if (xsituacaovenda == "2")
            {
                script = script + "AND p.proprietario_1 = 1 ";
            }
            if (xsituacaoquitacao == "1") //quitados
            {
                script = script + "AND p.quitado_1 = 1 ";
            }
            if (xsituacaoquitacao == "2") //não quitados
            {
                script = script + "AND p.quitado_1 <> 1 ";
            }
            if (xsituacaoprocesso == "1") //em processo
            {
                script = script + "AND p.processo_1 = 1 ";
            }
            if (xsituacaoprocesso == "2") //sem processo
            {
                script = script + "AND p.processo_1 <> 1 ";
            }
            script = script + "order by produto, grupo, unidade ";


        }
        else
        {
            if (xgrupo == string.Empty)
            {
                script = "SELECT p.*,c.nome nome_proprietario_1, c.cnpj cnpj_proprietario_1, c.rg rg_proprietario_1, " +
                         "c.enderecores, c.enderecoresnumero, c.enderecorescomplem, c.bairrores, c.cidaderes, c.ufres, c.cepres, " +
                         "c.fone1res, c.fone2res,  " +
                         "c.enderecocom, c.enderecocomnumero, c.enderecocomcomplem, c.bairrocom, c.cidadecom, c.ufcom, c.cepcom,  " +
                         "c.fone1com, c.fone2com,  " +
                         "situacao = ( " +
                         "   CASE " +
                         "     WHEN p.escritura_1 > 0" +
                         "      THEN (" + Srelib.QStr("Data: ") + "+" + "CONVERT(varchar(10), p.dtescritura_1, 103)" + "+" +
                                     Srelib.QStr(" - ") + "+" + Srelib.QStr("Cartório: ") + "+" + "p.cartorio_1" + "+" +
                                     Srelib.QStr(" - ") + "+" + Srelib.QStr("Livro: ") + "+" + "p.livro_1" + "+" +
                                     Srelib.QStr(" - ") + "+" + Srelib.QStr("Folha: ") + "+" + "p.folha_1)" +
                         "      ELSE " + Srelib.QStr("Compromissário") + " " +
                         "   END ) " +
                         "FROM produto_unidades p " +
                         "INNER JOIN contato c ON (p.proprietario_1 = c.ID) " +
                         "WHERE p.Produto = " + xproduto + " " +
                         "AND p.proprietario_1 <> 0  ";
                if (xsituacaovenda == "1")
                {
                    script = script + "AND p.proprietario_1 <> 1 ";
                }
                if (xsituacaovenda == "2")
                {
                    script = script + "AND p.proprietario_1 = 1 ";
                }
                if (xsituacaoquitacao == "1") //quitados
                {
                    script = script + "AND p.quitado_1 = 1 ";
                }
                if (xsituacaoquitacao == "2") //não quitados
                {
                    script = script + "AND p.quitado_1 <> 1 ";
                }
                if (xsituacaoprocesso == "1") //em processo
                {
                    script = script + "AND p.processo_1 = 1 ";
                }
                if (xsituacaoprocesso == "2") //sem processo
                {
                    script = script + "AND p.processo_1 <> 1 ";
                }
                script = script + "order by produto, grupo, unidade ";
            }
            else
            {
                script = "SELECT p.*,c.nome nome_proprietario_1, c.cnpj cnpj_proprietario_1, c.rg rg_proprietario_1, " +
                         "c.enderecores, c.enderecoresnumero, c.enderecorescomplem, c.bairrores, c.cidaderes, c.ufres, c.cepres, " +
                         "c.fone1res, c.fone2res,  " +
                         "c.enderecocom, c.enderecocomnumero, c.enderecocomcomplem, c.bairrocom, c.cidadecom, c.ufcom, c.cepcom,  " +
                         "c.fone1com, c.fone2com,  " +
                         "situacao = ( " +
                         "   CASE " +
                         "     WHEN p.escritura_1 > 0" +
                         "      THEN (" + Srelib.QStr("Data: ") + "+" + "CONVERT(varchar(10), p.dtescritura_1, 103)" + "+" +
                                     Srelib.QStr(" - ") + "+" + Srelib.QStr("Cartório: ") + "+" + "p.cartorio_1" + "+" +
                                     Srelib.QStr(" - ") + "+" + Srelib.QStr("Livro: ") + "+" + "p.livro_1" + "+" +
                                     Srelib.QStr(" - ") + "+" + Srelib.QStr("Folha: ") + "+" + "p.folha_1)" +
                         "      ELSE " + Srelib.QStr("Compromissário") + " " +
                         "   END ) " +
                         "FROM produto_unidades p " +
                         "INNER JOIN contato c ON (p.proprietario_1 = c.ID) " +
                         "WHERE p.Produto = " + xproduto + " " +
                         " AND Grupo = " + xgrupo + " " +
                         "AND p.proprietario_1 <> 0  ";
                if (xsituacaovenda == "1")
                {
                    script = script + "AND p.proprietario_1 <> 1 ";
                }
                if (xsituacaovenda == "2")
                {
                    script = script + "AND p.proprietario_1 = 1 ";
                }
                if (xsituacaoquitacao == "1") //quitados
                {
                    script = script + "AND p.quitado_1 = 1 ";
                }
                if (xsituacaoquitacao == "2") //não quitados
                {
                    script = script + "AND p.quitado_1 <> 1 ";
                }
                if (xsituacaoprocesso == "1") //em processo
                {
                    script = script + "AND p.processo_1 = 1 ";
                }
                if (xsituacaoprocesso == "2") //sem processo
                {
                    script = script + "AND p.processo_1 <> 1 ";
                }
                script = script + "order by produto, grupo, unidade ";
            }

        }

        return SreDblib.GetDsScript(script);

    }

    public static Int32 PegaProdutoGrupoQuantidade(Int32 xProduto, Int32 xgrupo)
    {
        string script;

        script = " SELECT quantidade FROM produto_grupo WITH(NOLOCK) " +
                 " WHERE produto = " + Convert.ToString(xProduto) +
                 " and grupo = " + Convert.ToString(xgrupo);

        return Convert.ToInt32(SreDblib.GetCampoScript(script));

    }

    public static String PegaProdutoGrupoDescricao(Int32 xProduto, Int32 xgrupo)
    {
        string script;

        script = " SELECT descricao FROM produto_grupo WITH(NOLOCK) " +
                 " WHERE produto = " + Convert.ToString(xProduto) +
                 " and grupo = " + Convert.ToString(xgrupo);

        return Convert.ToString(SreDblib.GetCampoScript(script));

    }

    public static string PegaProdutoDescricao(Int32 xTipo)
    {
        string script;

        script = " SELECT descricao FROM produto WITH(NOLOCK) " +
                 " WHERE ID = " + Convert.ToString(xTipo);

        return Convert.ToString(SreDblib.GetCampoScript(script));

    }

    public static string PegaProdutoTipoDescricao(Int32 xTipo)
    {
        string script;

        script = " SELECT unidade FROM produto_tipo WITH(NOLOCK) " +
                 " WHERE ID = " + Convert.ToString(xTipo);

        return Convert.ToString(SreDblib.GetCampoScript(script));

    }

    public static string PegaTipoProdutoDescricao(Int32 xProduto)
    {
        string script;

        script = " SELECT tipo FROM produto WITH(NOLOCK) " +
                 " WHERE ID = " + Convert.ToString(xProduto);

        string xTipo = Convert.ToString(SreDblib.GetCampoScript(script));

        script = " SELECT unidade FROM produto_tipo WITH(NOLOCK) " +
                 " WHERE ID = " + Convert.ToString(xTipo);

        return Convert.ToString(SreDblib.GetCampoScript(script));

    }

    public static String PegaTipo(Int32 xProduto)
    {

        string script = "SELECT TIPO from produto where ID = " + Convert.ToString(xProduto).Trim();

        return SreDblib.GetCampoScript(script);

    }

    public static String PegaDataHabitese(Int32 xProduto)
    {

        string script = "SELECT HABITESE from produto where ID = " + Convert.ToString(xProduto).Trim();

        return SreDblib.GetCampoScript(script);

    }

    public static String Grava(string xnumproduto,
                                string xtipo,
                                string xdescricao,
                                string xconta,
                                string xcnpj,
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
                                string xemail1,
                                string xemail2,
                                string xemail3,
                                string xarea,
                                string xsituacao_obra,
                                DateTime xhabitese,
                                decimal xcub,
                                string xobs1,
                                string xobs2,
                                string xobs3,
                                string xobs4,
                                string xobs5,
                                Boolean xativo,
                                string xcodpis)
    {

        if (xdescricao != String.Empty)
        {

            string script = "INSERT INTO PRODUTO VALUES ( " +
                            xnumproduto +
                            ", " + Srelib.QStr(xtipo) +
                            ", " + Srelib.QStr(xdescricao) +
                            ", " + Srelib.QStr(xconta) +
                            ", " + Srelib.QStr(xcnpj) +
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
                            ", " + Srelib.QStr(xemail1) +
                            ", " + Srelib.QStr(xemail2) +
                            ", " + Srelib.QStr(xemail3) +
                            ", " + Srelib.QStr(xarea) +
                            ", " + Srelib.QStr(xsituacao_obra) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xhabitese))) +
                            ", " + Srelib.forcaponto(Convert.ToString(xcub)) +
                            ", " + Srelib.QStr(xobs1) +
                            ", " + Srelib.QStr(xobs2) +
                            ", " + Srelib.QStr(xobs3) +
                            ", " + Srelib.QStr(xobs4) +
                            ", " + Srelib.QStr(xobs5) +
                            ", " + Convert.ToString(Convert.ToInt16(xativo)) +
                            ", " + Srelib.QStr(xcodpis) +
                            " ) ";

            //Inserir se não existe

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String GravaTipo(string xnumtipo,
                                   string xdescricao,
                                   string xproduto,
                                   string xgrupo,
                                   string xunidade)
    {

        if (xdescricao != String.Empty)
        {

            string script = "INSERT INTO PRODUTO_TIPO VALUES ( " +
                            xnumtipo +
                            ", " + Srelib.QStr(xdescricao) +
                            ", " + Srelib.QStr(xproduto) +
                            ", " + Srelib.QStr(xgrupo) +
                            ", " + Srelib.QStr(xunidade) +
                            " ) ";

            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String GravaGrupo(string xproduto,
                                    string xgrupo,
                                    string xgrupo_tipo,
                                    string xdescricao,
                                    string xquantidade,
                                    string xnum_inicial,
                                    string xnum_final,
                                    Boolean xativo,
                                    DateTime xdtbase_vlr_venda,
                                    string xvlr_venda,
                                    string xobserva_1,
                                    string xobserva_2)
    {

        if (xdescricao != String.Empty)
        {

            if (xvlr_venda == String.Empty)
                xvlr_venda = "0";

            string script = "INSERT INTO PRODUTO_GRUPO VALUES ( " +
                            Srelib.QStr(xproduto) +
                            ", " + Srelib.QStr(xgrupo) +
                            ", " + Srelib.QStr(xgrupo_tipo) +
                            ", " + Srelib.QStr(xdescricao) +
                            ", " + xquantidade +
                            ", " + xnum_inicial +
                            ", " + xnum_final +
                            ", " + Convert.ToString(Convert.ToInt16(xativo)) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtbase_vlr_venda))) +
                            ", " + Srelib.forcaponto(xvlr_venda) +
                            ", " + Srelib.QStr(xobserva_1) +
                            ", " + Srelib.QStr(xobserva_2) +
                            " ) ";

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String AlteraGrupo(string xID,
                                    string xproduto,
                                    string xgrupo,
                                    string xgrupo_tipo,
                                    string xdescricao,
                                    string xquantidade,
                                    string xnum_inicial,
                                    string xnum_final,
                                    Boolean xativo,
                                    DateTime xdtbase_vlr_venda,
                                    string xvlr_venda,
                                    string xobserva_1,
                                    string xobserva_2)
    {

        if (xdescricao != String.Empty)
        {

            if (xvlr_venda == String.Empty)
                xvlr_venda = "0";

            string script = "UPDATE PRODUTO_GRUPO SET " +
                            " produto = " + Srelib.QStr(xproduto) +
                            " ,grupo = " + Srelib.QStr(xgrupo) +
                            " ,grupo_tipo = " + Srelib.QStr(xgrupo_tipo) +
                            " ,descricao = " + Srelib.QStr(xdescricao) +
                            " ,quantidade = " + xquantidade +
                            " ,num_inicio = " + xnum_inicial +
                            " ,num_final = " + xnum_final +
                            " ,ativo = " + Convert.ToString(Convert.ToInt16(xativo)) +
                            " ,dtbase_vlr_venda = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdtbase_vlr_venda))) +
                            " ,vlr_venda = " + Srelib.forcaponto(xvlr_venda) +
                            " ,observa_1 = " + Srelib.QStr(xobserva_1) +
                            " ,observa_2 = " + Srelib.QStr(xobserva_2) +
                            " where ID =" + xID;


            //" where nome=" + Rgblib.QStr(pParametro);

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String ExcluiGrupo(string xID)
    {

        string script = "DELETE PRODUTO_GRUPO where ID =" + xID + " AND ATIVO = 0 ";

        SreDblib.ExecScript(script);

        return " ";
    }


    public static String Altera(string xID,
                                string xtipo,
                                string xdescricao,
                                string xconta,
                                string xcnpj,
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
                                string xemail1,
                                string xemail2,
                                string xemail3,
                                string xarea,
                                string xsituacao_obra,
                                DateTime xhabitese,
                                decimal xcub,
                                string xobs1,
                                string xobs2,
                                string xobs3,
                                string xobs4,
                                string xobs5,
                                Boolean xativo,
                                string xcodpis)
    {

        string script = "UPDATE PRODUTO SET " +
                        " descricao = " + Srelib.QStr(xdescricao) +
                        " ,conta = " + Srelib.QStr(xconta) +
                        " ,cnpj = " + Srelib.QStr(xcnpj) +
                        " ,enderecocom = " + Srelib.QStr(xenderecocom) +
                        " ,enderecocomnumero = " + Srelib.QStr(xenderecocomnumero) +
                        " ,enderecocomcomplem = " + Srelib.QStr(xenderecocomcomplem) +
                        " ,bairrocom = " + Srelib.QStr(xbairrocom) +
                        " ,cidadecom = " + Srelib.QStr(xcidadecom) +
                        " ,ufcom = " + Srelib.QStr(xufcom) +
                        " ,cepcom = " + Srelib.QStr(xcepcom) +
                        " ,fone1com = " + Srelib.QStr(xfone1com) +
                        " ,fone2com = " + Srelib.QStr(xfone2com) +
                        " ,fone3com = " + Srelib.QStr(xfone3com) +
                        " ,email1 = " + Srelib.QStr(xemail1) +
                        " ,email2 = " + Srelib.QStr(xemail2) +
                        " ,email3 = " + Srelib.QStr(xemail3) +
                        " ,area = " + Srelib.QStr(xarea) +
                        " ,situacao_obra = " + Srelib.QStr(xsituacao_obra) +
                        " ,habitese = " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xhabitese))) +
                        " ,cub = " + Srelib.forcaponto(Convert.ToString(xcub)) +
                        " ,obs1 = " + Srelib.QStr(xobs1) +
                        " ,obs2 = " + Srelib.QStr(xobs2) +
                        " ,obs3 = " + Srelib.QStr(xobs3) +
                        " ,obs4 = " + Srelib.QStr(xobs4) +
                        " ,obs5 = " + Srelib.QStr(xobs5) +
                        " ,ativo = " + Convert.ToInt16(Convert.ToInt16(xativo)) +
                        " ,codpis = " + Srelib.QStr(xcodpis) +
                        " where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String Exclui(string xID)
    {

        string script = "DELETE PRODUTO where ID =" + xID + " AND ATIVO = 0 ";

        SreDblib.ExecScript(script);

        return " ";
    }


    public static String AlteraTipo(string xID,
                                    string xproduto,
                                    string xdescricao,
                                    string xgrupo,
                                    string xunidade)
    {

        string script = "UPDATE PRODUTO_TIPO SET " +
                        " descricao = " + Srelib.QStr(xdescricao) +
                        " ,grupo = " + Srelib.QStr(xgrupo) +
                        " ,unidade = " + Srelib.QStr(xunidade) +
                        " where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String AlteraProdutoCadastro(string xproduto,
                                               Boolean xCadastro)
    {

        string script = "UPDATE PRODUTO SET " +
                        " ativo = " + Convert.ToInt16(xCadastro) +
                        " where ID =" + Srelib.QStr(xproduto);

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String AlteraGrupoCadastro(string xproduto,
                                             string xgrupo,
                                             Boolean xCadastro)
    {

        string script = "UPDATE PRODUTO_GRUPO SET " +
                        " ativo = " + Convert.ToInt16(xCadastro) +
                        " where produto =" + Srelib.QStr(xproduto) +
                        " and grupo = " + Srelib.QStr(xgrupo);

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String ExcluiTipo(string xID)
    {

        string script = "DELETE PRODUTO_TIPO where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static string PegaGrupoPorDescricao(string xdescricao)
    {
        string script;

        script = " SELECT grupo FROM produto_grupo " +
                 " WHERE produto = 41 " +
                 " AND substring(descricao,charindex(" + Srelib.QStr(xdescricao) + ",descricao,7),3) = " + Srelib.QStr(xdescricao);

        return Convert.ToString(SreDblib.GetCampoScript(script));

    }

    public static String PegaEndereco(string xID)
    {
        string script;
        string resultado = "";
        DataSet ds;
        //Comercial
        script = "SELECT enderecocom, enderecocomnumero, enderecocomcomplem, bairrocom, cidadecom, ufcom, cepcom FROM produto WITH(NOLOCK) WHERE ID = " + xID;
        ds = SreDblib.GetDsScript(script);

        resultado = ds.Tables[0].Rows[0]["enderecocom"].ToString() + ", " +
                    ds.Tables[0].Rows[0]["enderecocomnumero"].ToString() + " - " +
                    ds.Tables[0].Rows[0]["enderecocomcomplem"].ToString() + " - " +
                    ds.Tables[0].Rows[0]["bairrocom"].ToString() + " - " +
                    ds.Tables[0].Rows[0]["cidadecom"].ToString() + " - " +
                    ds.Tables[0].Rows[0]["ufcom"].ToString() + " - " +
                    ds.Tables[0].Rows[0]["cepcom"].ToString();

        return resultado;
    }


    public uProduto()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}