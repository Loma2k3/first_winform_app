
USE [Sach];
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [nvarchar](10) NOT NULL,
	[MaTheLoai] [nvarchar](10) NOT NULL,
	TenSach [nvarchar](200) NOT NULL,
	[TacGia] [nvarchar](150) NULL,
	[NgayXuatBan] [date] NOT NULL,
	[DonGiaBan] [int] NOT NULL,
	PRIMARY KEY (MaSach),
);
GO

CREATE TABLE dbo.HoaDon(
	MaHoaDon [nvarchar](10) NOT NULL,
	MaKH nvarchar(10) NOT NULL,
	[NgayBan] [date] NULL,
	TongTien money NULL,
	TinhTrang nvarchar(20) NULL
	PRIMARY KEY (MaHoaDon),
);
GO
CREATE TABLE dbo.ChiTietHoaDon(
	[MaHoaDon] [nvarchar](10) NOT NULL,
	[MaSach] [nvarchar](10) NOT NULL,
	[SLBan] [int] NULL,
);
GO
CREATE TABLE dbo.KhachHang(
	[MaKH] [nvarchar](10) NOT NULL,
	[password] nvarchar(20) not null,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[DienThoai] [nvarchar](15) NULL,
	PRIMARY KEY (MaKH)
);


GO

ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])

go
alter table Sach
add Description nvarchar(400)

alter table Sach
add Image nvarchar(30)

alter table Sach
add Stock int

alter table HoaDon
alter column MaHoaDon [nvarchar](200) NOT NULL

alter table ChiTietHoaDon
alter column [MaHoaDon] [nvarchar](200) NOT NULL