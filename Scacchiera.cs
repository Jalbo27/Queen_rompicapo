namespace Queen_rompicapo
{
    internal class Scacchiera
    {
        public static readonly byte MAX_QUEEN = 8; // grandezza della scacchiera
        private Regina[] regina = new Regina[MAX_QUEEN]; // array di regine [8]
        public Scacchiera() => Clear();
        //
        // Inizializza tutti gli attributi della classe
        // Parametri 0
        private void Clear()
        {
            Righe = 0; Colonne = 0;
            for (byte righe = 0; righe < MAX_QUEEN; righe++)
            {
                regina[righe] = new Regina()
                {
                    Id = 0,
                    Colonne = 0,
                    Righe = 0
                };
            }
        }
        //
        // Istanzia un oggetto al suo interno e copia gli attributi della copia passata
        // Parametri 1: un oggetto della stessa classe (Scacchiera)
        public static Scacchiera Copy(Scacchiera copy)
        {
            Scacchiera auxiliary = new();
            auxiliary.Righe = copy.Righe;
            auxiliary.Colonne = copy.Colonne;
            for (byte righe = 0; righe < MAX_QUEEN; righe++)
            {
                auxiliary.regina[righe] = new();
                auxiliary.regina[righe] |= copy.regina[righe];
            }
            return auxiliary;
        }
        //
        // Proprietà righe: setta e ritorna ques'ultima
        public byte Righe { get; set; }
        //
        // Proprietà colonne: setta e ritorna ques'ultima
        public byte Colonne { get; set; }
        //
        // Overloading di metodi: imposta righe e colonne
        // Parametri 2: righe e colonne
        public void setConfig(byte righe, byte colonne)
        {
            this.Righe = righe;
            this.Colonne = colonne;
            regina[righe].Righe = (byte)this.Righe;
            regina[righe].Colonne = (byte)this.Colonne;
            regina[righe].Id = (byte)this.Righe;
        }
        //
        // Overloading di metodi: imposta solo le colonne
        // Parametri 1: colonne
        private void setConfig(byte colonne_inc)
        {
            Colonne = colonne_inc;
            regina[Righe].Righe = (byte)Righe;
            regina[Righe].Colonne = (byte)Colonne;
            regina[Righe].Id = (byte)Righe;
        }
        private bool CheckQueen(byte righe, byte colonne)
        {
            short conta_righe = righe, conta_colonne = colonne;
            // sopra
            while (conta_righe >= 0)
            {
                if (regina[conta_righe].Colonne == conta_colonne && regina[conta_righe].Righe == conta_righe)
                    return false;
                conta_righe--;
            }
            conta_righe = righe;
            // diagonale destra sopra
            while (conta_righe >= 0 && conta_colonne <= 7)
            {
                if (regina[conta_righe].Colonne == conta_colonne && regina[conta_righe].Righe == conta_righe)
                    return false;
                conta_colonne++; conta_righe--;
            }
            conta_righe = righe; conta_colonne = colonne;
            // diagonale sinistra sopra
            while (conta_righe >= 0 && conta_colonne >= 0)
            {
                if (regina[conta_righe].Colonne == conta_colonne && regina[conta_righe].Righe == conta_righe)
                    return false;
                conta_righe--; conta_colonne--;
            }
            return true;
        }
        //
        // Controlla tramite una funzione privata
        // se ci sono altre regine dalla posizione attuale della regina sulla scacchiera
        // Parametri 2: l'incremento delle colonne che avviene esternamente la classe ed un parametro facoltativo
        //              il parametro serve per specificare se c'è backtracking o meno
        // Ritorni 1: ritorna true o false
        public bool is_Good(byte colonne_inc, bool back = false)
        {
            byte conta_righe = Righe;
            byte conta_colonne = colonne_inc;
            if (!back)
            {
                if (Righe + 1 < 8)
                    conta_righe++;
            }
            if (CheckQueen(conta_righe, conta_colonne))
            {
                if(!back)
                    increRighe();
                setConfig(colonne_inc);
                return true;
            }
            else
                return false;
        }
        //
        // metodo che ritorna vero o falso se l'Id dell'ultima regina è diverso da 0
        // Parametri 0
        public bool is_FullofQueen() => regina[7].Id == 7;
        /* Scritto in modo più semplice:
         * { 
         *     if(regina[7].getId() != 0)
         *        return true;
         *     else              
         *        return false;
         * }
         */
        //
        // Metodo che incrementa solamente le righe
        // Parametri 0 
        private void increRighe() { if ((Righe + 1) < 8) Righe++; }
        //
        // Metodo che ritorna i tre valori della regina
        // Parametri 1: indice che corrisponde all'indice dell'array di regine
        // Ritorni 3: (byte = id, byte = righe, byte = colonne)
        public (byte, byte, byte) GetQueen(in ushort index) => (regina[index].Id, regina[index].Righe, regina[index].Colonne);
    }
}