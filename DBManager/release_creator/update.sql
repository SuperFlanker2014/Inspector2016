alter table Docs_Bills_Services drop column [sum]
go

alter table Docs_Bills_Services add [sum] as CONVERT(NUMERIC(25, 2), [rate]*[count]*[sum_factor]) PERSISTED
go
