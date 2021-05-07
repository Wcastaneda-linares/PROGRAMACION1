/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [CORRELATIVO]
      ,[NOMBRE]
      ,[PARCIAL1]
      ,[PARCIAL2]
      ,[PARCIAL3]
  FROM [DBPROGRA1A].[dbo].[tb_alumnos]
  delete from tb_alumnos where CORRELATIVO>0