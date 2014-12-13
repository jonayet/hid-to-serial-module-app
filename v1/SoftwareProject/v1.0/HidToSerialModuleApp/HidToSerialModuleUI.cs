using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using INFRA.USB;
using INFRA.USB.HidHelper;
using INFRA.USB.HidToSerialHelper;

namespace HidToSerialModuleApp
{
    public partial class HidToSerialModuleUI : Form
    {
        private HidToSerialDevice hidToSerialDevice;

        public HidToSerialModuleUI()
        {
            InitializeComponent();

            hidToSerialDevice = new HidToSerialDevice(0x1FBD, 0x0005);
            hidToSerialDevice.HidDevice.OnDeviceAttached += new EventHandler(hidDevice1_OnDeviceAttached);
            hidToSerialDevice.HidDevice.OnDeviceRemoved += new EventHandler(hidDevice1_OnDeviceRemoved);
            hidToSerialDevice.HidDevice.OnReportReceived += hidDevice_OnReportReceived;
            hidToSerialDevice.HidDevice.Connect();

            hostTransmissionTypeComboBox.DataSource = Enum.GetNames(typeof (HostTransmisionType));

            foreach (HidDevice hidDevice in HidManager.GetDeviceList())
            {
                hidDeviceListComboBox.Items.Add(hidDevice.ProductName + " - (VID: " + hidDevice.VendorID + ", PID: " + hidDevice.ProductID + ")");
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (!hidToSerialDevice.HidDevice.IsAttached)
            {
                MessageBox.Show("Sorry but your device is not present. Plug it in!! ");
                return;
            }
            bool success;

            byte[] dataBytes = Encoding.ASCII.GetBytes(hostDataTextBox.Text);
            HostTransmisionType selectedTransmisionType =
                (HostTransmisionType)
                    Enum.Parse(typeof(HostTransmisionType), hostTransmissionTypeComboBox.SelectedItem.ToString());
            switch (selectedTransmisionType)
            {
                case HostTransmisionType.BAUDRATE_CMD_FROM_HOST:
                    int baudRateIndex = Convert.ToInt16(hostBaudRateIndexTextBox.Text);
                    string resp;
                    success = hidToSerialDevice.SetBaudRate(baudRateIndex, out resp);
                    deviceDataTextBox.Text = resp;
                    break;

                case HostTransmisionType.SINGLE_QUERY_FROM_HOST:
                    int expectedDataLength = Convert.ToInt16(hostExpectedDataLengthTextBox.Text);
                    int timeout = Convert.ToInt16(hostTimeoutTextBox.Text);

                    SingleResponse_FromDevice qResp;
                    success = hidToSerialDevice.SingleQuery(new byte[] { Convert.ToByte(hostDataTextBox.Text) }, expectedDataLength, timeout, out qResp);
                    string qRespText = BitConverter.ToString(qResp.Data).Replace("-", ",");
                    deviceDataTextBox.Text = qRespText;
                    break;

                case HostTransmisionType.SYNC_OUT_DATA_FROM_HOST:
                    int thisSegmentDataLength;
                    int noOfRemainingPackets;
                    int lastPacketLength;

                    //if (!isSyncPacketPending)
                    //{
                    //    isSyncPacketPending = hidDevice.SpecifiedDevice.SendSyncOutPackets(dataBytes, true,
                    //        out thisSegmentDataLength,
                    //        out noOfRemainingPackets, out lastPacketLength);
                    //}
                    //else
                    //{
                    //    isSyncPacketPending = hidDevice.SpecifiedDevice.SendSyncOutPackets(dataBytes, false,
                    //        out thisSegmentDataLength,
                    //        out noOfRemainingPackets, out lastPacketLength);
                    //}

                    // update ui
                    //hostThisSegmentLengthTextBox.Text = thisSegmentDataLength.ToString();
                    //hostNoOfRemainingPacketsTextBox.Text = noOfRemainingPackets.ToString();
                    //hostLastPacketLengthTextBox.Text = lastPacketLength.ToString();
                    break;

                case HostTransmisionType.SYNC_IN_START_FROM_HOST:
                    timeout = Convert.ToInt16(hostTimeoutTextBox.Text);
                    //hidDevice.SpecifiedDevice.SendSyncInStartPacket(timeout);
                    break;

                case HostTransmisionType.SYNC_IN_READ_FROM_HOST:
                    //hidDevice.SpecifiedDevice.SendSyncInReadPacket();
                    break;

                case HostTransmisionType.SYNC_IN_ACK_FROM_HOST:
                    int hostAckByte = Convert.ToInt16(hostAckByteTextBox.Text);
                    //hidDevice.SpecifiedDevice.SendSyncInAckPacket(hostAckByte);
                    break;

                case HostTransmisionType.ASYNC_OUT_FROM_HOST:
                    //hidDevice.SpecifiedDevice.SendAsyncOutPacket(dataBytes);
                    break;
                case HostTransmisionType.ASYNC_IN_START_FROM_HOST:
                    int requiredDataLength = Convert.ToInt16(hostRequiredDataLengthTextBox.Text);
                    timeout = Convert.ToInt16(hostTimeoutTextBox.Text);
                    //hidDevice.SpecifiedDevice.SendAsyncInStartPacket(requiredDataLength, timeout);
                    break;

                case HostTransmisionType.ASYNC_IN_STOP_FROM_HOST:
                    //hidDevice.SpecifiedDevice.SendAsyncInStopPacket();
                    break;
            }

            //deviceTransmissionTypeTextBox.Text = "";
            //deviceDataTextBox.Text = "";
            //deviceThisSegmentLengthTextBox.Text = "";
            //deviceNoOfRemainingPacketsTextBox.Text = "";
            //deviceLastPacketLengthTextBox.Text = "";
            //deviceAckByteTextBox.Text = "";
        }

        void hidDevice_OnReportReceived(object sender, ReportRecievedEventArgs e)
        {
            if (InvokeRequired)
            {
                //Invoke(new DataRecievedEventHandler(hidDevice1_OnDataRecieved), new[] { sender, args });
            }
            else
            {
                //if (args.DeviceTransmisionType == DeviceTransmisionType.BAUDRATE_RESP_FROM_DEVICE)
                //{
                //    BaudRateResponse_FromDevice baudRateResponse = args.PacketData as BaudRateResponse_FromDevice;
                //    deviceTransmissionTypeTextBox.Text = baudRateResponse.DeviceTransmisionType.ToString();
                //    deviceDataTextBox.Text = Encoding.ASCII.GetString(baudRateResponse.DataBytes);
                //}
                //else if (args.DeviceTransmisionType == DeviceTransmisionType.SINGLE_RESPONSE_FROM_DEVICE)
                //{
                //    SingleResponse_FromDevice singleResponsePacket = args.PacketData as SingleResponse_FromDevice;
                //    deviceTransmissionTypeTextBox.Text = singleResponsePacket.DeviceTransmisionType.ToString();
                //    deviceThisSegmentLengthTextBox.Text = singleResponsePacket.ThisSegmentDataLength.ToString();
                //    deviceDataTextBox.Text = Encoding.ASCII.GetString(singleResponsePacket.DataBytes);
                //}
                //else if (args.DeviceTransmisionType == DeviceTransmisionType.SYNC_OUT_ACK_FROM_DEVICE)
                //{
                //    SyncOutAck_FromDevice syncOutAckPacket = args.PacketData as SyncOutAck_FromDevice;
                //    deviceTransmissionTypeTextBox.Text = syncOutAckPacket.DeviceTransmisionType.ToString();
                //    deviceAckByteTextBox.Text = syncOutAckPacket.DeviceAckByte.ToString();
                //}
                //else if (args.DeviceTransmisionType == DeviceTransmisionType.ASYNC_IN_DATA_FROM_DEVICE)
                //{
                //    AsyncInData_FromDevice asyncInDataPacket = args.PacketData as AsyncInData_FromDevice;
                //    deviceTransmissionTypeTextBox.Text = asyncInDataPacket.DeviceTransmisionType.ToString();
                //    deviceThisSegmentLengthTextBox.Text = asyncInDataPacket.ThisSegmentDataLength.ToString();
                //    deviceDataTextBox.Text = Encoding.ASCII.GetString(asyncInDataPacket.DataBytes);
                //}
                //else if (args.DeviceTransmisionType == DeviceTransmisionType.SYNC_IN_DATA_FROM_DEVICE)
                //{
                //    SyncInData_FromDevice syncInDataPacket = args.PacketData as SyncInData_FromDevice;
                //    deviceTransmissionTypeTextBox.Text = syncInDataPacket.DeviceTransmisionType.ToString();
                //    deviceThisSegmentLengthTextBox.Text = syncInDataPacket.ThisSegmentDataLength.ToString();
                //    deviceNoOfRemainingPacketsTextBox.Text = syncInDataPacket.NoOfRemainingPackets.ToString();
                //    deviceLastPacketLengthTextBox.Text = syncInDataPacket.LastPacketLength.ToString();
                //    deviceThisSegmentLengthTextBox.Text = syncInDataPacket.ThisSegmentDataLength.ToString();
                //    deviceAckByteTextBox.Text = syncInDataPacket.HostAckByte.ToString();
                //    deviceDataTextBox.Text = Encoding.ASCII.GetString(syncInDataPacket.DataBytes);
                //}
                //else
                //{
                //    MessageBox.Show(args.DeviceTransmisionType.ToString());
                //}
            }
        }

        void hidDevice1_OnDeviceAttached(object sender, EventArgs e)
        {
            ThreadHelperClass.SetText(this, deviceConnectedLabel, "Connected");
        }

        void hidDevice1_OnDeviceRemoved(object sender, EventArgs e)
        {
            ThreadHelperClass.SetText(this, deviceConnectedLabel, "Not Connected");
        }

        private void hostDataTextBox_TextChanged(object sender, EventArgs e)
        {
            hostThisSegmentLengthTextBox.Text = hostDataTextBox.Text.Length.ToString();
        }
    }
}
