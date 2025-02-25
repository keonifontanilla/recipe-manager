USE [RecipesDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spIngredients_Insert]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spIngredients_Insert]
	-- Add the parameters for the stored procedure here
	@Ingredient nvarchar(200),
	@IngredientId int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Ingredients (Ingredient) VALUES (@Ingredient);

	SELECT @IngredientId = SCOPE_IDENTITY();
END
GO
