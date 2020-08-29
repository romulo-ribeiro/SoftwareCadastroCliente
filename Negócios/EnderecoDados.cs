using LiteDB;
using System.Collections.Generic;
using System.Linq;

namespace Negócios
{
    class EnderecoDados
    {
        private readonly ILiteDatabase liteDB;

        public EnderecoDados()
        {
            liteDB = new LiteDatabase(@"C:\temp\nomeubanquinho.db");
        }
        public void Create(EnderecoModel endereco)
        {
            liteDB.GetCollection<EnderecoModel>().Insert(endereco);
        }
        public void Delete(EnderecoModel endereco)
        {
            liteDB.GetCollection<EnderecoModel>().DeleteMany(q => q.Logradouro == endereco.Logradouro && q.Número == endereco.Número);
        }

        public void Update(EnderecoModel antigo, EnderecoModel novo)
        {
            Read(antigo)[0].Logradouro = novo.Logradouro;
            Read(antigo)[0].Número = novo.Número;
            Read(antigo)[0].Complemento = novo.Complemento;
            Read(antigo)[0].Cep = novo.Cep;
            Read(antigo)[0].Cidade = novo.Cidade;
            Read(antigo)[0].Estado = novo.Estado;
        }

        public List<EnderecoModel> Read()
        {
            return liteDB.GetCollection<EnderecoModel>().FindAll().ToList();
        }

        public List<EnderecoModel> Read(EnderecoModel endereco)
        {
            //return liteDB.GetCollection<EnderecoModel>().Find(q => q.Equals(cliente)).ToList();
            return liteDB.GetCollection<EnderecoModel>().Find(q => q.Logradouro == endereco.Logradouro
                                                                && q.Número == endereco.Número).ToList();
        }

    }
}
