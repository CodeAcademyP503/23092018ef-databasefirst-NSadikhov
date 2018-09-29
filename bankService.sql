use BankDb;


select * from person;



select * from Kredit;


create table Person
(Id int not null primary key identity(1,1),
Name varchar(20) not null,
Surname varchar(20) not null,
PassportNumber varchar(20) not null
);


create table Kredit
(Id int not null primary key identity(1,1),
User_Id int not null foreign key references Person(Id),
Time smalldatetime not null,
Price int not null)