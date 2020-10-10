using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

public partial class FRelAPagarDespesas : System.Web.UI.Page
{
    DataSet dsdespesas;                                    // DATASETS DOS LOOKUPS TEM QUE SER CRIADOS AQUI  ====================================================================================
    String login_usuario;
    Boolean lImprime = false;
    String fwObs_Log = "";
    String fWtabela = "CLASSE_DESPESAS";


    protected void Page_Init(object sender, EventArgs e)  // CARGA DOS LOOKUPS TEM QUE SER FEITA NESTE EVENTO  ====================================================================================
    {
        login_usuario = Convert.ToString(Session["usuario"]);
        lImprime = true; //SreDbLib.TemPermissao("001.070.080.001", (String)Session["CodUsuario"]);

        // CARGA DE UM LOOKUP  ===============================================================================================================================================
        // lookupempresa
        dsdespesas = uDespesas.LookUpDespesas();    // Método que retorna o dataset com os campos pro lookup
        lookupempresa.DataSource = dsdespesas;
        lookupempresa.KeyFieldName = "codigo";  // Campo Chave no dataset retornado
        lookupempresa.DataBind();
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


        if (lOk)
        {
            string tst;


            //CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================
            //Fornecedores
            tst = "";
            Session.Remove("cbdespesas");
            List<object> cbdespesas = lookupempresa.GetSelectedFieldValues(new string[] { "codigo" });
            if (cbdespesas.Count != dsdespesas.Tables[0].Rows.Count)  // VERIFICA SE TODOS OS ELEMENTOS FORAM SELECIONADOS  ===============================================================================================================================================
            {
                foreach (Int16 xval in cbdespesas)
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
                if ((cbdespesas.Count == 1) && (dsdespesas.Tables[0].Rows.Count == 1))
                {
                    foreach (Int16 xval in cbdespesas)
                    {
                        if (tst != "")
                        {
                            tst = tst + ",";
                        }
                        tst = tst + xval.ToString().Trim();
                    }
                }
            }
            Session.Add("cbdespesas", tst);
            //
            //FIM CRIAÇÃO DA VARIÁVEL DE SESSÃO COM OS ELEMENTOS SELECIONADOS NO LOOKUP  ===============================================================================================================================================

            //Usando Classe uLog.MakeLog - Gravando Log
            fwObs_Log = "RELATÓRIO DESPESAS CADASTRO RESUMIDO: " + tst;
            SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                         new SqlParameter("@tabela"   , fWtabela                              ),
                                         new SqlParameter("@operacao" , "RELATÓRIO"                           ),
                                         new SqlParameter("@obs"      , "RELATÓRIO DESPESAS CADASTRO RESUMIDO" ),
                                         new SqlParameter("@acao"     , fwObs_Log                             ) };
            uLog.MakeLog(param_log);

            // FIM CRIA LOG RELATÓRIO  ===============================================================================================================================================

            ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpRuntime.AppDomainAppVirtualPath + "/_APagar/relatorios/RelAPagarDespesas.aspx', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);

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

}
