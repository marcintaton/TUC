using System.Linq;

public class Multiplexer: element {

    private int[] select_line;

    public Multiplexer(params int[] values) {

        if (test(values.Skip(1).ToArray()) && check_inpult_length(values)) {

            input = new int[System.Convert.ToInt32(System.Math.Pow(2, values[0]))];
            select_line = new int[values[0]];
            output = new int[1];

            for (int i = 0; i < select_line.Length; i++) {
                select_line[i] = values[i+1];
            }

            for (int i = 0; i < input.Length; i++) {
                input[i] = values[i+values[0]+1];
            }

            calculate();
            is_initiated = 1;
        }
    }

    private bool check_inpult_length(params int[] values) {

        if (values.Length == 1 + values[0] + System.Math.Pow(2, values[0])) {
            return true;
        }
        else {
            return false;
        }
    }

    private void calculate() {

        string select_line_binary = string.Join("", select_line);
        int select_line_val = System.Convert.ToInt32(select_line_binary, 2);
        output[0] = input[select_line_val];
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