
CREATE PROCEDURE NewPostulant(
    IN NewName VARCHAR(30),
    IN NewLastName VARCHAR(40),
    IN NewDocumentType VARCHAR(20),
    IN NewDocument INT,
    OUT Response INT
)
BEGIN
    DECLARE NewID INT DEFAULT 0;
    DECLARE postulantExists INT DEFAULT 0;
    DECLARE currentDate DATE;
    DECLARE expirationDate DATE;

    SET postulantExists = (SELECT COUNT(*) FROM postulants WHERE DocumentType = NewDocumentType AND Document = NewDocument);

    IF postulantExists = 1 THEN
        SET Response = -1;
    ELSE
        SET currentDate = CURDATE();
        SET expirationDate = DATE_ADD(currentDate, INTERVAL 30 DAY);

        INSERT INTO postulants(FirstName, LastName, DocumentType, Document, InscriptionDate, ExpirationDate) 
            VALUES(NewName, NewLastName, NewDocumentType, NewDocument, currentDate, expirationDate);
        SET Response = (SELECT MAX(ID) FROM postulants);
    END IF;
END;

