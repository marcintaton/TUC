public class Signal: element {

    public Signal(int value) {

        if (test(value)) {

            output = new int[2];
            output[0] = value;

            if (value == 1) {
                output[1] = 0;
            }
            else {
                output[1] = 1;
            }
            
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