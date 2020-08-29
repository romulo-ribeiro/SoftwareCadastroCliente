using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negócios
{
    class TipoGenerico<T>
    {
        public readonly List<T> lista;

        public TipoGenerico()
        {
            lista = new List<T>();
        }

        public void Add(T item)
        {
            lista.Add(item);
        }
        public void Remove(T item)
        {
            lista.Remove(item);
        }
        public List<T> Result()
        {
            return lista;
        }

        public void Update(T antigo, T novo)
        {
            lista.Remove(antigo);
            lista.Add(novo);
        }
    }
}
