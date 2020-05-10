Create table HDChiTietDatHang(
	MSHD nvarchar(10) not null,
	MSHH nvarchar(20) not null,
	SoLuong int not null,
	TiLeGiam int
	PRIMARY Key(MSHD, MSHH)
);