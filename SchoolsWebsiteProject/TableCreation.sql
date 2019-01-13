drop database team39
create database team39
create table Schools 
(
name varchar(40) primary key,
address_home varchar(40),
phone_num int,
email varchar(40) unique,
gen_information varchar(100),
vision varchar(100),
mission varchar(100),
main_language varchar(15),
s_type varchar(40),
fees int,
begin_grade int,
end_grade int
)

create table Elementaries
(
name varchar(40) primary key foreign key references Schools(name) on update cascade on delete cascade,
supplies_list varchar (100)
)

create table Middles
(
name varchar(40) primary key foreign key references Schools(name) on update cascade on delete cascade
)

create table Highs
(
name varchar(40) primary key foreign key references Schools(name) on update cascade on delete cascade
)

create table Levels
(
name varchar(40) primary key
)

create table Elemntaries_have_levels
(
e_name varchar(40) primary key foreign key references Elementaries(name) on update cascade on delete cascade,
level_name varchar(40) foreign key references Levels(name) on update cascade on delete cascade
)

create table Middles_have_levels
(
m_name varchar(40) primary key foreign key references Middles(name) on update cascade on delete cascade,
level_name varchar(40) foreign key references Levels(name) on update cascade on delete cascade
)

create table Highs_have_levels
(
h_name varchar(40) primary key foreign key references Highs(name) on update cascade on delete cascade,
level_name varchar(40) foreign key references Levels(name) on update cascade on delete cascade
)

create table Parents
(
ssn int primary key ,
f_name varchar(40),
m_name varchar(40),
l_name varchar(40),
username varchar(40) unique,
pass varchar(40),
email varchar(40) unique,
home_address varchar(40)
)

create table Parents_have_PhoneNumber
(
h_num int,
ssn int foreign key references Parents(ssn) on update cascade on delete cascade,
primary key(h_num,ssn) 
)

create table Parents_have_MobileNumber
(
m_num int,
ssn int foreign key references Parents(ssn) on update cascade on delete cascade,
primary key(m_num,ssn) 
)

create table Children
(
c_ssn int primary key,
name varchar(40),
gender char(1),
birth_date datetime,
age as (year(current_timestamp)-year(birth_date)),
ssn int foreign key references Parents(ssn) on update cascade on delete cascade
)

create table Students
(
username varchar(40) unique,
pass varchar(40),
c_ssn int primary key foreign key references Children(c_ssn) on update cascade on delete cascade,
s_name varchar(40) foreign key references Schools(name)  on update cascade on delete cascade,
)

create table Levels_Enroll_Students
(
c_ssn int primary key foreign key references Students(c_ssn) on update cascade on delete cascade,
level_name varchar(40) foreign key references Levels(name) on update cascade on delete cascade,
)

create table Parents_review_Schools
(
s_name varchar(40) foreign key references Schools(name) on update cascade on delete cascade,
ssn int foreign key references Parents(ssn) on update cascade on delete cascade,
review varchar(100),
primary key(s_name,ssn)
)
--comment
create table Children_ApplyBy_Parents_in_Schools
(
s_name varchar(40) foreign key references Schools(name) on update cascade on delete cascade,
ssn int foreign key references Parents(ssn),
c_ssn int foreign key references Children(c_ssn),
accepted bit default null,
primary key(s_name,c_ssn)
)

create table Clubs
(
club_name varchar(40) primary key,
purpose varchar(100),
h_name varchar(40) foreign key references Highs(name) on update cascade on delete cascade
)


create table Clubs_JoinedBy_Students
(
club_name varchar(40) foreign key references Clubs(club_name) on update cascade on delete cascade,
st_username varchar(40) foreign key references Students(username),
primary key(club_name, st_username)
)

create table Employees
(
ID int primary key IDENTITY, 
username varchar(40),
pass varchar(40),
f_name varchar(40),
m_name varchar(40),
l_name varchar(40),
birthdate datetime,
e_address varchar(40) unique,
email varchar(40),
gender varchar(1),
salary int,
s_name varchar(40) foreign key references Schools(name) on update cascade on delete cascade,
)


create table Teachers
(
years_of_experience int not null,
ID int primary key foreign key references Employees(ID) on update cascade on delete cascade,
)

Create table Seniors
(
ID int foreign key references Teachers(ID) on update cascade on delete cascade,
primary key(ID)
)

create table Not_Seniors
(
ID int foreign key references Teachers(ID) on update cascade on delete cascade,
supervisor int foreign key references Seniors(ID) on update no action on delete no action,
primary key(ID)
)

create table Parents_rate_Teachers
(
rating int,
ssn int foreign key references Parents(ssn) on update cascade on delete cascade,
ID int foreign key references Teachers(ID) on update cascade on delete cascade,
primary key(ID)
)

create table Adminstrators
(
ID int primary key foreign key references Employees(ID) on update cascade on delete cascade,
)

create table Courses
(
name varchar(40),
code varchar(15) primary key,
c_description varchar(100),
p_code varchar(15) foreign key references Courses(code),
c_level varchar(40) foreign key references Levels(name) on update cascade on delete cascade,
grade int
)

create table Courses_TeachedTo_Students_By_Teachers
(
st_username varchar(40) foreign key references Students(username) on update cascade on delete cascade,
ID int foreign key references Teachers(ID) on update No Action on delete NO Action,
code varchar(15) foreign key references Courses(code) on update cascade on delete cascade,
primary key (code, ID, st_username)
)

create table Announcements
(
id int primary key identity,
an_date datetime,
ann_description varchar(100),
title varchar(40),
acc_type varchar(40),
admin_ID int foreign key references Adminstrators(ID) on update cascade on delete cascade,
)

create table Activities
(
id int primary key identity,
ac_date datetime,
ac_description varchar(100),
ac_type varchar(40),
ac_location varchar(40),
equipment varchar(40)
)

create table Activities_ParticipatedBy_Students
(
ac_id int foreign key references Activities(id) on update cascade on delete cascade,
st_username varchar(40) foreign key references Students(username) on update cascade on delete cascade,
primary key(ac_id,st_username)
)

create table Activities_assignedBy_Adminstrators_to_Teachers
(
a_ID int foreign key references Adminstrators(ID) on update No Action on delete No Action,
ac_id int foreign key references Activities(id) on update No Action on delete No Action,
ID int foreign key references Teachers(ID) on update cascade on delete cascade,
primary key(a_ID,ID,ac_id)
)



create table Courses_have_Questions_postedBy_Students
(
q_id int primary key Identity,
st_username varchar(40) foreign key references Students(username) on update cascade on delete cascade,
c_code varchar(15) foreign key references Courses(code) on update cascade on delete cascade,
content varchar(100),
answer varchar(100)
)

create table Assignments
(
ass_id int primary key identity,
posting_date datetime,
content varchar(40),
duedate datetime
)
create table Assignments_viewedBy_Students -- added
(
ass_id int foreign key references Assignments(ass_id) on update cascade on delete cascade,
st_username varchar(40) foreign key references Students(username) on update cascade on delete cascade,
c_code varchar(15) foreign key references Courses(code) on update cascade on delete cascade
)



create table Assignments_SolvedBy_Students
(
st_username varchar(40) foreign key references Students(username) on update cascade on delete cascade,
ass_id int foreign key references Assignments(ass_id) on update cascade on delete cascade,
c_code varchar(15) foreign key references Courses(code) on update cascade on delete cascade,  -- added
solution varchar(100), --added
grade int , -- added
primary key(st_username,ass_id) );



create table Assignments_postedBy_Teachers
(

ass_id int foreign key references Assignments(ass_id) on update cascade on delete cascade,
c_code varchar(15) foreign key references Courses(code) on update cascade on delete cascade,  -- added
ID int foreign key references Teachers(ID) on update cascade on delete cascade,
primary key(ID)
)

create Table Reports
(
r_id int primary key identity,
issue_date datetime,
teacher_comment varchar(100)
)

create table Parents_View_Reports
(
ssn int foreign key references Parents(ssn) on update cascade on delete cascade, 
r_id int foreign key references Reports(r_id) on update cascade on delete cascade,
primary key(ssn,r_id)
)

create table Parents_Reply_Reports
(
ssn int foreign key references Parents(ssn) on update cascade on delete cascade, 
r_id int foreign key references Reports(r_id) on update cascade on delete cascade,
reply varchar(100)
primary key(ssn,r_id)
)

create table Reports_isWrittenAbout_Students_By_Teachers
(
st_username varchar(40) foreign key references Students(username) on update cascade on delete cascade,
r_id int foreign key references Reports(r_id) on update cascade on delete cascade,
ID int foreign key references Teachers(ID) on update No action on delete no action,
primary key(ID,st_username,r_id)
)

create table sysAdminstrator(
username varchar(40) unique,
pass varchar(40),
primary key(username, pass)
)
