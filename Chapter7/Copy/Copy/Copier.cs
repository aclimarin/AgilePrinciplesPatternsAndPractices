namespace Copy
{
    //public class Copier
    //{
    //    //lembrar de reiniciar esta flag
    //    public static bool ptFlag = false;      //para a impressora
    //    public static bool punchFlag = false;   //para a fita
    //    public static void Copy()
    //    {
    //        int c;
    //        while ((c = (ptFlag ? PaperTpe.Read()
    //                            : Keyboard.Read())) != -1)
    //        {
    //            punchFlag ? PaperTape.Punch(c) : Printer.Write(c);

    //        }
    //    }
    //}

    public class Copier
    {
        public static Reader reader = new KeyBoardReader();
        public static void Copy()
        {
            int c;
            while ((c = reader.Read()) != -1)
            {
                Printer.Write(c);

            }
        }
    }
}
