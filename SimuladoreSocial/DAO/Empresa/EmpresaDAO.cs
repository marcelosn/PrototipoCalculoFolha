using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimuladoreSocial.Models;
using SimuladoreSocial.Models.Empresas;

namespace SimuladoreSocial.DAO.Empresa
{
    public class EmpresaDAO : IRepository<Empresas>
    {
        private Context _Context;

        public EmpresaDAO()
        {
            _Context = new Context();
        }

        public void Adiciona(Empresas entity)
        {
            _Context.TEmpresas.Add(entity);
            _Context.SaveChanges();
        }

        public void Atualiza(Empresas entity)
        {
            _Context.TEmpresas.Update(entity);
            _Context.SaveChanges();
        }


        public void Remove(Empresas entity)
        {
            _Context.TEmpresas.Remove(entity);
            _Context.SaveChanges();
        }


        public void Lista(Empresas entity)
        {
            _Context.TEmpresas.ToList();
            _Context.SaveChanges();
        }


        public Empresas SelecionaPorID(int id)
        {
            return _Context.TEmpresas.Find(id);
        }
    }
}
