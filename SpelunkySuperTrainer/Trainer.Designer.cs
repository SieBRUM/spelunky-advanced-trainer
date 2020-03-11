namespace SpelunkySuperTrainer
{
    partial class Trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainer));
            this.grpboxPlayer = new System.Windows.Forms.GroupBox();
            this.btnChangeCurrentlyHolding = new System.Windows.Forms.Button();
            this.lblCurrentlyHolding = new System.Windows.Forms.Label();
            this.cboxCurrentlyHolding = new System.Windows.Forms.ComboBox();
            this.chckboxMoney = new System.Windows.Forms.CheckBox();
            this.btnSetMoney = new System.Windows.Forms.Button();
            this.numMoney = new System.Windows.Forms.NumericUpDown();
            this.lblMoney = new System.Windows.Forms.Label();
            this.chckboxRopes = new System.Windows.Forms.CheckBox();
            this.btnSetRopes = new System.Windows.Forms.Button();
            this.numRopes = new System.Windows.Forms.NumericUpDown();
            this.lblRopes = new System.Windows.Forms.Label();
            this.chckboxBombs = new System.Windows.Forms.CheckBox();
            this.btnSetBombs = new System.Windows.Forms.Button();
            this.numBombs = new System.Windows.Forms.NumericUpDown();
            this.lblBombs = new System.Windows.Forms.Label();
            this.chckboxHearts = new System.Windows.Forms.CheckBox();
            this.btnSetHearts = new System.Windows.Forms.Button();
            this.numHearts = new System.Windows.Forms.NumericUpDown();
            this.lblHearts = new System.Windows.Forms.Label();
            this.grpboxLevel = new System.Windows.Forms.GroupBox();
            this.btnTeleportToExit = new System.Windows.Forms.Button();
            this.chckboxLockRightTimer = new System.Windows.Forms.CheckBox();
            this.chckboxLockLeftTimer = new System.Windows.Forms.CheckBox();
            this.btnSetStage = new System.Windows.Forms.Button();
            this.btnTeleportToDest = new System.Windows.Forms.Button();
            this.lblStage = new System.Windows.Forms.Label();
            this.txtbYPlayer = new System.Windows.Forms.TextBox();
            this.lblYPlayer = new System.Windows.Forms.Label();
            this.numStage = new System.Windows.Forms.NumericUpDown();
            this.txtbXPlayer = new System.Windows.Forms.TextBox();
            this.lblXPlayer = new System.Windows.Forms.Label();
            this.grpBoxEntities = new System.Windows.Forms.GroupBox();
            this.lblEntArray = new System.Windows.Forms.Label();
            this.numEntArray = new System.Windows.Forms.NumericUpDown();
            this.btnTeleportEntToPlayer = new System.Windows.Forms.Button();
            this.btnTeleportToEnt = new System.Windows.Forms.Button();
            this.lblEntType = new System.Windows.Forms.Label();
            this.lblEntY = new System.Windows.Forms.Label();
            this.lblEntX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpboxPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRopes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBombs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHearts)).BeginInit();
            this.grpboxLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStage)).BeginInit();
            this.grpBoxEntities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEntArray)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxPlayer
            // 
            this.grpboxPlayer.Controls.Add(this.btnChangeCurrentlyHolding);
            this.grpboxPlayer.Controls.Add(this.lblCurrentlyHolding);
            this.grpboxPlayer.Controls.Add(this.cboxCurrentlyHolding);
            this.grpboxPlayer.Controls.Add(this.chckboxMoney);
            this.grpboxPlayer.Controls.Add(this.btnSetMoney);
            this.grpboxPlayer.Controls.Add(this.numMoney);
            this.grpboxPlayer.Controls.Add(this.lblMoney);
            this.grpboxPlayer.Controls.Add(this.chckboxRopes);
            this.grpboxPlayer.Controls.Add(this.btnSetRopes);
            this.grpboxPlayer.Controls.Add(this.numRopes);
            this.grpboxPlayer.Controls.Add(this.lblRopes);
            this.grpboxPlayer.Controls.Add(this.chckboxBombs);
            this.grpboxPlayer.Controls.Add(this.btnSetBombs);
            this.grpboxPlayer.Controls.Add(this.numBombs);
            this.grpboxPlayer.Controls.Add(this.lblBombs);
            this.grpboxPlayer.Controls.Add(this.chckboxHearts);
            this.grpboxPlayer.Controls.Add(this.btnSetHearts);
            this.grpboxPlayer.Controls.Add(this.numHearts);
            this.grpboxPlayer.Controls.Add(this.lblHearts);
            this.grpboxPlayer.Location = new System.Drawing.Point(12, 12);
            this.grpboxPlayer.Name = "grpboxPlayer";
            this.grpboxPlayer.Size = new System.Drawing.Size(200, 426);
            this.grpboxPlayer.TabIndex = 0;
            this.grpboxPlayer.TabStop = false;
            this.grpboxPlayer.Text = "Player";
            // 
            // btnChangeCurrentlyHolding
            // 
            this.btnChangeCurrentlyHolding.Location = new System.Drawing.Point(10, 399);
            this.btnChangeCurrentlyHolding.Name = "btnChangeCurrentlyHolding";
            this.btnChangeCurrentlyHolding.Size = new System.Drawing.Size(140, 23);
            this.btnChangeCurrentlyHolding.TabIndex = 23;
            this.btnChangeCurrentlyHolding.Text = "Change currently holding";
            this.btnChangeCurrentlyHolding.UseVisualStyleBackColor = true;
            this.btnChangeCurrentlyHolding.Click += new System.EventHandler(this.btnChangeCurrentlyHolding_Click);
            // 
            // lblCurrentlyHolding
            // 
            this.lblCurrentlyHolding.AutoSize = true;
            this.lblCurrentlyHolding.Location = new System.Drawing.Point(10, 352);
            this.lblCurrentlyHolding.Name = "lblCurrentlyHolding";
            this.lblCurrentlyHolding.Size = new System.Drawing.Size(85, 13);
            this.lblCurrentlyHolding.TabIndex = 22;
            this.lblCurrentlyHolding.Text = "Currently holding";
            // 
            // cboxCurrentlyHolding
            // 
            this.cboxCurrentlyHolding.FormattingEnabled = true;
            this.cboxCurrentlyHolding.Location = new System.Drawing.Point(10, 371);
            this.cboxCurrentlyHolding.Name = "cboxCurrentlyHolding";
            this.cboxCurrentlyHolding.Size = new System.Drawing.Size(121, 21);
            this.cboxCurrentlyHolding.TabIndex = 21;
            // 
            // chckboxMoney
            // 
            this.chckboxMoney.AutoSize = true;
            this.chckboxMoney.Location = new System.Drawing.Point(84, 314);
            this.chckboxMoney.Name = "chckboxMoney";
            this.chckboxMoney.Size = new System.Drawing.Size(50, 17);
            this.chckboxMoney.TabIndex = 20;
            this.chckboxMoney.Text = "Lock";
            this.chckboxMoney.UseVisualStyleBackColor = true;
            this.chckboxMoney.CheckedChanged += new System.EventHandler(this.chckboxMoney_CheckedChanged);
            // 
            // btnSetMoney
            // 
            this.btnSetMoney.Location = new System.Drawing.Point(10, 309);
            this.btnSetMoney.Name = "btnSetMoney";
            this.btnSetMoney.Size = new System.Drawing.Size(67, 23);
            this.btnSetMoney.TabIndex = 19;
            this.btnSetMoney.Text = "Set money";
            this.btnSetMoney.UseVisualStyleBackColor = true;
            this.btnSetMoney.Click += new System.EventHandler(this.btnSetMoney_Click);
            // 
            // numMoney
            // 
            this.numMoney.Location = new System.Drawing.Point(10, 282);
            this.numMoney.Maximum = new decimal(new int[] {
            1874919423,
            0,
            0,
            0});
            this.numMoney.Name = "numMoney";
            this.numMoney.Size = new System.Drawing.Size(120, 20);
            this.numMoney.TabIndex = 18;
            this.numMoney.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(7, 266);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(39, 13);
            this.lblMoney.TabIndex = 17;
            this.lblMoney.Text = "Money";
            // 
            // chckboxRopes
            // 
            this.chckboxRopes.AutoSize = true;
            this.chckboxRopes.Location = new System.Drawing.Point(84, 231);
            this.chckboxRopes.Name = "chckboxRopes";
            this.chckboxRopes.Size = new System.Drawing.Size(50, 17);
            this.chckboxRopes.TabIndex = 11;
            this.chckboxRopes.Text = "Lock";
            this.chckboxRopes.UseVisualStyleBackColor = true;
            this.chckboxRopes.CheckedChanged += new System.EventHandler(this.chckboxRopes_CheckedChanged);
            // 
            // btnSetRopes
            // 
            this.btnSetRopes.Location = new System.Drawing.Point(10, 226);
            this.btnSetRopes.Name = "btnSetRopes";
            this.btnSetRopes.Size = new System.Drawing.Size(67, 23);
            this.btnSetRopes.TabIndex = 10;
            this.btnSetRopes.Text = "Set ropes";
            this.btnSetRopes.UseVisualStyleBackColor = true;
            this.btnSetRopes.Click += new System.EventHandler(this.btnSetRopes_Click);
            // 
            // numRopes
            // 
            this.numRopes.Location = new System.Drawing.Point(10, 199);
            this.numRopes.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numRopes.Name = "numRopes";
            this.numRopes.Size = new System.Drawing.Size(120, 20);
            this.numRopes.TabIndex = 9;
            this.numRopes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRopes
            // 
            this.lblRopes.AutoSize = true;
            this.lblRopes.Location = new System.Drawing.Point(7, 183);
            this.lblRopes.Name = "lblRopes";
            this.lblRopes.Size = new System.Drawing.Size(38, 13);
            this.lblRopes.TabIndex = 8;
            this.lblRopes.Text = "Ropes";
            // 
            // chckboxBombs
            // 
            this.chckboxBombs.AutoSize = true;
            this.chckboxBombs.Location = new System.Drawing.Point(84, 148);
            this.chckboxBombs.Name = "chckboxBombs";
            this.chckboxBombs.Size = new System.Drawing.Size(50, 17);
            this.chckboxBombs.TabIndex = 7;
            this.chckboxBombs.Text = "Lock";
            this.chckboxBombs.UseVisualStyleBackColor = true;
            this.chckboxBombs.CheckedChanged += new System.EventHandler(this.chckboxBombs_CheckedChanged);
            // 
            // btnSetBombs
            // 
            this.btnSetBombs.Location = new System.Drawing.Point(10, 143);
            this.btnSetBombs.Name = "btnSetBombs";
            this.btnSetBombs.Size = new System.Drawing.Size(67, 23);
            this.btnSetBombs.TabIndex = 6;
            this.btnSetBombs.Text = "Set bombs";
            this.btnSetBombs.UseVisualStyleBackColor = true;
            this.btnSetBombs.Click += new System.EventHandler(this.btnSetBombs_Click);
            // 
            // numBombs
            // 
            this.numBombs.Location = new System.Drawing.Point(10, 116);
            this.numBombs.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numBombs.Name = "numBombs";
            this.numBombs.Size = new System.Drawing.Size(120, 20);
            this.numBombs.TabIndex = 5;
            this.numBombs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblBombs
            // 
            this.lblBombs.AutoSize = true;
            this.lblBombs.Location = new System.Drawing.Point(7, 100);
            this.lblBombs.Name = "lblBombs";
            this.lblBombs.Size = new System.Drawing.Size(39, 13);
            this.lblBombs.TabIndex = 4;
            this.lblBombs.Text = "Bombs";
            // 
            // chckboxHearts
            // 
            this.chckboxHearts.AutoSize = true;
            this.chckboxHearts.Location = new System.Drawing.Point(84, 68);
            this.chckboxHearts.Name = "chckboxHearts";
            this.chckboxHearts.Size = new System.Drawing.Size(50, 17);
            this.chckboxHearts.TabIndex = 3;
            this.chckboxHearts.Text = "Lock";
            this.chckboxHearts.UseVisualStyleBackColor = true;
            this.chckboxHearts.CheckedChanged += new System.EventHandler(this.chckboxHearts_CheckedChanged);
            // 
            // btnSetHearts
            // 
            this.btnSetHearts.Location = new System.Drawing.Point(10, 63);
            this.btnSetHearts.Name = "btnSetHearts";
            this.btnSetHearts.Size = new System.Drawing.Size(67, 23);
            this.btnSetHearts.TabIndex = 2;
            this.btnSetHearts.Text = "Set hearts";
            this.btnSetHearts.UseVisualStyleBackColor = true;
            this.btnSetHearts.Click += new System.EventHandler(this.btnSetHearts_Click);
            // 
            // numHearts
            // 
            this.numHearts.Location = new System.Drawing.Point(10, 36);
            this.numHearts.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numHearts.Name = "numHearts";
            this.numHearts.Size = new System.Drawing.Size(120, 20);
            this.numHearts.TabIndex = 1;
            this.numHearts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHearts
            // 
            this.lblHearts.AutoSize = true;
            this.lblHearts.Location = new System.Drawing.Point(7, 20);
            this.lblHearts.Name = "lblHearts";
            this.lblHearts.Size = new System.Drawing.Size(38, 13);
            this.lblHearts.TabIndex = 0;
            this.lblHearts.Text = "Hearts";
            // 
            // grpboxLevel
            // 
            this.grpboxLevel.Controls.Add(this.btnTeleportToExit);
            this.grpboxLevel.Controls.Add(this.chckboxLockRightTimer);
            this.grpboxLevel.Controls.Add(this.chckboxLockLeftTimer);
            this.grpboxLevel.Controls.Add(this.btnSetStage);
            this.grpboxLevel.Controls.Add(this.btnTeleportToDest);
            this.grpboxLevel.Controls.Add(this.lblStage);
            this.grpboxLevel.Controls.Add(this.txtbYPlayer);
            this.grpboxLevel.Controls.Add(this.lblYPlayer);
            this.grpboxLevel.Controls.Add(this.numStage);
            this.grpboxLevel.Controls.Add(this.txtbXPlayer);
            this.grpboxLevel.Controls.Add(this.lblXPlayer);
            this.grpboxLevel.Location = new System.Drawing.Point(218, 13);
            this.grpboxLevel.Name = "grpboxLevel";
            this.grpboxLevel.Size = new System.Drawing.Size(200, 301);
            this.grpboxLevel.TabIndex = 1;
            this.grpboxLevel.TabStop = false;
            this.grpboxLevel.Text = "Level";
            // 
            // btnTeleportToExit
            // 
            this.btnTeleportToExit.Location = new System.Drawing.Point(9, 265);
            this.btnTeleportToExit.Name = "btnTeleportToExit";
            this.btnTeleportToExit.Size = new System.Drawing.Size(121, 23);
            this.btnTeleportToExit.TabIndex = 17;
            this.btnTeleportToExit.Text = "Teleport to exit";
            this.btnTeleportToExit.UseVisualStyleBackColor = true;
            this.btnTeleportToExit.Click += new System.EventHandler(this.btnTeleportToExit_Click);
            // 
            // chckboxLockRightTimer
            // 
            this.chckboxLockRightTimer.AutoSize = true;
            this.chckboxLockRightTimer.Location = new System.Drawing.Point(9, 122);
            this.chckboxLockRightTimer.Name = "chckboxLockRightTimer";
            this.chckboxLockRightTimer.Size = new System.Drawing.Size(98, 17);
            this.chckboxLockRightTimer.TabIndex = 22;
            this.chckboxLockRightTimer.Text = "Lock right timer";
            this.chckboxLockRightTimer.UseVisualStyleBackColor = true;
            this.chckboxLockRightTimer.CheckedChanged += new System.EventHandler(this.chckboxLockRightTimer_CheckedChanged);
            // 
            // chckboxLockLeftTimer
            // 
            this.chckboxLockLeftTimer.AutoSize = true;
            this.chckboxLockLeftTimer.Location = new System.Drawing.Point(9, 99);
            this.chckboxLockLeftTimer.Name = "chckboxLockLeftTimer";
            this.chckboxLockLeftTimer.Size = new System.Drawing.Size(92, 17);
            this.chckboxLockLeftTimer.TabIndex = 21;
            this.chckboxLockLeftTimer.Text = "Lock left timer";
            this.chckboxLockLeftTimer.UseVisualStyleBackColor = true;
            this.chckboxLockLeftTimer.CheckedChanged += new System.EventHandler(this.chckboxLockLeftTimer_CheckedChanged);
            // 
            // btnSetStage
            // 
            this.btnSetStage.Location = new System.Drawing.Point(9, 62);
            this.btnSetStage.Name = "btnSetStage";
            this.btnSetStage.Size = new System.Drawing.Size(67, 23);
            this.btnSetStage.TabIndex = 20;
            this.btnSetStage.Text = "Set stage";
            this.btnSetStage.UseVisualStyleBackColor = true;
            this.btnSetStage.Click += new System.EventHandler(this.btnSetStage_Click);
            // 
            // btnTeleportToDest
            // 
            this.btnTeleportToDest.Location = new System.Drawing.Point(9, 236);
            this.btnTeleportToDest.Name = "btnTeleportToDest";
            this.btnTeleportToDest.Size = new System.Drawing.Size(121, 23);
            this.btnTeleportToDest.TabIndex = 16;
            this.btnTeleportToDest.Text = "Teleport to destination";
            this.btnTeleportToDest.UseVisualStyleBackColor = true;
            this.btnTeleportToDest.Click += new System.EventHandler(this.btnTeleportToDest_Click);
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.Location = new System.Drawing.Point(6, 19);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(35, 13);
            this.lblStage.TabIndex = 18;
            this.lblStage.Text = "Stage";
            // 
            // txtbYPlayer
            // 
            this.txtbYPlayer.Location = new System.Drawing.Point(9, 209);
            this.txtbYPlayer.Name = "txtbYPlayer";
            this.txtbYPlayer.Size = new System.Drawing.Size(117, 20);
            this.txtbYPlayer.TabIndex = 15;
            // 
            // lblYPlayer
            // 
            this.lblYPlayer.AutoSize = true;
            this.lblYPlayer.Location = new System.Drawing.Point(6, 193);
            this.lblYPlayer.Name = "lblYPlayer";
            this.lblYPlayer.Size = new System.Drawing.Size(68, 13);
            this.lblYPlayer.TabIndex = 14;
            this.lblYPlayer.Text = "Y destination";
            // 
            // numStage
            // 
            this.numStage.Location = new System.Drawing.Point(9, 35);
            this.numStage.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numStage.Name = "numStage";
            this.numStage.Size = new System.Drawing.Size(120, 20);
            this.numStage.TabIndex = 19;
            this.numStage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtbXPlayer
            // 
            this.txtbXPlayer.Location = new System.Drawing.Point(9, 171);
            this.txtbXPlayer.Name = "txtbXPlayer";
            this.txtbXPlayer.Size = new System.Drawing.Size(117, 20);
            this.txtbXPlayer.TabIndex = 13;
            // 
            // lblXPlayer
            // 
            this.lblXPlayer.AutoSize = true;
            this.lblXPlayer.Location = new System.Drawing.Point(6, 155);
            this.lblXPlayer.Name = "lblXPlayer";
            this.lblXPlayer.Size = new System.Drawing.Size(68, 13);
            this.lblXPlayer.TabIndex = 12;
            this.lblXPlayer.Text = "X destination";
            // 
            // grpBoxEntities
            // 
            this.grpBoxEntities.Controls.Add(this.lblEntArray);
            this.grpBoxEntities.Controls.Add(this.numEntArray);
            this.grpBoxEntities.Controls.Add(this.btnTeleportEntToPlayer);
            this.grpBoxEntities.Controls.Add(this.btnTeleportToEnt);
            this.grpBoxEntities.Controls.Add(this.lblEntType);
            this.grpBoxEntities.Controls.Add(this.lblEntY);
            this.grpBoxEntities.Controls.Add(this.lblEntX);
            this.grpBoxEntities.Location = new System.Drawing.Point(424, 13);
            this.grpBoxEntities.Name = "grpBoxEntities";
            this.grpBoxEntities.Size = new System.Drawing.Size(200, 301);
            this.grpBoxEntities.TabIndex = 2;
            this.grpBoxEntities.TabStop = false;
            this.grpBoxEntities.Text = "Entities (dangerous)";
            // 
            // lblEntArray
            // 
            this.lblEntArray.AutoSize = true;
            this.lblEntArray.Location = new System.Drawing.Point(38, 41);
            this.lblEntArray.Name = "lblEntArray";
            this.lblEntArray.Size = new System.Drawing.Size(88, 13);
            this.lblEntArray.TabIndex = 26;
            this.lblEntArray.Text = "Entity Array index";
            // 
            // numEntArray
            // 
            this.numEntArray.Hexadecimal = true;
            this.numEntArray.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numEntArray.Location = new System.Drawing.Point(38, 62);
            this.numEntArray.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numEntArray.Name = "numEntArray";
            this.numEntArray.Size = new System.Drawing.Size(120, 20);
            this.numEntArray.TabIndex = 25;
            this.numEntArray.ValueChanged += new System.EventHandler(this.numEntArray_ValueChanged);
            // 
            // btnTeleportEntToPlayer
            // 
            this.btnTeleportEntToPlayer.Location = new System.Drawing.Point(38, 209);
            this.btnTeleportEntToPlayer.Name = "btnTeleportEntToPlayer";
            this.btnTeleportEntToPlayer.Size = new System.Drawing.Size(121, 23);
            this.btnTeleportEntToPlayer.TabIndex = 24;
            this.btnTeleportEntToPlayer.Text = "Teleport entity";
            this.btnTeleportEntToPlayer.UseVisualStyleBackColor = true;
            this.btnTeleportEntToPlayer.Click += new System.EventHandler(this.btnTeleportEntToPlayer_Click);
            // 
            // btnTeleportToEnt
            // 
            this.btnTeleportToEnt.Location = new System.Drawing.Point(38, 177);
            this.btnTeleportToEnt.Name = "btnTeleportToEnt";
            this.btnTeleportToEnt.Size = new System.Drawing.Size(121, 23);
            this.btnTeleportToEnt.TabIndex = 23;
            this.btnTeleportToEnt.Text = "Teleport to entity";
            this.btnTeleportToEnt.UseVisualStyleBackColor = true;
            this.btnTeleportToEnt.Click += new System.EventHandler(this.btnTeleportToEnt_Click);
            // 
            // lblEntType
            // 
            this.lblEntType.AutoSize = true;
            this.lblEntType.Location = new System.Drawing.Point(35, 142);
            this.lblEntType.Name = "lblEntType";
            this.lblEntType.Size = new System.Drawing.Size(140, 13);
            this.lblEntType.TabIndex = 5;
            this.lblEntType.Text = "Type = unknown (unknown)";
            // 
            // lblEntY
            // 
            this.lblEntY.AutoSize = true;
            this.lblEntY.Location = new System.Drawing.Point(35, 117);
            this.lblEntY.Name = "lblEntY";
            this.lblEntY.Size = new System.Drawing.Size(64, 13);
            this.lblEntY.TabIndex = 4;
            this.lblEntY.Text = "Y = unkown";
            // 
            // lblEntX
            // 
            this.lblEntX.AutoSize = true;
            this.lblEntX.Location = new System.Drawing.Point(35, 94);
            this.lblEntX.Name = "lblEntX";
            this.lblEntX.Size = new System.Drawing.Size(70, 13);
            this.lblEntX.TabIndex = 3;
            this.lblEntX.Text = "X = unknown";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "https://www.youtube.com/user/siebren88";
            // 
            // Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBoxEntities);
            this.Controls.Add(this.grpboxLevel);
            this.Controls.Add(this.grpboxPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(651, 485);
            this.MinimumSize = new System.Drawing.Size(651, 485);
            this.Name = "Trainer";
            this.Text = "Spelunky trainer by Brum";
            this.grpboxPlayer.ResumeLayout(false);
            this.grpboxPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRopes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBombs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHearts)).EndInit();
            this.grpboxLevel.ResumeLayout(false);
            this.grpboxLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStage)).EndInit();
            this.grpBoxEntities.ResumeLayout(false);
            this.grpBoxEntities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEntArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxPlayer;
        private System.Windows.Forms.GroupBox grpboxLevel;
        private System.Windows.Forms.GroupBox grpBoxEntities;
        private System.Windows.Forms.CheckBox chckboxHearts;
        private System.Windows.Forms.Button btnSetHearts;
        private System.Windows.Forms.NumericUpDown numHearts;
        private System.Windows.Forms.Label lblHearts;
        private System.Windows.Forms.CheckBox chckboxBombs;
        private System.Windows.Forms.Button btnSetBombs;
        private System.Windows.Forms.NumericUpDown numBombs;
        private System.Windows.Forms.Label lblBombs;
        private System.Windows.Forms.CheckBox chckboxRopes;
        private System.Windows.Forms.Button btnSetRopes;
        private System.Windows.Forms.NumericUpDown numRopes;
        private System.Windows.Forms.Label lblRopes;
        private System.Windows.Forms.TextBox txtbYPlayer;
        private System.Windows.Forms.Label lblYPlayer;
        private System.Windows.Forms.TextBox txtbXPlayer;
        private System.Windows.Forms.Label lblXPlayer;
        private System.Windows.Forms.Button btnTeleportToDest;
        private System.Windows.Forms.Button btnTeleportToExit;
        private System.Windows.Forms.Button btnSetStage;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.NumericUpDown numStage;
        private System.Windows.Forms.CheckBox chckboxLockRightTimer;
        private System.Windows.Forms.CheckBox chckboxLockLeftTimer;
        private System.Windows.Forms.CheckBox chckboxMoney;
        private System.Windows.Forms.Button btnSetMoney;
        private System.Windows.Forms.NumericUpDown numMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblEntX;
        private System.Windows.Forms.Label lblEntY;
        private System.Windows.Forms.Label lblEntType;
        private System.Windows.Forms.Button btnTeleportToEnt;
        private System.Windows.Forms.Button btnTeleportEntToPlayer;
        private System.Windows.Forms.Label lblCurrentlyHolding;
        private System.Windows.Forms.ComboBox cboxCurrentlyHolding;
        private System.Windows.Forms.Button btnChangeCurrentlyHolding;
        private System.Windows.Forms.NumericUpDown numEntArray;
        private System.Windows.Forms.Label lblEntArray;
        private System.Windows.Forms.Label label1;
    }
}

