namespace Lab2;

internal class Inspector
{
    public void Log(ITransport transport) => transport.CrushedAsync();
}