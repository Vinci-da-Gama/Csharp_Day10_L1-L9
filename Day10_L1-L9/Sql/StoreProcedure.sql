-- Create a new stored procedure called 'SelectAllCustomers' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'SelectAllCustomers'
)
DROP PROCEDURE SelectAllCustomers
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE SelectAllCustomers
AS
BEGIN
	-- Select rows from a Table or View 'SelectAllCustomer' in schema 'dbo'
	SELECT * FROM Customers
END
GO
-- Select All Customers
Exec SelectAllCustomers



-- Create a new stored procedure called 'GetCustomerByState' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
	FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
	AND SPECIFIC_NAME = N'GetCustomerByState'
)
DROP PROCEDURE GetCustomerByState
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE GetCustomerByState
	@state varchar(26)
AS
BEGIN
	SELECT c.FirstName, c.LastName, c.Email From dbo.Customers c Where c.State = @state
	Return
END
GO
-- Get Customer by State
Declare @state varchar(26)
Exec GetCustomerByState @state