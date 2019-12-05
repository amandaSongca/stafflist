Alter PROCEDURE EmployeesToUpdate
    @EmployeeID INT,
    @YearsInExperience INT
AS
BEGIN
UPDATE dbo.Employees
    SET YearsInExperience = @YearsInExperience
        WHERE EmployeeID = @EmployeeID
END