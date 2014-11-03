using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJob1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using System.Threading.Tasks;

    namespace Animales
    {
        public abstract class Animal
        {
            public string especie = "Animal";
            public string comida = "comida";
            public string ruido = "roar!";

            public Animal()
            {
                Console.WriteLine("cargando " + especie + "...");
                Console.ReadLine();
            }

            public virtual string comer()
            {
                Console.WriteLine(especie + " comiendo " + comida);
                return Console.ReadLine();
            }

            public string cagar()
            {
                Console.WriteLine(especie + " cagando...");
                return Console.ReadLine();
            }

            public string dormir()
            {
                Console.WriteLine("zzz...");
                return Console.ReadLine();
            }

            public string ruidoCaracteristico()
            {
                Console.WriteLine(ruido);
                return Console.ReadLine();
            }
        }

        public class Perro : Animal
        {
            public Perro()
            {
                especie = "Perro";
                comida = "doggy";
                ruido = "Wof! Wof!";
                Console.WriteLine("cargando " + especie + "...");
                Console.ReadLine();
            }
            public string babear()
            {
                Console.WriteLine(especie+" babeando...");
                return Console.ReadLine();
            }
        }

        public class Gato : Animal
        {
            public Gato()
            {
                especie = "Gato";
                comida = "whiskas";
                ruido = "Miau! Meeeeew!";
                Console.WriteLine("cargando " + especie + "...");
                Console.ReadLine();
            }
            public string frotarse()
            {
                Console.WriteLine(especie + " frotandose contra su amo...");
                return Console.ReadLine();
            }
        }

        public class Pajaro : Animal
        {
            public Pajaro()
            {
                especie = "Pajaro";
                comida = "semillitas";
                ruido = "Pio! Pio, Pio, Pio! La concha de tu madre sacame de la jaula, Pio!";
                Console.WriteLine("cargando " + especie + "...");
                Console.ReadLine();
            }
            public string volar()
            {
                Console.WriteLine(especie + " escapa de la jaula y vuela...");
                return Console.ReadLine();
            }
        }

        public class Vaca : Animal
        {
            public Vaca()
            {
                especie = "Vaca";
                comida = "pasto";
                ruido = "Muuuuuuu! Muuuuuuuu!";
                Console.WriteLine("cargando " + especie + "...");
                Console.ReadLine();
            }
            public string serAsado()
            {
                Console.WriteLine(especie + " muere y se convierte en un asadito para los pibes...");
                return Console.ReadLine();
            }
        }

        public class Cerdo : Animal
        {
            public Cerdo()
            {
                especie = "Cerdo";
                comida = "masa informe, probablemente compuesta por carnecita de su propia especie";
                ruido = "Oink! Oink!";
                Console.WriteLine("cargando " + especie + "...");
                Console.ReadLine();
            }
            public string revolucion()
            {
                Console.WriteLine(especie + " toma el poder de la granja y esclaviza a los demas animales...");
                return Console.ReadLine();
            }
        }
        class Test
        {
            public static void Main()
            {
                Perro perro = new Perro();
                perro.cagar();
                perro.comer();
                perro.ruidoCaracteristico();
                perro.dormir();
                perro.babear();

                Gato gato = new Gato();
                gato.cagar();
                gato.comer();
                gato.ruidoCaracteristico();
                gato.dormir();
                gato.frotarse();

                Pajaro pajaro = new Pajaro();
                pajaro.cagar();
                pajaro.comer();
                pajaro.ruidoCaracteristico();
                pajaro.dormir();
                pajaro.volar();

                Vaca vaca = new Vaca();
                vaca.cagar();
                vaca.comer();
                vaca.ruidoCaracteristico();
                vaca.dormir();
                vaca.serAsado();

                Cerdo cerdo = new Cerdo();
                cerdo.cagar();
                cerdo.comer();
                cerdo.ruidoCaracteristico();
                cerdo.dormir();
                cerdo.revolucion();

            }
        }
    }

}

