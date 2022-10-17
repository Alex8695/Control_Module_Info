using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Module_Info.Model
{
	public class Software_Info :ReleaseVersionAbstract
	{

		public Software_Info() : base() { }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="part_number">5Q0959593F</param>
		/// <param name="version_number">0287</param>
		public Software_Info(string part_number, string version_number) : base(part_number, version_number) { }
	}
}
