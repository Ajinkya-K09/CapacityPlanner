using VelocityCalculator.Model;

namespace VelocityCalculator.ViewModel
{
    public class VelocityCalculatorViewModel
    {
        public VelocityCalculatorViewModel()
        {
            var velocityCalculatorModelVM = new VelocityCalculatorModel();
            VelocityCalculatorVM = velocityCalculatorModelVM;
        }

        public VelocityCalculatorModel VelocityCalculatorVM { get; set; }

    }
}
