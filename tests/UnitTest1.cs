using Xunit;
using System;

namespace LaughingGiggle.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var entity = new Entity
        {
            Id = Guid.NewId(),
            CreatedAt = DateTime.Now()
        };
    }
}