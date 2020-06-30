using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_2683
{
    class Program
    {

        static void Main(string[] args)
        {

            KaryawanTetap[] karyawanTetap = new KaryawanTetap[20];
            KaryawanHarian[] karyawanHarian = new KaryawanHarian[20];
            Sales[] sales = new Sales[20];

            List<Karyawan> listkaryawan = new List<Karyawan>();

            int p1, p2;
            int i = 0, j = 0, x = 0;
            do
            {
            k1:
                Console.Title = "CRUD OPP KARYAWAN 2685";

                Console.WriteLine("Karyawan");
                Console.WriteLine("=================================");
                Console.WriteLine("Pilihan Menu : ");
                Console.WriteLine("1. Tambah Data");
                Console.WriteLine("2. Hapus Data");
                Console.WriteLine("3. Tampilkan Data");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("==================================");
                Console.WriteLine();

                Console.Write("Masukan Pilihan : ");
                p1 = Convert.ToInt32(Console.ReadLine());


                switch (p1)
                {
                    case 1:
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Tambah Karyawan");
                            Console.WriteLine("==================================");
                            Console.WriteLine("Pilih Karyawan : ");
                            Console.WriteLine("1. Karyawan Tetap ");
                            Console.WriteLine("2. Karyawan Harian");
                            Console.WriteLine("3. Sales");
                            Console.WriteLine("4. Kembali");
                            Console.WriteLine("==================================/n");
                            Console.WriteLine("Masukan Pilihan : ");

                            p2 = Convert.ToInt32(Console.ReadLine());

                            switch (p2)
                            {
                                //Tambah Karyawan
                                case 1:
                                    //Karyawan Tetap                        
                                    i++;
                                    karyawanTetap[i] = new KaryawanTetap();

                                    Console.Clear();
                                    Console.WriteLine("\nTambah Karyawan Tetap \n ");
                                    Console.Write("NIK          : ");
                                    karyawanTetap[i].Nik = Console.ReadLine();
                                    Console.Write("Nama         : ");
                                    karyawanTetap[i].Nama = Console.ReadLine();
                                    Console.Write("Gaji Bulanan : ");
                                    karyawanTetap[i].GajiBulanan = int.Parse(Console.ReadLine());

                                    //list
                                    listkaryawan.Add(karyawanTetap[i]);
                                    Console.WriteLine("\n");
                                    break;

                                case 2:
                                    //Karyawan Harian
                                    j++;
                                    karyawanHarian[j] = new KaryawanHarian();

                                    Console.Clear();
                                    Console.WriteLine("\nTambah Karyawan Harian \n ");
                                    Console.Write("NIk              : ");
                                    karyawanHarian[j].Nik = Console.ReadLine();
                                    Console.Write("Nama             : ");
                                    karyawanHarian[j].Nama = Console.ReadLine();
                                    Console.Write("Jumlah Jam Kerja : ");
                                    karyawanHarian[j].JumlahJamKerja = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Upah Per Jam     : ");
                                    karyawanHarian[j].UpahPerJam = Convert.ToDouble(Console.ReadLine());

                                    //list
                                    listkaryawan.Add(karyawanHarian[j]);
                                    Console.WriteLine("\n");
                                    break;

                                case 3:
                                    //Sales                                
                                    x++;
                                    sales[x] = new Sales();

                                    Console.Clear();
                                    Console.WriteLine("\nTambah Sales \n ");
                                    Console.Write("NIK              : ");
                                    sales[x].Nik = Console.ReadLine();
                                    Console.Write("Nama             : ");
                                    sales[x].Nama = Console.ReadLine();
                                    Console.Write("Jumlah Penjualan : ");
                                    sales[x].JumlahPenjualan = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Komisi           : ");
                                    sales[x].Komisi = Convert.ToDouble(Console.ReadLine());

                                    //list
                                    listkaryawan.Add(sales[x]);
                                    Console.WriteLine("\n");
                                    break;


                                case 4:
                                    Console.Clear();
                                    goto k1;
                            }

                        }
                        while (p2 != 4);
                        Console.Clear();
                        break;

                    //Hapus Karyawan
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Hapus Karyawan");
                        Console.WriteLine("---------------------------------");
                        Console.Write("NIK : ");
                        string nikhapus = Console.ReadLine();

                        if (listkaryawan.Any(n => n.Nik == nikhapus))
                        {
                            listkaryawan.RemoveAll(n => n.Nik == nikhapus);
                            Console.WriteLine("Data karyawan berhasil dihapus\n\n");
                        }
                        else
                        {
                            Console.WriteLine("Data tidak ditemukan\n\n");
                        }

                        break;



                    //Tampil Data Karyawan
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Tampilkan Data");
                        Console.WriteLine("---------------------------------");
                        int nourut = 0;

                        foreach (Karyawan karyawan in listkaryawan)
                        {
                            nourut++;
                            Console.Write("{0}. NIK : {1} | Nama: {2} | Gaji: {3:N0} | ",
                            nourut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                            if (karyawan is KaryawanTetap)
                            {
                                Console.Write("Karyawan Tetap \n");
                            }

                            else if (karyawan is KaryawanHarian)
                            {
                                Console.Write("Karyawan Harian \n");
                            }

                            else if (karyawan is Sales)
                            {
                                Console.Write("Sales \n");
                            }
                        }
                        Console.WriteLine("\n");

                        break;

                    //KELUAR
                    case 4:
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Yang anda Input Salah");
                        break;
                }

            }

            while (p1 != 4);
            Environment.Exit(0);
        }

    }

}