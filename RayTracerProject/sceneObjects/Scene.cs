namespace RayTracerProject.sceneObjects;

public class Scene(Sphere sphere, Camera camera, double focalDistance, Screen screen)
{
    public Sphere Sphere { get; } = sphere;
    public Camera Camera { get; } = camera;
    public double FocalDistance { get; } = focalDistance;
    public Screen Screen { get; } = screen;
}