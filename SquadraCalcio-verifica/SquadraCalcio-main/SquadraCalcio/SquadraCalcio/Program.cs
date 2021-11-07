using System;
using System.Collections.Generic;

namespace SquadraCalcio
{
    class Squadra
    {
        public string nomesquadra { get; set; }
        int partite_vinte, partite_perse, partite_pareggiate, gol_fatti, gol_subiti, punteggio, punteggio_totale;//attributi della classe Squadra
        public Squadra()//porta a 0 il valore degli attributi
        {
            this.nomesquadra = "";
            this.partite_vinte = 0;//porta a 0 il valore della variabile "partite_vinte" nell'istanza corrente
            this.partite_perse = 0;//porta a 0 il valore della variabile "partite_perse" nell'istanza corrente
            this.partite_pareggiate = 0;//porta a 0 il valore della variabile "partite_pareggiate" nell'istanza corrente
            this.gol_fatti = 0;//porta a 0 il valore della variabile "gol_fatti" nell'istanza corrente
            this.gol_subiti = 0;//porta a 0 il valore della variabile "gol_subiti" nell'istanza corrente
            this.punteggio = 0;//porta a 0 il valore della variabile "punteggio" nell'istanza corrente
            this.punteggio_totale = 0;//porta a 0 il valore della variabile "punteggio_totale" nell'istanza corrente
        }
        public int ControlloQuantità()//controllo che il valore inserito dall'utente sia un numero e che sia maggiore di 0, se non lo è allora ritorna -1
        {
            try//utilizzo "try" per controllare il valore che l'utente inserisce come risposta
               //utilizzo "catch" per gestire gli errori come nel caso in cui l'utente inserisce da tastiera qualcosa che non sia un numero
            {
                int risposta = int.Parse(Console.ReadLine());//legge il valore inserito in input da tastiera, lo converte in intero e lo assegna alla variabile risposta
                if(risposta < 0)//controlla che il valore che l'utente abbia inserito sia minore di 0 e se ciò si verifica allora ritorna -1
                {
                    return -1;
                }
                else//se il valore che l'utente scrive è maggiore od uguale a 0 viene fatto il return della variabile risposta
                {
                    return risposta;//ritorna il valore che l'utente ha inserito da tastiera 
                }       
            }
            catch
            {
                return -1;//
            }
        }
        public bool NomiSoloDiversi(string[] nomi)//controllo che il nome inserito non sia già stato inserito come nome di un'altra squadra
        {
            bool controllo = false;
            for(int i = 0; i < nomi.Length-1 && !controllo; i++)
            {
                if(nomi[nomi.Length-1] == nomi[i])
                {
                    controllo = true;
                }
            }
            return controllo;
        }
        public List<Squadra> CreaSqaudre(string[] nomi)
        {
            List<Squadra> creazione = new List<Squadra>();
            for(int i  = 0; i < nomi.Length; i++)
            {
                creazione.Add(new Squadra());
                creazione[i].nomesquadra = nomi[i];
            }
            return creazione;
        }
        public void AumentoPartite()//in base al valore degli attributi gol_fatti e gol_subiti e aumenta il numero di partite vinte, perse oppure pareggiate dell'istanza corrente 
        {
            if (this.gol_fatti < this.gol_subiti)//controlla se il numero di gol_fatti siano minori dei gol_subiti
                                                 //se si verifica questa condizione allora verrà aumentata la variabile partite
            {
                this.partite_perse++;//aumenta la variabile partite_perse dell'istanza corrente 
            }
            else if (this.gol_fatti == this.gol_subiti)//controlla che il numero di gol fatti siano lo stesso del numero di gol subiti
            {
                this.partite_pareggiate++;//aumenta di 1 il numero delle partite pareggiate dell'istanza corrente 
            }
            else
            {
                this.partite_vinte++;//aumenta di 1 il numero delle partite vinte dell'istanza corrente 
            }       
        }
        public int Punti()//calcola il punteggio della squadra basato sul numero di vittorie ed il numero di pareggi dell'istanza corrente
        {
            this.punteggio = (this.partite_vinte * 3) + (this.partite_pareggiate * 1);//assegna alla variabile punteggio dell'istanza corrente,lo somma tra il numero delle partite vinte dalla squadra corrente moltiplicato per 3 ed il numero delle partite pareggiate della squadra corrente                                                                          //
            return this.punteggio;//ritorna il punteggio della squadra corrente
        }
        public void Gol_Fatti(int gol)//assegna il valore di gol fatti alla variabile gol_fatti e li aggiunge alla variabile totale_gol_fatti dell'istanza corrente
        {
            this.gol_fatti = gol;//assegna il numero di gol che l'utente ha inserito da tastiera alla variabile gol_fatti dell'istanza corrente
        }
        public void Gol_Subiti(int gol)//assegna il valore di gol subiti alla variabile gol_subiti e li aggiunge alla variabile totale_gol_subiti
        {
            this.gol_subiti = gol;//assegna il valore di gol alla variabile gol_subiti dell'istanza corrente
        }
        public void AssegnazioneValori(int[] valori)//assegna i valori specificati dall'utente all'istanza corrente quindi prima alla Juventus e dopo al Milan
        {
            this.partite_vinte = valori[0];//assegna il primo valore che l'utente ha inserito da tastiera alla variabile "partite_vinte" dell'istanza corrente
            this.partite_pareggiate = valori[1];//assegna il secondo valore che l'utente ha inserito da tastiera alla variabile "partite_pareggiate" dell'istanza corrente
            this.partite_perse = valori[2];//assegna il terzo valore che l'utente ha inserito da tastiera alla variabile "partite_perse" dell'istanza corrente
        }
        public void InizioAnno()//riporta i valori a zero degli attributi della squadra corrente
        {
            this.partite_vinte = 0;//porta a 0 il valore della variabile "partite_vinte" nell'istanza corrente
            this.partite_pareggiate = 0;//porta a 0 il valore della variabile "partite_pareggiate" nell'istanza corrente
            this.partite_perse = 0;//porta a 0 il valore della variabile "partite_perse" nell'istanza corrente
            this.gol_fatti = 0;//porta a 0 il valore della variabile "gol_fatti" nell'istanza corrente
            this.gol_subiti = 0;//porta a 0 il valore della variabile "gol_subiti" nell'istanza corrente
        }
        public void ScambioValori(ref int[] risposte)//scambia il valore delle partite vinte con il valore delle partite perse della
                                                     //ed il valore delle partite perse con quelle vinte 
        {
            int n3;//variabile per lo scambio
            n3 = risposte[0];//assegna il valore di risposte[0] alla variabile per lo scambio
            risposte[0] = risposte[2];//assegna il valore di risposte[2] ad risposte[0]
            risposte[2] = n3;//assegna il valore della variabile di scambio, quindi risposte[0], a risposte[2]
        }
        public void IncrementoPunteggio()
        {
            this.punteggio_totale = this.punteggio_totale + this.punteggio;
        }
        public int ReturnPunteggioTotale()
        {
            return this.punteggio_totale;
        }
        public override string ToString()//ritorna una stringa in cui mostra il numero di partite vinte, di partite pareggiate e di partite perse della squadra corrente
        {
            return $"Numero partite vinte: {this.partite_vinte}\nNumero partite pareggiate: {this.partite_pareggiate}\nNumero partite perse: {this.partite_perse}\n";
        }

        static void Main(string[] args)
        {
            List<Squadra> squadre = new List<Squadra>();
            Squadra squadra = new Squadra();
            int risposta;
            string[] nomi;
            do
            {
                Console.WriteLine("Inserisci il numero di squadre");
                risposta = squadra.ControlloQuantità();
            } while (risposta < 0 || risposta % 2 != 0);
            nomi = new string[risposta];
            for(int i = 0; i < risposta; i++)
            {
                Console.WriteLine($"Inserisci il nome della squadra numero {i+1}");
                nomi[i] = Console.ReadLine();
                if(squadra.NomiSoloDiversi(nomi))
                {
                    Console.WriteLine("Questo nome e' gia' stato inserito");
                    i--;
                }
            }
            squadre = squadra.CreaSqaudre(nomi);
            //squadre[risposta].AssegnazioneValori();
            Squadra Juventus = new Squadra();//crea l'oggetto Juventus della classe Squadra
            Squadra Milan = new Squadra();//crea l'oggetto Milan della classe Squadra
            int[] risposte = new int[5];//array di interi per immagazzinare le risposte dell'utente che verranno usate per assegnare le variabili 
            do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
            {
                Console.WriteLine("Inserisci le partite vinte della Juventus");//scrive a schermo "Inserisci le partite vinte della Juventus"
                risposte[0] = Juventus.ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al primo livello dell'array risposte
            } while (risposte[0] < 0);
            do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
            {
                Console.WriteLine("Inserisci le partite pareggiate della Juventus");//scrive a schermo "Inserisci le partite pareggiate della Juventus"
                risposte[1] = Juventus.ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al secondo livello dell'array risposte
            } while (risposte[1] < 0);
            do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
            {
                Console.WriteLine("Inserisci le partite perse della Juventus");//scrive a schermo "Inserisci le partite perse della Juventus"
                risposte[2] = Juventus.ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al terzo livello dell'array risposte
            } while (risposte[2] < 0);

            Juventus.AssegnazioneValori(risposte);//invoca la funzione AssegnazioneValori della classe Squadra per l'oggetto Juventus e come argomento pone l'array contenente le risposte alle domande sopra 

            Console.WriteLine("\nDati Juventus:\n");
            Console.WriteLine(Juventus.ToString());//invoca la funzione ToString() della classe Squadra per l'oggetto Juventus che ritorna una stringa contenente i dati inseriti dall'utente 
            
            //non faccio inserire i dati anche al Milan perchè sono l'opposto di quelli della Juventus dato che sono le uniche due squadre nel campionato e quindi le partite vinte della prima squadra sono quelle perse della seconda squadra 
            Console.WriteLine("\nDati Milan:\n");
            Milan.ScambioValori(ref risposte);//invoca la funzione ScambioValori della classe Squadra per invertire le partite vinte della Juventus con le partite perse della Juventus nell'array risposte
            Milan.AssegnazioneValori(risposte);//invoca la funzione AssegnazioneValori della classe Squadra per l'oggetto Milan e come argomento pone l'array contenente le risposte alle domande sopra 
            Console.WriteLine(Milan.ToString());//invoca la funzione ToString() della classe Squadra per l'oggetto Milan che ritorna una stringa contenente i dati inseriti dall'utente 
            string answer = "";//stringa per terminare l'anno ed il campionato
            do
            {
                answer = "";
                for(int i = 0; i < 365 && answer != "yes"; i++)//continua a far giocare le squadre per un'anno intero oppure termina l'anno appena l'utente scrive yes alla che precede il ripetersi del ciclo
                {
                    Console.WriteLine($"Partita n°{i+1} di 365");
                    do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
                    {
                        Console.WriteLine("Inserisci il numero di gol fatti dalla squadra Juventus");
                        risposte[3] = Juventus.ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al quarto livello dell'array risposte
                    } while (risposte[3] < 0);
                    do//continua a chiedere fino a quando l'utente mette una valore maggiore od uguale a 0
                    {
                        Console.WriteLine("Inserisci il numero di gol fatti dalla squadra Milan");
                        risposte[4] = Juventus.ControlloQuantità();//invoca la funzione ControlloQuantità della classe Squadra e ritorna un valore che viene poi assegnato al quinto livello dell'array risposte
                    } while (risposte[4] < 0);
                    Juventus.Gol_Fatti(risposte[3]);
                    Juventus.Gol_Subiti(risposte[4]);
                    Milan.Gol_Fatti(risposte[4]);
                    Milan.Gol_Subiti(risposte[3]);
                    Milan.AumentoPartite();
                    Juventus.AumentoPartite();
                    Console.WriteLine("Scrivi yes per terminare l'anno");
                    answer = Console.ReadLine();
                }
                Console.WriteLine($"La squadra Juventus ha totalizzato {Juventus.Punti()} punti");//invoca la funzione Punti della classe Squadra e mostra i punti che Juventus ha totalizzato nell'anno
                Console.WriteLine($"La squadra Milan ha totalizzato {Milan.Punti()} punti");//invoca la funzione Punti della classe Squadra e mostra i punti che Juventus ha totalizzato nell'anno
                if (Juventus.Punti() < Milan.Punti())//invoca la funzione Punti della classe Squadra sia per l'oggetto Juventus che per Milan e se il valore dei punti della squadra Juventus è minore de
                {
                    Console.WriteLine("Ha vinto Milan");//scrive a schermo "Ha vino Milan"
                }
                else if(Juventus.Punti() == Milan.Punti())
                {
                    Console.WriteLine("Hanno pareggiato");//scrive a schermo "Ha vino Milan"
                }
                else
                {
                    Console.WriteLine("Ha vinto la Juventus");//scrive a schermo "Ha vino Milan"
                }
                Juventus.IncrementoPunteggio();
                Milan.IncrementoPunteggio();
                Juventus.InizioAnno();
                Milan.InizioAnno();
                answer = "";
                Console.WriteLine("Scrivi yes o y per terminare il campionato");
                answer = Console.ReadLine();
            } while (answer != "yes" && answer != "y");
            if(Juventus.ReturnPunteggioTotale() < Milan.ReturnPunteggioTotale())
            {
                Console.WriteLine($"Il vincitore del campionato e' Milan con {Milan.ReturnPunteggioTotale()} punti");
            }
            else if(Juventus.ReturnPunteggioTotale() == Milan.ReturnPunteggioTotale())
            {
                Console.WriteLine($"Il campionato è terminato in un pareggio");
            }
            else
            {
                Console.WriteLine($"Il vincitore del campionato e' Juventus con {Juventus.ReturnPunteggioTotale()} punti");
            }
        }
    }
}
