using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//the designer in Visual Studio. Go to Tools > Options > Environment > Preview Features and select the Use the preview Windows Forms designer for .NET Core apps option.
namespace WinFormsApp
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceRef.Service1Client client = new ServiceRef.Service1Client();


                int nbr = Int32.Parse(textBoxNbr.Text);
                Task<int> taskVal = new Task<int>(() => client.Fibonacci(nbr));
                taskVal.Start();
                //int taskVal = await client.FibonacciAsync(nbr);
                var val = await taskVal;
                this.Hide();
                MessageBox.Show(val.ToString());
            }
            catch (Exception ex)
            {
                label3.Text = "Veuillez entrer un chiffre"; //ex.ToString();

            }
        }

        private void FormClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
