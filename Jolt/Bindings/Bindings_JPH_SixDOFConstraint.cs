using Unity.Mathematics;

namespace Jolt
{
    internal static unsafe partial class Bindings
    {
        public static NativeHandle<JPH_SixDOFConstraint> JPH_SixDOFConstraint_Create(ref SixDOFConstraintSettings settings, NativeHandle<JPH_Body> body1, NativeHandle<JPH_Body> body2)
        {
            AssertInitialized();

            fixed (SixDOFConstraintSettings* ptr = &settings)
            {
                return CreateHandle(UnsafeBindings.JPH_SixDOFConstraint_Create((JPH_SixDOFConstraintSettings*)ptr, body1, body2));
            }
        }

        public static SixDOFConstraintSettings JPH_SixDOFConstraint_GetSettings(NativeHandle<JPH_SixDOFConstraint> constraint)
        {
            AssertInitialized();

            SixDOFConstraintSettings result;
            UnsafeBindings.JPH_SixDOFConstraint_GetSettings(constraint, (JPH_SixDOFConstraintSettings*)&result);
            return result;
        }

        public static float JPH_SixDOFConstraint_GetLimitsMin(NativeHandle<JPH_SixDOFConstraint> constraint, SixDOFConstraintAxis axis)
        {
            AssertInitialized();

            return UnsafeBindings.JPH_SixDOFConstraint_GetLimitsMin(constraint, axis);
        }

        public static float JPH_SixDOFConstraint_GetLimitsMax(NativeHandle<JPH_SixDOFConstraint> constraint, SixDOFConstraintAxis axis)
        {
            AssertInitialized();

            return UnsafeBindings.JPH_SixDOFConstraint_GetLimitsMax(constraint, axis);
        }

        public static float3 JPH_SixDOFConstraint_GetTotalLambdaPosition(NativeHandle<JPH_SixDOFConstraint> constraint)
        {
            AssertInitialized();

            float3 result;
            UnsafeBindings.JPH_SixDOFConstraint_GetTotalLambdaPosition(constraint, &result);
            return result;
        }

        public static float3 JPH_SixDOFConstraint_GetTotalLambdaRotation(NativeHandle<JPH_SixDOFConstraint> constraint)
        {
            AssertInitialized();

            float3 result;
            UnsafeBindings.JPH_SixDOFConstraint_GetTotalLambdaRotation(constraint, &result);
            return result;
        }

        public static float3 JPH_SixDOFConstraint_GetTotalLambdaMotorTranslation(NativeHandle<JPH_SixDOFConstraint> constraint)
        {
            AssertInitialized();

            float3 result;
            UnsafeBindings.JPH_SixDOFConstraint_GetTotalLambdaMotorTranslation(constraint, &result);
            return result;
        }

        public static float3 JPH_SixDOFConstraint_GetTotalLambdaMotorRotation(NativeHandle<JPH_SixDOFConstraint> constraint)
        {
            AssertInitialized();

            float3 result;
            UnsafeBindings.JPH_SixDOFConstraint_GetTotalLambdaMotorRotation(constraint, &result);
            return result;
        }

         public static void JPH_SixDOFConstraintSettings_MakeFixedAxis(ref SixDOFConstraintSettings settings, SixDOFConstraintAxis axis)
        {
            AssertInitialized();

            fixed (SixDOFConstraintSettings* ptr = &settings)
            {
               UnsafeBindings.JPH_SixDOFConstraintSettings_MakeFixedAxis((JPH_SixDOFConstraintSettings*)ptr, axis);
            }
            
        }

        public static void JPH_SixDOFConstraintSettings_SetLimitedAxis(ref SixDOFConstraintSettings settings, SixDOFConstraintAxis axis, float min, float max)
        {
            AssertInitialized();

            fixed (SixDOFConstraintSettings* ptr = &settings)
            {
                UnsafeBindings.JPH_SixDOFConstraintSettings_SetLimitedAxis((JPH_SixDOFConstraintSettings*)ptr, axis, min, max);
            }

        }

        public static void JPH_SixDOFConstraintSettings_MakeFreeAxis(ref SixDOFConstraintSettings settings, SixDOFConstraintAxis axis)
        {
            AssertInitialized();

            fixed (SixDOFConstraintSettings* ptr = &settings)
            {
                UnsafeBindings.JPH_SixDOFConstraintSettings_MakeFreeAxis((JPH_SixDOFConstraintSettings*)ptr, axis);
            }

        }

        public static void JPH_SixDOFConstraint_SetTargetPositionCS(NativeHandle<JPH_SixDOFConstraint> constraint, float3 position)
        {
            AssertInitialized();

            UnsafeBindings.JPH_SixDOFConstraint_SetTargetPositionCS(constraint, &position);
        }

        public static float3 JPH_SixDOFConstraint_GetTargetPositionCS(NativeHandle<JPH_SixDOFConstraint> constraint)
        {
            AssertInitialized();

            float3 result;
            UnsafeBindings.JPH_SixDOFConstraint_GetTargetPositionCS(constraint, &result);
            return result;
        }

        public static void JPH_SixDOFConstraint_SetTargetOrientationCS(NativeHandle<JPH_SixDOFConstraint> constraint, quaternion orientation)
        {
            AssertInitialized();

            UnsafeBindings.JPH_SixDOFConstraint_SetTargetOrientationCS(constraint, &orientation);
        }

        public static quaternion JPH_SixDOFConstraint_GetTargetOrientationCS(NativeHandle<JPH_SixDOFConstraint> constraint)
        {
            AssertInitialized();

            quaternion result;
            UnsafeBindings.JPH_SixDOFConstraint_GetTargetOrientationCS(constraint, &result);
            return result;
        }

        public static void JPH_SixDOFConstraint_SetMotorState(NativeHandle<JPH_SixDOFConstraint> constraint, SixDOFConstraintAxis axis, MotorState state)
        {
            AssertInitialized();

            UnsafeBindings.JPH_SixDOFConstraint_SetMotorState(constraint, axis, state);
        }

        public static MotorState JPH_SixDOFConstraint_GetMotorState(NativeHandle<JPH_SixDOFConstraint> constraint, SixDOFConstraintAxis axis)
        {
            AssertInitialized();

            return UnsafeBindings.JPH_SixDOFConstraint_GetMotorState(constraint, axis);
        }
    }
}
