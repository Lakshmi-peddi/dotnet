
create proc Sp_Update1
@EmpId int,
@EmpName VarChar(20),
@EmpSal float
as
begin
update EmpTb1 set empName=@EmpName,empSal=@EmpSal where empId=@EmpId
end