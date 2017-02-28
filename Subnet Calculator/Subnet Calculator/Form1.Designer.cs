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
namespace Subnet_Calculator {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.nwSubnetLabel = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.nwSubnetCalcButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.nwSubnetOkButton = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.nwSubnetGatewayReadonly = new System.Windows.Forms.TextBox();
			this.nwSubnetMaskReadonly = new System.Windows.Forms.TextBox();
			this.nwSubnetBroadcastReadonly = new System.Windows.Forms.TextBox();
			this.nwSubnetNetworkReadonly = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.nwSubnetSizeEdit = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nwSubnetAddressEdit = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.nwDecicmalStart = new System.Windows.Forms.TextBox();
			this.nwDecimalEnd = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// nwSubnetLabel
			// 
			this.nwSubnetLabel.AutoSize = true;
			this.nwSubnetLabel.ForeColor = System.Drawing.Color.Black;
			this.nwSubnetLabel.Location = new System.Drawing.Point(74, 204);
			this.nwSubnetLabel.Name = "nwSubnetLabel";
			this.nwSubnetLabel.Size = new System.Drawing.Size(105, 13);
			this.nwSubnetLabel.TabIndex = 40;
			this.nwSubnetLabel.Text = "255.255.255.255/32";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Blue;
			this.label9.Location = new System.Drawing.Point(248, 45);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(195, 13);
			this.label9.TabIndex = 39;
			this.label9.Text = "Click Calculate to fill in the values below";
			// 
			// nwSubnetCalcButton
			// 
			this.nwSubnetCalcButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.nwSubnetCalcButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.nwSubnetCalcButton.Image = ((System.Drawing.Image)(resources.GetObject("nwSubnetCalcButton.Image")));
			this.nwSubnetCalcButton.Location = new System.Drawing.Point(342, 10);
			this.nwSubnetCalcButton.Name = "nwSubnetCalcButton";
			this.nwSubnetCalcButton.Size = new System.Drawing.Size(101, 23);
			this.nwSubnetCalcButton.TabIndex = 38;
			this.nwSubnetCalcButton.Text = "Calculate";
			this.nwSubnetCalcButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.nwSubnetCalcButton.UseVisualStyleBackColor = true;
			this.nwSubnetCalcButton.Click += new System.EventHandler(this.nwSubnetCalcButton_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(368, 199);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 37;
			this.button1.Text = "Close";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// nwSubnetOkButton
			// 
			this.nwSubnetOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.nwSubnetOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.nwSubnetOkButton.Location = new System.Drawing.Point(287, 199);
			this.nwSubnetOkButton.Name = "nwSubnetOkButton";
			this.nwSubnetOkButton.Size = new System.Drawing.Size(75, 23);
			this.nwSubnetOkButton.TabIndex = 36;
			this.nwSubnetOkButton.Text = "Copy";
			this.nwSubnetOkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.nwSubnetOkButton.UseVisualStyleBackColor = true;
			this.nwSubnetOkButton.Click += new System.EventHandler(this.nwSubnetOkButton_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 111);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 13);
			this.label8.TabIndex = 35;
			this.label8.Text = "Gateway";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 85);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 13);
			this.label7.TabIndex = 34;
			this.label7.Text = "Subnet Mask";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(233, 111);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 13);
			this.label6.TabIndex = 33;
			this.label6.Text = "Broadcast IP";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(233, 85);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 32;
			this.label5.Text = "Network IP";
			// 
			// nwSubnetGatewayReadonly
			// 
			this.nwSubnetGatewayReadonly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nwSubnetGatewayReadonly.Location = new System.Drawing.Point(77, 108);
			this.nwSubnetGatewayReadonly.Name = "nwSubnetGatewayReadonly";
			this.nwSubnetGatewayReadonly.ReadOnly = true;
			this.nwSubnetGatewayReadonly.Size = new System.Drawing.Size(139, 20);
			this.nwSubnetGatewayReadonly.TabIndex = 31;
			// 
			// nwSubnetMaskReadonly
			// 
			this.nwSubnetMaskReadonly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nwSubnetMaskReadonly.Location = new System.Drawing.Point(77, 82);
			this.nwSubnetMaskReadonly.Name = "nwSubnetMaskReadonly";
			this.nwSubnetMaskReadonly.ReadOnly = true;
			this.nwSubnetMaskReadonly.Size = new System.Drawing.Size(139, 20);
			this.nwSubnetMaskReadonly.TabIndex = 30;
			// 
			// nwSubnetBroadcastReadonly
			// 
			this.nwSubnetBroadcastReadonly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nwSubnetBroadcastReadonly.Location = new System.Drawing.Point(304, 108);
			this.nwSubnetBroadcastReadonly.Name = "nwSubnetBroadcastReadonly";
			this.nwSubnetBroadcastReadonly.ReadOnly = true;
			this.nwSubnetBroadcastReadonly.Size = new System.Drawing.Size(139, 20);
			this.nwSubnetBroadcastReadonly.TabIndex = 29;
			// 
			// nwSubnetNetworkReadonly
			// 
			this.nwSubnetNetworkReadonly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nwSubnetNetworkReadonly.Location = new System.Drawing.Point(304, 82);
			this.nwSubnetNetworkReadonly.Name = "nwSubnetNetworkReadonly";
			this.nwSubnetNetworkReadonly.ReadOnly = true;
			this.nwSubnetNetworkReadonly.Size = new System.Drawing.Size(139, 20);
			this.nwSubnetNetworkReadonly.TabIndex = 28;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(115, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 13);
			this.label3.TabIndex = 27;
			this.label3.Text = "< Network bits";
			// 
			// nwSubnetSizeEdit
			// 
			this.nwSubnetSizeEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nwSubnetSizeEdit.Location = new System.Drawing.Point(77, 38);
			this.nwSubnetSizeEdit.Name = "nwSubnetSizeEdit";
			this.nwSubnetSizeEdit.Size = new System.Drawing.Size(32, 20);
			this.nwSubnetSizeEdit.TabIndex = 26;
			this.nwSubnetSizeEdit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nwSubnetSizeEdit_KeyUp);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(27, 13);
			this.label4.TabIndex = 25;
			this.label4.Text = "Size";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(222, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 24;
			this.label2.Text = "< IP address only";
			// 
			// nwSubnetAddressEdit
			// 
			this.nwSubnetAddressEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nwSubnetAddressEdit.Location = new System.Drawing.Point(77, 12);
			this.nwSubnetAddressEdit.Name = "nwSubnetAddressEdit";
			this.nwSubnetAddressEdit.Size = new System.Drawing.Size(139, 20);
			this.nwSubnetAddressEdit.TabIndex = 23;
			this.nwSubnetAddressEdit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nwSubnetAddressEdit_KeyUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 22;
			this.label1.Text = "Subnet";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 159);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(29, 13);
			this.label10.TabIndex = 41;
			this.label10.Text = "Start";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(233, 159);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(26, 13);
			this.label11.TabIndex = 42;
			this.label11.Text = "End";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(6, 134);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(57, 13);
			this.label12.TabIndex = 43;
			this.label12.Text = "Numerical:";
			// 
			// nwDecicmalStart
			// 
			this.nwDecicmalStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nwDecicmalStart.Location = new System.Drawing.Point(77, 156);
			this.nwDecicmalStart.Name = "nwDecicmalStart";
			this.nwDecicmalStart.ReadOnly = true;
			this.nwDecicmalStart.Size = new System.Drawing.Size(139, 20);
			this.nwDecicmalStart.TabIndex = 44;
			// 
			// nwDecimalEnd
			// 
			this.nwDecimalEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nwDecimalEnd.Location = new System.Drawing.Point(304, 156);
			this.nwDecimalEnd.Name = "nwDecimalEnd";
			this.nwDecimalEnd.ReadOnly = true;
			this.nwDecimalEnd.Size = new System.Drawing.Size(138, 20);
			this.nwDecimalEnd.TabIndex = 45;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button1;
			this.ClientSize = new System.Drawing.Size(454, 234);
			this.Controls.Add(this.nwDecimalEnd);
			this.Controls.Add(this.nwDecicmalStart);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.nwSubnetLabel);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.nwSubnetCalcButton);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.nwSubnetOkButton);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nwSubnetGatewayReadonly);
			this.Controls.Add(this.nwSubnetMaskReadonly);
			this.Controls.Add(this.nwSubnetBroadcastReadonly);
			this.Controls.Add(this.nwSubnetNetworkReadonly);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nwSubnetSizeEdit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nwSubnetAddressEdit);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Subnet Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nwSubnetLabel;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button nwSubnetCalcButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button nwSubnetOkButton;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox nwSubnetGatewayReadonly;
		private System.Windows.Forms.TextBox nwSubnetMaskReadonly;
		private System.Windows.Forms.TextBox nwSubnetBroadcastReadonly;
		private System.Windows.Forms.TextBox nwSubnetNetworkReadonly;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox nwSubnetSizeEdit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nwSubnetAddressEdit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox nwDecicmalStart;
		private System.Windows.Forms.TextBox nwDecimalEnd;
	}
}

