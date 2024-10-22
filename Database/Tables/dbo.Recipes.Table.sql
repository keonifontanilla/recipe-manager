USE [RecipesDatabase]
GO
/****** Object:  Table [dbo].[Recipes]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recipes](
	[RecipeId] [int] IDENTITY(1,1) NOT NULL,
	[RecipeName] [nvarchar](200) NOT NULL,
	[RecipeDescription] [nvarchar](1000) NULL,
	[RecipeType] [nvarchar](200) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Recipes] PRIMARY KEY CLUSTERED 
(
	[RecipeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Recipes] ADD  CONSTRAINT [DF_Recipes_RecipeDescription]  DEFAULT (NULL) FOR [RecipeDescription]
GO
ALTER TABLE [dbo].[Recipes] ADD  CONSTRAINT [DF_Recipes_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
