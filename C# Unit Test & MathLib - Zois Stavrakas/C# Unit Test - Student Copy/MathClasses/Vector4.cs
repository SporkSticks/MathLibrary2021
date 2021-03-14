using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector4
    {
        public float x, y, z, w;

        public Vector4()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 0;
        }

        // Overloaded Constructor
        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        // V = V + V --> Vector Addition
        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            Vector4 result = new Vector4();
            result.x = lhs.x + rhs.x;
            result.y = lhs.y + rhs.y;
            result.z = lhs.z + rhs.z;
            result.w = lhs.w + rhs.w;

            return result;
        }

        // V = V - V --> Vector Subtraction
        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            Vector4 result = new Vector4();
            result.x = lhs.x - rhs.x;
            result.y = lhs.y - rhs.y;
            result.z = lhs.z - rhs.z;
            result.w = lhs.w - rhs.w;

            return result;
        }

        // V = f * V --> Vector Scaling (float lhs)
        public static Vector4 operator *(float lhs, Vector4 rhs)
        {
            Vector4 result = new Vector4();
            result.x = lhs * rhs.x;
            result.y = lhs * rhs.y;
            result.z = lhs * rhs.z;
            result.w = lhs * rhs.w;

            return result;
        }

        // V = V * f --> Vector Scaling (float rhs)
        public static Vector4 operator *(Vector4 lhs, float rhs)
        {
            Vector4 result = new Vector4();
            result.x = lhs.x * rhs;
            result.y = lhs.y * rhs;
            result.z = lhs.z * rhs;
            result.w = lhs.w * rhs;

            return result;
        }

        // f = V.Dot(V) --> Dot Product
        public float Dot(Vector4 vector4)
        {
            float dotProd = (x * vector4.x) + (y * vector4.y) + (z * vector4.z) + (w * vector4.w);
            return dotProd;
        }

        // V = V.Cross(V) --> Cross Product
        public Vector4 Cross(Vector4 rhs)
        {
            Vector4 crossProd = new Vector4();
            crossProd.x = (y * rhs.z) - (z * rhs.y);
            crossProd.y = (z * rhs.x) - (x * rhs.z);
            crossProd.z = (x * rhs.y) - (y * rhs.x);
            crossProd.w = 0;

            return crossProd;
        }

        // f = V.Magnitude() --> Magnitude
        public float Magnitude()
        {
            float magnitude = (float)Math.Sqrt(x * x + y * y + z * z + w * w);
            return magnitude;
        }

        // f = V.MagSq() --> Magnitude Sqaured
        public float MagSq()
        {
            float magSq = x * x + y * y + z * z + w * w;
            return magSq;
        }

        // Nomarlize() --> Normalise a given vector
        public void Normalize()
        {
            float magnitude = Magnitude();
            if (magnitude != 0)
            {
                x /= magnitude;
                y /= magnitude;
                z /= magnitude;
                w /= magnitude;
            }
        }
    }
}
