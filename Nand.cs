public class Nand: element {

    public Nand(params int[] values) {

        if (test(values)) {

            input = new int[values.Length];
            output = new int[1];

            for (int i = 0; i < values.Length; i++) {
                input[i] = values[i];
            }

            calculate();
            is_initiated = 1;
        }
    }

    private void calculate () {

        output[0] = 0;
        for (int i = 0; i < input.Length; i++) {
            if (input[i] == 0) {
                output[0] = 1;
            }
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