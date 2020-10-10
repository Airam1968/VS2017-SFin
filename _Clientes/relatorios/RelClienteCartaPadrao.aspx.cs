using System;
using System.Data;
using System.Web.UI;

public partial class RelClienteMalaDireta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        ScriptManager.RegisterStartupScript(this, typeof(string), "MAXIMIZE", "top.window.moveTo(0,0); top.window.resizeTo(screen.availWidth,screen.availHeight);", true);

        RepClienteCartaPadrao report = new RepClienteCartaPadrao();
        // Use SqlDataAdapter to define and populate a DataSet using the information extracted from a Session vairable

        // EMPRESA MATRIZ
        report.lassinatura.Text = uEmpresa.PegaNome(uEmpresa.PegaMatriz());
        // DATA
        report.ldata.Text = uEmpresa.PegaCidade(uEmpresa.PegaMatriz()) + ", " + Srelib.DataExtenso(DateTime.Now);
        // CLIENTES
        string clientes = Convert.ToString(Session["cbclientes"]);
        // CARTAS
        string cartas = Convert.ToString(Session["cbcartas"]);
        report.carta = cartas;
        // USUÁRIO
        string usuario = Convert.ToString(Session["CodUsuario"]);
        //
        // rbfiltro
        string rbfiltro = Convert.ToString(Session["rbfiltro"]);
        //Produto
        string cbproduto = Convert.ToString(Session["cbproduto"]);
        //
        //Grupo
        string cbprodutogrupo = Convert.ToString(Session["cbprodutogrupo"]);
        //
        //Mês Aniversário
        string cbmes = Convert.ToString(Session["cbmes"]);
        //
        //Data Limite
        string dtprevisao1 = Convert.ToString(Session["dtprevisao1"]);
        //

        DataSet ds;

        if (rbfiltro == "0")
        {
            //Aniversariantes
            ds = uContato.PegaDadosContatoAniversariante(cbmes.Trim());

        }
        else
        {
            if (rbfiltro == "1")
            {
                //Clientes Produto
                ds = uContato.PegaDadosContatoProduto(cbproduto, cbprodutogrupo, dtprevisao1);

            }
            else
            {
                if (rbfiltro == "2")
                {
                    //Devedores
                    ds = uContato.PegaDadosContatoDevedores(cbproduto, cbprodutogrupo, dtprevisao1);
                }
                else
                {
                    //Filtro Desligado
                    ds = uContato.PegaDadosContato(clientes, "","0");
                }
            }
        }

        report.DataSource = ds;
        report.DataMember = ds.Tables[0].TableName;
        report.lnome.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "nome")});
        //
        //report.lendereco.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
        //    new DevExpress.XtraReports.UI.XRBinding("Text", null, "enderecocom")});


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