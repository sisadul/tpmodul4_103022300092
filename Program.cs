﻿using System;
using System.Runtime.InteropServices;

namespace tpmodul4_103022300092
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kelurahan    " + "Kode Pos");
            Console.WriteLine("Batununggal  " + KodePos.getKodePos(KodePos.Kelurahan.Batununggal));
            Console.WriteLine("Kujangsari   " + KodePos.getKodePos(KodePos.Kelurahan.Kujangsari));
            Console.WriteLine("Mengger      " + KodePos.getKodePos(KodePos.Kelurahan.Mengger));
            Console.WriteLine("Wates        " + KodePos.getKodePos(KodePos.Kelurahan.Wates));
            Console.WriteLine("Cijaura      " + KodePos.getKodePos(KodePos.Kelurahan.Cijaura));
            Console.WriteLine("Jatisari     " + KodePos.getKodePos(KodePos.Kelurahan.Jatisari));
            Console.WriteLine("Margasari    " + KodePos.getKodePos(KodePos.Kelurahan.Margasari));
            Console.WriteLine("Sekejati     " + KodePos.getKodePos(KodePos.Kelurahan.Sekejati));
            Console.WriteLine("Kebonwaru    " + KodePos.getKodePos(KodePos.Kelurahan.Kebonwaru));
            Console.WriteLine("Maleer       " + KodePos.getKodePos(KodePos.Kelurahan.Maleer));
            Console.WriteLine("Samoja       " + KodePos.getKodePos(KodePos.Kelurahan.Samoja));

            DoorMachine dor = new DoorMachine();
            while (true)
            {
                Console.WriteLine("buka/kunci/keluar");
                string inputan = Console.ReadLine().ToLower();

                if (inputan == "buka")
                {
                    dor.ActivateTrigger(Trigger.BukaPintu);
                }
                else if (inputan == "kunci")
                {
                    dor.ActivateTrigger(Trigger.KunciPintu);
                }
                else if (inputan == "keluar")
                {
                    Console.WriteLine("Anda telah keluar dari program");
                    break;
                }
                else
                {
                    Console.WriteLine("Perintah tidak valid");
                }
            }

        }

    }
}
