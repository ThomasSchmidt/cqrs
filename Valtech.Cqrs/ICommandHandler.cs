using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtech.Cqrs
{
	public interface ICommandHandler<in TCommand, out TResponse>
	{
		TResponse Handle(TCommand command);
	}
}
