namespace Domain.Flyweight
{
    using System.Drawing;

    public interface IWindow
    {
        void Draw(Graphics g, int x, int y, int width, int height);
    }

    public class RedWindow : IWindow
    {
        private Brush paintBrush;

        public RedWindow()
        {
            this.paintBrush = Brushes.Red;
            ObjectCounter++;
        }

        public static int ObjectCounter { get; set; } = 0;

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            g.FillRectangle(this.paintBrush, x, y, width, height);
        }
    }
}