using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.Xml;
using System.Text;
using TwinCAT.Ads;
using TwinCAT.PlcOpen;

namespace CallRpcMethod
{
    public struct MyType
    {
        public long a;
        public double b;
        public string c;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Ansi)]
    public struct T_MyType
    {
        [MarshalAs(UnmanagedType.U4)]
        public UInt32 a; // 4 byte
        [MarshalAs(UnmanagedType.R8)]
        public double b; // 8 byte
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string c;
    }
    public partial class Form1 : Form
    {
        private AdsClient plcClient = new AdsClient();
        private AdsClient cppClient = new AdsClient();

        private AmsNetId amsAddr;
        private CancellationToken cancel = CancellationToken.None;
        public Form1()
        {
            InitializeComponent();
        }

        private bool checkResult(ResultRpcMethod result)
        {
            return result.Succeeded && result.ReturnValue != null && result.ErrorCode == AdsErrorCode.NoError;
        }
        private void btn_clearState_Click(object sender, EventArgs e)
        {
            textBox_State.Clear();
        }
        private void btn_AdsClientConnect_Click(object sender, EventArgs e)
        {
            try
            {
                plcClient.Connect(textBox_NetId.Text, Int32.Parse(textBox_PLC_Port.Text));
            }
            catch (Exception ex)
            {

                textBox_State.AppendText(ex.Message + Environment.NewLine);
                return;
            }

            textBox_State.AppendText("PLC connected" + Environment.NewLine);

            try
            {
                cppClient.Connect(textBox_NetId.Text, Int32.Parse(textBox_TwinCAT_Cpp_Port.Text));
            }
            catch (Exception ex)
            {

                textBox_State.AppendText(ex.Message + Environment.NewLine);
                return;
            }

            textBox_State.AppendText("TwinCAT C++ connected" + Environment.NewLine);
        }

        private async void btn_Call_Method_Addition_Click(object sender, EventArgs e)
        {
            try
            {
                long a = Int32.Parse(textBox_Method_Addition_Argument_A.Text);
                long b = Int32.Parse(textBox_Method_Addition_Argument_B.Text);

                ResultRpcMethod result = await plcClient.InvokeRpcMethodAsync("MAIN.fb_rpc", "Addition", new object[] { a, b }, cancel);

                if (checkResult(result))
                {
                    textBox_Method_Addition_Return_Value.Text = result.ReturnValue.ToString();
                }
                else
                {
                    textBox_State.AppendText("PLC Addition(): " + result.ErrorCode + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                textBox_State.AppendText(ex.Message + Environment.NewLine);
                return;
            }
        }

        private async void btn_Call_Method_Read_String_Click(object sender, EventArgs e)
        {
            try
            {
                ResultRpcMethod result = await plcClient.InvokeRpcMethodAsync("MAIN.fb_rpc", "ReadString", new object[] { }, cancel);

                if (checkResult(result))
                {
                    textBox_read_string.Text = result.ReturnValue.ToString();

                }
                else
                {
                    textBox_State.AppendText("PLC ReadString(): " + result.ErrorCode + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {

                textBox_State.AppendText(ex.Message + Environment.NewLine);
            }
        }

        private async void btn_Call_Method_Write_String_Click(object sender, EventArgs e)
        {
            try
            {
                string stringToWrite = textBox_write_string.Text;
                ResultRpcMethod result = await plcClient.InvokeRpcMethodAsync("MAIN.fb_rpc", "WriteString", new object[] { (String)stringToWrite }, cancel);

                if (result.Succeeded && result.ErrorCode != AdsErrorCode.NoError)
                {
                    textBox_State.AppendText("PLC WriteString(): " + result.ErrorCode + Environment.NewLine);

                }
            }
            catch (Exception ex)
            {

                textBox_State.AppendText(ex.Message + Environment.NewLine);
            }
        }

        private async void btn_Call_Method_Read_Struct_Click(object sender, EventArgs e)
        {
            try
            {
                ResultRpcMethod result = await plcClient.InvokeRpcMethodAsync("MAIN.fb_rpc", "ReadStruct", new object[] { }, cancel);

                if (checkResult(result))
                {            
                    MemoryStream ms = new MemoryStream((byte[])result.ReturnValue);

                    BinaryReader br = new BinaryReader(ms);

                    uint a = br.ReadUInt32();
                    ms.Position = 8; // Advance Position
                    double b = br.ReadDouble();

                    string c = new string(br.ReadChars(81));

                    T_MyType myType = new T_MyType { a = (uint)a, b = b, c = c };

                    textBox_MyType_A_ro.Text = myType.a.ToString();
                    textBox_MyType_B_ro.Text = myType.b.ToString();
                    textBox_MyType_C_ro.Text = myType.c;
                }
                else
                {
                    textBox_State.AppendText("PLC ReadStruct(): " + result.ErrorCode + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {

                textBox_State.AppendText(ex.Message + Environment.NewLine);
            }
        }

        private async void btn_Call_Method_Write_Struct_Click(object sender, EventArgs e)
        {
            try
            {
                long a = Int32.Parse(textBox_MyType_A.Text);
                double b = Double.Parse(textBox_MyType_B.Text);
                string c = textBox_MyType_C.Text;

                // Manual approach

                //Byte[] c_ascii = Encoding.ASCII.GetBytes(c);
                //byte[] buffer = new byte[104];
                //MemoryStream ms = new MemoryStream(buffer);
                //BinaryWriter bw = new BinaryWriter(ms);
                //bw.Write(a);
                //bw.Write(b);
                //bw.Write(c_ascii);
                //ResultRpcMethod result = await plcClient.InvokeRpcMethodAsync("MAIN.fb_rpc", "WriteStruct", new object[] { buffer }, cancel);


                T_MyType myTypeArgument = new T_MyType { a = (uint)a, b = b, c = c};

                // Test: size must match with the size of T_MyType in the PLC
                //var size = Marshal.SizeOf(myTypeArgument);

                ResultRpcMethod result = await plcClient.InvokeRpcMethodAsync("MAIN.fb_rpc", "WriteStruct", new object[] { myTypeArgument }, cancel);

                if (checkResult(result))
                {
                    textBox_State.AppendText("WriteStruct() call cnt returned: " + result.ReturnValue + Environment.NewLine);
                }
                else
                {
                    textBox_State.AppendText("PLC WriteStruct(): " + result.ErrorCode + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                textBox_State.AppendText(ex.Message + Environment.NewLine);
            }
        }
    }
}