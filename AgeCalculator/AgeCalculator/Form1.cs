namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int current = Convert.ToInt32(box1.Text);
            int birthyear = Convert.ToInt32(box2.Text);
            int Year = current - birthyear;
            int Month = Year * 12;
            int Week = Month * 7;
            int Day = Week * 24;
            int Hour = Day * 60;
            int Minute = Hour * 60;

            year.Text = Year.ToString();
            month.Text = Month.ToString();
            week.Text = Week.ToString();
            day.Text = Day.ToString();
            hour.Text = Hour.ToString();
            minute.Text = Minute.ToString();

        }
    }
}
