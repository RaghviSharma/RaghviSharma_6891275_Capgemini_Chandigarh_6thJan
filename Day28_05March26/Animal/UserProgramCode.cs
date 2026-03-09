using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Animal
{
    internal class UserProgramCode
    {
        public interface IAnimal
        {
			int ID { get; set; }
			string Species { get; set; }
			string Name { get; set; }
			int Age { get; set; }
		}
        public interface IZoo
        {
            void addAnimal(IAnimal animal);
            void removeAnimal(int id);
            int CountAnimals();
            List<IAnimal> getAnimalsBySpecies(String species);
            Dictionary<int, List<IAnimal>> getAnimalsByAge();




		}
        public class Animal:IAnimal
        {
            public int ID { get; set; }
            public string Species {  get; set; }
            public string Name { get; set; }
            public int Age {  get; set; }
           public Animal()
            { }
            public Animal(int id,string species,string name,int age)
            {
                ID = id;
                Species = species;
                Name = name;
                Age = age;
            }

        }
        public class Zoo:IZoo
        {
            private List<IAnimal> animals= new List<IAnimal>();
            public void addAnimal(IAnimal animal)
            {
                animals.Add(animal);
            }
            public void removeAnimal(int id)
            {
                animals.RemoveAll(i => i.ID == id);
            }
            public int CountAnimals()
            {
                return animals.Count;
            }
            public List<IAnimal> getAnimalsBySpecies(String species)
            {
                return animals.Where(s => s.Species == species).ToList();
            }
            public Dictionary<int,List<IAnimal>> getAnimalsByAge()
            {
                return animals.GroupBy(a => a.Age).ToDictionary(g => g.Key, g => g.ToList());

            }
        }
    }
}
