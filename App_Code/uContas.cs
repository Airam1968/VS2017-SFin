using System.Data.SqlClient;
using System.Data;
using System;
using System.Configuration;
using DevExpress.Web.ASPxEditors;
using System.Text;

/// <summary>
/// Summary description for uContas
/// </summary>
public class uContas
{

    public static DataSet LookUpContas()
    {

        return SreDblib.GetDsScript("select ID, nome_agencia from contas where combo = 1 ORDER BY ID ");
    }

    public static ASPxComboBox MontaComboContas(ASPxComboBox pCombo, string pCodigo)
    {
        if (pCodigo != "0")
        {
            //
            if (SreDblib.GetParametro("EXIBE CONTA CORRENTE") == "SIM")
            {
                return SreDblib.MontaCombo(pCombo, "contas", "nome_agencia", "ID", true,
                "( " + Srelib.QStr(pCodigo) + " = " + Srelib.QStr("") + " OR conta IN (" + Srelib.QStr(pCodigo) + ") )" +
                //" WHERE ID = " + pCodigo +
                " ORDER BY ID ");
            }
            else
            {
                return SreDblib.MontaCombo(pCombo, "contas", "nome_agencia", "ID", true,
                "( " + Srelib.QStr(pCodigo) + " = " + Srelib.QStr("") + " OR conta IN (" + Srelib.QStr(pCodigo) + ") )" +
                //" WHERE ID = " + pCodigo +
                " AND combo = 1 " +
                " ORDER BY ID ");
            }
        }
        else
        {
            //
            if (SreDblib.GetParametro("EXIBE CONTA CORRENTE") == "SIM")
            {
                return SreDblib.MontaCombo(pCombo, "contas", "nome_agencia", "ID", true,
                    " ORDER BY ID ");
            }
            else
            {
                return SreDblib.MontaCombo(pCombo, "contas", "nome_agencia", "ID", true,
                    " WHERE combo = 1 " +
                    " ORDER BY ID ");
            }
        }

    }

    public static String GravaSaldoInicial(string xcod_conta,
                                            string xdata,
                                            string xdescricao,
                                            string xcomplemento,
                                            string xsaldo_i,
                                            string xsaldo_aplicacaoD,
                                            string xsaldo_aplicacaoB,
                                            string xdtregistro)
    {
        if (xsaldo_i.Trim() == "")
            xsaldo_i = "0.00";

        if (xcod_conta != String.Empty)
        {
            string script = "INSERT INTO CONTAS_SALDO_INICIAL VALUES ( " +
                            Srelib.QStr(xcod_conta) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata)) +
                            ", " + Srelib.QStr(xdescricao) +
                            ", " + Srelib.QStr(xcomplemento) +
                            ", " + Srelib.forcaponto(xsaldo_i) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtregistro)) +
                            ", " + Srelib.forcaponto(xsaldo_aplicacaoD) +
                            ", " + Srelib.forcaponto(xsaldo_aplicacaoB) +
                            " ) ";

            SreDblib.ExecScript(script);
        }
        return " ";
    }


    public static String Grava(string xcodigo,
                                string xcod_banco,
                                string xcod_agencia,
                                string xcod_conta,
                                string xnome_agencia,
                                string xcidade,
                                string xuf,
                                string xcep,
                                string xlimite_cheque,
                                string xconta_contabil,
                                string xcomplemento,
                                string xcombo)
    {

        if (xcod_banco != String.Empty)
        {
            string script = "INSERT INTO CONTAS VALUES ( " +
                            Srelib.QStr(xcodigo) +
                            ", " + Srelib.QStr(xcod_banco) +
                            ", " + Srelib.QStr(xcod_agencia) +
                            ", " + Srelib.QStr(xcod_conta) +
                            ", " + Srelib.QStr(xnome_agencia) +
                            ", " + Srelib.QStr(xcidade) +
                            ", " + Srelib.QStr(xuf) +
                            ", " + Srelib.QStr(xcep) +
                            ", " + Srelib.forcaponto(xlimite_cheque) +
                            ", " + Srelib.QStr(xconta_contabil) +
                            ", " + Srelib.QStr(xcomplemento) +
                            ", " + xcombo +
                            " ) ";

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String AlteraConta(string xID,
                                     string xcod_banco,
                                     string xcod_agencia,
                                     string xcod_conta,
                                     string xnome_agencia,
                                     string xcidade,
                                     string xuf,
                                     string xcep,
                                     string xlimite_cheque,
                                     string xconta_contabil,
                                     string xcomplemento,
                                     string xcombo)
    {

        string script = "UPDATE CONTAS SET " +
                        " cod_banco = " + Srelib.QStr(xcod_banco) +
                        " ,cod_agencia = " + Srelib.QStr(xcod_agencia) +
                        " ,cod_conta = " + Srelib.QStr(xcod_conta) +
                        " ,nome_agencia = " + Srelib.QStr(xnome_agencia) +
                        " ,cidade = " + Srelib.QStr(xcidade) +
                        " ,uf = " + Srelib.QStr(xuf) +
                        " ,cep = " + Srelib.QStr(xcep) +
                        " ,limite_cheque = " + Srelib.forcaponto(xlimite_cheque) +
                        " ,conta_contabil = " + Srelib.QStr(xconta_contabil) +
                        " ,complemento = " + Srelib.QStr(xcomplemento) +
                        " ,combo = " + Srelib.QStr(xcombo) +
                        " where ID =" + xID;

        //revisar quando mexer na cobrança bancária

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String AlteraContaSaldoInicial(string xID,
                                                 string xcod_conta,
                                                 string xdata,
                                                 string xdescricao,
                                                 string xcomplemento,
                                                 string xsaldo_i,
                                                 string xsaldo_aplicacaoD,
                                                 string xsaldo_aplicacaoB,
                                                 string xdtregistro)
    {

        string script = "UPDATE CONTAS_SALDO_INICIAL SET " +
                        " cod_conta = " + Srelib.QStr(xcod_conta) +
                        " ,data = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata)) +
                        " ,descricao = " + Srelib.QStr(xdescricao) +
                        " ,complemento = " + Srelib.QStr(xcomplemento) +
                        " ,saldo_i = " + Srelib.forcaponto(xsaldo_i) +
                        " ,saldo_aplicacaoD = " + Srelib.forcaponto(xsaldo_aplicacaoD) +
                        " ,saldo_aplicacaoB = " + Srelib.forcaponto(xsaldo_aplicacaoB) +
                        " ,dtregistro = " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtregistro)) +
                        " where ID =" + xID;

        //revisar quando mexer na cobrança bancária

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String ExcluiConta(string xID)
    {

        string script = "DELETE CONTAS where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String ExcluiLancamentos(string xcodigoconta,
                                           string xdtperiodo1,
                                           string xdtperiodo2)
    {
        string nomeconta = "conta_" + Srelib.QStr0(xcodigoconta.Trim(), 5);
        //

        string script = "DELETE " + nomeconta + " where " +
                        " (data between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo1)) +
                        " and " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtperiodo2)) + " ) ";



        SreDblib.ExecScript(script);

        return " ";
    }

    public static String ExcluiContaSaldoInicial(string xID)
    {

        string script = "DELETE CONTAS_SALDO_INICIAL where ID =" + xID;

        SreDblib.ExecScript(script);

        return " ";
    }

    public static String CriarTabelaContasCorrentes(string xcodigo)
    {
        //Criar Arquivo Contas Correntes individuais

        if (xcodigo != string.Empty)
        {
            //Cria nova tabela no SQL
            string nomeconta = "conta_" + Srelib.QStr0(xcodigo.Trim(), 5);
            string script = "";
            string script1 = "";
            string script2 = "";
            string script3 = "";
            string scriptconta = "";

            script1 = "CREATE TABLE [dbo].[";
            script2 = "](" +
                        "	[ID] [int] IDENTITY(1,1) NOT NULL," +
                        "	[cod_conta] [varchar](20) NOT NULL," +
                        "	[lancamento] [int] NOT NULL," +
                        "	[produto] [int] NULL," +
                        "	[classe] [int] NULL," +
                        "	[pedido_compra] [int] NOT NULL," +
                        "	[data] [datetime] NOT NULL," +
                        "	[descricao] [varchar](60) NULL," +
                        "	[complemento] [varchar](60) NULL," +
                        "	[saldo_i] [decimal](18, 2) NULL," +
                        "	[credito] [decimal](18, 2) NULL," +
                        "	[debito] [decimal](18, 2) NULL," +
                        "	[saldo_f] [decimal](18, 2) NULL," +
                        "	[saldo_aplicacaoD] [decimal](18, 2) NULL," +
                        "	[saldo_aplicacaoB] [decimal](18, 2) NULL," +
                        "	[saldo_total] [decimal](18, 2) NULL," +
                        "	[cheque] [varchar](20) NULL," +
                        "	[cmc7] [varchar](30) NULL," +
                        "	[dtregistro] [datetime] NOT NULL," +
                        " CONSTRAINT [PK_";
            script3 = "] PRIMARY KEY NONCLUSTERED " +
                        "(" +
                        "	[ID] ASC" +
                        ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]" +
                        ") ON [PRIMARY]"; // +
            //"GO";
            //
            scriptconta = scriptconta + nomeconta;

            //Criação da Tabela
            script = script1 + scriptconta + script2 + scriptconta + script3;
            //drop
            try
            {
                SreDblib.ExecScript("drop table dbo." + nomeconta);
            }
            catch (Exception)
            {
                //
            }
            //create
            try
            {
                SreDblib.ExecScript(script);
            }
            catch (Exception)
            {
                //
            }


        }
        //fim Cria nova tabela no SQL

        return " ";
    }


    public static String GravaLancamento(string xcodigo_conta,
                                        string xlancamento,
                                        string xproduto,
                                        string xclasse,
                                        string xpedido_compra,
                                        string xdata,
                                        string xdescricao,
                                        string xcomplemento,
                                        string xsaldo_i,
                                        string xcredito,
                                        string xdebito,
                                        string xsaldo_f,
                                        string xsaldo_aplicacaoD,
                                        string xsaldo_aplicacaoB,
                                        string xsaldo_total,
                                        string xcheque,
                                        string xcmc7,
                                        string xdtregistro)
    {

        if (xcodigo_conta != String.Empty)
        {
            string script = "INSERT INTO conta_" + Srelib.QStr0(xcodigo_conta.Trim(), 5) + " VALUES ( " +
                            Srelib.QStr(xcodigo_conta) +
                            ", " + Srelib.QStr(xlancamento) +
                            ", " + Srelib.QStr(xproduto) +
                            ", " + Srelib.QStr(xclasse) +
                            ", " + Srelib.QStr(xpedido_compra) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdata)) +
                            ", " + Srelib.QStr(xdescricao) +
                            ", " + Srelib.QStr(xcomplemento) +
                            ", " + Srelib.forcaponto(xsaldo_i) +
                            ", " + Srelib.forcaponto(xcredito) +
                            ", " + Srelib.forcaponto(xdebito) +
                            ", " + Srelib.forcaponto(xsaldo_f) +
                            ", " + Srelib.forcaponto(xsaldo_aplicacaoD) +
                            ", " + Srelib.forcaponto(xsaldo_aplicacaoB) +
                            ", " + Srelib.forcaponto(xsaldo_total) +
                            ", " + Srelib.QStr(xcheque) +
                            ", " + Srelib.QStr(xcmc7) +
                            ", " + Srelib.QStr(Srelib.DataAmericanasembarra(xdtregistro)) +
                            " ) ";

            SreDblib.ExecScript(script);
        }
        return " ";
    }

    public static String PegaSaldoInicialDataMigracao(string xcodigo_conta)
    {
        string script = "select top 1 data from conta_" + Srelib.QStr0(xcodigo_conta.Trim(), 5) +
                        " with(nolock) order by data ";
        string retorno = "";
        try
        {
            retorno = SreDblib.GetCampoScript(script);
            if (retorno.Trim() == String.Empty)
            {
                retorno = "01/01/1900";
            }
        }
        catch (Exception)
        {
            retorno = "01/01/1900";
        }
        return retorno;
    }

    public static String PegaSaldoFinalDataAnterior(string xcodigo_conta,
                                                    DateTime xdata,
                                                    ref string xsaldo_f,
                                                    ref string xsaldo_aplicacaoD,
                                                    ref string xsaldo_aplicacaoB)
    {
        //
        DataSet ds;
        string script = "select TOP 1 * from conta_" + Srelib.QStr0(xcodigo_conta.Trim(), 5) +
                        " with(nolock) " +
                        " Where " +
                        " data < " + Srelib.QStr(Srelib.DataAmericanasembarra(Convert.ToString(xdata).Substring(0, 10))) +
                        " order by ID DESC ";
        ds = SreDblib.GetDsScript(script);
        //
        if (ds.Tables[0].Rows.Count > 0)
        {
            //Faz caso exista lançamentos anteriores a data
            //
            xsaldo_f = ds.Tables[0].Rows[0]["saldo_f"].ToString().Trim();
            xsaldo_aplicacaoD = ds.Tables[0].Rows[0]["saldo_aplicacaoD"].ToString().Trim();
            xsaldo_aplicacaoB = ds.Tables[0].Rows[0]["saldo_aplicacaoB"].ToString().Trim();
        }
        else
        {
            //
            xsaldo_f = uContas.PegaSaldoInicial(xcodigo_conta);
            xsaldo_aplicacaoD = uContas.PegaSaldoInicialsaldo_aplicacaoD(xcodigo_conta);
            xsaldo_aplicacaoB = uContas.PegaSaldoInicialsaldo_aplicacaoB(xcodigo_conta);

        }
        return "";
    }

    public static String PegaContaDescricao(string xcodigo_conta)
    {
        DataSet ds;

        string script = "select id, cod_banco,cod_agencia,cod_conta,nome_agencia from CONTAS " +
                        " with(nolock) " +
                        " where ID = " + xcodigo_conta +
                        " order by id ";
        string retorno = "";

        ds = SreDblib.GetDsScript(script);

        try
        {
            retorno = ds.Tables[0].Rows[0]["ID"].ToString().Trim() + " - " +
                      ds.Tables[0].Rows[0]["cod_banco"].ToString().Trim() + " - " +
                      ds.Tables[0].Rows[0]["cod_agencia"].ToString().Trim() + " - " +
                      ds.Tables[0].Rows[0]["cod_conta"].ToString().Trim() + " - " +
                      ds.Tables[0].Rows[0]["nome_agencia"].ToString().Trim();
        }
        catch (Exception)
        {
            retorno = "0";
        }


        return retorno;
    }

    public static String PegaContaDescricaoSimples(string xcodigo_conta)
    {
        DataSet ds;

        string script = "select id, cod_banco,cod_agencia,cod_conta,nome_agencia from CONTAS " +
                        " with(nolock) " +
                        " where ID = " + xcodigo_conta +
                        " order by id ";
        string retorno = "";

        ds = SreDblib.GetDsScript(script);

        try
        {
            retorno = ds.Tables[0].Rows[0]["nome_agencia"].ToString().Trim();
        }
        catch (Exception)
        {
            retorno = "0";
        }


        return retorno;
    }

    public static String PegaContaCodigoBanco(string xcodigo_conta)
    {
        DataSet ds;

        string script = "select cod_banco from CONTAS " +
                        " with(nolock) " +
                        " where ID = " + xcodigo_conta +
                        " order by id ";
        string retorno = "";

        ds = SreDblib.GetDsScript(script);

        try
        {
            retorno = ds.Tables[0].Rows[0]["cod_banco"].ToString().Trim();
        }
        catch (Exception)
        {
            retorno = "0";
        }


        return retorno;
    }

    public static String PegaNovoID()
    {
        //
        string script = "SELECT MAX(ID) + 1  FROM CONTAS WITH(NOLOCK)";
        //
        return SreDblib.GetCampoScript(script);
        //
    }

    public static String PegaSaldoInicialMigracao(string xcodigo_conta)
    {
        string script = "select top 1 saldo_i from conta_" + Srelib.QStr0(xcodigo_conta.Trim(), 5) +
                        " with(nolock) order by data ";
        string retorno = "";
        try
        {
            retorno = SreDblib.GetCampoScript(script);
        }
        catch (Exception)
        {
            retorno = "0.00";
        }
        return retorno;
    }

    public static String PegaSaldoInicialAplicacaoDMigracao(string xcodigo_conta)
    {
        string script = "select top 1 saldo_aplicacaoD from conta_" + Srelib.QStr0(xcodigo_conta.Trim(), 5) +
                        " with(nolock) order by data ";
        string retorno = "";
        try
        {
            retorno = SreDblib.GetCampoScript(script);
        }
        catch (Exception)
        {
            retorno = "0.00";
        }
        return retorno;
    }

    public static String PegaSaldoInicialAplicacaoBMigracao(string xcodigo_conta)
    {
        string script = "select top 1 saldo_aplicacaoB from conta_" + Srelib.QStr0(xcodigo_conta.Trim(), 5) +
                        " with(nolock) order by data ";
        string retorno = "";
        try
        {
            retorno = SreDblib.GetCampoScript(script);
        }
        catch (Exception)
        {
            retorno = "0.00";
        }
        return retorno;
    }

    public static String PegaSaldoInicial(string xcodigoconta)
    {
        string script = "select saldo_i from contas_saldo_inicial " +
                        " with(nolock) " +
                        " where cod_conta = " + Srelib.QStr0(xcodigoconta.Trim(), 5);
        string retorno = "";
        try
        {
            retorno = SreDblib.GetCampoScript(script);
        }
        catch (Exception)
        {
            retorno = "0.00";
        }
        return retorno;
    }

    public static String PegaSaldoInicialsaldo_aplicacaoD(string xcodigoconta)
    {
        string script = "select saldo_aplicacaoD from contas_saldo_inicial " +
                        " with(nolock) " +
                        " where cod_conta = " + Srelib.QStr0(xcodigoconta.Trim(), 5);
        string retorno = "";
        try
        {
            retorno = SreDblib.GetCampoScript(script);
        }
        catch (Exception)
        {
            retorno = "0.00";
        }
        return retorno;
    }

    public static String PegaSaldoInicialsaldo_aplicacaoB(string xcodigoconta)
    {
        string script = "select saldo_aplicacaoB from contas_saldo_inicial " +
                        " with(nolock) " +
                        " where cod_conta = " + Srelib.QStr0(xcodigoconta.Trim(), 5);
        string retorno = "";
        try
        {
            retorno = SreDblib.GetCampoScript(script);
        }
        catch (Exception)
        {
            retorno = "0.00";
        }
        return retorno;
    }

    public static String PegaLimite(string xcodigoconta)
    {
        string script = "select limite_cheque from contas " +
                        " with(nolock) " +
                        " where ID = " + Srelib.QStr0(xcodigoconta.Trim(), 5);
        string retorno = "";
        try
        {
            retorno = SreDblib.GetCampoScript(script);
        }
        catch (Exception)
        {
            retorno = "0.00";
        }
        return retorno;
    }

    public static String PegaAgencia(string xcodigoconta)
    {
        string script = "select cod_agencia from contas " +
                        " with(nolock) " +
                        " where ID = " + Srelib.QStr0(xcodigoconta.Trim(), 5);
        string retorno = "";
        try
        {
            retorno = SreDblib.GetCampoScript(script);
        }
        catch (Exception)
        {
            retorno = "";
        }
        return retorno;
    }

    public static String PegaConta(string xcodigoconta)
    {
        string script = "select cod_conta from contas " +
                        " with(nolock) " +
                        " where ID = " + Srelib.QStr0(xcodigoconta.Trim(), 5);
        string retorno = "";
        try
        {
            retorno = SreDblib.GetCampoScript(script);
        }
        catch (Exception)
        {
            retorno = "";
        }
        return retorno;
    }

    public static String PegaComplemento(string xcodigoconta)
    {
        string script = "select complemento from contas " +
                        " with(nolock) " +
                        " where ID = " + Srelib.QStr0(xcodigoconta.Trim(), 5);
        string retorno = "";
        try
        {
            retorno = SreDblib.GetCampoScript(script);
        }
        catch (Exception)
        {
            retorno = "";
        }
        return retorno;
    }

    public static DateTime PegaDataInicial(string xcodigoconta)
    {
        string script = "select data from contas_saldo_inicial " +
                        " with(nolock) " +
                        " where cod_conta = " + Srelib.QStr0(xcodigoconta.Trim(), 5);
        //
        DateTime retorno = Convert.ToDateTime("01/01/1900");
        try
        {
            retorno = Convert.ToDateTime(SreDblib.GetCampoScript(script));
        }
        catch (Exception)
        {
            retorno = Convert.ToDateTime("01/01/1900");
        }
        return retorno;
    }

    public static DataSet PegaDadosContas(Int32 xID)
    {
        string script;

        if (xID == 0)
        {
            script = "SELECT * FROM contas WITH(NOLOCK) order by cod_banco";
        }
        else
        {
            script = "SELECT * FROM contas WITH(NOLOCK) WHERE ID = " + Convert.ToString(xID) + " order by cod_banco";
        }

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosContasSaldoInicial(Int32 xID)
    {
        string script;

        if (xID == 0)
        {
            script = "SELECT * FROM contas_saldo_inicial WITH(NOLOCK) order by REPLICATE('0', 2 - LEN(cod_conta)) + CAST(cod_conta AS varchar)";
        }
        else
        {
            script = "SELECT * FROM contas_saldo_inicial WITH(NOLOCK) WHERE ID = " + Convert.ToString(xID) + " order by REPLICATE('0', 2 - LEN(cod_conta)) + CAST(cod_conta AS varchar)";
        }

        return SreDblib.GetDsScript(script);

    }

    public static DataSet PegaDadosConta(string xcodigoconta,
                                         string xdataini,
                                         string xdatafim)
    {
        string script = "";
        string nomearquivo = "conta_" + Srelib.QStr0(xcodigoconta.Trim(), 5);

        script = "SELECT *, (saldo_f+saldo_aplicacaoD+saldo_aplicacaoB) saldo_finalaplicacao FROM " + nomearquivo + " WITH(NOLOCK) ";
        script = script + " WHERE ";
        //Conta
        script = script + " ( cod_conta = " + Srelib.QStr(xcodigoconta) + ") ";
        //Data Prevista
        script = script + " AND ";
        script = script + " (data between " + Srelib.QStr(Srelib.DataAmericanasembarra(xdataini)) + " and " +
                           Srelib.QStr(Srelib.DataAmericanasembarra(xdatafim)) + ") ";
        //script = script + " (data >= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdataini));
        //script = script + " and data <= " + Srelib.QStr(Srelib.DataAmericanasembarra(xdatafim)) + ") ";

        //Data Nota Fiscal
        script = script + " order by data ";


        return SreDblib.GetDsScript(script);

    }


    //public static DataSet PegaUltimoSaldoContas()
    //{
    //    DataSet dsConta;
    //    String script = "";
    //    string nomearquivo = "contas";
    //    string xcodigoconta = "";

    //    script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) ";
    //    script = script + " order by ID ";

    //    dsConta = SreDblib.GetDsScript(script);
    //    script = "";

    //    for (int i = 0; i < dsConta.Tables[0].Rows.Count - 1; i++)
    //    {
    //        nomearquivo = "";
    //        xcodigoconta = dsConta.Tables[0].Rows[i]["ID"].ToString().Trim();

    //        nomearquivo = "conta_" + Srelib.QStr0(xcodigoconta.Trim(), 5);
    //        script = "";
    //        script = script + " SELECT data, cod_conta, saldo_i, credito, debito, saldo_f, saldo_aplicacaoD, saldo_aplicacaoB, (saldo_f+saldo_aplicacaoD+saldo_aplicacaoB) saldo_finalaplicacao FROM ";
    //        script = script + nomearquivo + " WITH(NOLOCK) ";
    //        script = script + " WHERE ID = (select TOP 1 ID from " + nomearquivo + " ORDER BY ID DESC) ";

    //        if (i + 1 < (dsConta.Tables[0].Rows.Count - 1))
    //        {
    //            script = script + " UNION ALL ";
    //        }
    //    }

    //    return SreDblib.GetDsScript(script);

    //}

    public static DataSet PegaUltimoSaldoContas()
    {
        DataSet dsConta;
        DataSet dsSaldo;
        String script = "";
        string nomearquivo = "contas";
        string xcodigoconta = "";
        script = "";
        //
        script = "SELECT * FROM " + nomearquivo + " WITH(NOLOCK) ";
        script = script + " order by ID ";
        //
        dsConta = SreDblib.GetDsScript(script);
        //
        //string xdata = "01/01/1900";
        //string xcod_conta = "0";
        //string xsaldo_i = "0";
        //string xcredito = "0";
        //string xdebito = "0";
        //string xsaldo_f = "0";
        //string xsaldo_aplicacaoD = "0";
        //string xsaldo_aplicacaoB = "0";
        //string xsaldo_finalaplicacao = "0";

        //
        DataTable table1 = new DataTable("table1");
        table1.Columns.Add("data");
        table1.Columns.Add("cod_conta");
        table1.Columns.Add("saldo_i");
        table1.Columns.Add("credito");
        table1.Columns.Add("debito");
        table1.Columns.Add("saldo_f");
        table1.Columns.Add("saldo_aplicacaoD");
        table1.Columns.Add("saldo_aplicacaoB");
        table1.Columns.Add("saldo_finalaplicacao");
        //
        for (int i = 0; i < dsConta.Tables[0].Rows.Count - 1; i++)
        {
            nomearquivo = "";
            xcodigoconta = dsConta.Tables[0].Rows[i]["ID"].ToString().Trim();

            nomearquivo = "conta_" + Srelib.QStr0(xcodigoconta.Trim(), 5);
            script = "";
            script = script + " SELECT data, cod_conta, saldo_i, credito, debito, saldo_f, saldo_aplicacaoD, saldo_aplicacaoB, (saldo_f+saldo_aplicacaoD+saldo_aplicacaoB) saldo_finalaplicacao FROM ";
            script = script + nomearquivo + " WITH(NOLOCK) ";
            script = script + " WHERE ID = (select TOP 1 ID from " + nomearquivo + " ORDER BY ID DESC) ";

            dsSaldo = SreDblib.GetDsScript(script);
            //
            if (dsSaldo.Tables[0].Rows.Count > 0)
            {
                table1.Rows.Add(dsSaldo.Tables[0].Rows[0]["data"].ToString().Trim(),
                dsSaldo.Tables[0].Rows[0]["cod_conta"].ToString().Trim(),
                dsSaldo.Tables[0].Rows[0]["saldo_i"].ToString().Trim(),
                dsSaldo.Tables[0].Rows[0]["credito"].ToString().Trim(),
                dsSaldo.Tables[0].Rows[0]["debito"].ToString().Trim(),
                dsSaldo.Tables[0].Rows[0]["saldo_f"].ToString().Trim(),
                dsSaldo.Tables[0].Rows[0]["saldo_aplicacaoD"].ToString().Trim(),
                dsSaldo.Tables[0].Rows[0]["saldo_aplicacaoB"].ToString().Trim(),
                dsSaldo.Tables[0].Rows[0]["saldo_finalaplicacao"].ToString().Trim());
            }
        }
        //
        //
        DataSet ds = new DataSet("table");
        ds.Tables.Add(table1);
        //
        return ds;
        //
    }

    public static String GeraLancamentos(string xcodigoconta,
                                         string xdtperiodo1,
                                         string xdtperiodo2,
                                         Boolean xckchequedeposito,
                                         Boolean xckfornecedor)
    {
        //
        string nomearquivo = "conta_" + Srelib.QStr0(xcodigoconta.Trim(), 5);
        DateTime data = Convert.ToDateTime(xdtperiodo1);
        DataSet dscontasapagar;
        DataSet dscontasareceber;
        string saldo_f_corrente = "";
        //
        string lancamento = "";
        string produto = "";
        string classe = "";
        string pedido_compra = "";
        string descricao = "";
        string complemento = "";
        string saldo_i = "";
        string credito = "";
        string debito = "";
        string saldo_f = "";
        string saldo_aplicacaoD = "";
        string saldo_aplicacaoB = "";
        string saldo_total = "";
        string cheque = "";
        string cmc7 = "";
        DateTime dtregistro = Convert.ToDateTime("01/01/1900");
        //
        //Saldo Inicial do Período
        string inicial_saldo_f = "";
        string inicial_saldo_aplicacaoD = "";
        string inicial_saldo_aplicacaoB = "";
        //
        uContas.PegaSaldoFinalDataAnterior(xcodigoconta,
                                           data,
                                           ref inicial_saldo_f,
                                           ref inicial_saldo_aplicacaoD,
                                           ref inicial_saldo_aplicacaoB);
        //
        saldo_i = inicial_saldo_f;
        saldo_aplicacaoD = inicial_saldo_aplicacaoD;
        saldo_aplicacaoB = inicial_saldo_aplicacaoB;
        //
        //Apagar Lançamentos Conta
        uContas.ExcluiLancamentos(xcodigoconta,
                                  xdtperiodo1,
                                  xdtperiodo2);
        //
        //Geração
        while (data <= Convert.ToDateTime(xdtperiodo2))
        {
            //Contas á Receber
            //
            dscontasareceber = uContasReceber.PegaDadosCReceber("",
                                                                "",
                                                                "",
                                                                xcodigoconta,
                                                                "01/01/1900",
                                                                "31/12/2999",
                                                                data.ToString().Substring(0, 10),
                                                                data.ToString().Substring(0, 10),
                                                                "01/01/1900",
                                                                "31/12/2999",
                                                                "",
                                                                "R",
                                                                "DR",
                                                                false,
                                                                false
                                                                );
            //
            for (int row0 = 0; row0 < dscontasareceber.Tables[0].Rows.Count; row0++)
            {
                //
                lancamento = dscontasareceber.Tables[0].Rows[row0]["lancamento"].ToString().Trim();
                produto = dscontasareceber.Tables[0].Rows[row0]["produto"].ToString().Trim();
                classe = dscontasareceber.Tables[0].Rows[row0]["classe"].ToString().Trim();
                descricao = Srelib.tiraacento(dscontasareceber.Tables[0].Rows[row0]["descricao"].ToString().Trim());
                //
                credito = dscontasareceber.Tables[0].Rows[row0]["vlr_realizado"].ToString().Trim();
                debito = "0";
                //
                saldo_f_corrente = "";
                saldo_f_corrente = Convert.ToString(Convert.ToDecimal(saldo_i) +
                                   Convert.ToDecimal(credito));
                //
                saldo_f = saldo_f_corrente;
                //
                if (Convert.ToInt64(classe) == -1)
                {
                    saldo_aplicacaoD = Convert.ToString(Convert.ToDecimal(saldo_aplicacaoD) - Convert.ToDecimal(credito));

                }
                //
                if (Convert.ToInt64(classe) == -2)
                {

                    saldo_aplicacaoB = Convert.ToString(Convert.ToDecimal(saldo_aplicacaoB) - Convert.ToDecimal(credito));
                }
                //
                saldo_total = Convert.ToString(Convert.ToDecimal(saldo_f) + Convert.ToDecimal(saldo_aplicacaoD) + Convert.ToDecimal(saldo_aplicacaoB));
                cheque = dscontasareceber.Tables[0].Rows[row0]["cheque"].ToString().Trim();
                cmc7 = dscontasareceber.Tables[0].Rows[row0]["cheque"].ToString().Trim();
                dtregistro = DateTime.Now;

                if (xcodigoconta != String.Empty)
                {
                    uContas.GravaLancamento(xcodigoconta,
                                            lancamento,
                                            produto,
                                            classe,
                                            pedido_compra,
                                            Convert.ToString(data),
                                            descricao,
                                            complemento,
                                            saldo_i,
                                            credito,
                                            debito,
                                            saldo_f,
                                            saldo_aplicacaoD,
                                            saldo_aplicacaoB,
                                            saldo_total,
                                            cheque,
                                            cmc7,
                                            Convert.ToString(dtregistro)
                                            );

                }

                lancamento = "";
                produto = "";
                classe = "";
                pedido_compra = "";
                descricao = "";
                complemento = "";
                saldo_i = saldo_f;
                credito = "";
                debito = "";
                saldo_f = "";
                //saldo_aplicacaoD = "";
                //saldo_aplicacaoB = "";
                saldo_total = "";
                cheque = "";
                cmc7 = "";
                dtregistro = Convert.ToDateTime("01/01/1900");
                //
            }
            dscontasareceber.Clear();
            //Fim Contas á Receber
            //
            //Contas á Pagar
            //
            dscontasapagar = uContasPagar.PegaDadosCPagar("",
                                                          "",
                                                          "",
                                                          xcodigoconta,
                                                          "01/01/1900",
                                                          "31/12/2999",
                                                          data.ToString().Substring(0, 10),
                                                          data.ToString().Substring(0, 10),
                                                          "01/01/1900",
                                                          "31/12/2999",
                                                          "",
                                                          "R",
                                                          "DR",
                                                          false,
                                                          false
                                                          );
            //
            //
            for (int row0 = 0; row0 < dscontasapagar.Tables[0].Rows.Count; row0++)
            {
                //
                lancamento = dscontasapagar.Tables[0].Rows[row0]["lancamento"].ToString().Trim();
                produto = dscontasapagar.Tables[0].Rows[row0]["produto"].ToString().Trim();
                classe = dscontasapagar.Tables[0].Rows[row0]["classe"].ToString().Trim();
                descricao = Srelib.tiraacento(dscontasapagar.Tables[0].Rows[row0]["descricao"].ToString().Trim());
                //
                credito = "0";
                debito = dscontasapagar.Tables[0].Rows[row0]["vlr_realizado"].ToString().Trim();
                //
                saldo_f_corrente = "";
                saldo_f_corrente = Convert.ToString(Convert.ToDecimal(saldo_i) -
                                   Convert.ToDecimal(debito));
                //
                saldo_f = saldo_f_corrente;
                //
                if (Convert.ToInt64(classe) == -1)
                {
                    saldo_aplicacaoD = Convert.ToString(Convert.ToDecimal(saldo_aplicacaoD) + Convert.ToDecimal(debito));

                }
                //
                if (Convert.ToInt64(classe) == -2)
                {

                    saldo_aplicacaoB = Convert.ToString(Convert.ToDecimal(saldo_aplicacaoB) + Convert.ToDecimal(debito));
                }
                //
                saldo_total = Convert.ToString(Convert.ToDecimal(saldo_f) + Convert.ToDecimal(saldo_aplicacaoD) + Convert.ToDecimal(saldo_aplicacaoB));
                cheque = dscontasapagar.Tables[0].Rows[row0]["cheque"].ToString().Trim();
                cmc7 = dscontasapagar.Tables[0].Rows[row0]["cheque"].ToString().Trim();
                dtregistro = DateTime.Now;

                if (xcodigoconta != String.Empty)
                {
                    uContas.GravaLancamento(xcodigoconta,
                                            lancamento,
                                            produto,
                                            classe,
                                            pedido_compra,
                                            Convert.ToString(data),
                                            descricao,
                                            complemento,
                                            saldo_i,
                                            credito,
                                            debito,
                                            saldo_f,
                                            saldo_aplicacaoD,
                                            saldo_aplicacaoB,
                                            saldo_total,
                                            cheque,
                                            cmc7,
                                            Convert.ToString(dtregistro)
                                            );

                }

                lancamento = "";
                produto = "";
                classe = "";
                pedido_compra = "";
                descricao = "";
                complemento = "";
                saldo_i = saldo_f;
                credito = "";
                debito = "";
                saldo_f = "";
                //saldo_aplicacaoD = "";
                //saldo_aplicacaoB = "";
                saldo_total = "";
                cheque = "";
                cmc7 = "";
                dtregistro = Convert.ToDateTime("01/01/1900");
                //
            }
            dscontasapagar.Clear();
            //Fim Contas á Receber

            //Proxima Data
            data = data.AddDays(1);
        }

        return " ";

    }



    public uContas()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}