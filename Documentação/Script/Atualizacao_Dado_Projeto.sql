/***Atualizações SQL***/

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


/***28/06/2017***/
USE [Gitano_Dado_Projeto]
GO

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

/***25/09/2017***/
ALTER TABLE produto_grupo
ALTER COLUMN [vlr_venda] [decimal](18, 2) NULL

***Tabela de Preços das Unidades
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