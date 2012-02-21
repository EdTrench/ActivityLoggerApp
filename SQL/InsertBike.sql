/*
delete from Bike
drop bike
*/

create table Rider
(
	Id uniqueidentifier not null,
	[Weight] int,
	Dob int,
	Category bit
)
constraint PK_Rider_Id 
GO

create table Bike
(
	Id uniqueidentifier not null,
	RiderId uniqueidentifier null,
	Name nvarchar(50),
	[Type] nvarchar(50)
)
primary key constraint PK_Bike_Id
GO

insert into Bike(Id, Name, [Type])
SELECT NEWID(), 'test1', 'test1'
UNION ALL
SELECT newid(), 'test2', 'test2'


select * from Bike
select * from rider

select
	* 
from
	dbo.bike as b
	left join dbo.rider as r on b.RiderId = r.Id