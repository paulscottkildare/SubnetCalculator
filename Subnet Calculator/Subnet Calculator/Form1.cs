/**
 * Subnet Calculator
 * Copyright (c) 2015 Paul Scott
 * paul.scott.kildare@live.com
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 *
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subnet_Calculator {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		private string getIpFromHex(string ipn) {
			string[] maskOctets = { "", "", "", "" };
			maskOctets[0] = Convert.ToInt16(ipn.Substring(0, 2), 16).ToString();
			maskOctets[1] = Convert.ToInt16(ipn.Substring(2, 2), 16).ToString();
			maskOctets[2] = Convert.ToInt16(ipn.Substring(4, 2), 16).ToString();
			maskOctets[3] = Convert.ToInt16(ipn.Substring(6, 2), 16).ToString();
			return String.Join(".", maskOctets);
		}
		private string getIpFromInt(UInt32 ipn) {
			string ipString = ipn.ToString("X8");
			return getIpFromHex(ipString);
		}
		private UInt32 getIntFromIp(string ipv) {
			UInt32 ipn = 0;
			string[] octets = ipv.Split('.');
			if (octets.Length != 4) {
				MessageBox.Show("Network address does not appear to be a valid IP address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 0;
			}
			ipn += (UInt32)Convert.ToInt32(octets[0]) * Convert.ToUInt32(Math.Pow(2, 24));
			ipn += (UInt32)Convert.ToInt32(octets[1]) * Convert.ToUInt32(Math.Pow(2, 16));
			ipn += (UInt32)Convert.ToInt32(octets[2]) * Convert.ToUInt32(Math.Pow(2, 8));
			ipn += (UInt32)Convert.ToInt32(octets[3]);
			return ipn;
		}
		private void nwSubnetCalcButton_Click(object sender, EventArgs e) {
			string originalIp = nwSubnetAddressEdit.Text;
			if (!Utils1.isIpAddress(originalIp)) {
				MessageBox.Show("Network address does not appear to be a valid IP address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (nwSubnetSizeEdit.Text == "") {
				MessageBox.Show("You have not entered a network size", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			UInt32 ipNumeric = getIntFromIp(originalIp);
			if (nwSubnetSizeEdit.Text == "")
				return;
			if (nwSubnetSizeEdit.Text[0] == '/')
				nwSubnetSizeEdit.Text = nwSubnetSizeEdit.Text.Substring(1);
			int networkBits = Convert.ToInt32(nwSubnetSizeEdit.Text);
			int hostBits = 32-Convert.ToInt32(nwSubnetSizeEdit.Text);
			
			string binaryMask = new String('1', (int)networkBits)+ new String('0',(int)hostBits);
			string hexMask = Convert.ToInt32(binaryMask, 2).ToString("X");
			UInt32 networkMaskInt = (UInt32)Convert.ToInt32(binaryMask, 2);
			
			nwSubnetMaskReadonly.Text =getIpFromHex(hexMask);
			nwSubnetNetworkReadonly.Text = getIpFromInt(ipNumeric & networkMaskInt);
			nwSubnetBroadcastReadonly.Text = getIpFromInt(ipNumeric | ~networkMaskInt);
			nwSubnetGatewayReadonly.Text = getIpFromInt((ipNumeric & networkMaskInt) + 1);
			nwSubnetLabel.Text = nwSubnetNetworkReadonly.Text+"/"+nwSubnetSizeEdit.Text;
			nwDecicmalStart.Text = (ipNumeric & networkMaskInt).ToString();
			nwDecimalEnd.Text = (ipNumeric | ~networkMaskInt).ToString();
		}

		private void button1_Click(object sender, EventArgs e) {
			Close();
		}

		private void nwSubnetOkButton_Click(object sender, EventArgs e) {
			Clipboard.SetText(nwSubnetLabel.Text);
			MessageBox.Show("Subnet address has been copied to the clipboard", "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
			//Close();
		}

		private void nwSubnetAddressEdit_KeyUp(object sender, KeyEventArgs e) {
			if ((e.KeyCode == Keys.Enter) && (nwSubnetSizeEdit.Text != ""))
				nwSubnetCalcButton_Click(this, EventArgs.Empty);

		}

		private void nwSubnetSizeEdit_KeyUp(object sender, KeyEventArgs e) {
			if ((e.KeyCode == Keys.Enter) && (nwSubnetAddressEdit.Text != ""))
				nwSubnetCalcButton_Click(this, EventArgs.Empty);
		}
	}
}