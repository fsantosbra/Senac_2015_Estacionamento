use senacpos2015
go

if not exists (select * from sys.objects where name = 'STP_GravarLogEstacionamento')
	exec ('create procedure STP_GravarLogEstacionamento as begin select ''Programa em desenvolvimento''; end')
go

alter procedure STP_GravarLogEstacionamento (@AcessoID int, @DescricaoAcao varchar(100))
as
begin
	declare @Retorno	bit,
			@MsgRetorno varchar(255)

	set @Retorno	= 1
	set @MsgRetorno = 'OK'

	begin try
		begin tran
			insert into senacpos2015.dbo.LogEstacionamento (AcessoId, Descricao)
			values(@AcessoID, @DescricaoAcao)
		commit tran
	end try
	begin catch
		rollback tran

		set @Retorno = 0
		set @MsgRetorno = error_message()
	end catch

	select Retorno = @Retorno, MsgRetorno = @MsgRetorno
end

