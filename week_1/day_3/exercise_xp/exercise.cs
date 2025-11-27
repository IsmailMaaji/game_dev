    // Exercise 1: Convert Lists into Dictionaries
        Console.WriteLine("Exercise 1:");
        List<string> keys = new List<string> { "Ten", "Twenty", "Thirty" };
        List<int> values = new List<int> { 10, 20, 30 };
        Dictionary<string, int> myDict = new Dictionary<string, int>();
        for (int i = 0; i < keys.Count; i++)
        {
            myDict[keys[i]] = values[i];
        }
        Console.Write("{");
        int count = 0;
        foreach (var kvp in myDict)
        {
            Console.Write($"\"{kvp.Key}\": {kvp.Value}");
            count++;
            if (count < myDict.Count) Console.Write(", ");
        }
        Console.WriteLine("}\n");

    // Exercise 2: Cinemax 
        Console.WriteLine("Exercise 2:");
        Dictionary<string, int> family = new Dictionary<string, int>
        {
                {"rick", 43}, {"beth", 13}, {"morty", 5}, {"summer", 8}
            };
            int total = 0;
            foreach (var person in family)
            {
                int price = 0;
                if (person.Value < 3) price = 0;
                else if (person.Value <= 12) price = 10;
                else price = 15;
                Console.WriteLine($"{person.Key} pays: ${price}");
                total += price;
            }
         Console.WriteLine($"Total family cost: ${total}\n");

    // Exercise 3: Zara Brand Dictionary 
        Console.WriteLine("Exercise 3:");
        var brand = new Dictionary<string, object>
        {
            {"name", "Zara"},
            {"creation_date", 1975},
            {"creator_name", "Amancio Ortega Gaona"},
            {"type_of_clothes", new List<string>{"men", "women", "children", "home"}},
            {"international_competitors", new List<string>{"Gap", "H&M", "Benetton"}},
            {"number_stores", 7000},
            {"major_color", new Dictionary<string, List<string>>{
                {"France", new List<string>{"blue"}},
                {"Spain", new List<string>{"red"}},
                {"US", new List<string>{"pink", "green"}}
            }}
        };
        brand["number_stores"] = 2;
        var clothes = (List<string>)brand["type_of_clothes"];
        Console.WriteLine($"Zara clients: {string.Join(", ", clothes)}");
        brand["country_creation"] = "Spain";
        var competitors = (List<string>)brand["international_competitors"];
        competitors.Add("Desigual");
        brand.Remove("creation_date");
        Console.WriteLine($"Last competitor: {competitors[competitors.Count - 1]}");
        var majorColors = (Dictionary<string, List<string>>)brand["major_color"];
        Console.WriteLine($"US major colors: {string.Join(", ", majorColors["US"])}");

     //  Exercise 4: Some Geography 
        static void DescribeCity(string city, string country = "Iceland")
            {
                Console.WriteLine($"{city} is in {country}.");
            }

            static void Main(string[] args)
            {
                DescribeCity("Reykjavik");
                DescribeCity("Akureyri");
                DescribeCity("Edinburgh", "Scotland");
            }

     //  Exercise 5: Random Number Guess
            static void GenNumb(int x)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            if (x == randomNumber)
            {
                Console.WriteLine("You guessed the number!");

            }
            else
            {
                Console.WriteLine($"Sorry, the number was {randomNumber}.");
            }
        }
     //  Exercise 6: Personalized Shirts 
        void MakeShirt(string size = "Large", string text = "I love C#")
            {
                Console.WriteLine($"The size of the shirt is {size} and the text is '{text}'.");
            }
            const string defaultSize = "Large";
            const string defaultText = "Medium";
            MakeShirt(text: defaultText); 
            MakeShirt();

    // Exercise 7: Temperature Advice 
        void Main()
        {
            Console.WriteLine("Enter a season :");
            Console.ReadLine();
            GetRandomTemp(season);
            Console.WriteLine($"Season: {season}");
            if (rnd < 0) Console.WriteLine("Too cold!");
            else if (rnd <= 15) Console.WriteLine("Nice.");
            else if (rnd <= 25) Console.WriteLine("Nice weather!");
            else Console.WriteLine("To hot.");
            Console.WriteLine();

        }

    // Exercise 8: Star Wars Quiz 
        Console.WriteLine("Exercise 8:");
        var data = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string>{{"question","What is Baby Yoda's real name?"},{"answer","Grogu"}},
            new Dictionary<string, string>{{"question","Where did Obi-Wan take Luke after his birth?"},{"answer","Tatooine"}},
            new Dictionary<string, string>{{"question","What year did the first Star Wars movie come out?"},{"answer","1977"}},
            new Dictionary<string, string>{{"question","Who built C-3PO?"},{"answer","Anakin Skywalker"}},
            new Dictionary<string, string>{{"question","Anakin Skywalker grew up to be who?"},{"answer","Darth Vader"}},
            new Dictionary<string, string>{{"question","What species is Chewbacca?"},{"answer","Wookiee"}}
        };
        int correct = 0, wrong = 0;
        var wrongQuestions = new List<string>();
        foreach (var q in data)
        {
            string userAnswer = q["answer"]; 
            if (userAnswer == q["answer"]) correct++;
            else
            {
                wrong++;
                wrongQuestions.Add(q["question"]);
            }
        }
        Console.WriteLine($"Correct: {correct}, Wrong: {wrong}\n");

     // Exercise 9: Cats 
        public Cat(string name, string age)
        {
            catName = name;
            catAge = age;
            Cat cat1 = new Cat("Mimi", 3);
            Cat cat2 = new Cat("Tom", 5);
            Cat cat3 = new Cat("Garfield", 2);
            Cat oldest = GetOldestCat(new List<Cat> { cat1, cat2, cat3 });
            Console.WriteLine($"The oldest cat is {oldest.catName} aged {oldest.catAge} years.");
            return $"Cat Name: {catName}, Cat Age: {catAge}";
        }

    //Exercise 10: Dogs
            public class Dog
            {
                String name;
                int height;
                public Dog(string name , int height)
                {
                    name = name;    
                    height = height;
                }
                public void Bark()
                {
                    Console.WriteLine(" goes Woof!" + name);
                }
                public void jump()
                {
                    Console.WriteLine(name +"jumps."+ height*2+ "cm high!");
                }
                    Dog davidsDog = new Dog("Rex", 50);
                        davidsDog.Bark();
                        davidsDog.Jump();
                    Dog sarahsDog = new Dog("Teacup", 20);
                        sarahsDog.Bark();
                        sarahsDog.Jump();
            }

    // Exercise 11: Who’s the Song Producer? 
    class Song
    {
        private List<string> lyrics;
        public Song(List<string> lyrics)
        {
            this.lyrics = lyrics;
        }

        public void SingMeASong()
        {
            foreach (var line in lyrics)
            {
                Console.WriteLine(line);
            }
        SingMeASong();
        }
    }

        //  Exercise 12: Afternoon at the Zoo 
    
     class Zoo
        {
        public string Name;
            public List<string> Animals;

        public Zoo(string zooName)
            {
                Name = zooName;
                Animals = new List<string>();
            }
        public void AddAnimal(string newAnimal)
            {
                if (!Animals.Contains(newAnimal))
                    Animals.Add(newAnimal);
            }

        public void GetAnimals()
            {
                foreach (var animal in Animals)
                    Console.WriteLine(animal);
            }

        public void SellAnimal(string animalSold)
            {
                Animals.Remove(animalSold);
            }
        public void GetGroups()
            {
                var groups = SortAnimals();
                foreach (var group in groups)
                    Console.WriteLine($"{group.Key}: {string.Join(", ", group.Value)}");
            }
            static void Main()
                {
                    Zoo newYorkZoo = new Zoo("New York Zoo");

                    newYorkZoo.AddAnimal("Giraffe");
                    newYorkZoo.AddAnimal("Bear");
                    newYorkZoo.AddAnimal("Ape");
                    newYorkZoo.AddAnimal("Cougar");

                    Console.WriteLine("Animals:");
                    newYorkZoo.GetAnimals();

                    newYorkZoo.SellAnimal("Bear");

                    Console.WriteLine("\nGroups:");
                    newYorkZoo.GetGroups();
                }
        }