using System.IO;
public class Scripture
    {
        public Memorize memory = new Memorize();
        private string _reference = "Proverbs 3:5-6";
        public List<string> _scripture = new List<string>(){"Trust ", "in ", "the ", "Lord ", "with ", "all ", "thine ", "heart; ", "and ", "lean ", "not ", "unto ", "thine ", "own ", "understanding. ", "In ", "all ", "thy ", "ways ", "acknowledge ", "him, ", "and ", "he ", "shall ", "direct ", "thy ", "paths."};
        
        public Scripture()
        {

        }

        public void scriptureConstruct(List<String> scripture)
        {
            Console.Write(_reference + " ");
            foreach (string word in scripture)
            {
                
                Console.Write(word);
            }
            Console.WriteLine();
        }

        public List<string> passCopy()
        {
            memory._scriptureCopy = _scripture;
            return memory._scriptureCopy;
        }
    }