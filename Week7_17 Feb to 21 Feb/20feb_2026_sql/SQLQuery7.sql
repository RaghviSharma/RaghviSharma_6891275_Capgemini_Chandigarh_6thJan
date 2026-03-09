CREATE DATABASE RaghviShDB;
GO

USE RaghviShDB;
GO
CREATE TABLE Employeetb
(
    EmpId   INT PRIMARY KEY,
    EmpName VARCHAR(50),
    EmpDesg VARCHAR(50),
    EmpDOJ  DATETIME,
    EmpSal  INT,
    EmpDept INT
);
INSERT INTO Employeetb VALUES
(101,'Raghvi','Developer','2019-06-15',50000,10),
(102,'Amit','Manager','2018-03-20',65000,20),
(103,'Priya','Tester','2020-01-10',42000,30),
(104,'Rahul','Designer','2021-07-05',45000,40);
CREATE PROC SPEmp_Insert
(
    @PEmpId   INT,
    @PEmpName VARCHAR(50),
    @PEmpDesg VARCHAR(50),
    @PEmpDOJ  DATETIME,
    @PEmpSal  INT,
    @PEmpDept INT
)
AS
BEGIN
    INSERT INTO Employeetb
    VALUES (@PEmpId,@PEmpName,@PEmpDesg,@PEmpDOJ,@PEmpSal,@PEmpDept);
END
CREATE PROC SPEmp_Update
(
    @PEmpId   INT,
    @PEmpName VARCHAR(50),
    @PEmpDesg VARCHAR(50),
    @PEmpDOJ  DATETIME,
    @PEmpSal  INT,
    @PEmpDept INT
)
AS
BEGIN
    UPDATE Employeetb
    SET EmpName = @PEmpName,
        EmpDesg = @PEmpDesg,
        EmpDOJ  = @PEmpDOJ,
        EmpSal  = @PEmpSal,
        EmpDept = @PEmpDept
    WHERE EmpId = @PEmpId;
END

CREATE PROC SPEmp_Del
    @PEmpId INT
AS
BEGIN
    DELETE FROM Employeetb
    WHERE EmpId = @PEmpId;
END
CREATE PROC SPGetSal
(
    @PEmpId INT,
    @PEmpSal INT OUTPUT
)
AS
BEGIN
    SELECT @PEmpSal = EmpSal
    FROM Employeetb
    WHERE EmpId = @PEmpId;
END

CREATE PROC SPGetData
(
    @PEmpId   INT,
    @PEmpName VARCHAR(50) OUTPUT,
    @PEmpDesg VARCHAR(50) OUTPUT,
    @PEmpDOJ  DATETIME OUTPUT,
    @PEmpSal  INT OUTPUT,
    @PEmpDept INT OUTPUT
)
AS
BEGIN
    SELECT
        @PEmpName = EmpName,
        @PEmpDesg = EmpDesg,
        @PEmpDOJ  = EmpDOJ,
        @PEmpSal  = EmpSal,
        @PEmpDept = EmpDept
    FROM Employeetb
    WHERE EmpId = @PEmpId;
END

CREATE PROC sp_DelRecP
    @Pempno INT
AS
BEGIN
    DELETE FROM Employeetb
    WHERE EmpId = @Pempno;
END
