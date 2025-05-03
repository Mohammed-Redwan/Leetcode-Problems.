public class RandomizedSet {

    Dictionary<int, int> d;
    List<int> l;
    Random rand; 
    
    public RandomizedSet() {
        d = new Dictionary<int,int>();
        l = new List<int>();
        rand = new Random();
    }
    
    public bool Insert(int val) {

        if (d.ContainsKey(val))
            return false;

        l.Add(val);
        d.Add(val,l.Count - 1);
        return true;
        
    }
    
    public bool Remove(int val) {
        if (!d.ContainsKey(val))
            return false;
        
        int currentIndex = d[val];                  // get to deleted index
        int listLastValue = l[l.Count - 1];        // get the last value in list to replace white deleted value
        l[l.Count - 1] = l[currentIndex];         // replace the deleted value with last value to avoid incorrect indexing
        l[currentIndex] = listLastValue;           // to save last value from lost;

        l.RemoveAt(l.Count - 1);                       // Deleting val from the list 
        d[listLastValue] = currentIndex;
        d.Remove(val);                               // deleted val from the dictionary

        return true;
    }

    public int GetRandom() {
        int randomIndex = rand.Next(0, l.Count);     // ✅ استخدام rand من الكلاس نفسه
        return l[randomIndex];  
    }   


}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */