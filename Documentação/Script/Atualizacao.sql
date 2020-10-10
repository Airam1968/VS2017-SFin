/***Atualiza��es SQL***/

/***14/04/2016***/
ALTER TABLE CONTAS_PAGAR
ADD [nominal] [bit] NULL

UPDATE CONTAS_PAGAR
SET
nominal = 0

/***17/05/2016***/
INSERT INTO Parametros VALUES
( 'ORDEM PRODUTO',
'CODIGO',
'ORDENA��O DE PRODUTOS',
'TODO O SISTEMA',
'DEFINE A ORDENA��O PARA PRODUTO, ORDENA��ES POSS�VEIS POR C�DIGO E DESCRI��O, TER CUIDADO COM A GRAFIA, CASO ERRO, ORDENA��O PADR�O POR C�DIGO')

INSERT INTO Parametros VALUES
( 'ORDEM DESPESA',
'CODIGO',
'ORDENA��O DE DESPESAS',
'TODO O SISTEMA',
'DEFINE A ORDENA��O PARA DESPESAS, ORDENA��ES POSS�VEIS POR C�DIGO E DESCRI��O, TER CUIDADO COM A GRAFIA, CASO ERRO, ORDENA��O PADR�O POR C�DIGO')

INSERT INTO Parametros VALUES
( 'ORDEM RECEITA',
'CODIGO',
'ORDENA��O DE RECEITAS',
'TODO O SISTEMA',
'DEFINE A ORDENA��O PARA RECEITAS, ORDENA��ES POSS�VEIS POR C�DIGO E DESCRI��O, TER CUIDADO COM A GRAFIA, CASO ERRO, ORDENA��O PADR�O POR C�DIGO')

INSERT INTO Parametros VALUES
( 'ORDEM FORNECEDOR',
'CODIGO',
'ORDENA��O DE FORNECEDORES',
'TODO O SISTEMA',
'DEFINE A ORDENA��O PARA FORNECEDORES CONTAS A PAGAR, ORDENA��ES POSS�VEIS POR C�DIGO E DESCRI��O, TER CUIDADO COM A GRAFIA, CASO ERRO, ORDENA��O PADR�O POR C�DIGO')

INSERT INTO Parametros VALUES
( 'ORDEM CLIENTE',
'CODIGO',
'ORDENA��O DE CLIENTES',
'TODO O SISTEMA',
'DEFINE A ORDENA��O PARA CLIENTES CONTAS A RECEBER, ORDENA��ES POSS�VEIS POR C�DIGO E DESCRI��O, TER CUIDADO COM A GRAFIA, CASO ERRO, ORDENA��O PADR�O POR C�DIGO')



/***18/08/2016***/
INSERT INTO Parametros VALUES
( 'FILTRO FORNECEDOR',
'SIM',
'FILTRO COMBO FORNECEDORES',
'TODO O SISTEMA',
'DEFINE USO DO FILTRO NO COMBO DE FORNECEDORES, CASO PAR�METRO ORDENA��O DE FORNECEDORES ESTEJA POR NOME, COM O PAR�METRO SIM � POSSIVEL USAR O FILTRO NO COMBO DIGIT�VEL, CASO PAR�METRO N�O USO DO COMBO PADR�O')

INSERT INTO Parametros VALUES
( 'FILTRO CLIENTE',
'SIM',
'FILTRO COMBO CLIENTE',
'TODO O SISTEMA',
'DEFINE USO DO FILTRO NO COMBO DE CLIENTE, CASO PAR�METRO ORDENA��O DE CLIENTE ESTEJA POR NOME, COM O PAR�METRO SIM � POSSIVEL USAR O FILTRO NO COMBO DIGIT�VEL, CASO PAR�METRO N�O USO DO COMBO PADR�O')

/***08/09/2016***/
INSERT INTO Parametros VALUES
( 'FILTRO CONTATO',
'SIM',
'FILTRO COMBO CONTATO',
'TODO O SISTEMA',
'DEFINE USO DO FILTRO NO COMBO DE CONTATO, CASO PAR�METRO ORDENA��O DE CONTATO ESTEJA POR NOME, COM O PAR�METRO SIM � POSSIVEL USAR O FILTRO NO COMBO DIGIT�VEL, CASO PAR�METRO N�O USO DO COMBO PADR�O')


/***15/09/2016***/
ALTER TABLE CONTAS_SALDO_INICIAL
ADD [saldo_aplicacaoD] [decimal](18, 2) NULL

ALTER TABLE CONTAS_SALDO_INICIAL
ADD [saldo_aplicacaoB] [decimal](18, 2) NULL

UPDATE CONTAS_SALDO_INICIAL
SET
saldo_aplicacaoD = 0,
saldo_aplicacaoB = 0


/***03/11/2016***/
INSERT INTO Parametros VALUES
( 'DATA COMPENSA��O',
'NAO',
'DATA COMPENSA��O',
'TODO O SISTEMA',
'DEFINE USO DO PAR�METRO, CASO PAR�METRO ESTEJA N�O NO PREENCHIMENTO DA DATA DE COMPENSA��O NOS LAN�AMENTOS DE CONTAS A PAGAR E RECEBER N�O S�O PREENCHIDOS, COM O PAR�METRO SIM A DATA PREENCHIDA NA DATA REALIZADO SER� REPLICADA PARA A DATA DE COMPENSA��O')


/***11/11/2016***/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[bancos_2](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[cod_banco] [varchar](3) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[data] [datetime] NULL,
	[drive] [varchar](1) NULL,
	[pasta_remessa] [varchar](100) NULL,
	[pasta_retorno] [varchar](100) NULL,
	[pasta_envelope] [varchar](100) NULL,
	[assunto] [varchar](100) NULL,
	[caixa_postal] [varchar](100) NULL,
	[mascara_remessa] [varchar](10) NULL,
	[mascara_retorno] [varchar](10) NULL,
	[nome_arquivo] [varchar](100) NULL,
	[numero_arquivo] [int] NULL,
	[prazo_fol] [int] NULL,
	[prazo_dev] [int] NULL,
	[prazo_pro] [int] NULL,
	[multa] [decimal](18, 2) NULL,
	[juros] [decimal](18, 2) NULL,
	[comissao] [decimal](18, 2) NULL,
	[carteira] [varchar](10) NULL,
	[num_inicial] [int] NULL,
	[num_final] [int] NULL,
	[sequencia] [int] NULL,
	[numero_atual] [int] NULL,
	[complemento] [varchar](100) NULL,
 CONSTRAINT [PK_bancos_2] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/***16/11/2016***/
INSERT INTO Parametros VALUES
( 'DIFEREN�A BAIXA',
'0,50',
'DIFEREN�A ACEIT�VEL',
'COBRAN�A N�O BANC�RIA',
'DEFINE USO DO PAR�METRO, A DIFEREN�A ACEIT�VEL ENTRE O VALOR A PAGAR CORRIGIDO PELO SISTEMA E O VALOR FORNECIDO PELA COBRAN�A N�O BANC�RIA, COM O PAR�METRO ZERADO N�O EFETUA CALCULO DE DIFEREN�A')


/***24/11/2016***/
INSERT INTO Parametros VALUES
( 'TROCA INDEXADOR',
'SIM',
'TRAVA NA TROCA DE INDEXADOR',
'VENDAS',
'DEFINE USO DO PAR�METRO, CASO SIM EXECUTA TRAVA PARA TROCA DE INDEXADOR N�O PERMITINDO CASO N�O HAJA PARCELAS PAGAS, COM O PAR�METRO N�O IGNORA A TRAVA E PERMITE O PROCESSAMENTO.')

/***14/03/2017***/
INSERT INTO Parametros VALUES
( 'CORRIGE PARCELA IPTU',
'SIM',
'CORRIGE PARCELA IPTU',
'PARCELAS',
'DEFINE USO DO PAR�METRO, CASO SIM CORRIGE NORMALMENTE PARCELAS DO TIPO IPTU, COM O PAR�METRO N�O N�O EFETUA A CORRE��O DA PARCELA.')

/***15/03/2017***/
INSERT INTO Parametros VALUES
( 'PROXIMA NOTA FISCAL',
'0',
'PROXIMA NOTA FISCAL',
'VENDAS',
'DEFINE USO DO PAR�METRO, CONTADOR COM O NUMERO DA PR�XIMA NOTA FISCAL A SER IMPRESSA PELO SISTEMA.')

/***15/03/2017***/
ALTER TABLE USUARIO
ALTER COLUMN [nome] [varchar](100) NULL

ALTER TABLE USUARIO
ALTER COLUMN [Setor] [varchar](100) NULL

ALTER TABLE USUARIO
ALTER COLUMN [Funcao] [varchar](100) NULL

ALTER TABLE USUARIO
ALTER COLUMN [email] [varchar](100) NULL

/***05/04/2017***/
INSERT INTO Parametros VALUES
( 'BASE CEP',
'CEP2007',
'BASE DE CEP SISTEMA',
'TODOS O SISTEMA',
'DEFINE USO DO PAR�METRO, NOME DA BASE A SER UTILIZADA PARA PESQUISA DE CEP, VALORES V�LIDOS CEP2007 E CEP2014.')



/***23/05/2017***/

UPDATE cadpermissoes
SET DESCRICAO = 'GITANO - PROPOSTAS',
OBS = 'PERMISS�O M�DULO PROPOSTAS.'
WHERE PERMISSAO = '001.001.000.000'

INSERT INTO cadpermissoes VALUES
( '001.001.001.000',
'GITANO - PROPOSTAS - INCLUIR.',
'PERMISS�O M�DULO PROPOSTAS. - INCLUIR.',
'SIM')

INSERT INTO cadpermissoes VALUES
( '001.001.002.000',
'GITANO - PROPOSTAS - ALTERAR.',
'PERMISS�O M�DULO PROPOSTAS. - ALTERAR.',
'SIM')

INSERT INTO cadpermissoes VALUES
( '001.001.003.000',
'GITANO - PROPOSTAS - EXCLUIR.',
'PERMISS�O M�DULO PROPOSTAS. - EXCLUIR.',
'SIM')

INSERT INTO cadpermissoes VALUES
( '001.001.004.000',
'GITANO - PROPOSTAS - CONSULTAR.',
'PERMISS�O M�DULO PROPOSTAS. - CONSULTAR.',
'SIM')

INSERT INTO cadpermissoes VALUES
( '001.001.005.000',
'GITANO - PROPOSTAS - RELAT�RIO.',
'PERMISS�O M�DULO PROPOSTAS. - RELAT�RIO.',
'SIM')

UPDATE cadpermissoes
SET DESCRICAO = 'GITANO - CONT�BIL',
OBS = 'PERMISS�O M�DULO CONT�BIL.'
WHERE PERMISSAO = '001.010.000.000'

UPDATE cadpermissoes
SET DESCRICAO = 'GITANO - CONT�BIL - INCLUIR.',
OBS = 'PERMISS�O M�DULO CONT�BIL. - INCLUIR.'
WHERE PERMISSAO = '001.010.001.000'

UPDATE cadpermissoes
SET DESCRICAO = 'GITANO - CONT�BIL - ALTERAR.',
OBS = 'PERMISS�O M�DULO CONT�BIL. - ALTERAR.'
WHERE PERMISSAO = '001.010.002.000'

UPDATE cadpermissoes
SET DESCRICAO = 'GITANO - CONT�BIL - EXCLUIR.',
OBS = 'PERMISS�O M�DULO CONT�BIL. - EXCLUIR.'
WHERE PERMISSAO = '001.010.003.000'

UPDATE cadpermissoes
SET DESCRICAO = 'GITANO - CONT�BIL - CONSULTAR.',
OBS = 'PERMISS�O M�DULO CONT�BIL. - CONSULTAR.'
WHERE PERMISSAO = '001.010.004.000'

UPDATE cadpermissoes
SET DESCRICAO = 'GITANO - CONT�BIL - RELAT�RIO.',
OBS = 'PERMISS�O M�DULO CONT�BIL. - RELAT�RIO.'
WHERE PERMISSAO = '001.010.005.000'


INSERT INTO cadpermissoes VALUES
( '001.014.000.000',
'GITANO - JUR�DICO',
'PERMISS�O M�DULO JUR�DICO.',
'SIM')

INSERT INTO cadpermissoes VALUES
( '001.014.001.000',
'GITANO - JUR�DICO - INCLUIR.',
'PERMISS�O M�DULO JUR�DICO. - INCLUIR.',
'SIM')

INSERT INTO cadpermissoes VALUES
( '001.014.002.000',
'GITANO - JUR�DICO - ALTERAR.',
'PERMISS�O M�DULO JUR�DICO. - ALTERAR.',
'SIM')

INSERT INTO cadpermissoes VALUES
( '001.014.003.000',
'GITANO - JUR�DICO - EXCLUIR.',
'PERMISS�O M�DULO JUR�DICO. - EXCLUIR.',
'SIM')

INSERT INTO cadpermissoes VALUES
( '001.014.004.000',
'GITANO - JUR�DICO - CONSULTAR.',
'PERMISS�O M�DULO JUR�DICO. - CONSULTAR.',
'SIM')

INSERT INTO cadpermissoes VALUES
( '001.014.005.000',
'GITANO - JUR�DICO - RELAT�RIO.',
'PERMISS�O M�DULO JUR�DICO. - RELAT�RIO.',
'SIM')


INSERT INTO cadpermissoes VALUES
( '001.015.000.000',
'GITANO - OBRAS',
'PERMISS�O M�DULO OBRAS.',
'SIM')

INSERT INTO cadpermissoes VALUES
( '001.015.001.000',
'GITANO - OBRAS - INCLUIR.',
'PERMISS�O M�DULO OBRAS. - INCLUIR.',
'SIM')

INSERT INTO cadpermissoes VALUES
( '001.015.002.000',
'GITANO - OBRAS - ALTERAR.',
'PERMISS�O M�DULO OBRAS. - ALTERAR.',
'SIM')

INSERT INTO cadpermissoes VALUES
( '001.015.003.000',
'GITANO - OBRAS - EXCLUIR.',
'PERMISS�O M�DULO OBRAS. - EXCLUIR.',
'SIM')

INSERT INTO cadpermissoes VALUES
( '001.015.004.000',
'GITANO - OBRAS - CONSULTAR.',
'PERMISS�O M�DULO OBRAS. - CONSULTAR.',
'SIM')

INSERT INTO cadpermissoes VALUES
( '001.015.005.000',
'GITANO - OBRAS - RELAT�RIO.',
'PERMISS�O M�DULO OBRAS. - RELAT�RIO.',
'SIM')

/***25/09/2017***/
ALTER TABLE produto_grupo
ALTER COLUMN [vlr_venda] [decimal](18, 2) NULL


/***12/06/2017***/
ALTER TABLE [produto_unidades]
ADD [area_privativa_coletiva_m2] [decimal](18, 4) NULL

ALTER TABLE [produto_unidades]
ADD [area_privativa_terraco_coberto_m2] [decimal](18, 4) NULL

ALTER TABLE [produto_unidades]
ADD [area_privativa_terraco_descoberto_m2] [decimal](18, 4) NULL

ALTER TABLE [produto_unidades]
ADD [area_comum_m2] [decimal](18, 4) NULL

ALTER TABLE [produto_unidades]
ADD [area_garagem_m2] [decimal](18, 4) NULL

ALTER TABLE [produto_unidades]
ADD [area_hobby_box_m2] [decimal](18, 4) NULL

ALTER TABLE [produto_unidades]
ADD [area_total_m2] [decimal](18, 4) NULL

ALTER TABLE [produto_unidades]
ADD [fracao_ideal_m2] [decimal](18, 4) NULL

ALTER TABLE [produto_unidades]
ADD [fracao_ideal_percentual] [decimal](18, 8) NULL

ALTER TABLE [produto_unidades]
ADD [hobby_box_numero][varchar](30) NULL

ALTER TABLE [produto_unidades]
ADD [hobby_box_localizacao][varchar](100) NULL

ALTER TABLE [produto_unidades]
ADD [numero_garagem_01] [varchar](10) NULL

ALTER TABLE [produto_unidades]
ADD [numero_garagem_02] [varchar](10) NULL

ALTER TABLE [produto_unidades]
ADD [numero_garagem_03] [varchar](10) NULL

ALTER TABLE [produto_unidades]
ADD [numero_garagem_04] [varchar](10) NULL

ALTER TABLE [produto_unidades]
ADD [numero_garagem_05] [varchar](10) NULL

ALTER TABLE [produto_unidades]
ADD [vagas_localizacao] [varchar](100) NULL

ALTER TABLE [produto_unidades]
ADD [vagas_quantidade]  [int] NULL



UPDATE [produto_unidades]
SET
[area_privativa_coletiva_m2] = 0,
[area_privativa_terraco_coberto_m2]  = 0,
[area_privativa_terraco_descoberto_m2]  = 0,
[area_comum_m2]  = 0,
[area_garagem_m2] = 0,
[area_hobby_box_m2]  = 0,
[area_total_m2]  = 0,
[fracao_ideal_m2]  = 0,
[fracao_ideal_percentual] = 0,
[hobby_box_numero]= '',
[hobby_box_localizacao] = '',
[numero_garagem_01] = '',
[numero_garagem_02] = '',
[numero_garagem_03] = '',
[numero_garagem_04] = '',
[numero_garagem_05] = '',
[vagas_localizacao] = '',
[vagas_quantidade]  = 0


/***25/09/2017***/
ALTER TABLE produto_grupo
ALTER COLUMN [vlr_venda] [decimal](18, 2) NULL

***Tabela de Pre�os das Unidades
ALTER TABLE produto_unidades
ADD [sinal_perc] [decimal](18, 4) NULL,
	[sinal_vlr] [decimal](18, 2) NULL,
	[sinal_venc] [datetime] NULL,
	[intermediarias_perc] [decimal](18, 4) NULL,
	[intermediarias_vlr] [decimal](18, 2) NULL,
	[intermediarias_venc] [datetime] NULL,
	[chaves_perc] [decimal](18, 4) NULL,
	[chaves_vlr] [decimal](18, 2) NULL,
	[chaves_venc] [datetime] NULL,		   
	[fluxo1_perc] [decimal](18, 4) NULL,
	[fluxo1_vlr] [decimal](18, 2) NULL,
	[fluxo1_venc] [datetime] NULL,	
	[fluxo2_perc] [decimal](18, 4) NULL,
	[fluxo2_vlr] [decimal](18, 2) NULL,
	[fluxo2_venc] [datetime] NULL,
	[fluxo3_perc] [decimal](18, 4) NULL,
	[fluxo3_vlr] [decimal](18, 2) NULL,
	[fluxo3_venc] [datetime] NULL
	GO	

update produto_unidades
SET [sinal_perc] = 0,
	[sinal_vlr] = 0,
	[sinal_venc] = '19000101',
	[intermediarias_perc] = 0,
	[intermediarias_vlr] = 0,
	[intermediarias_venc] = '19000101',
	[chaves_perc] = 0,
	[chaves_vlr] = 0,
	[chaves_venc] = '19000101',	   
	[fluxo1_perc] = 0,
	[fluxo1_vlr]  = 0,
	[fluxo1_venc] = '19000101',
	[fluxo2_perc] = 0,
	[fluxo2_vlr] = 0,
	[fluxo2_venc]  = '19000101',
	[fluxo3_perc] = 0,
	[fluxo3_vlr] = 0,
	[fluxo3_venc] = '19000101'
	GO	   	 

/***28/06/2017***/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[proposta]([ID] [int] IDENTITY(1,1) NOT NULL,
	[proposta] [int] NOT NULL,
	[data_proposta] [datetime] NULL,	
	[produto] [int] NOT NULL,	
	[grupo] [int] NOT NULL,	
	[unidade] [int] NOT NULL,
	[parte] [int] NOT NULL,	
	[tipoplanta] [varchar](50) NOT NULL,	
	[indexadorprehabitese] [varchar](20) NOT NULL,			
	[indexadorposhabitese] [varchar](20) NOT NULL,		
	[jurosposhabitese] [varchar](20) NOT NULL,		
	[nome] [varchar](50) NOT NULL,
	[sexo] [varchar](1) NOT NULL,
	[cnpj] [varchar](14) NOT NULL,
	[inscmunicipal] [varchar](20) NULL,
	[inscestadual] [varchar](20) NULL,
	[regjuntacom] [varchar](15) NULL,
	[nire] [varchar](15) NULL,
	[rg] [varchar](14) NULL,
	[rguf] [varchar](2) NULL,
	[rgemissor] [varchar](20) NULL,
	[rgemissao] [datetime] NULL,
	[estadocivil] [varchar](20) NULL,	
	[regimecasamento] [varchar](50) NULL,		
	[nacionalidade] [varchar](20) NULL,	
	[profissao] [varchar](30) NULL,			
	[email1] [varchar](50) NULL,
	[email2] [varchar](50) NULL,
	[email3] [varchar](50) NULL,
	[dtnascimento] [datetime] NULL,
	[conjugenome] [varchar](50) NOT NULL,
	[conjugesexo] [varchar](1) NOT NULL,
	[conjugecpf] [varchar](14) NOT NULL,
	[conjugerg] [varchar](14) NULL,
	[conjugerguf] [varchar](2) NULL,
	[conjugergemissor] [varchar](20) NULL,
	[conjugergemissao] [datetime] NULL,
	[conjugenacionalidade] [varchar](20) NULL,	
	[conjugeprofissao] [varchar](30) NULL,					
	[conjugeemail1] [varchar](50) NULL,
	[conjugeemail2] [varchar](50) NULL,
	[conjugeemail3] [varchar](50) NULL,
	[conjugedtnascimento] [datetime] NULL,	
	[endereco] [varchar](1) NOT NULL,
	[enderecores] [varchar](70) NULL,
	[enderecoresnumero] [varchar](30) NULL,
	[enderecorescomplem] [varchar](30) NULL,
	[bairrores] [varchar](25) NULL,
	[cidaderes] [varchar](25) NULL,
	[ufres] [varchar](2) NULL,
	[cepres] [varchar](8) NULL,
	[fone1res] [varchar](30) NULL,
	[fone2res] [varchar](30) NULL,
	[fone3res] [varchar](30) NULL,
	[enderecocom] [varchar](70) NULL,
	[enderecocomnumero] [varchar](30) NULL,
	[enderecocomcomplem] [varchar](30) NULL,
	[bairrocom] [varchar](25) NULL,
	[cidadecom] [varchar](25) NULL,
	[ufcom] [varchar](2) NULL,
	[cepcom] [varchar](8) NULL,
	[fone1com] [varchar](30) NULL,
	[fone2com] [varchar](30) NULL,
	[fone3com] [varchar](30) NULL,	
	[ativo] [bit] NOT NULL,
	[comissaopermanencia] [decimal](18, 2) NOT NULL,
	[tabelaprice] [bit] NOT NULL,
	[valor_venda] [decimal](18, 2) NOT NULL,	
	[sinal] [decimal](18, 2) NOT NULL,	
	[saldo] [decimal](18, 2) NOT NULL,	
	[plano1_parcelas_qtd] [decimal](18, 2) NULL,
	[plano1_parcelas_vlr] [decimal](18, 2) NULL,			
	[plano1_parcelas_vencimento] [datetime] NULL,	
	[plano2_parcelas_qtd] [decimal](18, 2) NULL,
	[plano2_parcelas_vlr] [decimal](18, 2) NULL,			
	[plano2_parcelas_vencimento] [datetime] NULL,	
	[plano3_parcelas_qtd] [decimal](18, 2) NULL,
	[plano3_parcelas_vlr] [decimal](18, 2) NULL,			
	[plano3_parcelas_vencimento] [datetime] NULL,	
	[plano4_parcelas_qtd] [decimal](18, 2) NULL,
	[plano4_parcelas_vlr] [decimal](18, 2) NULL,			
	[plano4_parcelas_vencimento] [datetime] NULL,	
	[plano5_parcelas_qtd] [decimal](18, 2) NULL,
	[plano5_parcelas_vlr] [decimal](18, 2) NULL,			
	[plano5_parcelas_vencimento] [datetime] NULL,	
	[plano6_parcelas_qtd] [decimal](18, 2) NULL,
	[plano6_parcelas_vlr] [decimal](18, 2) NULL,			
	[plano6_parcelas_vencimento] [datetime] NULL,	
	[plano7_parcelas_qtd] [decimal](18, 2) NULL,
	[plano7_parcelas_vlr] [decimal](18, 2) NULL,			
	[plano7_parcelas_vencimento] [datetime] NULL,							
	[plano8_parcelas_qtd] [decimal](18, 2) NULL,
	[plano8_parcelas_vlr] [decimal](18, 2) NULL,			
	[plano8_parcelas_vencimento] [datetime] NULL,				
	[obs] [varchar](200) NULL,
    [corretor]  [int] NULL,	
 CONSTRAINT [PK_proposta] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

  
	
/***24/11/2017***/
INSERT INTO Parametros VALUES
( 'RELATORIO ZEBRADO',
'SIM',
'RELATORIO ZEBRADO',
'TODO O SISTEMA',
'DEFINE A EMISS�O DE RELAT�RIOS ZEBRADOS OU SEM ZEBRADO LINHA A LINHA, SIM ATIVA O ZEBRADO, N�O DESATIVA O ZEBRADO')
  	   

/***13/12/2017***/
INSERT INTO Parametros VALUES
( 'EXIBE CONTA CORRENTE',
'N�O',
'CONTAS CORRENTES',
'TODO O SISTEMA',
'DEFINE A EXIBI��O DE CONTAS CORRENTES SEM MOVIMENTO, ENCERRADAS, NOS COMBOS DE SELE��O DE CONTAS DO SISTEMA, SIM EXIBE NORMALMENTE, N�O, N�O EXIBE. USADO EM CONJUNTO COM O CAMPO COMBO DA TABELA CONTAS.')


ALTER TABLE CONTAS
ADD combo bit NULL
go

update CONTAS
SET [combo] = 1


/***14/12/2017***/
INSERT INTO Parametros VALUES
( 'EXIBE LOGO RELAT�RIO',
'SIM',
'RELAT�RIOS',
'TODO O SISTEMA',
'DEFINE A EXIBI��O DA IMAGEM DE LOGO NOS RELAT�RIOS, MARCADO SIM EXIBE NORMALMENTE, SE MARCADO N�O, N�O EXIBE.')


INSERT INTO Parametros VALUES
( 'EXIBE EMPRESA RELAT',
'SIM',
'RELAT�RIOS',
'TODO O SISTEMA',
'DEFINE A EXIBI��O DO NOME DA EMPRESA NOS RELAT�RIOS, MARCADO SIM EXIBE NORMALMENTE, SE MARCADO N�O, N�O EXIBE.')


INSERT INTO Parametros VALUES
( 'EXIBE FILTRO RELAT',
'SIM',
'RELAT�RIOS',
'TODO O SISTEMA',
'DEFINE A EXIBI��O DO CABE�ALHO DOS CAMPOS EM TODAS AS PAGINAS DO RELAT�RIO, MARCADO SIM EXIBE NORMALMENTE, SE MARCADO N�O, EXIBE S� NA PRIMEIRA PAGINA.')


/***16/01/2018***/
ALTER TABLE VENDAS
ADD [tabela_price] [bit] NULL,
	[juros_price] [decimal](18, 8) NULL,
	[total_parcelas_price] [int] NULL,
	[indexadorejuros] [bit] NULL,
	[indexador_juros]  [varchar](20) NULL
GO

UPDATE VENDAS
SET
[tabela_price] = 0,
[juros_price] = 0.00,
[total_parcelas_price] = 0,
[indexadorejuros] = 0,
[indexador_juros] = 'NENHUM'
GO

ALTER TABLE VENDAS_RENEGOCIACAO
ADD [tabela_price] [bit] NULL,
	[juros_price] [decimal](18, 8) NULL,
	[total_parcelas_price] [int] NULL,
	[indexadorejuros] [bit] NULL,
	[indexador_juros]  [varchar](20) NULL
GO

UPDATE VENDAS_RENEGOCIACAO
SET
[tabela_price] = 0,
[juros_price] = 0.00,
[total_parcelas_price] = 0,
[indexadorejuros] = 0,
[indexador_juros] = 'NENHUM'
GO

/***24/01/2018***/
/***Fazer em todas as tabelas de parcelas usar arquivo atualizacao2.sql***/
ALTER TABLE PARCELAS_RENEGOCIACAO
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_RENEGOCIACAO
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

/***27/02/2018***/
/***Corre��o da tabela vendas_renegocia��o, n�o esta gravando o numero do cliente***/
UPDATE t
SET t.CLIENTE = o.CLIENTE
FROM
    vendas_renegociacao AS t
INNER JOIN VENDAS AS o ON t.PRODUTO = o.produto AND 
t.GRUPO = o.grupo AND 
t.UNIDADE = o.unidade AND 
t.PARTE = o.parte AND
t.cliente = 0

/***19/10/2018***/
/***Campo DDA - Cadastro de D�bito Autom�tico***/
ALTER TABLE CONTATO
ADD dda bit NOT NULL Default 0
go

/***01/01/2019***/
UPDATE Parametros
SET valor = 'GITANO - SFin Financiamentos - v.2019'
WHERE nome = 'SISTEMA'

UPDATE Parametros
SET valor = 'v.2019'
WHERE nome = 'SISTEMA_VERSAO'

/***05/02/2019***/
INSERT INTO Parametros VALUES
( 'FLUXO DE PARCELAS',
'NAO',
'PARCELAS',
'TODO O SISTEMA',
'DEFINE PERMISS�O PARA ALTERA��O DE DATA E VALOR DE PARCELA DE FORMA MANUAL, N�O, N�O PERMITE A ALTERA��O, SIM, PERMITE A ALTERA��O.')

/***29/04/2019***/
INSERT INTO Parametros VALUES
( '�LTIMA CORRE��O',
'01/01/1900',
'VENDAS',
'TODO O SISTEMA',
'ARMAZENA A ULTIMA DATA DE CORRE��O MONET�RIA EFETUADA NO SISTEMA.')
