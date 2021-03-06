﻿using System;

namespace Magenic.SharedKernel
{
    /// <summary>
    /// Provides a set of static methods on Guids.
    /// </summary>
    public static class GuidEx
    {
        #region Public Static Methods

        /// <summary>
        /// Determines if guid is empty.
        /// </summary>
        /// <param name="guid">A Guid object.</param>
        /// <returns>True if guid is empty, otherwise False.</returns>
        public static bool IsEmpty(this Guid guid) => (guid == Guid.Empty);

        /// <summary>
        /// Performs ToString and ToUpper on guid.
        /// </summary>
        /// <param name="guid">A Guid object.</param>
        /// <returns>Uppercase string representations of guid.</returns>
        public static string ToUpper(this Guid guid) => guid.ToString().ToUpper();

        /// <summary>
        /// Performs ToString and ToUpper on guid.
        /// </summary>
        /// <param name="guid">A Guid object.</param>
        /// <param name="format">
        /// A single format specifier that indicates how to format the value of this Guid.
        /// The format parameter can be "N", "D", "B", "P", or "X".
        /// If format is null or an empty string (""), "D" is used.</param>
        /// <returns>Uppercase string representations of guid.</returns>
        public static string ToUpper(this Guid guid, string format)
            => guid.ToString(format).ToUpper();

        /// <summary>
        /// Determines if nullable guid is null or empty.
        /// </summary>
        /// <param name="nullableGuid">A Nullable Guid object.</param>
        /// <returns>True if nullable guid is null or its value is empty, otherwise False.</returns>
        public static bool IsNullOrEmpty(Guid? nullableGuid)
            => (nullableGuid == null || nullableGuid.Value.IsEmpty());

        #endregion
    }
}