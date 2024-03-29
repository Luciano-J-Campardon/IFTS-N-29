int numSecuence;
int position;
int acumulator = 0;
int numChar;
string? numEnString = "";
string arrayChar = "";
bool validEntry = false;

do
{
    Console.WriteLine("Ingrese un nùmero entero no negativo");
    numEnString = Console.ReadLine();
    if (numEnString != null && numEnString != "")
    {
        if ((validEntry = int.TryParse(numEnString, out numSecuence)) == false)
        {
            Console.WriteLine("El valor ingresado no es vàlido");
        }
        else
        {
            position = numEnString.Length;
            string[] individualNumbers = new string[position];

            for (int i = 0; i < position; i++)
            {
                arrayChar = numEnString.Substring(i, 1);
                individualNumbers[i] = arrayChar;
                int.TryParse(arrayChar, out numChar);
                acumulator += numChar;
            }

            Console.WriteLine($"{string.Join(" + ", individualNumbers)} = {acumulator}");
        }
    }
}
while (validEntry != true);
