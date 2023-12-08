using System;

class BeerSong
{
    public void Sing()
    {
        for (int bottles = 99; bottles >= 2; bottles--)
        {
            Console.WriteLine($"{bottles} bottles of beer on the wall, {bottles} bottles of beer.");
            Console.WriteLine($"Take one down and pass it around, {bottles - 1} {(bottles - 1 == 1 ? "bottle" : "bottles")} of beer on the wall.");
                Console.Write("");
        }
          Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer");
    }
}
//
class Program

{
    static void Main()
    {
        BeerSong beerSong = new BeerSong();
        beerSong.Sing();
    }
}




