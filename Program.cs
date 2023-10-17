// See https://aka.ms/new-console-template for more information
int month = DateTime.Now.Month;

switch (month)
{
    
    case 10:
        Console.WriteLine("Ekim ayındasınız");
    break;
    case 11:
        Console.WriteLine("Kasım ayındasınız");
    break;
    case 12:
        Console.WriteLine("Aralık ayındasınız");
    break;

    default:
    Console.WriteLine("Yanlış veri girdiniz");
    break;
}
switch (month)
{
    case 10:
    case 11:
    case 12:
    Console.WriteLine("Kış ayındasınız");
    break;
    
    default:

    break;
}
