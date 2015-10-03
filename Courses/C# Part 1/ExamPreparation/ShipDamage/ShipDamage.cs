using System;

    class ShipDamage
    {
        static void Main()
        {
            int sx1 = int.Parse(Console.ReadLine());
            int sy1 = int.Parse(Console.ReadLine());
            int sx2 = int.Parse(Console.ReadLine());
            int sy2 = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int cx1 = int.Parse(Console.ReadLine());
            int cy1 = int.Parse(Console.ReadLine());
            int cx2 = int.Parse(Console.ReadLine());
            int cy2 = int.Parse(Console.ReadLine());
            int cx3 = int.Parse(Console.ReadLine());
            int cy3 = int.Parse(Console.ReadLine());

            int sx3 = sx2;
            int sy3 = sy1;
            int sx4 = sx1;
            int sy4 = sy2;


            int opcy1 = (2 * H) - cy1;
            int opcy2 = (2 * H) - cy2;
            int opcy3 = (2 * H) - cy3;

            int damage = 0;

            //25%
            if ((opcy1==sy1&&(cx1==sx1||cx1==sx4))||(opcy1==sy2&&(cx1==sx2||cx1==sx3)))
            {
                damage += 25;
            }
            if ((opcy2 == sy1 && (cx1 == sx1 || cx1 == sx4)) || (opcy2 == sy2 && (cx1 == sx2 || cx1 == sx3)))
            {
                damage += 25;
            }
            if ((opcy3 == sy1 && (cx1 == sx1 || cx1 == sx4)) || (opcy3 == sy2 && (cx1 == sx2 || cx1 == sx3)))
            {
                damage += 25;
            }
            //50%
            if ((opcy1==sy1 && ((cx1 > sx1 && cx1<sx4) ||( cx1>sx4||cx1)) || (opcy1 == sy2 && (cx1 == sx2 || cx1 == sx3)))
            {
                damage += 100;
            }
            //100%
            if (opcy1)
            {
                
            }
        }
    }