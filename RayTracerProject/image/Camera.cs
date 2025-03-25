namespace RayTracerProject.image;

public class Camera(Vector3 position, Vector3 viewPoint)
{
    public Vector3 Position { get; } = position;
    public Vector3 ViewPoint { get; } = viewPoint;
    public Vector3 ViewDirection => new(ViewPoint.X - Position.X, ViewPoint.Y - Position.Y, ViewPoint.Z - Position.Z);
}