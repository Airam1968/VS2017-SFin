using System;

public partial class FundoPadrao : System.Web.UI.Page
{
    string Cnpj_corrente;

    protected void Page_Load(object sender, EventArgs e)
    {
        Cnpj_corrente = uEmpresa.PegaCnpj(uEmpresa.PegaMatriz());
        Cnpj_corrente = Srelib.QStr0(Cnpj_corrente, 14);
        //Gitano e Dado
        if (((Cnpj_corrente == "13305470000105")) || ((Cnpj_corrente == "62107453000179")))
        {
            Response.Redirect("~\\FundoPadraoMensagens.aspx");
        }
    }
}