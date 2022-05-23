USE [master]
GO
/****** Object:  Database [QLThuVien]    Script Date: 2022/05/23 AM 11:25:55 ******/
CREATE DATABASE [QLThuVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLThuVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLThuVien.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLThuVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLThuVien_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLThuVien] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLThuVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLThuVien] SET RECOVERY FULL 
GO
ALTER DATABASE [QLThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [QLThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLThuVien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLThuVien] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLThuVien', N'ON'
GO
USE [QLThuVien]
GO
/****** Object:  Table [dbo].[books]    Script Date: 2022/05/23 AM 11:25:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[books](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nameBook] [nvarchar](255) NULL,
	[image] [varchar](50) NULL,
	[kind] [nvarchar](50) NULL,
	[author] [nvarchar](100) NULL,
	[price] [numeric](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[customers]    Script Date: 2022/05/23 AM 11:25:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[customers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fullName] [nvarchar](100) NULL,
	[gender] [bit] NULL,
	[birthday] [smalldatetime] NULL,
	[email] [varchar](200) NULL,
	[phone] [varchar](13) NULL,
	[address] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[debt_sheet]    Script Date: 2022/05/23 AM 11:25:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[debt_sheet](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idCus] [int] NULL,
	[collectionDate] [smalldatetime] NULL,
	[debtMoney] [numeric](18, 2) NULL,
	[status] [nvarchar](25) NULL,
	[userId] [int] NULL,
	[createdDate] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[order_book]    Script Date: 2022/05/23 AM 11:25:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_book](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBook] [int] NULL,
	[quantity] [int] NULL,
	[price] [numeric](18, 2) NULL,
	[supplier] [nvarchar](255) NULL,
	[userId] [int] NULL,
	[dateOrder] [smalldatetime] NULL,
	[dateModify] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[receipt]    Script Date: 2022/05/23 AM 11:25:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receipt](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idCus] [int] NULL,
	[status] [nvarchar](20) NULL,
	[payCus] [numeric](18, 2) NULL,
	[userId] [int] NULL,
	[dateReceipt] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[receipt_detail]    Script Date: 2022/05/23 AM 11:25:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receipt_detail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idReceipt] [int] NULL,
	[idBook] [int] NULL,
	[price] [numeric](18, 2) NULL,
	[quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[regulartion]    Script Date: 2022/05/23 AM 11:25:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[regulartion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NULL,
	[status] [bit] NULL,
	[type] [nvarchar](100) NULL,
	[value] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users]    Script Date: 2022/05/23 AM 11:25:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NULL,
	[password] [varchar](50) NULL,
	[fullName] [nvarchar](100) NULL,
	[type] [nvarchar](30) NULL,
	[status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[warehouse]    Script Date: 2022/05/23 AM 11:25:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[warehouse](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBook] [int] NULL,
	[totalQuantity] [int] NULL,
	[sold] [int] NULL,
	[idOrder] [int] NULL,
	[dateImport] [smalldatetime] NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[debt_sheet]  WITH CHECK ADD  CONSTRAINT [fk_debt_sheet_customers] FOREIGN KEY([idCus])
REFERENCES [dbo].[customers] ([id])
GO
ALTER TABLE [dbo].[debt_sheet] CHECK CONSTRAINT [fk_debt_sheet_customers]
GO
ALTER TABLE [dbo].[order_book]  WITH CHECK ADD  CONSTRAINT [fk_order_book_book] FOREIGN KEY([idBook])
REFERENCES [dbo].[books] ([id])
GO
ALTER TABLE [dbo].[order_book] CHECK CONSTRAINT [fk_order_book_book]
GO
ALTER TABLE [dbo].[order_book]  WITH CHECK ADD  CONSTRAINT [fk_order_book_books] FOREIGN KEY([idBook])
REFERENCES [dbo].[books] ([id])
GO
ALTER TABLE [dbo].[order_book] CHECK CONSTRAINT [fk_order_book_books]
GO
ALTER TABLE [dbo].[order_book]  WITH CHECK ADD  CONSTRAINT [fk_order_book_users] FOREIGN KEY([userId])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[order_book] CHECK CONSTRAINT [fk_order_book_users]
GO
ALTER TABLE [dbo].[receipt]  WITH CHECK ADD  CONSTRAINT [fk_receipt_customers] FOREIGN KEY([idCus])
REFERENCES [dbo].[customers] ([id])
GO
ALTER TABLE [dbo].[receipt] CHECK CONSTRAINT [fk_receipt_customers]
GO
ALTER TABLE [dbo].[receipt]  WITH CHECK ADD  CONSTRAINT [fk_receipt_users] FOREIGN KEY([userId])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[receipt] CHECK CONSTRAINT [fk_receipt_users]
GO
ALTER TABLE [dbo].[receipt_detail]  WITH CHECK ADD  CONSTRAINT [fk_receipt_detail_books] FOREIGN KEY([idBook])
REFERENCES [dbo].[books] ([id])
GO
ALTER TABLE [dbo].[receipt_detail] CHECK CONSTRAINT [fk_receipt_detail_books]
GO
ALTER TABLE [dbo].[receipt_detail]  WITH CHECK ADD  CONSTRAINT [fk_receipt_detail_receipt] FOREIGN KEY([idReceipt])
REFERENCES [dbo].[receipt] ([id])
GO
ALTER TABLE [dbo].[receipt_detail] CHECK CONSTRAINT [fk_receipt_detail_receipt]
GO
ALTER TABLE [dbo].[warehouse]  WITH CHECK ADD  CONSTRAINT [fk_warehouse_books] FOREIGN KEY([idBook])
REFERENCES [dbo].[books] ([id])
GO
ALTER TABLE [dbo].[warehouse] CHECK CONSTRAINT [fk_warehouse_books]
GO
ALTER TABLE [dbo].[warehouse]  WITH CHECK ADD  CONSTRAINT [fk_warehouse_order] FOREIGN KEY([idOrder])
REFERENCES [dbo].[order_book] ([id])
GO
ALTER TABLE [dbo].[warehouse] CHECK CONSTRAINT [fk_warehouse_order]
GO
USE [master]
GO
ALTER DATABASE [QLThuVien] SET  READ_WRITE 
GO
