USE [VdkK22CNT3Lesoon10DB]
GO
/****** Object:  Table [dbo].[VdkAccount]    Script Date: 03/07/2024 9:20:04 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VdkAccount](
	[VdkID] [int] NOT NULL,
	[VdkUserName] [nvarchar](50) NULL,
	[VdkPassword] [nvarchar](50) NULL,
	[VdkFullName] [nchar](10) NULL,
	[VdkEmail] [nvarchar](50) NULL,
	[VdkPhone] [nvarchar](50) NULL,
	[VdkActive] [bit] NULL,
 CONSTRAINT [PK_VdkAccount] PRIMARY KEY CLUSTERED 
(
	[VdkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
