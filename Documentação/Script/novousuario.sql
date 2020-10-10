Para adicionar um usuário ao banco de dados do SQL Server você tem que seguir três passos:

Primeiro: você deve criar um login, que é um "cara" que tem permisssão de se logar no SQL Sever 

CREATE LOGIN usrgitano WITH PASSWORD = '1000'

Segundo: você deve criar um usuário para o banco de dados que deseja mapeando esse usuário para o
 login criado, assim seu usuário conseguirá se logar no SQL Server e entrar no banco de dados 
 desejado.
 
CREATE USER usrgitano FROM LOGIN usrgitano
 
Terceiro: você deve dar ou remover permissões ao usuário porque até o segundo passo o usuário
 criado só tem direito a entrar no banco de dados, dando as permissões o usuário já pode operar
  no banco de dados. Se o usuário for comum você pode adicioná-lo apenas 
  as roles de db_reader e db_writer, 
  que permitirá que o usuário faça select, insert, delete e update em todas as tabelas 
  do referido banco de dados.
 
EXEC SP_ADDROLEMEMBER 'DB_DATAREADER', 'usrgitano'
 
EXEC SP_ADDROLEMEMBER 'DB_DATAWRITER', 'usrgitano'

exec sp_dropuser 'usrgitano'
exec sp_adduser usrgitano, usrgitano, db_owner

exec sp_dropuser 'usrwinfact'

