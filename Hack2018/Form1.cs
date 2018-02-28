using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http;

namespace Hack2018
{
    public partial class Form1 : Form
    {
        Bitmap startImage;
        Bitmap endImage;
        Bitmap changeImage;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            float latitude  = float.Parse(textBoxLat.Text);
            float longitude = float.Parse(textBoxLon.Text);
            float zoomLevel = float.Parse(textBoxZoom.Text);

            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate   = dateTimePickerEnd.Value.Date;

            startImage = NASA.getImageAt(
                longitude, latitude, zoomLevel, startDate);
            pictureBoxStart.Image = startImage;

            endImage = NASA.getImageAt(
                longitude, latitude, zoomLevel, endDate);
            pictureBoxEnd.Image = endImage;

            changeImage = Comparator.Compare(startImage, endImage, Comparator.Flag.Forest);

            checkBoxChange.Checked = false;
        }

        private void checkBoxChange_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChange.Checked == true)
                pictureBoxEnd.Image = changeImage;
            else
                pictureBoxEnd.Image = endImage;
        }
    }
}
