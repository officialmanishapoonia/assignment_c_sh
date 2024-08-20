using Assignment_C_;

internal class pro
{
    public static void Main()
    {
        currency_converter[] currency = new currency_converter[4];
        currency[0] = new currency_converter();
        currency[1] = new currency_converter("EUR", "USD", 1.11);
        currency[2] = new currency_converter();
        currency[3] = new currency_converter("EUR", "USD", 1.11);


        Console.WriteLine(currency[0].ConvertAmount(100));
        Console.WriteLine(currency[1].ConvertAmount(100));
        Console.WriteLine(currency[2].ConvertAmount(100, 78.68));
        Console.WriteLine(currency[3].ConvertAmount(100, 1.02));

        VendingMachine vendingMachine = new VendingMachine();
        Product snack = new Snack();
        Product beverage = new Beverage();
        vendingMachine.SelectProduct(snack);
        vendingMachine.SelectProduct(beverage);





    }
}