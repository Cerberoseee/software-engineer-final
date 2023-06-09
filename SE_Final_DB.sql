USE [master]
GO
/****** Object:  Database [SE_Final]    Script Date: 25/04/2023 5:32:13 CH ******/
CREATE DATABASE [SE_Final]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SE_Final', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SE_Final.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SE_Final_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SE_Final_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SE_Final] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SE_Final].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SE_Final] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SE_Final] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SE_Final] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SE_Final] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SE_Final] SET ARITHABORT OFF 
GO
ALTER DATABASE [SE_Final] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SE_Final] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SE_Final] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SE_Final] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SE_Final] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SE_Final] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SE_Final] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SE_Final] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SE_Final] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SE_Final] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SE_Final] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SE_Final] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SE_Final] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SE_Final] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SE_Final] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SE_Final] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SE_Final] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SE_Final] SET RECOVERY FULL 
GO
ALTER DATABASE [SE_Final] SET  MULTI_USER 
GO
ALTER DATABASE [SE_Final] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SE_Final] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SE_Final] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SE_Final] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SE_Final] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SE_Final] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SE_Final', N'ON'
GO
ALTER DATABASE [SE_Final] SET QUERY_STORE = OFF
GO
USE [SE_Final]
GO
/****** Object:  Table [dbo].[DeliveryNote]    Script Date: 25/04/2023 5:32:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeliveryNote](
	[NoteID] [varchar](32) NOT NULL,
	[OrderID] [varchar](32) NOT NULL,
	[ResellerID] [varchar](32) NOT NULL,
	[DeliveryDate] [datetime] NULL,
	[DeliveryAddress] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailOrder]    Script Date: 25/04/2023 5:32:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailOrder](
	[OrderID] [varchar](32) NOT NULL,
	[GoodID] [varchar](32) NOT NULL,
	[Quantity] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 25/04/2023 5:32:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [varchar](32) NOT NULL,
	[EmployeeName] [varchar](255) NULL,
	[EmployeeRole] [varchar](32) NULL,
	[Username] [varchar](32) NULL,
	[Password] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Good]    Script Date: 25/04/2023 5:32:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Good](
	[GoodID] [varchar](32) NOT NULL,
	[GoodName] [varchar](255) NULL,
	[Quantity] [int] NULL,
	[Price] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GoodImportedReceipt]    Script Date: 25/04/2023 5:32:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoodImportedReceipt](
	[ReceiptID] [varchar](32) NOT NULL,
	[ImportDate] [datetime] NULL,
	[EmployeeID] [varchar](32) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GoodReceipt]    Script Date: 25/04/2023 5:32:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoodReceipt](
	[GoodID] [varchar](32) NOT NULL,
	[ReceiptID] [varchar](32) NOT NULL,
	[Quantity] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemOrder]    Script Date: 25/04/2023 5:32:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemOrder](
	[OrderID] [varchar](32) NOT NULL,
	[ResellerID] [varchar](32) NOT NULL,
	[OrderStatus] [varchar](32) NULL,
	[PaymentMethod] [varchar](32) NULL,
	[CreatedDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reseller]    Script Date: 25/04/2023 5:32:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reseller](
	[ResellerID] [varchar](32) NOT NULL,
	[ResellerName] [varchar](255) NULL,
	[ResellerAddress] [varchar](255) NULL,
	[Username] [varchar](32) NULL,
	[Password] [varchar](255) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [SE_Final] SET  READ_WRITE 
GO
