public class element {

    protected int is_initiated;

    protected int[] input;

    protected int[] output;

    protected bool test(params int[] input) {

        for (int i = 0; i < input.Length; i++) {
            if (input[i] != 0 && input[i] != 1) {
                return false;
            }
        }

        return true;
    }

    public virtual int result (int output_port) {
        return 0;
    }

};