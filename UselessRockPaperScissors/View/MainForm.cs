using System;
using System.Windows.Forms;
using UselessRockPaperScissors.Model;
using UselessRockPaperScissors.Presenter;

namespace UselessRockPaperScissors.View
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
            weaponCB.DataSource = Enum.GetValues(typeof(Weapon));
        }

        public Weapon Weapon
        {
            get => (Weapon) weaponCB.SelectedItem;
            set => weaponCB.SelectedItem = value;
        }

        public MainPresenter Presenter { private get; set; }

        private void playBtn_Click(object sender, EventArgs e)
        {
            Game.Start(Weapon);
        }
    }
}