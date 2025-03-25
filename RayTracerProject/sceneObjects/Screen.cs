using RayTracerProject.vector;

namespace RayTracerProject.sceneObjects;

public class Screen(int width, int height, Vector3 position)
{
    public int Width { get; } = width;
    public int Height { get; } = height;
    public Vector3 Position { get; } = position;
}