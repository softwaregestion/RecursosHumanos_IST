using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.RRHH
{
    public interface IMediator
    {
        void Command(ICommand command);

        TResult Query<TResult>(IQuery<TResult> query);
    }

    public sealed class Mediator : IMediator
    {
        private readonly Container container;

        public Mediator(Container container)
        {
            this.container = container;
        }

        [DebuggerStepThrough]
        public void Command(ICommand command)
        {
            var handlerType = typeof(ICommandHandler<>).MakeGenericType(command.GetType());

            dynamic handler = container.GetInstance(handlerType);

            handler.Handle((dynamic)command);
        }

        [DebuggerStepThrough]
        public TResult Query<TResult>(IQuery<TResult> query)
        {
            var handlerType = typeof(IQueryHandler<,>).MakeGenericType(new Type[] { query.GetType(), typeof(TResult) });

            dynamic handler = container.GetInstance(handlerType);

            return (TResult)handler.Handle((dynamic)query);
        }
    }

    #region COMMAND

    public interface ICommand { }

    public interface ICommandResult : ICommand
    {
        object Result { get; set; }
    }
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        void Handle(TCommand command);
    }

    #endregion

    #region QUERY
    public interface IQuery<TResult> { }

    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        TResult Handle(TQuery query);
    }


    #endregion
}
