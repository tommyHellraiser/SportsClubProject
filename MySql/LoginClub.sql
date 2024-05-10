

create procedure Login(in Us varchar(20),in Pass varchar(15))


begin

  
  select NameUser,LastName,Phone,Email,Birthday,NameRole
	from user u inner join roles r on u.RoleUser = r.RoleUser
		where NameUser = Us and PassUser = Pass 
			and ActiveUser = 1; 


end
