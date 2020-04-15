using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DatabaseManagement
{
    static class mdlGeneral
    {
        public const int cSUCCESS = 0;
        public const int cERROR = -1;

        public static void ErrorLogging(Exception ex)
        {
            string filePath = @"C:\Users\safa.k\Desktop\FinalTask_WithErrorProvider\ErrorLog.txt";
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine("=============Error Logging ===========");
                sw.WriteLine("===========Start============= " + DateTime.Now);
                sw.WriteLine("Error Message: " + ex.Message);
                sw.WriteLine("===========End============= " + DateTime.Now);

            }

        }
    }
}
