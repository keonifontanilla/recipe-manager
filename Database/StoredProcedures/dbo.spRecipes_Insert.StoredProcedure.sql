USE [RecipesDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spRecipes_Insert]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRecipes_Insert]
	-- Add the parameters for the stored procedure here
	@RecipeName nvarchar(200),
	@RecipeDescription nvarchar(1000) = null,
	@RecipeType nvarchar(200),
	@RecipeId int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Recipes (RecipeName, RecipeDescription, RecipeType, CreatedDate)
	VALUES (@RecipeName, @RecipeDescription, @RecipeType, GETDATE());

	SELECT @RecipeId = SCOPE_IDENTITY();
END
GO
