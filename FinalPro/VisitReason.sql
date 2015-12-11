USE [Clinic]
GO

/****** Object:  Table [dbo].[tb_VisitReason]    Script Date: 12/11/2015 11:13:28 AM ******/
DROP TABLE [dbo].[tb_VisitReason]
GO

/****** Object:  Table [dbo].[tb_VisitReason]    Script Date: 12/11/2015 11:13:28 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tb_VisitReason](
	[ReasonID] int NOT NULL,
	[Reason] [varchar](50) NOT NULL,
	[Cost] [int] NOT NULL,
 CONSTRAINT [PK_VisitReason] PRIMARY KEY CLUSTERED 
(
	[ReasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


