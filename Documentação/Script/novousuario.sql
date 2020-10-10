Para adicionar um usu�rio ao banco de dados do SQL Server voc� tem que seguir tr�s passos:

Primeiro: voc� deve criar um login, que � um "cara" que tem permisss�o de se logar no SQL Sever 

CREATE LOGIN usrgitano WITH PASSWORD = '1000'

Segundo: voc� deve criar um usu�rio para o banco de dados que deseja mapeando esse usu�rio para o
 login criado, assim seu usu�rio conseguir� se logar no SQL Server e entrar no banco de dados 
 desejado.
 
CREATE USER usrgitano FROM LOGIN usrgitano
 
Terceiro: voc� deve dar ou remover permiss�es ao usu�rio porque at� o segundo passo o usu�rio
 criado s� tem direito a entrar no banco de dados, dando as permiss�es o usu�rio j� pode operar
  no banco de dados. Se o usu�rio for comum voc� pode adicion�-lo apenas 
  as roles de db_reader e db_writer, 
  que permitir� que o usu�rio fa�a select, insert, delete e update em todas as tabelas 
  do referido banco de dados.
 
EXEC SP_ADDROLEMEMBER 'DB_DATAREADER', 'usrgitano'
 
EXEC SP_ADDROLEMEMBER 'DB_DATAWRITER', 'usrgitano'

exec sp_dropuser 'usrgitano'
exec sp_adduser usrgitano, usrgitano, db_owner

exec sp_dropuser 'usrwinfact'

