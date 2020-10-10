using System;
using System.Data;
using System.Web.UI;

public partial class RelNotaFiscalGitano : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepNotaFiscalGitano report = new RepNotaFiscalGitano();
        // Use SqlDataAdapter to define and populate a DataSet using the information extracted from a Session vairable

        // PRODUTO
        string produto = Convert.ToString(Session["cbproduto"]);
        // GRUPO
        string grupo = Convert.ToString(Session["cbgrupo"]);
        // UNIDADE
        string unidade = Convert.ToString(Session["cbgrupounidades"]);
        // PARTE
        string parte = Convert.ToString(Session["parte"]);
        // CONTA CORRENTE
        string contacorrente = Convert.ToString(Session["cbcontacorrente"]);
        // PROPRIETARIO
        string cliente = Convert.ToString(Session["cbcliente"]);
        // IMPRIMIR CARTEIRA
        string carteira = Convert.ToString(Session["ckimprimecarteira"]);
        // IMPRIMIR SEPARADO
        Boolean separado = Convert.ToBoolean(Session["ckimprimeseparado"]);
        // PERIODO
        DateTime dtprevisao1 = Convert.ToDateTime(Session["dtprevisao1"]);
        DateTime dtprevisao2 = Convert.ToDateTime(Session["dtprevisao2"]);
        //report.lfperiodo.Text = dtprevisao1.Date.ToString().Substring(0, 10) + " até " + dtprevisao2.Date.ToString().Substring(0, 10);

        //rbparcelasituacao
        string rbparcelasituacao = Convert.ToString(Session["rbparcelasituacao"]);
        string rbparcelasituacao2 = "";
        if (rbparcelasituacao == "0")
            rbparcelasituacao2 = "T";
        if (rbparcelasituacao == "1")
            rbparcelasituacao2 = "P";
        if (rbparcelasituacao == "2")
            rbparcelasituacao2 = "A";
        //
        // NOTA FISCAL
        Int32 proximanotafiscal = Convert.ToInt32(Session["edproximanotafiscal"]);
        report.numeronota = proximanotafiscal;
        //
        // PERIODO
        DateTime dtdataemissao = Convert.ToDateTime(Session["dtdataemissao"]);
        report.dtemissao = dtdataemissao;
        //
        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        //report.ltusuario.Text = "Usuário: " + usuario;
        //
        DataSet ds;
        //
        ds = uParcelas.PegaDadosParcelasContabil(produto,
                                                 grupo,
                                                 unidade,
                                                 parte,
                                                 "1",
                                                 dtprevisao1.ToString().Substring(0, 10),
                                                 dtprevisao2.ToString().Substring(0, 10),
                                                 rbparcelasituacao2,
                                                 contacorrente,
                                                 "N",
                                                 "1",
                                                 carteira,
                                                 false
                                                 );
        //
        //
        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;

        if (!separado)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportViewer1.Report = report;
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Nada a Imprimir!');", true);
                Page.ClientScript.RegisterStartupScript(GetType(), "close", "self.close()", true);
            }
        }
        else
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //
                //Separar dados para o dataset um por um
                //
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportViewer1.Report = report;
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Nada a Imprimir!');", true);
                    Page.ClientScript.RegisterStartupScript(GetType(), "close", "self.close()", true);
                }
            }
        }
    }

}