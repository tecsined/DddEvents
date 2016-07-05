using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Ddd.Events
{
    public class DomainEvents
    {
        private static List<Type> _handlers = new List<Type>();

        public static void Init()
        {
           var _handlersFromExecutingAssembly = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(
                    t =>
                        t.GetInterfaces()
                            .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof (IHandler<>)))
                .ToList();

            var _handlersFromCallingAssembly = Assembly.GetCallingAssembly()
              .GetTypes()
              .Where(
                  t =>
                      t.GetInterfaces()
                          .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IHandler<>)))
              .ToList();

            _handlers.AddRange(_handlersFromExecutingAssembly);

            _handlers.AddRange(_handlersFromCallingAssembly);
        }

        public static void Dispatch(IDomainEvents domainEvents)
        {
            for (var index = 0; index < _handlers.Count; index++)
            {
                var handlerType = _handlers[index];
                var canHandleEvent =
                    handlerType.GetInterfaces()
                        .Any(
                            i =>
                                i.IsGenericType
                                && i.GetGenericTypeDefinition() == typeof (IHandler<>)
                                && i.GenericTypeArguments[0] == domainEvents.GetType());

                if (!canHandleEvent) continue;

                dynamic handler = Activator.CreateInstance(handlerType);
                handler.Handle((dynamic) domainEvents);
            }
        }
    }
}
