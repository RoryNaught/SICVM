﻿namespace SIC_Simulator
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
            this.gbCPU = new System.Windows.Forms.GroupBox();
            this.txtSW_BIN_LSB = new System.Windows.Forms.TextBox();
            this.txtSW_BIN_MIB = new System.Windows.Forms.TextBox();
            this.txtSW_BIN_MSB = new System.Windows.Forms.TextBox();
            this.txtPC_BIN_LSB = new System.Windows.Forms.TextBox();
            this.txtPC_BIN_MIB = new System.Windows.Forms.TextBox();
            this.txtPC_BIN_MSB = new System.Windows.Forms.TextBox();
            this.txtX_BIN_LSB = new System.Windows.Forms.TextBox();
            this.txtX_BIN_MIB = new System.Windows.Forms.TextBox();
            this.txtX_BIN_MSB = new System.Windows.Forms.TextBox();
            this.txtL_BIN_LSB = new System.Windows.Forms.TextBox();
            this.txtL_BIN_MIB = new System.Windows.Forms.TextBox();
            this.txtL_BIN_MSB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSW_Dec = new System.Windows.Forms.TextBox();
            this.txtPC_Dec = new System.Windows.Forms.TextBox();
            this.txtX_Dec = new System.Windows.Forms.TextBox();
            this.txtL_Dec = new System.Windows.Forms.TextBox();
            this.txtA_Dec = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtA_BIN_LSB = new System.Windows.Forms.TextBox();
            this.txtA_BIN_MIB = new System.Windows.Forms.TextBox();
            this.txtA_BIN_MSB = new System.Windows.Forms.TextBox();
            this.txtSW_Hex = new System.Windows.Forms.TextBox();
            this.txtPC_Hex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtX_Hex = new System.Windows.Forms.TextBox();
            this.txtL_Hex = new System.Windows.Forms.TextBox();
            this.txtA_Hex = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpen_SIC_Object_File = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmloadAndAssembleSICSourceFIle = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSavedSICMachineStateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveMachineState = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFile_Ext = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout_CheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout_About = new System.Windows.Forms.ToolStripMenuItem();
            this.machineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmzeroAllMemory = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeAllMemoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setProgramCounterToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepSingleInstructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMachine = new System.Windows.Forms.TabControl();
            this.tpMemory = new System.Windows.Forms.TabPage();
            this.txtMemory = new System.Windows.Forms.TextBox();
            this.rbMemHex = new System.Windows.Forms.RadioButton();
            this.rbMemBinary = new System.Windows.Forms.RadioButton();
            this.tpDevices = new System.Windows.Forms.TabPage();
            this.gcDecodedInstruction = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStep = new System.Windows.Forms.Button();
            this.gbCPU.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tcMachine.SuspendLayout();
            this.tpMemory.SuspendLayout();
            this.gcDecodedInstruction.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCPU
            // 
            this.gbCPU.Controls.Add(this.txtSW_BIN_LSB);
            this.gbCPU.Controls.Add(this.txtSW_BIN_MIB);
            this.gbCPU.Controls.Add(this.txtSW_BIN_MSB);
            this.gbCPU.Controls.Add(this.txtPC_BIN_LSB);
            this.gbCPU.Controls.Add(this.txtPC_BIN_MIB);
            this.gbCPU.Controls.Add(this.txtPC_BIN_MSB);
            this.gbCPU.Controls.Add(this.txtX_BIN_LSB);
            this.gbCPU.Controls.Add(this.txtX_BIN_MIB);
            this.gbCPU.Controls.Add(this.txtX_BIN_MSB);
            this.gbCPU.Controls.Add(this.txtL_BIN_LSB);
            this.gbCPU.Controls.Add(this.txtL_BIN_MIB);
            this.gbCPU.Controls.Add(this.txtL_BIN_MSB);
            this.gbCPU.Controls.Add(this.label11);
            this.gbCPU.Controls.Add(this.txtSW_Dec);
            this.gbCPU.Controls.Add(this.txtPC_Dec);
            this.gbCPU.Controls.Add(this.txtX_Dec);
            this.gbCPU.Controls.Add(this.txtL_Dec);
            this.gbCPU.Controls.Add(this.txtA_Dec);
            this.gbCPU.Controls.Add(this.label10);
            this.gbCPU.Controls.Add(this.label9);
            this.gbCPU.Controls.Add(this.txtA_BIN_LSB);
            this.gbCPU.Controls.Add(this.txtA_BIN_MIB);
            this.gbCPU.Controls.Add(this.txtA_BIN_MSB);
            this.gbCPU.Controls.Add(this.txtSW_Hex);
            this.gbCPU.Controls.Add(this.txtPC_Hex);
            this.gbCPU.Controls.Add(this.label5);
            this.gbCPU.Controls.Add(this.label4);
            this.gbCPU.Controls.Add(this.label3);
            this.gbCPU.Controls.Add(this.label2);
            this.gbCPU.Controls.Add(this.label1);
            this.gbCPU.Controls.Add(this.txtX_Hex);
            this.gbCPU.Controls.Add(this.txtL_Hex);
            this.gbCPU.Controls.Add(this.txtA_Hex);
            this.gbCPU.Location = new System.Drawing.Point(12, 37);
            this.gbCPU.Name = "gbCPU";
            this.gbCPU.Size = new System.Drawing.Size(344, 182);
            this.gbCPU.TabIndex = 0;
            this.gbCPU.TabStop = false;
            this.gbCPU.Text = "SIC CPU";
            // 
            // txtSW_BIN_LSB
            // 
            this.txtSW_BIN_LSB.Location = new System.Drawing.Point(204, 150);
            this.txtSW_BIN_LSB.Name = "txtSW_BIN_LSB";
            this.txtSW_BIN_LSB.Size = new System.Drawing.Size(57, 20);
            this.txtSW_BIN_LSB.TabIndex = 32;
            this.txtSW_BIN_LSB.Text = "00000000";
            this.txtSW_BIN_LSB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSW_BIN_MIB
            // 
            this.txtSW_BIN_MIB.Location = new System.Drawing.Point(145, 150);
            this.txtSW_BIN_MIB.Name = "txtSW_BIN_MIB";
            this.txtSW_BIN_MIB.Size = new System.Drawing.Size(57, 20);
            this.txtSW_BIN_MIB.TabIndex = 31;
            this.txtSW_BIN_MIB.Text = "00000000";
            this.txtSW_BIN_MIB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSW_BIN_MSB
            // 
            this.txtSW_BIN_MSB.Location = new System.Drawing.Point(86, 150);
            this.txtSW_BIN_MSB.Name = "txtSW_BIN_MSB";
            this.txtSW_BIN_MSB.Size = new System.Drawing.Size(57, 20);
            this.txtSW_BIN_MSB.TabIndex = 30;
            this.txtSW_BIN_MSB.Text = "00000000";
            this.txtSW_BIN_MSB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPC_BIN_LSB
            // 
            this.txtPC_BIN_LSB.Location = new System.Drawing.Point(204, 121);
            this.txtPC_BIN_LSB.Name = "txtPC_BIN_LSB";
            this.txtPC_BIN_LSB.Size = new System.Drawing.Size(57, 20);
            this.txtPC_BIN_LSB.TabIndex = 29;
            this.txtPC_BIN_LSB.Text = "00000000";
            this.txtPC_BIN_LSB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPC_BIN_MIB
            // 
            this.txtPC_BIN_MIB.Location = new System.Drawing.Point(145, 121);
            this.txtPC_BIN_MIB.Name = "txtPC_BIN_MIB";
            this.txtPC_BIN_MIB.Size = new System.Drawing.Size(57, 20);
            this.txtPC_BIN_MIB.TabIndex = 28;
            this.txtPC_BIN_MIB.Text = "00000000";
            this.txtPC_BIN_MIB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPC_BIN_MSB
            // 
            this.txtPC_BIN_MSB.Location = new System.Drawing.Point(86, 121);
            this.txtPC_BIN_MSB.Name = "txtPC_BIN_MSB";
            this.txtPC_BIN_MSB.Size = new System.Drawing.Size(57, 20);
            this.txtPC_BIN_MSB.TabIndex = 27;
            this.txtPC_BIN_MSB.Text = "00000000";
            this.txtPC_BIN_MSB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtX_BIN_LSB
            // 
            this.txtX_BIN_LSB.Location = new System.Drawing.Point(204, 97);
            this.txtX_BIN_LSB.Name = "txtX_BIN_LSB";
            this.txtX_BIN_LSB.Size = new System.Drawing.Size(57, 20);
            this.txtX_BIN_LSB.TabIndex = 26;
            this.txtX_BIN_LSB.Text = "00000000";
            this.txtX_BIN_LSB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtX_BIN_MIB
            // 
            this.txtX_BIN_MIB.Location = new System.Drawing.Point(145, 97);
            this.txtX_BIN_MIB.Name = "txtX_BIN_MIB";
            this.txtX_BIN_MIB.Size = new System.Drawing.Size(57, 20);
            this.txtX_BIN_MIB.TabIndex = 25;
            this.txtX_BIN_MIB.Text = "00000000";
            this.txtX_BIN_MIB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtX_BIN_MSB
            // 
            this.txtX_BIN_MSB.Location = new System.Drawing.Point(86, 97);
            this.txtX_BIN_MSB.Name = "txtX_BIN_MSB";
            this.txtX_BIN_MSB.Size = new System.Drawing.Size(57, 20);
            this.txtX_BIN_MSB.TabIndex = 24;
            this.txtX_BIN_MSB.Text = "00000000";
            this.txtX_BIN_MSB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtL_BIN_LSB
            // 
            this.txtL_BIN_LSB.Location = new System.Drawing.Point(204, 68);
            this.txtL_BIN_LSB.Name = "txtL_BIN_LSB";
            this.txtL_BIN_LSB.Size = new System.Drawing.Size(57, 20);
            this.txtL_BIN_LSB.TabIndex = 23;
            this.txtL_BIN_LSB.Text = "00000000";
            this.txtL_BIN_LSB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtL_BIN_MIB
            // 
            this.txtL_BIN_MIB.Location = new System.Drawing.Point(145, 68);
            this.txtL_BIN_MIB.Name = "txtL_BIN_MIB";
            this.txtL_BIN_MIB.Size = new System.Drawing.Size(57, 20);
            this.txtL_BIN_MIB.TabIndex = 22;
            this.txtL_BIN_MIB.Text = "00000000";
            this.txtL_BIN_MIB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtL_BIN_MSB
            // 
            this.txtL_BIN_MSB.Location = new System.Drawing.Point(86, 68);
            this.txtL_BIN_MSB.Name = "txtL_BIN_MSB";
            this.txtL_BIN_MSB.Size = new System.Drawing.Size(57, 20);
            this.txtL_BIN_MSB.TabIndex = 21;
            this.txtL_BIN_MSB.Text = "00000000";
            this.txtL_BIN_MSB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Decimal";
            // 
            // txtSW_Dec
            // 
            this.txtSW_Dec.Location = new System.Drawing.Point(271, 150);
            this.txtSW_Dec.Name = "txtSW_Dec";
            this.txtSW_Dec.Size = new System.Drawing.Size(65, 20);
            this.txtSW_Dec.TabIndex = 19;
            this.txtSW_Dec.Text = "0";
            this.txtSW_Dec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPC_Dec
            // 
            this.txtPC_Dec.Location = new System.Drawing.Point(271, 122);
            this.txtPC_Dec.Name = "txtPC_Dec";
            this.txtPC_Dec.Size = new System.Drawing.Size(65, 20);
            this.txtPC_Dec.TabIndex = 18;
            this.txtPC_Dec.Text = "0";
            this.txtPC_Dec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtX_Dec
            // 
            this.txtX_Dec.Location = new System.Drawing.Point(271, 97);
            this.txtX_Dec.Name = "txtX_Dec";
            this.txtX_Dec.Size = new System.Drawing.Size(65, 20);
            this.txtX_Dec.TabIndex = 17;
            this.txtX_Dec.Text = "0";
            this.txtX_Dec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtL_Dec
            // 
            this.txtL_Dec.Location = new System.Drawing.Point(271, 66);
            this.txtL_Dec.Name = "txtL_Dec";
            this.txtL_Dec.Size = new System.Drawing.Size(65, 20);
            this.txtL_Dec.TabIndex = 16;
            this.txtL_Dec.Text = "0";
            this.txtL_Dec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtA_Dec
            // 
            this.txtA_Dec.Location = new System.Drawing.Point(271, 36);
            this.txtA_Dec.Name = "txtA_Dec";
            this.txtA_Dec.Size = new System.Drawing.Size(65, 20);
            this.txtA_Dec.TabIndex = 15;
            this.txtA_Dec.Text = "0";
            this.txtA_Dec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "BINARY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "HEX";
            // 
            // txtA_BIN_LSB
            // 
            this.txtA_BIN_LSB.Location = new System.Drawing.Point(204, 36);
            this.txtA_BIN_LSB.Name = "txtA_BIN_LSB";
            this.txtA_BIN_LSB.Size = new System.Drawing.Size(57, 20);
            this.txtA_BIN_LSB.TabIndex = 12;
            this.txtA_BIN_LSB.Text = "00000000";
            this.txtA_BIN_LSB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtA_BIN_MIB
            // 
            this.txtA_BIN_MIB.Location = new System.Drawing.Point(145, 36);
            this.txtA_BIN_MIB.Name = "txtA_BIN_MIB";
            this.txtA_BIN_MIB.Size = new System.Drawing.Size(57, 20);
            this.txtA_BIN_MIB.TabIndex = 11;
            this.txtA_BIN_MIB.Text = "00000000";
            this.txtA_BIN_MIB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtA_BIN_MSB
            // 
            this.txtA_BIN_MSB.Location = new System.Drawing.Point(86, 36);
            this.txtA_BIN_MSB.Name = "txtA_BIN_MSB";
            this.txtA_BIN_MSB.Size = new System.Drawing.Size(57, 20);
            this.txtA_BIN_MSB.TabIndex = 10;
            this.txtA_BIN_MSB.Text = "00000000";
            this.txtA_BIN_MSB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSW_Hex
            // 
            this.txtSW_Hex.Location = new System.Drawing.Point(33, 150);
            this.txtSW_Hex.Name = "txtSW_Hex";
            this.txtSW_Hex.Size = new System.Drawing.Size(45, 20);
            this.txtSW_Hex.TabIndex = 9;
            this.txtSW_Hex.Text = "000000";
            this.txtSW_Hex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPC_Hex
            // 
            this.txtPC_Hex.Location = new System.Drawing.Point(34, 122);
            this.txtPC_Hex.Name = "txtPC_Hex";
            this.txtPC_Hex.Size = new System.Drawing.Size(45, 20);
            this.txtPC_Hex.TabIndex = 8;
            this.txtPC_Hex.Text = "000000";
            this.txtPC_Hex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "SW";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "(PC)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "L";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // txtX_Hex
            // 
            this.txtX_Hex.Location = new System.Drawing.Point(34, 94);
            this.txtX_Hex.Name = "txtX_Hex";
            this.txtX_Hex.Size = new System.Drawing.Size(45, 20);
            this.txtX_Hex.TabIndex = 2;
            this.txtX_Hex.Text = "000000";
            this.txtX_Hex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtL_Hex
            // 
            this.txtL_Hex.Location = new System.Drawing.Point(33, 66);
            this.txtL_Hex.Name = "txtL_Hex";
            this.txtL_Hex.Size = new System.Drawing.Size(45, 20);
            this.txtL_Hex.TabIndex = 1;
            this.txtL_Hex.Text = "000000";
            this.txtL_Hex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtA_Hex
            // 
            this.txtA_Hex.Location = new System.Drawing.Point(33, 36);
            this.txtA_Hex.Name = "txtA_Hex";
            this.txtA_Hex.Size = new System.Drawing.Size(45, 20);
            this.txtA_Hex.TabIndex = 0;
            this.txtA_Hex.Text = "000000";
            this.txtA_Hex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmAbout,
            this.machineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpen_SIC_Object_File,
            this.tsmloadAndAssembleSICSourceFIle,
            this.loadSavedSICMachineStateToolStripMenuItem,
            this.tsmSaveMachineState,
            this.tsmFile_Ext});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(37, 20);
            this.tsmFile.Text = "File";
            // 
            // tsmOpen_SIC_Object_File
            // 
            this.tsmOpen_SIC_Object_File.Name = "tsmOpen_SIC_Object_File";
            this.tsmOpen_SIC_Object_File.Size = new System.Drawing.Size(257, 22);
            this.tsmOpen_SIC_Object_File.Text = "Open SIC Object File";
            // 
            // tsmloadAndAssembleSICSourceFIle
            // 
            this.tsmloadAndAssembleSICSourceFIle.Name = "tsmloadAndAssembleSICSourceFIle";
            this.tsmloadAndAssembleSICSourceFIle.Size = new System.Drawing.Size(257, 22);
            this.tsmloadAndAssembleSICSourceFIle.Text = "Load and Assemble SIC Source FIle";
            // 
            // loadSavedSICMachineStateToolStripMenuItem
            // 
            this.loadSavedSICMachineStateToolStripMenuItem.Name = "loadSavedSICMachineStateToolStripMenuItem";
            this.loadSavedSICMachineStateToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.loadSavedSICMachineStateToolStripMenuItem.Text = "Load Saved SIC Machine State";
            this.loadSavedSICMachineStateToolStripMenuItem.Click += new System.EventHandler(this.loadSavedSICMachineStateToolStripMenuItem_Click);
            // 
            // tsmSaveMachineState
            // 
            this.tsmSaveMachineState.Name = "tsmSaveMachineState";
            this.tsmSaveMachineState.Size = new System.Drawing.Size(257, 22);
            this.tsmSaveMachineState.Text = "Save SIC Machine State";
            this.tsmSaveMachineState.Click += new System.EventHandler(this.tsmSaveMachineState_Click);
            // 
            // tsmFile_Ext
            // 
            this.tsmFile_Ext.Name = "tsmFile_Ext";
            this.tsmFile_Ext.Size = new System.Drawing.Size(257, 22);
            this.tsmFile_Ext.Text = "Exit";
            // 
            // tsmAbout
            // 
            this.tsmAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbout_CheckForUpdates,
            this.tsmAbout_About});
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(52, 20);
            this.tsmAbout.Text = "About";
            // 
            // tsmAbout_CheckForUpdates
            // 
            this.tsmAbout_CheckForUpdates.Name = "tsmAbout_CheckForUpdates";
            this.tsmAbout_CheckForUpdates.Size = new System.Drawing.Size(171, 22);
            this.tsmAbout_CheckForUpdates.Text = "Check for Updates";
            // 
            // tsmAbout_About
            // 
            this.tsmAbout_About.Name = "tsmAbout_About";
            this.tsmAbout_About.Size = new System.Drawing.Size(171, 22);
            this.tsmAbout_About.Text = "About";
            // 
            // machineToolStripMenuItem
            // 
            this.machineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmzeroAllMemory,
            this.randomizeAllMemoryToolStripMenuItem,
            this.setProgramCounterToToolStripMenuItem,
            this.stepSingleInstructionToolStripMenuItem});
            this.machineToolStripMenuItem.Name = "machineToolStripMenuItem";
            this.machineToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.machineToolStripMenuItem.Text = "Machine";
            // 
            // tsmzeroAllMemory
            // 
            this.tsmzeroAllMemory.Name = "tsmzeroAllMemory";
            this.tsmzeroAllMemory.Size = new System.Drawing.Size(200, 22);
            this.tsmzeroAllMemory.Text = "Zero All Memory";
            // 
            // randomizeAllMemoryToolStripMenuItem
            // 
            this.randomizeAllMemoryToolStripMenuItem.Name = "randomizeAllMemoryToolStripMenuItem";
            this.randomizeAllMemoryToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.randomizeAllMemoryToolStripMenuItem.Text = "Randomize All Memory";
            // 
            // setProgramCounterToToolStripMenuItem
            // 
            this.setProgramCounterToToolStripMenuItem.Name = "setProgramCounterToToolStripMenuItem";
            this.setProgramCounterToToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.setProgramCounterToToolStripMenuItem.Text = "Set Program Counter To";
            // 
            // stepSingleInstructionToolStripMenuItem
            // 
            this.stepSingleInstructionToolStripMenuItem.Name = "stepSingleInstructionToolStripMenuItem";
            this.stepSingleInstructionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.stepSingleInstructionToolStripMenuItem.Text = "Step Single  Instruction";
            // 
            // tcMachine
            // 
            this.tcMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMachine.Controls.Add(this.tpMemory);
            this.tcMachine.Controls.Add(this.tpDevices);
            this.tcMachine.Location = new System.Drawing.Point(13, 226);
            this.tcMachine.Name = "tcMachine";
            this.tcMachine.SelectedIndex = 0;
            this.tcMachine.Size = new System.Drawing.Size(742, 320);
            this.tcMachine.TabIndex = 2;
            // 
            // tpMemory
            // 
            this.tpMemory.Controls.Add(this.txtMemory);
            this.tpMemory.Controls.Add(this.rbMemHex);
            this.tpMemory.Controls.Add(this.rbMemBinary);
            this.tpMemory.Location = new System.Drawing.Point(4, 22);
            this.tpMemory.Name = "tpMemory";
            this.tpMemory.Padding = new System.Windows.Forms.Padding(3);
            this.tpMemory.Size = new System.Drawing.Size(734, 294);
            this.tpMemory.TabIndex = 0;
            this.tpMemory.Text = "Memory";
            this.tpMemory.UseVisualStyleBackColor = true;
            // 
            // txtMemory
            // 
            this.txtMemory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemory.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemory.Location = new System.Drawing.Point(9, 29);
            this.txtMemory.Multiline = true;
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMemory.Size = new System.Drawing.Size(719, 257);
            this.txtMemory.TabIndex = 2;
            // 
            // rbMemHex
            // 
            this.rbMemHex.AutoSize = true;
            this.rbMemHex.Checked = true;
            this.rbMemHex.Location = new System.Drawing.Point(73, 7);
            this.rbMemHex.Name = "rbMemHex";
            this.rbMemHex.Size = new System.Drawing.Size(44, 17);
            this.rbMemHex.TabIndex = 1;
            this.rbMemHex.TabStop = true;
            this.rbMemHex.Text = "Hex";
            this.rbMemHex.UseVisualStyleBackColor = true;
            // 
            // rbMemBinary
            // 
            this.rbMemBinary.AutoSize = true;
            this.rbMemBinary.Location = new System.Drawing.Point(13, 7);
            this.rbMemBinary.Name = "rbMemBinary";
            this.rbMemBinary.Size = new System.Drawing.Size(54, 17);
            this.rbMemBinary.TabIndex = 0;
            this.rbMemBinary.Text = "Binary";
            this.rbMemBinary.UseVisualStyleBackColor = true;
            // 
            // tpDevices
            // 
            this.tpDevices.Location = new System.Drawing.Point(4, 22);
            this.tpDevices.Name = "tpDevices";
            this.tpDevices.Padding = new System.Windows.Forms.Padding(3);
            this.tpDevices.Size = new System.Drawing.Size(734, 294);
            this.tpDevices.TabIndex = 1;
            this.tpDevices.Text = "Devices";
            this.tpDevices.UseVisualStyleBackColor = true;
            // 
            // gcDecodedInstruction
            // 
            this.gcDecodedInstruction.Controls.Add(this.checkBox1);
            this.gcDecodedInstruction.Controls.Add(this.label8);
            this.gcDecodedInstruction.Controls.Add(this.label7);
            this.gcDecodedInstruction.Controls.Add(this.label6);
            this.gcDecodedInstruction.Location = new System.Drawing.Point(424, 46);
            this.gcDecodedInstruction.Name = "gcDecodedInstruction";
            this.gcDecodedInstruction.Size = new System.Drawing.Size(200, 183);
            this.gcDecodedInstruction.TabIndex = 3;
            this.gcDecodedInstruction.TabStop = false;
            this.gcDecodedInstruction.Text = "Decoded Instruction";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(38, 108);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "X Bit (Indexed Addressing)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "TA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mnemonic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "OpCode";
            // 
            // btnStep
            // 
            this.btnStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStep.Location = new System.Drawing.Point(30, 555);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(75, 23);
            this.btnStep.TabIndex = 4;
            this.btnStep.Text = "Step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 590);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.gcDecodedInstruction);
            this.Controls.Add(this.tcMachine);
            this.Controls.Add(this.gbCPU);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SIC Virtual Machine";
            this.gbCPU.ResumeLayout(false);
            this.gbCPU.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tcMachine.ResumeLayout(false);
            this.tpMemory.ResumeLayout(false);
            this.tpMemory.PerformLayout();
            this.gcDecodedInstruction.ResumeLayout(false);
            this.gcDecodedInstruction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCPU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtX_Hex;
        private System.Windows.Forms.TextBox txtL_Hex;
        private System.Windows.Forms.TextBox txtA_Hex;
        private System.Windows.Forms.TextBox txtSW_Hex;
        private System.Windows.Forms.TextBox txtPC_Hex;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen_SIC_Object_File;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveMachineState;
        private System.Windows.Forms.ToolStripMenuItem tsmFile_Ext;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout_CheckForUpdates;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout_About;
        private System.Windows.Forms.TabControl tcMachine;
        private System.Windows.Forms.TabPage tpMemory;
        private System.Windows.Forms.TabPage tpDevices;
        private System.Windows.Forms.ToolStripMenuItem machineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmzeroAllMemory;
        private System.Windows.Forms.ToolStripMenuItem randomizeAllMemoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setProgramCounterToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepSingleInstructionToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbMemHex;
        private System.Windows.Forms.RadioButton rbMemBinary;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.ToolStripMenuItem tsmloadAndAssembleSICSourceFIle;
        private System.Windows.Forms.ToolStripMenuItem loadSavedSICMachineStateToolStripMenuItem;
        private System.Windows.Forms.GroupBox gcDecodedInstruction;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSW_BIN_LSB;
        private System.Windows.Forms.TextBox txtSW_BIN_MIB;
        private System.Windows.Forms.TextBox txtSW_BIN_MSB;
        private System.Windows.Forms.TextBox txtPC_BIN_LSB;
        private System.Windows.Forms.TextBox txtPC_BIN_MIB;
        private System.Windows.Forms.TextBox txtPC_BIN_MSB;
        private System.Windows.Forms.TextBox txtX_BIN_LSB;
        private System.Windows.Forms.TextBox txtX_BIN_MIB;
        private System.Windows.Forms.TextBox txtX_BIN_MSB;
        private System.Windows.Forms.TextBox txtL_BIN_LSB;
        private System.Windows.Forms.TextBox txtL_BIN_MIB;
        private System.Windows.Forms.TextBox txtL_BIN_MSB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSW_Dec;
        private System.Windows.Forms.TextBox txtPC_Dec;
        private System.Windows.Forms.TextBox txtX_Dec;
        private System.Windows.Forms.TextBox txtL_Dec;
        private System.Windows.Forms.TextBox txtA_Dec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtA_BIN_LSB;
        private System.Windows.Forms.TextBox txtA_BIN_MIB;
        private System.Windows.Forms.TextBox txtA_BIN_MSB;
        private System.Windows.Forms.Button btnStep;
    }
}

