using System;
using System.Collections.Generic;

namespace AnimalesFrankie
{
	public class CerdoNegligente:Cerdo
	{
		public CerdoNegligente(string nombre):base(nombre){}

		public override void cagar(){
			base.cagar ();
			Console.WriteLine (this.Nombre + " esta cagando al Pueblo");
		}

	}
}
