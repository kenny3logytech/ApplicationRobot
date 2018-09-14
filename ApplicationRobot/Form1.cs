using ApplicationRobot.library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBID;
using System.Threading;
using System.Collections;
using System.Diagnostics;

namespace ApplicationRobot
{
    public partial class Form1 : Form
    {
        controller L = new controller();
        ////////////////////////////////////////////////Global declaration//////////////////////////////////////////////
        bool running = false;
        string norm;
        byte[] bytes;
        string HostIpAdrress = "169.254.129.44";
        int PortNumber = 30002;
        Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        string[] bookTag = new string[] { "E004015025CC264B-Peter", "E004015025CC260B-Margaux" , "E004015025CC8DBC-Dork" ,
                                           "E004015025CC262B-The Road", "E004015025CC266A-Mastering"};
        double[] bookthickness = new double[] {41,25,25,38,22 };
        string Position;
        string speedSlow = "a =  0.05, v = 0.2, r = 0)" + "\n" ;
        string speedMedium = "a =  0.1, v = 0.7, r = 0)" + "\n";
        string speedHigh = "a =  0.2, v = 1.05, r = 0)" + "\n";
        ////////////////////////////////////////////////Declare function of the robot arm//////////////////////////////////////////////
        public void OriginalPosition() //Straight position done testing//
        {
            string Position = L.DegToRad(-0, -90, 0, -90, 0, 0);
            norm = "movej([" + Position + "]," + speedHigh ;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
        }

        public async void ReadyPosition()//90 degree position done testing//
        {
            string Position = L.DegToRad(-90, -90, -90, -90, 0, -0);
            norm = "movej([" + Position + "]," + speedHigh ;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            await Task.Delay(3000);
        }

        public async void ReadyPositionMoveL()
        {
            string Position = L.DegToRad(-90, -90, -90, -90, 0, -0);
            norm = "movel([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            await Task.Delay(4000);
        }

        public async void StandbyPosition()//Standby hook and ready to hook book out done testing//
        {
            string Position = L.DegToRad(-89.32, -91.38, -63.78, -241.89, -2.01, 33.12);
            norm = "movej([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            await Task.Delay(3000);
        }

        public async void PickUpHook() 
        {   
            
            //pick up standby position
            Position = L.DegToRad(-64.32, -145.37, -61.29, -151.09, 114.39, 182.92);
            norm = "movej([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            await Task.Delay(6000);
            L.openG();

            //Move in vertically infront of the hook
            Position = L.DegToRad(-53.54, -122.70, -105.64, -129.35, 125.24, 183.47);
            norm = "movel([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            await Task.Delay(4000);

            L.closeG();
            await Task.Delay(600);

            //Move out vertically 
            Position = L.DegToRad(-64.32, -145.37, -61.29, -151.09, 114.39, 182.92);
            norm = "movel([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            await Task.Delay(4000);


            //standby position
            Position = L.DegToRad(-109.56, -98, -52, -212.79, -22, 0);
            norm = "movej([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            MessageBox.Show("Pick up hook completed.");
        }

        public async void PutBackHook()
        {
            //pick up standby position
            Position = L.DegToRad(-64.32, -145.37, -61.29, -151.09, 114.39, 182.92);
            norm = "movej([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            await Task.Delay(6000);

            //Move in vertically infront of the hook
            Position = L.DegToRad(-53.54, -122.70, -105.64, -129.35, 125.24, 183.47);
            norm = "movel([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            await Task.Delay(4000);

            L.openG();
            await Task.Delay(600);

            //Move out vertically 
            Position = L.DegToRad(-64.32, -145.37, -61.29, -151.09, 114.39, 182.92);
            norm = "movel([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            await Task.Delay(4000);

            L.closeG();

            Position = L.DegToRad(-90, -90, -90, -90, 0, -0);
            norm = "movej([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            MessageBox.Show("Put back hook done");
        }

        //Pull out book function
        public async void PullOutBook(int i)
        {
            StandbyPosition();


        }

        ////////////////////////////////////////////////Declare function of robot arm//////////////////////////////////////////////
        ////////////////////////////////////////////////Declare delegate function//////////////////////////////////////////////
        public delegate void DelegateAddListItem(string name);
        public Form1()
        {
            InitializeComponent();
            ////////////////////////////////////////////////Scan Mode////////////////////////////////////////////////
            Thread readerActivateScan = new Thread(ReadThread);
            readerActivateScan.Start();
            ////////////////////////////////////////////////Scan Mode////////////////////////////////////////////////

            ////////////////////////////////////////////////Lisbox List Item/////////////////////////////////////////
            for (int i = 0; i < bookTag.Length; i++)
            {
                listBoxSequence.Items.Add(bookTag[i]);
            }
            ////////////////////////////////////////////////Lisbox List Item/////////////////////////////////////////

            while (true)
            {
                try
                {
                    //Do Connection to robot arm
                    //Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    con.Connect(HostIpAdrress, PortNumber);
                    connectToRobotArmToolStripMenuItem.Text = "Disconnect to Reader";
                    labelRobotArmConnection.Text = "Connected";
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please ensure you connect to the robot arm");
                    Console.WriteLine(ex);
                }
            }

        }

        public void ConnectRobotArmTCP(string HostIpAdrress, int PortNumber)
        {
            //try
            //{
            //    Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //    con.Connect(HostIpAdrress, PortNumber);
            //    if (con.Connected)
            //    {
            //        connectToRobotArmToolStripMenuItem.Text = "Disconnect to Reader";
            //        labelRobotArmConnection.Text = "Connected";
            //    }
            //    else
            //    {
            //        MessageBox.Show("No Connection.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Please connect to Reader");
            //}

        }

        public void DisconnectRobotArmTCP(string HostIpAdrress, int PortNumber)
        {
            Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            con.Close();
            if (!con.Connected)
            {
                connectToRobotArmToolStripMenuItem.Text = "Connect to Reader";
                labelRobotArmConnection.Text = "Disconnect";
            }
            
        }
        //Declare connection function

        
        
        //RFID Function
        private void ReadThread()
        {
            //declaration from delegateobject

            while (true)
            {
                if (running == true)
                {
                    try
                    {
                        reader.SetData(FedmIscReaderID.FEDM_ISC_TMP_B0_CMD, 0x01);
                        reader.SetData(FedmIscReaderID.FEDM_ISC_TMP_B0_MODE, 0x00);
                        int back = reader.SetTableSize(FedmIscReaderConst.ISO_TABLE, 128);
                        String[] tagType = null;
                        String[] serialNumber = null;

                        back = reader.ResetTable(FedmIscReaderConst.ISO_TABLE);
                        back = reader.SendProtocol(0x69); // RFReset
                        System.Console.Write("RF-Reset: ");
                        System.Console.WriteLine(reader.GetErrorText(back));
                        back = reader.SendProtocol(0xB0); // ISOCmd
                        System.Console.Write("Inventory: ");

                        if (back < 0)
                        {
                            System.Console.WriteLine(reader.GetErrorText(back));
                        }
                        else
                        {
                            System.Console.WriteLine(reader.GetStatusText((byte)back));
                        }

                        while (reader.GetLastStatus() == 0x94) // more flag set?
                        {
                            reader.SetData(FedmIscReaderID.FEDM_ISC_TMP_B0_MODE_MORE, 0x01);
                            reader.SendProtocol(0xB0);
                        }

                        int length = reader.GetTableLength(FedmIscReaderConst.ISO_TABLE);
                        serialNumber = new String[length];
                        tagType = new String[length];

                        Console.WriteLine(reader.GetTableLength(FedmIscReaderConst.ISO_TABLE));

                        if (length > 0)
                        {
                            int i;
                            for (i = 0; i < reader.GetTableLength(FedmIscReaderConst.ISO_TABLE); i++)
                            {
                                reader.GetTableData(i, FedmIscReaderConst.ISO_TABLE, FedmIscReaderConst.DATA_SNR, out serialNumber[i]);
                                reader.GetTableData(i, FedmIscReaderConst.ISO_TABLE, FedmIscReaderConst.DATA_TRTYPE, out tagType[i]);
                                if (tagType[i].Equals("00")) tagType[i] = "Philips I-Code1";
                                if (tagType[i].Equals("01")) tagType[i] = "Texas Instruments Tag-it HF";
                                if (tagType[i].Equals("03")) tagType[i] = "ISO15693 Transponder";
                                if (tagType[i].Equals("04")) tagType[i] = "14443A";
                                if (tagType[i].Equals("05")) tagType[i] = "14443B";
                                if (tagType[i].Equals("06")) tagType[i] = "EPC";
                                Console.WriteLine(serialNumber[i]);
                                foreach (string tagNumber in serialNumber)
                                {
                                    AddListItem(tagNumber);
                                }
                                
                            }

                        }

                    }

                    catch
                    {

                    }
                }
                else
                {

                }
            }
        }

        //Delegate function for add tag to list
        private void AddListItem(string tagNum)
        {
            if (InvokeRequired)
            {
                DelegateAddListItem d = new DelegateAddListItem(AddListItem);
                this.Invoke(d, new object[] { tagNum });
            }
            else
            {
                try
                {
                    var selIndex = listBoxSearchItem.SelectedIndex;

                    if (!listBoxSearchItem.Items.Contains(tagNum))
                    {
                        listBoxSearchItem.Items.Add(tagNum);
                        labelItemFoundCount.Text = listBoxSearchItem.Items.Count.ToString() + " Founds";
                    }
                    else
                    {
                        Console.WriteLine("item existed");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }
        }
        //RFID Function


        private void button3_Click(object sender, EventArgs e)
        {
            L.openG();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            L.closeG();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void connectToRobotArmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //connection for robot arm via TCP/IP
            ConnectRobotArmTCP(HostIpAdrress, PortNumber);
        }

        private void labelRobotArmConnection_DoubleClick(object sender, EventArgs e)
        {
            DisconnectRobotArmTCP(HostIpAdrress, PortNumber);           
        }

        private void connectToGripperToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private FedmIscReader reader;
        private void conncetToScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reader = new FedmIscReader();
            L.ConnectScanner(reader);
            if(reader.Connected)
            {
                labelScannerConnection.Text = "Connected";
                conncetToScannerToolStripMenuItem.Text = "Disconnect to Scanner";
            }
            else
            {
                MessageBox.Show("Please connect scanner");
            }
        }


        private void labelScannerConnection_DoubleClick(object sender, EventArgs e)
        {
            reader = new FedmIscReader();
            L.DisconnectScanner(reader);
            labelScannerConnection.Text = "Disconnect";
            conncetToScannerToolStripMenuItem.Text = "Connect to Scanner";
        }

        private void buttonScanMode_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelScannerConnection.Text == "Disconnect")
                {
                    MessageBox.Show("Connect to Scanner");
                }
                else
                {
                    if (buttonScanMode.Text == "Scan Mode")
                    {
                        running = true;
                        buttonScanMode.Text = "Scanning...";
                        buttonScanMode.Enabled = false;
                        buttonStopScan.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void buttonStopScan_Click(object sender, EventArgs e)
        {
            try
            {
                if(buttonStopScan.Text == "Stop scanning")
                {
                    running = false;
                    buttonScanMode.Text = "Scan Mode";
                    buttonScanMode.Enabled = true;
                    buttonStopScan.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void buttonResetLeft_Click(object sender, EventArgs e)
        {
            listBoxSearchItem.Items.Clear();
            labelItemFoundCount.Text = "0 Found";
        }

        private void buttonResetRight_Click(object sender, EventArgs e)
        {
            listBoxSequence.Items.Clear();
        }

        private void buttonOriginalPos_Click(object sender, EventArgs e)
        {
            OriginalPosition();
        }

        private void buttonReadyPosition_Click(object sender, EventArgs e)
        {
            ReadyPosition();
        }

        private void buttonShelf1Left_Click(object sender, EventArgs e)
        {
            Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            con.Connect(HostIpAdrress, PortNumber);
            string Position = L.DegToRad(-99.77, -178.88, -34.99, -151.67, -9.87, 187.06);

            norm = "movel([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            MessageBox.Show(norm);
        }

        private void buttonShelf1Right_Click(object sender, EventArgs e)
        {
            Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            con.Connect(HostIpAdrress, PortNumber);
            string Position = L.DegToRad(-242.20, -173.65, -47.30, -141.24, -152.20, 179.64);

            norm = "movel([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            MessageBox.Show(norm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string Position = L.DegToRad(-90, -90, -90, -90, 0, -0);
            //norm = "movel([" + Position + "]," + speedHigh;
            //bytes = Encoding.UTF8.GetBytes(norm);
            //con.Send(bytes);
            MessageBox.Show(norm);
        }

        private void buttonShelf2Left_Click(object sender, EventArgs e)
        {
            Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            con.Connect(HostIpAdrress, PortNumber);
            string Position = L.DegToRad(-99.77, -151.53, -44.68, -168.71, -9.84, 186.51);

            norm = "movel([" + Position + "], a =  0.2, v = 1.5, r = 0)" + "\n";
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            MessageBox.Show(norm);
        }

        private void buttonShelf2Right_Click(object sender, EventArgs e)
        {
            Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            con.Connect(HostIpAdrress, PortNumber);
            string Position = L.DegToRad(-241.04, -141.85, -63.70, -156.66, -151.09, 179.72);

            norm = "movel([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            MessageBox.Show(norm);
        }

        private void buttonShelf3Left_Click(object sender, EventArgs e)
        {
            Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            con.Connect(HostIpAdrress, PortNumber);
            string Position = L.DegToRad(-100.77, -134.97, -32.34, -197.61, -10.93, 185.30);

            norm = "movel([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            MessageBox.Show(norm);
        }

        private void buttonShelf3Right_Click(object sender, EventArgs e)
        {
            Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            con.Connect(HostIpAdrress, PortNumber);
            string Position = L.DegToRad(-241.77, -141.31, -20.64, -200.74, -151.85, 178.03);

            norm = "movel([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            MessageBox.Show(norm);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxSequence_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGoToPosistion_Click(object sender, EventArgs e)
        {
            if (comboBoxBookIndex.Text == "1")
            {
                Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                con.Connect(HostIpAdrress, PortNumber);
                string Position = L.meterToMm(-478.32, -328.67 + (bookthickness[0] / 2), 602.92, 1.2826, -1.1696, -1.2002);

                norm = "movel(p[" + Position + "]," + speedHigh;
                bytes = Encoding.UTF8.GetBytes(norm);
                con.Send(bytes);
                MessageBox.Show(norm);
            }
            else if (comboBoxBookIndex.Text == "2")
            {
                Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                con.Connect(HostIpAdrress, PortNumber);
                string Position = L.meterToMm(-478.32, -328.67 + bookthickness[0] + (bookthickness[1] / 2), 602.92, 1.2826, -1.1696, -1.2002);

                norm = "movel(p[" + Position + "]," + speedHigh;
                bytes = Encoding.UTF8.GetBytes(norm);
                con.Send(bytes);
                MessageBox.Show(norm);
            }
            else if (comboBoxBookIndex.Text == "3")
            {
                Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                con.Connect(HostIpAdrress, PortNumber);
                string Position = L.meterToMm(-478.32, -328.67 + bookthickness[0] + bookthickness[1] +(bookthickness[2] / 2), 602.92, 1.2826, -1.1696, -1.2002);

                norm = "movel(p[" + Position + "]," + speedHigh;
                bytes = Encoding.UTF8.GetBytes(norm);
                con.Send(bytes);
                MessageBox.Show(norm);
            }
            else if (comboBoxBookIndex.Text == "4")
            {
                Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                con.Connect(HostIpAdrress, PortNumber);
                string Position = L.meterToMm(-478.32, -328.67 + bookthickness[0] + bookthickness[1] + bookthickness[2] + (bookthickness[3] / 2), 602.92, 1.2826, -1.1696, -1.2002);

                norm = "movel(p[" + Position + "]," + speedHigh;
                bytes = Encoding.UTF8.GetBytes(norm);
                con.Send(bytes);
                MessageBox.Show(norm);
            }
            else if (comboBoxBookIndex.Text == "5")
            {
                Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                con.Connect(HostIpAdrress, PortNumber);
                string Position = L.meterToMm(-478.32, -328.67 + bookthickness[0] + bookthickness[1] + bookthickness[2] + bookthickness[3] + (bookthickness[4] / 2), 602.92, 1.2826, -1.1696, -1.2002);

                norm = "movel(p[" + Position + "]," + speedHigh;
                bytes = Encoding.UTF8.GetBytes(norm);
                con.Send(bytes);
                MessageBox.Show(norm);
            }
            else
            {
                MessageBox.Show("Please select valid index");
            }
        }

        private void buttonGoToOriginal_Click(object sender, EventArgs e)
        {
            Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            con.Connect(HostIpAdrress, PortNumber);
            string Position = L.meterToMm(-476.35, -318.96, 377.32, 2.3577, 2.4255, -2.4040);

            norm = "movel(p[" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            MessageBox.Show(norm);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (labelItemFoundCount.Text == "5 Founds")
            {
                if (listBoxSequence.Items[0].ToString().Substring(0, 16) == listBoxSearchItem.Items[0].ToString())
                {
                    MessageBox.Show(listBoxSequence.Items[0].ToString() + " found");
                    if (listBoxSequence.Items[1].ToString().Substring(0, 16) == listBoxSearchItem.Items[1].ToString())
                    {
                        MessageBox.Show(listBoxSequence.Items[1].ToString() + " found");
                        if(listBoxSequence.Items[2].ToString().Substring(0, 16) == listBoxSearchItem.Items[2].ToString())
                        {
                            MessageBox.Show(listBoxSequence.Items[2].ToString() + " found");
                            if(listBoxSequence.Items[3].ToString().Substring(0, 16) == listBoxSearchItem.Items[3].ToString())
                            {
                                MessageBox.Show(listBoxSequence.Items[3].ToString() + " found");
                                if(listBoxSequence.Items[4].ToString().Substring(0, 16) == listBoxSearchItem.Items[4].ToString())
                                {
                                    MessageBox.Show(listBoxSequence.Items[4].ToString() + " found");
                                }else
                                {
                                    ////////////////////////////////////book[4] not found do something//////////////////////////////////
                                    MessageBox.Show(listBoxSequence.Items[4].ToString().Substring(0, 16) + "not found");
                                    for (int i = 0; i < listBoxSearchItem.Items.Count; i++)
                                    {
                                        var valid = listBoxSearchItem.Items[i].Equals(listBoxSequence.Items[4].ToString().Substring(0, 16));
                                        if (valid == true)
                                        {
                                            int indexOfMisplaceBook = listBoxSearchItem.Items.IndexOf(listBoxSequence.Items[4].ToString().Substring(0, 16));
                                            MessageBox.Show("Misplace Book are located in position " + (indexOfMisplaceBook + 1).ToString());
                                        }
                                    }
                                }
                            }else
                            {
                                ////////////////////////////////////book[3] not found do something//////////////////////////////////
                                MessageBox.Show(listBoxSequence.Items[3].ToString().Substring(0, 16) + "not found");
                                for (int i = 0; i < listBoxSearchItem.Items.Count; i++)
                                {
                                    var valid = listBoxSearchItem.Items[i].Equals(listBoxSequence.Items[3].ToString().Substring(0, 16));
                                    if (valid == true)
                                    {
                                        int indexOfMisplaceBook = listBoxSearchItem.Items.IndexOf(listBoxSequence.Items[3].ToString().Substring(0, 16));
                                        MessageBox.Show("Misplace Book are located in position " + (indexOfMisplaceBook + 1).ToString());
                                    }
                                }
                            }
                        }
                        else
                        {
                            ////////////////////////////////////book[2] not found do something//////////////////////////////////
                            MessageBox.Show(listBoxSequence.Items[2].ToString().Substring(0, 16) + "not found");
                            for (int i = 0; i < listBoxSearchItem.Items.Count; i++)
                            {
                                var valid = listBoxSearchItem.Items[i].Equals(listBoxSequence.Items[2].ToString().Substring(0, 16));
                                if (valid == true)
                                {
                                    int indexOfMisplaceBook = listBoxSearchItem.Items.IndexOf(listBoxSequence.Items[2].ToString().Substring(0, 16));
                                    MessageBox.Show("Misplace Book are located in position " + (indexOfMisplaceBook + 1).ToString());
                                }
                            }
                        }
                    }
                    else
                    {
                        ////////////////////////////////////book[1] not found do something//////////////////////////////////
                        MessageBox.Show(listBoxSequence.Items[1].ToString().Substring(0, 16) + "not found");
                        for (int i = 0; i < listBoxSearchItem.Items.Count; i++)
                        {
                            var valid = listBoxSearchItem.Items[i].Equals(listBoxSequence.Items[1].ToString().Substring(0, 16));
                            if (valid == true)
                            {
                                int indexOfMisplaceBook = listBoxSearchItem.Items.IndexOf(listBoxSequence.Items[1].ToString().Substring(0, 16));
                                MessageBox.Show("Misplace Book are located in position " + (indexOfMisplaceBook + 1).ToString());
                            }
                        }
                    }
                }
                else
                {
                    ////////////////////////////////////book[0] not found do something//////////////////////////////////
                    MessageBox.Show(listBoxSequence.Items[0].ToString().Substring(0, 16) + "not found");
                    for(int i = 0; i<listBoxSearchItem.Items.Count; i++)
                    {
                        var valid = listBoxSearchItem.Items[i].Equals(listBoxSequence.Items[0].ToString().Substring(0, 16));
                        if (valid == true)
                        {
                            int indexOfMisplaceBook = listBoxSearchItem.Items.IndexOf(listBoxSequence.Items[0].ToString().Substring(0, 16));
                            MessageBox.Show("Misplace Book are located in position " + (indexOfMisplaceBook+1).ToString());
                        }
                    }
                    
                   
                    ////////////////////////////////////book[0] not found do something//////////////////////////////////
                }
            }
            else
            {
                int foundBook = int.Parse(labelItemFoundCount.Text.Substring(0, 1));
                int bookNotFound = 5 - foundBook;
                MessageBox.Show(bookNotFound.ToString() +" more book not found. " );
            } 
        }

        private void buttonPickUpHook_Click(object sender, EventArgs e)
        {
            PickUpHook();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            L.initiate();
        }

        private void buttonStandbyPosition_Click(object sender, EventArgs e)
        {
            StandbyPosition();
            
        }

        private void buttonPutBackHook_Click(object sender, EventArgs e)
        {
            PutBackHook();
        }

        private async void buttonPickUpBook_Click(object sender, EventArgs e)
        {
            Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            con.Connect(HostIpAdrress, PortNumber);

            if (comboBoxPickUpBook.Text == "1")
            {
                string Position = L.meterToMm(-478.32, -328.67 + (bookthickness[0] / 2), 602.92, 1.2826, -1.1696, -1.2002);

                norm = "movel(p[" + Position + "]," + speedHigh;
                bytes = Encoding.UTF8.GetBytes(norm);
                con.Send(bytes);
                MessageBox.Show(norm);


            }
            else if (comboBoxPickUpBook.Text == "2")
            {
                string Position = L.meterToMm(-478.32, -328.67 + bookthickness[0] + (bookthickness[1] / 2), 602.92, 1.2826, -1.1696, -1.2002);

                norm = "movel(p[" + Position + "]," + speedHigh;
                bytes = Encoding.UTF8.GetBytes(norm);
                con.Send(bytes);
                await Task.Delay(4000);

                Position = L.meterToMm(-607.58, -328.67 + bookthickness[0] + (bookthickness[1] / 2), 602.92, 1.2826, -1.1696, -1.2002);
                norm = "movel(p[" + Position + "]," + speedHigh;
                bytes = Encoding.UTF8.GetBytes(norm);
                con.Send(bytes);
                await Task.Delay(3500);

                Position = L.meterToMm(-607.58, -328.67 + bookthickness[0] + (bookthickness[1] / 2), 533.34, 1.2826, -1.1696, -1.2002);
                norm = "movel(p[" + Position + "]," + speedHigh;
                bytes = Encoding.UTF8.GetBytes(norm);
                con.Send(bytes);
                await Task.Delay(2500);

                Position = L.meterToMm(-490, -328.67 + bookthickness[0] + (bookthickness[1] / 2), 533.34, 1.2826, -1.1696, -1.2002);
                norm = "movel(p[" + Position + "]," + speedHigh;
                bytes = Encoding.UTF8.GetBytes(norm);
                con.Send(bytes);
                await Task.Delay(2500);

                Position = L.meterToMm(-490, -328.67 + bookthickness[0] + (bookthickness[1] / 2), 608.55, 1.2826, -1.1696, -1.2002);
                norm = "movel(p[" + Position + "], a =  0.05, v = 0.5, r = 0)" + "\n";
                bytes = Encoding.UTF8.GetBytes(norm);
                con.Send(bytes);
                await Task.Delay(2500);

                Position = L.DegToRad(-90, -90, -90, -90, 0, -0);
                norm = "movel([" + Position + "]," + speedHigh;
                bytes = Encoding.UTF8.GetBytes(norm);
                con.Send(bytes);
                MessageBox.Show("Completed.");

            }
            else if (comboBoxPickUpBook.Text == "3")
            {
                string Position = L.meterToMm(-478.32, -328.67 + bookthickness[0] + bookthickness[1] + (bookthickness[2] / 2), 602.92, 1.2826, -1.1696, -1.2002);

                norm = "movel(p[" + Position + "]," + speedHigh;
                bytes = Encoding.UTF8.GetBytes(norm);
                con.Send(bytes);
                MessageBox.Show(norm);
            }
            else if (comboBoxPickUpBook.Text == "4")
            {
                string Position = L.meterToMm(-478.32, -328.67 + bookthickness[0] + bookthickness[1] + bookthickness[2] + (bookthickness[3] / 2), 602.92, 1.2826, -1.1696, -1.2002);

                norm = "movel(p[" + Position + "]," + speedHigh;
                bytes = Encoding.UTF8.GetBytes(norm);
                con.Send(bytes);
                MessageBox.Show(norm);
            }
            else if (comboBoxPickUpBook.Text == "5")
            {
                string Position = L.meterToMm(-478.32, -328.67 + bookthickness[0] + bookthickness[1] + bookthickness[2] + bookthickness[3] + (bookthickness[4] / 2), 602.92, 1.2826, -1.1696, -1.2002);

                norm = "movel(p[" + Position + "]," + speedHigh;
                bytes = Encoding.UTF8.GetBytes(norm);
                con.Send(bytes);
                MessageBox.Show(norm);
            }
            else
            {
                MessageBox.Show("Please select valid index");
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            con.Connect(HostIpAdrress, PortNumber);
            string Position = L.meterToMm(-478.32, -328.67 + bookthickness[0] + (bookthickness[1] / 2), 602.92, 1.2826, -1.1696, -1.2002);

            norm = "movel(p[" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            MessageBox.Show(norm);

            Position = L.meterToMm(-520, -328.67 + bookthickness[0] + (bookthickness[1] / 2), 602.92, 1.2826, -1.1696, -1.2002);
            norm = "movel(p[" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            MessageBox.Show(norm);
            //openG
            L.openG();

            Position = L.meterToMm(-521.48, -328.67 + bookthickness[0] + (bookthickness[1] / 2), 412.39, 1.2409, -1.1788, -1.1775);
            norm = "movel(p[" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            MessageBox.Show(norm);

            //CloseG
            L.closeG();
            MessageBox.Show(norm);

            //Carry Book Out of the book[2]
            Position = L.meterToMm(-177.53, -258.77, 416.83, 1.2341, -1.1602, -1.1938);
            norm = "movel(p[" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            MessageBox.Show(norm);

            //Rotation for arm to fit box
            Position = L.meterToMm(79.92, -294.00, 255.31, 2.2194, -2.1843, 0.1190);
            norm = "movel(p[" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            MessageBox.Show(norm);

            //go down to prepare drop book
            Position = L.DegToRad(-57.1, -131.88, -26.64, 170.27, -89.93, -56.13);
            norm = "movel([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);
            MessageBox.Show(norm);

            L.openG();
            MessageBox.Show("Done");
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            //Socket con = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //con.Connect(HostIpAdrress, PortNumber);
            //string Position = L.meterToMm(-292.92, -314.45, 616.8, 1.2500, -1.1663, -1.1481);
            //norm = "movel(p[" + Position + "], a =  0.01, v = 0.1, r = 0)" + "\n";
            //bytes = Encoding.UTF8.GetBytes(norm);
            //con.Send(bytes);
            //MessageBox.Show(norm);


            //L.openG();
            //MessageBox.Show("open");
            ////GO down to pick up book
            //Position = L.meterToMm(72.95, -320.80, -211.20, 2.2743, -2.1846, -0.09);
            //norm = "movel(p[" + Position + "], a =  0.01, v = 0.1, r = 0)" + "\n";
            //bytes = Encoding.UTF8.GetBytes(norm);
            //con.Send(bytes);
            //MessageBox.Show(norm);
            //L.closeG();
            Position = L.DegToRad(-57.1, -131.88, -126.64, 170.27, -89.93, -56.13);
            norm = "movel([" + Position + "]," + speedHigh;
            bytes = Encoding.UTF8.GetBytes(norm);
            con.Send(bytes);

        }

        private async void buttonPickDrop_Click(object sender, EventArgs e)
        {
            //comboBookIndex matching
            if(comboBoxBookIndex.Text == "1")
            {

                ReadyPosition();

                PickUpHook();


                
            }
        }
    }
}
