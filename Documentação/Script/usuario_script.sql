USE [Gitano]
GO

/****** Object:  Table [dbo].[Usuario]    Script Date: 06/25/2014 10:12:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Usuario](
	[Login] [varchar](20) NOT NULL,
	[Senha] [varchar](10) NULL,
	[Nome] [varchar](20) NULL,
	[Setor] [varchar](20) NULL,
	[Funcao] [varchar](20) NULL,
	[Fone] [varchar](30) NULL,
	[perfil] [bit] NULL,
	[email] [varchar](50) NULL,
	[alcada] [varchar](20) NULL,
	[ativo] [bit] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY NONCLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


