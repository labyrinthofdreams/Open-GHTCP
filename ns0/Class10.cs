using System;
using System.Runtime.InteropServices;

namespace ns0
{
	public class Class10
	{
		public struct Struct6
		{
			public int int_0;

			public int int_1;
		}

		public struct Struct7
		{
			public Class10.Struct6 struct6_0;

			public long long_0;

			public Guid guid_0;

			public Class10.Struct6 struct6_1;

			public int int_0;

			public int int_1;

			public int int_2;

			public Class10.Struct6 struct6_2;

			public string string_0;

			public int int_3;

			public int int_4;
		}

		[Guid("0000000c-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		public interface Interface0
		{
			void imethod_0(IntPtr pv, uint cb, out uint pcbRead);

			void imethod_1(IntPtr pv, uint cb, out uint pcbWritten);

			void imethod_2(long dlibMove, uint dwOrigin, out ulong plibNewPosition);

			void imethod_3(ulong libNewSize);

			void imethod_4(Class10.Interface0 pstm, ulong cb, out ulong pcbRead, out ulong pcbWritten);

			void imethod_5(uint grfCommitFlags);

			void imethod_6();

			void imethod_7(ulong libOffset, ulong cb, uint dwLockType);

			void imethod_8(ulong libOffset, ulong cb, uint dwLockType);

			void imethod_9(out Class10.Struct7 pstatstg, uint grfStatFlag);

			void imethod_10(out Class10.Interface0 ppstm);
		}

		[Guid("7c23ff90-33af-11d3-95da-00a024a85b51"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		public interface Interface1
		{
			void imethod_0(Class10.Interface2 pName);

			void imethod_1(out Class10.Interface2 ppName);

			void imethod_2([MarshalAs(UnmanagedType.LPWStr)] string szName, int pvValue, uint cbValue, uint dwFlags);

			void imethod_3([MarshalAs(UnmanagedType.LPWStr)] string szName, out int pvValue, ref uint pcbValue, uint dwFlags);

			void imethod_4(out int wzDynamicDir, ref uint pdwSize);
		}

		[Guid("CD193BC0-B4BC-11d2-9833-00C04FC31D2E"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		public interface Interface2
		{
			[PreserveSig]
			int imethod_0(uint PropertyId, IntPtr pvProperty, uint cbProperty);

			[PreserveSig]
			int imethod_1(uint PropertyId, IntPtr pvProperty, ref uint pcbProperty);

			[PreserveSig]
			int imethod_2();

			[PreserveSig]
			int imethod_3(IntPtr szDisplayName, ref uint pccDisplayName, uint dwDisplayFlags);

			[PreserveSig]
			int imethod_4(object refIID, object pAsmBindSink, Class10.Interface1 pApplicationContext, [MarshalAs(UnmanagedType.LPWStr)] string szCodeBase, long llFlags, int pvReserved, uint cbReserved, out int ppv);

			[PreserveSig]
			int imethod_5(out uint lpcwBuffer, out int pwzName);

			[PreserveSig]
			int imethod_6(out uint pdwVersionHi, out uint pdwVersionLow);

			[PreserveSig]
			int imethod_7(Class10.Interface2 pName, uint dwCmpFlags);

			[PreserveSig]
			int imethod_8(out Class10.Interface2 pName);
		}

		[Guid("9e3aaeb4-d1cd-11d2-bab9-00c04f8eceae"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		public interface Interface3
		{
			void imethod_0([MarshalAs(UnmanagedType.LPWStr)] string pszName, uint dwFormat, uint dwFlags, uint dwMaxSize, out Class10.Interface0 ppStream);

			void imethod_1(Class10.Interface2 pName);

			void imethod_2(uint dwFlags);

			void imethod_3(uint dwFlags);
		}

		[Guid("e707dcde-d1cd-11d2-bab9-00c04f8eceae"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		public interface Interface4
		{
			[PreserveSig]
			int imethod_0(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, IntPtr pvReserved, out uint pulDisposition);

			[PreserveSig]
			int imethod_1(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, IntPtr pAsmInfo);

			[PreserveSig]
			int imethod_2(uint dwFlags, IntPtr pvReserved, out Class10.Interface3 ppAsmItem, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName);

			[PreserveSig]
			int imethod_3(out object ppAsmScavenger);

			[PreserveSig]
			int imethod_4(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszManifestFilePath, IntPtr pvReserved);
		}

		[DllImport("fusion", CharSet = CharSet.Auto)]
		public static extern int CreateAssemblyCache(out Class10.Interface4 ppAsmCache, uint dwReserved);

		public static bool smethod_0(string string_0)
		{
			Class10.Interface4 @interface = null;
			int num = Class10.CreateAssemblyCache(out @interface, 0u);
			if (num != 0)
			{
				return false;
			}
			num = @interface.imethod_4(0u, string_0, IntPtr.Zero);
			return num == 0;
		}
	}
}
