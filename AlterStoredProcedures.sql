---------- Queries to update existing Stored Procedures

----- InsertTasks
ALTER PROCEDURE [dbo].[InsertTasks]
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
	CONVERT(DATE, @DueDate))
END
GO

----- RemoveTasks
ALTER PROCEDURE [dbo].[RemoveTasks]
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
END
GO

----- GetTasks
ALTER PROCEDURE [dbo].[GetTasks]
	@Date DATETIME2(0),
	@Status NVARCHAR(11)
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
		WHERE @Date = CompletedDate
		AND @Status = Status
	END

	ELSE
	BEGIN
		SELECT Descript
		FROM Tasks
		WHERE @Date = RemovedDate
		AND @Status = Status
	END
END
GO

----- CompleteTasks
ALTER PROCEDURE [dbo].[CompleteTasks]
	@ToComplete NVARCHAR(50),
	@TaskDate DATETIME2(0),
	@CompletedDate DATETIME2(0)
AS
BEGIN
	UPDATE Tasks
	SET Status = 'Completed',
		CompletedDate = @CompletedDate
	WHERE Descript = @ToComplete
	AND @TaskDate BETWEEN StartDate AND DueDate
END
GO

----- DeleteTasks
ALTER PROCEDURE DeleteTasks
	@ToDelete NVARCHAR(50),
	@Date DATETIME2(0)
AS
BEGIN
	DELETE FROM Tasks
	WHERE @ToDelete = Descript
	AND @Date = RemovedDate
END
GO

----- RecoverTasks
ALTER PROCEDURE RecoverTasks
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