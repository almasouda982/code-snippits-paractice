--- use master


create table courses(

course_id int,
course_title varchar(60) not null,
price decimal(8,2),
start_date Date default getdate() + 7,
duration int,


constraint courses_course_id_PK primary key(course_id),
constraint courses_course_titile_CK check (price between 800 and 3000),
constraint courses_duration_CK check (duration between 12 and 120),
);

select * 
from courses




create table projects(

project_id int,
project_name varchar(60) not null,
client_name varchar(60),
hour_rate DECIMAL(10,2),


constraint projects_project_id_PK primary key(project_id),
constraint projects_hour_rate_CK check (hour_rate > 1)


);

drop table projects

select *
from projects

select *
from courses

select *
from tasks

create table tasks(


task_id int,
description varchar(255),
start_date Date default getdate(),
end_date Date,
project_id int,


constraint tasks_task_id_PK Primary Key(task_id),
constraint tasks_end_date_CK check(end_date > start_Date),
constraint tasks_project_id_FK FOREIGN KEY(project_id) REFERENCES projects(project_id),

);
