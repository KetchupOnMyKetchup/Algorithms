using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.CSharp
{
    public enum ElevatorStatus
    {
        UP,
        STOPPED,
        DOWN
    }

    /// <summary>
    /// 1 Hotel elevator
    /// Lobby is most used and counts as floor 1
    /// Twist: 2 hotel elevators, no floor 13
    /// </summary>
    public class Elevator
    {
        // Current Floor
        public int CurrentFloor { get; set; }
        public List<int> DestinationFloors { get; set; }
        public ElevatorStatus ElevatorStatus { get; set; }
        public bool IsGoingUp { get; set; }

        // Call to current floor, add floor to Destination Floor queue
        public void CallElevator(int floor, bool goingUp)
        {
            while (CurrentFloor != floor)
            {
                MoveElevator();
            }

            Console.WriteLine($"Elevator has arrived at your floor: floor {CurrentFloor}.");
        }

        // Choose floor, add floor to Destination Floor queue at the beginng of list
        public void ChooseFloors(int floor)
        {
            // determine going up depending on current floor vs. destination floor
            
            // first button selects direction

            // sort all choices
        }

        private void MoveElevator()
        {
            Console.WriteLine($"Elevator is heading {(IsGoingUp ? "up" : "down")} and currently on floor: {CurrentFloor}.");

        }

        // If floor from queue is passed on the way to Destination, stop there
    }
}
