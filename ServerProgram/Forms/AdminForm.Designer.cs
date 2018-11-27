namespace ServerProgram.Forms
{
    partial class AdminForm
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomIdTextBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearchRoom = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.roomCapacityTextBox = new System.Windows.Forms.TextBox();
            this.FloorIDTextBox = new System.Windows.Forms.TextBox();
            this.RoomSizeTextBox = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.studentsGridView = new System.Windows.Forms.DataGridView();
            this.roomsGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.roomTab = new System.Windows.Forms.TabPage();
            this.roomNumbertextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.studentTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CloseSecondFormButtonsClicked = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.DeleteStudentTextBox = new System.Windows.Forms.TextBox();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.studentsIdTextBoxSearch = new System.Windows.Forms.TextBox();
            this.searchStudentBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.InsertStudentButtonClicked = new System.Windows.Forms.Button();
            this.RoomsSecondGridView = new System.Windows.Forms.DataGridView();
            this.StudentsSecondGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.roomTab.SuspendLayout();
            this.studentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsSecondGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsSecondGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1540, 555);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 35);
            this.deleteButton.TabIndex = 108;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteRoomButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 432);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 32);
            this.label1.TabIndex = 107;
            this.label1.Text = "STUDENTS INFORMATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 32);
            this.label4.TabIndex = 106;
            this.label4.Text = "FULL ROOMS DATABASE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1276, 509);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 104;
            this.label6.Text = "DELETE A ROOM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1267, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 103;
            this.label5.Text = "FIND A ROOM BY ID";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1451, 741);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 102;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.CloseFormButtonsClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1172, 565);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 101;
            this.label3.Text = "Delete a Room record:";
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(1371, 559);
            this.textBoxDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(148, 26);
            this.textBoxDelete.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1089, 382);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 20);
            this.label2.TabIndex = 99;
            this.label2.Text = "Enter the id of the room to search:";
            // 
            // roomIdTextBoxSearch
            // 
            this.roomIdTextBoxSearch.Location = new System.Drawing.Point(1369, 376);
            this.roomIdTextBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomIdTextBoxSearch.Name = "roomIdTextBoxSearch";
            this.roomIdTextBoxSearch.Size = new System.Drawing.Size(148, 26);
            this.roomIdTextBoxSearch.TabIndex = 98;
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.Location = new System.Drawing.Point(1540, 374);
            this.btnSearchRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(112, 35);
            this.btnSearchRoom.TabIndex = 97;
            this.btnSearchRoom.Text = "Search";
            this.btnSearchRoom.UseVisualStyleBackColor = true;
            this.btnSearchRoom.Click += new System.EventHandler(this.SearchStudentButtonClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1249, 34);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(203, 20);
            this.label14.TabIndex = 96;
            this.label14.Text = "INSERT A NEW ROOM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1374, 90);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 95;
            this.label11.Text = "Capacity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1109, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 94;
            this.label9.Text = "Floor Id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1087, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 93;
            this.label8.Text = "Room Size:";
            // 
            // roomCapacityTextBox
            // 
            this.roomCapacityTextBox.Location = new System.Drawing.Point(1451, 86);
            this.roomCapacityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomCapacityTextBox.Name = "roomCapacityTextBox";
            this.roomCapacityTextBox.Size = new System.Drawing.Size(148, 26);
            this.roomCapacityTextBox.TabIndex = 92;
            // 
            // FloorIDTextBox
            // 
            this.FloorIDTextBox.Location = new System.Drawing.Point(1181, 145);
            this.FloorIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FloorIDTextBox.Name = "FloorIDTextBox";
            this.FloorIDTextBox.Size = new System.Drawing.Size(148, 26);
            this.FloorIDTextBox.TabIndex = 91;
            // 
            // RoomSizeTextBox
            // 
            this.RoomSizeTextBox.Location = new System.Drawing.Point(1181, 86);
            this.RoomSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoomSizeTextBox.Name = "RoomSizeTextBox";
            this.RoomSizeTextBox.Size = new System.Drawing.Size(148, 26);
            this.RoomSizeTextBox.TabIndex = 90;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(1290, 208);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(112, 35);
            this.buttonInsert.TabIndex = 89;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.InsertRoomButtonClicked);
            // 
            // studentsGridView
            // 
            this.studentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGridView.Location = new System.Drawing.Point(24, 489);
            this.studentsGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentsGridView.Name = "studentsGridView";
            this.studentsGridView.Size = new System.Drawing.Size(986, 328);
            this.studentsGridView.TabIndex = 87;
            // 
            // roomsGridView
            // 
            this.roomsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsGridView.Location = new System.Drawing.Point(24, 84);
            this.roomsGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomsGridView.Name = "roomsGridView";
            this.roomsGridView.Size = new System.Drawing.Size(986, 314);
            this.roomsGridView.TabIndex = 86;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.roomTab);
            this.tabControl1.Controls.Add(this.studentTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1708, 879);
            this.tabControl1.TabIndex = 109;
            // 
            // roomTab
            // 
            this.roomTab.Controls.Add(this.roomNumbertextBox);
            this.roomTab.Controls.Add(this.label24);
            this.roomTab.Controls.Add(this.roomsGridView);
            this.roomTab.Controls.Add(this.deleteButton);
            this.roomTab.Controls.Add(this.studentsGridView);
            this.roomTab.Controls.Add(this.label1);
            this.roomTab.Controls.Add(this.label4);
            this.roomTab.Controls.Add(this.buttonInsert);
            this.roomTab.Controls.Add(this.RoomSizeTextBox);
            this.roomTab.Controls.Add(this.label6);
            this.roomTab.Controls.Add(this.FloorIDTextBox);
            this.roomTab.Controls.Add(this.label5);
            this.roomTab.Controls.Add(this.roomCapacityTextBox);
            this.roomTab.Controls.Add(this.btnExit);
            this.roomTab.Controls.Add(this.label8);
            this.roomTab.Controls.Add(this.label3);
            this.roomTab.Controls.Add(this.label9);
            this.roomTab.Controls.Add(this.textBoxDelete);
            this.roomTab.Controls.Add(this.label11);
            this.roomTab.Controls.Add(this.label2);
            this.roomTab.Controls.Add(this.label14);
            this.roomTab.Controls.Add(this.roomIdTextBoxSearch);
            this.roomTab.Controls.Add(this.btnSearchRoom);
            this.roomTab.Location = new System.Drawing.Point(4, 29);
            this.roomTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomTab.Name = "roomTab";
            this.roomTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomTab.Size = new System.Drawing.Size(1700, 846);
            this.roomTab.TabIndex = 0;
            this.roomTab.Text = "Rooms";
            this.roomTab.UseVisualStyleBackColor = true;
            // 
            // roomNumbertextBox
            // 
            this.roomNumbertextBox.Location = new System.Drawing.Point(1451, 142);
            this.roomNumbertextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomNumbertextBox.Name = "roomNumbertextBox";
            this.roomNumbertextBox.Size = new System.Drawing.Size(148, 26);
            this.roomNumbertextBox.TabIndex = 109;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1335, 146);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(116, 20);
            this.label24.TabIndex = 110;
            this.label24.Text = "Room Number:";
            // 
            // studentTab
            // 
            this.studentTab.Controls.Add(this.label7);
            this.studentTab.Controls.Add(this.label10);
            this.studentTab.Controls.Add(this.label12);
            this.studentTab.Controls.Add(this.CloseSecondFormButtonsClicked);
            this.studentTab.Controls.Add(this.label13);
            this.studentTab.Controls.Add(this.DeleteStudentTextBox);
            this.studentTab.Controls.Add(this.btnDeleteStudent);
            this.studentTab.Controls.Add(this.label15);
            this.studentTab.Controls.Add(this.studentsIdTextBoxSearch);
            this.studentTab.Controls.Add(this.searchStudentBtn);
            this.studentTab.Controls.Add(this.label16);
            this.studentTab.Controls.Add(this.label17);
            this.studentTab.Controls.Add(this.StudentID);
            this.studentTab.Controls.Add(this.label23);
            this.studentTab.Controls.Add(this.textBoxStudentID);
            this.studentTab.Controls.Add(this.textBoxStudentName);
            this.studentTab.Controls.Add(this.InsertStudentButtonClicked);
            this.studentTab.Controls.Add(this.RoomsSecondGridView);
            this.studentTab.Controls.Add(this.StudentsSecondGridView);
            this.studentTab.Location = new System.Drawing.Point(4, 29);
            this.studentTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentTab.Name = "studentTab";
            this.studentTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentTab.Size = new System.Drawing.Size(1700, 846);
            this.studentTab.TabIndex = 1;
            this.studentTab.Text = "Students";
            this.studentTab.UseVisualStyleBackColor = true;
            this.studentTab.Click += new System.EventHandler(this.studentTab_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1385, 486);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "DELETE A STUDENT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1376, 357);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 20);
            this.label10.TabIndex = 85;
            this.label10.Text = "FIND A STUDENT BY ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(355, 485);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(322, 32);
            this.label12.TabIndex = 84;
            this.label12.Text = "ROOM IMFORMATION";
            // 
            // CloseSecondFormButtonsClicked
            // 
            this.CloseSecondFormButtonsClicked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseSecondFormButtonsClicked.Location = new System.Drawing.Point(1401, 708);
            this.CloseSecondFormButtonsClicked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseSecondFormButtonsClicked.Name = "CloseSecondFormButtonsClicked";
            this.CloseSecondFormButtonsClicked.Size = new System.Drawing.Size(112, 35);
            this.CloseSecondFormButtonsClicked.TabIndex = 83;
            this.CloseSecondFormButtonsClicked.Text = "EXIT";
            this.CloseSecondFormButtonsClicked.UseVisualStyleBackColor = true;
            this.CloseSecondFormButtonsClicked.Click += new System.EventHandler(this.CloseSecondFormButtonsClicked_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1190, 549);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 20);
            this.label13.TabIndex = 82;
            this.label13.Text = "Delete a Student record:";
            // 
            // DeleteStudentTextBox
            // 
            this.DeleteStudentTextBox.Location = new System.Drawing.Point(1389, 542);
            this.DeleteStudentTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteStudentTextBox.Name = "DeleteStudentTextBox";
            this.DeleteStudentTextBox.Size = new System.Drawing.Size(148, 26);
            this.DeleteStudentTextBox.TabIndex = 81;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(1560, 541);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(112, 35);
            this.btnDeleteStudent.TabIndex = 80;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1120, 426);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(268, 20);
            this.label15.TabIndex = 79;
            this.label15.Text = "Enter the id of the student to search:";
            // 
            // studentsIdTextBoxSearch
            // 
            this.studentsIdTextBoxSearch.Location = new System.Drawing.Point(1401, 420);
            this.studentsIdTextBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentsIdTextBoxSearch.Name = "studentsIdTextBoxSearch";
            this.studentsIdTextBoxSearch.Size = new System.Drawing.Size(148, 26);
            this.studentsIdTextBoxSearch.TabIndex = 78;
            // 
            // searchStudentBtn
            // 
            this.searchStudentBtn.Location = new System.Drawing.Point(1572, 419);
            this.searchStudentBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchStudentBtn.Name = "searchStudentBtn";
            this.searchStudentBtn.Size = new System.Drawing.Size(112, 35);
            this.searchStudentBtn.TabIndex = 77;
            this.searchStudentBtn.Text = "Search";
            this.searchStudentBtn.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(306, 31);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(422, 32);
            this.label16.TabIndex = 76;
            this.label16.Text = "FULL STUDENTS DATABASE";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1358, 120);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(233, 20);
            this.label17.TabIndex = 75;
            this.label17.Text = "INSERT A NEW STUDENT";
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(1429, 175);
            this.StudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(87, 20);
            this.StudentID.TabIndex = 72;
            this.StudentID.Text = "StudentID:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1190, 178);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 20);
            this.label23.TabIndex = 69;
            this.label23.Text = "Name:";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(1521, 172);
            this.textBoxStudentID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(148, 26);
            this.textBoxStudentID.TabIndex = 66;
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(1251, 172);
            this.textBoxStudentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(148, 26);
            this.textBoxStudentName.TabIndex = 63;
            // 
            // InsertStudentButtonClicked
            // 
            this.InsertStudentButtonClicked.Location = new System.Drawing.Point(1380, 263);
            this.InsertStudentButtonClicked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InsertStudentButtonClicked.Name = "InsertStudentButtonClicked";
            this.InsertStudentButtonClicked.Size = new System.Drawing.Size(112, 35);
            this.InsertStudentButtonClicked.TabIndex = 62;
            this.InsertStudentButtonClicked.Text = "Insert";
            this.InsertStudentButtonClicked.UseVisualStyleBackColor = true;
            this.InsertStudentButtonClicked.Click += new System.EventHandler(this.InsertStudentButtonClicked_Click);
            // 
            // RoomsSecondGridView
            // 
            this.RoomsSecondGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsSecondGridView.Location = new System.Drawing.Point(35, 535);
            this.RoomsSecondGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoomsSecondGridView.Name = "RoomsSecondGridView";
            this.RoomsSecondGridView.Size = new System.Drawing.Size(1044, 269);
            this.RoomsSecondGridView.TabIndex = 61;
            // 
            // StudentsSecondGridView
            // 
            this.StudentsSecondGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsSecondGridView.Location = new System.Drawing.Point(35, 95);
            this.StudentsSecondGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StudentsSecondGridView.Name = "StudentsSecondGridView";
            this.StudentsSecondGridView.Size = new System.Drawing.Size(1044, 368);
            this.StudentsSecondGridView.TabIndex = 60;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1708, 879);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.LoadRoomsAndStudents);
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.roomTab.ResumeLayout(false);
            this.roomTab.PerformLayout();
            this.studentTab.ResumeLayout(false);
            this.studentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsSecondGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsSecondGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomIdTextBoxSearch;
        private System.Windows.Forms.Button btnSearchRoom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox roomCapacityTextBox;
        private System.Windows.Forms.TextBox FloorIDTextBox;
        private System.Windows.Forms.TextBox RoomSizeTextBox;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView studentsGridView;
        private System.Windows.Forms.DataGridView roomsGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage roomTab;
        private System.Windows.Forms.TabPage studentTab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button CloseSecondFormButtonsClicked;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DeleteStudentTextBox;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox studentsIdTextBoxSearch;
        private System.Windows.Forms.Button searchStudentBtn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Button InsertStudentButtonClicked;
        private System.Windows.Forms.DataGridView RoomsSecondGridView;
        private System.Windows.Forms.DataGridView StudentsSecondGridView;
        private System.Windows.Forms.TextBox roomNumbertextBox;
        private System.Windows.Forms.Label label24;
    }
}

