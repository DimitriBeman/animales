using System;
using System.Collections.Generic;

namespace AnimalesFrankie
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<IAnimal> misAnimales = new List<IAnimal> ();

			var myperro = new Perro ("Ricardito");
			var myhisterico = new PerroHisterico ("Juance");


			myperro.cosaComplicada ();
			myhisterico.cosaComplicada ();

			misAnimales.Add (myperro);
			misAnimales.Add (myhisterico);
			misAnimales.Add (new Gato ("Angie"));
			misAnimales.Add (new GatoHermosa ("Cirio"));
			misAnimales.Add (new Cerdo ("Alfonsin"));
			misAnimales.Add (new CerdoEPICO ("Peron"));
			misAnimales.Add (new CerdoChorro ("Boudue"));
			misAnimales.Add (new CerdoNegligente ("IBarra"));

			foreach (var animal in misAnimales) {
				Console.WriteLine (animal.GetType ());
				animal.comer ();
				animal.cagar ();
				animal.dormir ();
			}
		}
	}
}
