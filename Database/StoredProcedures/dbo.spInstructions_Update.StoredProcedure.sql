USE [RecipesDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spInstructions_Update]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInstructions_Update]
	-- Add the parameters for the stored procedure here
	@RecipeId int,
	@InstructionId int,
	@Instruction nvarchar(1000)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Insert statements for procedure here
	BEGIN TRANSACTION;	
		UPDATE Instructions SET Instruction = @Instruction WHERE RecipeId = @RecipeId AND InstructionId = @InstructionId;

		IF NOT EXISTS (SELECT * FROM Instructions WHERE RecipeId = @RecipeId AND InstructionId = @InstructionId)
		BEGIN
			INSERT INTO Instructions (RecipeId, Instruction) VALUES (@RecipeId, @Instruction)
		END;
	COMMIT;
END
GO
