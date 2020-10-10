using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;
using System.ComponentModel;

/// <summary>
/// Summary description for uFluxoCaixa
/// </summary>
public class uFluxoCaixa
{

    public static DataSet PegaDadosFCaixa(string xproduto,
                                          string xcontascorrentes,
                                          DateTime xdtprevisao1,
                                          DateTime xdtprevisao2,
                                          string xsituacaopgto,
                                          Boolean xckcompensado,
                                          Boolean xcompensado,
                                          Boolean xckaplicacao)
    {
        //
        DataSet dslancamentos;
        //
        string ID = "0";
        string tipo = "0";
        string lancamento = "0";
        string produto = "0";
        string classe = "0";
        string cliente = "0";
        string descricao = "0";
        string data_prevista = "0";
        string vlr_previsto = "0";
        string data_realizado = "0";
        string vlr_realizado = "0";
        string conta = "0";
        string documento = "0";
        string data_documento = "0";
        string cheque = "0";
        string cmc7 = "0";
        string dtcompensacao = "0";
        string contabil = "0";
        string integracao_contabil = "0";
        //
        DataTable table1 = new DataTable("table1");
        table1.Columns.Add("ID");
        table1.Columns.Add("tipo");
        table1.Columns.Add("lancamento");
        table1.Columns.Add("produto");
        table1.Columns.Add("classe");
        table1.Columns.Add("cliente");
        table1.Columns.Add("descricao");
        table1.Columns.Add("data_prevista", typeof(DateTime));
        table1.Columns.Add("vlr_previsto");
        table1.Columns.Add("data_realizado", typeof(DateTime));
        table1.Columns.Add("vlr_realizado");
        table1.Columns.Add("conta");
        table1.Columns.Add("documento");
        table1.Columns.Add("data_documento", typeof(DateTime));
        table1.Columns.Add("cheque");
        table1.Columns.Add("cmc7");
        table1.Columns.Add("dtcompensacao", typeof(DateTime));
        table1.Columns.Add("contabil");
        table1.Columns.Add("integracao_contabil");

        //CONTAS A RECEBER
        string script = "";
        string nomearquivo = "contas_receber";

        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) ";
        script = script + " WHERE ";
        //Produto
        script = script + "( " + Srelib.QStr(xproduto) + " = " + Srelib.QStr("") + " OR produto IN (" + Srelib.QStr(xproduto) + ") )";
        //Contas Correntes
        if (xcontascorrentes != "0")
        {
            script = script + " AND ";
            if (xcontascorrentes.Contains(","))
            {
                script = script + "( " + Srelib.QStr("1") + " = " + Srelib.QStr("") + " OR conta IN (" + xcontascorrentes + ") )";
            }
            else
            {
                script = script + "( " + Srelib.QStr(xcontascorrentes) + " = " + Srelib.QStr("") + " OR conta IN (" + Srelib.QStr(xcontascorrentes) + ") )";
            }
        }
        //Data Prevista
        script = script + " AND ";
        script = script + " (data_prevista >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1.ToString().Substring(0, 10)));
        script = script + " and data_prevista <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2.ToString().Substring(0, 10))) + ") ";
        //Aplicações
        if (!xckaplicacao)
        {
            script = script + " AND ";
            script = script + " (classe > 0 ) ";
        }
        //Compensado
        if (xckcompensado)
        {
            if (xcompensado)
            {
                //Compensado
                script = script + " AND ";
                script = script + " (dtcompensacao <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
            else
            {
                //Não Compensado
                script = script + " AND ";
                script = script + " (dtcompensacao = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
        }
        if (xsituacaopgto == "T")
        {
            //Todos
        }
        else
        {
            if (xsituacaopgto == "P")
            {
                //Previsto
                script = script + " AND ";
                script = script + " (data_realizado = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
                //Data Prevista
                script = script + " order by data_prevista ";
            }
            else
            {
                //Realizado
                script = script + " AND ";
                script = script + " (data_realizado > " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
                //Data Realizado
                script = script + " order by data_realizado ";
            }
        }
        //

        dslancamentos = SreDblib.GetDsScript(script);
        //
        for (int i = 0; i <= dslancamentos.Tables[0].Rows.Count - 1; i++)
        {
            //
            ID = "1";
            tipo = "R";
            lancamento = dslancamentos.Tables[0].Rows[i]["lancamento"].ToString().Trim();
            produto = dslancamentos.Tables[0].Rows[i]["produto"].ToString().Trim();
            classe = dslancamentos.Tables[0].Rows[i]["classe"].ToString().Trim();
            cliente = dslancamentos.Tables[0].Rows[i]["cliente"].ToString().Trim();
            descricao = dslancamentos.Tables[0].Rows[i]["descricao"].ToString().Trim();
            data_prevista = dslancamentos.Tables[0].Rows[i]["data_prevista"].ToString().Trim();
            vlr_previsto = dslancamentos.Tables[0].Rows[i]["vlr_realizado"].ToString().Trim();
            data_realizado = dslancamentos.Tables[0].Rows[i]["data_realizado"].ToString().Trim();
            vlr_realizado = dslancamentos.Tables[0].Rows[i]["vlr_realizado"].ToString().Trim();
            conta = dslancamentos.Tables[0].Rows[i]["conta"].ToString().Trim();
            documento = dslancamentos.Tables[0].Rows[i]["documento"].ToString().Trim();
            data_documento = dslancamentos.Tables[0].Rows[i]["data_documento"].ToString().Trim();
            cheque = dslancamentos.Tables[0].Rows[i]["cheque"].ToString().Trim();
            cmc7 = dslancamentos.Tables[0].Rows[i]["cmc7"].ToString().Trim();
            dtcompensacao = dslancamentos.Tables[0].Rows[i]["dtcompensacao"].ToString().Trim();
            contabil = dslancamentos.Tables[0].Rows[i]["contabil"].ToString().Trim();
            integracao_contabil = dslancamentos.Tables[0].Rows[i]["integracao_contabil"].ToString().Trim();
            //
            //
            table1.Rows.Add(ID,
                            tipo,
                            lancamento,
                            produto,
                            classe,
                            cliente,
                            descricao,
                            data_prevista,
                            vlr_previsto,
                            data_realizado,
                            vlr_realizado,
                            conta,
                            documento,
                            data_documento,
                            cheque,
                            cmc7,
                            dtcompensacao,
                            contabil,
                            integracao_contabil);
        }


        //CONTAS A PAGAR
        script = "";
        nomearquivo = "contas_pagar";

        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) ";
        script = script + " WHERE ";
        //Produto
        script = script + "( " + Srelib.QStr(xproduto) + " = " + Srelib.QStr("") + " OR produto IN (" + Srelib.QStr(xproduto) + ") )";
        //Contas Correntes
        //Contas Correntes
        if (xcontascorrentes != "0")
        {
            script = script + " AND ";
            if (xcontascorrentes.Contains(","))
            {
                script = script + "( " + Srelib.QStr("1") + " = " + Srelib.QStr("") + " OR conta IN (" + xcontascorrentes + ") )";
            }
            else
            {
                script = script + "( " + Srelib.QStr(xcontascorrentes) + " = " + Srelib.QStr("") + " OR conta IN (" + Srelib.QStr(xcontascorrentes) + ") )";
            }
        }
        //Data Prevista
        script = script + " AND ";
        script = script + " (data_prevista >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1.ToString().Substring(0, 10)));
        script = script + " and data_prevista <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2.ToString().Substring(0, 10))) + ") ";
        //Aplicações
        if (!xckaplicacao)
        {
            script = script + " AND ";
            script = script + " (classe > 0 ) ";
        }
        //Compensado
        if (xckcompensado)
        {
            if (xcompensado)
            {
                //Compensado
                script = script + " AND ";
                script = script + " (dtcompensacao <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
            else
            {
                //Não Compensado
                script = script + " AND ";
                script = script + " (dtcompensacao = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
        }
        if (xsituacaopgto == "T")
        {
            //Todos
        }
        else
        {
            if (xsituacaopgto == "P")
            {
                //Previsto
                script = script + " AND ";
                script = script + " (data_realizado = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
                //Data Prevista
                script = script + " order by data_prevista ";
            }
            else
            {
                //Realizado
                script = script + " AND ";
                script = script + " (data_realizado <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
                //Data Realizado
                script = script + " order by data_realizado ";
            }
        }
        //

        dslancamentos = SreDblib.GetDsScript(script);
        //
        for (int i = 0; i <= dslancamentos.Tables[0].Rows.Count - 1; i++)
        {
            //
            ID = "2";
            tipo = "D";
            lancamento = dslancamentos.Tables[0].Rows[i]["lancamento"].ToString().Trim();
            produto = dslancamentos.Tables[0].Rows[i]["produto"].ToString().Trim();
            classe = dslancamentos.Tables[0].Rows[i]["classe"].ToString().Trim();
            cliente = dslancamentos.Tables[0].Rows[i]["fornecedor"].ToString().Trim();
            descricao = dslancamentos.Tables[0].Rows[i]["descricao"].ToString().Trim();
            data_prevista = dslancamentos.Tables[0].Rows[i]["data_prevista"].ToString().Trim();
            vlr_previsto = dslancamentos.Tables[0].Rows[i]["vlr_realizado"].ToString().Trim();
            data_realizado = dslancamentos.Tables[0].Rows[i]["data_realizado"].ToString().Trim();
            vlr_realizado = dslancamentos.Tables[0].Rows[i]["vlr_realizado"].ToString().Trim();
            conta = dslancamentos.Tables[0].Rows[i]["conta"].ToString().Trim();
            documento = dslancamentos.Tables[0].Rows[i]["documento"].ToString().Trim();
            data_documento = dslancamentos.Tables[0].Rows[i]["data_documento"].ToString().Trim();
            cheque = dslancamentos.Tables[0].Rows[i]["cheque"].ToString().Trim();
            cmc7 = dslancamentos.Tables[0].Rows[i]["cmc7"].ToString().Trim();
            dtcompensacao = dslancamentos.Tables[0].Rows[i]["dtcompensacao"].ToString().Trim();
            contabil = dslancamentos.Tables[0].Rows[i]["contabil"].ToString().Trim();
            integracao_contabil = dslancamentos.Tables[0].Rows[i]["integracao_contabil"].ToString().Trim();
            //
            //
            table1.Rows.Add(ID,
                            tipo,
                            lancamento,
                            produto,
                            classe,
                            cliente,
                            descricao,
                            data_prevista,
                            vlr_previsto,
                            data_realizado,
                            vlr_realizado,
                            conta,
                            documento,
                            data_documento,
                            cheque,
                            cmc7,
                            dtcompensacao,
                            contabil,
                            integracao_contabil);
        }


        //
        DataView dataview = new DataView(table1);
        dataview.Sort = "ID ASC";
        DataTable table2 = dataview.ToTable();
        //
        DataSet dsresult = new DataSet("table");
        dsresult.Tables.Add(table2);
        //
        return dsresult;

    }


    public static DataSet PegaDadosFCaixaMensal(string xproduto,
                                                string xcontascorrentes,
                                                string xmes,
                                                string xano,
                                                string xrblancamentossituacao,
                                                Boolean xckcompensado,
                                                Boolean xcompensado,
                                                Boolean xckaplicacao)
    {
        //
        DataSet dslancamentos;
        //
        string tipo = "1";
        string classe = "";
        DateTime data = Convert.ToDateTime("01/01/1900");
        string descricao = "";
        string mes1 = "0,00";
        string mes2 = "0,00";
        string mes3 = "0,00";
        string totaltrimestre = "0,00";
        DateTime xdtprevisao1 = Convert.ToDateTime("01/01/1900");
        DateTime xdtprevisao2 = Convert.ToDateTime("31/12/2999");
        //
        if (xano != string.Empty)
        {
            if (xmes != string.Empty)
            {
                DateTime ultimoDia = new DateTime(Convert.ToInt16(xano),
                                                  Convert.ToInt16(xmes),
                                                  DateTime.DaysInMonth(Convert.ToInt16(xano), Convert.ToInt16(xmes)));

                xdtprevisao1 = Convert.ToDateTime("01/" + xmes + "/" + xano);
                xdtprevisao2 = Convert.ToDateTime(Srelib.strzero(ultimoDia.Day, 2) + "/" + xmes + "/" + xano);
            }
        }
        //
        DataTable table1 = new DataTable("table1");
        table1.Columns.Add("tipo");
        table1.Columns.Add("classe");
        table1.Columns.Add("data");
        table1.Columns.Add("descricao");
        table1.Columns.Add("mes1");
        table1.Columns.Add("mes2");
        table1.Columns.Add("mes3");
        table1.Columns.Add("totaltrimestre");
        //
        //CONTAS A RECEBER
        string script = "";
        string nomearquivo = "contas_receber";

        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) ";
        script = script + " WHERE 1 = 1 ";
        //Produto
        if (xproduto != string.Empty)
        {
            script = script + " AND ( " + Srelib.QStr(xproduto) + " = " + Srelib.QStr("") + " OR produto IN (" + Srelib.QStr(xproduto) + ") )";
        }
        //Contas Correntes
        if (xcontascorrentes != "0")
        {
            script = script + " AND ";
            if (xcontascorrentes.Contains(","))
            {
                script = script + "( " + Srelib.QStr("1") + " = " + Srelib.QStr("") + " OR conta IN (" + xcontascorrentes + ") )";
            }
            else
            {
                script = script + "( " + Srelib.QStr(xcontascorrentes) + " = " + Srelib.QStr("") + " OR conta IN (" + Srelib.QStr(xcontascorrentes) + ") )";
            }
        }
        //
        if (xrblancamentossituacao == "P")
        {
            //Data Prevista
            script = script + " AND ";
            script = script + " (data_prevista between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1.ToString().Substring(0, 10)));
            script = script + " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2.ToString().Substring(0, 10))) + ") ";
        }
        else
        {
            //Data Realizado
            script = script + " AND ";
            script = script + " (data_realizado between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1.ToString().Substring(0, 10)));
            script = script + " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2.ToString().Substring(0, 10))) + ") ";
        }
        //Aplicações
        if (!xckaplicacao)
        {
            script = script + " AND ";
            script = script + " (classe > 0 ) ";
        }
        //
        //Compensado
        if (xckcompensado)
        {
            if (xcompensado)
            {
                //Compensado
                script = script + " AND ";
                script = script + " (dtcompensacao <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
            else
            {
                //Não Compensado
                script = script + " AND ";
                script = script + " (dtcompensacao = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
        }
        script = script + " order by classe ";
        //
        dslancamentos = SreDblib.GetDsScript(script);
        //
        for (int i = 0; i <= dslancamentos.Tables[0].Rows.Count - 1; i++)
        {
            //
            tipo = "1";
            classe = dslancamentos.Tables[0].Rows[i]["classe"].ToString().Trim();
            //
            if (xrblancamentossituacao == "P")
            {
                //Previsto
                data = Convert.ToDateTime(dslancamentos.Tables[0].Rows[i]["data_prevista"]);
                //
                mes1 = Convert.ToString(
                       Convert.ToDouble(mes1) +
                       Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_previsto"]));
                //
                totaltrimestre = Convert.ToString(
                       Convert.ToDouble(totaltrimestre) +
                       Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_previsto"]));
                //
            }
            else
            {
                //Realizado
                data = Convert.ToDateTime(dslancamentos.Tables[0].Rows[i]["data_realizado"]);
                //
                mes1 = Convert.ToString(
                       Convert.ToDouble(mes1) +
                       Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_realizado"]));
                //
                totaltrimestre = Convert.ToString(
                       Convert.ToDouble(totaltrimestre) +
                       Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_realizado"]));
                //
            }
            //
            descricao = uReceitas.PegaReceitaDescricao(Convert.ToInt16(classe));
            //
            try
            {
                if (classe != dslancamentos.Tables[0].Rows[i + 1]["classe"].ToString().Trim())
                {
                    table1.Rows.Add(tipo,
                                    classe,
                                    data,
                                    descricao,
                                    mes1,
                                    mes2,
                                    mes3,
                                    totaltrimestre);
                    //
                    mes1 = "0,00";
                    mes2 = "0,00";
                    mes3 = "0,00";
                    totaltrimestre = "0,00";
                }
                //
            }
            catch (Exception)
            {

                table1.Rows.Add(tipo,
                                classe,
                                data,
                                descricao,
                                mes1,
                                mes2,
                                mes3,
                                totaltrimestre);
                //
                mes1 = "0,00";
                mes2 = "0,00";
                mes3 = "0,00";
                totaltrimestre = "0,00";
            }
            //
        }
        //
        //CONTAS A PAGAR
        script = "";
        nomearquivo = "contas_pagar";

        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) ";
        script = script + " WHERE 1 = 1 ";
        //Produto
        if (xproduto != string.Empty)
        {
            script = script + " AND ( " + Srelib.QStr(xproduto) + " = " + Srelib.QStr("") + " OR produto IN (" + Srelib.QStr(xproduto) + ") )";
        }
        //Contas Correntes
        if (xcontascorrentes != "0")
        {
            script = script + " AND ";
            if (xcontascorrentes.Contains(","))
            {
                script = script + "( " + Srelib.QStr("1") + " = " + Srelib.QStr("") + " OR conta IN (" + xcontascorrentes + ") )";
            }
            else
            {
                script = script + "( " + Srelib.QStr(xcontascorrentes) + " = " + Srelib.QStr("") + " OR conta IN (" + Srelib.QStr(xcontascorrentes) + ") )";
            }
        }
        //
        if (xrblancamentossituacao == "P")
        {
            //Data Prevista
            script = script + " AND ";
            script = script + " (data_prevista between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1.ToString().Substring(0, 10)));
            script = script + " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2.ToString().Substring(0, 10))) + ") ";
        }
        else
        {
            //Data Realizado
            script = script + " AND ";
            script = script + " (data_realizado between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1.ToString().Substring(0, 10)));
            script = script + " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2.ToString().Substring(0, 10))) + ") ";
        }
        //Aplicações
        if (!xckaplicacao)
        {
            script = script + " AND ";
            script = script + " (classe > 0 ) ";
        }
        //
        //Compensado
        if (xckcompensado)
        {
            if (xcompensado)
            {
                //Compensado
                script = script + " AND ";
                script = script + " (dtcompensacao <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
            else
            {
                //Não Compensado
                script = script + " AND ";
                script = script + " (dtcompensacao = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
        }
        script = script + " order by classe ";
        //
        dslancamentos = SreDblib.GetDsScript(script);
        //
        for (int i = 0; i <= dslancamentos.Tables[0].Rows.Count - 1; i++)
        {
            //           
            tipo = "2";
            classe = dslancamentos.Tables[0].Rows[i]["classe"].ToString().Trim();
            //
            if (xrblancamentossituacao == "P")
            {
                //Previsto
                data = Convert.ToDateTime(dslancamentos.Tables[0].Rows[i]["data_prevista"]);
                //
                mes1 = Convert.ToString(
                       Convert.ToDouble(mes1) +
                       Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_previsto"]));
                //
                totaltrimestre = Convert.ToString(
                       Convert.ToDouble(totaltrimestre) +
                       Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_previsto"]));
                //
            }
            else
            {
                //Realizado
                data = Convert.ToDateTime(dslancamentos.Tables[0].Rows[i]["data_realizado"]);
                //
                mes1 = Convert.ToString(
                       Convert.ToDouble(mes1) +
                       Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_realizado"]));
                //
                totaltrimestre = Convert.ToString(
                       Convert.ToDouble(totaltrimestre) +
                       Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_realizado"]));
                //
            }
            //
            descricao = uDespesas.PegaDespesaDescricao(Convert.ToInt16(classe));
            //
            try
            {
                if ((i < dslancamentos.Tables[0].Rows.Count) &&
                    (classe != dslancamentos.Tables[0].Rows[i + 1]["classe"].ToString().Trim()))
                {
                    table1.Rows.Add(tipo,
                                    classe,
                                    data,
                                    descricao,
                                    mes1,
                                    mes2,
                                    mes3,
                                    totaltrimestre);
                    //
                    mes1 = "0,00";
                    mes2 = "0,00";
                    mes3 = "0,00";
                    totaltrimestre = "0,00";
                }
            }
            catch (Exception)
            {
                //
                table1.Rows.Add(tipo,
                                classe,
                                data,
                                descricao,
                                mes1,
                                mes2,
                                mes3,
                                totaltrimestre);
                //
                mes1 = "0,00";
                mes2 = "0,00";
                mes3 = "0,00";
                totaltrimestre = "0,00";
                //
            }
        }
        //
        DataView dataview = new DataView(table1);
        dataview.Sort = "tipo, descricao ASC";
        DataTable table2 = dataview.ToTable();
        //
        DataSet dsresult = new DataSet("table");
        dsresult.Tables.Add(table2);
        //
        return dsresult;

    }

    public static DataSet PegaDadosFCaixaTrimestral(string xproduto,
                                                    string xcontascorrentes,
                                                    string xrbtrimestre,
                                                    string xano,
                                                    string xrblancamentossituacao,
                                                    Boolean xckcompensado,
                                                    Boolean xcompensado,
                                                    Boolean xckaplicacao)
    {
        //
        DataSet dslancamentos;
        //
        string tipo = "1";
        string classe = "";
        DateTime data = Convert.ToDateTime("01/01/1900");
        string descricao = "";
        string mes1 = "0,00";
        string mes2 = "0,00";
        string mes3 = "0,00";
        string totaltrimestre = "0,00";
        DateTime xdtprevisao1 = Convert.ToDateTime("01/01/1900");
        DateTime xdtprevisao2 = Convert.ToDateTime("31/12/2999");
        //
        if (xano != string.Empty)
        {
            if (xrbtrimestre == "1")
            {
                xdtprevisao1 = Convert.ToDateTime("01/01/" + xano);
                xdtprevisao2 = Convert.ToDateTime("31/03/" + xano);
            }
            if (xrbtrimestre == "2")
            {
                xdtprevisao1 = Convert.ToDateTime("01/04/" + xano);
                xdtprevisao2 = Convert.ToDateTime("30/06/" + xano);
            }
            if (xrbtrimestre == "3")
            {
                xdtprevisao1 = Convert.ToDateTime("01/07/" + xano);
                xdtprevisao2 = Convert.ToDateTime("30/09/" + xano);
            }
            if (xrbtrimestre == "4")
            {
                xdtprevisao1 = Convert.ToDateTime("01/10/" + xano);
                xdtprevisao2 = Convert.ToDateTime("31/12/" + xano);
            }
        }
        //
        DataTable table1 = new DataTable("table1");
        table1.Columns.Add("tipo");
        table1.Columns.Add("classe");
        table1.Columns.Add("data");
        table1.Columns.Add("descricao");
        table1.Columns.Add("mes1");
        table1.Columns.Add("mes2");
        table1.Columns.Add("mes3");
        table1.Columns.Add("totaltrimestre");
        //
        //CONTAS A RECEBER
        string script = "";
        string nomearquivo = "contas_receber";

        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) ";
        script = script + " WHERE 1 = 1 ";
        //Produto
        if (xproduto != string.Empty)
        {
            script = script + " AND ( " + Srelib.QStr(xproduto) + " = " + Srelib.QStr("") + " OR produto IN (" + Srelib.QStr(xproduto) + ") )";
        }
        //Contas Correntes
        if (xcontascorrentes != "0")
        {
            script = script + " AND ";
            if (xcontascorrentes.Contains(","))
            {
                script = script + "( " + Srelib.QStr("1") + " = " + Srelib.QStr("") + " OR conta IN (" + xcontascorrentes + ") )";
            }
            else
            {
                script = script + "( " + Srelib.QStr(xcontascorrentes) + " = " + Srelib.QStr("") + " OR conta IN (" + Srelib.QStr(xcontascorrentes) + ") )";
            }
        }
        //
        if (xrblancamentossituacao == "P")
        {
            //Data Prevista
            script = script + " AND ";
            script = script + " (data_prevista between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1.ToString().Substring(0, 10)));
            script = script + " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2.ToString().Substring(0, 10))) + ") ";
            //script = script + " (data_prevista >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1.ToString().Substring(0, 10)));
            //script = script + " and data_prevista <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2.ToString().Substring(0, 10))) + ") ";
        }
        else
        {
            //Data Realizado
            script = script + " AND ";
            script = script + " (data_realizado between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1.ToString().Substring(0, 10)));
            script = script + " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2.ToString().Substring(0, 10))) + ") ";
            //script = script + " (data_realizado >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1.ToString().Substring(0, 10)));
            //script = script + " and data_realizado <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2.ToString().Substring(0, 10))) + ") ";

        }
        //Aplicações
        if (!xckaplicacao)
        {
            script = script + " AND ";
            script = script + " (classe > 0 ) ";
        }
        //
        //Compensado
        if (xckcompensado)
        {
            if (xcompensado)
            {
                //Compensado
                script = script + " AND ";
                script = script + " (dtcompensacao <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
            else
            {
                //Não Compensado
                script = script + " AND ";
                script = script + " (dtcompensacao = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
        }
        //Aplicações
        if (!xckaplicacao)
        {
            script = script + " AND ";
            script = script + " (classe > 0 ) ";
        }
        //if (xrblancamentossituacao == "P")
        //{
        //    //Previsto
        //    script = script + " AND ";
        //    script = script + " (data_realizado = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
        //    //Data Prevista
        //    script = script + " order by classe ";
        //}
        //else
        //{
        //    //Realizado
        //    script = script + " AND ";
        //    script = script + " (data_realizado > " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
        //    //Data Realizado
        script = script + " order by classe ";
        //}
        //
        dslancamentos = SreDblib.GetDsScript(script);
        //
        for (int i = 0; i <= dslancamentos.Tables[0].Rows.Count - 1; i++)
        {
            //
            tipo = "1";
            classe = dslancamentos.Tables[0].Rows[i]["classe"].ToString().Trim();
            //
            if (xrblancamentossituacao == "P")
            {
                //Previsto
                data = Convert.ToDateTime(dslancamentos.Tables[0].Rows[i]["data_prevista"]);
                //
                if ((data.Month == 1) || (data.Month == 4) || (data.Month == 7) || (data.Month == 10))
                {
                    mes1 = Convert.ToString(
                           Convert.ToDouble(mes1) +
                           Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_previsto"]));
                }
                if ((data.Month == 2) || (data.Month == 5) || (data.Month == 8) || (data.Month == 11))
                {
                    mes2 = Convert.ToString(
                           Convert.ToDouble(mes2) +
                           Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_previsto"]));
                }
                if ((data.Month == 3) || (data.Month == 6) || (data.Month == 9) || (data.Month == 12))
                {
                    mes3 = Convert.ToString(
                           Convert.ToDouble(mes3) +
                           Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_previsto"]));
                }
                //
                totaltrimestre = Convert.ToString(
                       Convert.ToDouble(totaltrimestre) +
                       Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_previsto"]));
                //
            }
            else
            {
                //Realizado
                data = Convert.ToDateTime(dslancamentos.Tables[0].Rows[i]["data_realizado"]);
                //
                if ((data.Month == 1) || (data.Month == 4) || (data.Month == 7) || (data.Month == 10))
                {
                    mes1 = Convert.ToString(
                           Convert.ToDouble(mes1) +
                           Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_realizado"]));
                }
                if ((data.Month == 2) || (data.Month == 5) || (data.Month == 8) || (data.Month == 11))
                {
                    mes2 = Convert.ToString(
                           Convert.ToDouble(mes2) +
                           Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_realizado"]));
                }
                if ((data.Month == 3) || (data.Month == 6) || (data.Month == 9) || (data.Month == 12))
                {
                    mes3 = Convert.ToString(
                           Convert.ToDouble(mes3) +
                           Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_realizado"]));
                }
                //
                totaltrimestre = Convert.ToString(
                       Convert.ToDouble(totaltrimestre) +
                       Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_realizado"]));
                //
            }
            //
            descricao = uReceitas.PegaReceitaDescricao(Convert.ToInt16(classe));
            //
            try
            {
                if (classe != dslancamentos.Tables[0].Rows[i + 1]["classe"].ToString().Trim())
                {
                    table1.Rows.Add(tipo,
                                    classe,
                                    data,
                                    descricao,
                                    mes1,
                                    mes2,
                                    mes3,
                                    totaltrimestre);
                    //
                    mes1 = "0,00";
                    mes2 = "0,00";
                    mes3 = "0,00";
                    totaltrimestre = "0,00";
                }
                //
            }
            catch (Exception)
            {

                table1.Rows.Add(tipo,
                                classe,
                                data,
                                descricao,
                                mes1,
                                mes2,
                                mes3,
                                totaltrimestre);
                //
                mes1 = "0,00";
                mes2 = "0,00";
                mes3 = "0,00";
                totaltrimestre = "0,00";
            }
            //
        }
        //
        //CONTAS A PAGAR
        script = "";
        nomearquivo = "contas_pagar";

        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) ";
        script = script + " WHERE 1 = 1 ";
        //Produto
        if (xproduto != string.Empty)
        {
            script = script + " AND ( " + Srelib.QStr(xproduto) + " = " + Srelib.QStr("") + " OR produto IN (" + Srelib.QStr(xproduto) + ") )";
        }
        //Contas Correntes
        if (xcontascorrentes != "0")
        {
            script = script + " AND ";
            if (xcontascorrentes.Contains(","))
            {
                script = script + "( " + Srelib.QStr("1") + " = " + Srelib.QStr("") + " OR conta IN (" + xcontascorrentes + ") )";
            }
            else
            {
                script = script + "( " + Srelib.QStr(xcontascorrentes) + " = " + Srelib.QStr("") + " OR conta IN (" + Srelib.QStr(xcontascorrentes) + ") )";
            }
        }
        //
        if (xrblancamentossituacao == "P")
        {
            //Data Prevista
            script = script + " AND ";
            script = script + " (data_prevista between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1.ToString().Substring(0, 10)));
            script = script + " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2.ToString().Substring(0, 10))) + ") ";
            //script = script + " (data_prevista >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1.ToString().Substring(0, 10)));
            //script = script + " and data_prevista <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2.ToString().Substring(0, 10))) + ") ";
        }
        else
        {
            //Data Realizado
            script = script + " AND ";
            script = script + " (data_realizado between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1.ToString().Substring(0, 10)));
            script = script + " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2.ToString().Substring(0, 10))) + ") ";
            //script = script + " (data_realizado >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao1.ToString().Substring(0, 10)));
            //script = script + " and data_realizado <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtprevisao2.ToString().Substring(0, 10))) + ") ";

        }
        //Aplicações
        if (!xckaplicacao)
        {
            script = script + " AND ";
            script = script + " (classe > 0 ) ";
        }
        //
        //Compensado
        if (xckcompensado)
        {
            if (xcompensado)
            {
                //Compensado
                script = script + " AND ";
                script = script + " (dtcompensacao <> " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
            else
            {
                //Não Compensado
                script = script + " AND ";
                script = script + " (dtcompensacao = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
            }
        }
        //if (xrblancamentossituacao == "P")
        //{
        //    //Previsto
        //    script = script + " AND ";
        //    script = script + " (data_realizado = " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
        //    //Data Prevista
        //    script = script + " order by classe ";
        //}
        //else
        //{
        //    //Realizado
        //    script = script + " AND ";
        //    script = script + " (data_realizado > " + Srelib.QStr(Srelib.DataAmericanasembarra("01/01/1900")) + ") ";
        //    //Data Realizado
        script = script + " order by classe ";
        //}
        //
        dslancamentos = SreDblib.GetDsScript(script);
        //
        for (int i = 0; i <= dslancamentos.Tables[0].Rows.Count - 1; i++)
        {
            //           
            tipo = "2";
            classe = dslancamentos.Tables[0].Rows[i]["classe"].ToString().Trim();
            //
            if (xrblancamentossituacao == "P")
            {
                //Previsto
                data = Convert.ToDateTime(dslancamentos.Tables[0].Rows[i]["data_prevista"]);
                //
                if ((data.Month == 1) || (data.Month == 4) || (data.Month == 7) || (data.Month == 10))
                {
                    mes1 = Convert.ToString(
                           Convert.ToDouble(mes1) +
                           Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_previsto"]));
                }
                if ((data.Month == 2) || (data.Month == 5) || (data.Month == 8) || (data.Month == 11))
                {
                    mes2 = Convert.ToString(
                           Convert.ToDouble(mes2) +
                           Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_previsto"]));
                }
                if ((data.Month == 3) || (data.Month == 6) || (data.Month == 9) || (data.Month == 12))
                {
                    mes3 = Convert.ToString(
                           Convert.ToDouble(mes3) +
                           Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_previsto"]));
                }
                //
                totaltrimestre = Convert.ToString(
                       Convert.ToDouble(totaltrimestre) +
                       Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_previsto"]));
                //
            }
            else
            {
                //Realizado
                data = Convert.ToDateTime(dslancamentos.Tables[0].Rows[i]["data_realizado"]);
                //
                if ((data.Month == 1) || (data.Month == 4) || (data.Month == 7) || (data.Month == 10))
                {
                    mes1 = Convert.ToString(
                           Convert.ToDouble(mes1) +
                           Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_realizado"]));
                }
                if ((data.Month == 2) || (data.Month == 5) || (data.Month == 8) || (data.Month == 11))
                {
                    mes2 = Convert.ToString(
                           Convert.ToDouble(mes2) +
                           Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_realizado"]));
                }
                if ((data.Month == 3) || (data.Month == 6) || (data.Month == 9) || (data.Month == 12))
                {
                    mes3 = Convert.ToString(
                           Convert.ToDouble(mes3) +
                           Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_realizado"]));
                }
                //
                totaltrimestre = Convert.ToString(
                       Convert.ToDouble(totaltrimestre) +
                       Convert.ToDouble(dslancamentos.Tables[0].Rows[i]["vlr_realizado"]));
                //
            }
            //
            descricao = uDespesas.PegaDespesaDescricao(Convert.ToInt16(classe));
            //
            try
            {
                if ((i < dslancamentos.Tables[0].Rows.Count) &&
                    (classe != dslancamentos.Tables[0].Rows[i + 1]["classe"].ToString().Trim()))
                {
                    table1.Rows.Add(tipo,
                                    classe,
                                    data,
                                    descricao,
                                    mes1,
                                    mes2,
                                    mes3,
                                    totaltrimestre);
                    //
                    mes1 = "0,00";
                    mes2 = "0,00";
                    mes3 = "0,00";
                    totaltrimestre = "0,00";
                }
            }
            catch (Exception)
            {
                //
                table1.Rows.Add(tipo,
                                classe,
                                data,
                                descricao,
                                mes1,
                                mes2,
                                mes3,
                                totaltrimestre);
                //
                mes1 = "0,00";
                mes2 = "0,00";
                mes3 = "0,00";
                totaltrimestre = "0,00";
                //
            }
        }
        //
        DataView dataview = new DataView(table1);
        dataview.Sort = "tipo, descricao ASC";
        DataTable table2 = dataview.ToTable();
        //
        DataSet dsresult = new DataSet("table");
        dsresult.Tables.Add(table2);
        //
        return dsresult;

    }

    public uFluxoCaixa()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}