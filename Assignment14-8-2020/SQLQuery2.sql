create database  Assignmnets
use Assignments
create table EmpTb1(
  empId int  primary key identity(100,1),
  empName varchar(20),
  empSal float 
 );
 insert into EmpTb1 values('Sai',30000)
 insert into EmpTb1 values('Siri',20000)
 insert into EmpTb1 values('Mouni',40000)
 insert into EmpTb1 values('Monika',50000)
 insert into EmpTb1 values('Geetha',60000)
 select * from EmpTb1