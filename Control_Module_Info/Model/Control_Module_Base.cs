using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TXT = Utility_Text.Text_Validate;
using DIAG_ADDR = Control_Module_Info.Model.Diagnostic_Address_Info;

namespace Control_Module_Info.Model
{
	[DebuggerDisplay("{Module_DiagnosticAddress} - {Module_NameCommon}")]
	public class Control_Module_Base
	{



		#region OBJECT PUBLIC		

		/// <summary>
		///Diagnostic Bus Address Of Control Module
		/// </summary>

		public Diagnostic_Address_Info Module_Diagnostic_Address {
			get {
				return moduleDiagnosticAddress;
			}
		}


		/// <summary>
		/// Common Name:  Driver's Door Electronics
		/// </summary>
		public string Module_Name_Common {
			get {
				return TXT.Get_Valid_Text(moduleNameCommon);
			}
			set {
				moduleNameCommon = value;
			}
		}

		/// <summary>
		/// System Name: J386
		/// </summary>
		public string Module_NameAbbreviation {
			get {
				return TXT.Get_Valid_Text(moduleNameAbbreviation);
			}
			set {
				moduleNameAbbreviation = value;
			}
		}


		/// <summary>
		/// Short Name: TSG FS
		/// </summary>
		public string Module_NameShort {
			get {
				return TXT.Get_Valid_Text(moduleNameShort);
			}
			set {
				moduleNameShort = value;
			}
		}


		/// <summary>
		/// CAN Protocol Type: UDS/ISOTP 
		/// </summary>
		public string Module_ECM_DataType {
			get {
				return TXT.Get_Valid_Text(moduleEcmDataType);
			}
			set {
				moduleEcmDataType = value;
			}
		}


		/// <summary>
		/// True
		/// </summary>
		public bool Module_IsFlashable {
			get {
				return moduleIsFlashable;
			}
			set {
				moduleIsFlashable = value;
			}
		}




		#endregion

		#region OBJECT INTERNAL


		#endregion

		#region OBJECT PROTECTED


		#endregion

		#region OBJECT PRIVATE

		Diagnostic_Address_Info moduleDiagnosticAddress;
		private string moduleNameCommon;
		private string moduleNameAbbreviation;
		private string moduleNameShort;
		private string moduleEcmDataType;
		private bool moduleIsFlashable;

		#endregion

		#region METHOOD PRIVATE

		private void clear()
		{

			moduleDiagnosticAddress = new Diagnostic_Address_Info();
			moduleNameCommon = string.Empty;
			moduleNameAbbreviation = string.Empty;
			moduleNameShort = string.Empty;
			moduleEcmDataType = string.Empty;
			moduleIsFlashable = false;

		}


		#endregion

		#region METHOOD PROTECTED


		#endregion

		#region METHOOD INTERNAL


		#endregion

		#region METHOOD PUBLIC		 

		/// <summary>
		/// 
		/// </summary>
		/// <param name="diagnostic_address">0042</param>
		/// <param name="name_common">Driver's Door Electronics</param>
		/// <param name="name_abbreviation">J386</param>
		/// <param name="name_short">TSG FS</param>     
		/// <param name="ecm_data_type">CAN Protocol Type: UDS/ISOTP</param>
		/// <param name="is_flashable">True</param>
		public Control_Module_Base(
			string diagnostic_address
			, string name_common
			, string name_abbreviation
			, string name_short
			, string ecm_data_type
			, bool is_flashable
			)
		{
			moduleDiagnosticAddress =
				new Diagnostic_Address_Info(
					address: diagnostic_address);

			moduleNameCommon = name_common;

			moduleNameShort = name_short;

			moduleEcmDataType = ecm_data_type;

			moduleNameAbbreviation = name_abbreviation;

			moduleIsFlashable = is_flashable;


		}




		/// <summary>
		/// 
		/// </summary>
		/// <param name="diagnostic_address_info">0042</param>
		/// <param name="name_common">Driver's Door Electronics</param>
		/// <param name="name_abbreviation">J386</param>
		/// <param name="name_short">TSG FS</param>     
		/// <param name="ecm_data_type">CAN Protocol Type: UDS/ISOTP</param>
		/// <param name="is_flashable">True</param>
		public Control_Module_Base(
			DIAG_ADDR diagnostic_address_info
			, string name_common
			, string name_abbreviation
			, string name_short
			, string ecm_data_type
			, bool is_flashable
			)
		{
			moduleDiagnosticAddress =
				diagnostic_address_info;

			moduleNameCommon = name_common;

			moduleNameShort = name_short;

			moduleEcmDataType = ecm_data_type;

			moduleNameAbbreviation = name_abbreviation;

			moduleIsFlashable = is_flashable;


		}



		public Control_Module_Base()
		{
			clear();
		}

		#endregion





	}
}
