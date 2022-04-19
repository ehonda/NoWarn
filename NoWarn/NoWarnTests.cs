using NUnit.Framework;

namespace NoWarn;

public class NoWarnTests
{
    private string _s;

    private string F(string s)
        => s switch
        {
            "xyz" => "abc"
        };

    [Test]
    public void Passes()
    {
        Assert.Pass();
    }
}