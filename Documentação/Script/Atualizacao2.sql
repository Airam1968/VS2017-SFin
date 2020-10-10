/***Atualizações SQL***/


/***24/01/2018***/
/***Fazer em todas as tabelas de parcelas usar arquivo atualizacao2.sql***/
ALTER TABLE PARCELAS_RENEGOCIACAO
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_RENEGOCIACAO
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

/***EMPREENDIMENTO 01***/
ALTER TABLE PARCELAS_00001_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00002
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00002
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00003
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00003
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00004
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00004
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00005
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00005
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00006
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00006
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00007
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00007
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00008
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00008
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00009
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00009
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00010
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00010
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00011
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00011
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00012
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00012
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00013
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00013
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00014
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00014
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00015
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00015
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00016
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00016
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00017
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00017
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00018
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00018
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00019
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00019
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00020
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00020
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00021
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00021
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00022
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00022
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00023
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00023
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00024
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00024
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00025
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00025
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00026
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00026
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00027
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00027
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00028
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00028
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00029
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00029
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00030
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00030
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00031
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00031
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00032
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00032
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00033
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00033
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00034
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00034
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00035
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00035
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00036
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00036
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00037
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00037
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00038
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00038
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00039
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00039
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00040
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00040
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00041
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00041
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00042
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00042
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00043
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00043
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00044
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00044
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00045
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00045
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00046
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00046
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00047
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00047
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00048
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00048
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00049
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00049
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00050
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00050
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00051
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00051
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00052
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00052
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00053
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00053
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00054
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00054
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00055
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00055
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00056
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00056
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00057
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00057
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00058
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00058
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00059
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00059
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00060
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00060
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00061
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00061
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00062
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00062
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00063
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00063
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00064
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00064
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00065
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00065
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00066
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00066
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00067
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00067
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00068
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00068
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00069
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00069
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00381
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00381
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00501
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00501
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00001_00641
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00001_00641
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

/***FIM EMPREENDIMENTO 01***/

/***EMPREENDIMENTO 02***/

ALTER TABLE PARCELAS_00002_00002
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00002_00002
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00

ALTER TABLE PARCELAS_00002_00003
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00002_00003
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00

ALTER TABLE PARCELAS_00002_00004
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00002_00004
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00

ALTER TABLE PARCELAS_00004_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00004_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00

ALTER TABLE PARCELAS_00005_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00005_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00

ALTER TABLE PARCELAS_00006_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00006_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00

ALTER TABLE PARCELAS_00006_00002
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00006_00002
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00006_00003
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00006_00003
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00006_00004
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00006_00004
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00006_00005
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00006_00005
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00006_00006
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00006_00006
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00006_00007
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00006_00007
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00007_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00007_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00007_00002
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00007_00002
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00008_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00008_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00009_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00009_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00010_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00010_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00010_00002
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00010_00002
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00010_00003
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00010_00003
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00010_00004
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00010_00004
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00011_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00011_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00011_00002
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00011_00002
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00012_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00012_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00013_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00013_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00014_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00014_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00015_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00015_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00016_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00016_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00017_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00017_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00018_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00018_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00019_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00019_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00020_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00020_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00021_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00021_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00022_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00022_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00023_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00023_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00024_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00024_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00026_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00026_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00027_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00027_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00028_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00028_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00029_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00029_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00030_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00030_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00030_00002
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00030_00002
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00030_00003
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00030_00003
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00032_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00032_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00033_00002
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00033_00002
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00034_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00034_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00034_00002
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00034_00002
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00034_00003
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00034_00003
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00035_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00035_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00036_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00036_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00037_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00037_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00037_00002
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00037_00002
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00037_00003
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00037_00003
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00039_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00039_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00039_00002
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00039_00002
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO
/***FIM EMPREENDIMENTO 39***/

/***EMPREENDIMENTO 41***/
ALTER TABLE PARCELAS_00041_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00002
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00002
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00003
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00003
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00004
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00004
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00005
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00005
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00006
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00006
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00007
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00007
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00008
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00008
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00009
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00009
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00010
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00010
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00011
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00011
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00012
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00012
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00013
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00013
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00014
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00014
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00015
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00015
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00016
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00016
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00017
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00017
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00018
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00018
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00019
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00019
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00020
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00020
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00021
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00021
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00022
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00022
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00023
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00023
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00024
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00024
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00025
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00025
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00026
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00026
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00027
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00027
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00028
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00028
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00029
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00029
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00030
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00030
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00031
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00031
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00032
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00032
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00033
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00033
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00034
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00034
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00035
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00035
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00036
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00036
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00037
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00037
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00038
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00038
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00039
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00039
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00040
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00040
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00041
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00041
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00042
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00042
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00043
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00043
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00044
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00044
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00045
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00045
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00041_00046
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00041_00046
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

/***FIM EMPREENDIMENTO 41***/

/***EMPREENDIMENTO 42***/
ALTER TABLE PARCELAS_00042_00001
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00001
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00002
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00002
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00003
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00003
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00004
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00004
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00005
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00005
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00006
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00006
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00007
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00007
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00008
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00008
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00009
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00009
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00010
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00010
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00011
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00011
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00012
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00012
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00013
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00013
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00014
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00014
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00015
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00015
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00016
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00016
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00017
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00017
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00018
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00018
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00019
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00019
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00020
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00020
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00021
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00021
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00022
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00022
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00023
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00023
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00024
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00024
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00025
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00025
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00026
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00026
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00027
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00027
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00028
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00028
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00029
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00029
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00030
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00030
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00031
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00031
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00032
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00032
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00033
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00033
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00034
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00034
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00035
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00035
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00036
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00036
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00037
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00037
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00038
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00038
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00039
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00039
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00040
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00040
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00041
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00041
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00042
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00042
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00043
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00043
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00044
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00044
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00045
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00045
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00046
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00046
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00047
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00047
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00048
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00048
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00049
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00049
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00050
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00050
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00051
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00051
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00052
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00052
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00053
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00053
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00054
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00054
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00055
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00055
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00056
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00056
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00057
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00057
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00058
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00058
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00059
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00059
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00060
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00060
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00061
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00061
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00062
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00062
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00063
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00063
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00064
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00064
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00065
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00065
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00066
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00066
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00067
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00067
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00068
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00068
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00069
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00069
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00381
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00381
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00501
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00501
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO

ALTER TABLE PARCELAS_00042_00641
ADD [juros_price] [decimal](18, 8) NULL,
	[vlr_parcelas_jurosprice] [decimal](18, 2) NULL,
	[amortizacao] [int] NULL,
	[vlr_parcelas_descapitalizada] [decimal](18, 2) NULL,	
	[taxa_anual_price] [decimal](18, 2) NULL	
GO

UPDATE PARCELAS_00042_00641
SET
[juros_price] = 0.00,
[vlr_parcelas_jurosprice] = 0.00,
[amortizacao] = 0,
[vlr_parcelas_descapitalizada] = 0.00,
[taxa_anual_price] = 0.00
GO
/***FIM EMPREENDIMENTO 42***/
