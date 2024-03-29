USE [master]
GO
/****** Object:  Database [CoffeeShop]    Script Date: 10/3/2019 9:21:31 PM ******/
CREATE DATABASE [CoffeeShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CoffeeShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\CoffeeShop.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CoffeeShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\CoffeeShop_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CoffeeShop] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CoffeeShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CoffeeShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CoffeeShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CoffeeShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CoffeeShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CoffeeShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CoffeeShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CoffeeShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CoffeeShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CoffeeShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CoffeeShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CoffeeShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CoffeeShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CoffeeShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CoffeeShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CoffeeShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CoffeeShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CoffeeShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CoffeeShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CoffeeShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CoffeeShop] SET  MULTI_USER 
GO
ALTER DATABASE [CoffeeShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CoffeeShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CoffeeShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CoffeeShop] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [CoffeeShop]
GO
/****** Object:  Table [dbo].[Customer_Table]    Script Date: 10/3/2019 9:21:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer_Table](
	[Customer_Id] [int] IDENTITY(1,1) NOT NULL,
	[Customer_Name] [varchar](30) NOT NULL,
	[Contact_No] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[Customer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Item_Table]    Script Date: 10/3/2019 9:21:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Item_Table](
	[Item_Id] [int] IDENTITY(1,1) NOT NULL,
	[Item_Name] [varchar](30) NOT NULL,
	[Item_Price] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Item_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Items]    Script Date: 10/3/2019 9:21:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[Item_Id] [int] IDENTITY(1,1) NOT NULL,
	[Item_Name] [varchar](30) NOT NULL,
	[Price] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Item_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order_Table]    Script Date: 10/3/2019 9:21:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Order_Table](
	[Order_Id] [int] IDENTITY(1,1) NOT NULL,
	[Customer_Id] [int] NULL,
	[Item_Name] [varchar](10) NULL,
	[Quantity] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customer_Table] ON 

INSERT [dbo].[Customer_Table] ([Customer_Id], [Customer_Name], [Contact_No]) VALUES (1, N'SHAFIQ', N'1830422618')
INSERT [dbo].[Customer_Table] ([Customer_Id], [Customer_Name], [Contact_No]) VALUES (2, N'RAFIQ', N'1830422613')
INSERT [dbo].[Customer_Table] ([Customer_Id], [Customer_Name], [Contact_No]) VALUES (3, N'SHUVO', N'1630422613')
SET IDENTITY_INSERT [dbo].[Customer_Table] OFF
SET IDENTITY_INSERT [dbo].[Item_Table] ON 

INSERT [dbo].[Item_Table] ([Item_Id], [Item_Name], [Item_Price]) VALUES (1, N'BLACK', 120)
INSERT [dbo].[Item_Table] ([Item_Id], [Item_Name], [Item_Price]) VALUES (2, N'HOT', 100)
INSERT [dbo].[Item_Table] ([Item_Id], [Item_Name], [Item_Price]) VALUES (3, N'REGULAR', 90)
SET IDENTITY_INSERT [dbo].[Item_Table] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([Item_Id], [Item_Name], [Price]) VALUES (2, N'CAPRICHINO', 150)
INSERT [dbo].[Items] ([Item_Id], [Item_Name], [Price]) VALUES (3, N'REGULAR', 90)
SET IDENTITY_INSERT [dbo].[Items] OFF
SET IDENTITY_INSERT [dbo].[Order_Table] ON 

INSERT [dbo].[Order_Table] ([Order_Id], [Customer_Id], [Item_Name], [Quantity]) VALUES (1, 1, N'BLACK', 3)
INSERT [dbo].[Order_Table] ([Order_Id], [Customer_Id], [Item_Name], [Quantity]) VALUES (2, 2, N'HOT', 5)
INSERT [dbo].[Order_Table] ([Order_Id], [Customer_Id], [Item_Name], [Quantity]) VALUES (3, 3, N'REGULAR', 2)
SET IDENTITY_INSERT [dbo].[Order_Table] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Items__89CFF9E26028060A]    Script Date: 10/3/2019 9:21:31 PM ******/
ALTER TABLE [dbo].[Items] ADD UNIQUE NONCLUSTERED 
(
	[Item_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [CoffeeShop] SET  READ_WRITE 
GO
