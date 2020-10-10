using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FProdutoExcluir : System.Web.UI.Page
{
    DataSet dsunidade;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "PRODUTO_UNIDADES";

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.003.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.003.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.003.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.003.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lExclui;
        if (!lExclui)
            btprocessa.Image.ToolTip = Msg_acesso;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //Limpa Cache
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Cache.SetExpires(DateTime.Now);
        Response.Cache.SetNoServerCaching();
        Response.Cache.SetNoStore();
        //Fim Limpa Cache

        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Response.Redirect("~\\LoginTimeOut.aspx");
        }

        if (!Page.IsPostBack)
        {
            //Combo Empresas
            cbproduto.Items.Clear();
            uProduto.MontaComboProduto(cbproduto, false);
        }

    }


    protected void cbproduto_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            //Combo Grupo
            //string tipo = "";
            cbgrupo.Items.Clear();
            //tipo = uProduto.PegaTipo(Convert.ToInt32(cbproduto.Value));
            uProduto.MontaComboGrupo(cbgrupo, Convert.ToString(cbproduto.Value).Trim(), true);
            Label2.Visible = true;
            cbgrupo.Visible = true;
        }
        else
        {
            Label2.Visible = false;
            cbgrupo.Visible = false;
        }

    }

    private void AtualizaGrid()
    {
        lInsere = false; //SreDbLib.TemPermissao("001.070.080.001", (String)Session["CodUsuario"]);
        lAltera = true; //SreDbLib.TemPermissao("001.070.080.001", (String)Session["CodUsuario"]);
        lExclui = false; //SreDbLib.TemPermissao("001.070.080.001", (String)Session["CodUsuario"]);
    }

    protected void cbgrupo_SelectedIndexChanged(object sender, EventArgs e)
    {
        edunidades.Text = "";
        //
        if (cbproduto.Text != string.Empty)
        {
            if (cbgrupo.Text != string.Empty)
            {
                Int32 unidades = 0;
                string tipo = "";
                unidades = uProduto.PegaProdutoGrupoQuantidade(Convert.ToInt32(cbproduto.Value), Convert.ToInt32(cbgrupo.Value));
                tipo = uProduto.PegaTipoProdutoDescricao(Convert.ToInt32(cbproduto.Value));
                edunidades.Text = "O Sistema irá excluir (" + Convert.ToString(unidades).Trim() + ") unidades do tipo (" + tipo + "). Clique no botão Processar.";
                Label4.Visible = true;
                edunidades.Visible = true;
            }
            else
            {
                Label2.Visible = true;
                cbgrupo.Visible = true;
                Label4.Visible = false;
                edunidades.Visible = false;
            }
        }

    }



    protected void bthelp_Click(object sender, EventArgs e)
    {
        //
        //if (Popuphelp.IsCallback)
        {
            // Intentionally pauses server-side processing, 
            // to demonstrate the Loading Panel functionality.
            Thread.Sleep(1000);
        }
    }

    protected void btprocessa_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        //
        //Validação
        if (lOk)
        {
            string script = "select * from vendas with(nolock) where produto = " + cbproduto.Value.ToString() +
                            " and grupo = " + cbgrupo.Value.ToString();
            if (SreDblib.TemNaTabela(script))
            {
                lOk = false;
                edunidades.Text = "Exclusão Abortada! Existem vendas para o produto informado!";
            }
        }
        //

        if (lOk)
        {
            
            //Excluir
            uUnidade.Exclui(cbproduto.Value.ToString().Trim(),
                            cbgrupo.Value.ToString().Trim());

            //Alterar travas
            uProduto.AlteraGrupoCadastro(cbproduto.Value.ToString(),
                                         cbgrupo.Value.ToString(),
                                         false);

            edunidades.Text = "Concluído!";
        }

    }



    protected void ednumeracao_TextChanged(object sender, EventArgs e)
    {
        //

    }

}
