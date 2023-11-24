using System.Runtime.InteropServices;

namespace TestProject1;

public class UnitTest1
{
    [Theory]
    [InlineData(new char[]{'o', 'l', 'l', 'e', 'H'}, new char[] {'H', 'e', 'l', 'l', 'o'}) ]
    public void Test1(char[] input, char[] result)
    {
        char[] l1 = input;
        PartySmurf.Bungalow.Reverse(l1);
        Assert.Equal(result, l1);
    }
}