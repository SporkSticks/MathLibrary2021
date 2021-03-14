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