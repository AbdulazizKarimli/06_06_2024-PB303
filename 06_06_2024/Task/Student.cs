namespace Task
{
    public class Student
    {
        private string name;
        private string surname;
        private int avgPoint;

        public string Name 
        {
            get => name;
            set
            {
                if (char.IsUpper(value[0]))
                    name = value;
            } 
        }
        public string Surname 
        {
            get => surname;
            set
            {
                if (char.IsUpper(value[0]))
                    surname = value;
            }
        }
        public int  AvgPoint 
        {
            get => avgPoint;
            set
            {
                if (value >= 0 && value <= 100)
                    avgPoint = value;
            } 
        }

        public string GetInfo()
        {
            return $"Name: {Name} - Surname: {Surname} - AvgPoint: {AvgPoint}";
        }
    }
}
