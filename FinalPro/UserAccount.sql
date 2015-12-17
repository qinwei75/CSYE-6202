USE [Clinic]
GO

/****** Object:  Table [dbo].[tb_UserAccount]    Script Date: 12/17/2015 10:44:25 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tb_UserAccount](
	[UserName] [varchar](30) NOT NULL,
	[Password] [varchar](40) NOT NULL,
	[UserType] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tb_UserAccount] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


