USE [Gitano]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[contato](
	[ID] [int] NOT NULL,
	[apelido] [varchar](20) NOT NULL,
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
		
	[endereco] [varchar](1) NOT NULL,
					
	[enderecores] [varchar](70) NULL,
	[enderecoresnumero] [varchar](30) NULL,	
	[enderecorescomplem] [varchar](30) NULL,	
	[bairrores] [varchar](20) NULL,
	[cidaderes] [varchar](20) NULL,
	[ufres] [varchar](2) NULL,
	[cepres] [varchar](8) NULL,
	[fone1res] [varchar](30) NULL,
	[fone2res] [varchar](30) NULL,
	[fone3res] [varchar](30) NULL,
		
	[enderecocom] [varchar](70) NULL,
	[enderecocomnumero] [varchar](30) NULL,	
	[enderecocomcomplem] [varchar](30) NULL,	
	[bairrocom] [varchar](20) NULL,
	[cidadecom] [varchar](20) NULL,
	[ufcom] [varchar](2) NULL,
	[cepcom] [varchar](8) NULL,

	[fone1com] [varchar](30) NULL,
	[fone2com] [varchar](30) NULL,
	[fone3com] [varchar](30) NULL,
	
	[email1] [varchar](50) NULL,				
	[email2] [varchar](50) NULL,
	[email3] [varchar](50) NULL,
	[email4] [varchar](50) NULL,
	[email5] [varchar](50) NULL,
				
	[gerente] [varchar](10) NULL,
	[contato] [varchar](20) NULL,

	[dtnascimento] [datetime] NULL,
	[dtingresso] [datetime] NULL,
	
	[ncontrato] [varchar](10) NULL,
	[dtcontrato] [datetime] NULL,
	
	[ativo] [bit] NOT NULL,
	[acessointernet] [bit] NOT NULL,
	
	[empregador] [varchar](50) NULL,
	[cargo] [varchar](50) NULL,		
	[atividade] [varchar](50) NULL,

	[obs1] [varchar](80) NULL,
	[obs2] [varchar](80) NULL,
	[obs3] [varchar](80) NULL,
	[obs4] [varchar](80) NULL,
	[obs5] [varchar](80) NULL,
	
	[conjugenome] [varchar](50) NULL,
	[conjugesexo] [varchar](1) NULL,

	[conjugecnpj] [varchar](14) NULL,
	[conjugerg] [varchar](14) NULL,			
	[conjugerguf] [varchar](2) NULL,
	[conjugergemissor] [varchar](20) NULL,	
	[conjugergemissao] [datetime] NULL,		
	[dtnascimentoconjuge] [datetime] NULL,	
	[fone1con] [varchar](30) NULL,
	[fone2con] [varchar](30) NULL,
	[fone3con] [varchar](30) NULL,	
	
	[conjugeemail1] [varchar](50) NULL,				
	[conjugeemail2] [varchar](50) NULL,	
	
	[instrcob1] [varchar](2) NULL,
	[instrcob2] [varchar](2) NULL,
	[diasprotesto] [varchar](2) NULL,

	[conta1] [varchar](18) NULL,
	[conta2] [varchar](18) NULL,
	[conta3] [varchar](18) NULL,
	[conta4] [varchar](18) NULL,
	[conta5] [varchar](18) NULL,
	
 CONSTRAINT [PK_contato] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO




