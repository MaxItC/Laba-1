using System;

class Project
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>
        {
            1,2,3,1,4,5,2,2,1
        };

        var filtred = list.Select((el, ind) => list.Take(ind).Contains(el) ? 0 : el); // ind с 0


          foreach (var i in filtred)
            Console.WriteLine(i);

      
    }
}