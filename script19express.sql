USE [master]
GO
/****** Object:  Database [cdShopManagement]    Script Date: 1/27/2025 6:13:07 AM ******/
CREATE DATABASE [cdShopManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cdShopManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\cdShopManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cdShopManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\cdShopManagement.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cdShopManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cdShopManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cdShopManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cdShopManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cdShopManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cdShopManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cdShopManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [cdShopManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cdShopManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cdShopManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cdShopManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cdShopManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cdShopManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cdShopManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cdShopManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cdShopManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cdShopManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [cdShopManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cdShopManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cdShopManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cdShopManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cdShopManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cdShopManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cdShopManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cdShopManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [cdShopManagement] SET  MULTI_USER 
GO
ALTER DATABASE [cdShopManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cdShopManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cdShopManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cdShopManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cdShopManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cdShopManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [cdShopManagement] SET QUERY_STORE = ON
GO
ALTER DATABASE [cdShopManagement] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [cdShopManagement]
GO
/****** Object:  Table [dbo].[billInfo]    Script Date: 1/27/2025 6:13:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[billInfo](
	[BillID] [int] IDENTITY(1000,1) NOT NULL,
	[UserID] [nvarchar](10) NOT NULL,
	[BillingDate] [date] NOT NULL,
	[TotalBill] [float] NOT NULL,
	[CustomerID] [int] NOT NULL,
 CONSTRAINT [PK_billInfo] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cdInfo]    Script Date: 1/27/2025 6:13:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cdInfo](
	[CdID] [int] IDENTITY(1,1) NOT NULL,
	[CdName] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[Catagory] [varchar](20) NOT NULL,
 CONSTRAINT [PK_cdInfo] PRIMARY KEY CLUSTERED 
(
	[CdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customerInfo]    Script Date: 1/27/2025 6:13:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customerInfo](
	[CustomerID] [int] IDENTITY(5000,1) NOT NULL,
	[CustomerName] [varchar](50) NOT NULL,
	[CustomerPhone] [varchar](50) NOT NULL,
 CONSTRAINT [PK_customerInfo] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userInfo]    Script Date: 1/27/2025 6:13:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userInfo](
	[UserID] [nvarchar](10) NOT NULL,
	[UserPass] [nvarchar](20) NOT NULL,
	[UserName] [varchar](50) NULL,
	[UserPhone] [nvarchar](12) NOT NULL,
	[UserSalary] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[Role] [varchar](10) NOT NULL,
 CONSTRAINT [PK_userInfo] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[billInfo] ON 

INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1001, N'U-001', CAST(N'2025-01-17' AS Date), 768, 5000)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1005, N'U-001', CAST(N'2025-01-17' AS Date), 34.98, 5003)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1006, N'U-002', CAST(N'2025-01-17' AS Date), 79.98, 5004)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1007, N'U-001', CAST(N'2025-01-17' AS Date), 79.98, 5005)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1008, N'U-001', CAST(N'2025-01-17' AS Date), 149.96, 5006)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1009, N'U-002', CAST(N'2025-01-17' AS Date), 79.98, 5007)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1010, N'U-002', CAST(N'2025-01-17' AS Date), 99.97, 5008)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1011, N'U-002', CAST(N'2025-01-17' AS Date), 94.96999, 5009)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1012, N'U-001', CAST(N'2025-01-17' AS Date), 114.96, 5010)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1013, N'U-001', CAST(N'2025-01-17' AS Date), 74.98, 5011)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1014, N'U-001', CAST(N'2025-01-19' AS Date), 79.98, 5012)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1015, N'U-001', CAST(N'2025-01-21' AS Date), 59.99, 5013)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1016, N'U-001', CAST(N'2025-01-21' AS Date), 19.99, 5014)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1017, N'U-001', CAST(N'2025-01-23' AS Date), 59.99, 5015)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1018, N'U-002', CAST(N'2025-01-23' AS Date), 19.99, 5016)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1019, N'U-001', CAST(N'2025-01-23' AS Date), 19.99, 5017)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1020, N'U-001', CAST(N'2025-01-23' AS Date), 19.99, 5018)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1021, N'U-001', CAST(N'2025-01-23' AS Date), 59.99, 5019)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1022, N'U-001', CAST(N'2025-01-23' AS Date), 79.98, 5020)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1023, N'U-001', CAST(N'2025-01-23' AS Date), 19.99, 5021)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1024, N'U-001', CAST(N'2025-01-23' AS Date), 59.99, 5022)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1025, N'U-001', CAST(N'2025-01-23' AS Date), 79.98, 5023)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1026, N'U-001', CAST(N'2025-01-23' AS Date), 59.99, 5024)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1027, N'U-001', CAST(N'2025-01-23' AS Date), 19.99, 5025)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1028, N'U-001', CAST(N'2025-01-23' AS Date), 59.99, 5026)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1029, N'U-001', CAST(N'2025-01-23' AS Date), 79.98, 5028)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1030, N'U-001', CAST(N'2025-01-23' AS Date), 79.98, 5029)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1031, N'U-001', CAST(N'2025-01-23' AS Date), 0, 5030)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1032, N'U-001', CAST(N'2025-01-23' AS Date), 59.99, 5031)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1033, N'U-001', CAST(N'2025-01-23' AS Date), 59.99, 5032)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1034, N'U-001', CAST(N'2025-01-23' AS Date), 59.99, 5033)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1035, N'U-001', CAST(N'2025-01-23' AS Date), 79.98, 5034)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1036, N'U-001', CAST(N'2025-01-23' AS Date), 59.99, 5035)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1037, N'U-001', CAST(N'2025-01-23' AS Date), 59.99, 5036)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1038, N'U-001', CAST(N'2025-01-23' AS Date), 79.98, 5037)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1039, N'U-001', CAST(N'2025-01-23' AS Date), 59.99, 5038)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1040, N'U-001', CAST(N'2025-01-23' AS Date), 59.99, 5039)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1041, N'U-001', CAST(N'2025-01-23' AS Date), 59.99, 5040)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1042, N'U-001', CAST(N'2025-01-23' AS Date), 59.99, 5041)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1043, N'U-001', CAST(N'2025-01-23' AS Date), 79.98, 5042)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1044, N'U-001', CAST(N'2025-01-23' AS Date), 79.98, 5043)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1045, N'U-001', CAST(N'2025-01-23' AS Date), 79.98, 5044)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1046, N'U-001', CAST(N'2025-01-24' AS Date), 79.98, 5046)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1047, N'U-001', CAST(N'2025-01-24' AS Date), 59.99, 5047)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1048, N'U-001', CAST(N'2025-01-24' AS Date), 59.99, 5048)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1049, N'U-001', CAST(N'2025-01-24' AS Date), 99.97, 5049)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1050, N'U-001', CAST(N'2025-01-24' AS Date), 79.98, 5050)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1051, N'U-001', CAST(N'2025-01-24' AS Date), 239.94, 5051)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1052, N'U-001', CAST(N'2025-01-24' AS Date), 179.95, 5052)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1053, N'U-005', CAST(N'2025-01-24' AS Date), 59.99, 5053)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1054, N'U-001', CAST(N'2025-01-25' AS Date), 14.99, 5054)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1055, N'U-005', CAST(N'2025-01-26' AS Date), 217.73, 5055)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1056, N'U-001', CAST(N'2025-01-27' AS Date), 59.97, 5056)
INSERT [dbo].[billInfo] ([BillID], [UserID], [BillingDate], [TotalBill], [CustomerID]) VALUES (1057, N'U-005', CAST(N'2025-01-27' AS Date), 14.99, 5057)
SET IDENTITY_INSERT [dbo].[billInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[cdInfo] ON 

INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (1, N'The Last of Us Part II', 71, 59.99, N'Game')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (2, N'Avengers: Endgame', 80, 19.99, N'Movie')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (3, N'Nirvana - Nevermind', 98, 14.99, N'Music')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (4, N'Prince of Persia', 100, 99.5, N'Game')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (5, N'Road Rash', 99, 97.73, N'Game')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (6, N'DX-Ball', 100, 50.6, N'Game')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (7, N'Need For Speed', 99, 120, N'Game')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (8, N'Contra', 100, 67.77, N'Game')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (9, N'Mario Bros', 100, 87.96, N'Game')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (10, N'Protisruti', 100, 20.5, N'Music')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (11, N'Ferari Mon', 100, 21.5, N'Movie')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (12, N'Shukh', 100, 15.33, N'Music')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (13, N'Obhimani', 100, 12.77, N'Music')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (14, N'Ullash', 100, 25.66, N'Music')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (15, N'Bondhu', 100, 39, N'Music')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (16, N'Aguner Poroshmoni', 100, 100, N'Movie')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (17, N'Jibon Theke Newa', 100, 63.77, N'Movie')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (18, N'Titas Ekti Nadir Nam', 100, 102.5, N'Movie')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (19, N'Surjo Dighal Bari', 100, 95, N'Movie')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (20, N'Sereng Bou', 100, 97.05, N'Movie')
INSERT [dbo].[cdInfo] ([CdID], [CdName], [Quantity], [Price], [Catagory]) VALUES (21, N'Dhaka Vice CIty', 11, 20, N'Game')
SET IDENTITY_INSERT [dbo].[cdInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[customerInfo] ON 

INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5000, N'Jisan', N'01973846374')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5002, N'dry', N'01723456890')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5003, N'cold', N'098765443221')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5004, N'fhdbf', N'6387463554')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5005, N'jura', N'03483754365')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5006, N'rfgdg', N'9857874857')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5007, N'dnfhsf', N'4756734574')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5008, N'huston', N'74576345767')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5009, N'fhsdgfgds', N'745736564')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5010, N'dfbfddfj', N'4356745374')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5011, N'hdgfhsgdf', N'dvdfvfd')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5012, N'abir', N'12345678910')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5013, N'abcd', N'123456789')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5014, N'ssssss', N'000000000000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5015, N'Trump', N'999090902')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5016, N'm1', N'092984')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5017, N'Amanda', N'9999887456')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5018, N'amona', N'09120445')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5019, N'gg', N'qwe')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5020, N'pinku', N'999021234')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5021, N'chinku', N'990123455')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5022, N'jinku', N'908774563')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5023, N'tinku', N'02359456')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5024, N'devid', N'0999812345')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5025, N'alu', N'099912345')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5026, N'Saka', N'0183124324')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5027, N'jaka', N'00000000000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5028, N'levin', N'000001200000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5029, N'Nickel', N'088112324')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5030, N'Charlie', N'00009812')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5031, N'wasa', N'009988234')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5032, N'test1', N'00000000000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5033, N'test2', N'000000000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5034, N'test3', N'0000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5035, N'test4', N'000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5036, N'test5', N'000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5037, N'test6', N'000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5038, N'test6', N'000000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5039, N'test7', N'00000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5040, N'test7', N'0000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5041, N'test8', N'00000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5042, N'tomma', N'000000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5043, N'Dr Younus', N'000000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5044, N'abir', N'0000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5045, N'devil', N'0000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5046, N'tappu', N'9800012')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5047, N'dewa', N'09034')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5048, N'nuha', N'0988764')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5049, N'Jibon', N'0999845')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5050, N'Moho', N'099090')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5051, N'Maya', N'000999')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5052, N'mrFixer', N'01731849660')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5053, N'Hiper', N'000123')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5054, N'Farishta', N'000000000000')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5055, N'Putin', N'00909090909')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5056, N'Madhuri', N'090909090909')
INSERT [dbo].[customerInfo] ([CustomerID], [CustomerName], [CustomerPhone]) VALUES (5057, N'Shilpa', N'000999999090')
SET IDENTITY_INSERT [dbo].[customerInfo] OFF
GO
INSERT [dbo].[userInfo] ([UserID], [UserPass], [UserName], [UserPhone], [UserSalary], [StartDate], [Role]) VALUES (N'U-001', N'12345', N'Mahir', N'01784839478', 20000, CAST(N'2015-02-06' AS Date), N'Admin')
INSERT [dbo].[userInfo] ([UserID], [UserPass], [UserName], [UserPhone], [UserSalary], [StartDate], [Role]) VALUES (N'U-002', N'123', N'tonmoy', N'01991667516', 200, CAST(N'2015-02-06' AS Date), N'Employee')
INSERT [dbo].[userInfo] ([UserID], [UserPass], [UserName], [UserPhone], [UserSalary], [StartDate], [Role]) VALUES (N'U-004', N'13243', N'mahim', N'01937264823', 453, CAST(N'2025-11-01' AS Date), N'Employee')
INSERT [dbo].[userInfo] ([UserID], [UserPass], [UserName], [UserPhone], [UserSalary], [StartDate], [Role]) VALUES (N'U-005', N'66666', N'Alexa', N'01832428709', 500, CAST(N'2025-01-24' AS Date), N'Employee')
INSERT [dbo].[userInfo] ([UserID], [UserPass], [UserName], [UserPhone], [UserSalary], [StartDate], [Role]) VALUES (N'U-006', N'11111', N'Mahir3', N'01731849669', 20000, CAST(N'2025-01-27' AS Date), N'Admin')
GO
ALTER TABLE [dbo].[billInfo]  WITH CHECK ADD  CONSTRAINT [FK_billInfo_customerInfo] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[customerInfo] ([CustomerID])
GO
ALTER TABLE [dbo].[billInfo] CHECK CONSTRAINT [FK_billInfo_customerInfo]
GO
ALTER TABLE [dbo].[billInfo]  WITH CHECK ADD  CONSTRAINT [FK_billInfo_userInfo] FOREIGN KEY([UserID])
REFERENCES [dbo].[userInfo] ([UserID])
GO
ALTER TABLE [dbo].[billInfo] CHECK CONSTRAINT [FK_billInfo_userInfo]
GO
USE [master]
GO
ALTER DATABASE [cdShopManagement] SET  READ_WRITE 
GO
