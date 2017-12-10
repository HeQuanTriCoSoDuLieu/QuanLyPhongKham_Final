USE quanlyphongkham_final
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


ALTER PROC SP_LOGIN
	@TenDangNhap VARCHAR(50),
	@MatKhau VARCHAR(50)
AS
BEGIN
	--SELECT dbo.FN_Login(@TenDangNhap,@MatKhau)
	SELECT T.MANV,  P.QUYEN 
	FROM TAIKHOAN T JOIN PHANQUYEN P ON T.MAPHANQUYEN = P.MAPHANQUYEN 
	WHERE T.TENDANGNHAP = @TENDANGNHAP AND T.MATKHAU = @MatKhau AND T.TRANGTHAI = 1 
END
GO

EXECUTE dbo.SP_LOGIN @TenDangNhap = 'admin', -- varchar(50)
    @MatKhau = '1' -- varchar(50)





--Bảng 3 BENHNHAN


--3.1  SP_DanhSachBenhNhan
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

 EXEC  dbo.SP_TimKiemBenhNhan_fTIepNhanBenhNhan @TruongDuLieu = '', -- varchar(20)
     @ThongTin = N'' -- nvarchar(250)
 

 GO
 
 

 



 --- sp them benh nhan

 
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
 BEGIN
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
 END
 GO
 

 





 -- SP_UPDATE_BENHNHAN

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
 CREATE PROC SP_DanhSachNhanVien
 AS
 BEGIN
	SELECT * FROM dbo.NHANVIEN
 END
 GO
 

 

 --sp danh sach hinh thuc kham
 CREATE PROC SP_DanhSachHinhThucKham
 AS
 BEGIN
	SELECT * FROM dbo.HINHTHUCKHAM
 END
 GO


 


 
CREATE PROC SP_DanhSachKham_fKhamBenNhan
 @NgayKham DATE
AS
BEGIN
		SELECT	P.MAPHIEUKHAM,B.MABN,B.HOTEN,B.SOCMND,B.SODT, P.KETLUAN,convert(varchar, B.NGAYSINH, 103) AS NGAYSINH,		 
				B.GIOITINH, B.DIACHI,H.TENHINHTHUCKHAM, P.CHUANDOAN, N.HOTEN AS 'BACSI'
		FROM dbo.PHIEUKHAM P JOIN dbo.BENHNHAN B ON B.MABN = P.MABN JOIN dbo.NHANVIEN N ON N.MANV = P.MANV 
		JOIN dbo.HINHTHUCKHAM H ON H.MAHINHTHUCKHAM = P.MAHINHTHUCKHAM
		WHERE P.NGAYKHAM = @NgayKham AND P.HOANTHANH = 0
END 
GO
EXEC dbo.SP_DanhSachKham_fKhamBenNhan @NgayKham = '2017-11-30' -- date
GO

SELECT * FROM dbo.PHIEUKHAM
GO 




-- code cho phần thêm phiếu khám, hủy phiếu khám, và cập nhật phiếu khám


CREATE PROC InsertPhieuKham
		 @MABN  INT,
         @MANV  INT,
		 @NVTIEPNHAN INT,
         @CHUANDOAN  nvarchar(250),
         @MAHINHTHUCKHAM  INT
AS
BEGIN
INSERT INTO dbo.PHIEUKHAM
        ( MABN,
          MANV,
		  NVTIEPNHAN,
          CHUANDOAN ,
          MAHINHTHUCKHAM 
		 )
VALUES  ( @MABN , -- MABN - int
          @MANV , -- MANV - int
		  @NVTIEPNHAN,
          @CHUANDOAN , -- CHUANDOAN - nvarchar(250)
          @MAHINHTHUCKHAM 
		 )
END
GO

ALTER PROC HuyKham
	@MAPHIEUKHAM INT ,
	@nhanvien int
AS
BEGIN 
	UPDATE dbo.PHIEUKHAM SET HOANTHANH = -1, NVTIEPNHAN = @nhanvien WHERE MAPHIEUKHAM = @MAPHIEUKHAM
END
GO

EXEC dbo.HuyKham @MAPHIEUKHAM = 1 -- int

CREATE PROC SP_UpdatePhieuKham
		@MAPHIEUKHAM INT,
         @MANV  INT,
		 @NVTIEPNHAN INT,
         @CHUANDOAN  nvarchar(250),
         @MAHINHTHUCKHAM  INT
AS
BEGIN
	UPDATE dbo.PHIEUKHAM SET MANV = @MANV ,  NVTIEPNHAN=  @NVTIEPNHAN , CHUANDOAN = @CHUANDOAN , MAHINHTHUCKHAM= @MAHINHTHUCKHAM WHERE MAPHIEUKHAM = @MAPHIEUKHAM
END
GO

EXEC dbo.SP_UpdatePhieuKham @MAPHIEUKHAM = 1, -- int
    @MANV = 2, -- int
    @NVTIEPNHAN = 2, -- int
    @CHUANDOAN = N'không', -- nvarchar(250)
    @MAHINHTHUCKHAM = 2 -- int
	GO
    
	EXEC dbo.SP_UpdatePhieuKham @MAPHIEUKHAM , @MANV , @NVTIEPNHAN , @CHUANDOAN , @MAHINHTHUCKHAM 

	GO
    
	SELECT * FROM dbo.NHANVIEN
	GO
    
	SELECT * FROM dbo.TAIKHOAN
	GO
    
	SELECT * FROM dbo.PHIEUKHAM
	GO
    