using System;
using System.Security.Cryptography;

namespace ns13
{
	public abstract class Class207 : SymmetricAlgorithm
	{
		public static byte[] smethod_0(byte[] byte_0)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("seed");
			}
			if (byte_0.Length == 0)
			{
				throw new ArgumentException("Length is zero", "seed");
			}
			uint[] array = new uint[]
			{
				305419896u,
				591751049u,
				878082192u
			};
			for (int i = 0; i < byte_0.Length; i++)
			{
				array[0] = Class192.smethod_0(array[0], byte_0[i]);
				array[1] = array[1] + (uint)((byte)array[0]);
				array[1] = array[1] * 134775813u + 1u;
				array[2] = Class192.smethod_0(array[2], (byte)(array[1] >> 24));
			}
			return new byte[]
			{
				(byte)(array[0] & 255u),
				(byte)(array[0] >> 8 & 255u),
				(byte)(array[0] >> 16 & 255u),
				(byte)(array[0] >> 24 & 255u),
				(byte)(array[1] & 255u),
				(byte)(array[1] >> 8 & 255u),
				(byte)(array[1] >> 16 & 255u),
				(byte)(array[1] >> 24 & 255u),
				(byte)(array[2] & 255u),
				(byte)(array[2] >> 8 & 255u),
				(byte)(array[2] >> 16 & 255u),
				(byte)(array[2] >> 24 & 255u)
			};
		}
	}
}
