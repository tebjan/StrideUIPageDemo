using Stride.Engine;

namespace UITestGame.Windows
{
    class UITestGameApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
