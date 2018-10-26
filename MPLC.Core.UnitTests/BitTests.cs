using Microsoft.VisualStudio.TestTools.UnitTesting;
using MPLC.Core.DataType;
using NSubstitute;

namespace MPLC.Core.UnitTests
{
    [TestClass]
    public class BitTests
    {
        [TestMethod]
        public void SetOn()
        {
            var mplc = GetMPLC();
            var bit = new Bit(mplc, "B100");

            bit.SetOn();

            mplc.Received().SetBitOn(Arg.Is("B100"));
        }

        [TestMethod]
        public void SetOff()
        {
            var mplc = GetMPLC();
            var bit = new Bit(mplc, "B100");

            bit.SetOff();

            mplc.Received().SetBitOff(Arg.Is("B100"));
        }

        [TestMethod]
        public void IsOn()
        {
            var mplc = GetMPLC();
            var bit = new Bit(mplc, "B100");
            mplc.GetBit(Arg.Is("B100")).Returns(true);

            var isOn = bit.IsOn();

            Assert.IsTrue(isOn);
        }

        private static IMPLCProvider GetMPLC()
        {
            var mplc = Substitute.For<IMPLCProvider>();
            return mplc;
        }
    }
}