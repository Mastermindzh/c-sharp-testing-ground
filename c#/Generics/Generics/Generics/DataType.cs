namespace Generics.Generics
{
	public class DataType<T>
	{
		T _val;

		public T read()
		{
			return _val;
		}

		public void write(T val)
		{
			_val = val;
		}

	}
}
