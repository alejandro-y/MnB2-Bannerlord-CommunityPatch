using System;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace Antijank.Debugging {

  
  [SuppressMessage("ReSharper", "InconsistentNaming")]
  public struct COR_SECATTR {

    public uint tkCtor;

    public IntPtr pCustomAttribute;

    public uint cbCustomAttribute;

  }

}