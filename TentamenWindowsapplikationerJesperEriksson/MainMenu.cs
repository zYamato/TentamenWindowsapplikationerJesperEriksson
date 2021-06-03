using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TentamenWindowsapplikationerJesperEriksson
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void bookTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoText.Visible = false;
            screamfestIon.Visible = false;
            headerMainMenu.Visible = false;

            BookTicket bookTicketForm = new BookTicket();

            bookTicketForm.MdiParent = this;

            bookTicketForm.Show();
        }

        private void unbookTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoText.Visible = false;
            screamfestIon.Visible = false;
            headerMainMenu.Visible = false;

            UnbookTicket unbookTicketForm = new UnbookTicket();

            unbookTicketForm.MdiParent = this;

            unbookTicketForm.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoText.Visible = false;
            screamfestIon.Visible = false;
            headerMainMenu.Visible = false;

            Search searchForm = new Search();

            searchForm.MdiParent = this;

            searchForm.Show();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you want to book a ticket select Book Ticket and enter your SSN, Firstname, Lastname and phonenumber, and choose the seats then click Book Ticket \r\n " +
                "\r\nIf you want to change seat that is already booked, enter your SSN and select the seat you want to change and drag it to the seat you want instead. \r\n" +
                "\r\nYou can use the search feature to search for tickets you have bought. \r\n" +
                "\r\nYou can Unbook tickets if you select Unbook in the select menu. Enter your SSN and check the seats you want to unbook and click unbook.");
        }
    }
}
