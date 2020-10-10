USE [Gitano]
GO

DROP TABLE [dbo].[taxas_mensais]
GO

/****** Object:  Table [dbo].[taxas_mensais]    Script Date: 04/01/2016 13:23:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING OFF
GO

CREATE TABLE [dbo].[taxas_mensais](
	[MES] [char](2) NULL,
	[ANO] [char](4) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


