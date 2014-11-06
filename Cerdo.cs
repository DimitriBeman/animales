using System;

namespace AnimalesFrankie
{
	public class Cerdo : IAnimal
	{
		public string Nombre { get; set; }

		public Cerdo(string nombre){
			Nombre = nombre;
		}

		#region IAnimal implementation
		public virtual void cagar ()
		{
			Console.WriteLine (this.Nombre + " esta cagando");
		}
		public void comer ()
		{
			Console.WriteLine (this.Nombre + " esta comer");
		}
		public void dormir ()
		{
			Console.WriteLine (this.Nombre + " esta dormir");
		}
		public void ruidoCaracteristico ()
		{
			Console.WriteLine (this.Nombre + " esta Oink Oink");
		}
		#endregion
	}
}
