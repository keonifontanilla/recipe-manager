USE [RecipesDatabase]
GO
/****** Object:  Table [dbo].[RecipeIngredients]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecipeIngredients](
	[RecipeIngredientId] [int] IDENTITY(1,1) NOT NULL,
	[RecipeId] [int] NOT NULL,
	[IngredientId] [int] NOT NULL,
	[IngredientQuantity] [nvarchar](50) NOT NULL,
	[IngredientUnit] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_RecipeIngredients] PRIMARY KEY CLUSTERED 
(
	[RecipeIngredientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RecipeIngredients]  WITH CHECK ADD  CONSTRAINT [FK_RecipeIngredients_IngredientId] FOREIGN KEY([IngredientId])
REFERENCES [dbo].[Ingredients] ([IngredientId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RecipeIngredients] CHECK CONSTRAINT [FK_RecipeIngredients_IngredientId]
GO
ALTER TABLE [dbo].[RecipeIngredients]  WITH CHECK ADD  CONSTRAINT [FK_RecipeIngredients_RecipeId] FOREIGN KEY([RecipeId])
REFERENCES [dbo].[Recipes] ([RecipeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RecipeIngredients] CHECK CONSTRAINT [FK_RecipeIngredients_RecipeId]
GO
