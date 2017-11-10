public class Signal: element {

    public Signal(int value) {

        if (test(value)) {

            output = new int[1];
            output[0] = value;
            is_initiated = 1;            
        }
    }

    public override int result(int output_port) {

        if (is_initiated == 1 && output_port<output.Length) {
            return  output[output_port];
        }
        else {
            System.Environment.Exit(1);
            return -1;
        }
    }
};