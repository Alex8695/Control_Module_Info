using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW = Control_Module_Info.Model.Hardware_Info;
using SW = Control_Module_Info.Model.Software_Info;
using ODX = Control_Module_Info.Model.ODX_Info;
using ZDC = Control_Module_Info.Model.ZDC_Info;
using DA = Control_Module_Info.Model.Diagnostic_Address_Info;
using CODING = Control_Module_Info.Model.Coding_Info;

public class Control_Module:Control_Module_Info.Model.Control_Module_Detail
{

	public Control_Module() : base() { }

	public Control_Module(
			string HwPartNumber, string HwVersion
			, string SwPartNumber, string SwVersion
			, string ZdcName, string ZdcVersion
			, string CodingValue, string CodingType
			, string OdxFileId, string OdxVersion, string OdxFileName, string OdxFileNameBase
			, string PrString
			, DateTime DateOfProduction
			, string DiagnosticAddress
			, string NameCommon, string NameAbbreviation, string NameShort
			, string DataType
			, bool IsFlashable)
			: base(
				hw_part_number: HwPartNumber
				, hw_version: HwVersion
				, sw_part_number: SwPartNumber
				, sw_version: SwVersion
				, zdc_name: ZdcName
				, zdc_version: ZdcVersion
				, coding_value: CodingValue
				, coding_type: CodingType
				, odx_file_id: OdxFileId
				, odx_file_version: OdxVersion
				, odx_file_name: OdxFileName
				, odx_file_name_base: OdxFileNameBase
				, pr_string: PrString
				, date_of_production: DateOfProduction
				, diagnostic_address: DiagnosticAddress
				, name_common: NameCommon
				, name_abbreviation: NameAbbreviation
				, name_short: NameShort
				, data_type: DataType
				, is_flashable: IsFlashable
				)
	{ }

	public Control_Module(
			 HW hardware
			, SW software
			, ZDC zdc
			, ODX odx
			, DA diagnostic_address
			, CODING coding
			, string coding_value
			, string coding_type
			, string pr_string
			, DateTime date_of_production
			, string name_common
			, string name_abbreviation
			, string name_short
			, string data_type
			, bool is_flashable

		):base(
			  hardware: hardware
			, software: software
			, zdc: zdc
			, odx: odx
			, diagnostic_address: diagnostic_address
			,coding: coding				 
			, pr_string: pr_string
			, date_of_production: date_of_production
			, name_common: name_common
			, name_abbreviation: name_abbreviation
			, name_short: name_short
			, data_type: data_type
			, is_flashable: is_flashable
			)
	{ }


}
