namespace Template
{
    public class StartUp
    {
        public static void Main()
        {
            var twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            var sour = new Sourdough();
            sour.Make();

            var whole = new WholeWheat();
            whole.Make();
        }
    }
}