CREATE TABLE [dbo].[EmployeeTbl]
(
	[EmpId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmpName] VARCHAR(50) NOT NULL, 
    [EmpGen] VARCHAR(10) NOT NULL, 
    [EmpDep] INT NOT NULL, 
    [EmpDDB] DATE NOT NULL, 
    [EmpDate] DATE NOT NULL, 
    [EmpSal] INT NOT NULL
)
