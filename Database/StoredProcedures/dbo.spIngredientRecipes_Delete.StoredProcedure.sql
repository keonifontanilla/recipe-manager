USE [RecipesDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spIngredientRecipes_Delete]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIngredientRecipes_Delete]
	-- Add the parameters for the stored procedure here
	@IngredientId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	BEGIN TRANSACTION;
		DELETE FROM RecipeIngredients WHERE IngredientId = @IngredientId;

		DELETE FROM Ingredients WHERE IngredientId = @IngredientId;
	COMMIT;
END
GO
