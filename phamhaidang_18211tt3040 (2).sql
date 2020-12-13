create database QLNV

go 
use QLNV

set dateformat dmy

go
create table ChucVu(
MaCV varchar(5) primary key,
TenCV nvarchar(50),
MaLuong varchar(5)
)

go 
create table PhongBan(
MaPB varchar(5) primary key,
TenPB nvarchar(50)
)

go 
create table Luong(
MaLuong varchar(5) primary key,
TenLuong nvarchar(20),
LuongCoBan int,
LuongPhuCap int
)

go
create table NhanVien(
MaNV varchar(5) primary key,
TenNV nvarchar(50),
DanToc nvarchar(50),
GioiTinh nvarchar(5),
QueQuan nvarchar(100),
NgaySinh datetime,
SoDienThoai varchar(10),
MaCV varchar(5),
MaPB varchar(5),
)

go
--Khóa ngoại
ALTER TABLE ChucVu
ADD CONSTRAINT CV_Luong FOREIGN KEY (MaLuong)REFERENCES Luong (MaLuong)

go
Alter table NhanVien
ADD CONSTRAINT NV_PB FOREIGN KEY (MaPB)REFERENCES PhongBan (MaPB)

go
Alter table NhanVien
ADD CONSTRAINT NV_CV FOREIGN KEY (MaCV)REFERENCES ChucVu(MaCV)

 

--Bảng Lương
go
--Thêm
CREATE PROCEDURE sp_themLuong(@MaLuong varchar(5), @TenLuong nvarchar(20), @LuongCoBan int, @LuongPhuCap int)
AS
INSERT INTO Luong(MaLuong, TenLuong, LuongCoBan, LuongPhuCap)
VALUES(@MaLuong, @TenLuong, @LuongCoBan, @LuongPhuCap)

go
exec sp_themLuong 'L01','Giam doc', 30000000, 500000
exec sp_themLuong 'L02','Pho Giam doc', 20000000, 400000
exec sp_themLuong 'L03','Thu ky', 15000000, 300000
exec sp_themLuong 'L04','Truong phong', 10000000, 200000
exec sp_themLuong 'L05','Nhan vien', 7000000, 100000

go
--Xóa
CREATE PROCEDURE sp_xoaLuong(@MaLuong varchar(5))
AS
delete from Luong where MaLuong = @MaLuong

go
--Sửa
CREATE PROCEDURE sp_suaLuong(@MaLuong varchar(5), @TenLuong nvarchar(20), @LuongCoBan int, @LuongPhuCap int)
AS
update Luong set TenLuong=@TenLuong, LuongCoBan=@LuongCoBan, LuongPhuCap=@LuongPhuCap
where MaLuong=@MaLuong

go
exec sp_suaLuong 'L01','123',1,2