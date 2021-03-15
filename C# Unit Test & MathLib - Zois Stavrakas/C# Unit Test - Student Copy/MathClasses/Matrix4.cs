﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix4
    {
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

        // Vector Transformation --> V = M * V
        public static Vector4 operator* (Matrix4 lhs, Vector4 rhs)
        {
            Vector4 result = new Vector4();

            result.x = (lhs.m1  * rhs.x) + (lhs.m2  * rhs.y) + (lhs.m3  * rhs.z) + (lhs.m4  * rhs.w);
            result.y = (lhs.m5  * rhs.x) + (lhs.m6  * rhs.y) + (lhs.m7  * rhs.z) + (lhs.m8  * rhs.w);
            result.z = (lhs.m9  * rhs.x) + (lhs.m10 * rhs.y) + (lhs.m11 * rhs.z) + (lhs.m12 * rhs.w);
            result.w = (lhs.m13 * rhs.x) + (lhs.m14 * rhs.y) + (lhs.m15 * rhs.z) + (lhs.m16 * rhs.w);

            return result;
        }

        // Matrix Transformation --> M = M * M
        public static Matrix4 operator* (Matrix4 lhs, Matrix4 rhs)
        {
            Matrix4 result = new Matrix4();

            result.m1  = (lhs.m1  * rhs.m1) + (lhs.m2  * rhs.m5) + (lhs.m3  * rhs.m9)  + (lhs.m4  * rhs.m13);
            result.m2  = (lhs.m1  * rhs.m2) + (lhs.m2  * rhs.m6) + (lhs.m3  * rhs.m10) + (lhs.m4  * rhs.m14);
            result.m3  = (lhs.m1  * rhs.m3) + (lhs.m2  * rhs.m7) + (lhs.m3  * rhs.m11) + (lhs.m4  * rhs.m15);
            result.m4  = (lhs.m1  * rhs.m4) + (lhs.m2  * rhs.m8) + (lhs.m3  * rhs.m12) + (lhs.m4  * rhs.m16);
            result.m5  = (lhs.m5  * rhs.m1) + (lhs.m6  * rhs.m5) + (lhs.m7  * rhs.m9)  + (lhs.m8  * rhs.m13);
            result.m6  = (lhs.m5  * rhs.m2) + (lhs.m6  * rhs.m6) + (lhs.m7  * rhs.m10) + (lhs.m8  * rhs.m14);
            result.m7  = (lhs.m5  * rhs.m3) + (lhs.m6  * rhs.m7) + (lhs.m7  * rhs.m11) + (lhs.m8  * rhs.m15);
            result.m8  = (lhs.m5  * rhs.m4) + (lhs.m6  * rhs.m8) + (lhs.m7  * rhs.m12) + (lhs.m8  * rhs.m16);
            result.m9  = (lhs.m9  * rhs.m1) + (lhs.m10 * rhs.m5) + (lhs.m11 * rhs.m9)  + (lhs.m12 * rhs.m13);
            result.m10 = (lhs.m9  * rhs.m2) + (lhs.m10 * rhs.m6) + (lhs.m11 * rhs.m10) + (lhs.m12 * rhs.m14);
            result.m11 = (lhs.m9  * rhs.m3) + (lhs.m10 * rhs.m7) + (lhs.m11 * rhs.m11) + (lhs.m12 * rhs.m15);
            result.m12 = (lhs.m9  * rhs.m4) + (lhs.m10 * rhs.m8) + (lhs.m11 * rhs.m12) + (lhs.m12 * rhs.m16);
            result.m13 = (lhs.m13 * rhs.m1) + (lhs.m14 * rhs.m5) + (lhs.m15 * rhs.m9)  + (lhs.m16 * rhs.m13);
            result.m14 = (lhs.m13 * rhs.m2) + (lhs.m14 * rhs.m6) + (lhs.m15 * rhs.m10) + (lhs.m16 * rhs.m14);
            result.m15 = (lhs.m13 * rhs.m3) + (lhs.m14 * rhs.m7) + (lhs.m15 * rhs.m11) + (lhs.m16 * rhs.m15);
            result.m16 = (lhs.m13 * rhs.m4) + (lhs.m14 * rhs.m8) + (lhs.m15 * rhs.m12) + (lhs.m16 * rhs.m16);

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

        // SetEuler(f pitch, f yaw, f roll) - set the pitch yaw and roll rotations in a single function

    }
}
