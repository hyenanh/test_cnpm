
CREATE DATABASE QUAN_LI_NHA_SACH
create table SACH(
	MaSach varchar(10) primary key,
	TenSach nvarchar(250),
	TacGia nvarchar(150),
	DonGiaNhap money,
	DonGiaBan money,
	SoLuongTon int
)

create table PHIEUNHAP_SACH(
	MaPhieuNhap varchar(10) primary key,
	NgayTaoPhieu smalldatetime,
	NgayNhap smalldatetime,
	MaTk varchar(10)
)
create table CT_PNS(
	MaSach varchar(10),
	MaPhieuNhap varchar(10),
	SoLuong int
	primary key(MaSach,MaPhieuNhap)
)
create table KHACH_HANG(
	MaKH varchar(10) primary key,
	HoTen nvarchar(250),
	NgaySinh smalldatetime,
	DiaChi nvarchar(250),
	email nvarchar(200),
	SDT nvarchar(50),
	TienNo int
)
-- luc mua hang thi thu tien roi moi dua hoa don, nen lm phieu thu tien truoc
create table HOA_DON(
	MaHD varchar(10) primary key,
	MaKH varchar(10),
	NgayLapHoaDon smalldatetime,
	TongTien money,
	SoTienTra money,
	ConLai money,
	MaTK varchar(10)
)

create table CT_HD(
	MaHD varchar(10),
	MaSach varchar(10),
	SoLuongMua int
	primary key(MaHD,MaSach)
)
create table PHIEU_THU_TIEN(
	MaPT varchar(10) primary key,
	MaKH varchar(10),
	NgayThuTien smalldatetime,
	SoTienThu money,
	MaTK varchar(10)
)
create table THE_LOAI(
	MaTL varchar(10) primary key,
	TenTL nvarchar(100)
)
create table CTTL(
	MaTL varchar(10),
	MaSach varchar(10)
	primary key(MaTL,MaSach)
)
create table BC_TONKHO(
	MaTonKho varchar(10) primary key,
	Thang int,
	nam int

)
create table CT_BCTONKHO(
	MaTonKho varchar(10),
	MaSach varchar(10),
	TonDau int,
	TonCuoi int,
	PhatSinh int
	primary key(MaTonKho,MaSach)

)
create table BC_CONGNO(
	MaCongNo varchar(10) primary key,
	Thang int,
	nam int

)
create table CT_BCCONGNO(
	
	MaCongNo varchar(10),
	MaKH varchar(10),
	NoDau int,
	NoCuoi int,
	PhatSinh int
	primary key(MaCongNo,MaKH)
)

create table TAI_KHOAN(
	MaTK varchar(10) primary key,
	email nvarchar(150),
	TenDN varchar(100),
	MatKhau char(10),
	MaPhanQuyen varchar(10),
	HoTenNV nvarchar(250),
	DiaCHi nvarchar(200),
	SDT varchar(11),
	GioiTinh char(10),
	NgaySinh smalldatetime
)
create table PHANQUYEN(
	MaPhanQuyen varchar(10) primary key,
	TenPhanQuyen nvarchar(250)

)
create table QUYDINH(
	SoLuongNhapToiThieu int,
	SoLuongTonToiDa int,
	SoLuongTonItNhatSauBan int,
	TienNoToiDa money,
	DuocThuVuotQuaSoTienKhachDangNoHayKo bit,
	NgayCapNhat smalldatetime

)
-- bang QUYDINH CHI CO DUNG 1 DONG, chi dc cap nhat ko dc them
insert into QUYDINH values(150,300,20,20000,0,'05/15/2022')

alter table PHIEUNHAP_SACH add foreign key (MaTK) references TAI_KHOAN(MaTK)

alter table CT_PNS add foreign key (MaSach) references SACH(MaSach)
alter table CT_PNS add foreign key (MaPhieuNhap) references PHIEUNHAP_SACH(MaPhieuNhap)

alter table HOA_DON add foreign key (MaKH) references KHACH_HANG(MaKH)
alter table HOA_DON add foreign key (MaTK) references TAI_KHOAN(MaTK)

alter table CT_HD add foreign key (MaHD) references HOA_DON(MaHD)
alter table CT_HD add foreign key (MaSach) references SACH(MaSach)

alter table PHIEU_THU_TIEN add foreign key (MaKH) references KHACH_HANG(MaKH)
alter table PHIEU_THU_TIEN add foreign key (MaTK) references TAI_KHOAN(MaTK)

alter table CTTL add foreign key (MaTL) references THE_LOAI(MaTL)
alter table CTTL add foreign key (MaSach) references Sach(MaSach)

alter table CT_BCTONKHO add foreign key (MaSach) references SACH(MaSach)
alter table CT_BCTONKHO add foreign key (MaTonKho) references BC_TONKHO(MaTonKho)

alter table CT_BCCONGNO add foreign key (MaKH) references KHACH_HANG(MaKH)
alter table CT_BCCONGNO add foreign key (MaCongNo) references BC_CONGNO(MaCongNo)

alter table TAI_KHOAN add foreign key (MaPhanQuyen) references PHANQUYEN(MaPhanQuyen)





create or alter trigger So_luong_nhap_toi_thieu 
on CT_PNS for insert,update 
as
begin
	declare @soLuongNhap int, @SoLuongNhapToiThieu int
	select @soLuongNhap = SoLuong from inserted
	select @SoLuongNhapToiThieu = SoLuongNhapToiThieu from QUYDINH
	if(@soLuongNhap < @SoLuongNhapToiThieu)
	begin
		raiserror(N'Số lượng nhập chưa đủ', 16, 1)
		rollback
	end
end
/*alter table CT_PNS nocheck constraint all

insert into CT_PNS values('S01','PN01',160)
insert into CT_PNS values('S01','PN01',130)*/
-- thay doi tren bang nao, lam anh huong den bang khac thi cap nhat bang khac tren bang thay doi
create or alter trigger So_luong_nhap
on CT_PNS for insert,update
as
begin
	declare @SoLuongTon int,@SoLuongTonToiDa int,@SoLuongNhap int,@TongSoLuongTon int,@Masach varchar(10)
	select @SoLuongnhap=SoLuong from inserted
	select @Masach=Masach from inserted
	select @SoLuongTon=SoLuongTon from SACH where @Masach=SACH.MaSach 
	select @TongSoLuongTon=@SoLuongNhap+@SoLuongTon

	

	select @SoLuongTonToiDa=SoLuongTonToiDa from QUYDINH 
	if(@TongSoLuongTon>@SoLuongTonToiDa)
	begin
		raiserror(N'vượt quá số lượng tồn tối đa',16,1)
		rollback
	end
	else
	begin
		update SACH
		set SoLuongTon=@TongSoLuongTon
		where SACH.MaSach=@Masach
	end
end

create or alter trigger So_luong_ton_toi_da_DonGiaBan
on SACH for insert,update
as
begin
	declare @SoLuongTon int,@SoLuongTonToiDa int,@GiaNhap int, @GiaBan int, @MaSach varchar(10)

	select @GiaNhap=DonGiaNhap from inserted
	select @GiaBan=@GiaNhap*1.05
	select @MaSach=MaSach from inserted

	select @SoLuongTon=SoLuongTon from inserted
	select @SoLuongTonToiDa=SoLuongTonToiDa from QUYDINH 
	if(@SoLuongTon>@SoLuongTonToiDa)
	begin
		raiserror(N'vượt quá số lượng tồn tối đa',16,1)
		rollback
	end
	else
	begin
		update SACH
		set DonGiaBan=@GiaBan
		where  @MaSach=SACH.MaSach
	end
end
/*alter table SACH nocheck constraint all
insert into SACH values('S02',N'sgk vật lí',N'Quang Tuấn',10000,12000,350)
insert into SACH values('S03',N'sgk toán',N'Quang Tuấn',10000,12000,200)
insert into SACH values('S04','sgk vật lí','Quang Tuấn',10000,12000,500)
insert into SACH(MaSach,TenSach,TacGia,DonGiaNhap,SoLuongTon) values ('S06',N'Sách giáo khoa tiếng anh 12','Nhiều tác giả',10000,250)*/



create or alter trigger So_luong_ton_toi_thieu
on SACH for insert,update
as
begin
	declare @SoLuongTon int,@SoLuongTonToiThieu int
	select @SoLuongTon=SoLuongTon from inserted
	select @SoLuongTonToiThieu=SoLuongTonItNhatSauBan from QUYDINH
	if(@SoLuongTon<@SoLuongTonToiThieu)
	begin
		raiserror(N'số sách còn lại nhỏ hơn SL tồn tối thiểu',16,1)
		rollback
	end
end
/*alter table SACH nocheck constraint all
insert into SACH values('S05',N'sgk hóa',N'Quang Tuấn',10000,12000,21)
insert into SACH values('S06',N'sgk tiếng anh',N'Quang Tuấn',10000,12000,15)*/

create or alter trigger So_luong_ban
on CT_HD for insert,update
/*nhap vao so luong ban: 
t1 ktr so luong ton toi thieu 
t2 cap nhat lai so luong ton trog bang SACH
t3 cap nhat ton cuoi trong bccongno
*/
as
begin
	declare @SoLuongMua int,@SoLuongTonToiThieu int,@SoSAchConLai int,@SoLuongTon int,@masach varchar(10)
	select @SoLuongMua=SoLuongMua from inserted
	select @masach=MaSach from inserted
	select @SoLuongTon=SoluongTon from SACH where SACH.MaSach=@masach
	select @SoLuongTonToiThieu=SoLuongTonItNhatSauBan from QUYDINH

	select @SoSAchConLai=@SoLuongTon-@SoLuongMua

	if(@SoSAchConLai<@SoLuongTonToiThieu)
	begin
		raiserror(N'số sách còn lại nhỏ hơn SL tồn tối thiểu',16,1)
		rollback-- gap rollback thi nhung gi dc insert or update trc do ko dc xay ra nx
	end
	else
	begin
		update SACH
		set SoLuongTon=@SoSAchConLai
		where MaSach=@masach
	end
end


create or alter trigger Tien_no_toi_da
on KHACH_HANG for insert,update
as
begin
	declare @tienno int,@tiennotoida int
	select @tienno=TienNo from inserted
	select @tiennotoida=TienNoToiDa from QUYDINH
	if(@tienno>@tiennotoida)
	begin
		raiserror(N'vượt qua số tiền nợ cho phép',16,1)
		rollback
	end
end

create or alter trigger tongtien_tienconlai_capnhattienno
on HOA_DON for insert,update
as
begin
	declare @tongtien int,@mahd varchar(10),@masach varchar(10),@Sotientra money,@Conlai int,@tienno money,@capnhattienno money,@tiennotoida money,@makh varchar(10)
	select @Sotientra=SoTienTra from inserted
	select @mahd=MaHD from inserted
	select @makh=MaKH from inserted
	select @tienno=tienno from KHACH_HANG where KHACH_HANG.MaKH=@makh
	select @tiennotoida=TienNoToiDa from QUYDINH

	select @tongtien=sum(SoLuongMua*DonGiaBan) from SACH,CT_HD where SACH.MaSach=CT_HD.MaSach and CT_HD.MaHD=@mahd
	select @Conlai=@tongtien-@Sotientra-- dua thua tien thi coi nhu conlai=0(tra du)
	select @capnhattienno=@tienno+@Conlai
	-- th1 no qua thi phai thu no, th2 no chua qua or ko no thi cu lap hoa don
	if(@capnhattienno>@tiennotoida)
	begin
		raiserror(N'vượt qua số tiền nợ cho phép, phải thu nợ',16,1)
		rollback
	end
	else
	begin
		update HOA_DON
		set TongTien=@tongtien,ConLai=@Conlai
		where HOA_DON.MaHD=@mahd

		update KHACH_HANG
		set TienNo=@capnhattienno
		where KHACH_HANG.MaKH=@makh

	end

	
end

alter table HOA_DON nocheck constraint all
--insert into HOA_DON(MaHD,NgayLapHoaDon) values('HD01','02/11/2022')

alter table CT_HD nocheck constraint all
--insert into CT_HD(MaHD,MaSach,SoLuongMua) values('HD01','S01',2)
--insert into CT_HD(MaHD,MaSach,SoLuongMua) values('HD01','S02',3)
/*
 if 
	DuocThuVuotQuaSoTienKhachDangNoHayKo=0
	thi nhap so tien thu nhieu hon so tien no ko bao loi
else
	if DuocThuVuotQuaSoTienKhachDangNoHayKo=1
	nhap so tien thu nhieu hon so tien no
	bao loi "so tien thu ko dc vuot qua so tien khach dang no"
*/
-- khi lap phieu thu tien thi no se chay trigger nay

/*t1 ktr co su dung QD4 ko
t2 cap nhat tien no
*/
create or alter trigger QD4
on PHIEU_THU_TIEN for insert,update
as
begin
	declare @SDQD4 bit, @TienThu money,@TienNo money,@makh varchar(10),@capnhattienno money
	select @SDQD4=DuocThuVuotQuaSoTienKhachDangNoHayKo from QUYDINH
	select @TienThu=SoTienThu from inserted
	select @makh=MaKH from inserted
	select @TienNo=TienNo from KHACH_HANG b where b.MaKH=@makh

	


	if(@SDQD4=1)
	begin
		if(@TienNo<@TienThu)
		begin
			raiserror(N'Số tiền thu vượt quá số tiền nợ',16,1)
		rollback
		end
		else
		begin
			select @capnhattienno=@TienNo-@TienThu
			update KHACH_HANG
			set TienNo=@capnhattienno
			where KHACH_HANG.MaKH=@makh
		end

	end
	else
	begin
		if(@TienNo<@TienThu)
		begin
			select @capnhattienno=0
			update KHACH_HANG
			set TienNo=@capnhattienno
			where KHACH_HANG.MaKH=@makh
		end
		else
		begin
			select @capnhattienno=@TienNo-@TienThu
			update KHACH_HANG
			set TienNo=@capnhattienno
			where KHACH_HANG.MaKH=@makh
		end
	end


end

create or alter trigger TonDau_toncuoi
on CT_BCTONKHO for insert,update
as
begin
	declare @MaTonKho varchar(10), @tondau int,@toncuoi int, @toncuoicuathangtruoc int,@thang int,@nam int,@masach varchar(10),@phatsinh int
	select @masach=MaSach from inserted
	select @toncuoi=SoLuongTon from SACH where SACH.MaSach=@masach
	 
	select @MaTonKho=MaTonKho from inserted
	--lay thang nam cua tháng này
	select @thang=Thang,@nam=nam from BC_TONKHO where BC_TONKHO.MaTonKho=@MaTonKho
	--lay ton cuoi cua loại sách này trong tháng  truoc

	if(@thang=1)
	begin
		select @toncuoicuathangtruoc=TonCuoi from CT_BCTONKHO a,BC_TONKHO b where a.MaTonKho=b.MaTonKho and a.MaSach=@masach and  b.Thang=12 and b.nam=@nam-1
	end
	else
	begin
		select @toncuoicuathangtruoc=TonCuoi from CT_BCTONKHO a,BC_TONKHO b where a.MaTonKho=b.MaTonKho and a.MaSach=@masach and  b.Thang=@thang-1 and b.nam=@nam
	end
	--tồn đầu của sách trong tháng này bằng tồn cuối của sách trong tháng trước, tai thang dau tien nhap thi phai insert
	select @tondau=@toncuoicuathangtruoc

	select @phatsinh=@toncuoi-@tondau

	update CT_BCTONKHO
	set TonCuoi=@toncuoi,TonDau=@tondau,PhatSinh=@phatsinh
	where CT_BCTONKHO.MaTonKho=@MaTonKho and CT_BCTONKHO.MaSach=@masach
end


create or alter trigger NoDau_Nocuoi
on CT_BCCONGNO for insert,update
as
begin
	declare @MaCongNo varchar(10), @nodau int,@nocuoi int, @nocuoicuathangtruoc int,@thang int,@nam int,@maKH varchar(10),@phatsinh int
	select @nodau=Nodau from inserted
	select @maKH=MaKH from inserted
	
	select @nocuoi=TienNo from KHACH_HANG where KHACH_HANG.MaKh=@maKh

	select @MaCongNo=MaCongNo from inserted
	--lay thang nam cua tháng này
	select @thang=Thang,@nam=nam from BC_CONGNO where BC_CONGNO.MaCongNo=@MaCongNo
	--lay ton cuoi cua loại sách này trong tháng  truoc
	
	if(@thang=1)
	begin
		select @nocuoicuathangtruoc=noCuoi from CT_BCCONGNO a,BC_CONGNO b where a.MaCongNo=b.MaCongNo and a.MaKH=@makh and  b.Thang=12 and b.nam=@nam-1
	end
	else
	begin
		select @nocuoicuathangtruoc=noCuoi from CT_BCCONGNO a,BC_CONGNO b where a.MaCongNo=b.MaCongNo and a.MaKH=@makh and  b.Thang=@thang-1 and b.nam=@nam
	end
	--tồn đầu của sách trong tháng này bằng tồn cuối của sách trong tháng trước
	select @nodau=@nocuoicuathangtruoc

	select @phatsinh=@nocuoi-@nodau

	update CT_BCCONGNO
	set noCuoi=@nocuoi,noDau=@nodau,PhatSinh=@phatsinh
	where CT_BCCONGNO.MaCongNo=@MaCongNo and CT_BCCONGNO.Makh=@makh
	
end


set dateformat dmy
--KHACHHANG
insert into KHACH_HANG(MaKH,HoTen,NgaySinh,DiaChi,email,SDT,TienNo) values ('KH01',N'Lê Thị Phương Duyên','06/11/2002',N'ktx khu b','PDuyen@gmail.com','0123456789',12000)
insert into KHACH_HANG(MaKH,HoTen,NgaySinh,DiaChi,email,SDT,TienNo) values ('KH02',N'Huỳnh Yến Anh','06/12/2002',N'ktx khu b','YAnh@gmail.com','0124353334',3000)
insert into KHACH_HANG(MaKH,HoTen,NgaySinh,DiaChi,email,SDT,TienNo) values ('KH03',N'Ma Thị Thu Hiền','03/05/2002',N'ktx khu b','THienh@gmail.com','0982353316',10000)
insert into KHACH_HANG(MaKH,HoTen,NgaySinh,DiaChi,email,SDT,TienNo) values ('KH04',N'Đào Thị Thu Uyên','13/09/2002',N'ktx khu b','TUyen@gmail.com','0985791023',5000)
insert into KHACH_HANG(MaKH,HoTen,NgaySinh,DiaChi,email,SDT,TienNo) values ('KH05',N'Nguyễn Đặng Quang Tuấn','05/04/2002',N'ktx khu b','QTuan@gmail.com','0919895210',2000)

--SACH
-- nhớ insert dongiaban=105%dongianhap nha vì cái này tui ko code trog csdl để vô winform mới code
--insert into SACH(MaSach,TenSach,TacGia,DonGiaNhap,DonGiaBan,SoLuongTon) values ('S01',N'Lược sử thời gian','Stephen HawKing',20000,21000,10)
insert into SACH(MaSach,TenSach,TacGia,DonGiaNhap,DonGiaBan,SoLuongTon) values ('S01',N'Lược sử thời gian',N'Stephen HawKing',20000,21000,30)
insert into SACH(MaSach,TenSach,TacGia,DonGiaNhap,DonGiaBan,SoLuongTon) values ('S02',N'Vũ trụ trong vỏ hạt dẻ',N'Stephen HawKing',40000,42000,50)
insert into SACH(MaSach,TenSach,TacGia,DonGiaNhap,DonGiaBan,SoLuongTon) values ('S03',N'Sách giáo khoa toán 12',N'Nhiều tác giả',10000,10500,250)
insert into SACH(MaSach,TenSach,TacGia,DonGiaNhap,DonGiaBan,SoLuongTon) values ('S04',N'Sách giáo khoa vật lí 12',N'Nhiều tác giả',10000,10500,250)
insert into SACH(MaSach,TenSach,TacGia,DonGiaNhap,DonGiaBan,SoLuongTon) values ('S05',N'Sách giáo khoa ngữ văn 12',N'Nhiều tác giả',10000,10500,250)
--PHANQUYEN
insert into PHANQUYEN(MaPhanQuyen,TenPhanQuyen) values(1,N'Nhân viên')
insert into PHANQUYEN(MaPhanQuyen,TenPhanQuyen) values(2,N'Quản Lí')
insert into PHANQUYEN(MaPhanQuyen,TenPhanQuyen) values(3,N'Quản trị viên')
--TAIKHOAN

insert into TAI_KHOAN(MaTK,email,TenDN,MatKhau,MaPhanQuyen,HoTenNV,DiaChi,SDT,GioiTinh,NgaySinh) values('TK01','nv1@gmail.com','nv1','123456nv1',1,N'Nguyễn Thị Thảo',N'Thủ Đức ,tp HCM','0986223356','nu','02/06/1998')
insert into TAI_KHOAN(MaTK,email,TenDN,MatKhau,MaPhanQuyen,HoTenNV,DiaChi,SDT,GioiTinh,NgaySinh) values('TK02','nv2@gmail.com','nv2','123456nv2',1,N'Trần Thanh Trúc',N'Thủ Đức ,tp HCM','0985444980','nu','05/01/1990')
insert into TAI_KHOAN(MaTK,email,TenDN,MatKhau,MaPhanQuyen,HoTenNV,DiaChi,SDT,GioiTinh,NgaySinh) values('TK03','nv3@gmail.com','nv3','123456nv3',1,N'Nguyễn Gia Bảo',N'Quận 3 ,tp HCM','0989293292','nam','09/02/1994')
insert into TAI_KHOAN(MaTK,email,TenDN,MatKhau,MaPhanQuyen,HoTenNV,DiaChi,SDT,GioiTinh,NgaySinh) values('TK04','qli@gmail.com','qli','123456qli',2,N'Lê Đức Thành',N'Quận 2 ,tp HCM','0919892425','nam','04/08/1994')
insert into TAI_KHOAN(MaTK,email,TenDN,MatKhau,MaPhanQuyen,HoTenNV,DiaChi,SDT,GioiTinh,NgaySinh) values('TK05','qtri@gmail.com','qtri','123456qtri',3,N'Nguyễn Thảo Vân',N'Bình Thạnh ,tp HCM','0812345678','nu','01/12/1986')
--THELOAI


insert into THE_LOAI(MaTL,TenTL) values ('TL01',N'sách giáo khoa')
insert into THE_LOAI(MaTL,TenTL) values ('TL02',N'Khoa học vũ trụ')
insert into THE_LOAI(MaTL,TenTL) values ('TL03',N'truyện cổ tích')
insert into THE_LOAI(MaTL,TenTL) values ('TL04',N'ẩm thực')
insert into THE_LOAI(MaTL,TenTL) values ('TL05',N'tâm lí tình cảm')
--CHITIETTHELOAI

insert into CTTL(MaTL,MaSach)values ('TL01','S03')
insert into CTTL(MaTL,MaSach)values ('TL01','S04')
insert into CTTL(MaTL,MaSach)values ('TL01','S05')
insert into CTTL(MaTL,MaSach)values ('TL02','S01')
insert into CTTL(MaTL,MaSach)values ('TL02','S02')
--PHIEUNHAPSACH

insert into PHIEUNHAP_SACH(MaPhieuNhap,NgayTaoPhieu,NgayNhap,MaTk)values ('PN01','02/02/2022','04/02/2022','TK01')
insert into PHIEUNHAP_SACH(MaPhieuNhap,NgayTaoPhieu,NgayNhap,MaTk)values ('PN02','02/03/2022','05/03/2022','TK03')
--CT_PNS

--insert into CT_PNS(MaSach,MaPhieuNhap,SoLuong)values('CTPNS01','S01','PN01',120)
insert into CT_PNS(MaSach,MaPhieuNhap,SoLuong)values('S01','PN01',160)
insert into CT_PNS(MaSach,MaPhieuNhap,SoLuong)values('S02','PN01',150)
--insert into CT_PNS(MaSach,MaPhieuNhap,SoLuong)values('S03','PN01',200)
--insert into CT_PNS(MaSach,MaPhieuNhap,SoLuong)values('S04','PN02',400)
--insert into CT_PNS(MaSach,MaPhieuNhap,SoLuong)values('S04','PN02',160)
--insert into CT_PNS(MaSach,MaPhieuNhap,SoLuong)values('S05','PN02',160)
insert into CT_PNS(MaSach,MaPhieuNhap,SoLuong)values('S01','PN02',160)
insert into CT_PNS(MaSach,MaPhieuNhap,SoLuong)values('S02','PN02',150)
--CT_HD
--insert CT_HD(MaHD,MaSach,SoLuongMua)values('HD01','S03',300)
--ktr SACHxem no cap nhat so luong ton dung ko
insert CT_HD(MaHD,MaSach,SoLuongMua)values('HD01','S01',2)
insert CT_HD(MaHD,MaSach,SoLuongMua)values('HD01','S02',3)

insert CT_HD(MaHD,MaSach,SoLuongMua)values('HD02','S03',10)
insert CT_HD(MaHD,MaSach,SoLuongMua)values('HD02','S04',10)

insert CT_HD(MaHD,MaSach,SoLuongMua)values('HD03','S03',10)
insert CT_HD(MaHD,MaSach,SoLuongMua)values('HD03','S04',10)

insert CT_HD(MaHD,MaSach,SoLuongMua)values('HD04','S05',1)
insert CT_HD(MaHD,MaSach,SoLuongMua)values('HD04','S01',1)

--HOADON
insert into HOA_DON(MaHD,MaKH,NgayLapHoaDon,SoTienTra,MaTK) values('HD01','KH01','01/01/2022',160000,'TK01')
--ktr HOADON, KHACH_HANG xem no cap nhat dung k
insert into HOA_DON(MaHD,MaKH,NgayLapHoaDon,SoTienTra,MaTK) values('HD02','KH02','01/01/2022',200000,'TK01')
insert into HOA_DON(MaHD,MaKH,NgayLapHoaDon,SoTienTra,MaTK) values('HD03','KH02','02/01/2022',200000,'TK03')

insert into HOA_DON(MaHD,MaKH,NgayLapHoaDon,SoTienTra,MaTK) values('HD04','KH03','05/01/2022',10000,'TK02')

--PHIEUTHUTIEN
insert into PHIEU_THU_TIEN(MaPT,MaKH,NgayThuTien,SoTienThu,MaTK)values ('PT01','KH03','05/01/2022',10000,'TK02')
insert into PHIEU_THU_TIEN(MaPT,MaKH,NgayThuTien,SoTienThu,MaTK)values ('PT02','KH01','04/01/2022',15000,'TK02')
--BC_CONGNO
insert into BC_CONGNO(MaCongNo,Thang,Nam) values ('CN01','1','2022')
insert into BC_CONGNO(MaCongNo,Thang,Nam) values ('CN02','2','2022')
insert into BC_CONGNO(MaCongNo,Thang,Nam) values ('CN03','3','2022')
insert into BC_CONGNO(MaCongNo,Thang,Nam) values ('CN04','4','2022')
insert into BC_CONGNO(MaCongNo,Thang,Nam) values ('CN05','5','2022')
--CT_BCCONGNO
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN01','KH01')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN01','KHO2')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN01','KHO3')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN01','KHO4')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN01','KH05')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN02','KH01')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN02','KHO2')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN02','KHO3')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN02','KHO4')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN02','KH05')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN03','KH01')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN03','KHO2')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN03','KHO3')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN03','KHO4')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN03','KH05')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN04','KH01')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN04','KHO2')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN04','KHO3')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN04','KHO4')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN04','KH05')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN05','KH01')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN05','KHO2')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN05','KHO3')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN05','KHO4')
insert into CT_BCCONGNO(MaCongNo,MaKH) values ('CN05','KH05')

--BC_TONKHO 
insert into BC_TONKHO(MaTonKho,Thang,Nam) values ('TKh01','1','2022')
insert into BC_TONKHO(MaTonKho,Thang,Nam) values ('TKh02','2','2022')
insert into BC_TONKHO(MaTonKho,Thang,Nam) values ('TKh03','3','2022')
insert into BC_TONKHO(MaTonKho,Thang,Nam) values ('TKh04','4','2022')
insert into BC_TONKHO(MaTonKho,Thang,Nam) values ('TKh05','5','2022')

----CT_BCTONKHO
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh01','S01');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh01','S02');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh01','S03');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh01','S04');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh01','S05');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh02','S01');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh02','S02');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh02','S03');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh02','S04');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh02','S05');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh03','S01');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh03','S02');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh03','S03');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh03','S04');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh03','S05');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh04','S01');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh04','S02');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh04','S03');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh04','S04');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh04','S05');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh05','S01');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh05','S02');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh05','S03');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh05','S04');
insert into CT_BCTONKHO(MaTonKho,MaSach) values ('TKh05','S05');





