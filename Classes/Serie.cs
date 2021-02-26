using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_De_Series
{
    public class Serie : EntidadeBase
    {

        //Atributos

        private Genero Genero { get; set; }
        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        private bool excluido { get; set; }

        //metodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.excluido = false;
        }

        public override string ToString()
        {

            // Environment.NewLine  https://docs.microsoft.com/pt-br/dotnet/api/system.environment.newline?view=net-5.0
            // é uma apropiação de quebra de linhas
            string retorno = "";
            retorno = retorno + "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Decrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.excluido;
            return retorno;

        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.excluido;
        }

        public void Excluir()
        {
            this.excluido = true;
        }

    }
}
