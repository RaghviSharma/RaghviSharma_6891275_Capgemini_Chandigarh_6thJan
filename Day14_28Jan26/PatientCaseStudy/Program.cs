namespace PatientCaseStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
			List<Patient> patientList = new List<Patient>();
            int noOfPatients;
            int n = 1;
            string name, city,illness;
            int age;
            Console.WriteLine("Enter the number of Patients");
            noOfPatients = Convert.ToInt32(Console.ReadLine());
            Patient patient = new Patient();
            for (int i = 0; i < noOfPatients; i++)
            {
                Console.WriteLine("Enter patient " + (n++) + " details:");
                Console.WriteLine("Enter patient name ");
                name = Console.ReadLine();
                Console.WriteLine("Enter the age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the illness");
                illness = Console.ReadLine();
                Console.WriteLine("Enter the city");
                city = Console.ReadLine();
                patient =new Patient(name, age, illness,city);
                patientList.Add(patient);
            }
            int choice;
            string ans;
            PatientBO patientBO = new PatientBO();
            do
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1)Display Patient Details");
                Console.WriteLine("2)Display Youngest Patient Details");
                Console.WriteLine("3)Display Patients from City");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter patient name");
                        string p_name= Console.ReadLine();
                        patientBO.DisplayPatientDetails(patientList, p_name);
                        break;
                    case 2:
                        Console.WriteLine("The youngest patient detail ");
                        patientBO.DisplayYoungestPatientDetails(patientList);
                        break;
                    case 3:
                        Console.WriteLine("Enter city");
                        string city_n= Console.ReadLine();
                        patientBO.displayPatientsFromCity(patientList, city_n);
                        break;
                }
                Console.WriteLine("Do u want to continue yes or no");
                ans= Console.ReadLine();
            }
            while (ans.Equals("yes"));

		}
    }
}
