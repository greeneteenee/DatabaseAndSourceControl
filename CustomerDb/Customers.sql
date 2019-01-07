CREATE TABLE Customer
(
	ID		INT			PRIMARY KEY IDENTITY
	, Name	VARCHAR(30)	NOT NULL	
)

INSERT INTO Customer 
VALUES ('Joe')
	, ('Ken')
	, ('Jim')
	, ('Pam')