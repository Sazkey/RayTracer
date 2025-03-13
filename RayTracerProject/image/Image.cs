using System.Text;

namespace RayTracerProject.image;

public class Image
{
    public int Rows { get; }
    public int Columns { get; }
    public Pixel[,] Pixels { get; }

    public Image(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        Pixels = new Pixel[Rows, Columns];
    }
}