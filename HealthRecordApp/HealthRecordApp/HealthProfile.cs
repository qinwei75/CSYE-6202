using System;

namespace HealthRecordApp
{
	public enum Gender
	{
		Unspecified,
		Male,
		Female
	}

	public class HealthProfile
	{
		private const int UnknownValue = -1;
        private string firstname;
        private string lastname;
        private Gender gender;
        private DateTime dob;
        private int weight;
        private int height;

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public int WeightInPounds
        {
            get { return weight; }
            set { weight = value; }
        }

        public int HeightInInches
        {
            get { return height; }
            set { height = value; }
        }
        #region Methods

        public int CalculateAge()
		{
            int age = DateTime.Today.Year - dob.Year;
            if (DateTime.Today.Month < dob.Month ||
                (DateTime.Today.Month == dob.Month && DateTime.Today.Day < dob.Day))
            {
                age--;
            }
            return age;
        }

		public int CalculateMaxHeartRate()
		{
            int heartRate = 220 - CalculateAge();
            if (heartRate > 0) {
                return heartRate;
            }
            else { return UnknownValue; }
			
		}

		public decimal CalculateBMI()
		{
            try {
                decimal.Round((weight * 703) / (height ^ 2), 2);
                }
            catch (Exception)
            {
                return UnknownValue;
            }
            decimal bmi = decimal.Round(((decimal)weight *703)/((decimal)height * height), 2);
            if (bmi > 0)
            {
                return bmi;
            }
            else
            {
                return UnknownValue;
            }
                
            
		}

		public void DisplayPatientProfile()
        {
            Console.WriteLine("DisPlaying Patient Profile:");
            Console.WriteLine("===========================");
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Gender: " + Gender.ToString());
            Console.WriteLine("Date of Birth: " + DOB.ToString("M/d/yyyy"));//.ToString("d/m/yyyy")
            Console.WriteLine("Height: " + height.ToString() + " inches");
            Console.WriteLine("Weight: " + weight.ToString() + " pounds");
            Console.WriteLine("Age: " + CalculateAge());
            Console.WriteLine("Max Heart Rate: " + CalculateMaxHeartRate());
            Console.WriteLine("BMI: " + CalculateBMI());
        }

		#endregion
	}
}
