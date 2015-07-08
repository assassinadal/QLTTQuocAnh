///************************************************
/// Generated by: TuyenNT
/// Date: 15/03/2015 02:19:02
/// Goal: Create User Service Class for V_RPT_F460_TINH_HINH_BO_LOP
///************************************************
/// <summary>
/// Create User Service Class for V_RPT_F460_TINH_HINH_BO_LOP
/// </summary>

using System;
using BKI_QLTTQuocAnh.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLTTQuocAnh.US{

public class US_V_RPT_F460_TINH_HINH_BO_LOP : US_Object
{
	private const string c_TableName = "V_RPT_F460_TINH_HINH_BO_LOP";
#region "Public Properties"
	public decimal dcID 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID"] = value;
		}
	}

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public decimal dcID_LOP_MON 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOP_MON", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOP_MON"] = value;
		}
	}

	public bool IsID_LOP_MONNull()	{
		return pm_objDR.IsNull("ID_LOP_MON");
	}

	public void SetID_LOP_MONNull() {
		pm_objDR["ID_LOP_MON"] = System.Convert.DBNull;
	}

	public string strMO_TA 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MO_TA", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MO_TA"] = value;
		}
	}

	public bool IsMO_TANull() 
	{
		return pm_objDR.IsNull("MO_TA");
	}

	public void SetMO_TANull() {
		pm_objDR["MO_TA"] = System.Convert.DBNull;
	}

	public decimal dcID_HOC_SINH 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_HOC_SINH", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_HOC_SINH"] = value;
		}
	}

	public bool IsID_HOC_SINHNull()	{
		return pm_objDR.IsNull("ID_HOC_SINH");
	}

	public void SetID_HOC_SINHNull() {
		pm_objDR["ID_HOC_SINH"] = System.Convert.DBNull;
	}

	public string strMA_HOC_SINH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_HOC_SINH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_HOC_SINH"] = value;
		}
	}

	public bool IsMA_HOC_SINHNull() 
	{
		return pm_objDR.IsNull("MA_HOC_SINH");
	}

	public void SetMA_HOC_SINHNull() {
		pm_objDR["MA_HOC_SINH"] = System.Convert.DBNull;
	}

	public string strHO_TEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_TEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_TEN"] = value;
		}
	}

	public bool IsHO_TENNull() 
	{
		return pm_objDR.IsNull("HO_TEN");
	}

	public void SetHO_TENNull() {
		pm_objDR["HO_TEN"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_RPT_F460_TINH_HINH_BO_LOP() 
	{
		pm_objDS = new DS_V_RPT_F460_TINH_HINH_BO_LOP();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_RPT_F460_TINH_HINH_BO_LOP(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_RPT_F460_TINH_HINH_BO_LOP(decimal i_dbID) 
	{
		pm_objDS = new DS_V_RPT_F460_TINH_HINH_BO_LOP();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillDatasetByProc(DS_V_RPT_F460_TINH_HINH_BO_LOP op_ds, DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay)
    {
        CStoredProc v_pr = new CStoredProc("pr_f460_tinh_hinh_bo_lop");
        v_pr.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
        v_pr.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);
        v_pr.fillDataSetByCommand(this, op_ds);
    }

    public void load_tong_so_hs_dang_hoc(DateTime ip_dat_tu_ngay, DateTime ip_dat_den_ngay, ref decimal  ip_dc_tong_so_hs_dang_hoc)
    {
        CStoredProc v_pr = new CStoredProc("pr_load_tong_so_hs_dang_hoc");
        v_pr.addDatetimeInputParam("@ip_dat_tu_ngay", ip_dat_tu_ngay);
        v_pr.addDatetimeInputParam("@ip_dat_den_ngay", ip_dat_den_ngay);
        SqlParameter v_pa = v_pr.addDecimalOutputParam("@op_dc_tong_so_hs_dang_hoc", ip_dc_tong_so_hs_dang_hoc);

        v_pr.ExecuteCommand(this);
        ip_dc_tong_so_hs_dang_hoc = CIPConvert.ToDecimal(v_pa.Value);
    }
}
}
