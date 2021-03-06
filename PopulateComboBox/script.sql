USE [NorthWind2020]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 3/27/2021 3:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[ContactTypeIdentifier] [int] NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactType]    Script Date: 3/27/2021 3:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactType](
	[ContactTypeIdentifier] [int] IDENTITY(1,1) NOT NULL,
	[ContactTitle] [nvarchar](max) NULL,
 CONSTRAINT [PK_ContactType] PRIMARY KEY CLUSTERED 
(
	[ContactTypeIdentifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 3/27/2021 3:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryIdentifier] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryIdentifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 3/27/2021 3:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NOT NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[FirstName] [nvarchar](10) NOT NULL,
	[ContactTypeIdentifier] [int] NULL,
	[TitleOfCourtesy] [nvarchar](25) NULL,
	[BirthDate] [datetime] NULL,
	[HireDate] [datetime] NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Region] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[CountryIdentifier] [int] NULL,
	[HomePhone] [nvarchar](24) NULL,
	[Extension] [nvarchar](4) NULL,
	[Notes] [nvarchar](max) NULL,
	[ReportsTo] [int] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (1, N'Maria', N'Anders', 1)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (2, N'Ana', N'Trujillo', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (3, N'Antonio', N'Moreno', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (4, N'Thomas', N'Hardy', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (5, N'Christina', N'Berglund', 6)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (6, N'Hanna', N'Moos', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (7, N'Frédérique', N'Citeaux', 5)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (8, N'Martín', N'Sommer', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (9, N'Laurence', N'Lebihan', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (10, N'Victoria', N'Ashworth', 1)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (11, N'Patricio', N'Simpson', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (12, N'Francisco', N'Chang', 5)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (13, N'Yang', N'Wang', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (14, N'Elizabeth', N'Brown', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (15, N'Sven', N'Ottlieb', 6)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (16, N'Janine', N'Labrune', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (17, N'Ann', N'Devon', 9)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (18, N'Roland', N'Mendel', 11)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (19, N'Diego', N'Roel', 1)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (20, N'Martine', N'Rancé', 2)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (21, N'Maria', N'Larsson', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (22, N'Peter', N'Franken', 5)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (23, N'Carine', N'Schmitt', 5)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (24, N'Paolo', N'Accorti', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (25, N'Lino', N'Rodriguez', 11)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (26, N'Eduardo', N'Saavedra', 5)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (27, N'José', N'Pedro Freyre', 11)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (28, N'Philip', N'Cramer', 10)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (29, N'Daniel', N'Tonini', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (30, N'Annette', N'Roulet', 11)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (31, N'Renate', N'Messner', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (32, N'Giovanni', N'Rovelli', 5)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (33, N'Catherine', N'Dewey', 9)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (34, N'Alexander', N'Feuer', 4)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (35, N'Simon', N'Crowther', 10)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (36, N'Yvonne', N'Moncada', 9)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (37, N'Henriette', N'Pfalzheim', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (38, N'Marie', N'Bertrand', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (39, N'Guillermo', N'Fernández', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (40, N'Georg', N'Pipps', 11)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (41, N'Isabel', N'de Castro', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (42, N'Horst', N'Kloss', 1)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (43, N'Sergio', N'Gutiérrez', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (44, N'Maurizio', N'Moroni', 10)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (45, N'Michael', N'Holz', 11)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (46, N'Alejandra', N'Camino', 1)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (47, N'Jonas', N'Bergulfsen', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (48, N'Hari', N'Kumar', 11)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (49, N'Jytte', N'Petersen', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (50, N'Dominique', N'Perrier', 5)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (51, N'Pascale', N'Cartrain', 1)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (52, N'Karin', N'Josephs', 5)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (53, N'Miguel', N'Angel Paolino', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (54, N'Palle', N'Ibsen', 11)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (55, N'Mary', N'Saveley', 9)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (56, N'Paul', N'Henriot', 1)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (57, N'Rita', N'Müller', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (58, N'Pirkko', N'Koskitalo', 1)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (59, N'Matti', N'Karttunen', 8)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (60, N'Zbyszek', N'Piestrzeniewicz', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (61, N'Rene', N'Phillips', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (62, N'Elizabeth', N'Lincoln', 1)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (63, N'Yoshi', N'Tannamuri', 4)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (64, N'Jaime', N'Yorres', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (65, N'Patricia', N'McKenna', 10)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (66, N'Manuel', N'Pereira', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (67, N'Jose', N'Pavarotti', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (68, N'Helen', N'Bennett', 5)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (69, N'Carlos', N'González', 1)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (70, N'Liu', N'Wong', 4)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (71, N'Paula', N'Wilson', 3)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (72, N'Felipe', N'Izquierdo', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (73, N'Howard', N'Snyder', 5)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (74, N'Yoshi', N'Latimer', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (75, N'Fran', N'Wilson', 11)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (76, N'Liz', N'Nixon', 5)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (77, N'Jean', N'Fresnière', 4)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (78, N'Mario', N'Pontes', 1)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (79, N'Bernardo', N'Batista', 1)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (80, N'Janete', N'Limeira', 2)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (81, N'Pedro', N'Afonso', 10)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (82, N'Aria', N'Cruz', 4)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (83, N'André', N'Fonseca', 10)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (84, N'Lúcia', N'Carvalho', 4)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (85, N'Anabela', N'Domingues', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (86, N'Paula', N'Parente', 11)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (87, N'Carlos', N'Hernández', 12)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (88, N'John', N'Steel', 5)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (89, N'Helvetius', N'Nagy', 10)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (90, N'Karl', N'Jablonski', 7)
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName], [ContactTypeIdentifier]) VALUES (91, N'Art', N'Braunschweiger', 11)
SET IDENTITY_INSERT [dbo].[Contacts] OFF
SET IDENTITY_INSERT [dbo].[ContactType] ON 

INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (1, N'Accounting Manager')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (2, N'Assistant Sales Agent')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (3, N'Assistant Sales Representative')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (4, N'Marketing Assistant')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (5, N'Marketing Manager')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (6, N'Order Administrator')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (7, N'Owner')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (8, N'Owner/Marketing Assistant')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (9, N'Sales Agent')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (10, N'Sales Associate')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (11, N'Sales Manager')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (12, N'Sales Representative')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (13, N'Vice President, Sales')
SET IDENTITY_INSERT [dbo].[ContactType] OFF
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (1, N'Argentina')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (2, N'Austria')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (3, N'Belgium')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (4, N'Brazil')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (5, N'Canada')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (6, N'Denmark')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (7, N'Finland')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (8, N'France')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (9, N'Germany')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (10, N'Ireland')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (11, N'Italy')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (12, N'Mexico')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (13, N'Norway')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (14, N'Poland')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (15, N'Portugal')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (16, N'Spain')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (17, N'Sweden')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (18, N'Switzerland')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (19, N'UK')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (20, N'USA')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (21, N'Venezuela')
SET IDENTITY_INSERT [dbo].[Countries] OFF
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (1, N'Davolio', N'Nancy', 12, N'Ms.', CAST(N'1968-12-08T00:00:00.000' AS DateTime), CAST(N'1992-05-01T00:00:00.000' AS DateTime), N'507 - 20th Ave. E.
Apt. 2A', N'Seattle', N'WA', N'98122', 20, N'(206) 555-9857', N'5467', N'Education includes a BA in psychology from Colorado State University.  She also completed "The Art of the Cold Call."  Nancy is a member of Toastmasters International.', 2)
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (2, N'Fuller', N'Andrew', 13, N'Dr.', CAST(N'1952-02-19T00:00:00.000' AS DateTime), CAST(N'1992-08-14T00:00:00.000' AS DateTime), N'908 W. Capital Way', N'Tacoma', N'WA', N'98401', 20, N'(206) 555-9482', N'3457', N'Andrew received his BTS commercial and a Ph.D. in international marketing from the University of Dallas.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager and was then named vice president of sales.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association.', NULL)
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (3, N'Leverling', N'Janet', 12, N'Ms.', CAST(N'1963-08-30T00:00:00.000' AS DateTime), CAST(N'1992-04-01T00:00:00.000' AS DateTime), N'722 Moss Bay Blvd.', N'Kirkland', N'WA', N'98033', 20, N'(206) 555-3412', N'3355', N'Janet has a BS degree in chemistry from Boston College).  She has also completed a certificate program in food retailing management.  Janet was hired as a sales associate and was promoted to sales representative.', 2)
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (4, N'Peacock', N'Margaret', 12, N'Mrs.', CAST(N'1958-09-19T00:00:00.000' AS DateTime), CAST(N'1993-05-03T00:00:00.000' AS DateTime), N'4110 Old Redmond Rd.', N'Redmond', N'WA', N'98052', 20, N'(206) 555-8122', N'5176', N'Margaret holds a BA in English literature from Concordia College and an MA from the American Institute of Culinary Arts. She was temporarily assigned to the London office before returning to her permanent post in Seattle.', 2)
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (5, N'Buchanan', N'Steven', 11, N'Mr.', CAST(N'1955-03-04T00:00:00.000' AS DateTime), CAST(N'1993-10-17T00:00:00.000' AS DateTime), N'14 Garrett Hill', N'London', NULL, N'SW1 8JR', 19, N'(71) 555-4848', N'3453', N'Steven Buchanan graduated from St. Andrews University, Scotland, with a BSC degree.  Upon joining the company as a sales representative, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London, where he was promoted to sales manager.  Mr. Buchanan has completed the courses "Successful Telemarketing" and "International Sales Management."  He is fluent in French.', 2)
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (6, N'Suyama', N'Michael', 12, N'Mr.', CAST(N'1963-07-02T00:00:00.000' AS DateTime), CAST(N'1993-10-17T00:00:00.000' AS DateTime), N'Coventry House
Miner Rd.', N'London', NULL, N'EC2 7JR', 19, N'(71) 555-7773', N'428', N'Michael is a graduate of Sussex University (MA, economics) and the University of California at Los Angeles (MBA, marketing).  He has also taken the courses "Multi-Cultural Selling" and "Time Management for the Sales Professional."  He is fluent in Japanese and can read and write French, Portuguese, and Spanish.', 5)
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (7, N'King', N'Robert', 12, N'Mr.', CAST(N'1960-05-29T00:00:00.000' AS DateTime), CAST(N'1994-01-02T00:00:00.000' AS DateTime), N'Edgeham Hollow
Winchester Way', N'London', NULL, N'RG1 9SP', 19, N'(71) 555-5598', N'465', N'Robert King served in the Peace Corps and traveled extensively before completing his degree in English at the University of Michigan and then joining the company.  After completing a course entitled "Selling in Europe," he was transferred to the London office.', 5)
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (8, N'Callahan', N'Laura', 9, N'Ms.', CAST(N'1958-01-09T00:00:00.000' AS DateTime), CAST(N'1994-03-05T00:00:00.000' AS DateTime), N'4726 - 11th Ave. N.E.', N'Seattle', N'WA', N'98105', 20, N'(206) 555-1189', N'2344', N'Laura received a BA in psychology from the University of Washington.  She has also completed a course in business French.  She reads and writes French.', 2)
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (9, N'Dodsworth', N'Anne', 12, N'Ms.', CAST(N'1969-07-02T00:00:00.000' AS DateTime), CAST(N'1994-11-15T00:00:00.000' AS DateTime), N'7 Houndstooth Rd.', N'London', NULL, N'WG2 7LT', 19, N'(71) 555-4444', N'452', N'Anne has a BA degree in English from St. Lawrence College.  She is fluent in French and German.', 5)
ALTER TABLE [dbo].[Contacts]  WITH CHECK ADD  CONSTRAINT [FK_Contacts_ContactType] FOREIGN KEY([ContactTypeIdentifier])
REFERENCES [dbo].[ContactType] ([ContactTypeIdentifier])
GO
ALTER TABLE [dbo].[Contacts] CHECK CONSTRAINT [FK_Contacts_ContactType]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_ContactType] FOREIGN KEY([ContactTypeIdentifier])
REFERENCES [dbo].[ContactType] ([ContactTypeIdentifier])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_ContactType]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Countries] FOREIGN KEY([CountryIdentifier])
REFERENCES [dbo].[Countries] ([CountryIdentifier])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Countries]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contacts', @level2type=N'COLUMN',@level2name=N'ContactId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'First name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contacts', @level2type=N'COLUMN',@level2name=N'FirstName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contacts', @level2type=N'COLUMN',@level2name=N'LastName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Contact Type Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Contacts', @level2type=N'COLUMN',@level2name=N'ContactTypeIdentifier'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'EmployeeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'LastName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'First name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'FirstName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Title' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'TitleOfCourtesy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Birth date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'BirthDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Hiredate' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'HireDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Street' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'Address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Home phone' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'HomePhone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Manager' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'ReportsTo'
GO
