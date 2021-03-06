﻿USE quanlyphongkham_final
GO

-------------------STORE-PROCEDURE----------------------------------------

--1. Bảng PHANQUYEN
--1.1 SP_INSERT_PHANQUYEN
CREATE PROC SP_INSERT_PHANQUYEN
@QUYEN INT,
@GHICHU NVARCHAR(250)
AS
BEGIN
	INSERT dbo.PHANQUYEN
	        ( QUYEN, GHICHU )
	VALUES  ( @QUYEN, -- QUYEN - int
	          @GHICHU  -- GHICHU - nvarchar(250)
	          )
END
GO



--2. BẢNG TAIKHOAN
--2.1 SPINSERT_TAIKHOAN
DROP PROC dbo.SP_INSERT_TAIKHOAN
GO
CREATE PROC SP_INSERT_TAIKHOAN
	@TENDANGNHAP VARCHAR(50),
	@MATKHAU VARCHAR(50),
	@TENHIENTHI NVARCHAR(50),
	@MAPHANQUYEN int,
	@TRANGTHAI BIT
AS
BEGIN
	INSERT dbo.TAIKHOAN 
	        ( TENDANGNHAP ,
	          MATKHAU ,
	          TENHIENTHI ,
	          MAPHANQUYEN ,
	          TRANGTHAI
	        )
	VALUES  ( @TENDANGNHAP , -- TENDANGNHAP - varchar(50)
	          @MATKHAU , -- MATKHAU - varchar(50)
	          @TENHIENTHI , -- TENHIENTHI - nvarchar(50)
	          @MAPHANQUYEN , -- MAPHANQUYEN - int
	          @TRANGTHAI  -- TRANGTHAI - bit
	        )
END
GO


--2.2 SP_LOGIN

Drop PROC SP_LOGIN
GO

CREATE PROC SP_LOGIN
	@TenDangNhap VARCHAR(50),
	@MatKhau VARCHAR(50)
AS
BEGIN
	--SELECT dbo.FN_Login(@TenDangNhap,@MatKhau)
	SELECT T.MATK, T.MANV,T.TENDANGNHAP,T.MATKHAU,T.TENHIENTHI, P.QUYEN AS 'MAPHANQUYEN' , T.TRANGTHAI
	FROM TAIKHOAN T JOIN PHANQUYEN P ON T.MAPHANQUYEN = P.MAPHANQUYEN 
	WHERE T.TENDANGNHAP = @TENDANGNHAP AND T.MATKHAU = @MatKhau AND T.TRANGTHAI = 1 
END
GO

EXECUTE dbo.SP_LOGIN @TenDangNhap = 'bacsi', -- varchar(50)
    @MatKhau = '1' -- varchar(50)

GO
SELECT * FROM dbo.TAIKHOAN 
GO






--Bảng 3 BENHNHAN


--3.1  SP_DanhSachBenhNhan
DROP  PROC SP_DanhSachBenhNhan
GO

CREATE  PROC SP_DanhSachBenhNhan
AS
BEGIN
	SELECT	*
	FROM dbo.BENHNHAN
END
GO

EXEC dbo.SP_DanhSachBenhNhan
GO




 
-- 3.2 SP_TimKiemBenhNhan
DROP PROC SP_TimKiemBenhNhan_fTIepNhanBenhNhan
GO

CREATE PROC SP_TimKiemBenhNhan_fTIepNhanBenhNhan
	@TruongDuLieu VARCHAR(20),
	@ThongTin NVARCHAR(250)
 AS
 BEGIN 

	IF @TruongDuLieu = 'HOTEN'  SELECT * FROM dbo.BENHNHAN WHERE  HOTEN LIKE '%'+@ThongTin+'%'; 
	IF @TruongDuLieu = 'MABN'  SELECT * FROM dbo.BENHNHAN WHERE  MABN LIKE '%'+@ThongTin+'%';
	IF @TruongDuLieu = 'SODT'  SELECT * FROM dbo.BENHNHAN WHERE  SODT LIKE '%'+@ThongTin+'%';
	IF @TruongDuLieu = 'SOCMND'  SELECT * FROM dbo.BENHNHAN WHERE  SOCMND LIKE '%'+@ThongTin+'%';
	IF @TruongDuLieu = '*' SELECT * FROM dbo.BENHNHAN;
 END
 GO



 



 --- sp them benh nhan

 DROP PROC SP_InsertBenhNhan
 GO
 
 CREATE PROC SP_InsertBenhNhan
	@HOTEN nvarchar(50),
	@GIOITINH  BIT,
	@NGAYSINH  DATE,
	@DANTOC  nvarchar(50),
	@SOCMND  nvarchar(20),
	@DIACHI  nvarchar(250),
	@SODT  varchar(20),
	@TIENSU  nvarchar(250)
 AS
 BEGIN TRAN
	BEGIN TRY
		IF	@HOTEN = ''
		BEGIN
			PRINT N'Họ tên không được rỗng!'
			ROLLBACK TRAN
			RETURN 1
		END
        IF	@GIOITINH NOT IN (1,0) OR @GIOITINH IS NULL
		BEGIN
			PRINT N'Giới tính chỉ nhận giá trị 0 và 1 và not null!'
			ROLLBACK TRAN
			RETURN 1
		END
		IF	@DANTOC = ''
		BEGIN
			PRINT N'Dân tộc không được rỗng!'
			ROLLBACK TRAN
			RETURN 1
		END
		IF	@DIACHI = ''
		BEGIN
			PRINT N'Địa chỉ không được rỗng!'
			ROLLBACK TRAN
			RETURN 1
		END
		IF	@SODT = ''
		BEGIN
			PRINT N'Số điện thoại không được rỗng!'
			ROLLBACK TRAN
			RETURN 1
		END
		IF	@SOCMND = ''
		BEGIN
			PRINT N'Số chứng minh nhân dân không được rỗng!'
			ROLLBACK TRAN
			RETURN 1
		END
		IF	@TIENSU = ''
		BEGIN
			PRINT N'Tiền sử không được rỗng!'
			ROLLBACK TRAN
			RETURN 1
		END
	
	INSERT INTO dbo.BENHNHAN
	        ( HOTEN ,
	          GIOITINH ,
	          NGAYSINH ,
	          DANTOC ,
	          SOCMND ,
	          DIACHI ,
	          SODT ,
	          TIENSU
	        )
	VALUES  ( @HOTEN ,  @GIOITINH ,  @NGAYSINH ,   @DANTOC , @SOCMND ,  @DIACHI , @SODT ,  @TIENSU )
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		ROLLBACK TRAN
		RETURN 1
	END CATCH
	PRINT N'Thêm bệnh nhân thành công'
	COMMIT TRAN
	RETURN 0
 GO

 EXEC dbo.SP_InsertBenhNhan @HOTEN = N'123', -- nvarchar(50)
     @GIOITINH = 'gioitinh', -- bit
     @NGAYSINH = '2017-12-16 09:29:25', -- date
     @DANTOC = N'1', -- nvarchar(50)
     @SOCMND = N'1', -- nvarchar(20)
     @DIACHI = N'1', -- nvarchar(250)
     @SODT = '1', -- varchar(20)
     @TIENSU = N'1' -- nvarchar(250)
 DELETE dbo.BENHNHAN WHERE GIOITINH NOT IN (0,1)

 SELECT * FROM dbo.BENHNHAN
 GO
 
 -- SP_UPDATE_BENHNHAN
 DROP PROC SP_UpdateBenhNhan
 GO
 
CREATE PROC SP_UpdateBenhNhan
	@MABN INT,
	@HOTEN NVARCHAR(50),
	@GIOITINH BIT,
	@NGAYSINH DATE,
	@DANTOC NVARCHAR(50),
	@SOCMND NVARCHAR(20),
	@DIACHI NVARCHAR(250),
	@SODT VARCHAR(20),
	@TIENSU NVARCHAR(250)
AS
BEGIN
	UPDATE  dbo.BENHNHAN  SET   HOTEN = @HOTEN , GIOITINH = @GIOITINH, NGAYSINH = @NGAYSINH,  DANTOC = @DANTOC,
								SOCMND = @SOCMND, DIACHI = @DIACHI , SODT = @SODT , TIENSU = @TIENSU
	    
				WHERE MABN = @MABN
				
END
GO


 

 -- sp danhsach nhanvien
 DROP PROC SP_DanhSachNhanVien
 GO

 CREATE PROC SP_DanhSachNhanVien
 AS
 BEGIN
	SELECT * FROM dbo.NHANVIEN
 END
 GO
 

 

 --sp danh sach hinh thuc kham
  DROP PROC SP_DanhSachHinhThucKham
  GO
  
 CREATE PROC SP_DanhSachHinhThucKham
 AS
 BEGIN
	SELECT * FROM dbo.HINHTHUCKHAM
 END
 GO



DROP PROC SP_DanhSachKham_fKhamBenNhan 
GO

CREATE PROC SP_DanhSachKham_fKhamBenNhan
 @NgayKham DATE
AS
BEGIN
		SELECT	P.MAPHIEUKHAM,B.MABN,B.HOTEN,convert(varchar, P.NGAYKHAM, 103) AS NGAYKHAM,B.SOCMND,B.SODT, B.DANTOC, P.KETLUAN,convert(varchar, B.NGAYSINH, 103) AS NGAYSINH,		 
				B.GIOITINH, B.DIACHI,H.TENHINHTHUCKHAM, P.CHUANDOAN, N.HOTEN AS 'BACSI'
		FROM dbo.PHIEUKHAM P JOIN dbo.BENHNHAN B ON B.MABN = P.MABN JOIN dbo.NHANVIEN N ON N.MANV = P.MANV 
		JOIN dbo.HINHTHUCKHAM H ON H.MAHINHTHUCKHAM = P.MAHINHTHUCKHAM
		WHERE P.NGAYKHAM = @NgayKham AND P.HOANTHANH = 0
END 
GO


EXECUTE dbo.SP_DanhSachKham_fKhamBenNhan
 @NgayKham = '2017-11-30 ' -- date


-- code cho phần thêm phiếu khám, hủy phiếu khám, và cập nhật phiếu khám
DROP PROC InsertPhieuKham
GO

CREATE PROC InsertPhieuKham
		 @MABN  INT,
         @MANV  INT,
		 @NVTIEPNHAN INT,
         @CHUANDOAN  nvarchar(250),
         @MAHINHTHUCKHAM  INT
AS
BEGIN
	INSERT INTO dbo.PHIEUKHAM( MABN, MANV, NVTIEPNHAN, CHUANDOAN, MAHINHTHUCKHAM ,HOANTHANH)  
	VALUES  ( @MABN ,  @MANV ,  @NVTIEPNHAN, @CHUANDOAN , @MAHINHTHUCKHAM ,0 )
	
END
GO



--sp dbo.HuyKham @MAPHIEUKHAM , @nhanvien

DROP PROC HuyKham 
GO 

CREATE PROC HuyKham 
	@MAPHIEUKHAM INT ,
	 @nhanvien INT 
AS
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ 
BEGIN TRAN 
	UPDATE dbo.PHIEUKHAM SET HOANTHANH = -1 , NVTIEPNHAN = @nhanvien WHERE MAPHIEUKHAM = @MAPHIEUKHAM
COMMIT TRAN
GO

--SP_UpdatePhieuKham @MAPHIEUKHAM , @MANV , @NVTIEPNHAN , @CHUANDOAN , @MAHINHTHUCKHAM

DROP PROC  SP_UpdatePhieuKham 
GO
CREATE PROC SP_UpdatePhieuKham
	 @MAPHIEUKHAM INT ,
	  @MANV INT , 
	  @NVTIEPNHAN INT , 
	  @CHUANDOAN NVARCHAR(250),
	   @MAHINHTHUCKHAM INT 
 AS
 SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
	UPDATE dbo.PHIEUKHAM SET MANV =@MANV , NVTIEPNHAN = @NVTIEPNHAN , CHUANDOAN = @CHUANDOAN , MAHINHTHUCKHAM = @MAHINHTHUCKHAM WHERE MAPHIEUKHAM = @MAPHIEUKHAM
COMMIT TRAN 
GO








-- LICH SỬ KHÁM
-- SP_LOADLICHSUKHAMBYID
DROP PROC SP_LoadLichSuTiepNhanByID 
GO

CREATE PROC SP_LoadLichSuTiepNhanByID
	@MANV INT
AS
BEGIN
	SELECT	P.MAPHIEUKHAM, B.MABN,B.HOTEN, convert(varchar, P.NGAYKHAM, 103) AS NGAYKHAM,B.SOCMND,B.SODT, B.DANTOC, P.KETLUAN,convert(varchar, B.NGAYSINH, 103) AS NGAYSINH,		 
				B.GIOITINH, B.DIACHI,H.TENHINHTHUCKHAM, P.CHUANDOAN, N.HOTEN AS 'BACSI'
		FROM dbo.PHIEUKHAM P JOIN dbo.BENHNHAN B ON B.MABN = P.MABN JOIN dbo.NHANVIEN N ON N.MANV = P.MANV 
		JOIN dbo.HINHTHUCKHAM H ON H.MAHINHTHUCKHAM = P.MAHINHTHUCKHAM
		WHERE P.NVTIEPNHAN = @MANV
END

GO
	


--SP TimKiemLichSuTiepNhan
DROP  PROC TimKiemLichSuTiepNhan
GO

CREATE PROC TimKiemLichSuTiepNhan
	@MaNV INT,
	@TruongDuLieu VARCHAR(20),
	@ThongTin NVARCHAR(250)
 AS
 BEGIN 
	IF @TruongDuLieu = 'HOTEN'  
		SELECT	P.MAPHIEUKHAM, B.MABN,B.HOTEN, convert(varchar, P.NGAYKHAM, 103) AS NGAYKHAM,B.SOCMND,B.SODT, B.DANTOC, P.KETLUAN,convert(varchar, B.NGAYSINH, 103) AS NGAYSINH,		 
				B.GIOITINH, B.DIACHI,H.TENHINHTHUCKHAM, P.CHUANDOAN, N.HOTEN AS 'BACSI'
		FROM dbo.PHIEUKHAM P JOIN dbo.BENHNHAN B ON B.MABN = P.MABN JOIN dbo.NHANVIEN N ON N.MANV = P.MANV 
		JOIN dbo.HINHTHUCKHAM H ON H.MAHINHTHUCKHAM = P.MAHINHTHUCKHAM
		WHERE P.NVTIEPNHAN = @MANV AND   B.HOTEN LIKE '%'+@ThongTin+'%'; 
	IF @TruongDuLieu = 'MABN'  
		SELECT	P.MAPHIEUKHAM, B.MABN,B.HOTEN, convert(varchar, P.NGAYKHAM, 103) AS NGAYKHAM,B.SOCMND,B.SODT, B.DANTOC, P.KETLUAN,convert(varchar, B.NGAYSINH, 103) AS NGAYSINH,		 
				B.GIOITINH, B.DIACHI,H.TENHINHTHUCKHAM, P.CHUANDOAN, N.HOTEN AS 'BACSI'
		FROM dbo.PHIEUKHAM P JOIN dbo.BENHNHAN B ON B.MABN = P.MABN JOIN dbo.NHANVIEN N ON N.MANV = P.MANV 
		JOIN dbo.HINHTHUCKHAM H ON H.MAHINHTHUCKHAM = P.MAHINHTHUCKHAM
		WHERE P.NVTIEPNHAN = @MANV AND   B.MABN LIKE '%'+@ThongTin+'%';
	IF @TruongDuLieu = 'SODT' 
		SELECT	P.MAPHIEUKHAM, B.MABN,B.HOTEN, convert(varchar, P.NGAYKHAM, 103) AS NGAYKHAM,B.SOCMND,B.SODT, B.DANTOC, P.KETLUAN,convert(varchar, B.NGAYSINH, 103) AS NGAYSINH,		 
				B.GIOITINH, B.DIACHI,H.TENHINHTHUCKHAM, P.CHUANDOAN, N.HOTEN AS 'BACSI'
		FROM dbo.PHIEUKHAM P JOIN dbo.BENHNHAN B ON B.MABN = P.MABN JOIN dbo.NHANVIEN N ON N.MANV = P.MANV 
		JOIN dbo.HINHTHUCKHAM H ON H.MAHINHTHUCKHAM = P.MAHINHTHUCKHAM
		WHERE P.NVTIEPNHAN = @MANV AND   B.SODT LIKE '%'+@ThongTin+'%';
		
	IF @TruongDuLieu = 'SOCMND'  
		SELECT	P.MAPHIEUKHAM, B.MABN,B.HOTEN, convert(varchar, P.NGAYKHAM, 103) AS NGAYKHAM,B.SOCMND,B.SODT, B.DANTOC, P.KETLUAN,convert(varchar, B.NGAYSINH, 103) AS NGAYSINH,		 
				B.GIOITINH, B.DIACHI,H.TENHINHTHUCKHAM, P.CHUANDOAN, N.HOTEN AS 'BACSI'
		FROM dbo.PHIEUKHAM P JOIN dbo.BENHNHAN B ON B.MABN = P.MABN JOIN dbo.NHANVIEN N ON N.MANV = P.MANV 
		JOIN dbo.HINHTHUCKHAM H ON H.MAHINHTHUCKHAM = P.MAHINHTHUCKHAM
		WHERE P.NVTIEPNHAN = @MANV AND   B.SOCMND LIKE '%'+@ThongTin+'%';
	IF @TruongDuLieu = 'NGAYKHAM'
		SELECT	P.MAPHIEUKHAM, B.MABN,B.HOTEN, convert(varchar, P.NGAYKHAM, 103) AS NGAYKHAM,B.SOCMND,B.SODT, B.DANTOC, P.KETLUAN,convert(varchar, B.NGAYSINH, 103) AS NGAYSINH,		 
				B.GIOITINH, B.DIACHI,H.TENHINHTHUCKHAM, P.CHUANDOAN, N.HOTEN AS 'BACSI'
		FROM dbo.PHIEUKHAM P JOIN dbo.BENHNHAN B ON B.MABN = P.MABN JOIN dbo.NHANVIEN N ON N.MANV = P.MANV 
		JOIN dbo.HINHTHUCKHAM H ON H.MAHINHTHUCKHAM = P.MAHINHTHUCKHAM
		WHERE P.NVTIEPNHAN = @MANV AND   P.NGAYKHAM LIKE '%'+@ThongTin+'%';
END
 GO





 --SP CHO FTHUNGAN

-- lấy ra danh sách đơn thuốc của ngày hiện tại

DROP PROC SP_DANHSACHDONTHUOC
GO

CREATE PROC SP_DANHSACHDONTHUOC
	@NGAYKHAM VARCHAR(10)
AS
BEGIN 
	SELECT D.MADONTHUOC, B.MABN, B.HOTEN,B.GIOITINH,convert(varchar, B.NGAYSINH, 103) AS 'NGAYSINH',D.TONGCONG,D.TINHTRANG AS 'TRANGTHAI'
	FROM dbo.PHIEUKHAM P JOIN dbo.DONTHUOC D ON D.MAPHIEUKHAM = P.MAPHIEUKHAM JOIN dbo.BENHNHAN B ON B.MABN = P.MABN
	WHERE P.NGAYKHAM = @NGAYKHAM AND D.TINHTRANG = 0 
END
GO

EXEC dbo.SP_DANHSACHDONTHUOC @NGAYKHAM = '2017-12-13' -- varchar(10)
GO


--proc thu phí đơn thuốc
DROP PROC SP_THUPHIDONTHUOC
GO

CREATE PROC SP_THUPHIDONTHUOC
 @MADONTHUOC INT,
 @MANV INT 
 
AS
BEGIN
	UPDATE dbo.DONTHUOC SET TINHTRANG = 1 , NGUOITHU = @MANV WHERE MADONTHUOC = @MADONTHUOC
END
GO

EXEC dbo.SP_THUPHIDONTHUOC @MANV = 0, -- int
    @MADONTHUOC =2 -- int
GO


--PROC LOAD DANH SACH DICH VU CLS
DROP  PROC SP_DANHSACHDVCLS 
GO

CREATE PROC SP_DANHSACHDVCLS 
AS
BEGIN
SELECT CT.MADICHVUCLS,B.MABN,B.HOTEN,B.GIOITINH,convert(varchar, B.NGAYSINH, 103) AS 'NGAYSINH', CLS.TENCLS, DV.TINHTRANG,DV.TONGCONG
FROM dbo.CHITIETCLS CT JOIN dbo.DICHVUCLS DV ON  DV.MADICHVUCLS = CT.MADICHVUCLS 
JOIN dbo.PHIEUKHAM P ON P.MAPHIEUKHAM = DV.MAPHIEUKHAM
JOIN dbo.BENHNHAN B ON B.MABN = P.MABN
JOIN dbo.CANLAMSANG CLS ON CLS.MACLS = CT.MACLS
WHERE DV.TINHTRANG = 0
END
GO

EXEC dbo.SP_DANHSACHDVCLS
GO


--SP_THUPHIDVCLS
DROP PROC SP_THUPHIDVCLS
GO
CREATE PROC SP_THUPHIDVCLS
	@MADV INT,
	@MANV INT
AS
BEGIN
	UPDATE dbo.DICHVUCLS SET TINHTRANG = 1, NGUOITHU = @MANV WHERE MADICHVUCLS = @MADV
END
GO

EXEC dbo.SP_THUPHIDVCLS @MADV , @MANV 
GO

SELECT * FROM dbo.DICHVUCLS
GO

--SP_DanhSachThuoc
DROP  PROC SP_DanhSachThuoc
GO

CREATE PROC SP_DanhSachThuoc
AS
BEGIN 
SELECT T.MATHUOC,T.TENTHUOC, T.SOLUONGTON, DVT.TENDVT,LT.TENLOAI
FROM dbo.THUOC T JOIN dbo.LOAITHUOC LT ON LT.MALOAITHUOC = T.LOAITHUOC JOIN dbo.DONVITINH DVT ON DVT.MADVT = T.DONVITINH
END 
GO

EXEC dbo.SP_DanhSachThuoc
GO

--sptimkiem thuoc admin

DROP PROC SP_Admin_TimKiemThuoc
GO
CREATE  PROC SP_Admin_TimKiemThuoc
	@info NVARCHAR(250),
	@column NCHAR(10)
AS
BEGIN
	IF	@column = 'TENTHUOC' 
		SELECT T.MATHUOC,T.TENTHUOC, T.SOLUONGTON, DVT.TENDVT,LT.TENLOAI
		FROM dbo.THUOC T JOIN dbo.LOAITHUOC LT ON LT.MALOAITHUOC = T.LOAITHUOC JOIN dbo.DONVITINH DVT ON DVT.MADVT = T.DONVITINH
		WHERE TENTHUOC LIKE '%'+@info+'%'
    IF	@column = 'MATHUOC' 
		SELECT T.MATHUOC,T.TENTHUOC, T.SOLUONGTON, DVT.TENDVT,LT.TENLOAI
		FROM dbo.THUOC T JOIN dbo.LOAITHUOC LT ON LT.MALOAITHUOC = T.LOAITHUOC JOIN dbo.DONVITINH DVT ON DVT.MADVT = T.DONVITINH
		WHERE MATHUOC LIKE '%'+@info+'%'
END
GO

--EXEC dbo.SP_Admin_TimKiemThuoc @info ,  @column 
GO


--SP_ChiTietThuoc
DROP PROC SP_ChiTietThuoc
GO

CREATE PROC SP_ChiTietThuoc
	@mathuoc INT 
AS
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN 
SELECT  T.MATHUOC, T.TENTHUOC,CTPN.MAPHIEUNHAP,CTPN.SOLUONG,
		convert(varchar, PN.NGAYNHAP, 103) AS 'NGAYNHAP',
		CONVERT(varchar, CTPN.NGAYSX, 103) AS 'NGAYSX',
		CONVERT(varchar, CTPN.NGAYHETHAN, 103) AS 'NGAYHETHAN',
		CTPN.GIANHAP,CTPN.GIABANLE ,HSX.TENHSX,NCC.TENNHACC
FROM dbo.CHITIETPHIEUNHAPTHUOC CTPN JOIN dbo.PHIEUNHAP PN ON PN.MAPHIEUNHAP = CTPN.MAPHIEUNHAP
	JOIN dbo.THUOC T ON T.MATHUOC = CTPN.MATHUOC
	JOIN dbo.HANGSANXUAT HSX ON HSX.MAHSX = CTPN.MAHSX
	JOIN dbo.NHACUNGCAP NCC ON NCC.MANHACC = CTPN.MANHACC
	WHERE CTPN.MATHUOC = @mathuoc
END 
GO


EXEC dbo.SP_ChiTietThuoc @mathuoc = 1 -- int

GO

SELECT * FROM dbo.CHITIETPHIEUNHAPTHUOC
GO


SELECT * FROM dbo.PHIEUNHAP
GO


SELECT * FROM dbo.THUOC
GO

--SP_DanhSachDonViTinh
DROP PROC SP_DanhSachDonViTinh
GO
CREATE PROC SP_DanhSachDonViTinh
AS
BEGIN
SELECT * FROM dbo.DONVITINH
END
GO

EXEC dbo.SP_DanhSachDonViTinh
GO


--SP_DanhSachLoaiThuoc
DROP PROC SP_DanhSachLoaiThuoc
GO
CREATE PROC SP_DanhSachLoaiThuoc
AS
BEGIN
	SELECT * FROM dbo.LOAITHUOC
END
GO

EXEC dbo.SP_DanhSachLoaiThuoc 
GO

--SP_InserThuoc
DROP PROC SP_InserThuoc
GO

CREATE PROC SP_InserThuoc
	
	@TenThuoc NVARCHAR(250),
	@LoaiThuoc INT ,
	@DonViTinh INT ,
	@SoLuongTon INT, 
	@GhiChu NVARCHAR(250)
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
	INSERT INTO dbo.THUOC( TENTHUOC , DONVITINH , LOAITHUOC ,SOLUONGTON ,GHICHU)
	VALUES  ( @TenThuoc,	@DonViTinh ,@LoaiThuoc ,@SoLuongTon ,@GhiChu  )
	COMMIT TRAN 
GO

--EXEC dbo.SP_InserThuoc @TenThuoc , @LoaiThuoc , @DonViTinh , @SoLuongTon , @GhiChu 

SELECT * FROM dbo.THUOC
GO


-- SP_InsertPhieuNhapThuoc
DROP PROC SP_InsertPhieuNhapThuoc
GO

CREATE PROC SP_InsertPhieuNhapThuoc
	@manv INT 
AS
SET TRAN ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
	BEGIN TRY
		INSERT INTO dbo.PHIEUNHAP  ( MANV, NGAYNHAP ) VALUES  ( @manv,GETDATE() )     
	END TRY
	BEGIN CATCH
		RAISERROR('Lỗi không insert được',16,2)
		ROLLBACK TRAN
	END CATCH
	COMMIT TRAN
	SELECT TOP(1) * FROM dbo.PHIEUNHAP ORDER BY MAPHIEUNHAP DESC
	RETURN 0
GO 
 

 EXEC dbo.SP_InsertPhieuNhapThuoc @manv = 1-- int
 GO
 



 --SP_DanhSachNhaCungCap
 DROP PROC SP_DanhSachNhaCungCap
 GO

 CREATE PROC SP_DanhSachNhaCungCap
 AS
 BEGIN 
	SELECT * FROM dbo.NHACUNGCAP
 END 
 GO

 EXEC dbo.SP_DanhSachNhaCungCap
 GO
 

 --SP_DanhSachHangSanXuat
 DROP PROC SP_DanhSachHangSanXuat
 GO
 
 CREATE PROC SP_DanhSachHangSanXuat
 AS
 BEGIN
	
 END
 GO




 --SP_InsertChiTietPhieuNhap
 DROP PROC SP_InsertChiTietPhieuNhapThuoc
 GO
 
 CREATE PROC  SP_InsertChiTietPhieuNhapThuoc
	 @MaPhieuNhap INT,
	 @MaThuoc INT ,
	 @SoLuong INT, 
	 @NgayHetHan DATE,
	 @NgaySanXuat DATE,
	 @GiaNhap DECIMAL,
	 @GiaBanLe DECIMAL,
	 @MaHSX INT, 
	 @MaNhaCC INT 
 AS
 BEGIN
	BEGIN TRAN 
		SET TRAN ISOLATION LEVEL SERIALIZABLE
		BEGIN TRY
			INSERT INTO dbo.CHITIETPHIEUNHAPTHUOC  ( MAPHIEUNHAP , MATHUOC , SOLUONG , NGAYSX , NGAYHETHAN , GIANHAP , GIABANLE ,  MAHSX , MANHACC )
			VALUES  ( @MaPhieuNhap , -- MAPHIEUNHAP - int
			          @MaThuoc, -- MATHUOC - int
			          @SoLuong , -- SOLUONG - int
			          @NgaySanXuat , -- NGAYSX - date
			          @NgayHetHan , -- NGAYHETHAN - date
			          @GiaNhap , -- GIANHAP - money
			          @GiaBanLe , -- GIABANLE - money
			          @MaHSX , -- MAHSX - int
			          @MaNhaCC  -- MANHACC - int
			        )
		END TRY
		BEGIN CATCH
			RAISERROR('Không thêm được chi tiết phiếu nhập thuốc',16,1)
			ROLLBACK TRAN
		END CATCH
	COMMIT TRAN 
 END 

 GO
 

 EXEC dbo.SP_InsertChiTietPhieuNhapThuoc @MaPhieuNhap ,      @MaThuoc ,      @SoLuong ,  @NgayHetHan ,  @NgaySanXuat , @GiaNhap , @GiaBanLe ,  @MaHSX ,   @MaNhaCC 
 
 SELECT * FROM dbo.PHIEUNHAP
 GO
 
