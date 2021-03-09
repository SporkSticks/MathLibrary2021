using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector3
    {
        public float x, y, z;

        // Default Constructor
        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        // Overloaded Constructor
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // V = V + V --> Vector Addition
        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            Vector3 result = new Vector3();
            result.x = lhs.x + rhs.x;
            result.y = lhs.y + rhs.y;
            result.z = lhs.z + rhs.z;

            return result;
        }

        // V = V - V --> Vector Subtraction
        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            Vector3 result = new Vector3();
            result.x = lhs.x - rhs.x;
            result.y = lhs.y - rhs.y;
            result.z = lhs.z - rhs.z;

            return result;
        }

        // V = f * V --> Vector Scaling (float lhs)
        public static Vector3 operator *(float lhs, Vector3 rhs)
        {
            Vector3 result = new Vector3();
            result.x = lhs * rhs.x;
            result.y = lhs * rhs.y;
            result.z = lhs * rhs.z;

            return result;
        }

        // V = V * f --> Vector Scaling (float rhs)
        public static Vector3 operator *(Vector3 lhs, float rhs)
        {
            Vector3 result = new Vector3();
            result.x = lhs.x * rhs;
            result.y = lhs.y * rhs;
            result.z = lhs.z * rhs;

            return result;
        }

        // f = V.Dot(V) --> Dot Product
        public float Dot(Vector3 vector3)
        {
            float dotProd = (x * vector3.x) + (y * vector3.y) + (z * vector3.z);
            return dotProd;
        }

        // V = V.Cross(V) --> Cross Product
        public Vector3 Cross(Vector3 rhs)
        {
            Vector3 crossProd = new Vector3();
            crossProd.x = (y * rhs.z) - (z * rhs.y);
            crossProd.y = (z * rhs.x) - (x * rhs.z);
            crossProd.z = (x * rhs.y) - (y * rhs.x);

            return crossProd;
        }

        // f = V.Magnitude() --> Magnitude
        public float Magnitude()
        {
            float magnitude = (float)Math.Sqrt(x * x + y * y + z * z);
            return magnitude;
        }

        // f = V.MagSq() --> Magnitude Sqaured
        public float MagSq()
        {
            float magSq = x * x + y * y + z * z;
            return magSq;
        }

        // Nomarlize() --> return a normalised vector
        public void Normalize()
        {
            float magnitude = Magnitude();
            if (magnitude != 0)
            {
                x /= magnitude;
                y /= magnitude;
                z /= magnitude;
            }
        }

        // setRotateX(f)

        // setRotateY(f)

        // setRotateZ(f)

    }
}
