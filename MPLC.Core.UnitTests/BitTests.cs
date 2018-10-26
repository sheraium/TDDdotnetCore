using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MPLC.Core.UnitTests
{
    [TestClass]
    public class BitTests
    {
        [TestMethod]
        public void SetOn()
        {
            var bit = new Bit();

            bit.SetOn();
        }
    }

    public class Bit
    {
        public void SetOn()
        {
            throw new System.NotImplementedException();
        }
    }
}