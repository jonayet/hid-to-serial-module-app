namespace HidToSerialModuleApp
{
    partial class HidToSerialModuleUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deviceConnectedLabel = new System.Windows.Forms.Label();
            this.deviceDataTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.hostDataTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.hostBaudRateIndexTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.hostRequiredDataLengthTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.hostTimeoutTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.hostExpectedDataLengthTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hostAckByteTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hostTransmissionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.hostLastPacketLengthTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hostNoOfRemainingPacketsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hostThisSegmentLengthTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deviceTransmissionTypeTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.deviceAckByteTextBox = new System.Windows.Forms.TextBox();
            this.deviceLastPacketLengthTextBox = new System.Windows.Forms.TextBox();
            this.deviceThisSegmentLengthTextBox = new System.Windows.Forms.TextBox();
            this.deviceNoOfRemainingPacketsTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.hidDeviceListComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceConnectedLabel
            // 
            this.deviceConnectedLabel.Location = new System.Drawing.Point(473, 23);
            this.deviceConnectedLabel.Name = "deviceConnectedLabel";
            this.deviceConnectedLabel.Size = new System.Drawing.Size(81, 23);
            this.deviceConnectedLabel.TabIndex = 0;
            this.deviceConnectedLabel.Text = "Not Connected";
            this.deviceConnectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deviceDataTextBox
            // 
            this.deviceDataTextBox.Location = new System.Drawing.Point(221, 52);
            this.deviceDataTextBox.Multiline = true;
            this.deviceDataTextBox.Name = "deviceDataTextBox";
            this.deviceDataTextBox.ReadOnly = true;
            this.deviceDataTextBox.Size = new System.Drawing.Size(333, 98);
            this.deviceDataTextBox.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(479, 21);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // hostDataTextBox
            // 
            this.hostDataTextBox.Location = new System.Drawing.Point(221, 53);
            this.hostDataTextBox.Multiline = true;
            this.hostDataTextBox.Name = "hostDataTextBox";
            this.hostDataTextBox.Size = new System.Drawing.Size(333, 223);
            this.hostDataTextBox.TabIndex = 3;
            this.hostDataTextBox.TextChanged += new System.EventHandler(this.hostDataTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.hostBaudRateIndexTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.hostRequiredDataLengthTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.hostTimeoutTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.hostExpectedDataLengthTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hostAckByteTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.hostTransmissionTypeComboBox);
            this.groupBox1.Controls.Add(this.hostLastPacketLengthTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.hostNoOfRemainingPacketsTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.hostThisSegmentLengthTextBox);
            this.groupBox1.Controls.Add(this.hostDataTextBox);
            this.groupBox1.Controls.Add(this.sendButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 287);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From Host";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(50, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "BaudRate Index:";
            // 
            // hostBaudRateIndexTextBox
            // 
            this.hostBaudRateIndexTextBox.Location = new System.Drawing.Point(145, 256);
            this.hostBaudRateIndexTextBox.Name = "hostBaudRateIndexTextBox";
            this.hostBaudRateIndexTextBox.Size = new System.Drawing.Size(60, 20);
            this.hostBaudRateIndexTextBox.TabIndex = 18;
            this.hostBaudRateIndexTextBox.Text = "9";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Required Data Length:";
            // 
            // hostRequiredDataLengthTextBox
            // 
            this.hostRequiredDataLengthTextBox.Location = new System.Drawing.Point(145, 227);
            this.hostRequiredDataLengthTextBox.Name = "hostRequiredDataLengthTextBox";
            this.hostRequiredDataLengthTextBox.Size = new System.Drawing.Size(60, 20);
            this.hostRequiredDataLengthTextBox.TabIndex = 16;
            this.hostRequiredDataLengthTextBox.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(89, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Timeout:";
            // 
            // hostTimeoutTextBox
            // 
            this.hostTimeoutTextBox.Location = new System.Drawing.Point(145, 140);
            this.hostTimeoutTextBox.Name = "hostTimeoutTextBox";
            this.hostTimeoutTextBox.Size = new System.Drawing.Size(60, 20);
            this.hostTimeoutTextBox.TabIndex = 14;
            this.hostTimeoutTextBox.Text = "3000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Expected Data Length:";
            // 
            // hostExpectedDataLengthTextBox
            // 
            this.hostExpectedDataLengthTextBox.Location = new System.Drawing.Point(145, 198);
            this.hostExpectedDataLengthTextBox.Name = "hostExpectedDataLengthTextBox";
            this.hostExpectedDataLengthTextBox.Size = new System.Drawing.Size(60, 20);
            this.hostExpectedDataLengthTextBox.TabIndex = 12;
            this.hostExpectedDataLengthTextBox.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ack Byte:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Host Transmission Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hostAckByteTextBox
            // 
            this.hostAckByteTextBox.Location = new System.Drawing.Point(145, 169);
            this.hostAckByteTextBox.Name = "hostAckByteTextBox";
            this.hostAckByteTextBox.Size = new System.Drawing.Size(60, 20);
            this.hostAckByteTextBox.TabIndex = 10;
            this.hostAckByteTextBox.Text = "26";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Last Packet Length:";
            // 
            // hostTransmissionTypeComboBox
            // 
            this.hostTransmissionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hostTransmissionTypeComboBox.FormattingEnabled = true;
            this.hostTransmissionTypeComboBox.Location = new System.Drawing.Point(145, 23);
            this.hostTransmissionTypeComboBox.Name = "hostTransmissionTypeComboBox";
            this.hostTransmissionTypeComboBox.Size = new System.Drawing.Size(328, 21);
            this.hostTransmissionTypeComboBox.TabIndex = 6;
            // 
            // hostLastPacketLengthTextBox
            // 
            this.hostLastPacketLengthTextBox.Location = new System.Drawing.Point(145, 111);
            this.hostLastPacketLengthTextBox.Name = "hostLastPacketLengthTextBox";
            this.hostLastPacketLengthTextBox.Size = new System.Drawing.Size(60, 20);
            this.hostLastPacketLengthTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "No Of Remaining Packets:";
            // 
            // hostNoOfRemainingPacketsTextBox
            // 
            this.hostNoOfRemainingPacketsTextBox.Location = new System.Drawing.Point(145, 82);
            this.hostNoOfRemainingPacketsTextBox.Name = "hostNoOfRemainingPacketsTextBox";
            this.hostNoOfRemainingPacketsTextBox.Size = new System.Drawing.Size(60, 20);
            this.hostNoOfRemainingPacketsTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "This Segment Length:";
            // 
            // hostThisSegmentLengthTextBox
            // 
            this.hostThisSegmentLengthTextBox.Location = new System.Drawing.Point(145, 53);
            this.hostThisSegmentLengthTextBox.Name = "hostThisSegmentLengthTextBox";
            this.hostThisSegmentLengthTextBox.Size = new System.Drawing.Size(60, 20);
            this.hostThisSegmentLengthTextBox.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deviceTransmissionTypeTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.deviceConnectedLabel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.deviceAckByteTextBox);
            this.groupBox2.Controls.Add(this.deviceDataTextBox);
            this.groupBox2.Controls.Add(this.deviceLastPacketLengthTextBox);
            this.groupBox2.Controls.Add(this.deviceThisSegmentLengthTextBox);
            this.groupBox2.Controls.Add(this.deviceNoOfRemainingPacketsTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 167);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "From Device";
            // 
            // deviceTransmissionTypeTextBox
            // 
            this.deviceTransmissionTypeTextBox.Location = new System.Drawing.Point(145, 26);
            this.deviceTransmissionTypeTextBox.Name = "deviceTransmissionTypeTextBox";
            this.deviceTransmissionTypeTextBox.ReadOnly = true;
            this.deviceTransmissionTypeTextBox.Size = new System.Drawing.Size(319, 20);
            this.deviceTransmissionTypeTextBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ack Byte:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Device Transmission Type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Last Packet Length:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "No Of Remaining Packets:";
            // 
            // deviceAckByteTextBox
            // 
            this.deviceAckByteTextBox.Location = new System.Drawing.Point(145, 130);
            this.deviceAckByteTextBox.Name = "deviceAckByteTextBox";
            this.deviceAckByteTextBox.ReadOnly = true;
            this.deviceAckByteTextBox.Size = new System.Drawing.Size(60, 20);
            this.deviceAckByteTextBox.TabIndex = 18;
            // 
            // deviceLastPacketLengthTextBox
            // 
            this.deviceLastPacketLengthTextBox.Location = new System.Drawing.Point(145, 104);
            this.deviceLastPacketLengthTextBox.Name = "deviceLastPacketLengthTextBox";
            this.deviceLastPacketLengthTextBox.ReadOnly = true;
            this.deviceLastPacketLengthTextBox.Size = new System.Drawing.Size(60, 20);
            this.deviceLastPacketLengthTextBox.TabIndex = 16;
            // 
            // deviceThisSegmentLengthTextBox
            // 
            this.deviceThisSegmentLengthTextBox.Location = new System.Drawing.Point(145, 52);
            this.deviceThisSegmentLengthTextBox.Name = "deviceThisSegmentLengthTextBox";
            this.deviceThisSegmentLengthTextBox.ReadOnly = true;
            this.deviceThisSegmentLengthTextBox.Size = new System.Drawing.Size(60, 20);
            this.deviceThisSegmentLengthTextBox.TabIndex = 12;
            // 
            // deviceNoOfRemainingPacketsTextBox
            // 
            this.deviceNoOfRemainingPacketsTextBox.Location = new System.Drawing.Point(145, 78);
            this.deviceNoOfRemainingPacketsTextBox.Name = "deviceNoOfRemainingPacketsTextBox";
            this.deviceNoOfRemainingPacketsTextBox.ReadOnly = true;
            this.deviceNoOfRemainingPacketsTextBox.Size = new System.Drawing.Size(60, 20);
            this.deviceNoOfRemainingPacketsTextBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "This Segment Length:";
            // 
            // hidDeviceListComboBox
            // 
            this.hidDeviceListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hidDeviceListComboBox.FormattingEnabled = true;
            this.hidDeviceListComboBox.Location = new System.Drawing.Point(54, 294);
            this.hidDeviceListComboBox.Name = "hidDeviceListComboBox";
            this.hidDeviceListComboBox.Size = new System.Drawing.Size(518, 21);
            this.hidDeviceListComboBox.TabIndex = 20;
            // 
            // HidToSerialModuleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 484);
            this.Controls.Add(this.hidDeviceListComboBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HidToSerialModuleUI";
            this.Text = "HID To Serial Module";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label deviceConnectedLabel;
        private System.Windows.Forms.TextBox deviceDataTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox hostDataTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox hostTransmissionTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hostAckByteTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hostLastPacketLengthTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hostNoOfRemainingPacketsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hostThisSegmentLengthTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox deviceAckByteTextBox;
        private System.Windows.Forms.TextBox deviceLastPacketLengthTextBox;
        private System.Windows.Forms.TextBox deviceThisSegmentLengthTextBox;
        private System.Windows.Forms.TextBox deviceNoOfRemainingPacketsTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox hostExpectedDataLengthTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox hostTimeoutTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox hostRequiredDataLengthTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox hostBaudRateIndexTextBox;
        private System.Windows.Forms.TextBox deviceTransmissionTypeTextBox;
        private System.Windows.Forms.ComboBox hidDeviceListComboBox;
    }
}

