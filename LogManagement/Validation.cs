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

        public static Boolean inputTextValidation(List<object> ts)
        {
            bool result = true;
            byte i = 0;
            try
            {
                int count = ts.Count;
                bool[] valid = new bool[count];

                foreach (object t in ts)
                {
                    if (string.IsNullOrWhiteSpace(t.ToString()) || string.IsNullOrEmpty(t.ToString()))
                    {
                        valid[i] = false;
                    }
                    else
                    {
                        valid[i] = true;
                    }
                    i++;
                }
                if (valid.Contains(true))
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                LogValidationManagement.LogFile.LogData("inputTextValidation Error", ex.ToString(), 0);
                result = false;
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
                LogValidationManagement.LogFile.LogData("checkBoxListValidation Error", ex.ToString(), 0);
                result = false;
            }
            return result;
        }
    }
}
