using AdyEngine._3D_OBJECTS.MATERIALS;
using AdyEngine.OBJECTS;

namespace AdyEngine._3D_OBJECTS.GEOMETRY.LIGHT_OBJECTS;

public class Light : Object {
    /// <summary>
    /// Light object
    /// </summary>
    /// <param name="position"> Light position </param>
    /// <param name="strength"> Strength of light </param>
    /// <param name="name"> Light name </param>
    public Light(Vector3 position, double strength, string name = "light1")  : base(position, new Vector3(0), Material.DefaultMaterial, name) {
        Position = position;
        Strength = strength;
        Name     = name;
    }
    
    private double Strength { get; set; }

    public override Vector2 Intersection(Vector3 rayOrigin, Vector3 rayDirection, out Vector3 intersectionNormal) {
        intersectionNormal = new Vector3(0);
        return new Vector2(0);
    }

    public double GetStrength() => Strength;
}