using System;

namespace ProjectX {
    public static class Program {

        private static void Main(string[] args) {
            ProjectXGame projectXGame = new ProjectXGame();

            projectXGame.Run();

            projectXGame.Dispose();
        }

    }
}

