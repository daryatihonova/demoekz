USE [master]
GO
/****** Object:  Database [Tihonova_demo]    Script Date: 18.04.2025 10:16:23 ******/
CREATE DATABASE [Tihonova_demo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Tihonova_demo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.KITP\MSSQL\DATA\Tihonova_demo.mdf' , SIZE = 9024KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'Tihonova_demo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.KITP\MSSQL\DATA\Tihonova_demo_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Tihonova_demo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tihonova_demo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tihonova_demo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tihonova_demo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tihonova_demo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tihonova_demo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tihonova_demo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tihonova_demo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Tihonova_demo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tihonova_demo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tihonova_demo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tihonova_demo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tihonova_demo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tihonova_demo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tihonova_demo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tihonova_demo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tihonova_demo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Tihonova_demo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tihonova_demo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tihonova_demo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tihonova_demo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tihonova_demo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tihonova_demo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tihonova_demo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tihonova_demo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Tihonova_demo] SET  MULTI_USER 
GO
ALTER DATABASE [Tihonova_demo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tihonova_demo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tihonova_demo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tihonova_demo] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Tihonova_demo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Tihonova_demo] SET QUERY_STORE = OFF
GO
USE [Tihonova_demo]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 18.04.2025 10:16:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Client_ID] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [nvarchar](255) NULL,
	[Last_Name] [nvarchar](255) NULL,
	[Surname] [nvarchar](255) NULL,
	[Sex] [nvarchar](2) NULL,
	[Date_Birthday] [datetime] NULL,
	[Serya] [float] NULL,
	[Number] [float] NULL,
	[City] [nvarchar](255) NULL,
	[Adress] [nvarchar](255) NULL,
	[Home] [nvarchar](255) NULL,
	[Flat] [nvarchar](255) NULL,
	[Bonus_Card] [nvarchar](255) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Client_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contract_Cient_Room]    Script Date: 18.04.2025 10:16:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract_Cient_Room](
	[Contract_Cient_Room_ID] [int] IDENTITY(1,1) NOT NULL,
	[Client_ID] [int] NULL,
	[Hotel_Room_ID] [int] NULL,
	[Date_Contract] [date] NULL,
	[Date_Imp] [date] NULL,
	[Date_Exp] [date] NULL,
	[Sum] [money] NULL,
 CONSTRAINT [PK_Contract_Cient_Room] PRIMARY KEY CLUSTERED 
(
	[Contract_Cient_Room_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hotel_Room]    Script Date: 18.04.2025 10:16:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel_Room](
	[Hotel_Room_ID] [int] IDENTITY(1,1) NOT NULL,
	[Hotel_Room_Description] [nvarchar](255) NULL,
	[Ground] [int] NULL,
	[Price] [money] NULL,
	[Count_Seats] [int] NULL,
	[Name] [nvarchar](255) NULL,
 CONSTRAINT [PK_Hotel_Room] PRIMARY KEY CLUSTERED 
(
	[Hotel_Room_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Contract_Cient_Room]  WITH CHECK ADD  CONSTRAINT [FK_Contract_Cient_Room_Client] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Client] ([Client_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contract_Cient_Room] CHECK CONSTRAINT [FK_Contract_Cient_Room_Client]
GO
ALTER TABLE [dbo].[Contract_Cient_Room]  WITH CHECK ADD  CONSTRAINT [FK_Contract_Cient_Room_Hotel_Room] FOREIGN KEY([Hotel_Room_ID])
REFERENCES [dbo].[Hotel_Room] ([Hotel_Room_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contract_Cient_Room] CHECK CONSTRAINT [FK_Contract_Cient_Room_Hotel_Room]
GO
USE [master]
GO
ALTER DATABASE [Tihonova_demo] SET  READ_WRITE 
GO
