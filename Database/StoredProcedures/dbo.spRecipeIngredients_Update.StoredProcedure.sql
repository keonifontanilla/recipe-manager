USE [RecipesDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spRecipeIngredients_Update]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spRecipeIngredients_Update] 
	-- Add the parameters for the stored procedure here
	@RecipeId int,
	@IngredientId int,
	@IngredientQuantity nvarchar(50),
	@IngredientUnit nvarchar(50),
	@Ingredient nvarchar(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	BEGIN TRANSACTION;
		UPDATE RecipeIngredients SET IngredientQuantity = @IngredientQuantity, IngredientUnit = @IngredientUnit WHERE RecipeId = @RecipeId AND IngredientId = @IngredientId;

		UPDATE Ingredients SET Ingredient = @Ingredient WHERE IngredientId = @IngredientId;

		IF NOT EXISTS (SELECT * FROM RecipeIngredients WHERE RecipeId = @RecipeId AND IngredientId = @IngredientId)
		BEGIN
			INSERT INTO Ingredients (Ingredient) VALUES (@Ingredient);
			INSERT INTO RecipeIngredients (RecipeId, IngredientId, IngredientQuantity, IngredientUnit)
			VALUES (@RecipeId, SCOPE_IDENTITY(), @IngredientQuantity, @IngredientUnit);
		END;
	COMMIT;
END
GO
