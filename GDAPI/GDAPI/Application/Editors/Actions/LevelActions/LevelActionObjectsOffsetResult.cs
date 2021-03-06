﻿using GDAPI.Application.Editors.Delegates;
using System;
using GDAPI.Objects.GeometryDash.LevelObjects;

namespace GDAPI.Application.Editors.Actions.LevelActions
{
    /// <summary>Represents an action in the editor affecting the level which can be undone and redone containing a collection of affected objects whose properties are adjusted with an offset, along with the resulting value after the action being performed.</summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public abstract class LevelActionObjectsOffsetResult<TValue> : LevelActionObjectsOffset<TValue>
    {
        /// <summary>Represents the resulting value after the action is performed.</summary>
        public TValue ResultingValue { get; }

        /// <summary>Initiailizes a new instance of the <seealso cref="LevelActionObjectsOffsetResult{TActionDelegate}"/> class.</summary>
        /// <param name="affectedObjects">The objects that this action will affect.</param>
        /// <param name="offset">The offset to apply to the specified property of the affected objects.</param>
        /// <param name="resultingValue">The resulting value of the specified property after performing the action.</param>
        /// <param name="action">The action to be performed.</param>
        public LevelActionObjectsOffsetResult(LevelObjectCollection affectedObjects, TValue offset, TValue resultingValue, ObjectPropertyOffsetSetter<TValue> action)
            : base(affectedObjects, offset, action)
        {
            ResultingValue = resultingValue;
        }
    }
}
