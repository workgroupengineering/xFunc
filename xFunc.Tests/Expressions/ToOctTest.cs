// Copyright (c) Dmytro Kyshchenko. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace xFunc.Tests.Expressions;

public class ToOctTest : BaseExpressionTests
{
    [Test]
    public void ExecuteNumberTest()
    {
        var exp = new ToOct(Number.Two);

        Assert.That(exp.Execute(), Is.EqualTo("02"));
    }

    [Test]
    public void ExecuteNumberExceptionTest()
    {
        var exp = new ToOct(new Number(2.5));

        Assert.Throws<ArgumentException>(() => exp.Execute());
    }

    [Test]
    public void ExecuteLongMaxNumberTest()
    {
        var exp = new ToOct(new Number(int.MaxValue));

        Assert.That(exp.Execute(), Is.EqualTo("017777777777"));
    }

    [Test]
    public void ExecuteNegativeNumberTest()
    {
        var exp = new ToOct(new Number(-2));

        Assert.That(exp.Execute(), Is.EqualTo("037777777776"));
    }

    [Test]
    public void ExecuteBoolTest()
        => TestNotSupported(new ToOct(Bool.False));

    [Test]
    public void CloseTest()
    {
        var exp = new ToOct(new Number(10));
        var clone = exp.Clone();

        Assert.That(clone, Is.EqualTo(exp));
    }
}