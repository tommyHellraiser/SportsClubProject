

CREATE PROCEDURE Login(in InputUsername varchar(20),in InputPass varchar(15))


BEGIN

  
	SELECT u.ID, u.Username, u.FirstName, u.LastName, u.Phone, u.Email, u.Birthdate, r.RoleName
	FROM users AS u 
	INNER JOIN user_roles AS r
	ON u.UserRole = r.ID
	WHERE u.Username = InputUsername
	AND u.Pass = InputPass 
	AND u.ActiveUser = 1; 


END
