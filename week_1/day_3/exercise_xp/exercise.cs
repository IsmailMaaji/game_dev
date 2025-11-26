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
        Console.WriteLine("Exercise 4:");
        DescribeCity("Reykjavik");
        DescribeCity("Paris", "France");
        Console.WriteLine();

        //  Exercise 5: Random Number Guess
        Console.WriteLine("Exercise 5:");
        Random rnd = new Random();
        int userNumber = 42; // For example, you can use Console.ReadLine() to get input
        int randomNumber = rnd.Next(1, 101);
        if (userNumber == randomNumber)
            Console.WriteLine($"Success! Both numbers are {randomNumber}");
        else
            Console.WriteLine($"Fail! Your number: {userNumber}, Random: {randomNumber}\n");

        //  Exercise 6: Personalized Shirts 
        Console.WriteLine("Exercise 6:");
        MakeShirt();
        MakeShirt("Medium");
        MakeShirt("Small", "Custom Text");
        MakeShirt(size: "XL", text: "C# Rocks");
        Console.WriteLine();

        // Exercise 7: Temperature Advice 
        Console.WriteLine("Exercise 7:");
        string season = "summer"; // Example, replace with user input
        int temp = GetRandomTemp(season);
        Console.WriteLine($"Season: {season}, Temperature: {temp}°C");
        if (temp < 0) Console.WriteLine("Brrr, stay warm!");
        else if (temp <= 15) Console.WriteLine("Cool weather, wear a jacket.");
        else if (temp <= 25) Console.WriteLine("Nice weather!");
        else Console.WriteLine("It's hot, stay hydrated.");
        Console.WriteLine();

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
        Cat cat1 = new Cat("Whiskers", 3);
        Cat cat2 = new Cat("Tom", 5);
        Cat cat3 = new Cat("Garfield", 2);

        Cat oldest = GetOldestCat(new List<Cat>{cat1, cat2, cat3});
        Console.WriteLine($"The oldest cat is {oldest.Name}, and is {oldest.Age} years old.\n");

        //Exercise 10: Dogs
        Console.WriteLine("Exercise 10:");
        Dog davidsDog = new Dog("Rex", 50);
        davidsDog.Bark();
        davidsDog.Jump();

        Dog sarahsDog = new Dog("Teacup", 20);
        sarahsDog.Bark();
        sarahsDog.Jump();

        if (davidsDog.Height > sarahsDog.Height) Console.WriteLine($"{davidsDog.Name} is taller.\n");
        else Console.WriteLine($"{sarahsDog.Name} is taller.\n");

        // Exercise 11: Who's the Song Producer 
        Console.WriteLine("Exercise 11:");
        var stairway = new Song(new List<string>{
            "There’s a lady who's sure",
            "all that glitters is gold",
            "and she’s buying a stairway to heaven"
        });
        stairway.SingMeASong();
        Console.WriteLine();

        //  Exercise 12: Afternoon at the Zoo 
        Console.WriteLine("Exercise 12:");
        Zoo newYorkZoo = new Zoo("NY Zoo");
        newYorkZoo.AddAnimal("Lion");
        newYorkZoo.AddAnimal("Tiger");
        newYorkZoo.AddAnimal("Lion"); 
        newYorkZoo.GetAnimals();
        newYorkZoo.SellAnimal("Tiger");
        newYorkZoo.GetAnimals();
        newYorkZoo.AddAnimal("Giraffe");
        newYorkZoo.SortAnimals();
        newYorkZoo.GetGroups();
    }

    //  Exercise 9 Classes 
    class Cat
    {
        public string Name;
        public int Age;
        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    static Cat GetOldestCat(List<Cat> cats)
    {
        Cat oldest = cats[0];
        foreach (var cat in cats)
        {
            if (cat.Age > oldest.Age) oldest = cat;
        }
        return oldest;
    }

    //Exercise 10 Classes 
    class Dog
    {
        public string Name;
        public int Height;
        public Dog(string name, int height)
        {
            this.Name = name;
            this.Height = height;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} goes woof!");
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} jumps {Height * 2} cm high!");
        }
    }

    // Exercise 11 Classes 
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
        }
    }

    // Exercise 12 Classes
    class Zoo
    {
        private List<string> animals;
        public string Name;

        public Zoo(string zooName)
        {
            this.Name = zooName;
            animals = new List<string>();
        }

        public void AddAnimal(string newAnimal)
        {
            if (!animals.Contains(newAnimal))
            {
                animals.Add(newAnimal);
            }
        }

        public void GetAnimals()
        {
            Console.WriteLine($"Animals in {Name}: {string.Join(", ", animals)}");
        }

        public void SellAnimal(string animalSold)
        {
            if (animals.Contains(animalSold))
            {
                animals.Remove(animalSold);
            }
        }

        public void SortAnimals()
        {
            animals.Sort();
        }

        public void GetGroups()
        {
            var groups = new Dictionary<char, List<string>>();
            foreach (var animal in animals)
            {
                char firstLetter = animal[0];
                if (!groups.ContainsKey(firstLetter))
                {
                    groups[firstLetter] = new List<string>();
                }
                groups[firstLetter].Add(animal);
            }

            foreach (var kvp in groups)
            {
                Console.WriteLine($"{kvp.Key}: [{string.Join(", ", kvp.Value)}]");
            }
        }
    }
