using System.Security.Cryptography.Xml;
using TwinCAT.Ads;

namespace CallRpcMethod
{
    public struct MyType
    {
        public long a;
        public UDINT d;
        public double b;
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

                textBox_State.Text += ex.Message + Environment.NewLine;
                return;
            }

            textBox_State.Text += "PLC connected" + Environment.NewLine;

            try
            {
                cppClient.Connect(textBox_NetId.Text, Int32.Parse(textBox_TwinCAT_Cpp_Port.Text));
            }
            catch (Exception ex)
            {

                textBox_State.Text += ex.Message + Environment.NewLine;
                return;
            }

            textBox_State.Text += "TwinCAT C++ connected" + Environment.NewLine;
        }

        private async void btn_Call_Method_Addition_Click(object sender, EventArgs e)
        {
            try
            {
                long a = Int32.Parse(textBox_Method_Addition_Argument_A.Text);
                long b = Int32.Parse(textBox_Method_Addition_Argument_B.Text);

                ResultRpcMethod result = await plcClient.InvokeRpcMethodAsync("MAIN.fb_rcp", "Addition", new object[] { a, b }, cancel);

                if (checkResult(result))
                {
                    textBox_Method_Addition_Return_Value.Text = result.ReturnValue.ToString();
                }
                else
                {
                    textBox_State.Text += "PLC Addition(): " + result.ErrorCode + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                textBox_State.Text += ex.Message + Environment.NewLine;
                return;
            }
        }



        private async void btn_Call_Method_Write_Struct_Click(object sender, EventArgs e)
        {
            try
            {
                long a = Int32.Parse(textBox_MyType_A.Text);
                double b = Double.Parse(textBox_MyType_B.Text);
                string c = textBox_MyType_C.Text;

                MyType myTypeArgument = new MyType { a = a, b = b, c = c };

                ResultRpcMethod result = await plcClient.InvokeRpcMethodAsync("MAIN.fb_rcp", "WriteStruct", new object[] { myTypeArgument }, cancel);

                if (checkResult(result))
                {
                    //textBox_Method_Addition_Return_Value.Text = result.ReturnValue.ToString();
                    int x = 3;
                }
                else
                {
                    textBox_State.Text += "PLC WriteStruct(): " + result.ErrorCode + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                textBox_State.Text += ex.Message + Environment.NewLine;
                return;
            }
        }
    }
}