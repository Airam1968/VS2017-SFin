using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;

public partial class FSelecionaUsuarioAnaliseSeguranca : System.Web.UI.Page
{
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "LOG";
    //
    DataSet dsusuario;       // DATASETS DOS LOOKUPS TEM QUE SER CRIADOS AQUI  ====================================================================================
    DataSet dslog;
    DataSet dslog2;

    protected void Page_Init(object sender, EventArgs e)
    {
        // CARGA DE UM LOOKUP  ===============================================================================================================================================
        // lookupusuario
        dsusuario = uUsuario.LookUpUsuario();    // Método que retorna o dataset com os campos pro lookup
        lookupusuario.DataSource = dsusuario;
        lookupusuario.KeyFieldName = "login";  // Campo Chave no dataset retornado
        lookupusuario.DataBind();
        // FIM CARGA DE UM LOOKUP  ===============================================================================================================================================

        // lookuplog
        dslog = uLog.PegaDadosLog("", Convert.ToString(DateTime.Now.AddDays(-31)), Convert.ToString(DateTime.Now.AddDays(+1)), "", "", "");
        lookuplog.DataSource = dslog;
        lookuplog.KeyFieldName = "DataHora";
        lookuplog.DataBind();
        Label3.Text = "Log do Usuário (Todos)";

        //ComboAcao
        cbAcao.Items.Clear();
        uLog.MontaComboAcao(cbAcao);

        //ComboModulo
        cbModulo.Items.Clear();
        uLog.MontaComboModulo(cbModulo);

        //edComplemento
        edComplemento.Text = "";

        lInsere = SreDblib.TemPermissao("001.011.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.011.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.011.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.011.004.000", (String)Session["CodUsuario"]);

        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lConsulta;
        if (!lConsulta)
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
            dtinicio.Value = DateTime.Now.AddDays(-30);
            dtfim.Value = DateTime.Now;
        }

    }


    protected void btdesmarcar_Click(object sender, EventArgs e)
    {
        // Habilitar
        lookupusuario.Enabled = true;
        btprocessa.Enabled = true;
        btdesmarcar.Enabled = true;
        btimprimir.Enabled = false;
        dtinicio.Enabled = true;
        dtfim.Enabled = true;
        cktudoperiodo.Enabled = true;
        cbAcao.Enabled = true;
        cbModulo.Enabled = true;
        edComplemento.Enabled = true;
        cbModulo.Text = "";
        cbAcao.Text = "";
        edComplemento.Text = "";
        lookupusuario.Selection.UnselectAll();
        lookuplog.Selection.UnselectAll();
        // lookuplog
        dslog = uLog.LookUpLog("", Srelib.DataAmericanasembarra(dtinicio.Text), Srelib.DataAmericanasembarra(dtfim.Text), "", "", "");
        lookuplog.DataSource = dslog;
        lookuplog.KeyFieldName = "DataHora";
        lookuplog.DataBind();
        Label3.Text = "Log do Usuário (Todos)";
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
        //Usuario
        string tst = "";
        string tst_scpt = "";
        Session.Remove("cbusuarios");
        Session.Remove("cbusuarios_scpt");
        List<object> cbusuarios = lookupusuario.GetSelectedFieldValues(new string[] { "login" });

        if (cbusuarios.Count != dsusuario.Tables[0].Rows.Count)
        {
            tst = string.Join(",", cbusuarios.ToArray());

            foreach (string value in cbusuarios)
            {
                tst_scpt = tst_scpt + Srelib.QStr(value) + ",";
            }
        }
        Session.Add("cbusuarios", tst);
        if (tst_scpt.Length > 0)
            Session.Add("cbusuarios_scpt", tst_scpt.Substring(0, tst_scpt.Length - 1));
        else
            Session.Add("cbusuarios_scpt", "");
        //Usuario


        string usuarioselecionado = tst;

        //Atualiza grid
        //
        try
        {
            dslog2.Clear();
        }
        catch (Exception)
        {
            //
        }
        //
        //
        dslog2 = uLog.LookUpLog(usuarioselecionado.Trim(),
                                dtinicio.Text.Substring(0, 10),
                                dtfim.Text.Substring(0, 10),
                                cbModulo.Text.Trim(),
                                cbAcao.Text.Trim(),
                                edComplemento.Text.Trim());
        //
        lookuplog.DataSource = dslog2;
        lookuplog.KeyFieldName = "DataHora";
        lookuplog.DataBind();
        Label3.Text = "Log do Usuário (" + usuarioselecionado + ")";
        Label3.Text = Label3.Text + "- Ocorrências (" + Convert.ToString(dslog2.Tables[0].Rows.Count) + ")";
        Label3.Text = Label3.Text + "- Período (" + dtinicio.Text + " até " + dtfim.Text + ")";
        btimprimir.Enabled = true;

        //
        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "CONSULTA SEGURANÇA ACESSOS: Todos";
        if (tst != String.Empty)
        {
            fwObs_Log = "CONSULTA SEGURANÇA ACESSOS: " + tst + " - Período (" + dtinicio.Text + " até " + dtfim.Text + ")";
        }
        //
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                     new SqlParameter("@tabela"   , fWtabela                              ),
                                     new SqlParameter("@operacao" , "CONSULTA"                            ),
                                     new SqlParameter("@obs"      , "CONSULTA SEGURANÇA ACESSOS"          ),
                                     new SqlParameter("@acao"     , fwObs_Log                             ) };
        uLog.MakeLog(param_log);
    }

    protected void cktudoperiodo_CheckedChanged(object sender, EventArgs e)
    {
        if (cktudoperiodo.Checked)
        {
            dtinicio.Value = Convert.ToDateTime("01/01/1900");
            dtfim.Value = Convert.ToDateTime("31/12/2999");
        }
        else
        {
            dtinicio.Value = DateTime.Now.AddDays(-30);
            dtfim.Value = DateTime.Now;
        }
    }
    protected void btimprimir_Click(object sender, EventArgs e)
    {
        //
        //Usuario
        string tst = "";
        string tst_scpt = "";
        Session.Remove("cbusuarios");
        Session.Remove("cbusuarios_scpt");
        List<object> cbusuarios = lookupusuario.GetSelectedFieldValues(new string[] { "login" });

        if (cbusuarios.Count != dsusuario.Tables[0].Rows.Count)
        {
            tst = string.Join(",", cbusuarios.ToArray());

            foreach (string value in cbusuarios)
            {
                tst_scpt = tst_scpt + Srelib.QStr(value) + ",";
            }
        }
        Session.Add("cbusuarios", tst);
        if (tst_scpt.Length > 0)
            Session.Add("cbusuarios_scpt", tst_scpt.Substring(0, tst_scpt.Length - 1));
        else
            Session.Add("cbusuarios_scpt", "");
        //Usuario
        string usuarioselecionado = tst;
        //
        //
        Session.Remove("dtinicio");
        Session.Remove("dtfim");
        //
        Session.Add("dtinicio", dtinicio.Text.Substring(0, 10));
        Session.Add("dtfim", dtfim.Text.Substring(0, 10));
        //
        //
        Session.Remove("Modulo");
        Session.Remove("Acao");
        Session.Remove("Complemento");
        Session.Remove("RelatorioTipo");
        //
        Session.Add("Modulo", cbModulo.Text);
        Session.Add("Acao", cbAcao.Text);
        Session.Add("Complemento", edComplemento.Text);
        Session.Add("RelatorioTipo", 1);
        //
        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "RELATÓRIO SEGURANÇA ACESSOS: Todos";
        if (tst != String.Empty)
        {
            fwObs_Log = "RELATÓRIO SEGURANÇA ACESSOS: " + tst + " - Período (" + dtinicio.Text + " até " + dtfim.Text + ")"; 
        }
        //
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]         ), 
                                     new SqlParameter("@tabela"   , fWtabela                              ),
                                     new SqlParameter("@operacao" , "RELATÓRIO"                           ),
                                     new SqlParameter("@obs"      , "RELATÓRIO SEGURANÇA ACESSOS"         ),
                                     new SqlParameter("@acao"     , fwObs_Log                             ) };
        uLog.MakeLog(param_log);

        // FIM CRIA LOG RELATÓRIO  ===============================================================================================================================================

        ScriptManager.RegisterStartupScript(this, typeof(string), "OPEN_WINDOW", "window.open( '" + HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpRuntime.AppDomainAppVirtualPath + "/_Config/relatorios/RelConfigSeguranca.aspx', null, 'height=755,width=900,status=yes,resizable=yes,menubar=yes,location=yes' );", true);


    }
}
