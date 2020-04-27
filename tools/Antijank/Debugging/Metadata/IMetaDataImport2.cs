using System;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace Antijank.Debugging {

  
  [ComImport, Guid("FCE5EFA0-8BBA-4f8e-A036-8F2022B08466"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IMetaDataImport2 {

    void CloseEnum(IntPtr hEnum);

    uint CountEnum(IntPtr hEnum, out uint count);

    uint ResetEnum(IntPtr hEnum, uint ulPos);

    uint EnumTypeDefs(ref IntPtr phEnum, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
      uint[] rTypeDefs, uint cMax, out uint pcTypeDefs);

    uint EnumInterfaceImpls(ref IntPtr phEnum, uint td, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      uint[] rImpls, uint cMax, out uint pcImpls);

    uint EnumTypeRefs(ref IntPtr phEnum, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
      uint[] rTypeDefs, uint cMax, out uint pcTypeRefs);

    uint FindTypeDefByName([MarshalAs(UnmanagedType.LPWStr)] string szTypeDef, uint tkEnclosingClass, out uint ptd);

    uint GetScopeProps([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
      char[] szName, uint cchName, out uint pchName, ref Guid pmvid);

    uint GetModuleFromScope(out uint pmd);

    uint GetTypeDefProps(uint td, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
      char[] szTypeDef, uint cchTypeDef, out uint pchTypeDef, out uint pdwTypeDefFlags, out uint ptkExtends);

    uint GetInterfaceImplProps(uint iiImpl, out uint pClass, out uint ptkIface);

    uint GetTypeRefProps(uint tr, out uint ptkResolutionScope, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      char[] szName, uint cchName, out uint pchName);

    uint ResolveTypeRef(uint tr, ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppIScope, out uint ptd);

    uint EnumMembers(ref IntPtr phEnum, uint cl, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      uint[] rMembers, uint cMax, out uint pcTokens);

    uint EnumMembersWithName(ref IntPtr phEnum, uint cl, [MarshalAs(UnmanagedType.LPWStr)] string szName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)]
      uint[] rMembers, uint cMax, out uint pcTokens);

    uint EnumMethods(ref IntPtr phEnum, uint cl, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      uint[] rMethods, uint cMax, out uint pcTokens);

    uint EnumMethodsWithName(ref IntPtr phEnum, uint cl, [MarshalAs(UnmanagedType.LPWStr)] string szName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)]
      uint[] rMethods, uint cMax, out uint pcTokens);

    uint EnumFields(ref IntPtr phEnum, uint cl, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      uint[] rFields, uint cMax, out uint pcTokens);

    uint EnumFieldsWithName(ref IntPtr phEnum, uint cl, [MarshalAs(UnmanagedType.LPWStr)] string szName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)]
      uint[] rFields, uint cMax, out uint pcTokens);

    uint EnumParams(ref IntPtr phEnum, uint mb, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      uint[] rParams, uint cMax, out uint pcTokens);

    uint EnumMemberRefs(ref IntPtr phEnum, uint tkParent, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      uint[] rMemberRefs, uint cMax, out uint pcTokens);

    uint EnumMethodImpls(ref IntPtr phEnum, uint td, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)]
      uint[] rMethodBody, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)]
      uint[] rMethodDecl, uint cMax, out uint pcTokens);

    uint EnumPermissionSets(ref IntPtr phEnum, uint tk, uint dwActions, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)]
      uint[] rPermission, uint cMax, out uint pcTokens);

    uint FindMember(uint td, [MarshalAs(UnmanagedType.LPWStr)] string szName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      byte[] pvSigBlob, uint cbSigBlob, out uint pmb);

    uint FindMethod(uint td, [MarshalAs(UnmanagedType.LPWStr)] string szName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      byte[] pvSigBlob, uint cbSigBlob, out uint pmb);

    uint FindField(uint td, [MarshalAs(UnmanagedType.LPWStr)] string szName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      byte[] pvSigBlob, uint cbSigBlob, out uint pmb);

    uint FindMemberRef(uint td, [MarshalAs(UnmanagedType.LPWStr)] string szName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      byte[] pvSigBlob, int cbSigBlob, out uint pmr);

    uint GetMethodProps(uint mb, out uint pClass, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      char[] szMethod, uint cchMethod, out uint pchMethod, out uint pdwAttr, out IntPtr ppvSigBlob, out uint pcbSigBlob, out uint pulCodeRVA, out uint pdwImplFlags);

    uint GetMemberRefProps(uint mr, out uint ptk, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      char[] szMember, uint cchMember, out uint pchMember, out IntPtr ppvSigBlob, out uint pbSigBlob);

    uint EnumProperties(ref IntPtr phEnum, uint td, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      uint[] rProperties, uint cMax, out uint pcProperties);

    uint EnumEvents(ref IntPtr phEnum, uint td, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      uint[] rEvents, uint cMax, out uint pcEvents);

    uint GetEventProps(uint ev, out uint pClass, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      char[] szEvent, uint cchEvent, out uint pchEvent, out uint pdwEventFlags, out uint ptkEventType, out uint pmdAddOn, out uint pmdRemoveOn, out uint pmdFire, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 11)]
      uint[] rmdOtherMethod, uint cMax, out uint pcOtherMethod);

    uint EnumMethodSemantics(ref IntPtr phEnum, uint mb, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      uint[] rEventProp, uint cMax, out uint pcEventProp);

    uint GetMethodSemantics(uint mb, uint tkEventProp, out uint pdwSemanticsFlags);

    uint GetClassLayout(uint td, out uint pdwPackSize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      COR_FIELD_OFFSET[] rFieldOffset, uint cMax, out uint pcFieldOffset, out uint pulClassSize);

    uint GetFieldMarshal(uint tk, out IntPtr ppvNativeType, out uint pcbNativeType);

    uint GetRVA(uint tk, out uint pulCodeRVA, out uint pdwImplFlags);

    uint GetPermissionSetProps(uint pm, out uint pdwAction, out IntPtr ppvPermission, out uint pcbPermission);

    uint GetSigFromToken(uint mdSig, out IntPtr ppvSig, out uint pcbSig);

    uint GetModuleRefProps(uint mur, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
      char[] szName, uint cchName, out uint pchName);

    uint EnumModuleRefs(ref IntPtr phEnum, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
      uint[] rModuleRefs, uint cmax, out uint pcModuleRefs);

    uint GetTypeSpecFromToken(uint typespec, out IntPtr ppvSig, out uint pcbSig);

    uint GetNameFromToken(uint tk, out IntPtr pszUtf8NamePtr);

    uint EnumUnresolvedMethods(ref IntPtr phEnum, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
      uint[] rMethods, uint cMax, out uint pcTokens);

    uint GetUserString(uint stk, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
      char[] szString, uint cchString, out uint pchString);

    uint GetPinvokeMap(uint tk, out uint pdwMappingFlags, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      char[] szImportName, uint cchImportName, out uint pchImportName, out uint pmrImportDLL);

    uint EnumSignatures(ref IntPtr phEnum, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
      uint[] rSignatures, uint cmax, out uint pcSignatures);

    uint EnumTypeSpecs(ref IntPtr phEnum, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
      uint[] rTypeSpecs, uint cmax, out uint pcTypeSpecs);

    uint EnumUserStrings(ref IntPtr phEnum, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)]
      uint[] rStrings, uint cmax, out uint pcStrings);

    uint GetParamForMethodIndex(uint md, uint ulParamSeq, out uint ppd);

    uint EnumCustomAttributes(ref IntPtr phEnum, uint tk, uint tkType, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)]
      uint[] rCustomAttributes, uint cMax, out uint pcCustomAttributes);

    uint GetCustomAttributeProps(uint cv, out uint ptkObj, out uint ptkType, out IntPtr ppBlob, out uint pcbSize);

    uint FindTypeRef(uint tkResolutionScope, [MarshalAs(UnmanagedType.LPWStr)] string szName, out uint ptr);

    uint GetMemberProps(uint mb, out uint pClass, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      char[] szMember, uint cchMember, out uint pchMember, out uint pdwAttr, out IntPtr ppvSigBlob, out uint pcbSigBlob, out uint pulCodeRVA, out uint pdwImplFlags, out uint pdwCPlusTypeFlag, out IntPtr ppValue, out uint pcchValue);

    uint GetFieldProps(uint mb, out uint pClass, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      char[] szField, uint cchField, out uint pchField, out uint pdwAttr, out IntPtr ppvSigBlob, out uint pcbSigBlob, out uint pdwCPlusTypeFlag, out IntPtr ppValue, out uint pcchValue);

    uint GetPropertyProps(uint prop, out uint pClass, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      char[] szProperty, uint cchProperty, out uint pchProperty, out uint pdwPropFlags, out IntPtr ppvSig, out uint pbSig, out uint pdwCPlusTypeFlag, out IntPtr ppDefaultValue, out uint pcchDefaultValue, out uint pmdSetter,
      out uint pmdGetter, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 14)]
      uint[] rmdOtherMethod, uint cMax, out uint pcOtherMethod);

    uint GetParamProps(uint tk, out uint pmd, out uint pulSequence, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)]
      char[] szName, uint cchName, out uint pchName, out uint pdwAttr, out uint pdwCPlusTypeFlag, out IntPtr ppValue, out uint pcchValue);

    uint GetCustomAttributeByName(uint tkObj, [MarshalAs(UnmanagedType.LPWStr)] string szName, out IntPtr ppData, out uint pcbData);

    bool IsValidToken(uint tk);

    uint GetNestedClassProps(uint tdNestedClass, out uint ptdEnclosingClass);

    uint GetNativeCallConvFromSig(IntPtr pvSig, uint cbSig, out uint pCallConv);

    uint IsGlobal(uint pd, out uint pbGlobal);

    int EnumGenericParams(ref IntPtr phEnum, uint tk, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      uint[] rGenericParams, uint cMax, out uint pcGenericParams);

    int GetGenericParamProps(uint gp, out uint pulParamSeq, out uint pdwParamFlags, out uint ptOwner, out uint ptkKind, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)]
      char[] wzname, uint cchName, out uint pchName);

    int GetMethodSpecProps(uint mi, out uint tkParent, out IntPtr ppvSigBlob, out uint pcbSigBlob);

    int EnumGenericParamConstraints(ref IntPtr phEnum, uint tk, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      uint[] rGenericParamConstraints, uint cMax, out uint pcGenericParamConstraints);

    int GetGenericParamConstraintProps(uint gpc, out uint ptGenericParam, out uint ptkConstraintType);

    int GetPEKind(out uint pdwPEKind, out uint pdwMAchine);

    int GetVersionString([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
      char[] pwzBuf, uint ccBufSize, out uint pccBufSize);

    int EnumMethodSpecs(ref IntPtr phEnum, uint tk, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)]
      uint[] rMethodSpecs, uint cMax, out uint pcMethodSpecs);

  }

}