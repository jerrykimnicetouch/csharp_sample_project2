namespace PlayerClub
{
    partial class PlayerClubForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabTeamPage = new System.Windows.Forms.TabPage();
            this.PlayerList = new System.Windows.Forms.DataGridView();
            this.searchBoxTeam = new System.Windows.Forms.TextBox();
            this.searchTeamButton = new System.Windows.Forms.Button();
            this.regionCombo = new System.Windows.Forms.ComboBox();
            this.foundedYearCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.coachTeam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTeam = new System.Windows.Forms.TextBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.saveTeamButton = new System.Windows.Forms.Button();
            this.teamGridView = new System.Windows.Forms.DataGridView();
            this.tabPlayerPage = new System.Windows.Forms.TabPage();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.teamAddPlayer = new System.Windows.Forms.ComboBox();
            this.searchBoxPlayer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.heightAddPlayer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pobAddPlayer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.weightAddPlayer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameAddPlayer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.searchPlayerButton = new System.Windows.Forms.Button();
            this.addPlayerButtonNew = new System.Windows.Forms.Button();
            this.savePlayerButton = new System.Windows.Forms.Button();
            this.playerDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.assignButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.playerAfterAssign = new System.Windows.Forms.DataGridView();
            this.playerBeforeAssign = new System.Windows.Forms.DataGridView();
            this.fileOpenButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.selectTeamAssignComboBox = new System.Windows.Forms.ComboBox();
            this.saveAssignButton = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.tabTeamPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamGridView)).BeginInit();
            this.tabPlayerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerAfterAssign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBeforeAssign)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabTeamPage);
            this.mainTabControl.Controls.Add(this.tabPlayerPage);
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 56);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1068, 591);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabTeamPage
            // 
            this.tabTeamPage.Controls.Add(this.PlayerList);
            this.tabTeamPage.Controls.Add(this.searchBoxTeam);
            this.tabTeamPage.Controls.Add(this.searchTeamButton);
            this.tabTeamPage.Controls.Add(this.regionCombo);
            this.tabTeamPage.Controls.Add(this.foundedYearCombo);
            this.tabTeamPage.Controls.Add(this.label6);
            this.tabTeamPage.Controls.Add(this.label5);
            this.tabTeamPage.Controls.Add(this.label4);
            this.tabTeamPage.Controls.Add(this.coachTeam);
            this.tabTeamPage.Controls.Add(this.label3);
            this.tabTeamPage.Controls.Add(this.nameTeam);
            this.tabTeamPage.Controls.Add(this.addTeamButton);
            this.tabTeamPage.Controls.Add(this.saveTeamButton);
            this.tabTeamPage.Controls.Add(this.teamGridView);
            this.tabTeamPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTeamPage.Location = new System.Drawing.Point(4, 34);
            this.tabTeamPage.Name = "tabTeamPage";
            this.tabTeamPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeamPage.Size = new System.Drawing.Size(1060, 553);
            this.tabTeamPage.TabIndex = 1;
            this.tabTeamPage.Text = "Team";
            this.tabTeamPage.UseVisualStyleBackColor = true;
            // 
            // PlayerList
            // 
            this.PlayerList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.PlayerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerList.Location = new System.Drawing.Point(459, 210);
            this.PlayerList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PlayerList.Name = "PlayerList";
            this.PlayerList.RowTemplate.Height = 27;
            this.PlayerList.Size = new System.Drawing.Size(594, 323);
            this.PlayerList.TabIndex = 36;
            // 
            // searchBoxTeam
            // 
            this.searchBoxTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxTeam.Location = new System.Drawing.Point(459, 32);
            this.searchBoxTeam.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchBoxTeam.Name = "searchBoxTeam";
            this.searchBoxTeam.Size = new System.Drawing.Size(187, 20);
            this.searchBoxTeam.TabIndex = 35;
            this.searchBoxTeam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBoxTeam_KeyDown);
            // 
            // searchTeamButton
            // 
            this.searchTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTeamButton.Location = new System.Drawing.Point(676, 22);
            this.searchTeamButton.Name = "searchTeamButton";
            this.searchTeamButton.Size = new System.Drawing.Size(104, 38);
            this.searchTeamButton.TabIndex = 34;
            this.searchTeamButton.Text = "Search Team";
            this.searchTeamButton.UseVisualStyleBackColor = true;
            this.searchTeamButton.Click += new System.EventHandler(this.searchTeamButton_Click);
            // 
            // regionCombo
            // 
            this.regionCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionCombo.FormattingEnabled = true;
            this.regionCombo.Location = new System.Drawing.Point(112, 157);
            this.regionCombo.Name = "regionCombo";
            this.regionCombo.Size = new System.Drawing.Size(119, 21);
            this.regionCombo.TabIndex = 33;
            this.regionCombo.Text = "Select from list";
            // 
            // foundedYearCombo
            // 
            this.foundedYearCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foundedYearCombo.FormattingEnabled = true;
            this.foundedYearCombo.Location = new System.Drawing.Point(112, 115);
            this.foundedYearCombo.Name = "foundedYearCombo";
            this.foundedYearCombo.Size = new System.Drawing.Size(119, 21);
            this.foundedYearCombo.TabIndex = 32;
            this.foundedYearCombo.Text = "Select from list";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(27, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Region:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(27, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Founded Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(27, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ground Coach:";
            // 
            // coachTeam
            // 
            this.coachTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coachTeam.Location = new System.Drawing.Point(112, 75);
            this.coachTeam.Name = "coachTeam";
            this.coachTeam.Size = new System.Drawing.Size(119, 20);
            this.coachTeam.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(27, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Name:";
            // 
            // nameTeam
            // 
            this.nameTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTeam.Location = new System.Drawing.Point(70, 32);
            this.nameTeam.Name = "nameTeam";
            this.nameTeam.Size = new System.Drawing.Size(161, 20);
            this.nameTeam.TabIndex = 26;
            // 
            // addTeamButton
            // 
            this.addTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.Location = new System.Drawing.Point(299, 147);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(81, 38);
            this.addTeamButton.TabIndex = 8;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // saveTeamButton
            // 
            this.saveTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTeamButton.Location = new System.Drawing.Point(687, 144);
            this.saveTeamButton.Name = "saveTeamButton";
            this.saveTeamButton.Size = new System.Drawing.Size(93, 38);
            this.saveTeamButton.TabIndex = 7;
            this.saveTeamButton.Text = "Save Team";
            this.saveTeamButton.UseVisualStyleBackColor = true;
            this.saveTeamButton.Click += new System.EventHandler(this.saveTeamButton_Click);
            // 
            // teamGridView
            // 
            this.teamGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.teamGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamGridView.Location = new System.Drawing.Point(6, 210);
            this.teamGridView.Name = "teamGridView";
            this.teamGridView.Size = new System.Drawing.Size(426, 323);
            this.teamGridView.TabIndex = 0;
            this.teamGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teamGridView_CellClick);
            // 
            // tabPlayerPage
            // 
            this.tabPlayerPage.Controls.Add(this.dateTimePickerDOB);
            this.tabPlayerPage.Controls.Add(this.teamAddPlayer);
            this.tabPlayerPage.Controls.Add(this.searchBoxPlayer);
            this.tabPlayerPage.Controls.Add(this.label10);
            this.tabPlayerPage.Controls.Add(this.heightAddPlayer);
            this.tabPlayerPage.Controls.Add(this.label1);
            this.tabPlayerPage.Controls.Add(this.pobAddPlayer);
            this.tabPlayerPage.Controls.Add(this.label2);
            this.tabPlayerPage.Controls.Add(this.weightAddPlayer);
            this.tabPlayerPage.Controls.Add(this.label7);
            this.tabPlayerPage.Controls.Add(this.label8);
            this.tabPlayerPage.Controls.Add(this.nameAddPlayer);
            this.tabPlayerPage.Controls.Add(this.label9);
            this.tabPlayerPage.Controls.Add(this.searchPlayerButton);
            this.tabPlayerPage.Controls.Add(this.addPlayerButtonNew);
            this.tabPlayerPage.Controls.Add(this.savePlayerButton);
            this.tabPlayerPage.Controls.Add(this.playerDataGridView);
            this.tabPlayerPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPlayerPage.Location = new System.Drawing.Point(4, 34);
            this.tabPlayerPage.Name = "tabPlayerPage";
            this.tabPlayerPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayerPage.Size = new System.Drawing.Size(1060, 553);
            this.tabPlayerPage.TabIndex = 2;
            this.tabPlayerPage.Text = "Player";
            this.tabPlayerPage.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDOB.Location = new System.Drawing.Point(109, 104);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(197, 20);
            this.dateTimePickerDOB.TabIndex = 62;
            // 
            // teamAddPlayer
            // 
            this.teamAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamAddPlayer.FormattingEnabled = true;
            this.teamAddPlayer.Location = new System.Drawing.Point(77, 24);
            this.teamAddPlayer.Name = "teamAddPlayer";
            this.teamAddPlayer.Size = new System.Drawing.Size(229, 21);
            this.teamAddPlayer.TabIndex = 61;
            this.teamAddPlayer.Text = "Select from list";
            this.teamAddPlayer.DropDown += new System.EventHandler(this.teamAddPlayer_DropDown);
            this.teamAddPlayer.SelectedIndexChanged += new System.EventHandler(this.teamAddPlayer_SelectedIndexChanged);
            // 
            // searchBoxPlayer
            // 
            this.searchBoxPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.searchBoxPlayer.Location = new System.Drawing.Point(425, 27);
            this.searchBoxPlayer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchBoxPlayer.Name = "searchBoxPlayer";
            this.searchBoxPlayer.Size = new System.Drawing.Size(178, 20);
            this.searchBoxPlayer.TabIndex = 60;
            this.searchBoxPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBoxPlayer_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(34, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Height:";
            // 
            // heightAddPlayer
            // 
            this.heightAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.heightAddPlayer.Location = new System.Drawing.Point(84, 230);
            this.heightAddPlayer.Name = "heightAddPlayer";
            this.heightAddPlayer.Size = new System.Drawing.Size(222, 20);
            this.heightAddPlayer.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(34, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Place of Birth:";
            // 
            // pobAddPlayer
            // 
            this.pobAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pobAddPlayer.Location = new System.Drawing.Point(112, 189);
            this.pobAddPlayer.Name = "pobAddPlayer";
            this.pobAddPlayer.Size = new System.Drawing.Size(194, 20);
            this.pobAddPlayer.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(34, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Weight:";
            // 
            // weightAddPlayer
            // 
            this.weightAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.weightAddPlayer.Location = new System.Drawing.Point(84, 147);
            this.weightAddPlayer.Name = "weightAddPlayer";
            this.weightAddPlayer.Size = new System.Drawing.Size(222, 20);
            this.weightAddPlayer.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(34, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Date of Birth:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(34, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Name:";
            // 
            // nameAddPlayer
            // 
            this.nameAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameAddPlayer.Location = new System.Drawing.Point(77, 64);
            this.nameAddPlayer.Name = "nameAddPlayer";
            this.nameAddPlayer.Size = new System.Drawing.Size(229, 20);
            this.nameAddPlayer.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(34, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Team:";
            // 
            // searchPlayerButton
            // 
            this.searchPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchPlayerButton.Location = new System.Drawing.Point(655, 24);
            this.searchPlayerButton.Name = "searchPlayerButton";
            this.searchPlayerButton.Size = new System.Drawing.Size(125, 38);
            this.searchPlayerButton.TabIndex = 47;
            this.searchPlayerButton.Text = "Search Player";
            this.searchPlayerButton.UseVisualStyleBackColor = true;
            this.searchPlayerButton.Click += new System.EventHandler(this.searchPlayerButton_Click);
            // 
            // addPlayerButtonNew
            // 
            this.addPlayerButtonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerButtonNew.Location = new System.Drawing.Point(391, 220);
            this.addPlayerButtonNew.Name = "addPlayerButtonNew";
            this.addPlayerButtonNew.Size = new System.Drawing.Size(105, 38);
            this.addPlayerButtonNew.TabIndex = 38;
            this.addPlayerButtonNew.Text = "Add Player";
            this.addPlayerButtonNew.UseVisualStyleBackColor = true;
            this.addPlayerButtonNew.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // savePlayerButton
            // 
            this.savePlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.savePlayerButton.Location = new System.Drawing.Point(655, 220);
            this.savePlayerButton.Name = "savePlayerButton";
            this.savePlayerButton.Size = new System.Drawing.Size(125, 38);
            this.savePlayerButton.TabIndex = 37;
            this.savePlayerButton.Text = "Save Player";
            this.savePlayerButton.UseVisualStyleBackColor = true;
            this.savePlayerButton.Click += new System.EventHandler(this.savePlayerButton_Click);
            // 
            // playerDataGridView
            // 
            this.playerDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.playerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerDataGridView.Location = new System.Drawing.Point(8, 284);
            this.playerDataGridView.Name = "playerDataGridView";
            this.playerDataGridView.Size = new System.Drawing.Size(772, 263);
            this.playerDataGridView.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.saveAssignButton);
            this.tabPage1.Controls.Add(this.selectTeamAssignComboBox);
            this.tabPage1.Controls.Add(this.assignButton);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.playerAfterAssign);
            this.tabPage1.Controls.Add(this.playerBeforeAssign);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Size = new System.Drawing.Size(1060, 553);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Assign Player";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // assignButton
            // 
            this.assignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignButton.Location = new System.Drawing.Point(496, 235);
            this.assignButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(59, 43);
            this.assignButton.TabIndex = 6;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(498, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Team";
            // 
            // playerAfterAssign
            // 
            this.playerAfterAssign.BackgroundColor = System.Drawing.SystemColors.Window;
            this.playerAfterAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerAfterAssign.Location = new System.Drawing.Point(559, 85);
            this.playerAfterAssign.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.playerAfterAssign.Name = "playerAfterAssign";
            this.playerAfterAssign.RowTemplate.Height = 27;
            this.playerAfterAssign.Size = new System.Drawing.Size(494, 364);
            this.playerAfterAssign.TabIndex = 1;
            // 
            // playerBeforeAssign
            // 
            this.playerBeforeAssign.BackgroundColor = System.Drawing.SystemColors.Window;
            this.playerBeforeAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerBeforeAssign.Location = new System.Drawing.Point(5, 85);
            this.playerBeforeAssign.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.playerBeforeAssign.Name = "playerBeforeAssign";
            this.playerBeforeAssign.RowTemplate.Height = 27;
            this.playerBeforeAssign.Size = new System.Drawing.Size(487, 373);
            this.playerBeforeAssign.TabIndex = 0;
            // 
            // fileOpenButton
            // 
            this.fileOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileOpenButton.Location = new System.Drawing.Point(691, 12);
            this.fileOpenButton.Name = "fileOpenButton";
            this.fileOpenButton.Size = new System.Drawing.Size(93, 38);
            this.fileOpenButton.TabIndex = 6;
            this.fileOpenButton.Text = "File Open";
            this.fileOpenButton.UseVisualStyleBackColor = true;
            this.fileOpenButton.Click += new System.EventHandler(this.fileOpenButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(353, 138);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(125, 38);
            this.addPlayerButton.TabIndex = 38;
            this.addPlayerButton.Text = "Add";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamAssignComboBox
            // 
            this.selectTeamAssignComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamAssignComboBox.FormattingEnabled = true;
            this.selectTeamAssignComboBox.Location = new System.Drawing.Point(460, 45);
            this.selectTeamAssignComboBox.Name = "selectTeamAssignComboBox";
            this.selectTeamAssignComboBox.Size = new System.Drawing.Size(128, 21);
            this.selectTeamAssignComboBox.TabIndex = 7;
            this.selectTeamAssignComboBox.Text = "Select from list";
            this.selectTeamAssignComboBox.DropDown += new System.EventHandler(this.selectTeamAssignComboBox_DropDown);
            // 
            // saveAssignButton
            // 
            this.saveAssignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAssignButton.Location = new System.Drawing.Point(901, 16);
            this.saveAssignButton.Name = "saveAssignButton";
            this.saveAssignButton.Size = new System.Drawing.Size(108, 35);
            this.saveAssignButton.TabIndex = 8;
            this.saveAssignButton.Text = "Save Assign";
            this.saveAssignButton.UseVisualStyleBackColor = true;
            this.saveAssignButton.Click += new System.EventHandler(this.saveAssignButton_Click);
            // 
            // PlayerClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 645);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.fileOpenButton);
            this.Name = "PlayerClubForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PlayerClubForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.tabTeamPage.ResumeLayout(false);
            this.tabTeamPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamGridView)).EndInit();
            this.tabPlayerPage.ResumeLayout(false);
            this.tabPlayerPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerAfterAssign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBeforeAssign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabTeamPage;
        private System.Windows.Forms.TabPage tabPlayerPage;
        private System.Windows.Forms.Button fileOpenButton;
        private System.Windows.Forms.Button saveTeamButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView teamGridView;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button searchTeamButton;
        private System.Windows.Forms.ComboBox regionCombo;
        private System.Windows.Forms.ComboBox foundedYearCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox coachTeam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTeam;
        private System.Windows.Forms.Button searchPlayerButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button savePlayerButton;
        private System.Windows.Forms.DataGridView playerDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pobAddPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox weightAddPlayer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameAddPlayer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addPlayerButtonNew;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox heightAddPlayer;
        private System.Windows.Forms.TextBox searchBoxTeam;
        private System.Windows.Forms.TextBox searchBoxPlayer;
        private System.Windows.Forms.DataGridView PlayerList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView playerAfterAssign;
        private System.Windows.Forms.DataGridView playerBeforeAssign;
        private System.Windows.Forms.ComboBox teamAddPlayer;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Button saveAssignButton;
        private System.Windows.Forms.ComboBox selectTeamAssignComboBox;
    }
}

