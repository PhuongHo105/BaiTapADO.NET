create database Cattle;

use Cattle;

create table Cattles 
(
	ID int identity(1,1) primary key,
	type char(10), 
	min_Milk tinyint,
	max_Milk tinyint,
	cry char(20)
)

insert into Cattles(type, min_Milk, max_Milk, cry) values ('Cow', 0, 20, 'Moo moo...'), ('Sheep', 0, 5, 'Baa baa...'), ('Goat', 0, 10, 'Meh meh...')


