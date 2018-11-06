using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegraNegocio.Conexoes;
using SimuladoreSocial.DAO.Empresa;
using SimuladoreSocial.Models.Empresas;

namespace SimuladoreSocial.Controllers.Cadastro.Empresa
{
    public class EmpresaController : Controller
    {
       
        public IActionResult CadastroEmpresa()
        {

            return View();
        }


        [HttpPost]
        public IActionResult CadastrarEmpresa(Empresas empresa)
        {
            try
            {
                EmpresaDAO _daoEmp = new EmpresaDAO();
                _daoEmp.Adiciona(empresa);

                var a = "Cadastrado";
                return Json(a);
            }
            catch
            {
                var a = "Não foi possivel realizar o cadastro da empresa";
                return Json(a);
            }
        }
    }
}