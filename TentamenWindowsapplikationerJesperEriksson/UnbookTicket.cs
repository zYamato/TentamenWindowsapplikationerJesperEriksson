using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BackEnd;
using DatabaseContext;

namespace TentamenWindowsapplikationerJesperEriksson
{
    public partial class UnbookTicket : Form
    {
        public UnbookTicket()
        {
            InitializeComponent();
        }

        private DateTime StartTime;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                btnUnbook.Visible = true;
                string personNum = txtPersonNum.Text;

                using (var context = new FestivalContext())
                {

                    var customer = (from Customer in context.Customers
                                    where Customer.Ssn == personNum
                                    select Customer).FirstOrDefault();

                    var tickets = (from Tickets in context.Tickets
                                   where Tickets.CustomerId == customer.CustomerId
                                   select Tickets).ToList();

                    List<string> Movies = new List<string>();
                    List<int> showIds = new List<int>();
                    List<Show> showss = new List<Show>();

                    foreach (var ticket in tickets)
                    {
                        var shows = (from Shows in context.Shows
                                     where ticket.ShowId == Shows.ShowId
                                     select Shows).ToList();

                        foreach (var show in shows)
                        {
                            var movies = from Movie in context.Movies
                                         where Movie.MovieId == show.MovieId
                                         select Movie.Name;

                            foreach (var movie in movies)
                            {
                                if (!Movies.Contains(movie))
                                {
                                    Movies.Add(movie);
                                }
                            }
                        }
                    }
                    comboBoxMovies.DataSource = Movies;

                    for (int i = 0; i < Movies.Count; i++)
                    {
                        foreach (Control c in this.Controls)
                        {
                            if (c is CheckBox && c.Name.Contains("checkBoxMovie" + i.ToString()))
                            {
                                c.Text = Movies[i];
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("You need to put in a social security number to unbook!");
                return;
            }

        }

        private void txtPersonNum_Validating(object sender, CancelEventArgs e)
        {
            var incomingBox = sender as TextBox;
            bool isValid = Methods.validateSSN(incomingBox.Text);
            if (!isValid && incomingBox.Text.Length > 0)
            {
                txtPersonNum.BackColor = Color.Red;
            }
            else
            {
                txtPersonNum.BackColor = Color.White;
            }
        }

        private void comboBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)comboBoxMovies.SelectedItem == "The Thing")
            {
                ShowMovieInfo("The Thing");
            }
            if ((string)comboBoxMovies.SelectedItem == "The Shining")
            {
                ShowMovieInfo("The Shining");
            }
            if ((string)comboBoxMovies.SelectedItem == "The Exorcist")
            {
                ShowMovieInfo("The Exorcist");
            }
            if ((string)comboBoxMovies.SelectedItem == "The Conjuring")
            {
                ShowMovieInfo("The Conjuring");
            }
            if ((string)comboBoxMovies.SelectedItem == "A Cure For Wellness")
            {
                ShowMovieInfo("A Cure For Wellness");
            }
            if ((string)comboBoxMovies.SelectedItem == "IT")
            {
                ShowMovieInfo("IT");
            }
            if ((string)comboBoxMovies.SelectedItem == "IT Chapter 2")
            {
                ShowMovieInfo("IT Chapter 2");
            }
            if ((string)comboBoxMovies.SelectedItem == "Psycho")
            {
                ShowMovieInfo("Psycho");
            }
            if ((string)comboBoxMovies.SelectedItem == "Us")
            {
                ShowMovieInfo("Us");
            }
            if ((string)comboBoxMovies.SelectedItem == "Alien")
            {
                ShowMovieInfo("Alien");
            }
        }
        private void ShowMovieInfo(string movie)
        {
            BookTicket.FindInfo(movie, infoBox);
            string personNum = txtPersonNum.Text;

            using (var context = new FestivalContext())
            {
                var customer = (from Customer in context.Customers
                                where Customer.Ssn == personNum
                                select Customer).FirstOrDefault();


                var ticket = (from Ticket in context.Tickets
                              where Ticket.CustomerId == customer.CustomerId
                              select Ticket).ToList();

                foreach (var Ticket in ticket)
                {
                    var show = (from Show in context.Shows
                                where Show.MovieId == 2 && Ticket.CustomerId == customer.CustomerId && Show.StartTime == Ticket.StartTime
                                select Show).FirstOrDefault();

                    StartTime = Ticket.StartTime;
                    if (!infoBox.Text.Contains(show.StartTime.ToString()))
                    {
                        infoBox.AppendText($"\r\n Show StartTime: {show.StartTime}");
                    }
                }
                for (int i = 0; i < ticket.Count; i++)
                {
                    foreach (Control c in this.Controls)
                    {
                        if (c is CheckBox && c.Name.Contains("checkBoxTicket" + ticket[i].SeatNum.ToString()))
                        {
                            c.Visible = true;
                        }
                    }
                }
            }
        }

        private void btnUnbook_Click(object sender, EventArgs e)
            {
            string movie = comboBoxMovies.SelectedItem.ToString();
            List<int> seats = new List<int>();
            List<Ticket> tickets = new List<Ticket>();

            for(int i = 0; i <= 30; i++)
            {
                foreach(Control c in this.Controls)
                {
                    if(c is CheckBox && c.Name.Contains("checkBoxTicket" + i.ToString()))
                    {
                        if (((CheckBox)c).Checked)
                        {
                            if(c.Name.Length > 15)
                            {
                                int seat = int.Parse(c.Name.Substring(14, 2));
                                seats.Add(seat);
                            }
                            else
                            {
                                int seat = int.Parse(c.Name.Substring(14, 1));
                                seats.Add(seat);
                            }
                            
                        }
                    }
                }
            }
            using(var context = new FestivalContext())
            {
                foreach (var seat in seats)
                {
                    var movis = (from Movie in context.Movies
                                 where Movie.Name == comboBoxMovies.SelectedItem.ToString()
                                 select Movie.MovieId).FirstOrDefault();

                    var show = (from Show in context.Shows
                                where Show.MovieId == movis && Show.StartTime == StartTime
                                select Show.ShowId).FirstOrDefault();

                    var ticketss = (from ticket in context.Tickets
                                        where ticket.SeatNum == seat
                                        select ticket).FirstOrDefault();
                        tickets.Add(ticketss);

                    foreach (var tick in tickets)
                    {
                        Ticket ticket = context.Tickets.Where(n => n.TicketId == tick.TicketId).FirstOrDefault();
                        context.Tickets.Remove(ticket);
                    }
                }
                context.SaveChanges();
            }
           
            using (var context = new FestivalContext())
            {
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Ticket has been unbooked!");
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException ex)
                {
                    ex.Entries.Single().Reload();
                }
            }
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
