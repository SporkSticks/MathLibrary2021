using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Colour
    {
        public uint colour;

        // Default Constructor
        public Colour()
        {
            colour = 0x_0000_0000;
        }

        // Overloaded Constructor
        public Colour(byte r = 0, byte g = 0, byte b = 0, byte alpha = 0)
        {
            uint rValue = (uint)r << 24;
            uint gValue = (uint)g << 16;
            uint bValue = (uint)b << 8;

            colour |= rValue;
            colour |= gValue;
            colour |= bValue;
            colour |= alpha;
        }

        // Get the byte value of the red component
        public byte GetRed()
        {
            colour &= 0x_ff00_0000;
            return (byte)(colour >> 24);
        }

        // Set the byte value of the red component
        public void SetRed(byte red)
        {
            colour &= 0x_00ff_ffff;
            colour |= (uint)red << 24;
        }

        // Get the byte value of the green component
        public byte GetGreen()
        {
            colour &= 0x_00ff_0000;
            return (byte)(colour >> 16);
        }

        // Set the byte value of the green component
        public void SetGreen(byte green)
        {
            colour &= 0x_ff00_ffff;
            colour |= (uint)green << 16;
        }

        // Get the byte value of the blue component
        public byte GetBlue()
        {
            colour &= 0x_0000_ff00;
            return (byte)(colour >> 8);
        }

        // Set the byte value of the blue component
        public void SetBlue(byte blue)
        {
            colour &= 0x_ffff_00ff;
            colour |= (uint)blue << 8;
        }

        // Get the byte value of the alpha channel
        public byte GetAlpha()
        {
            colour &= 0x_0000_00ff;
            return (byte)colour;
        }

        // Set the byte value of the alpha channel
        public void SetAlpha(byte alpha)
        {
            colour &= 0x_ffff_ff00;
            colour |= (uint)alpha;
        }
    }
}
