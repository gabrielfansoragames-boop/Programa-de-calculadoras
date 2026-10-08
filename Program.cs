List<decimal> numbers = new List<decimal>();
bool FlowControl;
Console.WriteLine("Bienvenido a la calculadora");
Console.WriteLine("---------------------------");
do
{
    FlowControl = true;
    Console.WriteLine("Seleccione la función que desea utilizar");
    Console.WriteLine("1.Calculadora de operaciones aritméticas");
    Console.WriteLine("2.Calculadora de estudiantes aprobados");
    Console.WriteLine("3.Abandonar el programa");
    int option = 0;
    try
    {
        option = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Error al ingresar un numero");
    }
    if (option == 1)
    {
        option = 0;
        bool Reset = true;
        decimal NumberAndResults = 0;
        Console.WriteLine("Bienvenido a la calculadora de operaciones aritméticas");
        do
        {
            while (Reset == true)
            {
                Console.WriteLine("Digite un número");
                try
                {
                    NumberAndResults = decimal.Parse(Console.ReadLine());
                    Reset = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("No se ha digitado un número valido");
                }
            }
            option = 0;
            Console.WriteLine("Digite la operación que desea realizar a continuación");
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Multiplicación");
            Console.WriteLine("4.División");
            Console.WriteLine("5.Empezar otra operación");
            Console.WriteLine("6.Abandonar la calculadora aritmética");
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine();
            }
            switch (option)
            {
                case 0:
                    {
                        Console.WriteLine("No se ha digitado una opción valida, por favor revise las opciones y elija un número");
                        break;
                    }
                case 1:
                    {
                        while (option == 1)
                        {
                            try
                            {
                                Console.Write("Digite el siguiente número de la operación " + NumberAndResults + " + ");
                                NumberAndResults = NumberAndResults + decimal.Parse(Console.ReadLine());
                                Console.WriteLine(" = " + NumberAndResults);
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("No se ha digitado un número");
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        while (option == 2)
                        {
                            try
                            {
                                Console.Write("Digite el siguiente número de la operación " + NumberAndResults + " - ");
                                NumberAndResults = NumberAndResults - decimal.Parse(Console.ReadLine());
                                Console.WriteLine(" = " + NumberAndResults);
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("No se ha digitado un número");
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        while (option == 3)
                        {
                            try
                            {
                                Console.Write("Digite el siguiente número de la operación " + NumberAndResults + " * ");
                                NumberAndResults = NumberAndResults * decimal.Parse(Console.ReadLine());
                                Console.WriteLine(" = " + NumberAndResults);
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("No se ha digitado un número");
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        while (option == 4)
                        {
                            try
                            {
                                Console.Write("Digite el siguiente número de la operación " + NumberAndResults + " / ");
                                decimal divisor = decimal.Parse(Console.ReadLine());
                                if (divisor == 0)
                                {
                                    Console.WriteLine("No se puede dividir entre cero");
                                }
                                else
                                {
                                    NumberAndResults = NumberAndResults / divisor;
                                    Console.WriteLine(" = " + NumberAndResults);
                                }
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("No se ha digitado un número");
                            }
                        }
                        break;
                    }
                case 5:
                    {
                        NumberAndResults = 0;
                        Reset = true;
                        break;
                    }
                case 6:
                    {
                        FlowControl = false;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("No se ha insertado un número valido");
                        break;
                    }
            }
        } while (FlowControl == true);
    }
    else if (option == 2)
    {
        do
        {
            decimal Accumulated = 0;
            Console.WriteLine("Bienvenido a la calculadora de estudiantes aprobados");
            Console.WriteLine("Digite la cantidad de periodos a evaluar");
            int Periods = 0;
            try
            {
                Periods = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine();
            }
            if (Periods > 0)
            {
                Console.WriteLine("Ingrese la calificación minima para aprobar");
                decimal MinimumGrade = 0;
                do
                {
                    try
                    {
                        MinimumGrade = decimal.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite un número válido para la calificación Minima");
                    }
                } while (MinimumGrade == 0);
                int i = 0;
                while (i < Periods)
                {
                    try
                    {
                        Console.WriteLine("Digite la calificacion del periodo " + (i + 1));
                        i++;
                        numbers.Add(decimal.Parse(Console.ReadLine()));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("No se ha ingresado un numero");
                        i--;
                    }
                }
                foreach (decimal number in numbers)
                {
                    Accumulated = Accumulated + number;
                }
                for (int a = 0; a < numbers.Count; a++)
                {
                    numbers[a] = 0;
                }
                bool Status = (Accumulated / Periods >= MinimumGrade);
                if (Status)
                {
                    Console.WriteLine("El estudiante ha aprobado");
                }
                else
                {
                    Console.WriteLine("El estudiante ha reprobado");
                }
                FlowControl = true;
            }
            else
            {
                Console.WriteLine("Digite un número válido de periodos");
                FlowControl = false;
            }
        } while (FlowControl == false);
        FlowControl = false;
    }
    else if (option == 3)
    {
        Console.WriteLine("Entendido, abandonando el programa...");
    }
    else
    {
        Console.WriteLine("No se ha seleccionado una opción valida, por favor, introduzca '1' o '2' para acceder a las calculadoras");
        Console.WriteLine("O introduzca '3' para abandonar el programa");
        FlowControl = false;
    }
} while (FlowControl == false);