using System;

namespace SampleDatabaseFrst
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Utilizar o comando:
             * Scaffold-DbContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=exemplo_EF;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer
             * no Console do Gerenciador de Pacotes para gerar as classes e o contexto a partir do banco de dados.
             * 
             */
            using (var db = new exemplo_EFContext())
            {
                db.Estudantes.Add(new Estudantes { Nome = "Maria", Email = "maria@net.com" });
                db.Estudantes.Add(new Estudantes { Nome = "Manoel", Email = "manoel@net.com" });
                db.Estudantes.Add(new Estudantes { Nome = "Pedro", Email = "pedro@net.com" });
                var contador = db.SaveChanges();

                Console.WriteLine("{0} registros salvos no banco de dados : ", contador);
                Console.WriteLine();
                Console.WriteLine("Todos os estudantes no banco de dados:");

                foreach (var estudante in db.Estudantes)
                {
                    Console.WriteLine(" - {0}", estudante.Nome);
                }
                Console.ReadKey();
            }
        }
    }
}
