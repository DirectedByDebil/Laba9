using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual9
{
    public partial class Form1 : Form
    {
        Matrix aMatrix, bMatrix, cMatrix;
        
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SetMatrixes();

            aMatrix.RandomizeMatrix();

            await Task.Delay(10);
            bMatrix.RandomizeMatrix();


            ARichTextBox.Text = aMatrix.ToString();
            BRichTextBox.Text = bMatrix.ToString();

            cMatrix = aMatrix * bMatrix;
            CRichTextBox.Text = cMatrix.ToString();
        }

        private void SetMatrixes()
        {
            string[] sizeA = aBox.Text.Replace('.', ',').Split(' '),
                sizeB = bBox.Text.Replace('.', ',').Split(' ');

            aMatrix = new Matrix(int.Parse(sizeA[0]), int.Parse(sizeA[1]));
            bMatrix = new Matrix(int.Parse(sizeB[0]), int.Parse(sizeB[1]));
        }
    }
}
