using GUI.frmAdminUserControls.DataUserControl;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI.frmAdminUserControls
{
    public partial class DataUC : UserControl
    {
        public DataUC()
        {
            InitializeComponent();
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(24, 161, 251);
            public static Color color6 = Color.Crimson;
        }
        private void btnScreenTypeUC_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnScreenTypeUC.Height;
            SidePanel.Top = btnScreenTypeUC.Top;
            SidePanel.BackColor = RGBColors.color6;
            pnData.Controls.Clear();
            ScreenTypeUC screenTypeUC = new ScreenTypeUC();
            screenTypeUC.Dock = DockStyle.Fill;
            pnData.Controls.Add(screenTypeUC);
        }

        private void btnCinemaUC_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCinemaUC.Height;
            SidePanel.Top = btnCinemaUC.Top;
            SidePanel.BackColor = RGBColors.color3;
            pnData.Controls.Clear();
            CinemaUC cinemaUc = new CinemaUC();
            cinemaUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(cinemaUc);
        }

        private void btnGenreUC_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnGenreUC.Height;
            SidePanel.Top = btnGenreUC.Top;
            SidePanel.BackColor = RGBColors.color1;
            pnData.Controls.Clear();
            GenreUC genreUc = new GenreUC();
            genreUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(genreUc);
        }

        private void btnMovieUC_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMovieUC.Height;
            SidePanel.Top = btnMovieUC.Top;
            SidePanel.BackColor = RGBColors.color2;
            pnData.Controls.Clear();
            MovieUC movieUc = new MovieUC();
            movieUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(movieUc);
        }

        private void btnFormatMovieUC_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnFormatMovieUC.Height;
            SidePanel.Top = btnFormatMovieUC.Top;
            SidePanel.BackColor = RGBColors.color3;
            pnData.Controls.Clear();
            FormatMovieUC formatMovieUc = new FormatMovieUC();
            formatMovieUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(formatMovieUc);
        }

        private void btnShowTimesUC_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnShowTimesUC.Height;
            SidePanel.Top = btnShowTimesUC.Top;
            SidePanel.BackColor = RGBColors.color4;
            pnData.Controls.Clear();
            ShowTimesUC showTimesUc = new ShowTimesUC();
            showTimesUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(showTimesUc);
        }

        private void btnTicketsUC_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTicketsUC.Height;
            SidePanel.Top = btnTicketsUC.Top;
            SidePanel.BackColor = RGBColors.color5;
            pnData.Controls.Clear();
            TicketsUC ticketsUc = new TicketsUC();
            ticketsUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(ticketsUc);
        }
    }
}
