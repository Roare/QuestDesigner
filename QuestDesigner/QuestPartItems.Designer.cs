namespace DOL.Tools.QuestDesigner
{
	partial class QuestPartItems
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestPartItems));
            this.triggerTypeList = new System.Windows.Forms.CheckedListBox();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.actionTypeList = new System.Windows.Forms.CheckedListBox();
            this.requirementTypeList = new System.Windows.Forms.CheckedListBox();
            this.headerStrip1 = new DOL.Tools.QuestDesigner.Controls.HeaderStrip();
            this.toolStripLabelTrigger = new System.Windows.Forms.ToolStripLabel();
            this.headerStrip2 = new DOL.Tools.QuestDesigner.Controls.HeaderStrip();
            this.toolStripLabelRequirement = new System.Windows.Forms.ToolStripLabel();
            this.headerStrip3 = new DOL.Tools.QuestDesigner.Controls.HeaderStrip();
            this.toolStripLabelAction = new System.Windows.Forms.ToolStripLabel();
            this.questPartTextbox = new DOL.Tools.QuestDesigner.Controls.RichTextBoxEx();
            this.contextMenuStripQuestPart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.triggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whisperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questGivableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questPendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queststepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giveItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseQueststepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultStepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offerAcceptQuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipTimer = new System.Windows.Forms.Timer(this.components);
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.headerStrip1.SuspendLayout();
            this.headerStrip2.SuspendLayout();
            this.headerStrip3.SuspendLayout();
            this.contextMenuStripQuestPart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // triggerTypeList
            // 
            this.triggerTypeList.CheckOnClick = true;
            this.triggerTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggerTypeList.Enabled = false;
            this.triggerTypeList.FormattingEnabled = true;
            this.triggerTypeList.Location = new System.Drawing.Point(3, 23);
            this.triggerTypeList.Name = "triggerTypeList";
            this.triggerTypeList.Size = new System.Drawing.Size(125, 199);
            this.triggerTypeList.TabIndex = 1;
            this.toolTip.SetToolTip(this.triggerTypeList, "Trigger types");
            this.triggerTypeList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.triggerTypeList_ItemCheck);
            this.triggerTypeList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.questTypeList_MouseMove);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.questPartTextbox);
            this.splitContainerMain.Panel2.Controls.Add(this.bindingNavigator);
            this.splitContainerMain.Size = new System.Drawing.Size(394, 344);
            this.splitContainerMain.SplitterDistance = 228;
            this.splitContainerMain.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.triggerTypeList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.actionTypeList, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.requirementTypeList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.headerStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.headerStrip2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.headerStrip3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 228);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // actionTypeList
            // 
            this.actionTypeList.CheckOnClick = true;
            this.actionTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionTypeList.Enabled = false;
            this.actionTypeList.FormattingEnabled = true;
            this.actionTypeList.Location = new System.Drawing.Point(265, 23);
            this.actionTypeList.Name = "actionTypeList";
            this.actionTypeList.Size = new System.Drawing.Size(126, 199);
            this.actionTypeList.TabIndex = 3;
            this.toolTip.SetToolTip(this.actionTypeList, "Action Types");
            this.actionTypeList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.actionTypeList_ItemCheck);
            this.actionTypeList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.questTypeList_MouseMove);
            // 
            // requirementTypeList
            // 
            this.requirementTypeList.CheckOnClick = true;
            this.requirementTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requirementTypeList.Enabled = false;
            this.requirementTypeList.FormattingEnabled = true;
            this.requirementTypeList.Location = new System.Drawing.Point(134, 23);
            this.requirementTypeList.Name = "requirementTypeList";
            this.requirementTypeList.Size = new System.Drawing.Size(125, 199);
            this.requirementTypeList.TabIndex = 2;
            this.toolTip.SetToolTip(this.requirementTypeList, "Requirement Types");
            this.requirementTypeList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.requirementTypeList_ItemCheck);
            this.requirementTypeList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.questTypeList_MouseMove);
            // 
            // headerStrip1
            // 
            this.headerStrip1.AutoSize = false;
            this.headerStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.headerStrip1.ForeColor = System.Drawing.Color.Gray;
            this.headerStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.headerStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelTrigger});
            this.headerStrip1.Location = new System.Drawing.Point(0, 0);
            this.headerStrip1.Name = "headerStrip1";
            this.headerStrip1.Size = new System.Drawing.Size(131, 20);
            this.headerStrip1.TabIndex = 4;
            this.headerStrip1.Text = "headerStrip1";
            // 
            // toolStripLabelTrigger
            // 
            this.toolStripLabelTrigger.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabelTrigger.Name = "toolStripLabelTrigger";
            this.toolStripLabelTrigger.Size = new System.Drawing.Size(59, 17);
            this.toolStripLabelTrigger.Text = "Trigger";
            // 
            // headerStrip2
            // 
            this.headerStrip2.AutoSize = false;
            this.headerStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerStrip2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.headerStrip2.ForeColor = System.Drawing.Color.Gray;
            this.headerStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.headerStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelRequirement});
            this.headerStrip2.Location = new System.Drawing.Point(131, 0);
            this.headerStrip2.Name = "headerStrip2";
            this.headerStrip2.Size = new System.Drawing.Size(131, 20);
            this.headerStrip2.TabIndex = 5;
            this.headerStrip2.Text = "headerStrip2";
            // 
            // toolStripLabelRequirement
            // 
            this.toolStripLabelRequirement.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabelRequirement.Name = "toolStripLabelRequirement";
            this.toolStripLabelRequirement.Size = new System.Drawing.Size(99, 17);
            this.toolStripLabelRequirement.Text = "Requirement";
            // 
            // headerStrip3
            // 
            this.headerStrip3.AutoSize = false;
            this.headerStrip3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerStrip3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.headerStrip3.ForeColor = System.Drawing.Color.Gray;
            this.headerStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.headerStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelAction});
            this.headerStrip3.Location = new System.Drawing.Point(262, 0);
            this.headerStrip3.Name = "headerStrip3";
            this.headerStrip3.Size = new System.Drawing.Size(132, 20);
            this.headerStrip3.TabIndex = 6;
            this.headerStrip3.Text = "headerStrip3";
            // 
            // toolStripLabelAction
            // 
            this.toolStripLabelAction.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabelAction.Name = "toolStripLabelAction";
            this.toolStripLabelAction.Size = new System.Drawing.Size(60, 17);
            this.toolStripLabelAction.Text = "Actions";
            // 
            // questPartTextbox
            // 
            this.questPartTextbox.ContextMenuStrip = this.contextMenuStripQuestPart;
            this.questPartTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.questPartTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questPartTextbox.Location = new System.Drawing.Point(0, 0);
            this.questPartTextbox.Name = "questPartTextbox";
            this.questPartTextbox.ReadOnly = true;
            this.questPartTextbox.SelectionEnd = 0;
            this.questPartTextbox.Size = new System.Drawing.Size(394, 87);
            this.questPartTextbox.TabIndex = 0;
            this.questPartTextbox.Text = "";
            this.questPartTextbox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.questPartTextbox_LinkClicked);
            // 
            // contextMenuStripQuestPart
            // 
            this.contextMenuStripQuestPart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triggerToolStripMenuItem,
            this.requirementToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.defaultStepsToolStripMenuItem});
            this.contextMenuStripQuestPart.Name = "contextMenuStripQuestPart";
            this.contextMenuStripQuestPart.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStripQuestPart.Size = new System.Drawing.Size(151, 92);
            // 
            // triggerToolStripMenuItem
            // 
            this.triggerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interactToolStripMenuItem,
            this.whisperToolStripMenuItem});
            this.triggerToolStripMenuItem.Name = "triggerToolStripMenuItem";
            this.triggerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.triggerToolStripMenuItem.Text = "Trigger";
            // 
            // interactToolStripMenuItem
            // 
            this.interactToolStripMenuItem.Name = "interactToolStripMenuItem";
            this.interactToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.interactToolStripMenuItem.Text = "Interact";
            this.interactToolStripMenuItem.Click += new System.EventHandler(this.interactToolStripMenuItem_Click);
            // 
            // whisperToolStripMenuItem
            // 
            this.whisperToolStripMenuItem.Name = "whisperToolStripMenuItem";
            this.whisperToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.whisperToolStripMenuItem.Text = "Whisper";
            this.whisperToolStripMenuItem.Click += new System.EventHandler(this.whisperToolStripMenuItem_Click);
            // 
            // requirementToolStripMenuItem
            // 
            this.requirementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questGivableToolStripMenuItem,
            this.questPendingToolStripMenuItem,
            this.queststepToolStripMenuItem});
            this.requirementToolStripMenuItem.Name = "requirementToolStripMenuItem";
            this.requirementToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.requirementToolStripMenuItem.Text = "Requirement";
            // 
            // questGivableToolStripMenuItem
            // 
            this.questGivableToolStripMenuItem.Name = "questGivableToolStripMenuItem";
            this.questGivableToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.questGivableToolStripMenuItem.Text = "Quest Givable";
            this.questGivableToolStripMenuItem.Click += new System.EventHandler(this.questGivableToolStripMenuItem_Click);
            // 
            // questPendingToolStripMenuItem
            // 
            this.questPendingToolStripMenuItem.Name = "questPendingToolStripMenuItem";
            this.questPendingToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.questPendingToolStripMenuItem.Text = "Quest Pending";
            this.questPendingToolStripMenuItem.Click += new System.EventHandler(this.questPendingToolStripMenuItem_Click);
            // 
            // queststepToolStripMenuItem
            // 
            this.queststepToolStripMenuItem.Name = "queststepToolStripMenuItem";
            this.queststepToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.queststepToolStripMenuItem.Text = "Queststep";
            this.queststepToolStripMenuItem.Click += new System.EventHandler(this.queststepToolStripMenuItem_Click);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giveItemToolStripMenuItem,
            this.increaseQueststepToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // giveItemToolStripMenuItem
            // 
            this.giveItemToolStripMenuItem.Name = "giveItemToolStripMenuItem";
            this.giveItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.giveItemToolStripMenuItem.Text = "GiveItem";
            this.giveItemToolStripMenuItem.Click += new System.EventHandler(this.giveItemToolStripMenuItem_Click);
            // 
            // increaseQueststepToolStripMenuItem
            // 
            this.increaseQueststepToolStripMenuItem.Name = "increaseQueststepToolStripMenuItem";
            this.increaseQueststepToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.increaseQueststepToolStripMenuItem.Text = "Increase Queststep";
            this.increaseQueststepToolStripMenuItem.Click += new System.EventHandler(this.increaseQueststepToolStripMenuItem_Click);
            // 
            // defaultStepsToolStripMenuItem
            // 
            this.defaultStepsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offerAcceptQuestToolStripMenuItem});
            this.defaultStepsToolStripMenuItem.Name = "defaultStepsToolStripMenuItem";
            this.defaultStepsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.defaultStepsToolStripMenuItem.Text = "Default Steps";
            // 
            // offerAcceptQuestToolStripMenuItem
            // 
            this.offerAcceptQuestToolStripMenuItem.Name = "offerAcceptQuestToolStripMenuItem";
            this.offerAcceptQuestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.offerAcceptQuestToolStripMenuItem.Text = "Offer/Accept Quest";
            this.offerAcceptQuestToolStripMenuItem.Click += new System.EventHandler(this.offerAcceptQuestToolStripMenuItem_Click);
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 87);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(394, 25);
            this.bindingNavigator.TabIndex = 1;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tooltipTimer
            // 
            this.tooltipTimer.Tick += new System.EventHandler(this.tooltipTimer_Tick);
            // 
            // QuestPartItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerMain);
            this.Name = "QuestPartItems";
            this.Size = new System.Drawing.Size(394, 344);
            this.Load += new System.EventHandler(this.QuestPartItems_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            this.splitContainerMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.headerStrip1.ResumeLayout(false);
            this.headerStrip1.PerformLayout();
            this.headerStrip2.ResumeLayout(false);
            this.headerStrip2.PerformLayout();
            this.headerStrip3.ResumeLayout(false);
            this.headerStrip3.PerformLayout();
            this.contextMenuStripQuestPart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private global::DOL.Tools.QuestDesigner.Controls.RichTextBoxEx questPartTextbox;
		private System.Windows.Forms.CheckedListBox triggerTypeList;
		private System.Windows.Forms.SplitContainer splitContainerMain;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.CheckedListBox actionTypeList;
		private System.Windows.Forms.CheckedListBox requirementTypeList;
		private DOL.Tools.QuestDesigner.Controls.HeaderStrip headerStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabelTrigger;
		private DOL.Tools.QuestDesigner.Controls.HeaderStrip headerStrip2;
		private System.Windows.Forms.ToolStripLabel toolStripLabelRequirement;
		private DOL.Tools.QuestDesigner.Controls.HeaderStrip headerStrip3;
		private System.Windows.Forms.ToolStripLabel toolStripLabelAction;
		private System.Windows.Forms.BindingNavigator bindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripQuestPart;
		private System.Windows.Forms.ToolStripMenuItem triggerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem interactToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem whisperToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem requirementToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem questGivableToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem questPendingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem queststepToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem giveItemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem increaseQueststepToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem defaultStepsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem offerAcceptQuestToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer tooltipTimer;
	}
}
