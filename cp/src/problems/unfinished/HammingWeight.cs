class HammingWeights
{
    // UNFINISHED
    /*
        Write a function that takes an unsigned 
        integer and returns the number of '1' bits 
        it has (also known as the Hamming weight).
    */
    public int HammingWeight(uint n)
    {
        Int32 weight = 0;
        string bin = n.ToString();
        foreach (char i in bin)
        {
            if (i == '1')
                weight++;
        }
        return weight;
    }
}