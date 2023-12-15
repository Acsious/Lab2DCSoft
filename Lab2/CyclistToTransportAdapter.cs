namespace Lab2;

internal class CyclistToTransportAdapter : ITransport
{
    Cyclist cyclist;
    public CyclistToTransportAdapter(Cyclist c) => cyclist = c;
    public void CrushedAsync() => cyclist.InjuredAsync();
}
