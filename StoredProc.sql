Create table Employee
(
EmployeeId int primary key,
EmployeeName varchar(50) not null,
EmployeeSalary money check(EmployeeSalary >= 25000),
EmployeeType char(1) check(EmployeeType in('C','P'))
)

go
sp_help Employee
go
Create Proc usp_InsertEmployee
as
begin
Select * from Employee
end


exec usp_InsertEmployee

go
Alter Proc usp_InsertEmployee(@EmployeeId int, @EmployeeName varchar(50),@EmployeeSalary money,@EmployeeType char(1))
as
begin
if(	LEN(@EmployeeName) < 3)
	return -1;
if(	LEN(@EmployeeName) > 20)
	return -2;
if(@EmployeeSalary < 25000)
	return -3;
if(@EmployeeType not in ('P','C'))
	return -4;
else
	if(not exists(Select 'a' from Employee Where EmployeeId = @EmployeeId))
		begin
			Insert Employee(EmployeeId, EmployeeName,EmployeeSalary,EmployeeType) values(@EmployeeId, @EmployeeName,@EmployeeSalary,@EmployeeType)
			-- SET @Id = IDENT_CURRENT('Employee')
		end
	else
		return -5

 
end

Insert Employee(EmployeeId, EmployeeName,EmployeeSalary,EmployeeType) values(1,'Srinivas',50000,'P')
Select * from Employee

exec usp_InsertEmployee