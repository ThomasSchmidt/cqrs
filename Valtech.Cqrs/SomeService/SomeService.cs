using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtech.Cqrs.SomeService
{
	public class SomeService : ISomeService
	{
		public string DoSomeThing()
		{
			return "in DoSomeThing()";
		}
	}
}
