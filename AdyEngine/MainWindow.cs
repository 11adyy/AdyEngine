using AdyEngine._3D_OBJECTS.GEOMETRY.GEOMETRY_OBJECTS;
using AdyEngine._3D_OBJECTS.GEOMETRY.LIGHT_OBJECTS;
using AdyEngine.ENGINE_OBJECTS;
using AdyEngine.ENGINE_OBJECTS.CAMERA.CHROME_CAMERA;
using AdyEngine.ENGINE_OBJECTS.CAMERA.COLOR;
using AdyEngine.OBJECTS;
using Object = AdyEngine._3D_OBJECTS.GEOMETRY.Object;

namespace AdyEngine;

public static class MainWindow {
    public static void Main() {
        Console.CursorVisible = false;

        var space = new Space(new ChromeCamera(new Vector3(-4,0,0), new Vector3(0), true, 20), 
            new List<Object> {
                new Collection(new Vector3(0), new Vector3(0), new List<Object> {
                    new Polygon(new [] {
                        new Vector3(0,-1,-1),
                        new Vector3(0,1,-1),
                        new Vector3(0,1,1),
                    }),
                    new Polygon(new [] {
                        new Vector3(0,-1,-1),
                        new Vector3(0,-1,1),
                        new Vector3(0,1,1),
                    }),
                    
                    new Polygon(new [] {
                        new Vector3(0,-1,-1),
                        new Vector3(0,-1,1),
                        new Vector3(6,-1,1),
                    }),
                }),
                new Light(new Vector3(0, 2, 0), 20)
            });

        var t = 0;
        while (true) {
            t++;
            space.GetView();
            
            space.GetObject("collection1").Rotate(new Vector3(0, .01, .01));
        }
    }
}