using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtech.Cqrs
{
	public interface IQueryHandler<in TQuery, out TResponse>
		where TQuery : IQuery<TResponse>
	{
		TResponse Handle(TQuery query);
	}
}
