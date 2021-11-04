using System;

namespace SquadraCalcio
{
    class Squadra
    {
        int partite_vinte, partite_perse, partite_pareggiate, gol_fatti, gol_subiti, totale_gol_subiti, totale_gol_fatti, punteggio;//attributi della classe Squadra
        public Squadra()//porta a 0 il valore degli attributi
        {
            this.partite_vinte = 0;//porta a 0 il valore della variabile "partite_vinte" nell'istanza corrente
            this.partite_perse = 0;//porta a 0 il valore della variabile "partite_perse" nell'istanza corrente
            this.partite_pareggiate = 0;//porta a 0 il valore della variabile "partite_pareggiate" nell'istanza corrente
            this.gol_fatti = 0;//porta a 0 il valore della variabile "gol_fatti" nell'istanza corrente
            this.gol_subiti = 0;//porta a 0 il valore della variabile "gol_subiti" nell'istanza corrente
            this.totale_gol_fatti = 0;//porta a 0 il valore della variabile "totale_gol_fatti" nell'istanza corrente
            this.totale_gol_subiti = 0;//porta a 0 il valore della variabile "totale_gol_subiti" nell'istanza corrente
            this.punteggio = 0;//porta a 0 il valore della variabile "punteggio" nell'istanza corrente
        }
        public int ControlloQuantità()//controllo che il valore inserito dall'utente sia un numero e che sia maggiore di 0, se non lo è allora ritorna -1
        {
            try
            {
                int risposta = int.Parse(Console.ReadLine());//legge il valore inserito in input da tastiera e lo converte in intero
                if(risposta < 0)
                {
                    return -1;
                }
                else
                {
                    return risposta;
                }       
            }
            catch
            {
                return -1;
            }
        }
        public void AumentoPartite()//in base al valore degli attributi gol_fatti e gol_subiti e aumenta il numero di partite vinte, perse oppure pareggiate dell'istanza corrente 
        {
            if (this.gol_fatti < this.gol_subiti)//controlla se il numero di gol_fatti siano minori dei gol_subiti
                                                 //se si verifica questa condizione allora verrà aumentata la variabile partite
            {
                this.partite_perse++;
            }
            else if (this.gol_fatti == this.gol_subiti)
            {
                this.partite_pareggiate++;
            }
            else
            {
                this.partite_vinte++;
            }       
        }
        public int Punti()//calcola il punteggio della squadra basato sul numero di vittorie ed il numero di pareggi dell'istanza corrente
        {
            this.punteggio = this.punteggio +  (this.partite_vinte * 3) + (this.partite_pareggiate * 1);
            return (this.partite_vinte * 3) + (this.partite_pareggiate * 1);
        }
        public void Gol_Fatti(int gol)//assegna il valore di gol fatti alla variabile gol_fatti e li aggiunge alla variabile totale_gol_fatti dell'istanza corrente
        {
            this.gol_fatti = gol;//assegna il numero di gol che l'utente ha inserito da tastiera alla variabile gol_fatti dell'istanza corrente
            this.totale_gol_fatti = this.totale_gol_fatti + this.gol_fatti;//aggiunge il numero di gol fatti dalla squadra corrente alla variabile totale_gol_fatti dell'istanza corrente
        }
        public void Gol_Subiti(int gol)//assegna il valore di gol subiti alla variabile gol_subiti e li aggiunge alla variabile totale_gol_subiti
        {
            this.gol_subiti = gol;//
            this.totale_gol_subiti = this.totale_gol_subiti + this.gol_subiti;//
        }
        public void AssegnazioneValori(int[] valori)//assegna i valori specificati dall'utente all'istanza corrente quindi prima alla Juventus e dopo al Milan
        {
            this.partite_vinte = valori[0];//assegna il primo valore che l'utente ha inserito da tastiera alla variabile "partite_vinte" dell'istanza corrente
            this.partite_pareggiate = valori[1];//assegna il secondo valore che l'utente ha inserito da tastiera alla variabile "partite_pareggiate" dell'istanza corrente
            this.partite_perse = valori[2];//assegna il terzo valore che l'utente ha inserito da tastiera alla variabile "partite_perse" dell'istanza corrente
            this.totale_gol_fatti = valori[3];//assegna il quarto valore che l'utente ha inserito da tastiera alla variabile "totale_gol_fatti" dell'istanza corrente
            this.totale_gol_subiti = valori[4];//assegna il quinto valore che l'utente ha inserito da tastiera alla variabile "totale_gol_subiti" dell'istanza corrente
        }
        public void InizioAnno()//riporta i valori a zero degli attributi della squadra corrente
        {
            this.partite_vinte = 0;//
            this.partite_pareggiate = 0;//
            this.partite_perse = 0;//
            this.totale_gol_fatti = 0;//
            this.totale_gol_subiti = 0;//
            this.gol_fatti = 0;//
            this.gol_subiti = 0;//
        }
        public void ScambioValori(ref int[] risposte)//scambio il valore delle partite vinte della Juventus con le partite perse dato che le squadre sono due e quindi 
                                                     //
        {
            int n3;
            n3 = risposte[0];
            risposte[0] = risposte[2];
            risposte[2] = n3;
            n3 = risposte[3];
            risposte[3] = risposte[4];
            risposte[4] = n3;
        }
        public override string ToString()
        {
            return $"Numero partite vinte: {this.partite_vinte}\nNumero partite pareggiate: {this.partite_pareggiate}\nNumero partite perse: {this.partite_perse}\nNumero totale gol fatti: {this.totale_gol_fatti}\nNumero totale gol subiti: {this.totale_gol_subiti}";
        }
        static void Main(string[] args)
        {
            Squadra Juventus = new Squadra();//crea l'oggetto Juventus della classe Squadra
            Squadra Milan = new Squadra();//crea l'oggetto Milan della classe Squadra
            int[] risposte = new int[7];//array di interi per immagazzinare le risposte dell'utente che verranno usate per assegnare le variabili 
            do
            {
                Console.WriteLine("Inserisci le partite vinte della Juventus");
                risposte[0] = Juventus.ControlloQuantità();
            } while (risposte[0] < 0);
            do
            {
                Console.WriteLine("Inserisci le partite pareggiate della Juventus");
                risposte[1] = Juventus.ControlloQuantità();
            } while (risposte[1] < 0);
            do
            {
                Console.WriteLine("Inserisci le partite perse della Juventus");
                risposte[2] = Juventus.ControlloQuantità();
            } while (risposte[2] < 0);
            do
            {
                Console.WriteLine("Inserisci il totale dei gol fatti della Juventus");
                risposte[3] = Juventus.ControlloQuantità();
            } while (risposte[3] < 0);
            do
            {
                Console.WriteLine("Inserisci le totale dei gol subiti della Juventus");
                risposte[4] = Juventus.ControlloQuantità();
            } while (risposte[4] < 0);
            Juventus.AssegnazioneValori(risposte);
            Console.WriteLine(Juventus.ToString());
            Console.WriteLine("Ora verranno messi anche i dati per la squadra Milan");
            Milan.ScambioValori(ref risposte);
            Milan.AssegnazioneValori(risposte);

            Console.WriteLine(Milan.ToString());
            string answer = "";
            do
            {
                for(int i = 0; i < 365 && answer != "yes"; i++)
                {
                    do
                    {
                        Console.WriteLine("Inserisci il numero di gol fatti dalla squadra Juventus");
                        risposte[5] = Juventus.ControlloQuantità();
                    } while (risposte[5] < 0);
                    do
                    {
                        Console.WriteLine("Inserisci il numero di gol fatti dalla squadra Milan");
                        risposte[6] = Juventus.ControlloQuantità();
                    } while (risposte[6] < 0);
                    Juventus.Gol_Fatti(risposte[5]);
                    Juventus.Gol_Subiti(risposte[6]);
                    Milan.Gol_Fatti(risposte[6]);
                    Milan.Gol_Subiti(risposte[5]);
                    Console.WriteLine("Scrivi yes per terminare l'anno");
                    answer = Console.ReadLine();
                }
                Console.WriteLine($"La squadra Juventus ha totalizzato{Juventus.Punti()} punti");//invoca la funzione Punti della classe Squadra e mostra i punti che Juventus ha totalizzato
                Console.WriteLine($"La squadra Milan ha totalizzato{Milan.Punti()} punti");//invoca la funzione Punti della classe Squadra e mostra i punti che Juventus ha totalizzato
                if (Juventus.Punti() < Milan.Punti())////invoca la funzione Punti della classe Squadra sia per l'oggetto Juventus che per Milan e se il valore dei punti della squadra Juventus è minore de
                {
                    Console.WriteLine("Ha vinto Milan");
                }
                else if(Juventus.Punti() == Milan.Punti())
                {
                    Console.WriteLine("Hanno pareggiato");
                }
                else
                {
                    Console.WriteLine("Ha vinto la Juventus");
                }
                Juventus.InizioAnno();
                Milan.InizioAnno();
                Console.WriteLine("Scrivi yes o y per terminare il campionato");
                answer = Console.ReadLine();
            } while (answer != "yes" && answer != "y");
            Console.WriteLine("Permi un tasto per chiudere il programma");
        }
    }
}
