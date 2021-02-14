using Mediator.Component;
using Mediator.Interfaces;
using Mediator.Service;
using System;

namespace Mediator.Mediator
{
    public class SumAndSubtractionMediator : IMediator
    {
        private SimpleCalculatorService _simpleCalculatorService = new SimpleCalculatorService();
        public void Send(object send)
        {
            if (send is SumComponent)
                _simpleCalculatorService.Sum((SumComponent)send);
            else if (send is SubtractionComponent)
                _simpleCalculatorService.Subtraction((SubtractionComponent)send);
            else
                throw new NotImplementedException();
        }
    }
}
