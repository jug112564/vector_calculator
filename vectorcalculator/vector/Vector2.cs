using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vectorcalculator.vector
{
    public class Vector2
    {
        private double x;
        private double y;

        public Vector2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetX() { return x; }
        public double GetY() { return y; }

        //one vector need
        public double Length()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public double LengthSq()
        {
            return (x * x + y * y);
        }

        public Vector2 Normalize()
        {
            double len = Length();
            
            if(len>double.Epsilon)
            {
                x /= len;
                y /= len;
            }
            return this;
        }

        public Vector2 Perp()
        {
            return new Vector2(-y, x);
        }

        public Vector2 Truncate(double max)
        {
            Vector2 result = this;
            if (Length() > max)
            {
                Normalize();

                result *= max;
            }
            return result;
        }

        public Vector2 GetReverse()
        {
            return new Vector2(-x,-y);
        }

        //two vector need
        public double Dot(Vector2 v2)
        {
            return (x * v2.x + y * v2.y);
        }

        public int Sign(Vector2 v2)
        {
            if (y * v2.x > x * v2.y)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public double Distance(Vector2 v2)
        {
            double ySeparation = v2.y - y;
            double xSeparation = v2.x - x;

            return Math.Sqrt(ySeparation * ySeparation + xSeparation * xSeparation);
        }

        public double DistanceSq(Vector2 v2)
        {
            double ySeparation = v2.y - y;
            double xSeparation = v2.x - x;

            return (ySeparation * ySeparation + xSeparation * xSeparation);
        }

        public Vector2 Reflect(Vector2 v2)
        {
            Vector2 result = this;
            result += 2.0 * Dot(v2) * v2.GetReverse();
            return result;
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            double x = v1.x + v2.x;
            double y = v1.y + v2.y;
            return new Vector2(x, y);
        }

        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            double x = v1.x - v2.x;
            double y = v1.y - v2.y;
            return new Vector2(x, y);
        }

        public static Vector2 operator *(Vector2 v1, double n1)
        {
            double x = v1.x * n1;
            double y = v1.y * n1;
            return new Vector2(x, y);
        }

        public static Vector2 operator *(double n1, Vector2 v1)
        {
            double x = v1.x * n1;
            double y = v1.y * n1;
            return new Vector2(x, y);
        }

        public static Vector2 operator /(Vector2 v1, double n1)
        {
            double x = v1.x / n1;
            double y = v1.y / n1;
            return new Vector2(x, y);
        }

        public static Vector2 operator /(double n1, Vector2 v1)
        {
            double x = v1.x / n1;
            double y = v1.y / n1;
            return new Vector2(x, y);
        }

        public static bool operator ==(Vector2 v1, Vector2 v2)
        {
            return (v1.x == v2.x) && (v1.y == v2.y);
        }
        public static bool operator !=(Vector2 v1, Vector2 v2)
        {
            return !(v1==v2);
        }

    }
}
