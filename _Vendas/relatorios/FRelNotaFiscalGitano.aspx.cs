using System;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;

public partial class FRelNotaFiscalGitano : System.Web.UI.Page
{
    //DataSet dsproduto;                                    // DATASETS DOS LOOKUPS TEM QUE SER CRIADOS AQUI  ====================================================================================
    String login_usuario;
    Boolean lImprime = false;
    String fwObs_Log = "";
    String fWtabela = "PARCELAS";


    protected void Page_Init(object sender, EventArgs e)  // CARGA DOS LOOKUPS TEM QUE SER FEITA NESTE EVENTO  ====================================================================================
    {
        login_usuario = Convert.ToString(Session["usuario"]);
        lImprime = true; //SreDbLib.TemPermissao("001.070.080.001", (String)Session["CodUsuario"]);

        // CARGA DE UM LOOKUP  ===============================================================================================================================================
        // lookupempresa
        cbproduto.Items.Clear();
        uProduto.MontaComboProduto(cbproduto, true);
        // FIM CARGA DE UM LOOKUP  ===============================================================================================================================================
        //
        dtprevisao1.Date = DateTime.Now.AddMonths(1);
        dtprevisao2.Date = DateTime.Now.AddMonths(1);
        //
        dtdataemissao.Date = DateTime.Now;
        //
        cbcontacorrente.Items.Clear();
        uContas.MontaComboContas(cbcontacorrente, "0");
        //
        ednotafiscal.Text = uParametros.PegaParametro("PROXIMA NOTA FISCAL");
        //
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if ((String)Session["IdSessao"] == null)
        {
            Session.Add("fimdesessao", "A Sessão foi expirada, reinicie o sistema!");
            Server.Transfer("~\\LoginTimeOut.aspx");
        }

        if (!Page.IsPostBack)
        {
            login_usuario = Convert.ToString(Session["usuario"]);
            lImprime = true; //SreDbLib.TemPermissao("001.070.080.001", (String)Session["CodUsuario"]);
            //
            dtprevisao1.Date = DateTime.Now.AddMonths(1);
            dtprevisao2.Date = DateTime.Now.AddMonths(1);
            //
            cbcontacorrente.Items.Clear();
            uContas.MontaComboContas(cbcontacorrente,"0");
        }
    }

    protected void btImpressao_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;
        string tst = "";
        ////CRITICAS

        if (lOk)
        {
            //CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================
            //Produto
            Session.Remove("cbproduto");
            if (cbproduto.Text != string.Empty)
            {
                Session.Add("cbproduto", cbproduto.Value.ToString().Trim());
                tst = cbproduto.Value.ToString().Trim();
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Nenhum Produto Selecionado!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Nenhum Produto Selecionado!', 'Atenção!')", true);
            }
        }
        if (lOk)
        {
            //Grupo
            Session.Remove("cbgrupo");
            if (cbgrupo.Text != string.Empty)
            {
                Session.Add("cbgrupo", cbgrupo.Value.ToString().Trim());
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Nenhum Grupo Selecionado!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Nenhum Grupo Selecionado!', 'Atenção!')", true);
            }
        }
        if (lOk)
        {

            //Unidades
            Session.Remove("cbgrupounidades");
            if (cbgrupounidades.Text != string.Empty)
            {
                Session.Add("cbgrupounidades", cbgrupounidades.Value.ToString().Trim());
                //Parte
                Session.Remove("parte");
                Session.Add("parte", "0");
            }
            else
            {
                Session.Add("cbgrupounidades", "");
                //Parte
                Session.Remove("parte");
                Session.Add("parte", "0");
                //lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Nenhuma Unidade Selecionada!');", true);
            }
        }
        if (lOk)
        {
            //Previsão
            Session.Remove("dtprevisao1");
            Session.Remove("dtprevisao2");
            if (dtprevisao1.Text != string.Empty)
            {
                Session.Add("dtprevisao1", dtprevisao1.Value.ToString().Trim());
            }
            else
            {
                Session.Add("dtprevisao1", "01/01/1900");
            }
            //
            if (dtprevisao2.Text != string.Empty)
            {
                Session.Add("dtprevisao2", dtprevisao2.Value.ToString().Trim());
            }
            else
            {
                Session.Add("dtprevisao2", "31/12/2999");
            }
        }
        if (lOk)
        {
            //
            //cbcontacorrente
            Session.Remove("cbcontacorrente");
            if (cbcontacorrente.Text != string.Empty)
            {
                Session.Add("cbcontacorrente", cbcontacorrente.Value.ToString().Trim());
            }
            else
            {
                Session.Add("cbcontacorrente", "0");
            }
        }
        if (lOk)
        {
            //cbcliente
            Session.Remove("cbcliente");
            string cliente = "";
            string grupounidades = cbgrupounidades.Text;
            string parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
            if ((cbproduto.Value.ToString() != string.Empty) &&
                (cbgrupo.Value.ToString() != string.Empty) &&
                (cbgrupounidades.Value != null) &&
                (parte != string.Empty))
            {
                cliente = uUnidade.PegaIDCliente(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, "1");
            }
            //
            if (cliente != string.Empty)
            {
                Session.Add("cbcliente", cliente);
            }
            else
            {
                Session.Add("cbcliente", "");
            }
            //
        }
        if (lOk)
        {
            //rbparcelasituacao
            Session.Remove("rbparcelasituacao");
            Session.Add("rbparcelasituacao", rbparcelasituacao.SelectedIndex.ToString());
            //
        }
        if (lOk)
        {
            //ckimprimecarteira
            Session.Remove("ckimprimecarteira");
            Session.Add("ckimprimecarteira", ckimprimecarteira.Checked.ToString());
            //
        }
        if (lOk)
        {
            //ckimprimeseparado
            Session.Remove("ckimprimeseparado");
            Session.Add("ckimprimeseparado", ckimprimeseparado.Checked.ToString());
            //
        }
        if (lOk)
        {
            //edproximanotafiscal
            Session.Remove("edproximanotafiscal");
            Session.Add("edproximanotafiscal", ednotafiscal.Text);
            //
            //dtdataemissao
            Session.Remove("dtdataemissao");
            Session.Add("dtdataemissao", dtdataemissao.Value.ToString().Trim());
            //
            //
            //FIM CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================
        }

        if (lOk)
        {
            //Usando Classe uLog.MakeLog - Gravando Log
            fwObs_Log = "RELATÓRIO NOTAS FISCAL: " + tst;
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "RELATÓRIO"                           ),
                                         new SqlParameter("@obs"      , "RELATÓRIO NOTAS FISCAL"              ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);

            // FIM CRIA LOG RELATÓRIO  ===============================================================================================================================================

            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpRuntime.AppDomainAppVirtualPath + "/_Vendas/relatorios/RelNotaFiscalGitano.aspx', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);

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
            Label23.Visible = true;
            cbgrupo.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
            dtprevisao1.Visible = true;
            dtprevisao2.Visible = true;
            Label14.Visible = true;
            cbcontacorrente.Visible = true;
            //
            Label1.Visible = true;
            rbparcelasituacao.Visible = true;
            Label3.Visible = true;
            ednotafiscal.Visible = true;
            Label6.Visible = true;
            dtdataemissao.Visible = true;
            Label9.Visible = true;
            ckimprimecarteira.Visible = true;
            Label10.Visible = false;
            ckimprimeseparado.Visible = false;
            //

            //
            cbgrupo.Focus();
        }
        else
        {
            Label23.Visible = false;
            cbgrupo.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            dtprevisao1.Visible = false;
            dtprevisao2.Visible = false;
            Label14.Visible = false;
            cbcontacorrente.Visible = false;
            //
            Label1.Visible = false;
            rbparcelasituacao.Visible = false;
            Label3.Visible = false;
            ednotafiscal.Visible = false;
            Label6.Visible = false;
            dtdataemissao.Visible = false;
            Label9.Visible = false;
            ckimprimecarteira.Visible = false;
            Label10.Visible = false;
            ckimprimeseparado.Visible = false;
        }

    }

    protected void cbgrupo_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            if (cbgrupo.Text != string.Empty)
            {
                //Combo Unidades
                cbgrupounidades.Items.Clear();
                //tipo = uProduto.PegaTipo(Convert.ToInt32(cbproduto.Value));
                uProduto.MontaComboUnidades(cbgrupounidades, Convert.ToString(cbproduto.Value).Trim(), Convert.ToString(cbgrupo.Value).Trim(), true);
                if (cbgrupounidades.Items.Count == 0)
                {
                    btImpressao.Enabled = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Não Há Unidades Disponíveis!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.info('Não Há Unidades Disponíveis!', 'Atenção!')", true);
                }
                Label7.Visible = true;
                cbgrupounidades.Visible = true;
            }
            else
            {
                Label2.Visible = true;
                cbgrupo.Visible = true;
                Label7.Visible = false;
                cbgrupounidades.Visible = false;
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

    protected void cbgrupounidades_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            if (cbgrupo.Text != string.Empty)
            {
                if (cbgrupounidades.Text != string.Empty)
                {
                    //Cliente
                    string grupounidades = cbgrupounidades.Text;
                    string parte = grupounidades.Substring(grupounidades.IndexOf("-") + 1).Trim();
                    string IDCliente = uUnidade.PegaIDCliente(cbproduto.Value.ToString(), cbgrupo.Value.ToString(), cbgrupounidades.Value.ToString(), parte, "1");
                    edcliente.Text = Srelib.QStr0(IDCliente.Trim(), 5) + " - " + uContato.PegaNomeID(IDCliente);
                    Label8.Visible = true;
                    edcliente.Visible = true;
                    //
                }
                else
                {
                    Label8.Visible = false;
                    edcliente.Visible = false;
                    //
                }
            }
        }
    }

    protected void cbcontacorrente_SelectedIndexChanged(object sender, EventArgs e)
    {
        //edmulta.Focus();
    }
}
