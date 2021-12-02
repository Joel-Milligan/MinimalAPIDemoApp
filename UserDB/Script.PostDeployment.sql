IF (SELECT COUNT(*) FROM [dbo].[User]) = 0
BEGIN
	INSERT INTO [dbo].[User] (FirstName, LastName)
	VALUES ('Joel', 'Milligan'), 
	('Hannah', 'Spencer'), 
	('Leigh', 'Blagden'), 
	('Zak', 'Kazakoff');
END