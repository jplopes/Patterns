namespace Domain.Flyweight
{
    using System.Collections.Generic;

    public class WindowFactory
    {
        private static Dictionary<string, IWindow> windows = new Dictionary<string, IWindow>();

        public static IWindow GetWindow(string windowType)
        {
            switch (windowType)
            {
                case "Red":
                    if (!windows.ContainsKey("Red"))
                    {
                        windows["Red"] = new RedWindow();
                    }

                    return windows["Red"];
                case "Blue":
                    if (!windows.ContainsKey("Blue"))
                    {
                        windows["Blue"] = new BlueWindow();
                    }

                    return windows["Blue"];
                default:
                    {
                        break;
                    }
            }

            return null;
        }
    }
}