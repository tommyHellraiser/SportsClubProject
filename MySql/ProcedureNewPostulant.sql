  
CREATE PROCEDURE NewPostulant(
    IN Nam VARCHAR(30),
    IN LstN VARCHAR(40),
    IN Typ VARCHAR(20),
    IN DocP INT,
    OUT res INT
)
BEGIN
    DECLARE filas INT DEFAULT 0;
    DECLARE existe INT DEFAULT 0;

    SET filas = (SELECT MAX(NameP) + 1 FROM postulant);
    IF filas IS NULL THEN
        SET filas = 452; 
    END IF;

    SET existe = (SELECT COUNT(*) FROM postulant WHERE TDoc = Typ AND Doc = DocP);

    IF existe = 0 THEN
        INSERT INTO postulante VALUES(filas, Nom, Ape, Tip, Doc);
        SET res = filas;
    ELSE
        SET res = existe; 
    END IF;
END;
