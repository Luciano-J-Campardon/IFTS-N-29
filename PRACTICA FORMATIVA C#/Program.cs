using System.ComponentModel;
using System.Dynamic;

namespace Program
{
    public class Televisor
    {
        private string marca;
        private string modelo;
        private int cantidadDePulgadas;
        private int numeroCanal;
        public bool estadoTelevision;  //true = encendido y false = apagado

        private string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        private int CantidadDePulgadas
        {
            get { return cantidadDePulgadas; }
            set { cantidadDePulgadas = value; }
        }

        private int NumeroCanal
        {
            get { return numeroCanal; }
            set { numeroCanal = value; }
        }

        private bool EstadoTelevision
        {
            get { return estadoTelevision; }
            set { estadoTelevision = value; }
        }

        public Televisor(string marca, string modelo, int pulgadas, int canal, bool estado, Persona persona1, Persona persona2)
        {
            this.marca = marca;
            this.modelo = modelo;
            cantidadDePulgadas = pulgadas;
            numeroCanal = canal;
            estadoTelevision = estado;
        }

        public static int ObtenerCanalActual(Televisor television)
        {
            return television.numeroCanal;
        }

        public static string verPrendido(Televisor television)
        {
            bool estadoActual = television.estadoTelevision;
            if (estadoActual != true)
            {
                return "Falso";
            }
            else
            {
                return "Verdadero";
            }
        }

        public static void cambiarEstado(Televisor television)
        {
            bool estadoActual = television.estadoTelevision;
            if (estadoActual != true)
            {
                television.estadoTelevision = true;
            }
            else
            {
                television.estadoTelevision = false;
            }
        }

        public static void cambiarCanal(Televisor television, int numOption)
        {
            television.numeroCanal = numOption;
        }

        public static void cambiarCanal(Televisor television)
        {
            television.numeroCanal += 1;
            if (television.numeroCanal > 150)
            {
                television.numeroCanal = 1;
            }
        }

    }

    public class Persona
    {
        private string nombre;

        private string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Persona(string valorNombre, Domicilio casa)
        {
            nombre = valorNombre;
        }
    }

    public class Domicilio
    {
        private string calle;
        private string barrio;
        private int numero;

        private string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        private string Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }

        private int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public Domicilio(string valorCalle, string valorBarrio, int valorNum)
        {
            calle = valorCalle;
            barrio = valorBarrio;
            numero = valorNum;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;
            bool exitProgram1 = false;
            bool validNumber = false;
            int numOption;
            string? readResult;
            string eleccionMenu = "";
            string currentUser = "";

            Domicilio casa = new("Jonte", "Monte Castro", 5299);
            Persona persona1 = new("Facundo", casa);
            Persona persona2 = new("Camila", casa);
            Televisor television = new("Samsung", "UN55CU7000GCZB", 55, 1, true, persona1, persona2);

            do
            {
                Console.WriteLine("\nElija quien de los siguientes usuarios va usar el televisor (Ingrese solamente el nùmero de usuario)\n");
                Console.WriteLine("1 - FACUNDO");
                Console.WriteLine("2 - CAMILA");
                Console.WriteLine("3 - SALIR DEL PROGRAMA\n");

                readResult = Console.ReadLine();
                Console.WriteLine();
                if (readResult != null)
                {
                    if (int.TryParse(readResult, out numOption))
                    {
                        if (numOption < 0 || numOption > 3)
                        {
                            Console.WriteLine("La opcion ingresada no es vàlida");
                        }
                        else
                        {
                            if (numOption == 1)
                            {
                                currentUser = "FACUNDO";
                                Console.WriteLine($"ELECCION CONFIRMADA. EL USUARIO ACTUAL ES {currentUser}\n");
                            }
                            else if (numOption == 2)
                            {
                                currentUser = "CAMILA";
                                Console.WriteLine($"ELECCION CONFIRMADA. EL USUARIO ACTUAL ES {currentUser}\n");
                            }
                            else if (numOption == 3)
                            {
                                exitProgram = true;
                            }

                            while (currentUser == "FACUNDO" || currentUser == "CAMILA")
                            {
                                do
                                {
                                    Console.WriteLine("Elegì de entre las siguientes opciones para administrar la television\n");
                                    Console.WriteLine("1 - Indicar si la television esta prendida (devuelve verdadero) o apagada (devuelve falso)");
                                    Console.WriteLine("2 - Encender/Apagar la television");
                                    Console.WriteLine("3 - Cambiar el canal (Ingrese el canal que desea ver de entre los 150 disponibles)");
                                    Console.WriteLine("4 - Cambiar el canal (Incrementa en 1 el nùmero del canal actual)");
                                    Console.WriteLine("5 - Indicar el nùmero del canal actual");
                                    Console.WriteLine("6 - Salir del menù / Cambiar de usuario\n");

                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                    {
                                        eleccionMenu = readResult;
                                    }

                                    if (int.TryParse(eleccionMenu, out numOption))
                                    {
                                        if (numOption < 0 || numOption > 6)
                                        {
                                            Console.WriteLine("La opcion ingresada no es vàlida");
                                        }
                                        else
                                        {
                                            switch (numOption)
                                            {
                                                case 1:
                                                    {
                                                        Console.WriteLine();
                                                        Console.WriteLine(Televisor.verPrendido(television));
                                                        Console.WriteLine();
                                                    }
                                                    break;

                                                case 2:
                                                    {
                                                        Console.WriteLine();
                                                        Televisor.cambiarEstado(television);
                                                    }
                                                    break;

                                                case 3:
                                                    {
                                                        if (television.estadoTelevision != true)
                                                        {
                                                            Console.WriteLine("Operacion no valida. Primero debe encender la television\n");
                                                        }
                                                        else
                                                        {
                                                            do
                                                            {
                                                                Console.WriteLine("\nIngrese el nùmero del canal que quiere ver\n");
                                                                readResult = Console.ReadLine();
                                                                if (readResult != null)
                                                                {
                                                                    if (int.TryParse(readResult, out numOption))
                                                                    {
                                                                        if (numOption < 1 || numOption > 150)
                                                                        {
                                                                            Console.WriteLine("\nEl numero de canal ingresado no es vàlido. Los canales disponibles van del 1 al 150\n");
                                                                        }
                                                                        else
                                                                        {
                                                                            Televisor.cambiarCanal(television, numOption);
                                                                            validNumber = true;
                                                                            Console.WriteLine();
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("El numero de canal ingresado no es vàlido\n");
                                                                    }
                                                                }
                                                            }
                                                            while (validNumber != true);
                                                        }
                                                    }
                                                    break;

                                                case 4:
                                                    {
                                                        if (television.estadoTelevision != true)
                                                        {
                                                            Console.WriteLine("\nOperacion no valida. Primero debe encender la television\n");
                                                        }
                                                        else
                                                        {
                                                            Televisor.cambiarCanal(television);
                                                        }
                                                    }
                                                    break;

                                                case 5:
                                                    {
                                                        if (television.estadoTelevision != true)
                                                        {
                                                            Console.WriteLine("\nOperacion no valida. Primero debe encender la television\n");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"\nNumero del canal actual: {Televisor.ObtenerCanalActual(television)}\n");
                                                        }
                                                    }
                                                    break;

                                                case 6:
                                                    {
                                                        exitProgram1 = true;
                                                        currentUser = "";
                                                    }
                                                    break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nLa opcion ingresada no es vàlida\n");
                                    }
                                }
                                while (exitProgram1 == false);             
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("La opcion ingresada no es vàlida");
                    }
                }
            }
            while (exitProgram == false);


        }
    }
}