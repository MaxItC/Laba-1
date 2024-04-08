using System;
using System.Text.Json.Nodes;
using Newtonsoft.Json;

class Project
{
    static void Main(string[] args)
    {
        var dict = new Dictionary<int, string>
        {                                                                 
            {1,"1" },
            {2,"1" },
            {3,"2" },
            {4,"4" },
            {5,"1" },
        };

        var dict2 = new Dictionary<int, string>();
        int count = 0;


        for (int i = 0; i < dict.Count; i++)
        {
            if (!dict2.ContainsValue(dict.ElementAt(i).Value))
            {
                count++; // key
                dict2.Add(count, dict.ElementAt(i).Value);
            }
        }

        dict.Clear();
        dict = dict2;

        dict2 = null;
        
        foreach (KeyValuePair<int,string> i in dict)
        {
            Console.WriteLine("Key:{0} , Value:{1}",i.Key,i.Value);
        }

        string ser = JsonConvert.SerializeObject(dict);
    }
}
