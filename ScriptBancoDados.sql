USE [master]
GO
/****** Object:  Database [SaipherControleVoo]    Script Date: 29/03/2018 08:31:47 ******/
CREATE DATABASE [SaipherControleVoo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SaipherControleVoo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SaipherControleVoo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SaipherControleVoo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SaipherControleVoo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SaipherControleVoo] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SaipherControleVoo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SaipherControleVoo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET ARITHABORT OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SaipherControleVoo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SaipherControleVoo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SaipherControleVoo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SaipherControleVoo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SaipherControleVoo] SET  MULTI_USER 
GO
ALTER DATABASE [SaipherControleVoo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SaipherControleVoo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SaipherControleVoo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SaipherControleVoo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SaipherControleVoo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SaipherControleVoo] SET QUERY_STORE = OFF
GO
USE [SaipherControleVoo]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [SaipherControleVoo]
GO
/****** Object:  Table [dbo].[TB_SCV_AERONAVE]    Script Date: 29/03/2018 08:31:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_SCV_AERONAVE](
	[ID_SCV_AERONAVE] [int] IDENTITY(1,1) NOT NULL,
	[FK_SCV_FABRICANTE] [int] NOT NULL,
	[NM_NOME_AERONAVE] [varchar](50) NOT NULL,
	[NM_MODELO] [varchar](20) NOT NULL,
	[NR_PASSAGEIROS] [int] NULL,
	[DT_CADASTRO] [datetime] NOT NULL,
	[DT_ATUALIZACAO] [datetime] NOT NULL,
 CONSTRAINT [PK_TB_SCV_AERONAVE] PRIMARY KEY CLUSTERED 
(
	[ID_SCV_AERONAVE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_SCV_FROTA]    Script Date: 29/03/2018 08:31:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_SCV_FROTA](
	[ID_SCV_FROTA] [int] IDENTITY(1,1) NOT NULL,
	[FK_SCV_COMPANHIA] [int] NOT NULL,
	[FK_SCV_AERONAVE] [int] NOT NULL,
	[NM_MATRICULA] [varchar](20) NOT NULL,
	[NR_SERIE] [bigint] NOT NULL,
	[DT_FABRICACAO] [date] NOT NULL,
	[DT_COMPRA_TRANSFERENCIA] [date] NOT NULL,
	[BT_ATIVO] [bit] NOT NULL,
	[DT_CADASTRO] [datetime] NOT NULL,
	[DT_ATUALIZACAO] [datetime] NOT NULL,
 CONSTRAINT [PK_TB_SCV_FROTA] PRIMARY KEY CLUSTERED 
(
	[ID_SCV_FROTA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_SCV_FROTA_AERONAVE]    Script Date: 29/03/2018 08:31:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_SCV_FROTA_AERONAVE]
AS
SELECT 
	ID_SCV_FROTA, 
	ID_SCV_AERONAVE, 
	FK_SCV_COMPANHIA,
	NM_MATRICULA, 
	NR_SERIE, 
	DT_FABRICACAO, 
	DT_COMPRA_TRANSFERENCIA,
	NM_NOME_AERONAVE,
	NM_MODELO
  FROM [SaipherControleVoo].[dbo].[TB_SCV_FROTA] AS FRT
  INNER JOIN [SaipherControleVoo].[dbo].TB_SCV_AERONAVE AS ARN
	ON FRT.FK_SCV_AERONAVE = ARN.ID_SCV_AERONAVE
WHERE
	BT_ATIVO = 1
GO
/****** Object:  Table [dbo].[TB_SCV_COMPANHIA]    Script Date: 29/03/2018 08:31:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_SCV_COMPANHIA](
	[ID_SCV_COMPANHIA] [int] IDENTITY(1,1) NOT NULL,
	[NM_COMPANHIA] [varchar](150) NOT NULL,
	[NM_IATA] [varchar](2) NOT NULL,
	[NM_ICAO] [varchar](3) NOT NULL,
	[NM_INDICATIVO_CHAMADA] [varchar](20) NOT NULL,
	[BT_ATIVO] [bit] NOT NULL,
	[DT_CADASTRO] [datetime] NOT NULL,
	[DT_ATUALIZACAO] [datetime] NOT NULL,
 CONSTRAINT [PK_TB_SCV_COMPANHIA] PRIMARY KEY CLUSTERED 
(
	[ID_SCV_COMPANHIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_SCV_CENTRO_OPERACAO]    Script Date: 29/03/2018 08:31:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_SCV_CENTRO_OPERACAO](
	[ID_SCV_CENTRO_OPERACAO] [int] IDENTITY(1,1) NOT NULL,
	[NM_CENTRO_OPERACAO] [varchar](150) NOT NULL,
	[NM_IATA] [varchar](3) NOT NULL,
	[NM_ICAO] [varchar](4) NOT NULL,
	[NM_LOCALIZACAO] [varchar](100) NOT NULL,
	[BT_ATIVO] [bit] NOT NULL,
	[DT_CADASTRO] [datetime] NOT NULL,
	[DT_ATUALIZACAO] [datetime] NOT NULL,
 CONSTRAINT [PK_TB_SCV_CENTRO_OPERACAO] PRIMARY KEY CLUSTERED 
(
	[ID_SCV_CENTRO_OPERACAO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_SCV_PLANO_VOO]    Script Date: 29/03/2018 08:31:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_SCV_PLANO_VOO](
	[ID_SCV_PLANO_VOO] [int] IDENTITY(1,1) NOT NULL,
	[FK_SCV_COMPANHIA] [int] NOT NULL,
	[FK_SCV_FROTA] [int] NOT NULL,
	[DT_VOO] [datetime] NOT NULL,
	[FK_SCV_CENTRO_OPERACAO_ORIGEM] [int] NOT NULL,
	[FK_SCV_CENTRO_OPERACAO_DESTINO] [int] NOT NULL,
	[BT_ATIVO] [bit] NOT NULL,
	[DT_ATUALIZACAO] [datetime] NOT NULL,
	[DT_CADASTRO] [datetime] NOT NULL,
 CONSTRAINT [PK_TB_SCV_PLANO_VOO] PRIMARY KEY CLUSTERED 
(
	[ID_SCV_PLANO_VOO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_SCV_PLANO_VOO_INFORMACAO]    Script Date: 29/03/2018 08:31:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_SCV_PLANO_VOO_INFORMACAO]
AS
SELECT  
	PVO.ID_SCV_PLANO_VOO,
	COM.ID_SCV_COMPANHIA,
	VRT.ID_SCV_FROTA,
	COO.ID_SCV_CENTRO_OPERACAO AS ID_SCV_CENTRO_OPERACAO_ORIGEM,
	COD.ID_SCV_CENTRO_OPERACAO AS ID_SCV_CENTRO_OPERACAO_DESTINO,
	COM.NM_ICAO + REPLICATE('0', 4-LEN(PVO.ID_SCV_PLANO_VOO)) + CAST(PVO.ID_SCV_PLANO_VOO AS VARCHAR) AS NUMERO_VOO,
	PVO.DT_VOO,
	PVO.DT_CADASTRO,
	PVO.DT_ATUALIZACAO,
	COM.NM_COMPANHIA,
	COM.NM_ICAO AS COMPANHIA_ICAO,
	VRT.NM_NOME_AERONAVE,
	VRT.NM_MATRICULA,
	VRT.NR_SERIE,
	COO.NM_ICAO AS CENTRO_OPERACAO_ORIGEM,
	COD.NM_ICAO AS CENTRO_OPERACAO_DESTINO
  FROM [SaipherControleVoo].[dbo].[TB_SCV_PLANO_VOO] PVO
  INNER JOIN [SaipherControleVoo].[dbo].TB_SCV_COMPANHIA COM
	ON PVO.FK_SCV_COMPANHIA = COM.ID_SCV_COMPANHIA
  INNER JOIN [SaipherControleVoo].[dbo].VW_SCV_FROTA_AERONAVE VRT
	ON PVO.FK_SCV_FROTA = VRT.ID_SCV_FROTA
  INNER JOIN [SaipherControleVoo].[dbo].TB_SCV_CENTRO_OPERACAO COO
	ON PVO.FK_SCV_CENTRO_OPERACAO_ORIGEM = COO.ID_SCV_CENTRO_OPERACAO
  INNER JOIN [SaipherControleVoo].[dbo].TB_SCV_CENTRO_OPERACAO COD
	ON PVO.FK_SCV_CENTRO_OPERACAO_ORIGEM = COD.ID_SCV_CENTRO_OPERACAO
WHERE PVO.BT_ATIVO = 1
GO
/****** Object:  Table [dbo].[TB_SCV_FABRICANTE]    Script Date: 29/03/2018 08:31:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_SCV_FABRICANTE](
	[ID_SCV_FABRICANTE] [int] IDENTITY(1,1) NOT NULL,
	[NM_RAZAO_SOCIAL] [varchar](100) NOT NULL,
	[NM_FABRICANTE] [varchar](20) NOT NULL,
	[NM_PAIS] [varchar](20) NOT NULL,
	[DT_CADASTRO] [datetime] NOT NULL,
	[DT_ALTERACAO] [datetime] NOT NULL,
 CONSTRAINT [PK_TB_SCV_FABRICANTE] PRIMARY KEY CLUSTERED 
(
	[ID_SCV_FABRICANTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TB_SCV_AERONAVE] ON 

INSERT [dbo].[TB_SCV_AERONAVE] ([ID_SCV_AERONAVE], [FK_SCV_FABRICANTE], [NM_NOME_AERONAVE], [NM_MODELO], [NR_PASSAGEIROS], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (1, 1, N'Embraer 190', N'ERJ 190-100 IGW', 106, CAST(N'2018-03-26T22:50:09.370' AS DateTime), CAST(N'2018-03-26T22:50:09.370' AS DateTime))
INSERT [dbo].[TB_SCV_AERONAVE] ([ID_SCV_AERONAVE], [FK_SCV_FABRICANTE], [NM_NOME_AERONAVE], [NM_MODELO], [NR_PASSAGEIROS], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (2, 1, N'Embraer 190', N'ERJ 190-100 LR', 130, CAST(N'2018-03-26T22:50:29.310' AS DateTime), CAST(N'2018-03-26T22:50:29.310' AS DateTime))
INSERT [dbo].[TB_SCV_AERONAVE] ([ID_SCV_AERONAVE], [FK_SCV_FABRICANTE], [NM_NOME_AERONAVE], [NM_MODELO], [NR_PASSAGEIROS], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (3, 1, N'Embraer 195', N'ERJ 190-200 IGW', 130, CAST(N'2018-03-26T22:50:46.430' AS DateTime), CAST(N'2018-03-26T22:50:46.430' AS DateTime))
INSERT [dbo].[TB_SCV_AERONAVE] ([ID_SCV_AERONAVE], [FK_SCV_FABRICANTE], [NM_NOME_AERONAVE], [NM_MODELO], [NR_PASSAGEIROS], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (4, 3, N'Airbus A320', N'A320-100', 126, CAST(N'2018-03-26T22:54:13.073' AS DateTime), CAST(N'2018-03-26T22:54:13.073' AS DateTime))
INSERT [dbo].[TB_SCV_AERONAVE] ([ID_SCV_AERONAVE], [FK_SCV_FABRICANTE], [NM_NOME_AERONAVE], [NM_MODELO], [NR_PASSAGEIROS], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (5, 3, N'Airbus A300', N'A300B2', 300, CAST(N'2018-03-26T22:54:56.153' AS DateTime), CAST(N'2018-03-26T22:54:56.153' AS DateTime))
INSERT [dbo].[TB_SCV_AERONAVE] ([ID_SCV_AERONAVE], [FK_SCV_FABRICANTE], [NM_NOME_AERONAVE], [NM_MODELO], [NR_PASSAGEIROS], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (6, 2, N'Boeing 767', N'767-200ER', 400, CAST(N'2018-03-26T22:55:56.530' AS DateTime), CAST(N'2018-03-26T22:55:56.530' AS DateTime))
INSERT [dbo].[TB_SCV_AERONAVE] ([ID_SCV_AERONAVE], [FK_SCV_FABRICANTE], [NM_NOME_AERONAVE], [NM_MODELO], [NR_PASSAGEIROS], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (7, 2, N'Boeing 777', N'777-300ER', 500, CAST(N'2018-03-26T22:57:16.480' AS DateTime), CAST(N'2018-03-26T22:57:16.480' AS DateTime))
SET IDENTITY_INSERT [dbo].[TB_SCV_AERONAVE] OFF
SET IDENTITY_INSERT [dbo].[TB_SCV_CENTRO_OPERACAO] ON 

INSERT [dbo].[TB_SCV_CENTRO_OPERACAO] ([ID_SCV_CENTRO_OPERACAO], [NM_CENTRO_OPERACAO], [NM_IATA], [NM_ICAO], [NM_LOCALIZACAO], [BT_ATIVO], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (1, N'Aeroporto de São Paulo-Congonhas', N'CGH', N'SBSP', N'São Paulo, SP, Brasil', 1, CAST(N'2018-03-26T22:43:21.797' AS DateTime), CAST(N'2018-03-26T22:43:21.797' AS DateTime))
INSERT [dbo].[TB_SCV_CENTRO_OPERACAO] ([ID_SCV_CENTRO_OPERACAO], [NM_CENTRO_OPERACAO], [NM_IATA], [NM_ICAO], [NM_LOCALIZACAO], [BT_ATIVO], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (2, N'Aeroporto Internacional do Rio de Janeiro-Galeão', N'GIG', N'SBGL', N'Rio de Janeiro, RJ, Brasil', 1, CAST(N'2018-03-26T22:44:11.750' AS DateTime), CAST(N'2018-03-26T22:44:11.750' AS DateTime))
INSERT [dbo].[TB_SCV_CENTRO_OPERACAO] ([ID_SCV_CENTRO_OPERACAO], [NM_CENTRO_OPERACAO], [NM_IATA], [NM_ICAO], [NM_LOCALIZACAO], [BT_ATIVO], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (3, N'Aeroporto Internacional de Belo Horizonte-Confins', N'CNF', N'SBCF', N'Confins, Minas Gerais, Brasil', 1, CAST(N'2018-03-26T22:45:07.207' AS DateTime), CAST(N'2018-03-26T22:45:07.207' AS DateTime))
INSERT [dbo].[TB_SCV_CENTRO_OPERACAO] ([ID_SCV_CENTRO_OPERACAO], [NM_CENTRO_OPERACAO], [NM_IATA], [NM_ICAO], [NM_LOCALIZACAO], [BT_ATIVO], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (4, N'Aeroporto Internacional de São Paulo-Guarulhos', N'GRU', N'SBGR', N'Guarulhos, São Paulo', 1, CAST(N'2018-03-26T22:45:43.953' AS DateTime), CAST(N'2018-03-26T22:45:43.953' AS DateTime))
SET IDENTITY_INSERT [dbo].[TB_SCV_CENTRO_OPERACAO] OFF
SET IDENTITY_INSERT [dbo].[TB_SCV_COMPANHIA] ON 

INSERT [dbo].[TB_SCV_COMPANHIA] ([ID_SCV_COMPANHIA], [NM_COMPANHIA], [NM_IATA], [NM_ICAO], [NM_INDICATIVO_CHAMADA], [BT_ATIVO], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (1, N'Gol Linhas Aéreas Inteligentes', N'G3', N'GLO', N'GOL', 1, CAST(N'2018-03-26T22:37:02.410' AS DateTime), CAST(N'2018-03-26T22:37:02.410' AS DateTime))
INSERT [dbo].[TB_SCV_COMPANHIA] ([ID_SCV_COMPANHIA], [NM_COMPANHIA], [NM_IATA], [NM_ICAO], [NM_INDICATIVO_CHAMADA], [BT_ATIVO], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (2, N'LATAM Airlines', N'LA', N'TAM', N'TAM', 1, CAST(N'2018-03-26T22:38:11.670' AS DateTime), CAST(N'2018-03-26T22:38:11.670' AS DateTime))
INSERT [dbo].[TB_SCV_COMPANHIA] ([ID_SCV_COMPANHIA], [NM_COMPANHIA], [NM_IATA], [NM_ICAO], [NM_INDICATIVO_CHAMADA], [BT_ATIVO], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (3, N'Azul Linhas Aéreas Brasileiras', N'AD', N'AZU', N'AZUL', 1, CAST(N'2018-03-26T22:40:45.003' AS DateTime), CAST(N'2018-03-26T22:40:45.003' AS DateTime))
SET IDENTITY_INSERT [dbo].[TB_SCV_COMPANHIA] OFF
SET IDENTITY_INSERT [dbo].[TB_SCV_FABRICANTE] ON 

INSERT [dbo].[TB_SCV_FABRICANTE] ([ID_SCV_FABRICANTE], [NM_RAZAO_SOCIAL], [NM_FABRICANTE], [NM_PAIS], [DT_CADASTRO], [DT_ALTERACAO]) VALUES (1, N'Embraer S.A.', N'Embraer', N'Brasil', CAST(N'2018-03-26T22:29:49.307' AS DateTime), CAST(N'2018-03-26T22:29:49.307' AS DateTime))
INSERT [dbo].[TB_SCV_FABRICANTE] ([ID_SCV_FABRICANTE], [NM_RAZAO_SOCIAL], [NM_FABRICANTE], [NM_PAIS], [DT_CADASTRO], [DT_ALTERACAO]) VALUES (2, N'The Boeing Company', N'Boeing', N'Estados Unidos', CAST(N'2018-03-26T22:31:56.433' AS DateTime), CAST(N'2018-03-26T22:31:56.433' AS DateTime))
INSERT [dbo].[TB_SCV_FABRICANTE] ([ID_SCV_FABRICANTE], [NM_RAZAO_SOCIAL], [NM_FABRICANTE], [NM_PAIS], [DT_CADASTRO], [DT_ALTERACAO]) VALUES (3, N'EADS Airbus', N'Airbus', N'França', CAST(N'2018-03-26T22:35:10.663' AS DateTime), CAST(N'2018-03-26T22:35:10.663' AS DateTime))
SET IDENTITY_INSERT [dbo].[TB_SCV_FABRICANTE] OFF
SET IDENTITY_INSERT [dbo].[TB_SCV_FROTA] ON 

INSERT [dbo].[TB_SCV_FROTA] ([ID_SCV_FROTA], [FK_SCV_COMPANHIA], [FK_SCV_AERONAVE], [NM_MATRICULA], [NR_SERIE], [DT_FABRICACAO], [DT_COMPRA_TRANSFERENCIA], [BT_ATIVO], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (1, 1, 6, N'PR-GEA', 3026, CAST(N'2009-01-15' AS Date), CAST(N'2009-05-01' AS Date), 1, CAST(N'2018-03-26T23:07:01.177' AS DateTime), CAST(N'2018-03-26T23:07:01.177' AS DateTime))
INSERT [dbo].[TB_SCV_FROTA] ([ID_SCV_FROTA], [FK_SCV_COMPANHIA], [FK_SCV_AERONAVE], [NM_MATRICULA], [NR_SERIE], [DT_FABRICACAO], [DT_COMPRA_TRANSFERENCIA], [BT_ATIVO], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (2, 1, 6, N'PR-GEH', 2241, CAST(N'2010-03-08' AS Date), CAST(N'2015-06-16' AS Date), 1, CAST(N'2018-03-26T23:07:01.177' AS DateTime), CAST(N'2018-03-26T23:07:01.177' AS DateTime))
INSERT [dbo].[TB_SCV_FROTA] ([ID_SCV_FROTA], [FK_SCV_COMPANHIA], [FK_SCV_AERONAVE], [NM_MATRICULA], [NR_SERIE], [DT_FABRICACAO], [DT_COMPRA_TRANSFERENCIA], [BT_ATIVO], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (3, 2, 4, N'PR-MAM', 1826, CAST(N'2002-01-01' AS Date), CAST(N'2002-01-01' AS Date), 1, CAST(N'2018-03-26T23:07:01.177' AS DateTime), CAST(N'2018-03-26T23:07:01.177' AS DateTime))
INSERT [dbo].[TB_SCV_FROTA] ([ID_SCV_FROTA], [FK_SCV_COMPANHIA], [FK_SCV_AERONAVE], [NM_MATRICULA], [NR_SERIE], [DT_FABRICACAO], [DT_COMPRA_TRANSFERENCIA], [BT_ATIVO], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (4, 2, 5, N'PT-TME', 4389, CAST(N'2010-01-01' AS Date), CAST(N'2010-01-01' AS Date), 1, CAST(N'2018-03-26T23:07:01.177' AS DateTime), CAST(N'2018-03-26T23:07:01.177' AS DateTime))
INSERT [dbo].[TB_SCV_FROTA] ([ID_SCV_FROTA], [FK_SCV_COMPANHIA], [FK_SCV_AERONAVE], [NM_MATRICULA], [NR_SERIE], [DT_FABRICACAO], [DT_COMPRA_TRANSFERENCIA], [BT_ATIVO], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (5, 3, 1, N'PRAZD', 19000271, CAST(N'2009-05-06' AS Date), CAST(N'2009-06-01' AS Date), 1, CAST(N'2018-03-26T23:07:01.223' AS DateTime), CAST(N'2018-03-26T23:07:01.223' AS DateTime))
INSERT [dbo].[TB_SCV_FROTA] ([ID_SCV_FROTA], [FK_SCV_COMPANHIA], [FK_SCV_AERONAVE], [NM_MATRICULA], [NR_SERIE], [DT_FABRICACAO], [DT_COMPRA_TRANSFERENCIA], [BT_ATIVO], [DT_CADASTRO], [DT_ATUALIZACAO]) VALUES (6, 3, 3, N'PPPJQ', 19000493, CAST(N'2010-02-01' AS Date), CAST(N'2011-12-20' AS Date), 1, CAST(N'2018-03-26T23:07:01.227' AS DateTime), CAST(N'2018-03-26T23:07:01.227' AS DateTime))
SET IDENTITY_INSERT [dbo].[TB_SCV_FROTA] OFF
SET IDENTITY_INSERT [dbo].[TB_SCV_PLANO_VOO] ON 

INSERT [dbo].[TB_SCV_PLANO_VOO] ([ID_SCV_PLANO_VOO], [FK_SCV_COMPANHIA], [FK_SCV_FROTA], [DT_VOO], [FK_SCV_CENTRO_OPERACAO_ORIGEM], [FK_SCV_CENTRO_OPERACAO_DESTINO], [BT_ATIVO], [DT_ATUALIZACAO], [DT_CADASTRO]) VALUES (1, 3, 5, CAST(N'2018-03-29T22:30:00.000' AS DateTime), 1, 3, 1, CAST(N'2018-03-28T22:52:20.223' AS DateTime), CAST(N'2018-03-28T22:29:44.387' AS DateTime))
INSERT [dbo].[TB_SCV_PLANO_VOO] ([ID_SCV_PLANO_VOO], [FK_SCV_COMPANHIA], [FK_SCV_FROTA], [DT_VOO], [FK_SCV_CENTRO_OPERACAO_ORIGEM], [FK_SCV_CENTRO_OPERACAO_DESTINO], [BT_ATIVO], [DT_ATUALIZACAO], [DT_CADASTRO]) VALUES (2, 3, 6, CAST(N'2018-03-31T15:00:00.000' AS DateTime), 4, 2, 1, CAST(N'2018-03-28T23:34:51.073' AS DateTime), CAST(N'2018-03-28T23:34:51.073' AS DateTime))
INSERT [dbo].[TB_SCV_PLANO_VOO] ([ID_SCV_PLANO_VOO], [FK_SCV_COMPANHIA], [FK_SCV_FROTA], [DT_VOO], [FK_SCV_CENTRO_OPERACAO_ORIGEM], [FK_SCV_CENTRO_OPERACAO_DESTINO], [BT_ATIVO], [DT_ATUALIZACAO], [DT_CADASTRO]) VALUES (3, 3, 1, CAST(N'2018-03-29T18:00:00.000' AS DateTime), 1, 2, 1, CAST(N'2018-03-29T07:27:26.113' AS DateTime), CAST(N'2018-03-29T07:27:26.113' AS DateTime))
SET IDENTITY_INSERT [dbo].[TB_SCV_PLANO_VOO] OFF
ALTER TABLE [dbo].[TB_SCV_AERONAVE]  WITH CHECK ADD  CONSTRAINT [FK_TB_SCV_AERONAVE_TB_SCV_FABRICANTE] FOREIGN KEY([FK_SCV_FABRICANTE])
REFERENCES [dbo].[TB_SCV_FABRICANTE] ([ID_SCV_FABRICANTE])
GO
ALTER TABLE [dbo].[TB_SCV_AERONAVE] CHECK CONSTRAINT [FK_TB_SCV_AERONAVE_TB_SCV_FABRICANTE]
GO
ALTER TABLE [dbo].[TB_SCV_FROTA]  WITH CHECK ADD  CONSTRAINT [FK_TB_SCV_FROTA_TB_SCV_AERONAVE] FOREIGN KEY([FK_SCV_AERONAVE])
REFERENCES [dbo].[TB_SCV_AERONAVE] ([ID_SCV_AERONAVE])
GO
ALTER TABLE [dbo].[TB_SCV_FROTA] CHECK CONSTRAINT [FK_TB_SCV_FROTA_TB_SCV_AERONAVE]
GO
ALTER TABLE [dbo].[TB_SCV_FROTA]  WITH CHECK ADD  CONSTRAINT [FK_TB_SCV_FROTA_TB_SCV_COMPANHIA] FOREIGN KEY([FK_SCV_COMPANHIA])
REFERENCES [dbo].[TB_SCV_COMPANHIA] ([ID_SCV_COMPANHIA])
GO
ALTER TABLE [dbo].[TB_SCV_FROTA] CHECK CONSTRAINT [FK_TB_SCV_FROTA_TB_SCV_COMPANHIA]
GO
ALTER TABLE [dbo].[TB_SCV_PLANO_VOO]  WITH CHECK ADD  CONSTRAINT [FK_TB_SCV_PLANO_VOO_TB_SCV_CENTRO_OPERACAO] FOREIGN KEY([FK_SCV_CENTRO_OPERACAO_ORIGEM])
REFERENCES [dbo].[TB_SCV_CENTRO_OPERACAO] ([ID_SCV_CENTRO_OPERACAO])
GO
ALTER TABLE [dbo].[TB_SCV_PLANO_VOO] CHECK CONSTRAINT [FK_TB_SCV_PLANO_VOO_TB_SCV_CENTRO_OPERACAO]
GO
ALTER TABLE [dbo].[TB_SCV_PLANO_VOO]  WITH CHECK ADD  CONSTRAINT [FK_TB_SCV_PLANO_VOO_TB_SCV_CENTRO_OPERACAO1] FOREIGN KEY([FK_SCV_CENTRO_OPERACAO_DESTINO])
REFERENCES [dbo].[TB_SCV_CENTRO_OPERACAO] ([ID_SCV_CENTRO_OPERACAO])
GO
ALTER TABLE [dbo].[TB_SCV_PLANO_VOO] CHECK CONSTRAINT [FK_TB_SCV_PLANO_VOO_TB_SCV_CENTRO_OPERACAO1]
GO
ALTER TABLE [dbo].[TB_SCV_PLANO_VOO]  WITH CHECK ADD  CONSTRAINT [FK_TB_SCV_PLANO_VOO_TB_SCV_COMPANHIA] FOREIGN KEY([FK_SCV_COMPANHIA])
REFERENCES [dbo].[TB_SCV_COMPANHIA] ([ID_SCV_COMPANHIA])
GO
ALTER TABLE [dbo].[TB_SCV_PLANO_VOO] CHECK CONSTRAINT [FK_TB_SCV_PLANO_VOO_TB_SCV_COMPANHIA]
GO
ALTER TABLE [dbo].[TB_SCV_PLANO_VOO]  WITH CHECK ADD  CONSTRAINT [FK_TB_SCV_PLANO_VOO_TB_SCV_FROTA] FOREIGN KEY([FK_SCV_FROTA])
REFERENCES [dbo].[TB_SCV_FROTA] ([ID_SCV_FROTA])
GO
ALTER TABLE [dbo].[TB_SCV_PLANO_VOO] CHECK CONSTRAINT [FK_TB_SCV_PLANO_VOO_TB_SCV_FROTA]
GO
USE [master]
GO
ALTER DATABASE [SaipherControleVoo] SET  READ_WRITE 
GO
