using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtech.Cqrs.SomeService
{
	public class SomeServiceImp : ISomeService
	{
		public string DoSomeThing()
		{
			return "in DoSomeThing()";
		}
	}
}
