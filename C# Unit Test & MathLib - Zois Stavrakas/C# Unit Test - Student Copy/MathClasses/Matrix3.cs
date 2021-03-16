﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix3
    {
        // Initialise the 9 entries in the matrix
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

        // Scalar Multiplication --> M = M * f
        public static Matrix3 operator* (Matrix3 lhs, float rhs)
        {
            Matrix3 result = new Matrix3();

            result.m1 = lhs.m1 * rhs;
            result.m2 = lhs.m2 * rhs;
            result.m3 = lhs.m3 * rhs;
            result.m4 = lhs.m4 * rhs;
            result.m5 = lhs.m5 * rhs;
            result.m6 = lhs.m6 * rhs;
            result.m7 = lhs.m7 * rhs;
            result.m8 = lhs.m8 * rhs;
            result.m9 = lhs.m9 * rhs;

            return result;
        }

        // Scalar Multiplication --> M = f * M
        public static Matrix3 operator* (float lhs, Matrix3 rhs)
        {
            Matrix3 result = new Matrix3();

            result.m1 = lhs * rhs.m1;
            result.m2 = lhs * rhs.m2;
            result.m3 = lhs * rhs.m3;
            result.m4 = lhs * rhs.m4;
            result.m5 = lhs * rhs.m5;
            result.m6 = lhs * rhs.m6;
            result.m7 = lhs * rhs.m7;
            result.m8 = lhs * rhs.m8;
            result.m9 = lhs * rhs.m9;

            return result;
        }


        // Vector Transformation --> V = M * V
        public static Vector3 operator* (Matrix3 lhs, Vector3 rhs)
        {
            Vector3 result = new Vector3();

            result.x = (lhs.m1 * rhs.x) + (lhs.m4 * rhs.y) + (lhs.m7 * rhs.z);
            result.y = (lhs.m2 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m8 * rhs.z);
            result.z = (lhs.m3 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m9 * rhs.z);

            return result;
        }

        // Matrix Transformation --> M = M * M
        public static Matrix3 operator* (Matrix3 lhs, Matrix3 rhs)
        {
            Matrix3 result = new Matrix3();

            result.m1 = (lhs.m1 * rhs.m1) + (lhs.m4 * rhs.m2) + (lhs.m7 * rhs.m3);
            result.m2 = (lhs.m2 * rhs.m1) + (lhs.m5 * rhs.m2) + (lhs.m8 * rhs.m3);
            result.m3 = (lhs.m3 * rhs.m1) + (lhs.m6 * rhs.m2) + (lhs.m9 * rhs.m3);
            result.m4 = (lhs.m1 * rhs.m4) + (lhs.m4 * rhs.m5) + (lhs.m7 * rhs.m6);
            result.m5 = (lhs.m2 * rhs.m4) + (lhs.m5 * rhs.m5) + (lhs.m8 * rhs.m6);
            result.m6 = (lhs.m3 * rhs.m4) + (lhs.m6 * rhs.m5) + (lhs.m9 * rhs.m6);
            result.m7 = (lhs.m1 * rhs.m7) + (lhs.m4 * rhs.m8) + (lhs.m7 * rhs.m9);
            result.m8 = (lhs.m2 * rhs.m7) + (lhs.m5 * rhs.m8) + (lhs.m8 * rhs.m9);
            result.m9 = (lhs.m3 * rhs.m7) + (lhs.m6 * rhs.m8) + (lhs.m9 * rhs.m9);

            return result;
        }

        // setRotateX(f) - set the X-axis rotation of the matrix
        public void SetRotateX(float xRot)
        {
            m1 = 1;
            m2 = 0;
            m3 = 0;
            m4 = 0;
            m5 = (float)Math.Cos(xRot);
            m6 = (float)Math.Sin(xRot);
            m7 = 0;
            m8 = -(float)Math.Sin(xRot);
            m9 = (float)Math.Cos(xRot);
        }

        // setRotateY(f) - set the Y-axis rotation of the matrix
        public void SetRotateY(float yRot)
        {
            m1 = (float)Math.Cos(yRot);
            m2 = 0;
            m3 = -(float)Math.Sin(yRot);
            m4 = 0;
            m5 = 1;
            m6 = 0;
            m7 = (float)Math.Sin(yRot);
            m8 = 0;
            m9 = (float)Math.Cos(yRot);
        }

        // setRotateZ(f) - set the Z-axis rotation of the matrix
        public void SetRotateZ(float zRot)
        {
            m1 = (float)Math.Cos(zRot);
            m2 = (float)Math.Sin(zRot);
            m3 = 0;
            m4 = -(float)Math.Sin(zRot);
            m5 = (float)Math.Cos(zRot);
            m6 = 0;
            m7 = 0;
            m8 = 0;
            m9 = 1;
        }

        // SetEuler --> Set rotation simultaneously using three floats
        public void SetEuler(float xRot, float yRot)
        {
            Matrix3 x = new Matrix3();
            Matrix3 y = new Matrix3();

            x.SetRotateX(xRot);
            y.SetRotateY(yRot);

            Matrix3 result = y * x;

            m1 = result.m1;
            m2 = result.m2;
            m4 = result.m4;
            m5 = result.m5;
        }

        // SetEuler --> Set rotation simultaneously using Vector3
        public void SetEuler(Vector2 rotation)
        {
            Matrix3 x = new Matrix3();
            Matrix3 y = new Matrix3();

            x.SetRotateX(rotation.x);
            y.SetRotateY(rotation.y);

            Matrix3 result = y * x;

            m1 = result.m1;
            m2 = result.m2;
            m4 = result.m4;
            m5 = result.m5;
        }

        // Set Translation Using Two Floats
        public void SetTranslation(float x, float y)
        {
            m3 = x;
            m6 = y;
        }

        // Set Translation Using Vector2
        public void SetTranslation(Vector2 pos)
        {
            m3 = pos.x;
            m6 = pos.y;
        }

        // Set Scale Using Two Floats
        public void SetScale(float x, float y)
        {
            m1 = x;
            m5 = y;
        }

        // Set Scale Using Vector2
        public void SetScale(Vector2 scale)
        {
            m1 = scale.x;
            m5 = scale.y;
        }

        // Invert the Matrix
        public void Invert()
        {
            float detA = 1 / ((m1 * m5 * m9) + (m2 * m6 * m7) + (m3 * m4 * m8) + (m3 * m5 * m7) + (m2 * m4 * m9) + (m1 * m6 * m8));

            // if the deteminant is zero, the 3x3 matrix has no inverse and it is singular
            if (detA == 0)
                return;

            Matrix3 adjugate = new Matrix3();
            adjugate.m1 = +((m5 * m9) - (m6 * m8));
            adjugate.m2 = -((m2 * m9) - (m3 * m8));
            adjugate.m3 = +((m2 * m6) - (m3 * m5));
            adjugate.m4 = -((m4 * m9) - (m6 * m7));
            adjugate.m5 = +((m1 * m9) - (m3 * m7));
            adjugate.m6 = -((m1 * m6) - (m3 * m4));
            adjugate.m7 = +((m4 * m8) - (m5 * m7));
            adjugate.m8 = -((m1 * m8) - (m2 * m7));
            adjugate.m9 = +((m1 * m5) - (m2 * m4));

            Matrix3 inverse = detA * adjugate;
            m1 = inverse.m1;
            m2 = inverse.m2;
            m3 = inverse.m3;
            m4 = inverse.m4;
            m5 = inverse.m5;
            m6 = inverse.m6;
            m7 = inverse.m7;
            m8 = inverse.m8;
            m9 = inverse.m9;
        }
    }
}