using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreditUnionFYP.classes
{
    public class ValidationClass
    {
        public static string validChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public Boolean dateValidation(DateTime dt) {
            return true;
        }

        public Boolean inputTextValidation(List<object> ts){
            bool result=true;
            int i = 0;
            try
            {
                int count = ts.Count;
                bool[] valid = new bool[count];
               
                foreach (object t in ts){
                    if (string.IsNullOrWhiteSpace(t.ToString()) || string.IsNullOrEmpty(t.ToString())){
                        valid[i] = false;
                    }
                    else{
                        valid[i] = true;
                    }
                    i++;
                }
                if (valid.Contains(true)){
                    result= true;
                }
            }
            catch (Exception ex) {
                ex.ToString();
                result=false;
            }
            return result;
          
        }
    }
}
