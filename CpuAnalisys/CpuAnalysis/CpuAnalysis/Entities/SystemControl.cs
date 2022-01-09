using System;
using System.Diagnostics;
using System.Management;
using System.Dynamic;
using System.Collections.Generic;


namespace CpuAnalysis.Entities
{
    internal class SystemControl
    {

        public void Retorno()
        {
            Process[] processList = Process.GetProcesses();

            SystemControl sys = new SystemControl();

            foreach (Process process in processList)
            {
                string status = (process.Responding == true ? "Responding" : "Not responding");

                string[] row = new string[] {
                    process.ProcessName,
                    process.Id.ToString(),
                    status,
                    sys.BytesToReadableValue(process.PrivateMemorySize64),
                    "----------------------"
                };

                for (int i = 0; i < row.Length; i++)
                {

                    Console.WriteLine(row[i]);

                }
            }
        }

        public string BytesToReadableValue(long number)
        {
            List<string> suffixes = new List<string> { " B", " KB", " MB", " GB", " TB", " PB" };

            for (int i = 0; i < suffixes.Count; i++)
            {
                long temp = number / (int)Math.Pow(1024, i + 1);

                if (temp == 0)
                {
                    return (number / (int)Math.Pow(1024, i)) + suffixes[i];
                }
            }

            return number.ToString();
        }

    } 
}
