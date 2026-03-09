CREATE DATABASE CollegeDB;
USE CollegeDB;
CREATE TABLE Student (
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50),
    Age INT,
    Course VARCHAR(30)
);
INSERT INTO Student (StudentID, Name, Age, Course)
VALUES (1, 'Raghvi', 21, 'Computer Science');

INSERT INTO Student (StudentID, Name, Age, Course)
VALUES (2, 'Aman', 22, 'Information Technology');

INSERT INTO Student (StudentID, Name, Age, Course)
VALUES (3, 'Neha', 20, 'Data Science');
Select * from Student;

