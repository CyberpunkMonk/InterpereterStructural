using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpereterStructural {
	class TerminalExpression:AbstractExpression {
		public override void Interperet(Context context) {
			Console.WriteLine("Called TerminalExpression.Interperet()");
		}
	}
}
