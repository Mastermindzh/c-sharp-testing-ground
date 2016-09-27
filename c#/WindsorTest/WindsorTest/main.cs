namespace WindsorTest
{
	public class main
	{
		private ISpaceBase _SpaceBase;
		private ISpaceShip _SpaceShip;

		public main(ISpaceBase SpaceBase, ISpaceShip SpaceShip)
		{
			_SpaceBase = SpaceBase;
			_SpaceShip = SpaceShip;
		}

		public void NameObjects()
		{
			_SpaceBase.Name = "Deep space nine";
			_SpaceShip.Name = "The Defiant";
		}

		public string getSpaceShipName()
		{
			return _SpaceShip.Name;
		}
		public string getSpaceBaseName()
		{
			return _SpaceBase.Name;
		}
	}
}
