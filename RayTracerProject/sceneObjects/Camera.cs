using RayTracerProject.image;
using RayTracerProject.vector;

namespace RayTracerProject.sceneObjects;

public class Camera(Vector3 position, Vector3 viewPoint)
{
    public Vector3 CameraUp = new(0, 1, 0);
    public Vector3 CameraRight = new(1, 0, 0);
    public Vector3 Position { get; } = position;
    public Vector3 ViewPoint { get; } = viewPoint;
    public Vector3 ViewDirection => new(ViewPoint.X - Position.X, ViewPoint.Y - Position.Y, ViewPoint.Z - Position.Z);
}