using System;

namespace ProjectX.ScreenManagment {
    public class MessageBoxScreen {

        private readonly string message;

        public extern void orig_Accept();
        public void Accept() {
            Console.WriteLine("MessageBoxScreen: Accept:");
            Console.WriteLine(message);
            orig_Accept();
        }

        public extern void orig_Cancel();
        public void Cancel() {
            Console.WriteLine("MessageBoxScreen: Cancel:");
            Console.WriteLine(message);
            orig_Cancel();
        }

    }
}

