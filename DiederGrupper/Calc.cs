using System;
using IStruktur;

namespace DiederGrupper
{
	abstract public class Calc : ICalc
	{
		abstract public DiederGruppe S ();
		abstract public DiederGruppe R(int n);
	}
}

