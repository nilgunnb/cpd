class Student
{
    public string FirstName;
    public string LastName;
    public string Group;
    public double Points;
    public double StudyingYears;
    public bool isGraduated;

    public Student(string FirstName, string LastName, string Group, double Points, double StudyingYears)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Group = Group;
        this.Points = Points;
        this.StudyingYears = StudyingYears;

    }
    public void GetfullName()
    {
        Console.WriteLine($"{this.FirstName},{this.LastName}");
    }
    
    public void GetFullInfo()
    {
        Console.WriteLine($"{this.FirstName},{this.LastName},{this.Group},{this.Points},{this.StudyingYears}");
        
        if (StudyingYears > 0 && StudyingYears < 4)
        {
            isGraduated = false;
            Console.WriteLine("Mezun olmayib, hele oxuyur");
        }
        else if (StudyingYears == 4)
        {
            isGraduated = true;
            Console.WriteLine("Mezun olub");
        }
        else
        {
            Console.WriteLine("Bu hec univetsitetde deyil");
        }

        if (StudyingYears > 0 && StudyingYears < 4 && Points > 80 && Points < 100)
        {
            Console.WriteLine( "Ikinci imtahana gire belersen,malades");
        }
        else if (StudyingYears > 0 && StudyingYears < 4 && Points == 100)
        {
            Console.WriteLine("Ay deli, ikinci imtahan neyine lazim?! 100-nu almisan otur yerinde de");
        }
        else if (StudyingYears > 0 && StudyingYears < 4 && Points < 80)
        {
            Console.WriteLine("Ikinci imtahana gire bilmersen. Vaxtinda oxuyardin");
        }
        else if (StudyingYears > 0 && StudyingYears < 4 && Points < 0 || Points < 100)
        {
            Console.WriteLine("Bunun balini hansi agilli yazib?");
        }
        else if (StudyingYears == 4)
        {
            Console.WriteLine("Artiq mezun olub, imtahanlarin verib. El cekin usaqdan");
        }
    }



    }

