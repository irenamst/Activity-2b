USE Test

GO

insert into dbo.Users (USERNAME,PASSWORD) values ('BillGates','bigbucks')
delete from dbo.Users  where USERNAME='BillGates' AND PASSWORD='bigbicks'
select * from dbo.Users