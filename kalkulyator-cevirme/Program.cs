Console.OutputEncoding=System.Text.Encoding.UTF8;




while (true)
{
    double netice = 0;
    double inputDeyer = deyerAl();

    Console.WriteLine("1)KG to T");
    Console.WriteLine("2)METR to SM");
    Console.WriteLine("3)F to C");

    int cevirmeEmelliyati = Convert.ToInt32(Console.ReadLine());
    
    switch(cevirmeEmelliyati)
    {
        case 0:
            Console.WriteLine("Programi Istifade Etdiyiniz Ucun Tesekkurler");
            return;
        case 1:
            Console.WriteLine("kg to t");
            netice = inputDeyer / 1000.0;
            Console.WriteLine($"{inputDeyer} kg={netice}");
            break;
        case 2:
            Console.WriteLine("Metr to sm");
            netice = inputDeyer * 100.0;
            Console.WriteLine($"{inputDeyer}  sm={netice}");
            break;
        case 3:
            Console.WriteLine("F to C");
            netice = (inputDeyer - 32.0) * 5 / 9.0;
            Console.WriteLine($"{inputDeyer} C={netice}");
            break;
        default:
            Console.WriteLine("Duzgun Secim Edin!");
            break;
    }

}

double deyerAl()
{
    while (true)
    {
        Console.WriteLine("Zehmet olmasa deyer daxil edin");
        try
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Xeta baş verdi");
        }
    }
}