namespace TentamenWindowsapplikationerJesperEriksson
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unbookTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.headerMainMenu = new System.Windows.Forms.Label();
            this.infoText = new System.Windows.Forms.TextBox();
            this.screamfestIon = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screamfestIon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookTicketToolStripMenuItem,
            this.unbookTicketToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // bookTicketToolStripMenuItem
            // 
            this.bookTicketToolStripMenuItem.Name = "bookTicketToolStripMenuItem";
            this.bookTicketToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.bookTicketToolStripMenuItem.Text = "Book Ticket";
            this.bookTicketToolStripMenuItem.Click += new System.EventHandler(this.bookTicketToolStripMenuItem_Click);
            // 
            // unbookTicketToolStripMenuItem
            // 
            this.unbookTicketToolStripMenuItem.Name = "unbookTicketToolStripMenuItem";
            this.unbookTicketToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.unbookTicketToolStripMenuItem.Text = "Unbook Ticket";
            this.unbookTicketToolStripMenuItem.Click += new System.EventHandler(this.unbookTicketToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // headerMainMenu
            // 
            this.headerMainMenu.AutoSize = true;
            this.headerMainMenu.BackColor = System.Drawing.Color.DarkGray;
            this.headerMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerMainMenu.Location = new System.Drawing.Point(120, 39);
            this.headerMainMenu.Name = "headerMainMenu";
            this.headerMainMenu.Size = new System.Drawing.Size(601, 31);
            this.headerMainMenu.TabIndex = 3;
            this.headerMainMenu.Text = "SCREAMFEST HORROR FILM FESTIVAL 2020";
            // 
            // infoText
            // 
            this.infoText.BackColor = System.Drawing.Color.Gray;
            this.infoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.Location = new System.Drawing.Point(126, 91);
            this.infoText.Multiline = true;
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(605, 214);
            this.infoText.TabIndex = 4;
            this.infoText.Text = resources.GetString("infoText.Text");
            // 
            // screamfestIon
            // 
            this.screamfestIon.Image = global::TentamenWindowsapplikationerJesperEriksson.Properties.Resources.logo;
            this.screamfestIon.Location = new System.Drawing.Point(257, 311);
            this.screamfestIon.Name = "screamfestIon";
            this.screamfestIon.Size = new System.Drawing.Size(329, 266);
            this.screamfestIon.TabIndex = 6;
            this.screamfestIon.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 657);
            this.Controls.Add(this.screamfestIon);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.headerMainMenu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "SCREAMFEST FILMFESTIVAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screamfestIon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unbookTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Label headerMainMenu;
        private System.Windows.Forms.TextBox infoText;
        private System.Windows.Forms.PictureBox screamfestIon;
    }
}

