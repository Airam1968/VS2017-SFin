using System;
using System.Web;
using System.Text;


public partial class FLicencaUso : System.Web.UI.Page
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

        texto.Append("GITANO - SFIN - FINANCIAMENTOS E COMPONENTES DE SOFTWARE RELACIONADOS. VERSÃO 1995-" + DateTime.Now.Year.ToString()).AppendLine();
        texto.AppendLine();
        texto.AppendLine();
        //
        texto.Append("CONTRATO DE LICENÇA DE USUÁRIO FINAL PARA SOFTWARE GITANO ").AppendLine();
        texto.AppendLine();
        texto.Append("IMPORTANTE - LEIA COM ATENÇÃO: Este Contrato de Licença de Usuário Final GITANO (CLUF, CONTRATO DE LICENÇA DE USO PARA USUÁRIO FINAL) ‚ um acordo legal entre você (pessoa física ou jurídica) e a Vivian Teixeira Fernandes MEI., inscrita sob o CGC No. 13.305.470/0001-05, estabelecida a Rua Palmares, 116/44 - Parque Industrial - São José‚ dos Campos - SP, para o software GITANO identificado acima, que pode incluir componentes de software associados, meios físicos, materiais impressos e documentação on-line ou eletrônica (SOFTWARE). Ao instalar, copiar ou de qualquer outra forma utilizar o SOFTWARE, você está  concordando em vincular-se aos termos deste CLUF. Caso não esteja de acordo com os termos deste CLUF, não instale ou utilize o SOFTWARE. Caso tenha adquirido o SOFTWARE, você poder  devolvê-lo ao local de compra para ser reembolsado. ").AppendLine();
        texto.AppendLine();
        texto.Append("Este SOFTWARE ‚ protegidos por leis de copyright e tratados internacionais, bem como por outras legislações e tratados sobre propriedade intelectual. O SOFTWARE ‚ licenciado e não vendido. ").AppendLine();
        texto.AppendLine();
        texto.Append("1. CONCESSÃO DE LICENÇA. O SOFTWARE ‚ licenciado conforme as disposições abaixo: ").AppendLine();
        texto.AppendLine();
        texto.Append("*Instalação e uso: A GITANO lhe concede o direito de instalar e usar cópias do SOFTWARE em seus computadores executando cópias validamente licenciadas do sistema operacional para qual o SOFTWARE foi elaborado (por exemplo, Windows(r) 7, Windows Server, Android, Macintosh, etc.). ").AppendLine();
        texto.AppendLine();
        texto.Append("*Cópias de backup: você pode também fazer cópias do SOFTWARE, conforme necessário, para fins de cópias de backup ou arquivo. ").AppendLine();
        texto.AppendLine();
        texto.Append("*Componentes. Certos componentes do SOFTWARE estão sujeitos as seguintes cláusulas adicionais: ").AppendLine();
        texto.AppendLine();
        texto.Append("GITANO pode ser instalado em um servidor de rede, para utilização pelas estações ligadas a referida rede, controlando as funções da empresa a qual foi licenciado por este CLUF. Permitindo assim o uso simultâneo do referido componente.  ").AppendLine();
        texto.AppendLine();
        texto.Append("2. DESCRIÇÃO DE OUTROS DIREITOS E LIMITAÇÕES. ").AppendLine();
        texto.AppendLine();
        texto.Append("* Manutenção dos avisos de copyright.  vedada a remoção ou alteração de quaisquer avisos de copyright das cópias do SOFTWARE. ").AppendLine();
        texto.AppendLine();
        texto.Append("* Distribuição.  vedada a distribuição de cópias do SOFTWARE para terceiros. ").AppendLine();
        texto.AppendLine();
        texto.Append("* Engenharia reversa, descompilação e desmontagem.  vedada a engenharia reversa, descompilação ou desmontagem do SOFTWARE, exceto e somente na medida em que estas atividades sejam expressamente permitidas pela legislação aplicável, inobstante tal limitação. ").AppendLine();
        texto.AppendLine();
        texto.Append("* Locação.  vedada à locação, sublocação, aluguel ou arrendamento do SOFTWARE. Função exclusiva da GITANO e possui direitos exclusivos. ").AppendLine();
        texto.AppendLine();
        texto.Append("* Transferência. Você poder  transferir permanentemente todos os seus direitos sob este CLUF, desde que o adquirente concorde com os termos deste CLUF. ").AppendLine();
        texto.AppendLine();
        texto.Append("*  Serviços de Suporte. A GITANO poder  lhe fornecer serviços de suporte relacionados ao SOFTWARE (Serviços de Suporte). O uso dos Serviços de Suporte ‚ regulamentado pelas diretrizes e programas da GITANO pela legislação pertinente, na documentação on-line e/ou em outros materiais fornecidos pela GITANO. Qualquer código suplementar do software que lhe for fornecido como parte dos Serviços de Suporte dever  ser considerado parte do SOFTWARE e estar  sujeito aos termos e condições deste CLUF. Com respeito as informações técnicas fornecidas por você à GITANO como parte dos Serviços de Suporte, a GITANO pode usar tais informações para fins comerciais, incluindo o desenvolvimento e suporte ao produto. A GITANO não usará  tais informações técnicas de maneira que possam identifica -lo.  ").AppendLine();
        texto.AppendLine();
        texto.Append("* Cumprimento da legislação aplicável. Você deve obedecer todas as leis aplicáveis no que diz respeito ao uso do SOFTWARE. ").AppendLine();
        texto.AppendLine();
        texto.Append("3. RESCISÃO. Sem detrimento de quaisquer outros direitos, a GITANO pode rescindir este CLUF caso você não cumpra com seus termos e condições. Neste caso, você deve destruir todas as cópias do SOFTWARE. ").AppendLine();
        texto.AppendLine();
        texto.Append("4. COPYRIGHT. Todos os títulos e copyright relativos ao SOFTWARE e as suas cópias pertencem à GITANO ou aos seus fornecedores. A titularidade e os direitos de propriedade intelectuais relativos ao conteúdo, que pode ser acessado através do uso do SOFTWARE, pertencem ao proprietário do respectivo conteúdo e são protegidos por leis de copyright e tratados de propriedade intelectual aplicáveis. Este CLUF não lhe concede o direito de utilização de tal conteúdo. Todos os direitos não expressamente concedidos são reservados à GITANO. ").AppendLine();
        texto.AppendLine();
        texto.Append("5. RESTRIÇÕES DE EXPORTAÇÃO. Você concorda em não exportar ou reexportar o SOFTWARE para qualquer país, pessoa física ou jurídica, ou usuário sujeito as restrições de exportação impostas pelo BRASIL. ").AppendLine();
        texto.AppendLine();
        texto.Append("6. GARANTIA, A GITANO garante pelo prazo de 90 ( Noventa ) dias da aquisição deste produto, garantia quanto a falhas, dando suporte ao correto funcionamento do suporte. ").AppendLine();
        texto.AppendLine();
        texto.Append("7. LIMITAÇÃO DE RESPONSABILIDADE. De acordo com as limitações impostas pela legislação aplicável, em nenhuma hipótese, a GITANO ou seus fornecedores serão responsáveis por quaisquer danos especiais, acidentais, consequências ou quaisquer outros danos indiretos (incluindo, sem limitações, danos por perda de lucros comerciais, interrupções de transações comerciais, perda de informações comerciais ou outras perdas pecuniárias), decorrentes do uso ou da impossibilidade de utilizar este SOFTWARE, ou do fornecimento ou da ocorrência de falha no oferecimento de Serviços de Suporte, mesmo que a GITANO tenha sido alertada quanto à possibilidade destes danos. Em todo caso, a inteira responsabilidade da GITANO, sob qualquer cláusula deste CLUF, dever  ser limitada a maior quantia paga por você pelo SOFTWARE ou R$ 5,00 ( Cinco Reais ); se, contudo, você tiver se vinculado a um Contrato de Serviços de Suporte da GITANO, a inteira responsabilidade da GITANO no que se refere aos Serviços de Suporte deverão ser regidas pelos termos daquele contrato. Tendo em vista que alguns países e estados não permitem a exclusão ou limitação de responsabilidade por danos consequenciais ou indiretos, a limitação acima pode não lhe ser aplicável. ").AppendLine();
        texto.AppendLine();
        texto.Append("8. DISPOSIÇOES GERAIS ").AppendLine();
        texto.AppendLine();
        texto.Append("Este CLUF ‚ regido pela legislação do Código de Defesa do Consumidor da Republica Federativa do Brasil. ").AppendLine();
        texto.AppendLine();
        texto.Append("Quaisquer direitos não expressamente concedidos aqui são reservados. ").AppendLine();
        texto.AppendLine();
        MemoLicenca.Text = texto.ToString();
        //
    }

}
