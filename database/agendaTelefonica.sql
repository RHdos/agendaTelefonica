USE [master]
GO
/****** Object:  Database [agendaTelefonica]    Script Date: 07/02/2020 23:51:49 ******/
CREATE DATABASE [agendaTelefonica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'agendaTelefonica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\agendaTelefonica.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'agendaTelefonica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\agendaTelefonica_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [agendaTelefonica] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [agendaTelefonica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [agendaTelefonica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [agendaTelefonica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [agendaTelefonica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [agendaTelefonica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [agendaTelefonica] SET ARITHABORT OFF 
GO
ALTER DATABASE [agendaTelefonica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [agendaTelefonica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [agendaTelefonica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [agendaTelefonica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [agendaTelefonica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [agendaTelefonica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [agendaTelefonica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [agendaTelefonica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [agendaTelefonica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [agendaTelefonica] SET  ENABLE_BROKER 
GO
ALTER DATABASE [agendaTelefonica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [agendaTelefonica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [agendaTelefonica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [agendaTelefonica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [agendaTelefonica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [agendaTelefonica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [agendaTelefonica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [agendaTelefonica] SET RECOVERY FULL 
GO
ALTER DATABASE [agendaTelefonica] SET  MULTI_USER 
GO
ALTER DATABASE [agendaTelefonica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [agendaTelefonica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [agendaTelefonica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [agendaTelefonica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [agendaTelefonica] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'agendaTelefonica', N'ON'
GO
ALTER DATABASE [agendaTelefonica] SET QUERY_STORE = OFF
GO
USE [agendaTelefonica]
GO
/****** Object:  Table [dbo].[contato]    Script Date: 07/02/2020 23:51:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contato](
	[contatoId] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](255) NOT NULL,
	[telefone1] [varchar](50) NOT NULL,
	[telefone2] [varchar](50) NULL,
	[email] [varchar](255) NULL,
	[cep] [varchar](255) NULL,
	[rua] [varchar](255) NULL,
	[bairro] [varchar](255) NULL,
	[cidade] [varchar](255) NULL,
	[estado] [varchar](2) NULL,
	[numero] [varchar](50) NULL,
	[complemento] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[contatoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [agendaTelefonica] SET  READ_WRITE 
GO
