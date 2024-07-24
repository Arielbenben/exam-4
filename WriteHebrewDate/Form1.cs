using WriteHebrewDate.Model;
using static WriteHebrewDate.Service.DateService;



namespace WriteHebrewDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            DateModel date = ChooseDate(
                DayInWeekComboBox.Text, DayInMonthComboBox.Text, MonthComboBox.Text, YearComboBox.Text);

           

            AddToDocument(date);
            MessageBox.Show(AddAllConvertTogether(date));
            

        }
    }
}
