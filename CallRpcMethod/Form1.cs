using TwinCAT.Ads;

namespace CallRpcMethod
{
    public partial class Form1 : Form
    {
        private AdsClient plcClient = new AdsClient();
        private AdsClient cppClient = new AdsClient();

        private AmsNetId amsAddr;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AdsClientConnect_Click(object sender, EventArgs e)
        {

            textBox_AdsConnectionState.Clear();

            try
            {
                plcClient.Connect(textBox_NetId.Text, Int32.Parse(textBox_PLC_Port.Text));
            }
            catch (Exception ex)
            {

                textBox_AdsConnectionState.Text += ex.Message + Environment.NewLine;
                return;
            }

            textBox_AdsConnectionState.Text += "PLC connected" + Environment.NewLine;

            try
            {
                cppClient.Connect(textBox_NetId.Text, Int32.Parse(textBox_TwinCAT_Cpp_Port.Text));
            }
            catch (Exception ex)
            {

                textBox_AdsConnectionState.Text += ex.Message + Environment.NewLine;
                return;
            }

            textBox_AdsConnectionState.Text += "TwinCAT C++ connected" + Environment.NewLine;
        }
    }
}