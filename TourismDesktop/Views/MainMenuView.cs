namespace TourismDesktop
{
    public partial class MainMenuView : Form
    {
        bool sidebarExpand;

        public MainMenuView()
        {
            InitializeComponent();
        }





        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            // 

            if (sidebarExpand)
            {
                //if sidebar is expand, minimize
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menubutton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Navigate to TabpageHome
            tabControl1.SelectTab(TabPageHome);
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageDestination);
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageActivity);
        }

        private void btnItinerary_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageItinerary);
        }

        private void btnPaymentMethod_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPagePaymentMethod);
        }

        private void btnHotels_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(TabPageHotels);
        }
    }
}
