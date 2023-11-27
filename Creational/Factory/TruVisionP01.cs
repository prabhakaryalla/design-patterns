public class TruVisionP01 : ICamera
{
    public string CameraModel()
    {
        return "TVGP-P01-0401-BUL-G";
    }

    public void Play()
    {
        throw new NotImplementedException();
    }

    public string Quality()
    {
        return "8MP";
    }
}