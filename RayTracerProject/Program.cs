// See https://aka.ms/new-console-template for more information

using RayTracerProject.image;

Image exampleImage = new Image(48, 64);

var centre = ((exampleImage.Rows - 1) / 2, (exampleImage.Columns - 1) / 2);
var radius = 5;

for (int i = 0; i < exampleImage.Rows; i++)
{
    for (int j = 0; j < exampleImage.Columns; j++)
    {
        if ((Math.Pow(j - centre.Item2, 2) + Math.Pow(i - centre.Item1, 2) <= Math.Pow(radius, 2)))
            exampleImage.Pixels[i, j] = Pixel.White;
        else exampleImage.Pixels[i, j] = Pixel.Black;
    }
}

PpmImage pixels = new PpmImage(exampleImage);


File.WriteAllText(@"D:\RiderProjects\RayTracerProject\RayTracerProject\artifacts\ababa.ppm", pixels.ToString());