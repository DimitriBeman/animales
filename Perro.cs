using System;

namespace AnimalesFrankie
{
	public class Perro : IAnimal, ICanino
	{
		string Nombre { get; set; }

		public Perro(string nombre){
			Nombre = nombre;
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
			Console.WriteLine (this.Nombre + " esta dormiendo");
		}
		public void ruidoCaracteristico ()
		{
			Console.WriteLine (this.Nombre + " esta haciendo Wuf Wuf");
		}

		public void moder ()
		{
			Console.WriteLine (this.Nombre + " esta MORDIENDO");
		}

		public virtual void cosaComplicada(){
			algomasSimple ();
			otracosa ();
			algunaotracosa ();
		}

		internal void algomasSimple ()
		{
			throw new NotImplementedException ();
		}

		internal void otracosa ()
		{
			throw new NotImplementedException ();
		}

		internal void algunaotracosa ()
		{
			throw new NotImplementedException ();
		}
	}
}
