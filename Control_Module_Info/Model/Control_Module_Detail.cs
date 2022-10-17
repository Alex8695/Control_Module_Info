using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TXT = Utility_Text.Text_Validate;
using HW = Control_Module_Info.Model.Hardware_Info;
using SW = Control_Module_Info.Model.Software_Info;
using ODX = Control_Module_Info.Model.ODX_Info;
using ZDC = Control_Module_Info.Model.ZDC_Info;
using DA = Control_Module_Info.Model.Diagnostic_Address_Info;
using CI = Control_Module_Info.Model.Coding_Info;

namespace Control_Module_Info.Model
{
	public class Control_Module_Detail	: Control_Module_Base
	{


		#region OBJECT PUBLIC

		public string Module_PrNumberString {
			get {
			return TXT.Get_Valid_Text(modulePrNumberString);
			}
			set {
				modulePrNumberString = value;
			}
		}

		public Hardware_Info Module_HardwareInfo {
			get {
				return moduleHardwareInfo;
			}
			set {
				moduleHardwareInfo = value;
			}
		}
		public Software_Info Module_SoftwareInfo {
			get {
				return moduleSoftwareInfo;
			}
			set {
				moduleSoftwareInfo = value;
			}
		}
		public ZDC_Info Module_ZdcInfo {
			get {
				return moduleZdcInfo;
			}
			set {
				moduleZdcInfo = value;
			}
		}
		public ODX_Info Module_OdxInfo {
			get {
				return moduleOdxInfo;
			}
			set {
				moduleOdxInfo = value;
			}
		}
		public Coding_Info Module_CodingInfo {
			get {
				return moduleCodingInfo;
			}
			set {
				moduleCodingInfo = value;
			}
		}
		public DateTime Module_DateOfProduction {
			get {
				return moduleDateOfProduction;
			}
			set {
				moduleDateOfProduction = value;
			}
		}


		#endregion

		#region OBJECT INTERNAL


		#endregion

		#region OBJECT PROTECTED


		#endregion

		#region OBJECT PRIVATE


		Hardware_Info moduleHardwareInfo;
		Software_Info moduleSoftwareInfo;
		ZDC_Info moduleZdcInfo;
		ODX_Info moduleOdxInfo;
		Coding_Info moduleCodingInfo;
		string modulePrNumberString;
		DateTime moduleDateOfProduction;


		#endregion

		#region METHOOD PRIVATE

		private void init()
		{
			moduleHardwareInfo = new Hardware_Info();
			moduleSoftwareInfo = new Software_Info();
			moduleZdcInfo = new ZDC_Info();
			moduleOdxInfo = new ODX_Info();
			moduleCodingInfo = new Coding_Info();
			modulePrNumberString = string.Empty;
			moduleDateOfProduction = DateTime.MinValue;


		}


		#endregion

		#region METHOOD PROTECTED


		#endregion

		#region METHOOD INTERNAL


		#endregion

		#region METHOOD PUBLIC

		public Control_Module_Detail() { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="hw_part_number">5Q0959593F</param>
		/// <param name="hw_version">002</param>
		/// <param name="sw_part_number">5Q0959593F</param>
		/// <param name="sw_version">0287</param>
		/// <param name="zdc_name">83A909872B</param>
		/// <param name="zdc_version">0016</param>
		/// <param name="coding_value">001E9B004000108000000032</param>
		/// <param name="coding_type">LONG</param>
		/// <param name="odx_file_id">EV_DCU2DriveSideMAXHKLO</param>
		/// <param name="odx_file_version">001010</param>
		/// <param name="odx_file_name">EV_DCU2DriveSideMAXHKLO_001</param>
		/// <param name="odx_file_name_base">BV_DoorElectDriveSideUDS</param>
		/// <param name="pr_string">00 00 00 00 00 00 00 00 00 00 00 00</param>
		/// <param name="date_of_production">01/12/2009</param>
		/// <param name="diagnostic_address">0042</param>
		/// <param name="name_common">Driver's Door Electronics</param>
		/// <param name="name_abbreviation">J386</param>         
		/// <param name="name_short">TSG FS</param>
		/// <param name="data_type">CAN Protocol Type: UDS/ISOTP</param>
		/// <param name="nameSystem"></param>
		/// <param name="is_flashable">True</param>
		public Control_Module_Detail(
			string hw_part_number
			, string hw_version
			, string sw_part_number
			, string sw_version
			, string zdc_name
			, string zdc_version
			, string coding_value
			, string coding_type
			, string odx_file_id
			, string odx_file_version
			, string odx_file_name
			, string odx_file_name_base
			, string pr_string
			, DateTime date_of_production
			, string diagnostic_address
			, string name_common
			, string name_abbreviation
			, string name_short
			, string data_type
			, bool is_flashable
			):base(
                 diagnostic_address: diagnostic_address
                 ,name_common: name_common
                 ,name_abbreviation:name_abbreviation
                 ,name_short:name_short  
                 ,ecm_data_type:data_type
                 ,is_flashable:is_flashable
                 ){

			Module_HardwareInfo =
				new Hardware_Info(
					part_number: hw_part_number
					, version_number: hw_version);

			Module_SoftwareInfo =
				new Software_Info(
					part_number: sw_part_number
					, version_number: sw_version);

			Module_ZdcInfo =
				  new ZDC_Info(
					  part_number: zdc_name
					  , version_number: zdc_version);

			Module_CodingInfo =
				new CI(
					coding: coding_value
					, codingType: coding_type);		 

			Module_OdxInfo = new ODX_Info(
				file_id: odx_file_id
				, file_version: odx_file_version
				, file_name: odx_file_name
				, file_name_base: odx_file_name_base);


			Module_PrNumberString = pr_string;
			Module_DateOfProduction = date_of_production;


		}



		public Control_Module_Detail(
			HW hardware
			, SW software
			, ZDC zdc
			, ODX odx
			, DA diagnostic_address
			, CI coding
			, string pr_string
			, DateTime date_of_production
			, string name_common
			, string name_abbreviation
			, string name_short
			, string data_type
			, bool is_flashable
			) : base(
				diagnostic_address_info: diagnostic_address
				, name_common: name_common
				, name_abbreviation: name_abbreviation
				, name_short: name_short
				, ecm_data_type: data_type
				, is_flashable: is_flashable)
		{

			Module_HardwareInfo =
				hardware;

			Module_SoftwareInfo =
				software;

			Module_ZdcInfo =
				 zdc;

			Module_OdxInfo =
				odx;

			moduleCodingInfo =
				coding;

			Module_PrNumberString = pr_string;
			Module_DateOfProduction = date_of_production;
		}




		#endregion

	}
}
