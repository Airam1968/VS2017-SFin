select * from rimini$

select * from ravenna$

delete from rimini$ where PRODUTO is null
delete from ravenna$ where PRODUTO is null


UPDATE rimini$
SET GRUPO = 1
WHERE ID = 114

INSERT INTO produto_unidade ([area_privativa_coletiva_m2],
	[area_privativa_terraco_coberto_m2],
	[area_privativa_terraco_descoberto_m2],
	[area_comum_m2],
	[area_garagem_m2],
	[area_hobby_box_m2],
	[area_total_m2],
	[fracao_ideal_m2],
	[fracao_ideal_percentual],
	[hobby_box_numero],
	[hobby_box_localizacao],
	[numero_garagem_01],
	[numero_garagem_02],
	[numero_garagem_03],
	[numero_garagem_04],
	[numero_garagem_05],
	[vagas_localizacao],
	[vagas_quantidade]) 
SELECT '41', dado_B, dado_C FROM TabelaConsulta WHERE dado_C > 0 
/* O valor '7' é um campo fixo e corresponde ao campo_A */
/* Os campos: campo_B, campo_C são obtidos pelo resultado do select */




UPDATE produto_unidades
SET area_privativa_coletiva_m2 = 
	(SELECT b.APC FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2
---
UPDATE produto_unidades
SET area_privativa_terraco_coberto_m2 = 
	(SELECT b.APTC FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2
---
UPDATE produto_unidades
SET area_privativa_terraco_descoberto_m2 = 
	(SELECT b.APTD FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2
---
UPDATE produto_unidades
SET area_comum_m2 = 
	(SELECT b.AC FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2
---
UPDATE produto_unidades
SET area_garagem_m2 = 
	(SELECT b.AG FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2
---      
UPDATE produto_unidades
SET area_hobby_box_m2 = 
	(SELECT b.HB FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2      
---
UPDATE produto_unidades
SET area_total_m2 = 
	(SELECT b.AT FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2
---
UPDATE produto_unidades
SET fracao_ideal_m2 = 
	(SELECT b.FIM2 FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2
---  
UPDATE produto_unidades
SET fracao_ideal_percentual = 
	(SELECT b.FIPERC FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2
---  
UPDATE produto_unidades
SET hobby_box_numero = 
	(SELECT b.HBNUM FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2
---   
UPDATE produto_unidades
SET hobby_box_localizacao = 
	(SELECT b.HBLOCAL FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2
---
UPDATE produto_unidades
SET numero_garagem_01 = 
	(SELECT b.GARAGEMNUM1 FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2
--- 
UPDATE produto_unidades
SET numero_garagem_02 = 
	(SELECT b.GARAGEMNUM2 FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2
---  
UPDATE produto_unidades
SET numero_garagem_03 = 
	(SELECT b.GARAGEMNUM3 FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2
---   
UPDATE produto_unidades
SET vagas_localizacao = 
	(SELECT b.GARAGEMLOCAL FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2    
---
UPDATE produto_unidades
SET vagas_quantidade = 
	(SELECT b.GARAGEMQUANT FROM RAVENNA$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 2     