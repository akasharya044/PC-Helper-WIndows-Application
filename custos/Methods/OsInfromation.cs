using custos.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace custos.Methods
{
    public class OsInfromation
    {

        CommonMethod method = new CommonMethod();
        ManagementObjectSearcher searcher;
        ManagementObjectSearcher searcher1;

        public ManagementObjectSearcher OsInformation()
        {

            try
            {

                Events events = new Events();
                events.Event = "Os Information Fetched";
                events.EventDate = DateTime.Now;
                events.SystemId = System.Environment.MachineName;
                method.EventLog(events);

                searcher = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
                //searcher1 = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");


            }
            catch(Exception ex) {
                


            }
            return searcher;
        }

        public ManagementObjectSearcher OsInformation1()
        {

            try
            {

                Events events = new Events();
                events.Event = "Os Information Fetched";
                events.EventDate = DateTime.Now;
                events.SystemId = System.Environment.MachineName;
                method.EventLog(events);

                //searcher = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
                searcher1 = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");


            }
            catch (Exception ex)
            {



            }
            return searcher1;
        }

        
    }
}
