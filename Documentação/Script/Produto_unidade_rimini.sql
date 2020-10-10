select * from RIMINI$


delete from RIMINI$ where PRODUTO is null

/*
[area_privativa_coletiva_m2],
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
*/




UPDATE produto_unidades
SET area_privativa_coletiva_m2 = 
	(SELECT b.APC FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1
---
UPDATE produto_unidades
SET area_privativa_terraco_coberto_m2 = 
	(SELECT b.APTC FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1
---
UPDATE produto_unidades
SET area_privativa_terraco_descoberto_m2 = 
	(SELECT b.APTD FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1
---
UPDATE produto_unidades
SET area_comum_m2 = 
	(SELECT b.AC FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1
---
UPDATE produto_unidades
SET area_garagem_m2 = 
	(SELECT b.AG FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1
---      
UPDATE produto_unidades
SET area_hobby_box_m2 = 
	(SELECT b.HB FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1      
---
UPDATE produto_unidades
SET area_total_m2 = 
	(SELECT b.AT FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1
---
UPDATE produto_unidades
SET fracao_ideal_m2 = 
	(SELECT b.FIM2 FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1
---  
UPDATE produto_unidades
SET fracao_ideal_percentual = 
	(SELECT b.FIPERC FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1
---  
UPDATE produto_unidades
SET hobby_box_numero = 
	(SELECT b.HBNUM FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1
---   
UPDATE produto_unidades
SET hobby_box_localizacao = 
	(SELECT b.HBLOCAL FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1
---
UPDATE produto_unidades
SET numero_garagem_01 = 
	(SELECT b.GARAGEMNUM1 FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1
--- 
UPDATE produto_unidades
SET numero_garagem_02 = 
	(SELECT b.GARAGEMNUM2 FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1
---  
UPDATE produto_unidades
SET numero_garagem_03 = 
	(SELECT b.GARAGEMNUM3 FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1
---   
UPDATE produto_unidades
SET vagas_localizacao = 
	(SELECT b.GARAGEMLOCAL FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1    
---
UPDATE produto_unidades
SET vagas_quantidade = 
	(SELECT b.GARAGEMQUANT FROM RIMINI$ b
	WHERE 
	(PRODUTO = b.PRODUTO
	AND GRUPO = b.GRUPO
	AND UNIDADE = b.apartamento))
WHERE
PRODUTO = 22 AND GRUPO = 1     