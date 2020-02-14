namespace KryptonAutoHiddenGroupIssue
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.regularToggleButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.hiddenProxyToggleButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.hiddenToggleButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.forceEventCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonDockableWorkspace1);
            this.kryptonPanel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(513, 300);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // regularToggleButton
            // 
            this.regularToggleButton.Location = new System.Drawing.Point(80, 333);
            this.regularToggleButton.Name = "regularToggleButton";
            this.regularToggleButton.Size = new System.Drawing.Size(109, 25);
            this.regularToggleButton.TabIndex = 1;
            this.regularToggleButton.Values.Text = "Toggle Regular";
            this.regularToggleButton.Click += new System.EventHandler(this.RegularToggleButton_Click);
            // 
            // kryptonDockableWorkspace1
            // 
            this.kryptonDockableWorkspace1.AutoHiddenHost = false;
            this.kryptonDockableWorkspace1.CompactFlags = ((ComponentFactory.Krypton.Workspace.CompactFlags)(((ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptyCells | ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | ComponentFactory.Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.kryptonDockableWorkspace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableWorkspace1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDockableWorkspace1.Name = "kryptonDockableWorkspace1";
            // 
            // 
            // 
            this.kryptonDockableWorkspace1.Root.UniqueName = "30d48767a9504da68fdd863e62cc751f";
            this.kryptonDockableWorkspace1.Root.WorkspaceControl = this.kryptonDockableWorkspace1;
            this.kryptonDockableWorkspace1.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(513, 300);
            this.kryptonDockableWorkspace1.TabIndex = 0;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // hiddenProxyToggleButton
            // 
            this.hiddenProxyToggleButton.Location = new System.Drawing.Point(310, 333);
            this.hiddenProxyToggleButton.Name = "hiddenProxyToggleButton";
            this.hiddenProxyToggleButton.Size = new System.Drawing.Size(130, 25);
            this.hiddenProxyToggleButton.TabIndex = 3;
            this.hiddenProxyToggleButton.Values.Text = "Toggle Hidden Proxy";
            this.hiddenProxyToggleButton.Click += new System.EventHandler(this.HiddenProxyToggleButton_Click);
            // 
            // hiddenToggleButton
            // 
            this.hiddenToggleButton.Location = new System.Drawing.Point(195, 333);
            this.hiddenToggleButton.Name = "hiddenToggleButton";
            this.hiddenToggleButton.Size = new System.Drawing.Size(109, 25);
            this.hiddenToggleButton.TabIndex = 4;
            this.hiddenToggleButton.Values.Text = "Toggle Hidden";
            this.hiddenToggleButton.Click += new System.EventHandler(this.HiddenToggleButton_Click);
            // 
            // forceEventCheckBox
            // 
            this.forceEventCheckBox.Location = new System.Drawing.Point(139, 364);
            this.forceEventCheckBox.Name = "forceEventCheckBox";
            this.forceEventCheckBox.Size = new System.Drawing.Size(234, 20);
            this.forceEventCheckBox.TabIndex = 5;
            this.forceEventCheckBox.Values.Text = "Force OnAppearancePropertyChanged";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 390);
            this.Controls.Add(this.forceEventCheckBox);
            this.Controls.Add(this.hiddenToggleButton);
            this.Controls.Add(this.hiddenProxyToggleButton);
            this.Controls.Add(this.regularToggleButton);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton regularToggleButton;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton hiddenProxyToggleButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton hiddenToggleButton;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox forceEventCheckBox;
    }
}

