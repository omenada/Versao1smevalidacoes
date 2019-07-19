

USE apartment;

GO 

CREATE SCHEMA ato ;


GO

/****** Object:  Table [dbo].[apart]    Script Date: 7/14/2019 5:22:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[apart](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[owner_name] [nvarchar](50) NULL,
	[family_member] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[gender] [nvarchar](50) NULL,
	[mobile] [nvarchar](50) NULL,
	[wing] [nvarchar](50) NULL,
	[floor] [nvarchar](50) NULL,
	[flat_number] [nvarchar](50) NULL,
	[area] [nvarchar](50) NULL,
	[c_position] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[entry](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[person_name] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[time] [nvarchar](50) NULL,
	[vehicle_type] [nvarchar](50) NULL,
	[veh_no] [nvarchar](50) NULL,
	[owner] [nvarchar](50) NULL,
	[flat_no] [nvarchar](50) NULL,
	[wing] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[parking](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[brand_name] [nvarchar](50) NULL,
	[model] [nvarchar](50) NULL,
	[year] [nvarchar](50) NULL,
	[veh_type] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[register](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[gender] [nvarchar](50) NULL,
	[mobile] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[position] [nvarchar](50) NULL,
	[pass] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



