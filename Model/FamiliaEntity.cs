using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_19_11.Model
{
    public class FamiliaEntity
    {
        public FamiliaEntity(int id, int id_Cidade, string nome_Familia)
        {
            Id = id;
            Id_Cidade = id_Cidade;
            Nome_Familia = nome_Familia;
        }

        public int Id { get; private set; }
        public int Id_Cidade { get; private set; }
        public string Nome_Familia { get; private set; }
    }
}
