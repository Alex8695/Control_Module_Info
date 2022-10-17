using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Module_Info.Model
{
	[DebuggerDisplay("{AsString}")]
	public class Diagnostic_Address_Info
	{


		#region OBJECT PUBLIC	  

		/// <summary>
		/// 00-01
		/// </summary>
		public string AsStringHex {
			get {
				return 
					Control.Hex.hexData_to_string(hexData);
			}
		}

		/// <summary>
		/// 0x01
		/// </summary>
		public string AsHex {
			get {
				return 
					Control.Hex.hexData_to_word(hexData);
			}
		}

		public byte[] AsByteArray()
		{
			return
				Control.Hex.hexData_to_byte_array(hexData);
		}

		/// <summary>
		/// 1
		/// </summary>
		public int AsInt32 {
			get {
				return Control.Hex.hex_to_int(hexData);
			}
		}

		/// <summary>
		/// 0001
		/// </summary>
		public string AsString {
			get {
				return 
					Control.Hex.hexData_to_string_long(hexData);
			}
		}

		/// <summary>
		/// 01
		/// </summary>
		public string AsStringShort {
			get {
				return 
					Control.Hex.hexData_to_string_short(hexData);
			}
		}



		#endregion

		#region OBJECT INTERNAL


		#endregion

		#region OBJECT PROTECTED


		#endregion

		#region OBJECT PRIVATE

		string[] hexData = null;
		string inputText = null;

		#endregion

		#region METHOOD PRIVATE



		private void init()
		{

			hexData =
				new string[] {
					string.Empty,
					string.Empty};

			inputText =
				null;
		}

		private void onInputText()
		{

			if (inputText != null)
			{
				switch (inputText.Length)
				{
					case 4:
						hexData[0] =
							inputText.Substring(0, 2);

						hexData[1] =
							inputText.Substring(2, 2);

						break;

					case 3:
						hexData[0] =
							inputText.Substring(0, 2);

						hexData[1] =
							$"0{inputText.Substring(2, 1)}";

						break;

					case 2:
						hexData[1] =
							inputText.Substring(0, 2);

						hexData[0] =
							"00";
						break;

					case 1:
						hexData[1] =
							$"0{inputText}";

						hexData[0] =
							"00";
						break;

					default:
						break;
				}
			}

			if (!isValid())
			{
				init();
			}
		}

		private bool isValid()
		{
			bool _out = false;

			if (hexData[0] != string.Empty)
			{

				_out =
					true;

			}

			return _out;
		}

		private string debugText()
		{

			return ""
				+ $"As Hex: {AsHex}"
				+ "\t"
				+ $"As String: {AsString}"
				+ "\t"
				+ $"As String Hex: {AsStringHex}"
				+ "\t"
				+ $"As String Short: {AsStringShort}"
				+ "\t"
				+ $"As Int: {AsInt32}"
				+ "\t"
				+ $"From Input: {inputText}"
				+ "\t"
				+ $""

				+ "";


		}
					

		#endregion

		#region METHOOD PROTECTED


		#endregion

		#region METHOOD INTERNAL


		#endregion

		#region METHOOD PUBLIC

		public Diagnostic_Address_Info() {
			init();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="address">0042</param>
		public Diagnostic_Address_Info(string address) {
			init();

			inputText =
				address;

			onInputText();
		}


		public override string ToString()
		{
			return debugText();
		}


		public override bool Equals(object obj)
		{
			bool _out = false;
			string _asString = string.Empty;
			int _asInt = 0;


			if (obj != null)
			{

				if (obj.GetType() == typeof(string))
				{
					_asString =
						(string)obj;

					switch (_asString.Length)
					{
						case 2:
							_out =
								_asString == AsStringShort;
							break;

						case 4:
							_out =
								_asString == AsString;
							break;

						default:
							break;

					}
				}
				else if (obj.GetType() == typeof(int))
				{

					_asInt =
						(int)obj;

					_out =
						_asInt == AsInt32;

				}
				else if (obj.GetType() == typeof(Diagnostic_Address_Info))
				{

					_out =
						this.AsInt32 == ((Diagnostic_Address_Info)obj).AsInt32;

				}
			}

			return _out;
		}



		#endregion

	}
}
