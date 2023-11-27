public class CameraFactory
{

    public static ICamera GetCamera(string cameraModel)
    {
        ICamera camera = null;
        if (cameraModel == "TVGP-P01-0401-BUL-G")
        {
            camera = new TruVisionP01();
        }
        else if (cameraModel == "TVTH-S01-0001-BUL-G")
        {
            camera = new TruVisionS01();
        }
        return camera;
    }

}