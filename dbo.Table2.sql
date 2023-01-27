CREATE TABLE [dbo].[Table]
(
	[SCode] INT NOT NULL PRIMARY KEY, 
    [Employee] INT NOT NULL, 
    [Attendance] INT NOT NULL, 
    [Period] VARCHAR(100) NOT NULL, 
    [Amount] INT NOT NULL, 
    [PayDate] DATE NOT NULL
)
