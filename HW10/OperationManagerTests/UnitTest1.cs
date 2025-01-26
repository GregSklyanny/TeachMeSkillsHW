using DelegatesProgram;

namespace OperationManagerTests
{
    public class UnitTest1
    {
        [Fact]
        public void AriphmeticTest()
        {
            var op = new OperationManager(10, -15);

            Assert.Equal(-5, op.executionManager.FuncExecute[Operation.Sum]());
            Assert.Equal(25, op.executionManager.FuncExecute[Operation.Subtract]());
            Assert.Equal(-150, op.executionManager.FuncExecute[Operation.Multiply]());
        }
    }
}