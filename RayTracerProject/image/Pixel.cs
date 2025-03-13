namespace RayTracerProject.image;

public class Pixel
{
    public static Pixel White = new Pixel(255, 255, 255);
    public static Pixel Black = new Pixel(0, 0, 0);
    private byte _r;
    private byte _g;
    private byte _b;

    public Pixel(byte r, byte g, byte b)
    {
        _r = r;
        _g = g;
        _b = b;
    }

    public override string ToString()
    {
        return _r.ToString() + " " + _g.ToString() + " " + _b.ToString() + '\n';
    }
}