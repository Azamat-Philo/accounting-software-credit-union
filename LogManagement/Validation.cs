using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
                        else if (tb.TextLength == 0)
                        {
                            valid[i] = false;
                        }
                        else
                        {
                            valid[i] = true;
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
                LogValidationManagement.LogFile.LogData("inputTextValidation Error", ex.ToString(), 0);
                result = false;
            }
            ts.Clear();
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
                LogValidationManagement.LogFile.LogData("checkBoxListValidation Error", ex.ToString(), 0);
                result = false;
            }
            return result;
        }
    }
}
