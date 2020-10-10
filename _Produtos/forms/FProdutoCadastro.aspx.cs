using DevExpress.Web.ASPxGridView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web;
using System.Web.UI;


public partial class FProdutoCadastro : System.Web.UI.Page
{
    DataSet dsunidade;
    List<object> selectedValues;
    Boolean lInsere = false;
    Boolean lAltera = false;
    Boolean lExclui = false;
    Boolean lConsulta = false;
    String fwObs_Log = "";
    String fWtabela = "PRODUTO_UNIDADES";
    Int32 quantidadedigitada = 1;
    Int32[] unidadesdigitadas = new Int32[1000];

    protected void Page_Init(object sender, EventArgs e)
    {
        lInsere = SreDblib.TemPermissao("001.003.001.000", (String)Session["CodUsuario"]);
        lAltera = SreDblib.TemPermissao("001.003.002.000", (String)Session["CodUsuario"]);
        lExclui = SreDblib.TemPermissao("001.003.003.000", (String)Session["CodUsuario"]);
        lConsulta = SreDblib.TemPermissao("001.003.004.000", (String)Session["CodUsuario"]);
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        btprocessa.Enabled = lInsere;
        if (!lInsere)
            btprocessa.Image.ToolTip = Msg_acesso;
        //
        lInsere = false;
        lAltera = false;
        lExclui = false;
        lConsulta = false;
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
            uProduto.MontaComboGrupo(cbgrupo, Convert.ToString(cbproduto.Value).Trim(), false);
            Label2.Visible = true;
            cbgrupo.Visible = true;
            GridListagem.Visible = false;
        }
        else
        {
            Label2.Visible = false;
            cbgrupo.Visible = false;
            GridListagem.Visible = false;
        }

    }

    private void AtualizaGrid()
    {
        //
        string Msg_acesso = "Usuário corrente não possui direitos de acesso para esta opção.";
        //
        GridListagem.Enabled = lInsere;
        if (!lInsere)
        {
            GridListagem.ToolTip = Msg_acesso;
            btprocessa.Enabled = false;
        }
        else
        {
            //
            // lookupusuario
            //dsusuario.Clear();
            dsunidade = uProduto.PegaDadosProdutoUnidades(cbproduto.Value.ToString().Trim(), cbgrupo.Value.ToString().Trim(), "0", "0", "0");
            GridListagem.DataSource = dsunidade;
            GridListagem.KeyFieldName = "ID";
            GridListagem.DataBind();
            btprocessa.Enabled = false;
        }
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
                edunidades.Text = "O Sistema irá criar (" + Convert.ToString(unidades).Trim() + ") unidades do tipo (" + tipo + ")";
                Label4.Visible = true;
                edunidades.Visible = true;
                Label5.Visible = true;
                rbnumeracao.Visible = true;
                rbnumeracao.Focus();
                //AtualizaGrid();
                //GridListagem.Visible = true;
            }
            else
            {
                Label2.Visible = true;
                cbgrupo.Visible = true;
                Label4.Visible = false;
                edunidades.Visible = false;
                Label5.Visible = false;
                rbnumeracao.Visible = false;
                //GridListagem.Visible = false;
            }
        }

    }

    protected void rbnumeracao_SelectedIndexChanged(object sender, EventArgs e)
    {
        ednumeracao.Text = "";
        ednumeracao2.Text = "";
        ednumeracao3.Text = "";
        ednumeracao4.Text = "";
        ednumeracao.Visible = true;
        ednumeracao2.Visible = false;
        ednumeracao3.Visible = false;
        ednumeracao4.Visible = false;
        btnumeracaomanual.Visible = false;
        int unidades = 0;
        unidades = uProduto.PegaProdutoGrupoQuantidade(Convert.ToInt32(cbproduto.Value), Convert.ToInt32(cbgrupo.Value));
        //Sequencial
        if (rbnumeracao.SelectedIndex == 0)
        {
            // Sequencial
            ednumeracao.Visible = false;
            ednumeracao.Text = "A Numeração das unidades iniciará em (1) até (" + Convert.ToString(unidades).Trim() + "). Clique em Processar.";
        }
        //Alternada
        if (rbnumeracao.SelectedIndex == 1)
        {
            // Alternada
            // Sequencial
            ednumeracao.Visible = true;
            ednumeracao2.Visible = true;
            ednumeracao3.Visible = true;
            ednumeracao4.Visible = true;
            ednumeracao.Text = "Informe o numeral inicial das unidades, Ex: 11, para unidades começarem em 11, 12, 13, etc ";
            ednumeracao3.Text = "Informe a quantidade por parte, Ex: 4, para que as unidades tenham a sequencia 31, 32, 33, 34, 41, 42, etc ";
            ednumeracao2.Focus();
        }


        //Informada Manualmente
        if (rbnumeracao.SelectedIndex == 2)
        {
            // Quantidade Digitada
            Int32 aux = 1;
            string aux2 = ednumeracao3.Text;
            aux = aux2.IndexOf(",");
            if (aux == -1)
                aux = 1;

            // Informada Manualmente
            for (int i = 0; i < unidades; i++)
            {
                ednumeracao.Visible = true;
                ednumeracao2.Visible = true;
                ednumeracao4.Visible = true;
                ednumeracao4.Text = "Sequencia Informada: ";
                //
                //ednumeracao.Text = "Informe o numero da unidade (" + unidades.ToString().Trim() + ") : ";
                ednumeracao.Text = "Informe o numero da unidade (" + aux + "/" + unidades.ToString().Trim() + ") : ";
                btnumeracaomanual.Visible = true;
                ednumeracao2.Focus();
            }

        }

        btprocessa.Focus();

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
        Int32 unidades = 0;
        Int32 contador = 0;
        Int32 salto = 0;
        Int32 contadorsalto = 0;
        Int32 contadorsalto2 = 0;
        Int32 aux = 0;
        unidades = uProduto.PegaProdutoGrupoQuantidade(Convert.ToInt32(cbproduto.Value), Convert.ToInt32(cbgrupo.Value));
        int[] aUnidades = new int[unidades + 10];
        //
        string produto = "";
        string grupo = "";
        string unidade = "";
        string parte = "";
        decimal metragem_total = 0;
        decimal vlr_total = 0;
        decimal vlr_1 = 0;
        decimal metragem_1 = 0;
        string inscricao_1 = "";
        string proprietario_1 = "";
        Boolean quitado_1 = false;
        Boolean escritura_1 = false;
        DateTime dtescritura_1 = Convert.ToDateTime("01/01/1900");
        string cartorio_1 = "";
        string livro_1 = "";
        string folha_1 = "";
        Boolean processo_1 = false;
        string obs_1 = "";
        decimal vlr_2 = 0;
        decimal metragem_2 = 0;
        string inscricao_2 = "";
        string proprietario_2 = "";
        Boolean quitado_2 = false;
        Boolean escritura_2 = false;
        DateTime dtescritura_2 = Convert.ToDateTime("01/01/1900");
        string cartorio_2 = "";
        string livro_2 = "";
        string folha_2 = "";
        Boolean processo_2 = false;
        string obs_2 = "";
        //
        decimal area_privativa_coletiva_m2 = 0;
        decimal area_privativa_terraco_coberto_m2 = 0;
        decimal area_privativa_terraco_descoberto_m2 = 0;
        decimal area_comum_m2 = 0;
        decimal area_garagem_m2 = 0;
        decimal area_hobby_box_m2 = 0;
        decimal area_total_m2 = 0;
        decimal fracao_ideal_m2 = 0;
        decimal fracao_ideal_percentual = 0;
        string hobby_box_numero = "";
        string hobby_box_localizacao = "";
        string numero_garagem_01 = "";
        string numero_garagem_02 = "";
        string numero_garagem_03 = "";
        string numero_garagem_04 = "";
        string numero_garagem_05 = "";
        string vagas_localizacao = "";
        Int16 vagas_quantidade = 0;
        //

        if (rbnumeracao.SelectedValue == "")
        {
            lOk = false;
            //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Selecione uma opção de numeração!');", true);
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
            "toastr.info('Selecione uma opção de numeração!', 'Atenção!')", true);
        }

        if (lOk)
        {
            //Sequencial
            if (rbnumeracao.SelectedIndex == 0)
            {
                // Sequencial
                unidades = 0;
                unidades = uProduto.PegaProdutoGrupoQuantidade(Convert.ToInt32(cbproduto.Value), Convert.ToInt32(cbgrupo.Value));
                ednumeracao.Text = "Iniciando a criação de (" + Convert.ToString(unidades).Trim() + ") numeração sequencial, aguarde.";
                //Numeração
                contador = 1;
                for (int i = 0; i < unidades; i++)
                {
                    aUnidades[i] = contador;
                    //Criar Unidades
                    produto = cbproduto.Value.ToString();
                    grupo = cbgrupo.Value.ToString();
                    unidade = Convert.ToString(contador).Trim();
                    parte = "0";
                    metragem_total = 0;
                    vlr_total = 0;
                    vlr_1 = 0;
                    metragem_1 = 0;
                    inscricao_1 = "";
                    proprietario_1 = "1";
                    quitado_1 = false;
                    escritura_1 = false;
                    dtescritura_1 = Convert.ToDateTime("01/01/1900");
                    cartorio_1 = "";
                    livro_1 = "";
                    folha_1 = "";
                    processo_1 = false;
                    obs_1 = "";
                    vlr_2 = 0;
                    metragem_2 = 0;
                    inscricao_2 = "";
                    proprietario_2 = "1";
                    quitado_2 = false;
                    escritura_2 = false;
                    dtescritura_2 = Convert.ToDateTime("01/01/1900");
                    cartorio_2 = "";
                    livro_2 = "";
                    folha_2 = "";
                    processo_2 = false;
                    obs_2 = "";
                    //
                    uUnidade.Grava(produto,
                                    grupo,
                                    unidade,
                                    parte,
                                    metragem_total,
                                    vlr_total,
                                    vlr_1,
                                    metragem_1,
                                    inscricao_1,
                                    proprietario_1,
                                    Convert.ToInt16(quitado_1),
                                    Convert.ToInt16(escritura_1),
                                    Convert.ToString(dtescritura_1).Substring(0, 10),
                                    cartorio_1,
                                    livro_1,
                                    folha_1,
                                    Convert.ToInt16(processo_1),
                                    obs_1,
                                    vlr_2,
                                    metragem_2,
                                    inscricao_2,
                                    proprietario_2,
                                    Convert.ToInt16(quitado_2),
                                    Convert.ToInt16(escritura_2),
                                    Convert.ToString(dtescritura_2).Substring(0, 10),
                                    cartorio_2,
                                    livro_2,
                                    folha_2,
                                    Convert.ToInt16(processo_2),
                                    obs_2,
                                    area_privativa_coletiva_m2,
                                    area_privativa_terraco_coberto_m2,
                                    area_privativa_terraco_descoberto_m2,
                                    area_comum_m2,
                                    area_garagem_m2,
                                    area_hobby_box_m2,
                                    area_total_m2,
                                    fracao_ideal_m2,
                                    fracao_ideal_percentual,
                                    hobby_box_numero,
                                    hobby_box_localizacao,
                                    numero_garagem_01,
                                    numero_garagem_02,
                                    numero_garagem_03,
                                    numero_garagem_04,
                                    numero_garagem_05,
                                    vagas_localizacao,
                                    vagas_quantidade);

                    //
                    contador++;
                }
                //Alterar travas
                uProduto.AlteraProdutoCadastro(cbproduto.Value.ToString(),
                                               true);
                //
                uProduto.AlteraGrupoCadastro(cbproduto.Value.ToString(),
                                             cbgrupo.Value.ToString(),
                                             true);
                //
                //Cria Arquivo
                uParcelas.CriarTabelaParcelas(cbproduto.Value.ToString(),
                                             cbgrupo.Value.ToString());
                //
                //Grid
                GridListagem.Visible = true;
                AtualizaGrid();
                btprocessa.Enabled = false;

            }
            //Alternada
            if (rbnumeracao.SelectedIndex == 1)
            {
                // Alternada
                unidades = 0;
                unidades = uProduto.PegaProdutoGrupoQuantidade(Convert.ToInt32(cbproduto.Value), Convert.ToInt32(cbgrupo.Value));
                edunidades.Text = "Iniciando a criação de (" + Convert.ToString(unidades).Trim() + ") unidades com numeração alternada, aguarde.";
                //Numeração
                contador = 1;

                if (Convert.ToInt16(ednumeracao2.Text) == 0)
                {
                    lOk = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Numero inicial não aceitável!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.info('Numero inicial não aceitável!', 'Atenção!')", true);

                }

                if (Convert.ToInt16(ednumeracao4.Text) == 0)
                {
                    lOk = false;
                    //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Salto não aceitável!');", true);
                    ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                    "toastr.info('Salto não aceitável!', 'Atenção!')", true);
                }
                else
                {
                    if (Convert.ToInt16(ednumeracao4.Text) > 9)
                    {
                        lOk = false;
                        //ScriptManager.RegisterStartupScript(UpdatePanel, GetType(), "msgbox", "alert('Atenção! Salto maior que 9 não é aceitável!');", true);
                        ScriptManager.RegisterStartupScript(this.Page, typeof(Page), Guid.NewGuid().ToString(),
                        "toastr.info('Salto maior que 9 não é aceitável!', 'Atenção!')", true);
                    }
                }

                if (lOk)
                {
                    contadorsalto = 1;
                    contadorsalto2 = 1;
                    salto = Convert.ToInt16(ednumeracao4.Text);
                    contador = Convert.ToInt16(ednumeracao2.Text);

                    for (int i = 0; i < unidades; i++)
                    {
                        aUnidades[i] = contador;
                        //Criar Unidades
                        produto = cbproduto.Value.ToString();
                        grupo = cbgrupo.Value.ToString();
                        unidade = Convert.ToString(contador).Trim();
                        parte = "0";
                        metragem_total = 0;
                        vlr_total = 0;
                        vlr_1 = 0;
                        metragem_1 = 0;
                        inscricao_1 = "";
                        proprietario_1 = "1";
                        quitado_1 = false;
                        escritura_1 = false;
                        dtescritura_1 = Convert.ToDateTime("01/01/1900");
                        cartorio_1 = "";
                        livro_1 = "";
                        folha_1 = "";
                        processo_1 = false;
                        obs_1 = "";
                        vlr_2 = 0;
                        metragem_2 = 0;
                        inscricao_2 = "";
                        proprietario_2 = "1";
                        quitado_2 = false;
                        escritura_2 = false;
                        dtescritura_2 = Convert.ToDateTime("01/01/1900");
                        cartorio_2 = "";
                        livro_2 = "";
                        folha_2 = "";
                        processo_2 = false;
                        obs_2 = "";
                        //
                        area_privativa_coletiva_m2 = 0;
                        area_privativa_terraco_coberto_m2 = 0;
                        area_privativa_terraco_descoberto_m2 = 0;
                        area_comum_m2 = 0;
                        area_garagem_m2 = 0;
                        area_hobby_box_m2 = 0;
                        area_total_m2 = 0;
                        fracao_ideal_m2 = 0;
                        fracao_ideal_percentual = 0;
                        hobby_box_numero = "";
                        hobby_box_localizacao = "";
                        numero_garagem_01 = "";
                        numero_garagem_02 = "";
                        numero_garagem_03 = "";
                        numero_garagem_04 = "";
                        numero_garagem_05 = "";
                        vagas_localizacao = "";
                        vagas_quantidade = 0;
                        //
                        uUnidade.Grava(produto,
                                        grupo,
                                        unidade,
                                        parte,
                                        metragem_total,
                                        vlr_total,
                                        vlr_1,
                                        metragem_1,
                                        inscricao_1,
                                        proprietario_1,
                                        Convert.ToInt16(quitado_1),
                                        Convert.ToInt16(escritura_1),
                                        Convert.ToString(dtescritura_1).Substring(0, 10),
                                        cartorio_1,
                                        livro_1,
                                        folha_1,
                                        Convert.ToInt16(processo_1),
                                        obs_1,
                                        vlr_2,
                                        metragem_2,
                                        inscricao_2,
                                        proprietario_2,
                                        Convert.ToInt16(quitado_2),
                                        Convert.ToInt16(escritura_2),
                                        Convert.ToString(dtescritura_2).Substring(0, 10),
                                        cartorio_2,
                                        livro_2,
                                        folha_2,
                                        Convert.ToInt16(processo_2),
                                        obs_2,
                                        area_privativa_coletiva_m2,
                                        area_privativa_terraco_coberto_m2,
                                        area_privativa_terraco_descoberto_m2,
                                        area_comum_m2,
                                        area_garagem_m2,
                                        area_hobby_box_m2,
                                        area_total_m2,
                                        fracao_ideal_m2,
                                        fracao_ideal_percentual,
                                        hobby_box_numero,
                                        hobby_box_localizacao,
                                        numero_garagem_01,
                                        numero_garagem_02,
                                        numero_garagem_03,
                                        numero_garagem_04,
                                        numero_garagem_05,
                                        vagas_localizacao,
                                        vagas_quantidade);


                        contador++;
                        contadorsalto++;
                        if (contadorsalto > salto)
                        {
                            contadorsalto = 1;
                            aux = contador;
                            contador = Convert.ToInt16(ednumeracao2.Text) + (contadorsalto2 * 10);
                            contadorsalto2++;
                        }
                    }
                    //Alterar travas
                    uProduto.AlteraProdutoCadastro(cbproduto.Value.ToString(),
                                                   true);
                    //
                    uProduto.AlteraGrupoCadastro(cbproduto.Value.ToString(),
                                                 cbgrupo.Value.ToString(),
                                                 true);
                    //
                    //Cria Arquivo
                    uParcelas.CriarTabelaParcelas(cbproduto.Value.ToString(),
                                                 cbgrupo.Value.ToString());
                    //
                    //Grid
                    GridListagem.Visible = true;
                    AtualizaGrid();
                    btprocessa.Enabled = false;
                }
            }


            //Informada Manualmente
            if (rbnumeracao.SelectedIndex == 2)
            {
                unidades = 0;
                unidades = uProduto.PegaProdutoGrupoQuantidade(Convert.ToInt32(cbproduto.Value), Convert.ToInt32(cbgrupo.Value));
                ednumeracao2.Text = "Iniciando a criação de (" + Convert.ToString(unidades).Trim() + ") numeração informada Manualmente, aguarde.";
                //Numeração Unidades
                int[] Arrayunidades = new int[unidades];
                Int32 posicao = 0;
                string numeracao = ednumeracao4.Text;
                numeracao = numeracao.Substring(21, numeracao.Length - 21);
                for (int i = 0; i < 14; i++)
                {
                    posicao = numeracao.IndexOf(",");
                    Arrayunidades[i] = Convert.ToInt32(numeracao.Substring(0, posicao));
                    numeracao = numeracao.Substring(posicao + 2, numeracao.Length - posicao - 2);

                }
                //Criar Unidades
                contador = 1;
                for (int i = 0; i < unidades; i++)
                {
                    aUnidades[i] = contador;
                    //Criar Unidades
                    produto = cbproduto.Value.ToString();
                    grupo = cbgrupo.Value.ToString();
                    unidade = Convert.ToString(Arrayunidades[i]).Trim();
                    parte = "0";
                    metragem_total = 0;
                    vlr_total = 0;
                    vlr_1 = 0;
                    metragem_1 = 0;
                    inscricao_1 = "";
                    proprietario_1 = "1";
                    quitado_1 = false;
                    escritura_1 = false;
                    dtescritura_1 = Convert.ToDateTime("01/01/1900");
                    cartorio_1 = "";
                    livro_1 = "";
                    folha_1 = "";
                    processo_1 = false;
                    obs_1 = "";
                    vlr_2 = 0;
                    metragem_2 = 0;
                    inscricao_2 = "";
                    proprietario_2 = "1";
                    quitado_2 = false;
                    escritura_2 = false;
                    dtescritura_2 = Convert.ToDateTime("01/01/1900");
                    cartorio_2 = "";
                    livro_2 = "";
                    folha_2 = "";
                    processo_2 = false;
                    obs_2 = "";
                    //
                    uUnidade.Grava(produto,
                                    grupo,
                                    unidade,
                                    parte,
                                    metragem_total,
                                    vlr_total,
                                    vlr_1,
                                    metragem_1,
                                    inscricao_1,
                                    proprietario_1,
                                    Convert.ToInt16(quitado_1),
                                    Convert.ToInt16(escritura_1),
                                    Convert.ToString(dtescritura_1).Substring(0, 10),
                                    cartorio_1,
                                    livro_1,
                                    folha_1,
                                    Convert.ToInt16(processo_1),
                                    obs_1,
                                    vlr_2,
                                    metragem_2,
                                    inscricao_2,
                                    proprietario_2,
                                    Convert.ToInt16(quitado_2),
                                    Convert.ToInt16(escritura_2),
                                    Convert.ToString(dtescritura_2).Substring(0, 10),
                                    cartorio_2,
                                    livro_2,
                                    folha_2,
                                    Convert.ToInt16(processo_2),
                                    obs_2,
                                    area_privativa_coletiva_m2,
                                    area_privativa_terraco_coberto_m2,
                                    area_privativa_terraco_descoberto_m2,
                                    area_comum_m2,
                                    area_garagem_m2,
                                    area_hobby_box_m2,
                                    area_total_m2,
                                    fracao_ideal_m2,
                                    fracao_ideal_percentual,
                                    hobby_box_numero,
                                    hobby_box_localizacao,
                                    numero_garagem_01,
                                    numero_garagem_02,
                                    numero_garagem_03,
                                    numero_garagem_04,
                                    numero_garagem_05,
                                    vagas_localizacao,
                                    vagas_quantidade);

                    //
                    contador++;
                }

                //Alterar travas
                uProduto.AlteraProdutoCadastro(cbproduto.Value.ToString(),
                                               true);
                //
                uProduto.AlteraGrupoCadastro(cbproduto.Value.ToString(),
                                             cbgrupo.Value.ToString(),
                                             true);
                //
                //Cria Arquivo
                uParcelas.CriarTabelaParcelas(cbproduto.Value.ToString(),
                                             cbgrupo.Value.ToString());
                //
                //Grid
                GridListagem.Visible = true;
                AtualizaGrid();
                btprocessa.Enabled = false;

            }
        }

    }

    protected void GridListagem_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
    {
        //Código Original
        //ASPxGridView gridView = (ASPxGridView)sender;

        ////
        //string apelido = "";
        //string nome = "";
        //string cnpj = "";
        //string inscmunicipal = "";
        //string inscestadual = "";
        //string regjuntacom = "";
        //string nire = "";
        //string enderecocom = "";
        //string enderecocomnumero = "";
        //string enderecocomcomplem = "";
        //string bairrocom = "";
        //string cidadecom = "";
        //string ufcom = "";
        //string cepcom = "";
        //string fone1com = "";
        //string fone2com = "";
        //string fone3com = "";
        //string email1 = "";
        //string email2 = "";
        //string email3 = "";
        //string email4 = "";
        //string email5 = "";
        //string gerente = "";
        //string contato = "";
        //DateTime dtnascimento = Convert.ToDateTime("01/01/1900");
        //DateTime dtingresso = Convert.ToDateTime("01/01/1900");
        //string ncontrato = "";
        //DateTime dtcontrato = Convert.ToDateTime("01/01/1900");
        //Boolean ativo = true;
        //Boolean acessointernet = true;
        //string obs1 = "";
        //string obs2 = "";
        //string obs3 = "";
        //string obs4 = "";
        //string obs5 = "";
        //string instrcob1 = "";
        //string instrcob2 = "";
        //string diasprotesto = "";
        //string conta1 = "";
        //string conta2 = "";
        //string conta3 = "";
        //string conta4 = "";
        //string conta5 = "";
        ////
        //// Empresa
        //apelido = e.NewValues["apelido"].ToString().ToUpper();
        //nome = e.NewValues["nome"].ToString().ToUpper();
        //cnpj = e.NewValues["cnpj"].ToString();
        //if (e.NewValues["inscmunicipal"] != null)
        //    inscmunicipal = e.NewValues["inscmunicipal"].ToString();
        //if (e.NewValues["inscestadual"] != null)
        //    inscestadual = e.NewValues["inscestadual"].ToString();
        //if (e.NewValues["regjuntacom"] != null)
        //    regjuntacom = e.NewValues["regjuntacom"].ToString();
        //if (e.NewValues["nire"] != null)
        //    nire = e.NewValues["nire"].ToString();
        //if (e.NewValues["enderecocom"] != null)
        //    enderecocom = e.NewValues["enderecocom"].ToString();
        //if (e.NewValues["enderecocomnumero"] != null)
        //    enderecocomnumero = e.NewValues["enderecocomnumero"].ToString();
        //if (e.NewValues["enderecocomcomplem"] != null)
        //    enderecocomcomplem = e.NewValues["enderecocomcomplem"].ToString();
        //if (e.NewValues["bairrocom"] != null)
        //    bairrocom = e.NewValues["bairrocom"].ToString();
        //if (e.NewValues["cidadecom"] != null)
        //    cidadecom = e.NewValues["cidadecom"].ToString();
        //if (e.NewValues["ufcom"] != null)
        //    ufcom = e.NewValues["ufcom"].ToString();
        //if (e.NewValues["cepcom"] != null)
        //    cepcom = e.NewValues["cepcom"].ToString();
        //if (e.NewValues["fone1com"] != null)
        //    fone1com = e.NewValues["fone1com"].ToString();
        //if (e.NewValues["fone2com"] != null)
        //    fone2com = e.NewValues["fone2com"].ToString();
        //if (e.NewValues["fone3com"] != null)
        //    fone3com = e.NewValues["fone3com"].ToString();
        //if (e.NewValues["email1"] != null)
        //    email1 = e.NewValues["email1"].ToString();
        //if (e.NewValues["email2"] != null)
        //    email2 = e.NewValues["email2"].ToString();
        //if (e.NewValues["email3"] != null)
        //    email3 = e.NewValues["email3"].ToString();
        //if (e.NewValues["email4"] != null)
        //    email4 = e.NewValues["email4"].ToString();
        //if (e.NewValues["email5"] != null)
        //    email5 = e.NewValues["email5"].ToString();
        //if (e.NewValues["gerente"] != null)
        //    gerente = e.NewValues["gerente"].ToString();
        //if (e.NewValues["contato"] != null)
        //    contato = e.NewValues["contato"].ToString();
        //if (e.NewValues["dtnascimento"] != null)
        //    dtnascimento = Convert.ToDateTime(e.NewValues["dtnascimento"].ToString());
        //if (e.NewValues["dtingresso"] != null)
        //    dtingresso = Convert.ToDateTime(e.NewValues["dtingresso"].ToString());
        //if (e.NewValues["ncontrato"] != null)
        //    ncontrato = e.NewValues["ncontrato"].ToString();
        //if (e.NewValues["dtcontrato"] != null)
        //    dtcontrato = Convert.ToDateTime(e.NewValues["dtcontrato"].ToString());
        //if (e.NewValues["ativo"] != null)
        //    ativo = Convert.ToBoolean(e.NewValues["ativo"].ToString());
        //if (e.NewValues["acessointernet"] != null)
        //    acessointernet = Convert.ToBoolean(e.NewValues["acessointernet"].ToString());
        //if (e.NewValues["obs1"] != null)
        //    obs1 = e.NewValues["obs1"].ToString();
        //if (e.NewValues["obs2"] != null)
        //    obs2 = e.NewValues["obs2"].ToString();
        //if (e.NewValues["obs3"] != null)
        //    obs3 = e.NewValues["obs3"].ToString();
        //if (e.NewValues["obs4"] != null)
        //    obs4 = e.NewValues["obs4"].ToString();
        //if (e.NewValues["obs5"] != null)
        //    obs5 = e.NewValues["obs5"].ToString();
        //if (e.NewValues["instrcob1"] != null)
        //    instrcob1 = e.NewValues["instrcob1"].ToString();
        //if (e.NewValues["instrcob2"] != null)
        //    instrcob2 = e.NewValues["instrcob2"].ToString();
        //if (e.NewValues["diasprotesto"] != null)
        //    diasprotesto = e.NewValues["diasprotesto"].ToString();
        //if (e.NewValues["conta1"] != null)
        //    conta1 = e.NewValues["conta1"].ToString();
        //if (e.NewValues["conta2"] != null)
        //    conta2 = e.NewValues["conta2"].ToString();
        //if (e.NewValues["conta3"] != null)
        //    conta3 = e.NewValues["conta3"].ToString();
        //if (e.NewValues["conta4"] != null)
        //    conta4 = e.NewValues["conta4"].ToString();
        //if (e.NewValues["conta5"] != null)
        //    conta5 = e.NewValues["conta5"].ToString();

        //uEmpresa.Grava(apelido,
        //               nome,
        //               cnpj,
        //               inscmunicipal,
        //               inscestadual,
        //               regjuntacom,
        //               nire,
        //               enderecocom,
        //               enderecocomnumero,
        //               enderecocomcomplem,
        //               bairrocom,
        //               cidadecom,
        //               ufcom,
        //               cepcom,
        //               fone1com,
        //               fone2com,
        //               fone3com,
        //               email1,
        //               email2,
        //               email3,
        //               email4,
        //               email5,
        //               gerente,
        //               contato,
        //               dtnascimento,
        //               dtingresso,
        //               ncontrato,
        //               dtcontrato,
        //               ativo,
        //               acessointernet,
        //               obs1,
        //               obs2,
        //               obs3,
        //               obs4,
        //               obs5,
        //               instrcob1,
        //               instrcob2,
        //               diasprotesto,
        //               conta1,
        //               conta2,
        //               conta3,
        //               conta4,
        //               conta5);

        ////Código Original
        //gridView.CancelEdit();
        //e.Cancel = true;

        ////Usando Classe uLog.MakeLog - Gravando Log
        //fwObs_Log = "INCLUI EMPRESA: " + "NOVO" + "/" + e.NewValues["apelido"].ToString().ToUpper();
        //SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
        //                             new SqlParameter("@tabela"   , fWtabela                     ),
        //                             new SqlParameter("@operacao" , "EMPRESA"                    ),
        //                             new SqlParameter("@obs"      , "INCLUI"                     ),
        //                             new SqlParameter("@acao"     , fwObs_Log                    ) };
        //uLog.MakeLog(param_log);
        //
        AtualizaGrid();

    }
    protected void GridListagem_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
    {
        ASPxGridView gridView = (ASPxGridView)sender;

        //
        string produto = "";
        string grupo = "";
        string unidade = "";
        string parte = "";
        decimal metragem_total = 0;
        decimal vlr_total = 0;
        decimal vlr_1 = 0;
        decimal metragem_1 = 0;
        string inscricao_1 = "";
        string proprietario_1 = "";
        Boolean quitado_1 = false;
        Boolean escritura_1 = false;
        DateTime dtescritura_1 = Convert.ToDateTime("01/01/1900");
        string cartorio_1 = "";
        string livro_1 = "";
        string folha_1 = "";
        Boolean processo_1 = false;
        string obs_1 = "";
        decimal vlr_2 = 0;
        decimal metragem_2 = 0;
        string inscricao_2 = "";
        string proprietario_2 = "";
        Boolean quitado_2 = false;
        Boolean escritura_2 = false;
        DateTime dtescritura_2 = Convert.ToDateTime("01/01/1900");
        string cartorio_2 = "";
        string livro_2 = "";
        string folha_2 = "";
        Boolean processo_2 = false;
        string obs_2 = "";
        //
        decimal area_privativa_coletiva_m2 = 0;
        decimal area_privativa_terraco_coberto_m2 = 0;
        decimal area_privativa_terraco_descoberto_m2 = 0;
        decimal area_comum_m2 = 0;
        decimal area_garagem_m2 = 0;
        decimal area_hobby_box_m2 = 0;
        decimal area_total_m2 = 0;
        decimal fracao_ideal_m2 = 0;
        decimal fracao_ideal_percentual = 0;
        string hobby_box_numero = "";
        string hobby_box_localizacao = "";
        string numero_garagem_01 = "";
        string numero_garagem_02 = "";
        string numero_garagem_03 = "";
        string numero_garagem_04 = "";
        string numero_garagem_05 = "";
        string vagas_localizacao = "";
        Int16 vagas_quantidade = 0;
        //
        //
        // Empresa
        ID = e.NewValues["ID"].ToString();
        produto = e.NewValues["produto"].ToString();
        grupo = e.NewValues["grupo"].ToString();
        unidade = e.NewValues["unidade"].ToString();
        parte = e.NewValues["parte"].ToString();
        if (e.NewValues["metragem_total"] != null)
            metragem_total = Convert.ToDecimal(e.NewValues["metragem_total"].ToString());
        if (e.NewValues["vlr_total"] != null)
            vlr_total = Convert.ToDecimal(e.NewValues["vlr_total"].ToString());
        if (e.NewValues["vlr_1"] != null)
            vlr_1 = Convert.ToDecimal(e.NewValues["vlr_1"].ToString());
        if (e.NewValues["metragem_1"] != null)
            metragem_1 = Convert.ToDecimal(e.NewValues["metragem_1"].ToString());
        if (e.NewValues["inscricao_1"] != null)
            inscricao_1 = e.NewValues["inscricao_1"].ToString();
        if (e.NewValues["proprietario_1"] != null)
            proprietario_1 = e.NewValues["proprietario_1"].ToString();
        if (e.NewValues["quitado_1"] != null)
            quitado_1 = Convert.ToBoolean(e.NewValues["quitado_1"].ToString());
        if (e.NewValues["escritura_1"] != null)
            escritura_1 = Convert.ToBoolean(e.NewValues["escritura_1"].ToString());
        if (e.NewValues["dtescritura_1"] != null)
            dtescritura_1 = Convert.ToDateTime(e.NewValues["dtescritura_1"].ToString());
        if (e.NewValues["cartorio_1"] != null)
            cartorio_1 = e.NewValues["cartorio_1"].ToString();
        if (e.NewValues["livro_1"] != null)
            livro_1 = e.NewValues["livro_1"].ToString();
        if (e.NewValues["folha_1"] != null)
            folha_1 = e.NewValues["folha_1"].ToString();
        if (e.NewValues["processo_1"] != null)
            processo_1 = Convert.ToBoolean(e.NewValues["processo_1"].ToString());
        if (e.NewValues["obs_1"] != null)
            obs_1 = e.NewValues["obs_1"].ToString();
        if (e.NewValues["vlr_2"] != null)
            vlr_2 = Convert.ToDecimal(e.NewValues["vlr_2"].ToString());
        if (e.NewValues["metragem_2"] != null)
            metragem_2 = Convert.ToDecimal(e.NewValues["metragem_2"].ToString());
        if (e.NewValues["inscricao_2"] != null)
            inscricao_2 = e.NewValues["inscricao_2"].ToString();
        if (e.NewValues["proprietario_2"] != null)
            proprietario_2 = e.NewValues["proprietario_2"].ToString();
        if (e.NewValues["quitado_2"] != null)
            quitado_2 = Convert.ToBoolean(e.NewValues["quitado_2"].ToString());
        if (e.NewValues["escritura_2"] != null)
            escritura_2 = Convert.ToBoolean(e.NewValues["escritura_2"].ToString());
        if (e.NewValues["dtescritura_2"] != null)
            dtescritura_2 = Convert.ToDateTime(e.NewValues["dtescritura_2"].ToString());
        if (e.NewValues["cartorio_2"] != null)
            cartorio_2 = e.NewValues["cartorio_2"].ToString();
        if (e.NewValues["livro_2"] != null)
            livro_2 = e.NewValues["livro_2"].ToString();
        if (e.NewValues["folha_2"] != null)
            folha_2 = e.NewValues["folha_2"].ToString();
        if (e.NewValues["processo_2"] != null)
            processo_2 = Convert.ToBoolean(e.NewValues["processo_2"].ToString());
        if (e.NewValues["obs_2"] != null)
            obs_2 = e.NewValues["obs_2"].ToString();
        //
        if (e.NewValues["area_privativa_coletiva_m2"] != null)
            area_privativa_coletiva_m2 = Convert.ToDecimal(e.NewValues["area_privativa_coletiva_m2"]);
        if (e.NewValues["area_privativa_terraco_coberto_m2"] != null)
            area_privativa_terraco_coberto_m2 = Convert.ToDecimal(e.NewValues["area_privativa_terraco_coberto_m2"]);
        if (e.NewValues["area_privativa_terraco_descoberto_m2"] != null)
            area_privativa_terraco_descoberto_m2 = Convert.ToDecimal(e.NewValues["area_privativa_terraco_descoberto_m2"]);
        //
        if (e.NewValues["area_comum_m2"] != null)
            area_comum_m2 = Convert.ToDecimal(e.NewValues["area_comum_m2"]);
        if (e.NewValues["area_garagem_m2"] != null)
            area_garagem_m2 = Convert.ToDecimal(e.NewValues["area_garagem_m2"]);
        if (e.NewValues["area_hobby_box_m2"] != null)
            area_hobby_box_m2 = Convert.ToDecimal(e.NewValues["area_hobby_box_m2"]);
        if (e.NewValues["area_total_m2"] != null)
            area_total_m2 = Convert.ToDecimal(e.NewValues["area_total_m2"]);
        if (e.NewValues["fracao_ideal_m2"] != null)
            fracao_ideal_m2 = Convert.ToDecimal(e.NewValues["fracao_ideal_m2"]);
        if (e.NewValues["fracao_ideal_percentual"] != null)
            fracao_ideal_percentual = Convert.ToDecimal(e.NewValues["fracao_ideal_percentual"]);
        //
        if (e.NewValues["hobby_box_numero"] != null)
            hobby_box_numero = e.NewValues["hobby_box_numero"].ToString();
        if (e.NewValues["hobby_box_localizacao"] != null)
            hobby_box_localizacao = e.NewValues["hobby_box_localizacao"].ToString();
        if (e.NewValues["numero_garagem_01"] != null)
            numero_garagem_01 = e.NewValues["numero_garagem_01"].ToString();
        if (e.NewValues["numero_garagem_02"] != null)
            numero_garagem_02 = e.NewValues["numero_garagem_02"].ToString();
        if (e.NewValues["numero_garagem_03"] != null)
            numero_garagem_03 = e.NewValues["numero_garagem_03"].ToString();
        if (e.NewValues["numero_garagem_04"] != null)
            numero_garagem_04 = e.NewValues["numero_garagem_04"].ToString();
        if (e.NewValues["numero_garagem_05"] != null)
            numero_garagem_05 = e.NewValues["numero_garagem_05"].ToString();
        //
        if (e.NewValues["vagas_localizacao"] != null)
            vagas_localizacao = e.NewValues["vagas_localizacao"].ToString();
        if (e.NewValues["vagas_quantidade"] != null)
            vagas_quantidade = Convert.ToInt16(e.NewValues["vagas_quantidade"]);
        //        

        uUnidade.Altera(ID,
                        produto,
                        grupo,
                        unidade,
                        parte,
                        metragem_total,
                        vlr_total,
                        vlr_1,
                        metragem_1,
                        inscricao_1,
                        proprietario_1,
                        Convert.ToInt16(quitado_1),
                        Convert.ToInt16(escritura_1),
                        Convert.ToString(dtescritura_1).Substring(0, 10),
                        cartorio_1,
                        livro_1,
                        folha_1,
                        Convert.ToInt16(processo_1),
                        obs_1,
                        vlr_2,
                        metragem_2,
                        inscricao_2,
                        proprietario_2,
                        Convert.ToInt16(quitado_2),
                        Convert.ToInt16(escritura_2),
                        Convert.ToString(dtescritura_2).Substring(0, 10),
                        cartorio_2,
                        livro_2,
                        folha_2,
                        Convert.ToInt16(processo_2),
                        obs_2,
                        area_privativa_coletiva_m2,
                        area_privativa_terraco_coberto_m2,
                        area_privativa_terraco_descoberto_m2,
                        area_comum_m2,
                        area_garagem_m2,
                        area_hobby_box_m2,
                        area_total_m2,
                        fracao_ideal_m2,
                        fracao_ideal_percentual,
                        hobby_box_numero,
                        hobby_box_localizacao,
                        numero_garagem_01,
                        numero_garagem_02,
                        numero_garagem_03,
                        numero_garagem_04,
                        numero_garagem_05,
                        vagas_localizacao,
                        vagas_quantidade);


        gridView.CancelEdit();
        e.Cancel = true;

        //Usando Classe uLog.MakeLog - Gravando Log
        fwObs_Log = "ALTERA PRODUTO UNIDADE: " + produto + "/" + grupo + "/" + unidade + "/" + parte;
        SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
                                     new SqlParameter("@tabela"   , fWtabela                     ),
                                     new SqlParameter("@operacao" , "PRODUTO UNIDADE"            ),
                                     new SqlParameter("@obs"      , "ALTERA"                     ),
                                     new SqlParameter("@acao"     , fwObs_Log                    ) };
        uLog.MakeLog(param_log);

        //
        AtualizaGrid();
    }

    protected void GridListagem_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {
        //ASPxGridView gridView = (ASPxGridView)sender;

        //uEmpresa.Exclui(e.Values["ID"].ToString());
        ////

        //gridView.CancelEdit();
        //e.Cancel = true;

        ////Usando Classe uLog.MakeLog - Gravando Log
        //fwObs_Log = "EXCLUI EMPRESA: " + e.Values["ID"].ToString() + "/" + e.Values["apelido"].ToString().ToUpper();
        //SqlParameter[] param_log = { new SqlParameter("@login"    , (String)Session["CodUsuario"]), 
        //                             new SqlParameter("@tabela"   , fWtabela                     ),
        //                             new SqlParameter("@operacao" , "EMPRESA"                    ),
        //                             new SqlParameter("@obs"      , "EXCLUI"                     ),
        //                             new SqlParameter("@acao"     , fwObs_Log                    ) };
        //uLog.MakeLog(param_log);
        //
        AtualizaGrid();

    }

    protected void GridListagem_CommandButtonInitialize(object sender, ASPxGridViewCommandButtonEventArgs e)
    {
        //Botão Edit
        if (e.ButtonType == DevExpress.Web.ASPxGridView.ColumnCommandButtonType.Edit)
            e.Visible = lAltera;

        //Botão Novo
        if (e.ButtonType == DevExpress.Web.ASPxGridView.ColumnCommandButtonType.New)
            e.Visible = lInsere;

        //Botão Altera
        if (e.ButtonType == DevExpress.Web.ASPxGridView.ColumnCommandButtonType.Update)
            e.Visible = lAltera;

        //Botão Exclui
        if (e.ButtonType == DevExpress.Web.ASPxGridView.ColumnCommandButtonType.Delete)
            e.Visible = lExclui;

    }
    protected void GridListagem_InitNewRow(object sender, DevExpress.Web.Data.ASPxDataInitNewRowEventArgs e)
    {
        //e.NewValues["dtnascimento"] = Convert.ToDateTime("01/01/1900");
        //e.NewValues["dtingresso"] = DateTime.Now;
        //e.NewValues["dtcontrato"] = Convert.ToDateTime("01/01/1900");
        //e.NewValues["ativo"] = true;
        //e.NewValues["acessointernet"] = true;
        //e.NewValues["gerente"] = "GERAL";
    }

    private void GetSelectedValues()
    {
        if (selectedValues != null)
            selectedValues.Clear();

        List<string> fieldNames = new List<string>();
        foreach (GridViewColumn column in GridListagem.Columns)
            if (column is GridViewDataColumn)
                fieldNames.Add(((GridViewDataColumn)column).FieldName);
        selectedValues = GridListagem.GetSelectedFieldValues(fieldNames.ToArray());
    }


    protected void ednumeracao_TextChanged(object sender, EventArgs e)
    {
        if (rbnumeracao.SelectedIndex == 1)
        {
            if (ednumeracao4.IsVisible())
                ednumeracao4.Focus();
        }
        //Informada Manualmente
        if (rbnumeracao.SelectedIndex == 2)
        {
            //ednumeracao4.Text = ednumeracao4.Text + ednumeracao2.Text + ", ";
        }

    }

    protected void btnumeracaomanual_Click(object sender, EventArgs e)
    {
        Int32 aux = 1;
        aux = Srelib.Ocorrenciasstring(ednumeracao4.Text, ",");
        if (aux == -1)
            aux = 1;
        //
        int unidades = 0;
        unidades = uProduto.PegaProdutoGrupoQuantidade(Convert.ToInt32(cbproduto.Value), Convert.ToInt32(cbgrupo.Value));
        //
        if (aux < unidades)
        {
            ednumeracao.Text = "Informe o numero da unidade (" + aux + "/" + unidades.ToString().Trim() + ") : ";

            //
            if (ednumeracao2.Text != "")
            {
                //Verifica se ja foi digitado
                if (Srelib.Ocorrenciasstring(ednumeracao4.Text, ednumeracao2.Text) == 0)
                {
                    if (Convert.ToInt32(ednumeracao2.Text) != 0)
                    {
                        ednumeracao4.Text = ednumeracao4.Text + ednumeracao2.Text + ", ";
                        //ednumeracao2.Text = "";
                        ednumeracao2.Focus();
                    }
                }
            }
            unidades = 0;
            unidades = uProduto.PegaProdutoGrupoQuantidade(Convert.ToInt32(cbproduto.Value), Convert.ToInt32(cbgrupo.Value));
            aux = Srelib.Ocorrenciasstring(ednumeracao4.Text, ",");
            if (aux == -1)
                aux = 1;
            //
            ednumeracao.Text = "Informe o numero da unidade (" + aux + "/" + unidades.ToString().Trim() + ") : ";
            //
            ednumeracao2.Focus();
        }
    }
}
