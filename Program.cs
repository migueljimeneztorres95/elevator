class Solution {
	static int fib(int n) {
		if (n <= 1) {
      return n;
    }
		return fib(n - 1) + fib(n - 2);
	}

	static public void Main() {
		Console.Write("Number of floors: ");
    string value = Console.ReadLine();
    int A = Convert.ToInt32(value);
		Console.WriteLine("Number of distinct ways: " + fib(A + 1));
	}
}