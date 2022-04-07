/* ROMPICAPO DELLE 8 REGINE: 
 * trovare le combinazioni possibili per le quali le regine siano disposte nella scacchiera senza mai toccarsi muovendosi
 */

using System.Runtime.CompilerServices;

namespace Queen_rompicapo
{
    public partial class Rompicapo : Form
    {
        private Scacchiera? chest = new();
        private Scacchiera pick_chest = new();
        private Stack<Scacchiera> config = new();
        private readonly PictureBox[,] celle = new PictureBox[8, 8];
        private byte queens_count = 0;
        public Rompicapo() => InitializeComponent();
        /*
         * Form1_Load
         */
        #region Inizializzazione degli oggetti e stack
        private void Form1_Load(object sender, EventArgs e)
        {
            pick_chest = Scacchiera.Copy(chest);
            for(byte config_init = 0; config_init < Scacchiera.MAX_QUEEN; config_init++)
            {
                chest.setConfig(0, (byte)(7 - config_init));
                config.Push(chest);
                chest = Scacchiera.Copy(chest);
            }
            chest = null;
            LoadChest();
        }
        #endregion
        /*
         *  Disegna la scacchiera
         */
        #region LoadChest: Carica la scacchiera e setta le label utili
        [MethodImpl(MethodImplOptions.AggressiveInlining)] // (c++ = inline)
        private void LoadChest()
        {
            Regina1.Text = "Regina 1:  ";
            Regina2.Text = "Regina 2:  ";
            Regina3.Text = "Regina 3:  ";
            Regina4.Text = "Regina 4:  ";
            Regina5.Text = "Regina 5:  ";
            Regina6.Text = "Regina 6:  ";
            Regina7.Text = "Regina 7:  ";
            Regina8.Text = "Regina 8:  ";
            byte somma = 0;
            for (byte rows = 0; rows < 8; rows++)
            {
                for (byte columns = 0; columns < 8; columns++)
                {
                    celle[rows, columns] = new PictureBox
                    {
                        Location = new Point(500 + 50 * columns, 310 + 50 * rows),
                        Size = new Size(110, 110),
                        SizeMode = PictureBoxSizeMode.AutoSize,
                        BorderStyle = BorderStyle.Fixed3D,
                        BackColor = Color.Transparent
                    };
                    if (rows % 2 == 0)
                        _ = (columns + somma) % 2 == 0 ? celle[rows, columns].Image = imageList1.Images[1] : celle[rows, columns].Image = imageList1.Images[2];
                    else
                        _ = (columns + somma) % 2 != 0 ? celle[rows, columns].Image = imageList1.Images[1] : celle[rows, columns].Image = imageList1.Images[2];

                    Controls.Add(celle[rows, columns]);
                    celle[rows, columns].BringToFront();
                    somma += 2;
                }
            }
        }
        #endregion
        /*
         * Bottone "START"
         */
        #region Evento click mouse bottone START
        private void button1_Click(object sender, EventArgs e) => Gestione_Regine();
        #endregion
        /*
         * Gestione delle regine
         */
        #region Gestisce tutte le regine per una singola configurazione
        readonly Scacchiera? NULL_OBJECT = null;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] // (c++ = inline)
        private void Gestione_Regine() // trova una signola configurazione delle regine
        {
            LoadChest();
            object p = config.Count > 0 ? pick_chest = config.Peek() : button1.Enabled = false;
            pick_chest = Scacchiera.Copy(pick_chest);
            byte colonne_inc = 0;
            for (UInt16 i = 0; i < 10000; i++)
            {
                while (true && config.Count > 0)
                {
                    if (pick_chest.is_Good(colonne_inc))
                    {                                    
                        config.Push(pick_chest);
                        pick_chest = config.Peek();
                        pick_chest = Scacchiera.Copy(pick_chest);
                        colonne_inc = 0;
                        break;
                    }
                    else
                        colonne_inc++;  
                    if (colonne_inc >= 8)
                    {
                        config.Push(NULL_OBJECT); // push a null object (Scacchiera)
                        Backtracking(); 
                        pick_chest = config.Peek();
                        pick_chest = Scacchiera.Copy(pick_chest);
                        colonne_inc = 0; 
                        break;
                    }
                }
                if (pick_chest.is_FullofQueen())
                {
                    queens_count++;
                    ViewQueen(queens_count);
                    break;
                }
            }
        }
        #endregion
        /*
         * Backtracking
         */
        #region Backtracking
        [MethodImpl(MethodImplOptions.AggressiveInlining)] // c++ = inline
        private bool Backtracking() // backtracking
        {
            config.Pop();
            pick_chest = config.Peek();
            pick_chest = Scacchiera.Copy(pick_chest);
            var (_, _, colonne) = pick_chest.GetQueen(pick_chest.Righe);
            byte colonne_inc = (byte)(colonne + 1);
            if (colonne_inc >= 8)
                return Backtracking();
            while (true && config.Count > 0)
            {
                if (pick_chest.is_Good(colonne_inc, true))
                {
                    if (pick_chest.Righe == config.Peek().Righe)
                        config.Pop();
                    config.Push(pick_chest);
                    break;
                }
                else
                    colonne_inc++;
                if (colonne_inc >= 8)
                {
                    Backtracking();
                    break;
                }
            }
            return true;
        }
        #endregion
        /*
         * Visualizzazione regine su scacchiera
         */
        #region View Queens
        private void ViewQueen(ushort combinazioni)
        {
            if(combinazioni < 9)
                label5.Text = combinazioni.ToString();
            for(byte i = 0; i < Scacchiera.MAX_QUEEN; i++)
            {
                if(config.Count > 0) config.Pop();
                var (id, _, colonne) = pick_chest.GetQueen(i);
                celle[id, colonne].Image = imageList1.Images[0];
                switch (i)
                {
                    case 0:
                        Regina1.Text += "   Riga: " + (id + 1).ToString() + "     Colonna: " + (colonne + 1).ToString();
                        break;
                    case 1:
                        Regina2.Text += "   Riga: " + (id + 1).ToString() + "     Colonna: " + (colonne + 1).ToString();
                        break;
                    case 2:
                        Regina3.Text += "   Riga: " + (id + 1).ToString() + "     Colonna: " + (colonne + 1).ToString();
                        break;
                    case 3:
                        Regina4.Text += "   Riga: " + (id + 1).ToString() + "     Colonna: " + (colonne + 1).ToString();
                        break;
                    case 4:
                        Regina5.Text += "   Riga: " + (id + 1).ToString() + "     Colonna: " + (colonne + 1).ToString();
                        break;
                    case 5:
                        Regina6.Text += "   Riga: " + (id + 1).ToString() + "     Colonna: " + (colonne + 1).ToString();
                        break;
                    case 6:
                        Regina7.Text += "   Riga: " + (id + 1).ToString() + "     Colonna: " + (colonne + 1).ToString();
                        break;
                    case 7:
                        Regina8.Text += "   Riga: " + (id + 1).ToString() + "     Colonna: " + (colonne + 1).ToString();
                        break;
                }
            }
        }
        #endregion
        /*
         * Notify icon 
         */
        #region Icona di notifica per chiudere e riaprire il programma
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible) 
                this.Hide();
            else
                this.Show();   
        }
        #endregion
    }
}
#region DEVELOPED BY ALBERTO LORENZINI
#endregion