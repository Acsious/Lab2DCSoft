using Lab2;

// путешественник
Driver driver = new();
// машина
Car auto = new();
// отправляемся в путешествие
driver.Travel(auto);
// встретились пески, надо использовать верблюда
Camel camel = new();
// используем адаптер
ITransport camelTransport = new CamelToTransportAdapter(camel);
// продолжаем путь по пескам пустыни
driver.Travel(camelTransport);

Console.Read();
