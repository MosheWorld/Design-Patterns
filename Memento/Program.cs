using System;

namespace MosheBinieli.Memento
{
    class MainApp
    {
        static void Main()
        {
            try
            {
                ProspectMemory mMamnager = new ProspectMemory();
                SalesProspect s = new SalesProspect();

                ChangeSalesState(s, "Noel van Halen", "(412) 256-0990", 25000.0);
                mMamnager.Insert(s.SaveMemento());

                ChangeSalesState(s, "Leo Welch", "(310) 209-7111", 1000000.0);
                mMamnager.Insert(s.SaveMemento());

                ChangeSalesState(s, "Moshe Binieli", "(972) 054-2477052", 3120000.0);
                mMamnager.Insert(s.SaveMemento());

                s.RestoreMemento(mMamnager.Get());
                s.RestoreMemento(mMamnager.Get());
                s.RestoreMemento(mMamnager.Get());
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ChangeSalesState(SalesProspect s, string newName, string newPhone, double newBudget)
        {
            s.Name = newName;
            s.Phone = newPhone;
            s.Budget = newBudget;
        }
    }
}

