using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace InterpereterStructural {
	class MainApp {
		static void Main() {
			Context context = new Context();

			//Usually a tree
			ArrayList list = new ArrayList();

			//Populate 'abstract syntax tree'
			list.Add(new TerminalExpression());
			list.Add(new NonterminalExpression());
			list.Add(new TerminalExpression());
			list.Add(new TerminalExpression());

			//Interperet
			foreach (AbstractExpression exp in list) {
				exp.Interperet(context);
			}

			//Wait for user
			Console.ReadKey();
		}
	}
}
