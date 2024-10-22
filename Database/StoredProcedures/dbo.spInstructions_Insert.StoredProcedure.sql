USE [RecipesDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spInstructions_Insert]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInstructions_Insert]
	-- Add the parameters for the stored procedure here
	@RecipeId int,
	@Instruction nvarchar(1000)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Instructions (RecipeId, Instruction)
	VALUES (@RecipeId, @Instruction);
END
GO
