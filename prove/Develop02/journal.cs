using System.IO;
public class Journal
    {
        public Entry JournalEntry = new Entry();
        public List<string> _entries = new List<string>();

        public Journal()
        {

        }

        public void addEntry(string newEntry)
        {
            _entries.Add(newEntry);
        }

        public void saveJournal()
        {
            Console.WriteLine("Please Enter the name for your journal file:");
            string fileName = Console.ReadLine();
            foreach (string saveEntry in _entries)
            {
                using (StreamWriter outputFile = new StreamWriter(saveEntry))
                {
                    outputFile.WriteLine(fileName);
                }
            }
            
        }

        public void loadJournal()
        {
            _entries.Clear();
            Console.WriteLine("The previous journal has been cleared. What is the filename of the new journal?");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                
                addEntry(line);
                
            }
        }

        public void displayEntry()
        {
            foreach (string disEntry in _entries)
            {
                Console.WriteLine(disEntry);
            }
        }
    }