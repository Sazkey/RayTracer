using RayTracerProject.vector;

namespace RayTracerProject.sceneObjects;

public class Sphere(Vector3 origin, double radius)
{
    public Vector3 Origin { get; } = origin;
    private double Radius { get; } = radius;
    public bool WithinSphere(Vector3 vector)
    {
        return vector.DotProduct(vector) <= Math.Pow(Radius, 2);
    }
}