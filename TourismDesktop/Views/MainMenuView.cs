using TourismDesktop.Views;

namespace TourismDesktop
{
    public partial class MainMenuView : Form
    {
        public MainMenuView()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            HomeView homeView = new HomeView();
            homeView.Show();
        }
    }
}
