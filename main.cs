class mainclass {

    static void Main() {

        //Sygnały
        Signal x1 = new Signal(System.Convert.ToInt32(System.Console.ReadLine()));
        Signal x2 = new Signal(System.Convert.ToInt32(System.Console.ReadLine()));
        Signal x3 = new Signal(System.Convert.ToInt32(System.Console.ReadLine()));
        Signal x4 = new Signal(System.Convert.ToInt32(System.Console.ReadLine()));

        //Bramki

        Nand nand1 = new Nand(x3.result(0), x4.result(1));
        Nand nand2 = new Nand(x3.result(1), x4.result(0));
        Nand nand3 = new Nand(nand1.result(0), nand2.result(0));
        Not not1 = new Not(nand2.result(0));
        Multiplexer mux1 = new Multiplexer(4, 0, 0, x1.result(0), x2.result(0), not1.result(0), nand3.result(0), 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);

        //Wynik
        System.Console.WriteLine("F = {0}", mux1.result(0));

        
    }

}