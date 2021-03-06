USE [RuthProject]
GO
/****** Object:  Table [dbo].[ClassTbl]    Script Date: 16/11/2021 16:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClassTbl](
	[ClassId] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [nchar](10) NULL,
 CONSTRAINT [PK_ClassTbl] PRIMARY KEY CLUSTERED 
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConstraintToStudentTbl]    Script Date: 16/11/2021 16:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConstraintToStudentTbl](
	[ConsId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NULL,
	[PropId] [int] NULL,
	[Is] [bit] NULL,
 CONSTRAINT [PK_ConstraintToStudentTbl] PRIMARY KEY CLUSTERED 
(
	[ConsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertiesTbl]    Script Date: 16/11/2021 16:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertiesTbl](
	[PropId] [int] IDENTITY(1,1) NOT NULL,
	[PropName] [nchar](20) NULL,
 CONSTRAINT [PK_PropertiesTbl] PRIMARY KEY CLUSTERED 
(
	[PropId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentTbl]    Script Date: 16/11/2021 16:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentTbl](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](30) NULL,
	[LastName] [nchar](30) NULL,
	[Grade] [int] NULL,
	[ChatRate] [int] NULL,
	[LineRecomended] [int] NULL,
	[Row] [int] NULL,
	[Line] [int] NULL,
	[PathImage] [nchar](50) NULL,
 CONSTRAINT [PK_StudentTbl] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ClassTbl] ON 

INSERT [dbo].[ClassTbl] ([ClassId], [ClassName]) VALUES (4, N'1         ')
INSERT [dbo].[ClassTbl] ([ClassId], [ClassName]) VALUES (18, N'5         ')
INSERT [dbo].[ClassTbl] ([ClassId], [ClassName]) VALUES (19, N'3         ')
INSERT [dbo].[ClassTbl] ([ClassId], [ClassName]) VALUES (20, N'7         ')
INSERT [dbo].[ClassTbl] ([ClassId], [ClassName]) VALUES (21, N'6         ')
INSERT [dbo].[ClassTbl] ([ClassId], [ClassName]) VALUES (22, N'2         ')
INSERT [dbo].[ClassTbl] ([ClassId], [ClassName]) VALUES (23, N'4         ')
SET IDENTITY_INSERT [dbo].[ClassTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[ConstraintToStudentTbl] ON 

INSERT [dbo].[ConstraintToStudentTbl] ([ConsId], [StudentId], [PropId], [Is]) VALUES (1, 21, 3, 1)
INSERT [dbo].[ConstraintToStudentTbl] ([ConsId], [StudentId], [PropId], [Is]) VALUES (2, 1, 1, 1)
INSERT [dbo].[ConstraintToStudentTbl] ([ConsId], [StudentId], [PropId], [Is]) VALUES (3, 2, 1, 0)
INSERT [dbo].[ConstraintToStudentTbl] ([ConsId], [StudentId], [PropId], [Is]) VALUES (4, 2, 5, 1)
INSERT [dbo].[ConstraintToStudentTbl] ([ConsId], [StudentId], [PropId], [Is]) VALUES (5, 3, 2, 1)
INSERT [dbo].[ConstraintToStudentTbl] ([ConsId], [StudentId], [PropId], [Is]) VALUES (6, 4, 6, 1)
INSERT [dbo].[ConstraintToStudentTbl] ([ConsId], [StudentId], [PropId], [Is]) VALUES (7, 8, 5, 1)
INSERT [dbo].[ConstraintToStudentTbl] ([ConsId], [StudentId], [PropId], [Is]) VALUES (8, 8, 3, 1)
INSERT [dbo].[ConstraintToStudentTbl] ([ConsId], [StudentId], [PropId], [Is]) VALUES (9, 1, 1, 1)
INSERT [dbo].[ConstraintToStudentTbl] ([ConsId], [StudentId], [PropId], [Is]) VALUES (10, 3, 3, 1)
INSERT [dbo].[ConstraintToStudentTbl] ([ConsId], [StudentId], [PropId], [Is]) VALUES (11, 5, 4, 0)
INSERT [dbo].[ConstraintToStudentTbl] ([ConsId], [StudentId], [PropId], [Is]) VALUES (12, 16, 4, 1)
INSERT [dbo].[ConstraintToStudentTbl] ([ConsId], [StudentId], [PropId], [Is]) VALUES (13, 6, 5, 0)
INSERT [dbo].[ConstraintToStudentTbl] ([ConsId], [StudentId], [PropId], [Is]) VALUES (14, 17, 8, 1)
INSERT [dbo].[ConstraintToStudentTbl] ([ConsId], [StudentId], [PropId], [Is]) VALUES (15, 7, 4, 0)
SET IDENTITY_INSERT [dbo].[ConstraintToStudentTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[PropertiesTbl] ON 

INSERT [dbo].[PropertiesTbl] ([PropId], [PropName]) VALUES (1, N'מאחורי עמוד         ')
INSERT [dbo].[PropertiesTbl] ([PropId], [PropName]) VALUES (2, N'ליד הדלת            ')
INSERT [dbo].[PropertiesTbl] ([PropId], [PropName]) VALUES (3, N'רחוק מהשקע          ')
INSERT [dbo].[PropertiesTbl] ([PropId], [PropName]) VALUES (4, N'מקום מוסתר          ')
INSERT [dbo].[PropertiesTbl] ([PropId], [PropName]) VALUES (5, N'רחוק מיעל           ')
INSERT [dbo].[PropertiesTbl] ([PropId], [PropName]) VALUES (6, N'אזור המזגן          ')
INSERT [dbo].[PropertiesTbl] ([PropId], [PropName]) VALUES (7, N'רחוק מהמורה         ')
INSERT [dbo].[PropertiesTbl] ([PropId], [PropName]) VALUES (8, N'מקום מסנוור         ')
INSERT [dbo].[PropertiesTbl] ([PropId], [PropName]) VALUES (9, N'אין קליטה           ')
SET IDENTITY_INSERT [dbo].[PropertiesTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[StudentTbl] ON 

INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (1, N'תמר                           ', N'כץ                            ', 5, 5, 1, NULL, NULL, N'\..\..\..\Images\tamark.jpg                       ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (2, N'אורית                         ', N'וולפסון                       ', 5, 1, 1, NULL, NULL, N'\..\..\..\Images\orit.jpg                         ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (3, N'רות                           ', N'חבשוש                         ', 5, 2, 2, NULL, NULL, N'\..\..\..\Images\ruth.jpg                         ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (4, N'מיכל                          ', N'ביטון                         ', 5, 3, 1, NULL, NULL, N'\..\..\..\Images\michal.jpg                       ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (5, N'חני                           ', N'שפירא                         ', 5, 2, 1, NULL, NULL, N'\..\..\..\Images\chani.jpg                        ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (6, N'שירה                          ', N'עזרא                          ', 5, 3, 2, NULL, NULL, N'\..\..\..\Images\shira.jpg                        ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (7, N'מלי                           ', N'שוורץ                         ', 5, 2, 3, NULL, NULL, N'\..\..\..\Images\mali.jpg                         ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (8, N'יעל                           ', N'קצב                           ', 5, 4, 3, NULL, NULL, N'\..\..\..\Images\yael.jpg                         ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (10, N'אלישבע                        ', N'גרשוני                        ', 5, 2, 1, NULL, NULL, N'\..\..\..\Images\elish.jpg                        ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (11, N'נועה                          ', N'שוכר                          ', 5, 4, 2, NULL, NULL, N'\..\..\..\Images\noa.jpg                          ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (12, N'יעלי                          ', N'קלמן                          ', 5, 1, 1, NULL, NULL, N'\..\..\..\Images\yaeli.jpg                        ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (13, N'יהודית                        ', N'ספינר                         ', 5, 2, 3, NULL, NULL, N'\..\..\..\Images\yeudit.jpg                       ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (14, N'נחמי                          ', N'הלפגוט                        ', 5, 2, 3, NULL, NULL, N'\..\..\..\Images\nechami2.jpg                     ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (15, N'תמר                           ', N'מלול                          ', 5, 5, 1, NULL, NULL, N'\..\..\..\Images\tamarm.jpg                       ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (16, N'תמר                           ', N'רוטשטיין                      ', 5, 1, 3, NULL, NULL, NULL)
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (17, N'גילי                          ', N'גוטרמן                        ', 5, 2, 3, NULL, NULL, N'\..\..\..\Images\gili.jpg                         ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (18, N'ברכי                          ', N'אביבי                         ', 5, 3, 3, NULL, NULL, N'\..\..\..\Images\brachi.jpg                       ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (19, N'אפרת                          ', N'אב"ש                          ', 5, 2, 2, NULL, NULL, N'\..\..\..\Images\abash.jpg                        ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (20, N'אפרת                          ', N'יצחקי                         ', 5, 3, 3, NULL, NULL, N'\..\..\..\Images\efrati.jpg                       ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (21, N'מירי                          ', N'רייזמן                        ', 5, 5, 2, NULL, NULL, N'\..\..\..\Images\migi.jpg                         ')
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (22, N'אילה                          ', N'כהן                           ', 7, 2, 1, NULL, NULL, NULL)
INSERT [dbo].[StudentTbl] ([StudentId], [FirstName], [LastName], [Grade], [ChatRate], [LineRecomended], [Row], [Line], [PathImage]) VALUES (23, N'תרצה                          ', N'לוי                           ', 7, 1, 1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[StudentTbl] OFF
GO
ALTER TABLE [dbo].[ConstraintToStudentTbl]  WITH CHECK ADD  CONSTRAINT [FK_ConstraintToStudentTbl_PropertiesTbl] FOREIGN KEY([PropId])
REFERENCES [dbo].[PropertiesTbl] ([PropId])
GO
ALTER TABLE [dbo].[ConstraintToStudentTbl] CHECK CONSTRAINT [FK_ConstraintToStudentTbl_PropertiesTbl]
GO
