namespace MPLC.Core
{
    public interface IMPLCProvider
    {
        void SetBitOn(string address);
        void SetBitOff(string address);
    }
}