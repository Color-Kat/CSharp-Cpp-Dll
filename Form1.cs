namespace ArraySum
{
    public partial class Form1 : Form
    {
        ArraySum ArraySum = new ArraySum();

        public Form1()
        {
            InitializeComponent();
        }

        private void generateArrayButton_Click(object sender, EventArgs e)
        {
            ArraySum.GenerateRandomArray(Int32.Parse(itemsCountInput.Text));
        }

        private void csharpSumButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = ArraySum.CSharpSum();
        }

        private void cppSum_Click(object sender, EventArgs e)
        {
            resultLabel.Text = ArraySum.CppSum();
        }

        private void xmmSum_Click(object sender, EventArgs e)
        {
            resultLabel.Text = ArraySum.XMMSum();
        }
    }
}
