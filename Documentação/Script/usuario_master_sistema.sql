--configura��o usu�rio master 

select * from usuario

delete Permissoes
where Login = 'MASTER'

delete usuario where Login = 'MASTER'