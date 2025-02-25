USE [RecipesDatabase]
GO
/****** Object:  Table [dbo].[Instructions]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructions](
	[InstructionId] [int] IDENTITY(1,1) NOT NULL,
	[RecipeId] [int] NOT NULL,
	[Instruction] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Instructions] PRIMARY KEY CLUSTERED 
(
	[InstructionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Instructions]  WITH CHECK ADD  CONSTRAINT [FK_Instructions_RecipeId] FOREIGN KEY([RecipeId])
REFERENCES [dbo].[Recipes] ([RecipeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Instructions] CHECK CONSTRAINT [FK_Instructions_RecipeId]
GO
