double Area, Volumen, Altura, Base, Contador;
Contador = 0;
do
{
    Console.WriteLine("Se solicita que ingrese la altura de la piramide");
    var str = Console.ReadLine();
    if (Double.TryParse(str, out Altura))
    {
        if (Altura > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Valor mal ingresado, intente nuevamente");
        }
    }
    else
    {
        Console.WriteLine("El valor ingresado no es un numero, intente nuevamente");
    }
} while (true);
do
{
    Console.WriteLine("Se solicita que ingrese la base de la piramide");
    var strl = Console.ReadLine();
    if (double.TryParse(strl, out Base))
    {
        if (Base > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Valor mal ingresado, intente nuevamente");
        }
    }
    else
    {
        Console.WriteLine("El valor ingresado no es un numero, intente nuevamente");
    }
} while (true);
Contador = Contador + 1;
Volumen = CalcularVolumen(Base, Altura);
Area = CalcularArea(Base, Altura);

Console.WriteLine($"El area de la piramide es: {Area}");
Console.WriteLine($"El volumen de la piramide es: {Volumen}");
Console.WriteLine($"La cantidad de piramides ingresadas son: {Contador}");

double CalcularArea(double Base, double Altura)
{
    return Math.Round(Base * (Base + Math.Sqrt(4 * Math.Pow(Altura, 2) + Math.Pow(Base, 2))));
}

double CalcularVolumen(double Base, double Altura)
{
    return Math.Round(Math.Pow(Base, 2) * Altura) / 3;
}
