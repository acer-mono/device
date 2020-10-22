namespace Device.Devices
{
    public interface IDevice
    {
        IDevice Clone();
        string GetInformation();
    }
}