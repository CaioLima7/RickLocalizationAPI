USE [RickLocalizationDB]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201116024108_Load_Database', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201116064203_Update_Database', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201116195554_Update_Database2', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201118164557_Update_Database3', N'5.0.0')
GO
SET IDENTITY_INSERT [dbo].[Morty] ON 

INSERT [dbo].[Morty] ([Id], [Name], [Dimension]) VALUES (1, N'teste', N'5')
INSERT [dbo].[Morty] ([Id], [Name], [Dimension]) VALUES (2, N'teste', N'5')
SET IDENTITY_INSERT [dbo].[Morty] OFF
GO
SET IDENTITY_INSERT [dbo].[Navigations] ON 

INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (1, CAST(N'2020-11-16T18:38:04.6400000' AS DateTime2), N'string', 1)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2, CAST(N'2020-11-16T18:38:04.6400000' AS DateTime2), N'string', 1)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (1002, CAST(N'2020-11-17T00:00:00.0000000' AS DateTime2), N'disney land', 1)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (1003, CAST(N'2020-11-18T00:00:00.0000000' AS DateTime2), N'another place', 1)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2002, CAST(N'2020-11-18T16:02:51.7860000' AS DateTime2), N'string', 1)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2003, CAST(N'2020-11-18T16:02:51.7860000' AS DateTime2), N'string', 1)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2004, CAST(N'2020-11-18T16:02:51.7860000' AS DateTime2), N'string', 1)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2005, CAST(N'2020-11-18T16:02:51.7860000' AS DateTime2), N'string', 1)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2006, CAST(N'2020-11-18T16:02:51.7860000' AS DateTime2), N'string', 1)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2007, CAST(N'2020-11-18T16:02:51.7860000' AS DateTime2), N'string', 1)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2008, CAST(N'2020-11-18T16:02:51.7860000' AS DateTime2), N'string', 1)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2009, CAST(N'2020-11-18T16:02:51.7860000' AS DateTime2), N'string', 1)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2011, CAST(N'2020-11-05T03:00:00.0000000' AS DateTime2), N'afsdfg', 1)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2012, CAST(N'2020-11-05T03:00:00.0000000' AS DateTime2), N'afsdfg', 1)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2013, CAST(N'2020-11-06T03:00:00.0000000' AS DateTime2), N'asdfasdfa', 0)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2014, CAST(N'2020-11-03T03:00:00.0000000' AS DateTime2), N'asdfas', 0)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2015, CAST(N'2020-11-18T17:29:53.7270000' AS DateTime2), N'string', 3)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2016, CAST(N'2020-11-04T03:00:00.0000000' AS DateTime2), N'asdfa', 1)
INSERT [dbo].[Navigations] ([Id], [Date], [TravelName], [RickId]) VALUES (2017, CAST(N'2020-11-02T03:00:00.0000000' AS DateTime2), N'sdfasdfa', 2)
SET IDENTITY_INSERT [dbo].[Navigations] OFF
GO
SET IDENTITY_INSERT [dbo].[RickandMorty] ON 

INSERT [dbo].[RickandMorty] ([Id], [Rick], [Morty], [ImgFileMorty], [ImgFileRick]) VALUES (1, 1, 1, N'morty', N'rick')
INSERT [dbo].[RickandMorty] ([Id], [Rick], [Morty], [ImgFileMorty], [ImgFileRick]) VALUES (3, 2, 2, N'morty', N'rick')
INSERT [dbo].[RickandMorty] ([Id], [Rick], [Morty], [ImgFileMorty], [ImgFileRick]) VALUES (4, 3, 3, N'morty', N'rick')
INSERT [dbo].[RickandMorty] ([Id], [Rick], [Morty], [ImgFileMorty], [ImgFileRick]) VALUES (5, 4, 4, N'morty', N'rick')
INSERT [dbo].[RickandMorty] ([Id], [Rick], [Morty], [ImgFileMorty], [ImgFileRick]) VALUES (6, 5, 5, N'morty', N'rick')
INSERT [dbo].[RickandMorty] ([Id], [Rick], [Morty], [ImgFileMorty], [ImgFileRick]) VALUES (7, 6, 6, N'morty', N'rick')
INSERT [dbo].[RickandMorty] ([Id], [Rick], [Morty], [ImgFileMorty], [ImgFileRick]) VALUES (8, 7, 7, N'morty', N'rick')
SET IDENTITY_INSERT [dbo].[RickandMorty] OFF
GO
SET IDENTITY_INSERT [dbo].[RickHistorics] ON 

INSERT [dbo].[RickHistorics] ([Id], [RickId], [Navigation]) VALUES (1, 1, 1)
SET IDENTITY_INSERT [dbo].[RickHistorics] OFF
GO
SET IDENTITY_INSERT [dbo].[Ricks] ON 

INSERT [dbo].[Ricks] ([Id], [History], [Name], [Dimension]) VALUES (1, 1, N'rick test', N'dimension test')
SET IDENTITY_INSERT [dbo].[Ricks] OFF
GO
