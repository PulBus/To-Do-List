---------- Queries to test out To-Do List program

------- Create table that will hold task description, date, and status
CREATE TABLE Tasks (
	Descript NVARCHAR(50), 
	DateCreated DATETIME2(0), 
	Status NVARCHAR(11), 
	StartDate DATETIME2(0), 
	DueDate DATETIME2(0),
	CompletedDate DATETIME2(0),
	RemovedDate DATETIME2(0),
	RemovedFrom NVARCHAR(10)
	);
GO

------- Stored Procedures

----- Insert Tasks
-- Only used to insert tasks into the to-do list
CREATE PROCEDURE InsertTasks
	@Description NVARCHAR(50),
	@DateCreated DATETIME2(0),
	@StartDate DATETIME2(0),
	@DueDate DATETIME2(0)
AS
BEGIN
	INSERT INTO Tasks (
	Descript, 
	DateCreated, 
	Status, 
	StartDate, 
	DueDate
	)
	VALUES (
	@Description, 
	@DateCreated, 
	'To-Do', 
	CONVERT(DATE, @StartDate), 
	DATEADD(SECOND, 86399, @DueDate)) -- Sets the due date to yyyy-mm-dd 23:59:59
END;
GO

----- Remove Tasks
-- Used to remove tasks from to-do list or completed tasks list
CREATE PROCEDURE RemoveTasks
	@ToDelete NVARCHAR(50),
	@Date DATETIME2(0),
	@Status NVARCHAR(10)
AS
BEGIN
	UPDATE Tasks
	SET RemovedFrom = @Status, 
		RemovedDate = @Date,
		Status = 'Removed'
	WHERE @ToDelete = Descript
	AND @Date BETWEEN StartDate AND DueDate
END;
GO

----- Get Tasks
-- Load tasks onto to-do or completed tasks list
CREATE PROCEDURE GetTasks
	@Date DateTime2(0),
	@Status NVARCHAR(10)
AS
BEGIN
	IF @Status = 'To-Do'
	BEGIN
		SELECT Descript
		FROM Tasks
		WHERE (@Date BETWEEN StartDate AND DueDate)
		AND Status = @Status
	END

	IF @Status = 'Completed'
	BEGIN
		SELECT Descript
		FROM Tasks
		WHERE @Date = CONVERT(date, CompletedDate)
		AND @Status = Status
	END

	ELSE
	BEGIN
		SELECT Descript
		FROM Tasks
		WHERE @Date = RemovedDate
		AND @Status = Status
	END
END;
GO

----- Complete Tasks
-- Transfers tasks from to-do to completed list
CREATE PROCEDURE CompleteTasks
	@ToComplete NVARCHAR(50),
	@TaskDate DATETIME2(0)
AS
BEGIN
	UPDATE Tasks
	SET Status = 'Completed', 
		CompletedDate = CONVERT(DATETIME2(0), GETDATE()) -- Sets CompletedDate to "Today's" date
	WHERE Descript = @ToComplete
	AND @TaskDate BETWEEN StartDate AND DueDate
END;
GO

----- Delete Tasks
-- Deletes task from removed list
CREATE PROCEDURE DeleteTasks
	@ToDelete NVARCHAR(50),
	@Date DATETIME2(0)
AS
BEGIN
	DELETE FROM Tasks
	WHERE @ToDelete = Descript
	AND @Date = RemovedDate
END;
GO

----- Recover Tasks
-- Recovers task from removed list and returns it to the list it was removed from
CREATE PROCEDURE RecoverTasks
	@ToRecover NVARCHAR(50),
	@Date DATETIME2(0)
AS
BEGIN
	UPDATE Tasks
	SET Status = RemovedFrom, 
		RemovedFrom = NULL, 
		RemovedDate = NULL
	WHERE @ToRecover = Descript
	AND @Date = RemovedDate
END;
GO

----- View Overdue Tasks
-- Returns tasks due before current day
CREATE PROCEDURE OverdueTasks
AS
BEGIN
	SELECT 'Task: ' + Descript + '. Due by: ' + CONVERT(NVARCHAR, CAST(DueDate AS DATE)) AS OverdueTask
	FROM Tasks
	WHERE CONVERT(DATETIME2(0), GETDATE()) > DueDate
	AND Status <> 'Completed'
END;
GO


select * from tasks

update tasks
set status = 'Removed'
where status = 'Completed'


DELETE FROM Tasks
WHERE Status = 'Removed'
