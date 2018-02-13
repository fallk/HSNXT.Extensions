#region Usings

using HSNXT;
using System;
using System.Linq;
using System.Reflection;
using FluentAssertions;
using Xunit;

#endregion

namespace Extend.Testing
{
    public partial class AssemblyExTest
    {
        [Fact]
        public void GetAttributes()
        {
            var actual = typeof(String)
                .GetDeclaringAssembly()
                .GetAttributes<AssemblyCompanyAttribute>()
                .ToList();

            actual.Count
                .Should()
                .Be(1);
            actual.First()
                .Company.Should()
                .Be("Microsoft Corporation");
        }
    }
}