using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class AddRoomFrm : Form
    {
        private DataTable _dataTable;

        public DataTable dataTable {get; set;}


        public AddRoomFrm(DataTable dt)
        {
            InitializeComponent();
            LoadDataOptions();

            _dataTable = dt; 
        }

        private void LoadDataOptions()
        {          
            List<string> roomTypeItems = new List<string>{ "Single Room", "Family Room", "Deluxe Room", "Family Room"};
            List<string> bedTypeItems = new List<string> { "Single Bed(s)", "Queen Bed(s)"};


            cboRoomType.Items.AddRange(roomTypeItems.ToArray());
            cboBedType.Items.AddRange(bedTypeItems.ToArray());
        }
        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            //Retrive values from UI 
            if (nudLevel.Value == 0 || nudRoom.Value == 0)
            {

            }
            else
            {

                string roomLocation = $"Level {nudLevel.Value.ToString()} | Room {nudRoom.Value.ToString()}";

                string roomType = ""; 
                if (cboRoomType.SelectedItem != null)
                {
                    roomType = cboRoomType.SelectedItem.ToString(); 
                }
                string bedNum = "";
                if (cboBedType.SelectedItem != null)
                {
                    bedNum = nudBeds.Value.ToString() + " " + cboBedType.SelectedItem.ToString();
                }

                string bathroomType = "";
                if (radStandingShower.Checked)
                    bathroomType = radStandingShower.Text;
                else if (radBathtub.Checked)
                    bathroomType = radBathtub.Text;
                string bathroomNum = nudBathroom.Value.ToString();
                string amenities = nudAmenities.Value.ToString() + " " + lblAmenities.Text + "\n" + txtAmenities.Text;
                //List<string> AmenitiesList = new List<string>();
                //foreach (Control control in this.grpAmenities.Controls)
                //{
                //    if (control is CheckBox)
                //    {
                //        CheckBox checkBox = (CheckBox)control;
                //        AmenitiesList.Add(checkBox.Text);
                //    }
                //}
                Room room = new Room(int.Parse(txtRoomID.Text), roomLocation,
                                    roomType,
                                    int.Parse(nudGuest.Value.ToString()),
                                    bedNum,
                                    int.Parse(bathroomNum),
                                    bathroomType,
                                    amenities,
                                    double.Parse(txtPrice.Text));
                int status = room.addRoom();

                if (status > 0)
                {
                    DataRow newRow = _dataTable.NewRow();
                    List<string> dataRows = new List<string>()
                    {
                        txtRoomID.Text,
                        roomLocation,
                        roomType,
                        nudGuest.Value.ToString(),
                        bedNum,
                        bathroomNum,
                        bathroomType,
                        amenities,
                        double.Parse(txtPrice.Text).ToString("0.00")
                    };

                    int indexData = 0;
                    foreach (DataColumn col in _dataTable.Columns)
                    {
                        newRow[col.ColumnName] = dataRows[indexData].ToString();
                        indexData++;
                    }
                    _dataTable.Rows.Add(newRow);
                }
                
            }





            //for (int r = 0; r < dataRows.Count; r++)
            //{
                
            //}

        }

        private void btnResetAllRoomFields_Click(object sender, EventArgs e)
        {
            txtRoomID.Text = "-"; 
            
        }

        private void btnGenerateID_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            txtRoomID.Text = room.generateRoomID((int)nudLevel.Value, (int)nudRoom.Value).ToString();
        }

        //private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkSelectAll.Checked)
        //    {
        //        chkSceenTV.Checked = true;
        //        chkWIFI.Checked = true;
        //        chkAirCon.Checked = true;
        //        chkSofa.Checked = true;
        //        chkMiniFridge.Checked = true;
        //        chkBeverageMaker.Checked = true;
        //        chkElectricKettle.Checked = true;
        //        chkHairDryer.Checked = true;

        //        chkSelectAll.Text = "Unselect All";
        //    }
        //    else
        //    {
        //        chkSceenTV.Checked = false;
        //        chkWIFI.Checked = false;
        //        chkAirCon.Checked = false;
        //        chkSofa.Checked = false;
        //        chkMiniFridge.Checked = false;
        //        chkBeverageMaker.Checked = false;
        //        chkElectricKettle.Checked = false;
        //        chkHairDryer.Checked = false;

        //        chkSelectAll.Text = "Select All";
        //    }

        //}
    }
}
