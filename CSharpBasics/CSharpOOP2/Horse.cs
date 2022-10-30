using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP2
{
    public class Horse
    {
        public string NickName;
        public string Color;
        public double Age;
        public string Breed;
        public double TailLength;
        public bool IsVaccinated;
        public bool IsHealthy;
        public int DaysNumberLastVaccination;
        public int NumbersOfWins = 5;
        public int _speed;
        public bool _isReadyToCompetition;

        public static string _kind = "Horse";

        public static string Kind
        {
            get { return _kind; }
            set { _kind = value; }
        }
       
        public int JockeysNumber { get; private set; }
        
        public int Speed
        {
            set {_speed = value;}
        }

        public bool IsReadyToCompetition
        {
            get {return _isReadyToCompetition;}
        }

        public Horse(string nickName, string color, double age, string breed, double tailLength, bool isVaccinated, bool isHealthy, int daysNumberLastVaccination)
        {
            NickName = nickName;
            Color = color;
            Age = age;
            Breed = breed;
            TailLength = tailLength;
            IsVaccinated = isVaccinated;
            IsHealthy = isHealthy;
            DaysNumberLastVaccination = daysNumberLastVaccination;
        }

        public Horse()
        {
        }

        public Horse(string nickName, double age)
        {
            NickName = nickName;
            Age = age;
        }

        internal void CheckVaccination(double age)
        {
            switch (Age)
            {
                case 0.5:
                    Console.WriteLine("First vactination is required.");
                    break;
                case 1:
                    Console.WriteLine("Second vactination is required.");
                    break;
                case 2:
                    Console.WriteLine("Third vactination is required.");
                    break;
                case 3:
                    Console.WriteLine("Fourth vactination is required.");
                    break;
                default: Console.WriteLine("Vactination at the request of the owner");
                    break;
            }
        }
        public void TakePartInTournaments(bool isHealthy, bool isVaccinated)
        {
            if (IsHealthy && IsVaccinated)
            {
                Console.WriteLine("The horse can take part in the races");
            } else
            {
                Console.WriteLine("The horse should go to the vet");
            }
        }
        public bool NeedDoVaccination(int DaysNumberLastVaccination)
        {
            if (DaysNumberLastVaccination >= 0 && DaysNumberLastVaccination <= 365)
            {
            return IsVaccinated = true;
            } else
            {
                return IsVaccinated = false;
            }
        }
        private string CutTail (double tailLength)
        {
            if (tailLength <= 0)
            {
                return $"Value {tailLength} is not correct";
            } else if (tailLength >0 && tailLength <= 1.2)
            {
                return $"Your horse with tail {tailLength} look perfect and ready for exibition.";
            }else 
            {
                return $"The horse with {tailLength} should go to a haidresser for animals.";
            }
        }
        
        public void PrintParticipantGreeting(string name, string breed)
        {
            Console.WriteLine($"Welcome the next participant of tournament {name} of the {breed} breed");
        }

        public static string CheckHorseTrainigOrCompetition(int jokeyNumber)
        {
            switch (jokeyNumber)
            {
                case 0:
                    return "This horse is too small for training or competition";
                case 1:
                    return "This horse is for competition";
                default:
                    return "This horse is for training in the arena";
            }

        }
    }
}
