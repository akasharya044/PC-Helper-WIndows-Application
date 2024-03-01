using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace custos.Methods
{
    public class Harddiskinfoma
    {

        public HardDiskDto HardDiskInfomation()
        {
            
            try
            {

                string nonSystemDrive = GetNonSystemDrive();

                DriveInfo[] allDrives = DriveInfo.GetDrives();


                string[] driveLetters = Environment.GetLogicalDrives()
                .Select(drive => Path.GetPathRoot(drive).TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar))
                .Select(drive => drive.Substring(0, 1))
                .ToArray();

                string driveLetter = driveLetters[0];

                string systemdrive = GetSystemDrive();
                string drivename = String.Empty;
                string drivetype = String.Empty;
                string driveformat = String.Empty;
                string serialNumber = String.Empty;
                string totalsize = String.Empty;
                string freespace = String.Empty;
                string Availablefreespace = String.Empty;
                string nonsysdrive = String.Empty;
                string nontotal = String.Empty;
                string nonfree = String.Empty;

                foreach (DriveInfo drive in allDrives)
                {

                    serialNumber = GetDriveSerialNumber(driveLetter.ToString());
                    drivename = drive.Name;
                    drivetype = drive.DriveType.ToString();
                    if (systemdrive.Contains(drive.Name))
                    {
                        if (drivename != null)
                        {
                            drivename = drive.Name;

                        }
                        if (drivetype != null)
                        {
                            drivetype = drive.DriveType.ToString();
                        }





                        if (systemdrive != null)
                        {
                            totalsize = FormatBytes(drive.TotalSize);
                            freespace = FormatBytes(drive.TotalFreeSpace);
                            Availablefreespace = FormatBytes(drive.AvailableFreeSpace);
                            driveformat = drive.DriveFormat.ToString();


                        }


                        //if (drive.DriveType == DriveType.Fixed)
                        //{
                        //    if (serialNumber != null)
                        //    {
                        //        hardDiskDto.SerialNumber = serialNumber;
                        //    }

                        //}
                    }

                    if (nonSystemDrive != null)
                    {
                        DriveInfo driveInfo = new DriveInfo(nonSystemDrive);

                        nonsysdrive = driveInfo.Name;
                        nontotal = FormatBytes(driveInfo.TotalSize);
                        nonfree = FormatBytes(driveInfo.TotalFreeSpace);

                        


                    }

                }



               // hardDiskDto.SystemId = System.Environment.MachineName;

                return new HardDiskDto
                {
                    DriveName = drivename,
                    DriveType = drivetype,
                    DriveFormat = driveformat,
                    SerialNumber = serialNumber,
                    TotalSize =  totalsize,
                    FreeSpace = freespace,
                    AvailableFreeSpace = Availablefreespace,
                    NonSystemDriveName = nonsysdrive,
                    NonSystemTotalSpace = nontotal,
                    NonSystemFreeSpace = nonfree,
                    SystemId = System.Environment.MachineName,

                };

            }
            catch (Exception ex)
            {
                return null;
            }

            

        }

        static string FormatBytes(long bytes)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            int suffixIndex = 0;

            while (bytes >= 1024 && suffixIndex < suffixes.Length - 1)
            {
                bytes /= 1024;
                suffixIndex++;
            }

            return $"{bytes} {suffixes[suffixIndex]}";
        }

        static string GetDriveSerialNumber(string driveLetter)
        {

            try
            {
                ManagementObject disk = new ManagementObject($"win32_logicaldisk.deviceid=\"{driveLetter}:\"");
                disk.Get();
                return disk["VolumeSerialNumber"].ToString();
            }
            catch (ManagementException mex)
            {
                Console.WriteLine($"ManagementException: {mex.Message}");
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine($"UnauthorizedAccessException: {uae.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving drive serial number: {ex.Message}");
            }

            return "N/A";
        }

        static string GetNonSystemDrive()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                if (drive.DriveType == DriveType.Fixed && !Path.GetPathRoot(Environment.SystemDirectory).StartsWith(drive.Name))
                {
                    return drive.Name;
                }
            }

            return null;
        }

        static string GetSystemDrive()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.DriveType == DriveType.Fixed && Path.GetPathRoot(Environment.SystemDirectory).StartsWith(drive.Name))
                {
                    return drive.Name;
                }
            }
            return null;
        }
    }

    public class HardDiskDto
    {
       
        public string DriveName { get; set; }
        public string DriveType { get; set; }
        public string DriveFormat { get; set; }
        public string SerialNumber { get; set; }
        public string TotalSize { get; set; }
        public string FreeSpace { get; set; }
        public string AvailableFreeSpace { get; set; }

        public string NonSystemDriveName { get; set; }

        public string NonSystemTotalSpace { get; set; }

        public string NonSystemFreeSpace { get; set; }

        public string SystemId { get; set; }
    }
}
