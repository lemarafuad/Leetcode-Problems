public class RandomizedSet
{
    private List<int> myList;
    private Dictionary<int, int> myDictionary;
    Random randomNumber;

    public RandomizedSet()
    {
        myList = new List<int>();
        myDictionary = new Dictionary<int, int>();
        randomNumber = new Random();
    }
    public bool Insert(int val)
    {
        if (myDictionary.ContainsKey(val)) return false;

        myList.Add(val);
        myDictionary.Add(val, myList.Count - 1);

        return true;
    }

    public bool Remove(int val)
    {
        if (!myDictionary.ContainsKey(val)) return false;

        myList[myDictionary[val]] = myList[myList.Count - 1];
        myDictionary[myList[myList.Count - 1]] = myDictionary[val];

        myList.RemoveAt(myList.Count - 1);
        myDictionary.Remove(val);

        return true;
    }

    public int GetRandom()
    {
        int randomIndex = randomNumber.Next(0, myList.Count);
        return myList[randomIndex];
    }
}