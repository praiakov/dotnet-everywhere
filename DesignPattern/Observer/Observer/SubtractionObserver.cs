using System;

namespace Observer.Observer
{
    public class SubtractionObserver : Interfaces.IObserver<SimpleCalculator>
    {
        public void Update(SimpleCalculator subject)
        {
            if (subject.Operation == Operation.Subtraction)
                Console.WriteLine($"A subtração dos valores é {subject.FirstNumber}-{subject.SecondNumber} = {subject.FirstNumber - subject.SecondNumber}");
        }
    }
}
