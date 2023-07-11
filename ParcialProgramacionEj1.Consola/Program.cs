namespace ParcialProgramacionEj1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Area, Volumen, Altura, Base, CantidadIngresada;
            Area = 0;
            Volumen = 0;
            CantidadIngresada = 1;
            Base = 0;

            do
            {
                Console.Write("Ingrese Altura: ");
                var str = Console.ReadLine();
                Console.Write("Ingrese la Base: ");
                var sttr = Console.ReadLine();
                if (double.TryParse(str, out Altura))
                {
                    if (double.TryParse(sttr, out Base))
                    {
                        if (Altura != 0 & Base != 0)
                        {
                            Area = FuncionDeArea(Altura, Base);
                            Volumen = FuncionDeVolumen(Altura, Base);
                        }
                        else
                        {
                            break;
                        }
                        CantidadIngresada++;
                        Console.WriteLine($"El Area es: {Area}");
                        Console.WriteLine($"El Volumen es: {Volumen}");
                    }  
                    else
                    {
                            Console.WriteLine("Lo ingresado no es valido");
                    }
                }
                else
                {
                    Console.WriteLine("Lo ingresado no es valido");
                }
  
           } while (true);
               CantidadIngresada--;
            Console.WriteLine($"Se ingresaron {CantidadIngresada} piramides");
        }
        
            


        private static double FuncionDeVolumen(double Altura, double Base)
        {
            return Math.Pow(Base, 2) * Altura / 3;
        }

        private static double FuncionDeArea(double Altura, double Base)
        {
            return Base * (Base + (Math.Sqrt(4 * Math.Pow(Altura, 2) + Math.Pow(Base, 2))));  
        }
    }
}