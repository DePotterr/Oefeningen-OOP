using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SoftwareSysteem_robots
{
    abstract class Robot : ICloneable, IComparable
    {

        private const int MAXBATTERIJ = 100;
        private const int MINBATTERIJ = 0;
        private static int opvolgnummer = 0;
        private double batterijverbruik;
        public int Id { get; set; }
        public string Naam { get; set; }
        public bool KanOpstarten { get; set; }
        public Timer Timer { get; set; }
        public double Batterijverbuik
        {
            get { return batterijverbruik; }
            set
            {
                if(value > MAXBATTERIJ ||value < MINBATTERIJ)
                {
                    batterijverbruik = MAXBATTERIJ;
                }
                else
                {
                    batterijverbruik = value;
                }
            }
        }

        public bool PowerOn { get; set; }

        protected Robot(string naam)
        {
            Id = ++opvolgnummer;
            Naam = naam;
            PowerOn = false;
            Opladen();
            Timer = new Timer();
            Timer.Interval = 1000;
            Timer.Elapsed += Event_Tick;
        }
        protected void Event_Tick(Object source, ElapsedEventArgs e)
        {
            Batterijverbuik--;
            if(Batterijverbuik <= MINBATTERIJ)
            {
                Timer.Stop();
                Uitschakelen();
            }
        }
        public void Opstarten()
        {
            if (CheckKanOpstarten() && Batterijverbuik > 0)
            {
                PowerOn = true;
                Timer.Start();
            }
            else
            {
                if(Batterijverbuik <= 0)
                {
                    throw new CustumRobotException("Batterij is leeg.");
                }
            }
        }
        public void Uitschakelen()
        {
            PowerOn = false;
            Timer.Stop();
        }
        public abstract bool CheckKanOpstarten();
        public void Opladen()
        {
            Batterijverbuik = 100;
        }
        public override string ToString()
        {
            return Naam;
        }

        public object Clone()
        {
            return this;
        }

        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                return 0;
            }
            Robot robot = obj as Robot;
            if(robot == null)
            {
                return 0;
            }
            if(robot.Naam.CompareTo(this.Naam) == 1)
            {
                return -1;
            }
            else if(robot.Naam.CompareTo(this.Naam) == -1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
