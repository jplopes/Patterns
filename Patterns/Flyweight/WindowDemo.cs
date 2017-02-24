namespace Flyweight
{
    using System;
    using System.Windows.Forms;

    using Domain.Flyweight;

    public partial class WindowDemo : Form
    {
        private Random random = new Random();

        public WindowDemo()
        {
            this.InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for (int i = 0; i < 20; i++)
            {
                IWindow redWindow = WindowFactory.GetWindow("Red");
                redWindow.Draw(
                    e.Graphics,
                    this.GetRandomNumber(),
                    this.GetRandomNumber(),
                    this.GetRandomNumber(),
                    this.GetRandomNumber());
            }

            for (int i = 0; i < 20; i++)
            {
                IWindow stoneTile = WindowFactory.GetWindow("Blue");
                stoneTile.Draw(
                    e.Graphics,
                    this.GetRandomNumber(),
                    this.GetRandomNumber(),
                    this.GetRandomNumber(),
                    this.GetRandomNumber());
            }

            this.lblObjectCounter.Text = "Total Objects Created : "
                                         + Convert.ToString(RedWindow.ObjectCounter + BlueWindow.ObjectCounter);
        }

        private int GetRandomNumber()
        {
            return (int)this.random.Next(100);
        }

        private void WindowDemo_Load(object sender, EventArgs e)
        {
        }
    }
}