using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodos
{
    internal class Program
    {
        class Node
        {
            public string letra;
            public int dato;
            public Node siguiente;

            public Node(string Letra, int datavalue, Node siguienteNodo)
            {
                this.letra = Letra;
                this.dato = datavalue;
                this.siguiente = siguienteNodo;
            }
        }
        class LinkedList
        {
            public Node head;
            public LinkedList()
            {
                head = null;
            }
        }
        static void Main(string[] args)
        {
            //PROGRAMA 2
            //PARA 5 JUGADORES FIJOS NODOS ENLAZADOS
            //PROGRAMA 3
            // TINGO TINGO TANGO
            LinkedList ListCircular = new LinkedList();
            Node A = new Node("A", 0, null);
            Node B = new Node("B", 0, null);
            Node C = new Node("C", 0, null);
            Node D = new Node("D", 0, null);
            Node E = new Node("E", 0, null);
            Node Temporal = new Node("", 0, null);
            int tango = 10;
            for (int i = 1; i <= tango; i++)
            {
                if (i <= tango)
                {
                    A = new Node("A", i, null);
                    ListCircular.head = A;
                    A.siguiente = ListCircular.head;
                    i++;
                }
                if (i <= tango)
                {
                    B = new Node("B", i, null);
                    A.siguiente = B;
                    B.siguiente = ListCircular.head;
                    i++;
                }
                if (i <= tango)
                {
                    C = new Node("C", i, null);
                    B.siguiente = C;
                    C.siguiente = ListCircular.head;
                    i++;
                }
                if (i <= tango)
                {
                    D = new Node("D", i, null);
                    C.siguiente = D;
                    D.siguiente = ListCircular.head;
                    i++;
                }
                if (i <= tango)
                {
                    E = new Node("E", i, null);
                    D.siguiente = E;
                    E.siguiente = ListCircular.head;
                }
            }
            
            Temporal = ListCircular.head;
            while (true)
            {
                Temporal = Temporal.siguiente;
                if(Temporal.dato == tango)
                {
                    Console.WriteLine(Temporal.letra);
                }
                if (Temporal == ListCircular.head)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
