using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TXT = Utility_Text.Text_Validate;

namespace Control_Module_Info.Model
{
	public class Coding_Info
	{
		string codingRead = string.Empty;
		string codingType = string.Empty;

		/// <summary>
		/// Coding String: 001E9B004000108000000032
		/// </summary>
		public string Coding {
			get {
				return
					TXT.Get_Valid_Text(codingRead);
			}
			set {
				codingRead =
					value;
			}
		}
		/// <summary>
		/// Type Of Coding: LONG
		/// </summary>
		public string CodingType {
			get {

				return
					TXT.Get_Valid_Text(codingType);
			}
			set {
				codingType =
					value;
			}
		}

		public Coding_Info() { }
		public Coding_Info(string coding, string codingType)
		{
			this.codingRead = coding;
			this.codingType = codingType;

		}

	}
}
