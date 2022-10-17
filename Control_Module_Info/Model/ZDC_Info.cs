using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Module_Info.Model
{
	public class ZDC_Info : ReleaseVersionAbstract
	{
		public ZDC_Info() : base() { }


		/// <summary>
		/// ZDC - Parameter File
		/// </summary>
		/// <param name="part_number">83A909872B</param>
		/// <param name="version_number">0016</param>
		public ZDC_Info(string part_number, string version_number) : base(part_number, version_number) { }
	}
}
