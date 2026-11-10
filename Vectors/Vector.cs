public struct Vector
{

    public Vector(float x, float y)
    {
        XComponent = x;
        YComponent = y;
    }

    public float Lenght()
    {
        return MathF.Sqrt(XComponent * XComponent + YComponent * YComponent);
    }

    public float XComponent { get; set; }
    public float YComponent { get; set; }

    // Toplama
    public static Vector operator +(Vector a, Vector b)
        => new Vector(a.XComponent + b.XComponent, a.YComponent + b.YComponent);

    // Çıkarma
    public static Vector operator -(Vector a, Vector b)
        => new Vector(a.XComponent - b.XComponent, a.YComponent - b.YComponent);

    // Skalerle çarpma
    public static Vector operator *(Vector a, float scalar)
        => new Vector(a.XComponent * scalar, a.YComponent * scalar);

    // Skalere bölme
    public static Vector operator /(Vector a, float scalar)
        => new Vector(a.XComponent / scalar, a.YComponent / scalar);


    public override string ToString() => $"({XComponent}, {YComponent})";
}