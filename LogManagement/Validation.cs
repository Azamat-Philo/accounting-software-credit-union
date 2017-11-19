using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Bunifu.Framework.UI;

namespace LogValidationManagement
{
    public class Validation
    {
        public static string validChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static Boolean dateValidation(DateTime dt)
        {
            return true;
        }

        public Boolean inputTextValidation(List<Control> ts)
        {
            bool result = true;
            byte i = 0;
            try
            {
                int count = ts.Count;
                bool[] valid = new bool[count];

                foreach (Control t in ts)
                {
                   if (t.GetType().Name == "TextBox")
                    {
                        TextBox tb = (TextBox)t;
                        if (string.IsNullOrWhiteSpace(tb.Text.ToString()) || string.IsNullOrEmpty(tb.Text.ToString()))
                        {
                            valid[i] = false;
                        }
                        else if (tb.TextLength > 0)
                        {
                            valid[i] = true;
                        }
                        else
                        {
                            valid[i] = true;
                        }
                    }
                    else if ( t.GetType().Name == "ComboBox" || t.GetType().Name == "BunifuDropdown")
                    {
                        if (t.GetType().Name == "ComboBox")
                        {
                            ComboBox tr = (ComboBox)t;
                            if (tr.SelectedIndex==-1)
                            {
                                valid[i] = false;
                            }
                            else
                            {
                                valid[i] = true;
                            }
                        }
                        else {
                            BunifuDropdown tr = (BunifuDropdown)t;
                            if(tr.selectedIndex == -1)
                            {
                                valid[i] = false;
                            }
                            else
                            {
                                valid[i] = true;
                            }
                        }
                        
                    }
                    else {
                        valid[i] = false;
                    }
                    i++;
                }
                if (valid.Contains(false))
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                LogValidationManagement.LogFile.LogData(System.Reflection.MethodBase.GetCurrentMethod(), ex.ToString(), 0);
                result = false;
            }
            ts.Clear();
            return result;

        }
        public static Boolean rbButtonCheck(List<RadioButton> rbs) {
            bool result = true;
            int count = rbs.Count;
            bool[] valid = new bool[count];
            byte i = 0;
            foreach (RadioButton rb in rbs)
            {
                if (rb.Checked)
                {
                    valid[i] = true;
                }
                else {
                    valid[i] = false;
                }
                i++;
            }
            if (valid.Contains(true))
            {
                result = true;
            }
            return result;
        }
        public static Boolean checkBoxListValidation(CheckedListBox chk)
        {
            bool result = true;
            try
            {
                if (chk.CheckedIndices.Count > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

            }
            catch (Exception ex)
            {
                LogValidationManagement.LogFile.LogData(MethodBase.GetCurrentMethod(), ex.ToString(), 0);
                result = false;
            }
            return result;
        }
    }
}
