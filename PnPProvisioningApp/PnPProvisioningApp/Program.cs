using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnPProvisioningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sharePointVersion = GetSharePointVersion();

            if (sharePointVersion == null)
            {
                Console.WriteLine("Invalid SharePoint version specified.");
                return;
            }

            switch (sharePointVersion)
            {
                case SharePointVersion.SPO:
                    ProcessSPO();
                    break;
                case SharePointVersion.SP2013:
                    Process2013();
                    break;
                case SharePointVersion.SP2016:
                    Process2016();
                    break;
            }


        }


        private static void ProcessSPO()
        {
            Console.WriteLine("Processing SPO.");
        }



        private static void Process2013()
        {
            Console.WriteLine("SP 2013 not supported yet.");
        }

        private static void Process2016()
        {
            Console.WriteLine("SP 2016 not supported yet.");
        }


        private static SharePointVersion? GetSharePointVersion()
        {
            Console.WriteLine("Please specify 'SPO', 'SP2013' or 'SP2016'");
            var input = Console.ReadLine().Trim();

            SharePointVersion sharePointVersion;

            if (!Enum.TryParse<SharePointVersion>(input, true, out sharePointVersion))
            {
                return null;
            }
            else
            {
                return sharePointVersion;
            }
        }

    }
}
