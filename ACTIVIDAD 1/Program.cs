int precio;
string? readResult = "";
bool validEntry = false;

do
{
    Console.WriteLine("Ingrese el precio del producto sin ganancia del negocio");
    readResult = Console.ReadLine();
    if (readResult != null && readResult != "")
    {
        if ((validEntry = int.TryParse(readResult, out precio)) == false)
        {
            Console.WriteLine("El valor ingresado no es vàlido");
        }
        else
        {
            Console.WriteLine($"El precio de venta del producto es de ${(precio*1.15)}");
        }
    }
}
while (validEntry != true);