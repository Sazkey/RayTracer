namespace RayTracerProject.image;

public class Vector2
{
    public int X { get; }
    public int Y { get; }
    public double EuclideanNorm => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));

    public Vector2(int x, int y)
    {
        X = x;
        Y = y;
    }
}