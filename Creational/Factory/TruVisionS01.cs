public class TruVisionS01 : ICamera
{
    public string CameraModel()
    {
        return "TVTH-S01-0001-BUL-G";
    }

    public string Quality()
    {
        return "4MP";
    }

    public void Play()
    {
        throw new NotImplementedException();
    }
}