﻿namespace HSNXT
{
    using System;
    using System.IO;

    public static partial class Extensions
    {
        /// <summary>
        /// Copies all files from one directory to another.
        /// <remarks>
        /// Contributed by Christian Liensberger, 
        /// http://www.liensberger.it/
        /// </remarks>
        /// </summary>
        public static void CopyTo(this DirectoryInfo source, string destination, bool recursive)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            DirectoryInfo target = new DirectoryInfo(destination);
            if (!source.Exists)
            {
                throw new DirectoryNotFoundException("Source directory not found: " + source.FullName);
            }

            if (!target.Exists)
            {
                target.Create();
            }

            foreach (var file in source.GetFiles())
            {
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
            }

            if (!recursive)
            {
                return;
            }

            foreach (var directory in source.GetDirectories())
            {
                CopyTo(directory, Path.Combine(target.FullName, directory.Name), recursive);
            }
        }
    }
}