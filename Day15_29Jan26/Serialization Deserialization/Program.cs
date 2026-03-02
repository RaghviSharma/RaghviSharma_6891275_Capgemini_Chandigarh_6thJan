using System.Xml.Serialization;
namespace Serialization_Deserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student { id = 17255, name = "Raghvi" };
            FileStream fs = new FileStream("student.xml",FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Student));
            serializer.Serialize(fs, s);
            fs.Close();

        }
    }
}
