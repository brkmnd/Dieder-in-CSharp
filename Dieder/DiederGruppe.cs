using System;
using System.Collections.Generic;
using System.Linq;
using static Grupper.Dieder;

namespace DiederGrupper
{
	public class DiederGruppe : Calc
	{
		private Dieder d0;
		private bool s = true;
		private int r(int n){
			return n;
		}
		public DiederGruppe (int n){
			this.d0 = create (n);
		}
		private DiederGruppe (Dieder d){
			this.d0 = d;
		}
		public override string ToString (){
			return Dieder.toString ((acc,x) => acc + " " + x,this.d0);
		}
		public List<Int32> ToList(){
			return this.d0.vs.ToList();
		}
		public override DiederGruppe S(){
			return new DiederGruppe (this.d0 * this.s);
		}
		public override DiederGruppe R(int n){
			return new DiederGruppe (this.d0 * this.r(n));
		}
	}
}

