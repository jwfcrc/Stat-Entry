using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryStatisticsApp
{
    public partial class Form1 : Form
    {
        // Counter variables
        int InfoCount = 0;
        int DirectionCount = 0;
        int TechCount = 0;
        int TeleCount = 0;
        int EContCount = 0;
        int TotalCount = 0;

        string DoorCountBackup = "";
        string DoorCount = "";
        string LocStr = "";
        string DateStr = "";
        string fileOutput = "";
        string filePath = "";

        //bool variables
        bool isResetting = false;
        bool isStarted = false;
        bool isLoaded = false;
        bool isDataEntered = false;

        public Form1()
        {
            InitializeComponent();
            //Load location from settings
            LocationComboBox.SelectedIndex = LibraryStatistics.Properties.Settings.Default.LocationSelection;
            //Block mouse for location combobox
            LocationComboBox.MouseWheel += new MouseEventHandler(DoNothing_MouseWheel);
        }

        // Blocks mousewheel control
        private void DoNothing_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ee = (HandledMouseEventArgs)e;
            ee.Handled = true;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check door count
            if (DoorCountInput.Text != "0")
            {
                DoorCountBackup = DoorCountInput.Text;
            }
            //Check if location requires door count
            if (LocationComboBox.Text.Contains("Info"))
            {
                //set doorcount to 0 and lock, backup previous data
                DoorCountInput.Text = "0";
                DoorCountInput.ReadOnly = true;
            }
            else
            {
                //unlock doorcount box
                DoorCountInput.ReadOnly = false;

                if (DoorCountBackup.Length > 0)
                {
                    DoorCountInput.Text = DoorCountBackup;
                }

            }
            // check for existing data if not changed from reset
            if (isResetting == false)
            {
                //CheckAndLoadExistingData();
            }

        }

        private void PlusInfoButton_MouseClick(object sender, MouseEventArgs e)
        {
            InfoCount++;
            InfoEnquiriesCountLabel.Text = InfoCount.ToString();
            isDataEntered = true;
            RemoveResetButton();
        }

        private void PlusDirectButton_MouseClick(object sender, MouseEventArgs e)
        {
            DirectionCount++;
            DirectionCountLabel.Text = DirectionCount.ToString();
            isDataEntered = true;
            RemoveResetButton();
        }

        private void PlusTechButton_MouseClick(object sender, MouseEventArgs e)
        {
            TechCount++;
            TechCountLabel.Text = TechCount.ToString();
            isDataEntered = true;
            RemoveResetButton();
        }

        private void PlusTeleButton_MouseClick(object sender, MouseEventArgs e)
        {
            TeleCount++;
            TeleCountLabel.Text = TeleCount.ToString();
            isDataEntered = true;
            RemoveResetButton();
        }

        private void PlusEcontentButton_MouseClick(object sender, MouseEventArgs e)
        {
            EContCount++;
            EContCountLabel.Text = EContCount.ToString();
            isDataEntered = true;
            RemoveResetButton();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Telephone enquiries add button
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //Information enquiries add button
        private void PlusInfoButton_Click(object sender, EventArgs e)
        {
            
        }

        //Information enquries minus button
        private void MinusInfoButton_Click(object sender, EventArgs e)
        {
            InfoCount--;
            InfoEnquiriesCountLabel.Text = InfoCount.ToString();
        }

        private void InfoEnquiriesLabel_Click(object sender, EventArgs e)
        {

        }

        //Directional enquiries add button
        private void PlusDirectButton_Click(object sender, EventArgs e)
        {

        }

        //Directional enquiries minus button
        private void MinusDirectButton_Click(object sender, EventArgs e)
        {
            DirectionCount--;
            DirectionCountLabel.Text = DirectionCount.ToString();
        }

        //Technical enquiries add button
        private void PlusTechButton_Click(object sender, EventArgs e)
        {

        }

        //Technical enquiries minus button
        private void MinusTechButton_Click(object sender, EventArgs e)
        {
            TechCount--;
            TechCountLabel.Text = TechCount.ToString();
        }

        //Telephone enquiries minus button
        private void MinusTeleButton_Click(object sender, EventArgs e)
        {
            TeleCount--;
            TeleCountLabel.Text = TeleCount.ToString();
        }

        //E-Content enquiries add button
        private void PlusEcontentButton_Click(object sender, EventArgs e)
        {

        }

        //E-Content enquiries minus button
        private void MinusEcontentButton_Click(object sender, EventArgs e)
        {
            EContCount--;
            EContCountLabel.Text = EContCount.ToString();
        }

        // Save button
        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Check Location is entered
            if (LocationComboBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Please select a location");
            }
            //Check Door Count is entered
            else if (DoorCountInput.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Please add the door count");
            }
            //Check door count is only numbers
            else if (!DoorCountInput.Text.All(char.IsDigit))
            {
                System.Windows.Forms.MessageBox.Show("Please check that the door count only contains numbers with no spaces or other characters");
            }
            //Check counter values for input
            else if (InfoCount == 0 &&
                DirectionCount == 0 &&
                TechCount == 0 &&
                TeleCount == 0 &&
                EContCount == 0)
            {
                System.Windows.Forms.MessageBox.Show("Error: all enquiries have a value of 0");
            }
            //Collect and save data
            else
            {
                DoorCount = DoorCountInput.Text;
                LocStr = LocationComboBox.Text;
                DateStr = dateTimePicker1.Text;
                TotalCount = InfoCount + DirectionCount + TechCount + TeleCount + EContCount;

                fileOutput = "Date: " + DateStr + "\nLocation: " + LocStr +
                    "\n\nInformation Enquiries: " + InfoCount.ToString() +
                    "\nDirectional Enquiries: " + DirectionCount.ToString() +
                    "\nTechnical Enquiries: " + TechCount.ToString() +
                    "\nTelephone Enquiries: " + TeleCount.ToString() +
                    "\nE-Content Enquiries: " + EContCount.ToString() +
                    "\n\nTotal Enquiries: " + TotalCount.ToString() +
                    "\n\nDoor Count: " + DoorCount.ToString();

                string extension = ".txt";
                if (Directory.Exists(LibraryStatistics.Properties.Settings.Default.SaveLocation))
                {
                    filePath = LibraryStatistics.Properties.Settings.Default.SaveLocation;
                    string fileCheck = Path.Combine(filePath, LocStr + DateStr + extension);

                    //if file exists ask to double check date and location and make user type overwrite to save new copy
                    if (File.Exists(fileCheck))
                    {
                        // if file has been loaded
                        if (isLoaded)
                        {
                            if (MessageBox.Show("Saving will update the loaded stats, continue?", "Loaded Stats", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                // overwrite file
                                WriteStatsToFile();
                            }
                            else
                            {
                                // dont save
                            }
                        }
                        // if file hasnt been loaded
                        else
                        {
                            if (MessageBox.Show("Please check the location and dates chosen. Only click yes if you wish to overwrite the existing save file!", "File Already Exists!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                // user clicked yes
                                if (MessageBox.Show("Are you really sure you wish to overwrite the existing file", "File Already Exists!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    // overwrite file
                                    WriteStatsToFile();
                                }
                                else
                                {
                                    // dont save
                                }
                            }
                            else
                            {
                                // user clicked no
                                // dont save
                            }
                        }
                        
                    }
                    else
                    {
                        WriteStatsToFile();
                    }
                }
                else
                {
                    string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Statistic Save Files");
                    Directory.CreateDirectory(path);
                    filePath = path;
                    string fileCheck = Path.Combine(filePath, LocStr + DateStr + extension);

                    //if file exists ask to double check date and location and make user type overwrite to save new copy
                    if (File.Exists(fileCheck))
                    {
                        // if file has been loaded
                        if (isLoaded)
                        {
                            if (MessageBox.Show("Saving will update the loaded stats, continue?", "Loaded Stats", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                // overwrite file
                                WriteStatsToFile();
                            }
                            else
                            {
                                // dont save
                            }
                        }
                        // if file hasnt been loaded
                        else
                        {
                            if (MessageBox.Show("Please check the location and dates chosen. Only click yes if you wish to overwrite the existing save file!", "File Already Exists!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                // user clicked yes
                                if (MessageBox.Show("Are you really sure you wish to overwrite the existing file", "File Already Exists!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    // overwrite file
                                    WriteStatsToFile();
                                }
                                else
                                {
                                    // dont save
                                }
                            }
                            else
                            {
                                // user clicked no
                                // dont save
                            }
                        }

                    }
                    else
                    {
                        WriteStatsToFile();
                    }
                }

            }


        }

        private void WriteStatsToFile()
        {
            var dest = Path.Combine(filePath, LocStr + DateStr + ".txt");
            using (StreamWriter File = new StreamWriter(dest, false))
            {
                File.Write(fileOutput);
            }
            //let user know save was successful
            SaveSuccess();
            //close form
            isResetting = true;
            this.Close();
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        //Form initialisation
        private void Form1_Load(object sender, EventArgs e)
        {
            //Check if application is already running
            if (Process.GetProcessesByName("LibraryStatisticsApp").Length > 1 || Process.GetProcessesByName("LibraryStatistics").Length > 1)
            {
                //If it is running inform the user and close this instance
                DialogResult dialogResult = MessageBox.Show("Application already running", "Caution!", MessageBoxButtons.OK);
                this.Close();
            }
            SetMyCustomFormat();

            //set filepath to default
            filePath = LibraryStatistics.Properties.Settings.Default.SaveLocation;

            //Check if default path is available, if not go to backup
            if (!Directory.Exists(LibraryStatistics.Properties.Settings.Default.SaveLocation))
            {
                filePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Statistic Save Files");
            }

            //Set the starting position on the screen
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - (Size.Height * 2));
            
            //Disable buttons so location and date is set first
            //StatButtonActivation(false);

        }

        //Enable or Disable all buttons for entering/saving data
        private void StatButtonActivation(bool activate)
        {
            PlusInfoButton.Enabled = activate;
            PlusDirectButton.Enabled = activate;
            PlusTechButton.Enabled = activate;
            PlusTeleButton.Enabled = activate;
            PlusEcontentButton.Enabled = activate;
            SaveButton.Enabled = activate;
            LoadButton.Enabled = activate;
        }

        //Reset button
        private void ResetButton_Click(object sender, EventArgs e)
        {
            //Pop-Up warning
            DialogResult dialogResult = MessageBox.Show("All unsaved data will be lost, are you sure you want to reset?", "Caution!", MessageBoxButtons.YesNo);

            //If the user is sure, reset clear all counters
            if (dialogResult == DialogResult.Yes)
            {
                ResetDataInForm();  
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
            
        }

        //Method called on form closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Dont prompt if App is already running
            if (Process.GetProcessesByName("LibraryStatisticsApp").Length > 1 || Process.GetProcessesByName("LibraryStatistics").Length > 1 || !isStarted)
            {
                //closing
            }
            //If this is the only instance prompt before closing unless form is resetting
            else if (isResetting)
            {
                //save location selection if changed
                LibraryStatistics.Properties.Settings.Default.LocationSelection = LocationComboBox.SelectedIndex;
                LibraryStatistics.Properties.Settings.Default.Save();
            }
            else
            {
                //save location selection if changed
                LibraryStatistics.Properties.Settings.Default.LocationSelection = LocationComboBox.SelectedIndex;
                LibraryStatistics.Properties.Settings.Default.Save();

                if (MessageBox.Show("All unsaved data will be lost, are you sure you want to exit?",
                               "Caution!",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // check for existing data if not changed from reset
            if (isResetting == false)
            {
                //CheckAndLoadExistingData();
            }
        }

        private void ResetButton_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(ResetButton, "Click to reset data");
        }

        private void SaveButton_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(SaveButton, "Click to save todays data");
        }

        private void DoorCountLabel_MouseHover(object sender, EventArgs e)
        {

        }

        // Check for an existing file and if it exists load the data (WIP)
        private void CheckAndLoadExistingData()
        {
            LocStr = LocationComboBox.Text;
            DateStr = dateTimePicker1.Text;
            string ext = ".txt";
            string file = Path.Combine(filePath, LocStr + DateStr + ext);
            //initialise data list
            List<int> dataList = new List<int>();

            // if the file exists load the data
            if (File.Exists(file))
            {
                if (MessageBox.Show("Stats for the selected day and location exist, would you like to load this data",
               "File Found!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string fileContentsStr = File.ReadAllText(file);
                    //Debug.Print(fileContentsStr);

                    //populate data list
                    string[] digits = Regex.Split(fileContentsStr, @"\D+");
                    foreach (string value in digits)
                    {
                        int number;
                        if (int.TryParse(value, out number))
                        {
                            //Debug.Print(value);
                            dataList.Add(number);
                        }

                    }
                    //update data labels on form
                    InfoEnquiriesCountLabel.Text = dataList[3].ToString();
                    InfoCount = dataList[3];
                    DirectionCountLabel.Text = dataList[4].ToString();
                    DirectionCount = dataList[4];
                    TechCountLabel.Text = dataList[5].ToString();
                    TechCount = dataList[5];
                    TeleCountLabel.Text = dataList[6].ToString();
                    TeleCount = dataList[6];
                    EContCountLabel.Text = dataList[7].ToString();
                    EContCount = dataList[7];
                    DoorCountInput.Text = dataList[9].ToString();
                    DoorCount = dataList[9].ToString();

                    //clear datalist for new data
                    dataList.Clear();
                    LoadSuccess();
                }

            }
            else
            {
                //Debug.Print(file + "not found");
                //MessageBox.Show("No Files Found");
            }
        }

        private void LoadSuccess()
        {
            //successful Load
            MessageBox.Show("Loaded Successfully");
            isLoaded = true;
            isDataEntered = true;

            //mark form as reading from loaded file
            //this.Text = "Library Statistics (loaded file)";
        }

        private void SaveSuccess()
        {
            //successful save
            MessageBox.Show("Saved Successfully");

            //this.Text = "Library Statistics";
        }

        private void ResetDataInForm()
        {
            isResetting = true;
            /*DoorCountBackup = "";
            InfoCount = 0;
            InfoEnquiriesCountLabel.Text = InfoCount.ToString();
            DirectionCount = 0;
            DirectionCountLabel.Text = DirectionCount.ToString();
            TechCount = 0;
            TechCountLabel.Text = DirectionCount.ToString();
            TeleCount = 0;
            TeleCountLabel.Text = TeleCount.ToString();
            EContCount = 0;
            EContCountLabel.Text = EContCount.ToString();
            DoorCount = "0";
            DoorCountInput.Text = DoorCount.ToString();
            dateTimePicker1.Value = DateTime.Now;*/

            Application.Restart();

            //remove loaded tag if file was loaded
            this.Text = "Library Statistics";
            isResetting = false;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            CheckAndLoadExistingData();
        }

        private void LoadButton_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(LoadButton, "Click to load data for the selected date and location");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //Pop Up to check if user has setup date and location
            //If yes unlock buttons, Lock Selectors (date, loc) and remove this button
            if (MessageBox.Show("Is the Date and Location set correctly?",
               "Setup Check",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                StartButton.Visible = false;
                LocationComboBox.Enabled = false;
                dateTimePicker1.Enabled = false;
                CheckAndLoadExistingData();
                isStarted = true;

                // remove door count if not needed
                if (LocationComboBox.Text.Contains("Info"))
                {
                    DoorCountInput.Visible = false;
                    DoorCountLabel.Visible = false;
                }
            }

            //If no do nothing
        }

        // remove the reset button and stop it from being used if data has been entered
        private void RemoveResetButton()
        {
            if (isDataEntered)
            {
                ResetButton.Enabled = false;
                ResetButton.Visible = false;
            }

        }

        // Restrict characters for doorcount to numbers only
        private void DoorCountInput_KeyPress(object sender, KeyPressEventArgs args)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;
            int keyvalue = args.KeyChar;

            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;
            // Allow nothing else
            args.Handled = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            DateLabel.Focus();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            DateLabel.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://intrac.frasercoast.qld.gov.au/drf/?3512115");
        }
    }
}
