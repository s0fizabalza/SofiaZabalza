internal class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo tecla;
        string[] menu = {
                "            Alta de Usuario                    ",
                "            Baja de Usuario                    ",
                "            Modificación de Usuario            ",
                "            Listar Usuarios                 ",
                "            Salir                           "
            };

        int posMenu = 0;
        Console.CursorVisible = false;
        for (int i = 0; i < menu.Count(); i++)
        {
            Console.SetCursorPosition(30, i + 10);
            if (i == 0)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write(menu[i]);
        }

        while (true)
        {
            tecla = Console.ReadKey(true);
            if (tecla.Key == ConsoleKey.DownArrow)
            {
                if (posMenu < 4)
                {
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(menu[posMenu]);
                    posMenu++;
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(menu[posMenu]);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.Write(menu[posMenu]);
                    posMenu = 0;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.Write(menu[posMenu]);
                }
            }
            tecla = Console.ReadKey(true);
            if (tecla.Key == ConsoleKey.UpArrow)
            {
                if (posMenu < 4)
                {
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(menu[posMenu]);
                    posMenu--;
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(menu[posMenu]);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.Write(menu[posMenu]);
                    posMenu > 0;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(30, posMenu + 10);
                    Console.Write(menu[posMenu]);
                }
            }
            if (tecla.Key == ConsoleKey.Enter)
            {
                Console.Write(posMenu);
            }
        }
    }
}
