using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix3
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;

        // Default Constructor
        public Matrix3()
        {
            m1 = 1; m2 = 0; m3 = 0;
            m4 = 0; m5 = 1; m6 = 0;
            m7 = 0; m8 = 0; m9 = 1;
        }

        // Overloaded Constructor
        public Matrix3(float m1 = 0.0f, float m2 = 0.0f, float m3 = 0.0f,
                       float m4 = 0.0f, float m5 = 0.0f, float m6 = 0.0f,
                       float m7 = 0.0f, float m8 = 0.0f, float m9 = 0.0f)
        {
            this.m1 = m1; this.m2 = m2; this.m3 = m3;
            this.m4 = m4; this.m5 = m5; this.m6 = m6;
            this.m7 = m7; this.m8 = m8; this.m9 = m9;
        }

        // Vector Transformation --> V = M * V
        public static Vector3 operator* (Matrix3 lhs, Vector3 rhs)
        {
            Vector3 result = new Vector3();

            result.x = (lhs.m1 * rhs.x) + (lhs.m2 * rhs.y) + (lhs.m3 * rhs.z);
            result.y = (lhs.m4 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m6 * rhs.z);
            result.z = (lhs.m7 * rhs.x) + (lhs.m8 * rhs.y) + (lhs.m9 * rhs.z);

            return result;
        }

        // Matrix Transformation --> M = M * M
        public static Matrix3 operator* (Matrix3 lhs, Matrix3 rhs)
        {
            Matrix3 result = new Matrix3();

            result.m1 = (lhs.m1 * rhs.m1) + (lhs.m2 * rhs.m4) + (lhs.m3 * rhs.m7);
            result.m2 = (lhs.m1 * rhs.m2) + (lhs.m2 * rhs.m5) + (lhs.m3 * rhs.m8);
            result.m3 = (lhs.m1 * rhs.m3) + (lhs.m2 * rhs.m6) + (lhs.m3 * rhs.m9);
            result.m4 = (lhs.m4 * rhs.m1) + (lhs.m5 * rhs.m4) + (lhs.m6 * rhs.m7);
            result.m5 = (lhs.m4 * rhs.m2) + (lhs.m5 * rhs.m5) + (lhs.m6 * rhs.m8);
            result.m6 = (lhs.m4 * rhs.m3) + (lhs.m5 * rhs.m6) + (lhs.m6 * rhs.m9);
            result.m7 = (lhs.m7 * rhs.m1) + (lhs.m8 * rhs.m4) + (lhs.m9 * rhs.m7);
            result.m8 = (lhs.m7 * rhs.m2) + (lhs.m8 * rhs.m5) + (lhs.m9 * rhs.m8);
            result.m9 = (lhs.m7 * rhs.m3) + (lhs.m8 * rhs.m6) + (lhs.m9 * rhs.m9);

            return result;
        }

        // setRotateX(f)
        public void SetRotateX(float xRot)
        {

        }

        // setRotateY(f)
        public void SetRotateY(float yRot)
        {

        }

        // setRotateZ(f)
        public void SetRotateZ(float zRot)
        {

        }

        // setPositionX(f)
        public void SetPositionX(float xPos)
        {

        }

        // setPositionY(f)
        public void SetPositionY(float yPos)
        {

        }

        // setPositionZ(f)
        public void SetPositionZ(float zPos)
        {

        }

        // setScaleX(f)
        public void SetScaleX(float xScale)
        {

        }

        // setScaleY(f)
        public void SetScaleY(float yScale)
        {

        }

        // setScaleZ(f)
        public void SetScaleZ(float zScale)
        {

        }
    }
}