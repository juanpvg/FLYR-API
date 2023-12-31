﻿using QuickGraph;
using TripsDb.Models;


namespace TripsRestAPI.Utilities
{
    public class FlightPathFinder
    {
        private readonly List<Flight> flights;
        private AdjacencyGraph<string, Edge<string>> graph;
        private string origin;

        public FlightPathFinder(List<Flight> flights)
        {
            this.flights = flights;
            InitializeGraph();
        }

        private void InitializeGraph()
        {
            graph = new AdjacencyGraph<string, Edge<string>>();

            foreach (var flight in flights)
            {
                graph.AddVertex(flight.Origin);
                graph.AddVertex(flight.Destination);
                graph.AddEdge(new Edge<string>(flight.Origin, flight.Destination));
            }
        }

        public List<Journey> FindAllPaths(string origin, string destination)
        {
            var allPaths = new List<Journey>();
            var visited = new HashSet<string>();
            var currentPath = new List<string>();
            this.origin = origin;

            FindPathsDFS(origin, destination, visited, currentPath, allPaths);

            return allPaths;
        }

        private void FindPathsDFS(
            string currentCity,
            string destination,
            HashSet<string> visited,
            List<string> currentPath,
            List<Journey> allPaths)
        {
            visited.Add(currentCity);
            currentPath.Add(currentCity);

            if (currentCity == destination)
            {
                var journey = new Journey();
                journey.Origin = this.origin;
                journey.Destination = destination;
                for (int i = 0; i < currentPath.Count - 1; i++)
                {
                    var flight = flights.FirstOrDefault(f =>
                        f.Origin == currentPath[i] && f.Destination == currentPath[i + 1]
                    );

                    if (flight != null){
                        journey.addFlight(flight);
                    }
                }
                allPaths.Add(journey);
            }
            else
            {
                foreach (var neighbor in graph.OutEdges(currentCity))
                {
                    if (!visited.Contains(neighbor.Target))
                    {
                        FindPathsDFS(neighbor.Target, destination, visited, currentPath, allPaths);
                    }
                }
            }

            visited.Remove(currentCity);
            currentPath.RemoveAt(currentPath.Count - 1);
        }
    }
}
