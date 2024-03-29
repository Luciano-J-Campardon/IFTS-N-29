string? readResult;
string porcentajeTexto;
string txtMod1;
string txtMod2;
int montoTotal = 0;
decimal porcentajeSocio = 0;
bool validEntry = false;

string[] nombreSocios = new string[3];
int[] montoSocios = new int[3];

for (int i = 0; i < 3; i++)
{
    do
    {
        Console.WriteLine($"Ingrese el nombre del socio Nº{(i+1)}:");
        readResult = Console.ReadLine();
        Console.WriteLine();
        if (readResult != null)
        {
            nombreSocios[i] = readResult;
            do
            {
                Console.WriteLine($"Ingrese el monto aportado por el socio Nº{(i+1)}:");
                readResult = Console.ReadLine();
                Console.WriteLine();
                if ((int.TryParse(readResult, out montoSocios[i])) != false)
                {
                    montoTotal += montoSocios[i];
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine("El monto ingresado no es vàlido");
                    validEntry = false;
                }
            }
            while (validEntry == false);
        }
        else
        {
            Console.WriteLine("El nombre ingresado no es valido");
            validEntry = false;
        }
    }
    while (validEntry != true);
}

for (int i = 0; i < 3; i++)
{
    porcentajeSocio = ((decimal)montoSocios[i] / montoTotal);
    porcentajeTexto = porcentajeSocio.ToString();
    txtMod1 = porcentajeTexto.Substring(2,2);
    txtMod2 = porcentajeTexto.Substring(4,4);
    
    Console.WriteLine($"El socio {nombreSocios[i]} ha aportado un {txtMod1},{txtMod2}% del monto total");
    Console.WriteLine();
}



