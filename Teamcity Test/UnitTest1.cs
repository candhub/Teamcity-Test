using FluentAssertions;

namespace Teamcity_Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var sut = new Sample();
        sut.Get_num().Should().Be(5);
    }
}
