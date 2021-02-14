using Mediator.Interfaces;

namespace Mediator.Component
{
    public class SubtractionComponent : BaseComponent
    {

        public SubtractionComponent(int firstNumber, int secondNumber, IMediator mediator) : base(mediator)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
    }
}
