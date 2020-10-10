---Script reverter Quitação
Select * from vendas

update vendas
set quitado = 0
where produto = 1 and grupo = 1 and unidade = 3

select * from parcelas_00001_00001
where produto = 1 and grupo = 1 and unidade = 3

update parcelas_00001_00001
set ativa = 1
where produto = 1 and grupo = 1 and unidade = 3
and ID > 1000

select * from produto_unidades
where produto = 1 and grupo = 1 and unidade = 3

update produto_unidades
set quitado_1 = 0
where produto = 1 and grupo = 1 and unidade = 3

select * from log
order by DataHora

delete Log
where Acao = 'RENEGOCIACAO IMOVEL : 1/1/3/0'
