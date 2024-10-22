USE [RecipesDatabase]
GO
/****** Object:  StoredProcedure [dbo].[spInstructions_Delete]    Script Date: 2/12/2021 2:01:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInstructions_Delete]
	-- Add the parameters for the stored procedure here
	@InstructionId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM Instructions WHERE InstructionId = @InstructionId;
END
GO
