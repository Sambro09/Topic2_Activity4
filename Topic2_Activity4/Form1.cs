namespace Topic2_Activity4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int seconds;

            if (int.TryParse(inputLabel.Text, out seconds))
            {
                if (seconds <= 0)
                {
                    MessageBox.Show("Must be a positive integer");
                }
                else if (seconds < 60)
                {
                    if (seconds == 1)
                        counterLabel.Text = seconds + " second";
                    else
                        counterLabel.Text = seconds + " seconds";
                }
                else if (seconds >= 60 && seconds < 3600)
                {
                    seconds = seconds / 60;

                    if (seconds == 1)
                        counterLabel.Text = seconds + " minute";
                    else
                        counterLabel.Text = seconds + " minutes";
                }
                else if (seconds >= 3600 && seconds < 86400)
                {
                    seconds = seconds / 3600;

                    if (seconds == 1)
                        counterLabel.Text = seconds + " hour";
                    else
                        counterLabel.Text = seconds + " hours";
                }
                else if (seconds >= 86400)
                {
                    seconds = seconds / 86400;

                    if (seconds == 1)
                        counterLabel.Text = seconds + " day";
                    else
                        counterLabel.Text = seconds + " days";
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}