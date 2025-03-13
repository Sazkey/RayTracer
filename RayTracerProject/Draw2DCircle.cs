using RayTracerProject.image;

var exampleImage = new Image(48, 64);

var centre = new Vector2((exampleImage.Columns - 1) / 2, (exampleImage.Rows - 1) / 2);
const int radius = 5;

for (var i = 0; i < exampleImage.Rows; i++)
{
    for (var j = 0; j < exampleImage.Columns; j++)
    {
        var pixel = new Vector2(Math.Abs(j - centre.X), Math.Abs(i - centre.Y));
        if (pixel.EuclideanNorm <= radius)
            exampleImage.Pixels[i, j] = Pixel.White;
        else exampleImage.Pixels[i, j] = Pixel.Black;
    }
}

PpmImage pixels = new PpmImage(exampleImage);

File.WriteAllText(@"D:\RiderProjects\RayTracerProject\RayTracerProject\artifacts\ababa.ppm", pixels.ToString());