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
            paises[33] = "França";
            paises[55] = "Brasil";



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
                
            List<string> ddi = new List<string>();
            ddi.Add("Brasil");
            ddi.Add("Reino Unido");
            ddi.Add("França");
            Console.WriteLine(ddi[0]);
            Console.WriteLine(ddi[1]);
            Console.WriteLine(ddi[2]);

            Console.WriteLine("O DDI é: {0}", ddi[0]);
            foreach (KeyValuePair<int, string> item in paises)
            {
                int codigo = item.Key; string pais = item.Value;
                Console.WriteLine("Código {0} = {1}", codigo, pais);
            }


            List<float> ListaAcimaMedia = new List<float>();
            ListaAcimaMedia.Add(10);
            ListaAcimaMedia.Add(20);
            ListaAcimaMedia.Add(30);
            Console.WriteLine(ListaAcimaMedia[0]);
            Console.WriteLine(ListaAcimaMedia[1]);
            Console.WriteLine(ListaAcimaMedia[2]);

            //Console.WriteLine("Valor", ListaAcimaMedia[0]);

            foreach (float soma in ListaAcimaMedia) 
            {
               Console.WriteLine(soma / 3);
            
            }

          
        }

    }
}
