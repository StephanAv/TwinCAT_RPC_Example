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
            groupBox_Method_Addition = new GroupBox();
            btn_Call_Method_Addition = new Button();
            textBox_Method_Addition_Return_Value = new TextBox();
            label_Method_Addition__Value_Returned = new Label();
            label_Method_Addition__Arg_B = new Label();
            textBox_Method_Addition_Argument_B = new TextBox();
            textBox_Method_Addition_Argument_A = new TextBox();
            label_Method_Addition__Arg_A = new Label();
            groupBox_Cpp = new GroupBox();
            groupBox_AdsClient = new GroupBox();
            textBox_State = new TextBox();
            btn_AdsClientConnect = new Button();
            textBox_TwinCAT_Cpp_Port = new TextBox();
            textBox_PLC_Port = new TextBox();
            label_TwinCAT_Cpp_Port = new Label();
            label_PLC_Port = new Label();
            label_NetId = new Label();
            textBox_NetId = new TextBox();
            groupBox_state = new GroupBox();
            groupBox_PLC.SuspendLayout();
            groupBox_Method_Addition.SuspendLayout();
            groupBox_AdsClient.SuspendLayout();
            groupBox_state.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_PLC
            // 
            groupBox_PLC.Controls.Add(groupBox_Method_Addition);
            groupBox_PLC.Location = new Point(35, 219);
            groupBox_PLC.Name = "groupBox_PLC";
            groupBox_PLC.Size = new Size(457, 407);
            groupBox_PLC.TabIndex = 1;
            groupBox_PLC.TabStop = false;
            groupBox_PLC.Text = "PLC";
            // 
            // groupBox_Method_Addition
            // 
            groupBox_Method_Addition.Controls.Add(btn_Call_Method_Addition);
            groupBox_Method_Addition.Controls.Add(textBox_Method_Addition_Return_Value);
            groupBox_Method_Addition.Controls.Add(label_Method_Addition__Value_Returned);
            groupBox_Method_Addition.Controls.Add(label_Method_Addition__Arg_B);
            groupBox_Method_Addition.Controls.Add(textBox_Method_Addition_Argument_B);
            groupBox_Method_Addition.Controls.Add(textBox_Method_Addition_Argument_A);
            groupBox_Method_Addition.Controls.Add(label_Method_Addition__Arg_A);
            groupBox_Method_Addition.Location = new Point(20, 33);
            groupBox_Method_Addition.Name = "groupBox_Method_Addition";
            groupBox_Method_Addition.Size = new Size(364, 153);
            groupBox_Method_Addition.TabIndex = 0;
            groupBox_Method_Addition.TabStop = false;
            groupBox_Method_Addition.Text = "Addition";
            // 
            // btn_Call_Method_Addition
            // 
            btn_Call_Method_Addition.Location = new Point(218, 31);
            btn_Call_Method_Addition.Name = "btn_Call_Method_Addition";
            btn_Call_Method_Addition.Size = new Size(124, 99);
            btn_Call_Method_Addition.TabIndex = 6;
            btn_Call_Method_Addition.Text = "Call Addition()";
            btn_Call_Method_Addition.UseVisualStyleBackColor = true;
            btn_Call_Method_Addition.Click += btn_Call_Method_Addition_Click;
            // 
            // textBox_Method_Addition_Return_Value
            // 
            textBox_Method_Addition_Return_Value.Location = new Point(131, 107);
            textBox_Method_Addition_Return_Value.Name = "textBox_Method_Addition_Return_Value";
            textBox_Method_Addition_Return_Value.Size = new Size(64, 23);
            textBox_Method_Addition_Return_Value.TabIndex = 5;
            // 
            // label_Method_Addition__Value_Returned
            // 
            label_Method_Addition__Value_Returned.AutoSize = true;
            label_Method_Addition__Value_Returned.Location = new Point(16, 115);
            label_Method_Addition__Value_Returned.Name = "label_Method_Addition__Value_Returned";
            label_Method_Addition__Value_Returned.Size = new Size(73, 15);
            label_Method_Addition__Value_Returned.TabIndex = 4;
            label_Method_Addition__Value_Returned.Text = "Return Value";
            // 
            // label_Method_Addition__Arg_B
            // 
            label_Method_Addition__Arg_B.AutoSize = true;
            label_Method_Addition__Arg_B.Location = new Point(16, 73);
            label_Method_Addition__Arg_B.Name = "label_Method_Addition__Arg_B";
            label_Method_Addition__Arg_B.Size = new Size(71, 15);
            label_Method_Addition__Arg_B.TabIndex = 3;
            label_Method_Addition__Arg_B.Text = "Argument B";
            // 
            // textBox_Method_Addition_Argument_B
            // 
            textBox_Method_Addition_Argument_B.Location = new Point(131, 70);
            textBox_Method_Addition_Argument_B.Name = "textBox_Method_Addition_Argument_B";
            textBox_Method_Addition_Argument_B.Size = new Size(64, 23);
            textBox_Method_Addition_Argument_B.TabIndex = 2;
            textBox_Method_Addition_Argument_B.Text = "11";
            // 
            // textBox_Method_Addition_Argument_A
            // 
            textBox_Method_Addition_Argument_A.Location = new Point(131, 32);
            textBox_Method_Addition_Argument_A.Name = "textBox_Method_Addition_Argument_A";
            textBox_Method_Addition_Argument_A.Size = new Size(62, 23);
            textBox_Method_Addition_Argument_A.TabIndex = 1;
            textBox_Method_Addition_Argument_A.Text = "5";
            // 
            // label_Method_Addition__Arg_A
            // 
            label_Method_Addition__Arg_A.AutoSize = true;
            label_Method_Addition__Arg_A.Location = new Point(16, 35);
            label_Method_Addition__Arg_A.Name = "label_Method_Addition__Arg_A";
            label_Method_Addition__Arg_A.Size = new Size(72, 15);
            label_Method_Addition__Arg_A.TabIndex = 0;
            label_Method_Addition__Arg_A.Text = "Argument A";
            // 
            // groupBox_Cpp
            // 
            groupBox_Cpp.Location = new Point(536, 219);
            groupBox_Cpp.Name = "groupBox_Cpp";
            groupBox_Cpp.Size = new Size(200, 407);
            groupBox_Cpp.TabIndex = 2;
            groupBox_Cpp.TabStop = false;
            groupBox_Cpp.Text = "TwinCAT C++";
            // 
            // groupBox_AdsClient
            // 
            groupBox_AdsClient.Controls.Add(btn_AdsClientConnect);
            groupBox_AdsClient.Controls.Add(textBox_TwinCAT_Cpp_Port);
            groupBox_AdsClient.Controls.Add(textBox_PLC_Port);
            groupBox_AdsClient.Controls.Add(label_TwinCAT_Cpp_Port);
            groupBox_AdsClient.Controls.Add(label_PLC_Port);
            groupBox_AdsClient.Controls.Add(label_NetId);
            groupBox_AdsClient.Controls.Add(textBox_NetId);
            groupBox_AdsClient.Location = new Point(35, 26);
            groupBox_AdsClient.Name = "groupBox_AdsClient";
            groupBox_AdsClient.Size = new Size(314, 187);
            groupBox_AdsClient.TabIndex = 3;
            groupBox_AdsClient.TabStop = false;
            groupBox_AdsClient.Text = "ADS";
            // 
            // textBox_State
            // 
            textBox_State.AcceptsReturn = true;
            textBox_State.Location = new Point(19, 22);
            textBox_State.Multiline = true;
            textBox_State.Name = "textBox_State";
            textBox_State.ReadOnly = true;
            textBox_State.Size = new Size(306, 149);
            textBox_State.TabIndex = 7;
            // 
            // btn_AdsClientConnect
            // 
            btn_AdsClientConnect.Location = new Point(10, 148);
            btn_AdsClientConnect.Name = "btn_AdsClientConnect";
            btn_AdsClientConnect.Size = new Size(228, 23);
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
            // groupBox_state
            // 
            groupBox_state.Controls.Add(textBox_State);
            groupBox_state.Location = new Point(393, 26);
            groupBox_state.Name = "groupBox_state";
            groupBox_state.Size = new Size(343, 187);
            groupBox_state.TabIndex = 9;
            groupBox_state.TabStop = false;
            groupBox_state.Text = "State";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 719);
            Controls.Add(groupBox_state);
            Controls.Add(groupBox_AdsClient);
            Controls.Add(groupBox_Cpp);
            Controls.Add(groupBox_PLC);
            Name = "Form1";
            Text = "Call RPC Method";
            groupBox_PLC.ResumeLayout(false);
            groupBox_Method_Addition.ResumeLayout(false);
            groupBox_Method_Addition.PerformLayout();
            groupBox_AdsClient.ResumeLayout(false);
            groupBox_AdsClient.PerformLayout();
            groupBox_state.ResumeLayout(false);
            groupBox_state.PerformLayout();
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
        private TextBox textBox_State;
        private GroupBox groupBox_Method_Addition;
        private Label label_Method_Addition__Arg_B;
        private TextBox textBox_Method_Addition_Argument_B;
        private TextBox textBox_Method_Addition_Argument_A;
        private Label label_Method_Addition__Arg_A;
        private Button btn_Call_Method_Addition;
        private TextBox textBox_Method_Addition_Return_Value;
        private Label label_Method_Addition__Value_Returned;
        private GroupBox groupBox_state;
    }
}