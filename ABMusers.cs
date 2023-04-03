using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class persons
{
    public string nom;
    public string dni;

    public persons()
    {
    }
    public persons(string nom, string dni)
    {
        this.nom = nom;
        this.dni = dni;
    }
    static public string mostrar(List<persons> personslist)
    {
        for (int i = 0; i < personslist.Count; i++)
        {
            Console.WriteLine(personslist[i].nom + "," + personslist[i].dni);
        }
        return null;
    }

    static public string buscarDni(List<persons> Per, string dni, string modificar)
    {
        for (int i = 0; i < Per.Count; i++)
        {
            if (Per[i].dni == dni)
            {
                if (modificar == "nombre")
                {
                    return Per[i].nom = Console.ReadLine();

                }
                else if (modificar == "dni")
                {
                    return Per[i].dni = Console.ReadLine();
                }
            }
        }
        return null;
    }

    static public string borrar(List<persons> Per, string dni)
    {
        for (int i = 0; i < Per.Count; i++)
        {
            if (Per[i].dni == dni)
            {
                Per.RemoveAt(i);
            }

        }
        return null;
    }

    static public string mostrarMenu(string[] menu)
    {
        for (int i = 0; i < menu.Count(); i++)
        {
            Console.SetCursorPosition(30, i + 10);
            if (i == 0)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write(menu[i]);
        }
        return "";
    }
}

internal class Program
{
    static List<persons> personslista = new List<persons>();
    static void Main(string[] args)
    {
        ConsoleKeyInfo tecla;
        string[] menu = {
                "            Crear Usuario                       ",
                "            Modificación de Usuario             ",
                "            Eliminar Usuario                    ",
                "            Listar Usuarios                     ",
                "            Salir                               "
        };
        persons.mostrarMenu(menu);

        int posMenu = 0;
        Console.CursorVisible = false;

        while (true)
        {

            tecla = Console.ReadKey(true);
            if (tecla.Key == ConsoleKey.DownArrow)
            {
                if (posMenu < 4)
                {
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(menu[posMenu]);
                    posMenu++;
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(menu[posMenu]);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.Write(menu[posMenu]);
                    posMenu = 0;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.Write(menu[posMenu]);
                }
            }
            else if (tecla.Key == ConsoleKey.UpArrow)
            {
                if (posMenu > 0)
                {
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(menu[posMenu]);
                    posMenu--;
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(menu[posMenu]);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.Write(menu[posMenu]);
                    posMenu = 4;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.Write(menu[posMenu]);
                }
            }
            int opcion = -1;
            if (tecla.Key == ConsoleKey.Enter)
            {
                opcion = posMenu;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }

            switch (opcion)
            {
                case 0:
                    Console.Clear();
                    Console.Write("Ingresar nuevo user ");
                    int vuel = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= vuel; i++)
                    {
                        Console.Write("Ingresar el nombre de la persona" + i + ":");
                        string nombrePer = Console.ReadLine();

                        Console.Write("Ingresar el DNI de la persona" + i + ":");
                        string dniPer = Console.ReadLine();
                        personslista.Add(new persons(nombrePer, dniPer));

                    }
                    Console.Clear();
                    persons.mostrarMenu(menu);
                    break;

                case 1:
                    Console.Clear();
                    if (personslista.Count == 0)
                    {
                        Console.WriteLine("No existen personas para modificar");
                        Console.ReadKey();
                        Console.Clear();
                        persons.mostrarMenu(menu);
                        break;
                    }

                    Console.Write("Ingrear dni de la persona que quiere cambiar: ");
                    string confirm = Console.ReadLine();

                    Console.WriteLine("Ingresar que se modifica: Nombre o DNI y despues el nuevo valor: ");
                    string modif = Console.ReadLine().ToLower();

                    persons.buscarDni(personslista, confirm, modif);
                    Console.Clear();
                    persons.mostrarMenu(menu);
                    break;

                case 2:
                    Console.Clear();
                    if (personslista.Count == 0)
                    {
                        Console.WriteLine("No existe persona para eliminar");
                        Console.ReadKey();
                        Console.Clear();
                        persons.mostrarMenu(menu);
                        break;
                    }

                    Console.Write("Ingresar el DNI de la persona que quieras eliminar: ");
                    String eliminar = Console.ReadLine();
                    persons.borrar(personslista, eliminar);
                    Console.Clear();
                    persons.mostrarMenu(menu);
                    break;

                case 3:
                    Console.Clear();
                    if (personslista.Count == 0)
                    {
                        Console.WriteLine("No existen personas para mostrar");
                        Console.ReadKey();
                        Console.Clear();
                        persons.mostrarMenu(menu);
                        break;
                    }
                    persons.mostrar(personslista);

                    Console.ReadLine();
                    Console.Clear();
                    persons.mostrarMenu(menu);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

