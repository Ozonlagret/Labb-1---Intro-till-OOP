namespace Labb_1___Intro_till_OOP
{
    public class Circle
    {
        public float _pi = 3.141f;
        public int Radius;

        public float GetArea(int Radius, float _pi)
        {
            return Radius * Radius * _pi;
        }
    }
}
