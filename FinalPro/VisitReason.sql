USE [Clinic]
GO

/****** Object:  Table [dbo].[tb_VisitReason]    Script Date: 12/17/2015 10:45:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tb_VisitReason](
	[ReasonID] [varchar](20) NOT NULL,
	[Reason] [varchar](50) NULL,
	[Cost] [int] NULL,
 CONSTRAINT [PK_VisitReason] PRIMARY KEY CLUSTERED 
(
	[ReasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


