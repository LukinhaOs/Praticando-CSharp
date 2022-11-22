using System;
using System.Collections.Generic;
using System.Linq;
using Lambda.Entidades;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Print<T>(string message, IEnumerable<T> collection)
            {
                Console.WriteLine(message);
                foreach (T obj in collection)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
            }

            Categoria c1 = new Categoria() { id = 1, nome = "Ferramenta", camada = 2 };
            Categoria c2 = new Categoria() { id = 2, nome = "Computadores", camada = 1 };
            Categoria c3 = new Categoria() { id = 3, nome = "Eletrico", camada = 1 };

            List<Produto> products = new List<Produto>()
            {
                new Produto() {id = 1, nome = "Computador", preco = 2875.0, categoria = c2},
                new Produto() {id = 2, nome = "Martelo", preco = 80.0, categoria = c1},
                new Produto() {id = 3, nome = "RX 570", preco = 1278.0, categoria = c2},
                new Produto() {id = 4, nome = "Memoria RAM DDR4 3200Mhz", preco = 478.0, categoria = c2},
                new Produto() {id = 5, nome = "Furadeira", preco = 1878.0, categoria = c1},
                new Produto() {id = 6, nome = "Geladeira Panasonic", preco = 1878.0, categoria = c3},
                new Produto() {id = 7, nome = "Impressora Philco", preco = 780.0, categoria = c3},
                new Produto() {id = 8, nome = "ASRock M4A50B", preco = 570.0, categoria = c2},
                new Produto() {id = 9, nome = "Caixa de parafuso T-8", preco = 85.0, categoria = c1},
                new Produto() {id = 10, nome = "Monitor LG OLED Full HD", preco = 756.0, categoria = c2},
                new Produto() {id = 11, nome = "Mouse Microsft", preco = 55.0, categoria = c2},
                new Produto() {id = 12, nome = "Fone de Ouvido Samsung", preco = 55.0, categoria = c2}
            };

            //var r1 = products.Where(p => p.categoria.camada == 1 && p.preco < 900.0);
            var r1 =
                from p in products
                where p.categoria.camada == 1 && p.preco < 900.0
                select p;
            Print(" -------- Camada 1 e preço < 900 -------- ", r1);


            //var r2 = products.Where(p => p.categoria.nome == "Ferramenta").Select(p => p.nome);
            var r2 =
                from p in products
                where p.categoria.nome == "Ferramenta"
                select p.nome;
            Print(" -------- Lista de Ferramentas -------- ", r2);


            // var r3 = products.Where(p => p.nome[0] == 'C').Select(p => new { p.nome, p.preco, CategoriaNome = p.categoria });
            var r3 =
                from p in products
                where p.nome[0] == 'C'
                select new { p.nome, p.preco, CategoriaNome = p.categoria };
            Print(" -------- Nomes com 'C' e objeto anônimo", r3);


            //var r4 = products.Where(p => p.categoria.camada == 1).OrderBy(p => p.preco).ThenBy(p => p.nome);
            var r4 =
                from p in products
                where p.categoria.camada == 1
                orderby p.nome
                orderby p.preco
                select p;
            Print(" -------- Ordenado por Preço e Nome --------", r4);


            //var r5 = r4.Skip(2).Take(4);
            var r5 =
                (from p in r4
                 select p).Skip(2).Take(4);
            Print(" -------- SKIP 2 & TAKE 4 --------- ", r5);


            // var r6 = products.First();
            var r6 =
                products.First();
            Console.WriteLine("First teste1: " + r6);


            //var r7 = products.Where(p => p.preco > 3000.0).FirstOrDefault();
            var r7 =
                (from p in products
                 where p.preco > 3000.0
                 select p).FirstOrDefault();
            Console.WriteLine("First teste2: " + r7);


            //var r8 = products.Where(p => p.id == 3).SingleOrDefault(); // Utilizado somente caso, tenha certeza do valor à retornar
            var r8 =
                (from p in products
                 where p.id == 3
                 select p).SingleOrDefault();
            Console.WriteLine(" -------- Seleção de um Produto --------- ");
            Console.WriteLine(r8);

            var r9 = products.Where(p => p.id == 11).SingleOrDefault(); // Utilizado somente caso, tenha certeza do valor à retornar null
            Console.WriteLine(" -------- Seleção de um Produto Null -------- ");
            Console.WriteLine(r9);

            //var r10 = products.Max(p => p.preco);
            var r10 =
                (from p in products
                select p.preco).Max();
            Console.WriteLine("Max preço: " + r10);

            //var r11 = products.Min(p => p.preco);
            var r11 =
                (from p in products
                 select p.preco).Min();
            Console.WriteLine("Min preço: " + r11);

            //var r12 = products.Where(p => p.categoria.id == 1).Sum(p => p.preco);
            var r12 =
                (from p in products
                 where p.categoria.id == 1
                 select p.preco).Sum();
            Console.WriteLine("Categoria 1 soma preço: " + r12);

            //var r13 = products.Where(p => p.categoria.id == 1).Average(p => p.preco);
            var r13 =
                (from p in products
                 where p.categoria.id == 1
                 select p.preco).Average();
            Console.WriteLine("Categoria 1 média: " + r13);

            //var r14 = products.Where(p => p.categoria.id == 5).Select(p => p.preco).DefaultIfEmpty().Average();
            var r14 =
                (from p in products
                 where p.categoria.id == 5
                 select p.preco).DefaultIfEmpty().Average();
            Console.WriteLine("Categoria 5 média: " + r14);

            //var r15 = products.Where(p => p.categoria.id == 5).Select(p => p.preco).Aggregate(0.0, (x, y) => x + y);
            var r15 =
                (from p in products
                 where p.categoria.id == 5
                 select p.preco).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Categoria Aggregate: " + r15);
            Console.WriteLine();

            var r16 = products.GroupBy(p => p.categoria);
            foreach (IGrouping<Categoria, Produto> group in r16)
            {
                Console.WriteLine("Categoria - " + group.Key.nome + ":");
                foreach (Produto p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}