// class AutoReset
// {
//     static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
//     static void Main()
//     {
//         Thread thread = new Thread(SomeMethod)
//         {
//             Name = "New Thread"
//         };

//         Thread thread2 = new Thread(SomeMethod)
//         {
//             Name = "Another Thread"
//         };

//         thread.Start();
//         thread2.Start();

//         Console.ReadLine();
//     }

//     static void SomeMethod()
//     {
//         autoResetEvent.WaitOne(); //Wait
//         System.Console.WriteLine("Starting...");
//         System.Console.WriteLine(Thread.CurrentThread.Name);
//         Thread.Sleep(2000);
//         System.Console.WriteLine("Finishing...");
//         System.Console.WriteLine(Thread.CurrentThread.Name);
//         autoResetEvent.Set();
//     }
// }