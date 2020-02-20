using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _841KeysAndRooms
    {
        //public static void Main()
        //{
        //    List<IList<int>> rooms = new List<IList<int>>();
        //    rooms.Add(new List<int>() { 1 });
        //    rooms.Add(new List<int>() { 2 });
        //    rooms.Add(new List<int>() { 3 });
        //    rooms.Add(new List<int>());

        //    var result = CanVisitAllRooms(rooms);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        // Room = entities = Vertices
        // Keys = relationships = Edges
        // Need "seen" Hashset so we don't process room twice
        // If room.size = hashset.length then we're done
        public static bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            Queue<int> queue = new Queue<int>();
            HashSet<int> seen = new HashSet<int>();

            queue.Enqueue(0);
            seen.Add(0);

            while (queue.Count != 0)
            {
                int currentRoom = queue.Dequeue();
                IList<int> keys = rooms[currentRoom];

                foreach (var key in keys)
                {
                    if (!seen.Contains(key))
                    {
                        seen.Add(key);
                        queue.Enqueue(key);
                    }
                }

                if (rooms.Count == seen.Count) return true;
            }

            return seen.Count == rooms.Count;
        }
    }
}
