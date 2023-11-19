using Lab2;

Console.WriteLine("Программа оформления дтп с участием велосепидиста.\n");

Inspector inspector = new();

Car auto = new();
inspector.Log(auto);

Cyclist cyclist = new();
ITransport cyclistTransport = new CyclistToTransportAdapter(cyclist);
inspector.Log(cyclistTransport);
