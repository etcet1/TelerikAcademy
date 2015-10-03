using System;

class TripleRotationOfDigits
{
    static void Main(string[] args)
    {
        string numberK = Console.ReadLine();

        string newNumberK = "";
        if (numberK.Length==1)
        {
            Console.WriteLine(numberK);
        }
        else if (numberK.Length>1&&numberK.Length<=2)
        {
            for (int i = 0; i < 3; i++)
            {
                newNumberK = "";
                for (int j = 0; j <  numberK.Length - 1; j++)
                {
                    if (j == 0)
                    {
                        if (numberK[numberK.Length - 1] != '0')
                        {
                            newNumberK += numberK[numberK.Length - 1];
                        }
                    }

                    newNumberK += numberK[j];

                }
                numberK = newNumberK;
            }

            Console.WriteLine(newNumberK);
        }
        else if (numberK.Length > 1 && numberK.Length <= 3)
        {
            for (int i = 0; i < numberK.Length; i++)
            {
                newNumberK = "";
                for (int j = 0; j < numberK.Length - 1; j++)
                {
                    if (j == 0)
                    {
                        if (numberK[numberK.Length - 1] != '0')
                        {
                            newNumberK += numberK[numberK.Length - 1];
                        }
                    }

                    newNumberK += numberK[j];

                }
                numberK = newNumberK;
            }

            Console.WriteLine(newNumberK);
        }
        else
        {
            
            for (int i = 0; i < 3; i++)
            {
                newNumberK = "";
                for (int j = 0; j <  numberK.Length - 1; j++)
                {
                    if (j == 0)
                    {
                        if (numberK[numberK.Length - 1] != '0')
                        {
                            newNumberK += numberK[numberK.Length - 1];
                        }
                    }

                    newNumberK += numberK[j];

                }
                numberK = newNumberK;
            }

            Console.WriteLine(newNumberK);
        }
    }
}
