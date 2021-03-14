using System;
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


        // Matrix Transformation --> M = M * M


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
