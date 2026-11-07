using HermesTest.Core;
using Xunit;

namespace HermesTest.Core.Tests;

public class HelloDialogTests
{
    [Fact]
    public void Message_is_exactly_Hello()
    {
        Assert.Equal("Hello", HelloDialog.Message);
    }
}
