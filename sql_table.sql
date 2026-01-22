create table students (
    id int not null primary key,
    student_name nvarchar(100) not null,
    student_email nvarchar(255) null,
    student_mobile varchar(15) not null
);

/* insert data */
insert into students (id, student_name, student_mobile) values (1,'Avinash Seth', '9876543210');
go
/* insert data */
**************************************************
select * from students;
go
**************************************************
select * from students where id = 1;
go
**************************************************
update students set student_email = 'avinash@google.com' where id = 1;
go
**************************************************
delete from students where id = 2;
go
**************************************************
dotnet add package Microsoft.Data.SqlClient
**************************************************
