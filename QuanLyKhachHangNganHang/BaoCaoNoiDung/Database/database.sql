USE [master]
GO
/****** Object:  Database [QuanLyKhachHangNganHang]    Script Date: 6/4/2024 10:40:32 AM ******/
CREATE DATABASE [QuanLyKhachHangNganHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKhachHangNganHang_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyKhachHangNganHang.mdf' , SIZE = 11264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyKhachHangNganHang_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyKhachHangNganHang.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKhachHangNganHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLyKhachHangNganHang]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 6/4/2024 10:40:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](100) NULL,
	[DisplayName] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
	[Position] [int] NULL,
 CONSTRAINT [PK__Employee__7AD04FF1890F30CA] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblAccount]    Script Date: 6/4/2024 10:40:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccount](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[AccountOwnerID] [int] NULL,
	[AccountTypeID] [int] NULL,
	[AccountStatus] [nvarchar](50) NULL,
	[AccountOpenDate] [datetime] NULL,
	[Balance] [int] NULL,
	[AccountNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK__tblAccou__349DA58600767931] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblAccountType]    Script Date: 6/4/2024 10:40:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccountType](
	[AccountTypeID] [int] IDENTITY(1,1) NOT NULL,
	[AccountTypeName] [nvarchar](50) NULL,
	[AccountTypeDescription] [nvarchar](200) NULL,
	[InterestRate] [nvarchar](100) NULL,
 CONSTRAINT [PK__tblAccou__8F95854F5A3261C2] PRIMARY KEY CLUSTERED 
(
	[AccountTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 6/4/2024 10:40:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](100) NULL,
	[CCCD] [nvarchar](12) NULL,
	[Address] [nvarchar](200) NULL,
	[CustomerPhone] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[Gender] [nvarchar](50) NULL,
	[NextOfKin] [int] NULL,
	[DateOfBirth] [date] NULL,
	[OccupationID] [int] NULL,
	[AverageIncome] [decimal](10, 2) NULL,
	[MaritalStatusID] [int] NULL,
	[Debt] [int] NULL,
	[Loans] [int] NULL,
	[CreditTerm] [nvarchar](200) NULL,
 CONSTRAINT [PK__tblCusto__A4AE64B8F8B37E98] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMaritalStatus]    Script Date: 6/4/2024 10:40:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMaritalStatus](
	[MaritalStatusID] [int] IDENTITY(1,1) NOT NULL,
	[MaritalStatusName] [nvarchar](50) NULL,
 CONSTRAINT [PK__tblMarit__C8B1BA523BD8E50F] PRIMARY KEY CLUSTERED 
(
	[MaritalStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNextOfKin]    Script Date: 6/4/2024 10:40:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNextOfKin](
	[NextOfKinID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[NextOfKinName] [nvarchar](100) NULL,
	[NextOfKinRelationship] [nvarchar](50) NULL,
	[NextOfKinPhone] [nvarchar](50) NULL,
	[NextOfKinAddress] [nvarchar](200) NULL,
 CONSTRAINT [PK__tblNextO__95588E6F9453F643] PRIMARY KEY CLUSTERED 
(
	[NextOfKinID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOccupation]    Script Date: 6/4/2024 10:40:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOccupation](
	[OccupationID] [int] IDENTITY(1,1) NOT NULL,
	[OccupationName] [nvarchar](100) NULL,
	[OccupationAbbreviation] [nvarchar](50) NULL,
 CONSTRAINT [PK__tblOccup__8917118D74167945] PRIMARY KEY CLUSTERED 
(
	[OccupationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblService]    Script Date: 6/4/2024 10:40:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblService](
	[ServiceID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [nvarchar](200) NULL,
	[ServicePrice] [int] NULL,
	[ServiceDescription] [nvarchar](200) NULL,
	[ServiceStatus] [nvarchar](200) NULL,
 CONSTRAINT [PK__tblServi__C51BB0EA9AF287FE] PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTransactionHistory]    Script Date: 6/4/2024 10:40:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTransactionHistory](
	[TransactionID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NULL,
	[ServiceID] [int] NULL,
	[TransactionDate] [datetime] NULL,
	[TransactionAmount] [int] NULL,
	[TransactionDescription] [nvarchar](200) NULL,
 CONSTRAINT [PK__tblTrans__55433A4B518E3A4C] PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblAccount]  WITH CHECK ADD  CONSTRAINT [FK_tblAccount_tblAccountType] FOREIGN KEY([AccountTypeID])
REFERENCES [dbo].[tblAccountType] ([AccountTypeID])
GO
ALTER TABLE [dbo].[tblAccount] CHECK CONSTRAINT [FK_tblAccount_tblAccountType]
GO
ALTER TABLE [dbo].[tblAccount]  WITH CHECK ADD  CONSTRAINT [FK_tblAccount_tblCustomer] FOREIGN KEY([AccountOwnerID])
REFERENCES [dbo].[tblCustomer] ([CustomerID])
GO
ALTER TABLE [dbo].[tblAccount] CHECK CONSTRAINT [FK_tblAccount_tblCustomer]
GO
ALTER TABLE [dbo].[tblCustomer]  WITH CHECK ADD  CONSTRAINT [FK_tblCustomer_tblMaritalStatus] FOREIGN KEY([MaritalStatusID])
REFERENCES [dbo].[tblMaritalStatus] ([MaritalStatusID])
GO
ALTER TABLE [dbo].[tblCustomer] CHECK CONSTRAINT [FK_tblCustomer_tblMaritalStatus]
GO
ALTER TABLE [dbo].[tblCustomer]  WITH CHECK ADD  CONSTRAINT [FK_tblCustomer_tblOccupation] FOREIGN KEY([OccupationID])
REFERENCES [dbo].[tblOccupation] ([OccupationID])
GO
ALTER TABLE [dbo].[tblCustomer] CHECK CONSTRAINT [FK_tblCustomer_tblOccupation]
GO
ALTER TABLE [dbo].[tblNextOfKin]  WITH CHECK ADD  CONSTRAINT [FK_tblNextOfKin_tblCustomer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tblCustomer] ([CustomerID])
GO
ALTER TABLE [dbo].[tblNextOfKin] CHECK CONSTRAINT [FK_tblNextOfKin_tblCustomer]
GO
ALTER TABLE [dbo].[tblTransactionHistory]  WITH CHECK ADD  CONSTRAINT [FK_tblTransactionHistory_tblAccount] FOREIGN KEY([AccountID])
REFERENCES [dbo].[tblAccount] ([AccountID])
GO
ALTER TABLE [dbo].[tblTransactionHistory] CHECK CONSTRAINT [FK_tblTransactionHistory_tblAccount]
GO
ALTER TABLE [dbo].[tblTransactionHistory]  WITH CHECK ADD  CONSTRAINT [FK_tblTransactionHistory_tblService] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[tblService] ([ServiceID])
GO
ALTER TABLE [dbo].[tblTransactionHistory] CHECK CONSTRAINT [FK_tblTransactionHistory_tblService]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate]    Script Date: 6/4/2024 10:40:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetListBillByDate]
@checkIn date, @checkout date
AS
BEGIN
	SELECT t.name, b.totalPrice, DateCheckIn, DateCheckOut, discount
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkout AND b.status = 1
	AND t.id = b.idTable
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 6/4/2024 10:40:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBill]
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	DECLARE @isExistsBillInfo INT;
	DECLARE @existingCount INT;

	SELECT @isExistsBillInfo = COUNT(*), @existingCount = b.[count]
	FROM dbo.BillInfo AS b
	WHERE idBill = @idBill AND idFood = @idFood;

	IF (@isExistsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @existingCount + @count;
		IF (@newCount > 0)
			UPDATE dbo.BillInfo SET [count] = @newCount WHERE idBill = @idBill AND idFood = @idFood;
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood;
	END
	ELSE
	BEGIN
		INSERT dbo.BillInfo (idBill, idFood, [count])
		VALUES (@idBill, @idFood, @count);
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 6/4/2024 10:40:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_InsertBillInfo]
@idBill INT, @idFood INT, @count INT
AS
BEGIN
    DECLARE @isExistsBillInfo INT
    DECLARE @foodCount INT = 1
    
    SELECT @isExistsBillInfo = id, @foodCount = b.count 
    FROM dbo.BillInfo AS b
    WHERE idBill = @idBill AND idFood = @idFood
    
    IF (@isExistsBillInfo > 0)
    BEGIN
        DECLARE @newCount INT = @foodCount + @count
        IF (@newCount > 0)
            UPDATE dbo.BillInfo SET count = @newCount WHERE idBill = @idBill AND idFood = @idFood
        ELSE
            DELETE FROM dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
    END
    ELSE
    BEGIN
        INSERT INTO dbo.BillInfo(idBill, idFood, count)
        VALUES(@idBill, @idFood, @count)
    END
END



UPDATE dbo.Bill SET status = 1 WHERE id = 1
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 6/4/2024 10:40:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_Login]
    @employeeName NVARCHAR(100),
    @passWord NVARCHAR(100)
AS
BEGIN
    SELECT * FROM dbo.Employees WHERE EmployeeName = @employeeName AND Password = @passWord;
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyKhachHangNganHang] SET  READ_WRITE 
GO
