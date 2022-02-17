using CabInvoiceGeneratorAssignment;


Console.WriteLine("Welcome to CabInvoice Generator");

#region Normal Customers
InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
double fare = invoiceGenerator.CalculateFare(2.0, 5);
Console.WriteLine($"Fare for Normal customer : {fare}");
Console.ReadLine();
#endregion
#region Premium Customer
InvoiceGenerator invoiceGeneratorforPremium = new InvoiceGenerator(RideType.PREMIUM);
double fareforpremium = invoiceGeneratorforPremium.CalculateFare(2.0, 5);
Console.WriteLine($"Fare for Premium Customer : {fareforpremium}");
Console.ReadLine();
#endregion