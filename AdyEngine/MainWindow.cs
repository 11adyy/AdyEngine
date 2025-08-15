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
                //new Cube(new Vector3(0), new Vector3(2), Material.DefaultMaterial, "cube2"),
                //new Light(new Vector3(0, 1, -3), 1, "light1_1"),
                new Cube(new Vector3(0,0,0), new Vector3(2))
            });

        var t = 0;

        space.GetCamera().Angles = new Vector3(0, 1.25, 0);
        
        while (true) {
            t++;
            space.GetView();
        }
    }
}