using System;
using System.Threading;
using System.Web;
using System.Web.UI;

public partial class FEditorHtml : System.Web.UI.Page
{
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "PERMISSOES";
    //

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.011.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.011.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.011.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.011.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        //btprocessa.Enabled = lConsulta;
        //if (!lConsulta)
        //    btprocessa.Image.ToolTip = Msg_acesso;
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
            //
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



    //Abrir/importar documento
    //using System;
    //using System.Collections.Generic;
    //using System.Web;
    //using System.Web.UI;
    //using System.Web.UI.WebControls;

    //public partial class Features_ImportExport : System.Web.UI.Page
    //{
    //    const string DocumentUrl = @"~/Content/Demo/SampleImportDocument.rtf";
    //    const string ContentFolder = @"~/UploadImages/Imported";

    //    protected void Page_Load(object sender, EventArgs e)
    //    {
    //        if(!IsPostBack) {
    //            HtmlEditorUtils.SetASPxHtmlEditorHtml(this, DemoHtmlEditor, "Features/ImportExport.html");
    //            DocumentHyperLink.NavigateUrl = DocumentUrl;
    //            DocumentHyperLink.Text = DocumentUrl;
    //            ContentFolderLabel.Text = ContentFolder;
    //        }
    //    }
    //    protected void ImportButton_Click(object sender, EventArgs e) {
    //        DemoHtmlEditor.Import(
    //            DocumentUrl,
    //            ImportStylesComboBox.Value.ToString() == "inline",
    //            ContentFolder
    //        );
    //    }
    //}
}
