using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimuladoreSocial.DAO
{
    interface IRepository<T> where T : class
    {
        T SelecionaPorID(int id);
        void Adiciona(T entity);
        void Atualiza(T entity);
        void Remove(T entity);
        void Lista(T entity);
    }
}
