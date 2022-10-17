using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Module_Info.Model
{
	public class Hardware_Info:ReleaseVersionAbstract
	{
		public Hardware_Info() : base() { }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="part_number">5Q0959593F</param>
		/// <param name="version_number">H02</param>
		public Hardware_Info(string part_number, string version_number) : base(part_number,version_number) { }
	}
}
