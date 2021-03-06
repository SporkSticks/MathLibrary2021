using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix4
    {
        // Initialise the 16 entries in the matrix
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16;

        // Default Constructor
        public Matrix4()
        {
            m1 = 1; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = 1; m7 = 0; m8 = 0;
            m9 = 0; m10= 0; m11= 1; m12= 0;
            m13= 0; m14= 0; m15= 0; m16= 1;
        }

        // Overloaded Constructor
        public Matrix4(float m1 = 0.0f, float m2 = 0.0f, float m3 = 0.0f, float m4 = 0.0f,
                       float m5 = 0.0f, float m6 = 0.0f, float m7 = 0.0f, float m8 = 0.0f,
                       float m9 = 0.0f, float m10 = 0.0f, float m11 = 0.0f, float m12 = 0.0f,
                       float m13 = 0.0f, float m14 = 0.0f, float m15 = 0.0f, float m16 = 0.0f)
        {
            this.m1 = m1;  this.m2 = m2;  this.m3 = m3;  this.m4 = m4;
            this.m5 = m5;  this.m6 = m6;  this.m7 = m7;  this.m8 = m8;
            this.m9 = m9;  this.m10= m10; this.m11= m11; this.m12= m12;
            this.m13= m13; this.m14= m14; this.m15= m15; this.m16= m16;
        }

        // Scalar Multiplication --> M = M * f
        public static Matrix4 operator *(Matrix4 lhs, float rhs)
        {
            Matrix4 result = new Matrix4();

            result.m1  = lhs.m1  * rhs;
            result.m2  = lhs.m2  * rhs;
            result.m3  = lhs.m3  * rhs;
            result.m4  = lhs.m4  * rhs;
            result.m5  = lhs.m5  * rhs;
            result.m6  = lhs.m6  * rhs;
            result.m7  = lhs.m7  * rhs;
            result.m8  = lhs.m8  * rhs;
            result.m9  = lhs.m9  * rhs;
            result.m10 = lhs.m10 * rhs;
            result.m11 = lhs.m11 * rhs;
            result.m12 = lhs.m12 * rhs;
            result.m13 = lhs.m13 * rhs;
            result.m14 = lhs.m14 * rhs;
            result.m15 = lhs.m15 * rhs;
            result.m16 = lhs.m16 * rhs;

            return result;
        }

        // Scalar Multiplication --> M = f * M
        public static Matrix4 operator *(float lhs, Matrix4 rhs)
        {
            Matrix4 result = new Matrix4();

            result.m1  = lhs * rhs.m1;
            result.m2  = lhs * rhs.m2;
            result.m3  = lhs * rhs.m3;
            result.m4  = lhs * rhs.m4;
            result.m5  = lhs * rhs.m5;
            result.m6  = lhs * rhs.m6;
            result.m7  = lhs * rhs.m7;
            result.m8  = lhs * rhs.m8;
            result.m9  = lhs * rhs.m9;
            result.m10 = lhs * rhs.m10;
            result.m11 = lhs * rhs.m11;
            result.m12 = lhs * rhs.m12;
            result.m13 = lhs * rhs.m13;
            result.m14 = lhs * rhs.m14;
            result.m15 = lhs * rhs.m15;
            result.m16 = lhs * rhs.m16;

            return result;
        }

        // Vector Transformation --> V = M * V
        public static Vector4 operator* (Matrix4 lhs, Vector4 rhs)
        {
            Vector4 result = new Vector4();

            result.x = (lhs.m1 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m9  * rhs.z) + (lhs.m13 * rhs.w);
            result.y = (lhs.m2 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m10 * rhs.z) + (lhs.m14 * rhs.w);
            result.z = (lhs.m3 * rhs.x) + (lhs.m7 * rhs.y) + (lhs.m11 * rhs.z) + (lhs.m15 * rhs.w);
            result.w = (lhs.m4 * rhs.x) + (lhs.m8 * rhs.y) + (lhs.m12 * rhs.z) + (lhs.m16 * rhs.w);

            return result;
        }

        // Matrix Transformation --> M = M * M
        public static Matrix4 operator* (Matrix4 lhs, Matrix4 rhs)
        {
            Matrix4 result = new Matrix4();

            result.m1  = (lhs.m1 * rhs.m1)  + (lhs.m5 * rhs.m2)  + (lhs.m9  * rhs.m3)  + (lhs.m13 * rhs.m4);
            result.m2  = (lhs.m2 * rhs.m1)  + (lhs.m6 * rhs.m2)  + (lhs.m10 * rhs.m3)  + (lhs.m14 * rhs.m4);
            result.m3  = (lhs.m3 * rhs.m1)  + (lhs.m7 * rhs.m2)  + (lhs.m11 * rhs.m3)  + (lhs.m15 * rhs.m4);
            result.m4  = (lhs.m4 * rhs.m1)  + (lhs.m8 * rhs.m2)  + (lhs.m12 * rhs.m3)  + (lhs.m16 * rhs.m4);
            result.m5  = (lhs.m1 * rhs.m5)  + (lhs.m5 * rhs.m6)  + (lhs.m9  * rhs.m7)  + (lhs.m13 * rhs.m8);
            result.m6  = (lhs.m2 * rhs.m5)  + (lhs.m6 * rhs.m6)  + (lhs.m10 * rhs.m7)  + (lhs.m14 * rhs.m8);
            result.m7  = (lhs.m3 * rhs.m5)  + (lhs.m7 * rhs.m6)  + (lhs.m11 * rhs.m7)  + (lhs.m15 * rhs.m8);
            result.m8  = (lhs.m4 * rhs.m5)  + (lhs.m8 * rhs.m6)  + (lhs.m12 * rhs.m7)  + (lhs.m16 * rhs.m8);
            result.m9  = (lhs.m1 * rhs.m9)  + (lhs.m5 * rhs.m10) + (lhs.m9  * rhs.m11) + (lhs.m13 * rhs.m12);
            result.m10 = (lhs.m2 * rhs.m9)  + (lhs.m6 * rhs.m10) + (lhs.m10 * rhs.m11) + (lhs.m14 * rhs.m12);
            result.m11 = (lhs.m3 * rhs.m9)  + (lhs.m7 * rhs.m10) + (lhs.m11 * rhs.m11) + (lhs.m15 * rhs.m12);
            result.m12 = (lhs.m4 * rhs.m9)  + (lhs.m8 * rhs.m10) + (lhs.m12 * rhs.m11) + (lhs.m16 * rhs.m12);
            result.m13 = (lhs.m1 * rhs.m13) + (lhs.m5 * rhs.m14) + (lhs.m9  * rhs.m15) + (lhs.m13 * rhs.m16);
            result.m14 = (lhs.m2 * rhs.m13) + (lhs.m6 * rhs.m14) + (lhs.m10 * rhs.m15) + (lhs.m14 * rhs.m16);
            result.m15 = (lhs.m3 * rhs.m13) + (lhs.m7 * rhs.m14) + (lhs.m11 * rhs.m15) + (lhs.m15 * rhs.m16);
            result.m16 = (lhs.m4 * rhs.m13) + (lhs.m8 * rhs.m14) + (lhs.m12 * rhs.m15) + (lhs.m16 * rhs.m16);

            return result;
        }

        // setRotateX(f) - set the X-axis rotation of the matrix
        public void SetRotateX(float xRot)
        {
            m1 = 1;
            m2 = 0;
            m3 = 0;
            m4 = 0;
            m5 = 0;
            m6 = (float)Math.Cos(xRot);
            m7 = (float)Math.Sin(xRot);
            m8 = 0;
            m9 = 0;
            m10= -(float)Math.Sin(xRot);
            m11= (float)Math.Cos(xRot);
            m12= 0;
            m13= 0;
            m14= 0;
            m15= 0;
            m16= 1;
        }

        // setRotateY(f) - set the Y-axis rotation of the matrix
        public void SetRotateY(float yRot)
        {
            m1 = (float)Math.Cos(yRot);
            m2 = 0;
            m3 = -(float)Math.Sin(yRot);
            m4 = 0;
            m5 = 0;
            m6 = 1;
            m7 = 0;
            m8 = 0;
            m9 = (float)Math.Sin(yRot);
            m10= 0;
            m11= (float)Math.Cos(yRot);
            m12= 0;
            m13= 0;
            m14= 0;
            m15= 0;
            m16= 1;
        }

        // setRotateZ(f) - set the Z-axis rotation of the matrix
        public void SetRotateZ(float zRot)
        {
            m1 = (float)Math.Cos(zRot);
            m2 = (float)Math.Sin(zRot);
            m3 = 0;
            m4 = 0;
            m5 = -(float)Math.Sin(zRot);
            m6 = (float)Math.Cos(zRot);
            m7 = 0;
            m8 = 0;
            m9 = 0;
            m10= 0;
            m11= 1;
            m12= 0;
            m13= 0;
            m14= 0;
            m15= 0;
            m16= 1;
        }

        // SetEuler --> Set rotation simultaneously using three floats
        public void SetEuler(float pitch, float yaw, float roll)
        {
            Matrix4 x = new Matrix4();
            Matrix4 y = new Matrix4();
            Matrix4 z = new Matrix4();

            x.SetRotateX(pitch);
            y.SetRotateY(yaw);
            z.SetRotateZ(roll);

            Matrix4 result = z * y * x;

            m1 = result.m1;
            m2 = result.m2;
            m3 = result.m3;
            m5 = result.m5;
            m6 = result.m6;
            m7 = result.m7;
            m9 = result.m9;
            m10= result.m10;
            m11= result.m11;
        }

        // SetEuler --> Set rotation simultaneously using Vector3
        public void SetEuler(Vector3 rotation)
        {
            Matrix4 x = new Matrix4();
            Matrix4 y = new Matrix4();
            Matrix4 z = new Matrix4();

            x.SetRotateX(rotation.x);
            y.SetRotateY(rotation.y);
            z.SetRotateZ(rotation.z);

            Matrix4 result = z * y * x;

            m1 = result.m1;
            m2 = result.m2;
            m3 = result.m3;
            m5 = result.m5;
            m6 = result.m6;
            m7 = result.m7;
            m9 = result.m9;
            m10 = result.m10;
            m11 = result.m11;
        }

        // Set Translation Using Three Floats
        public void SetTranslation(float x, float y, float z)
        {
            m4 = x;
            m8 = y;
            m12 = z;
        }

        // Set Translation Using Vector3
        public void SetTranslation(Vector3 pos)
        {
            m4 = pos.x;
            m8 = pos.y;
            m12 = pos.z;
        }

        // Set Scale Using Three Floats
        public void SetScale(float x, float y, float z)
        {
            m1 = x;
            m6 = y;
            m11 = z;
        }

        // Set Scale Using Vector3
        public void SetScale(Vector3 scale)
        {
            m1 = scale.x;
            m6 = scale.y;
            m11 = scale.z;
        }
    }
}
