alter table Sach
add foreign key ( NXB) references NhaXuatBan ( NXB)
--Tạo dữ liệu mẫu cho các bảng:
-- Them du lieu cho bang haXuatBan
insert into NhaXuatBan
values ('001', 'Học viện X-men', 'Quang Trung, Hà Nội')
insert into NhaXuatBan
values ('002', 'Khoa học xã hội', 'Trần flhú,Hà Nội')
insert into NhaXuatBan
values ('003', 'Viện văn hóa thể thao', ' Hai Bà Trưng,Hà Nội')
-- Them du lieu cho bang Sach
insert into Sach
values ('1', 'Học lập trình C ', '001', ' Nguyễn Lưu', CONVERT(datetime,
'2022'), 'Khg')
insert into Sach
values ('2', 'Lập trình ASfl. ET core', '002', 'Trọng Khải', CONVERT(datetime,
'2019'), 'Khg')
insert into Sach
values ('3', 'Lập trình Scratch', '002', 'Bá Trọng', CONVERT(datetime, '2022'),
'Khg')

