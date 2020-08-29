using System;
using System.Collections.Generic;
using System.Linq;
using LiteDB;
using System.Threading.Tasks;

namespace Negócios
{
    public class UsuarioDados
    {
        private ILiteDatabase liteDB;

        public UsuarioDados()
        {
             //liteDB = new LiteDatabase(@"C:\temp\nomeubanquinho.db");
        }
        public void Create(UsuarioModel usuario)
        {
            using (liteDB = new LiteDatabase(@"C:\temp\nomeubanquinho.db"))
            {
                liteDB.GetCollection<UsuarioModel>().Insert(usuario);
            }
        }
        public void Delete(UsuarioModel usuario)
        {
            using (liteDB = new LiteDatabase(@"C:\temp\nomeubanquinho.db"))
            {
                liteDB.GetCollection<UsuarioModel>().DeleteMany(q => q.Usuario == usuario.Usuario && q.Senha == usuario.Senha);
            }
        }

        public void Update(UsuarioModel antigo, UsuarioModel novo)
        {
            using (liteDB = new LiteDatabase(@"C:\temp\nomeubanquinho.db"))
            {
                Read(antigo)[0].Usuario = novo.Usuario;
                Read(antigo)[0].Senha = novo.Senha;
            }
        }

        public List<UsuarioModel> Read()
        {
            using (liteDB = new LiteDatabase(@"C:\temp\nomeubanquinho.db"))
            {
                return liteDB.GetCollection<UsuarioModel>().FindAll().ToList();
            };
        }

        public List<UsuarioModel> Read(UsuarioModel usuario)
        {
            using (liteDB = new LiteDatabase(@"C:\temp\nomeubanquinho.db"))
            {
                //return liteDB.GetCollection<UsuarioModel>().Find(q => q.Equals(cliente)).ToList();
                return liteDB.GetCollection<UsuarioModel>().Find(q => q.Usuario == usuario.Usuario && q.Senha == usuario.Senha).ToList();
            };
        }

    }
}
