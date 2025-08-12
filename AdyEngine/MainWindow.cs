using AdyEngine.OBJECTS;
using Object = AdyEngine.OBJECTS.Object;

namespace AdyEngine;

public static class MainWindow {
    public static void Main() {
        Console.CursorVisible = false;

        var camera = new Camera(0d, 0d, 0d, 0d);
        var map = new Object((1,1,1), (4,0,0));
        var world = new World(camera);
        
        while (true) {
            world.GetView(0);
        }
    }
}