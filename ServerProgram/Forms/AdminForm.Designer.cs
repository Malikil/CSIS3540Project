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
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.studentsIdTextBoxSearch = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxRoom = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.roomTab.SuspendLayout();
            this.studentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.studentTab.Controls.Add(this.button2);
            this.studentTab.Controls.Add(this.label7);
            this.studentTab.Controls.Add(this.label10);
            this.studentTab.Controls.Add(this.label12);
            this.studentTab.Controls.Add(this.button3);
            this.studentTab.Controls.Add(this.label13);
            this.studentTab.Controls.Add(this.textBox1);
            this.studentTab.Controls.Add(this.btnDelete);
            this.studentTab.Controls.Add(this.label15);
            this.studentTab.Controls.Add(this.studentsIdTextBoxSearch);
            this.studentTab.Controls.Add(this.button4);
            this.studentTab.Controls.Add(this.label16);
            this.studentTab.Controls.Add(this.label17);
            this.studentTab.Controls.Add(this.label18);
            this.studentTab.Controls.Add(this.label19);
            this.studentTab.Controls.Add(this.label20);
            this.studentTab.Controls.Add(this.label21);
            this.studentTab.Controls.Add(this.label22);
            this.studentTab.Controls.Add(this.label23);
            this.studentTab.Controls.Add(this.textBoxRoom);
            this.studentTab.Controls.Add(this.textBoxEmail);
            this.studentTab.Controls.Add(this.textBoxPhone);
            this.studentTab.Controls.Add(this.textBoxAge);
            this.studentTab.Controls.Add(this.textBoxLastname);
            this.studentTab.Controls.Add(this.textBoxName);
            this.studentTab.Controls.Add(this.button5);
            this.studentTab.Controls.Add(this.dataGridView1);
            this.studentTab.Controls.Add(this.dataGridView2);
            this.studentTab.Location = new System.Drawing.Point(4, 29);
            this.studentTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentTab.Name = "studentTab";
            this.studentTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentTab.Size = new System.Drawing.Size(1700, 846);
            this.studentTab.TabIndex = 1;
            this.studentTab.Text = "Students";
            this.studentTab.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1287, 745);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 87;
            this.button2.Text = "LOAD";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1385, 595);
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
            this.label10.Location = new System.Drawing.Point(1376, 466);
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
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1468, 745);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 83;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1190, 658);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 20);
            this.label13.TabIndex = 82;
            this.label13.Text = "Delete a Student record:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1389, 651);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 81;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1560, 650);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 80;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1120, 535);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(268, 20);
            this.label15.TabIndex = 79;
            this.label15.Text = "Enter the id of the student to search:";
            // 
            // studentsIdTextBoxSearch
            // 
            this.studentsIdTextBoxSearch.Location = new System.Drawing.Point(1401, 529);
            this.studentsIdTextBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentsIdTextBoxSearch.Name = "studentsIdTextBoxSearch";
            this.studentsIdTextBoxSearch.Size = new System.Drawing.Size(148, 26);
            this.studentsIdTextBoxSearch.TabIndex = 78;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1572, 528);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 77;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1461, 291);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 20);
            this.label18.TabIndex = 74;
            this.label18.Text = "Room:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1465, 235);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 20);
            this.label19.TabIndex = 73;
            this.label19.Text = "Email:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1456, 178);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 20);
            this.label20.TabIndex = 72;
            this.label20.Text = "Phone:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1203, 292);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 20);
            this.label21.TabIndex = 71;
            this.label21.Tag = "Age";
            this.label21.Text = "Age:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1159, 235);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 20);
            this.label22.TabIndex = 70;
            this.label22.Text = "Last Name:";
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
            // textBoxRoom
            // 
            this.textBoxRoom.Location = new System.Drawing.Point(1521, 286);
            this.textBoxRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRoom.Name = "textBoxRoom";
            this.textBoxRoom.Size = new System.Drawing.Size(148, 26);
            this.textBoxRoom.TabIndex = 68;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(1521, 231);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(148, 26);
            this.textBoxEmail.TabIndex = 67;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(1521, 172);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(148, 26);
            this.textBoxPhone.TabIndex = 66;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(1251, 286);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(148, 26);
            this.textBoxAge.TabIndex = 65;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(1251, 231);
            this.textBoxLastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(148, 26);
            this.textBoxLastname.TabIndex = 64;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(1251, 172);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(148, 26);
            this.textBoxName.TabIndex = 63;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1402, 360);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 62;
            this.button5.Text = "Insert";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 535);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1044, 269);
            this.dataGridView1.TabIndex = 61;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(35, 95);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1044, 368);
            this.dataGridView2.TabIndex = 60;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox studentsIdTextBoxSearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxRoom;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox roomNumbertextBox;
        private System.Windows.Forms.Label label24;
    }
}

