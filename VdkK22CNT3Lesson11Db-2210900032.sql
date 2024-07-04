USE [VdkK22CNT3Less11Db]
GO
/****** Object:  Table [dbo].[VdkCategory]    Script Date: 04/07/2024 10:12:45 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VdkCategory](
	[VdkID] [int] NOT NULL,
	[VdkCateName] [nvarchar](50) NULL,
	[VdkStatus] [bit] NULL,
 CONSTRAINT [PK_VdkCategory] PRIMARY KEY CLUSTERED 
(
	[VdkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VdkProduct]    Script Date: 04/07/2024 10:12:45 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VdkProduct](
	[VdkId2210900032] [int] NOT NULL,
	[VdkProName] [nvarchar](50) NULL,
	[VdkQty] [int] NULL,
	[VdkPrice] [float] NULL,
	[VdkCateId] [int] NULL,
	[VdkActive] [bit] NULL,
 CONSTRAINT [PK_VdkProduct] PRIMARY KEY CLUSTERED 
(
	[VdkId2210900032] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[VdkCategory] ([VdkID], [VdkCateName], [VdkStatus]) VALUES (1, N'2210900032', 1)
INSERT [dbo].[VdkCategory] ([VdkID], [VdkCateName], [VdkStatus]) VALUES (2, N'Iphone', 0)
GO
INSERT [dbo].[VdkProduct] ([VdkId2210900032], [VdkProName], [VdkQty], [VdkPrice], [VdkCateId], [VdkActive]) VALUES (1, N'Iphone15', 1, 2000, 1, 1)
INSERT [dbo].[VdkProduct] ([VdkId2210900032], [VdkProName], [VdkQty], [VdkPrice], [VdkCateId], [VdkActive]) VALUES (221090032, N'Vu Duc Khoa', 10, 1000, 1, 1)
GO
