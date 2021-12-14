CREATE DATABASE quanlybanh
USE quanlybanh
GO

CREATE TABLE tblKhach(
MaKhach NVARCHAR(50)  NOT NULL,
TenKhach NVARCHAR(50) NOT NULL,
DiaChi NVARCHAR(50) NOT NULL,
DienThoai NVARCHAR(50) NOT NULL,
PRIMARY KEY CLUSTERED (MaKhach ASC)
)
GO

--CREATE TABLE tblChatLieu(
--MaChatLieu NVARCHAR(50) NOT NULL,
--TenChatLieu NVARCHAR(50) NOT NULL,
--PRIMARY KEY CLUSTERED(MaChatLieu ASC)
--)
--GO

CREATE TABLE tblLoaiBanh(
MaLoaiBanh NVARCHAR(50) NOT NULL,
TenLoaiBanh NVARCHAR(50) NOT NULL,
PRIMARY KEY CLUSTERED(MaLoaiBanh ASC)
)
GO

CREATE TABLE tblNhaCungCap(
MaNhaCungCap NVARCHAR(50) NOT NULL,
TenNhaCungCap NVARCHAR(50) NOT NULL,
PRIMARY KEY CLUSTERED(MaNhaCungCap ASC)
)
GO


CREATE TABLE tblNhanVien(
MaNhanVien  NVARCHAR(50) NOT NULL,
TenNhanVien  NVARCHAR(50) NOT NULL,
GioiTinh  NVARCHAR(50) NOT NULL,
DiaChi  NVARCHAR(50) NOT NULL,
DienThoai  NVARCHAR(50) NOT NULL,
NgaySinh DATE NOT NULL,
PRIMARY KEY CLUSTERED (MaNhanVien ASC)
)
GO

CREATE TABLE tblLogin(
ID NVARCHAR(50) NOT NULL,
MaNhanVien NVARCHAR(50) NOT NULL,
Pass NVARCHAR(50) NOT NULL
PRIMARY KEY CLUSTERED(ID ASC),
FOREIGN KEY(MaNhanVien) REFERENCES tblNhanVien(MaNhanVien),
)
GO

CREATE  TABLE tblHang(
MaHang NVARCHAR(50) NOT NULL,
TenHang NVARCHAR(50) NOT NULL,
--MaChatLieu NVARCHAR(50) NOT NULL ,
MaLoaiBanh NVARCHAR(50) NOT NULL,
MaNhaCungCap NVARCHAR(50) NOT NULL,
SoLuong FLOAT(50) NOT NULL,
DonGiaNhap FLOAT(50) NOT NULL,
DonGiaBan FLOAT(50) NOT NULL,
Anh NVARCHAR(200) NOT NULL,
GhiChu NVARCHAR(200) NULL,
PRIMARY KEY CLUSTERED(MaHang ASC),
--FOREIGN KEY(MaChatLieu) REFERENCES dbo.tblChatLieu(MaChatLieu),
FOREIGN KEY(MaLoaiBanh) REFERENCES dbo.tblLoaiBanh(MaLoaiBanh),
FOREIGN KEY(MaNhaCungCap) REFERENCES dbo.tblNhaCungCap(MaNhaCungCap)
)
GO
CREATE TABLE tblHDBan(
MaHDBan NVARCHAR(50) NOT NULL,
MaNhanVien NVARCHAR(50) NOT NULL,
NgayBan DATETIME NOT NULL,
MaKhach NVARCHAR(50) NOT NULL,
TongTien FLOAT(53) NOT NULL,
PRIMARY KEY CLUSTERED(MaHDBan ASC),
FOREIGN KEY(MaKhach) REFERENCES dbo.tblKhach(MaKhach),
FOREIGN KEY(MaNhanVien) REFERENCES dbo.tblNhanVien(MaNhanVien)
)
GO

CREATE TABLE tblChiTietHDBan(
MaHDBan NVARCHAR(50) NOT NULL,
MaHang NVARCHAR(50) NOT NULL,
SoLuong FLOAT(50) NOT NULL,
DonGia FLOAT NOT NULL,
GiamGia FLOAT NULL,
ThanhTien FLOAT NULL,
FOREIGN KEY (MaHDBan) REFERENCES dbo.tblHDBan(MaHDBan),
FOREIGN KEY(MaHang) REFERENCES dbo.tblHang(MaHang)
)
GO
INSERT INTO dbo.tblLoaiBanh
(MaLoaiBanh, TenLoaiBanh)
VALUES
(N'LB001', N'Bánh crepe'), 
(N'LB002', N'Bánh su kem'), 
(N'LB003', N'Bánh kem'), 
(N'LB004', N'Bánh Pizza'),
(N'LB005', N'Bánh bông lan')
GO
INSERT INTO dbo.tblNhaCungCap
(MaNhaCungCap, TenNhaCungCap)
VALUES
(N'NCC001', N'Tiệm bánh Poeme'), 
(N'NCC002', N'Tiệm bánh Patisserie Lapin'), 
(N'NCC003', N'Cửa hàng chuyên bánh kem Jony'), 
(N'NCC004', N'Cửa hàng bánh ngọt Pháp'),
(N'NCC005', N'Tiệm bánh IT')
GO
--INSERT INTO dbo.tblChatLieu
--(MaChatLieu,TenChatLieu) VALUES 
--( N'CL001', N'Phô Mai' ),
--( N'CL002', N'Mat Cha' ),
--( N'CL003', N'Dâu Tây' ),
--( N'CL004', N'Hương Chuối'),
--( N'CL005', N'Đậu Đỏ' )
--GO
INSERT INTO dbo.tblKhach
(MaKhach,TenKhach,DiaChi,DienThoai)
VALUES
(N'MKH001',N'Phạm Văn Chiến',N'Nam Định',N'085782821'),
(N'MKH002',N'Nguyễn Công Phượng',N'Nam Định',N'085766621'),
(N'MKH003',N'Phạm Minh Chính',N'Nam Định',N'085722821'),
(N'MKH004',N'Phạm Băng Băng',N'Nam Định',N'085332821'),
(N'MKH005',N'Phạm Khánh Phương',N'Nam Định',N'085787777')
GO
INSERT INTO dbo.tblNhanVien
(MaNhanVien,TenNhanVien,GioiTinh,DiaChi,DienThoai,NgaySinh)
VALUES
(N'MNV001',N'Ngô Thế Tùng',N'Nam',N'Nam Định',N'093578956',GETDATE()),
(N'MNV002',N'Ngô Thế Đào',N'Nam',N'Nam Định',N'0935345956',GETDATE()),
(N'MNV003',N'Ngô Thế Tiến',N'Nam',N'Nam Định',N'093533356',GETDATE()),
(N'MNV004',N'Ngô Thế Dũng',N'Nam',N'Nam Định',N'093578556',GETDATE()),
(N'MNV005',N'Ngô Thế Hương',N'Nam',N'Nam Định',N'093578666',GETDATE())
GO
INSERT INTO dbo.tblLogin
(ID, MaNhanVien, Pass)
VALUES
(N'M001', N'MNV001', 'abc@1357'),
(N'M002', N'MNV002', 'zaq12345'),
(N'M003', N'MNV003', 'mko09876')
GO

INSERT INTO dbo.tblHang
( MaHang,TenHang,MaLoaiBanh,MaNhaCungCap,SoLuong,DonGiaNhap,DonGiaBan,Anh,GhiChu)
VALUES
(N'MH001',N'Bánh Kem Trứng',N'LB003','NCC005',150,50000,800000,N'D:\cach-lam-banh-su-kem-nhan-kem-trung-de-lam-thom-ngon-bat-bai-11.jpg',N'null'),
(N'MH002',N'Bánh Kem Dừa',N'LB003','NCC005',150,10000,3800000,N'D:\cach-lam-banh-su-kem-nhan-kem-trung-de-lam-thom-ngon-bat-bai-11.jpg',N'null'),
(N'MH003',N'Bánh su kem sữa tươi',N'LB002','NCC001',150,30000,2800000,N'D:\cach-lam-banh-su-kem-nhan-kem-trung-de-lam-thom-ngon-bat-bai-11.jpg',N'null'),
(N'MH004',N'Bánh crepe sầu riêng',N'LB001','NCC002',150,60000,1800000,N'D:\cach-lam-banh-su-kem-nhan-kem-trung-de-lam-thom-ngon-bat-bai-11.jpg',N'null'),
(N'MH005',N'Bánh Crepe Sầu riêng - Chuối',N'LB001','NCC002',150,650000,800000,N'D:\cach-lam-banh-su-kem-nhan-kem-trung-de-lam-thom-ngon-bat-bai-11.jpg',N'null'),
(N'MH006',N'Bánh su kem nhân dừa',N'LB002','NCC004',150,650000,800000,N'D:\cach-lam-banh-su-kem-nhan-kem-trung-de-lam-thom-ngon-bat-bai-11.jpg',N'null')
GO
INSERT INTO dbo.tblHDBan
(MaHDBan,MaNhanVien,NgayBan,MaKhach,TongTien
)
VALUES
(N'MHDB001',N'MNV003',GETDATE(), N'MKH002',800000),
(N'MHDB002',N'MNV003',GETDATE(), N'MKH002',800000),
(N'MHDB003',N'MNV002',GETDATE(), N'MKH004',800000),
(N'MHDB004',N'MNV001',GETDATE(), N'MKH001',800000)
go
