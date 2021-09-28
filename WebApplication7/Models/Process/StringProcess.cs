using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApplication7.Models.Process
{
    public class StringProcess
    {
        private object newNumPart;

        public string AutoGenerateKey(string id)
        {
            string numPart, strPart, newKey = ""; newNumPart="";
            int intNumber;
            numPart = Regex.Match(id, @"\d+").Value;
            intNumber = Convert.ToInt32(numPart) + 1;
            for (int i = 0; i < numPart.Length - intNumber.ToString().Length; i++)
            {
                newNumPart += "0";
            }
            strPart= numPart = Regex.Match(id, @"\d+").Value;
            newKey = strPart + newNumPart;
            return newKey;

        }
    }
}