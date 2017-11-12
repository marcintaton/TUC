public class Demultiplexer: element {

    private int[] select_line;

    public Demultiplexer(params int[] values) {

        if (test(values)) {

            input = new int[1];
            select_line = new int[values.Length - 1];
            output = new int[System.Convert.ToInt32(System.Math.Pow(2, (values.Length - 1)))];

            for (int i = 0; i < select_line.Length; i++) {
                select_line[i] = values[i+1];
            }

            input[0] = values[0];

            calculate();
            is_initiated = 1;
        }
    }

    private void calculate() {

        for (int i = 0; i < output.Length; i++) {
            output[i] = 1;
        }

        string select_line_binary = string.Join("", select_line);
        int select_line_val = System.Convert.ToInt32(select_line_binary, 2);
        output[select_line_val] = input[0];
    }

    public override int result (int output_port) {

        if (is_initiated == 1 && output_port < output.Length) {
            return output[output_port];
        }
        else {
            System.Environment.Exit(1);
            return -1;
        }
    }

};