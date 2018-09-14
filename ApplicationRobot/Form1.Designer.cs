namespace ApplicationRobot
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToRobotArmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conncetToScannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelScannerConnection = new System.Windows.Forms.Label();
            this.labelScanner = new System.Windows.Forms.Label();
            this.labelRobotArmConnection = new System.Windows.Forms.Label();
            this.labelRobotArm = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonShelf3Right = new System.Windows.Forms.Button();
            this.buttonShelf3Left = new System.Windows.Forms.Button();
            this.buttonShelf2Right = new System.Windows.Forms.Button();
            this.buttonShelf2Left = new System.Windows.Forms.Button();
            this.buttonShelf1Right = new System.Windows.Forms.Button();
            this.buttonShelf1Left = new System.Windows.Forms.Button();
            this.buttonReadyPosition = new System.Windows.Forms.Button();
            this.buttonOriginalPos = new System.Windows.Forms.Button();
            this.buttonCloseGripper = new System.Windows.Forms.Button();
            this.buttonOpenGripper = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonStopScan = new System.Windows.Forms.Button();
            this.buttonResetRight = new System.Windows.Forms.Button();
            this.buttonResetLeft = new System.Windows.Forms.Button();
            this.label3MatchingIncorrectCount = new System.Windows.Forms.Label();
            this.labelMatchingIncorrect = new System.Windows.Forms.Label();
            this.labelMatchingCorrectCount = new System.Windows.Forms.Label();
            this.labelMatchingCorrect = new System.Windows.Forms.Label();
            this.labelItemFoundCount = new System.Windows.Forms.Label();
            this.labelFoundItem = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonScanMode = new System.Windows.Forms.Button();
            this.listBoxSequence = new System.Windows.Forms.ListBox();
            this.listBoxSearchItem = new System.Windows.Forms.ListBox();
            this.comboBoxBookIndex = new System.Windows.Forms.ComboBox();
            this.buttonGoToPosistion = new System.Windows.Forms.Button();
            this.buttonPickUpHook = new System.Windows.Forms.Button();
            this.buttonPutBackHook = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonPickBook = new System.Windows.Forms.Button();
            this.comboBoxPickUpBook = new System.Windows.Forms.ComboBox();
            this.buttonPickUpBook = new System.Windows.Forms.Button();
            this.buttonStandbyPosition = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonPickDrop = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToRobotArmToolStripMenuItem,
            this.conncetToScannerToolStripMenuItem,
            this.toolStripMenuItem2,
            this.optionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // connectToRobotArmToolStripMenuItem
            // 
            this.connectToRobotArmToolStripMenuItem.Name = "connectToRobotArmToolStripMenuItem";
            this.connectToRobotArmToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.connectToRobotArmToolStripMenuItem.Text = "Connect to Robot Arm";
            this.connectToRobotArmToolStripMenuItem.Click += new System.EventHandler(this.connectToRobotArmToolStripMenuItem_Click);
            // 
            // conncetToScannerToolStripMenuItem
            // 
            this.conncetToScannerToolStripMenuItem.Name = "conncetToScannerToolStripMenuItem";
            this.conncetToScannerToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.conncetToScannerToolStripMenuItem.Text = "Conncet to Scanner";
            this.conncetToScannerToolStripMenuItem.Click += new System.EventHandler(this.conncetToScannerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(194, 22);
            this.toolStripMenuItem2.Text = " Connect to Gripper";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelScannerConnection);
            this.groupBox1.Controls.Add(this.labelScanner);
            this.groupBox1.Controls.Add(this.labelRobotArmConnection);
            this.groupBox1.Controls.Add(this.labelRobotArm);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect to devices";
            // 
            // labelScannerConnection
            // 
            this.labelScannerConnection.AutoSize = true;
            this.labelScannerConnection.Location = new System.Drawing.Point(130, 65);
            this.labelScannerConnection.Name = "labelScannerConnection";
            this.labelScannerConnection.Size = new System.Drawing.Size(61, 13);
            this.labelScannerConnection.TabIndex = 5;
            this.labelScannerConnection.Text = "Disconnect";
            this.labelScannerConnection.DoubleClick += new System.EventHandler(this.labelScannerConnection_DoubleClick);
            // 
            // labelScanner
            // 
            this.labelScanner.AutoSize = true;
            this.labelScanner.Location = new System.Drawing.Point(44, 65);
            this.labelScanner.Name = "labelScanner";
            this.labelScanner.Size = new System.Drawing.Size(53, 13);
            this.labelScanner.TabIndex = 4;
            this.labelScanner.Text = "Scanner :";
            // 
            // labelRobotArmConnection
            // 
            this.labelRobotArmConnection.AutoSize = true;
            this.labelRobotArmConnection.Location = new System.Drawing.Point(130, 30);
            this.labelRobotArmConnection.Name = "labelRobotArmConnection";
            this.labelRobotArmConnection.Size = new System.Drawing.Size(61, 13);
            this.labelRobotArmConnection.TabIndex = 1;
            this.labelRobotArmConnection.Text = "Disconnect";
            this.labelRobotArmConnection.DoubleClick += new System.EventHandler(this.labelRobotArmConnection_DoubleClick);
            // 
            // labelRobotArm
            // 
            this.labelRobotArm.AutoSize = true;
            this.labelRobotArm.Location = new System.Drawing.Point(44, 30);
            this.labelRobotArm.Name = "labelRobotArm";
            this.labelRobotArm.Size = new System.Drawing.Size(63, 13);
            this.labelRobotArm.TabIndex = 0;
            this.labelRobotArm.Text = "Robot Arm :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.buttonShelf3Right);
            this.groupBox2.Controls.Add(this.buttonShelf3Left);
            this.groupBox2.Controls.Add(this.buttonShelf2Right);
            this.groupBox2.Controls.Add(this.buttonShelf2Left);
            this.groupBox2.Controls.Add(this.buttonShelf1Right);
            this.groupBox2.Controls.Add(this.buttonShelf1Left);
            this.groupBox2.Controls.Add(this.buttonReadyPosition);
            this.groupBox2.Controls.Add(this.buttonOriginalPos);
            this.groupBox2.Location = new System.Drawing.Point(13, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 203);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Robot Arm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Return Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonShelf3Right
            // 
            this.buttonShelf3Right.Location = new System.Drawing.Point(120, 136);
            this.buttonShelf3Right.Name = "buttonShelf3Right";
            this.buttonShelf3Right.Size = new System.Drawing.Size(100, 23);
            this.buttonShelf3Right.TabIndex = 7;
            this.buttonShelf3Right.Text = "Shelf 3 (Right)";
            this.buttonShelf3Right.UseVisualStyleBackColor = true;
            this.buttonShelf3Right.Click += new System.EventHandler(this.buttonShelf3Right_Click);
            // 
            // buttonShelf3Left
            // 
            this.buttonShelf3Left.Location = new System.Drawing.Point(18, 136);
            this.buttonShelf3Left.Name = "buttonShelf3Left";
            this.buttonShelf3Left.Size = new System.Drawing.Size(96, 23);
            this.buttonShelf3Left.TabIndex = 6;
            this.buttonShelf3Left.Text = "Shelf 3 (Left)";
            this.buttonShelf3Left.UseVisualStyleBackColor = true;
            this.buttonShelf3Left.Click += new System.EventHandler(this.buttonShelf3Left_Click);
            // 
            // buttonShelf2Right
            // 
            this.buttonShelf2Right.Location = new System.Drawing.Point(121, 107);
            this.buttonShelf2Right.Name = "buttonShelf2Right";
            this.buttonShelf2Right.Size = new System.Drawing.Size(100, 23);
            this.buttonShelf2Right.TabIndex = 5;
            this.buttonShelf2Right.Text = "Shelf 2 (Right)";
            this.buttonShelf2Right.UseVisualStyleBackColor = true;
            this.buttonShelf2Right.Click += new System.EventHandler(this.buttonShelf2Right_Click);
            // 
            // buttonShelf2Left
            // 
            this.buttonShelf2Left.Location = new System.Drawing.Point(19, 107);
            this.buttonShelf2Left.Name = "buttonShelf2Left";
            this.buttonShelf2Left.Size = new System.Drawing.Size(96, 23);
            this.buttonShelf2Left.TabIndex = 4;
            this.buttonShelf2Left.Text = "Shelf 2 (Left)";
            this.buttonShelf2Left.UseVisualStyleBackColor = true;
            this.buttonShelf2Left.Click += new System.EventHandler(this.buttonShelf2Left_Click);
            // 
            // buttonShelf1Right
            // 
            this.buttonShelf1Right.Location = new System.Drawing.Point(120, 77);
            this.buttonShelf1Right.Name = "buttonShelf1Right";
            this.buttonShelf1Right.Size = new System.Drawing.Size(100, 23);
            this.buttonShelf1Right.TabIndex = 3;
            this.buttonShelf1Right.Text = "Shelf 1 (Right)";
            this.buttonShelf1Right.UseVisualStyleBackColor = true;
            this.buttonShelf1Right.Click += new System.EventHandler(this.buttonShelf1Right_Click);
            // 
            // buttonShelf1Left
            // 
            this.buttonShelf1Left.Location = new System.Drawing.Point(18, 77);
            this.buttonShelf1Left.Name = "buttonShelf1Left";
            this.buttonShelf1Left.Size = new System.Drawing.Size(96, 23);
            this.buttonShelf1Left.TabIndex = 2;
            this.buttonShelf1Left.Text = "Shelf 1 (Left)";
            this.buttonShelf1Left.UseVisualStyleBackColor = true;
            this.buttonShelf1Left.Click += new System.EventHandler(this.buttonShelf1Left_Click);
            // 
            // buttonReadyPosition
            // 
            this.buttonReadyPosition.Location = new System.Drawing.Point(18, 48);
            this.buttonReadyPosition.Name = "buttonReadyPosition";
            this.buttonReadyPosition.Size = new System.Drawing.Size(202, 23);
            this.buttonReadyPosition.TabIndex = 1;
            this.buttonReadyPosition.Text = "Ready Position";
            this.buttonReadyPosition.UseVisualStyleBackColor = true;
            this.buttonReadyPosition.Click += new System.EventHandler(this.buttonReadyPosition_Click);
            // 
            // buttonOriginalPos
            // 
            this.buttonOriginalPos.Location = new System.Drawing.Point(18, 19);
            this.buttonOriginalPos.Name = "buttonOriginalPos";
            this.buttonOriginalPos.Size = new System.Drawing.Size(202, 23);
            this.buttonOriginalPos.TabIndex = 0;
            this.buttonOriginalPos.Text = "Original Posistion";
            this.buttonOriginalPos.UseVisualStyleBackColor = true;
            this.buttonOriginalPos.Click += new System.EventHandler(this.buttonOriginalPos_Click);
            // 
            // buttonCloseGripper
            // 
            this.buttonCloseGripper.Location = new System.Drawing.Point(15, 48);
            this.buttonCloseGripper.Name = "buttonCloseGripper";
            this.buttonCloseGripper.Size = new System.Drawing.Size(100, 23);
            this.buttonCloseGripper.TabIndex = 10;
            this.buttonCloseGripper.Text = "Close Gripper";
            this.buttonCloseGripper.UseVisualStyleBackColor = true;
            this.buttonCloseGripper.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonOpenGripper
            // 
            this.buttonOpenGripper.Location = new System.Drawing.Point(15, 19);
            this.buttonOpenGripper.Name = "buttonOpenGripper";
            this.buttonOpenGripper.Size = new System.Drawing.Size(100, 23);
            this.buttonOpenGripper.TabIndex = 9;
            this.buttonOpenGripper.Text = "Open Gripper";
            this.buttonOpenGripper.UseVisualStyleBackColor = true;
            this.buttonOpenGripper.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonStopScan);
            this.groupBox3.Controls.Add(this.buttonResetRight);
            this.groupBox3.Controls.Add(this.buttonResetLeft);
            this.groupBox3.Controls.Add(this.label3MatchingIncorrectCount);
            this.groupBox3.Controls.Add(this.labelMatchingIncorrect);
            this.groupBox3.Controls.Add(this.labelMatchingCorrectCount);
            this.groupBox3.Controls.Add(this.labelMatchingCorrect);
            this.groupBox3.Controls.Add(this.labelItemFoundCount);
            this.groupBox3.Controls.Add(this.labelFoundItem);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.buttonScanMode);
            this.groupBox3.Controls.Add(this.listBoxSequence);
            this.groupBox3.Controls.Add(this.listBoxSearchItem);
            this.groupBox3.Location = new System.Drawing.Point(274, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(641, 249);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mismatch Process";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // buttonStopScan
            // 
            this.buttonStopScan.Location = new System.Drawing.Point(272, 65);
            this.buttonStopScan.Name = "buttonStopScan";
            this.buttonStopScan.Size = new System.Drawing.Size(100, 23);
            this.buttonStopScan.TabIndex = 21;
            this.buttonStopScan.Text = "Stop scanning";
            this.buttonStopScan.UseVisualStyleBackColor = true;
            this.buttonStopScan.Visible = false;
            this.buttonStopScan.Click += new System.EventHandler(this.buttonStopScan_Click);
            // 
            // buttonResetRight
            // 
            this.buttonResetRight.Location = new System.Drawing.Point(272, 167);
            this.buttonResetRight.Name = "buttonResetRight";
            this.buttonResetRight.Size = new System.Drawing.Size(100, 23);
            this.buttonResetRight.TabIndex = 20;
            this.buttonResetRight.Text = ">>Reset right>>";
            this.buttonResetRight.UseVisualStyleBackColor = true;
            this.buttonResetRight.Click += new System.EventHandler(this.buttonResetRight_Click);
            // 
            // buttonResetLeft
            // 
            this.buttonResetLeft.Location = new System.Drawing.Point(272, 138);
            this.buttonResetLeft.Name = "buttonResetLeft";
            this.buttonResetLeft.Size = new System.Drawing.Size(100, 23);
            this.buttonResetLeft.TabIndex = 19;
            this.buttonResetLeft.Text = "<<Reset left<<";
            this.buttonResetLeft.UseVisualStyleBackColor = true;
            this.buttonResetLeft.Click += new System.EventHandler(this.buttonResetLeft_Click);
            // 
            // label3MatchingIncorrectCount
            // 
            this.label3MatchingIncorrectCount.AutoSize = true;
            this.label3MatchingIncorrectCount.Location = new System.Drawing.Point(522, 230);
            this.label3MatchingIncorrectCount.Name = "label3MatchingIncorrectCount";
            this.label3MatchingIncorrectCount.Size = new System.Drawing.Size(44, 13);
            this.label3MatchingIncorrectCount.TabIndex = 18;
            this.label3MatchingIncorrectCount.Text = "0 Count";
            this.label3MatchingIncorrectCount.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelMatchingIncorrect
            // 
            this.labelMatchingIncorrect.AutoSize = true;
            this.labelMatchingIncorrect.Location = new System.Drawing.Point(405, 230);
            this.labelMatchingIncorrect.Name = "labelMatchingIncorrect";
            this.labelMatchingIncorrect.Size = new System.Drawing.Size(102, 13);
            this.labelMatchingIncorrect.TabIndex = 17;
            this.labelMatchingIncorrect.Text = "Matching Incorrect :";
            // 
            // labelMatchingCorrectCount
            // 
            this.labelMatchingCorrectCount.AutoSize = true;
            this.labelMatchingCorrectCount.Location = new System.Drawing.Point(522, 201);
            this.labelMatchingCorrectCount.Name = "labelMatchingCorrectCount";
            this.labelMatchingCorrectCount.Size = new System.Drawing.Size(44, 13);
            this.labelMatchingCorrectCount.TabIndex = 16;
            this.labelMatchingCorrectCount.Text = "0 Count";
            // 
            // labelMatchingCorrect
            // 
            this.labelMatchingCorrect.AutoSize = true;
            this.labelMatchingCorrect.Location = new System.Drawing.Point(405, 201);
            this.labelMatchingCorrect.Name = "labelMatchingCorrect";
            this.labelMatchingCorrect.Size = new System.Drawing.Size(94, 13);
            this.labelMatchingCorrect.TabIndex = 15;
            this.labelMatchingCorrect.Text = "Matching Correct :";
            // 
            // labelItemFoundCount
            // 
            this.labelItemFoundCount.AutoSize = true;
            this.labelItemFoundCount.Location = new System.Drawing.Point(106, 201);
            this.labelItemFoundCount.Name = "labelItemFoundCount";
            this.labelItemFoundCount.Size = new System.Drawing.Size(46, 13);
            this.labelItemFoundCount.TabIndex = 5;
            this.labelItemFoundCount.Text = "0 Found";
            // 
            // labelFoundItem
            // 
            this.labelFoundItem.AutoSize = true;
            this.labelFoundItem.Location = new System.Drawing.Point(20, 201);
            this.labelFoundItem.Name = "labelFoundItem";
            this.labelFoundItem.Size = new System.Drawing.Size(63, 13);
            this.labelFoundItem.TabIndex = 4;
            this.labelFoundItem.Text = "Item found :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Matching Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // buttonScanMode
            // 
            this.buttonScanMode.Location = new System.Drawing.Point(272, 30);
            this.buttonScanMode.Name = "buttonScanMode";
            this.buttonScanMode.Size = new System.Drawing.Size(100, 23);
            this.buttonScanMode.TabIndex = 11;
            this.buttonScanMode.Text = "Scan Mode";
            this.buttonScanMode.UseVisualStyleBackColor = true;
            this.buttonScanMode.Click += new System.EventHandler(this.buttonScanMode_Click);
            // 
            // listBoxSequence
            // 
            this.listBoxSequence.FormattingEnabled = true;
            this.listBoxSequence.Location = new System.Drawing.Point(399, 30);
            this.listBoxSequence.Name = "listBoxSequence";
            this.listBoxSequence.Size = new System.Drawing.Size(222, 160);
            this.listBoxSequence.TabIndex = 1;
            this.listBoxSequence.SelectedIndexChanged += new System.EventHandler(this.listBoxSequence_SelectedIndexChanged);
            // 
            // listBoxSearchItem
            // 
            this.listBoxSearchItem.FormattingEnabled = true;
            this.listBoxSearchItem.Location = new System.Drawing.Point(23, 30);
            this.listBoxSearchItem.Name = "listBoxSearchItem";
            this.listBoxSearchItem.Size = new System.Drawing.Size(222, 160);
            this.listBoxSearchItem.TabIndex = 0;
            // 
            // comboBoxBookIndex
            // 
            this.comboBoxBookIndex.FormattingEnabled = true;
            this.comboBoxBookIndex.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxBookIndex.Location = new System.Drawing.Point(154, 28);
            this.comboBoxBookIndex.Name = "comboBoxBookIndex";
            this.comboBoxBookIndex.Size = new System.Drawing.Size(100, 21);
            this.comboBoxBookIndex.TabIndex = 23;
            this.comboBoxBookIndex.Text = "Book Index";
            // 
            // buttonGoToPosistion
            // 
            this.buttonGoToPosistion.Location = new System.Drawing.Point(260, 28);
            this.buttonGoToPosistion.Name = "buttonGoToPosistion";
            this.buttonGoToPosistion.Size = new System.Drawing.Size(100, 23);
            this.buttonGoToPosistion.TabIndex = 22;
            this.buttonGoToPosistion.Text = "Go To Position";
            this.buttonGoToPosistion.UseVisualStyleBackColor = true;
            this.buttonGoToPosistion.Click += new System.EventHandler(this.buttonGoToPosistion_Click);
            // 
            // buttonPickUpHook
            // 
            this.buttonPickUpHook.Location = new System.Drawing.Point(32, 28);
            this.buttonPickUpHook.Name = "buttonPickUpHook";
            this.buttonPickUpHook.Size = new System.Drawing.Size(100, 23);
            this.buttonPickUpHook.TabIndex = 11;
            this.buttonPickUpHook.Text = "PickUpHook";
            this.buttonPickUpHook.UseVisualStyleBackColor = true;
            this.buttonPickUpHook.Click += new System.EventHandler(this.buttonPickUpHook_Click);
            // 
            // buttonPutBackHook
            // 
            this.buttonPutBackHook.Location = new System.Drawing.Point(32, 57);
            this.buttonPutBackHook.Name = "buttonPutBackHook";
            this.buttonPutBackHook.Size = new System.Drawing.Size(100, 23);
            this.buttonPutBackHook.TabIndex = 12;
            this.buttonPutBackHook.Text = "PutBackHook";
            this.buttonPutBackHook.UseVisualStyleBackColor = true;
            this.buttonPutBackHook.Click += new System.EventHandler(this.buttonPutBackHook_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonPickBook);
            this.groupBox4.Controls.Add(this.comboBoxPickUpBook);
            this.groupBox4.Controls.Add(this.buttonPickUpBook);
            this.groupBox4.Controls.Add(this.buttonStandbyPosition);
            this.groupBox4.Controls.Add(this.buttonPutBackHook);
            this.groupBox4.Controls.Add(this.buttonPickUpHook);
            this.groupBox4.Controls.Add(this.comboBoxBookIndex);
            this.groupBox4.Controls.Add(this.buttonGoToPosistion);
            this.groupBox4.Location = new System.Drawing.Point(274, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(413, 139);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pick And Put";
            // 
            // buttonPickBook
            // 
            this.buttonPickBook.Location = new System.Drawing.Point(260, 86);
            this.buttonPickBook.Name = "buttonPickBook";
            this.buttonPickBook.Size = new System.Drawing.Size(100, 23);
            this.buttonPickBook.TabIndex = 27;
            this.buttonPickBook.Text = "Pick Up Book";
            this.buttonPickBook.UseVisualStyleBackColor = true;
            this.buttonPickBook.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // comboBoxPickUpBook
            // 
            this.comboBoxPickUpBook.FormattingEnabled = true;
            this.comboBoxPickUpBook.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxPickUpBook.Location = new System.Drawing.Point(154, 59);
            this.comboBoxPickUpBook.Name = "comboBoxPickUpBook";
            this.comboBoxPickUpBook.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPickUpBook.TabIndex = 26;
            this.comboBoxPickUpBook.Text = "Book Index To Pick Up";
            // 
            // buttonPickUpBook
            // 
            this.buttonPickUpBook.Location = new System.Drawing.Point(260, 57);
            this.buttonPickUpBook.Name = "buttonPickUpBook";
            this.buttonPickUpBook.Size = new System.Drawing.Size(100, 23);
            this.buttonPickUpBook.TabIndex = 25;
            this.buttonPickUpBook.Text = "Hook Out Book";
            this.buttonPickUpBook.UseVisualStyleBackColor = true;
            this.buttonPickUpBook.Click += new System.EventHandler(this.buttonPickUpBook_Click);
            // 
            // buttonStandbyPosition
            // 
            this.buttonStandbyPosition.Location = new System.Drawing.Point(32, 110);
            this.buttonStandbyPosition.Name = "buttonStandbyPosition";
            this.buttonStandbyPosition.Size = new System.Drawing.Size(222, 23);
            this.buttonStandbyPosition.TabIndex = 24;
            this.buttonStandbyPosition.Text = "Standby Position";
            this.buttonStandbyPosition.UseVisualStyleBackColor = true;
            this.buttonStandbyPosition.Click += new System.EventHandler(this.buttonStandbyPosition_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonCloseGripper);
            this.groupBox5.Controls.Add(this.buttonOpenGripper);
            this.groupBox5.Location = new System.Drawing.Point(13, 339);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(240, 84);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gripper Control";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(708, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "TEst";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // buttonPickDrop
            // 
            this.buttonPickDrop.Location = new System.Drawing.Point(814, 297);
            this.buttonPickDrop.Name = "buttonPickDrop";
            this.buttonPickDrop.Size = new System.Drawing.Size(100, 23);
            this.buttonPickDrop.TabIndex = 29;
            this.buttonPickDrop.Text = "Pick&Drop";
            this.buttonPickDrop.UseVisualStyleBackColor = true;
            this.buttonPickDrop.Click += new System.EventHandler(this.buttonPickDrop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 422);
            this.Controls.Add(this.buttonPickDrop);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToRobotArmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conncetToScannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelScannerConnection;
        private System.Windows.Forms.Label labelScanner;
        private System.Windows.Forms.Label labelRobotArmConnection;
        private System.Windows.Forms.Label labelRobotArm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCloseGripper;
        private System.Windows.Forms.Button buttonOpenGripper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonShelf3Right;
        private System.Windows.Forms.Button buttonShelf3Left;
        private System.Windows.Forms.Button buttonShelf2Right;
        private System.Windows.Forms.Button buttonShelf2Left;
        private System.Windows.Forms.Button buttonShelf1Right;
        private System.Windows.Forms.Button buttonShelf1Left;
        private System.Windows.Forms.Button buttonReadyPosition;
        private System.Windows.Forms.Button buttonOriginalPos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxSequence;
        private System.Windows.Forms.ListBox listBoxSearchItem;
        private System.Windows.Forms.Label label3MatchingIncorrectCount;
        private System.Windows.Forms.Label labelMatchingIncorrect;
        private System.Windows.Forms.Label labelMatchingCorrectCount;
        private System.Windows.Forms.Label labelMatchingCorrect;
        private System.Windows.Forms.Label labelItemFoundCount;
        private System.Windows.Forms.Label labelFoundItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonScanMode;
        private System.Windows.Forms.Button buttonResetRight;
        private System.Windows.Forms.Button buttonResetLeft;
        private System.Windows.Forms.Button buttonStopScan;
        private System.Windows.Forms.Button buttonGoToPosistion;
        private System.Windows.Forms.ComboBox comboBoxBookIndex;
        private System.Windows.Forms.Button buttonPutBackHook;
        private System.Windows.Forms.Button buttonPickUpHook;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonStandbyPosition;
        private System.Windows.Forms.ComboBox comboBoxPickUpBook;
        private System.Windows.Forms.Button buttonPickUpBook;
        private System.Windows.Forms.Button buttonPickBook;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonPickDrop;
    }
}

