select * from TAXA_dia
select * from taxas_diarias
DELETE TAXA_DIA
drop table taxas_diarias

--Insert da Tabela convertida (http://dbfconv.com/) para a tabela do Sistema Gitano
--
INSERT INTO taxas_diarias
(NOME,PERIODICIDADE,INICIO,FIM,DIVULGACAO,TIPO,DMAIS,ATIVO,DESCRICAO,ORGAO,OBSERVA_1,OBSERVA_2)
select NOME,PERIODO,INICIO,FIM,DIVULGACAO,TIPO,D,1,'','','','' from TAXA_MES order by MES, ANO
--

-- Script Sql de inclusão dos registros
-- 

CREATE TABLE taxas_diarias (
   DATA DATETIME, 
   TR_D DECIMAL(8, 4));



COMMIT;

   
   
   

-------------
--
