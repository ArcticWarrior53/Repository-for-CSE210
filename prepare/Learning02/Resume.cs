public class Resume
    {
        // The C# convention is to start member variables with an underscore _
        public string _name = "";
        public List<Job> _jobs;
        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Resume()
        {
        }

        // A method that displays the company, job title, and start and end year 
        // countries or <family name, given name>.
        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs: ");
            foreach (Job previous in _jobs)
            {
                previous.Display();
            }
            
        }

        
    }