class mainclass {

    static void Main() {

        //Sygnały
        Signal x1 = new Signal(System.Convert.ToInt32(System.Console.ReadLine()));
        Signal x2 = new Signal(System.Convert.ToInt32(System.Console.ReadLine()));

        //Bramki
        And and1 = new And(x1.result(0), x2.result(0));
        Nand nand1 = new Nand(x1.result(0), x2.result(0));
        Or or1 = new Or(x1.result(0), x2.result(0));
        Nor nor1 = new Nor(x1.result(0), x2.result(0));
        Xor xor1 = new Xor(x1.result(0), x2.result(0));
        Xnor xnor1 = new Xnor(x1.result(0), x2.result(0));
        Not not1 = new Not(x1.result(0));
        Not not2 = new Not(x2.result(0));

        //Wynik
        System.Console.WriteLine("And = {0}", and1.result(0));
        System.Console.WriteLine("Nand = {0}", nand1.result(0));
        System.Console.WriteLine("Or = {0}", or1.result(0));
        System.Console.WriteLine("Nor = {0}", nor1.result(0));
        System.Console.WriteLine("Xor = {0}", xor1.result(0));
        System.Console.WriteLine("Xnor = {0}", xnor1.result(0));
        System.Console.WriteLine("Not x1 = {0}", not1.result(0));
        System.Console.WriteLine("Not x2 = {0}", not2.result(0));
        
    }

}