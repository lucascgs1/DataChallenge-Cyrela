/****** Object:  Table [dbo].[Carteira]    Script Date: 24/06/2021 02:01:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Carteira](
	[obra_cod] [nvarchar](255) NULL,
	[obra_descricao] [nvarchar](255) NULL,
	[Marca] [nvarchar](255) NULL,
	[Regional] [nvarchar](255) NULL,
	[Carteira] [float] NULL,
	[VGV] [float] NULL,
	[Data] [datetime] NULL,
	[F8] [nvarchar](255) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[ex_cbr]    Script Date: 24/06/2021 02:01:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ex_cbr](
	[Empresa] [nvarchar](255) NULL,
	[Marca] [nvarchar](255) NULL,
	[Empreendimento] [nvarchar](255) NULL,
	[Cliente] [nvarchar](255) NULL,
	[Regional] [nvarchar](255) NULL,
	[Obra] [nvarchar](255) NULL,
	[Bloco] [nvarchar](255) NULL,
	[Unidade] [nvarchar](255) NULL,
	[Dt Venda] [datetime] NULL,
	[Dt Chaves] [datetime] NULL,
	[Carteira (SD Gerencial)] [float] NULL,
	[Saldo Devedor] [float] NULL,
	[Data base] [datetime] NULL,
	[Total Atraso] [money] NULL,
	[Faixa de Atraso] [nvarchar](255) NULL,
	[Dias Atraso] [float] NULL,
	[Valor Pago Atualizado] [money] NULL,
	[Valor Pago] [money] NULL,
	[Status] [nvarchar](255) NULL,
	[Dt Reneg] [nvarchar](255) NULL,
	[Descosn] [nvarchar](255) NULL,
	[Vaga] [nvarchar](255) NULL,
	[VGV] [money] NULL
) ON [PRIMARY]
GO



