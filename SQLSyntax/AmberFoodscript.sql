USE [master]
GO
/****** Object:  Database [FoodOption]    Script Date: 2021/8/12 上午 12:45:06 ******/
CREATE DATABASE [FoodOption]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FoodOption', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.FOOD\MSSQL\DATA\FoodOption.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FoodOption_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.FOOD\MSSQL\DATA\FoodOption_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FoodOption].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FoodOption] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FoodOption] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FoodOption] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FoodOption] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FoodOption] SET ARITHABORT OFF 
GO
ALTER DATABASE [FoodOption] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FoodOption] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FoodOption] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FoodOption] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FoodOption] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FoodOption] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FoodOption] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FoodOption] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FoodOption] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FoodOption] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FoodOption] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FoodOption] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FoodOption] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FoodOption] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FoodOption] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FoodOption] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FoodOption] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FoodOption] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FoodOption] SET  MULTI_USER 
GO
ALTER DATABASE [FoodOption] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FoodOption] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FoodOption] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FoodOption] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FoodOption] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FoodOption] SET QUERY_STORE = OFF
GO
USE [FoodOption]
GO
/****** Object:  Schema [HumanReSource]    Script Date: 2021/8/12 上午 12:45:06 ******/
CREATE SCHEMA [HumanReSource]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2021/8/12 上午 12:45:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustNo] [char](7) NOT NULL,
	[ServerNo] [char](7) NULL,
	[ServerName] [varchar](20) NOT NULL,
	[CustGender] [char](1) NULL,
	[OrderDay] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 2021/8/12 上午 12:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmpNo] [char](7) NOT NULL,
	[EmpName] [varchar](20) NOT NULL,
	[Title] [varchar](30) NULL,
	[Gender] [char](1) NULL,
	[BDay] [datetime] NULL,
	[StartDay] [datetime] NULL,
	[AddressNo] [varchar](10) NULL,
	[HomeAddr] [varchar](60) NULL,
	[ExtNo] [varchar](4) NULL,
	[Reporter] [char](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodMenu]    Script Date: 2021/8/12 上午 12:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodMenu](
	[FoodName] [varchar](50) NULL,
	[FoodPrice] [money] NOT NULL,
	[FoodDetail] [varchar](1000) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodStoreLogin]    Script Date: 2021/8/12 上午 12:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodStoreLogin](
	[StoreName] [varchar](10) NULL,
	[Manager] [varchar](30) NULL,
	[StoreAddress] [varchar](50) NULL,
	[StorePhoneNum] [varchar](10) NULL,
	[PhoneNum] [varchar](10) NULL,
	[ManagerID] [varchar](10) NULL,
	[ManagerPwd] [varchar](max) NULL,
	[ErrorTime] [int] NULL,
	[isLocked] [int] NULL,
	[Email] [char](100) NULL,
	[vertifyNum] [int] NULL,
	[isVertify] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogInStatus]    Script Date: 2021/8/12 上午 12:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogInStatus](
	[ManagerID] [varchar](10) NULL,
	[ManagerPwd] [varchar](50) NULL,
	[AccStatus] [int] NULL,
	[StatusMemo] [varchar](50) NULL,
	[CurrentTime] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderBuy]    Script Date: 2021/8/12 上午 12:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderBuy](
	[CustNoBuy] [char](7) NULL,
	[ServerNoBuy] [char](7) NULL,
	[ServerNameBuy] [varchar](20) NOT NULL,
	[CustGenderBuy] [char](1) NULL,
	[OrderDayBuy] [datetime] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LogInStatus] ADD  DEFAULT (getdate()) FOR [CurrentTime]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD FOREIGN KEY([ServerNo])
REFERENCES [dbo].[Employee] ([EmpNo])
GO
ALTER TABLE [dbo].[OrderBuy]  WITH CHECK ADD FOREIGN KEY([CustNoBuy])
REFERENCES [dbo].[Customer] ([CustNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
/****** Object:  StoredProcedure [dbo].[SP_FoodLogIn]    Script Date: 2021/8/12 上午 12:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--exec SP_FoodLogIn 'DDD','EEE'

CREATE PROCEDURE [dbo].[SP_FoodLogIn]
	-- Add the parameters for the stored procedure here
	@ID varchar(10),
	@Pwd varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	
	SET NOCOUNT ON;


	Declare @ErrTime as int
	


	IF (select Count(*) from FoodStoreLogin where ManagerID=@ID and isLocked='1')>0
		BEGIN
			insert into LogInStatus
								(ManagerID,ManagerPwd,AccStatus,StatusMemo,CurrentTime)
									VALUES(@ID,@Pwd,'4','帳號登入鎖定，請找工程師解鎖',GetDate())
			update LogInStatus set AccStatus='4',StatusMemo='帳號登入鎖定，請找工程師解鎖' where ManagerID=@ID
		END

	
    -- Insert statements for procedure here
	Else IF (select Count(*) from FoodStoreLogin where ManagerID=@ID and ManagerPwd=@Pwd)=0 
		BEGIN
			
			--撈不到這組帳密，先檢查是否有這組帳號，如果有的話
			IF (select Count(*) from FoodStoreLogin where ManagerID=@ID)>0
				BEGIN
					 
					 --把登入的紀錄寫入LogInStatus的Table

					insert into LogInStatus
					(ManagerID,ManagerPwd,AccStatus,StatusMemo)
					VALUES(@ID,@Pwd,'2','登入失敗:密碼錯誤')

					--更新錯誤次數
					set @ErrTime=(select Count(*) from LogInStatus where ManagerID=@ID)
					update FoodStoreLogin set ErrorTime=@ErrTime where ManagerID=@ID

					IF @ErrTime=5
					 BEGIN
						update FoodStoreLogin set isLocked='1' where ManagerID=@ID 
					 END


					
				END
			
			ELSE
				BEGIN
					insert into LogInStatus
					(ManagerID,ManagerPwd,AccStatus,StatusMemo,CurrentTime)
					VALUES(@ID,@Pwd,'3','查無帳號，需註冊',GetDate())
				END

		END
	ELSE
	BEGIN
		IF(select Count(*) from FoodStoreLogin where ManagerID=@ID and ManagerPwd=@Pwd and isVertify=1)=0
				BEGIN
					insert into LogInStatus
					(ManagerID,ManagerPwd,AccStatus,StatusMemo,CurrentTime)
					VALUES(@ID,@Pwd,'5','帳號未驗證!請去驗證',GetDate())
				END
		ELSE

				BEGIN
					insert into LogInStatus
					(ManagerID,ManagerPwd,AccStatus,StatusMemo,CurrentTime)
						VALUES(@ID,@Pwd,'1','登入成功',GetDate())
					delete LogInStatus where ManagerID=@ID and AccStatus='2'
					
			
					update FoodStoreLogin set isLocked='0',ErrorTime='0' where ManagerID=@ID and ManagerPwd=@Pwd
				END

	
		print @ErrTime
	END
END
GO
USE [master]
GO
ALTER DATABASE [FoodOption] SET  READ_WRITE 
GO
