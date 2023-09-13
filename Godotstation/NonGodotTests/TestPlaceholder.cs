using GodotStation.Engine;

namespace NonGodotTests;

public class TestPlaceholder
{
    [Fact]
    public void TestPlaceHolderIsNotNull()
    {
        Placeholder placeholder = new();
        placeholder.ShouldNotBeNull();
    }
}