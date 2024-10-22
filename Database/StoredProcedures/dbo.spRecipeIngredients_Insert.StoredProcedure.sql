USE [RecipesDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spRecipeIngredients_Insert]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRecipeIngredients_Insert]
	-- Add the parameters for the stored procedure here
	@RecipeId int,
	@IngredientId int,
	@IngredientQuantity nvarchar(50),
	@IngredientUnit nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO RecipeIngredients (RecipeId, IngredientId, IngredientQuantity, IngredientUnit)
	VALUES (@RecipeId, @IngredientId, @IngredientQuantity, @IngredientUnit);
END
GO
