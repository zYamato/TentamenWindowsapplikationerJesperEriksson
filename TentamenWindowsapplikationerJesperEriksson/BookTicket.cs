using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;
using DatabaseContext;

namespace TentamenWindowsapplikationerJesperEriksson
{
    public partial class BookTicket : Form
    {
        public BookTicket()
        {
            InitializeComponent();

        }

        //Posters ClickEvent region
        #region
        private void alienBox_Click(object sender, EventArgs e)
        {
            SetToInvis();
            mainPoster.Image = this.mainPoster.Image = global::TentamenWindowsapplikationerJesperEriksson.Properties.Resources.Alien;
            DateTime StartTime = new DateTime(2020, 07, 11, 20, 00, 00);
            SetAllInfo("Alien", 3, txtMovieInfo);
            movieLable.Text = "Alien";
            movieLable.Visible = true;
            wheelChairBox.Visible = false;
            showStartTimes.SelectedIndex = 1;
            showStartTimes.SelectedIndex = 0;
            PictureBoxAllowDrop();
        }
        private void exorsistBox_Click(object sender, EventArgs e)
        {
            SetToInvis();
            mainPoster.Image = this.mainPoster.Image = global::TentamenWindowsapplikationerJesperEriksson.Properties.Resources.The_Exorsist;
            DateTime startTime = new DateTime(2020, 07, 11, 20, 00, 00);
            SetAllInfo("The Exorcist", 10, txtMovieInfo);
            movieLable.Text = "The Exorcist";
            movieLable.Visible = true;
            wheelChairBox.Visible = true;
            showStartTimes.SelectedIndex = 1;
            showStartTimes.SelectedIndex = 0;
            PictureBoxAllowDrop();
        }
        private void thingBox_Click(object sender, EventArgs e)
        {
            SetToInvis();
            mainPoster.Image = this.mainPoster.Image = global::TentamenWindowsapplikationerJesperEriksson.Properties.Resources.The_Thing;
            SetAllInfo("The Thing", 2, txtMovieInfo);
            movieLable.Text = "The Thing";
            movieLable.Visible = true;
            wheelChairBox.Visible = false;
            showStartTimes.SelectedIndex = 1;
            showStartTimes.SelectedIndex = 0;
            PictureBoxAllowDrop();
        }
        private void shiningBox_Click(object sender, EventArgs e)
        {
            SetToInvis();
            mainPoster.Image = this.mainPoster.Image = global::TentamenWindowsapplikationerJesperEriksson.Properties.Resources.The_Shining;
            SetAllInfo("The Shining", 1, txtMovieInfo);
            movieLable.Text = "The Shining";
            movieLable.Visible = true;
            wheelChairBox.Visible = false;
            showStartTimes.SelectedIndex = 1;
            showStartTimes.SelectedIndex = 0;
            PictureBoxAllowDrop();
        }
        private void itBox_Click(object sender, EventArgs e)
        {
            SetToInvis();
            mainPoster.Image = this.mainPoster.Image = global::TentamenWindowsapplikationerJesperEriksson.Properties.Resources.It;
            SetAllInfo("IT", 5, txtMovieInfo);
            movieLable.Text = "IT";
            wheelChairBox.Visible = false;
            movieLable.Visible = true;
            showStartTimes.SelectedIndex = 1;
            showStartTimes.SelectedIndex = 0;
            PictureBoxAllowDrop();
        }
        private void welnessBox_Click(object sender, EventArgs e)
        {
            SetToInvis();
            mainPoster.Image = this.mainPoster.Image = global::TentamenWindowsapplikationerJesperEriksson.Properties.Resources.A_Cure_for_Wellness;
            SetAllInfo("A Cure For Wellness", 7, txtMovieInfo);
            movieLable.Text = "A Cure For Wellness";
            movieLable.Visible = true;
            wheelChairBox.Visible = false;
            showStartTimes.SelectedIndex = 1;
            showStartTimes.SelectedIndex = 0;
            PictureBoxAllowDrop();
        }
        private void psychoBox_Click(object sender, EventArgs e)
        {
            SetToInvis();
            mainPoster.Image = this.mainPoster.Image = global::TentamenWindowsapplikationerJesperEriksson.Properties.Resources.Psycho;
            SetAllInfo("Psycho", 4, txtMovieInfo);
            movieLable.Text = "Psycho";
            movieLable.Visible = true;
            wheelChairBox.Visible = false;
            showStartTimes.SelectedIndex = 1;
            showStartTimes.SelectedIndex = 0;
            PictureBoxAllowDrop();
        }
        private void usBox_Click(object sender, EventArgs e)
        {
            SetToInvis();
            mainPoster.Image = this.mainPoster.Image = global::TentamenWindowsapplikationerJesperEriksson.Properties.Resources.Us;
            SetAllInfo("Us", 8, txtMovieInfo);
            movieLable.Text = "Us";
            movieLable.Visible = true;
            wheelChairBox.Visible = false;
            showStartTimes.SelectedIndex = 1;
            showStartTimes.SelectedIndex = 0;
            PictureBoxAllowDrop();
        }
        private void conjuringBox_Click(object sender, EventArgs e)
        {
            SetToInvis();
            mainPoster.Image = this.mainPoster.Image = global::TentamenWindowsapplikationerJesperEriksson.Properties.Resources.Conjuring;
            SetAllInfo("The Conjuring", 9, txtMovieInfo);
            movieLable.Text = "The Conjuring";
            movieLable.Visible = true;
            wheelChairBox.Visible = true;
            showStartTimes.SelectedIndex = 1;
            showStartTimes.SelectedIndex = 0;
            PictureBoxAllowDrop();

        }
        private void it2Box_Click(object sender, EventArgs e)
        {
            SetToInvis();
            mainPoster.Image = this.mainPoster.Image = global::TentamenWindowsapplikationerJesperEriksson.Properties.Resources.It2;
            SetAllInfo("IT Chapter 2", 6, txtMovieInfo);
            movieLable.Text = "IT Chapter 2";
            movieLable.Visible = true;
            wheelChairBox.Visible = false;
            showStartTimes.SelectedIndex = 1;
            showStartTimes.SelectedIndex = 0;
            PictureBoxAllowDrop();
        }
        #endregion

        private void SetToInvis()
        {
            alienBox.Visible = false;
            exorsistBox.Visible = false;
            itBox.Visible = false;
            it2Box.Visible = false;
            welnessBox.Visible = false;
            thingBox.Visible = false;
            usBox.Visible = false;
            psychoBox.Visible = false;
            conjuringBox.Visible = false;
            shiningBox.Visible = false;
            backBtn.Visible = true;
            personNummerLabel.Visible = true;
            numberLabel.Visible = true;
            fNameLabel.Visible = true;
            lNameLabel.Visible = true;
            textBoxSSN.Visible = true;
            textBoxEfternamn.Visible = true;
            textBoxFörstaNamn.Visible = true;
            textBoxNum.Visible = true;
            mainPoster.Visible = true;
            showStartTimes.Visible = true;
            wheelChairBox.Visible = true;
            movieLable.Visible = false;
            bookbtn.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
            pictureBox20.Visible = true;
            pictureBox21.Visible = true;
            pictureBox22.Visible = true;
            pictureBox23.Visible = true;
            pictureBox24.Visible = true;
            pictureBox25.Visible = true;
            pictureBox26.Visible = true;
            pictureBox27.Visible = true;
            pictureBox28.Visible = true;
            pictureBox29.Visible = true;
            pictureBox30.Visible = true;

        }
        private void SetToVis()
        {
            alienBox.Visible = true;
            exorsistBox.Visible = true;
            itBox.Visible = true;
            it2Box.Visible = true;
            welnessBox.Visible = true;
            thingBox.Visible = true;
            usBox.Visible = true;
            psychoBox.Visible = true;
            conjuringBox.Visible = true;
            shiningBox.Visible = true;
            backBtn.Visible = false;
            personNummerLabel.Visible = false;
            numberLabel.Visible = false;
            fNameLabel.Visible = false;
            lNameLabel.Visible = false;
            textBoxSSN.Visible = false;
            textBoxEfternamn.Visible = false;
            textBoxFörstaNamn.Visible = false;
            textBoxNum.Visible = false;
            mainPoster.Visible = false;
            txtMovieInfo.Visible = false;
            showStartTimes.Visible = false;
            wheelChairBox.Visible = false;
            movieLable.Visible = false;
            SalongLable.Visible = false;
            bookbtn.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            

        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            SetToVis();
            SetAllParametersToNothing();
        }

        //Picturebox ClickEvent region
        #region
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox1);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox2);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox3);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox4);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox5);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox6);
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox7);
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox8);
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox9);
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox10);
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox11);
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox12);
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox13);
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox14);
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox15);
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox16);
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox17);
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox18);
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox19);
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox20);
        }
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox21);
        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox22);
        }
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox23);
        }
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox24);
        }
        private void pictureBox25_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox25);
        }
        private void pictureBox26_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox26);
        }
        private void pictureBox27_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox27);
        }
        private void pictureBox28_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox28);
        }
        private void pictureBox29_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox29);
        }
        private void pictureBox30_Click(object sender, EventArgs e)
        {
            ChangeColorPicBox(pictureBox30);
        }
        #endregion

        /// <summary>
        /// Selects a box and changes the color
        /// </summary>
        /// <param name="picBox"></param>
        private void ChangeColorPicBox(PictureBox picBox)
        {
            if (picBox.BackColor == Color.LightGray)
            {
                picBox.BackColor = Color.LightSteelBlue;
            }
            else if (picBox.BackColor == Color.LightSteelBlue)
            {
                picBox.BackColor = Color.LightGray;
            }
            else if(picBox.BackColor == Color.LightYellow)
            {
                picBox.BackColor = Color.Yellow;
            }
            else if(picBox.BackColor == Color.Yellow)
            {
                picBox.BackColor = Color.LightYellow;
            }
        }
        /// <summary>
        /// Check what spaces are occupied in the specified show.
        /// </summary>
        /// <param name="showId"></param>
        private void CheckOccupiedSpots(int movieId)
        {
            using(var context = new FestivalContext())
            {
                // var tickets = context.Tickets.Where(n => n.Show.ShowId >= 40).ToList();

                var tickets = (from Tickets in context.Tickets
                               where Tickets.MovieId == movieId && Tickets.StartTime == (DateTime)showStartTimes.SelectedItem
                               select Tickets).ToList();

                foreach(Control ct in this.Controls)
                {
                    if(ct is PictureBox && ct.Name.Contains("pictureBox"))
                    {
                        ct.BackColor = Color.LightGray;
                    }
                }

                foreach(var ticket in tickets)
                {
                    var seat = ticket.SeatNum;

                    foreach(Control c in this.Controls)
                    {
                        if(c is PictureBox && c.Name == "pictureBox" + seat.ToString())
                        {
                            c.BackColor = Color.Red;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Finds the information about the specified movie
        /// </summary>
        /// <param name="filmname"></param>
        public static void FindInfo(string filmname, TextBox textBox)
        {
            textBox.Visible = true;
            using (var context = new FestivalContext())
            {
                var movie = context.Movies.Where(n => n.Name == filmname)
                                          .FirstOrDefault();
                textBox.Text = movie.Info;
            }
        }
        /// <summary>
        /// Finds the start time of the shows of a specified movie
        /// </summary>
        /// <param name="movieId"></param>
        /// <param name="StartTime"></param>
        /// <returns></returns>
        private List<DateTime> FindShowsStartTime(int movieId)
        {
            using(var context = new FestivalContext())
            {
                var show = (from Show in context.Shows
                            where Show.MovieId == movieId
                            select Show.StartTime).ToList();
                return show;
            }
        }
        /// <summary>
        /// Finds all the shows for a specefied movie
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        private List<Show> FindShows(int movieId)
        {
            using(var context = new FestivalContext())
            {
                var show = (from Show in context.Shows
                            where Show.MovieId == movieId
                            select Show).ToList();
                return show;
            }
        }
        /// <summary>
        /// Sets all the info for a movie
        /// </summary>
        /// <param name="movieName"></param>
        /// <param name="movieId"></param>
        private void SetAllInfo(string movieName, int movieId, TextBox textBox)
        {
            FindInfo(movieName, textBox);
            List<DateTime> showsStartTime = FindShowsStartTime(movieId);
            List<Show> shows = FindShows(movieId);
            showStartTimes.DataSource = showsStartTime;
            SalongLable.Visible = true;
            foreach(var show in shows)
            {
                SalongLable.Text = $"Salong {show.RoomNum.ToString()}";
            }
        }
        private void bookbtn_Click(object sender, EventArgs e)
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            List<int> seatNums = new List<int>();
            string personNum = textBoxSSN.Text;
            string firstName = textBoxFörstaNamn.Text;
            string lastName = textBoxEfternamn.Text;
            string phoneNumber = textBoxNum.Text;
            if(textBoxSSN.BackColor == Color.Red || textBoxFörstaNamn.BackColor == Color.Red || textBoxEfternamn.BackColor == Color.Red || textBoxNum.BackColor == Color.Red)
            {
                MessageBox.Show("Check the information again, something went wrong");
                return;
            }
            foreach (Control c in this.Controls)
            {
                if(c is PictureBox)
                {
                    try
                    {
                        pictureBoxes.Add((PictureBox)c);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something went wrong", ex.Message);
                    }
                }
            }
            foreach(var box in pictureBoxes)
            {
                if(box.BackColor == Color.LightSteelBlue)
                {
                    if(box.Name.Length > 11)
                    {
                        string num = box.Name.Substring(10, 2);
                        seatNums.Add(int.Parse(num));
                    }
                    else
                    {
                        string num = box.Name.Substring(10, 1);
                        seatNums.Add(int.Parse(num));
                    }
                }
            }

            var customer = new Customer
            {
                Ssn = personNum,
                FName = firstName,
                LName = lastName,
                PhoneNumber = phoneNumber,
            };

            using(var context = new FestivalContext())
            {
                try
                {
                    if (!context.Customers.Any(o => o.Ssn == personNum))
                    {
                        context.Customers.Add(customer);
                        context.SaveChanges();
                    }

                    int movieId = Methods.CheckWhatMovie(movieLable.Text.ToString());

                    //var showw = context.Shows.Where(n => n.StartTime == (DateTime)showStartTimes.SelectedItem && n.Movie.MovieId == movieId).FirstOrDefault();

                    var show = (from Show in context.Shows
                                where (Show.MovieId == movieId && Show.StartTime == (DateTime)showStartTimes.SelectedItem)
                                select Show).FirstOrDefault();

                    foreach (var num in seatNums)
                    {
                        var customerId = (from c in context.Customers
                                          where c.Ssn == personNum
                                          select c.CustomerId).FirstOrDefault();
                        if (wheelChairBox.Checked)
                        {
                            var ticket = new Ticket
                            {
                                CustomerId = customerId,
                                ShowId = show.ShowId,
                                SeatNum = num,
                                MovieId = show.MovieId,
                                WheelChair = true,
                                StartTime = (DateTime)showStartTimes.SelectedItem
                            };
                            context.Tickets.Add(ticket);
                            context.SaveChanges();
                        }
                        else
                        {
                            var ticket = new Ticket
                            {
                                CustomerId = customerId,
                                ShowId = show.ShowId,
                                SeatNum = num,
                                MovieId = show.MovieId,
                                WheelChair = false,
                                StartTime = (DateTime)showStartTimes.SelectedItem
                            };
                            context.Tickets.Add(ticket);
                            context.SaveChanges();
                        }


                    }
                    MessageBox.Show("Tickets has been booked");
                    this.Controls.Clear();
                    this.InitializeComponent();
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to add booking.");
                }
                
            }
        }
        private void textBoxSSN_Validating(object sender, CancelEventArgs e)
        {
            var incomingBox = sender as TextBox;
            bool isValid = Methods.validateSSN(incomingBox.Text);
            if(!isValid && incomingBox.Text.Length > 0)
            {
                textBoxSSN.BackColor = Color.Red;
            }
            else
            {
                textBoxSSN.BackColor = Color.White;
            }
        }
        private void textBoxFörstaNamn_Validating(object sender, CancelEventArgs e)
        {
            var incomingBox = sender as TextBox;
            bool isValid = Methods.ValidateName(incomingBox.Text);
            if(!isValid && incomingBox.Text.Length > 0)
            {
                textBoxFörstaNamn.BackColor = Color.Red;
            }
            else
            {
                textBoxFörstaNamn.BackColor = Color.White;
            }
        }
        private void textBoxEfternamn_Validating(object sender, CancelEventArgs e)
        {
            var incomingBox = sender as TextBox;
            bool isValid = Methods.ValidateLastName(incomingBox.Text);
            if(!isValid && incomingBox.Text.Length > 0)
            {
                textBoxEfternamn.BackColor = Color.Red;
            }
            else
            {
                textBoxEfternamn.BackColor = Color.White;
            }
        }
        private void textBoxNum_Validating(object sender, CancelEventArgs e)
        {
            var incomingBox = sender as TextBox;
            bool isValid = Methods.ValidatePhoneNumber(incomingBox.Text);
            if(!isValid && incomingBox.Text.Length > 0)
            {
                textBoxNum.BackColor = Color.Red;
            }
            else
            {
                textBoxNum.BackColor = Color.White;
            }
        }
        /// <summary>
        /// Resets all the parameter textboxes.
        /// </summary>
        private void SetAllParametersToNothing()
        {
            textBoxSSN.Text = "";
            textBoxFörstaNamn.Text = "";
            textBoxEfternamn.Text = "";
            textBoxNum.Text = "";
            textBoxSSN.BackColor = Color.White;
            textBoxFörstaNamn.BackColor = Color.White;
            textBoxEfternamn.BackColor = Color.White;
            textBoxNum.BackColor = Color.White;
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    c.BackColor = Color.LightGray;
                }
            }
        }
        private void showStartTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string movieName = movieLable.Text;

            using(var context = new FestivalContext())
            {
                var movieId = (from movie in context.Movies
                               where movie.Name == movieName
                               select movie.MovieId).FirstOrDefault();

                var show = (from Show in context.Shows
                            where Show.MovieId == movieId && Show.StartTime == (DateTime)showStartTimes.SelectedItem
                            select Show.MovieId).FirstOrDefault();

                CheckOccupiedSpots(show);
            }
            
        }

        private void pictureBox29_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox spot = sender as PictureBox;
            if(spot.BackColor == Color.LightGray)
            {
                int newSpot = 0;
                var incoming = int.Parse(e.Data.GetData(DataFormats.Text).ToString());

                if (spot.Name.Length > 11)
                {
                    string num = spot.Name.Substring(10, 2);
                    newSpot = int.Parse(num);
                }
                else
                {
                    string num = spot.Name.Substring(10, 1);
                    newSpot = int.Parse(num);
                }
                try
                {
                    using (var context = new FestivalContext())
                    {
                        Ticket ticket = context.Tickets.Where(n => n.TicketId == incoming).FirstOrDefault();
                        context.Tickets.Remove(ticket);
                        context.SaveChanges();
                        ticket.SeatNum = newSpot;
                        var newTicket = new Ticket
                        {
                            CustomerId = ticket.CustomerId,
                            ShowId = ticket.ShowId,
                            SeatNum = ticket.SeatNum,
                            MovieId = ticket.MovieId,
                            WheelChair = ticket.WheelChair,
                            StartTime = ticket.StartTime
                        };
                        context.Tickets.Add(newTicket);
                        context.SaveChanges();
                        MessageBox.Show("Ticket has been moved");
                    }
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException ex)
                {
                    ex.Entries.Single().Reload();
                }
                this.Controls.Clear();
                this.InitializeComponent();
            }
            
        }

        private void textBoxSSN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string personNum = textBoxSSN.Text;
                using (var context = new FestivalContext())
                {
                    var customer = (from Customer in context.Customers
                                    where Customer.Ssn == personNum
                                    select Customer).FirstOrDefault();


                    var movie = (from Movie in context.Movies
                                 where Movie.Name == movieLable.Text
                                 select Movie.MovieId).FirstOrDefault();

                    var show = (from Show in context.Shows
                                where Show.MovieId == movie && Show.StartTime == (DateTime)showStartTimes.SelectedItem
                                select Show.ShowId).FirstOrDefault();

                    var tickets = (from Tickets in context.Tickets
                                   where Tickets.CustomerId == customer.CustomerId && Tickets.ShowId == show
                                   select Tickets).ToList();

                    if (textBoxSSN.Text == customer.Ssn)
                    {
                        foreach (var ticket in tickets)
                        {
                            foreach (Control ct in this.Controls)
                            {
                                if (ct is PictureBox && ct.Name == ("pictureBox" + ticket.SeatNum))
                                {
                                    ct.BackColor = Color.LightYellow;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void pictureBox22_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox spot = sender as PictureBox;
            int spotNumber = 0;
            try
            {
                if (spot.BackColor == Color.Yellow)
                {
                    if (spot.Name.Length > 11)
                    {
                        string num = spot.Name.Substring(10, 2);
                        spotNumber = int.Parse(num);
                    }
                    else
                    {
                        string num = spot.Name.Substring(10, 1);
                        spotNumber = int.Parse(num);
                    }
                    using (var context = new FestivalContext())
                    {
                        var ticketPresent = (from ticket in context.Tickets
                                             where ticket.SeatNum == spotNumber
                                             select ticket).FirstOrDefault();

                        string toSend = ticketPresent.TicketId.ToString();
                        spot.DoDragDrop(toSend, DragDropEffects.Move);
                    }
                }
            }
            catch(NullReferenceException)
            {
                return;
            }

           

        }

        private void pictureBox22_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void BookTicket_Load(object sender, EventArgs e)
        {
            PictureBoxAllowDrop();
        }

        /// <summary>
        /// Allow all pictureboxes to Drag Drop
        /// </summary>
        public void PictureBoxAllowDrop()
        {
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;
            pictureBox9.AllowDrop = true;
            pictureBox10.AllowDrop = true;
            pictureBox11.AllowDrop = true;
            pictureBox12.AllowDrop = true;
            pictureBox13.AllowDrop = true;
            pictureBox14.AllowDrop = true;
            pictureBox15.AllowDrop = true;
            pictureBox16.AllowDrop = true;
            pictureBox17.AllowDrop = true;
            pictureBox18.AllowDrop = true;
            pictureBox19.AllowDrop = true;
            pictureBox20.AllowDrop = true;
            pictureBox21.AllowDrop = true;
            pictureBox22.AllowDrop = true;
            pictureBox23.AllowDrop = true;
            pictureBox24.AllowDrop = true;
            pictureBox25.AllowDrop = true;
            pictureBox26.AllowDrop = true;
            pictureBox27.AllowDrop = true;
            pictureBox28.AllowDrop = true;
            pictureBox29.AllowDrop = true;
            pictureBox30.AllowDrop = true;
        }
    }
}
