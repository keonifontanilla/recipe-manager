USE [RecipesDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spRecipes_Update]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRecipes_Update] 
	-- Add the parameters for the stored procedure here
	@RecipeId int,
	@RecipeName nvarchar(200),
	@RecipeDescription nvarchar(1000) = null,
	@RecipeType nvarchar(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Recipes 
	SET RecipeName = @RecipeName, RecipeDescription = @RecipeDescription, RecipeType = @RecipeType, UpdatedDate = GETDATE()
	WHERE RecipeId = @RecipeId;
END
GO
