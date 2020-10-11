using System;

namespace kms
{
    class Program
    {
        static void Main(string[] args)
        {
            int wannaDie = 0;

            while(wannaDie != 3)
            {
                Console.WriteLine("\nDoes will wanna die? Enter 1 for yes and 2 for no, or 3 to exit.\n");
                wannaDie = int.Parse(Console.ReadLine());

                switch(wannaDie)
                {
                    case 1:
                    Console.WriteLine("Correct, will desires the sweet relief of death.");
                    break;

                    case 2:
                    Console.WriteLine("HA SIKE ASS!!!! YES HE DOES!!!!");
                    break;

                    case 3:
                    Console.WriteLine("Okay it's over, but will's feelings of wanting to take a bus to the face isn't over.");
                    break;
                    
                    default:
                    Console.WriteLine("You can't follow directions and will still wants to die.");
                    break;
                }
            }
        }
    }
}
