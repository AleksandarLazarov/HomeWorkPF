using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var notes = new List<string>();
            var naturals = new List<string>();
            var sharps = new List<string>();

            for (int i = 0; i < str.Count; i++)
            {
                if (str[i] == 261.63)
                {
                    notes.Add("C");
                }
                else if (str[i] == 277.18)
                {
                    notes.Add("C#");
                }
                else if (str[i] == 293.66)
                {
                    notes.Add("D");
                }
                else if (str[i] == 311.13)
                {
                    notes.Add("D#");
                }
                else if (str[i] == 329.63)
                {
                    notes.Add("E");
                }
                else if (str[i] == 349.23)
                {
                    notes.Add("F");
                }
                else if (str[i] == 369.99)
                {
                    notes.Add("F#");
                }
                else if (str[i] == 392.00)
                {
                    notes.Add("G");
                }
                else if (str[i] == 415.30)
                {
                    notes.Add("G#");
                }
                else if (str[i] == 440.00)
                {
                    notes.Add("A");
                }
                else if (str[i] == 466.16)
                {
                    notes.Add("A#");
                }
                else if (str[i] == 493.88)
                {
                    notes.Add("B");
                }
            }

            foreach (var note in notes)
            {
                if (note.Contains("#"))
                {
                    sharps.Add(note);
                }
                else
                {
                    naturals.Add(note);
                }
            }

            double sumSharps = 0;

            for (int i = 0; i < sharps.Count; i++)
            {
                if (sharps[i] == "C#")
                {
                    sumSharps += 277.18;
                }
                else if (sharps[i] == "D#")
                {
                    sumSharps += 311.13;
                }
                else if (sharps[i] == "F#")
                {
                    sumSharps += 369.99;
                }
                else if (sharps[i] == "G#")
                {
                    sumSharps += 415.30;
                }
                else if (sharps[i] == "A#")
                {
                    sumSharps += 466.16;
                }
            }

            double sumNaturals = 0;
            for (int i = 0; i < naturals.Count; i++)
            {
                if (naturals[i] == "C")
                {
                    sumNaturals += 261.63;
                }
                else if (naturals[i] == "D")
                {
                    sumNaturals += 293.66;
                }
                else if (naturals[i] == "E")
                {
                    sumNaturals += 329.63;
                }
                else if (naturals[i] == "F")
                {
                    sumNaturals += 349.23;
                }
                else if (naturals[i] == "G")
                {
                    sumNaturals += 392.00;
                }
                else if (naturals[i] == "A")
                {
                    sumNaturals += 440.00;
                }
                else if (naturals[i] == "B")
                {
                    sumNaturals += 493.88;
                }
                
            }

            Console.Write("Notes: ");
            Console.WriteLine(string.Join(" ",notes));
            Console.Write("Naturals: ");
            Console.WriteLine(string.Join(", ", naturals));
            Console.Write("Sharps: ");
            Console.WriteLine(string.Join(", ", sharps));
            Console.WriteLine($"Naturals sum: {sumNaturals}");
            Console.WriteLine($"Sharps sum: {sumSharps}");

        }
    }
}
