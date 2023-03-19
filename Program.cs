// See https://aka.ms/new-console-template for more information
using tpmodul5kpl_1302213003;

namespace tpmodul5kpl_1302213003
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            HaloGeneric<String> sapa = new HaloGeneric<String>();

            String X = "Marsya RH";

            sapa.SapaUser(X);

            DataGeneric<String> data_saved = new DataGeneric<string>("1302213003");

            data_saved.PrintData();
        }
    }
}

