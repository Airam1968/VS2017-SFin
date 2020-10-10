using System;
using System.Data;
using System.Web.UI;

public partial class RelParcelas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepParcelas report = new RepParcelas();
        // Use SqlDataAdapter to define and populate a DataSet using the information extracted from a Session vairable

        // EMPRESA MATRIZ
        report.ltempresa.Text = uEmpresa.PegaNome(uEmpresa.PegaMatriz());

        // PRODUTO
        string produto = Convert.ToString(Session["cbproduto"]);
        // GRUPO
        string grupo = Convert.ToString(Session["cbgrupo"]);
        // UNIDADE
        string unidade = Convert.ToString(Session["cbgrupounidades"]);
        // PARTE
        string parte = Convert.ToString(Session["cbparte"]);
        //
        // ID PARCELA
        string id = Convert.ToString(Session["id"]);
        //
        // FORMA DE PAGAMENTO
        string formapagamento = Convert.ToString(Session["formapagamento"]);
        // CONTA CORRENTE
        string contacorrente = Convert.ToString(Session["cbcontacorrente"]);
        // PROPRIETARIO
        string cliente = Convert.ToString(Session["cbcliente"]);
        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        report.ltusuario.Text = "Usuário: " + usuario;
        //TITULO RECIBO
        string recibo = Convert.ToString(Session["PROXIMO RECIBO"]);
        report.recibo = Convert.ToInt64(recibo);
        //
        // RODAPÉ
        report.lcaminho.Text = "Gitano ->SGFin ->Pagamentos ->Recibo de Pagamento de Parcela";
        //
        DataSet ds;

        ds = uParcelas.PegaDadosParcelaID(produto,
                                          grupo,
                                          unidade,
                                          parte,
                                          id);
        //
        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;
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