USE [Clinic]
GO

/****** Object:  Table [dbo].[tb_Patient]    Script Date: 12/11/2015 1:41:38 AM ******/
DROP TABLE [dbo].[tb_Patient]
GO

/****** Object:  Table [dbo].[tb_Patient]    Script Date: 12/11/2015 1:41:38 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_Patient](
	[FirstName] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[DOB] [date] NOT NULL,
	[PatientID] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tb_Patient] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


