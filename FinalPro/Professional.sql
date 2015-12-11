USE [Clinic]
GO

/****** Object:  Table [dbo].[tb_Profession]    Script Date: 12/11/2015 1:46:21 AM ******/
DROP TABLE [dbo].[tb_Profession]
GO

/****** Object:  Table [dbo].[tb_Profession]    Script Date: 12/11/2015 1:46:21 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_Professional](
	[FirstName] [nvarchar](10) NOT NULL,
	[LastName] [nvarchar](10) NOT NULL,
	[DOB] [date] NOT NULL,
	[ProfessionalID] [nvarchar](20) NOT NULL,
	[Type] [nvarchar](20) NOT NULL
 CONSTRAINT [PK_tb_Professional] PRIMARY KEY CLUSTERED 
(
	[ProfessionalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


