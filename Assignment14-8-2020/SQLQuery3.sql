create proc Sp_Insert
@EmpName varchar(20),
@EmpSal float
as
begin
insert into EmpTb1(EmpName,EmpSal) values (@EmpName,@EmpSal)
end