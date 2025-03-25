using System.Text;

namespace RayTracerProject.image;

public class PpmImage
{
    private Image _image;
    
    public PpmImage(Image image)
    {
        _image = image;
    }
    
    public override string ToString()
    {
        var result = new StringBuilder();
        result.AppendLine("P3");
        result.AppendLine($"{_image.Columns} {_image.Rows}");
        result.AppendLine("255");
        for (var i = 0; i < _image.Rows; i++)
        {
            for (var j = 0; j < _image.Columns; j++)
            {
                result.Append(_image.Pixel[i, j]);
            }
        }
        return result.ToString();
    }
}