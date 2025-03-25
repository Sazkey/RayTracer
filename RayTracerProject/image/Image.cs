namespace RayTracerProject.image;

public class Image
{
    public int Rows { get; }
    public int Columns { get; }
    public Pixel[,] Pixel { get; }

    public Image(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        Pixel = new Pixel[Rows, Columns];
    }
}