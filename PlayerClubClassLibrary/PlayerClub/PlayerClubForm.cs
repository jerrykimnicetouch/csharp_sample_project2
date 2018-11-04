using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayerClubClassLibrary;
using System.IO;

namespace PlayerClub
{
    public partial class PlayerClubForm : Form
    {
        private string openfile;
        private string openfileTeam;
        private string openfilePlayer;
        private BindingSource sourceTeam = new BindingSource(); //team 
        private BindingSource sourcePlayer = new BindingSource(); //Player
        private BindingSource sourcePlayerList = new BindingSource(); 
        private BindingSource sourcePlayerBeforeAssign = new BindingSource(); //Player before assign
        private BindingSource sourcePlayerAfterAssign = new BindingSource(); //Player after assign
        private string teamFileKey = "549286";
        private string playerFileKey = "111111";
        private Boolean isTeamFileOpen = false;
        private Boolean isPlayerFileOpen = false;

        private List<Player> rightAdded = new List<Player>(); //assign to right
        private List<Player> leftBefore = new List<Player>(); //assign before -- at left


        public PlayerClubForm()
        {
            InitializeComponent();

            //for team tab
            int yearRange = 40; //40 years
            int latestYearInt = 2018;
            int yearToAdd = 0;

            //founded year combo box
            for (int i = 0; i < yearRange; i++)
            {
                yearToAdd = latestYearInt - i;
                this.foundedYearCombo.Items.Add("" + yearToAdd);
            }

            //region ComboBox
            this.regionCombo.Items.Add("Auckland");
            this.regionCombo.Items.Add("Hamilton");
            this.regionCombo.Items.Add("Wellington");
            this.regionCombo.Items.Add("ChristChurch");



        }

        private void PlayerClubForm_Load(object sender, EventArgs e)
        {
            this.Text = "Welcome to Player Club";
        }
        private void fileOpenButton_Click(object sender, EventArgs e) // Team tab open file
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                this.openfile = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(this.openfile);
                    size = text.Length;

                    //get file type
                    int fileType = getDateFileType(text);
                    switch (fileType)
                    {
                        case 0: //Team data file
                            this.sourceTeam.DataSource = getTeamDataListFromString(text); //get data list for grid view
                            this.teamGridView.DataSource = this.sourceTeam; //display data in grid view
                            //set openfile to team file
                            this.openfileTeam = this.openfile;
                            //Style datagridview font size
                            this.teamGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel);
                            foreach (DataGridViewColumn column in this.teamGridView.Columns)
                            {
                                column.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel); //Microsoft Sans Serif; 8.25pt
                            }
                            //add team names list in combo box at player tab and assign tab
                            foreach (DataGridViewRow row in this.teamGridView.Rows)
                            {
                                this.teamAddPlayer.Items.Add(row.Cells[0].Value.ToString());
                                this.selectTeamAssignComboBox.Items.Add(row.Cells[0].Value.ToString());

                            }
                           
                            //set boolean to true for team file open
                            this.isTeamFileOpen = true;
                            if(!this.isPlayerFileOpen) MessageBox.Show("Please open corresponding Player data file too");
                            break;
                        case 1: //Player data file
                            this.sourcePlayer.DataSource = getPlayerDataListFromString(text); //get data list for grid view
                            this.playerDataGridView.DataSource = this.sourcePlayer; //display data in grid view

                            //show all player list at assgin datagrid view
                            this.sourcePlayerBeforeAssign.DataSource = this.sourcePlayer.DataSource; //get data list for grid view
                            this.playerBeforeAssign.DataSource = this.sourcePlayerBeforeAssign; //display data in grid view
                            //Style datagridview font size
                            this.playerBeforeAssign.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel);
                            foreach (DataGridViewColumn column in this.playerBeforeAssign.Columns)
                            {
                                column.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel); //Microsoft Sans Serif; 8.25pt
                            }

                            //set openfile to player file
                            this.openfilePlayer = this.openfile;
                            //Style datagridview font size
                            this.playerDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel);
                            foreach (DataGridViewColumn column in this.playerDataGridView.Columns)
                            {
                                column.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel); //Microsoft Sans Serif; 8.25pt
                            }
                            this.isPlayerFileOpen = true;
                            if (!this.isTeamFileOpen) MessageBox.Show("Please open corresponding Team data file too");
                            break;
                        case -1: //wrong file type 
                            MessageBox.Show("Wrong File. Please select right team or player data file");
                            break;
                    }
                   
                   

                }
                catch (IOException)
                {
                    Console.WriteLine("IO Exception");
                }
                /*(Exception e)
                {
                    Console.WriteLine(e.Message);
                }*/
            }

        }
        private int getDateFileType(string phrase)
        {
            //get parsed words list
            string[] words = phrase.Split(';');
            int i = 0;
            foreach (var word in words)
            {
                words[i] = word.Trim();

                i++;
            }

            //check if the file type is TEAM or Palyer or incorrect file type
            if ((words[0].Equals("TEAM")) && (words[1].Equals(this.teamFileKey)))
            {
                //File type is TEAM data file
                return 0; //The file type is not Team nor Player
            }
            else if((words[0].Equals("Player")) && (words[1].Equals(this.playerFileKey)))
            {
                //File type is Player data file
                return 1; //The file type is not Team nor Player
            }
            else
            {
                //In correct file type
                return -1; //The file type is not Team nor Player
            }

        }
        private List<Team> getTeamDataListFromString(string phrase)
        {
            string[] words = phrase.Split(';');
            int i = 0;
            foreach (var word in words)
            {
                words[i] = word.Trim();
                
                i++;
            }
            List<Team> listTeam = new List<Team> { };
            for (int j = 1; j < ((words.Length - 1) / 4); j++)
            {
               
                    listTeam.Add(new Team(words[j * 4 + 0], words[j * 4 + 1], words[j * 4 + 2], words[j * 4 + 3]));
            }

            return listTeam;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        //save team button
        private void saveTeamButton_Click(object sender, EventArgs e)
        {
            string dataString = "TEAM;" + this.teamFileKey + ";www;file;" + System.Environment.NewLine;


            foreach (DataGridViewRow row in this.teamGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string value = cell.Value.ToString();
                    //System.Console.WriteLine($"<{value}>");
                    //get data string to save in file
                    dataString = dataString + value + ";";
                }
                dataString = dataString + System.Environment.NewLine; //add a new line
            }
            //Write the data string to a file

            SaveFileDialog save = new SaveFileDialog();

            if (this.openfileTeam != null)
            {
                save.FileName = this.openfileTeam;
            }
            else
            {
                save.FileName = "DefaultOutputName.txt";
            }

            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {

                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine(dataString);
                writer.Dispose();
                writer.Close();
            }

        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            //get all team names in current data grid view 
            List<Team> items = new List<Team>();
            foreach (DataGridViewRow dr in this.teamGridView.Rows)
            {

                Team item = new Team(dr.Cells[0].Value.ToString(), dr.Cells[1].Value.ToString(), dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString());
                System.Console.WriteLine(dr.Cells[0].Value.ToString());
                items.Add(item);
            }
            List<Team> duplicateList = items.FindAll(x => x.Name.Trim() == this.nameTeam.Text.ToString().Trim());

            //required fields check - name of team
            if (this.nameTeam.Text.Trim() == string.Empty) //team name empty check
            {
                MessageBox.Show("You must enter team name!");
                return;
            }
            //team name duplication check
            else if ( duplicateList.Count() > 0) 
            {
                //duplicate 
                MessageBox.Show("There is duplicated team name. Please enter new team name!");
                return;
            }
            else
            {
                
                Team itemToAdd = new Team(this.nameTeam.Text, this.coachTeam.Text, this.foundedYearCombo.Text, this.regionCombo.Text);
                items.Add(itemToAdd);
                //diplay team list
                this.teamGridView.DataSource = null;
                this.teamGridView.DataSource = items;
                //Style datagridview font size
                this.teamGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel);
                foreach (DataGridViewColumn column in this.teamGridView.Columns)
                {
                    column.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel); //Microsoft Sans Serif; 8.25pt
                }
            }


        }
        private List<Player> getPlayerDataListFromString(string phrase)
        {
            string[] words = phrase.Split(';');
            int i = 0;
            foreach (var word in words)
            {
                words[i] = word.Trim();
                // System.Console.WriteLine($"<{words[i]}>");
                i++;
            }
            List<Player> listPlayer = new List<Player> { };
            for (int j = 1; j < ((words.Length - 1) / 7); j++)
            {
                listPlayer.Add(new Player(words[j * 7 + 0], words[j * 7 + 1], words[j * 7 + 2], words[j * 7 + 3], words[j * 7 + 4], words[j * 7 + 5], words[j * 7 + 6]
                    ));
              
            }
             
            return listPlayer;
        }
        // save player button
        private void savePlayerButton_Click(object sender, EventArgs e)
        {
            string dataString = "Player;" + this.playerFileKey + ";www;file;file;file;file;" + System.Environment.NewLine;

            foreach (DataGridViewRow row in this.playerDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string value = cell.Value.ToString();
                    //System.Console.WriteLine($"<{value}>");
                    //get data string to save in file
                    dataString = dataString + value + ";";
                }
                dataString = dataString + System.Environment.NewLine; //add a new line
            }
            //Write the data string to a file

            SaveFileDialog save = new SaveFileDialog();

            if (this.openfilePlayer != null)
            {
                save.FileName = this.openfilePlayer;
            }
            else
            {
                save.FileName = "DefaultOutputNamePlayer.txt";
            }

            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {

                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine(dataString);
                writer.Dispose();
                writer.Close();
            }
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            List<Player> items = new List<Player>();     //ORIGINAL CODE
            int size = 0;
            foreach (DataGridViewRow dr in this.playerDataGridView.Rows)
            {
                size++;
                Player item = new Player(dr.Cells[0].Value.ToString(), dr.Cells[1].Value.ToString(), dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString()
                    , dr.Cells[4].Value.ToString(), dr.Cells[5].Value.ToString(), dr.Cells[6].Value.ToString()
                    );
                //System.Console.WriteLine(dr.Cells[0].Value.ToString());
                items.Add(item);
            }
            //get DOB from date time picker
            string dob = dateTimePickerDOB.Value.Day.ToString() + "/" + dateTimePickerDOB.Value.Month + "/" + dateTimePickerDOB.Value.Year.ToString();

            //duplication check by -- team name, player name, DOB
            List<Player> duplicateList = items.FindAll(x => ( x.Team.ToLower().Trim() == this.teamAddPlayer.Text.ToLower().Trim() 
            && x.Name.ToLower().Trim() == this.nameAddPlayer.Text.ToLower().Trim()
            && x.DOB.Trim() == dob.Trim()
            ));

            //required fields check - name of team, player name
            if (this.teamAddPlayer.Text.Trim() == string.Empty || this.teamAddPlayer.Text.Trim()== "Select from list") //team name empty check
            {
                MessageBox.Show("You must select Team Name!");
                return;
            }
            else if (this.nameAddPlayer.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter Player Name!");
                return;
            }
            //duplication check by -- team name, player name, DOB
            else if (duplicateList.Count() > 0)
            {
                MessageBox.Show("There is a duplicate player! -- same name and same DOB in the same team ");
                return;
            }
            else
            {
                   
                Player itemToAdd = new Player("" + (size + 1),
                    this.nameAddPlayer.Text,
                    // this.dobAddPlayer.Text,
                    dob,
                    this.heightAddPlayer.Text,
                    this.weightAddPlayer.Text,
                    this.pobAddPlayer.Text,
                    this.teamAddPlayer.Text
                    );
                //add a new player
                items.Add(itemToAdd);
                //display all player
                this.playerDataGridView.DataSource = null;
                this.playerDataGridView.DataSource = items;
                //Style datagridview font size
                this.playerDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel);
                foreach (DataGridViewColumn column in this.playerDataGridView.Columns)
                {
                    column.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel); //Microsoft Sans Serif; 8.25pt
                }
              
            }


            

        }

        private void searchTeamButton_Click(object sender, EventArgs e)
        {
            //Empty player detail list at right datagridview at team tap
            this.sourcePlayerList.DataSource = null;
            this.PlayerList.DataSource = this.sourcePlayerList;

            //search team start
            string searchValue = searchBoxTeam.Text;

            this.teamGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in this.teamGridView.Rows)
                {
                    int len = row.Cells.Count;
                    row.Selected = false;       // For deselecting already selected row
                                                // Console.WriteLine("" + len);
                    for (int i = 0; i < len; i++)
                    {

                        if (row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            row.Selected = true;
                            break;
                        }
                    }


                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }



        private void searchBoxTeam_KeyDown(object sender, KeyEventArgs e) // Using enter as Search Box press
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.searchTeamButton_Click(sender, e);
            }
        }

        private void searchPlayerButton_Click(object sender, EventArgs e)
        {
            //search player start
            string searchValue = searchBoxPlayer.Text;
            this.playerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in this.playerDataGridView.Rows)
                {
                    int len = row.Cells.Count;
                    row.Selected = false;       // For deselecting already selected row
                                                // Console.WriteLine("" + len);
                    for (int i = 0; i < len; i++)
                    {

                        if (row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            row.Selected = true;
                            break;
                        }
                    }


                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void searchBoxPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.searchPlayerButton_Click(sender, e);
            }
        }
        // team selected row click
        private void teamGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(isPlayerFileOpen){

                DataGridView dgv = sender as DataGridView;
                if (dgv == null)
                    return;
                if (dgv.CurrentRow.Selected)
                {

                    List<Player> listPlayer = (List<Player>)this.sourcePlayer.DataSource;
                    List<Player> result = listPlayer.FindAll(x => x.Team == dgv.SelectedCells[0].Value.ToString());
                    if ( result.Count() > 0 ) //result empty check
                    {
                        this.sourcePlayerList.DataSource = result;
                        this.PlayerList.DataSource = this.sourcePlayerList;     // Binding datasource

                        this.PlayerList.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel);
                        foreach (DataGridViewColumn column in this.PlayerList.Columns)
                        {
                            column.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel); //Microsoft Sans Serif; 8.25pt
                        }
                    }
                    else
                    {
                        this.sourcePlayerList.DataSource = null;
                        this.PlayerList.DataSource = this.sourcePlayerList;
                        MessageBox.Show("No matched player with this team. Please add a player at Player tap");
                    }

                }
            }
            else
            {
                MessageBox.Show("Please open Player data file and try it again!");
            }
        }

        private void teamAddPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show("test");
        }

        private void teamAddPlayer_DropDown(object sender, EventArgs e)
        {
            //MessageBox.Show("test");
            if (!this.isTeamFileOpen)
            {
                MessageBox.Show("Please open team data file before do this!");
            }
            
        }

        private void selectTeamAssignComboBox_DropDown(object sender, EventArgs e)
        {
            if (!this.isTeamFileOpen)
            {
                MessageBox.Show("Please open team data file before do this!");
            }
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            if (isPlayerFileOpen && isTeamFileOpen)
            {

                DataGridView dgv = this.playerBeforeAssign;
                if (dgv == null)
                {
                    return;
                }
                   
                if (dgv.CurrentRow.Selected)
                {
                    //check if a team selected
                    if (this.selectTeamAssignComboBox.Text.Trim() == string.Empty || this.selectTeamAssignComboBox.Text.Trim() == "Select from list") //team name empty check
                    {
                        MessageBox.Show("You must select a Team to assign!");
                        return;
                    }
                    else
                    {
                      
                        foreach (DataGridViewRow dr in this.playerBeforeAssign.SelectedRows )
                        {
                            Player item = new Player(dr.Cells[0].Value.ToString(), dr.Cells[1].Value.ToString(), dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString()
                                , dr.Cells[4].Value.ToString(), dr.Cells[5].Value.ToString(), 
                               this.selectTeamAssignComboBox.Text.ToString() //change to selected team
                            );
                            this.rightAdded.Add(item);
                        }

                        this.sourcePlayerAfterAssign.DataSource = null;
                        this.playerAfterAssign.DataSource = null;
                        this.sourcePlayerAfterAssign.DataSource = this.rightAdded;
                        this.playerAfterAssign.DataSource = this.sourcePlayerAfterAssign;

                        //Style datagridview font size
                        this.playerAfterAssign.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel);
                        foreach (DataGridViewColumn column in this.playerAfterAssign.Columns)
                        {
                            column.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel); //Microsoft Sans Serif; 8.25pt
                        }
                        //remove selected rows from left
                        for (int i = 0; i < this.playerBeforeAssign.SelectedRows.Count; i++)
                        {
                           
                            try
                            {
                                int selectedIndex = this.playerBeforeAssign.SelectedRows[i].Index;
                                //MessageBox.Show(selectedIndex + "removed:" + this.playerBeforeAssign.SelectedRows.Count);

                                if (selectedIndex > -1)
                                {
                                    this.playerBeforeAssign.Rows.RemoveAt(selectedIndex);
                                    this.playerBeforeAssign.Refresh();
                                    //dataGridView1.Refresh(); // if needed
                                }
                            }
                            catch (InvalidOperationException ex)
                            {
                                MessageBox.Show("Unable to remove selected row at this time");
                            }
                        }
                   
                    }

                }
                else
                {
                    MessageBox.Show("please select the row to assign from left data grid view!");
                }
            }
            else
            {
                MessageBox.Show("Please open Player data file & team data file and try it again!");
            }
        }

        private void saveAssignButton_Click(object sender, EventArgs e)
        {

            List<Player> items = new List<Player>();     //ORIGINAL CODE
            int size = 0;
            foreach (DataGridViewRow dr in this.playerBeforeAssign.Rows)
            {
                size++;
                Player item = new Player(dr.Cells[0].Value.ToString(), dr.Cells[1].Value.ToString(), dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString()
                    , dr.Cells[4].Value.ToString(), dr.Cells[5].Value.ToString(), dr.Cells[6].Value.ToString()
                    );
                //System.Console.WriteLine(dr.Cells[0].Value.ToString());
                items.Add(item);
            }

            foreach (DataGridViewRow dr in this.playerAfterAssign.Rows)
            {
                size++;
                Player item = new Player(dr.Cells[0].Value.ToString(), dr.Cells[1].Value.ToString(), dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString()
                    , dr.Cells[4].Value.ToString(), dr.Cells[5].Value.ToString(), dr.Cells[6].Value.ToString()
                    );
                //System.Console.WriteLine(dr.Cells[0].Value.ToString());
                items.Add(item);
            }

            //sort by id
            items.Sort(delegate (Player x, Player y)
            {
                return x.ID.CompareTo(y.ID);
            });


            List<Player> result = items;

            //save player list
            string dataString = "Player;" + this.playerFileKey + ";www;file;file;file;file;" + System.Environment.NewLine;

            for(int i =0; i < result.Count(); i++)
            {
                //result[i].ID
                string value = result[i].ID.ToString() + ";"
                     + result[i].Name.ToString() + ";"
                      + result[i].DOB.ToString() + ";"
                       + result[i].Height.ToString() + ";"
                        + result[i].Weight.ToString() + ";"
                         + result[i].PlaceOfBirth.ToString() + ";"
                          + result[i].Team.ToString() + ";" + System.Environment.NewLine; 
;
                //get data string to save in file
                dataString = dataString + value ;
            }

            
            //Write the data string to a file

            StreamWriter writer = new StreamWriter(this.openfilePlayer);
            writer.WriteLine(dataString);
            writer.Dispose();
            writer.Close();


            //refresh left grid view with the saved
            this.sourcePlayerAfterAssign.DataSource = null;
            this.playerAfterAssign.DataSource = null;

            try
            {
                string text = File.ReadAllText(this.openfilePlayer);
                size = text.Length;

                //get file type
                int fileType = getDateFileType(text);
                switch (fileType)
                {
                    case 0: //Team data file
                        MessageBox.Show("File exception occurs in save operation");
                        break;
                    case 1: //Player data file
                        this.sourcePlayer.DataSource = getPlayerDataListFromString(text); //get data list for grid view
                        this.playerDataGridView.DataSource = this.sourcePlayer; //display data in grid view

                        //show all player list at assgin datagrid view
                        this.sourcePlayerBeforeAssign.DataSource = this.sourcePlayer.DataSource; //get data list for grid view
                        this.playerBeforeAssign.DataSource = this.sourcePlayerBeforeAssign; //display data in grid view
                                                                                            //Style datagridview font size
                        this.playerBeforeAssign.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel);
                        foreach (DataGridViewColumn column in this.playerBeforeAssign.Columns)
                        {
                            column.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel); //Microsoft Sans Serif; 8.25pt
                        }

                        //set openfile to player file
                        this.openfilePlayer = this.openfile;
                        //Style datagridview font size
                        this.playerDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel);
                        foreach (DataGridViewColumn column in this.playerDataGridView.Columns)
                        {
                            column.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, GraphicsUnit.Pixel); //Microsoft Sans Serif; 8.25pt
                        }
                        this.isPlayerFileOpen = true;
                        MessageBox.Show("The update has been successfully saved to the file and refreshed at left data grid view!!");
                        break;
                    case -1: //wrong file type 
                        MessageBox.Show("File exception occurs in save operation");
                        break;
                }



            }
            catch (IOException)
            {
                Console.WriteLine("IO Exception");
            }




        }
    }
}



    
