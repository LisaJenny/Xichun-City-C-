namespace Xichun_City_Train
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ����FToolStripMenuItem_Click(object sender, EventArgs e)
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
                    streamWriter.WriteLine("���Σ�" + IDC_TEXTBOXTRAIN.Text);
                    streamWriter.WriteLine("�������ͣ�" + IDC_RICHTEXTBOXSTATION.Text);
                    streamWriter.WriteLine("������" + IDC_TEXTBOXLOCOMOTIVE.Text);
                    streamWriter.WriteLine("����ٶ�=" + IDC_TEXTBOXMAXSPEED.Text+"km/h");
                    streamWriter.WriteLine("����վ�㣺" +IDC_RICHTEXTBOXSTATION.Text);
                    streamWriter.Close();
                    myStream.Close();
                }
            }
        }
    }
}