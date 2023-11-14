DROP TABLE if exists #Employee;

CREATE TABLE #Employee (
    ID INT,
    Name NVARCHAR(255),
    Salary INT
);

INSERT INTO #Employee (ID, Name, Salary)
VALUES
    (1001, 'Robert', 75000),
    (1002, 'Andy', 80000),
    (1003, 'William', 65000),
    (1004, 'Faisal', 60000),
    (1005, 'Jerry', 75000);

SELECT ID, Name, Salary
FROM #Employee
WHERE Salary = (
    SELECT DISTINCT Salary
    FROM #Employee
    ORDER BY Salary DESC
    OFFSET 1 ROWS
    FETCH NEXT 1 ROWS ONLY
);

