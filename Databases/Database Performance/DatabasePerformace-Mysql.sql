CREATE TABLE Logs(
LogId INT NOT NULL AUTO_INCREMENT,
LogDate DATETIME NOT NULL,
LogText VARCHAR(50),
CONSTRAINT PK_Logs_LogId PRIMARY KEY(LogId, LogDate)
) PARTITION BY RANGE(YEAR(LogDate)) (
    PARTITION p0 VALUES LESS THAN (1990),
    PARTITION p1 VALUES LESS THAN (2000),
    PARTITION p2 VALUES LESS THAN (2010),
    PARTITION p3 VALUES LESS THAN MAXVALUE
);

DELIMITER //

CREATE PROCEDURE populateLogs ()
BEGIN
	DECLARE counter INT DEFAULT 0;
	WHILE counter < 1000000 DO
		INSERT INTO Logs(LogDate, LogText)
		VALUES(TIMESTAMPADD(DAY, FLOOR(1 + RAND() * 15000), '1980-01-01'), counter);
		SET counter = counter + 1;
	END WHILE;
END//

CALL populateLogs ();

SELECT * FROM Logs PARTITION(p1);

SELECT * FROM Logs WHERE YEAR(LogDate) = 1995;