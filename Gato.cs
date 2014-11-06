using System;

namespace AnimalesFrankie
{
	public class Gato : IAnimal
	{
		string Nombre { get; set; }

		public Gato(string nombre){
			this.Nombre = nombre;
		}

		public void cagar ()
		{
			Console.WriteLine (this.Nombre + " esta cagando");
		}

		public void comer ()
		{
			Console.WriteLine (this.Nombre + " esta comiendo");
		}

		public void dormir ()
		{
			Console.WriteLine (this.Nombre + " esta dormir");
		}

		public void ruidoCaracteristico ()
		{
			Console.WriteLine (this.Nombre + " esta MIAUUUU, dimi te estas anganchando !");
		}
		public void hacerPlanteo(){
			Console.WriteLine (this.Nombre + " esta haciendote un planteo: vos me dijiste que me ibas a llevar el domingo con mi familia....");
		}

	}
}
