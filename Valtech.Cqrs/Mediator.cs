using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace Valtech.Cqrs
{
	public class Mediator : IMediator
	{
		private readonly IContainer _container;

		public Mediator(IContainer container)
		{
			_container = container;
		}

		public TResponse Request<TResponse>(IQuery<TResponse> query)
		{
			var handler = GetHandler(query);
			return (TResponse)handler.GetType().GetMethod("Handle").Invoke(handler, new object[] { query });
		}

		public TResponse Send<TResponse>(ICommand command)
		{
			throw new NotImplementedException();
		}

		object GetHandler<TResponseData>(IQuery<TResponseData> query)
		{
			var handlerType = typeof(IQueryHandler<,>).MakeGenericType(query.GetType(), typeof(TResponseData));
			var handler = _container.GetInstance(handlerType);
			return handler;
		}
	}
}
