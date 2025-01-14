create [QuanLyThuVien]
go
USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[DocGias]    Script Date: 4/11/2022 2:18:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGias](
	[DocGiaId] [uniqueidentifier] NOT NULL,
	[HoTen] [nvarchar](60) NOT NULL,
	[Loai] [nvarchar](max) NULL,
	[NgaySinh] [datetime2](7) NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[NgayLap] [datetime2](7) NOT NULL,
	[TongNo] [real] NOT NULL,
	[NhanVienId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_DocGias] PRIMARY KEY CLUSTERED 
(
	[DocGiaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanViens]    Script Date: 4/11/2022 2:18:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanViens](
	[NhanVienId] [uniqueidentifier] NOT NULL,
	[HoTen] [nvarchar](60) NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[NgaySinh] [datetime2](7) NOT NULL,
	[SDT] [nvarchar](max) NULL,
	[BangCap] [nvarchar](max) NULL,
	[BoPhan] [nvarchar](max) NULL,
	[ChucVu] [nvarchar](max) NULL,
 CONSTRAINT [PK_NhanViens] PRIMARY KEY CLUSTERED 
(
	[NhanVienId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 4/11/2022 2:18:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [uniqueidentifier] NOT NULL,
	[Email] [nvarchar](60) NOT NULL,
	[PasswordHash] [nvarchar](max) NOT NULL,
	[PasswordSalt] [nvarchar](max) NOT NULL,
	[RefreshToken] [nvarchar](max) NULL,
	[NhanVienId] [uniqueidentifier] NOT NULL,
	[RefreshTokenExpiryTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[DocGias] ([DocGiaId], [HoTen], [Loai], [NgaySinh], [DiaChi], [Email], [NgayLap], [TongNo], [NhanVienId]) VALUES (N'f7f7d68a-e60e-4dfd-e6b1-08da1553c189', N'Phạm Quang Trung', N'X', CAST(N'1999-01-01T09:23:54.8850000' AS DateTime2), N'123', N'123', CAST(N'1999-01-01T09:23:54.8850000' AS DateTime2), 0, N'f7f7d68a-e60e-4dfd-e6b1-08da1553c178')
INSERT [dbo].[DocGias] ([DocGiaId], [HoTen], [Loai], [NgaySinh], [DiaChi], [Email], [NgayLap], [TongNo], [NhanVienId]) VALUES (N'a6bfa8bf-2daf-4b82-4370-08da16d55c11', N'Khoa', N'Y', CAST(N'2022-04-05T07:24:43.7000000' AS DateTime2), N'322', N'15123', CAST(N'2022-04-05T07:24:43.7000000' AS DateTime2), 0, N'a6bfa8bf-2daf-4b82-4370-08da16d55c12')
INSERT [dbo].[DocGias] ([DocGiaId], [HoTen], [Loai], [NgaySinh], [DiaChi], [Email], [NgayLap], [TongNo], [NhanVienId]) VALUES (N'd9794229-b43a-4509-0cfe-08da16d5e242', N'22231123', N'1241241', CAST(N'2022-04-05T07:28:21.0390000' AS DateTime2), N'string', N'string', CAST(N'2022-04-05T07:28:21.0390000' AS DateTime2), 110, N'f7f7d68a-e60e-4dfd-e6b1-08da1553c178')
INSERT [dbo].[DocGias] ([DocGiaId], [HoTen], [Loai], [NgaySinh], [DiaChi], [Email], [NgayLap], [TongNo], [NhanVienId]) VALUES (N'337e71a7-8aa5-4944-a48f-08da16d89d9e', N'Phạm Quang Trung 1', N'X', CAST(N'1999-01-01T09:23:54.8850000' AS DateTime2), N'123', N'123', CAST(N'1999-01-01T09:23:54.8850000' AS DateTime2), 0, N'f7f7d68a-e60e-4dfd-e6b1-08da1553c178')
INSERT [dbo].[DocGias] ([DocGiaId], [HoTen], [Loai], [NgaySinh], [DiaChi], [Email], [NgayLap], [TongNo], [NhanVienId]) VALUES (N'78221eeb-ee4e-475c-70ed-08da16d9ef86', N'trung123', N'1241241', CAST(N'2000-01-01T09:23:54.8850000' AS DateTime2), N'string', N'string', CAST(N'2022-04-05T07:28:21.0390000' AS DateTime2), 110, N'f7f7d68a-e60e-4dfd-e6b1-08da1553c178')
GO
INSERT [dbo].[NhanViens] ([NhanVienId], [HoTen], [DiaChi], [NgaySinh], [SDT], [BangCap], [BoPhan], [ChucVu]) VALUES (N'f7f7d68a-e60e-4dfd-e6b1-08da1553c171', N'Giang Anh Kiệt', N'60/14 Lâm Văn Bền-Q7-TPHCM', CAST(N'2000-01-01T09:23:54.8850000' AS DateTime2), N'0456123789', N'Cao Đẳng', N'Thủ Kho', N'Nhân Viên')
INSERT [dbo].[NhanViens] ([NhanVienId], [HoTen], [DiaChi], [NgaySinh], [SDT], [BangCap], [BoPhan], [ChucVu]) VALUES (N'f7f7d68a-e60e-4dfd-e6b1-08da1553c178', N'Phạm Quang Trung', N'365 Trần Hưng Đạo-Q1-TPHCM', CAST(N'1999-04-04T07:41:05.3630000' AS DateTime2), N'0123123123', N'Tiến Sĩ', N'Ban Giám Đốc', N'Giám Đốc')
INSERT [dbo].[NhanViens] ([NhanVienId], [HoTen], [DiaChi], [NgaySinh], [SDT], [BangCap], [BoPhan], [ChucVu]) VALUES (N'a6bfa8bf-2daf-4b82-4370-08da16d55c12', N'Dương Nhật Khoa', N'135B Trần Hưng Đạo-Q1-TPHCM', CAST(N'2000-04-05T07:24:43.7000000' AS DateTime2), N'0123123122', N'Thạc Sĩ', N'Ban Giám Đốc', N'Phó Giám Đốc')
INSERT [dbo].[NhanViens] ([NhanVienId], [HoTen], [DiaChi], [NgaySinh], [SDT], [BangCap], [BoPhan], [ChucVu]) VALUES (N'fc2dcf06-cf7d-4fb4-7233-08da16da7adf', N'Bùi Văn Sơn', N'135A Trần Hưng Đạo-Q1-TPHCM', CAST(N'1998-04-05T08:01:18.4000000' AS DateTime2), N'0987654321', N'Đại Học', N'Thủ Quỹ', N'Trưởng Phòng')
INSERT [dbo].[NhanViens] ([NhanVienId], [HoTen], [DiaChi], [NgaySinh], [SDT], [BangCap], [BoPhan], [ChucVu]) VALUES (N'fc2dcf06-cf7d-4fb4-7233-08da16db7adf', N'Nguyễn Thanh Dương', N'155/12 Đất Thánh-Q.TB-TPHCM', CAST(N'1999-01-01T09:23:54.8850000' AS DateTime2), N'0789456123', N'Tú Tài', N'Thủ Thư', N'Phó Phòng')
INSERT [dbo].[NhanViens] ([NhanVienId], [HoTen], [DiaChi], [NgaySinh], [SDT], [BangCap], [BoPhan], [ChucVu]) VALUES (N'425df716-6983-441f-fbdb-08da1b810954', N'444', N'123', CAST(N'2022-04-11T06:03:39.8140000' AS DateTime2), N'123', N'Cao Đẳng', N'Thủ Kho', N'Nhân Viên')
GO
INSERT [dbo].[Users] ([UserId], [Email], [PasswordHash], [PasswordSalt], [RefreshToken], [NhanVienId], [RefreshTokenExpiryTime]) VALUES (N'15450d43-c921-4deb-2432-08da1785ba6b', N'mrtrung081099@gmail.com', N'/F6MGLLeHmnyXObV/1bgIT8fCHXO1DN23CfvaBfwRRs=', N'7Mqii7Nb/M8T/ogO4RypHQ==', N'g8xWuOAbkTSY1PiYXr4aVOu++DNvfqyIkr6TPpyh7zQ=', N'f7f7d68a-e60e-4dfd-e6b1-08da1553c178', CAST(N'2022-04-16T17:54:48.8665171' AS DateTime2))
INSERT [dbo].[Users] ([UserId], [Email], [PasswordHash], [PasswordSalt], [RefreshToken], [NhanVienId], [RefreshTokenExpiryTime]) VALUES (N'84c6e6c3-6cc1-454a-59f0-08da1a179832', N'sonbede@gmail.com', N'yJ5IYDEV9om9XmInhcs/Ustrj1QC5BYPN72RcMGozU8=', N'UKKB0kpeVj07LalB693YpQ==', N'8qCKyFX6CJyr2YsWSKTLb2oDbspRMHCslh9TX5tjEM4=', N'fc2dcf06-cf7d-4fb4-7233-08da16da7adf', CAST(N'2022-04-17T00:28:28.6023821' AS DateTime2))
GO
ALTER TABLE [dbo].[NhanViens] ADD  DEFAULT (N'') FOR [HoTen]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [RefreshTokenExpiryTime]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_NhanViens_NhanVienId] FOREIGN KEY([NhanVienId])
REFERENCES [dbo].[NhanViens] ([NhanVienId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_NhanViens_NhanVienId]
GO
