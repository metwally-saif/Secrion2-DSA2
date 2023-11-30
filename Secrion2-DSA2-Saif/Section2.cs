using Secrion2_DSA2_Saif.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secrion2_DSA2_Saif
{
    public partial class Section2 : Form
    {
        private List<Link> roads;
        private List<City> towns;
        private List<City> path;
        public Section2()
        {
            InitializeComponent();

            roads = new List<Link>();
            towns = new List<City>();
            path = new List<City>();
        }

        private void Section2_Load(object sender, EventArgs e)
        {
            string[] cityNames = { "Varna", "Dobrich", "Shumen", "Silistra", "Razgrad", "Burgas", "Yambol", "Veliko Tarnovo", "Stara Zagora", "Sliven", "Kazanlyk", "Targovishte" };

            foreach (string cityName in cityNames)
            {
                towns.Add(new City(cityName));
            }

            List<Link> list = new List<Link>
                {
                new Link(towns[0], towns[5], 150, 140), new Link(towns[0], towns[1], 52, 100), new Link(towns[0], towns[2], 89, 100),
                new Link(towns[0], towns[3], 141, 80), new Link(towns[0], towns[4], 128, 80), new Link(towns[0], towns[6], 208, 70),
                new Link(towns[0], towns[7], 222, 87), new Link(towns[0], towns[8], 288, 82), new Link(towns[0], towns[9], 211, 73),
                new Link(towns[0], towns[10], 291, 75), new Link(towns[0], towns[11], 122, 81), new Link(towns[1], towns[5], 164, 70),
                new Link(towns[1], towns[2], 125, 100), new Link(towns[1], towns[3], 90, 80), new Link(towns[1], towns[4], 164, 85),
                new Link(towns[1], towns[6], 243, 78), new Link(towns[1], towns[7], 258, 86), new Link(towns[1], towns[8], 323, 82),
                new Link(towns[1], towns[9], 247, 73), new Link(towns[1], towns[10], 328, 78), new Link(towns[1], towns[11], 157, 90),
                new Link(towns[2], towns[5], 127, 64), new Link(towns[2], towns[3], 112, 75), new Link(towns[2], towns[4], 48, 72),
                new Link(towns[2], towns[6], 129, 65), new Link(towns[2], towns[7], 142, 74), new Link(towns[2], towns[8], 210, 74),
                new Link(towns[2], towns[9], 136, 67), new Link(towns[2], towns[10], 217, 73), new Link(towns[2], towns[11], 41, 90),
                new Link(towns[3], towns[5], 226, 65), new Link(towns[3], towns[4], 115, 67), new Link(towns[3], towns[6], 243, 70),
                new Link(towns[3], towns[7], 230, 78), new Link(towns[3], towns[8], 324, 77), new Link(towns[3], towns[9], 250, 72),
                new Link(towns[3], towns[10], 329, 74), new Link(towns[3], towns[11], 140, 73),
                new Link(towns[3], towns[11], 140, 73), new Link(towns[4], towns[5], 176, 71), new Link(towns[4], towns[6], 160, 69),
                new Link(towns[4], towns[7], 114, 69), new Link(towns[4], towns[8], 240, 82), new Link(towns[4], towns[9], 148, 65),
                new Link(towns[4], towns[10], 212, 71), new Link(towns[4], towns[11], 37, 72), new Link(towns[5], towns[6], 92, 90),
                new Link(towns[5], towns[7], 216, 87), new Link(towns[5], towns[8], 172, 105), new Link(towns[5], towns[9], 114, 92),
                new Link(towns[5], towns[10], 190, 96), new Link(towns[5], towns[11], 149, 70), new Link(towns[6], towns[7], 131, 70),
                new Link(towns[6], towns[8], 87, 85), new Link(towns[6], towns[9], 29, 60), new Link(towns[6], towns[10], 105, 80),
                new Link(towns[6], towns[11], 124, 64), new Link(towns[7], towns[8], 109, 67), new Link(towns[7], towns[9], 112, 68),
                new Link(towns[7], towns[10], 102, 75), new Link(towns[7], towns[11], 100, 78), new Link(towns[8], towns[9], 70, 68),
                new Link(towns[8], towns[10], 36, 60), new Link(towns[8], towns[11], 205, 84), new Link(towns[9], towns[10], 86, 75),
                new Link(towns[9], towns[11], 112, 58), new Link(towns[10], towns[11], 197, 74)
               };

            roads.AddRange(list);
        }

        private void btnFindPath_Click_1(object sender, EventArgs e)
        {
            lstPath.Items.Clear();
            string startCity = StartCityBox.Text;
            City start = towns.FirstOrDefault(city => city.Name.Equals(startCity, StringComparison.OrdinalIgnoreCase));

            string endCity = EndCityBox.Text;
            City end = towns.FirstOrDefault(city => city.Name.Equals(endCity, StringComparison.OrdinalIgnoreCase));


            if (start == null || end == null)
            {
                lstPath.Items.Clear();
                //message
                return;
            }

            List<City> quickestPath = FindQuickestPath(start, end);

            lstPath.Items.Clear();
            foreach (var city in quickestPath)
            {
                lstPath.Items.Add(city.Name);
            }

            Link link = roads.FirstOrDefault(l => (l.City1 == start && l.City2 == end) || (l.City1 == end && l.City2 == start));

            if (link != null)
            {
                float distance = link.GetDistance();
                float timeAtMaxSpeed = link.CalculateTimeAtMaxSpeed();

                Time.Text = $"Distance between {start.Name} and {end.Name}: {distance} km";
                TimeSpan timeSpan = TimeSpan.FromHours(timeAtMaxSpeed);

                string formattedTime = $"{(int)timeSpan.TotalHours} hours {timeSpan.Minutes} minutes";

                Distance.Text = $"Time at maximum speed: {formattedTime}";
            }
        }

        private List<City> FindQuickestPath(City start, City finish)
        {
            foreach (var city in towns)
            {
                city.Expenses = float.MaxValue;
                city.Visited = false;
            }

            start.Expenses = 0;
            Queue<City> priorityQueue = new Queue<City>();
            priorityQueue.Enqueue(start);

            while (priorityQueue.Count > 0)
            {
                City current = priorityQueue.Dequeue();

                if (current.Name == finish.Name)
                {
                    return GetPath(current);
                }

                if (current.Visited)
                {
                    continue;
                }

                current.Visited = true;

                var neighbors = GetNeighbors(current.Name, roads);

                foreach (var neighbor in neighbors)
                {
                    float newExpense = current.Expenses + neighbor.Cost;
                    if (newExpense < neighbor.City2.Expenses)
                    {
                        neighbor.City2.Expenses = newExpense;
                        neighbor.City2.Previous = current;
                        priorityQueue.Enqueue(neighbor.City2);
                    }
                }
            }

            return new List<City>();
        }
        private List<Link> GetNeighbors(string cityName, List<Link> roads)
        {
            // Find and return the neighbors of a city by its name
            return roads.Where(link => link.City1.Name == cityName || link.City2.Name == cityName).ToList();
        }

        private List<City> GetPath(City end)
        {
            List<City> path = new List<City>();
            while (end != null)
            {
                path.Insert(0, end);
                end = end.Previous;
            }
            return path;
        }
    }
}

