﻿using System;
using Jolt;
using Unity.Collections;
using Unity.Mathematics;

namespace Jolt
{
    public partial struct TaperedCapsuleShapeSettings : IEquatable<TaperedCapsuleShapeSettings>
    {
        #region IEquatable
        
        public bool Equals(TaperedCapsuleShapeSettings other) => Handle.Equals(other.Handle);
        
        public override bool Equals(object obj) => obj is TaperedCapsuleShapeSettings other && Equals(other);
        
        public override int GetHashCode() => Handle.GetHashCode();
        
        public static bool operator ==(TaperedCapsuleShapeSettings lhs, TaperedCapsuleShapeSettings rhs) => lhs.Equals(rhs);
        
        public static bool operator !=(TaperedCapsuleShapeSettings lhs, TaperedCapsuleShapeSettings rhs) => !lhs.Equals(rhs);
        
        #endregion
        
        #region JPH_TaperedCapsuleShapeSettings
        
        public TaperedCapsuleShape CreateShape() => new TaperedCapsuleShape { Handle = Bindings.JPH_TaperedCapsuleShapeSettings_CreateShape(Handle) };
        
        #endregion
        
        #region JPH_ConvexShapeSettings
        
        public float GetDensity() => Bindings.JPH_ConvexShapeSettings_GetDensity(Handle.Reinterpret<JPH_ConvexShapeSettings>());
        
        public void SetDensity(float density) => Bindings.JPH_ConvexShapeSettings_SetDensity(Handle.Reinterpret<JPH_ConvexShapeSettings>(), density);
        
        #endregion
        
        #region JPH_ShapeSettings
        
        public void Destroy() => Bindings.JPH_ShapeSettings_Destroy(Handle.Reinterpret<JPH_ShapeSettings>());
        
        public ulong GetUserData() => Bindings.JPH_ShapeSettings_GetUserData(Handle.Reinterpret<JPH_ShapeSettings>());
        
        public void SetUserData(ulong data) => Bindings.JPH_ShapeSettings_SetUserData(Handle.Reinterpret<JPH_ShapeSettings>(), data);
        
        #endregion
        
    }
}
