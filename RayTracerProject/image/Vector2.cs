namespace RayTracerProject.image;

public class Vector2(int x, int y)
{
    public int X { get; } = x;
    public int Y { get; } = y;
    public double EuclideanNorm => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
}