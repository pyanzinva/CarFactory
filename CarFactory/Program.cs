using CarFactory;

class Program
{
    static void Main()
    {
        ICarFactory sedanFactory = new SedanFactory();
        ICarFactory suvFactory = new SUVFactory();

        ICar sedan = sedanFactory.CreateCar();
        ICar suv = suvFactory.CreateCar();

        sedan.Accelerate();
        suv.Accelerate();
        suv.Accelerate();
        suv.DisplayInfo();

        Thread sedanThread = new Thread(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                sedan.Accelerate();
                Thread.Sleep(1000);
            }
        });

        Thread suvThread = new Thread(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                suv.Accelerate();
                Thread.Sleep(1000);
            }
        });

        sedanThread.Start();
        suvThread.Start();

        sedanThread.Join();
        suvThread.Join();

        sedan.DisplayInfo();
        suv.DisplayInfo();
    }
}
