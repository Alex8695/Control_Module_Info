using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Module_Info.Control
{
	class Hex
	{
		public static Func<string[], bool> hexIsValid = (x => x.All(a => a != string.Empty));
		public static Func<string, string> hexMake = (x => $"0x{x.Trim().ToUpper()}");

		/// <summary>
		/// to int32
		/// </summary>
		/// <param name="hex_data"></param>
		/// <returns></returns>
		public static int hex_to_int(string[] hex_data)
		{
			int _out = 0;

			if ((hexIsValid(hex_data)))
			{
				if (hex_data[1] != string.Empty)
				{						
					int.TryParse(
						s: hex_data[1]
						, style: System.Globalization.NumberStyles.HexNumber
						,provider:null
						, result: out _out);
				}
			}

			return _out;
		}


		/// <summary>
		/// 00 01 02
		/// </summary>
		/// <param name="hex_data"></param>
		/// <returns></returns>
		public static string hexData_to_string(string[] hex_data)
		{
			string _out = string.Empty;

			for (int i = 0; i < hex_data.Length; i++)
			{
				if (hex_data[i] != string.Empty)
				{
					_out =
						(_out == string.Empty)
						? hexMake(hex_data[i])
						: $"{_out} {hexMake(hex_data[i])}";
				}
			}

			return _out;
		}


		/// <summary>
		/// 000102
		/// </summary>
		/// <param name="hex_data"></param>
		/// <returns></returns>
		public static string hexData_to_string_long(string[] hex_data)
		{
			return (hexIsValid(hex_data))
				? string.Join("", hex_data)
				:"XXXX";

		}

		/// <summary>
		/// 01
		/// </summary>
		/// <param name="hex_data"></param>
		/// <returns></returns>
		public static string hexData_to_string_short(string[] hex_data)
		{

			return (hexIsValid(hex_data))
				? string.Join(
					separator: ""
					, values: hex_data
						.Where(w => w != "00")
						.Select(s => s)
						)
				:"XX";

		}


		/// <summary>
		/// 0x01
		/// </summary>
		/// <param name="hex_data"></param>
		/// <returns></returns>
		public static string hexData_to_word(string[] hex_data)
		{
			return  (hexIsValid(hex_data))
				?$"0x{hex_data[1]}"
				:"0xXX";
		}


		public static byte[] hexData_to_byte_array(string[] hex_data)
		{
			return (!hexIsValid(hex_data))
				? new byte[] { 0, 0 }
				: hex_data
				.Select(x => Convert.ToByte(x, 16))
				.ToArray();
		}

	}
}
