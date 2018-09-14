using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using OBID;
using System.IO.Ports;
using System.Diagnostics;

namespace ApplicationRobot.library
{
    class controller
    {
        public void ConnectScanner(FedmIscReader reader)
        {
            reader.ConnectUSB(0);
        }

        public void DisconnectScanner(FedmIscReader reader)
        {
            if (reader.Connected)
            { 
                reader.DisConnect();
            }else
            {
                Console.WriteLine("No device connected");
            }
            
        }
        //////////////////////////////////////////////Gripper function////////////////////////////////////////////////
        public void initiate()
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("initialize_port.bat");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            process = Process.Start(processInfo);
            process.WaitForExit(0);
        }

        public void openG()
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("run_openG.bat");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            process = Process.Start(processInfo);
            process.WaitForExit(0);
        }

        public void closeG()
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("run_closeG.bat");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            process = Process.Start(processInfo);
            process.WaitForExit(0);
        }
        ////////////////////////////////////////////////Gripper function////////////////////////////////////////////////


        ////////////////////////////////////////////////RobotArm function///////////////////////////////////////////////
        public string DegToRad(double Base, double Shoulder, double Elbow, double Wrist1, double Wrist2, double Wrist3)
        {
            Base = 3.14 * Base / 180;
            Shoulder = 3.14 * Shoulder / 180;
            Elbow = 3.14 * Elbow / 180;
            Wrist1 = 3.14 * Wrist1 / 180;
            Wrist2 = 3.14 * Wrist2 / 180;
            Wrist3 = 3.14 * Wrist3 / 180;
            string Position = Base + "," + Shoulder + "," + Elbow + "," + Wrist1 + "," + Wrist2 + "," + Wrist3;
            return Position;
        }

        public string meterToMm(double x, double y, double z, double RX, double RY, double RZ)
        {
            x = x / 1000;
            y = y / 1000;
            z = z / 1000;
            string Position = x + "," + y + "," + z + "," + RX + "," + RY + "," + RZ;
            return Position;
        }

        ////////////////////////////////////////////////RobotArm function///////////////////////////////////////////////


        ////////////////////////////////////////////////Reference///////////////////////////////////////////////
        //Peter Ackroyd  37.55mm > Mid 18.775mm
        //Margaux Fragoso 23.85mm > Mid 11.925mm
        //Dork diaries 25.30mm > Mid 12.65mm
        //The Road to Rangoon 37.85mm > Mid 18.925mm
        //Mastering Business Negotiation 21.13mm > Mid 10.565mm
        //Richard Branson 28.15mm > Mid 14.075mm
        ////////////////////////////////////////////////Reference///////////////////////////////////////////////
    }

}
