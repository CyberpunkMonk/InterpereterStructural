using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpereterStructural {
	abstract class AbstractExpression {
		public abstract void Interperet(Context context);
	}
}