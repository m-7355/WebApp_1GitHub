SELECT 
    company_id,
    email,
    name,
    password_hash
FROM attendance
WHERE company_id = @CompanyId
  AND password_hash = @Password
  AND (
        email = @Email
        OR name = @UserName
      )
LIMIT 1;