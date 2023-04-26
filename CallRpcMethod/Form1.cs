using TwinCAT.Ads;

namespace CallRpcMethod
{
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

        private void btn_AdsClientConnect_Click(object sender, EventArgs e)
        {

            textBox_State.Clear();

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

                if (result.Succeeded && result.ReturnValue != null)
                {
                    textBox_Method_Addition_Return_Value.Text = result.ReturnValue.ToString();
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