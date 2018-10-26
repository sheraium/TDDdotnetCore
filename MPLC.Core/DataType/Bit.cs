namespace MPLC.Core.DataType
{
    public class Bit
    {
        private readonly IMPLCProvider _mplc;
        private readonly string _address;

        public Bit(IMPLCProvider mplc, string address)
        {
            _mplc = mplc;
            _address = address;
        }

        public void SetOn()
        {
            _mplc.SetBitOn(_address);
        }

        public void SetOff()
        {
            _mplc.SetBitOff(_address);
        }

        public bool IsOn()
        {
            return _mplc.GetBit(_address);
        }
    }
}