namespace AIR_HOCKEY_101
{
    public partial class AirHockey101 : Form
    {
        public AirHockey101()
        {
            InitializeComponent();
        }

        void DrawGame()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            g.DrawRectangle(Pens.Black, 50, 50, 400, 200);
            g.FillEllipse(Brushes.Red, 100, 100, 20, 20);
            g.FillEllipse(Brushes.Blue, 300, 100, 20, 20);
        }
    }
}
