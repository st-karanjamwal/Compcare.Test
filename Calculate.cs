namespace Compcare.Test
{
	public class Calculate
    {
        public Calculate() { }
        public int Add(int a, int b)
        {
            var result = a + b;
            return result;
        }

        public int Substract(int a, int b)
        {
            var result = a - b;
            return result;
        }

        public int Multiply(int a, int b)
        {
            var result = a * b;
            return result;
        }

        public float Divide(int a, int b)
        {
            var result = a / b;
            return result;
        }
    }
}
