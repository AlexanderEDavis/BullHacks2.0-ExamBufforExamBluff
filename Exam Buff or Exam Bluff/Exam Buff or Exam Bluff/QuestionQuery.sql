/*
Run this to create the database, DO NOT USE THE ONE YOU ORIGINALLY MADE, 
 this one will actually auto-increment the ID field. 

 Bare in mind that deleting a record will not adjust the ID fields
 to be contiguous again, there will be a gap.
*/


-- Comment lines out using "--" where you see /* to enable that function, then run the query.
-- When you don't want the method to run, remove the "--" you added.

	/*
CREATE TABLE [dbo].[Questions] (
    [Id]            INT IDENTITY(1,1) PRIMARY KEY,
    [Question]      VARCHAR(50) NOT NULL,
    [Answer1]       VARCHAR(50) NOT NULL,
    [Answer2]       VARCHAR(50) NOT NULL,
    [Answer3]       VARCHAR(50) NOT NULL,
    [Answer4]       VARCHAR(50) NOT NULL,
    [CorrectAnswer] VARCHAR(50) NOT NULL
);
--*/

DECLARE @Id varchar(50)
DECLARE @Question varchar(50)
DECLARE @Answer1 varchar(50)
DECLARE @Answer2 varchar(50)
DECLARE @Answer3 varchar(50)
DECLARE @Answer4 varchar(50)
DECLARE @CorrectAnswer varchar(50)

-- Fill out values in the SET statements below and then run the code blocks below.

SET @Id = '' -- Only used if deleting records

SET @Question = 'Which is not a correct type of a computer?'
SET @Answer1 = 'Mini Frame Computer'
SET @Answer2 = 'Super Computer'
SET @Answer3 = 'Workstations'
SET @Answer4 = 'Personal Computer'
SET @CorrectAnswer = 'Answer1'

	--/*
INSERT into dbo.Questions (
Question,
Answer1,
Answer2,
Answer3,
Answer4,
CorrectAnswer
) VALUES (
@Question,
@Answer1,
@Answer2,
@Answer3,
@Answer4,
@CorrectAnswer
)
--*/

	/*
DELETE FROM Questions
WHERE Id = @Id
--*/

--SELECT * FROM dbo.Questions