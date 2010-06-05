using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DersDemo_Win_CopyFile
{
    /// <summary>
    /// Common Operations
    /// </summary>
    public static class CO
    {
        private static readonly string[]
            _sizes = { "B", "KB", "MB", "GB", "TB", "PB" };
        public static string GetSizeString(long l)
        {
            double d = l;
            for (int i = 0; i < _sizes.Length; i++)
            {
                if (d < 1024)
                {
                    return string.Format("{0:N2}{1}", d, _sizes[i]);
                }
                d /= 1024;

            }
            return string.Format("{0:N2}{1}", d, _sizes[_sizes.Length - 1]);
        }
    }
}
