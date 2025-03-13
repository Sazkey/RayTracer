using System.Text;

namespace RayTracerProject.image;

public class Image
{
    private const char White = '.';
    private const char Black = 'x';
    private static int _rows;
    private static int _columns;
    private static double _radius;
    private static (int, int) _centre;
    private static char[,]? _image;

    public static char[,]? GenerateImage()
    {
        _centre = ((_rows - 1) / 2, (_columns - 1) / 2);

        for (var i = 0; i < _rows; i++)
        {
            for (var j = 0; j < _columns; j++)
            {
                if (Math.Pow((j - _centre.Item2), 2) + Math.Pow((i - _centre.Item1), 2) <= Math.Pow(_radius, 2))
                {
                    if (_image != null) _image[i, j] = White;
                }
                else if (_image != null) _image[i, j] = Black;
            }
        }

        return _image;
    }

    public static string PrintImage(int rows, int columns, double radius)
    {
        var result = new StringBuilder();

        _rows = rows;
        _columns = columns;
        _radius = radius;
        _image = new char[_rows, _columns];

        GenerateImage();

        for (var i = 0; i < _rows; i++)
        {
            for (var j = 0; j < _columns; j++)
            {
                result.Append(_image[i, j]);
            }

            result.Append('\n');
        }

        return result.ToString();
    }
}