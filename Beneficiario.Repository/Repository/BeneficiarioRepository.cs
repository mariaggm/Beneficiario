using Beneficiario.Domain.Commands;
using Beneficiario.Domain.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beneficiario.Repository.Repository
{
    public class BeneficiarioRepository : IBeneficiarioRepository 
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Beneficiario ;Trusted_Connection=True;MultipleActiveResultSets=true";
        public async Task<string> PostAsync(BeneficiarioCommand command)
        {
            string queryInsert = @"
            INSERT INTO Beneficiario(Nome, Cidade, Estado, Cep, Email, Telefone, BeneficiarioId)
            VALUES(@Nome, @Cidade, @Estado, @Cep, @Email, @Telefone, @BeneficiarioId)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {
                    Nome = command.Nome,
                    Cidade = command.Cidade,
                    BeneficiarioId = command.BeneficiarioId,
                    Estado = command.estado,
                    Cep = command.Cep,
                    Email = command.Email,
                    Telefone = command.Telefone,
                });

                return "Beneficiario Cadastrado com sucesso";
            }
        }
        public void PostAsync()
        {
            throw new NotImplementedException();
        }

    }
}

