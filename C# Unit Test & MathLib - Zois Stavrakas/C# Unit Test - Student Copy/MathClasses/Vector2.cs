using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
	public class Vector2
	{
        public float x, y;

        // Default Constructor
        public Vector2()
        {
            x = 0;
            y = 0;
        }

        // Overloaded Constructor
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        // V = V + V --> Vector Addition
        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            Vector2 result = new Vector2();
            result.x = lhs.x + rhs.x;
            result.y = lhs.y + rhs.y;

            return result;
        }

        // V = V - V --> Vector Subtraction
        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            Vector2 result = new Vector2();
            result.x = lhs.x - rhs.x;
            result.y = lhs.y - rhs.y;

            return result;
        }

        // V = f * V --> Vector Scaling (float lhs)
        public static Vector2 operator *(float lhs, Vector2 rhs)
        {
            Vector2 result = new Vector2();
            result.x = lhs * rhs.x;
            result.y = lhs * rhs.y;

            return result;
        }

        // V = V * f --> Vector Scaling (float rhs)
        public static Vector2 operator *(Vector2 lhs, float rhs)
        {
            Vector2 result = new Vector2();
            result.x = lhs.x * rhs;
            result.y = lhs.y * rhs;

            return result;
        }

        // f = V.Dot(V) --> Dot Product
        public float Dot(Vector2 vector2)
        {
            float dotProd = (x * vector2.x) + (y * vector2.y);
            return dotProd;
        }

        // V = V.PerpendicularPosX(V) --> Get Perpendicular Angle to Vector (Positive X)
        public Vector2 PerpendicularPosX(Vector2 vector2)
        {
            Vector2 perpVector = new Vector2(-y, x);
            return perpVector;
        }

        // V = V.PerpendicularNegX(V) --> Get Perpendicular Angle to Vector (Negative X)
        public Vector2 PerpendicularNegX(Vector2 vector2)
        {
            Vector2 perpVector = new Vector2(y, -x);
            return perpVector;
        }

        // f = GetAngleBetween(V1, V2) --> get angle between two vectors
        public float GetAngleBetween(Vector2 lhs, Vector2 rhs, bool returnClockwise)
        {
            lhs.Normalize();
            rhs.Normalize();
            float fDot = lhs.Dot(rhs);

            float angle = (float)Math.Acos(fDot);

            
            if (returnClockwise)
            {

            }

            return angle;
        }

        // f = V.Magnitude() --> Magnitude
        public float Magnitude()
        {
            float magnitude = (float)Math.Sqrt(x * x + y * y);
            return magnitude;
        }

        // f = V.MagSq() --> Magnitude Sqaured
        public float MagSq()
        {
            float magSq = x * x + y * y;
            return magSq;
        }

        // Nomarlize() --> return a normalised vector
        public void Normalize()
        {
            float magnitude = Magnitude();
            if(magnitude != 0)
            {
                x /= magnitude;
                y /= magnitude;
            }
        }

        // setRotateX(f)

        // setRotateY(f)
    }
}
