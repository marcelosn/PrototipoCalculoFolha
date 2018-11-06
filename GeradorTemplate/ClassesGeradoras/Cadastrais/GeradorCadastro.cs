using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeradorTemplate.ClassesGeradoras.Cadastrais
{
    public class GeradorCadastro<T> : Gerador where T : class
    {
        private T _Entidade;
        private string _NomeCadastro;

        public GeradorCadastro(string caminho, T entidade, string nomeCadastro) : base(caminho)
        {
            _Caminho = caminho;
            _Entidade = entidade;
            _NomeCadastro = nomeCadastro;
        }
        

        private void Tag()
        {
            _Writer.WriteLine("< !--Tag-- >");
            _Writer.WriteLine("<div class=\"banner\">");
            _Writer.WriteLine("     <h2>");
            _Writer.WriteLine("         <a href=\"~/Home/Index\">Home</a>");
            _Writer.WriteLine("         <i class=\"fa fa-angle-right\"></i>");
            _Writer.WriteLine("         <span>" + _NomeCadastro + "</span>");
            _Writer.WriteLine("     </h2>");
            _Writer.WriteLine(" </div>");
        }

        private void Formulario()
        {
            _Writer.WriteLine("                         <form method=\"GET\" action=\"~/"+ _Entidade +"/Cadastrar"+ _Entidade +"\" class=\"valida\" autocomplete=\"off\" novalidate=\"novalidate\">");
            _Writer.WriteLine("                         </form>");
        }

        private void CampoFormulario()
        {
            _Writer.WriteLine("<!--Tag-- >");
            _Writer.WriteLine("<div class=\"blank\">");
            _Writer.WriteLine("     <div class=\"grids\">");
            _Writer.WriteLine("         <div class=\"forms-grids\">");
            _Writer.WriteLine("             <div class=\"w3agile-validation\">");
            _Writer.WriteLine("                 <div class=\"panel panel-widget agile-validation\">");
            _Writer.WriteLine("                     <div class=\"my-div\">");
            Formulario();
            _Writer.WriteLine("                     </div>");
            _Writer.WriteLine("                 </div>");
            _Writer.WriteLine("             </div>");
            _Writer.WriteLine("         <div class=\"clearfix\"> </div>");
            _Writer.WriteLine("     </div>");
            _Writer.WriteLine("</div>");
            _Writer.WriteLine(" <script src=\"~/ScriptsJSAjax/Detalhes.js\"></script>");
        }

        public override void ConstroiArquivo()
        {
            _Writer = File.CreateText(_Caminho + ".cshtml");
            _Writer.WriteLine("@using SimuladoreSocial.Models." + _Entidade);
            Tag();
            CampoFormulario();
            _Writer.Close();
        }
    }
}
