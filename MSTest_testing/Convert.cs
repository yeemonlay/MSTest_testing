using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MSTest_testing
{
    public static class Convert
    {
        public static double Mth1(double num1)
        {
            return (num1 - 32) * 5 / 9;
        }
        public static double Mth2(double num2)
        {
            return (num2 * 9 / 5) + 32;
        }
        public static int getNewID(this List<int> integers)
        {
            try
            {
                int i, d, x, rcount = 0, maxID = 0, lgvalue = 0;

                ArrayList seq = new ArrayList();
                rcount = integers.Count; 
                maxID = integers.Max(); 
                integers.Sort(); 
                if (rcount != maxID)
                {
                    x = 1;
                    if (rcount > 0)
                    {
                        for (i = 0; i < rcount - 1; i++) 
                        {
                            d = integers[i + 1] - integers[i];
                            if (d > 1)
                            {
                                do
                                {
                                    seq.Add(integers[i + 1] - x);
                                    d = d - 1;
                                    x++;
                                } while (1 < d);
                                x = 1;
                            }

                        }
                        seq.Sort();
                    }
                    else
                    {
                        for (i = 0; i < maxID - 1; i++)
                        {
                            do
                            {
                                seq.Add(maxID - x);
                                x++;
                            } while (rcount == maxID);
                            x = 1;
                        }
                        seq.Sort();
                    }

                    if (seq.Count > 0)
                    {
                        lgvalue = (int)seq[0];
                    }
                    else
                    {
                        lgvalue = maxID + 1;
                    }


                }
                else
                {
                    lgvalue = maxID + 1;
                }
                return lgvalue;
            }
            catch (Exception ex)
            {
                string exstr = ex.Message;
                return 1;
            }
        }
        public static string GetPhoneNumberFormat(string PhoneNo)
        {
            string _mobileNumber = CleanNumber(PhoneNo);
            _mobileNumber = _mobileNumber.TrimStart(new char[] { '0' });
            if (_mobileNumber.StartsWith("959"))
            {
                _mobileNumber = "+" + _mobileNumber;
            }
            if (_mobileNumber.StartsWith("9"))
            {
                _mobileNumber = "+95" + _mobileNumber;
            }
            return _mobileNumber;
        }
        public static string CleanNumber(string PhoneNo)
        {
            Regex digitsOnly = new Regex(@"[^\d]");
            return digitsOnly.Replace(PhoneNo, "");
        }
    }
}
