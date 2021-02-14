using Mediator.Interfaces;

namespace Mediator.Component
{
    public abstract class BaseComponent
    {
        protected IMediator _mediator;

        public BaseComponent(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Send()
        {
            _mediator.Send(this);
        }
    }
}
