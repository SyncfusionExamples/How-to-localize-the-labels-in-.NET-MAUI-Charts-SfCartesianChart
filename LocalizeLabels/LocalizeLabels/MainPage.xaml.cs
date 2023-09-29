namespace LocalizeLabels
{
    public partial class MainPage : ContentPage
    {
        public List<Person> Data { get; set; }

        public MainPage()
        {
            Data = new List<Person>()
        {
            new Person { Day = "Sunday", High = 20 , Low=12},
            new Person { Day = "Monday", High = 16, Low=10 },
            new Person { Day = "Tuesday", High = 17 , Low=11},
            new Person { Day = "Wednesday", High = 12 , Low=6},
            new Person { Day = "Thrusday", High = 21 , Low=14},
            new Person { Day = "Friday", High = 15 , Low=8},
            new Person { Day = "Saturday", High = 26, Low=18 }

        };
            InitializeComponent();
            BindingContext = this;
        }

        
    }


    public class Person
    {
        public string Day { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
    }
}