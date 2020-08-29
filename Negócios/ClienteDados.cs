using LiteDB;
using System.Collections.Generic;
using System.Linq;

namespace Negócios
{
    class ClienteDados
    {
        private readonly ILiteDatabase liteDB;

        public ClienteDados()
        {
            liteDB = new LiteDatabase(@"C:\temp\nomeubanquinho.db");
        }
        public void Create(ClienteModel cliente)
        {
            liteDB.GetCollection<ClienteModel>().Insert(cliente);
        }
        public void Delete(ClienteModel cliente)
        {
            liteDB.GetCollection<ClienteModel>().DeleteMany(q => q.Documento == cliente.Documento);
        }

        public void Update(ClienteModel antigo, ClienteModel novo)
        {
            Read(antigo)[0].Nome           = novo.Nome;
            Read(antigo)[0].DataNascimento = novo.DataNascimento;
            Read(antigo)[0].Telefone       = novo.Telefone;
            Read(antigo)[0].Documento      = novo.Documento;
            Read(antigo)[0].Sexo           = novo.Sexo;
        }

        public List<ClienteModel> Read()
        {
            return liteDB.GetCollection<ClienteModel>().FindAll().ToList();
        }

        public List<ClienteModel> Read(ClienteModel cliente)
        {
            //return liteDB.GetCollection<ClienteModel>().Find(q => q.Equals(cliente)).ToList();
            return liteDB.GetCollection<ClienteModel>().Find(q => q.Documento == cliente.Documento).ToList();
        }

    }

}
