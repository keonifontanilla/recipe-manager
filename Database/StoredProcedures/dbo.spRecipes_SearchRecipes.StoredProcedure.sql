USE [RecipesDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spRecipes_SearchRecipes]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRecipes_SearchRecipes]
	-- Add the parameters for the stored procedure here
	@RecipeName nvarchar(200),
	@RecipeType nvarchar(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		IF @RecipeType = 'All'
		BEGIN 
			SELECT * FROM Recipes WHERE RecipeName LIKE @recipeName
		END
		ELSE
		BEGIN 
			SELECT * FROM Recipes WHERE RecipeName LIKE @recipeName AND RecipeType = @RecipeType;
		END
END
GO
