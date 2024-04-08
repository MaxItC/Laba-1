using System;

class Project
{
    static void Main(string[] args)
    {
        List<Obj> list = new List<Obj>
        {
            new Obj {Id = 135},
            new Obj {Id = 142},
            new Obj {Id = 354},
            new Obj {Id = 176},
            new Obj {Id = 999},
            new Obj {Id = 777},
        };

        // шукаемо за властивостью ( э цифра 7)
        var founded = list.Where(x => x.Id.ToString().Contains("7")); // LINQ

        
        foreach(var i in founded)
         Console.WriteLine(i.Id);
    }

    class Obj
    {
        public int Id;
    }
}
