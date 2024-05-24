    public class Car : IDisposable
    {
        private bool isDisposed = false;

        public Car()
        {
            Console.WriteLine("Car constructor");
        }

        ~Car()
        {
            Console.WriteLine("Car DESTRUCTOR");
            Dispose(false);
        }

        // IDisposable Dispose method
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    // you can clean up any managed code here
                }
                // clean up unmanaged resources here
                isDisposed = true;
            }
        }
    }