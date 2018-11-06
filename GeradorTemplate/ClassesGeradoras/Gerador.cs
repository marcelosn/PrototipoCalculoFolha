using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeradorTemplate.ClassesGeradoras
{
    public class Gerador
    {
        protected string _Caminho;
        protected StreamWriter _Writer;

        public Gerador(string caminho)
        {
            _Caminho = caminho;
        }

        public virtual void ConstroiArquivo()
        {
            _Writer = File.CreateText(_Caminho+".cshtml");
            _Writer.Close();
        }

        public virtual void AbrirPagina()
        {
            System.Diagnostics.Process.Start("explorer", _Caminho);
        }
    }
}
