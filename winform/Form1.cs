using System;
using System.Windows.Forms;
using Dyball.ServiceLayer;


namespace winform
{
    public partial class Form1 : Form
    {
        private Timer _refreshTimer;
        private readonly IAnimalService _service;

        public Form1()
        {
            _service = new AnimalService();

            InitializeComponent();
            InitialiseForm();

        }
        private void InitialiseForm()
        {
            _refreshTimer = new Timer
            {
                Interval = 10000 //This can be changed to any time
            };

            _refreshTimer.Tick += RefreshTimerTick;
            _refreshTimer.Start();
        }

        private void RefreshTimerTick(object sender, EventArgs e)
        {
            _service.ReduceLife();
            RefreshGrid();
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            _service.Feed();
            RefreshGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgElephant.DataSource = _service.Elephants;
            dgGiraffe.DataSource = _service.Giraffes;
            dgMonkey.DataSource = _service.Monkeys;

            lblTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss");
        }

        private void RefreshGrid()
        {
            dgElephant.Refresh();
            dgGiraffe.Refresh();
            dgMonkey.Refresh();

            lblTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss");
        }
    }
}
