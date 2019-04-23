using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalClinic
{
    class DataGridFocusedRow
    {
        DataGridViewRow focusedRow;
        public DataGridFocusedRow(DataGridView view)
        {
              this.focusedRow = view.Rows[view.CurrentCell.RowIndex];
        }

        public object get(string columnName)
        {
            return focusedRow.Cells[columnName].Value;
        }
    }
}
