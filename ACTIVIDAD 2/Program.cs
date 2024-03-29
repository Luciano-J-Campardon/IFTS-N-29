string? nombreParticipante;
string? puntajeString;
int acumulador = 0;
bool finIteracion = false;
bool datoValido = false;

do
{
    Console.WriteLine("Ingrese el nombre del participante");
    nombreParticipante = Console.ReadLine();
    if (nombreParticipante != null && nombreParticipante != "")
    {
        if (nombreParticipante == "fin" || nombreParticipante == "FIN")
        {
            finIteracion = true;
        }
        else
        {
            finIteracion = false;

            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese el puntaje del jurado N° {i + 1}");
                    puntajeString = Console.ReadLine();
                    Console.WriteLine();

                    if (puntajeString != null)
                    {
                        int puntajeInt;
                        datoValido = int.TryParse(puntajeString, out puntajeInt);
                        acumulador += puntajeInt;
                    }
                }
                while (datoValido != true);
            }
            Console.WriteLine($"El participante {nombreParticipante} ha obtenido una puntuacion de {(acumulador / 3)}");
            acumulador = 0;
        }
    }
    Console.WriteLine();
} while (finIteracion == false);



