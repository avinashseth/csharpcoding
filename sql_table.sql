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
