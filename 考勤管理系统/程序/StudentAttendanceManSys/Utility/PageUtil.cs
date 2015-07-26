using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Data;

namespace Utility
{
    public class PageUtil
    {
        /// <summary>
        /// 对下拉列表进行初始值绑定
        /// </summary>
        /// <param name="ddl"></param>
        /// <param name="value"></param>
        public static void bindDropDownList(DropDownList ddl, string value)
        {
            for (int i = 0; i < ddl.Items.Count; i++)
            {
                if (ddl.Items[i].Text.Equals(value) || ddl.Items[i].Value.Equals(value))
                {
                    ddl.SelectedIndex = i;
                    break;
                }
            }
        }

        /// <summary>
        /// 对数据进行分页处理
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static DataTable getPaged(DataTable dt, int from, int to)
        {
            DataTable pagedDt = dt.Clone();

            for (int i = from - 1; i < to; i++)
            {
                pagedDt.ImportRow(dt.Rows[i]);
            }

            return pagedDt;
        }

        /// <summary>
        /// 取得经过筛选和排序处理后的DataTable
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="filter"></param>
        /// <param name="sort"></param>
        /// <returns></returns>
        public static DataTable getProcessedDataTable(DataTable dt, string filter = null, string sort = null, Boolean doResort = true)
        {
            DataView dv = dt.DefaultView;
            if (filter != null)
                dv.RowFilter = filter;
            if (sort != null)
                dv.Sort = sort;

            if (doResort)
                return resort(dv.ToTable());
            else
                return dv.ToTable();
        }

        /// <summary>
        /// 对DataTable重新排序
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DataTable resort(DataTable dt)
        {
            int colNum = 1;
            for (int i = 0; i < dt.Rows.Count; i++, colNum++)
            {
                dt.Rows[i][0] = colNum;
            }

            return dt;
        }
    }
}
