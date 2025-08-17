using AdyEngine._3D_OBJECTS.GEOMETRY;
using AdyEngine._3D_OBJECTS.GEOMETRY.GEOMETRY_OBJECTS;
using AdyEngine._3D_OBJECTS.GEOMETRY.LIGHT_OBJECTS;
using AdyEngine._3D_OBJECTS.MATERIALS;
using AdyEngine.ENGINE_OBJECTS;
using AdyEngine.ENGINE_OBJECTS.CAMERA;
using AdyEngine.ENGINE_OBJECTS.CAMERA.CHROME_CAMERA;
using AdyEngine.ENGINE_OBJECTS.CAMERA.COLOR;
using AdyEngine.OBJECTS;
using Object = AdyEngine._3D_OBJECTS.GEOMETRY.Object;

namespace AdyEngine;

public static class MainWindow {
    public static void Main() {
        Console.CursorVisible = false;

        var space = new Space(new ChromeCamera(new Vector3(-4,0,0), new Vector3(0)), 
            new List<Object> {
                new Sphere(new Vector3(0,4, 0), new Vector3(1), Material.DefaultMaterial, "sphere_1"),   
                new Sphere(new Vector3(0,1, 0), new Vector3(1), Material.DefaultMaterial, "sphere_2"),  
                new Light(new Vector3(0, -4, 0), 1, "light_1")
            });

        var t = 0;
        while (true) {
            t++;
            space.GetView();
            //space.GetObject("light_1").SetPosition(new Vector3(0, -4,Math.Cos(t * .010) * 2));
            space.GetObject("sphere_2").SetPosition(new Vector3(0, 1,Math.Cos(t * .010)));
        }
    }
}