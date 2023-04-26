namespace CallRpcMethod
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox_PLC = new GroupBox();
            groupBox_Cpp = new GroupBox();
            groupBox_AdsClient = new GroupBox();
            textBox_AdsConnectionState = new TextBox();
            btn_AdsClientConnect = new Button();
            textBox_TwinCAT_Cpp_Port = new TextBox();
            textBox_PLC_Port = new TextBox();
            label_TwinCAT_Cpp_Port = new Label();
            label_PLC_Port = new Label();
            label_NetId = new Label();
            textBox_NetId = new TextBox();
            groupBox_AdsClient.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_PLC
            // 
            groupBox_PLC.Location = new Point(35, 219);
            groupBox_PLC.Name = "groupBox_PLC";
            groupBox_PLC.Size = new Size(200, 407);
            groupBox_PLC.TabIndex = 1;
            groupBox_PLC.TabStop = false;
            groupBox_PLC.Text = "PLC";
            // 
            // groupBox_Cpp
            // 
            groupBox_Cpp.Location = new Point(372, 219);
            groupBox_Cpp.Name = "groupBox_Cpp";
            groupBox_Cpp.Size = new Size(200, 407);
            groupBox_Cpp.TabIndex = 2;
            groupBox_Cpp.TabStop = false;
            groupBox_Cpp.Text = "TwinCAT C++";
            // 
            // groupBox_AdsClient
            // 
            groupBox_AdsClient.Controls.Add(textBox_AdsConnectionState);
            groupBox_AdsClient.Controls.Add(btn_AdsClientConnect);
            groupBox_AdsClient.Controls.Add(textBox_TwinCAT_Cpp_Port);
            groupBox_AdsClient.Controls.Add(textBox_PLC_Port);
            groupBox_AdsClient.Controls.Add(label_TwinCAT_Cpp_Port);
            groupBox_AdsClient.Controls.Add(label_PLC_Port);
            groupBox_AdsClient.Controls.Add(label_NetId);
            groupBox_AdsClient.Controls.Add(textBox_NetId);
            groupBox_AdsClient.Location = new Point(35, 26);
            groupBox_AdsClient.Name = "groupBox_AdsClient";
            groupBox_AdsClient.Size = new Size(580, 161);
            groupBox_AdsClient.TabIndex = 3;
            groupBox_AdsClient.TabStop = false;
            groupBox_AdsClient.Text = "ADS";
            // 
            // textBox_AdsConnectionState
            // 
            textBox_AdsConnectionState.AcceptsReturn = true;
            textBox_AdsConnectionState.Location = new Point(312, 75);
            textBox_AdsConnectionState.Multiline = true;
            textBox_AdsConnectionState.Name = "textBox_AdsConnectionState";
            textBox_AdsConnectionState.ReadOnly = true;
            textBox_AdsConnectionState.Size = new Size(205, 55);
            textBox_AdsConnectionState.TabIndex = 7;
            // 
            // btn_AdsClientConnect
            // 
            btn_AdsClientConnect.Location = new Point(312, 36);
            btn_AdsClientConnect.Name = "btn_AdsClientConnect";
            btn_AdsClientConnect.Size = new Size(205, 23);
            btn_AdsClientConnect.TabIndex = 6;
            btn_AdsClientConnect.Text = "Connect";
            btn_AdsClientConnect.UseVisualStyleBackColor = true;
            btn_AdsClientConnect.Click += btn_AdsClientConnect_Click;
            // 
            // textBox_TwinCAT_Cpp_Port
            // 
            textBox_TwinCAT_Cpp_Port.Location = new Point(138, 107);
            textBox_TwinCAT_Cpp_Port.Name = "textBox_TwinCAT_Cpp_Port";
            textBox_TwinCAT_Cpp_Port.Size = new Size(100, 23);
            textBox_TwinCAT_Cpp_Port.TabIndex = 5;
            textBox_TwinCAT_Cpp_Port.Text = "350";
            // 
            // textBox_PLC_Port
            // 
            textBox_PLC_Port.Location = new Point(138, 72);
            textBox_PLC_Port.Name = "textBox_PLC_Port";
            textBox_PLC_Port.Size = new Size(100, 23);
            textBox_PLC_Port.TabIndex = 4;
            textBox_PLC_Port.Text = "851";
            // 
            // label_TwinCAT_Cpp_Port
            // 
            label_TwinCAT_Cpp_Port.AutoSize = true;
            label_TwinCAT_Cpp_Port.Location = new Point(6, 110);
            label_TwinCAT_Cpp_Port.Name = "label_TwinCAT_Cpp_Port";
            label_TwinCAT_Cpp_Port.Size = new Size(104, 15);
            label_TwinCAT_Cpp_Port.TabIndex = 3;
            label_TwinCAT_Cpp_Port.Text = "TwinCAT C++ Port";
            // 
            // label_PLC_Port
            // 
            label_PLC_Port.AutoSize = true;
            label_PLC_Port.Location = new Point(6, 75);
            label_PLC_Port.Name = "label_PLC_Port";
            label_PLC_Port.Size = new Size(53, 15);
            label_PLC_Port.TabIndex = 2;
            label_PLC_Port.Text = "PLC Port";
            // 
            // label_NetId
            // 
            label_NetId.AutoSize = true;
            label_NetId.Location = new Point(6, 39);
            label_NetId.Name = "label_NetId";
            label_NetId.Size = new Size(36, 15);
            label_NetId.TabIndex = 1;
            label_NetId.Text = "NetId";
            // 
            // textBox_NetId
            // 
            textBox_NetId.Location = new Point(138, 36);
            textBox_NetId.Name = "textBox_NetId";
            textBox_NetId.Size = new Size(100, 23);
            textBox_NetId.TabIndex = 0;
            textBox_NetId.Text = "5.80.201.232.1.1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 719);
            Controls.Add(groupBox_AdsClient);
            Controls.Add(groupBox_Cpp);
            Controls.Add(groupBox_PLC);
            Name = "Form1";
            Text = "Call RPC Method";
            groupBox_AdsClient.ResumeLayout(false);
            groupBox_AdsClient.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_PLC;
        private GroupBox groupBox_Cpp;
        private GroupBox groupBox_AdsClient;
        private TextBox textBox_NetId;
        private Label label_NetId;
        private Button btn_AdsClientConnect;
        private TextBox textBox_TwinCAT_Cpp_Port;
        private TextBox textBox_PLC_Port;
        private Label label_TwinCAT_Cpp_Port;
        private Label label_PLC_Port;
        private TextBox textBox_AdsConnectionState;
    }
}