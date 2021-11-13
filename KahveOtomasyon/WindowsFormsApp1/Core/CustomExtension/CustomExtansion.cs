using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Core.CustomExtension
{
   public static class CustomExtansion
    {
        public static void FillDataSource(this ComboBox cmb, string[] items)
        {
            cmb.Items.Clear();
            cmb.Items.Add("Seçiniz");
            for (int i = 0; i < items.Length; i++)
            {
                cmb.Items.Add(items[i]);
            }
            cmb.SelectedIndex = 0;
        }
    }
}
