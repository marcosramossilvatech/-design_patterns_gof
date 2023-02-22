using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory_Pizza.ExemploLivro
{
    internal class Biblioteca
    {
        internal static void SolicitarLivro()
        {
            var livro = LivroFactory.CriaLivro("C# - Básico", "James King", 323, DateTime.Now);

            Console.WriteLine("Titulo: " + livro.Titulo);
            Console.WriteLine("Autor: " + livro.Autor);
            Console.WriteLine("Paginas : " + livro.Paginas);
            Console.WriteLine("Data de Lançamento: " + livro.Lancamento);


            Console.WriteLine("Objeto Livro: " + livro.ToString());
            Console.ReadLine();
        }
    }
}
