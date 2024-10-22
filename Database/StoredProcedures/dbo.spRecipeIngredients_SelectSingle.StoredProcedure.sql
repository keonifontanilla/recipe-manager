USE [RecipesDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spRecipeIngredients_SelectSingle]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRecipeIngredients_SelectSingle] 
	-- Add the parameters for the stored procedure here
	@RecipeId int,
	@IngredientId int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM RecipeIngredients ri
	INNER JOIN Ingredients i
	ON ri.IngredientId = i.IngredientId
	WHERE RecipeId = @RecipeId;
END	
GO
