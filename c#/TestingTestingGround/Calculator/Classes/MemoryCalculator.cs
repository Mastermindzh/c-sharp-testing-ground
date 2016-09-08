namespace CalculatorTest.Classes
{
	public class MemoryCalculator
	{
		public int Amount { get; set; }

		public void Substract(int value)
		{
			Amount -= value;
		}
		public void Add(int value)
		{
			Amount += value;
		}
		public void Divide(int value) {
			Amount /= value;
		}
	}
}
