alter table SenacPos2015.dbo.LogEstacionamento add constraint DF_DataAgora default getdate() for DataAcao

alter table senacpos2015.dbo.parceiros
alter column Desconto decimal(18,2) not null