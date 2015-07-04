using prjEstacionamento.Sources.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstacionamento.Sources.DAO
{
    class daoPagamento : daoBase
    {

        private string Select =
            @"SELECT T0.[DataEntrada],
                     T0.[DataSaida],
                     T0.[ParceiroId],
                     T4.[Desconto],
                     T0.[MensalistaId],
                     T3.[PrimeiraHora],
                     T3.[DemaisHoras]
                FROM [UsoVaga] T0
                JOIN [Modelo] T1 ON T1.[Id] = T0.[ModeloId]
                JOIN [TipoVeiculo] T2 ON T2.[Id] = T1.[TipoVeiculoId]
                JOIN [PrecosAvulsos] T3 ON T3.[TipoVeiculoId] = T2.[Id]
                JOIN [Parceiros] T4 ON T4.[Id] = T0.[ParceiroId]
                WHERE T0.[Id] = @Id";

        public daoPagamento()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
        }
        
        public DataTable SelecionaDadosTicket(int value)
        {
            DataTable dataTable = new DataTable();
            var param1 = new SqlParameter("@Id", value);
            base.comando.CommandText = Select;
            base.comando.Parameters.Add(param1);
            base.conexao.Open();
            dataTable.Load(base.comando.ExecuteReader());
            return dataTable;
        }
    }
}
