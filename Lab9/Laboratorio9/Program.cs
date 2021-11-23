using System;
using System.Collections.Generic;


namespace Laboratorio9
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Dictionary<int, string> paises = new Dictionary<int, string>(); 
            paises[44] = "Reino Unido";
            paises[33] = "França"; paises[55] = "Brasil";

            Console.WriteLine("O código 55 é: {0}", paises[55]); 
            foreach (KeyValuePair<int, string> item in paises)
            {
                int codigo = item.Key; string pais = item.Value;
                Console.WriteLine("Código {0} = {1}", codigo, pais);
            }

            List<string> listaStrings = new List<string>();
            listaStrings.Add("Um"); 
            listaStrings.Add("Hello"); 
            listaStrings.Add("World"); 
            Console.WriteLine(listaStrings[0]); 
            Console.WriteLine(listaStrings[1]); 
            Console.WriteLine(listaStrings[2]); 
            listaStrings.Add(0);

            Queue<Object> q = new Queue<Object>();
            q.Enqueue(".net framework / core");
            q.Enqueue(new Decimal(123.456));
            q.Enqueue(654.321);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            Queue<int> minhaFila = new Queue<int>();
            minhaFila.Enqueue(10);
            minhaFila.Enqueue(200);
            minhaFila.Enqueue(1000);
            Console.WriteLine(minhaFila.Dequeue());
            Console.WriteLine(minhaFila.Dequeue());
            Console.WriteLine(minhaFila.Dequeue());
        }
    }
}
