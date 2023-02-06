using System.Runtime.InteropServices;

namespace Teams_KeepAwake
{
    internal class Main
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        public static void MoveMouseBy(int xDelta, int yDelta)
        {
            mouse_event(0x0001, xDelta, yDelta, 0, 0);
        }

        public static void Start()
        {
            Console.Title = "Teams KeepAwake by Umbra";
            Console.WriteLine("This Program prevents MS Teams from going into AFK mode by Moving the Mouse 1 pixel every 2 Seconds");

            while (true)
            {
                MoveMouseBy(1, 1);
                Console.WriteLine("Mouse ping sent");
                Thread.Sleep(120000);
            }
        }
    }
}
