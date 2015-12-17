USE [Clinic]
GO

/****** Object:  Table [dbo].[tb_Appointment]    Script Date: 12/17/2015 10:42:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tb_Appointment](
	[AppointmentID] [nvarchar](40) NOT NULL,
	[PatientID] [nvarchar](20) NOT NULL,
	[ProfessionalID] [nvarchar](20) NOT NULL,
	[VisitDate] [datetime] NOT NULL,
	[LastUpdateTime] [datetime] NOT NULL,
	[Reason] [nvarchar](40) NOT NULL,
	[Cost] [int] NOT NULL,
	[Location] [varchar](50) NULL,
 CONSTRAINT [PK_tb_Appointment] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tb_Appointment]  WITH CHECK ADD  CONSTRAINT [FK_tb_Appointment_tb_Appointment] FOREIGN KEY([AppointmentID])
REFERENCES [dbo].[tb_Appointment] ([AppointmentID])
GO

ALTER TABLE [dbo].[tb_Appointment] CHECK CONSTRAINT [FK_tb_Appointment_tb_Appointment]
GO

ALTER TABLE [dbo].[tb_Appointment]  WITH CHECK ADD  CONSTRAINT [FK_tb_Appointment_tb_Appointment1] FOREIGN KEY([AppointmentID])
REFERENCES [dbo].[tb_Appointment] ([AppointmentID])
GO

ALTER TABLE [dbo].[tb_Appointment] CHECK CONSTRAINT [FK_tb_Appointment_tb_Appointment1]
GO


