namespace superHeroes
{
    class SuperHeroe
    {
        string nombre;
        int fuerza;
        int resistencia;
        int superpoderes;

        private int Fuerza
        {
            get { return fuerza; }
            set
            {
                if (value < 0)
                {
                    fuerza = 0;
                }
                else if (value > 100)
                {
                    fuerza = 100;
                }
                else
                {
                    fuerza = value;
                }
            }
        }

        private int Resistencia
        {
            get { return resistencia; }
            set
            {
                if (value < 0)
                {
                    resistencia = 0;
                }
                else if (value > 100)
                {
                    resistencia = 100;
                }
                else
                {
                    resistencia = value;
                }
            }
        }

        private int Superpoderes
        {
            get { return superpoderes; }
            set
            {
                if (value < 0)
                {
                    superpoderes = 0;
                }
                else if (value > 100)
                {
                    superpoderes = 100;
                }
                else
                {
                    superpoderes = value;
                }
            }
        }

        public SuperHeroe(string nombre, int fuerza, int resistencia, int superpoderes)
        {
            this.nombre = nombre;
        }

        public static void Competir(SuperHeroe superHeroe1, SuperHeroe superHeroe2)
        {
            int sh1Wins = 0;
            int sh2Wins = 0;

            if (superHeroe1.Fuerza > superHeroe2.Fuerza)
            {
                sh1Wins++;
            }
            else
            {
                sh2Wins++;
            }

            if (superHeroe1.Resistencia > superHeroe2.Resistencia)
            {
                sh1Wins++;
            }
            else
            {
                sh2Wins++;
            }

            if (superHeroe1.Superpoderes > superHeroe2.Superpoderes)
            {
                sh1Wins++;
            }
            else
            {
                sh2Wins++;
            }

            if (sh1Wins > sh2Wins)   
            {
                Console.WriteLine("TRIUNFO");
            }
            else
            {
                Console.WriteLine("DERROTA");
            }

        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            SuperHeroe superHeroe1 = new("Batman", 90, 70, 0);
            SuperHeroe superHeroe2 = new("Superman", 95, 60, 70);

            SuperHeroe.Competir(superHeroe1, superHeroe2);
        }
    }
}