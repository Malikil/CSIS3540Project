using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBEntities;

namespace CSIS3540Project
{
    public partial class StudentsReservations : Form
    {
        
        public StudentsReservations()
        {
            InitializeComponent();
        }

        private void StudentsReservations_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datein, dateout;
            label1.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            label2.Text = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            datein = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            dateout = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            NamedPipeClientStream outstream = new NamedPipeClientStream(".", "ProjectServerIn", PipeDirection.Out);
            NamedPipeClientStream instream = new NamedPipeClientStream(".", "ProjectServerOut", PipeDirection.In);
            try
            {
                outstream.Connect(3000);
                instream.Connect(3000);
                using (StreamWriter toserver = new StreamWriter(outstream))
                {
                    toserver.WriteLine("AVAILABLE");
                    toserver.WriteLine($"{datein}");
                    toserver.WriteLine($"{dateout}");
                }
                StreamReader sr = new StreamReader(instream);
                sr.ReadToEndAsync().ContinueWith(showRooms, sr);
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Can't connect to the server");
            }
        }
        private void showRooms(Task<string> task, object sr)
        {
            List<DormRoom> rList = new List<DormRoom>();


            (sr as StreamReader).Close();
        }
    }
}
