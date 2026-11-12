using System.Data.Common;
using Raylib_cs;
public class VectorControl
{

    static List<Vector> vectors = new List<Vector>();
    static int nextId = 1;


    public int CreateVector()
    {
        if (Raylib.IsKeyReleased(KeyboardKey.P))
        {
            int id = nextId + 1;
            vectors.Add(new Vector();
            return nextId;
        }
        return 0;
    }

}