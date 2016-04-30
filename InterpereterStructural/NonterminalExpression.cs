using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpereterStructural {
	class NonterminalExpression:AbstractExpression {
		public override void Interperet(Context context) {
			Console.WriteLine("Called Nonterminal.Interperet()");
		}
	}
}
