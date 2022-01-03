using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_19_11.Model
{
    class Pessoa
    {
        public Pessoa(int id, int id_Familia, string nome, string cPF, string rG, string telefone, DateTime data_Nasc)
        {
            Id = id;
            Id_Familia = id_Familia;
            Nome = nome;
            CPF = cPF;
            RG = rG;
            Telefone = telefone;
            Data_Nasc = data_Nasc;
        }

        public Pessoa(int id, int id_Familia, string nome, string rG, string telefone)
        {
            Id = id;
            Id_Familia = id_Familia;
            Nome = nome;
            RG = rG;
            Telefone = telefone;        }

        public int Id { get; private set; }
        public int Id_Familia { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public string Telefone { get; private set; }
        public DateTime Data_Nasc { get; private set; }
    }
}
