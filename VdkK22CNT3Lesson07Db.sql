USE [VdkK22CNT3Lesson07Db]
GO
/****** Object:  Table [dbo].[vdkKhoa]    Script Date: 26/06/2024 10:28:57 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vdkKhoa](
	[VdkMaKH] [nchar](10) NOT NULL,
	[VdkTenKH] [nvarchar](50) NULL,
	[VdkTrangThai] [bit] NULL,
 CONSTRAINT [PK_vdkKhoa] PRIMARY KEY CLUSTERED 
(
	[VdkMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vdkSinhVien]    Script Date: 26/06/2024 10:28:57 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vdkSinhVien](
	[VdkMaSV] [nvarchar](50) NOT NULL,
	[VdkHoSV] [nvarchar](50) NULL,
	[VdkTenSV] [nvarchar](50) NULL,
	[VdkNgaySinh] [date] NULL,
	[VdkPhai] [bit] NULL,
	[VdkPhone] [nchar](10) NULL,
	[VdkEmail] [nvarchar](50) NULL,
	[VdkMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_vdkSinhVien] PRIMARY KEY CLUSTERED 
(
	[VdkMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[vdkKhoa] ([VdkMaKH], [VdkTenKH], [VdkTrangThai]) VALUES (N'K22CNT3   ', N'K22CNT3', 1)
GO
INSERT [dbo].[vdkSinhVien] ([VdkMaSV], [VdkHoSV], [VdkTenSV], [VdkNgaySinh], [VdkPhai], [VdkPhone], [VdkEmail], [VdkMaKH]) VALUES (N'2210900032', N'Vu Duc', N'Khoa', CAST(N'2004-08-27' AS Date), 1, N'0567699711', N'kedeptrai@gmail.com', N'K22CNT3   ')
GO
