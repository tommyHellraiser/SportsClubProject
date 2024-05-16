  
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

    SET postulantExists = (SELECT COUNT(*) FROM postulants WHERE DocumentType = NewDocumentType AND Document = NewDocument);

    IF postulantExists = 1 THEN
        SET Response = -1;
    ELSE
        INSERT INTO postulants(FirstName, LastName, DocumentType, Document) 
            VALUES(NewName, NewLastName, NewDocumentType, NewDocument);
        SET Response = (SELECT MAX(ID) FROM postulants);
    END IF;
END;
