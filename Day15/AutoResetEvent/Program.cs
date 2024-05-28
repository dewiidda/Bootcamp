// //Autoreset event has 3 method, Set() Reset() WaitOne()
// class Program
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

//         Console.ReadKey();
//         autoResetEvent.Set();
        
//     }

//     static void SomeMethod()
//     {
//         System.Console.WriteLine("Starting..");
//         System.Console.WriteLine(Thread.CurrentThread.Name);
//         autoResetEvent.WaitOne();
//         System.Console.WriteLine(Thread.CurrentThread.Name);
//         System.Console.WriteLine("Finishing..");
        
//     }
// }