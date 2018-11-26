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
using System.Xml.Serialization;

namespace ServerProgram.Forms
{
    public partial class StudentsReservations : Form
    {
        
        public StudentsReservations()
        {
            InitializeComponent();
        }

        private void GetAvailabilityFromServer_EventHandler(object sender, EventArgs e)
        {
            string datein, dateout;
            label1.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            label2.Text = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            datein = dateTimePicker1.Value.ToString();
            dateout = dateTimePicker2.Value.ToString();
            NamedPipeClientStream outstream = new NamedPipeClientStream(".", "ProjectServerIn", PipeDirection.Out);
            NamedPipeClientStream instream = new NamedPipeClientStream(".", "ProjectServerOut", PipeDirection.In);
            try
            {
                outstream.Connect(3000);
                instream.Connect(3000);
                using (StreamWriter toserver = new StreamWriter(outstream))
                {
                    toserver.WriteLine("AVAILABLE");
                    toserver.WriteLine(datein);
                    toserver.WriteLine(dateout);
                }

                Task.Factory.StartNew(() =>
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<DormRoom>));
                    List<DormRoom> roomList;
                    using (StreamReader fromserver = new StreamReader(instream))
                        roomList = xml.Deserialize(fromserver) as List<DormRoom>;

                    dataGridView1.DataSource = roomList;
                });
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Can't connect to the server");
            }
        }
    }
}
