using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseContext;
using BackEnd;
using System.Windows.Forms.VisualStyles;

namespace TentamenWindowsapplikationerJesperEriksson
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string personNum = textBoxSSN.Text;

                using (var context = new FestivalContext())
                {

                    var customer = (from Customer in context.Customers
                                    where Customer.Ssn == personNum
                                    select Customer).FirstOrDefault();

                    var tickets = (from Tickets in context.Tickets
                                   where Tickets.CustomerId == customer.CustomerId
                                   select Tickets).ToList();

                    var ticketNum = (from Ticket in context.Tickets
                                     where Ticket.CustomerId == customer.CustomerId
                                     select Ticket.SeatNum).ToList();

                    List<Show> shows = new List<Show>();

                    foreach (var ticket in tickets)
                    {
                        var show = (from Show in context.Shows
                                     where Show.MovieId == ticket.MovieId && Show.ShowId == ticket.ShowId
                                     select Show).FirstOrDefault();

                        shows.Add(show);
                    }

                    comboBox1.DataSource = shows;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("A person with that SSN does not exist", ex.Message);
                return;
            }
            
        }

        private void textBoxSSN_Validating(object sender, CancelEventArgs e)
        {
            var incomingBox = sender as TextBox;
            bool isValid = Methods.validateSSN(incomingBox.Text);
            if (!isValid && incomingBox.Text.Length > 0)
            {
                textBoxSSN.BackColor = Color.Red;
            }
            else
            {
                textBoxSSN.BackColor = Color.White;
            }
        }
    }
}
