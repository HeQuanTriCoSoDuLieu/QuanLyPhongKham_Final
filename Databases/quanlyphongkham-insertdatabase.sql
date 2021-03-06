﻿USE quanlyphongkham_final
GO


-------------------------------------------- INSERT DATABASE ---------------------------------------------------------------------------------------


---1. BANG LOAI CAN LAM SANG -----

INSERT INTO LOAICANLAMSANG(TENLOAI) VALUES(N'KHOA DƯỢC');
INSERT INTO LOAICANLAMSANG(TENLOAI) VALUES(N'KHOA XÉT NGHIỆM');
INSERT INTO LOAICANLAMSANG(TENLOAI) VALUES(N'KHOA CHUẨN ĐOÁN HÌNH ẢNH');
INSERT INTO LOAICANLAMSANG(TENLOAI) VALUES(N'KHOA KIỂM SOÁT NHIỂM KHUẨN');
INSERT INTO LOAICANLAMSANG(TENLOAI) VALUES(N'TRUNG TÂM NỘI SOI')
GO

----2. BANG CAN LAM SAN -----


INSERT INTO CANLAMSANG(TENCLS,GIATIEN,MALOAICLS) VALUES(N'CHỤP HÌNH X-QUANG','50000',1);
INSERT INTO CANLAMSANG(TENCLS,GIATIEN,MALOAICLS) VALUES(N'SIÊU ÂM','100000',2);
INSERT INTO CANLAMSANG(TENCLS,GIATIEN,MALOAICLS) VALUES(N'CHỤP CẮT LỚP VI TÍNH','150000',3);
INSERT INTO CANLAMSANG(TENCLS,GIATIEN,MALOAICLS) VALUES(N'CHỤP CỘNG HƯỞNG TỪ','200000',4);
INSERT INTO CANLAMSANG(TENCLS,GIATIEN,MALOAICLS) VALUES(N'NỘI SOI','500000',5);
INSERT INTO CANLAMSANG(TENCLS,GIATIEN,MALOAICLS) VALUES(N'XÉT NGHIỆM TỔNG QUÁT','100000',3);
INSERT INTO CANLAMSANG(TENCLS,GIATIEN,MALOAICLS) VALUES(N'KHÁM SỨC KHỎE TỔNG THỂ','100000',4);
INSERT INTO CANLAMSANG(TENCLS,GIATIEN,MALOAICLS) VALUES(N'ĐO THỊ LỰC MẮT','100000',1);

GO

---3. BANG HINH THUC KHAM ------


INSERT INTO HINHTHUCKHAM(TENHINHTHUCKHAM) VALUES(N'Khám thường');
INSERT INTO HINHTHUCKHAM(TENHINHTHUCKHAM) VALUES(N'Khám dịch vụ');
INSERT INTO HINHTHUCKHAM(TENHINHTHUCKHAM) VALUES(N'Khám cấp cứu');
GO

----4. BANG BENH NHAN ------
INSERT INTO BENHNHAN(HOTEN,NGAYSINH,DANTOC,SOCMND,DIACHI,SODT) VALUES(N'HỒ THANH SƠN','1968-01-01','KINH','312574968',N'209, TRẦN HƯNG ĐẠO,Q.5','0936547821');
INSERT INTO BENHNHAN(HOTEN,NGAYSINH,DANTOC,SOCMND,DIACHI,SODT) VALUES(N'TRẦN TÂM THANH','1960-03-04','KINH','312574896',N'109/2 CMTT F10 QTB','0936547563');
INSERT INTO BENHNHAN(HOTEN,NGAYSINH,DANTOC,SOCMND,DIACHI,SODT) VALUES(N'TRẦN NAM SƠN','1979-01-19','KINH','312574520',N'34 DỖ DUY DƯƠNG, Q.5','0936547852');
INSERT INTO BENHNHAN(HOTEN,NGAYSINH,DANTOC,SOCMND,DIACHI,SODT) VALUES(N'NGUYỄN TIẾN DŨNG','1988-07-11','KINH','312574032',N'23/8 TRẦN VĂN LUÂN, Q.1','0936552121');
INSERT INTO BENHNHAN(HOTEN,NGAYSINH,DANTOC,SOCMND,DIACHI,SODT) VALUES(N'MAI THANH NAM','1978-12-21','KINH','312574263',N'209, TRẦN HƯNG ĐẠO,Q.1','0935812005');
INSERT INTO BENHNHAN(HOTEN,NGAYSINH,DANTOC,SOCMND,DIACHI,SODT) VALUES(N'NGUYỄN MẠNH HÙNG','1987-06-22','KINH','312562148',N'209, TRẦN HƯNG ĐẠO,Q.5','0936547821');
INSERT INTO BENHNHAN(HOTEN,NGAYSINH,DANTOC,SOCMND,DIACHI,SODT) VALUES(N'NGUYỄN THỊ KHÁNH VÂN','1968-08-22','KINH','312556311',N'189 TRẦN VĂN BỘ, Q.9','0936547821');
INSERT INTO BENHNHAN(HOTEN,NGAYSINH,DANTOC,SOCMND,DIACHI,SODT) VALUES(N'TRẦN ĐINH LÊ HƯƠNG','1988-02-24','KINH','312575201',N'567/13 PHAN ĐĂNG LƯU, QBT','0936547821');
INSERT INTO BENHNHAN(HOTEN,NGAYSINH,DANTOC,SOCMND,DIACHI,SODT) VALUES(N'LÊ THỊ GIA TRÂN','1990-01-30','KINH','312575222',N'203 AN DƯƠNG VƯƠNG, Q.5','0936861522');
INSERT INTO BENHNHAN(HOTEN,NGAYSINH,DANTOC,SOCMND,DIACHI,SODT) VALUES(N'NGUYỄN THỊ TUYẾT ANH','1978-11-22','KINH','312575641',N'209 NGUYỄN CƯ TRINH, Q.1','093654854');
GO

SELECT * FROM dbo.BENHNHAN
GO


DECLARE @i INT = 1;
WHILE @i < 13
BEGIN 
	UPDATE dbo.BENHNHAN SET DANTOC = N'Kinh' , TIENSU = N'Không' WHERE MABN = @i
	SET @i += 1;
END 
GO



----5. BANG KHOA ----


INSERT INTO KHOA(TENKHOA) VALUES(N'KHOA KHÁM BỆNH');
INSERT INTO KHOA(TENKHOA) VALUES(N'KHOA HỒI SỨC CẤP CỨU');
INSERT INTO KHOA(TENKHOA) VALUES(N'KHOA MẮT');
INSERT INTO KHOA(TENKHOA) VALUES(N'KHOA PHỤ SẢN');
INSERT INTO KHOA(TENKHOA) VALUES(N'KHOA NHI');
INSERT INTO KHOA(TENKHOA) VALUES(N'KHOA Y HỌC CỔ TRUYỀN');
INSERT INTO KHOA(TENKHOA) VALUES(N'KHOA GIẢI PHẨU THUẬT');
INSERT INTO KHOA(TENKHOA) VALUES(N'KHOA NGOẠI TỔNG HỢP');
INSERT INTO KHOA(TENKHOA) VALUES(N'KHOA NỘI TỔNG HỢP');
INSERT INTO KHOA(TENKHOA) VALUES(N'KHOA NỘI SOI');
GO


----6. BANG CHUC VU -----


INSERT INTO CHUCVU(TENCHUCVU) VALUES(N'TRƯỞNG KHOA KHÁM BỆNH')
INSERT INTO CHUCVU(TENCHUCVU) VALUES(N'TRƯỞNG KHOA HỒI SỨC CẤP CỨU')
INSERT INTO CHUCVU(TENCHUCVU) VALUES(N'TRƯỞNG KHOA MẮT')
INSERT INTO CHUCVU(TENCHUCVU) VALUES(N'TRƯỞNG KHOA PHỤ SẢN')
INSERT INTO CHUCVU(TENCHUCVU) VALUES(N'TRƯỞNG KHOA KHOA NHI')
INSERT INTO CHUCVU(TENCHUCVU) VALUES(N'TRƯỞNG KHOA Y HỌC CỔ TRUYỀN ')
INSERT INTO CHUCVU(TENCHUCVU) VALUES(N'TRƯỞNG PHÒNG KHOA GIẢI PHẨU THUẬT')
INSERT INTO CHUCVU(TENCHUCVU) VALUES(N'TRƯỞNG KHOA NGOẠI TỔNG HỢP')
INSERT INTO CHUCVU(TENCHUCVU) VALUES(N'TRƯỞNG KHOA NỘI TỔNG HỢP')
INSERT INTO CHUCVU(TENCHUCVU) VALUES(N'TRƯỞNG KHOA NỘI SOI')
GO

----7. BANG CHUC DANH -----



INSERT INTO CHUCDANH(TENCHUCDANH) VALUES(N'TIẾN SĨ')
INSERT INTO CHUCDANH(TENCHUCDANH) VALUES(N'THẠC SĨ')
INSERT INTO CHUCDANH(TENCHUCDANH) VALUES(N'TIẾN SĨ')
INSERT INTO CHUCDANH(TENCHUCDANH) VALUES(N'TIẾN SĨ')
INSERT INTO CHUCDANH(TENCHUCDANH) VALUES(N'THẠC SĨ')
INSERT INTO CHUCDANH(TENCHUCDANH) VALUES(N'THẠC SĨ')
INSERT INTO CHUCDANH(TENCHUCDANH) VALUES(N'TIẾN SĨ')
INSERT INTO CHUCDANH(TENCHUCDANH) VALUES(N'THẠC SĨ')
INSERT INTO CHUCDANH(TENCHUCDANH) VALUES(N'TIẾN SĨ')
INSERT INTO CHUCDANH(TENCHUCDANH) VALUES(N'THẠC SĨ')
GO

---8. BANG NHAN VIEN -----


INSERT INTO NHANVIEN(HOTEN,GIOITINH,SODT,EMAIL,MAKHOA,MACHUCDANH,MACHUCVU) VALUES(N'DANG HUYNH DAT Y','1','O971234578','danghuynhdaty@gmail.com',1,1,1);
INSERT INTO NHANVIEN(HOTEN,GIOITINH,SODT,EMAIL,MAKHOA,MACHUCDANH,MACHUCVU) VALUES(N'DINH BA TIEN','1','0978684538','dinhbatien@gmail.com',2,2,2);
INSERT INTO NHANVIEN(HOTEN,GIOITINH,SODT,EMAIL,MAKHOA,MACHUCDANH,MACHUCVU) VALUES(N'TRUONG NGUYEN HOANG THUONG','1','O971452648','truongnguyenhoangthuong97@gmail.com',3,3,3);
INSERT INTO NHANVIEN(HOTEN,GIOITINH,SODT,EMAIL,MAKHOA,MACHUCDANH,MACHUCVU) VALUES(N'VO TAN TRA','1','01623468378','votantra@gmail.com',4,4,4);
INSERT INTO NHANVIEN(HOTEN,GIOITINH,SODT,EMAIL,MAKHOA,MACHUCDANH,MACHUCVU) VALUES(N'TRIEU VY','1','O977648324','trieuvi@gmail.com',5,5,5);
INSERT INTO NHANVIEN(HOTEN,GIOITINH,SODT,EMAIL,MAKHOA,MACHUCDANH,MACHUCVU) VALUES(N'NGUYEN THANH TUNG','1','O971234578','nguyenthanhtung@gmail.com',6,6,6);
INSERT INTO NHANVIEN(HOTEN,GIOITINH,SODT,EMAIL,MAKHOA,MACHUCDANH,MACHUCVU) VALUES(N'LE THI NHAN','0','O989035684','lethinhan@gmail.com',7,7,7);
INSERT INTO NHANVIEN(HOTEN,GIOITINH,SODT,EMAIL,MAKHOA,MACHUCDANH,MACHUCVU) VALUES(N'NGUYEN MANH HUNG','1','O971234578','nguyenmanhhung@gmail.com',8,8,8);
INSERT INTO NHANVIEN(HOTEN,GIOITINH,SODT,EMAIL,MAKHOA,MACHUCDANH,MACHUCVU) VALUES(N'TRAN HONG QUAN','1','O909475578','tranhongquan@gmail.com',9,9,9);
INSERT INTO NHANVIEN(HOTEN,GIOITINH,SODT,EMAIL,MAKHOA,MACHUCDANH,MACHUCVU) VALUES(N'VUONG NGOC QUYEN','1','O979864328','vuongngocquyen@gmail.com',10,10,10);
GO


---9. BANG PHIEU KHAM ------




INSERT INTO PHIEUKHAM(MABN,MANV,NVTIEPNHAN,CHUANDOAN,MAHINHTHUCKHAM,KETLUAN,HOANTHANH,DATHANHTOAN) 
VALUES(1,1,4,N'Thiếu vitamin, suy nhược',1,N'Thiếu máu',1,1);
INSERT INTO PHIEUKHAM(MABN,MANV,NVTIEPNHAN,CHUANDOAN,MAHINHTHUCKHAM,KETLUAN,HOANTHANH,DATHANHTOAN) 
VALUES(2,1,4,N'Chấn động mạnh, bông gân',1,N'Dập cơ',1,1);
INSERT INTO PHIEUKHAM(MABN,MANV,NVTIEPNHAN,CHUANDOAN,MAHINHTHUCKHAM,KETLUAN,HOANTHANH,DATHANHTOAN) 
VALUES(3,1,4,N'Đau dạ dày, lâu ngày',1,N'Loét dạ dày cấp tính',1,1);
INSERT INTO PHIEUKHAM(MABN,MANV,NVTIEPNHAN,CHUANDOAN,MAHINHTHUCKHAM,KETLUAN,HOANTHANH,DATHANHTOAN) 
VALUES(4,1,4,N'Chống mặt, sảng, hạ huyết áp, rối loạn tiêu hóa',1,N'Nhiểm độc allenic nocleucin',1,1);
INSERT INTO PHIEUKHAM(MABN,MANV,NVTIEPNHAN,CHUANDOAN,MAHINHTHUCKHAM,KETLUAN,HOANTHANH,DATHANHTOAN) 
VALUES(5,1,4,N'Hạ huyết áp, chống mặt',1,N'Thiếu máu',1,1);
INSERT INTO PHIEUKHAM(MABN,MANV,NVTIEPNHAN,CHUANDOAN,MAHINHTHUCKHAM,KETLUAN,HOANTHANH,DATHANHTOAN) 
VALUES(6,1,4,N'Nhiểm khuẩn, vết thương tím',1,N'Nhiểm trùng vết thương',1,1);
INSERT INTO PHIEUKHAM(MABN,MANV,NVTIEPNHAN,CHUANDOAN,MAHINHTHUCKHAM,KETLUAN,HOANTHANH,DATHANHTOAN) 
VALUES(7,1,4,N'Da sưng tấy, ngứa',1,N'Do Microsporum Epidermophyton Trichophyton',1,1);
INSERT INTO PHIEUKHAM(MABN,MANV,NVTIEPNHAN,CHUANDOAN,MAHINHTHUCKHAM,KETLUAN,HOANTHANH,DATHANHTOAN) 
VALUES(8,1,4,N'Đau dạ dày nhiều ngày, quặn đau',1,N'Loét dạ dày do vi khuẩn HP',1,1);
INSERT INTO PHIEUKHAM(MABN,MANV,NVTIEPNHAN,CHUANDOAN,MAHINHTHUCKHAM,KETLUAN,HOANTHANH,DATHANHTOAN) 
VALUES(9,1,4,N'Suy nhược, đau nhức',1,N'Suy nhược cơ thể',1,1);
GO

select * from PHIEUKHAM
go


UPDATE dbo.PHIEUKHAM SET HOANTHANH = 0, NVTIEPNHAN = 1 , MANV = 2





---10. BANG DICH VU CẬN LÂM SÀNG ---------


INSERT INTO DICHVUCLS(MAPHIEUKHAM,TONGCONG) VALUES(1,'50000');
INSERT INTO DICHVUCLS(MAPHIEUKHAM,TONGCONG) VALUES(2,'100000');
INSERT INTO DICHVUCLS(MAPHIEUKHAM,TONGCONG) VALUES(3,'500000');
INSERT INTO DICHVUCLS(MAPHIEUKHAM,TONGCONG) VALUES(4,'100000');
INSERT INTO DICHVUCLS(MAPHIEUKHAM,TONGCONG) VALUES(5,'50000');
INSERT INTO DICHVUCLS(MAPHIEUKHAM,TONGCONG) VALUES(6,'150000');
INSERT INTO DICHVUCLS(MAPHIEUKHAM,TONGCONG) VALUES(7,'150000');
INSERT INTO DICHVUCLS(MAPHIEUKHAM,TONGCONG) VALUES(8,'50000');
INSERT INTO DICHVUCLS(MAPHIEUKHAM,TONGCONG) VALUES(9,'100000')
GO

----11. BANG CHI TIET CLS -------

INSERT INTO CHITIETCLS(MADICHVUCLS,MACLS,KETQUA) VALUES(1,2,N'GÃY CHÂN PHẢI');
INSERT INTO CHITIETCLS(MADICHVUCLS,MACLS,KETQUA) VALUES(2,1,N'ĐỨT DÂY CHẰNG CHÂN TRÁI');
INSERT INTO CHITIETCLS(MADICHVUCLS,MACLS,KETQUA) VALUES(3,2,N'ĐAU RUỘT THỪA');
INSERT INTO CHITIETCLS(MADICHVUCLS,MACLS,KETQUA) VALUES(5,8,N'HAI MẮT BỊ CẬN 1 ĐỘ');
INSERT INTO CHITIETCLS(MADICHVUCLS,MACLS,KETQUA) VALUES(5,1,N'GÃY TAY PHẢI');
INSERT INTO CHITIETCLS(MADICHVUCLS,MACLS,KETQUA) VALUES(6,3,N'CHẤN THƯƠNG PHẦN MỀM Ở ĐÙI TRÁI');
INSERT INTO CHITIETCLS(MADICHVUCLS,MACLS,KETQUA) VALUES(7,3,N'CHẤN THƯƠNG TOÀN THÂN');
INSERT INTO CHITIETCLS(MADICHVUCLS,MACLS,KETQUA) VALUES(8,1,N'CHẤN THƯƠNG ĐẦU');
INSERT INTO CHITIETCLS(MADICHVUCLS,MACLS,KETQUA) VALUES(9,6,N'MÁU BỊ NHIỄM VI KHUẨN')
GO



select * from CHITIETCLS
----13. BANG PHIEU NHAP -----


INSERT INTO PHIEUNHAP(MANV,NGAYNHAP) VALUES(1,'2017-08-12');
INSERT INTO PHIEUNHAP(MANV,NGAYNHAP) VALUES(2,'2017-08-16');
INSERT INTO PHIEUNHAP(MANV,NGAYNHAP) VALUES(3,'2017-09-10');
INSERT INTO PHIEUNHAP(MANV,NGAYNHAP) VALUES(4,'2017-11-10');
INSERT INTO PHIEUNHAP(MANV,NGAYNHAP) VALUES(5,'2017-08-22');
INSERT INTO PHIEUNHAP(MANV,NGAYNHAP) VALUES(6,'2017-09-17');
INSERT INTO PHIEUNHAP(MANV,NGAYNHAP) VALUES(7,'2017-10-11');
INSERT INTO PHIEUNHAP(MANV,NGAYNHAP) VALUES(8,'2017-10-10');
INSERT INTO PHIEUNHAP(MANV,NGAYNHAP) VALUES(9,'2017-08-11');
INSERT INTO PHIEUNHAP(MANV,NGAYNHAP) VALUES(10,'2017-07-10')
GO


---14. BANG DON VI TINH -------


INSERT INTO DONVITINH(TENDVT) VALUES(N'VIÊN');
INSERT INTO DONVITINH(TENDVT) VALUES(N'HỘP');
INSERT INTO DONVITINH(TENDVT) VALUES(N'LỌ');
INSERT INTO DONVITINH(TENDVT) VALUES(N'CHAI')
INSERT INTO DONVITINH(TENDVT) VALUES(N'CÁI')
GO

---15. BANG VAT TU Y TE -------


INSERT INTO VATTUYTE(TENVATTU,MADVT,SOLUONGTON) VALUES('MÁY CHỤP X-QUANG',1,5);
INSERT INTO VATTUYTE(TENVATTU,MADVT,SOLUONGTON) VALUES('MÁY NỘI SOI',2,3);
INSERT INTO VATTUYTE(TENVATTU,MADVT,SOLUONGTON) VALUES('MÁY SIÊU ÂM',3,4);
INSERT INTO VATTUYTE(TENVATTU,MADVT,SOLUONGTON) VALUES('MÁY CỘNG HƯỞNG TỪ',4,3);
INSERT INTO VATTUYTE(TENVATTU,MADVT,SOLUONGTON) VALUES('MÁY XÉT NGHIỆM MÁU TỰ ĐỘNG',4,4);

---16. BANG QUOC GIA -------


INSERT INTO QUOCGIA(TENQUOCGIA) VALUES(N'VIỆT NAM');
INSERT INTO QUOCGIA(TENQUOCGIA) VALUES(N'SINGAPORE ');
INSERT INTO QUOCGIA(TENQUOCGIA) VALUES(N'THỦY SĨ');
INSERT INTO QUOCGIA(TENQUOCGIA) VALUES(N'NHẬT');
INSERT INTO QUOCGIA(TENQUOCGIA) VALUES(N'HÀ LAN');
INSERT INTO QUOCGIA(TENQUOCGIA) VALUES(N'ANH');
INSERT INTO QUOCGIA(TENQUOCGIA) VALUES(N'THÁI LAN');
INSERT INTO QUOCGIA(TENQUOCGIA) VALUES(N'HÀ LAN');
INSERT INTO QUOCGIA(TENQUOCGIA) VALUES(N'CANADA');
INSERT INTO QUOCGIA(TENQUOCGIA) VALUES(N'PHÁP');
GO

----17. BANG NHA CUNG CAP -------


INSERT INTO NHACUNGCAP(TENNHACC,DIACHI,SODT,EMAIL,MAQUOCGIA) VALUES(N'CÔNG TY CỔ PHẦN NEEMTREE',N'37/5B, TRUNG MỸ TÂY, TRUNG CHÁNH, HÓC MÔN, TP.HCM','02871066869','www.info@neemtree.vn',1);
INSERT INTO NHACUNGCAP(TENNHACC,DIACHI,SODT,EMAIL,MAQUOCGIA) VALUES(N'CÔNG TY TNHH MTV THIỆN OANH',N'1/13/1,NGUYỄN ĐÌNH KHỞI, P.4,Q.TÂN BÌNH, TP.HCM','02838117762','www.thaoduocthiennhienvn@gmail.com',2);
INSERT INTO NHACUNGCAP(TENNHACC,DIACHI,SODT,EMAIL,MAQUOCGIA) VALUES(N'CÔNG TY CỔ PHẦN FOUR-H VIỆT NAM',N'57/7F,HỒ BÁ PHẤN, P.PHƯỚC LONG A,Q.9,TP.HCM','02862808488','www.foursjc@gmail.com',3);
INSERT INTO NHACUNGCAP(TENNHACC,DIACHI,SODT,EMAIL,MAQUOCGIA) VALUES(N'CÔNG TY TNHH BIO SUN',N'78 TRẦN PHÚ, P.4,Q.5, TP.HCM','0288958452','www.thutrinhdhdn@gmail.com',4);
INSERT INTO NHACUNGCAP(TENNHACC,DIACHI,SODT,EMAIL,MAQUOCGIA) VALUES(N'CÔNG TY CỔ PHẦN ETERNAL SPRING VIỆT NAM',N'322 LÊ TRỌNG TẤN, Q.THANHM XUAN,HÀ NỘI','0969783380','www.thuoctot24h@gmail.com',5);
INSERT INTO NHACUNGCAP(TENNHACC,DIACHI,SODT,EMAIL,MAQUOCGIA) VALUES(N'CÔNG TY TNHH DNC SOLUTION',N'26,P.PHÚ LƯƠNG,Q.HÀ ĐÔNG,HÀ NỘI','02439952922','www.duocphamthiennhiendncsolution@gmail.com',6);
INSERT INTO NHACUNGCAP(TENNHACC,DIACHI,SODT,EMAIL,MAQUOCGIA) VALUES(N'CÔNG TY TNHH PHILAVIDA',N'P.12, Q.10, TP.HCM','0287105192','www.philavida@gmail.com',7);
INSERT INTO NHACUNGCAP(TENNHACC,DIACHI,SODT,EMAIL,MAQUOCGIA) VALUES(N'CÔNG TY TNHH THẢO DƯỢC ĐẠI THIÊN NƯƠNG',N'7 HUỲNH THÚC KHÁNG, Q. ĐỐNG ĐA, HÀ NỘI','02871066869','www.lannuong@gmail.com',8);
INSERT INTO NHACUNGCAP(TENNHACC,DIACHI,SODT,EMAIL,MAQUOCGIA) VALUES(N'CÔNG TY CỔ PHẦn ĐẦU TƯ QUỐC TẾ VIỆT Á',N'61, P.VĨNH TUY, Q.HAI BÀ TRƯNG, HÀ NỘI','09471066869','www.',9);
INSERT INTO NHACUNGCAP(TENNHACC,DIACHI,SODT,EMAIL,MAQUOCGIA) VALUES(N'CÔNG TY CỔ PHẦN DƯỢC PHẨM TRUNG ƯƠNG I-PHARBACO',N'160 TÔN ĐỨC THẮNG,Q.ĐỐNG ĐA, HÀ NỘI','09412365871','www.duocphamtrunguong@gmail.com',10);
GO

---18. BANG HANG SAN XUAT -----


INSERT INTO HANGSANXUAT(TENHSX,DIACHI,MAQUOCGIA) VALUES(N'Công ty cổ phần quốc tế Minh Việt (IMV)', N'Quận 7, Hồ Chí Minh', 1);
INSERT INTO HANGSANXUAT(TENHSX,DIACHI,MAQUOCGIA) VALUES(N'Shimadzu Vietnam', N'87 Lương Đình Của, Phương Mai, Đống Đa, Hà Nội.', 1);
INSERT INTO HANGSANXUAT(TENHSX,DIACHI,MAQUOCGIA) VALUES(N'Creatz3D Pte Ltd', N'08-07 Yi Guang Factory Building Singapore 409032 ', 2);
INSERT INTO HANGSANXUAT(TENHSX,DIACHI,MAQUOCGIA) VALUES(N'Công Ty TNHH Thương Mại Dịch Vụ Đỉnh Việt', N'Quận 8', 1);
INSERT INTO HANGSANXUAT(TENHSX,DIACHI,MAQUOCGIA) VALUES(N'Công Ty Cổ Phần Dược Phẩm Trung Ương I - Pharbaco', N'160 Tôn Đức Thắng, Q. Đống Đa, Hà Nội', 1);
INSERT INTO HANGSANXUAT(TENHSX,DIACHI,MAQUOCGIA) VALUES(N'Công Ty Cổ Phần Dược Phẩm Davinci - Pháp', N'VPGD: Số 12/259 Phố Vọng, Quận Hai Bà Trưng, Hà Nội', 1);
GO


---19. BANG CHI TIET NHAP VAT TU -------

INSERT INTO CHITIETNHAPVATTU(MAPHIEUNHAP,MAVTYT,SOLUONG,MAHSX,NGAYSX,NGAYHETHAN,GIANHAP,MANHACC) VALUES(1,1,2,1,'2017-05-07','2020-05-07',5000000,1);
INSERT INTO CHITIETNHAPVATTU(MAPHIEUNHAP,MAVTYT,SOLUONG,MAHSX,NGAYSX,NGAYHETHAN,GIANHAP,MANHACC) VALUES(2,3,4,3,'2017-07-07','2020-07-07',5000000,4);
INSERT INTO CHITIETNHAPVATTU(MAPHIEUNHAP,MAVTYT,SOLUONG,MAHSX,NGAYSX,NGAYHETHAN,GIANHAP,MANHACC) VALUES(3,2,3,3,'2017-05-07','2020-05-07',5000000,2);
INSERT INTO CHITIETNHAPVATTU(MAPHIEUNHAP,MAVTYT,SOLUONG,MAHSX,NGAYSX,NGAYHETHAN,GIANHAP,MANHACC) VALUES(4,4,5,4,'2017-05-07','2020-05-07',5000000,3);
INSERT INTO CHITIETNHAPVATTU(MAPHIEUNHAP,MAVTYT,SOLUONG,MAHSX,NGAYSX,NGAYHETHAN,GIANHAP,MANHACC) VALUES(5,4,2,5,'2017-05-07','2020-05-07',5000000,5);
INSERT INTO CHITIETNHAPVATTU(MAPHIEUNHAP,MAVTYT,SOLUONG,MAHSX,NGAYSX,NGAYHETHAN,GIANHAP,MANHACC) VALUES(6,2,3,5,'2017-05-07','2020-05-07',5000000,2);
INSERT INTO CHITIETNHAPVATTU(MAPHIEUNHAP,MAVTYT,SOLUONG,MAHSX,NGAYSX,NGAYHETHAN,GIANHAP,MANHACC) VALUES(7,4,4,3,'2017-05-07','2020-05-07',5000000,4);
INSERT INTO CHITIETNHAPVATTU(MAPHIEUNHAP,MAVTYT,SOLUONG,MAHSX,NGAYSX,NGAYHETHAN,GIANHAP,MANHACC) VALUES(8,4,4,3,'2017-05-07','2020-05-07',5000000,6);
INSERT INTO CHITIETNHAPVATTU(MAPHIEUNHAP,MAVTYT,SOLUONG,MAHSX,NGAYSX,NGAYHETHAN,GIANHAP,MANHACC) VALUES(9,5,3,5,'2017-05-07','2020-05-07',5000000,7);
INSERT INTO CHITIETNHAPVATTU(MAPHIEUNHAP,MAVTYT,SOLUONG,MAHSX,NGAYSX,NGAYHETHAN,GIANHAP,MANHACC) VALUES(10,1,5,4,'2017-06-07','2020-05-07',5000000,8);
GO


---20. BANG LOAI THUOC -----


INSERT INTO LOAITHUOC(TENLOAI) VALUES(N'THUỐC CHỐNG DỊ ỨNG');
INSERT INTO LOAITHUOC(TENLOAI) VALUES(N'HẠ SỐT, CHỐNG CO THẮT, GIẢM ĐAU');
INSERT INTO LOAITHUOC(TENLOAI) VALUES(N'THUỐC ĐIỀU TRỊ BỆNH KHỚP');
INSERT INTO LOAITHUOC(TENLOAI) VALUES(N'THUỐC TÁC ĐỘNG LÊN, RUỘT GANG, DẠ DÀY');
INSERT INTO LOAITHUOC(TENLOAI) VALUES(N'THUỐC GIẢI ĐỘC');
INSERT INTO LOAITHUOC(TENLOAI) VALUES(N'THUỐC NGOÀI DA');
INSERT INTO LOAITHUOC(TENLOAI) VALUES(N'THUỐC SỬ DỤNG TRONG NHA KHOA');
INSERT INTO LOAITHUOC(TENLOAI) VALUES(N'THUỐC SỬ DỤNG TRONG NHÃN KHOA');
INSERT INTO LOAITHUOC(TENLOAI) VALUES(N'THUỐC THUỐC ĐIỀU TRỊ TAY-MŨI-HỌNG');
INSERT INTO LOAITHUOC(TENLOAI) VALUES(N'THUỐC TRỊ BỆNH NHIỄM KHUẨN, KÍ SINH TRÙNG');
GO

---21. BANG THUOC ------


INSERT INTO THUOC(TENTHUOC,DONVITINH,LOAITHUOC,SOLUONGTON,GHICHU) 
VALUES(N'Thuốc Prednisolone 5mg',1,2,100,N'Số đăng ký: VN-9867-05 Dạng bào chế: viên nén Quy cách đóng gói: hộp 100 viên Công ty đăng ký: S.I.A. (Tenamyd Canada) Inc. Thành phần:prednisolone: 5mg Chỉ định: Chống viêm, chống dị ứng mạnh và ức chế miễn dịch. Dùng khi viêm đau khớp đặc biệt là viêm thấp khớp, đa khớp, viêm nhiễm');
INSERT INTO THUOC(TENTHUOC,DONVITINH,LOAITHUOC,SOLUONGTON,GHICHU) 
VALUES(N'Thuốc Colocol 500mg',1,1,50,N'Số đăng ký: VD-1999-06 Dạng bào chế: viên nén Quy cách đóng gói: Hộp 6 vỉ x 10 viên Công ty đăng ký: Công ty TNHH Sao Kim Thành phần:Paracetamol: 500mg Chỉ định: Điều trị triệu chứng các cơn đau vừa và nhẹ, các trạng thái sốt. Chống chỉ định: – Mẫn cảm với thuốc');
INSERT INTO THUOC(TENTHUOC,DONVITINH,LOAITHUOC,SOLUONGTON,GHICHU) 
VALUES(N'Thuốc Vinsamin 250mg',1,3,100,N'Số đăng ký: VNA-1273-03 Dạng bào chế: viên nang Quy cách đóng gói: Hộp 9 vỉ x 10 viên Công ty đăng ký: Xí nghiệp dược phẩm trung ương 1 Thành phần:Glucosamin: 250mg Chỉ định: Tất cả các bệnh thoái hóa xương khớp, thoái khớp nguyên phát và thứ phát như thoái khớp gối, háng,');
INSERT INTO THUOC(TENTHUOC,DONVITINH,LOAITHUOC,SOLUONGTON,GHICHU) 
VALUES(N'Thuốc Digelase',1,1,100,N'Số đăng ký: VNB-1204-03 Dạng bào chế: viên nang mềm Quy cách đóng gói: Hộp 10 vỉ x 10 viên Công ty đăng ký: Công ty TNHH SPM Thành phần:Pancreatin: 176mg Chỉ định: Điều trị các chứng bệnh đường tiêu hóa: ăn không tiêu, biếng ăn…chướng bụng, đầy hơi, các rối loạn hấp thu dinh');
INSERT INTO THUOC(TENTHUOC,DONVITINH,LOAITHUOC,SOLUONGTON,GHICHU) 
VALUES(N'Thuốc Rutin Vitamin C',1,4,100,N'Số đăng ký: VNB-3859-05 Dạng bào chế: viên nén bao đường Quy cách đóng gói: Hộp 10 vỉ x 10 viên Công ty đăng ký: Công ty cổ phần hoá dược phẩm Mekophar Thành phần:Acid ascorbic: 50mg Chỉ định: Điều trị hội chứng chảy máu, xơ cứng, tăng huyết áp, ban xuất huyết, chứng giãn');
INSERT INTO THUOC(TENTHUOC,DONVITINH,LOAITHUOC,SOLUONGTON,GHICHU) 
VALUES(N'Thuốc Tetracycline 500mg',1,5,100,N'Số đăng ký: VNA-3694-00 Dạng bào chế: viên nang Quy cách đóng gói: Hộp 10 vỉ x 10 viên Công ty đăng ký: Công ty cổ phần hoá dược phẩm Mekophar Thành phần:Tetracyclin: 500mg Chỉ định: Điều trị các nhiễm khuẩn do Chlamydia, Rickettsia, lậu cầu, xoắn khuẩn, tả, nhất là các nhiễm khuẩn đường');
INSERT INTO THUOC(TENTHUOC,DONVITINH,LOAITHUOC,SOLUONGTON,GHICHU) 
VALUES(N'Thuốc Metrogyl Gel 10mg',3,5,100,N'Số đăng ký: vn-1555-06 Dạng bào chế: Gel màu trắng Quy cách đóng gói: Tube nhôm 20g Công ty đăng ký: Unique Pharmaceutical Laboratories Thành phần:Metronidazole: 10mg Chỉ định: Metrogyl Denta được chỉ định điều trị: viêm nha chu mãn tính, sâu răng, viêm nướu răng, viêm ống tủy răng. Viêm loét miệng, hôi miệng');
INSERT INTO THUOC(TENTHUOC,DONVITINH,LOAITHUOC,SOLUONGTON,GHICHU) 
VALUES(N'Thuốc Tmotol 0.5%',4,7,100,N'Số đăng ký: VNA-3606-05 Dạng bào chế: dung dịch tra mắt Quy cách đóng gói: Hộp 1 lọ 10ml Công ty đăng ký: Công ty dược trang thiết bị y tế Bình Định Thành phần:Timolol: 50mg Chỉ định: Làm giảm nhãn áp ở người bệnh tăng nhãn áp hoặc glôccôm góc mở. ');
INSERT INTO THUOC(TENTHUOC,DONVITINH,LOAITHUOC,SOLUONGTON,GHICHU) 
VALUES(N'Thuốc Symbicort Turbuhaler-160/4,5mcg',4,8,100,N'Số đăng ký: VN-1583-06 Dạng bào chế: Thuốc bột để hít Quy cách đóng gói: Hộp 1 ống hít 60 liều Công ty đăng ký: AstraZeneca Singapore Pte., Ltd. Thành phần:Budesonide: 160mcg Chỉ định: – Điều trị thường xuyên bệnh hen. – Bệnh nhân không được kiểm soát tốt với corticosteroid dạng hít và chất');
INSERT INTO THUOC(TENTHUOC,DONVITINH,LOAITHUOC,SOLUONGTON,GHICHU) 
VALUES(N'Thuốc Topsukan 80mg',2,9,100,N'Số đăng ký: VN-0814-06 Dạng bào chế: Viên nén bao phim Quy cách đóng gói: Hộp 10 vỉ x 10 viên Công ty đăng ký: Công ty TNHH Dược phẩm Toàn Chân Thành phần:Cao bạch quả Chỉ định: – Giảm trí nhớ, kém tập trung, đặc biệt ở người lớn tuổi. – Thiểu năng tuần');
GO

---22. BANG DON THUOC --------

INSERT INTO DONTHUOC(MAPHIEUKHAM,TONGCONG) VALUES(1,'');
INSERT INTO DONTHUOC(MAPHIEUKHAM,TONGCONG) VALUES(2,'');
INSERT INTO DONTHUOC(MAPHIEUKHAM,TONGCONG) VALUES(3,'');
INSERT INTO DONTHUOC(MAPHIEUKHAM,TONGCONG) VALUES(4,'');
INSERT INTO DONTHUOC(MAPHIEUKHAM,TONGCONG) VALUES(5,'');
INSERT INTO DONTHUOC(MAPHIEUKHAM,TONGCONG) VALUES(6,'');
INSERT INTO DONTHUOC(MAPHIEUKHAM,TONGCONG) VALUES(7,'');
INSERT INTO DONTHUOC(MAPHIEUKHAM,TONGCONG) VALUES(8,'');
INSERT INTO DONTHUOC(MAPHIEUKHAM,TONGCONG) VALUES(9,'')
GO


---23. BANG CHI TIET DON THUOC --------


INSERT INTO CHITIETDONTHUOC(MADONTHUOC,MATHUOC,SOLUONG,HUONGDAN) VALUES(1,1,30,N'UỐNG MỘT NGÀY 2 LẦN SÁNG CHIỀU');
INSERT INTO CHITIETDONTHUOC(MADONTHUOC,MATHUOC,SOLUONG,HUONGDAN) VALUES(2,4,10,N'UỐNG MỘT NGÀY 3 LẦN ');
INSERT INTO CHITIETDONTHUOC(MADONTHUOC,MATHUOC,SOLUONG,HUONGDAN) VALUES(3,3,30,N'UỐNG MỘT NGÀY 2 LẦN ');
INSERT INTO CHITIETDONTHUOC(MADONTHUOC,MATHUOC,SOLUONG,HUONGDAN) VALUES(4,5,20,N'UỐNG MỘT NGÀY 2 LẦN SÁNG CHIỀU');
INSERT INTO CHITIETDONTHUOC(MADONTHUOC,MATHUOC,SOLUONG,HUONGDAN) VALUES(5,6,10,N'UỐNG MỘT NGÀY 3 LẦN');
INSERT INTO CHITIETDONTHUOC(MADONTHUOC,MATHUOC,SOLUONG,HUONGDAN) VALUES(6,3,40,N'UỐNG MỘT NGÀY 2 LẦN SÁNG CHIỀU');
INSERT INTO CHITIETDONTHUOC(MADONTHUOC,MATHUOC,SOLUONG,HUONGDAN) VALUES(7,5,20,N'UỐNG MỘT NGÀY 2 LẦN SÁNG CHIỀU');
INSERT INTO CHITIETDONTHUOC(MADONTHUOC,MATHUOC,SOLUONG,HUONGDAN) VALUES(8,7,30,N'UỐNG MỘT NGÀY 2 LẦN SÁNG CHIỀU');
INSERT INTO CHITIETDONTHUOC(MADONTHUOC,MATHUOC,SOLUONG,HUONGDAN) VALUES(9,4,15,N'UỐNG MỘT NGÀY 2 LẦN SÁNG CHIỀU')

----24. BANG CHI TIET PHIEU NHAP THUOC----

INSERT INTO CHITIETPHIEUNHAPTHUOC(MAPHIEUNHAP,MATHUOC,SOLUONG,NGAYSX,NGAYHETHAN,GIANHAP,GIABANLE,MAHSX,MANHACC) 
VALUES(1,1,100,'2017-08-11','2019-08-11','1200000','15000',1,1);
INSERT INTO CHITIETPHIEUNHAPTHUOC(MAPHIEUNHAP,MATHUOC,SOLUONG,NGAYSX,NGAYHETHAN,GIANHAP,GIABANLE,MAHSX,MANHACC) 
VALUES(2,2,100,'2017-08-11','2020-08-11','2000000','25000',2,2);
INSERT INTO CHITIETPHIEUNHAPTHUOC(MAPHIEUNHAP,MATHUOC,SOLUONG,NGAYSX,NGAYHETHAN,GIANHAP,GIABANLE,MAHSX,MANHACC) 
VALUES(3,3,200,'2017-08-12','2020-08-12','4000000','45000',3,3);
INSERT INTO CHITIETPHIEUNHAPTHUOC(MAPHIEUNHAP,MATHUOC,SOLUONG,NGAYSX,NGAYHETHAN,GIANHAP,GIABANLE,MAHSX,MANHACC) 
VALUES(4,4,500,'2017-08-13','2019-08-13','5000000','15000',4,4);
INSERT INTO CHITIETPHIEUNHAPTHUOC(MAPHIEUNHAP,MATHUOC,SOLUONG,NGAYSX,NGAYHETHAN,GIANHAP,GIABANLE,MAHSX,MANHACC) 
VALUES(5,5,400,'2017-08-11','2020-08-11','4000000','15000',5,5);
INSERT INTO CHITIETPHIEUNHAPTHUOC(MAPHIEUNHAP,MATHUOC,SOLUONG,NGAYSX,NGAYHETHAN,GIANHAP,GIABANLE,MAHSX,MANHACC) 
VALUES(6,6,600,'2017-08-14','2020-08-14','6000000','25000',6,6);
INSERT INTO CHITIETPHIEUNHAPTHUOC(MAPHIEUNHAP,MATHUOC,SOLUONG,NGAYSX,NGAYHETHAN,GIANHAP,GIABANLE,MAHSX,MANHACC) 
VALUES(7,7,800,'2017-08-13','2019-08-13','8000000','20000',2,7);
INSERT INTO CHITIETPHIEUNHAPTHUOC(MAPHIEUNHAP,MATHUOC,SOLUONG,NGAYSX,NGAYHETHAN,GIANHAP,GIABANLE,MAHSX,MANHACC) 
VALUES(8,8,300,'2017-08-12','2020-08-12','3000000','15000',5,8);
INSERT INTO CHITIETPHIEUNHAPTHUOC(MAPHIEUNHAP,MATHUOC,SOLUONG,NGAYSX,NGAYHETHAN,GIANHAP,GIABANLE,MAHSX,MANHACC) 
VALUES(9,9,500,'2017-08-11','2019-08-11','1200000','20000',3,9);
INSERT INTO CHITIETPHIEUNHAPTHUOC(MAPHIEUNHAP,MATHUOC,SOLUONG,NGAYSX,NGAYHETHAN,GIANHAP,GIABANLE,MAHSX,MANHACC) 
VALUES(10,10,200,'2017-08-11','2020-08-11','10000000','55000',6,10)
GO

--25 bảng phanquyen



INSERT INTO dbo.PHANQUYEN (QUYEN, GHICHU) VALUES (1, N'Admin')
INSERT INTO dbo.PHANQUYEN (QUYEN, GHICHU) VALUES (2, N'Bác Sĩ')
INSERT INTO dbo.PHANQUYEN (QUYEN, GHICHU) VALUES (3, N'Y tá')
INSERT INTO dbo.PHANQUYEN (QUYEN, GHICHU) VALUES (4, N'Kế toán')
GO

-- 26 bảng tài khoản



INSERT INTO dbo.TAIKHOAN ( MANV ,TENDANGNHAP ,MATKHAU , TENHIENTHI , MAPHANQUYEN , TRANGTHAI )VALUES  ( 1,'admin' , '1' , N'Admin' , 1,1 )
INSERT INTO dbo.TAIKHOAN ( MANV ,TENDANGNHAP ,MATKHAU , TENHIENTHI , MAPHANQUYEN , TRANGTHAI )VALUES  ( 2,'bacsi' , '1' , N'Bác sĩ' , 2,1 )
INSERT INTO dbo.TAIKHOAN (MANV , TENDANGNHAP ,MATKHAU , TENHIENTHI , MAPHANQUYEN , TRANGTHAI )VALUES  ( 4,'yta' , '1' , N'Y tá' , 3,1 )
INSERT INTO dbo.TAIKHOAN ( MANV ,TENDANGNHAP ,MATKHAU , TENHIENTHI , MAPHANQUYEN , TRANGTHAI )VALUES  ( 3,'ketoan' , '1' , N'Kế toán' , 4,1 )


GO
SELECT * FROM dbo.TAIKHOAN
GO
