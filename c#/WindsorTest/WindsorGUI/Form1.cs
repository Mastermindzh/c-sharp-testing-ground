using Castle.Windsor;
using NLog;
using System;
using System.Windows.Forms;

namespace WindsorGUI
{
	public partial class Form1 : Form
	{
		private static Logger logger = LogManager.GetCurrentClassLogger();

		public Form1()
		{
			InitializeComponent();
			logger.Info("Form started");
		}

		private void btn_get_data_Click(object sender, EventArgs e)
		{
			logger.Warn("Warning, getting info");

			var container = new WindsorContainer();

			container.Register(Castle.MicroKernel.Registration.Component.For<WindsorTest.main>());
			container.Register(Castle.MicroKernel.Registration.Component.For<WindsorTest.ISpaceBase>().ImplementedBy<WindsorTest.SpaceBase.SpaceBase>());
			container.Register(Castle.MicroKernel.Registration.Component.For<WindsorTest.ISpaceShip>().ImplementedBy<WindsorTest.SpaceShip.SpaceShip>());

			var mainThing = container.Resolve<WindsorTest.main>();
			mainThing.NameObjects();

			lbl_SpaceBase.Text = mainThing.getSpaceBaseName();
			lbl_SpaceShip.Text = mainThing.getSpaceShipName();

			logger.Fatal("Fatalities!");
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
