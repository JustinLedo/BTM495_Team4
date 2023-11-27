DROP TABLE managers

CREATE TABLE managers
(
id INT PRIMARY KEY IDENTITY (1,1),
username VARCHAR(MAX) NULL,
password VARCHAR(MAX) NULL,
)
INSERT INTO managers (username, password) VALUES ('testM', 'test'); 

SELECT * FROM managers