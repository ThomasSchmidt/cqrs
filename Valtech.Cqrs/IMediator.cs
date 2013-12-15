using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtech.Cqrs
{
	public interface IMediator
	{
		TResponse Request<TResponse>(IQuery<TResponse> query);
		TResponse Send<TResponse>(ICommand command);
	}
}
