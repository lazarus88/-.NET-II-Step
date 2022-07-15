--1. დაწერეთ sql რომელიც ააგებს შესაბამის table-ებს.
IF OBJECT_ID('tempdb..#teacher') IS NOT NULL
    BEGIN
        DROP TABLE #teacher;
    END;

create table #teacher
	(
		Teacher_ID int IDENTITY(1,1),
		Name varchar(150),
		Lastname varchar(150),
		sex varchar(100),
		Subject varchar(150),
		Pupil_ID int	
	)

	


insert into #teacher
values	('Natela','Pachuashvili','female','Math',1),
		('Makvala','Tskhadadze','female','physics',6),
		('Goderdzi','Maisuradze','Transgender','literature',1),
		('Tamar','Gunia','Does not know','History',4),
		('Genadi','abashidze','sometimes male, sometimes female','Biology',3),
		('Ambako','julukhidze','Male','Chemistry',2)



IF OBJECT_ID('tempdb..#Pupil') IS NOT NULL
    BEGIN
        DROP TABLE #Pupil;
    END;



create table #Pupil
	(
		Pupil_ID int IDENTITY(1,1),
		Name varchar(150),
		Lastname varchar(150),
		sex varchar(100),
		Subject varchar(150),
		Teacher_ID	int
	)


insert into #Pupil
values	('Giorgi','abuladze','male','5',1),
		('luka','malutashvili','male','9',1),
		('guja','abramishvili','male','12',4),
		('lana','beraia','female','7',5),
		('mariam','axalaia','female','7',6),
		('amirani','metreveli','male','5',3),
		('Gigi','dvali','male','8',4),
		('ana','beraia','female','10',3)


--თუ Teacher_ID-ით გადავაბამთ წამოგვიღებს მასწავლებლების შესაბამის მოსწავლეებს
select p.Name,p.Lastname from #teacher t
join #Pupil p on t.Teacher_ID=p.Teacher_ID 
where t.Name='Natela'

--თუ Pupil_ID-ით გადავაბამთ წამოგვიღებს მოსწავლეზე შესაბამის მასწავლებლებს
select * from #teacher t
join #Pupil p on t.Pupil_ID=p.Pupil_ID



--2. დაწერეთ sql რომელიც დააბრუნებს ყველა მასწავლებელს, რომელიც ასწავლის მოსწავლეს, რომელის სახელია: „გიორგი“ 

select t.Name,t.Lastname from #teacher t
join #Pupil p on t.Pupil_ID=p.Pupil_ID
where p.Name='Giorgi'