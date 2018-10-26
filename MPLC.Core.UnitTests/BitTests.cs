using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace MPLC.Core.UnitTests
{
    [TestClass]
    public class BitTests
    {
        [TestMethod]
        public void SetOn()
        {
            var mplc = Substitute.For<IMPLCProvider>();
            var bit = new Bit(mplc, "B100");

            bit.SetOn();

            mplc.Received().SetBitOn(Arg.Is("B100"));
        }
    }
}