public class Not: element {

    public Not(int in_value) {

        if (test(in_value)) {

            input = new int[1];
            output = new int[1];

            input[0] = in_value;

            calculate();
            is_initiated = 1;
        }
    }

    private void calculate () {

        if (input[0] == 1) {
            output[0] = 0;
        }
        else {
            output[0] = 1;
        }
    }

    public override int result (int output_port) {

        if (is_initiated == 1 && output_port<output.Length) {
            return output[output_port];
        }
        else {
            System.Environment.Exit(1);
            return -1;
        }
    }

};