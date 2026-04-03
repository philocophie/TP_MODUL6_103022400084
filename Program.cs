using TP_MODUL6_103022400084;
class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack track = new SayaMusicTrack("Cherry Waves - Deftones");
        track.IncreasePlayCount(5);
        track.PrintTrackDetails();
    }
}