using System;
using System.Web;
using System.Text;


public partial class FNovidades : System.Web.UI.Page
{
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

        //Carregamento
        StringBuilder texto = new StringBuilder();

        texto.Append("GITANO - SFIN - FINANCIAMENTOS, VERSÃO DOS-WEB 1995/" + DateTime.Now.Year.ToString()).AppendLine();
        texto.AppendLine();
        texto.AppendLine();
        //
        texto.Append("05/04/2019 - Aprimorado a consulta de renegociações e criada a consulta de desistências, para verificação de dados armazenados. ").AppendLine();
        texto.AppendLine();
        //
        texto.Append("05/04/2019 - Ativado a mascara de milhar em relatórios e consultas em tela nos grids. ").AppendLine();
        texto.AppendLine();
        //
        texto.Append("28/03/2019 - Ativado o controle de acesso por usuários via permissões, anteriormente o controle estava ativo apenas para as opções presentes nos menus e nas opções internas das paginas. Agora está ativado também a habilitação das opções de menus, permitindo que eles sejam clicáveis ou não. ").AppendLine();
        texto.AppendLine();
        //
        texto.Append("05/02/2019 - Reformulado Cabeçalho e Totalizadores dos Relatórios de Extrato de Financiamentos, Extrato de Financiamentos Corrigido, Extrato de Correção, Saldos de Financiamentos, Saldo Devedor e Saldo Credor. ").AppendLine();
        texto.AppendLine();
        //
        texto.Append("13/01/2019 - Novo modelo de notificação para mensagens do sistema, não exigindo intervençao do usuário nem suspenção do uso do sistema, baseado em JQuery-Toastr. ").AppendLine();
        texto.AppendLine();
        //
        texto.Append("13/12/2018 - Permissões de Usuários, criado filtro por módulo do sistema, permitindo ao usuário trabalhar as permissões módulo á módulo. ").AppendLine();
        texto.AppendLine();
        //
        texto.Append("08/11/2018 - Relatório de Devedores, incluido filtro para Cobrança, Todas, Bancária e Carteira. ").AppendLine();
        texto.AppendLine();
        //
        texto.Append("01/11/2018 - Implementado na Consulta de Renegociações acesso a todas as Renegociações de uma Unidade. ").AppendLine();
        texto.AppendLine();
        //
        texto.Append("22/10/2018 - Criado o Relatório de Não Quitados, relacionando financiamentos em que estão em aberto. ").AppendLine();
        texto.AppendLine();
        //
        texto.Append("21/10/2018 - Correção Monetária, Elaborada trava para Financiamentos Quitados não sejam incluidos na correção. ").AppendLine();
        texto.AppendLine();
        texto.Append("21/10/2018 - Menu Pagamentos, Elaboradas travas para Financiamentos Quitados e parcelas Inativadas. ").AppendLine();
        texto.AppendLine();
        texto.Append("21/10/2018 - Menu Vendas, Elaboradas travas para Financiamentos Quitados. ").AppendLine();
        texto.AppendLine();
        //
        texto.Append("12/10/2018 - Relatório de Inadimplência, inclusão de funcionalidade no caso de seleção por número de parcelas, opção de marcar a partir de (n) parcelas, por exemplo, a partir de 3 parcelas de inadimplência até (n). ").AppendLine();
        texto.AppendLine();
        texto.Append("15/08/2018 - Relatório de Fluxo de Caixa, Todos, incluída opção de selecionar várias contas correntes. ").AppendLine();
        texto.AppendLine();
        texto.Append("10/08/2018 - Atualização da versão do Visual Studio e adequação de código interno. ").AppendLine();
        texto.AppendLine();
        texto.Append("10/08/2018 - Início da refatoração (Otimização) do código interno do sistema, visando performance. ").AppendLine();
        texto.AppendLine();
        texto.Append("10/08/2018 - Inclusão de Financiamentos com Tabela Price no momento da venda. ").AppendLine();
        texto.AppendLine();
        texto.Append("15/08/2016 - Contas a Pagar e Receber, caso o parâmetro ORDEM FORNECEDORES esteja por descrição/nome é possivel configurar outro parametro FILTRO FORNECEDOR para usar o combo via digitação do nome ").AppendLine();
        texto.AppendLine();
        texto.Append("20/06/2016 - Correção das tabelas de Taxas Diárias/Mensais inclusão e exclusão. ").AppendLine();
        texto.AppendLine();
        texto.Append("31/05/2016 - Novo relatório, Menu Config->Análises->Segurança, opção para impressão de Relatório da Seleção ").AppendLine();

        MemoNovidades.Text = texto.ToString();  
        //
    }


}
