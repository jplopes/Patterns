namespace Domain.Flyweight
{
    using System.Drawing;

    public class BlueWindow : IWindow
    {
        private Brush paintBrush;

        public BlueWindow()
        {
            this.paintBrush = Brushes.Blue;
            ObjectCounter++;
        }

        public static int ObjectCounter { get; set; } = 0;

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            g.FillRectangle(this.paintBrush, x, y, width, height);
        }
    }
}