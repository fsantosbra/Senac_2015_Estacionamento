USE [master]
GO
/****** Object:  Database [senacpos2015]    Script Date: 27/06/2015 14:52:54 ******/
CREATE DATABASE [senacpos2015]
GO
ALTER DATABASE [senacpos2015] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [senacpos2015].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [senacpos2015] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [senacpos2015] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [senacpos2015] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [senacpos2015] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [senacpos2015] SET ARITHABORT OFF 
GO
ALTER DATABASE [senacpos2015] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [senacpos2015] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [senacpos2015] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [senacpos2015] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [senacpos2015] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [senacpos2015] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [senacpos2015] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [senacpos2015] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [senacpos2015] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [senacpos2015] SET  DISABLE_BROKER 
GO
ALTER DATABASE [senacpos2015] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [senacpos2015] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [senacpos2015] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [senacpos2015] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [senacpos2015] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [senacpos2015] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [senacpos2015] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [senacpos2015] SET RECOVERY FULL 
GO
ALTER DATABASE [senacpos2015] SET  MULTI_USER 
GO
ALTER DATABASE [senacpos2015] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [senacpos2015] SET DB_CHAINING OFF 
GO
USE [senacpos2015]
GO
/****** Object:  Table [dbo].[Acesso]    Script Date: 27/06/2015 14:52:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Acesso](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Funcionario] [varchar](150) NULL,
	[Login] [varchar](50) NULL,
	[Senha] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Endereco]    Script Date: 27/06/2015 14:52:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Endereco](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Logradouro] [varchar](150) NOT NULL,
	[Numero] [varchar](20) NOT NULL,
	[Bairro] [varchar](150) NOT NULL,
	[Cidade] [varchar](150) NOT NULL,
	[Estado] [varchar](2) NOT NULL,
	[CEP] [varchar](9) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LogEstacionamento]    Script Date: 27/06/2015 14:52:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LogEstacionamento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AcessoId] [int] NOT NULL,
	[Descricao] [varchar](100) NOT NULL,
	[DataAcao] [datetime] NOT NULL CONSTRAINT [DF_DataAgora]  DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mensalista]    Script Date: 27/06/2015 14:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mensalista](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NOT NULL,
	[EnderecoId] [int] NOT NULL,
	[TelefoneId] [int] NOT NULL,
	[Ativo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MensalistaPrecoTipo]    Script Date: 27/06/2015 14:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MensalistaPrecoTipo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MensalistaId] [int] NOT NULL,
	[PrecoMensalistaId] [int] NOT NULL,
	[Placa] [varchar](8) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Modelo]    Script Date: 27/06/2015 14:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Modelo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Modelo] [varchar](150) NOT NULL,
	[TipoVeiculoId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Parametros]    Script Date: 27/06/2015 14:52:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Parametros](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Valor] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Parceiros]    Script Date: 27/06/2015 14:52:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Parceiros](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeParceiro] [varchar](150) NOT NULL,
	[Desconto] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PrecosAvulsos]    Script Date: 27/06/2015 14:52:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrecosAvulsos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TipoVeiculoId] [int] NOT NULL,
	[PrimeiraHora] [decimal](18, 0) NOT NULL,
	[DemaisHoras] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[PrecosMensalistas]    Script Date: 27/06/2015 14:52:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrecosMensalistas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TipoVeiculoId] [int] NOT NULL,
	[Valor] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[Telefone]    Script Date: 27/06/2015 14:52:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Telefone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TipoTelefoneId] [int] NOT NULL,
	[Telefone] [varchar](14) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoTelefone]    Script Date: 27/06/2015 14:52:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoTelefone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoVeiculo]    Script Date: 27/06/2015 14:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoVeiculo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsoVaga]    Script Date: 27/06/2015 14:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UsoVaga](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ModeloId] [int] NOT NULL,
	[Placa] [varchar](8) NOT NULL,
	[DataEntrada] [datetime] NOT NULL,
	[DataSaida] [datetime] NULL,
	[EhMensalista] [bit] NULL,
	[MensalistaId] [int] NOT NULL,
	[CorVeiculo] [int] NOT NULL,
	[ParceiroId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vagas]    Script Date: 27/06/2015 14:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vagas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TipoVeiculoId] [int] NOT NULL,
	[QtdeVagasTotal] [int] NULL,
	[QtdeMensalista] [int] NULL,
	[QtdeVagasTotalCorrente] [int] NULL,
	[QtdeMensalistaCorrente] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
ALTER TABLE [dbo].[Mensalista]  WITH CHECK ADD  CONSTRAINT [FK_MENSALISTA_ENDERECO] FOREIGN KEY([EnderecoId])
REFERENCES [dbo].[Endereco] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Mensalista] CHECK CONSTRAINT [FK_MENSALISTA_ENDERECO]
GO
ALTER TABLE [dbo].[Mensalista]  WITH CHECK ADD  CONSTRAINT [FK_MENSALISTA_TELEFONE] FOREIGN KEY([TelefoneId])
REFERENCES [dbo].[Telefone] ([Id])
GO
ALTER TABLE [dbo].[Mensalista] CHECK CONSTRAINT [FK_MENSALISTA_TELEFONE]
GO
ALTER TABLE [dbo].[MensalistaPrecoTipo]  WITH CHECK ADD  CONSTRAINT [FK_MENSALISTA_PRECO] FOREIGN KEY([MensalistaId])
REFERENCES [dbo].[Mensalista] ([Id])
GO
ALTER TABLE [dbo].[MensalistaPrecoTipo] CHECK CONSTRAINT [FK_MENSALISTA_PRECO]
GO
ALTER TABLE [dbo].[MensalistaPrecoTipo]  WITH CHECK ADD  CONSTRAINT [FK_PRECO_MENSALISTA] FOREIGN KEY([PrecoMensalistaId])
REFERENCES [dbo].[PrecosMensalistas] ([Id])
GO
ALTER TABLE [dbo].[MensalistaPrecoTipo] CHECK CONSTRAINT [FK_PRECO_MENSALISTA]
GO
ALTER TABLE [dbo].[PrecosAvulsos]  WITH CHECK ADD  CONSTRAINT [FK_PRECO_TIPOVEICULO] FOREIGN KEY([TipoVeiculoId])
REFERENCES [dbo].[TipoVeiculo] ([Id])
GO
ALTER TABLE [dbo].[PrecosAvulsos] CHECK CONSTRAINT [FK_PRECO_TIPOVEICULO]
GO
ALTER TABLE [dbo].[PrecosMensalistas]  WITH CHECK ADD  CONSTRAINT [FK_PRECOMENSAL_TIPOVEICULO] FOREIGN KEY([TipoVeiculoId])
REFERENCES [dbo].[TipoVeiculo] ([Id])
GO
ALTER TABLE [dbo].[PrecosMensalistas] CHECK CONSTRAINT [FK_PRECOMENSAL_TIPOVEICULO]
GO
ALTER TABLE [dbo].[Telefone]  WITH CHECK ADD  CONSTRAINT [FK_TELEFONE_TIPO] FOREIGN KEY([TipoTelefoneId])
REFERENCES [dbo].[TipoTelefone] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Telefone] CHECK CONSTRAINT [FK_TELEFONE_TIPO]
GO
ALTER TABLE [dbo].[UsoVaga]  WITH CHECK ADD  CONSTRAINT [FK_PARCEIRO_VAGA] FOREIGN KEY([ParceiroId])
REFERENCES [dbo].[Parceiros] ([Id])
GO
ALTER TABLE [dbo].[UsoVaga] CHECK CONSTRAINT [FK_PARCEIRO_VAGA]
GO
ALTER TABLE [dbo].[UsoVaga]  WITH CHECK ADD  CONSTRAINT [FK_USOVAGA_MENSALISTA] FOREIGN KEY([MensalistaId])
REFERENCES [dbo].[Mensalista] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UsoVaga] CHECK CONSTRAINT [FK_USOVAGA_MENSALISTA]
GO
ALTER TABLE [dbo].[UsoVaga]  WITH CHECK ADD  CONSTRAINT [FK_USOVAGA_MODELO] FOREIGN KEY([ModeloId])
REFERENCES [dbo].[Modelo] ([Id])
GO
ALTER TABLE [dbo].[UsoVaga] CHECK CONSTRAINT [FK_USOVAGA_MODELO]
GO
ALTER TABLE [dbo].[Vagas]  WITH CHECK ADD  CONSTRAINT [FK_TIPOVEICULO_VAGAS] FOREIGN KEY([TipoVeiculoId])
REFERENCES [dbo].[TipoVeiculo] ([Id])
GO
ALTER TABLE [dbo].[Vagas] CHECK CONSTRAINT [FK_TIPOVEICULO_VAGAS]
GO
/****** Object:  StoredProcedure [dbo].[STP_GravarLogEstacionamento]    Script Date: 27/06/2015 14:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[STP_GravarLogEstacionamento] (@AcessoID int, @DescricaoAcao varchar(100))
as
begin
	declare @Retorno	bit,
			@MsgRetorno varchar(255)

	set @Retorno	= 1
	set @MsgRetorno = 'OK'

	begin try
		begin tran

		insert into senacpos2015.dbo.LogEstacionamento (AcessoId, Descricao)
		values(@AcessoID, @DescricaoAcao)

		commit tran
	end try
	begin catch
		rollback tran

		set @Retorno = 0
		set @MsgRetorno = error_message()
	end catch

	select Retorno = @Retorno, MsgRetorno = @MsgRetorno
end


GO
USE [master]
GO
ALTER DATABASE [senacpos2015] SET  READ_WRITE 
GO
