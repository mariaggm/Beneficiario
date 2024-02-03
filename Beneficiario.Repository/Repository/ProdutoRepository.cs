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
    public class ProdutoRepository : IProdutoRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Beneficiario ;Trusted_Connection=True;MultipleActiveResultSets=true";
        public async Task<string> PostAsync(ProdutoCommand command)
        {
            string queryInsert = @"
            INSERT INTO ProdutoId(IdProduto, NomeProduto, Descricao, Categoria, DisponibilidadeAdocao, BeneficiarioId)
            VALUES(@IdProduto, @NomeProduto, @Descricao, @Categoria, @DisponibilidadeAdocao, @BeneficiarioId)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {
                    IdProduto = command.IdProduto,
                    NomeProduto = command.NomeProduto,
                    Descricao = command.Descricao,
                    Categoria = command.Categoria,
                    DisponibilidadeAdocao = command.DisponibilidadeAdocao,
                    BeneficiarioId = command.BeneficiarioId,

                });

                return "Produto Cadastrado com sucesso";
            }
        }
        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}

