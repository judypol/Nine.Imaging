﻿// ===============================================================================
// IBarcodeReader.cs
// .NET Image Tools
// ===============================================================================
// Copyright (c) .NET Image Tools Development Group. 
// All rights reserved.
// ===============================================================================

namespace Nine.Imaging.Barcode
{
    /// <summary>
    /// Base interface for all barcode readers.
    /// </summary>
    public interface IBarcodeReader
    {
        /// <summary>
        /// Reads an barcode from the specified image.
        /// </summary>
        /// <param name="image">The image to read the barcode from.</param>
        /// <returns>The result of the reading operation when a barcode could be read or null otherwise.</returns>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="image"/> is null.</exception>
        /// <exception cref="T:System.ArgumentException"><paramref name="image"/> is empty.</exception>
        BarcodeResult ReadBarcode(Image image);
    }
}
