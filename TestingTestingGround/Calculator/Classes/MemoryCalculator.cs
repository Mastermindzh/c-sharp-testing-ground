namespace CalculatorTest.Classes
{
	public class MemoryCalculator
	{
		public int Amount { get; set; }

		public void Substract(int value)
		{
			Amount -= value;
		}
	}
}
