using System;


namespace Antijank.Debugging {

  [Flags]
  
  public enum CorGCReferenceType {

    CorHandleStrong = 1 << 0,

    CorHandleStrongPinning = 1 << 1,

    CorHandleWeakShort = 1 << 2,

    CorHandleWeakLong = 1 << 3,

    CorHandleWeakRefCount = 1 << 4,

    CorHandleStrongRefCount = 1 << 5,

    CorHandleStrongDependent = 1 << 6,

    CorHandleStrongAsyncPinned = 1 << 7,

    CorHandleStrongSizedByref = 1 << 8,

    CorReferenceStack = -2147483647,

    CorReferenceFinalizer = -2147483648,

    // Used for EnumHandles
    CorHandleStrongOnly = 0x1E3,

    CorHandleWeakOnly = 0x1C,

    CorHandleAll = 0x7FFFFFFF

  }

}