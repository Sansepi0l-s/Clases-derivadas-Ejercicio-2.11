using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponente ponente;
            Oyente oyente;
            bool salir = false;
            string nom, ap, pasiRes, email, tp, tema, gradoA;
            long telef;
            bool cont;
            char sex;
            int op, op2, i;
            List<Participante> participantes = new List<Participante>();
            while (salir == false)
            {
                do
                {
                    menu();
                    op = Leer.datoInt();
                } while (op < 1 || op > 5);
                switch (op)
                {
                    case 1:
                        //introducir participante
                        do
                        {
                            Console.WriteLine("\tINTRODUCIENDO PARTICIPANTE...");
                            menu2();
                            op2 = Leer.datoInt();
                        } while (op2 < 1 || op2 > 3);
                        switch (op2)
                        {
                            case 1:
                                //introducir ponente
                                cont = false;
                                Console.WriteLine("\tINTRODUCIENDO PONENETE...");
                                Console.WriteLine("_______________________________________");
                                Console.Write("Nombre: ");
                                nom = Console.ReadLine();
                                Console.Write("Apellido: ");
                                ap = Console.ReadLine();
                                Console.Write("Sexo (M/F): ");
                                sex = char.Parse(Console.ReadLine());
                                while ((sex != 'M' && sex != 'F') && (sex != 'm' && sex != 'f'))
                                {
                                    Console.WriteLine("\t¡¡¡ERROR - SEXO NO VÁLIDO, INTÉNTALO DE NUEVO!!!");
                                    Console.Write("Sexo (M/F): ");
                                    sex = char.Parse(Console.ReadLine());
                                }
                                Console.Write("País de Residencia: ");
                                pasiRes = Console.ReadLine();
                                Console.Write("Teléfono: ");
                                telef = Leer.datoLong();
                                Console.Write("Email: ");
                                email = Console.ReadLine();
                                cont = false;
                                Console.Write("Título ponencias: ");
                                tp = Console.ReadLine();
                                Console.Write("Temática: ");
                                tema = Console.ReadLine();
                                foreach (Participante participante in participantes)
                                {
                                    ponente = new Ponente();
                                    ponente = participante as Ponente;
                                    if (ponente != null)
                                    {
                                        if (ponente.Email == email)
                                        {
                                            cont = true;
                                        }
                                    }
                                }
                                if (cont == false)
                                {
                                    ponente = new Ponente(nom, ap, sex, pasiRes, telef, email, tp, tema);
                                    participantes.Add(ponente);
                                    Console.WriteLine("\t¡¡¡PONENTE AGREGADO EXITOSAMENTE!!!");
                                }
                                else
                                {
                                    Console.WriteLine("\t¡¡¡YA EXISTE UN PONENTE CON EL MISMO EMAIL!!!");
                                }
                                break;
                            case 2:
                                //intorducir oyente
                                cont = false;
                                Console.WriteLine("\tINTRODUCIENDO OYENTE...");
                                Console.WriteLine("_______________________________________");
                                Console.Write("Nombre: ");
                                nom = Console.ReadLine();
                                Console.Write("Apellido: ");
                                ap = Console.ReadLine();
                                Console.Write("Sexo (M/F): ");
                                sex = char.Parse(Console.ReadLine());
                                while ((sex != 'M' && sex != 'F') && (sex != 'm' && sex != 'f'))
                                {
                                    Console.WriteLine("\t¡¡¡ERROR - SEXO NO VÁLIDO, INTÉNTALO DE NUEVO!!!");
                                    Console.Write("Sexo (M/F): ");
                                    sex = char.Parse(Console.ReadLine());
                                }
                                Console.Write("País de Residencia: ");
                                pasiRes = Console.ReadLine();
                                Console.Write("Teléfono: ");
                                telef = Leer.datoLong();
                                Console.Write("Email: ");
                                email = Console.ReadLine();
                                Console.Write("Grado Académico: ");
                                gradoA = Console.ReadLine();
                                foreach (Participante participante in participantes)
                                {
                                    oyente = new Oyente();
                                    oyente = participante as Oyente;
                                    if (oyente != null)
                                    {
                                        if (oyente.Email == email)
                                        {
                                            cont = true;
                                        }
                                    }
                                }
                                if (cont == false)
                                {
                                    oyente = new Oyente(nom, ap, sex, pasiRes, telef, email, gradoA);
                                    participantes.Add(oyente);
                                    Console.WriteLine("\t¡¡¡OYENTE AGREGADO EXITOSAMENTE!!!");
                                }
                                else
                                {
                                    Console.WriteLine("\t¡¡¡YA EXISTE UN OYENTE CON EL MISMO EMAIL!!!");
                                }
                               
                                break;
                        }
                        break;
                    case 2:
                        //mostrar ponentes
                        i = 0;
                        cont = false;
                        Console.WriteLine("\tMOSTRANDO PONENTES...");
                        Console.WriteLine("_________________________________");
                        foreach (Participante participante in participantes)
                        {
                            if (participante is Ponente)
                            {
                                cont = true;
                                Console.WriteLine("\tPonente [{0}]", i + 1);
                                Console.WriteLine(participante.ToString());
                            }
                            Console.WriteLine("_______________________________________");
                            i++;
                        }
                        if (cont == false) {
                            Console.WriteLine("\t¡¡¡NO SE HA ENCONTRADO NINGÚN PONENTE EN LA LISTA!!!");
                        }
                        break;
                    case 3:
                        //mostrar oyentes
                        i = 0;
                        cont = false;
                        Console.WriteLine("\tMOSTRANDO OYENTES...");
                        Console.WriteLine("_________________________________");
                        foreach (Participante participante in participantes)
                        {
                            if (participante is Oyente)
                            {
                                cont = true;
                                Console.WriteLine("\tOyente [{0}]", i + 1);
                                Console.WriteLine(participante.ToString());
                            }
                            Console.WriteLine("_______________________________________");
                            i++;
                        }
                        if (cont == false)
                        {
                            Console.WriteLine("\t¡¡¡NO SE HA ENCONTRADO NINGÚN OYENTE EN LA LISTA!!!");
                        }
                        break;
                    case 4:
                        //buscar participante
                        i = 1;
                        cont = false;
                        Console.WriteLine("\tBUSCANDO PARTICIPANTES...");
                        Console.WriteLine("_____________________________________________");
                        Console.Write("Ingrese el el email del participante: ");
                        email = Console.ReadLine();
                        foreach (Participante participante in participantes)
                        {
                            ponente = new Ponente();
                            ponente = participante as Ponente;
                            if (ponente != null)
                            {
                                if (ponente.Email == email)
                                {
                                    cont = true;
                                    Console.WriteLine("_______________________________________");
                                    Console.WriteLine("\tPonente [{0}]", i);
                                    Console.WriteLine(participante.ToString());
                                }
                            }
                            oyente = new Oyente();
                            oyente = participante as Oyente;
                            if (oyente != null)
                            {
                                if (oyente.Email == email)
                                {
                                    cont = true;
                                    Console.WriteLine("_______________________________________");
                                    Console.WriteLine("\tOyente [{0}]", i);
                                    Console.WriteLine(participante.ToString());
                                }
                            }
                            i++;
                        }
                        if (cont == false)
                        {
                            Console.WriteLine("\tNO SE HA ENCONTRADO NINGÚN PARTICIPANTE CON EL EMIALI {0}", email);
                        }
                        break;
                    case 5:
                        salir = true;
                        break;
                }
            }
            Console.ReadKey();
        }
        public static void menu()
        {
            Console.WriteLine("1) Introducir participante");
            Console.WriteLine("2) Mostrar ponentes");
            Console.WriteLine("3) Mostrar Oyentes");
            Console.WriteLine("4) Buscar participante");
            Console.WriteLine("5) Salir");
        }
        public static void menu2()
        {
            Console.WriteLine("1) Introducir Ponente");
            Console.WriteLine("2) Introducir Oyente");
            Console.WriteLine("3) Regresar");
        }
    }
}
