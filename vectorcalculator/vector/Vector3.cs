using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectorcalculator.vector
{
    public class Vector3
    {
        private double x;
        private double y;
        private double z;

        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double GetX() { return x; }
        public double GetY() { return y; }
        public double GetZ() { return z; }

        //one vector need
        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public double LengthSq()
        {
            return (x * x + y * y + z * z);
        }

        public Vector3 Normalize()
        {
            double len = Length();

            if (len > double.Epsilon)
            {
                x /= len;
                y /= len;
                z /= len;
            }
            return this;
        }

        public Vector3 Perp()
        {
            return new Vector3(-y, x, -z);
        }

        public Vector3 Truncate(double max)
        {
            Vector3 result = this;
            if (Length() > max)
            {
                Normalize();

                result *= max;
            }
            return result;
        }

        public Vector3 GetReverse()
        {
            return new Vector3(-x, -y, -z);
        }

        //two vector need
        public double Dot(Vector3 v2)
        {
            return (x * v2.x + y * v2.y + z * v2.z);
        }

        public int Sign(Vector3 v2)
        {
            // 시계 방향 정의에 따라 X와 Y 성분을 사용
            if (y * v2.x > x * v2.y)
            {
                return 1;
            }
            else if (y * v2.x < x * v2.y)
            {
                return -1;
            }
            else
            {
                // Z축 방향에 따라 시계 방향과 반시계 방향을 정의
                if (z > v2.z)
                {
                    return 1;
                }
                else if (z < v2.z)
                {
                    return -1;
                }
                else
                {
                    return 0; // 벡터가 동일한 방향을 가리킴
                }
            }
        }

        public double Distance(Vector3 v2)
        {
            double ySeparation = v2.y - y;
            double xSeparation = v2.x - x;
            double zSeparation = v2.z - z;

            return Math.Sqrt(ySeparation * ySeparation + xSeparation * xSeparation + zSeparation * zSeparation);
        }
        public double DistanceSq(Vector3 v2)
        {
            double ySeparation = v2.y - y;
            double xSeparation = v2.x - x;
            double zSeparation = v2.z - z;

            return (ySeparation * ySeparation + xSeparation * xSeparation + zSeparation * zSeparation);
        }

        public Vector3 Reflect(Vector3 v2)
        {
            Vector3 result = this;
            result += 2.0 * Dot(v2) * v2.GetReverse();
            return result;
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            double x = v1.x + v2.x;
            double y = v1.y + v2.y;
            double z = v1.z + v2.z;
            return new Vector3(x, y, z);
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            double x = v1.x - v2.x;
            double y = v1.y - v2.y;
            double z = v1.z - v2.z;
            return new Vector3(x, y, z);
        }

        public static Vector3 operator *(Vector3 v1, double n1)
        {
            double x = v1.x * n1;
            double y = v1.y * n1;
            double z = v1.z * n1;
            return new Vector3(x, y, z);
        }

        public static Vector3 operator *(double n1, Vector3 v1)
        {
            double x = v1.x * n1;
            double y = v1.y * n1;
            double z = v1.z * n1;
            return new Vector3(x, y, z);
        }

        public static Vector3 operator /(Vector3 v1, double n1)
        {
            double x = v1.x / n1;
            double y = v1.y / n1;
            double z = v1.z / n1;
            return new Vector3(x, y, z);
        }

        public static Vector3 operator /(double n1, Vector3 v1)
        {
            double x = v1.x / n1;
            double y = v1.y / n1;
            double z = v1.z / n1;
            return new Vector3(x, y, z);
        }

        public static bool operator ==(Vector3 v1, Vector3 v2)
        {
            return (v1.x == v2.x) && (v1.y == v2.y) && (v1.z == v2.z);
        }
        public static bool operator !=(Vector3 v1, Vector3 v2)
        {
            return !(v1 == v2);
        }
    }
}
