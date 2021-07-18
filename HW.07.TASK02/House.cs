using System;

namespace HW._07.TASK02
{
    public class House
    {
        protected double area;
        public Door door;

        public double Area
        {
            get { return area; }
            set { area = value; }
        }


        public House(double area)
        {
            this.area = area;
        }

        public virtual void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {area} m2");
        }
        
        public Door GetDoor()
        {
            return door;
        }
    }

    public class Door
        {
            protected string color;
            public string Color
            {
                get { return color; }
                set { color = value; }
            }

            public Door(string color)
            {
                this.color = color;
            }

            public void ShowData()
            {
                Console.WriteLine($"I am a door, my color is {color}");
            }
        }
    }

