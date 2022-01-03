using CRUD_19_11.Model;
using ExercicioCrudBanco.DAO;
using Hl7.Fhir.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CRUD_19_11.Controller
{
    class PessoaController
    {
        public bool GravarPessoa(Pessoa pessoa)
        {
            BancoInstance banco;
            bool ok = false;
            using (banco = new BancoInstance())
            {
                ok = banco.Banco.ExecuteNonQuery(@"INSERT INTO Pessoa (Nome_Pessoa, Id_Familia, CPF, RG, Telefone, Dt_nasc) VALUES (@1, @2, @3, @4, @5, @6)", "@1", pessoa.Nome, "@2", pessoa.Id_Familia, "@3", pessoa.CPF, "@4", pessoa.RG, "@5", pessoa.Telefone, "@6", pessoa.Data_Nasc);
            }
            return ok;
        }

        public bool ExcluirPessoa(int id)
        {
            BancoInstance banco;
            
            using (banco = new BancoInstance())
            {
                bool ok = false;
                return ok = banco.Banco.ExecuteNonQuery(@"DELETE FROM Pessoa WHERE Id_Pessoa = @1", "@1", id);
            }
            
        }

        public bool AlterarPessoa(Pessoa pessoa)
        {
            BancoInstance banco;
            bool ok = false;
            using (banco = new BancoInstance())
            {
                ok = banco.Banco.ExecuteNonQuery(@"UPDATE Pessoa SET Nome_Pessoa = @1, Id_Familia = @2, RG = @3, Telefone = @4",
                    "@1", pessoa.Nome,
                    "@2", pessoa.Id_Familia,
                    "@3", pessoa.RG,
                    "@4", pessoa.Telefone);

            }
            return ok;
        }

        public DataTable buscarPessoa(string cpf)
        {
            DataTable resultado = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT * FROM Pessoa WHERE CPF LIKE @1", out resultado, "@1", cpf );
                return resultado;
            }
        }

        public DataTable buscarPessoapeloID(int id)
        {
            DataTable resultado = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT * FROM Pessoa WHERE Id_Pessoa=@1", out resultado, "@1", id);
                return resultado;
            }
        }

        public DataTable buscarPessoapeloId_Familia(int id)
        {
            DataTable resultado = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT * FROM Pessoa WHERE Id_Familia=@1", out resultado, "@1", id);
                return resultado;
            }
        }

        public DataTable buscarPessoapeloNome(string nome)
        {
            DataTable resultado = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT * FROM Pessoa WHERE Nome_Pessoa=@1", out resultado, "@1", nome);
                return resultado;
            }
        }

        public DataTable buscarPessoapeloCPF(string cpf)
        {
            DataTable resultado = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT * FROM Pessoa WHERE CPF=@1", out resultado, "@1", cpf);
                return resultado;
            }
        }
    }
}
