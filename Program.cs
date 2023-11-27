using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace design_patterns;

class Program
{
    #region  Singleton
    // static void Main(string[] args)
    // {
    //     Console.WriteLine("Simple Singleton Implementation");
    //     SimpleSingleton objSimpleSingleton = SimpleSingleton.GetInstance;
    //     objSimpleSingleton.PrintMessage("Simple Singleton Implementation");

    //     SimpleSingleton objSimpleSingleton2 = SimpleSingleton.GetInstance;
    //     objSimpleSingleton2.PrintMessage("Simple Singleton Implementation");

    //     Console.WriteLine("--------------------------------------------------");

    //     Console.WriteLine("Issue with Simple Singleton without sealed");

    //     SimpleSingleton.DerivedSimpleSingleton objDerivedSimpleSingleton1 = new SimpleSingleton.DerivedSimpleSingleton();
    //     objDerivedSimpleSingleton1.PrintMessage("Simple Singleton Implementation from nested class");

    //     SimpleSingleton.DerivedSimpleSingleton objDerivedSimpleSingleton2 = new SimpleSingleton.DerivedSimpleSingleton();
    //     objDerivedSimpleSingleton2.PrintMessage("Simple Singleton Implementation from nested class");

    //     Console.WriteLine("--------------------------------------------------");

    //     Console.WriteLine("Thread safety Issue with Simple Singleton with sealed");

    //     Parallel.Invoke(() => PrintSimpleSingletonDetails(), 
    //     () => PrintSimpleSingletonDetails());

    //     Console.WriteLine("--------------------------------------------------");

    //     Console.WriteLine("Singleton with Lock");

    //     Parallel.Invoke(() => PrintSingletWithLockonDetails(), 
    //     () => PrintSingletWithLockonDetails());

    //     Console.WriteLine("--------------------------------------------------");

    //     Console.WriteLine("Singleton with Eager Loading");

    //     Parallel.Invoke(() => PrintSingletWithEagerLoadingDetails(), 
    //     () => PrintSingletWithEagerLoadingDetails());

    //     Console.WriteLine("--------------------------------------------------");

    //     Console.WriteLine("Singleton with Lazy Loading");

    //     Parallel.Invoke(() => PrintSingletWithLazyLoadingDetails(), 
    //     () => PrintSingletWithLazyLoadingDetails());

    //     Console.WriteLine("--------------------------------------------------");

    //     Console.ReadLine();

    // }

    static void PrintSimpleSingletonDetails()
    {
        SimpleSealedSingleton objSimpleSealedSingleton = SimpleSealedSingleton.GetInstance;
        objSimpleSealedSingleton.PrintMessage("Simple Sealed Singleton Implementation");
    }

    static void PrintSingletWithLockonDetails()
    {
        SingletonWithLock obj = SingletonWithLock.GetInstance;
        obj.PrintMessage("Singleton with Lock Implementation");
    }

    static void PrintSingletWithEagerLoadingDetails()
    {
        SingletonWithEagerLoading obj = SingletonWithEagerLoading.GetInstance;
        obj.PrintMessage("Singleton with Eager Loading Implementation");
    }

    static void PrintSingletWithLazyLoadingDetails()
    {
        SingletonWithLazyLoading obj = SingletonWithLazyLoading.GetInstance;
        obj.PrintMessage("Singleton with Lazy Loading Implementation");
    }

    #endregion


    #region Factory
    static void Main(string[] args)
    {

        Console.WriteLine("Implentation without Factory");

        string cameraModel = "TVGP-P01-0401-BUL-G";

        ICamera camera = null;

        if (cameraModel == "TVGP-P01-0401-BUL-G")
        {
            camera = new TruVisionP01();
        }
        else if (cameraModel == "TVTH-S01-0001-BUL-G")
        {
            camera = new TruVisionS01();
        }

        if (camera != null)
        {
            Console.WriteLine("CameraModel : " + camera.CameraModel());
            Console.WriteLine("Camera Quality : " + camera.Quality());
        }
        else
        {
            Console.Write("Invalid Camera Model");
        }

        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("Implentation with Factory");

        ICamera camera1 =  CameraFactory.GetCamera(cameraModel);
        Console.WriteLine("CameraModel : " + camera1.CameraModel());
        Console.WriteLine("Camera Quality : " + camera1.Quality());




        Console.WriteLine("--------------------------------------------------");


        Console.ReadLine();

    }
    #endregion
}
