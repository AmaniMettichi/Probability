namespace Probability
{
    public struct ProbabilityEvents
    {
        public decimal ProbabilityOfA_And_B(decimal probabilityOfEventA, decimal probabilityOfEventB)
        {
            return probabilityOfEventA * probabilityOfEventB;
        }

        public decimal ProbabilityOfA_Or_B(decimal probabilityOfEventA, decimal probabilityOfEventB)
        {
            return probabilityOfEventA + probabilityOfEventB - ProbabilityOfA_And_B(probabilityOfEventA, probabilityOfEventB);
        }

        public decimal ProbabilityInverseOfA(decimal probabilityOfEventA)
        {
            return 1 - probabilityOfEventA;
        }

        static void Main(string[] args)
        {
        }
    }
}
