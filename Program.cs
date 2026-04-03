using TP_MODUL6_103022400084;
class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack track1 = new SayaMusicTrack(null);
        track1.IncreasePlayCount(5);
        SayaMusicTrack track2 = new SayaMusicTrack(new string('A', 101));
        track2.IncreasePlayCount(5);
        SayaMusicTrack track3 = new SayaMusicTrack("Ngetes");
        track3.IncreasePlayCount(20000000);
        SayaMusicTrack track4 = new SayaMusicTrack("Cherry Waves - Deftones");
        for (int i = 0; i < 300; i++)
        {
            track4.IncreasePlayCount(10000000);
        }
        track4.PrintTrackDetails();
    }
}