/****** Object:  Table [dbo].[DIM_CLIENTE]    Script Date: 24/06/2021 02:05:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DIM_CLIENTE](
	[SK_CLiENTE] [int] IDENTITY(1,1) NOT NULL,
	[Obra] [nvarchar](10) NULL,
	[Bloco] [nvarchar](10) NULL,
	[Unidade] [nvarchar](10) NULL,
	[Ativo] [bit] NULL,
	[PercentualPago] [decimal](7, 2) NULL,
	[Nome] [nvarchar](40) NULL,
	[DocumentoCliente] [nvarchar](20) NULL,
 CONSTRAINT [SK_DIMCLiENTE] PRIMARY KEY CLUSTERED 
(
	[SK_CLiENTE] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


