namespace Xichun_City_Train
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 保存FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Xichun City Train Data files (*.xc-raod)|*.xc-road";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    StreamWriter streamWriter = new StreamWriter(myStream);
                    streamWriter.WriteLine("车次：" + IDC_TEXTBOXTRAIN.Text);
                    streamWriter.WriteLine("车次类型：" + IDC_RICHTEXTBOXSTATION.Text);
                    streamWriter.WriteLine("机车：" + IDC_TEXTBOXLOCOMOTIVE.Text);
                    streamWriter.WriteLine("最大速度=" + IDC_TEXTBOXMAXSPEED.Text+"km/h");
                    streamWriter.WriteLine("所经站点：" +IDC_RICHTEXTBOXSTATION.Text);
                    streamWriter.Close();
                    myStream.Close();
                }
            }
        }
    }
}