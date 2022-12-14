USE [MyEquipment]
GO
/****** Object:  Table [dbo].[Klavye]    Script Date: 22.05.2021 21:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klavye](
	[Urun_id] [int] IDENTITY(1,1) NOT NULL,
	[Urun_adi] [nvarchar](50) NULL,
	[Urun_marka] [nvarchar](50) NULL,
	[Oyun_tur] [nvarchar](50) NULL,
	[Urun_boy] [nvarchar](50) NULL,
	[Bilek_destegi] [nvarchar](50) NULL,
	[Urun_Fiyat] [nvarchar](50) NULL,
	[Fiyat_seviye] [nvarchar](50) NULL,
	[Urun_Link] [nvarchar](max) NULL,
	[Urun_Puan] [int] NULL,
	[Urun_Resimlink] [nvarchar](max) NULL,
 CONSTRAINT [PK_Klavye] PRIMARY KEY CLUSTERED 
(
	[Urun_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kullanici_giris]    Script Date: 22.05.2021 21:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici_giris](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kullanici_adi] [nvarchar](50) NULL,
	[kullanici_sifre] [nvarchar](50) NULL,
	[ad] [nvarchar](50) NULL,
	[soyadi] [nvarchar](50) NULL,
	[telno] [nvarchar](50) NULL,
	[e_posta] [nvarchar](50) NULL,
	[ulke] [nvarchar](50) NULL,
	[il] [nvarchar](50) NULL,
	[dogum_yili] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kullanici_giris] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mouse]    Script Date: 22.05.2021 21:43:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mouse](
	[Urun_id] [int] IDENTITY(1,1) NOT NULL,
	[Urun_adi] [nvarchar](50) NULL,
	[Urun_marka] [nvarchar](50) NULL,
	[Oyun_tur] [nvarchar](50) NULL,
	[Urun_boy] [nvarchar](50) NULL,
	[Makro] [nvarchar](50) NULL,
	[Urun_Fiyat] [nvarchar](50) NULL,
	[Fiyat_seviye] [nvarchar](50) NULL,
	[Urun_Link] [nvarchar](max) NULL,
	[Urun_Puan] [int] NULL,
	[Urun_Resimlink] [nvarchar](max) NULL,
	[Kablosuz] [nvarchar](50) NULL,
 CONSTRAINT [PK_Mouse] PRIMARY KEY CLUSTERED 
(
	[Urun_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
