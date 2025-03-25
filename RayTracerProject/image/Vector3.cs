namespace RayTracerProject.image;

public class Vector3(double x, double y, double z)
{
    public double X { get; } = x;
    public double Y { get; } = y;
    public double Z { get; } = z;
    public double EuclideanNorm => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
    public double DotProduct(Vector3 secondVector) => X * secondVector.X + Y * secondVector.Y + Z * secondVector.Z;
    public Vector3 Scaled(double scalar) => new Vector3(scalar * X, scalar * Y, scalar * Z);
    public Vector3 Sum(Vector3 addend) => new Vector3(addend.X + X, addend.Y + Y, addend.Z + Z);
}