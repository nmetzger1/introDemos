// See https://aka.ms/new-console-template for more information


string[] OneSyllable = new string[] { "a", "and", "it", "is", "the", "tree", "sky", "leaf", "hill", 
                                    "lake", "moon", "bird", "dawn", "wind", "cloud", "snow", 
                                    "field", "rain", "road", "stream", "fire", "dusk", "ice", "mist", 
                                    "soil", "star", "sun", "dew", "rose", "spring", "night", "day", "peace", 
                                    "life", "love", "death", "grace", "smile", "bloom", "frost", "fall" };

string[] TwoSyllable = new string[] { "after", "beauty", "lego", "armor", "before", "lovely", "autumn", "bamboo", "harvest", "temple", "simple", "under", "river" };

BuidHaiku();

string WriteStanza(int syllables)
{
    Random random = new Random();    
    int currentSyllables = 0;
    string line = string.Empty;
    

    while(currentSyllables < syllables)
    {
        //If only one syllable is left in the stanza, force it to use one syllable world, then exit the loop
        if(currentSyllables == syllables - 1)
        {
            line += AddWord(OneSyllable);
            break;
        }
        

        //Use a random one or two syllable word then update the count.
        if(random.Next(2) == 0)
        {
            line += AddWord(OneSyllable);
            currentSyllables++;
        }
        else
        {
            line += AddWord(TwoSyllable);
            currentSyllables += 2;
        }
    }

    return line;
}

string AddWord(string[] array)
{
    Random random = new Random();
    string newWord = array[random.Next(0, array.Length - 1)] + " ";

    return newWord;
}

void BuidHaiku()
{
    Console.WriteLine(WriteStanza(5));
    Console.WriteLine(WriteStanza(7));
    Console.WriteLine(WriteStanza(5));
}
          