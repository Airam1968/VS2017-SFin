USE gitano_castor
GO
ALTER DATABASE gitano_castor
SET RECOVERY SIMPLE
GO
DBCC SHRINKFILE (demo_log, 1);
GO
ALTER DATABASE gitano_castor
SET RECOVERY FULL;
GO 
