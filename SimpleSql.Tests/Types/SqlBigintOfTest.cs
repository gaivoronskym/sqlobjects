﻿using SimpleSql.Types;

namespace SimpleSql.Tests.Types;

public class SqlBigintOfTest
{
    [Fact]
    public void Act()
    {
        string expected = "123456789";

        Assert.Equal(
            expected,
            new SqlBigintOf(123456789).Raw()
        );
    }
}