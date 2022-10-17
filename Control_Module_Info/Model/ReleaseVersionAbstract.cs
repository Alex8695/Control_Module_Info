using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TXT = Utility_Text.Text_Validate;

namespace Control_Module_Info.Model
{
	public class ReleaseVersionAbstract
	{


		public string PartNumber {
			get {
				return TXT.Get_Valid_Text(
					partNumber);
			}
			internal set {
				partNumber =
					value;
					
			}
		}
		public string VersionNumber {
			get {
				return TXT.Get_Valid_Text(
					versionNumber);
			}
			internal set {
				versionNumber = 
					value;
			}
		}

		private string partNumber;
		private string versionNumber;

		protected ReleaseVersionAbstract() { }
		protected ReleaseVersionAbstract(string part_number, string version_number)
		{
			partNumber = part_number;
			versionNumber = version_number;
		}

	}
}

