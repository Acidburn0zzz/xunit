﻿namespace Xunit
{
    /// <summary>
    /// Used to decorate xUnit.net test classes and collections to indicate a test which has
    /// per-test-class fixture data. An instance of the fixture data is initialized just before
    /// the first test in the class is run, and if it implements IDisposable, is disposed
    /// after the last test in the class is run. To gain access to the fixture data from
    /// inside the test, a constructor argument should be added to the test class which
    /// exactly matches the <typeparamref name="TFixture"/>.
    /// </summary>
    /// <typeparam name="TFixture">The type of the fixture.</typeparam>
    public interface IClassFixture<TFixture> where TFixture : class, new() { }
}
