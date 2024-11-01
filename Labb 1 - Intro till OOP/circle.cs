namespace Labb_1___Intro_till_OOP
{
    public class Circle
    {
        public float _pi = 3.141f;
        public int radius;

        public Circle()
        {
            radius = 6;
        }

        public float GetArea(int radius, float _pi)
        {
            return radius * radius * _pi;
        }
    }
}
