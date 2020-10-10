using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;

public partial class FRelFCaixaMensal : System.Web.UI.Page
{
    DataSet dscontas;                                   // DATASETS DOS LOOKUPS TEM QUE SER CRIADOS AQUI  ====================================================================================
    String login_usuario;
    Boolean lImprime = false;
    String fwObs_Log = "";
    String fWtabela = "CONTAS_PAGAR";


    protected void Page_Init(object sender, EventArgs e)  // CARGA DOS LOOKUPS TEM QUE SER FEITA NESTE EVENTO  ====================================================================================
    {
        login_usuario = Convert.ToString(Session["usuario"]);
        lImprime = true; //SreDbLib.TemPermissao("001.070.080.001", (String)Session["CodUsuario"]);

        // CARGA DE UM LOOKUP  ===============================================================================================================================================
        //Combo Empresas
        cbproduto.Items.Clear();
        uProduto.MontaComboProduto(cbproduto, true);
        //
        //Combo Contas Correntes
        cbcontascorrentes.Items.Clear();
        uContas.MontaComboContas(cbcontascorrentes, "0");
        Label16.Visible = true;
        cbcontascorrentes.Visible = true;
        //
        // CARGA DE UM LOOKUP  ===============================================================================================================================================
        // lookupempresa
        dscontas = uContas.LookUpContas();    // Método que retorna o dataset com os campos pro lookup
        lookupempresa.DataSource = dscontas;
        lookupempresa.KeyFieldName = "ID";  // Campo Chave no dataset retornado
        lookupempresa.DataBind();
        // FIM CARGA DE UM LOOKUP  ===============================================================================================================================================
        //
        cbano.Items.Clear();
        Srelib.MontaComboAno(cbano, false);
        //
        cbmes.Items.Clear();
        Srelib.MontaComboMes(cbmes, true);
        //
        Label1.Visible = true;
        cbmes.Visible = true;
        //
        Label4.Visible = true;
        cbano.Visible = true;
        //
        Label5.Visible = true;
        edsaldo_inicial.Visible = true;
        //       
        Label9.Visible = true;
        ckmulticontas.Visible = true;
        lookupempresa.Visible = false;
        //
        Label6.Visible = true;
        ckaplicacoes.Visible = true;
        ckaplicacoes.Checked = true;
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
            //Combo Empresas
            cbproduto.Items.Clear();
            uProduto.MontaComboProduto(cbproduto, true);
            //
            //Combo Contas Correntes
            cbcontascorrentes.Items.Clear();
            uContas.MontaComboContas(cbcontascorrentes, "0");
            Label16.Visible = true;
            cbcontascorrentes.Visible = true;
            //
            cbano.Items.Clear();
            Srelib.MontaComboAno(cbano, false);
            //
            cbmes.Items.Clear();
            Srelib.MontaComboMes(cbmes, true);
            //
            Label1.Visible = true;
            cbmes.Visible = true;
            //
            Label4.Visible = true;
            cbano.Visible = true;
            //
            Label5.Visible = true;
            edsaldo_inicial.Visible = true;
            //     
            Label9.Visible = true;
            ckmulticontas.Visible = true;
            lookupempresa.Visible = false;
            //
            Label6.Visible = true;
            ckaplicacoes.Visible = true;
            ckaplicacoes.Checked = true;
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
                Session.Add("cbproduto", "");
                tst = "Todos";
                //lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Nenhum Produto Selecionado!');", true);
            }
        }
        if (lOk)
        {
            //
            //cbcontacorrente
            if (!ckmulticontas.Checked)
            {
                Session.Remove("cbcontacorrente");
                if (cbcontascorrentes.Text != string.Empty)
                {
                    Session.Add("cbcontacorrente", cbcontascorrentes.Value.ToString().Trim());
                }
                else
                {
                    Session.Add("cbcontacorrente", "");
                }
            }
            else
            {
                tst = "";
                Session.Remove("cbcontacorrente");
                List<object> cbcontascorrentes2 = lookupempresa.GetSelectedFieldValues(new string[] { "ID" });
                if (cbcontascorrentes2.Count != dscontas.Tables[0].Rows.Count)  // VERIFICA SE TODOS OS ELEMENTOS FORAM SELECIONADOS  ===============================================================================================================================================
                {
                    foreach (Int32 xval in cbcontascorrentes2)
                    {
                        if (tst != "")
                        {
                            tst = tst + ",";
                        }
                        tst = tst + xval.ToString().Trim();
                    }
                }
                else
                {
                    if ((cbcontascorrentes2.Count == 1) && (dscontas.Tables[0].Rows.Count == 1))
                    {
                        foreach (Int32 xval in cbcontascorrentes2)
                        {
                            if (tst != "")
                            {
                                tst = tst + ",";
                            }
                            tst = tst + xval.ToString().Trim();
                        }
                    }
                }
                Session.Add("cbcontacorrente", tst);
            }
        }
        //
        if (lOk)
        {
            //
            //Trimestre
            Session.Remove("cbmes");
            Session.Add("cbmes", cbmes.Text.ToString().Trim());
        }
        //
        if (lOk)
        {
            //
            //cbano
            Session.Remove("cbano");
            if (cbano.Text != string.Empty)
            {
                Session.Add("cbano", cbano.Text.ToString().Trim());
            }
            else
            {
                Session.Add("cbano", "");
            }
        }
        //
        if (lOk)
        {
            //
            //Previsão
            Session.Remove("rblancamentossituacao");
            Session.Add("rblancamentossituacao", rblancamentossituacao.SelectedIndex.ToString());
        }
        //
        if (lOk)
        {
            //
            //edsaldoinicial
            Session.Remove("edsaldoinicial");
            if (cbano.Text != string.Empty)
            {
                Session.Add("edsaldoinicial", edsaldo_inicial.Text);
            }
            else
            {
                Session.Add("edsaldoinicial", "0");
            }
        }
        if (lOk)
        {
            //Inclui Aplicações
            Session.Remove("ckaplicacoes");
            Session.Add("ckaplicacoes", ckaplicacoes.Checked.ToString());
        }
        //
        //
        //FIM CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================
        if (lOk)
        {
            //Usando Classe uLog.MakeLog - Gravando Log
            fwObs_Log = "RELATÓRIO FLUXO DE CAIXA - MENSAL: " + cbano.Text.Trim() + " - " + cbmes.Text.Trim();
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]           ),
                                         new SqlParameter("@tabela"   , fWtabela                                ),
                                         new SqlParameter("@operacao" , "RELATÓRIO"                             ),
                                         new SqlParameter("@obs"      , "RELATÓRIO FLUXO DE CAIXA - MENSAL"     ),
                                         new SqlParameter("@acao"     , fwObs_Log                               ) };
            uLog.MakeLog(param_log);

            // FIM CRIA LOG RELATÓRIO  ===============================================================================================================================================

            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpRuntime.AppDomainAppVirtualPath + "/_FCaixa/relatorios/RelFCaixaMensal.aspx', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);

        }
    }

    protected void cbproduto_SelectedIndexChanged(object sender, EventArgs e)
    {
        //

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

    protected void cbcontacorrente_SelectedIndexChanged(object sender, EventArgs e)
    {
        //edmulta.Focus();
    }

    protected void ckmulticontas_CheckedChanged(object sender, EventArgs e)
    {
        if (ckmulticontas.Checked)
        {
            cbcontascorrentes.SelectedIndex = -1;
            cbcontascorrentes.Enabled = false;
            lookupempresa.Visible = true;
        }
        else
        {
            cbcontascorrentes.SelectedIndex = -1;
            cbcontascorrentes.Enabled = true;
            lookupempresa.Visible = false;
        }

    }
}
