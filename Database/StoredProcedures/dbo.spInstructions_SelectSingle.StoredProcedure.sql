USE [RecipesDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spInstructions_SelectSingle]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInstructions_SelectSingle] 
	-- Add the parameters for the stored procedure here
	@RecipeId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Instructions
	WHERE RecipeId = @RecipeId;
END
GO
