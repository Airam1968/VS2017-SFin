using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;

public partial class FRelClienteCartaPadrao : System.Web.UI.Page
{
    DataSet dsclientes;                                    // DATASETS DOS LOOKUPS TEM QUE SER CRIADOS AQUI  ====================================================================================
    DataSet dscartas;
    String login_usuario;
    Boolean lImprime = false;
    String fwObs_Log = "";
    String fWtabela = "CONTATO";


    protected void Page_Init(object sender, EventArgs e)  // CARGA DOS LOOKUPS TEM QUE SER FEITA NESTE EVENTO  ====================================================================================
    {
        login_usuario = Convert.ToString(Session["usuario"]);
        lImprime = true; //SreDbLib.TemPermissao("001.070.080.001", (String)Session["CodUsuario"]);

        // CARGA DE UM LOOKUP  ===============================================================================================================================================
        // lookupcliente
        dsclientes = uContato.LookUpContato();    // Método que retorna o dataset com os campos pro lookup
        lookupcliente.DataSource = dsclientes;
        lookupcliente.KeyFieldName = "apelido";  // Campo Chave no dataset retornado
        lookupcliente.DataBind();
        //
        // LookUpMala
        dscartas = uMalaDireta.LookUpMala();    // Método que retorna o dataset com os campos pro lookup
        lookupcartas.DataSource = dscartas;
        lookupcartas.KeyFieldName = "nome";  // Campo Chave no dataset retornado
        lookupcartas.DataBind();
        //
        uProduto.MontaComboProduto(cbproduto, true);
        //
        Srelib.MontaComboMes(cbmes, true);
        //
        dtprevisao1.Date = Convert.ToDateTime("01/01/1900");
        //
        // FIM CARGA DE UM LOOKUP  ===============================================================================================================================================

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
        }
    }

    protected void btImpressao_Click(object sender, EventArgs e)
    {
        Boolean lOk = true;

        ////CRITICAS
        lOk = true;
        string tst = "";

        if (lOk)
        {
            //CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================
            //cbclientes
            tst = "";
            Session.Remove("cbclientes");
            List<object> cbclientes = lookupcliente.GetSelectedFieldValues(new string[] { "apelido" });
            if (cbclientes.Count != dsclientes.Tables[0].Rows.Count)  // VERIFICA SE TODOS OS ELEMENTOS FORAM SELECIONADOS  ===============================================================================================================================================
            {
                foreach (string xval in cbclientes)
                {
                    if (tst != "")
                    {
                        tst = tst + ",";
                    }
                    tst = tst + Srelib.QStr(xval);
                }
            }
            else
            {
                if ((cbclientes.Count == 1) && (dsclientes.Tables[0].Rows.Count == 1))
                {
                    foreach (string xval in cbclientes)
                    {
                        if (tst != "")
                        {
                            tst = tst + ",";
                        }
                        tst = tst + xval;
                    }
                }
            }
            Session.Add("cbclientes", tst);
            //
            //cbcartas
            tst = "";
            Session.Remove("cbcartas");
            List<object> cbcartas = lookupcartas.GetSelectedFieldValues(new string[] { "nome" });
            if (cbcartas.Count == 1)
            {
                foreach (string xval in cbcartas)
                {
                    if (tst != "")
                    {
                        tst = tst + ",";
                    }
                    tst = tst + xval;
                }
            }
            else
            {
                lOk = false;
                //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Nenhuma ou Todas Cartas Selecionadas!');", true);
                ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                "toastr.info('Nenhuma ou Todas Cartas Selecionadas!', 'Atenção!')", true);
            }
            Session.Add("cbcartas", tst);
            //
            //FIM CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================
        }

        if (lOk)
        {
            //Filtro
            Session.Remove("rbfiltro");
            Session.Add("rbfiltro", rbfiltro.SelectedIndex.ToString());
            //
            //Produto
            Session.Remove("cbproduto");
            if (cbproduto.Text != string.Empty)
            {
                Session.Add("cbproduto", cbproduto.Text.Substring(0, 5));
            }
            else
            {
                Session.Add("cbproduto", "");
            }
            //
            //Grupo
            Session.Remove("cbprodutogrupo");
            if (cbgrupo.Text != string.Empty)
            {
                Session.Add("cbprodutogrupo", cbgrupo.Text.Substring(0, 5));
            }
            else
            {
                Session.Add("cbprodutogrupo", "");
            }
            //
            //Mês Aniversário
            Session.Remove("cbmes");
            if (cbmes.Text != string.Empty)
            {
                Session.Add("cbmes", cbmes.Text.Substring(0, 2));
            }
            else
            {
                Session.Add("cbmes", "");
            }
            //
            //Data Limite
            Session.Remove("dtprevisao1");
            Session.Add("dtprevisao1", dtprevisao1.Text.Substring(0, 10));
            //
        }

        if (lOk)
        {

            //Usando Classe uLog.MakeLog - Gravando Log
            fwObs_Log = "RELATÓRIO CLIENTE CARTAS PADRÃO: " + tst;
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "RELATÓRIO"                           ),
                                         new SqlParameter("@obs"      , "RELATÓRIO CLIENTE CARTAS PADRÃO"     ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);

            // FIM CRIA LOG RELATÓRIO  ===============================================================================================================================================

            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpRuntime.AppDomainAppVirtualPath + "/_Clientes/relatorios/RelClienteCartaPadrao.aspx', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);

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
    protected void rbfiltro_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        //Aniversariantes
        if (rbfiltro.SelectedIndex == 0)
        {
            Label14.Visible = true;
            cbmes.Visible = true;
            //
            Label2.Visible = false;
            cbproduto.Visible = false;
            Label23.Visible = false;
            cbgrupo.Visible = false;
            //
            Label4.Visible = false;
            dtprevisao1.Visible = false;
        }
        //Clientes Produto
        if (rbfiltro.SelectedIndex == 1)
        {
            Label14.Visible = false;
            cbmes.Visible = false;
            //
            Label2.Visible = true;
            cbproduto.Visible = true;
            Label23.Visible = true;
            cbgrupo.Visible = true;
            //
            Label4.Visible = false;
            dtprevisao1.Visible = false;
        }
        //Devedores
        if (rbfiltro.SelectedIndex == 2)
        {
            Label14.Visible = false;
            cbmes.Visible = false;
            //
            Label2.Visible = true;
            cbproduto.Visible = true;
            Label23.Visible = true;
            cbgrupo.Visible = true;
            //
            Label4.Visible = true;
            dtprevisao1.Visible = true;
        }
    }

    protected void cbproduto_SelectedIndexChanged(object sender, EventArgs e)
    {
        //
        if (cbproduto.Text != string.Empty)
        {
            //Combo Grupo
            cbgrupo.Items.Clear();
            uProduto.MontaComboGrupo(cbgrupo, Convert.ToString(cbproduto.Value).Trim(), true);
            cbgrupo.Focus();
        }
        else
        {
            //
        }
    }
}
