﻿using System;
using GDAPI.Enumerations.GeometryDash;
using static GDAPI.Information.GeometryDash.LevelLengths;

namespace GDAPI.Functions.GeometryDash
{
    /// <summary>Provides functions to convert values based on level lengths.</summary>
    public static class EnumConverters
    {
        #region LevelLength
        /// <summary>Returns the <seealso cref="LevelLength"/> of a level from the seconds.</summary>
        /// <param name="seconds">The seconds of the length of the level to get the <seealso cref="LevelLength"/> value of.</param>
        public static LevelLength GetLevelLength(double seconds)
        {
            if (seconds >= MinXLLength)
                return LevelLength.XL;
            if (seconds >= MinLongLength)
                return LevelLength.Long;
            if (seconds >= MinMediumLength)
                return LevelLength.Medium;
            if (seconds >= MinSmallLength)
                return LevelLength.Small;
            return LevelLength.Tiny;
        }
        /// <summary>Returns the respective time length range, given a <seealso cref="LevelLength"/>.</summary>
        /// <param name="length">The <seealso cref="LevelLength"/> whose respective time length range to return.</param>
        public static Range<double> GetLevelLengthRange(LevelLength length)
        {
            switch (length)
            {
                case LevelLength.XL:
                    return XLLengthRange;
                case LevelLength.Long:
                    return LongLengthRange;
                case LevelLength.Medium:
                    return MediumLengthRange;
                case LevelLength.Small:
                    return SmallLengthRange;
                case LevelLength.Tiny:
                default:
                    return TinyLengthRange;
            }
        }
        #endregion

        #region LevelDifficulty
        /// <summary>Returns the <seealso cref="LevelDifficulty"/> of a level from the specified star rating.</summary>
        /// <param name="stars">The star rating of the level to get the <seealso cref="LevelDifficulty"/> value of.</param>
        public static LevelDifficulty GetLevelDifficulty(int stars)
        {
            switch (stars)
            {
                case 0:
                default:
                    return LevelDifficulty.NA;
                case 1:
                    return LevelDifficulty.Auto;
                case 2:
                    return LevelDifficulty.Easy;
                case 3:
                    return LevelDifficulty.Normal;
                case 4:
                case 5:
                    return LevelDifficulty.Hard;
                case 6:
                case 7:
                    return LevelDifficulty.Harder;
                case 8:
                case 9:
                    return LevelDifficulty.Insane;
                case 10:
                    return LevelDifficulty.Demon;
            }
        }
        #endregion
    }
}
