using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{

    public class Game
    {
        public int noOfPlayers;
        public string country;
        public string CurrentYear = DateTime.UtcNow.ToString("yyyy");
        public Game()
        {

        }
        public Game(int _noOfPlayers, string _country)
        {
            noOfPlayers = _noOfPlayers;
            country = _country;
        }
        public void WorldCup(string country, int CurrentYear)
        {
            Console.WriteLine(" {0} have won WorldCup-{1}", country, CurrentYear);
        }
    }
    public class Criket : Game
    {
        public string coachName;
        public Criket()
        {

        }
        public Criket(int _noOfPlayers, string _country, string _coach) : base(_noOfPlayers, _country)
        {

        }

    }
    class FootBall : Game
    {
        public string LeagueName;

        public FootBall()
        {

        }
        public FootBall(int _noOfPlayers, string _country, string _LeagueName) : base(_noOfPlayers, _country)
        {
            LeagueName = _LeagueName;
        }
    }
    class ShowGameDetails
    {
        public void ShowCricketDetails(string country, int noOfPlayers, string Coach)
        {
            //Console.WriteLine("---------------CricketDetails----------------");
            Console.WriteLine("Country: {0} No of Players :{1} Coach :{2} ", country, noOfPlayers, Coach);
        }
        public void ShowFootBallDetails(string country, int noOfPlayers, string Coach)
        {
            //Console.WriteLine("====================FootBall Details===============================");
            Console.WriteLine("Country: {0} No of Players :{1} Coach :{2} ", country, noOfPlayers, Coach);
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Criket India = new Criket();
            Criket Australia = new Criket();
            FootBall Spain = new FootBall();
            FootBall England = new FootBall();
            ShowGameDetails show = new ShowGameDetails();
            Console.WriteLine("===========Cricket Details======================");
            show.ShowCricketDetails("India", 11, "SAchin");
            show.ShowCricketDetails("Australia", 11, "SAchin");
            Console.WriteLine("===============Foot Ball Details=================");

            show.ShowFootBallDetails("Australia", 8, "Dhoni");
            show.ShowFootBallDetails("Spain", 8, "Dhoni");

            Game G = new Game();
            Console.WriteLine("                               ");


            Australia.WorldCup("Australia", 2007);
            Spain.WorldCup("Spain", 20007);








        }
    }
}

