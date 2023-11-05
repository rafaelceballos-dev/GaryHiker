namespace GaryHikerConsoleApp
{
    internal class Hiker
    {
        private string _path;
        public bool IsValidPath { get; private set; } = false;
        public Hiker(string path, int steps = 0)
        {
            _path = Sanitize(path, steps);
        }
        private string Sanitize(string text, int steps = 0)
        {
            if(string.IsNullOrEmpty(text))
            {
                IsValidPath = false;
                return text;
            }
            
            steps = steps <= 0 ? text.Length : steps;

            var workingString = text.Trim().ToLower();

            var charlist = workingString.ToList();
            workingString = string.Empty;
            
            charlist.ForEach(x => { 
                if(x == 'u' || x == 'd')
                {
                    workingString += x;
                }
            });
            
            workingString = text.Substring(0, steps);

            IsValidPath = true;
            
            return workingString;
        }
        public int CountingValleys()
        {
            if(IsValidPath)
            {
                int level = 0; // 0 = sea level, positive = above the sea, negative = under the sea 
                int valleyCounter = 0;
                _path.ToList().ForEach(x =>
                {
                    if(x == 'u')
                    {
                        level++;
                        if(level == 0)
                        {
                            valleyCounter++;
                        }
                    }
                    else
                    {
                        level--;
                    }
                });
                return valleyCounter;
            }
            return 0;
        }
        public int CountingMountains()
        {

            if (IsValidPath)
            {
                int level = 0; // 0 = sea level, positive = above the sea, negative = under the sea 
                int mountainCounter = 0;
                _path.ToList().ForEach(x =>
                {
                    if (x == 'u')
                    {
                        level++;                        
                    }
                    else
                    {
                        level--;
                        if (level == 0)
                        {
                            mountainCounter++;
                        }
                    }
                });
                return mountainCounter;
            }
            return 0;
        }
    }
}
