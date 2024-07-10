namespace RM2.Login.Structures.Player
{
    public class Vector3
    {
        public float X { get; set; } = 0F;
        public float Y { get; set; } = 0F;
        public float Z { get; set; } = 0F;

        public static Vector3 Zero => new(0F, 0F, 0F);


        public Vector3() :
            this(0F, 0F, 0F)
        {
        }

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}