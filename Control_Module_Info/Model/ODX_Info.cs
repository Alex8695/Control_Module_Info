using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TXT = Utility_Text.Text_Validate;

namespace Control_Module_Info.Model
{
				   
	[DebuggerDisplay("{ODX_FileName}")]
	public class ODX_Info
	{
		private string fileId = string.Empty;
		private string version = string.Empty;
		private string fileName = string.Empty;
		private string fileBase = string.Empty;


		public ODX_Info() { }
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="FileId">EV_DCU2DriveSideMAXHKLO</param>
		/// <param name="FileVersion">001010</param>
		/// <param name="FileName">EV_DCU2DriveSideMAXHKLO</param>
		/// <param name="FileNameBase">BV_DoorElectDriveSideUDS</param>
		internal ODX_Info(
			string file_id
			, string file_version
			, string file_name
			, string file_name_base
			)
		{
			ODX_FileId =
				file_id;

			ODX_Version =
				file_version;

			ODX_FileName =
				file_name;

			ODX_BaseFile =
				file_name_base;
		}

		/// <summary>
		/// File Name:  EV_DCU2DriveSideMAXHKLO
		/// </summary>
		public string ODX_FileId {
			get {
				return TXT.Get_Valid_Text(fileId);
			}
			set {
				fileId = value;
			}
		}
		/// <summary>
		/// Version Number: 001010
		/// </summary>
		public string ODX_Version {
			get {
				return TXT.Get_Valid_Text( version);
			}
			set {
				version = value;
			}
		}
		/// <summary>
		/// Full Name:  EV_DCU2DriveSideMAXHKLO_001
		/// </summary>
		public string ODX_FileName {
			get {
				return TXT.Get_Valid_Text(fileName);
			}
			set {
				fileName = value;
			}
		}

		/// <summary>
		/// Base File:  BV_DoorElectDriveSideUDS
		/// </summary>
		public string ODX_BaseFile {
			get {
				return TXT.Get_Valid_Text(fileBase);
			}
			set {
				fileBase = value;
			}
		}

	}
}
