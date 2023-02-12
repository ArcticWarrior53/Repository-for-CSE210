using System.IO;
public class Memorize
    {
        //public Scripture proverbs = new Scripture();
        public List<string> _scriptureCopy = new List<string>(){"Trust ", "in ", "the ", "Lord ", "with ", "all ", "thine ", "heart; ", "and ", "lean ", "not ", "unto ", "thine ", "own ", "understanding. ", "In ", "all ", "thy ", "ways ", "acknowledge ", "him, ", "and ", "he ", "shall ", "direct ", "thy ", "paths."};
        public List<string> _scripture = new List<string>(){"Trust ", "in ", "the ", "Lord ", "with ", "all ", "thine ", "heart; ", "and ", "lean ", "not ", "unto ", "thine ", "own ", "understanding. ", "In ", "all ", "thy ", "ways ", "acknowledge ", "him, ", "and ", "he ", "shall ", "direct ", "thy ", "paths."};


        public Memorize()
        {

        }
        
        //public List<string> scripturePower()
        //{
        //    _scriptureCopy = proverbs.passCopy();
        //    return _scriptureCopy;
        //}

        public List<string> removeWords()
        {
            int toRemove;
            string oLetter;
            string blank = "____ ";
            do 
            {
                toRemove = randomSelector();
                oLetter = _scriptureCopy[toRemove];
                
            } while (oLetter == blank);
            //foreach (char letter in _scriptureCopy[toRemove])
            //{
            //    _blank = _blank + "_";
            //}
            _scriptureCopy.Insert(toRemove, blank);
            _scriptureCopy.RemoveAt(toRemove + 1);
            return _scriptureCopy;
        }

        public int randomSelector()
        {
            Random randomGen = new Random();
            int promptIndex = randomGen.Next(0, _scriptureCopy.Count());
            return promptIndex;
        }

        public List<string> addWords()
        {
            int toAdd;
            char oLetter;
            //char blank = '_';
            //do
            //{
                toAdd = randomSelector();
                oLetter = _scriptureCopy[toAdd][0];
            //} while (oLetter != blank);
            _scriptureCopy[toAdd] = _scripture[toAdd];
            return _scriptureCopy;
        }

    }