
public class Program
{
    private static readonly Dictionary<string, string[]> _graph = [];

    private static void Main(string[] args)
    {

        _graph.Add("voce", ["alice", "bob", "claire"]);
        _graph.Add("bob", ["anuj", "peggy"]);
        _graph.Add("alice", ["peggy"]);
        _graph.Add("claire", ["thon", "jonny"]);
        _graph.Add("anuj", []);
        _graph.Add("peggy", []);
        _graph.Add("thon", []);
        _graph.Add("jonny", ["douglas_m"]);
        _graph.Add("douglas_m", [""]);

        Search("voce");
    }

    private static bool Search(string name)
    {
        Queue<string> searchQueue = new(_graph[name]);
        HashSet<string> verified = [];

        while (searchQueue.Count != 0)
        {
            var person = searchQueue.Dequeue();
            if (!verified.Contains(person))
            {
                if (PersonIsSeller(person))
                {
                    Console.WriteLine($"{person} is a mango seller");
                    return true;
                }
                else
                {
                    //Console.WriteLine($"{person} has {_graph[person].Length} friends.");

                    foreach (var item in _graph[person])
                    {
                        searchQueue.Enqueue(item);
                    }

                    verified.Add(person);
                }
            }
        }


        return false;
    }

    private static bool PersonIsSeller(string person)
    {
        Console.WriteLine($"Is {person} a mango seller?");
        return person.EndsWith('m');
    }
}