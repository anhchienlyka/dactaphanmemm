CREATE DATABASE quanlybanh
USE quanlybanh
GO

CREATE TABLE tblKhach(
MaHang NVARCHAR(50)  NOT NULL,
TenKhach NVARCHAR(50) NOT NULL,
DiaChi NVARCHAR(50) NOT NULL,
DienThoai NVARCHAR(50) NOT NULL,
PRIMARY KEY CLUSTERED (MaHang ASC)
)
GO

CREATE TABLE tblChatLieu(
MaChatLieu NVARCHAR(50) NOT NULL,
TenChatLieu NVARCHAR(50) NOT NULL,
PRIMARY KEY CLUSTERED(MaChatLieu ASC)
)
GO

CREATE TABLE tblNhanVien(
MaNhanVien  NVARCHAR(50) NOT NULL,
TenNhanVien  NVARCHAR(50) NOT NULL,
GioiTinh  NVARCHAR(50) NOT NULL,
DiaChi  NVARCHAR(50) NOT NULL,
DienThoai  NVARCHAR(50) NOT NULL,
NgaySinh DATE NOT NULL,
UserName NVARCHAR(50) NOT NULL,
Password VARCHAR(50) NOT NULL,
PRIMARY KEY CLUSTERED (MaNhanVien ASC)
)
GO

CREATE  TABLE tblHang(
MaHang NVARCHAR(50) NOT NULL,
TenHang NVARCHAR(50) NOT NULL,
MaChatLieu NVARCHAR(50) NOT NULL ,
SoLuong FLOAT(50) NOT NULL,
DonGiaNhap FLOAT(50) NOT NULL,
DonGiaBan FLOAT(50) NOT NULL,
Anh NVARCHAR(200) NOT NULL,
GhiChu NVARCHAR(200) NULL,
PRIMARY KEY CLUSTERED(MaHang ASC),
FOREIGN KEY(MaChatLieu) REFERENCES dbo.tblChatLieu(MaChatLieu)
)
GO
CREATE TABLE tblHDBan(
MaHDBan NVARCHAR(50) NOT NULL,
MaNhanVien NVARCHAR(50) NOT NULL,
NgayBan DATETIME NOT NULL,
MaKhach NVARCHAR(50) NOT NULL,
TongTien FLOAT(53) NOT NULL,
PRIMARY KEY CLUSTERED(MaHDBan ASC),
FOREIGN KEY(MaKhach) REFERENCES dbo.tblKhach(MaHang),
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
INSERT INTO dbo.tblChatLieu
(MaChatLieu,TenChatLieu) VALUES 
( N'CL001', N'Phô Mai' ),
( N'CL002', N'Mat Cha' ),
( N'CL003', N'Dâu Tây' ),
( N'CL004', N'Hương Chuối'),
( N'CL005', N'Đậu Đỏ' )
GO
INSERT INTO dbo.tblKhach
(MaHang,TenKhach,DiaChi,DienThoai)
VALUES
(N'MKH001',N'Phạm Văn Chiến',N'Nam Định',N'085782821'),
(N'MKH002',N'Nguyễn Công Phượng',N'Nam Định',N'085766621'),
(N'MKH003',N'Phạm Minh Chính',N'Nam Định',N'085722821'),
(N'MKH004',N'Phạm Băng Băng',N'Nam Định',N'085332821'),
(N'MKH005',N'Phạm Khánh Phương',N'Nam Định',N'085787777')
GO
INSERT INTO dbo.tblNhanVien
(MaNhanVien,TenNhanVien,GioiTinh,DiaChi,DienThoai,NgaySinh,UserName,Password)
VALUES
(N'MNV001',N'Ngô Thế Tùng',N'Nam',N'Nam Định',N'093578956',GETDATE(),N'admin','123'),
(N'MNV002',N'Ngô Thế Đào',N'Nam',N'Nam Định',N'0935345956',GETDATE(),N'admin','123'),
(N'MNV003',N'Ngô Thế Tiến',N'Nam',N'Nam Định',N'093533356',GETDATE(),N'admin','123'),
(N'MNV004',N'Ngô Thế Dũng',N'Nam',N'Nam Định',N'093578556',GETDATE(),N'admin','123'),
(N'MNV005',N'Ngô Thế Hương',N'Nam',N'Nam Định',N'093578666',GETDATE(),N'admin','123')
GO
INSERT INTO dbo.tblHang
( MaHang,TenHang,MaChatLieu,SoLuong,DonGiaNhap,DonGiaBan,Anh,GhiChu)
VALUES
(N'MH001',N'Bánh Kem Trứng',N'CL001',150,50000,800000,N'null',N'null'),
(N'MH002',N'Bánh Kem Dừa',N'CL001',150,10000,3800000,N'null',N'null'),
(N'MH003',N'Bánh Kem Bơ',N'CL001',150,30000,2800000,N'null',N'null'),
(N'MH004',N'Bánh Kem Cam',N'CL001',150,60000,1800000,N'null',N'null'),
(N'MH005',N'Bánh Kem Trứng Muối',N'CL001',150,650000,800000,N'null',N'null')
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
