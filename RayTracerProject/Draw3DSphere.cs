using RayTracerProject.image;
using RayTracerProject.sceneObjects;
using RayTracerProject.vector;

var camera = new Camera(new Vector3(0, 0, -20), new Vector3(0, 0, 0));
var image = new Image(64, 48);
var sphere = new Sphere(new Vector3(0, 0, 0), 5);
var screen = new Screen(image.Rows, image.Columns, new Vector3(0, 0, -10));

var scene = new Scene(sphere, camera, 10, screen);

for (var i = 0; i < image.Rows; i++)
{
    for (var j = 0; j < image.Columns; j++)
    {
        var ray = new Vector3(0, 0, 0);
        if (sphere.WithinSphere(ray)) image.Pixel[i, j] = Pixel.Black;

        // image.Pixel[i,j]
    }
}

// Console.WriteLine($"{ray.X} {ray.Y} {ray.Z}");