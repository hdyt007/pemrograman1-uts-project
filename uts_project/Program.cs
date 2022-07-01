// See https://aka.ms/new-console-template for more information

/*

============================ Keterangan ============================
= Nama               : Hidayat Bakri                               =
= Nim                : 20212205038                                 =
= Kelas              : T.203                                       =
= Metode             : 3 Metode (Kondisi, Perulangan, Konversi)    =
= Variabel           : 3 Jenis (Integer, string, array)            =
= Looping            : 2 Jenis (While dan For)                     =
= Konversi tipe data : Konversi string ke integer                  =
= Kondisi            : 2 Kondisi (If else dan Switch case)         =
====================================================================
 
*/

using System;
class Games
{
    static void Main(String[] args)
    {
        // Create New Variable
        string player;
        int repeat, getRandom, i = 0, computerScore = 0, playerScore = 0;
        

        Random rand = new Random();
        


        Console.WriteLine("==== Game Suit Batu Gunting Kertas ==== \n");
        
        // input player
        Console.Write("Masukkan Nama : ");
        player = Console.ReadLine();
        Console.Write("Ingin Main Berapakali : ");
        repeat = int.Parse(Console.ReadLine());

        int[] computer = new int[repeat];
        int[] inputPlayer = new int[repeat];
        string[] computerModel = new string[repeat];
        string[] playerModel = new string[repeat];
        string[] results = new string[repeat];

        // rules
        Console.WriteLine("\n=====================================");
        Console.WriteLine(player + " vs Komputer");
        Console.WriteLine("=====================================");
        Console.WriteLine("=Kode Untuk Memilih Model Suit Anda =");
        Console.WriteLine("= 1 : Batu                          =");
        Console.WriteLine("= 2 : Gunting                       =");
        Console.WriteLine("= 3 : Kertas                        =");
        Console.WriteLine("=====================================\n");

        
        while(i < repeat){

            // create random value
            getRandom = rand.Next(1, 9);

            // computer choice
            if (getRandom <= 3)
            {
                computer[i] = 1;
            }
            else if (getRandom <= 6) {
                computer[i] = 2;
            }
            else
            {
                computer[i] = 3;
            }

            // player choice
            Console.Write("Masukkan Pilihan Ke - " + (i + 1) + " Anda : ");
            inputPlayer[i] = int.Parse(Console.ReadLine());

            i++;
        }

        for (int j = 0; j < repeat; j++) {

            // model initialization

            switch (computer[j])
            {
                case 1:
                    computerModel[j] = "Batu";
                    break;
                case 2:
                    computerModel[j] = "Gunting";
                    break;
                default:
                    computerModel[j] = "Kertas";
                    break;
            }

            switch (inputPlayer[j])
            {
                case 1:
                    playerModel[j] = "Batu";
                    break;
                case 2:
                    playerModel[j] = "Gunting";
                    break;
                default:
                    playerModel[j] = "Kertas";
                    break;
            }

            Console.WriteLine("\nKomputer Memilih " + computerModel[j] + " dan Anda Memilih " + playerModel[j]);

            // condition check
            if (computer[j] == inputPlayer[j]) {
                results[j] = "Hasil Permainan Ke - " + (j + 1) + " : Permainan Seri";
                computerScore += 1;
                playerScore += 1;
            }else if (computer[j] == 1 && inputPlayer[j] == 2)
            {
                results[j] = "Hasil Permainan Ke - " + (j + 1) + " : Anda Kalah";
                computerScore += 1;
                playerScore += 0;
            }
            else if (computer[j] == 1 && inputPlayer[j] == 3)
            {
                results[j] = "Hasil Permainan Ke - " + (j + 1) + " : Anda Menang";
                computerScore += 0;
                playerScore += 1;
            }
            else if (computer[j] == 2 && inputPlayer[j] == 1)
            {
                results[j] = "Hasil Permainan Ke - " + (j + 1) + " : Anda Menang";
                computerScore += 0;
                playerScore += 1;
            }
            else if (computer[j] == 2 && inputPlayer[j] == 3)
            {
                results[j] = "Hasil Permainan Ke - " + (j + 1) + " : Anda Kalah";
                computerScore += 1;
                playerScore += 0;
            }
            else if (computer[j] == 3 && inputPlayer[j] == 1)
            {
                results[j] = "Hasil Permainan Ke - " + (j + 1) + " : Anda Kalah";
                computerScore += 1;
                playerScore += 0;
            }
            else if (computer[j] == 3 && inputPlayer[j] == 2)
            {
                results[j] = "Hasil Permainan Ke - " + (j + 1) + " : Anda Menang";
                computerScore += 0;
                playerScore += 1;
            }

            Console.WriteLine(results[j]);
        }

        // print results

        Console.WriteLine("\n============= Hasil Akhir ================");
        Console.WriteLine("Komputer : " + computerScore);
        Console.WriteLine(player + " : " + playerScore);
        if(computerScore == playerScore)
        {
            Console.WriteLine("Hasil Akhir, Permainan Seri");
        }else if(computerScore < playerScore)
        {
            Console.WriteLine("Hasil Akhir, Selamat Anda Menang");
        }else
        {
            Console.WriteLine("Hasil Akhir, Ops Anda Kalah");
        }

        Console.WriteLine("==========================================");
    }
}
