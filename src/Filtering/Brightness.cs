﻿// ===============================================================================
// Contrast.cs
// .NET Image Tools
// ===============================================================================
// Copyright (c) .NET Image Tools Development Group. 
// All rights reserved.
// ===============================================================================

namespace Nine.Imaging.Filtering
{
    /// <summary>
    /// An <see cref="IImageFilter"/> for changing the brightness of an <see cref="Image"/>.
    /// </summary>
    public sealed class Brightness : ParallelImageFilter
    {
        public int Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Brightness"/> class.
        /// </summary>
        /// <param name="brightness">The brightness value. Must be between -255 and 255.</param>
        /// <exception cref="ArgumentException">
        /// 	<para><paramref name="brightness"/> is less than -255.</para>
        /// 	<para>- or -</para>
        /// 	<para><paramref name="brightness"/> is greater than 255.</para>
        /// </exception>
        public Brightness(int brightness)
        {
            Value = brightness;
        }

        protected override void Apply(ImageBase target, ImageBase source, Rectangle rectangle, int startY, int endY)
        {
            for (int y = startY; y < endY; y++)
            {
                for (int x = rectangle.X; x < rectangle.Right; x++)
                {
                    Color color = source[x, y];

                    int r = color.R + Value;
                    int g = color.G + Value;
                    int b = color.B + Value;

                    r = r.RemainBetween(0, 255);
                    g = g.RemainBetween(0, 255);
                    b = b.RemainBetween(0, 255);

                    color.R = (byte)r;
                    color.G = (byte)g;
                    color.B = (byte)b;

                    target[x, y] = color;
                }
            }
        }
    }
}
