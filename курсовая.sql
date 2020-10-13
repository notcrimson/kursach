USE [master]
GO
/****** Object:  Database [Курсовая]    Script Date: 10/12/2020 10:37:40 AM ******/
CREATE DATABASE [Курсовая]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Курсовая', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Курсовая.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Курсовая_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Курсовая_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Курсовая] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Курсовая].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Курсовая] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Курсовая] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Курсовая] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Курсовая] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Курсовая] SET ARITHABORT OFF 
GO
ALTER DATABASE [Курсовая] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Курсовая] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Курсовая] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Курсовая] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Курсовая] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Курсовая] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Курсовая] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Курсовая] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Курсовая] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Курсовая] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Курсовая] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Курсовая] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Курсовая] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Курсовая] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Курсовая] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Курсовая] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Курсовая] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Курсовая] SET RECOVERY FULL 
GO
ALTER DATABASE [Курсовая] SET  MULTI_USER 
GO
ALTER DATABASE [Курсовая] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Курсовая] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Курсовая] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Курсовая] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Курсовая] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Курсовая', N'ON'
GO
ALTER DATABASE [Курсовая] SET QUERY_STORE = OFF
GO
USE [Курсовая]
GO
/****** Object:  Table [dbo].[Professional units]    Script Date: 10/12/2020 10:37:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professional units](
	[Name of PU] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Professional units] PRIMARY KEY CLUSTERED 
(
	[Name of PU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Result]    Script Date: 10/12/2020 10:37:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Student_login] [varchar](50) NULL,
	[PU name] [varchar](50) NULL,
	[Test name] [varchar](50) NULL,
	[Answers] [varchar](max) NULL,
 CONSTRAINT [PK_Result] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student_profile]    Script Date: 10/12/2020 10:37:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_profile](
	[Student_login] [varchar](50) NOT NULL,
	[PU learned] [varchar](20) NULL,
	[Correct tests] [varchar](20) NULL,
	[Time entered] [time](7) NULL,
	[Time exited] [time](7) NULL,
 CONSTRAINT [PK_Student_profile] PRIMARY KEY CLUSTERED 
(
	[Student_login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Test correct answers]    Script Date: 10/12/2020 10:37:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test correct answers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name of PU] [varchar](50) NULL,
	[Test name] [varchar](50) NOT NULL,
	[Correct answers] [varchar](max) NULL,
 CONSTRAINT [PK_Test correct answers_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tests]    Script Date: 10/12/2020 10:37:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tests](
	[Name of PU] [varchar](50) NOT NULL,
	[Test name] [varchar](50) NOT NULL,
	[Number of questions] [int] NULL,
	[Answers] [varchar](max) NULL,
	[Student_login] [varchar](50) NULL,
 CONSTRAINT [PK_Tests] PRIMARY KEY CLUSTERED 
(
	[Name of PU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/12/2020 10:37:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Login] [varchar](50) NOT NULL,
	[Name] [varchar](50) NULL,
	[Password] [varchar](50) NOT NULL,
	[ProfilePic] [varbinary](50) NULL,
	[Role] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Users_1] PRIMARY KEY CLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Result_Professional units] FOREIGN KEY([PU name])
REFERENCES [dbo].[Professional units] ([Name of PU])
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Result_Professional units]
GO
ALTER TABLE [dbo].[Result]  WITH CHECK ADD  CONSTRAINT [FK_Result_Users] FOREIGN KEY([Student_login])
REFERENCES [dbo].[Users] ([Login])
GO
ALTER TABLE [dbo].[Result] CHECK CONSTRAINT [FK_Result_Users]
GO
ALTER TABLE [dbo].[Student_profile]  WITH CHECK ADD  CONSTRAINT [FK_Student_profile_Users] FOREIGN KEY([Student_login])
REFERENCES [dbo].[Users] ([Login])
GO
ALTER TABLE [dbo].[Student_profile] CHECK CONSTRAINT [FK_Student_profile_Users]
GO
ALTER TABLE [dbo].[Test correct answers]  WITH CHECK ADD  CONSTRAINT [FK_Test correct answers_Professional units] FOREIGN KEY([Name of PU])
REFERENCES [dbo].[Professional units] ([Name of PU])
GO
ALTER TABLE [dbo].[Test correct answers] CHECK CONSTRAINT [FK_Test correct answers_Professional units]
GO
ALTER TABLE [dbo].[Tests]  WITH CHECK ADD  CONSTRAINT [FK_Tests_Professional units1] FOREIGN KEY([Name of PU])
REFERENCES [dbo].[Professional units] ([Name of PU])
GO
ALTER TABLE [dbo].[Tests] CHECK CONSTRAINT [FK_Tests_Professional units1]
GO
ALTER TABLE [dbo].[Tests]  WITH CHECK ADD  CONSTRAINT [FK_Tests_Users] FOREIGN KEY([Student_login])
REFERENCES [dbo].[Users] ([Login])
GO
ALTER TABLE [dbo].[Tests] CHECK CONSTRAINT [FK_Tests_Users]
GO
USE [master]
GO
ALTER DATABASE [Курсовая] SET  READ_WRITE 
GO
