--tạo DB
Create database PhongGym
go
use PhongGym

--tạo các table

Create table HoiVien(
	id_hv varchar(10),
	hoten nvarchar(50),
	gioitinh nvarchar(3),
	sdt varchar(12),
	ngayhethan date,
	goitap nvarchar(50),
	hinhanh varbinary(max),
	Primary key(id_hv)
)
go

Create table SanPham(
	id_sp varchar(10),
	ten nvarchar(50),
	loai nvarchar(30),
	ngaynhap date,
	soluong int,
	dongia varchar(12),
	trongluong varchar(10),
	hangsx nvarchar(50),
	tinhtrang nvarchar(20),
	hinhanh varbinary(max)
	primary key(id_sp)
)
go

Create table ThietBi(
	id_tb varchar(10),
	ten nvarchar(50),
	loai nvarchar(10),
	soluong int,
	hangsx nvarchar(50),
	tinhtrang nvarchar(20),
	soluonghu int,
	ghichu nvarchar(200),
	hinhanh varbinary(max)
	primary key(id_tb)
)
go


create table NhanVien(
	id_nv varchar(10) primary key not null,
	hoten nvarchar(50),
	gioitinh nvarchar(3),
	sdt varchar(12)
)

create table TaiKhoan(
	id_nv varchar(10) primary key not null,
	username varchar(50) unique not null,
	password varchar(50) not null	
	foreign key(id_nv) references NhanVien(id_nv)
)

insert into NhanVien values('NV001',N'Nguyễn Thị A',N'Nữ','025362325');
insert into TaiKhoan values('NV001','admin','1')
