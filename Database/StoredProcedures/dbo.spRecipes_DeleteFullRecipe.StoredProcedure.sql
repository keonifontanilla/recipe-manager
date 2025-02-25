USE [RecipesDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spRecipes_DeleteFullRecipe]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spRecipes_DeleteFullRecipe]
	-- Add the parameters for the stored procedure here
	@RecipeId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	BEGIN TRANSACTION;
		DELETE i FROM Ingredients i 
		INNER JOIN RecipeIngredients ri 
			ON i.IngredientId = ri.IngredientId
		WHERE ri.RecipeId = @RecipeId AND i.IngredientId = ri.IngredientId;

		DELETE FROM Recipes WHERE RecipeId = @RecipeId;
	COMMIT;
END
GO
