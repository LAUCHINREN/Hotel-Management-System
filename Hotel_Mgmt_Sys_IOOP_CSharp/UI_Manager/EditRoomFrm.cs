using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class EditRoomFrm : Form
    {
        private DataTable _dataTable;
        private DataRowView _rowView;

        public DataTable dataTable { get; set; }
        public DataRowView rowView { get; set; }

        public EditRoomFrm(DataRowView rowView, DataTable dt)
        {
            InitializeComponent();

            _rowView = rowView;
            _dataTable = dt;
            LoadDataOptions();
            RetrieveEditRowValues(); 
        }

        private void LoadDataOptions()
        {
            List<string> roomTypeItems = new List<string> { "Single Room", "Family Room", "Deluxe Room", "Family Room" };
            List<string> bedTypeItems = new List<string> { "Single Bed(s)", "Queen Bed(s)" };


            cboRoomType.Items.AddRange(roomTypeItems.ToArray());
            cboBedType.Items.AddRange(bedTypeItems.ToArray());
        }

        private void RetrieveEditRowValues()
        {
            DataRow row = _rowView.Row;
            DatabaseUtility dBUtil = new DatabaseUtility("dBConnect");

            Dictionary<string, string> rowDict = dBUtil.GetRowData("Room", _dataTable.Columns[0].ColumnName, row[_dataTable.Columns[0].ColumnName].ToString());
            List<string> header = dBUtil.RetriveTableHeader("Room");

            txtRoomID.Text = rowDict[header[0]];
            nudLevel.Value = decimal.Parse(rowDict[header[1]].Split('|')[0].Replace("Level" ,""));
            nudRoom.Value = decimal.Parse(rowDict[header[1]].Split('|')[1].Replace("Room", ""));
            cboRoomType.SelectedItem = rowDict[header[2]];
            nudGuest.Value = decimal.Parse(rowDict[header[3]]);
            nudBeds.Value = decimal.Parse(rowDict[header[4]].Split(' ')[0]);
            string[] bedStrs = rowDict[header[4]].Split(' ');
            string bedType = "";
            for (int i = 0; i < bedStrs.Length; i++)
            {
                if (i == 0)
                    continue;
                else
                {
                    bedType += bedStrs[i];
                    bedType += " ";
                }
            }
            cboBedType.SelectedItem = bedType.TrimStart().TrimEnd();
            nudBathroom.Value = decimal.Parse(rowDict[header[5]]);
            
            if (rowDict[header[6]].ToLower() == "bathtub")
                radBathtub.Checked = true;
            else
                radStandingShower.Checked = true;
            string[] stringSeparators = new string[] { "set(s)" };
            string randomStr = rowDict[header[7]].Replace("\r", "").Split('\n')[0].Split(stringSeparators, StringSplitOptions.None)[0];
            nudAmenities.Value = decimal.Parse(rowDict[header[7]].Replace("\r", "").Split('|')[0].Split(stringSeparators, StringSplitOptions.None)[0]);
            txtAmenities.Text = rowDict[header[7]].Split('|')[1];
            txtPrice.Text = rowDict[header[8]];
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

        private void btnUpdateRoom_Click(object sender, EventArgs e)
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
                Room room = new Room(int.Parse(txtRoomID.Text), roomLocation,
                                    roomType,
                                    int.Parse(nudGuest.Value.ToString()),
                                    bedNum,
                                    int.Parse(bathroomNum),
                                    bathroomType,
                                    amenities,
                                    double.Parse(txtPrice.Text),
                                    "Vacant");

                int status = room.editRoom();

                if (status > 0)
                {
                    _dataTable.Clear();
                    List<List<string>> dataRows = room.viewAllRooms();
                    for (int r = 0; r < dataRows.Count; r++)
                    {
                        DataRow row = _dataTable.NewRow();
                        int indexData = 0;
                        foreach (DataColumn col in _dataTable.Columns)
                        {
                            row[col.ColumnName] = dataRows[r][indexData].ToString();
                            indexData++;
                        }
                        _dataTable.Rows.Add(row);
                    }
                    this.Close(); 
                }

            }

        }




    }
}
