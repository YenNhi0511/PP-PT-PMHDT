Create database QuanLyBanSach;
use QuanLyBanSach;
CREATE TABLE [dbo].[Sach]
(
[MaSach] char(10),
[TenSach] nvarchar(300),
[NXB] char(10),
[TenTG] nvarchar(100),
[NamXB] datetime,
[GhiChu] nvarchar(500),
primary key (MaSach)
)
CREATE TABLE [dbo].[NhaXuatBan]
(
[NXB] char(10),
[TenTG] nvarchar(100),
[DiaChi] nvarchar(500),
primary key (NXB)
)
-- Tao khoa ngoai lien ket 2 bang
alter table Sach
add foreign key (NXB) references NhaXuatBan (NXB)
--Tạo dữ liệu mẫu cho các bảng:
-- Them du lieu cho bang haXuatBan
insert into NhaXuatBan
values ('001', N'Học viện X-men', N'Quang Trung, Hà Nội')
insert into NhaXuatBan
values ('002', N'Khoa học xã hội', N'Trần flhú, Hà Nội')
insert into NhaXuatBan
values ('003', N'Viện văn hóa thể thao', N'Hai Bà Trưng, Hà Nội')
-- Them du lieu cho bang Sach
insert into Sach
values ('1', N'Học lập trình C#', '001', N'Nguyễn Lưu', CONVERT(datetime,'2022'), 'Khg')
insert into Sach
values ('2', N'Lập trình ASfl. ET core', '002', N'Trọng Khải', CONVERT(datetime,'2019'), 'Khg')
insert into Sach
values ('3', N'Lập trình Scratch', '002', N'Bá Trọng', CONVERT(datetime, '2022'),'Khg')