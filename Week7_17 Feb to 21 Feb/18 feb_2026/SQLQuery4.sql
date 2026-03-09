-- Create Database
CREATE DATABASE UniversityDB;
USE UniversityDB;

-- Departments Table
CREATE TABLE Departments (
    DeptId INT PRIMARY KEY IDENTITY(1,1),
    DeptName NVARCHAR(100) NOT NULL
);

-- Courses Table
CREATE TABLE Courses (
    CourseId INT PRIMARY KEY IDENTITY(1,1),
    CourseName NVARCHAR(100) NOT NULL,
    DeptId INT FOREIGN KEY REFERENCES Departments(DeptId)
);

-- Students Table
CREATE TABLE Students (
    StudentId INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    DeptId INT FOREIGN KEY REFERENCES Departments(DeptId)
);

-- Enrollments Table
CREATE TABLE Enrollments (
    EnrollmentId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT FOREIGN KEY REFERENCES Students(StudentId),
    CourseId INT FOREIGN KEY REFERENCES Courses(CourseId),
    Grade CHAR(2)
);

-- Insert Departments
INSERT INTO Departments (DeptName) VALUES ('Computer Science'), ('Mathematics'), ('Physics');

-- Insert Courses
INSERT INTO Courses (CourseName, DeptId) VALUES 
('Data Structures', 1),
('Algorithms', 1),
('Linear Algebra', 2),
('Quantum Mechanics', 3);

-- Insert Students
INSERT INTO Students (FirstName, LastName, Email, DeptId) VALUES
('Alice', 'Johnson', 'alice@uni.com', 1),
('Bob', 'Smith', 'bob@uni.com', 2),
('Charlie', 'Brown', 'charlie@uni.com', 3);

-- Insert Enrollments
INSERT INTO Enrollments (StudentId, CourseId, Grade) VALUES
(1, 1, 'A'),
(1, 2, 'B'),
(2, 3, 'A'),
(3, 4, 'C');

CREATE PROCEDURE GetStudents
AS
BEGIN
SELECT s.FirstName,s.LastName,s.Email,s.DeptId
from Students s
end;
exec GetStudents;


CREATE PROCEDURE InsertStudent
@FirstName varchar(100),
@LastName varchar(100),
@Email varchar(225),
@DeptId int
As
BEGIN
insert into Students(FirstName,LastName,Email,DeptId)
values (@FirstName,@LastName,@Email,@DeptId)
end;
exec InsertStudent "Raghvi","Sharma","raghvi29sharma@gmail.com",1;

CREATE PROCEDURE UpdateStWithId
@Studentid int,
@FirstName varchar(100),
@LastName varchar(100),
@Email varchar(225),
@DeptId int
As
BEGIN
update Students
set FirstName=@FirstName,LastName=@LastName,Email=@Email,DeptId=@DeptId
where StudentId=@Studentid;
END;
exec UpdateStWithId 2,"Riya","Shah","riya29shah@gmail.com",2;



 


CREATE PROCEDURE GetAllStudents
AS
BEGIN
SELECT s.FirstName,s.LastName,s.Email,c.CourseId,c.CourseName,d.DeptName,d.DeptId
from Students s
inner join Courses c
on s.DeptId=c.DeptId
inner join Departments d 
on c.DeptId=d.DeptId;
end;
exec GetAllStudents;
drop procedure GetAllStudents;

CREATE PROCEDURE UpdateStudentWithId
@StudentId int,
@FirstName varchar(100),
@LastName varchar(100),
@CourseId int,
@CourseName varchar(100),
@DeptName varchar(100),
@DeptId int
As
BEGIN
update Students
set FirstName=@FirstName,LastName=@LastName
where StudentId=@StudentId;
update Courses
set CourseName=@CourseName
where CourseId=@CourseId
update Departments
set DeptName=@DeptName
where DeptId=@DeptId;
END;
drop procedure UpdateStudentWithId;
exec UpdateStudentWithId 2,"Riya","Sharma",2,"Linear Algebra","Mathematics",2;






