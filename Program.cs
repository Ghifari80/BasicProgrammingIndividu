namespace BasicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        static void MainMenu()
        {
            string[] idPegawai = { "PG01", "PG02", "PG03" };
            String[] nmPegawai = { "Diego", "Max", "James" };
            String[] jbtPegawai = { "Direktur", "Staff", "IT Support" };
            int[] golongan = { 1, 2, 2 };

            int[] lamaBekerja = new int[idPegawai.Length];
            double[] gajiPokok = new double[idPegawai.Length];
            double[] tunjanganfungsional = new double[idPegawai.Length];
            double[] tunjangan = new double[idPegawai.Length];
            double[] totGaji = new double[idPegawai.Length];

            bool valueLmkerja = false;

            int menu1, menu2;
            do
            {
                Console.Clear();
                Console.WriteLine("=========================");
                Console.WriteLine("    DETAIL GAJI PEGAWAI  ");
                Console.WriteLine("=========================");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Data Pegawai");
                Console.WriteLine("2. Detail Gaji Pegawai");
                Console.WriteLine("3. Keluar");
                Console.Write("Masukan Pilihan : ");
                menu1 = Convert.ToInt32(Console.ReadLine());

                switch (menu1)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("=========================");
                        Console.WriteLine("       DATA PEGAWAI      ");
                        Console.WriteLine("=========================");
                        Console.WriteLine();
                        for (int i = 0; i < idPegawai.Length; i++)
                        {
                            int no = i + 1;
                            DataPegawai(idPegawai[i], nmPegawai[i], jbtPegawai[i], golongan[i], no);
                        }
                        break;
                    case 2:
                        if (valueLmkerja)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("=========================");
                            Console.WriteLine("   DETAIL GAJI PEGAWAI   ");
                            Console.WriteLine("=========================");
                            Console.WriteLine();
                            for (int i = 0; i < idPegawai.Length; i++)
                            {
                                int no = i + 1;
                                gajiPokok[i] = GajiPokok(jbtPegawai[i]);
                                tunjangan[i] = TunjanganPegawai(golongan[i]);
                                tunjanganfungsional[i] = TunjanganFungsional(lamaBekerja[i]);
                                totGaji[i] = gajiPokok[i] + tunjangan[i] + tunjanganfungsional[i];

                                DetailGaji(idPegawai[i], nmPegawai[i], jbtPegawai[i], golongan[i], lamaBekerja[i], gajiPokok[i],
                                    tunjangan[i], tunjanganfungsional[i], totGaji[i], no);

                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Silahkan Inputkan Lama Bekerja Pegawai! (Tahun)");
                            for (int i = 0; i < idPegawai.Length; i++)
                            {
                                int no = i + 1;
                                Console.WriteLine();
                                Console.WriteLine("Pegawai Ke " + no);
                                Console.WriteLine("ID Pegawai           : " + idPegawai[i]);
                                Console.WriteLine("Nama Pegawai         : " + nmPegawai[i]);
                                Console.WriteLine("Jabatan              : " + jbtPegawai[i]);
                                Console.Write("Masukan Lama Bekerja : ");
                                int lama = Convert.ToInt32(Console.ReadLine());
                                lamaBekerja[i] = lama;
                                Console.WriteLine("------------------------------------");
                            }
                            valueLmkerja = true;
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Input Invalid");
                        break;
                }
                Console.WriteLine("Kembali Ke Home?");
                Console.WriteLine("1. Ya");
                Console.WriteLine("2. tidak");
                Console.Write("Masukan Pilihan : ");
                menu2 = Convert.ToInt32(Console.ReadLine());
            } while (menu2 != 2);
        }

        static void DataPegawai(String idPegawai, String nmPegawai, String jabatan, int golongan, int no)
        {
            Console.WriteLine("Pegawai Ke " + no);
            Console.WriteLine("ID Pegawai   : " + idPegawai);
            Console.WriteLine("Nama Pegawai : " + nmPegawai);
            Console.WriteLine("Jabatan      : " + jabatan);
            Console.WriteLine("Golongan     : " + golongan);
            Console.WriteLine();
        }
        static double GajiPokok(String jbtPegawai)
        {
            double gajiPokok = 0;
            if (jbtPegawai == "Direktur")
            {
                gajiPokok = 6500000;
            }
            else if (jbtPegawai == "Staff")
            {
                gajiPokok = 5500000;
            }
            else if (jbtPegawai == "IT Support")
            {
                gajiPokok = 5600000;
            }
            else
            {
                gajiPokok = 0;
            }
            return gajiPokok;
        }
        static double TunjanganPegawai(int golongan)
        {
            double tunjangan = 0;
            if (golongan == 1)
            {
                tunjangan = 1150000;
            }
            else
            {
                tunjangan = 920000;
            }
            return tunjangan;
        }
        static double TunjanganFungsional(int lamaKerja)
        {
            double tjgFungsional = 0;
            if (lamaKerja >= 2)
            {
                tjgFungsional = 700000;
            }
            else
            {
                tjgFungsional = 400000;
            }
            return tjgFungsional;
        }
        static void DetailGaji(String idPegawai, String nmPegawai, String jbtPegawai, int gol, int lamakerja, double gapok,
            double tunjangan, double tjgFungsional, double total, int no)
        {
            Console.WriteLine("Pegawai Ke " + no);
            Console.WriteLine("ID Pegawai              : " + idPegawai);
            Console.WriteLine("Nama Pegawai            : " + nmPegawai);
            Console.WriteLine("Jabatan                 : " + jbtPegawai);
            Console.WriteLine("Golongan                : " + gol);
            Console.WriteLine("Lama Bekerja            : " + lamakerja + " Tahun");
            Console.WriteLine("Gaji Pokok              : Rp." + gapok);
            Console.WriteLine("Tunjangan               : Rp." + tunjangan);
            Console.WriteLine("Tunjangan Fungsional    : Rp." + tjgFungsional);
            Console.WriteLine("Total Gaji              : Rp." + total);
            Console.WriteLine();
        }
    }
}