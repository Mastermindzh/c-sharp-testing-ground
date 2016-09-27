using Castle.Windsor;
using System;
using System.Windows.Forms;

namespace WindsorGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_get_data_Click(object sender, EventArgs e)
		{
			var container = new WindsorContainer();

			container.Register(Castle.MicroKernel.Registration.Component.For<WindsorTest.main>());
			container.Register(Castle.MicroKernel.Registration.Component.For<WindsorTest.ISpaceBase>().ImplementedBy<WindsorTest.SpaceBase.SpaceBase>());
			container.Register(Castle.MicroKernel.Registration.Component.For<WindsorTest.ISpaceShip>().ImplementedBy<WindsorTest.SpaceShip.SpaceShip>());

			var mainThing = container.Resolve<WindsorTest.main>();
			mainThing.NameObjects();

			lbl_SpaceBase.Text = mainThing.getSpaceBaseName();
			lbl_SpaceShip.Text = mainThing.getSpaceShipName();
		}
	}
}
