use quanlyphongkham_final
go

drop proc SP_Thuoc_selectall
go

------------- lấy dữ liêu kho thuoc --------------
create proc SP_Thuoc_selectall
as
begin
	select T.MATHUOC,T.TENTHUOC,DVT.TENDVT,LT.TENLOAI,T.SOLUONGTON,T.GHICHU from THUOC T, LOAITHUOC LT, DONVITINH DVT WHERE T.LOAITHUOC=LT.MALOAITHUOC AND T.DONVITINH=DVT.MADVT
end
go

------- tim kiếm kho thuoc-------------
drop proc SP_Thuoc_search
go

create proc SP_Thuoc_search
@Thongtin nvarchar(20),
@DuLieu nvarchar (50)
as
begin
	if @Thongtin='MATHUOC' select T.MATHUOC,T.TENTHUOC,DVT.TENDVT,LT.TENLOAI,T.SOLUONGTON,T.GHICHU from THUOC T, LOAITHUOC LT, DONVITINH DVT WHERE T.LOAITHUOC=LT.MALOAITHUOC AND T.DONVITINH=DVT.MADVT and T.MATHUOC=@DuLieu
	if @Thongtin='TENTHUOC' select T.MATHUOC,T.TENTHUOC,DVT.TENDVT,LT.TENLOAI,T.SOLUONGTON,T.GHICHU from THUOC T, LOAITHUOC LT, DONVITINH DVT WHERE T.LOAITHUOC=LT.MALOAITHUOC AND T.DONVITINH=DVT.MADVT and T.TENTHUOC like '%'+@DuLieu+'%'
	if @Thongtin='TENLOAI' select T.MATHUOC,T.TENTHUOC,DVT.TENDVT,LT.TENLOAI,T.SOLUONGTON,T.GHICHU from THUOC T, LOAITHUOC LT, DONVITINH DVT WHERE T.LOAITHUOC=LT.MALOAITHUOC AND T.DONVITINH=DVT.MADVT and LT.TENLOAI like '%'+@DuLieu+'%'

end
go

----- lấy dữ liệu kho vat tu ---------

drop proc SP_Vattuyte_selectall
go
create proc SP_Vattuyte_selectall
as
begin
	select V.MAVTYT, V.TENVATTU, D.TENDVT, V.SOLUONGTON from VATTUYTE V , DONVITINH D where D.MADVT = V.MADVT
end
go

 
------- tim kiếm kho vật tư y tế ----------

drop proc SP_Vattuyte_search
go

create proc SP_Vattuyte_search
@thongtin nvarchar(20),
@dulieu nvarchar(50)
as
begin
	if @thongtin = 'MAVTYT' select V.MAVTYT, V.TENVATTU, D.TENDVT, V.SOLUONGTON from VATTUYTE V , DONVITINH D where D.MADVT = V.MADVT AND V.MAVTYT=@dulieu
	if @thongtin ='TENVATTU' select V.MAVTYT, V.TENVATTU, D.TENDVT, V.SOLUONGTON from VATTUYTE V , DONVITINH D where D.MADVT = V.MADVT AND V.TENVATTU like '%'+@dulieu+'%'
	if @thongtin ='TENDVT' select V.MAVTYT, V.TENVATTU, D.TENDVT, V.SOLUONGTON from VATTUYTE V , DONVITINH D where D.MADVT = V.MADVT AND D.TENDVT like '%'+@dulieu+'%'
end
go