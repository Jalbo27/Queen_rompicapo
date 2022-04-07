namespace Queen_rompicapo
{
    internal class Regina
    {
        private Regina(params byte[] pos) // costruttore privato per settare le proprietà
        {
            Id = pos[0];
            Righe = pos[1];
            Colonne = pos[2];
        }
        public Regina() { Righe = 0; Colonne = 0; Id = 0; } // costruttore 
        public byte Id { get; set; } // proprietà con i metodi getter e setter integrati dell'Id della regina
        public byte Righe { get; set; } // proprietà con i metodi getter e setter integrati delle righe della regina
        public byte Colonne { get; set; } // proprietà con i metodi getter e setter integrati delle colonne della regina
        public static Regina operator |(Regina reginasx, // override di operatore
                             Regina reginadx) => new(reginadx.Id, reginadx.Righe, reginadx.Colonne);
    }
}