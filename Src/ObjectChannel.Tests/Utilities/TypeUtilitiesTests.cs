namespace ObjectChannel.Tests.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using ObjectChannel.Utilities;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TypeUtilitiesTests
    {
        [TestMethod]
        public void GetTypeByName()
        {
            Type type = TypeUtilities.GetType("System.Int32");

            Assert.IsNotNull(type);
            Assert.AreEqual(type, typeof(int));
        }

        [TestMethod]
        public void GetTypeInAnotherAssembly()
        {
            Type type = TypeUtilities.GetType("System.Data.DataSet");

            Assert.IsNotNull(type);
            Assert.AreEqual(type, typeof(System.Data.DataSet));
        }

        [TestMethod]
        public void NullIfUnknownType()
        {
            Assert.IsNull(TypeUtilities.GetType("Foo.Bar"));
        }
    }
}
