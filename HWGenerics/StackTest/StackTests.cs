using Generics;

namespace StackTest
{
    public class StackTests
    {
        MyStack<string> stringStack = new();
        MyStack<int> intStack = new();

        [Fact]
        public void ExceptionsTest()
        {
            stringStack.Push("a");
            stringStack.Push("b");
            stringStack.Pop();
            stringStack.Pop();

            intStack.Push(1);
            intStack.Push(2);
            intStack.Pop();
            intStack.Pop();

            Assert.Throws<EmptyStackException>( () => { stringStack.Pop(); });
            Assert.Throws<EmptyStackException>(() => { stringStack.Peek(); });

            Assert.Throws<EmptyStackException>(() => { intStack.Pop(); });
            Assert.Throws<EmptyStackException>(() => { intStack.Peek(); });
        }

        [Fact]
        public void EqualityTest()
        {
            stringStack.Push("a");
            stringStack.Push("b");
            
            intStack.Push(1);
            intStack.Push(2);
            
            Assert.Equal("b", stringStack.Pop());
            Assert.Equal("a", stringStack.Pop());

            Assert.Equal(2, intStack.Pop());
            Assert.Equal(1, intStack.Pop());
        }
    }
}