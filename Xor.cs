public class Xor: element {

    public Xor(int in_0, int in_1) {

        if (test(in_0, in_1)) {

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
            output[0] = 0;
        }
        else if (input[0] == 0 && input[1] == 0) {
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