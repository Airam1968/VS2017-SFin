--configuração usuário master 

select * from usuario

delete Permissoes
where Login = 'MASTER'

delete usuario where Login = 'MASTER'