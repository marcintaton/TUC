public class element {

    protected int is_initiated;

    protected int test(params int[] input) {

        for (int i = 0; i < input.Length; i++) {
            if (input[i] != 0 && input[i] != 1) {
                return 0;
            }
        }

        return 1;
    }

    public virtual int result (int output_port) {
        return 0;
    }

};

public class and: element {

    private int[] input;

    private int[] output;

    public and(int in_0, int in_1) {

        if (test(in_0, in_1) == 1) {

            input = new int[2];
            output = new int[1];

            input[0] = in_0;
            input[1] = in_1;

            calculate();
            is_initiated = 1;
        }
    }

    private void calculate () {

        if (input[0] == 1 && input[1] == 1) {
            output[0] = 1;
        }
        else {
            output[0] = 0;
        }
    }

    public override int result (int output_port) {

        if (is_initiated == 1) {
            return output[0];
        }
        else {
            System.Environment.Exit(1);
            return -1;
        }
    }

};

public class signal: element {

    private int signal_val;

    public signal(int value) {

        if (test(value) == 1) {
            signal_val = value;
            is_initiated = 1;            
        }
    }

    public override int result(int output_port) {

        if (is_initiated == 1) {
            return signal_val;
        }
        else {
            System.Environment.Exit(1);
            return -1;
        }
    }
};

class mainclass {

    static void Main() {

        signal x1 = new signal(1);
        signal x2 = new signal(1);
        and and1 = new and(x1.result(0), x2.result(0));
        System.Console.Write(and1.result(0));
        
    }

}