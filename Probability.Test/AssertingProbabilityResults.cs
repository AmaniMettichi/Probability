using Xunit;

namespace Probability.Test
{
    public class AssertingProbabilityResults
    {
        [Fact]
        public void ProbabilityOfA_And_B_Test()
        {
            var sut = new ProbabilityEvents(); // sut: system under test
            var result = sut.ProbabilityOfA_And_B((decimal)0.35, (decimal)0.25);
            Assert.Equal((decimal)0.0875, result);
        }

        [Fact]
        public void ProbabilityOfA_Or_B_Test()
        {
            var sut = new ProbabilityEvents(); // sut: system under test
            var result = sut.ProbabilityOfA_Or_B((decimal)0.35, (decimal)0.25);
            Assert.Equal((decimal)0.5125, result);
        }

        [Fact]
        public void ProbabilityInverseOfA_Test()
        {
            var sut = new ProbabilityEvents(); // sut: system under test
            var result = sut.ProbabilityInverseOfA((decimal)0.35);
            Assert.Equal((decimal)0.65, result);
        }
    }
}
