USE [Zoologico]
GO
/****** Object:  Table [dbo].[Alimentos]    Script Date: 22/05/2023 21:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alimentos](
	[Codalimento] [int] IDENTITY(1,1) NOT NULL,
	[Alimento] [nvarchar](15) NOT NULL,
	[Descricao] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codalimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Animais]    Script Date: 22/05/2023 21:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animais](
	[Codanimal] [int] IDENTITY(1,1) NOT NULL,
	[Animal] [nvarchar](50) NOT NULL,
	[paisOrigem] [nvarchar](30) NOT NULL,
	[Localizacao] [nvarchar](30) NOT NULL,
	[codalimento] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Codanimal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
